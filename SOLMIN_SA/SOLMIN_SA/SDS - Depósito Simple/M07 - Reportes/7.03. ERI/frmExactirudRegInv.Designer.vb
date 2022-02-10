<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExactirudRegInv
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExactirudRegInv))
        Dim BePlanta1 As Ransa.TYPEDEF.UbicacionPlanta.Planta.bePlanta = New Ransa.TYPEDEF.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania = New Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAjustarInv = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarXLS = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAdjuntarInvFi = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGenerarInvSistema = New System.Windows.Forms.ToolStripButton
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.dteFechaInvFinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaInvFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInvInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaInvInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAdjuntarInv = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAdjuntarInvFisico = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGenerarInvSistem = New System.Windows.Forms.ToolStripButton
        Me.dgCabInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ccmpn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.crgvta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cplndv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nroeri = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecinvdes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cclnt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stseri = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.steri = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecinv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgDetInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.nrocorrelativo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codmercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mercaderia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stockSistema = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stockFisico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRCERI = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.tsReporte.SuspendLayout()
        CType(Me.dgCabInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
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
        Me.khgFiltros.Panel.Controls.Add(Me.tsReporte)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInvFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInvFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInvInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInvInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(826, 148)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 58
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
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar, Me.ToolStripSeparator4, Me.tsbAjustarInv, Me.ToolStripSeparator5, Me.tsbExportarXLS, Me.ToolStripSeparator6, Me.tsbAdjuntarInvFi, Me.ToolStripSeparator7, Me.tsbGenerarInvSistema})
        Me.tsReporte.Location = New System.Drawing.Point(0, 91)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(824, 26)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 26)
        '
        'tsbAjustarInv
        '
        Me.tsbAjustarInv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAjustarInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAjustarInv.Enabled = False
        Me.tsbAjustarInv.Image = CType(resources.GetObject("tsbAjustarInv.Image"), System.Drawing.Image)
        Me.tsbAjustarInv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAjustarInv.Name = "tsbAjustarInv"
        Me.tsbAjustarInv.Size = New System.Drawing.Size(70, 23)
        Me.tsbAjustarInv.Text = "Ajustar Inv."
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 26)
        '
        'tsbAdjuntarInvFi
        '
        Me.tsbAdjuntarInvFi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAdjuntarInvFi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAdjuntarInvFi.Enabled = False
        Me.tsbAdjuntarInvFi.Image = Global.SOLMIN_SA.My.Resources.Resources.ico_impresora
        Me.tsbAdjuntarInvFi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAdjuntarInvFi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdjuntarInvFi.Name = "tsbAdjuntarInvFi"
        Me.tsbAdjuntarInvFi.Size = New System.Drawing.Size(112, 23)
        Me.tsbAdjuntarInvFi.Text = "Adjuntar Inv. Fisico"
        Me.tsbAdjuntarInvFi.ToolTipText = "Adjuntar Inv. Fisico"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 26)
        '
        'tsbGenerarInvSistema
        '
        Me.tsbGenerarInvSistema.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarInvSistema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGenerarInvSistema.Image = CType(resources.GetObject("tsbGenerarInvSistema.Image"), System.Drawing.Image)
        Me.tsbGenerarInvSistema.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarInvSistema.Name = "tsbGenerarInvSistema"
        Me.tsbGenerarInvSistema.Size = New System.Drawing.Size(118, 23)
        Me.tsbGenerarInvSistema.Text = "Generar Inv. Sistema"
        Me.tsbGenerarInvSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(486, 16)
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
        Me.UcPLanta_Cmb011.TabIndex = 79
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'dteFechaInvFinal
        '
        Me.dteFechaInvFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInvFinal.Location = New System.Drawing.Point(408, 67)
        Me.dteFechaInvFinal.Name = "dteFechaInvFinal"
        Me.dteFechaInvFinal.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInvFinal.TabIndex = 77
        '
        'lblFechaInvFinal
        '
        Me.lblFechaInvFinal.Location = New System.Drawing.Point(297, 67)
        Me.lblFechaInvFinal.Name = "lblFechaInvFinal"
        Me.lblFechaInvFinal.Size = New System.Drawing.Size(90, 20)
        Me.lblFechaInvFinal.TabIndex = 76
        Me.lblFechaInvFinal.Text = "Fecha Inv. Fin : "
        Me.lblFechaInvFinal.Values.ExtraText = ""
        Me.lblFechaInvFinal.Values.Image = Nothing
        Me.lblFechaInvFinal.Values.Text = "Fecha Inv. Fin : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(90, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel3.TabIndex = 74
        Me.KryptonLabel3.Text = "Cliente : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(150, 43)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(528, 22)
        Me.txtCliente.TabIndex = 73
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(150, 15)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(252, 31)
        Me.UcCompania_Cmb011.TabIndex = 72
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(430, 19)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel1.TabIndex = 69
        Me.KryptonLabel1.Text = "Planta : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Planta : "
        '
        'dteFechaInvInicial
        '
        Me.dteFechaInvInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInvInicial.Location = New System.Drawing.Point(150, 68)
        Me.dteFechaInvInicial.Name = "dteFechaInvInicial"
        Me.dteFechaInvInicial.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInvInicial.TabIndex = 1
        Me.dteFechaInvInicial.Value = New Date(2015, 7, 15, 17, 47, 47, 0)
        '
        'lblFechaInvInicial
        '
        Me.lblFechaInvInicial.Location = New System.Drawing.Point(39, 69)
        Me.lblFechaInvInicial.Name = "lblFechaInvInicial"
        Me.lblFechaInvInicial.Size = New System.Drawing.Size(105, 20)
        Me.lblFechaInvInicial.TabIndex = 65
        Me.lblFechaInvInicial.Text = "Fecha Inv. Inicial : "
        Me.lblFechaInvInicial.Values.ExtraText = ""
        Me.lblFechaInvInicial.Values.Image = Nothing
        Me.lblFechaInvInicial.Values.Text = "Fecha Inv. Inicial : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(72, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Compañía : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañía : "
        '
        'tsbGenerarReporte
        '
        Me.tsbGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarReporte.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarReporte.Name = "tsbGenerarReporte"
        Me.tsbGenerarReporte.Size = New System.Drawing.Size(62, 23)
        Me.tsbGenerarReporte.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'tsbAdjuntarInv
        '
        Me.tsbAdjuntarInv.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAdjuntarInv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAdjuntarInv.Image = CType(resources.GetObject("tsbAdjuntarInv.Image"), System.Drawing.Image)
        Me.tsbAdjuntarInv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdjuntarInv.Name = "tsbAdjuntarInv"
        Me.tsbAdjuntarInv.Size = New System.Drawing.Size(79, 23)
        Me.tsbAdjuntarInv.Text = "Adjuntar Inv."
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 26)
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(102, 23)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'tsbAdjuntarInvFisico
        '
        Me.tsbAdjuntarInvFisico.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAdjuntarInvFisico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAdjuntarInvFisico.Enabled = False
        Me.tsbAdjuntarInvFisico.Image = Global.SOLMIN_SA.My.Resources.Resources.ico_impresora
        Me.tsbAdjuntarInvFisico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAdjuntarInvFisico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdjuntarInvFisico.Name = "tsbAdjuntarInvFisico"
        Me.tsbAdjuntarInvFisico.Size = New System.Drawing.Size(112, 23)
        Me.tsbAdjuntarInvFisico.Text = "Adjuntar Inv. Fisico"
        Me.tsbAdjuntarInvFisico.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'tsbGenerarInvSistem
        '
        Me.tsbGenerarInvSistem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarInvSistem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGenerarInvSistem.Enabled = False
        Me.tsbGenerarInvSistem.Image = CType(resources.GetObject("tsbGenerarInvSistem.Image"), System.Drawing.Image)
        Me.tsbGenerarInvSistem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarInvSistem.Name = "tsbGenerarInvSistem"
        Me.tsbGenerarInvSistem.Size = New System.Drawing.Size(118, 23)
        Me.tsbGenerarInvSistem.Text = "Generar Inv. Sistema"
        Me.tsbGenerarInvSistem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'dgCabInventario
        '
        Me.dgCabInventario.AllowUserToAddRows = False
        Me.dgCabInventario.AllowUserToDeleteRows = False
        Me.dgCabInventario.AllowUserToResizeColumns = False
        Me.dgCabInventario.AllowUserToResizeRows = False
        Me.dgCabInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCabInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccmpn, Me.crgvta, Me.cplndv, Me.nroeri, Me.fecinvdes, Me.cclnt, Me.TCMPCL, Me.stseri, Me.steri, Me.fecinv})
        Me.dgCabInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCabInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgCabInventario.Location = New System.Drawing.Point(0, 0)
        Me.dgCabInventario.MultiSelect = False
        Me.dgCabInventario.Name = "dgCabInventario"
        Me.dgCabInventario.ReadOnly = True
        Me.dgCabInventario.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCabInventario.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCabInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCabInventario.Size = New System.Drawing.Size(826, 171)
        Me.dgCabInventario.StandardTab = True
        Me.dgCabInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgCabInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgCabInventario.TabIndex = 69
        '
        'ccmpn
        '
        Me.ccmpn.HeaderText = "campania"
        Me.ccmpn.Name = "ccmpn"
        Me.ccmpn.ReadOnly = True
        Me.ccmpn.Visible = False
        Me.ccmpn.Width = 88
        '
        'crgvta
        '
        Me.crgvta.HeaderText = "negocio"
        Me.crgvta.Name = "crgvta"
        Me.crgvta.ReadOnly = True
        Me.crgvta.Visible = False
        Me.crgvta.Width = 79
        '
        'cplndv
        '
        Me.cplndv.HeaderText = "Planta"
        Me.cplndv.Name = "cplndv"
        Me.cplndv.ReadOnly = True
        Me.cplndv.Visible = False
        Me.cplndv.Width = 69
        '
        'nroeri
        '
        Me.nroeri.DataPropertyName = "nroeri"
        Me.nroeri.HeaderText = "Nro. Doc. ERI"
        Me.nroeri.Name = "nroeri"
        Me.nroeri.ReadOnly = True
        Me.nroeri.Width = 105
        '
        'fecinvdes
        '
        Me.fecinvdes.HeaderText = "Fecha Inv."
        Me.fecinvdes.Name = "fecinvdes"
        Me.fecinvdes.ReadOnly = True
        Me.fecinvdes.Width = 89
        '
        'cclnt
        '
        Me.cclnt.DataPropertyName = "cclnt"
        Me.cclnt.HeaderText = "Cod. Cliente"
        Me.cclnt.Name = "cclnt"
        Me.cclnt.ReadOnly = True
        Me.cclnt.Width = 101
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMPCL.DataPropertyName = "tcmpcl"
        Me.TCMPCL.HeaderText = "Razón Social"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        '
        'stseri
        '
        Me.stseri.DataPropertyName = "STSERI"
        Me.stseri.HeaderText = "cod. estado eri"
        Me.stseri.Name = "stseri"
        Me.stseri.ReadOnly = True
        Me.stseri.Visible = False
        Me.stseri.Width = 113
        '
        'steri
        '
        Me.steri.DataPropertyName = "tdsdes"
        Me.steri.HeaderText = "Estado ERI"
        Me.steri.Name = "steri"
        Me.steri.ReadOnly = True
        Me.steri.Width = 90
        '
        'fecinv
        '
        Me.fecinv.DataPropertyName = "fecinv"
        Me.fecinv.HeaderText = "fecinv"
        Me.fecinv.Name = "fecinv"
        Me.fecinv.ReadOnly = True
        Me.fecinv.Visible = False
        Me.fecinv.Width = 68
        '
        'dgDetInventario
        '
        Me.dgDetInventario.AllowUserToAddRows = False
        Me.dgDetInventario.AllowUserToDeleteRows = False
        Me.dgDetInventario.AllowUserToResizeColumns = False
        Me.dgDetInventario.AllowUserToResizeRows = False
        Me.dgDetInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDetInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nrocorrelativo, Me.codmercaderia, Me.mercaderia, Me.stockSistema, Me.stockFisico, Me.CUNCN5, Me.PRCERI})
        Me.dgDetInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDetInventario.Location = New System.Drawing.Point(0, 0)
        Me.dgDetInventario.MultiSelect = False
        Me.dgDetInventario.Name = "dgDetInventario"
        Me.dgDetInventario.ReadOnly = True
        Me.dgDetInventario.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetInventario.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDetInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetInventario.Size = New System.Drawing.Size(826, 163)
        Me.dgDetInventario.StandardTab = True
        Me.dgDetInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDetInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDetInventario.TabIndex = 70
        '
        'nrocorrelativo
        '
        Me.nrocorrelativo.HeaderText = "Nro. Correlativo"
        Me.nrocorrelativo.Name = "nrocorrelativo"
        Me.nrocorrelativo.ReadOnly = True
        Me.nrocorrelativo.Width = 120
        '
        'codmercaderia
        '
        Me.codmercaderia.DataPropertyName = "CMRCLR"
        Me.codmercaderia.HeaderText = "Cod. Mercadería"
        Me.codmercaderia.Name = "codmercaderia"
        Me.codmercaderia.ReadOnly = True
        Me.codmercaderia.Width = 123
        '
        'mercaderia
        '
        Me.mercaderia.DataPropertyName = "TMRCD2"
        Me.mercaderia.HeaderText = "Mercadería"
        Me.mercaderia.Name = "mercaderia"
        Me.mercaderia.ReadOnly = True
        Me.mercaderia.Width = 95
        '
        'stockSistema
        '
        Me.stockSistema.DataPropertyName = "QSLMC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0.000"
        Me.stockSistema.DefaultCellStyle = DataGridViewCellStyle2
        Me.stockSistema.HeaderText = "Stock Sistema"
        Me.stockSistema.Name = "stockSistema"
        Me.stockSistema.ReadOnly = True
        Me.stockSistema.Width = 109
        '
        'stockFisico
        '
        Me.stockFisico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.stockFisico.DataPropertyName = "QSFMC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = "0.000"
        Me.stockFisico.DefaultCellStyle = DataGridViewCellStyle3
        Me.stockFisico.HeaderText = "Stock Fisico"
        Me.stockFisico.Name = "stockFisico"
        Me.stockFisico.ReadOnly = True
        Me.stockFisico.Width = 98
        '
        'CUNCN5
        '
        Me.CUNCN5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CUNCN5.DataPropertyName = "CUNCN5"
        Me.CUNCN5.HeaderText = "Unidad Medida"
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.ReadOnly = True
        Me.CUNCN5.Width = 117
        '
        'PRCERI
        '
        Me.PRCERI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PRCERI.DataPropertyName = "PRCERI"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = "0.000"
        Me.PRCERI.DefaultCellStyle = DataGridViewCellStyle4
        Me.PRCERI.HeaderText = "Porcentaje ERI"
        Me.PRCERI.Name = "PRCERI"
        Me.PRCERI.ReadOnly = True
        Me.PRCERI.Width = 111
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NROERI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Doc. ERI"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 105
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FECINV"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Inv."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 89
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 101
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "STSERI"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado ERI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nrocorrelativo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nro. Correlativo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "codmercaderia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cod. Mercadería"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "mercaderia"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 95
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "stockSistema"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Stock Sistema"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 109
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "stockFisico"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Stock Fisico"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CMRCLR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unidad Media"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 110
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TMRCD2"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Porcentaje ERI"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 111
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "QSLMC"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Stock Sistema"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 109
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "QSFMC"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Stock Fisico"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Unidad Media"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 110
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Porcentaje ERI"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 111
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 148)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgCabInventario)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgDetInventario)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(826, 339)
        Me.KryptonSplitContainer1.SplitterDistance = 171
        Me.KryptonSplitContainer1.TabIndex = 72
        '
        'frmExactirudRegInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 487)
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.khgFiltros)
        Me.Name = "frmExactirudRegInv"
        Me.Text = "Exactitud Reg. Inventario"
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.dgCabInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents UcCompania_Cmb011 As RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInvInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInvInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInvFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInvFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAdjuntarInvFisico As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGenerarInvSistem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAdjuntarInv As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgCabInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgDetInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAjustarInv As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarXLS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAdjuntarInvFi As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGenerarInvSistema As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ccmpn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crgvta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cplndv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nroeri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecinvdes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cclnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stseri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents steri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecinv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nrocorrelativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codmercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mercaderia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stockSistema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stockFisico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRCERI As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
