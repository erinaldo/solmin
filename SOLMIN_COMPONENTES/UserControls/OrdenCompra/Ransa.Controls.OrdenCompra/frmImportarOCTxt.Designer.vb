<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarOCTxt
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
        Me.dgExcelDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCargarObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtRutaObservaciones = New System.Windows.Forms.TextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCargarDetalle = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnCargarCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.TxtRutaDetalle = New System.Windows.Forms.TextBox
        Me.TxtRutaCabecera = New System.Windows.Forms.TextBox
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
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
        Me.PSNORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNFORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNMONOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNFSOLIC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTTINTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPAGME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPAISEM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTNOMCOM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 214)
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
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(792, 382)
        Me.KryptonSplitContainer1.SplitterDistance = 163
        Me.KryptonSplitContainer1.TabIndex = 34
        '
        'dgExcelCabecera
        '
        Me.dgExcelCabecera.AllowUserToAddRows = False
        Me.dgExcelCabecera.AllowUserToDeleteRows = False
        Me.dgExcelCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExcelCabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSNORCML, Me.PNFORCML, Me.PSNMONOC, Me.PNFSOLIC, Me.PSTTINTC, Me.PSTPAGME, Me.PSTPAISEM, Me.PSTNOMCOM})
        Me.dgExcelCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgExcelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.dgExcelCabecera.Name = "dgExcelCabecera"
        Me.dgExcelCabecera.ReadOnly = True
        Me.dgExcelCabecera.Size = New System.Drawing.Size(792, 163)
        Me.dgExcelCabecera.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelCabecera.TabIndex = 31
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
        Me.dgExcelDetalle.Size = New System.Drawing.Size(792, 189)
        Me.dgExcelDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelDetalle.TabIndex = 32
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
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 189)
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
        Me.hgFiltros.Panel.Controls.Add(Me.btnCargarObservaciones)
        Me.hgFiltros.Panel.Controls.Add(Me.txtRutaObservaciones)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.btnCargarDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.btnCargarCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaDetalle)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(792, 189)
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
        'btnCargarObservaciones
        '
        Me.btnCargarObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargarObservaciones.Enabled = False
        Me.btnCargarObservaciones.Location = New System.Drawing.Point(587, 104)
        Me.btnCargarObservaciones.Name = "btnCargarObservaciones"
        Me.btnCargarObservaciones.Size = New System.Drawing.Size(81, 44)
        Me.btnCargarObservaciones.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCargarObservaciones.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCargarObservaciones.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCargarObservaciones.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCargarObservaciones.TabIndex = 50
        Me.btnCargarObservaciones.Text = "&Cargar"
        Me.btnCargarObservaciones.Values.ExtraText = "Consulta"
        Me.btnCargarObservaciones.Values.Image = Nothing
        Me.btnCargarObservaciones.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCargarObservaciones.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCargarObservaciones.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCargarObservaciones.Values.Text = "&Cargar"
        '
        'txtRutaObservaciones
        '
        Me.txtRutaObservaciones.Location = New System.Drawing.Point(97, 120)
        Me.txtRutaObservaciones.Name = "txtRutaObservaciones"
        Me.txtRutaObservaciones.Size = New System.Drawing.Size(457, 20)
        Me.txtRutaObservaciones.TabIndex = 49
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 121)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(75, 19)
        Me.KryptonLabel1.TabIndex = 48
        Me.KryptonLabel1.Text = "Nota de OC : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nota de OC : "
        '
        'btnCargarDetalle
        '
        Me.btnCargarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargarDetalle.Enabled = False
        Me.btnCargarDetalle.Location = New System.Drawing.Point(587, 55)
        Me.btnCargarDetalle.Name = "btnCargarDetalle"
        Me.btnCargarDetalle.Size = New System.Drawing.Size(81, 44)
        Me.btnCargarDetalle.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCargarDetalle.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCargarDetalle.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCargarDetalle.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCargarDetalle.TabIndex = 47
        Me.btnCargarDetalle.Text = "&Cargar"
        Me.btnCargarDetalle.Values.ExtraText = "Consulta"
        Me.btnCargarDetalle.Values.Image = Nothing
        Me.btnCargarDetalle.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCargarDetalle.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCargarDetalle.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCargarDetalle.Values.Text = "&Cargar"
        '
        'btnCargarCabecera
        '
        Me.btnCargarCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargarCabecera.Location = New System.Drawing.Point(587, 3)
        Me.btnCargarCabecera.Name = "btnCargarCabecera"
        Me.btnCargarCabecera.Size = New System.Drawing.Size(81, 49)
        Me.btnCargarCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCargarCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCargarCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCargarCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCargarCabecera.TabIndex = 46
        Me.btnCargarCabecera.Text = "&Cargar"
        Me.btnCargarCabecera.Values.ExtraText = "Consulta"
        Me.btnCargarCabecera.Values.Image = Nothing
        Me.btnCargarCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCargarCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCargarCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCargarCabecera.Values.Text = "&Cargar"
        '
        'TxtRutaDetalle
        '
        Me.TxtRutaDetalle.Location = New System.Drawing.Point(97, 67)
        Me.TxtRutaDetalle.Name = "TxtRutaDetalle"
        Me.TxtRutaDetalle.Size = New System.Drawing.Size(457, 20)
        Me.TxtRutaDetalle.TabIndex = 45
        '
        'TxtRutaCabecera
        '
        Me.TxtRutaCabecera.Location = New System.Drawing.Point(97, 23)
        Me.TxtRutaCabecera.Name = "TxtRutaCabecera"
        Me.TxtRutaCabecera.Size = New System.Drawing.Size(457, 20)
        Me.TxtRutaCabecera.TabIndex = 44
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(11, 67)
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
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(11, 24)
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
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 158)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSNORCML"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Orden de Compra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PNFORCML"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha de Orden de Compra"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSNMONOC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PNFSOLIC"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha De Solicitud"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSTTINTC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Incoterm"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSTPAGME"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Termino de Pago"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSTPAISEM"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pais"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PSTNOMCOM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre de Comprador"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSNORCML"
        Me.DataGridViewTextBoxColumn9.HeaderText = "N° Orden Compra"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PNNRITOC"
        Me.DataGridViewTextBoxColumn10.HeaderText = "N° Item"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PSTCITCL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codigo de Item "
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PNQCNTIT"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cantidad "
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PSTDITES"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PSTUNDIT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Unidad de Medida"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PSNORCML
        '
        Me.PSNORCML.DataPropertyName = "PSNORCML"
        Me.PSNORCML.HeaderText = "Orden de Compra"
        Me.PSNORCML.Name = "PSNORCML"
        Me.PSNORCML.ReadOnly = True
        '
        'PNFORCML
        '
        Me.PNFORCML.DataPropertyName = "PNFORCML"
        Me.PNFORCML.HeaderText = "Fecha de Orden de Compra"
        Me.PNFORCML.Name = "PNFORCML"
        Me.PNFORCML.ReadOnly = True
        '
        'PSNMONOC
        '
        Me.PSNMONOC.DataPropertyName = "PSNMONOC"
        Me.PSNMONOC.HeaderText = "Moneda"
        Me.PSNMONOC.Name = "PSNMONOC"
        Me.PSNMONOC.ReadOnly = True
        '
        'PNFSOLIC
        '
        Me.PNFSOLIC.DataPropertyName = "PNFSOLIC"
        Me.PNFSOLIC.HeaderText = "Fecha De Solicitud"
        Me.PNFSOLIC.Name = "PNFSOLIC"
        Me.PNFSOLIC.ReadOnly = True
        '
        'PSTTINTC
        '
        Me.PSTTINTC.DataPropertyName = "PSTTINTC"
        Me.PSTTINTC.HeaderText = "Incoterm"
        Me.PSTTINTC.Name = "PSTTINTC"
        Me.PSTTINTC.ReadOnly = True
        '
        'PSTPAGME
        '
        Me.PSTPAGME.DataPropertyName = "PSTPAGME"
        Me.PSTPAGME.HeaderText = "Termino de Pago"
        Me.PSTPAGME.Name = "PSTPAGME"
        Me.PSTPAGME.ReadOnly = True
        '
        'PSTPAISEM
        '
        Me.PSTPAISEM.DataPropertyName = "PSTPAISEM"
        Me.PSTPAISEM.HeaderText = "Pais"
        Me.PSTPAISEM.Name = "PSTPAISEM"
        Me.PSTPAISEM.ReadOnly = True
        '
        'PSTNOMCOM
        '
        Me.PSTNOMCOM.DataPropertyName = "PSTNOMCOM"
        Me.PSTNOMCOM.HeaderText = "Nombre de Comprador"
        Me.PSTNOMCOM.Name = "PSTNOMCOM"
        Me.PSTNOMCOM.ReadOnly = True
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
        'frmImportarOCTxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 596)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 630)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 630)
        Me.Name = "frmImportarOCTxt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Ordenes de CompraText"
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
    Friend WithEvents TxtRutaDetalle As System.Windows.Forms.TextBox
    Friend WithEvents TxtRutaCabecera As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarDetalle As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCargarCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgExcelDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCargarObservaciones As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtRutaObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PSNORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNFORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNMONOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNFSOLIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTTINTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPAGME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPAISEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTNOMCOM As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
