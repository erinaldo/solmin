<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLPosiciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLPosiciones))
        Dim BeCompania2 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim BePlanta2 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgPosiciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnEtiquetas = New System.Windows.Forms.ToolStripSplitButton()
        Me.btnImprimirPosiciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnImprimirPasilloFila = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.brnCargamasiva = New System.Windows.Forms.ToolStripButton()
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoAlmacen = New Ransa.CONTROL.ucAyuda()
        Me.txtAlmacen = New Ransa.CONTROL.ucAyuda()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.txtPosicion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPosicion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblSector = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSector = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lblServicio = New System.Windows.Forms.ToolStripLabel()
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator()
        Me.cbxPlanta = New System.Windows.Forms.ToolStripComboBox()
        Me.lblPlanta = New System.Windows.Forms.ToolStripLabel()
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
        Me.PNCCLNRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPSCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPSLL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCCLMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQSLETQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PSTPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNCPLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgPosiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgPosiciones)
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1344, 737)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgPosiciones
        '
        Me.dgPosiciones.AllowUserToAddRows = False
        Me.dgPosiciones.AllowUserToDeleteRows = False
        Me.dgPosiciones.AllowUserToResizeColumns = False
        Me.dgPosiciones.AllowUserToResizeRows = False
        Me.dgPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPosiciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCCLNRN, Me.CPSCN, Me.PSTIPO, Me.PSALMACEN, Me.CPSLL, Me.PSCCLMN, Me.PSCLIENTE, Me.PSTMRCD2, Me.PNQSLETQ, Me.BTN, Me.PSTPLNTA, Me.TIPO_ALMACEN, Me.ALMACEN, Me.ZONA, Me.CLIENTE, Me.PSCTPALM, Me.PSCALMC, Me.PSCZNALM, Me.PNCPLNFC, Me.Column1})
        Me.dgPosiciones.DataMember = "dtRZSC30"
        Me.dgPosiciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPosiciones.Location = New System.Drawing.Point(0, 217)
        Me.dgPosiciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dgPosiciones.MultiSelect = False
        Me.dgPosiciones.Name = "dgPosiciones"
        Me.dgPosiciones.ReadOnly = True
        Me.dgPosiciones.RowHeadersWidth = 20
        Me.dgPosiciones.RowTemplate.ReadOnly = True
        Me.dgPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPosiciones.Size = New System.Drawing.Size(1344, 489)
        Me.dgPosiciones.StandardTab = True
        Me.dgPosiciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgPosiciones.TabIndex = 27
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 706)
        Me.UcPaginacion.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(1344, 31)
        Me.UcPaginacion.TabIndex = 28
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizar, Me.btnExportar, Me.ToolStripLabel1, Me.btnEtiquetas, Me.tsbImprimir, Me.tsbEliminar, Me.tsbModificar, Me.tsbAgregar, Me.brnCargamasiva})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 190)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1344, 27)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'btnActualizar
        '
        Me.btnActualizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnActualizar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(76, 24)
        Me.btnActualizar.Text = "Buscar"
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 24)
        Me.btnExportar.Text = "Exportar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(256, 24)
        Me.ToolStripLabel1.Tag = "POSICION"
        Me.ToolStripLabel1.Text = "POSICION MERCADERIA LISTADO"
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEtiquetas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimirPosiciones, Me.btnImprimirPasilloFila})
        Me.btnEtiquetas.Image = Global.SOLMIN_SA.My.Resources.Resources.mime_resource
        Me.btnEtiquetas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEtiquetas.Name = "btnEtiquetas"
        Me.btnEtiquetas.Size = New System.Drawing.Size(109, 24)
        Me.btnEtiquetas.Text = "Etiquetas"
        '
        'btnImprimirPosiciones
        '
        Me.btnImprimirPosiciones.Name = "btnImprimirPosiciones"
        Me.btnImprimirPosiciones.Size = New System.Drawing.Size(238, 26)
        Me.btnImprimirPosiciones.Text = "Etiquetas de Posiciones"
        '
        'btnImprimirPasilloFila
        '
        Me.btnImprimirPasilloFila.Name = "btnImprimirPasilloFila"
        Me.btnImprimirPasilloFila.Size = New System.Drawing.Size(238, 26)
        Me.btnImprimirPasilloFila.Text = "Etiquetas  Pasillo/Fila"
        Me.btnImprimirPasilloFila.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsbImprimir
        '
        Me.tsbImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(90, 24)
        Me.tsbImprimir.Text = "&Imprimir"
        Me.tsbImprimir.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(87, 24)
        Me.tsbEliminar.Text = "&Eliminar"
        '
        'tsbModificar
        '
        Me.tsbModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(97, 24)
        Me.tsbModificar.Text = "&Modificar"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregar.Image = CType(resources.GetObject("tsbAgregar.Image"), System.Drawing.Image)
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(87, 24)
        Me.tsbAgregar.Text = "&Agregar"
        '
        'brnCargamasiva
        '
        Me.brnCargamasiva.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.brnCargamasiva.Image = Global.SOLMIN_SA.My.Resources.Resources.GenerarReporte
        Me.brnCargamasiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.brnCargamasiva.Name = "brnCargamasiva"
        Me.brnCargamasiva.Size = New System.Drawing.Size(152, 24)
        Me.brnCargamasiva.Text = "Masivo Posiciones"
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.txtPosicion)
        Me.hgFiltros.Panel.Controls.Add(Me.lblPosicion)
        Me.hgFiltros.Panel.Controls.Add(Me.lblSector)
        Me.hgFiltros.Panel.Controls.Add(Me.txtSector)
        Me.hgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(1344, 190)
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
        'bsaStatusOcultarFiltros
        '
        Me.bsaStatusOcultarFiltros.ExtraText = ""
        Me.bsaStatusOcultarFiltros.Image = Nothing
        Me.bsaStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaStatusOcultarFiltros.Text = "Ocultar"
        Me.bsaStatusOcultarFiltros.ToolTipImage = Nothing
        Me.bsaStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaStatusOcultarFiltros.UniqueName = "035391BBFC7044C3035391BBFC7044C3"
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
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(544, 110)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(349, 26)
        Me.txtCliente.TabIndex = 61
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(467, 113)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 60
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(109, 74)
        Me.txtTipoAlmacen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(236, 26)
        Me.txtTipoAlmacen.TabIndex = 58
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(547, 73)
        Me.txtAlmacen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = True
        Me.txtAlmacen.Size = New System.Drawing.Size(286, 26)
        Me.txtAlmacen.TabIndex = 59
        Me.txtAlmacen.ValueMember = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(109, 27)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania2.CCMPN_CodigoCompania = ""
        BeCompania2.Orden = -1
        BeCompania2.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania2
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(236, 28)
        Me.UcCompania_Cmb011.TabIndex = 52
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(772, 31)
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
        Me.KryptonLabel2.Location = New System.Drawing.Point(371, 27)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel2.TabIndex = 56
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 31)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel1.TabIndex = 55
        Me.KryptonLabel1.Text = "Compañia : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(847, 27)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta2.CCMPN_CodigoCompania = ""
        BePlanta2.CDSPSP_CodSedeSAP = Nothing
        BePlanta2.CDVSN_CodigoDivision = ""
        BePlanta2.CPLNDV_CodigoPlanta = 0.0R
        BePlanta2.Orden = -1
        BePlanta2.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta2
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0.0R
        Me.UcPLanta_Cmb011.PlantaDefault = -1.0R
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(205, 28)
        Me.UcPLanta_Cmb011.TabIndex = 54
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(459, 27)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(273, 28)
        Me.UcDivision_Cmb011.TabIndex = 53
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(285, 111)
        Me.txtPosicion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(165, 26)
        Me.txtPosicion.TabIndex = 49
        Me.txtPosicion.Text = " "
        '
        'lblPosicion
        '
        Me.lblPosicion.Location = New System.Drawing.Point(195, 113)
        Me.lblPosicion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(76, 24)
        Me.lblPosicion.TabIndex = 48
        Me.lblPosicion.Text = "Posición : "
        Me.lblPosicion.Values.ExtraText = ""
        Me.lblPosicion.Values.Image = Nothing
        Me.lblPosicion.Values.Text = "Posición : "
        '
        'lblSector
        '
        Me.lblSector.Location = New System.Drawing.Point(23, 111)
        Me.lblSector.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(58, 24)
        Me.lblSector.TabIndex = 45
        Me.lblSector.Text = "Sector:"
        Me.lblSector.Values.ExtraText = ""
        Me.lblSector.Values.Image = Nothing
        Me.lblSector.Values.Text = "Sector:"
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(109, 108)
        Me.txtSector.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(51, 26)
        Me.txtSector.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSector.TabIndex = 44
        Me.txtSector.Text = "G"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(453, 74)
        Me.lblAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(78, 24)
        Me.lblAlmacen.TabIndex = 43
        Me.lblAlmacen.Text = "Almacén : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacén : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(23, 74)
        Me.lblTipoAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(49, 24)
        Me.lblTipoAlmacen.TabIndex = 42
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(1063, -1)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 153)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'lblServicio
        '
        Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(73, 22)
        Me.lblServicio.Tag = "SERVICIOS"
        Me.lblServicio.Text = "SERVICIOS"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'cbxPlanta
        '
        Me.cbxPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlanta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cbxPlanta.Name = "cbxPlanta"
        Me.cbxPlanta.Size = New System.Drawing.Size(150, 25)
        '
        'lblPlanta
        '
        Me.lblPlanta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblPlanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(55, 22)
        Me.lblPlanta.Text = "Planta : "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTIPO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSALMACEN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 79
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSCPSLL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pasillo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSCCLMN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Columna"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSCPSCN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Posición"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSCLIENTE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSFAMILIA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Familia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 72
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PSGRUPO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSMERCADERIA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mercaderia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 93
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSNCRPRD"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Prioridad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 83
        '
        'PNCCLNRN
        '
        Me.PNCCLNRN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCCLNRN.DataPropertyName = "PNCCLNRN"
        Me.PNCCLNRN.HeaderText = "Código Cliente"
        Me.PNCCLNRN.Name = "PNCCLNRN"
        Me.PNCCLNRN.ReadOnly = True
        Me.PNCCLNRN.Visible = False
        Me.PNCCLNRN.Width = 141
        '
        'CPSCN
        '
        Me.CPSCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPSCN.DataPropertyName = "PSCLIENTE"
        Me.CPSCN.HeaderText = "Des. Abrev. del Cliente"
        Me.CPSCN.Name = "CPSCN"
        Me.CPSCN.ReadOnly = True
        Me.CPSCN.Visible = False
        Me.CPSCN.Width = 191
        '
        'PSTIPO
        '
        Me.PSTIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTIPO.DataPropertyName = "PSCPSCN"
        Me.PSTIPO.HeaderText = "Posición"
        Me.PSTIPO.Name = "PSTIPO"
        Me.PSTIPO.ReadOnly = True
        Me.PSTIPO.Width = 96
        '
        'PSALMACEN
        '
        Me.PSALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSALMACEN.DataPropertyName = "PNCSRVPK"
        Me.PSALMACEN.HeaderText = "Srv Pck"
        Me.PSALMACEN.Name = "PSALMACEN"
        Me.PSALMACEN.ReadOnly = True
        Me.PSALMACEN.Width = 87
        '
        'CPSLL
        '
        Me.CPSLL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPSLL.DataPropertyName = "PSCPSLL"
        Me.CPSLL.HeaderText = "Pasillo"
        Me.CPSLL.Name = "CPSLL"
        Me.CPSLL.ReadOnly = True
        Me.CPSLL.Width = 84
        '
        'PSCCLMN
        '
        Me.PSCCLMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCCLMN.DataPropertyName = "PSCCLMN"
        Me.PSCCLMN.HeaderText = "Columna"
        Me.PSCCLMN.Name = "PSCCLMN"
        Me.PSCCLMN.ReadOnly = True
        Me.PSCCLMN.Width = 101
        '
        'PSCLIENTE
        '
        Me.PSCLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCLIENTE.DataPropertyName = "PSESTADO"
        Me.PSCLIENTE.HeaderText = "Estado"
        Me.PSCLIENTE.Name = "PSCLIENTE"
        Me.PSCLIENTE.ReadOnly = True
        Me.PSCLIENTE.Width = 87
        '
        'PSTMRCD2
        '
        Me.PSTMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTMRCD2.DataPropertyName = "PSTMRCD2"
        Me.PSTMRCD2.HeaderText = "Producto Descripción"
        Me.PSTMRCD2.Name = "PSTMRCD2"
        Me.PSTMRCD2.ReadOnly = True
        Me.PSTMRCD2.Width = 184
        '
        'PNQSLETQ
        '
        Me.PNQSLETQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNQSLETQ.DataPropertyName = "PNQSLETQ"
        Me.PNQSLETQ.HeaderText = "Cantidad"
        Me.PNQSLETQ.Name = "PNQSLETQ"
        Me.PNQSLETQ.ReadOnly = True
        Me.PNQSLETQ.Width = 102
        '
        'BTN
        '
        Me.BTN.HeaderText = "Inventario"
        Me.BTN.Image = Global.SOLMIN_SA.My.Resources.Resources.cell_layout
        Me.BTN.Name = "BTN"
        Me.BTN.ReadOnly = True
        Me.BTN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BTN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BTN.Width = 108
        '
        'PSTPLNTA
        '
        Me.PSTPLNTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTPLNTA.DataPropertyName = "PSTPLNTA"
        Me.PSTPLNTA.HeaderText = "Planta"
        Me.PSTPLNTA.Name = "PSTPLNTA"
        Me.PSTPLNTA.ReadOnly = True
        Me.PSTPLNTA.Width = 83
        '
        'TIPO_ALMACEN
        '
        Me.TIPO_ALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_ALMACEN.DataPropertyName = "PSTIPO_ALMACEN"
        Me.TIPO_ALMACEN.HeaderText = "Tipo Almacén"
        Me.TIPO_ALMACEN.Name = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN.ReadOnly = True
        Me.TIPO_ALMACEN.Width = 134
        '
        'ALMACEN
        '
        Me.ALMACEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALMACEN.DataPropertyName = "PSALMACEN"
        Me.ALMACEN.HeaderText = "Almacén"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.ReadOnly = True
        '
        'ZONA
        '
        Me.ZONA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZONA.DataPropertyName = "PSZONA"
        Me.ZONA.HeaderText = "Zona"
        Me.ZONA.Name = "ZONA"
        Me.ZONA.ReadOnly = True
        Me.ZONA.Width = 76
        '
        'CLIENTE
        '
        Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLIENTE.DataPropertyName = "PSCLIENTE"
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 88
        '
        'PSCTPALM
        '
        Me.PSCTPALM.DataPropertyName = "PSCTPALM"
        Me.PSCTPALM.HeaderText = "PSCTPALM"
        Me.PSCTPALM.Name = "PSCTPALM"
        Me.PSCTPALM.ReadOnly = True
        Me.PSCTPALM.Visible = False
        Me.PSCTPALM.Width = 112
        '
        'PSCALMC
        '
        Me.PSCALMC.DataPropertyName = "PSCALMC"
        Me.PSCALMC.HeaderText = "PSCALMC"
        Me.PSCALMC.Name = "PSCALMC"
        Me.PSCALMC.ReadOnly = True
        Me.PSCALMC.Visible = False
        Me.PSCALMC.Width = 106
        '
        'PSCZNALM
        '
        Me.PSCZNALM.DataPropertyName = "PSCZNALM"
        Me.PSCZNALM.HeaderText = "PSCZNALM"
        Me.PSCZNALM.Name = "PSCZNALM"
        Me.PSCZNALM.ReadOnly = True
        Me.PSCZNALM.Visible = False
        Me.PSCZNALM.Width = 117
        '
        'PNCPLNFC
        '
        Me.PNCPLNFC.DataPropertyName = "PNCPLNFC"
        Me.PNCPLNFC.HeaderText = "PNCPLNFC"
        Me.PNCPLNFC.Name = "PNCPLNFC"
        Me.PNCPLNFC.ReadOnly = True
        Me.PNCPLNFC.Visible = False
        Me.PNCPLNFC.Width = 112
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmLPosiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 737)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLPosiciones"
        Me.Text = "00"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgPosiciones, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents lblServicio As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cbxPlanta As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents lblPlanta As System.Windows.Forms.ToolStripLabel
    Private WithEvents dgPosiciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents tsbImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Friend WithEvents txtSector As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblSector As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnEtiquetas As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnImprimirPosiciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnImprimirPasilloFila As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtPosicion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPosicion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents txtTipoAlmacen As RANSA.CONTROL.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.CONTROL.ucAyuda
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents brnCargamasiva As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PNCCLNRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPSCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPSLL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCLMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQSLETQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BTN As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PSTPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
