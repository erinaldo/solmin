<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOcupabilidadInventario
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim BePlanta1 As Ransa.TYPEDEF.UbicacionPlanta.Planta.bePlanta = New Ransa.TYPEDEF.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania = New Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cboMes = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarXLS = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgDisInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UBICACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UBICACIONES_O = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISINVEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.tsReporte.SuspendLayout()
        CType(Me.dgDisInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.cboMes)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.khgFiltros.Panel.Controls.Add(Me.txtAnio)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.khgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.tsReporte)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(1241, 140)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 60
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
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.DropDownWidth = 117
        Me.cboMes.FormattingEnabled = False
        Me.cboMes.ItemHeight = 15
        Me.cboMes.Location = New System.Drawing.Point(840, 45)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(117, 23)
        Me.cboMes.TabIndex = 26
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(795, 46)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel7.TabIndex = 111
        Me.KryptonLabel7.Text = "Mes : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Mes : "
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.Location = New System.Drawing.Point(711, 46)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(69, 20)
        Me.txtAnio.TabIndex = 25
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(666, 46)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel6.TabIndex = 109
        Me.KryptonLabel6.Text = "Año : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Año : "
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.Etiquetas_Form = Nothing
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(403, 45)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = False
        Me.txtAlmacen.PopupHeight = 0
        Me.txtAlmacen.PopupWidth = 0
        Me.txtAlmacen.Size = New System.Drawing.Size(243, 23)
        Me.txtAlmacen.TabIndex = 24
        Me.txtAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.Etiquetas_Form = Nothing
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(105, 45)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(226, 23)
        Me.txtTipoAlmacen.TabIndex = 23
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 45)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel3.TabIndex = 103
        Me.KryptonLabel3.Text = "Tipo Almacen : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo Almacen : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(337, 45)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel5.TabIndex = 104
        Me.KryptonLabel5.Text = "Almacen : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Almacen : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(403, 15)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(243, 23)
        Me.UcDivision_Cmb011.TabIndex = 21
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(340, 18)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 81
        Me.KryptonLabel2.Text = "División : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "División : "
        '
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.ToolStripSeparator5, Me.tsbExportarXLS, Me.ToolStripSeparator7})
        Me.tsReporte.Location = New System.Drawing.Point(0, 83)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1239, 26)
        Me.tsReporte.TabIndex = 80
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(62, 23)
        Me.tsbBuscar.Text = "Buscar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 26)
        '
        'tsbExportarXLS
        '
        Me.tsbExportarXLS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarXLS.Enabled = False
        Me.tsbExportarXLS.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarXLS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarXLS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarXLS.Name = "tsbExportarXLS"
        Me.tsbExportarXLS.Size = New System.Drawing.Size(73, 23)
        Me.tsbExportarXLS.Text = "Exportar"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 26)
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(711, 13)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(192, 23)
        Me.UcPLanta_Cmb011.TabIndex = 22
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(105, 16)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(226, 31)
        Me.UcCompania_Cmb011.TabIndex = 20
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(655, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel1.TabIndex = 69
        Me.KryptonLabel1.Text = "Planta : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Planta : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(27, 16)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Compañía : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañía : "
        '
        'dgDisInventario
        '
        Me.dgDisInventario.AllowUserToAddRows = False
        Me.dgDisInventario.AllowUserToDeleteRows = False
        Me.dgDisInventario.AllowUserToResizeColumns = False
        Me.dgDisInventario.AllowUserToResizeRows = False
        Me.dgDisInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDisInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTPALM, Me.TALMC, Me.CALMC, Me.TCMPAL, Me.CZNALM, Me.TCMZNA, Me.UBICACIONES, Me.UBICACIONES_O, Me.DISINVEN})
        Me.dgDisInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDisInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDisInventario.Location = New System.Drawing.Point(0, 140)
        Me.dgDisInventario.MultiSelect = False
        Me.dgDisInventario.Name = "dgDisInventario"
        Me.dgDisInventario.ReadOnly = True
        Me.dgDisInventario.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDisInventario.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDisInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDisInventario.Size = New System.Drawing.Size(1241, 265)
        Me.dgDisInventario.StandardTab = True
        Me.dgDisInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDisInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDisInventario.TabIndex = 71
        '
        'CTPALM
        '
        Me.CTPALM.DataPropertyName = "CTPALM"
        Me.CTPALM.HeaderText = "Cod. Tipo Almacén"
        Me.CTPALM.Name = "CTPALM"
        Me.CTPALM.ReadOnly = True
        Me.CTPALM.Width = 138
        '
        'TALMC
        '
        Me.TALMC.DataPropertyName = "TALMC"
        Me.TALMC.HeaderText = "Descripción tipo Almacén"
        Me.TALMC.Name = "TALMC"
        Me.TALMC.ReadOnly = True
        Me.TALMC.Width = 172
        '
        'CALMC
        '
        Me.CALMC.DataPropertyName = "CALMC"
        Me.CALMC.HeaderText = "Cod. Almacén"
        Me.CALMC.Name = "CALMC"
        Me.CALMC.ReadOnly = True
        Me.CALMC.Width = 111
        '
        'TCMPAL
        '
        Me.TCMPAL.DataPropertyName = "TCMPAL"
        Me.TCMPAL.HeaderText = "Descripción Almacén"
        Me.TCMPAL.Name = "TCMPAL"
        Me.TCMPAL.ReadOnly = True
        Me.TCMPAL.Width = 148
        '
        'CZNALM
        '
        Me.CZNALM.DataPropertyName = "CZNALM"
        Me.CZNALM.HeaderText = "Cod. Zona"
        Me.CZNALM.Name = "CZNALM"
        Me.CZNALM.ReadOnly = True
        Me.CZNALM.Width = 91
        '
        'TCMZNA
        '
        Me.TCMZNA.DataPropertyName = "TCMZNA"
        Me.TCMZNA.HeaderText = "Descripción Zona"
        Me.TCMZNA.Name = "TCMZNA"
        Me.TCMZNA.ReadOnly = True
        Me.TCMZNA.Width = 128
        '
        'UBICACIONES
        '
        Me.UBICACIONES.DataPropertyName = "UBICACIONES"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.UBICACIONES.DefaultCellStyle = DataGridViewCellStyle1
        Me.UBICACIONES.HeaderText = "Total Ubicaciones (A)"
        Me.UBICACIONES.Name = "UBICACIONES"
        Me.UBICACIONES.ReadOnly = True
        Me.UBICACIONES.Width = 149
        '
        'UBICACIONES_O
        '
        Me.UBICACIONES_O.DataPropertyName = "UBICACIONES_O"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.UBICACIONES_O.DefaultCellStyle = DataGridViewCellStyle2
        Me.UBICACIONES_O.HeaderText = "Total Ubicaciones ocupadas (B)"
        Me.UBICACIONES_O.Name = "UBICACIONES_O"
        Me.UBICACIONES_O.ReadOnly = True
        Me.UBICACIONES_O.Width = 202
        '
        'DISINVEN
        '
        Me.DISINVEN.DataPropertyName = "DISINVEN"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.DISINVEN.DefaultCellStyle = DataGridViewCellStyle3
        Me.DISINVEN.HeaderText = "Ocupabilidad de Almacén (B/A)"
        Me.DISINVEN.Name = "DISINVEN"
        Me.DISINVEN.ReadOnly = True
        Me.DISINVEN.Width = 204
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTPALM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Tipo Almacén"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 138
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TALMC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción tipo Almacén"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 172
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CALMC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cod. Almacén"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 111
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCMPAL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción Almacén"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 148
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CZNALM"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cod. Zona"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 91
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCMZNA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción Zona"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 128
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UBICACIONES"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total Ubicaciones (A)"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 149
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UBICACIONES_O"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total Ubicaciones ocupadas (B)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 202
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OCUALMA"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ocupabilidad de Almacén (B/A)"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 204
        '
        'frmOcupabilidadInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 405)
        Me.Controls.Add(Me.dgDisInventario)
        Me.Controls.Add(Me.khgFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmOcupabilidadInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ocupabilidad Inventario"
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.dgDisInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarXLS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoAlmacen As RANSA.Utilitario.ucAyuda
    Friend WithEvents cboMes As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgDisInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICACIONES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICACIONES_O As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISINVEN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
