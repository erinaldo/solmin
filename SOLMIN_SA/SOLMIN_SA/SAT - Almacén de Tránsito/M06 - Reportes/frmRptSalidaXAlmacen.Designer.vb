<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptSalidaXAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptSalidaXAlmacen))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta1 As RANSA.Controls.UbicacionPlanta.Planta.bePlanta = New RANSA.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania1 As RANSA.Controls.UbicacionPlanta.Compania.beCompania = New RANSA.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.dgSalidaSubItem = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.dgSalidaItem = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.dgSalidaOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsReporte = New System.Windows.Forms.ToolStrip()
        Me.btnGenerarReporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsmModelo01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmModelo02 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmModelo02Chinalco = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEnviarCorreo = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador_003 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente2 = New RANSA.Utilitario.ucCliente_Check()
        Me.txtUbicacionReferencial = New RANSA.Utilitario.ucAyuda()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtSubitem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtOrdenDeCompra = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtItem = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaTipoMovimientoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblTipoMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUbicacionReferencial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcDivision_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ALMACEN1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FSLDAL2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCCM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABDES2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLACP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDEACP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNMBCH2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QAROCP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCITPR_SUB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCITCL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDITES1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QCNRCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FSLDAL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLOSA_GR_ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRT1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCCM1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABDES1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLACP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDEACP1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNMBCH1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROSEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCITPR_ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPEPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNDCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUBRFR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FSLDAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLOSA_GR_OC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABDES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDEACP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNMBCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QVLBTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QAROCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TTINTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNMMDT_ENVIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCTCST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCTCSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCTCSF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.dgSalidaSubItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSalidaItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSalidaOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1525, 783)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 163)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dgSalidaSubItem)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dgSalidaItem)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dgSalidaOC)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tsReporte)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1525, 620)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "...Reporte..."
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'dgSalidaSubItem
        '
        Me.dgSalidaSubItem.AllowUserToAddRows = False
        Me.dgSalidaSubItem.AllowUserToDeleteRows = False
        Me.dgSalidaSubItem.AllowUserToResizeColumns = False
        Me.dgSalidaSubItem.AllowUserToResizeRows = False
        Me.dgSalidaSubItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSalidaSubItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn30, Me.TIPO_ALMACEN1, Me.ALMACEN1, Me.ZONA1, Me.FSLDAL2, Me.DataGridViewTextBoxColumn53, Me.TCMTRT2, Me.NPLCCM2, Me.TABDES2, Me.NPLACP2, Me.TDEACP2, Me.TNMBCH2, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.QAROCP2, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.TCITPR_SUB, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn55, Me.SBITOC, Me.TCITCL1, Me.TDITES1, Me.QCNRCP})
        Me.dgSalidaSubItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSalidaSubItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgSalidaSubItem.Location = New System.Drawing.Point(0, 27)
        Me.dgSalidaSubItem.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSalidaSubItem.MultiSelect = False
        Me.dgSalidaSubItem.Name = "dgSalidaSubItem"
        Me.dgSalidaSubItem.ReadOnly = True
        Me.dgSalidaSubItem.RowHeadersWidth = 20
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSalidaSubItem.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgSalidaSubItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSalidaSubItem.Size = New System.Drawing.Size(1523, 566)
        Me.dgSalidaSubItem.StandardTab = True
        Me.dgSalidaSubItem.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgSalidaSubItem.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSalidaSubItem.TabIndex = 71
        Me.dgSalidaSubItem.Visible = False
        '
        'dgSalidaItem
        '
        Me.dgSalidaItem.AllowUserToAddRows = False
        Me.dgSalidaItem.AllowUserToDeleteRows = False
        Me.dgSalidaItem.AllowUserToResizeColumns = False
        Me.dgSalidaItem.AllowUserToResizeRows = False
        Me.dgSalidaItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSalidaItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.FSLDAL1, Me.DataGridViewTextBoxColumn22, Me.GLOSA_GR_ITEM, Me.TCMTRT1, Me.NPLCCM1, Me.TABDES1, Me.NPLACP1, Me.TDEACP1, Me.TNMBCH1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn, Me.NROSEC, Me.DataGridViewTextBoxColumn18, Me.NRITOC, Me.TCITCL, Me.TCITPR_ITEM, Me.TDITES, Me.QBLTSR, Me.QPEPQT, Me.TUNDCN, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57})
        Me.dgSalidaItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSalidaItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgSalidaItem.Location = New System.Drawing.Point(0, 27)
        Me.dgSalidaItem.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSalidaItem.MultiSelect = False
        Me.dgSalidaItem.Name = "dgSalidaItem"
        Me.dgSalidaItem.ReadOnly = True
        Me.dgSalidaItem.RowHeadersWidth = 20
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSalidaItem.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgSalidaItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSalidaItem.Size = New System.Drawing.Size(1523, 566)
        Me.dgSalidaItem.StandardTab = True
        Me.dgSalidaItem.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgSalidaItem.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSalidaItem.TabIndex = 70
        '
        'dgSalidaOC
        '
        Me.dgSalidaOC.AllowUserToAddRows = False
        Me.dgSalidaOC.AllowUserToDeleteRows = False
        Me.dgSalidaOC.AllowUserToResizeColumns = False
        Me.dgSalidaOC.AllowUserToResizeRows = False
        Me.dgSalidaOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgSalidaOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCLNT, Me.TCMPCL, Me.TUBRFR, Me.TIPO_ALMACEN, Me.ALMACEN, Me.ZONA, Me.FSLDAL, Me.NGUIRM, Me.GLOSA_GR_OC, Me.TCMTRT, Me.NPLCCM, Me.TABDES, Me.NPLACP, Me.TDEACP, Me.TNMBCH, Me.CREFFW, Me.QREFFW, Me.TIPBTO, Me.QPSOBL, Me.TUNPSO, Me.QVLBTO, Me.TUNVOL, Me.QAROCP, Me.TPRVCL, Me.NGRPRV, Me.NORCML, Me.TTINTC, Me.TLUGEN, Me.TNMMDT_ENVIO, Me.TCTCST, Me.TCTCSA, Me.TCTCSF})
        Me.dgSalidaOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSalidaOC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgSalidaOC.Location = New System.Drawing.Point(0, 27)
        Me.dgSalidaOC.Margin = New System.Windows.Forms.Padding(4)
        Me.dgSalidaOC.MultiSelect = False
        Me.dgSalidaOC.Name = "dgSalidaOC"
        Me.dgSalidaOC.ReadOnly = True
        Me.dgSalidaOC.RowHeadersWidth = 20
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSalidaOC.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgSalidaOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSalidaOC.Size = New System.Drawing.Size(1523, 566)
        Me.dgSalidaOC.StandardTab = True
        Me.dgSalidaOC.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgSalidaOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgSalidaOC.TabIndex = 69
        Me.dgSalidaOC.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGenerarReporte, Me.ToolStripSeparator1, Me.btnExportarExcel, Me.tssSeparador_002, Me.tsbEnviarCorreo, Me.tssSeparador_003, Me.tsbImprimir})
        Me.tsReporte.Location = New System.Drawing.Point(0, 0)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1523, 27)
        Me.tsReporte.TabIndex = 60
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenerarReporte.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(76, 24)
        Me.btnGenerarReporte.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmModelo01, Me.tsmModelo02, Me.tsmModelo02Chinalco})
        Me.btnExportarExcel.Enabled = False
        Me.btnExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(104, 24)
        Me.btnExportarExcel.Text = "Exportar"
        '
        'tsmModelo01
        '
        Me.tsmModelo01.Name = "tsmModelo01"
        Me.tsmModelo01.Size = New System.Drawing.Size(241, 26)
        Me.tsmModelo01.Text = "Modelo 01"
        '
        'tsmModelo02
        '
        Me.tsmModelo02.Name = "tsmModelo02"
        Me.tsmModelo02.Size = New System.Drawing.Size(241, 26)
        Me.tsmModelo02.Text = "Modelo 02 (PERENCO)"
        '
        'tsmModelo02Chinalco
        '
        Me.tsmModelo02Chinalco.Name = "tsmModelo02Chinalco"
        Me.tsmModelo02Chinalco.Size = New System.Drawing.Size(241, 26)
        Me.tsmModelo02Chinalco.Text = "Modelo 02 (CHINALCO)"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 27)
        Me.tssSeparador_002.Visible = False
        '
        'tsbEnviarCorreo
        '
        Me.tsbEnviarCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarCorreo.Enabled = False
        Me.tsbEnviarCorreo.Image = Global.SOLMIN_SA.My.Resources.Resources.tsbEnviarCorreo_Image
        Me.tsbEnviarCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEnviarCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarCorreo.Name = "tsbEnviarCorreo"
        Me.tsbEnviarCorreo.Size = New System.Drawing.Size(145, 24)
        Me.tsbEnviarCorreo.Text = "Enviar por Correo"
        Me.tsbEnviarCorreo.Visible = False
        '
        'tssSeparador_003
        '
        Me.tssSeparador_003.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_003.Name = "tssSeparador_003"
        Me.tssSeparador_003.Size = New System.Drawing.Size(6, 27)
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbImprimir.Enabled = False
        Me.tsbImprimir.Image = Global.SOLMIN_SA.My.Resources.Resources.printer2
        Me.tsbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(86, 24)
        Me.tsbImprimir.Text = "Imprimir"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtUbicacionReferencial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigoRecepcion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblBulto)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTipoMovimiento)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblTipoMovimiento)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblUbicacionReferencial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1525, 163)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 1
        Me.KryptonHeaderGroup1.Text = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "A9D88B3492AC491DA9D88B3492AC491D"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(585, 48)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(86, 24)
        Me.KryptonLabel1.TabIndex = 10
        Me.KryptonLabel1.Text = "Ubicación : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Ubicación : "
        '
        'txtCliente2
        '
        Me.txtCliente2.DataSource = Nothing
        Me.txtCliente2.DispleyMember = ""
        Me.txtCliente2.ListColumnas = Nothing
        Me.txtCliente2.Location = New System.Drawing.Point(107, 47)
        Me.txtCliente2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente2.Name = "txtCliente2"
        Me.txtCliente2.Obligatorio = True
        Me.txtCliente2.Size = New System.Drawing.Size(432, 30)
        Me.txtCliente2.TabIndex = 8
        Me.txtCliente2.ValueMember = ""
        '
        'txtUbicacionReferencial
        '
        Me.txtUbicacionReferencial.BackColor = System.Drawing.Color.White
        Me.txtUbicacionReferencial.DataSource = Nothing
        Me.txtUbicacionReferencial.DispleyMember = ""
        Me.txtUbicacionReferencial.Etiquetas_Form = Nothing
        Me.txtUbicacionReferencial.ListColumnas = Nothing
        Me.txtUbicacionReferencial.Location = New System.Drawing.Point(688, 49)
        Me.txtUbicacionReferencial.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUbicacionReferencial.Name = "txtUbicacionReferencial"
        Me.txtUbicacionReferencial.Obligatorio = False
        Me.txtUbicacionReferencial.PopupHeight = 0
        Me.txtUbicacionReferencial.PopupWidth = 0
        Me.txtUbicacionReferencial.Size = New System.Drawing.Size(377, 28)
        Me.txtUbicacionReferencial.SizeFont = 0
        Me.txtUbicacionReferencial.TabIndex = 12
        Me.txtUbicacionReferencial.ValueMember = ""
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(15, 107)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(80, 24)
        Me.lblFechaInicial.TabIndex = 17
        Me.lblFechaInicial.Text = "Fecha de :"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha de :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtSubitem)
        Me.GroupBox1.Controls.Add(Me.rbtOrdenDeCompra)
        Me.GroupBox1.Controls.Add(Me.rbtItem)
        Me.GroupBox1.Location = New System.Drawing.Point(688, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(377, 50)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista de reporte"
        '
        'rbtSubitem
        '
        Me.rbtSubitem.Location = New System.Drawing.Point(275, 18)
        Me.rbtSubitem.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtSubitem.Name = "rbtSubitem"
        Me.rbtSubitem.Size = New System.Drawing.Size(87, 24)
        Me.rbtSubitem.TabIndex = 2
        Me.rbtSubitem.Text = "SubItems"
        Me.rbtSubitem.Values.ExtraText = ""
        Me.rbtSubitem.Values.Image = Nothing
        Me.rbtSubitem.Values.Text = "SubItems"
        '
        'rbtOrdenDeCompra
        '
        Me.rbtOrdenDeCompra.Location = New System.Drawing.Point(28, 20)
        Me.rbtOrdenDeCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtOrdenDeCompra.Name = "rbtOrdenDeCompra"
        Me.rbtOrdenDeCompra.Size = New System.Drawing.Size(144, 24)
        Me.rbtOrdenDeCompra.TabIndex = 0
        Me.rbtOrdenDeCompra.Text = "Orden de compra"
        Me.rbtOrdenDeCompra.Values.ExtraText = ""
        Me.rbtOrdenDeCompra.Values.Image = Nothing
        Me.rbtOrdenDeCompra.Values.Text = "Orden de compra"
        '
        'rbtItem
        '
        Me.rbtItem.Checked = True
        Me.rbtItem.Location = New System.Drawing.Point(199, 20)
        Me.rbtItem.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtItem.Name = "rbtItem"
        Me.rbtItem.Size = New System.Drawing.Size(54, 24)
        Me.rbtItem.TabIndex = 1
        Me.rbtItem.Text = "Item"
        Me.rbtItem.Values.ExtraText = ""
        Me.rbtItem.Values.Image = Nothing
        Me.rbtItem.Values.Text = "Item"
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Checked = False
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(107, 113)
        Me.dteFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(135, 22)
        Me.dteFechaInicial.TabIndex = 18
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(344, 113)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(48, 24)
        Me.lblFechaFinal.TabIndex = 19
        Me.lblFechaFinal.Text = "hasta"
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "hasta"
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Checked = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(401, 113)
        Me.dteFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(135, 22)
        Me.dteFechaFinal.TabIndex = 0
        '
        'txtCodigoRecepcion
        '
        Me.txtCodigoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoRecepcion.Location = New System.Drawing.Point(107, 79)
        Me.txtCodigoRecepcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoRecepcion.Name = "txtCodigoRecepcion"
        Me.txtCodigoRecepcion.Size = New System.Drawing.Size(432, 26)
        Me.txtCodigoRecepcion.TabIndex = 16
        '
        'lblBulto
        '
        Me.lblBulto.Location = New System.Drawing.Point(39, 84)
        Me.lblBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.lblBulto.Name = "lblBulto"
        Me.lblBulto.Size = New System.Drawing.Size(55, 24)
        Me.lblBulto.TabIndex = 15
        Me.lblBulto.Text = "Bulto : "
        Me.lblBulto.Values.ExtraText = ""
        Me.lblBulto.Values.Image = Nothing
        Me.lblBulto.Values.Text = "Bulto : "
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoMovimientoListar})
        Me.txtTipoMovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(1221, 46)
        Me.txtTipoMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoMovimiento.MaxLength = 50
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(251, 26)
        Me.txtTipoMovimiento.TabIndex = 14
        '
        'bsaTipoMovimientoListar
        '
        Me.bsaTipoMovimientoListar.ExtraText = ""
        Me.bsaTipoMovimientoListar.Image = Nothing
        Me.bsaTipoMovimientoListar.Text = ""
        Me.bsaTipoMovimientoListar.ToolTipImage = Nothing
        Me.bsaTipoMovimientoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoMovimientoListar.UniqueName = "4EECBBFDBA8848AE4EECBBFDBA8848AE"
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(1108, 43)
        Me.lblTipoMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(105, 24)
        Me.lblTipoMovimiento.TabIndex = 13
        Me.lblTipoMovimiento.Text = "Tipo de Mov :"
        Me.lblTipoMovimiento.Values.ExtraText = ""
        Me.lblTipoMovimiento.Values.Image = Nothing
        Me.lblTipoMovimiento.Values.Text = "Tipo de Mov :"
        '
        'lblUbicacionReferencial
        '
        Me.lblUbicacionReferencial.Location = New System.Drawing.Point(436, 52)
        Me.lblUbicacionReferencial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUbicacionReferencial.Name = "lblUbicacionReferencial"
        Me.lblUbicacionReferencial.Size = New System.Drawing.Size(86, 24)
        Me.lblUbicacionReferencial.TabIndex = 9
        Me.lblUbicacionReferencial.Text = "Ubicación : "
        Me.lblUbicacionReferencial.Values.ExtraText = ""
        Me.lblUbicacionReferencial.Values.Image = Nothing
        Me.lblUbicacionReferencial.Values.Text = "Ubicación : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(28, 53)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(1155, 11)
        Me.lblPlanta.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(61, 24)
        Me.lblPlanta.TabIndex = 5
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(1221, 11)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(251, 28)
        Me.UcPLanta_Cmb011.TabIndex = 6
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(600, 11)
        Me.lblDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(73, 24)
        Me.lblDivision.TabIndex = 3
        Me.lblDivision.Text = "Division : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "Division : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(688, 11)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(377, 28)
        Me.UcDivision_Cmb011.TabIndex = 4
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(7, 16)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(88, 24)
        Me.lblCompania.TabIndex = 0
        Me.lblCompania.Text = "Compañia : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(107, 11)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(432, 28)
        Me.UcCompania_Cmb011.TabIndex = 1
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 88
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 127
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "TUBRFR"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 108
        '
        'TIPO_ALMACEN1
        '
        Me.TIPO_ALMACEN1.DataPropertyName = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN1.HeaderText = "Tipo Almacen"
        Me.TIPO_ALMACEN1.Name = "TIPO_ALMACEN1"
        Me.TIPO_ALMACEN1.ReadOnly = True
        Me.TIPO_ALMACEN1.Width = 134
        '
        'ALMACEN1
        '
        Me.ALMACEN1.DataPropertyName = "ALMACEN"
        Me.ALMACEN1.HeaderText = "Almacen"
        Me.ALMACEN1.Name = "ALMACEN1"
        Me.ALMACEN1.ReadOnly = True
        '
        'ZONA1
        '
        Me.ZONA1.DataPropertyName = "ZONA"
        Me.ZONA1.HeaderText = "Zona"
        Me.ZONA1.Name = "ZONA1"
        Me.ZONA1.ReadOnly = True
        Me.ZONA1.Width = 76
        '
        'FSLDAL2
        '
        Me.FSLDAL2.DataPropertyName = "FSLDAL"
        Me.FSLDAL2.HeaderText = "Fecha"
        Me.FSLDAL2.Name = "FSLDAL2"
        Me.FSLDAL2.ReadOnly = True
        Me.FSLDAL2.Width = 80
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Guía Remisión"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 137
        '
        'TCMTRT2
        '
        Me.TCMTRT2.DataPropertyName = "TCMTRT"
        Me.TCMTRT2.HeaderText = "Transportista"
        Me.TCMTRT2.Name = "TCMTRT2"
        Me.TCMTRT2.ReadOnly = True
        Me.TCMTRT2.Width = 127
        '
        'NPLCCM2
        '
        Me.NPLCCM2.DataPropertyName = "NPLCCM"
        Me.NPLCCM2.HeaderText = "Placa"
        Me.NPLCCM2.Name = "NPLCCM2"
        Me.NPLCCM2.ReadOnly = True
        Me.NPLCCM2.Width = 77
        '
        'TABDES2
        '
        Me.TABDES2.DataPropertyName = "TABDES"
        Me.TABDES2.HeaderText = "Tipo Tracto"
        Me.TABDES2.Name = "TABDES2"
        Me.TABDES2.ReadOnly = True
        Me.TABDES2.Width = 117
        '
        'NPLACP2
        '
        Me.NPLACP2.DataPropertyName = "NPLACP"
        Me.NPLACP2.HeaderText = "Acoplado"
        Me.NPLACP2.Name = "NPLACP2"
        Me.NPLACP2.ReadOnly = True
        Me.NPLACP2.Width = 107
        '
        'TDEACP2
        '
        Me.TDEACP2.DataPropertyName = "TDEACP"
        Me.TDEACP2.HeaderText = "Tipo Acoplado"
        Me.TDEACP2.Name = "TDEACP2"
        Me.TDEACP2.ReadOnly = True
        Me.TDEACP2.Width = 141
        '
        'TNMBCH2
        '
        Me.TNMBCH2.DataPropertyName = "TNMBCH"
        Me.TNMBCH2.HeaderText = "Chofer"
        Me.TNMBCH2.Name = "TNMBCH2"
        Me.TNMBCH2.ReadOnly = True
        Me.TNMBCH2.Width = 86
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 77
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "QREFFW"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn33.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn33.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 102
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Tipo de Bulto"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 132
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn35.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn35.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Width = 72
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "TUNPSO"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Unidad Peso"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Width = 124
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn37.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn37.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Unidad Vol."
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Width = 118
        '
        'QAROCP2
        '
        Me.QAROCP2.DataPropertyName = "QAROCP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.QAROCP2.DefaultCellStyle = DataGridViewCellStyle4
        Me.QAROCP2.HeaderText = "Area del Bulto (MT2)"
        Me.QAROCP2.Name = "QAROCP2"
        Me.QAROCP2.ReadOnly = True
        Me.QAROCP2.Width = 180
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "TPRVCL"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Width = 110
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "NGRPRV"
        Me.DataGridViewTextBoxColumn40.HeaderText = "N° Guía Prov."
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Width = 129
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn42.HeaderText = "N° O/C"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Width = 89
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "TTINTC"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Término Internacional Carga"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Width = 229
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Width = 72
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "TCITCL"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Width = 122
        '
        'TCITPR_SUB
        '
        Me.TCITPR_SUB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCITPR_SUB.DataPropertyName = "TCITPR"
        Me.TCITPR_SUB.HeaderText = "Cod. Item Prov"
        Me.TCITPR_SUB.Name = "TCITPR_SUB"
        Me.TCITPR_SUB.ReadOnly = True
        Me.TCITPR_SUB.Width = 139
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Descripción del Item"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Width = 179
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn48.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn48.HeaderText = "Cant. Item"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Width = 109
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn49.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn49.HeaderText = "Peso Item"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Width = 106
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "TUNDCN"
        Me.DataGridViewTextBoxColumn50.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Width = 90
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "TLUGEN"
        Me.DataGridViewTextBoxColumn51.HeaderText = "Lugar Destino"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Width = 134
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "TNMMDT_ENVIO"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Medio de Envío"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Width = 146
        '
        'SBITOC
        '
        Me.SBITOC.DataPropertyName = "SBITOC"
        Me.SBITOC.HeaderText = "Sub Item"
        Me.SBITOC.Name = "SBITOC"
        Me.SBITOC.ReadOnly = True
        Me.SBITOC.Width = 101
        '
        'TCITCL1
        '
        Me.TCITCL1.DataPropertyName = "TCITCL1"
        Me.TCITCL1.HeaderText = "Cod. Sub Item"
        Me.TCITCL1.Name = "TCITCL1"
        Me.TCITCL1.ReadOnly = True
        Me.TCITCL1.Width = 135
        '
        'TDITES1
        '
        Me.TDITES1.DataPropertyName = "TDITES1"
        Me.TDITES1.HeaderText = "Descripción"
        Me.TDITES1.Name = "TDITES1"
        Me.TDITES1.ReadOnly = True
        Me.TDITES1.Width = 120
        '
        'QCNRCP
        '
        Me.QCNRCP.DataPropertyName = "QCNRCP"
        Me.QCNRCP.HeaderText = "Cantidad "
        Me.QCNRCP.Name = "QCNRCP"
        Me.QCNRCP.ReadOnly = True
        Me.QCNRCP.Width = 106
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 88
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 127
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TUBRFR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ubicación"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 108
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TIPO_ALMACEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Almacen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 134
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALMACEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 76
        '
        'FSLDAL1
        '
        Me.FSLDAL1.DataPropertyName = "FSLDAL"
        Me.FSLDAL1.HeaderText = "Fecha"
        Me.FSLDAL1.Name = "FSLDAL1"
        Me.FSLDAL1.ReadOnly = True
        Me.FSLDAL1.Width = 80
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Guía Remisión"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 137
        '
        'GLOSA_GR_ITEM
        '
        Me.GLOSA_GR_ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GLOSA_GR_ITEM.DataPropertyName = "GLOSA_GR"
        Me.GLOSA_GR_ITEM.HeaderText = "Glosa Gr"
        Me.GLOSA_GR_ITEM.Name = "GLOSA_GR_ITEM"
        Me.GLOSA_GR_ITEM.ReadOnly = True
        Me.GLOSA_GR_ITEM.Width = 98
        '
        'TCMTRT1
        '
        Me.TCMTRT1.DataPropertyName = "TCMTRT"
        Me.TCMTRT1.HeaderText = "Transportista"
        Me.TCMTRT1.Name = "TCMTRT1"
        Me.TCMTRT1.ReadOnly = True
        Me.TCMTRT1.Width = 127
        '
        'NPLCCM1
        '
        Me.NPLCCM1.DataPropertyName = "NPLCCM"
        Me.NPLCCM1.HeaderText = "Placa"
        Me.NPLCCM1.Name = "NPLCCM1"
        Me.NPLCCM1.ReadOnly = True
        Me.NPLCCM1.Width = 77
        '
        'TABDES1
        '
        Me.TABDES1.DataPropertyName = "TABDES"
        Me.TABDES1.HeaderText = "Tipo Tracto"
        Me.TABDES1.Name = "TABDES1"
        Me.TABDES1.ReadOnly = True
        Me.TABDES1.Width = 117
        '
        'NPLACP1
        '
        Me.NPLACP1.DataPropertyName = "NPLACP"
        Me.NPLACP1.HeaderText = "Acoplado"
        Me.NPLACP1.Name = "NPLACP1"
        Me.NPLACP1.ReadOnly = True
        Me.NPLACP1.Width = 107
        '
        'TDEACP1
        '
        Me.TDEACP1.DataPropertyName = "TDEACP"
        Me.TDEACP1.HeaderText = "Tipo Acoplado"
        Me.TDEACP1.Name = "TDEACP1"
        Me.TDEACP1.ReadOnly = True
        Me.TDEACP1.Width = 141
        '
        'TNMBCH1
        '
        Me.TNMBCH1.DataPropertyName = "TNMBCH"
        Me.TNMBCH1.HeaderText = "Chofer"
        Me.TNMBCH1.Name = "TNMBCH1"
        Me.TNMBCH1.ReadOnly = True
        Me.TNMBCH1.Width = 86
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 77
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QREFFW"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 102
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo de Bulto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 132
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn11.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 72
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TUNPSO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unidad Peso"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 124
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn13.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Unidad Vol."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 118
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "QAROCP"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Area del Bulto (MT2)"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 180
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TPRVCL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 110
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NGRPRV"
        Me.DataGridViewTextBoxColumn16.HeaderText = "N° Guía Prov."
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 129
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn17.HeaderText = "N° O/C"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 89
        '
        'DataGridViewTextBoxColumn
        '
        Me.DataGridViewTextBoxColumn.DataPropertyName = "NRPDTS"
        Me.DataGridViewTextBoxColumn.HeaderText = "Pedido de Traslado"
        Me.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn"
        Me.DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataGridViewTextBoxColumn.Width = 169
        '
        'NROSEC
        '
        Me.NROSEC.DataPropertyName = "NROSEC"
        Me.NROSEC.HeaderText = "Item Ped. Traslado"
        Me.NROSEC.Name = "NROSEC"
        Me.NROSEC.ReadOnly = True
        Me.NROSEC.Width = 163
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TTINTC"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Término Internacional Carga"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 229
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "NRITOC"
        Me.NRITOC.HeaderText = "Item"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.ReadOnly = True
        Me.NRITOC.Width = 72
        '
        'TCITCL
        '
        Me.TCITCL.DataPropertyName = "TCITCL"
        Me.TCITCL.HeaderText = "Cod. Cliente"
        Me.TCITCL.Name = "TCITCL"
        Me.TCITCL.ReadOnly = True
        Me.TCITCL.Width = 122
        '
        'TCITPR_ITEM
        '
        Me.TCITPR_ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCITPR_ITEM.DataPropertyName = "TCITPR"
        Me.TCITPR_ITEM.HeaderText = "Cod. Item Prov"
        Me.TCITPR_ITEM.Name = "TCITPR_ITEM"
        Me.TCITPR_ITEM.ReadOnly = True
        Me.TCITPR_ITEM.Width = 139
        '
        'TDITES
        '
        Me.TDITES.DataPropertyName = "TDITES"
        Me.TDITES.HeaderText = "Descripción del Item"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        Me.TDITES.Width = 179
        '
        'QBLTSR
        '
        Me.QBLTSR.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.QBLTSR.DefaultCellStyle = DataGridViewCellStyle11
        Me.QBLTSR.HeaderText = "Cant. Item"
        Me.QBLTSR.Name = "QBLTSR"
        Me.QBLTSR.ReadOnly = True
        Me.QBLTSR.Width = 109
        '
        'QPEPQT
        '
        Me.QPEPQT.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.QPEPQT.DefaultCellStyle = DataGridViewCellStyle12
        Me.QPEPQT.HeaderText = "Peso Item"
        Me.QPEPQT.Name = "QPEPQT"
        Me.QPEPQT.ReadOnly = True
        Me.QPEPQT.Width = 106
        '
        'TUNDCN
        '
        Me.TUNDCN.DataPropertyName = "TUNDCN"
        Me.TUNDCN.HeaderText = "Unidad"
        Me.TUNDCN.Name = "TUNDCN"
        Me.TUNDCN.ReadOnly = True
        Me.TUNDCN.Width = 90
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TLUGEN"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Lugar Destino"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 134
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "TNMMDT_ENVIO"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Medio de Envío"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 146
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TCTCST"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Cuenta Imputación Terrestre"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 228
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "TCTCSA"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Cuenta Imputación Aéreo"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Width = 211
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "TCTCSF"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Cuenta Imputación Fluvial"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Width = 213
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Width = 88
        '
        'TCMPCL
        '
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Razón Social"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        Me.TCMPCL.Width = 127
        '
        'TUBRFR
        '
        Me.TUBRFR.DataPropertyName = "TUBRFR"
        Me.TUBRFR.HeaderText = "Ubicación"
        Me.TUBRFR.Name = "TUBRFR"
        Me.TUBRFR.ReadOnly = True
        Me.TUBRFR.Width = 108
        '
        'TIPO_ALMACEN
        '
        Me.TIPO_ALMACEN.DataPropertyName = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN.HeaderText = "Tipo Almacen"
        Me.TIPO_ALMACEN.Name = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN.ReadOnly = True
        Me.TIPO_ALMACEN.Width = 134
        '
        'ALMACEN
        '
        Me.ALMACEN.DataPropertyName = "ALMACEN"
        Me.ALMACEN.HeaderText = "Almacen"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.ReadOnly = True
        '
        'ZONA
        '
        Me.ZONA.DataPropertyName = "ZONA"
        Me.ZONA.HeaderText = "Zona"
        Me.ZONA.Name = "ZONA"
        Me.ZONA.ReadOnly = True
        Me.ZONA.Width = 76
        '
        'FSLDAL
        '
        Me.FSLDAL.DataPropertyName = "FSLDAL"
        Me.FSLDAL.HeaderText = "Fecha"
        Me.FSLDAL.Name = "FSLDAL"
        Me.FSLDAL.ReadOnly = True
        Me.FSLDAL.Width = 80
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        Me.NGUIRM.HeaderText = "Guía Remisión"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Width = 137
        '
        'GLOSA_GR_OC
        '
        Me.GLOSA_GR_OC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GLOSA_GR_OC.DataPropertyName = "GLOSA_GR"
        Me.GLOSA_GR_OC.HeaderText = "Glosa Gr"
        Me.GLOSA_GR_OC.Name = "GLOSA_GR_OC"
        Me.GLOSA_GR_OC.ReadOnly = True
        Me.GLOSA_GR_OC.Width = 98
        '
        'TCMTRT
        '
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 127
        '
        'NPLCCM
        '
        Me.NPLCCM.DataPropertyName = "NPLCCM"
        Me.NPLCCM.HeaderText = "Placa"
        Me.NPLCCM.Name = "NPLCCM"
        Me.NPLCCM.ReadOnly = True
        Me.NPLCCM.Width = 77
        '
        'TABDES
        '
        Me.TABDES.DataPropertyName = "TABDES"
        Me.TABDES.HeaderText = "Tipo Tracto"
        Me.TABDES.Name = "TABDES"
        Me.TABDES.ReadOnly = True
        Me.TABDES.Width = 117
        '
        'NPLACP
        '
        Me.NPLACP.DataPropertyName = "NPLACP"
        Me.NPLACP.HeaderText = "Acoplado"
        Me.NPLACP.Name = "NPLACP"
        Me.NPLACP.ReadOnly = True
        Me.NPLACP.Width = 107
        '
        'TDEACP
        '
        Me.TDEACP.DataPropertyName = "TDEACP"
        Me.TDEACP.HeaderText = "Tipo Acoplado"
        Me.TDEACP.Name = "TDEACP"
        Me.TDEACP.ReadOnly = True
        Me.TDEACP.Width = 141
        '
        'TNMBCH
        '
        Me.TNMBCH.DataPropertyName = "TNMBCH"
        Me.TNMBCH.HeaderText = "Chofer"
        Me.TNMBCH.Name = "TNMBCH"
        Me.TNMBCH.ReadOnly = True
        Me.TNMBCH.Width = 86
        '
        'CREFFW
        '
        Me.CREFFW.DataPropertyName = "CREFFW"
        Me.CREFFW.HeaderText = "Bulto"
        Me.CREFFW.Name = "CREFFW"
        Me.CREFFW.ReadOnly = True
        Me.CREFFW.Width = 77
        '
        'QREFFW
        '
        Me.QREFFW.DataPropertyName = "QREFFW"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.QREFFW.DefaultCellStyle = DataGridViewCellStyle14
        Me.QREFFW.HeaderText = "Cantidad"
        Me.QREFFW.Name = "QREFFW"
        Me.QREFFW.ReadOnly = True
        Me.QREFFW.Width = 102
        '
        'TIPBTO
        '
        Me.TIPBTO.DataPropertyName = "TIPBTO"
        Me.TIPBTO.HeaderText = "Tipo de Bulto"
        Me.TIPBTO.Name = "TIPBTO"
        Me.TIPBTO.ReadOnly = True
        Me.TIPBTO.Width = 132
        '
        'QPSOBL
        '
        Me.QPSOBL.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.QPSOBL.DefaultCellStyle = DataGridViewCellStyle15
        Me.QPSOBL.HeaderText = "Peso"
        Me.QPSOBL.Name = "QPSOBL"
        Me.QPSOBL.ReadOnly = True
        Me.QPSOBL.Width = 72
        '
        'TUNPSO
        '
        Me.TUNPSO.DataPropertyName = "TUNPSO"
        Me.TUNPSO.HeaderText = "Unidad Peso"
        Me.TUNPSO.Name = "TUNPSO"
        Me.TUNPSO.ReadOnly = True
        Me.TUNPSO.Width = 124
        '
        'QVLBTO
        '
        Me.QVLBTO.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.QVLBTO.DefaultCellStyle = DataGridViewCellStyle16
        Me.QVLBTO.HeaderText = "Volumen"
        Me.QVLBTO.Name = "QVLBTO"
        Me.QVLBTO.ReadOnly = True
        '
        'TUNVOL
        '
        Me.TUNVOL.DataPropertyName = "TUNVOL"
        Me.TUNVOL.HeaderText = "Unidad Vol."
        Me.TUNVOL.Name = "TUNVOL"
        Me.TUNVOL.ReadOnly = True
        Me.TUNVOL.Width = 118
        '
        'QAROCP
        '
        Me.QAROCP.DataPropertyName = "QAROCP"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.QAROCP.DefaultCellStyle = DataGridViewCellStyle17
        Me.QAROCP.HeaderText = "Area del Bulto (MT2)"
        Me.QAROCP.Name = "QAROCP"
        Me.QAROCP.ReadOnly = True
        Me.QAROCP.Width = 180
        '
        'TPRVCL
        '
        Me.TPRVCL.DataPropertyName = "TPRVCL"
        Me.TPRVCL.HeaderText = "Proveedor"
        Me.TPRVCL.Name = "TPRVCL"
        Me.TPRVCL.ReadOnly = True
        Me.TPRVCL.Width = 110
        '
        'NGRPRV
        '
        Me.NGRPRV.DataPropertyName = "NGRPRV"
        Me.NGRPRV.HeaderText = "N° Guía Prov."
        Me.NGRPRV.Name = "NGRPRV"
        Me.NGRPRV.ReadOnly = True
        Me.NGRPRV.Width = 129
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "NORCML"
        Me.NORCML.HeaderText = "N° O/C"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        Me.NORCML.Width = 89
        '
        'TTINTC
        '
        Me.TTINTC.DataPropertyName = "TTINTC"
        Me.TTINTC.HeaderText = "Término Internacional Carga"
        Me.TTINTC.Name = "TTINTC"
        Me.TTINTC.ReadOnly = True
        Me.TTINTC.Width = 229
        '
        'TLUGEN
        '
        Me.TLUGEN.DataPropertyName = "TLUGEN"
        Me.TLUGEN.HeaderText = "Lugar Destino"
        Me.TLUGEN.Name = "TLUGEN"
        Me.TLUGEN.ReadOnly = True
        Me.TLUGEN.Width = 134
        '
        'TNMMDT_ENVIO
        '
        Me.TNMMDT_ENVIO.DataPropertyName = "TNMMDT_ENVIO"
        Me.TNMMDT_ENVIO.HeaderText = "Medio de Envío"
        Me.TNMMDT_ENVIO.Name = "TNMMDT_ENVIO"
        Me.TNMMDT_ENVIO.ReadOnly = True
        Me.TNMMDT_ENVIO.Width = 146
        '
        'TCTCST
        '
        Me.TCTCST.DataPropertyName = "TCTCST"
        Me.TCTCST.HeaderText = "Cuenta Imputación Terrestre"
        Me.TCTCST.Name = "TCTCST"
        Me.TCTCST.ReadOnly = True
        Me.TCTCST.Width = 228
        '
        'TCTCSA
        '
        Me.TCTCSA.DataPropertyName = "TCTCSA"
        Me.TCTCSA.HeaderText = "Cuenta Imputación Aéreo"
        Me.TCTCSA.Name = "TCTCSA"
        Me.TCTCSA.ReadOnly = True
        Me.TCTCSA.Width = 211
        '
        'TCTCSF
        '
        Me.TCTCSF.DataPropertyName = "TCTCSF"
        Me.TCTCSF.HeaderText = "Cuenta Imputación Fluvial"
        Me.TCTCSF.Name = "TCTCSF"
        Me.TCTCSF.ReadOnly = True
        Me.TCTCSF.Width = 213
        '
        'frmRptSalidaXAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1525, 783)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRptSalidaXAlmacen"
        Me.Text = "Salida por Almacen"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.dgSalidaSubItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSalidaItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSalidaOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents lblUbicacionReferencial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoMovimiento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoMovimientoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTipoMovimiento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtOrdenDeCompra As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtItem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents rbtSubitem As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtUbicacionReferencial As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtCliente2 As RANSA.Utilitario.ucCliente_Check
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsmModelo01 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmModelo02 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEnviarCorreo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_003 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgSalidaOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgSalidaItem As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgSalidaSubItem As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsmModelo02Chinalco As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ALMACEN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLDAL2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCM2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABDES2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLACP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDEACP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCH2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAROCP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITPR_SUB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITCL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLDAL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLOSA_GR_ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCM1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABDES1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLACP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDEACP1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCH1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROSEC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITPR_ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPEPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUBRFR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLDAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLOSA_GR_OC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDEACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QVLBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAROCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGRPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTINTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMMDT_ENVIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCSF As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
