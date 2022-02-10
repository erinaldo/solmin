<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptInventarioXGR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        'Dim BePlanta1 As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta = New Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta()
        'Dim BeCompania1 As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania = New Ransa.TypeDef.UbicacionPlanta.Compania.beCompania()
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptInventarioXGR))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.chkfecha = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.GrpBoxFechas = New System.Windows.Forms.GroupBox()
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.dgReporteGR = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGenerarReporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton()
        Me.M_TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_FGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_MOTTRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QCNGU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QCNREC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_QCNPEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GrpBoxFechas.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.dgReporteGR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chkfecha)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GrpBoxFechas)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtGuiaRemision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblGuia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup1.Panel.MinimumSize = New System.Drawing.Size(0, 135)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1488, 157)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.Text = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "753CEA494AAC48DF753CEA494AAC48DF"
        '
        'chkfecha
        '
        Me.chkfecha.Checked = False
        Me.chkfecha.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkfecha.Location = New System.Drawing.Point(552, 43)
        Me.chkfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Size = New System.Drawing.Size(144, 24)
        Me.chkfecha.TabIndex = 126
        Me.chkfecha.Text = "Fecha Guía Salida"
        Me.chkfecha.Values.ExtraText = ""
        Me.chkfecha.Values.Image = Nothing
        Me.chkfecha.Values.Text = "Fecha Guía Salida"
        '
        'GrpBoxFechas
        '
        Me.GrpBoxFechas.BackColor = System.Drawing.SystemColors.Window
        Me.GrpBoxFechas.Controls.Add(Me.dteFechaFinal)
        Me.GrpBoxFechas.Controls.Add(Me.dteFechaInicial)
        Me.GrpBoxFechas.Controls.Add(Me.lblFechaFinal)
        Me.GrpBoxFechas.Controls.Add(Me.lblFechaInicial)
        Me.GrpBoxFechas.Enabled = False
        Me.GrpBoxFechas.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GrpBoxFechas.Location = New System.Drawing.Point(552, 62)
        Me.GrpBoxFechas.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpBoxFechas.Name = "GrpBoxFechas"
        Me.GrpBoxFechas.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpBoxFechas.Size = New System.Drawing.Size(472, 47)
        Me.GrpBoxFechas.TabIndex = 125
        Me.GrpBoxFechas.TabStop = False
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Enabled = False
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(333, 18)
        Me.dteFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(115, 22)
        Me.dteFechaFinal.TabIndex = 107
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Enabled = False
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(124, 18)
        Me.dteFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(104, 22)
        Me.dteFechaInicial.TabIndex = 106
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Enabled = False
        Me.lblFechaFinal.Location = New System.Drawing.Point(230, 18)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(94, 24)
        Me.lblFechaFinal.TabIndex = 19
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Enabled = False
        Me.lblFechaInicial.Location = New System.Drawing.Point(8, 18)
        Me.lblFechaInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(99, 24)
        Me.lblFechaInicial.TabIndex = 17
        Me.lblFechaInicial.Text = "Fecha Inicio : "
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio : "
        '
        'txtGuiaRemision
        '
        Me.txtGuiaRemision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuiaRemision.Location = New System.Drawing.Point(182, 83)
        Me.txtGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaRemision.Name = "txtGuiaRemision"
        Me.txtGuiaRemision.Size = New System.Drawing.Size(331, 26)
        Me.txtGuiaRemision.TabIndex = 124
        '
        'lblGuia
        '
        Me.lblGuia.Location = New System.Drawing.Point(33, 90)
        Me.lblGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGuia.Name = "lblGuia"
        Me.lblGuia.Size = New System.Drawing.Size(143, 24)
        Me.lblGuia.TabIndex = 100
        Me.lblGuia.Text = "Nro Guía Remisión:"
        Me.lblGuia.Values.ExtraText = ""
        Me.lblGuia.Values.Image = Nothing
        Me.lblGuia.Values.Text = "Nro Guía Remisión:"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(182, 49)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(331, 26)
        Me.txtCliente.TabIndex = 99
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(33, 53)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(949, 14)
        Me.lblPlanta.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(61, 24)
        Me.lblPlanta.TabIndex = 89
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(1028, 10)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
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
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(291, 28)
        Me.UcPLanta_Cmb011.TabIndex = 4
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(541, 14)
        Me.lblDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(73, 24)
        Me.lblDivision.TabIndex = 2
        Me.lblDivision.Text = "División : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División : "
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
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(635, 10)
        Me.UcDivision_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(291, 28)
        Me.UcDivision_Cmb011.TabIndex = 3
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(33, 14)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(88, 24)
        Me.lblCompania.TabIndex = 0
        Me.lblCompania.Text = "Compañía : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(182, 10)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania1
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(331, 28)
        Me.UcCompania_Cmb011.TabIndex = 1
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 157)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dgReporteGR)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1488, 483)
        Me.KryptonHeaderGroup2.TabIndex = 59
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "...Reporte..."
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'dgReporteGR
        '
        Me.dgReporteGR.AllowUserToAddRows = False
        Me.dgReporteGR.AllowUserToDeleteRows = False
        Me.dgReporteGR.AllowUserToResizeColumns = False
        Me.dgReporteGR.AllowUserToResizeRows = False
        Me.dgReporteGR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgReporteGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgReporteGR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_TCMPCL, Me.M_NGUIRM, Me.M_FGUIRM, Me.M_MOTTRA, Me.M_TNMMDT, Me.M_SITUAC, Me.TCMPTR, Me.NPLCCM, Me.NPLACP, Me.NBRVCH, Me.M_NORCML, Me.TCITCL, Me.TMRCD2, Me.QCNGU, Me.TUNDIT, Me.QCNREC, Me.M_QCNPEN})
        Me.dgReporteGR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgReporteGR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgReporteGR.Location = New System.Drawing.Point(0, 27)
        Me.dgReporteGR.Margin = New System.Windows.Forms.Padding(4)
        Me.dgReporteGR.MultiSelect = False
        Me.dgReporteGR.Name = "dgReporteGR"
        Me.dgReporteGR.ReadOnly = True
        Me.dgReporteGR.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgReporteGR.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgReporteGR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgReporteGR.Size = New System.Drawing.Size(1486, 429)
        Me.dgReporteGR.StandardTab = True
        Me.dgReporteGR.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgReporteGR.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgReporteGR.TabIndex = 69
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGenerarReporte, Me.ToolStripSeparator3, Me.btnExportarExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1486, 27)
        Me.ToolStrip1.TabIndex = 57
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenerarReporte.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(76, 24)
        Me.btnGenerarReporte.Text = "Buscar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(127, 24)
        Me.btnExportarExcel.Text = "&Exportar Excel"
        '
        'M_TCMPCL
        '
        Me.M_TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCMPCL.DataPropertyName = "TCMPCL"
        Me.M_TCMPCL.HeaderText = "Cliente"
        Me.M_TCMPCL.Name = "M_TCMPCL"
        Me.M_TCMPCL.ReadOnly = True
        Me.M_TCMPCL.Width = 88
        '
        'M_NGUIRM
        '
        Me.M_NGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NGUIRM.DataPropertyName = "NGUIRM"
        Me.M_NGUIRM.HeaderText = "Nro Guía Remisión"
        Me.M_NGUIRM.Name = "M_NGUIRM"
        Me.M_NGUIRM.ReadOnly = True
        Me.M_NGUIRM.Width = 166
        '
        'M_FGUIRM
        '
        Me.M_FGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FGUIRM.DataPropertyName = "FGUIRM"
        Me.M_FGUIRM.HeaderText = "Fecha Guía Remisión"
        Me.M_FGUIRM.Name = "M_FGUIRM"
        Me.M_FGUIRM.ReadOnly = True
        Me.M_FGUIRM.Width = 179
        '
        'M_MOTTRA
        '
        Me.M_MOTTRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_MOTTRA.DataPropertyName = "MOTTRA"
        Me.M_MOTTRA.HeaderText = "Motivo Traslado"
        Me.M_MOTTRA.Name = "M_MOTTRA"
        Me.M_MOTTRA.ReadOnly = True
        Me.M_MOTTRA.Width = 149
        '
        'M_TNMMDT
        '
        Me.M_TNMMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TNMMDT.DataPropertyName = "TNMMDT"
        Me.M_TNMMDT.HeaderText = "Medio Envío"
        Me.M_TNMMDT.Name = "M_TNMMDT"
        Me.M_TNMMDT.ReadOnly = True
        Me.M_TNMMDT.Width = 125
        '
        'M_SITUAC
        '
        Me.M_SITUAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_SITUAC.DataPropertyName = "SITUAC"
        Me.M_SITUAC.HeaderText = "Situación"
        Me.M_SITUAC.Name = "M_SITUAC"
        Me.M_SITUAC.ReadOnly = True
        Me.M_SITUAC.Width = 103
        '
        'TCMPTR
        '
        Me.TCMPTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPTR.DataPropertyName = "TCMPTR"
        Me.TCMPTR.HeaderText = "Transportista"
        Me.TCMPTR.Name = "TCMPTR"
        Me.TCMPTR.ReadOnly = True
        Me.TCMPTR.Width = 127
        '
        'NPLCCM
        '
        Me.NPLCCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCCM.DataPropertyName = "NPLCCM"
        Me.NPLCCM.HeaderText = "Tracto"
        Me.NPLCCM.Name = "NPLCCM"
        Me.NPLCCM.ReadOnly = True
        Me.NPLCCM.Width = 83
        '
        'NPLACP
        '
        Me.NPLACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLACP.DataPropertyName = "NPLACP"
        Me.NPLACP.HeaderText = "Acoplado"
        Me.NPLACP.Name = "NPLACP"
        Me.NPLACP.ReadOnly = True
        Me.NPLACP.Width = 107
        '
        'NBRVCH
        '
        Me.NBRVCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NBRVCH.DataPropertyName = "NBRVCH"
        Me.NBRVCH.HeaderText = "Brevete"
        Me.NBRVCH.Name = "NBRVCH"
        Me.NBRVCH.ReadOnly = True
        Me.NBRVCH.Width = 92
        '
        'M_NORCML
        '
        Me.M_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NORCML.DataPropertyName = "NORCML"
        Me.M_NORCML.HeaderText = "Nro Orden Compra"
        Me.M_NORCML.Name = "M_NORCML"
        Me.M_NORCML.ReadOnly = True
        Me.M_NORCML.Width = 169
        '
        'TCITCL
        '
        Me.TCITCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCITCL.DataPropertyName = "TCITCL"
        Me.TCITCL.HeaderText = "Cód. Mercadería"
        Me.TCITCL.Name = "TCITCL"
        Me.TCITCL.ReadOnly = True
        Me.TCITCL.Width = 151
        '
        'TMRCD2
        '
        Me.TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Mercadería"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        Me.TMRCD2.Width = 117
        '
        'QCNGU
        '
        Me.QCNGU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QCNGU.DataPropertyName = "QCNGU"
        Me.QCNGU.HeaderText = "Cantidad GR"
        Me.QCNGU.Name = "QCNGU"
        Me.QCNGU.ReadOnly = True
        Me.QCNGU.Width = 125
        '
        'TUNDIT
        '
        Me.TUNDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TUNDIT.DataPropertyName = "TUNDIT"
        Me.TUNDIT.HeaderText = "Unid. Medida"
        Me.TUNDIT.Name = "TUNDIT"
        Me.TUNDIT.ReadOnly = True
        Me.TUNDIT.Width = 131
        '
        'QCNREC
        '
        Me.QCNREC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QCNREC.DataPropertyName = "QCNREC"
        Me.QCNREC.HeaderText = "Cant. Recepcionada"
        Me.QCNREC.Name = "QCNREC"
        Me.QCNREC.ReadOnly = True
        Me.QCNREC.Width = 173
        '
        'M_QCNPEN
        '
        Me.M_QCNPEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNPEN.DataPropertyName = "QCNPEN"
        Me.M_QCNPEN.HeaderText = "Cant. Pendiente"
        Me.M_QCNPEN.Name = "M_QCNPEN"
        Me.M_QCNPEN.ReadOnly = True
        Me.M_QCNPEN.Width = 144
        '
        'frmRptInventarioXGR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 640)
        Me.Controls.Add(Me.KryptonHeaderGroup2)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRptInventarioXGR"
        Me.Text = "Inventario por Guía de Remisión"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GrpBoxFechas.ResumeLayout(False)
        Me.GrpBoxFechas.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.dgReporteGR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dgReporteGR As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Private WithEvents lblGuia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents GrpBoxFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Private WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkfecha As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents M_TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_MOTTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNPEN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
