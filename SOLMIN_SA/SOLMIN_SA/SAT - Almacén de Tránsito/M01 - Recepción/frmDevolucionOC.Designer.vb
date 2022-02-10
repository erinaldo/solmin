<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucionOC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionOC))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.scrContainer_001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgOrdenCompra = New Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCambiarCliente = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbPrioridad = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.lblPrioridad = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblSituacionOC = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbSituacionOC = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.txtProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01
        Me.cmbTermInter = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaDescripcionLimpiar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTerminoInternacional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaOrdenCompraLimpiar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tbcDetalles = New System.Windows.Forms.TabControl
        Me.tbpDetalle = New System.Windows.Forms.TabPage
        Me.dgItemsOC = New Ransa.Controls.OrdenCompra.ucItemOC_DgF01
        Me.tbpMovimientos = New System.Windows.Forms.TabPage
        Me.dgMovimientoItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NOPREC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_INGSDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECDOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRGUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CREFFW1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_INGSDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECDOC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRGUSA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QBLTSR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUIRM1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IMBULTO = New System.Windows.Forms.DataGridViewImageColumn
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader
        Me.tbpObservaciones = New System.Windows.Forms.TabPage
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.scrContainer_001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrContainer_001.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scrContainer_001.Panel1.SuspendLayout()
        CType(Me.scrContainer_001.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scrContainer_001.Panel2.SuspendLayout()
        Me.scrContainer_001.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.tbcDetalles.SuspendLayout()
        Me.tbpDetalle.SuspendLayout()
        Me.tbpMovimientos.SuspendLayout()
        CType(Me.dgMovimientoItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpObservaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.scrContainer_001)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(988, 621)
        Me.KryptonPanel.TabIndex = 0
        '
        'scrContainer_001
        '
        Me.scrContainer_001.Cursor = System.Windows.Forms.Cursors.Default
        Me.scrContainer_001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scrContainer_001.Location = New System.Drawing.Point(0, 0)
        Me.scrContainer_001.Name = "scrContainer_001"
        Me.scrContainer_001.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scrContainer_001.Panel1
        '
        Me.scrContainer_001.Panel1.Controls.Add(Me.dgOrdenCompra)
        Me.scrContainer_001.Panel1.Controls.Add(Me.hgFiltros)
        '
        'scrContainer_001.Panel2
        '
        Me.scrContainer_001.Panel2.Controls.Add(Me.tbcDetalles)
        Me.scrContainer_001.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
        Me.scrContainer_001.Size = New System.Drawing.Size(988, 621)
        Me.scrContainer_001.SplitterDistance = 451
        Me.scrContainer_001.TabIndex = 2
        '
        'dgOrdenCompra
        '
        Me.dgOrdenCompra.Agregar = True
        Me.dgOrdenCompra.BackColor = System.Drawing.Color.Transparent
        Me.dgOrdenCompra.CambiarDeCliente = True
        Me.dgOrdenCompra.CodCliente = 0
        Me.dgOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenCompra.Eliminar = True
        Me.dgOrdenCompra.Location = New System.Drawing.Point(0, 169)
        Me.dgOrdenCompra.Modificar = True
        Me.dgOrdenCompra.Name = "dgOrdenCompra"
        Me.dgOrdenCompra.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgOrdenCompra.pREGPAG_NroRegPorPagina = 20
        Me.dgOrdenCompra.Size = New System.Drawing.Size(988, 282)
        Me.dgOrdenCompra.TabIndex = 0
        Me.dgOrdenCompra.Traslado = True
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.btnCambiarCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.cmbPrioridad)
        Me.hgFiltros.Panel.Controls.Add(Me.lblPrioridad)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblSituacionOC)
        Me.hgFiltros.Panel.Controls.Add(Me.cmbSituacionOC)
        Me.hgFiltros.Panel.Controls.Add(Me.txtProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.cmbTermInter)
        Me.hgFiltros.Panel.Controls.Add(Me.lblDescripcion)
        Me.hgFiltros.Panel.Controls.Add(Me.txtDescripcion)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTerminoInternacional)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaFinal)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaInicial)
        Me.hgFiltros.Panel.Controls.Add(Me.lblOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.hgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.hgFiltros.Panel.Controls.Add(Me.txtOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblProveedor)
        Me.hgFiltros.Size = New System.Drawing.Size(988, 169)
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
        'btnCambiarCliente
        '
        Me.btnCambiarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarCliente.Location = New System.Drawing.Point(898, 57)
        Me.btnCambiarCliente.Name = "btnCambiarCliente"
        Me.btnCambiarCliente.Size = New System.Drawing.Size(68, 69)
        Me.btnCambiarCliente.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnCambiarCliente.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCambiarCliente.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCambiarCliente.TabIndex = 20
        Me.btnCambiarCliente.Text = "&Cambiar"
        Me.btnCambiarCliente.Values.ExtraText = "Cliente"
        Me.btnCambiarCliente.Values.Image = CType(resources.GetObject("btnCambiarCliente.Values.Image"), System.Drawing.Image)
        Me.btnCambiarCliente.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCambiarCliente.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCambiarCliente.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCambiarCliente.Values.Text = "&Cambiar"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(703, 61)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 76)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(824, 56)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 24
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(678, 8)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(342, 8)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel2.TabIndex = 56
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 8)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 19)
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
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(731, 8)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(180, 23)
        Me.UcPLanta_Cmb011.TabIndex = 14
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(425, 4)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(243, 23)
        Me.UcDivision_Cmb011.TabIndex = 12
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(72, 4)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(262, 23)
        Me.UcCompania_Cmb011.TabIndex = 11
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.cmbPrioridad.Location = New System.Drawing.Point(72, 107)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.pCategoria = "NTPDES"
        Me.cmbPrioridad.pIsRequired = False
        Me.cmbPrioridad.Size = New System.Drawing.Size(262, 21)
        Me.cmbPrioridad.TabIndex = 8
        '
        'lblPrioridad
        '
        Me.lblPrioridad.Location = New System.Drawing.Point(6, 107)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(61, 19)
        Me.lblPrioridad.TabIndex = 7
        Me.lblPrioridad.Text = "Prioridad : "
        Me.lblPrioridad.Values.ExtraText = ""
        Me.lblPrioridad.Values.Image = Nothing
        Me.lblPrioridad.Values.Text = "Prioridad : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(72, 33)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(262, 21)
        Me.txtCliente.TabIndex = 15
        '
        'lblSituacionOC
        '
        Me.lblSituacionOC.Location = New System.Drawing.Point(342, 107)
        Me.lblSituacionOC.Name = "lblSituacionOC"
        Me.lblSituacionOC.Size = New System.Drawing.Size(62, 19)
        Me.lblSituacionOC.TabIndex = 17
        Me.lblSituacionOC.Text = "Situación :"
        Me.lblSituacionOC.Values.ExtraText = ""
        Me.lblSituacionOC.Values.Image = Nothing
        Me.lblSituacionOC.Values.Text = "Situación :"
        '
        'cmbSituacionOC
        '
        Me.cmbSituacionOC.BackColor = System.Drawing.Color.Transparent
        Me.cmbSituacionOC.Location = New System.Drawing.Point(425, 107)
        Me.cmbSituacionOC.Name = "cmbSituacionOC"
        Me.cmbSituacionOC.pCategoria = "SITUOC"
        Me.cmbSituacionOC.pIsRequired = False
        Me.cmbSituacionOC.Size = New System.Drawing.Size(243, 21)
        Me.cmbSituacionOC.TabIndex = 23
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(72, 83)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = False
        Me.txtProveedor.Size = New System.Drawing.Size(262, 21)
        Me.txtProveedor.TabIndex = 19
        '
        'cmbTermInter
        '
        Me.cmbTermInter.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermInter.Location = New System.Drawing.Point(425, 58)
        Me.cmbTermInter.Name = "cmbTermInter"
        Me.cmbTermInter.pCategoria = "TERINT"
        Me.cmbTermInter.pIsRequired = False
        Me.cmbTermInter.Size = New System.Drawing.Size(243, 21)
        Me.cmbTermInter.TabIndex = 18
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(342, 36)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(74, 19)
        Me.lblDescripcion.TabIndex = 9
        Me.lblDescripcion.Text = "Descripción : "
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "Descripción : "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaDescripcionLimpiar})
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(425, 33)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(243, 21)
        Me.txtDescripcion.TabIndex = 16
        '
        'bsaDescripcionLimpiar
        '
        Me.bsaDescripcionLimpiar.ExtraText = ""
        Me.bsaDescripcionLimpiar.Image = Nothing
        Me.bsaDescripcionLimpiar.Text = ""
        Me.bsaDescripcionLimpiar.ToolTipImage = Nothing
        Me.bsaDescripcionLimpiar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaDescripcionLimpiar.UniqueName = "DD3C34848EF94820DD3C34848EF94820"
        '
        'lblTerminoInternacional
        '
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(342, 61)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(69, 19)
        Me.lblTerminoInternacional.TabIndex = 11
        Me.lblTerminoInternacional.Text = "Térm. Inter.:"
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Inter.:"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaFinal.Location = New System.Drawing.Point(595, 83)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaFinal.Size = New System.Drawing.Size(73, 21)
        Me.txtFechaFinal.TabIndex = 22
        Me.txtFechaFinal.Text = "  /  /"
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInicial.Location = New System.Drawing.Point(425, 83)
        Me.txtFechaInicial.Mask = "00/00/0000"
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInicial.Size = New System.Drawing.Size(73, 21)
        Me.txtFechaInicial.TabIndex = 20
        Me.txtFechaInicial.Text = "  /  /"
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(5, 61)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(60, 19)
        Me.lblOrdenCompra.TabIndex = 3
        Me.lblOrdenCompra.Text = "Nro. O/C : "
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(513, 85)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(71, 19)
        Me.lblFechaFinal.TabIndex = 21
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(342, 86)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(74, 19)
        Me.lblFechaInicial.TabIndex = 13
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaOrdenCompraLimpiar})
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.Location = New System.Drawing.Point(72, 58)
        Me.txtOrdenCompra.MaxLength = 100
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(262, 21)
        Me.txtOrdenCompra.TabIndex = 17
        '
        'bsaOrdenCompraLimpiar
        '
        Me.bsaOrdenCompraLimpiar.ExtraText = ""
        Me.bsaOrdenCompraLimpiar.Image = Nothing
        Me.bsaOrdenCompraLimpiar.Text = ""
        Me.bsaOrdenCompraLimpiar.ToolTipImage = Nothing
        Me.bsaOrdenCompraLimpiar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaOrdenCompraLimpiar.UniqueName = "DD3C34848EF94820DD3C34848EF94820"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(5, 36)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(5, 86)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(67, 19)
        Me.lblProveedor.TabIndex = 5
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'tbcDetalles
        '
        Me.tbcDetalles.Controls.Add(Me.tbpDetalle)
        Me.tbcDetalles.Controls.Add(Me.tbpMovimientos)
        Me.tbcDetalles.Controls.Add(Me.tbpObservaciones)
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.SelectedIndex = 0
        Me.tbcDetalles.Size = New System.Drawing.Size(988, 165)
        Me.tbcDetalles.TabIndex = 0
        '
        'tbpDetalle
        '
        Me.tbpDetalle.Controls.Add(Me.dgItemsOC)
        Me.tbpDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetalle.Name = "tbpDetalle"
        Me.tbpDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetalle.Size = New System.Drawing.Size(980, 139)
        Me.tbpDetalle.TabIndex = 0
        Me.tbpDetalle.Text = "Detalle Item"
        Me.tbpDetalle.UseVisualStyleBackColor = True
        '
        'dgItemsOC
        '
        Me.dgItemsOC.Agregar = True
        Me.dgItemsOC.BackColor = System.Drawing.Color.Transparent
        Me.dgItemsOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemsOC.Eliminar = True
        Me.dgItemsOC.Location = New System.Drawing.Point(3, 3)
        Me.dgItemsOC.Modificar = True
        Me.dgItemsOC.Name = "dgItemsOC"
        Me.dgItemsOC.pEstado = ""
        Me.dgItemsOC.pMostrarGenerar = RANSA.Controls.OrdenCompra.eGenerarTipo.GenerarBulto
        Me.dgItemsOC.pMostrarGenerarRecojo = False
        Me.dgItemsOC.Size = New System.Drawing.Size(974, 133)
        Me.dgItemsOC.TabIndex = 0
        '
        'tbpMovimientos
        '
        Me.tbpMovimientos.Controls.Add(Me.dgMovimientoItemOC)
        Me.tbpMovimientos.Controls.Add(Me.KryptonHeader1)
        Me.tbpMovimientos.Location = New System.Drawing.Point(4, 22)
        Me.tbpMovimientos.Name = "tbpMovimientos"
        Me.tbpMovimientos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMovimientos.Size = New System.Drawing.Size(980, 139)
        Me.tbpMovimientos.TabIndex = 1
        Me.tbpMovimientos.Text = "Movimiento Item O/C"
        Me.tbpMovimientos.UseVisualStyleBackColor = True
        '
        'dgMovimientoItemOC
        '
        Me.dgMovimientoItemOC.AllowUserToAddRows = False
        Me.dgMovimientoItemOC.AllowUserToDeleteRows = False
        Me.dgMovimientoItemOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMovimientoItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NOPREC, Me.M_CREFFW, Me.M_INGSDA, Me.M_FECDOC, Me.M_NRGUSA, Me.M_QBLTSR, Me.M_NGUIRM, Me.M_CREFFW1, Me.M_INGSDA1, Me.M_FECDOC1, Me.M_NRGUSA1, Me.M_QBLTSR1, Me.M_NGUIRM1, Me.M_IMBULTO})
        Me.dgMovimientoItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMovimientoItemOC.Location = New System.Drawing.Point(3, 22)
        Me.dgMovimientoItemOC.Name = "dgMovimientoItemOC"
        Me.dgMovimientoItemOC.ReadOnly = True
        Me.dgMovimientoItemOC.Size = New System.Drawing.Size(974, 114)
        Me.dgMovimientoItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMovimientoItemOC.TabIndex = 1
        '
        'M_NOPREC
        '
        Me.M_NOPREC.DataPropertyName = "NOPREC"
        Me.M_NOPREC.HeaderText = "No. Bulto Parcial"
        Me.M_NOPREC.Name = "M_NOPREC"
        Me.M_NOPREC.ReadOnly = True
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 105
        '
        'M_INGSDA
        '
        Me.M_INGSDA.DataPropertyName = "INGSDA"
        Me.M_INGSDA.HeaderText = "Mov. Ing."
        Me.M_INGSDA.Name = "M_INGSDA"
        Me.M_INGSDA.ReadOnly = True
        Me.M_INGSDA.Width = 70
        '
        'M_FECDOC
        '
        Me.M_FECDOC.DataPropertyName = "FECDOC"
        Me.M_FECDOC.HeaderText = "Fecha Mov."
        Me.M_FECDOC.Name = "M_FECDOC"
        Me.M_FECDOC.ReadOnly = True
        Me.M_FECDOC.Width = 80
        '
        'M_NRGUSA
        '
        Me.M_NRGUSA.DataPropertyName = "NRGUSA"
        Me.M_NRGUSA.HeaderText = "No. Guia (P)/(S)"
        Me.M_NRGUSA.Name = "M_NRGUSA"
        Me.M_NRGUSA.ReadOnly = True
        Me.M_NRGUSA.Width = 220
        '
        'M_QBLTSR
        '
        Me.M_QBLTSR.DataPropertyName = "QBLTSR"
        Me.M_QBLTSR.HeaderText = "Cantidad"
        Me.M_QBLTSR.Name = "M_QBLTSR"
        Me.M_QBLTSR.ReadOnly = True
        '
        'M_NGUIRM
        '
        Me.M_NGUIRM.DataPropertyName = "NGUIRM"
        Me.M_NGUIRM.HeaderText = "No. Guia Remisión"
        Me.M_NGUIRM.Name = "M_NGUIRM"
        Me.M_NGUIRM.ReadOnly = True
        Me.M_NGUIRM.Visible = False
        '
        'M_CREFFW1
        '
        Me.M_CREFFW1.DataPropertyName = "CREFFW1"
        Me.M_CREFFW1.HeaderText = "Bulto"
        Me.M_CREFFW1.Name = "M_CREFFW1"
        Me.M_CREFFW1.ReadOnly = True
        Me.M_CREFFW1.Visible = False
        '
        'M_INGSDA1
        '
        Me.M_INGSDA1.DataPropertyName = "INGSDA1"
        Me.M_INGSDA1.HeaderText = "Mov. Sal."
        Me.M_INGSDA1.Name = "M_INGSDA1"
        Me.M_INGSDA1.ReadOnly = True
        Me.M_INGSDA1.Width = 70
        '
        'M_FECDOC1
        '
        Me.M_FECDOC1.DataPropertyName = "FECDOC1"
        Me.M_FECDOC1.HeaderText = "Fecha Mov."
        Me.M_FECDOC1.Name = "M_FECDOC1"
        Me.M_FECDOC1.ReadOnly = True
        Me.M_FECDOC1.Width = 80
        '
        'M_NRGUSA1
        '
        Me.M_NRGUSA1.DataPropertyName = "NRGUSA1"
        Me.M_NRGUSA1.HeaderText = "No. Guia (P)/(S)"
        Me.M_NRGUSA1.Name = "M_NRGUSA1"
        Me.M_NRGUSA1.ReadOnly = True
        Me.M_NRGUSA1.Width = 125
        '
        'M_QBLTSR1
        '
        Me.M_QBLTSR1.DataPropertyName = "QBLTSR1"
        Me.M_QBLTSR1.HeaderText = "Cantidad"
        Me.M_QBLTSR1.Name = "M_QBLTSR1"
        Me.M_QBLTSR1.ReadOnly = True
        '
        'M_NGUIRM1
        '
        Me.M_NGUIRM1.DataPropertyName = "NGUIRM1"
        Me.M_NGUIRM1.HeaderText = "No. Guia Remision"
        Me.M_NGUIRM1.Name = "M_NGUIRM1"
        Me.M_NGUIRM1.ReadOnly = True
        Me.M_NGUIRM1.Width = 120
        '
        'M_IMBULTO
        '
        Me.M_IMBULTO.HeaderText = "Items"
        Me.M_IMBULTO.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.M_IMBULTO.Name = "M_IMBULTO"
        Me.M_IMBULTO.ReadOnly = True
        Me.M_IMBULTO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.M_IMBULTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.M_IMBULTO.Width = 40
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(974, 19)
        Me.KryptonHeader1.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeader1.TabIndex = 0
        Me.KryptonHeader1.Text = "Movimiento Item O/C"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Movimiento Item O/C"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'tbpObservaciones
        '
        Me.tbpObservaciones.Controls.Add(Me.txtObservacion)
        Me.tbpObservaciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpObservaciones.Name = "tbpObservaciones"
        Me.tbpObservaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpObservaciones.Size = New System.Drawing.Size(980, 139)
        Me.tbpObservaciones.TabIndex = 2
        Me.tbpObservaciones.Text = "Observaciones O/C"
        Me.tbpObservaciones.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservacion.Location = New System.Drawing.Point(3, 3)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(974, 133)
        Me.txtObservacion.TabIndex = 26
        Me.txtObservacion.TabStop = False
        '
        'frmDevolucionOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 621)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmDevolucionOC"
        Me.Text = "Devolucion Orden de Compra"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.scrContainer_001.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scrContainer_001.Panel1.ResumeLayout(False)
        Me.scrContainer_001.Panel1.PerformLayout()
        CType(Me.scrContainer_001.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scrContainer_001.Panel2.ResumeLayout(False)
        CType(Me.scrContainer_001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scrContainer_001.ResumeLayout(False)
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        Me.tbcDetalles.ResumeLayout(False)
        Me.tbpDetalle.ResumeLayout(False)
        Me.tbpMovimientos.ResumeLayout(False)
        Me.tbpMovimientos.PerformLayout()
        CType(Me.dgMovimientoItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpObservaciones.ResumeLayout(False)
        Me.tbpObservaciones.PerformLayout()
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
    Private WithEvents scrContainer_001 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgOrdenCompra As Ransa.Controls.OrdenCompra.ucOrdenCompra_DgF01
    Friend WithEvents tbcDetalles As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetalle As System.Windows.Forms.TabPage
    Friend WithEvents dgItemsOC As Ransa.Controls.OrdenCompra.ucItemOC_DgF01
    Friend WithEvents tbpMovimientos As System.Windows.Forms.TabPage
    Friend WithEvents dgMovimientoItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NOPREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_INGSDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRGUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CREFFW1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_INGSDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECDOC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRGUSA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QBLTSR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRM1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMBULTO As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
    Friend WithEvents tbpObservaciones As System.Windows.Forms.TabPage
    Private WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents cmbPrioridad As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents lblPrioridad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents lblSituacionOC As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbSituacionOC As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Friend WithEvents txtProveedor As Ransa.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents cmbTermInter As Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents btnCambiarCliente As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents bsaDescripcionLimpiar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents lblTerminoInternacional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents txtFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents txtFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents bsaOrdenCompraLimpiar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
