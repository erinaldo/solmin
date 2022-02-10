<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionValorizacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracionValorizacion))
        Dim BeCompania1 As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania = New Ransa.TypeDef.UbicacionPlanta.Compania.beCompania()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.spContainer001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dtgOperaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.txtTiempoAprobacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtFchCorte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnularCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tss001 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.tss002 = New System.Windows.Forms.ToolStripSeparator()
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.cmbEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator1 = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNFCVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QDAPVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBSE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NTRMCR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HULTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.spContainer001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spContainer001.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spContainer001.Panel1.SuspendLayout()
        CType(Me.spContainer001.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spContainer001.Panel2.SuspendLayout()
        Me.spContainer001.SuspendLayout()
        CType(Me.dtgOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.spContainer001)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(966, 521)
        Me.KryptonPanel.TabIndex = 0
        '
        'spContainer001
        '
        Me.spContainer001.Cursor = System.Windows.Forms.Cursors.Default
        Me.spContainer001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spContainer001.Location = New System.Drawing.Point(0, 115)
        Me.spContainer001.Name = "spContainer001"
        Me.spContainer001.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spContainer001.Panel1
        '
        Me.spContainer001.Panel1.Controls.Add(Me.dtgOperaciones)
        '
        'spContainer001.Panel2
        '
        Me.spContainer001.Panel2.Controls.Add(Me.KryptonPanel2)
        Me.spContainer001.Panel2.Controls.Add(Me.ToolStrip3)
        Me.spContainer001.Panel2.Controls.Add(Me.ToolStrip2)
        Me.spContainer001.Size = New System.Drawing.Size(966, 406)
        Me.spContainer001.SplitterDistance = 145
        Me.spContainer001.TabIndex = 6
        '
        'dtgOperaciones
        '
        Me.dtgOperaciones.AllowUserToAddRows = False
        Me.dtgOperaciones.AllowUserToDeleteRows = False
        Me.dtgOperaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.CNFCVL, Me.CCLNT, Me.TCMPCL, Me.REFCNT, Me.QDAPVL, Me.TOBSE1, Me.NTRMCR, Me.SESTRG, Me.CUSCRT, Me.FCHCRT, Me.HRACRT, Me.FULTAC, Me.HULTAC, Me.CULUSA})
        Me.dtgOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.dtgOperaciones.Name = "dtgOperaciones"
        Me.dtgOperaciones.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgOperaciones.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOperaciones.Size = New System.Drawing.Size(966, 145)
        Me.dtgOperaciones.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgOperaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOperaciones.TabIndex = 6
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.txtObservacion)
        Me.KryptonPanel2.Controls.Add(Me.txtTiempoAprobacion)
        Me.KryptonPanel2.Controls.Add(Me.txtFchCorte)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel2.Controls.Add(Me.lblCompania)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 50)
        Me.KryptonPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(966, 164)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 8
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(174, 37)
        Me.txtObservacion.MaxLength = 50
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(225, 110)
        Me.txtObservacion.TabIndex = 55
        '
        'txtTiempoAprobacion
        '
        Me.txtTiempoAprobacion.Location = New System.Drawing.Point(629, 9)
        Me.txtTiempoAprobacion.MaxLength = 20
        Me.txtTiempoAprobacion.Name = "txtTiempoAprobacion"
        Me.txtTiempoAprobacion.Size = New System.Drawing.Size(225, 22)
        Me.txtTiempoAprobacion.TabIndex = 54
        '
        'txtFchCorte
        '
        Me.txtFchCorte.Location = New System.Drawing.Point(174, 9)
        Me.txtFchCorte.MaxLength = 20
        Me.txtFchCorte.Name = "txtFchCorte"
        Me.txtFchCorte.Size = New System.Drawing.Size(225, 22)
        Me.txtFchCorte.TabIndex = 52
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(408, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(227, 20)
        Me.KryptonLabel1.TabIndex = 51
        Me.KryptonLabel1.Text = "Tiempo Aprobación Valorización (dias) :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tiempo Aprobación Valorización (dias) :"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(10, 9)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(158, 20)
        Me.KryptonLabel9.TabIndex = 50
        Me.KryptonLabel9.Text = "Fecha Corte (Valorización) :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Fecha Corte (Valorización) :"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(23, 35)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(84, 20)
        Me.lblCompania.TabIndex = 36
        Me.lblCompania.Text = "Observacion :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Observacion :"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator3, Me.btnGuardar, Me.ToolStripSeparator4, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAnularCancelar})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(966, 25)
        Me.ToolStrip3.TabIndex = 7
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAnularCancelar
        '
        Me.btnAnularCancelar.Image = CType(resources.GetObject("btnAnularCancelar.Image"), System.Drawing.Image)
        Me.btnAnularCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnularCancelar.Name = "btnAnularCancelar"
        Me.btnAnularCancelar.Size = New System.Drawing.Size(99, 22)
        Me.btnAnularCancelar.Text = "Anular/Cerrar"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(966, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripLabel1.Text = "Informacion de Mantenimiento"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.tss001, Me.btnExportar, Me.tss002})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 90)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(966, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'tss001
        '
        Me.tss001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss001.Name = "tss001"
        Me.tss001.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(99, 22)
        Me.btnExportar.Text = "Exportar Excel"
        '
        'tss002
        '
        Me.tss002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss002.Name = "tss002"
        Me.tss002.Size = New System.Drawing.Size(6, 25)
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.cmbEstado)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HGFiltro.Panel.Controls.Add(Me.UcCliente)
        Me.HGFiltro.Panel.Controls.Add(Me.lblCliente)
        Me.HGFiltro.Panel.Controls.Add(Me.UcCompania)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HGFiltro.Size = New System.Drawing.Size(966, 90)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 2
        Me.HGFiltro.Text = "Filtro"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Filtro"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.DropDownWidth = 162
        Me.cmbEstado.FormattingEnabled = False
        Me.cmbEstado.ItemHeight = 15
        Me.cmbEstado.Location = New System.Drawing.Point(698, 9)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(178, 23)
        Me.cmbEstado.TabIndex = 90
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(639, 10)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel2.TabIndex = 88
        Me.KryptonLabel2.Text = "Estado :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Estado :"
        '
        'UcCliente
        '
        Me.UcCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcCliente.CCMPN = "EZ"
        Me.UcCliente.Location = New System.Drawing.Point(345, 8)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pCDDRSP_CodClienteSAP = ""
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.pVisualizaNegocio = False
        Me.UcCliente.Size = New System.Drawing.Size(273, 22)
        Me.UcCliente.TabIndex = 86
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(286, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(54, 20)
        Me.lblCliente.TabIndex = 87
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Habilitar = True
        Me.UcCompania.Location = New System.Drawing.Point(77, 5)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania.oBeCompania = BeCompania1
        Me.UcCompania.Size = New System.Drawing.Size(203, 24)
        Me.UcCompania.TabIndex = 0
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(5, 9)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Text = "Compañia :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia :"
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CodCompañia"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CNFCVL
        '
        Me.CNFCVL.DataPropertyName = "CNFCVL"
        Me.CNFCVL.HeaderText = "Correlativo"
        Me.CNFCVL.Name = "CNFCVL"
        Me.CNFCVL.ReadOnly = True
        Me.CNFCVL.Width = 70
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cod. Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Width = 80
        '
        'TCMPCL
        '
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Cliente"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        Me.TCMPCL.Width = 120
        '
        'REFCNT
        '
        Me.REFCNT.DataPropertyName = "REFCNT"
        Me.REFCNT.HeaderText = "Fecha Corte (Valorizacion)"
        Me.REFCNT.Name = "REFCNT"
        Me.REFCNT.ReadOnly = True
        '
        'QDAPVL
        '
        Me.QDAPVL.DataPropertyName = "QDAPVL"
        Me.QDAPVL.HeaderText = "Tiempo Aprobacion Valorizacion (dias)"
        Me.QDAPVL.Name = "QDAPVL"
        Me.QDAPVL.ReadOnly = True
        Me.QDAPVL.Width = 150
        '
        'TOBSE1
        '
        Me.TOBSE1.DataPropertyName = "TOBSE1"
        Me.TOBSE1.HeaderText = "Observacion"
        Me.TOBSE1.Name = "TOBSE1"
        Me.TOBSE1.ReadOnly = True
        '
        'NTRMCR
        '
        Me.NTRMCR.DataPropertyName = "NTRMCR"
        Me.NTRMCR.HeaderText = "Num Terminal"
        Me.NTRMCR.Name = "NTRMCR"
        Me.NTRMCR.ReadOnly = True
        Me.NTRMCR.Visible = False
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "Flg Estado"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Visible = False
        '
        'CUSCRT
        '
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "Cod Usuario Creador"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.ReadOnly = True
        Me.CUSCRT.Visible = False
        '
        'FCHCRT
        '
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "Fecha Creacion"
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.ReadOnly = True
        '
        'HRACRT
        '
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "Hora Creacion"
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.ReadOnly = True
        Me.HRACRT.Visible = False
        '
        'FULTAC
        '
        Me.FULTAC.DataPropertyName = "FULTAC"
        Me.FULTAC.HeaderText = "Fecha Ultima Actualizacion"
        Me.FULTAC.Name = "FULTAC"
        Me.FULTAC.ReadOnly = True
        Me.FULTAC.Width = 155
        '
        'HULTAC
        '
        Me.HULTAC.DataPropertyName = "HULTAC"
        Me.HULTAC.HeaderText = "Hora Ultima Actualizacion"
        Me.HULTAC.Name = "HULTAC"
        Me.HULTAC.ReadOnly = True
        Me.HULTAC.Visible = False
        '
        'CULUSA
        '
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "Cod Usuario Actualizador"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.ReadOnly = True
        Me.CULUSA.Visible = False
        '
        'frmConfiguracionValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 521)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConfiguracionValorizacion"
        Me.Text = "Configuración de Valorización"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.spContainer001.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContainer001.Panel1.ResumeLayout(False)
        CType(Me.spContainer001.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContainer001.Panel2.ResumeLayout(False)
        Me.spContainer001.Panel2.PerformLayout()
        CType(Me.spContainer001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContainer001.ResumeLayout(False)
        CType(Me.dtgOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
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
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TypeValidator1 As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents spContainer001 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dtgOperaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnularCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UcCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTiempoAprobacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtFchCorte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNFCVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QDAPVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTRMCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HULTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
