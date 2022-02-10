<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisponibilidadInventario
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarXLS = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInvInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaInvInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgDisInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMC_N = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMP_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMP_N = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISINVEN = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.khgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.tsReporte)
        Me.khgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInvInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInvInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(1299, 155)
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
        'UcDivision_Cmb011
        '
        Me.UcDivision_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision_Cmb011.CDVSN_ANTERIOR = Nothing
        Me.UcDivision_Cmb011.Compania = ""
        Me.UcDivision_Cmb011.Division = Nothing
        Me.UcDivision_Cmb011.DivisionDefault = Nothing
        Me.UcDivision_Cmb011.DivisionDescripcion = Nothing
        Me.UcDivision_Cmb011.ItemTodos = False
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(472, 12)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.obeDivision = Nothing
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(197, 23)
        Me.UcDivision_Cmb011.TabIndex = 21
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(406, 15)
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
        Me.tsReporte.Location = New System.Drawing.Point(0, 98)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1297, 26)
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(739, 12)
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
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(114, 39)
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
        Me.txtCliente.Location = New System.Drawing.Point(174, 41)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(495, 22)
        Me.txtCliente.TabIndex = 23
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(174, 13)
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(683, 15)
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
        Me.dteFechaInvInicial.Location = New System.Drawing.Point(174, 66)
        Me.dteFechaInvInicial.Name = "dteFechaInvInicial"
        Me.dteFechaInvInicial.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInvInicial.TabIndex = 24
        Me.dteFechaInvInicial.Value = New Date(2015, 8, 12, 15, 30, 52, 0)
        '
        'lblFechaInvInicial
        '
        Me.lblFechaInvInicial.Location = New System.Drawing.Point(101, 67)
        Me.lblFechaInvInicial.Name = "lblFechaInvInicial"
        Me.lblFechaInvInicial.Size = New System.Drawing.Size(67, 20)
        Me.lblFechaInvInicial.TabIndex = 65
        Me.lblFechaInvInicial.Text = "Fecha Inv.: "
        Me.lblFechaInvInicial.Values.ExtraText = ""
        Me.lblFechaInvInicial.Values.Image = Nothing
        Me.lblFechaInvInicial.Values.Text = "Fecha Inv.: "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(96, 13)
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
        Me.dgDisInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CMRCLR, Me.NORDSR, Me.TMRCD2, Me.QSLMC_S, Me.QSLMC_N, Me.CUNCN5, Me.QSLMP_S, Me.QSLMP_N, Me.CUNPS5, Me.DISINVEN})
        Me.dgDisInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDisInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDisInventario.Location = New System.Drawing.Point(0, 155)
        Me.dgDisInventario.MultiSelect = False
        Me.dgDisInventario.Name = "dgDisInventario"
        Me.dgDisInventario.ReadOnly = True
        Me.dgDisInventario.RowHeadersWidth = 20
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDisInventario.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDisInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDisInventario.Size = New System.Drawing.Size(1299, 332)
        Me.dgDisInventario.StandardTab = True
        Me.dgDisInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDisInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDisInventario.TabIndex = 70
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "CMRCLR"
        Me.CMRCLR.HeaderText = "Cod. Mercadería"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        Me.CMRCLR.Width = 123
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "Orden de Servicio"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        Me.NORDSR.Width = 129
        '
        'TMRCD2
        '
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Mercadería"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        Me.TMRCD2.Width = 95
        '
        'QSLMC_S
        '
        Me.QSLMC_S.DataPropertyName = "QSLMC_S"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.QSLMC_S.DefaultCellStyle = DataGridViewCellStyle1
        Me.QSLMC_S.HeaderText = "Cantidad disponible (A)"
        Me.QSLMC_S.Name = "QSLMC_S"
        Me.QSLMC_S.ReadOnly = True
        Me.QSLMC_S.Width = 161
        '
        'QSLMC_N
        '
        Me.QSLMC_N.DataPropertyName = "QSLMC_N"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.QSLMC_N.DefaultCellStyle = DataGridViewCellStyle2
        Me.QSLMC_N.HeaderText = "Cantidad Inmovilizado (B)"
        Me.QSLMC_N.Name = "QSLMC_N"
        Me.QSLMC_N.ReadOnly = True
        Me.QSLMC_N.Width = 173
        '
        'CUNCN5
        '
        Me.CUNCN5.DataPropertyName = "CUNCN5"
        Me.CUNCN5.HeaderText = "Unidad de medida"
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.ReadOnly = True
        Me.CUNCN5.Width = 133
        '
        'QSLMP_S
        '
        Me.QSLMP_S.DataPropertyName = "QSLMP_S"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.QSLMP_S.DefaultCellStyle = DataGridViewCellStyle3
        Me.QSLMP_S.HeaderText = "Peso disponible"
        Me.QSLMP_S.Name = "QSLMP_S"
        Me.QSLMP_S.ReadOnly = True
        Me.QSLMP_S.Width = 119
        '
        'QSLMP_N
        '
        Me.QSLMP_N.DataPropertyName = "QSLMP_N"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.QSLMP_N.DefaultCellStyle = DataGridViewCellStyle4
        Me.QSLMP_N.HeaderText = "Peso Inmovilizado"
        Me.QSLMP_N.Name = "QSLMP_N"
        Me.QSLMP_N.ReadOnly = True
        Me.QSLMP_N.Width = 132
        '
        'CUNPS5
        '
        Me.CUNPS5.DataPropertyName = "CUNPS5"
        Me.CUNPS5.HeaderText = "Unidad de Peso"
        Me.CUNPS5.Name = "CUNPS5"
        Me.CUNPS5.ReadOnly = True
        Me.CUNPS5.Width = 118
        '
        'DISINVEN
        '
        Me.DISINVEN.DataPropertyName = "DISINVEN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.DISINVEN.DefaultCellStyle = DataGridViewCellStyle5
        Me.DISINVEN.HeaderText = "Disponibilidad de Inventario (B/A)"
        Me.DISINVEN.Name = "DISINVEN"
        Me.DISINVEN.ReadOnly = True
        Me.DISINVEN.Width = 215
        '
        'frmDisponibilidadInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 487)
        Me.Controls.Add(Me.dgDisInventario)
        Me.Controls.Add(Me.khgFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmDisponibilidadInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disponibilidad Inventario"
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
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarXLS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInvInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInvInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents dgDisInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC_N As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMP_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMP_N As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISINVEN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
