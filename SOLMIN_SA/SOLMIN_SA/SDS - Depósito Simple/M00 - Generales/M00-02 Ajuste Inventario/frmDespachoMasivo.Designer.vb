<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespachoMasivo
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
        Dim BePlanta4 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnDespacho = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtZonaAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaFamiliaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtGrupo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaGrupoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.btnchk = New System.Windows.Forms.ToolStripButton()
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QSLMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QSLMC2_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPDP6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QSLMP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgMercaderias)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.Panel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1427, 492)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgMercaderias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.CMRCLR, Me.TMRCD2, Me.QSLMC2, Me.QSLMC2_D, Me.CUNCN5, Me.NORDSR, Me.CFMCLR, Me.TFMCLR, Me.CGRCLR, Me.TGRCLR, Me.CTPALM, Me.CALMC, Me.CZNALM, Me.UBICA1, Me.SITUAC, Me.Column1, Me.CCLNT, Me.NCNTR, Me.NCRCTC, Me.NAUTR, Me.CUNPS5, Me.CUNVL5, Me.FUNDS2, Me.CTPDP6, Me.QSLMP2, Me.CMRCD})
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(0, 167)
        Me.dgMercaderias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.Size = New System.Drawing.Size(1427, 325)
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnDespacho, Me.btnExportar, Me.btnchk})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 140)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1427, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnDespacho
        '
        Me.btnDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDespacho.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDespacho.Name = "btnDespacho"
        Me.btnDespacho.Size = New System.Drawing.Size(99, 24)
        Me.btnDespacho.Text = "Despacho"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.txtZonaAlmacen)
        Me.Panel1.Controls.Add(Me.txtTipoAlmacen)
        Me.Panel1.Controls.Add(Me.txtAlmacen)
        Me.Panel1.Controls.Add(Me.lblZonaAlmacen)
        Me.Panel1.Controls.Add(Me.lblAlmacen)
        Me.Panel1.Controls.Add(Me.lblTipoAlmacen)
        Me.Panel1.Controls.Add(Me.txtFamilia)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.txtGrupo)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.KryptonLabel13)
        Me.Panel1.Controls.Add(Me.UcPLanta_Cmb011)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1427, 140)
        Me.Panel1.TabIndex = 1
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.BackColor = System.Drawing.Color.White
        Me.txtZonaAlmacen.DataSource = Nothing
        Me.txtZonaAlmacen.DispleyMember = ""
        Me.txtZonaAlmacen.Etiquetas_Form = Nothing
        Me.txtZonaAlmacen.ListColumnas = Nothing
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(747, 98)
        Me.txtZonaAlmacen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Obligatorio = True
        Me.txtZonaAlmacen.PopupHeight = 0
        Me.txtZonaAlmacen.PopupWidth = 0
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(193, 31)
        Me.txtZonaAlmacen.SizeFont = 0
        Me.txtZonaAlmacen.TabIndex = 118
        Me.txtZonaAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.Etiquetas_Form = Nothing
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(109, 98)
        Me.txtTipoAlmacen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(212, 26)
        Me.txtTipoAlmacen.SizeFont = 0
        Me.txtTipoAlmacen.TabIndex = 116
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.Etiquetas_Form = Nothing
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(436, 100)
        Me.txtAlmacen.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = True
        Me.txtAlmacen.PopupHeight = 0
        Me.txtAlmacen.PopupWidth = 0
        Me.txtAlmacen.Size = New System.Drawing.Size(219, 31)
        Me.txtAlmacen.SizeFont = 0
        Me.txtAlmacen.TabIndex = 117
        Me.txtAlmacen.ValueMember = ""
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(680, 100)
        Me.lblZonaAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(54, 24)
        Me.lblZonaAlmacen.TabIndex = 121
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(355, 101)
        Me.lblAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(78, 24)
        Me.lblAlmacen.TabIndex = 120
        Me.lblAlmacen.Text = "Almacén : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacén : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(36, 101)
        Me.lblTipoAlmacen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(49, 24)
        Me.lblTipoAlmacen.TabIndex = 119
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'txtFamilia
        '
        Me.txtFamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaFamiliaListar})
        Me.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFamilia.Location = New System.Drawing.Point(109, 53)
        Me.txtFamilia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(371, 26)
        Me.txtFamilia.TabIndex = 115
        '
        'bsaFamiliaListar
        '
        Me.bsaFamiliaListar.ExtraText = ""
        Me.bsaFamiliaListar.Image = Nothing
        Me.bsaFamiliaListar.Text = ""
        Me.bsaFamiliaListar.ToolTipImage = Nothing
        Me.bsaFamiliaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaFamiliaListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(36, 55)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(67, 24)
        Me.KryptonLabel3.TabIndex = 114
        Me.KryptonLabel3.Text = "Familia : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Familia : "
        '
        'txtGrupo
        '
        Me.txtGrupo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaGrupoListar})
        Me.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupo.Location = New System.Drawing.Point(568, 53)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGrupo.MaxLength = 30
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(371, 26)
        Me.txtGrupo.TabIndex = 113
        '
        'bsaGrupoListar
        '
        Me.bsaGrupoListar.ExtraText = ""
        Me.bsaGrupoListar.Image = Nothing
        Me.bsaGrupoListar.Text = ""
        Me.bsaGrupoListar.ToolTipImage = Nothing
        Me.bsaGrupoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaGrupoListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(488, 55)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(62, 24)
        Me.KryptonLabel6.TabIndex = 112
        Me.KryptonLabel6.Text = "Grupo : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Grupo : "
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(488, 9)
        Me.KryptonLabel13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel13.TabIndex = 111
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
        Me.UcPLanta_Cmb011.CodSedeSAP = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(568, 5)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta4.CCMPN_CodigoCompania = ""
        BePlanta4.CDSPSP_CodSedeSAP = Nothing
        BePlanta4.CDVSN_CodigoDivision = ""
        BePlanta4.CPLNDV_CodigoPlanta = 0.0R
        BePlanta4.Orden = -1
        BePlanta4.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta4
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0.0R
        Me.UcPLanta_Cmb011.PlantaDefault = -1.0R
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(205, 28)
        Me.UcPLanta_Cmb011.TabIndex = 110
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(109, 6)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(371, 26)
        Me.txtCliente.TabIndex = 109
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(36, 9)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 24)
        Me.KryptonLabel1.TabIndex = 108
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'btnchk
        '
        Me.btnchk.Image = Global.SOLMIN_SA.My.Resources.Resources.confirmacion_1
        Me.btnchk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnchk.Name = "btnchk"
        Me.btnchk.Size = New System.Drawing.Size(57, 24)
        Me.btnchk.Text = "Chk"
        '
        'CHK
        '
        Me.CHK.HeaderText = "Sel"
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CMRCLR
        '
        Me.CMRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMRCLR.DataPropertyName = "CMRCLR"
        Me.CMRCLR.HeaderText = "Cod. Mercadería"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        Me.CMRCLR.Width = 151
        '
        'TMRCD2
        '
        Me.TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Descripción"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        Me.TMRCD2.Width = 120
        '
        'QSLMC2
        '
        Me.QSLMC2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QSLMC2.DataPropertyName = "QSLMC2"
        Me.QSLMC2.HeaderText = "Cantidad"
        Me.QSLMC2.Name = "QSLMC2"
        Me.QSLMC2.ReadOnly = True
        Me.QSLMC2.Width = 102
        '
        'QSLMC2_D
        '
        Me.QSLMC2_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QSLMC2_D.DataPropertyName = "QSLMC2"
        Me.QSLMC2_D.HeaderText = "Despachar"
        Me.QSLMC2_D.Name = "QSLMC2_D"
        Me.QSLMC2_D.Visible = False
        Me.QSLMC2_D.Width = 112
        '
        'CUNCN5
        '
        Me.CUNCN5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNCN5.DataPropertyName = "CUNCN5"
        Me.CUNCN5.HeaderText = "Unidad Medida"
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.ReadOnly = True
        Me.CUNCN5.Width = 145
        '
        'NORDSR
        '
        Me.NORDSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "Orden Servicio"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        Me.NORDSR.Width = 139
        '
        'CFMCLR
        '
        Me.CFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CFMCLR.DataPropertyName = "CFMCLR"
        Me.CFMCLR.HeaderText = "Cod. Familia"
        Me.CFMCLR.Name = "CFMCLR"
        Me.CFMCLR.ReadOnly = True
        Me.CFMCLR.Width = 123
        '
        'TFMCLR
        '
        Me.TFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TFMCLR.DataPropertyName = "TFMCLR"
        Me.TFMCLR.HeaderText = "Familia"
        Me.TFMCLR.Name = "TFMCLR"
        Me.TFMCLR.ReadOnly = True
        Me.TFMCLR.Width = 89
        '
        'CGRCLR
        '
        Me.CGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGRCLR.DataPropertyName = "CGRCLR"
        Me.CGRCLR.HeaderText = "Cod. Grupo"
        Me.CGRCLR.Name = "CGRCLR"
        Me.CGRCLR.ReadOnly = True
        Me.CGRCLR.Width = 117
        '
        'TGRCLR
        '
        Me.TGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TGRCLR.DataPropertyName = "TGRCLR"
        Me.TGRCLR.HeaderText = "Grupo"
        Me.TGRCLR.Name = "TGRCLR"
        Me.TGRCLR.ReadOnly = True
        Me.TGRCLR.Width = 83
        '
        'CTPALM
        '
        Me.CTPALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTPALM.DataPropertyName = "CTPALM"
        Me.CTPALM.HeaderText = "Tipo Almacén"
        Me.CTPALM.Name = "CTPALM"
        Me.CTPALM.ReadOnly = True
        Me.CTPALM.Width = 134
        '
        'CALMC
        '
        Me.CALMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CALMC.DataPropertyName = "CALMC"
        Me.CALMC.HeaderText = "Almacén"
        Me.CALMC.Name = "CALMC"
        Me.CALMC.ReadOnly = True
        '
        'CZNALM
        '
        Me.CZNALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CZNALM.DataPropertyName = "CZNALM"
        Me.CZNALM.HeaderText = "Zona"
        Me.CZNALM.Name = "CZNALM"
        Me.CZNALM.ReadOnly = True
        Me.CZNALM.Width = 76
        '
        'UBICA1
        '
        Me.UBICA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBICA1.DataPropertyName = "UBICA1"
        Me.UBICA1.HeaderText = "Ref. Ubicación"
        Me.UBICA1.Name = "UBICA1"
        Me.UBICA1.ReadOnly = True
        Me.UBICA1.Visible = False
        Me.UBICA1.Width = 137
        '
        'SITUAC
        '
        Me.SITUAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SITUAC.DataPropertyName = "SITUAC"
        Me.SITUAC.HeaderText = "Situación"
        Me.SITUAC.Name = "SITUAC"
        Me.SITUAC.ReadOnly = True
        Me.SITUAC.Width = 103
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'NCNTR
        '
        Me.NCNTR.DataPropertyName = "NCNTR"
        Me.NCNTR.HeaderText = "NCNTR"
        Me.NCNTR.Name = "NCNTR"
        Me.NCNTR.ReadOnly = True
        Me.NCNTR.Visible = False
        '
        'NCRCTC
        '
        Me.NCRCTC.DataPropertyName = "NCRCTC"
        Me.NCRCTC.HeaderText = "NCRCTC"
        Me.NCRCTC.Name = "NCRCTC"
        Me.NCRCTC.ReadOnly = True
        Me.NCRCTC.Visible = False
        '
        'NAUTR
        '
        Me.NAUTR.DataPropertyName = "NAUTR"
        Me.NAUTR.HeaderText = "NAUTR"
        Me.NAUTR.Name = "NAUTR"
        Me.NAUTR.ReadOnly = True
        Me.NAUTR.Visible = False
        '
        'CUNPS5
        '
        Me.CUNPS5.DataPropertyName = "CUNPS5"
        Me.CUNPS5.HeaderText = "CUNPS5"
        Me.CUNPS5.Name = "CUNPS5"
        Me.CUNPS5.ReadOnly = True
        Me.CUNPS5.Visible = False
        '
        'CUNVL5
        '
        Me.CUNVL5.DataPropertyName = "CUNVL5"
        Me.CUNVL5.HeaderText = "CUNVL5"
        Me.CUNVL5.Name = "CUNVL5"
        Me.CUNVL5.ReadOnly = True
        Me.CUNVL5.Visible = False
        '
        'FUNDS2
        '
        Me.FUNDS2.DataPropertyName = "FUNDS2"
        Me.FUNDS2.HeaderText = "FUNDS2"
        Me.FUNDS2.Name = "FUNDS2"
        Me.FUNDS2.ReadOnly = True
        Me.FUNDS2.Visible = False
        '
        'CTPDP6
        '
        Me.CTPDP6.DataPropertyName = "CTPDP6"
        Me.CTPDP6.HeaderText = "CTPDP6"
        Me.CTPDP6.Name = "CTPDP6"
        Me.CTPDP6.ReadOnly = True
        Me.CTPDP6.Visible = False
        '
        'QSLMP2
        '
        Me.QSLMP2.DataPropertyName = "QSLMP2"
        Me.QSLMP2.HeaderText = "QSLMP2"
        Me.QSLMP2.Name = "QSLMP2"
        Me.QSLMP2.ReadOnly = True
        Me.QSLMP2.Visible = False
        '
        'CMRCD
        '
        Me.CMRCD.DataPropertyName = "CMRCD"
        Me.CMRCD.HeaderText = "CMRCD"
        Me.CMRCD.Name = "CMRCD"
        Me.CMRCD.ReadOnly = True
        Me.CMRCD.Visible = False
        '
        'frmDespachoMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 492)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDespachoMasivo"
        Me.Text = "Despacho masivo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtZonaAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFamilia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaFamiliaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGrupo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaGrupoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnchk As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC2_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPDP6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
