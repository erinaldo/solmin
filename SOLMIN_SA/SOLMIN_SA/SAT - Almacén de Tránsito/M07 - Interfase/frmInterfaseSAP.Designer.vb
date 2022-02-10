<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterfaseSAP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterfaseSAP))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgBultos = New Ransa.Controls.WayBill.ucWaybill_DgF01
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtUbicacionReferencial = New Ransa.CONTROL.ucAyuda
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbTermInter = New Ransa.Controls.TipoAyuda.ucTipoAyuda_CmbF01
        Me.lblTerminoInternacional = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.grpFecha = New System.Windows.Forms.GroupBox
        Me.rbtnRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnDespacho = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.txtClient = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroPaletizado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroPaletizado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUbicacionReferencial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.bgwExportarData = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.grpFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgBultos)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1098, 587)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgBultos
        '
        Me.dgBultos.BackColor = System.Drawing.Color.Transparent
        Me.dgBultos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBultos.Location = New System.Drawing.Point(0, 189)
        Me.dgBultos.Name = "dgBultos"
        Me.dgBultos.NroRegPorPagina = 100
        Me.dgBultos.pCCLNT_CodigoCliente = CType(0, Long)
        Me.dgBultos.pMostrarInfCliente = True
        Me.dgBultos.pShowBtnAdjuntarDoc = True
        Me.dgBultos.pShowBtnAgregar = False
        Me.dgBultos.pShowBtnConfirmarLlegada = True
        Me.dgBultos.pShowBtnEditar = False
        Me.dgBultos.pShowBtnEliminar = False
        Me.dgBultos.pShowBtnEtiqueta = False
        Me.dgBultos.pShowBtnExportar = True
        Me.dgBultos.pShowBtnExportarExcel = True
        Me.dgBultos.pShowBtnExportarInventarioExcel = True
        Me.dgBultos.pShowBtnImprimir = True
        Me.dgBultos.pShowBtnInterfase = False
        Me.dgBultos.pShowBtnPaletizar = False
        Me.dgBultos.pShowBtnPreDespacho = False
        Me.dgBultos.pShowBtnRePacking = False
        Me.dgBultos.pShowBtnTraslado = False
        Me.dgBultos.pShowColCheck = False
        Me.dgBultos.pShowColStatusTransf = False
        Me.dgBultos.Size = New System.Drawing.Size(1098, 398)
        Me.dgBultos.TabIndex = 21
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
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbTermInter)
        Me.khgFiltros.Panel.Controls.Add(Me.lblTerminoInternacional)
        Me.khgFiltros.Panel.Controls.Add(Me.grpFecha)
        Me.khgFiltros.Panel.Controls.Add(Me.txtClient)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCriterioLote)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCriterioLote)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroPaletizado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblNroPaletizado)
        Me.khgFiltros.Panel.Controls.Add(Me.lblUbicacionReferencial)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodigoRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCodigoRecepcion)
        Me.khgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(1098, 189)
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
        Me.txtUbicacionReferencial.ListColumnas = Nothing
        Me.txtUbicacionReferencial.Location = New System.Drawing.Point(467, 46)
        Me.txtUbicacionReferencial.Name = "txtUbicacionReferencial"
        Me.txtUbicacionReferencial.Obligatorio = False
        Me.txtUbicacionReferencial.Size = New System.Drawing.Size(248, 23)
        Me.txtUbicacionReferencial.TabIndex = 4
        Me.txtUbicacionReferencial.ValueMember = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(729, 21)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel3.TabIndex = 67
        Me.KryptonLabel3.Text = "Planta : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(782, 20)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(207, 23)
        Me.UcPLanta_Cmb011.TabIndex = 2
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(396, 20)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 65
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(467, 20)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(248, 23)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(1, 21)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Compañia : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(73, 18)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(302, 23)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'cmbTermInter
        '
        Me.cmbTermInter.BackColor = System.Drawing.Color.Transparent
        Me.cmbTermInter.Location = New System.Drawing.Point(467, 122)
        Me.cmbTermInter.Name = "cmbTermInter"
        Me.cmbTermInter.pCategoria = "TERINT"
        Me.cmbTermInter.pIsRequired = False
        Me.cmbTermInter.Size = New System.Drawing.Size(247, 21)
        Me.cmbTermInter.TabIndex = 11
        '
        'lblTerminoInternacional
        '
        Me.lblTerminoInternacional.Location = New System.Drawing.Point(385, 127)
        Me.lblTerminoInternacional.Name = "lblTerminoInternacional"
        Me.lblTerminoInternacional.Size = New System.Drawing.Size(75, 20)
        Me.lblTerminoInternacional.TabIndex = 10
        Me.lblTerminoInternacional.Text = "Térm. Inter.:"
        Me.lblTerminoInternacional.Values.ExtraText = ""
        Me.lblTerminoInternacional.Values.Image = Nothing
        Me.lblTerminoInternacional.Values.Text = "Térm. Inter.:"
        '
        'grpFecha
        '
        Me.grpFecha.BackColor = System.Drawing.Color.Transparent
        Me.grpFecha.Controls.Add(Me.rbtnRecepcion)
        Me.grpFecha.Controls.Add(Me.rbtnDespacho)
        Me.grpFecha.Controls.Add(Me.lblFechaInicial)
        Me.grpFecha.Controls.Add(Me.lblFechaFinal)
        Me.grpFecha.Controls.Add(Me.dteFechaInicial)
        Me.grpFecha.Controls.Add(Me.dteFechaFinal)
        Me.grpFecha.Location = New System.Drawing.Point(10, 92)
        Me.grpFecha.Name = "grpFecha"
        Me.grpFecha.Size = New System.Drawing.Size(365, 59)
        Me.grpFecha.TabIndex = 7
        Me.grpFecha.TabStop = False
        '
        'rbtnRecepcion
        '
        Me.rbtnRecepcion.Checked = True
        Me.rbtnRecepcion.Location = New System.Drawing.Point(6, 13)
        Me.rbtnRecepcion.Name = "rbtnRecepcion"
        Me.rbtnRecepcion.Size = New System.Drawing.Size(79, 20)
        Me.rbtnRecepcion.TabIndex = 0
        Me.rbtnRecepcion.Text = "Recepción"
        Me.rbtnRecepcion.Values.ExtraText = ""
        Me.rbtnRecepcion.Values.Image = Nothing
        Me.rbtnRecepcion.Values.Text = "Recepción"
        '
        'rbtnDespacho
        '
        Me.rbtnDespacho.Location = New System.Drawing.Point(88, 13)
        Me.rbtnDespacho.Name = "rbtnDespacho"
        Me.rbtnDespacho.Size = New System.Drawing.Size(76, 20)
        Me.rbtnDespacho.TabIndex = 1
        Me.rbtnDespacho.Text = "Despacho"
        Me.rbtnDespacho.Values.ExtraText = ""
        Me.rbtnDespacho.Values.Image = Nothing
        Me.rbtnDespacho.Values.Text = "Despacho"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(6, 38)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(71, 20)
        Me.lblFechaInicial.TabIndex = 2
        Me.lblFechaInicial.Text = "Fch. Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fch. Inicio : "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(180, 38)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(67, 20)
        Me.lblFechaFinal.TabIndex = 4
        Me.lblFechaFinal.Text = "Fch. Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fch. Final : "
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(80, 34)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInicial.TabIndex = 3
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(252, 34)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaFinal.TabIndex = 5
        '
        'txtClient
        '
        Me.txtClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClient.BackColor = System.Drawing.Color.Transparent
        Me.txtClient.Location = New System.Drawing.Point(73, 47)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.pAccesoPorUsuario = True
        Me.txtClient.pRequerido = True
        Me.txtClient.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClient.Size = New System.Drawing.Size(302, 22)
        Me.txtClient.TabIndex = 3
        '
        'txtCriterioLote
        '
        Me.txtCriterioLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterioLote.Location = New System.Drawing.Point(467, 97)
        Me.txtCriterioLote.MaxLength = 100
        Me.txtCriterioLote.Name = "txtCriterioLote"
        Me.txtCriterioLote.Size = New System.Drawing.Size(247, 22)
        Me.txtCriterioLote.TabIndex = 9
        Me.TypeValidator.SetTypes(Me.txtCriterioLote, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblCriterioLote
        '
        Me.lblCriterioLote.Location = New System.Drawing.Point(385, 100)
        Me.lblCriterioLote.Name = "lblCriterioLote"
        Me.lblCriterioLote.Size = New System.Drawing.Size(84, 20)
        Me.lblCriterioLote.TabIndex = 8
        Me.lblCriterioLote.Text = "Criterio Lote : "
        Me.lblCriterioLote.Values.ExtraText = ""
        Me.lblCriterioLote.Values.Image = Nothing
        Me.lblCriterioLote.Values.Text = "Criterio Lote : "
        '
        'txtNroPaletizado
        '
        Me.txtNroPaletizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroPaletizado.Location = New System.Drawing.Point(467, 72)
        Me.txtNroPaletizado.MaxLength = 100
        Me.txtNroPaletizado.Name = "txtNroPaletizado"
        Me.txtNroPaletizado.Size = New System.Drawing.Size(247, 22)
        Me.txtNroPaletizado.TabIndex = 6
        Me.TypeValidator.SetTypes(Me.txtNroPaletizado, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblNroPaletizado
        '
        Me.lblNroPaletizado.Location = New System.Drawing.Point(385, 75)
        Me.lblNroPaletizado.Name = "lblNroPaletizado"
        Me.lblNroPaletizado.Size = New System.Drawing.Size(73, 20)
        Me.lblNroPaletizado.TabIndex = 15
        Me.lblNroPaletizado.Text = "Paletizado : "
        Me.lblNroPaletizado.Values.ExtraText = ""
        Me.lblNroPaletizado.Values.Image = Nothing
        Me.lblNroPaletizado.Values.Text = "Paletizado : "
        '
        'lblUbicacionReferencial
        '
        Me.lblUbicacionReferencial.Location = New System.Drawing.Point(385, 50)
        Me.lblUbicacionReferencial.Name = "lblUbicacionReferencial"
        Me.lblUbicacionReferencial.Size = New System.Drawing.Size(70, 20)
        Me.lblUbicacionReferencial.TabIndex = 13
        Me.lblUbicacionReferencial.Text = "Ubicación : "
        Me.lblUbicacionReferencial.Values.ExtraText = ""
        Me.lblUbicacionReferencial.Values.Image = Nothing
        Me.lblUbicacionReferencial.Values.Text = "Ubicación : "
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(1017, 13)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'txtCodigoRecepcion
        '
        Me.txtCodigoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoRecepcion.Location = New System.Drawing.Point(73, 72)
        Me.txtCodigoRecepcion.MaxLength = 100
        Me.txtCodigoRecepcion.Name = "txtCodigoRecepcion"
        Me.txtCodigoRecepcion.Size = New System.Drawing.Size(302, 22)
        Me.txtCodigoRecepcion.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtCodigoRecepcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblCodigoRecepcion
        '
        Me.lblCodigoRecepcion.Location = New System.Drawing.Point(6, 75)
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
        Me.lblCliente.Location = New System.Drawing.Point(6, 50)
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
        Me.KryptonLabel5.Location = New System.Drawing.Point(721, -1)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 157)
        Me.KryptonLabel5.TabIndex = 34
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'frmInterfaseSAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 587)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmInterfaseSAP"
        Me.Text = "Interfase"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.grpFecha.ResumeLayout(False)
        Me.grpFecha.PerformLayout()
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
    Friend WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtClient As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNroPaletizado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroPaletizado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUbicacionReferencial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgBultos As Ransa.Controls.WayBill.ucWaybill_DgF01
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents rbtnDespacho As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnRecepcion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents grpFecha As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTermInter As RANSA.Controls.TipoAyuda.ucTipoAyuda_CmbF01
    Private WithEvents lblTerminoInternacional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bgwExportarData As System.ComponentModel.BackgroundWorker
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents txtUbicacionReferencial As RANSA.CONTROL.ucAyuda
End Class
