<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaBulto
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBulto))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dgBultos = New Ransa.Controls.WayBill.ucWaybill_DgF01()
        Me.cmsBultoCabecera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiEliminarBultoPaleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tapagItemRelacionados = New System.Windows.Forms.TabPage()
        Me.dgBultosDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.D_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QPEPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_QVOPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X_MARRET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBITEM = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NRSITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tsMenuItemBulto = New System.Windows.Forms.ToolStrip()
        Me.tsbEliminarItemBulto = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregarItemBulto = New System.Windows.Forms.ToolStripButton()
        Me.hgDetalleItem = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtInformacionItemBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TabPagPaquetes = New System.Windows.Forms.TabPage()
        Me.dtgPaquetesDeBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.PNQCTPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTLRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTANC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTALT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQVOLMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQPSOMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtUbicacionReferencial = New Ransa.Utilitario.ucAyuda()
        Me.txtSentidoCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaSentidoCargaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtOc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtGuiaProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroPaletizado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblEstadoTransito = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbEstadoTransito = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cmbEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.lblEstado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.txtClient = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.txtCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblNroPaletizado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUbicacionReferencial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        Me.cmsBultoCabecera.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tapagItemRelacionados.SuspendLayout()
        CType(Me.dgBultosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuItemBulto.SuspendLayout()
        CType(Me.hgDetalleItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalleItem.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgDetalleItem.Panel.SuspendLayout()
        Me.hgDetalleItem.SuspendLayout()
        Me.TabPagPaquetes.SuspendLayout()
        CType(Me.dtgPaquetesDeBulto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Size = New System.Drawing.Size(1082, 585)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 172)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgBultos)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1082, 413)
        Me.KryptonSplitContainer1.SplitterDistance = 228
        Me.KryptonSplitContainer1.TabIndex = 2
        '
        'dgBultos
        '
        Me.dgBultos.BackColor = System.Drawing.Color.Transparent
        Me.dgBultos.ContextMenuStrip = Me.cmsBultoCabecera
        Me.dgBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBultos.Location = New System.Drawing.Point(0, 0)
        Me.dgBultos.Name = "dgBultos"
        Me.dgBultos.NroRegPorPagina = 20
        Me.dgBultos.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgBultos.pMostrarInfCliente = True
        Me.dgBultos.pShowBtnAdjuntarDoc = True
        Me.dgBultos.pShowBtnAgregar = False
        Me.dgBultos.pShowBtnConfirmarLlegada = True
        Me.dgBultos.pShowBtnEditar = True
        Me.dgBultos.pShowBtnEliminar = False
        Me.dgBultos.pShowBtnEtiqueta = True
        Me.dgBultos.pShowBtnExportar = False
        Me.dgBultos.pShowBtnExportarExcel = True
        Me.dgBultos.pShowBtnExportarInventarioExcel = False
        Me.dgBultos.pShowBtnImprimir = False
        Me.dgBultos.pShowBtnInterfase = False
        Me.dgBultos.pShowBtnPaletizar = False
        Me.dgBultos.pShowBtnPreDespacho = False
        Me.dgBultos.pShowBtnRePacking = False
        Me.dgBultos.pShowBtnTraslado = True
        Me.dgBultos.pShowColCheck = True
        Me.dgBultos.pShowColStatusTransf = False
        Me.dgBultos.pVerInfDespacho = True
        Me.dgBultos.Size = New System.Drawing.Size(1082, 228)
        Me.dgBultos.TabIndex = 0
        '
        'cmsBultoCabecera
        '
        Me.cmsBultoCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmsBultoCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEliminarBultoPaleta})
        Me.cmsBultoCabecera.Name = "cmsRecepcion"
        Me.cmsBultoCabecera.Size = New System.Drawing.Size(197, 26)
        '
        'tsmiEliminarBultoPaleta
        '
        Me.tsmiEliminarBultoPaleta.Name = "tsmiEliminarBultoPaleta"
        Me.tsmiEliminarBultoPaleta.Size = New System.Drawing.Size(196, 22)
        Me.tsmiEliminarBultoPaleta.Text = "Eliminar Bulto de la Paleta"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tapagItemRelacionados)
        Me.TabControl1.Controls.Add(Me.TabPagPaquetes)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1082, 180)
        Me.TabControl1.TabIndex = 22
        '
        'tapagItemRelacionados
        '
        Me.tapagItemRelacionados.Controls.Add(Me.dgBultosDetalle)
        Me.tapagItemRelacionados.Controls.Add(Me.tsMenuItemBulto)
        Me.tapagItemRelacionados.Controls.Add(Me.hgDetalleItem)
        Me.tapagItemRelacionados.Location = New System.Drawing.Point(4, 22)
        Me.tapagItemRelacionados.Name = "tapagItemRelacionados"
        Me.tapagItemRelacionados.Padding = New System.Windows.Forms.Padding(3)
        Me.tapagItemRelacionados.Size = New System.Drawing.Size(1074, 154)
        Me.tapagItemRelacionados.TabIndex = 0
        Me.tapagItemRelacionados.Text = "Relación de Items"
        Me.tapagItemRelacionados.UseVisualStyleBackColor = True
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
        Me.dgBultosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgBultosDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_CREFFW, Me.D_NORCML, Me.D_NRITOC, Me.D_CIDPAQ, Me.D_TDITES, Me.D_QBLTSR, Me.D_QPEPQT, Me.D_TUNPSO, Me.D_QVOPQT, Me.D_TUNVOL, Me.D_TLUGEN, Me.D_NGRPRV, Me.X_MARRET, Me.SUBITEM, Me.NRSITEM, Me.Obs})
        Me.dgBultosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBultosDetalle.Location = New System.Drawing.Point(3, 28)
        Me.dgBultosDetalle.MultiSelect = False
        Me.dgBultosDetalle.Name = "dgBultosDetalle"
        Me.dgBultosDetalle.ReadOnly = True
        Me.dgBultosDetalle.RowHeadersWidth = 20
        Me.dgBultosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgBultosDetalle.Size = New System.Drawing.Size(1047, 123)
        Me.dgBultosDetalle.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgBultosDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgBultosDetalle.TabIndex = 1
        '
        'D_CREFFW
        '
        Me.D_CREFFW.DataPropertyName = "PSCREFFW"
        Me.D_CREFFW.HeaderText = "Bulto"
        Me.D_CREFFW.Name = "D_CREFFW"
        Me.D_CREFFW.ReadOnly = True
        Me.D_CREFFW.Visible = False
        Me.D_CREFFW.Width = 64
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
        Me.D_NRITOC.HeaderText = "Nro. Item O/C"
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
        Me.D_CIDPAQ.Width = 107
        '
        'D_TDITES
        '
        Me.D_TDITES.DataPropertyName = "PSTDITES"
        Me.D_TDITES.HeaderText = "Descripción"
        Me.D_TDITES.Name = "D_TDITES"
        Me.D_TDITES.ReadOnly = True
        Me.D_TDITES.Width = 98
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
        Me.D_QBLTSR.Width = 84
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
        Me.D_QPEPQT.Width = 61
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
        Me.D_QVOPQT.Width = 83
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
        Me.D_TLUGEN.DataPropertyName = "PSTLUGEN"
        Me.D_TLUGEN.HeaderText = "Lugar Entrega"
        Me.D_TLUGEN.Name = "D_TLUGEN"
        Me.D_TLUGEN.ReadOnly = True
        Me.D_TLUGEN.Width = 109
        '
        'D_NGRPRV
        '
        Me.D_NGRPRV.DataPropertyName = "PNNGRPRV"
        Me.D_NGRPRV.HeaderText = "Guia Proveedor"
        Me.D_NGRPRV.Name = "D_NGRPRV"
        Me.D_NGRPRV.ReadOnly = True
        Me.D_NGRPRV.Visible = False
        Me.D_NGRPRV.Width = 117
        '
        'X_MARRET
        '
        Me.X_MARRET.DataPropertyName = "PSMARRET"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.X_MARRET.DefaultCellStyle = DataGridViewCellStyle5
        Me.X_MARRET.HeaderText = "Custodia Retención"
        Me.X_MARRET.Name = "X_MARRET"
        Me.X_MARRET.ReadOnly = True
        Me.X_MARRET.Width = 139
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
        'Obs
        '
        Me.Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Obs.HeaderText = "Observación"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Obs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Obs.Width = 75
        '
        'tsMenuItemBulto
        '
        Me.tsMenuItemBulto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuItemBulto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuItemBulto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbEliminarItemBulto, Me.tsbAgregarItemBulto})
        Me.tsMenuItemBulto.Location = New System.Drawing.Point(3, 3)
        Me.tsMenuItemBulto.Name = "tsMenuItemBulto"
        Me.tsMenuItemBulto.Size = New System.Drawing.Size(1047, 25)
        Me.tsMenuItemBulto.TabIndex = 21
        '
        'tsbEliminarItemBulto
        '
        Me.tsbEliminarItemBulto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminarItemBulto.Image = CType(resources.GetObject("tsbEliminarItemBulto.Image"), System.Drawing.Image)
        Me.tsbEliminarItemBulto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarItemBulto.Name = "tsbEliminarItemBulto"
        Me.tsbEliminarItemBulto.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminarItemBulto.Text = "&Eliminar"
        '
        'tsbAgregarItemBulto
        '
        Me.tsbAgregarItemBulto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregarItemBulto.Image = CType(resources.GetObject("tsbAgregarItemBulto.Image"), System.Drawing.Image)
        Me.tsbAgregarItemBulto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarItemBulto.Name = "tsbAgregarItemBulto"
        Me.tsbAgregarItemBulto.Size = New System.Drawing.Size(69, 22)
        Me.tsbAgregarItemBulto.Text = "&Agregar"
        '
        'hgDetalleItem
        '
        Me.hgDetalleItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.hgDetalleItem.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left
        Me.hgDetalleItem.HeaderVisibleSecondary = False
        Me.hgDetalleItem.Location = New System.Drawing.Point(1050, 3)
        Me.hgDetalleItem.Name = "hgDetalleItem"
        '
        'hgDetalleItem.Panel
        '
        Me.hgDetalleItem.Panel.Controls.Add(Me.txtInformacionItemBulto)
        Me.hgDetalleItem.Size = New System.Drawing.Size(21, 148)
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
        Me.txtInformacionItemBulto.Size = New System.Drawing.Size(0, 146)
        Me.txtInformacionItemBulto.StateCommon.Content.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacionItemBulto.TabIndex = 24
        Me.txtInformacionItemBulto.TabStop = False
        '
        'TabPagPaquetes
        '
        Me.TabPagPaquetes.Controls.Add(Me.dtgPaquetesDeBulto)
        Me.TabPagPaquetes.Location = New System.Drawing.Point(4, 22)
        Me.TabPagPaquetes.Name = "TabPagPaquetes"
        Me.TabPagPaquetes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagPaquetes.Size = New System.Drawing.Size(1074, 154)
        Me.TabPagPaquetes.TabIndex = 1
        Me.TabPagPaquetes.Text = "Paquetes del bulto"
        Me.TabPagPaquetes.UseVisualStyleBackColor = True
        '
        'dtgPaquetesDeBulto
        '
        Me.dtgPaquetesDeBulto.AllowUserToAddRows = False
        Me.dtgPaquetesDeBulto.AllowUserToDeleteRows = False
        Me.dtgPaquetesDeBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPaquetesDeBulto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgPaquetesDeBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPaquetesDeBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNQCTPQT, Me.PNQMTLRG, Me.PNQMTANC, Me.PNQMTALT, Me.PNQVOLMR, Me.PNQPSOMR, Me.Column1})
        Me.dtgPaquetesDeBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPaquetesDeBulto.Location = New System.Drawing.Point(3, 3)
        Me.dtgPaquetesDeBulto.MultiSelect = False
        Me.dtgPaquetesDeBulto.Name = "dtgPaquetesDeBulto"
        Me.dtgPaquetesDeBulto.ReadOnly = True
        Me.dtgPaquetesDeBulto.RowHeadersWidth = 20
        Me.dtgPaquetesDeBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPaquetesDeBulto.Size = New System.Drawing.Size(1068, 148)
        Me.dtgPaquetesDeBulto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgPaquetesDeBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPaquetesDeBulto.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dtgPaquetesDeBulto.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPaquetesDeBulto.StateCommon.HeaderRow.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dtgPaquetesDeBulto.TabIndex = 2
        '
        'PNQCTPQT
        '
        Me.PNQCTPQT.DataPropertyName = "PNQCTPQT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PNQCTPQT.DefaultCellStyle = DataGridViewCellStyle6
        Me.PNQCTPQT.HeaderText = "Cantidad Paquete"
        Me.PNQCTPQT.Name = "PNQCTPQT"
        Me.PNQCTPQT.ReadOnly = True
        Me.PNQCTPQT.Width = 108
        '
        'PNQMTLRG
        '
        Me.PNQMTLRG.DataPropertyName = "PNQMTLRG"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PNQMTLRG.DefaultCellStyle = DataGridViewCellStyle7
        Me.PNQMTLRG.HeaderText = "Largo (mts)"
        Me.PNQMTLRG.Name = "PNQMTLRG"
        Me.PNQMTLRG.ReadOnly = True
        Me.PNQMTLRG.Width = 86
        '
        'PNQMTANC
        '
        Me.PNQMTANC.DataPropertyName = "PNQMTANC"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PNQMTANC.DefaultCellStyle = DataGridViewCellStyle8
        Me.PNQMTANC.HeaderText = "Ancho (mts)"
        Me.PNQMTANC.Name = "PNQMTANC"
        Me.PNQMTANC.ReadOnly = True
        Me.PNQMTANC.Width = 88
        '
        'PNQMTALT
        '
        Me.PNQMTALT.DataPropertyName = "PNQMTALT"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PNQMTALT.DefaultCellStyle = DataGridViewCellStyle9
        Me.PNQMTALT.HeaderText = "Alto (mts)"
        Me.PNQMTALT.Name = "PNQMTALT"
        Me.PNQMTALT.ReadOnly = True
        Me.PNQMTALT.Width = 78
        '
        'PNQVOLMR
        '
        Me.PNQVOLMR.DataPropertyName = "VOLUMENPAQUETE"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N3"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PNQVOLMR.DefaultCellStyle = DataGridViewCellStyle10
        Me.PNQVOLMR.HeaderText = "Volumen Paquete"
        Me.PNQVOLMR.Name = "PNQVOLMR"
        Me.PNQVOLMR.ReadOnly = True
        Me.PNQVOLMR.Width = 108
        '
        'PNQPSOMR
        '
        Me.PNQPSOMR.DataPropertyName = "PNQPSOMR"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N3"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.PNQPSOMR.DefaultCellStyle = DataGridViewCellStyle11
        Me.PNQPSOMR.HeaderText = "Peso Paquete"
        Me.PNQPSOMR.Name = "PNQPSOMR"
        Me.PNQPSOMR.ReadOnly = True
        Me.PNQPSOMR.Width = 91
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.txtUbicacionReferencial)
        Me.khgFiltros.Panel.Controls.Add(Me.txtSentidoCarga)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodigoRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.txtOc)
        Me.khgFiltros.Panel.Controls.Add(Me.txtGuiaProveedor)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroPaletizado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblEstadoTransito)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbEstadoTransito)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbEstado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblEstado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblPlanta)
        Me.khgFiltros.Panel.Controls.Add(Me.lblDivision)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.txtClient)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCriterioLote)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCriterioLote)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroPaletizado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblUbicacionReferencial)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCodigoRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(1082, 172)
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
        'txtUbicacionReferencial
        '
        Me.txtUbicacionReferencial.BackColor = System.Drawing.Color.White
        Me.txtUbicacionReferencial.DataSource = Nothing
        Me.txtUbicacionReferencial.DispleyMember = ""
        Me.txtUbicacionReferencial.Etiquetas_Form = Nothing
        Me.txtUbicacionReferencial.ListColumnas = Nothing
        Me.txtUbicacionReferencial.Location = New System.Drawing.Point(483, 37)
        Me.txtUbicacionReferencial.Name = "txtUbicacionReferencial"
        Me.txtUbicacionReferencial.Obligatorio = False
        Me.txtUbicacionReferencial.PopupHeight = 0
        Me.txtUbicacionReferencial.PopupWidth = 0
        Me.txtUbicacionReferencial.Size = New System.Drawing.Size(213, 23)
        Me.txtUbicacionReferencial.SizeFont = 0
        Me.txtUbicacionReferencial.TabIndex = 4
        Me.txtUbicacionReferencial.ValueMember = ""
        '
        'txtSentidoCarga
        '
        Me.txtSentidoCarga.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaSentidoCargaListar})
        Me.txtSentidoCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtSentidoCarga, True)
        Me.txtSentidoCarga.Location = New System.Drawing.Point(813, 90)
        Me.txtSentidoCarga.MaxLength = 17
        Me.txtSentidoCarga.Name = "txtSentidoCarga"
        Me.txtSentidoCarga.Size = New System.Drawing.Size(150, 22)
        Me.txtSentidoCarga.TabIndex = 17
        '
        'bsaSentidoCargaListar
        '
        Me.bsaSentidoCargaListar.ExtraText = ""
        Me.bsaSentidoCargaListar.Image = Nothing
        Me.bsaSentidoCargaListar.Text = ""
        Me.bsaSentidoCargaListar.ToolTipImage = Nothing
        Me.bsaSentidoCargaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaSentidoCargaListar.UniqueName = "0F1FEA32575749D90F1FEA32575749D9"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(708, 87)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(111, 20)
        Me.KryptonLabel4.TabIndex = 60
        Me.KryptonLabel4.Text = "Sentido de Carga : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Sentido de Carga : "
        '
        'txtCodigoRecepcion
        '
        Me.txtCodigoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoRecepcion, True)
        Me.txtCodigoRecepcion.Location = New System.Drawing.Point(104, 64)
        Me.txtCodigoRecepcion.MaxLength = 100
        Me.txtCodigoRecepcion.Name = "txtCodigoRecepcion"
        Me.txtCodigoRecepcion.Size = New System.Drawing.Size(248, 22)
        Me.txtCodigoRecepcion.TabIndex = 12
        '
        'txtOc
        '
        Me.txtOc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtOc, True)
        Me.txtOc.Location = New System.Drawing.Point(104, 89)
        Me.txtOc.MaxLength = 100
        Me.txtOc.Name = "txtOc"
        Me.txtOc.Size = New System.Drawing.Size(249, 22)
        Me.txtOc.TabIndex = 15
        '
        'txtGuiaProveedor
        '
        Me.txtGuiaProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtGuiaProveedor, True)
        Me.txtGuiaProveedor.Location = New System.Drawing.Point(483, 87)
        Me.txtGuiaProveedor.MaxLength = 100
        Me.txtGuiaProveedor.Name = "txtGuiaProveedor"
        Me.txtGuiaProveedor.Size = New System.Drawing.Size(213, 22)
        Me.txtGuiaProveedor.TabIndex = 16
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(361, 87)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(101, 20)
        Me.KryptonLabel2.TabIndex = 58
        Me.KryptonLabel2.Text = "Guía Proveedor :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Guía Proveedor :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 87)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(104, 20)
        Me.KryptonLabel1.TabIndex = 56
        Me.KryptonLabel1.Text = "Orde de Compra: "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Orde de Compra: "
        '
        'txtNroPaletizado
        '
        Me.txtNroPaletizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtNroPaletizado, True)
        Me.txtNroPaletizado.Location = New System.Drawing.Point(483, 62)
        Me.txtNroPaletizado.MaxLength = 100
        Me.txtNroPaletizado.Name = "txtNroPaletizado"
        Me.txtNroPaletizado.Size = New System.Drawing.Size(213, 22)
        Me.txtNroPaletizado.TabIndex = 13
        '
        'lblEstadoTransito
        '
        Me.lblEstadoTransito.Location = New System.Drawing.Point(708, 62)
        Me.lblEstadoTransito.Name = "lblEstadoTransito"
        Me.lblEstadoTransito.Size = New System.Drawing.Size(97, 20)
        Me.lblEstadoTransito.TabIndex = 54
        Me.lblEstadoTransito.Text = "Est. de Entrega : "
        Me.lblEstadoTransito.Values.ExtraText = ""
        Me.lblEstadoTransito.Values.Image = Nothing
        Me.lblEstadoTransito.Values.Text = "Est. de Entrega : "
        Me.lblEstadoTransito.Visible = False
        '
        'cmbEstadoTransito
        '
        Me.cmbEstadoTransito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoTransito.DropDownWidth = 150
        Me.cmbEstadoTransito.FormattingEnabled = False
        Me.cmbEstadoTransito.ItemHeight = 15
        Me.cmbEstadoTransito.Location = New System.Drawing.Point(813, 64)
        Me.cmbEstadoTransito.Name = "cmbEstadoTransito"
        Me.cmbEstadoTransito.Size = New System.Drawing.Size(150, 23)
        Me.cmbEstadoTransito.TabIndex = 14
        Me.cmbEstadoTransito.Visible = False
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.DropDownWidth = 150
        Me.cmbEstado.FormattingEnabled = False
        Me.cmbEstado.ItemHeight = 15
        Me.cmbEstado.Location = New System.Drawing.Point(813, 38)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(150, 23)
        Me.cmbEstado.TabIndex = 10
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(708, 39)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(53, 20)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.Text = "Estado : "
        Me.lblEstado.Values.ExtraText = ""
        Me.lblEstado.Values.Image = Nothing
        Me.lblEstado.Values.Text = "Estado : "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(708, 14)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(50, 20)
        Me.lblPlanta.TabIndex = 51
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(361, 13)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(60, 20)
        Me.lblDivision.TabIndex = 50
        Me.lblDivision.Text = "Division : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "Division : "
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(5, 16)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(72, 20)
        Me.lblCompania.TabIndex = 49
        Me.lblCompania.Text = "Compañia : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(813, 9)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(150, 23)
        Me.UcPLanta_Cmb011.TabIndex = 2
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(483, 11)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(213, 23)
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
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(104, 13)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(248, 23)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.CCMPN = "EZ"
        Me.txtClient.Location = New System.Drawing.Point(104, 39)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pCDDRSP_CodClienteSAP = ""
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.pVisualizaNegocio = False
        Me.txtClient.Size = New System.Drawing.Size(248, 22)
        Me.txtClient.TabIndex = 3
        '
        'txtCriterioLote
        '
        Me.txtCriterioLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCriterioLote, True)
        Me.txtCriterioLote.Location = New System.Drawing.Point(104, 114)
        Me.txtCriterioLote.MaxLength = 100
        Me.txtCriterioLote.Name = "txtCriterioLote"
        Me.txtCriterioLote.Size = New System.Drawing.Size(248, 22)
        Me.txtCriterioLote.TabIndex = 18
        '
        'lblCriterioLote
        '
        Me.lblCriterioLote.Location = New System.Drawing.Point(5, 117)
        Me.lblCriterioLote.Name = "lblCriterioLote"
        Me.lblCriterioLote.Size = New System.Drawing.Size(84, 20)
        Me.lblCriterioLote.TabIndex = 13
        Me.lblCriterioLote.Text = "Criterio Lote : "
        Me.lblCriterioLote.Values.ExtraText = ""
        Me.lblCriterioLote.Values.Image = Nothing
        Me.lblCriterioLote.Values.Text = "Criterio Lote : "
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(615, 115)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(81, 20)
        Me.dteFechaFinal.TabIndex = 22
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(482, 115)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(86, 20)
        Me.dteFechaInicial.TabIndex = 20
        '
        'lblNroPaletizado
        '
        Me.lblNroPaletizado.Location = New System.Drawing.Point(359, 64)
        Me.lblNroPaletizado.Name = "lblNroPaletizado"
        Me.lblNroPaletizado.Size = New System.Drawing.Size(73, 20)
        Me.lblNroPaletizado.TabIndex = 11
        Me.lblNroPaletizado.Text = "Paletizado : "
        Me.lblNroPaletizado.Values.ExtraText = ""
        Me.lblNroPaletizado.Values.Image = Nothing
        Me.lblNroPaletizado.Values.Text = "Paletizado : "
        '
        'lblUbicacionReferencial
        '
        Me.lblUbicacionReferencial.Location = New System.Drawing.Point(359, 39)
        Me.lblUbicacionReferencial.Name = "lblUbicacionReferencial"
        Me.lblUbicacionReferencial.Size = New System.Drawing.Size(70, 20)
        Me.lblUbicacionReferencial.TabIndex = 9
        Me.lblUbicacionReferencial.Text = "Ubicación : "
        Me.lblUbicacionReferencial.Values.ExtraText = ""
        Me.lblUbicacionReferencial.Values.Image = Nothing
        Me.lblUbicacionReferencial.Values.Text = "Ubicación : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(1009, 11)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 23
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(566, 119)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(47, 20)
        Me.lblFechaFinal.TabIndex = 21
        Me.lblFechaFinal.Text = "Hasta : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Hasta : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(361, 117)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(116, 20)
        Me.lblFechaInicial.TabIndex = 19
        Me.lblFechaInicial.Text = "Fch. Recepción De : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fch. Recepción De : "
        '
        'lblCodigoRecepcion
        '
        Me.lblCodigoRecepcion.Location = New System.Drawing.Point(5, 68)
        Me.lblCodigoRecepcion.Name = "lblCodigoRecepcion"
        Me.lblCodigoRecepcion.Size = New System.Drawing.Size(45, 20)
        Me.lblCodigoRecepcion.TabIndex = 3
        Me.lblCodigoRecepcion.Text = "Bulto : "
        Me.lblCodigoRecepcion.Values.ExtraText = ""
        Me.lblCodigoRecepcion.Values.Image = Nothing
        Me.lblCodigoRecepcion.Values.Text = "Bulto : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 43)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(850, 43)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 78)
        Me.KryptonLabel5.TabIndex = 11
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
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
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CREFFW"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bulto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nro. O/C"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 79
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nro. Item O/C"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CIDPAQ"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cód. Paquete"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 92
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn7.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TUNPSO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "QVOPQT"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn9.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 77
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TUNVOL"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TLUGEN"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Lugar Entrega"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 103
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NGRPRV"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Guia Proveedor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 110
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "MARRET"
        Me.DataGridViewTextBoxColumn13.HeaderText = "D_MARRET"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 96
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "X_MARRET"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn14.HeaderText = "Custodia Retención"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 129
        '
        'frmConsultaBulto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 585)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmConsultaBulto"
        Me.Text = "Almacén de Bultos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.cmsBultoCabecera.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tapagItemRelacionados.ResumeLayout(False)
        Me.tapagItemRelacionados.PerformLayout()
        CType(Me.dgBultosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuItemBulto.ResumeLayout(False)
        Me.tsMenuItemBulto.PerformLayout()
        CType(Me.hgDetalleItem.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleItem.Panel.ResumeLayout(False)
        Me.hgDetalleItem.Panel.PerformLayout()
        CType(Me.hgDetalleItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalleItem.ResumeLayout(False)
        Me.TabPagPaquetes.ResumeLayout(False)
        CType(Me.dtgPaquetesDeBulto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents txtCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmsBultoCabecera As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents lblUbicacionReferencial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroPaletizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroPaletizado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup


    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsmiEliminarBultoPaleta As System.Windows.Forms.ToolStripMenuItem


    Friend WithEvents dgBultos As Ransa.Controls.WayBill.ucWaybill_DgF01
    Friend WithEvents txtClient As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
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
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Private WithEvents lblEstado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents lblEstadoTransito As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbEstadoTransito As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtOc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGuiaProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSentidoCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaSentidoCargaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUbicacionReferencial As Ransa.Utilitario.ucAyuda
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tapagItemRelacionados As System.Windows.Forms.TabPage
    Friend WithEvents dgBultosDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents Obs As System.Windows.Forms.DataGridViewImageColumn
    Private WithEvents tsMenuItemBulto As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbEliminarItemBulto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregarItemBulto As System.Windows.Forms.ToolStripButton
    Friend WithEvents hgDetalleItem As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtInformacionItemBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TabPagPaquetes As System.Windows.Forms.TabPage
    Friend WithEvents dtgPaquetesDeBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNQCTPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTLRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTANC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTALT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQVOLMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPSOMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
