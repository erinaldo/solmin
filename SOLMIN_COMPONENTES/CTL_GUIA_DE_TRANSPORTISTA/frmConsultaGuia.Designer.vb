<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaGuia
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
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.MenuBar_0 = New System.Windows.Forms.ToolStrip()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.panelFiltro = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnBuscaOrdenServicio = New System.Windows.Forms.Button()
        Me.txtFiltroGuiaProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtFiltroGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaFiltroFin = New System.Windows.Forms.DateTimePicker()
        Me.lblGuia = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel51 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCliente_GuiaRemision = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.dtpFechaFiltroInicio = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELECCIONAR = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.NGUIRM_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNGUIRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FGUIRM_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRVCL_0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRM_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTDGRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar_0.SuspendLayout()
        CType(Me.panelFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgGuiaRemision)
        Me.KryptonPanel.Controls.Add(Me.MenuBar_0)
        Me.KryptonPanel.Controls.Add(Me.panelFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1162, 498)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgGuiaRemision
        '
        Me.dtgGuiaRemision.AllowUserToAddRows = False
        Me.dtgGuiaRemision.AllowUserToDeleteRows = False
        Me.dtgGuiaRemision.AllowUserToResizeColumns = False
        Me.dtgGuiaRemision.AllowUserToResizeRows = False
        Me.dtgGuiaRemision.ColumnHeadersHeight = 30
        Me.dtgGuiaRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONAR, Me.NGUIRM_0, Me.DNGUIRS, Me.FGUIRM_0, Me.TCMPCL_0, Me.CCLNT_0, Me.CPRVCL_0, Me.NGUIRM_S, Me.NGUIRS, Me.CTDGRM})
        Me.dtgGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgGuiaRemision.Location = New System.Drawing.Point(0, 133)
        Me.dtgGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgGuiaRemision.Name = "dtgGuiaRemision"
        Me.dtgGuiaRemision.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgGuiaRemision.RowHeadersVisible = False
        Me.dtgGuiaRemision.RowHeadersWidth = 20
        Me.dtgGuiaRemision.Size = New System.Drawing.Size(1162, 365)
        Me.dtgGuiaRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgGuiaRemision.TabIndex = 3
        '
        'MenuBar_0
        '
        Me.MenuBar_0.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar_0.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar_0.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.btnProcesar, Me.ToolStripSeparator2, Me.btnBuscar})
        Me.MenuBar_0.Location = New System.Drawing.Point(0, 106)
        Me.MenuBar_0.Name = "MenuBar_0"
        Me.MenuBar_0.Size = New System.Drawing.Size(1162, 27)
        Me.MenuBar_0.TabIndex = 9
        Me.MenuBar_0.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 24)
        Me.btnSalir.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(92, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(77, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'panelFiltro
        '
        Me.panelFiltro.Controls.Add(Me.cmbPlanta)
        Me.panelFiltro.Controls.Add(Me.KryptonLabel6)
        Me.panelFiltro.Controls.Add(Me.btnBuscaOrdenServicio)
        Me.panelFiltro.Controls.Add(Me.txtFiltroGuiaProveedor)
        Me.panelFiltro.Controls.Add(Me.txtFiltroGuiaRemision)
        Me.panelFiltro.Controls.Add(Me.txtGuiaRemision)
        Me.panelFiltro.Controls.Add(Me.lblGuiaRemision)
        Me.panelFiltro.Controls.Add(Me.dtpFechaFiltroFin)
        Me.panelFiltro.Controls.Add(Me.lblGuia)
        Me.panelFiltro.Controls.Add(Me.KryptonLabel51)
        Me.panelFiltro.Controls.Add(Me.lblNombre)
        Me.panelFiltro.Controls.Add(Me.UcCliente_GuiaRemision)
        Me.panelFiltro.Controls.Add(Me.dtpFechaFiltroInicio)
        Me.panelFiltro.Controls.Add(Me.KryptonLabel1)
        Me.panelFiltro.Controls.Add(Me.txtOperacion)
        Me.panelFiltro.Controls.Add(Me.lblOperacion)
        Me.panelFiltro.Controls.Add(Me.KryptonLabel2)
        Me.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFiltro.Location = New System.Drawing.Point(0, 0)
        Me.panelFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.panelFiltro.Name = "panelFiltro"
        Me.panelFiltro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panelFiltro.Size = New System.Drawing.Size(1162, 106)
        Me.panelFiltro.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelFiltro.TabIndex = 2
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CodSedeSAP = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(540, 17)
        Me.cmbPlanta.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(200, 26)
        Me.cmbPlanta.Name = "cmbPlanta"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDSPSP_CodSedeSAP = Nothing
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0.0R
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.cmbPlanta.obePlanta = BePlanta1
        Me.cmbPlanta.pHabilitado = True
        Me.cmbPlanta.Planta = 0.0R
        Me.cmbPlanta.PlantaDefault = -1.0R
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(279, 28)
        Me.cmbPlanta.TabIndex = 114
        Me.cmbPlanta.Usuario = ""
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(488, 22)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(54, 26)
        Me.KryptonLabel6.TabIndex = 113
        Me.KryptonLabel6.Text = "Planta"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Planta"
        '
        'btnBuscaOrdenServicio
        '
        Me.btnBuscaOrdenServicio.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.cell_layout
        Me.btnBuscaOrdenServicio.Location = New System.Drawing.Point(901, 64)
        Me.btnBuscaOrdenServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscaOrdenServicio.Name = "btnBuscaOrdenServicio"
        Me.btnBuscaOrdenServicio.Size = New System.Drawing.Size(33, 30)
        Me.btnBuscaOrdenServicio.TabIndex = 17
        Me.btnBuscaOrdenServicio.UseVisualStyleBackColor = True
        '
        'txtFiltroGuiaProveedor
        '
        Me.txtFiltroGuiaProveedor.Enabled = False
        Me.txtFiltroGuiaProveedor.Location = New System.Drawing.Point(233, 65)
        Me.txtFiltroGuiaProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroGuiaProveedor.MaxLength = 20
        Me.txtFiltroGuiaProveedor.Name = "txtFiltroGuiaProveedor"
        Me.txtFiltroGuiaProveedor.Size = New System.Drawing.Size(144, 26)
        Me.txtFiltroGuiaProveedor.TabIndex = 11
        Me.txtFiltroGuiaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFiltroGuiaProveedor.Visible = False
        '
        'txtFiltroGuiaRemision
        '
        Me.txtFiltroGuiaRemision.Enabled = False
        Me.txtFiltroGuiaRemision.Location = New System.Drawing.Point(233, 65)
        Me.txtFiltroGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroGuiaRemision.MaxLength = 10
        Me.txtFiltroGuiaRemision.Name = "txtFiltroGuiaRemision"
        Me.txtFiltroGuiaRemision.Size = New System.Drawing.Size(144, 26)
        Me.txtFiltroGuiaRemision.TabIndex = 5
        Me.txtFiltroGuiaRemision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFiltroGuiaRemision.Visible = False
        '
        'txtGuiaRemision
        '
        Me.txtGuiaRemision.Location = New System.Drawing.Point(500, 65)
        Me.txtGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaRemision.MaxLength = 20
        Me.txtGuiaRemision.Name = "txtGuiaRemision"
        Me.txtGuiaRemision.Size = New System.Drawing.Size(144, 26)
        Me.txtGuiaRemision.TabIndex = 10
        '
        'lblGuiaRemision
        '
        Me.lblGuiaRemision.Location = New System.Drawing.Point(384, 66)
        Me.lblGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGuiaRemision.Name = "lblGuiaRemision"
        Me.lblGuiaRemision.Size = New System.Drawing.Size(109, 26)
        Me.lblGuiaRemision.TabIndex = 9
        Me.lblGuiaRemision.Text = "Guía Remisión"
        Me.lblGuiaRemision.Values.ExtraText = ""
        Me.lblGuiaRemision.Values.Image = Nothing
        Me.lblGuiaRemision.Values.Text = "Guía Remisión"
        '
        'dtpFechaFiltroFin
        '
        Me.dtpFechaFiltroFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFiltroFin.Location = New System.Drawing.Point(1028, 21)
        Me.dtpFechaFiltroFin.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaFiltroFin.Name = "dtpFechaFiltroFin"
        Me.dtpFechaFiltroFin.Size = New System.Drawing.Size(116, 22)
        Me.dtpFechaFiltroFin.TabIndex = 6
        '
        'lblGuia
        '
        Me.lblGuia.Checked = False
        Me.lblGuia.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.lblGuia.Location = New System.Drawing.Point(83, 66)
        Me.lblGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGuia.Name = "lblGuia"
        Me.lblGuia.Size = New System.Drawing.Size(125, 26)
        Me.lblGuia.TabIndex = 4
        Me.lblGuia.Text = "Guía Remisión"
        Me.lblGuia.Values.ExtraText = ""
        Me.lblGuia.Values.Image = Nothing
        Me.lblGuia.Values.Text = "Guía Remisión"
        '
        'KryptonLabel51
        '
        Me.KryptonLabel51.Location = New System.Drawing.Point(820, 22)
        Me.KryptonLabel51.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel51.Name = "KryptonLabel51"
        Me.KryptonLabel51.Size = New System.Drawing.Size(51, 26)
        Me.KryptonLabel51.TabIndex = 2
        Me.KryptonLabel51.Text = "Fecha"
        Me.KryptonLabel51.Values.ExtraText = ""
        Me.KryptonLabel51.Values.Image = Nothing
        Me.KryptonLabel51.Values.Text = "Fecha"
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(13, 22)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 26)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Cliente"
        Me.lblNombre.Values.ExtraText = ""
        Me.lblNombre.Values.Image = Nothing
        Me.lblNombre.Values.Text = "Cliente"
        '
        'UcCliente_GuiaRemision
        '
        Me.UcCliente_GuiaRemision.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente_GuiaRemision.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente_GuiaRemision.CCMPN = "EZ"
        Me.UcCliente_GuiaRemision.Location = New System.Drawing.Point(85, 20)
        Me.UcCliente_GuiaRemision.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCliente_GuiaRemision.Name = "UcCliente_GuiaRemision"
        Me.UcCliente_GuiaRemision.pAccesoPorUsuario = False
        Me.UcCliente_GuiaRemision.pCDDRSP_CodClienteSAP = ""
        Me.UcCliente_GuiaRemision.pRequerido = False
        Me.UcCliente_GuiaRemision.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente_GuiaRemision.pVisualizaNegocio = False
        Me.UcCliente_GuiaRemision.Size = New System.Drawing.Size(391, 26)
        Me.UcCliente_GuiaRemision.TabIndex = 1
        '
        'dtpFechaFiltroInicio
        '
        Me.dtpFechaFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFiltroInicio.Location = New System.Drawing.Point(876, 21)
        Me.dtpFechaFiltroInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaFiltroInicio.Name = "dtpFechaFiltroInicio"
        Me.dtpFechaFiltroInicio.Size = New System.Drawing.Size(116, 22)
        Me.dtpFechaFiltroInicio.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(997, 22)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(25, 26)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Al"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Al"
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(764, 66)
        Me.txtOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOperacion.MaxLength = 10
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(133, 26)
        Me.txtOperacion.TabIndex = 13
        '
        'lblOperacion
        '
        Me.lblOperacion.Location = New System.Drawing.Point(669, 68)
        Me.lblOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(82, 26)
        Me.lblOperacion.TabIndex = 12
        Me.lblOperacion.Text = "Operación"
        Me.lblOperacion.Values.ExtraText = ""
        Me.lblOperacion.Values.Image = Nothing
        Me.lblOperacion.Values.Text = "Operación"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(204, 66)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(22, 26)
        Me.KryptonLabel2.TabIndex = 8
        Me.KryptonLabel2.Text = " - "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = " - "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DNGUIRS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Guía Remisión"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FGUIRM_S"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Guía Remisión"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CPRVCL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CPRVCL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NGUIRM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "NGUIRM_S"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NGUIRS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NGUIRS"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CTDGRM"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CTDGRM"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'SELECCIONAR
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.SELECCIONAR.DefaultCellStyle = DataGridViewCellStyle1
        Me.SELECCIONAR.FalseValue = Nothing
        Me.SELECCIONAR.HeaderText = ""
        Me.SELECCIONAR.IndeterminateValue = Nothing
        Me.SELECCIONAR.Name = "SELECCIONAR"
        Me.SELECCIONAR.TrueValue = Nothing
        Me.SELECCIONAR.Width = 25
        '
        'NGUIRM_0
        '
        Me.NGUIRM_0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUIRM_0.DataPropertyName = "NGUIRM"
        Me.NGUIRM_0.HeaderText = "Guía R. Cliente"
        Me.NGUIRM_0.Name = "NGUIRM_0"
        Me.NGUIRM_0.ReadOnly = True
        Me.NGUIRM_0.Width = 138
        '
        'DNGUIRS
        '
        Me.DNGUIRS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DNGUIRS.DataPropertyName = "DNGUIRS"
        Me.DNGUIRS.HeaderText = "Guía R. Cliente Txt"
        Me.DNGUIRS.Name = "DNGUIRS"
        Me.DNGUIRS.ReadOnly = True
        Me.DNGUIRS.Width = 161
        '
        'FGUIRM_0
        '
        Me.FGUIRM_0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FGUIRM_0.DataPropertyName = "FGUIRM_S"
        Me.FGUIRM_0.HeaderText = "Fecha Guía R."
        Me.FGUIRM_0.Name = "FGUIRM_0"
        Me.FGUIRM_0.ReadOnly = True
        Me.FGUIRM_0.Width = 130
        '
        'TCMPCL_0
        '
        Me.TCMPCL_0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMPCL_0.DataPropertyName = "TCMPCL"
        Me.TCMPCL_0.HeaderText = "Cliente"
        Me.TCMPCL_0.Name = "TCMPCL_0"
        Me.TCMPCL_0.ReadOnly = True
        '
        'CCLNT_0
        '
        Me.CCLNT_0.DataPropertyName = "CCLNT"
        Me.CCLNT_0.HeaderText = "CCLNT"
        Me.CCLNT_0.Name = "CCLNT_0"
        Me.CCLNT_0.ReadOnly = True
        Me.CCLNT_0.Visible = False
        '
        'CPRVCL_0
        '
        Me.CPRVCL_0.DataPropertyName = "CPRVCL"
        Me.CPRVCL_0.HeaderText = "CPRVCL"
        Me.CPRVCL_0.Name = "CPRVCL_0"
        Me.CPRVCL_0.Visible = False
        '
        'NGUIRM_S
        '
        Me.NGUIRM_S.DataPropertyName = "NGUIRS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NGUIRM_S.DefaultCellStyle = DataGridViewCellStyle2
        Me.NGUIRM_S.HeaderText = "NGUIRM_S"
        Me.NGUIRM_S.Name = "NGUIRM_S"
        Me.NGUIRM_S.Visible = False
        '
        'NGUIRS
        '
        Me.NGUIRS.DataPropertyName = "NGUIRS"
        Me.NGUIRS.HeaderText = "NGUIRS"
        Me.NGUIRS.Name = "NGUIRS"
        Me.NGUIRS.ReadOnly = True
        Me.NGUIRS.Visible = False
        '
        'CTDGRM
        '
        Me.CTDGRM.DataPropertyName = "CTDGRM"
        Me.CTDGRM.HeaderText = "CTDGRM"
        Me.CTDGRM.Name = "CTDGRM"
        Me.CTDGRM.ReadOnly = True
        Me.CTDGRM.Visible = False
        '
        'frmConsultaGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 498)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConsultaGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Guía"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar_0.ResumeLayout(False)
        Me.MenuBar_0.PerformLayout()
        CType(Me.panelFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFiltro.ResumeLayout(False)
        Me.panelFiltro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents panelFiltro As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents lblGuia As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents KryptonLabel51 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents UcCliente_GuiaRemision As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents txtFiltroGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents dtpFechaFiltroInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtgGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents dtpFechaFiltroFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar_0 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents txtGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtFiltroGuiaProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnBuscaOrdenServicio As System.Windows.Forms.Button
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SELECCIONAR As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NGUIRM_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNGUIRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FGUIRM_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRVCL_0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTDGRM As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
