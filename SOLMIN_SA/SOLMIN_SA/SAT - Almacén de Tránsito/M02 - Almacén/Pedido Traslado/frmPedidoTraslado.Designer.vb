Imports Ransa.Controls.Cliente


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoTraslado
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
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoTraslado))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtNroPedidoTraslado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonAtender = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgCabPedido = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.M_NRPDTS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECPED = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CENSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLTECL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CLDSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDSDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESPRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstCabPedidoTraslado = New System.Data.DataSet
        Me.dtPedidoTraslado = New System.Data.DataTable
        Me.CCLNT = New System.Data.DataColumn
        Me.NRPDTS = New System.Data.DataColumn
        Me.FECPED = New System.Data.DataColumn
        Me.CENSAP = New System.Data.DataColumn
        Me.TLTECL = New System.Data.DataColumn
        Me.CLDSAP = New System.Data.DataColumn
        Me.SESPRC = New System.Data.DataColumn
        Me.TDSDES = New System.Data.DataColumn
        Me.CCMPN = New System.Data.DataColumn
        Me.CDVSN = New System.Data.DataColumn
        Me.CPLNDV = New System.Data.DataColumn
        Me.CHKED = New System.Data.DataColumn
        Me.dgDetInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NROSECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCITCLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNTITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTYPENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNDITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRPDTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVUNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPLINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRFRN1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRFRN2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRFRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstDetPedidoTraslado = New System.Data.DataSet
        Me.dtDetPedidoTraslado = New System.Data.DataTable
        Me.D_CCLNT = New System.Data.DataColumn
        Me.D_NRPDTS = New System.Data.DataColumn
        Me.NROSEC = New System.Data.DataColumn
        Me.TCITCL = New System.Data.DataColumn
        Me.TDITES = New System.Data.DataColumn
        Me.TDITIN = New System.Data.DataColumn
        Me.QCNTIT = New System.Data.DataColumn
        Me.QTYPEN = New System.Data.DataColumn
        Me.TUNDIT = New System.Data.DataColumn
        Me.IVUNIT = New System.Data.DataColumn
        Me.TIPLIN = New System.Data.DataColumn
        Me.TRFRN1 = New System.Data.DataColumn
        Me.TRFRN2 = New System.Data.DataColumn
        Me.TRFRN = New System.Data.DataColumn
        Me.CLARSG = New System.Data.DataColumn
        Me.NROONU = New System.Data.DataColumn
        Me.TPOEMB = New System.Data.DataColumn
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgCabPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstCabPedidoTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPedidoTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstDetPedidoTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDetPedidoTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1, Me.ButtonSpecHeaderGroup2})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.cboEstado)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroPedidoTraslado)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel8)
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel9)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel10)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel11)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel12)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel13)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel14)
        Me.khgFiltros.Panel.Controls.Add(Me.ToolStrip1)
        Me.khgFiltros.Size = New System.Drawing.Size(1027, 148)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 59
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.ButtonSpecHeaderGroup1.Text = "Ocultar"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup1.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.ButtonSpecHeaderGroup2.Text = "Cerrar"
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.ButtonSpecHeaderGroup2.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 129
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 15
        Me.cboEstado.Location = New System.Drawing.Point(514, 61)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(129, 23)
        Me.cboEstado.TabIndex = 113
        '
        'txtNroPedidoTraslado
        '
        Me.txtNroPedidoTraslado.Location = New System.Drawing.Point(142, 61)
        Me.txtNroPedidoTraslado.Name = "txtNroPedidoTraslado"
        Me.txtNroPedidoTraslado.Size = New System.Drawing.Size(153, 22)
        Me.txtNroPedidoTraslado.TabIndex = 112
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(455, 63)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel5.TabIndex = 111
        Me.KryptonLabel5.Text = "Estado : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Estado : "
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(51, 60)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(82, 20)
        Me.KryptonLabel8.TabIndex = 110
        Me.KryptonLabel8.Text = "Nro. Pedido : "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Nro. Pedido : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(514, 7)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(197, 23)
        Me.UcDivision_Cmb011.TabIndex = 106
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(448, 10)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel9.TabIndex = 109
        Me.KryptonLabel9.Text = "División : "
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "División : "
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(781, 7)
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
        Me.UcPLanta_Cmb011.TabIndex = 107
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(725, 10)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel10.TabIndex = 108
        Me.KryptonLabel10.Text = "Planta : "
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Planta : "
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(622, 37)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(89, 20)
        Me.dteFechaFinal.TabIndex = 105
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(599, 37)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(17, 20)
        Me.KryptonLabel11.TabIndex = 104
        Me.KryptonLabel11.Text = "a"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "a"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(79, 33)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel12.TabIndex = 103
        Me.KryptonLabel12.Text = "Cliente : "
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(142, 35)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(306, 22)
        Me.txtCliente.TabIndex = 102
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(142, 7)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(306, 31)
        Me.UcCompania_Cmb011.TabIndex = 101
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(514, 37)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(79, 20)
        Me.dteFechaInicial.TabIndex = 98
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(460, 37)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel13.TabIndex = 100
        Me.KryptonLabel13.Text = "Fecha : "
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Fecha : "
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(61, 7)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel14.TabIndex = 99
        Me.KryptonLabel14.Text = "Compañía : "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Compañía : "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AccessibleDescription = "<"
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButtonAtender, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 92)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1025, 25)
        Me.ToolStrip1.TabIndex = 80
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonAtender
        '
        Me.ToolStripButtonAtender.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButtonAtender.BackColor = System.Drawing.Color.Black
        Me.ToolStripButtonAtender.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonAtender.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButtonAtender.Image = CType(resources.GetObject("ToolStripButtonAtender.Image"), System.Drawing.Image)
        Me.ToolStripButtonAtender.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAtender.Name = "ToolStripButtonAtender"
        Me.ToolStripButtonAtender.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButtonAtender.Text = "Atender"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgCabPedido)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgDetInventario)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1027, 371)
        Me.KryptonSplitContainer1.SplitterDistance = 187
        Me.KryptonSplitContainer1.TabIndex = 73
        '
        'dgCabPedido
        '
        Me.dgCabPedido.AllowUserToAddRows = False
        Me.dgCabPedido.AllowUserToDeleteRows = False
        Me.dgCabPedido.AllowUserToResizeRows = False
        Me.dgCabPedido.AutoGenerateColumns = False
        Me.dgCabPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCabPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHK, Me.M_NRPDTS, Me.M_FECPED, Me.M_CENSAP, Me.M_TLTECL, Me.M_CLDSAP, Me.M_TDSDES, Me.M_CCLNT, Me.M_SESPRC, Me.M_CCMPN, Me.M_CDVSN, Me.M_CPLNDV})
        Me.dgCabPedido.DataMember = "dtPedidoTraslado"
        Me.dgCabPedido.DataSource = Me.dstCabPedidoTraslado
        Me.dgCabPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCabPedido.Location = New System.Drawing.Point(0, 0)
        Me.dgCabPedido.MultiSelect = False
        Me.dgCabPedido.Name = "dgCabPedido"
        Me.dgCabPedido.RowHeadersWidth = 20
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCabPedido.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgCabPedido.RowTemplate.ReadOnly = True
        Me.dgCabPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgCabPedido.Size = New System.Drawing.Size(1027, 187)
        Me.dgCabPedido.StandardTab = True
        Me.dgCabPedido.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgCabPedido.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgCabPedido.TabIndex = 69
        '
        'M_CHK
        '
        Me.M_CHK.DataPropertyName = "CHKED"
        Me.M_CHK.FalseValue = "False"
        Me.M_CHK.FillWeight = 35.53299!
        Me.M_CHK.HeaderText = "Chk"
        Me.M_CHK.Name = "M_CHK"
        Me.M_CHK.TrueValue = "True"
        '
        'M_NRPDTS
        '
        Me.M_NRPDTS.DataPropertyName = "NRPDTS"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.M_NRPDTS.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_NRPDTS.FillWeight = 110.7445!
        Me.M_NRPDTS.HeaderText = "Nro. Pedido"
        Me.M_NRPDTS.Name = "M_NRPDTS"
        '
        'M_FECPED
        '
        Me.M_FECPED.DataPropertyName = "FECPED"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.M_FECPED.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_FECPED.FillWeight = 110.7445!
        Me.M_FECPED.HeaderText = "Fecha"
        Me.M_FECPED.Name = "M_FECPED"
        '
        'M_CENSAP
        '
        Me.M_CENSAP.DataPropertyName = "CENSAP"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.M_CENSAP.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_CENSAP.FillWeight = 110.7445!
        Me.M_CENSAP.HeaderText = "Cód. Centro"
        Me.M_CENSAP.Name = "M_CENSAP"
        '
        'M_TLTECL
        '
        Me.M_TLTECL.DataPropertyName = "TLTECL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.M_TLTECL.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_TLTECL.FillWeight = 110.7445!
        Me.M_TLTECL.HeaderText = "Centro"
        Me.M_TLTECL.Name = "M_TLTECL"
        '
        'M_CLDSAP
        '
        Me.M_CLDSAP.DataPropertyName = "CLDSAP"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.M_CLDSAP.DefaultCellStyle = DataGridViewCellStyle5
        Me.M_CLDSAP.FillWeight = 110.7445!
        Me.M_CLDSAP.HeaderText = "Clase Doc. SAP"
        Me.M_CLDSAP.Name = "M_CLDSAP"
        '
        'M_TDSDES
        '
        Me.M_TDSDES.DataPropertyName = "TDSDES"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.M_TDSDES.DefaultCellStyle = DataGridViewCellStyle6
        Me.M_TDSDES.FillWeight = 110.7445!
        Me.M_TDSDES.HeaderText = "Estado"
        Me.M_TDSDES.Name = "M_TDSDES"
        '
        'M_CCLNT
        '
        Me.M_CCLNT.DataPropertyName = "CCLNT"
        Me.M_CCLNT.HeaderText = "CCLNT"
        Me.M_CCLNT.Name = "M_CCLNT"
        Me.M_CCLNT.Visible = False
        '
        'M_SESPRC
        '
        Me.M_SESPRC.DataPropertyName = "SESPRC"
        Me.M_SESPRC.HeaderText = "SESPRC"
        Me.M_SESPRC.Name = "M_SESPRC"
        Me.M_SESPRC.Visible = False
        '
        'M_CCMPN
        '
        Me.M_CCMPN.DataPropertyName = "CCMPN"
        Me.M_CCMPN.HeaderText = "CCMPN"
        Me.M_CCMPN.Name = "M_CCMPN"
        Me.M_CCMPN.Visible = False
        '
        'M_CDVSN
        '
        Me.M_CDVSN.DataPropertyName = "CDVSN"
        Me.M_CDVSN.HeaderText = "CDVSN"
        Me.M_CDVSN.Name = "M_CDVSN"
        Me.M_CDVSN.Visible = False
        '
        'M_CPLNDV
        '
        Me.M_CPLNDV.DataPropertyName = "CPLNDV"
        Me.M_CPLNDV.HeaderText = "CPLNDV"
        Me.M_CPLNDV.Name = "M_CPLNDV"
        Me.M_CPLNDV.Visible = False
        '
        'dstCabPedidoTraslado
        '
        Me.dstCabPedidoTraslado.DataSetName = "dstCabPedidoTraslado"
        Me.dstCabPedidoTraslado.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstCabPedidoTraslado.Tables.AddRange(New System.Data.DataTable() {Me.dtPedidoTraslado})
        '
        'dtPedidoTraslado
        '
        Me.dtPedidoTraslado.Columns.AddRange(New System.Data.DataColumn() {Me.CCLNT, Me.NRPDTS, Me.FECPED, Me.CENSAP, Me.TLTECL, Me.CLDSAP, Me.SESPRC, Me.TDSDES, Me.CCMPN, Me.CDVSN, Me.CPLNDV, Me.CHKED})
        Me.dtPedidoTraslado.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtPedidoTraslado.TableName = "dtPedidoTraslado"
        '
        'CCLNT
        '
        Me.CCLNT.Caption = "CCLNT"
        Me.CCLNT.ColumnName = "CCLNT"
        Me.CCLNT.DataType = GetType(Long)
        '
        'NRPDTS
        '
        Me.NRPDTS.Caption = "NRPDTS"
        Me.NRPDTS.ColumnName = "NRPDTS"
        Me.NRPDTS.DataType = GetType(Long)
        '
        'FECPED
        '
        Me.FECPED.Caption = "FECPED"
        Me.FECPED.ColumnName = "FECPED"
        '
        'CENSAP
        '
        Me.CENSAP.Caption = "CENSAP"
        Me.CENSAP.ColumnName = "CENSAP"
        '
        'TLTECL
        '
        Me.TLTECL.Caption = "TLTECL"
        Me.TLTECL.ColumnName = "TLTECL"
        '
        'CLDSAP
        '
        Me.CLDSAP.Caption = "CLDSAP"
        Me.CLDSAP.ColumnName = "CLDSAP"
        '
        'SESPRC
        '
        Me.SESPRC.Caption = "SESPRC"
        Me.SESPRC.ColumnName = "SESPRC"
        '
        'TDSDES
        '
        Me.TDSDES.Caption = "TDSDES"
        Me.TDSDES.ColumnName = "TDSDES"
        '
        'CCMPN
        '
        Me.CCMPN.Caption = "CCMPN"
        Me.CCMPN.ColumnName = "CCMPN"
        '
        'CDVSN
        '
        Me.CDVSN.Caption = "CDVSN"
        Me.CDVSN.ColumnName = "CDVSN"
        '
        'CPLNDV
        '
        Me.CPLNDV.Caption = "CPLNDV"
        Me.CPLNDV.ColumnName = "CPLNDV"
        Me.CPLNDV.DataType = GetType(Integer)
        '
        'CHKED
        '
        Me.CHKED.Caption = "CHKED"
        Me.CHKED.ColumnName = "CHKED"
        Me.CHKED.DataType = GetType(Boolean)
        Me.CHKED.DefaultValue = False
        '
        'dgDetInventario
        '
        Me.dgDetInventario.AllowUserToAddRows = False
        Me.dgDetInventario.AllowUserToDeleteRows = False
        Me.dgDetInventario.AllowUserToResizeRows = False
        Me.dgDetInventario.AutoGenerateColumns = False
        Me.dgDetInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROSECDataGridViewTextBoxColumn, Me.TCITCLDataGridViewTextBoxColumn, Me.TDITESDataGridViewTextBoxColumn, Me.QCNTITDataGridViewTextBoxColumn, Me.QTYPENDataGridViewTextBoxColumn, Me.TUNDITDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.CCLNTDataGridViewTextBoxColumn, Me.NRPDTSDataGridViewTextBoxColumn, Me.TDITINDataGridViewTextBoxColumn, Me.IVUNITDataGridViewTextBoxColumn, Me.TIPLINDataGridViewTextBoxColumn, Me.TRFRN1DataGridViewTextBoxColumn, Me.TRFRN2DataGridViewTextBoxColumn, Me.TRFRNDataGridViewTextBoxColumn})
        Me.dgDetInventario.DataMember = "dtDetPedidoTraslado"
        Me.dgDetInventario.DataSource = Me.dstDetPedidoTraslado
        Me.dgDetInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDetInventario.Location = New System.Drawing.Point(0, 0)
        Me.dgDetInventario.MultiSelect = False
        Me.dgDetInventario.Name = "dgDetInventario"
        Me.dgDetInventario.ReadOnly = True
        Me.dgDetInventario.RowHeadersWidth = 20
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetInventario.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgDetInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetInventario.Size = New System.Drawing.Size(1027, 179)
        Me.dgDetInventario.StandardTab = True
        Me.dgDetInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDetInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDetInventario.TabIndex = 70
        '
        'NROSECDataGridViewTextBoxColumn
        '
        Me.NROSECDataGridViewTextBoxColumn.DataPropertyName = "NROSEC"
        Me.NROSECDataGridViewTextBoxColumn.HeaderText = "Posición"
        Me.NROSECDataGridViewTextBoxColumn.Name = "NROSECDataGridViewTextBoxColumn"
        Me.NROSECDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TCITCLDataGridViewTextBoxColumn
        '
        Me.TCITCLDataGridViewTextBoxColumn.DataPropertyName = "TCITCL"
        Me.TCITCLDataGridViewTextBoxColumn.HeaderText = "Cód. Material"
        Me.TCITCLDataGridViewTextBoxColumn.Name = "TCITCLDataGridViewTextBoxColumn"
        Me.TCITCLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TDITESDataGridViewTextBoxColumn
        '
        Me.TDITESDataGridViewTextBoxColumn.DataPropertyName = "TDITES"
        Me.TDITESDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.TDITESDataGridViewTextBoxColumn.Name = "TDITESDataGridViewTextBoxColumn"
        Me.TDITESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QCNTITDataGridViewTextBoxColumn
        '
        Me.QCNTITDataGridViewTextBoxColumn.DataPropertyName = "QCNTIT"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QCNTITDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.QCNTITDataGridViewTextBoxColumn.HeaderText = "Cantidad Solicitada"
        Me.QCNTITDataGridViewTextBoxColumn.Name = "QCNTITDataGridViewTextBoxColumn"
        Me.QCNTITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QTYPENDataGridViewTextBoxColumn
        '
        Me.QTYPENDataGridViewTextBoxColumn.DataPropertyName = "QTYPEN"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QTYPENDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.QTYPENDataGridViewTextBoxColumn.HeaderText = "Cantidad Pendiente"
        Me.QTYPENDataGridViewTextBoxColumn.Name = "QTYPENDataGridViewTextBoxColumn"
        Me.QTYPENDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TUNDITDataGridViewTextBoxColumn
        '
        Me.TUNDITDataGridViewTextBoxColumn.DataPropertyName = "TUNDIT"
        Me.TUNDITDataGridViewTextBoxColumn.HeaderText = "Unidad de Medida de Mercadería"
        Me.TUNDITDataGridViewTextBoxColumn.Name = "TUNDITDataGridViewTextBoxColumn"
        Me.TUNDITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CLARSG"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clase de Riesgo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NROONU"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número de ONU"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TPOEMB"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo de Embalaje"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CCLNTDataGridViewTextBoxColumn
        '
        Me.CCLNTDataGridViewTextBoxColumn.DataPropertyName = "CCLNT"
        Me.CCLNTDataGridViewTextBoxColumn.HeaderText = "CCLNT"
        Me.CCLNTDataGridViewTextBoxColumn.Name = "CCLNTDataGridViewTextBoxColumn"
        Me.CCLNTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CCLNTDataGridViewTextBoxColumn.Visible = False
        '
        'NRPDTSDataGridViewTextBoxColumn
        '
        Me.NRPDTSDataGridViewTextBoxColumn.DataPropertyName = "NRPDTS"
        Me.NRPDTSDataGridViewTextBoxColumn.HeaderText = "NRPDTS"
        Me.NRPDTSDataGridViewTextBoxColumn.Name = "NRPDTSDataGridViewTextBoxColumn"
        Me.NRPDTSDataGridViewTextBoxColumn.ReadOnly = True
        Me.NRPDTSDataGridViewTextBoxColumn.Visible = False
        '
        'TDITINDataGridViewTextBoxColumn
        '
        Me.TDITINDataGridViewTextBoxColumn.DataPropertyName = "TDITIN"
        Me.TDITINDataGridViewTextBoxColumn.HeaderText = "TDITIN"
        Me.TDITINDataGridViewTextBoxColumn.Name = "TDITINDataGridViewTextBoxColumn"
        Me.TDITINDataGridViewTextBoxColumn.ReadOnly = True
        Me.TDITINDataGridViewTextBoxColumn.Visible = False
        '
        'IVUNITDataGridViewTextBoxColumn
        '
        Me.IVUNITDataGridViewTextBoxColumn.DataPropertyName = "IVUNIT"
        Me.IVUNITDataGridViewTextBoxColumn.HeaderText = "IVUNIT"
        Me.IVUNITDataGridViewTextBoxColumn.Name = "IVUNITDataGridViewTextBoxColumn"
        Me.IVUNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.IVUNITDataGridViewTextBoxColumn.Visible = False
        '
        'TIPLINDataGridViewTextBoxColumn
        '
        Me.TIPLINDataGridViewTextBoxColumn.DataPropertyName = "TIPLIN"
        Me.TIPLINDataGridViewTextBoxColumn.HeaderText = "TIPLIN"
        Me.TIPLINDataGridViewTextBoxColumn.Name = "TIPLINDataGridViewTextBoxColumn"
        Me.TIPLINDataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPLINDataGridViewTextBoxColumn.Visible = False
        '
        'TRFRN1DataGridViewTextBoxColumn
        '
        Me.TRFRN1DataGridViewTextBoxColumn.DataPropertyName = "TRFRN1"
        Me.TRFRN1DataGridViewTextBoxColumn.HeaderText = "TRFRN1"
        Me.TRFRN1DataGridViewTextBoxColumn.Name = "TRFRN1DataGridViewTextBoxColumn"
        Me.TRFRN1DataGridViewTextBoxColumn.ReadOnly = True
        Me.TRFRN1DataGridViewTextBoxColumn.Visible = False
        '
        'TRFRN2DataGridViewTextBoxColumn
        '
        Me.TRFRN2DataGridViewTextBoxColumn.DataPropertyName = "TRFRN2"
        Me.TRFRN2DataGridViewTextBoxColumn.HeaderText = "TRFRN2"
        Me.TRFRN2DataGridViewTextBoxColumn.Name = "TRFRN2DataGridViewTextBoxColumn"
        Me.TRFRN2DataGridViewTextBoxColumn.ReadOnly = True
        Me.TRFRN2DataGridViewTextBoxColumn.Visible = False
        '
        'TRFRNDataGridViewTextBoxColumn
        '
        Me.TRFRNDataGridViewTextBoxColumn.DataPropertyName = "TRFRN"
        Me.TRFRNDataGridViewTextBoxColumn.HeaderText = "TRFRN"
        Me.TRFRNDataGridViewTextBoxColumn.Name = "TRFRNDataGridViewTextBoxColumn"
        Me.TRFRNDataGridViewTextBoxColumn.ReadOnly = True
        Me.TRFRNDataGridViewTextBoxColumn.Visible = False
        '
        'dstDetPedidoTraslado
        '
        Me.dstDetPedidoTraslado.DataSetName = "dstDetPedidoTraslado"
        Me.dstDetPedidoTraslado.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstDetPedidoTraslado.Tables.AddRange(New System.Data.DataTable() {Me.dtDetPedidoTraslado})
        '
        'dtDetPedidoTraslado
        '
        Me.dtDetPedidoTraslado.Columns.AddRange(New System.Data.DataColumn() {Me.D_CCLNT, Me.D_NRPDTS, Me.NROSEC, Me.TCITCL, Me.TDITES, Me.TDITIN, Me.QCNTIT, Me.QTYPEN, Me.TUNDIT, Me.IVUNIT, Me.TIPLIN, Me.TRFRN1, Me.TRFRN2, Me.TRFRN, Me.CLARSG, Me.NROONU, Me.TPOEMB})
        Me.dtDetPedidoTraslado.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtDetPedidoTraslado.TableName = "dtDetPedidoTraslado"
        '
        'D_CCLNT
        '
        Me.D_CCLNT.Caption = "CCLNT"
        Me.D_CCLNT.ColumnName = "CCLNT"
        Me.D_CCLNT.DataType = GetType(Integer)
        '
        'D_NRPDTS
        '
        Me.D_NRPDTS.Caption = "NRPDTS"
        Me.D_NRPDTS.ColumnName = "NRPDTS"
        Me.D_NRPDTS.DataType = GetType(Integer)
        '
        'NROSEC
        '
        Me.NROSEC.Caption = "NROSEC"
        Me.NROSEC.ColumnName = "NROSEC"
        Me.NROSEC.DataType = GetType(Integer)
        '
        'TCITCL
        '
        Me.TCITCL.Caption = "TCITCL"
        Me.TCITCL.ColumnName = "TCITCL"
        '
        'TDITES
        '
        Me.TDITES.Caption = "TDITES"
        Me.TDITES.ColumnName = "TDITES"
        '
        'TDITIN
        '
        Me.TDITIN.Caption = "TDITIN"
        Me.TDITIN.ColumnName = "TDITIN"
        '
        'QCNTIT
        '
        Me.QCNTIT.Caption = "QCNTIT"
        Me.QCNTIT.ColumnName = "QCNTIT"
        Me.QCNTIT.DataType = GetType(Decimal)
        '
        'QTYPEN
        '
        Me.QTYPEN.Caption = "QTYPEN"
        Me.QTYPEN.ColumnName = "QTYPEN"
        Me.QTYPEN.DataType = GetType(Decimal)
        '
        'TUNDIT
        '
        Me.TUNDIT.Caption = "TUNDIT"
        Me.TUNDIT.ColumnName = "TUNDIT"
        '
        'IVUNIT
        '
        Me.IVUNIT.Caption = "IVUNIT"
        Me.IVUNIT.ColumnName = "IVUNIT"
        Me.IVUNIT.DataType = GetType(Decimal)
        '
        'TIPLIN
        '
        Me.TIPLIN.Caption = "TIPLIN"
        Me.TIPLIN.ColumnName = "TIPLIN"
        '
        'TRFRN1
        '
        Me.TRFRN1.Caption = "TRFRN1"
        Me.TRFRN1.ColumnName = "TRFRN1"
        '
        'TRFRN2
        '
        Me.TRFRN2.Caption = "TRFRN2"
        Me.TRFRN2.ColumnName = "TRFRN2"
        '
        'TRFRN
        '
        Me.TRFRN.Caption = "TRFRN"
        Me.TRFRN.ColumnName = "TRFRN"
        '
        'CLARSG
        '
        Me.CLARSG.Caption = "CLARSG"
        Me.CLARSG.ColumnName = "CLARSG"
        '
        'NROONU
        '
        Me.NROONU.Caption = "NROONU"
        Me.NROONU.ColumnName = "NROONU"
        '
        'TPOEMB
        '
        Me.TPOEMB.Caption = "TPOEMB"
        Me.TPOEMB.ColumnName = "TPOEMB"
        '
        'frmPedidoTraslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 519)
        Me.Controls.Add(Me.KryptonSplitContainer1)
        Me.Controls.Add(Me.khgFiltros)
        Me.Name = "frmPedidoTraslado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgCabPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstCabPedidoTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPedidoTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstDetPedidoTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDetPedidoTraslado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtNroPedidoTraslado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonAtender As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dgDetInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CCLNT As System.Data.DataColumn
    Friend WithEvents NRPDTS As System.Data.DataColumn
    Friend WithEvents FECPED As System.Data.DataColumn
    Friend WithEvents CENSAP As System.Data.DataColumn
    Friend WithEvents TLTECL As System.Data.DataColumn
    Friend WithEvents CLDSAP As System.Data.DataColumn
    Friend WithEvents SESPRC As System.Data.DataColumn
    Friend WithEvents TDSDES As System.Data.DataColumn
    Friend WithEvents CCMPN As System.Data.DataColumn
    Friend WithEvents CDVSN As System.Data.DataColumn
    Friend WithEvents CPLNDV As System.Data.DataColumn
    Friend WithEvents CHKED As System.Data.DataColumn
    Private WithEvents dgCabPedido As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents dstCabPedidoTraslado As System.Data.DataSet
    Private WithEvents dtPedidoTraslado As System.Data.DataTable
    Private WithEvents dstDetPedidoTraslado As System.Data.DataSet
    Private WithEvents dtDetPedidoTraslado As System.Data.DataTable
    Friend WithEvents D_CCLNT As System.Data.DataColumn
    Friend WithEvents D_NRPDTS As System.Data.DataColumn
    Friend WithEvents NROSEC As System.Data.DataColumn
    Friend WithEvents TCITCL As System.Data.DataColumn
    Friend WithEvents TDITES As System.Data.DataColumn
    Friend WithEvents TDITIN As System.Data.DataColumn
    Friend WithEvents QCNTIT As System.Data.DataColumn
    Friend WithEvents QTYPEN As System.Data.DataColumn
    Friend WithEvents TUNDIT As System.Data.DataColumn
    Friend WithEvents IVUNIT As System.Data.DataColumn
    Friend WithEvents TIPLIN As System.Data.DataColumn
    Friend WithEvents TRFRN1 As System.Data.DataColumn
    Friend WithEvents TRFRN2 As System.Data.DataColumn
    Friend WithEvents TRFRN As System.Data.DataColumn
    Friend WithEvents CLARSG As System.Data.DataColumn
    Friend WithEvents NROONU As System.Data.DataColumn
    Friend WithEvents TPOEMB As System.Data.DataColumn
    Friend WithEvents M_CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_NRPDTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECPED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CENSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLTECL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CLDSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDSDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESPRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROSECDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITCLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNTITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTYPENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRPDTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVUNITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPLINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRFRN1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRFRN2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRFRNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
