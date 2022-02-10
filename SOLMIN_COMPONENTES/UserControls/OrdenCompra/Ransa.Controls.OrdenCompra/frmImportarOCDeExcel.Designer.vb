<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarOCDeExcel
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FROCMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REFDO1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTDSCML_Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNMONOC_MonedaDeOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PCPRPCL_CodigoClienteProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTNOMCOM_NombreComprador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTTINTC_TerminoIntern = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNREFCL_ReferenciaCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTPAGME_TerminoPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pNTPDES_Prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pCMNDA1_Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTEMPFAC_EmpresaFacturar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pTCTCST_CentroCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pCMEDTR_MedioTransporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMAEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgExcelDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.CmbXlsHoja1 = New System.Windows.Forms.ComboBox
        Me.brnAbrirDetalle = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAbrirCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.NmCount1 = New System.Windows.Forms.NumericUpDown
        Me.btnExcelDetalle = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.CmbXlsHoja = New System.Windows.Forms.ComboBox
        Me.NmCount = New System.Windows.Forms.NumericUpDown
        Me.TxtRutaXlsDetalle = New System.Windows.Forms.TextBox
        Me.TxtRutaXlsCabecera = New System.Windows.Forms.TextBox
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgExcelCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgExcelDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        CType(Me.NmCount1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(792, 596)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 171)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgExcelCabecera)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgExcelDetalle)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(792, 425)
        Me.KryptonSplitContainer1.SplitterDistance = 182
        Me.KryptonSplitContainer1.TabIndex = 34
        '
        'dgExcelCabecera
        '
        Me.dgExcelCabecera.AllowUserToAddRows = False
        Me.dgExcelCabecera.AllowUserToDeleteRows = False
        Me.dgExcelCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExcelCabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCCLNT, Me.PSNORCML, Me.PNCPRVCL, Me.FORCML, Me.FROCMP, Me.REFDO1, Me.pTDSCML_Descripcion, Me.pNMONOC_MonedaDeOC, Me.PCPRPCL_CodigoClienteProveedor, Me.pTNOMCOM_NombreComprador, Me.pTTINTC_TerminoIntern, Me.pNREFCL_ReferenciaCliente, Me.pTPAGME_TerminoPago, Me.pNTPDES_Prioridad, Me.pCMNDA1_Moneda, Me.pTEMPFAC_EmpresaFacturar, Me.pTCTCST_CentroCosto, Me.pCMEDTR_MedioTransporte, Me.TCMAEM})
        Me.dgExcelCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgExcelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.dgExcelCabecera.Name = "dgExcelCabecera"
        Me.dgExcelCabecera.ReadOnly = True
        Me.dgExcelCabecera.Size = New System.Drawing.Size(792, 182)
        Me.dgExcelCabecera.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelCabecera.TabIndex = 31
        '
        'PNCCLNT
        '
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "CodigoCliente"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        '
        'PSNORCML
        '
        Me.PSNORCML.DataPropertyName = "PSNORCML"
        Me.PSNORCML.HeaderText = "NroOrden Compra"
        Me.PSNORCML.Name = "PSNORCML"
        Me.PSNORCML.ReadOnly = True
        '
        'PNCPRVCL
        '
        Me.PNCPRVCL.DataPropertyName = "PNCPRVCL"
        Me.PNCPRVCL.HeaderText = "CodigoClienteTercero"
        Me.PNCPRVCL.Name = "PNCPRVCL"
        Me.PNCPRVCL.ReadOnly = True
        Me.PNCPRVCL.Visible = False
        '
        'FORCML
        '
        Me.FORCML.DataPropertyName = "PNFORCML"
        Me.FORCML.HeaderText = "Fecha OC"
        Me.FORCML.Name = "FORCML"
        Me.FORCML.ReadOnly = True
        '
        'FROCMP
        '
        Me.FROCMP.DataPropertyName = "PNFROCMP"
        Me.FROCMP.HeaderText = "Fecha De Recepción"
        Me.FROCMP.Name = "FROCMP"
        Me.FROCMP.ReadOnly = True
        '
        'REFDO1
        '
        Me.REFDO1.DataPropertyName = "PSREFDO1"
        Me.REFDO1.HeaderText = "ReferenciaDocumento"
        Me.REFDO1.Name = "REFDO1"
        Me.REFDO1.ReadOnly = True
        '
        'pTDSCML_Descripcion
        '
        Me.pTDSCML_Descripcion.DataPropertyName = "PSTDSCML"
        Me.pTDSCML_Descripcion.HeaderText = "Descripcion "
        Me.pTDSCML_Descripcion.Name = "pTDSCML_Descripcion"
        Me.pTDSCML_Descripcion.ReadOnly = True
        '
        'pNMONOC_MonedaDeOC
        '
        Me.pNMONOC_MonedaDeOC.DataPropertyName = "PSNMONOC"
        Me.pNMONOC_MonedaDeOC.HeaderText = "MonedaDeOC"
        Me.pNMONOC_MonedaDeOC.Name = "pNMONOC_MonedaDeOC"
        Me.pNMONOC_MonedaDeOC.ReadOnly = True
        '
        'PCPRPCL_CodigoClienteProveedor
        '
        Me.PCPRPCL_CodigoClienteProveedor.DataPropertyName = "PSCPRPCL"
        Me.PCPRPCL_CodigoClienteProveedor.HeaderText = "Codigo Cliente Proveedor"
        Me.PCPRPCL_CodigoClienteProveedor.Name = "PCPRPCL_CodigoClienteProveedor"
        Me.PCPRPCL_CodigoClienteProveedor.ReadOnly = True
        Me.PCPRPCL_CodigoClienteProveedor.Visible = False
        '
        'pTNOMCOM_NombreComprador
        '
        Me.pTNOMCOM_NombreComprador.DataPropertyName = "PSTNOMCOM"
        Me.pTNOMCOM_NombreComprador.HeaderText = "NombreComprador"
        Me.pTNOMCOM_NombreComprador.Name = "pTNOMCOM_NombreComprador"
        Me.pTNOMCOM_NombreComprador.ReadOnly = True
        Me.pTNOMCOM_NombreComprador.Visible = False
        '
        'pTTINTC_TerminoIntern
        '
        Me.pTTINTC_TerminoIntern.DataPropertyName = "PSTTINTC"
        Me.pTTINTC_TerminoIntern.HeaderText = "Termino Interno"
        Me.pTTINTC_TerminoIntern.Name = "pTTINTC_TerminoIntern"
        Me.pTTINTC_TerminoIntern.ReadOnly = True
        '
        'pNREFCL_ReferenciaCliente
        '
        Me.pNREFCL_ReferenciaCliente.DataPropertyName = "PSNREFCL"
        Me.pNREFCL_ReferenciaCliente.HeaderText = "ReferenciaCliente"
        Me.pNREFCL_ReferenciaCliente.Name = "pNREFCL_ReferenciaCliente"
        Me.pNREFCL_ReferenciaCliente.ReadOnly = True
        Me.pNREFCL_ReferenciaCliente.Visible = False
        '
        'pTPAGME_TerminoPago
        '
        Me.pTPAGME_TerminoPago.DataPropertyName = "PSTPAGME"
        Me.pTPAGME_TerminoPago.HeaderText = "TerminoPago"
        Me.pTPAGME_TerminoPago.Name = "pTPAGME_TerminoPago"
        Me.pTPAGME_TerminoPago.ReadOnly = True
        Me.pTPAGME_TerminoPago.Visible = False
        '
        'pNTPDES_Prioridad
        '
        Me.pNTPDES_Prioridad.DataPropertyName = "PNNTPDES"
        Me.pNTPDES_Prioridad.HeaderText = "Prioridad"
        Me.pNTPDES_Prioridad.Name = "pNTPDES_Prioridad"
        Me.pNTPDES_Prioridad.ReadOnly = True
        Me.pNTPDES_Prioridad.Visible = False
        '
        'pCMNDA1_Moneda
        '
        Me.pCMNDA1_Moneda.DataPropertyName = "PNCMNDA1"
        Me.pCMNDA1_Moneda.HeaderText = "Moneda"
        Me.pCMNDA1_Moneda.Name = "pCMNDA1_Moneda"
        Me.pCMNDA1_Moneda.ReadOnly = True
        Me.pCMNDA1_Moneda.Visible = False
        '
        'pTEMPFAC_EmpresaFacturar
        '
        Me.pTEMPFAC_EmpresaFacturar.DataPropertyName = "PSTEMPFAC"
        Me.pTEMPFAC_EmpresaFacturar.HeaderText = "EmpresaFacturar"
        Me.pTEMPFAC_EmpresaFacturar.Name = "pTEMPFAC_EmpresaFacturar"
        Me.pTEMPFAC_EmpresaFacturar.ReadOnly = True
        Me.pTEMPFAC_EmpresaFacturar.Visible = False
        '
        'pTCTCST_CentroCosto
        '
        Me.pTCTCST_CentroCosto.DataPropertyName = "PSTCTCST"
        Me.pTCTCST_CentroCosto.HeaderText = "Centro de Costo"
        Me.pTCTCST_CentroCosto.Name = "pTCTCST_CentroCosto"
        Me.pTCTCST_CentroCosto.ReadOnly = True
        '
        'pCMEDTR_MedioTransporte
        '
        Me.pCMEDTR_MedioTransporte.DataPropertyName = "PNCMEDTR"
        Me.pCMEDTR_MedioTransporte.HeaderText = "MedioTransporte"
        Me.pCMEDTR_MedioTransporte.Name = "pCMEDTR_MedioTransporte"
        Me.pCMEDTR_MedioTransporte.ReadOnly = True
        Me.pCMEDTR_MedioTransporte.Visible = False
        '
        'TCMAEM
        '
        Me.TCMAEM.DataPropertyName = "PSTCMAEM"
        Me.TCMAEM.HeaderText = "DescAreaEmpresa"
        Me.TCMAEM.Name = "TCMAEM"
        Me.TCMAEM.ReadOnly = True
        Me.TCMAEM.Visible = False
        '
        'dgExcelDetalle
        '
        Me.dgExcelDetalle.AllowUserToAddRows = False
        Me.dgExcelDetalle.AllowUserToDeleteRows = False
        Me.dgExcelDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExcelDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORCML, Me.NRITOC, Me.TCITCL, Me.QCNTIT, Me.TDITES, Me.TUNDIT})
        Me.dgExcelDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgExcelDetalle.Location = New System.Drawing.Point(0, 25)
        Me.dgExcelDetalle.Name = "dgExcelDetalle"
        Me.dgExcelDetalle.ReadOnly = True
        Me.dgExcelDetalle.Size = New System.Drawing.Size(792, 213)
        Me.dgExcelDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelDetalle.TabIndex = 32
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "PSNORCML"
        Me.NORCML.HeaderText = "N° Orden Compra"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "PNNRITOC"
        Me.NRITOC.HeaderText = "N° Item"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.ReadOnly = True
        '
        'TCITCL
        '
        Me.TCITCL.DataPropertyName = "PSTCITCL"
        Me.TCITCL.HeaderText = "Codigo de Item "
        Me.TCITCL.Name = "TCITCL"
        Me.TCITCL.ReadOnly = True
        Me.TCITCL.Visible = False
        '
        'QCNTIT
        '
        Me.QCNTIT.DataPropertyName = "PNQCNTIT"
        Me.QCNTIT.HeaderText = "Cantidad "
        Me.QCNTIT.Name = "QCNTIT"
        Me.QCNTIT.ReadOnly = True
        '
        'TDITES
        '
        Me.TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDITES.DataPropertyName = "PSTDITES"
        Me.TDITES.HeaderText = "Descripcion"
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        '
        'TUNDIT
        '
        Me.TUNDIT.DataPropertyName = "PSTUNDIT"
        Me.TUNDIT.HeaderText = "Unidad de Medida"
        Me.TUNDIT.Name = "TUNDIT"
        Me.TUNDIT.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 33
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(203, 22)
        Me.ToolStripLabel2.Tag = "DETALLE ORDENES DE COMPRA"
        Me.ToolStripLabel2.Text = "DETALLE ORDENES DE COMPRA"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 146)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(792, 25)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripLabel1.Tag = "ORDENES DE COMPRA"
        Me.ToolStripLabel1.Text = "ORDENES DE COMPRA"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.Image = Global.Ransa.Controls.OrdenCompra.My.Resources.Resources.filesave
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        Me.tsbGuardar.ToolTipText = "Guardar "
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.CmbXlsHoja1)
        Me.hgFiltros.Panel.Controls.Add(Me.brnAbrirDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.btnAbrirCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.NmCount1)
        Me.hgFiltros.Panel.Controls.Add(Me.btnExcelDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.btnExcelCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.CmbXlsHoja)
        Me.hgFiltros.Panel.Controls.Add(Me.NmCount)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaXlsDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaXlsCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(792, 146)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 3
        Me.hgFiltros.Text = "Filtros"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "EC0877FED5AD46CBEC0877FED5AD46CB"
        '
        'CmbXlsHoja1
        '
        Me.CmbXlsHoja1.FormattingEnabled = True
        Me.CmbXlsHoja1.Location = New System.Drawing.Point(874, 61)
        Me.CmbXlsHoja1.Name = "CmbXlsHoja1"
        Me.CmbXlsHoja1.Size = New System.Drawing.Size(104, 21)
        Me.CmbXlsHoja1.TabIndex = 53
        Me.CmbXlsHoja1.Visible = False
        '
        'brnAbrirDetalle
        '
        Me.brnAbrirDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.brnAbrirDetalle.Enabled = False
        Me.brnAbrirDetalle.Location = New System.Drawing.Point(689, 53)
        Me.brnAbrirDetalle.Name = "brnAbrirDetalle"
        Me.brnAbrirDetalle.Size = New System.Drawing.Size(74, 44)
        Me.brnAbrirDetalle.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.brnAbrirDetalle.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.brnAbrirDetalle.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.brnAbrirDetalle.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.brnAbrirDetalle.TabIndex = 49
        Me.brnAbrirDetalle.Text = "&Abrir"
        Me.brnAbrirDetalle.Values.ExtraText = "Consulta"
        Me.brnAbrirDetalle.Values.Image = Nothing
        Me.brnAbrirDetalle.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.brnAbrirDetalle.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.brnAbrirDetalle.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.brnAbrirDetalle.Values.Text = "&Abrir"
        '
        'btnAbrirCabecera
        '
        Me.btnAbrirCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirCabecera.Location = New System.Drawing.Point(689, 3)
        Me.btnAbrirCabecera.Name = "btnAbrirCabecera"
        Me.btnAbrirCabecera.Size = New System.Drawing.Size(74, 44)
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnAbrirCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnAbrirCabecera.TabIndex = 48
        Me.btnAbrirCabecera.Text = "&Abrir"
        Me.btnAbrirCabecera.Values.ExtraText = "Consulta"
        Me.btnAbrirCabecera.Values.Image = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAbrirCabecera.Values.Text = "&Abrir"
        '
        'NmCount1
        '
        Me.NmCount1.BackColor = System.Drawing.SystemColors.Window
        Me.NmCount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NmCount1.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.NmCount1.Location = New System.Drawing.Point(800, 62)
        Me.NmCount1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmCount1.Name = "NmCount1"
        Me.NmCount1.Size = New System.Drawing.Size(68, 20)
        Me.NmCount1.TabIndex = 52
        Me.NmCount1.Visible = False
        '
        'btnExcelDetalle
        '
        Me.btnExcelDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelDetalle.Enabled = False
        Me.btnExcelDetalle.Location = New System.Drawing.Point(587, 53)
        Me.btnExcelDetalle.Name = "btnExcelDetalle"
        Me.btnExcelDetalle.Size = New System.Drawing.Size(81, 44)
        Me.btnExcelDetalle.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelDetalle.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnExcelDetalle.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelDetalle.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnExcelDetalle.TabIndex = 47
        Me.btnExcelDetalle.Text = "&Cargar"
        Me.btnExcelDetalle.Values.ExtraText = "Consulta"
        Me.btnExcelDetalle.Values.Image = Nothing
        Me.btnExcelDetalle.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExcelDetalle.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExcelDetalle.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExcelDetalle.Values.Text = "&Cargar"
        '
        'btnExcelCabecera
        '
        Me.btnExcelCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelCabecera.Location = New System.Drawing.Point(587, 3)
        Me.btnExcelCabecera.Name = "btnExcelCabecera"
        Me.btnExcelCabecera.Size = New System.Drawing.Size(81, 44)
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnExcelCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnExcelCabecera.TabIndex = 46
        Me.btnExcelCabecera.Text = "&Cargar"
        Me.btnExcelCabecera.Values.ExtraText = "Consulta"
        Me.btnExcelCabecera.Values.Image = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExcelCabecera.Values.Text = "&Cargar"
        '
        'CmbXlsHoja
        '
        Me.CmbXlsHoja.FormattingEnabled = True
        Me.CmbXlsHoja.Location = New System.Drawing.Point(874, 26)
        Me.CmbXlsHoja.Name = "CmbXlsHoja"
        Me.CmbXlsHoja.Size = New System.Drawing.Size(104, 21)
        Me.CmbXlsHoja.TabIndex = 51
        Me.CmbXlsHoja.Visible = False
        '
        'NmCount
        '
        Me.NmCount.BackColor = System.Drawing.SystemColors.Window
        Me.NmCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NmCount.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.NmCount.Location = New System.Drawing.Point(800, 27)
        Me.NmCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmCount.Name = "NmCount"
        Me.NmCount.Size = New System.Drawing.Size(68, 20)
        Me.NmCount.TabIndex = 50
        Me.NmCount.Visible = False
        '
        'TxtRutaXlsDetalle
        '
        Me.TxtRutaXlsDetalle.Location = New System.Drawing.Point(97, 71)
        Me.TxtRutaXlsDetalle.Name = "TxtRutaXlsDetalle"
        Me.TxtRutaXlsDetalle.Size = New System.Drawing.Size(457, 20)
        Me.TxtRutaXlsDetalle.TabIndex = 45
        '
        'TxtRutaXlsCabecera
        '
        Me.TxtRutaXlsCabecera.Location = New System.Drawing.Point(97, 12)
        Me.TxtRutaXlsCabecera.Name = "TxtRutaXlsCabecera"
        Me.TxtRutaXlsCabecera.Size = New System.Drawing.Size(457, 20)
        Me.TxtRutaXlsCabecera.TabIndex = 44
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(15, 71)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 19)
        Me.lblAlmacen.TabIndex = 43
        Me.lblAlmacen.Text = "Detalle : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Detalle : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(15, 12)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(62, 19)
        Me.lblTipoAlmacen.TabIndex = 42
        Me.lblTipoAlmacen.Text = "Cabecera : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Cabecera : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(782, -1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 115)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'frmImportarOCDeExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 596)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 630)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 630)
        Me.Name = "frmImportarOCDeExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Ordenes de Compra Excell"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgExcelCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgExcelDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        CType(Me.NmCount1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmCount, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtRutaXlsDetalle As System.Windows.Forms.TextBox
    Friend WithEvents TxtRutaXlsCabecera As System.Windows.Forms.TextBox
    Friend WithEvents btnExcelDetalle As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents brnAbrirDetalle As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAbrirCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents NmCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents CmbXlsHoja As System.Windows.Forms.ComboBox
    Friend WithEvents CmbXlsHoja1 As System.Windows.Forms.ComboBox
    Friend WithEvents NmCount1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgExcelDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FROCMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFDO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTDSCML_Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNMONOC_MonedaDeOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCPRPCL_CodigoClienteProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTNOMCOM_NombreComprador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTTINTC_TerminoIntern As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNREFCL_ReferenciaCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTPAGME_TerminoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pNTPDES_Prioridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCMNDA1_Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTEMPFAC_EmpresaFacturar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pTCTCST_CentroCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pCMEDTR_MedioTransporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMAEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
