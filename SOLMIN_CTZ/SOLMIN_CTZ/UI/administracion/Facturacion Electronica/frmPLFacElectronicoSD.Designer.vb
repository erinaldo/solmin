<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLFacElectronicoSD
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
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAvance = New System.Windows.Forms.Label()
        Me.chkAvance = New System.Windows.Forms.CheckBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btncheck = New System.Windows.Forms.ToolStripButton()
        Me.btnFacturaPreLiquidacion = New System.Windows.Forms.ToolStripButton()
        Me.btnAnularPreliquidacion = New System.Windows.Forms.ToolStripButton()
        Me.btnEditPL = New System.Windows.Forms.ToolStripButton()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.lblseleccionados = New System.Windows.Forms.ToolStripLabel()
        Me.dgwLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.chk2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.CCLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRLQD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA_PL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVLSRV_PL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRVTA_L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL_OP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL_FAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRGVTA_L = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDetalleLiquidacion = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NOPRCN = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TIPODOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO_PL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_ESTPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnPreDoc = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnFacturaPreDoc = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnVerPreDoc = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.TabListaLiquidacion = New System.Windows.Forms.TabControl()
        Me.tabLiquidacion = New System.Windows.Forms.TabPage()
        Me.dtgPreDocumentos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NRCTRL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPCTRL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIP_DOC_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_DOC_FACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_FACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERACION = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TCMPDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTOP_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSGNMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVLSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABTPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCMFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asd = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        CType(Me.dgwLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.TabListaLiquidacion.SuspendLayout()
        Me.tabLiquidacion.SuspendLayout()
        CType(Me.dtgPreDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFiltros
        '
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.PictureBox1)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblAvance)
        Me.PanelFiltros.Panel.Controls.Add(Me.chkAvance)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbTipo)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtClienteFiltro)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel18)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboDivision)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Size = New System.Drawing.Size(1349, 109)
        Me.PanelFiltros.TabIndex = 1
        Me.PanelFiltros.Text = "INFORMACIÓN DE JUNTA"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "INFORMACIÓN DE JUNTA"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SOLMIN_CT.My.Resources.Resources.iconoEspera
        Me.PictureBox1.Location = New System.Drawing.Point(532, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'lblAvance
        '
        Me.lblAvance.AutoSize = True
        Me.lblAvance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvance.Location = New System.Drawing.Point(13, 80)
        Me.lblAvance.Name = "lblAvance"
        Me.lblAvance.Size = New System.Drawing.Size(70, 20)
        Me.lblAvance.TabIndex = 101
        Me.lblAvance.Text = "Avance"
        '
        'chkAvance
        '
        Me.chkAvance.AutoSize = True
        Me.chkAvance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkAvance.Location = New System.Drawing.Point(897, 48)
        Me.chkAvance.Name = "chkAvance"
        Me.chkAvance.Size = New System.Drawing.Size(175, 21)
        Me.chkAvance.TabIndex = 99
        Me.chkAvance.Text = "Avanzar en automático"
        Me.chkAvance.UseVisualStyleBackColor = False
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(533, 48)
        Me.cmbTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(331, 24)
        Me.cmbTipo.TabIndex = 98
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(460, 47)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(41, 24)
        Me.KryptonLabel2.TabIndex = 83
        Me.KryptonLabel2.Text = "Tipo"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Tipo"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Location = New System.Drawing.Point(96, 46)
        Me.txtClienteFiltro.Margin = New System.Windows.Forms.Padding(5)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pCDDRSP_CodClienteSAP = ""
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.pVisualizaNegocio = False
        Me.txtClienteFiltro.Size = New System.Drawing.Size(353, 26)
        Me.txtClienteFiltro.TabIndex = 7
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(5, 47)
        Me.KryptonLabel18.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(59, 24)
        Me.KryptonLabel18.TabIndex = 6
        Me.KryptonLabel18.Text = "Cliente"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Cliente"
        '
        'cboDivision
        '
        Me.cboDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.DropDownWidth = 211
        Me.cboDivision.FormattingEnabled = False
        Me.cboDivision.ItemHeight = 20
        Me.cboDivision.Location = New System.Drawing.Point(533, 9)
        Me.cboDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(331, 28)
        Me.cboDivision.TabIndex = 3
        Me.cboDivision.TabStop = False
        '
        'cboCompania
        '
        Me.cboCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompania.DropDownWidth = 248
        Me.cboCompania.FormattingEnabled = False
        Me.cboCompania.ItemHeight = 20
        Me.cboCompania.Location = New System.Drawing.Point(96, 9)
        Me.cboCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCompania.Name = "cboCompania"
        Me.cboCompania.Size = New System.Drawing.Size(353, 28)
        Me.cboCompania.TabIndex = 1
        Me.cboCompania.TabStop = False
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(453, 11)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(65, 24)
        Me.KryptonLabel5.TabIndex = 2
        Me.KryptonLabel5.Text = "División"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 11)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(81, 24)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Compañía"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañía"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncheck, Me.btnFacturaPreLiquidacion, Me.btnAnularPreliquidacion, Me.btnEditPL, Me.btnBuscar, Me.btnExportar, Me.lblseleccionados})
        Me.MenuBar.Location = New System.Drawing.Point(0, 109)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1349, 27)
        Me.MenuBar.TabIndex = 2
        Me.MenuBar.TabStop = True
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btncheck
        '
        Me.btncheck.Image = Global.SOLMIN_CT.My.Resources.Resources.btnMarcarItems
        Me.btncheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncheck.Name = "btncheck"
        Me.btncheck.Size = New System.Drawing.Size(72, 24)
        Me.btncheck.Text = "Check"
        '
        'btnFacturaPreLiquidacion
        '
        Me.btnFacturaPreLiquidacion.BackgroundImage = Global.SOLMIN_CT.My.Resources.Resources.runprog
        Me.btnFacturaPreLiquidacion.Image = Global.SOLMIN_CT.My.Resources.Resources.runprog
        Me.btnFacturaPreLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFacturaPreLiquidacion.Name = "btnFacturaPreLiquidacion"
        Me.btnFacturaPreLiquidacion.Size = New System.Drawing.Size(99, 24)
        Me.btnFacturaPreLiquidacion.Text = "Factura PL"
        Me.btnFacturaPreLiquidacion.ToolTipText = "Factura Pre Liquidacion"
        '
        'btnAnularPreliquidacion
        '
        Me.btnAnularPreliquidacion.BackgroundImage = Global.SOLMIN_CT.My.Resources.Resources._stop
        Me.btnAnularPreliquidacion.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnAnularPreliquidacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnularPreliquidacion.Name = "btnAnularPreliquidacion"
        Me.btnAnularPreliquidacion.Size = New System.Drawing.Size(95, 24)
        Me.btnAnularPreliquidacion.Text = "Anular PL"
        '
        'btnEditPL
        '
        Me.btnEditPL.Image = Global.SOLMIN_CT.My.Resources.Resources.cell_layout
        Me.btnEditPL.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditPL.Name = "btnEditPL"
        Me.btnEditPL.Size = New System.Drawing.Size(122, 24)
        Me.btnEditPL.Text = "Editar PL Doc"
        Me.btnEditPL.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_CT.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipText = "Buscar"
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_CT.My.Resources.Resources.excel1
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 24)
        Me.btnExportar.Text = "Exportar"
        '
        'lblseleccionados
        '
        Me.lblseleccionados.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseleccionados.Name = "lblseleccionados"
        Me.lblseleccionados.Size = New System.Drawing.Size(13, 24)
        Me.lblseleccionados.Text = "."
        '
        'dgwLiquidacion
        '
        Me.dgwLiquidacion.AllowUserToAddRows = False
        Me.dgwLiquidacion.AllowUserToDeleteRows = False
        Me.dgwLiquidacion.AllowUserToResizeColumns = False
        Me.dgwLiquidacion.AllowUserToResizeRows = False
        Me.dgwLiquidacion.ColumnHeadersHeight = 25
        Me.dgwLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwLiquidacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk2, Me.CCLNFC, Me.CCMPN, Me.CDVSN, Me.CCLNT, Me.NPRLQD, Me.NUMDOC, Me.MONEDA_PL, Me.CMNDA1, Me.IVLSRV_PL, Me.TCRVTA_L, Me.TCMPCL_OP, Me.TCMPCL_FAC, Me.CRGVTA_L, Me.btnDetalleLiquidacion, Me.NOPRCN, Me.TIPODOC, Me.DCCLNT, Me.SBCLNT, Me.ESTADO_PL, Me.DESC_ESTPL, Me.Column1})
        Me.dgwLiquidacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgwLiquidacion.Location = New System.Drawing.Point(0, 136)
        Me.dgwLiquidacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwLiquidacion.Name = "dgwLiquidacion"
        Me.dgwLiquidacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwLiquidacion.RowHeadersVisible = False
        Me.dgwLiquidacion.RowHeadersWidth = 20
        Me.dgwLiquidacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwLiquidacion.Size = New System.Drawing.Size(1349, 255)
        Me.dgwLiquidacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwLiquidacion.TabIndex = 23
        Me.dgwLiquidacion.TabStop = False
        '
        'chk2
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.NullValue = False
        Me.chk2.DefaultCellStyle = DataGridViewCellStyle23
        Me.chk2.FalseValue = Nothing
        Me.chk2.HeaderText = "Selec."
        Me.chk2.IndeterminateValue = Nothing
        Me.chk2.Name = "chk2"
        Me.chk2.TrueValue = Nothing
        Me.chk2.Visible = False
        Me.chk2.Width = 46
        '
        'CCLNFC
        '
        Me.CCLNFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNFC.DataPropertyName = "CCLNFC"
        Me.CCLNFC.HeaderText = "CCLNFC"
        Me.CCLNFC.Name = "CCLNFC"
        Me.CCLNFC.ReadOnly = True
        Me.CCLNFC.Visible = False
        Me.CCLNFC.Width = 94
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'NPRLQD
        '
        Me.NPRLQD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRLQD.DataPropertyName = "NPRLQD"
        Me.NPRLQD.HeaderText = "Nro PL"
        Me.NPRLQD.Name = "NPRLQD"
        Me.NPRLQD.ReadOnly = True
        Me.NPRLQD.Width = 86
        '
        'NUMDOC
        '
        Me.NUMDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NUMDOC.HeaderText = "Nro Doc"
        Me.NUMDOC.Name = "NUMDOC"
        Me.NUMDOC.ReadOnly = True
        Me.NUMDOC.Width = 98
        '
        'MONEDA_PL
        '
        Me.MONEDA_PL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA_PL.DataPropertyName = "TSGNMN"
        Me.MONEDA_PL.HeaderText = "Moneda"
        Me.MONEDA_PL.Name = "MONEDA_PL"
        Me.MONEDA_PL.ReadOnly = True
        Me.MONEDA_PL.Width = 97
        '
        'CMNDA1
        '
        Me.CMNDA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMNDA1.DataPropertyName = "CMNDA1"
        Me.CMNDA1.HeaderText = "CMNDA1"
        Me.CMNDA1.Name = "CMNDA1"
        Me.CMNDA1.ReadOnly = True
        Me.CMNDA1.Visible = False
        Me.CMNDA1.Width = 104
        '
        'IVLSRV_PL
        '
        Me.IVLSRV_PL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IVLSRV_PL.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N5"
        Me.IVLSRV_PL.DefaultCellStyle = DataGridViewCellStyle24
        Me.IVLSRV_PL.HeaderText = "Importe"
        Me.IVLSRV_PL.Name = "IVLSRV_PL"
        Me.IVLSRV_PL.ReadOnly = True
        Me.IVLSRV_PL.Width = 95
        '
        'TCRVTA_L
        '
        Me.TCRVTA_L.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA_L.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TCRVTA_L.DefaultCellStyle = DataGridViewCellStyle25
        Me.TCRVTA_L.HeaderText = "Org. Venta"
        Me.TCRVTA_L.Name = "TCRVTA_L"
        Me.TCRVTA_L.ReadOnly = True
        Me.TCRVTA_L.Width = 111
        '
        'TCMPCL_OP
        '
        Me.TCMPCL_OP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL_OP.DataPropertyName = "TCMPCL_OP"
        Me.TCMPCL_OP.HeaderText = "Cliente"
        Me.TCMPCL_OP.Name = "TCMPCL_OP"
        Me.TCMPCL_OP.ReadOnly = True
        Me.TCMPCL_OP.Width = 88
        '
        'TCMPCL_FAC
        '
        Me.TCMPCL_FAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL_FAC.DataPropertyName = "TCMPCL_FAC"
        Me.TCMPCL_FAC.HeaderText = "Cliente Fact"
        Me.TCMPCL_FAC.Name = "TCMPCL_FAC"
        Me.TCMPCL_FAC.ReadOnly = True
        Me.TCMPCL_FAC.Width = 118
        '
        'CRGVTA_L
        '
        Me.CRGVTA_L.DataPropertyName = "CRGVTA"
        Me.CRGVTA_L.HeaderText = "CRGVTA"
        Me.CRGVTA_L.Name = "CRGVTA_L"
        Me.CRGVTA_L.ReadOnly = True
        Me.CRGVTA_L.Visible = False
        Me.CRGVTA_L.Width = 77
        '
        'btnDetalleLiquidacion
        '
        Me.btnDetalleLiquidacion.HeaderText = "Det. Liq"
        Me.btnDetalleLiquidacion.Image = Global.SOLMIN_CT.My.Resources.Resources.ok
        Me.btnDetalleLiquidacion.Name = "btnDetalleLiquidacion"
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Image = Global.SOLMIN_CT.My.Resources.Resources.text_block
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.Width = 88
        '
        'TIPODOC
        '
        Me.TIPODOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPODOC.DataPropertyName = "TIPODOC"
        Me.TIPODOC.HeaderText = "Tipo Doc"
        Me.TIPODOC.Name = "TIPODOC"
        Me.TIPODOC.ReadOnly = True
        Me.TIPODOC.Visible = False
        Me.TIPODOC.Width = 103
        '
        'DCCLNT
        '
        Me.DCCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DCCLNT.DataPropertyName = "DCCLNT"
        Me.DCCLNT.HeaderText = "Doc. Cliente"
        Me.DCCLNT.Name = "DCCLNT"
        Me.DCCLNT.ReadOnly = True
        Me.DCCLNT.Visible = False
        Me.DCCLNT.Width = 122
        '
        'SBCLNT
        '
        Me.SBCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SBCLNT.DataPropertyName = "SBCLNT"
        Me.SBCLNT.HeaderText = "Sub Doc. Cliente"
        Me.SBCLNT.Name = "SBCLNT"
        Me.SBCLNT.ReadOnly = True
        Me.SBCLNT.Visible = False
        Me.SBCLNT.Width = 151
        '
        'ESTADO_PL
        '
        Me.ESTADO_PL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO_PL.DataPropertyName = "ESTADO_PL"
        Me.ESTADO_PL.HeaderText = "ESTADO_PL"
        Me.ESTADO_PL.Name = "ESTADO_PL"
        Me.ESTADO_PL.ReadOnly = True
        Me.ESTADO_PL.Visible = False
        Me.ESTADO_PL.Width = 118
        '
        'DESC_ESTPL
        '
        Me.DESC_ESTPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_ESTPL.DataPropertyName = "DESC_ESTPL"
        Me.DESC_ESTPL.HeaderText = "Estado PL"
        Me.DESC_ESTPL.Name = "DESC_ESTPL"
        Me.DESC_ESTPL.ReadOnly = True
        Me.DESC_ESTPL.Width = 106
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'HeaderDatos
        '
        Me.HeaderDatos.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnPreDoc, Me.btnFacturaPreDoc, Me.btnVerPreDoc})
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 391)
        Me.HeaderDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.TabListaLiquidacion)
        Me.HeaderDatos.Size = New System.Drawing.Size(1349, 237)
        Me.HeaderDatos.TabIndex = 24
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'btnPreDoc
        '
        Me.btnPreDoc.ExtraText = ""
        Me.btnPreDoc.Image = Global.SOLMIN_CT.My.Resources.Resources.ok
        Me.btnPreDoc.Text = "Pre Documento"
        Me.btnPreDoc.ToolTipImage = Nothing
        Me.btnPreDoc.UniqueName = "583A8E7020CD404A583A8E7020CD404A"
        '
        'btnFacturaPreDoc
        '
        Me.btnFacturaPreDoc.ExtraText = ""
        Me.btnFacturaPreDoc.Image = Global.SOLMIN_CT.My.Resources.Resources.runprog
        Me.btnFacturaPreDoc.Text = "Facturar Pre-Documento"
        Me.btnFacturaPreDoc.ToolTipImage = Nothing
        Me.btnFacturaPreDoc.UniqueName = "E979FCA5F8B342C0E979FCA5F8B342C0"
        '
        'btnVerPreDoc
        '
        Me.btnVerPreDoc.ExtraText = ""
        Me.btnVerPreDoc.Image = Global.SOLMIN_CT.My.Resources.Resources.cell_layout
        Me.btnVerPreDoc.Text = "Ver PreDocumentos"
        Me.btnVerPreDoc.ToolTipImage = Nothing
        Me.btnVerPreDoc.UniqueName = "8BD456AFB6F646288BD456AFB6F64628"
        '
        'TabListaLiquidacion
        '
        Me.TabListaLiquidacion.Controls.Add(Me.tabLiquidacion)
        Me.TabListaLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabListaLiquidacion.Location = New System.Drawing.Point(0, 0)
        Me.TabListaLiquidacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TabListaLiquidacion.Name = "TabListaLiquidacion"
        Me.TabListaLiquidacion.SelectedIndex = 0
        Me.TabListaLiquidacion.Size = New System.Drawing.Size(1347, 204)
        Me.TabListaLiquidacion.TabIndex = 1
        '
        'tabLiquidacion
        '
        Me.tabLiquidacion.Controls.Add(Me.dtgPreDocumentos)
        Me.tabLiquidacion.Location = New System.Drawing.Point(4, 25)
        Me.tabLiquidacion.Margin = New System.Windows.Forms.Padding(4)
        Me.tabLiquidacion.Name = "tabLiquidacion"
        Me.tabLiquidacion.Padding = New System.Windows.Forms.Padding(4)
        Me.tabLiquidacion.Size = New System.Drawing.Size(1339, 175)
        Me.tabLiquidacion.TabIndex = 2
        Me.tabLiquidacion.Text = "Lista Pre-Documentos"
        Me.tabLiquidacion.UseVisualStyleBackColor = True
        '
        'dtgPreDocumentos
        '
        Me.dtgPreDocumentos.AllowUserToAddRows = False
        Me.dtgPreDocumentos.AllowUserToDeleteRows = False
        Me.dtgPreDocumentos.AllowUserToResizeColumns = False
        Me.dtgPreDocumentos.AllowUserToResizeRows = False
        Me.dtgPreDocumentos.ColumnHeadersHeight = 25
        Me.dtgPreDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPreDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRCTRL, Me.TPCTRL, Me.NCRRPD, Me.ID_MONEDA, Me.DESC_MONEDA, Me.IMPORTE, Me.TIP_DOC_CLIENTE, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.TIPO_DOC_FACT, Me.NRO_DOC_FACT, Me.OPERACION, Me.TCMPDV, Me.TPLNTA, Me.SESTOP_DESC, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.NSECFC, Me.TCMTRF, Me.TSGNMN, Me.IVLSRV, Me.TABTPD, Me.NDCMFC, Me.asd})
        Me.dtgPreDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPreDocumentos.Location = New System.Drawing.Point(4, 4)
        Me.dtgPreDocumentos.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgPreDocumentos.Name = "dtgPreDocumentos"
        Me.dtgPreDocumentos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgPreDocumentos.RowHeadersVisible = False
        Me.dtgPreDocumentos.RowHeadersWidth = 20
        Me.dtgPreDocumentos.Size = New System.Drawing.Size(1331, 167)
        Me.dtgPreDocumentos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPreDocumentos.TabIndex = 21
        Me.dtgPreDocumentos.TabStop = False
        '
        'NRCTRL
        '
        Me.NRCTRL.DataPropertyName = "NRCTRL"
        Me.NRCTRL.HeaderText = "NRCTRL"
        Me.NRCTRL.Name = "NRCTRL"
        Me.NRCTRL.Visible = False
        '
        'TPCTRL
        '
        Me.TPCTRL.DataPropertyName = "TPCTRL"
        Me.TPCTRL.HeaderText = "TPCTRL"
        Me.TPCTRL.Name = "TPCTRL"
        Me.TPCTRL.Visible = False
        '
        'NCRRPD
        '
        Me.NCRRPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRPD.DataPropertyName = "NCRRPD"
        Me.NCRRPD.HeaderText = "Id Pre-Doc"
        Me.NCRRPD.Name = "NCRRPD"
        Me.NCRRPD.ReadOnly = True
        Me.NCRRPD.Width = 113
        '
        'ID_MONEDA
        '
        Me.ID_MONEDA.DataPropertyName = "ID_MONEDA"
        Me.ID_MONEDA.HeaderText = "ID_MONEDA"
        Me.ID_MONEDA.Name = "ID_MONEDA"
        Me.ID_MONEDA.Visible = False
        '
        'DESC_MONEDA
        '
        Me.DESC_MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_MONEDA.DataPropertyName = "DESC_MONEDA"
        Me.DESC_MONEDA.HeaderText = "Moneda"
        Me.DESC_MONEDA.Name = "DESC_MONEDA"
        Me.DESC_MONEDA.ReadOnly = True
        Me.DESC_MONEDA.Width = 97
        '
        'IMPORTE
        '
        Me.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPORTE.DataPropertyName = "IMPORTE"
        Me.IMPORTE.HeaderText = "Importe"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        Me.IMPORTE.Width = 95
        '
        'TIP_DOC_CLIENTE
        '
        Me.TIP_DOC_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIP_DOC_CLIENTE.DataPropertyName = "TIP_DOC_CLIENTE"
        Me.TIP_DOC_CLIENTE.HeaderText = "Tipo Doc Cliente"
        Me.TIP_DOC_CLIENTE.Name = "TIP_DOC_CLIENTE"
        Me.TIP_DOC_CLIENTE.ReadOnly = True
        Me.TIP_DOC_CLIENTE.Width = 153
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "DCCLNT"
        Me.DataGridViewTextBoxColumn71.HeaderText = "Doc. Cliente"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        Me.DataGridViewTextBoxColumn71.ReadOnly = True
        Me.DataGridViewTextBoxColumn71.Width = 122
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "SBCLNT"
        Me.DataGridViewTextBoxColumn72.HeaderText = "Sub Doc Cliente"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.ReadOnly = True
        Me.DataGridViewTextBoxColumn72.Visible = False
        Me.DataGridViewTextBoxColumn72.Width = 148
        '
        'TIPO_DOC_FACT
        '
        Me.TIPO_DOC_FACT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_DOC_FACT.DataPropertyName = "TIPO_DOC_FACT"
        Me.TIPO_DOC_FACT.HeaderText = "Tipo Doc Fact"
        Me.TIPO_DOC_FACT.Name = "TIPO_DOC_FACT"
        Me.TIPO_DOC_FACT.ReadOnly = True
        Me.TIPO_DOC_FACT.Width = 133
        '
        'NRO_DOC_FACT
        '
        Me.NRO_DOC_FACT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRO_DOC_FACT.DataPropertyName = "NRO_DOC_FACT"
        Me.NRO_DOC_FACT.HeaderText = "Nro Doc. Fact"
        Me.NRO_DOC_FACT.Name = "NRO_DOC_FACT"
        Me.NRO_DOC_FACT.ReadOnly = True
        Me.NRO_DOC_FACT.Width = 131
        '
        'OPERACION
        '
        Me.OPERACION.DataPropertyName = "OPERACION"
        Me.OPERACION.HeaderText = "Operación"
        Me.OPERACION.Image = Global.SOLMIN_CT.My.Resources.Resources.text_block
        Me.OPERACION.Name = "OPERACION"
        '
        'TCMPDV
        '
        Me.TCMPDV.DataPropertyName = "División"
        Me.TCMPDV.HeaderText = "TCMPDV"
        Me.TCMPDV.Name = "TCMPDV"
        Me.TCMPDV.Visible = False
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "Planta"
        Me.TPLNTA.HeaderText = "TPLNTA"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.Visible = False
        '
        'SESTOP_DESC
        '
        Me.SESTOP_DESC.DataPropertyName = "Estado OP."
        Me.SESTOP_DESC.HeaderText = "SESTOP_DESC"
        Me.SESTOP_DESC.Name = "SESTOP_DESC"
        Me.SESTOP_DESC.Visible = False
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "Pre-Factura"
        Me.DataGridViewTextBoxColumn73.HeaderText = "NDCPRF"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.Visible = False
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "Pre-Liquidación"
        Me.DataGridViewTextBoxColumn74.HeaderText = "NPRLQD"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        Me.DataGridViewTextBoxColumn74.Visible = False
        '
        'NSECFC
        '
        Me.NSECFC.DataPropertyName = "Número Consistencia"
        Me.NSECFC.HeaderText = "NSECFC"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.Visible = False
        '
        'TCMTRF
        '
        Me.TCMTRF.DataPropertyName = "Servicio"
        Me.TCMTRF.HeaderText = "TCMTRF"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.Visible = False
        '
        'TSGNMN
        '
        Me.TSGNMN.DataPropertyName = "Moneda"
        Me.TSGNMN.HeaderText = "TSGNMN"
        Me.TSGNMN.Name = "TSGNMN"
        Me.TSGNMN.Visible = False
        '
        'IVLSRV
        '
        Me.IVLSRV.DataPropertyName = "Importe"
        Me.IVLSRV.HeaderText = "IVLSRV"
        Me.IVLSRV.Name = "IVLSRV"
        Me.IVLSRV.Visible = False
        '
        'TABTPD
        '
        Me.TABTPD.DataPropertyName = "Tipo Doc Fac"
        Me.TABTPD.HeaderText = "TABTPD"
        Me.TABTPD.Name = "TABTPD"
        Me.TABTPD.Visible = False
        '
        'NDCMFC
        '
        Me.NDCMFC.DataPropertyName = "Factura"
        Me.NDCMFC.HeaderText = "NDCMFC"
        Me.NDCMFC.Name = "NDCMFC"
        Me.NDCMFC.Visible = False
        '
        'asd
        '
        Me.asd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.asd.HeaderText = ""
        Me.asd.Name = "asd"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPRLQD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro PL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TOTAL_SOL"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle26.Format = "N5"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn2.HeaderText = "Importe por Cobrar S/."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TOTAL_DOL"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N5"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe por Cobrar $"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VLR_SOL"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewTextBoxColumn4.HeaderText = "Valorización S/."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VLR_DOL"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn5.HeaderText = "Valorización $."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn6.HeaderText = "Organización Venta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CRGVTA"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EN_VLR"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "N5"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn8.HeaderText = "En Valorización"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "VLR_CANT"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn9.HeaderText = "VLR_CANT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TIPODOC"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo Doc"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DCCLNT"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Doc. Cliente"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SBCLNT"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Sub Doc. Cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SBCLNT"
        Me.DataGridViewTextBoxColumn13.HeaderText = ""
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NRCTRL"
        Me.DataGridViewTextBoxColumn14.HeaderText = "NRCTRL"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TPCTRL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "TPCTRL"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NCRRPD"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Id Pre-Doc"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ID_MONEDA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ID_MONEDA"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "DESC_MONEDA"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "IMPORTE"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TIP_DOC_CLIENTE"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Tipo Doc Cliente"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "DCCLNT"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Doc. Cliente"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "SBCLNT"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Sub Doc Cliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TIPO_DOC_FACT"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Tipo Doc Fact"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NRO_DOC_FACT"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Nro Doc. Fact"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "División"
        Me.DataGridViewTextBoxColumn25.HeaderText = "TCMPDV"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Planta"
        Me.DataGridViewTextBoxColumn26.HeaderText = "TPLNTA"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Estado OP."
        Me.DataGridViewTextBoxColumn27.HeaderText = "SESTOP_DESC"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Pre-Factura"
        Me.DataGridViewTextBoxColumn28.HeaderText = "NDCPRF"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Pre-Liquidación"
        Me.DataGridViewTextBoxColumn29.HeaderText = "NPRLQD"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Número Consistencia"
        Me.DataGridViewTextBoxColumn30.HeaderText = "NSECFC"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Servicio"
        Me.DataGridViewTextBoxColumn31.HeaderText = "TCMTRF"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn32.HeaderText = "TSGNMN"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Importe"
        Me.DataGridViewTextBoxColumn33.HeaderText = "IVLSRV"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Tipo Doc Fac"
        Me.DataGridViewTextBoxColumn34.HeaderText = "TABTPD"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Visible = False
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Factura"
        Me.DataGridViewTextBoxColumn35.HeaderText = "NDCMFC"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Importe"
        Me.DataGridViewTextBoxColumn36.HeaderText = ""
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Tipo Doc Fac"
        Me.DataGridViewTextBoxColumn37.HeaderText = "TABTPD"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Factura"
        Me.DataGridViewTextBoxColumn38.HeaderText = "NDCMFC"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Visible = False
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Importe"
        Me.DataGridViewTextBoxColumn39.HeaderText = ""
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Visible = False
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Tipo Doc Fac"
        Me.DataGridViewTextBoxColumn40.HeaderText = "TABTPD"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Factura"
        Me.DataGridViewTextBoxColumn41.HeaderText = "NDCMFC"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Visible = False
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn42.HeaderText = ""
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'frmPLFacElectronicoSD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 628)
        Me.Controls.Add(Me.HeaderDatos)
        Me.Controls.Add(Me.dgwLiquidacion)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.PanelFiltros)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPLFacElectronicoSD"
        Me.Text = "Facturación por PreLiquidación"
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.dgwLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.TabListaLiquidacion.ResumeLayout(False)
        Me.tabLiquidacion.ResumeLayout(False)
        CType(Me.dtgPreDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFacturaPreLiquidacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnularPreliquidacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditPL As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgwLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnPreDoc As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents TabListaLiquidacion As System.Windows.Forms.TabControl
    Friend WithEvents tabLiquidacion As System.Windows.Forms.TabPage
    Friend WithEvents dtgPreDocumentos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnFacturaPreDoc As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRCTRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPCTRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIP_DOC_CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_DOC_FACT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_FACT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OPERACION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TCMPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOP_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSGNMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVLSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCMFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVerPreDoc As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents btncheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents CCLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRLQD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA_PL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVLSRV_PL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA_L As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL_OP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL_FAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRGVTA_L As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDetalleLiquidacion As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TIPODOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_PL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ESTPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkAvance As System.Windows.Forms.CheckBox
    Friend WithEvents lblAvance As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblseleccionados As System.Windows.Forms.ToolStripLabel
End Class
