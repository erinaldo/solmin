<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprobacionValorizacion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAprobacionValorizacion))
        Dim BeCompania2 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.spContainer001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dtgOperaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNFCVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QDAPVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBSE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.UcCliente_TxtF011 = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
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
        Me.TypeValidator1 = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
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
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1288, 641)
        Me.KryptonPanel.TabIndex = 0
        '
        'spContainer001
        '
        Me.spContainer001.Cursor = System.Windows.Forms.Cursors.Default
        Me.spContainer001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spContainer001.Location = New System.Drawing.Point(0, 138)
        Me.spContainer001.Margin = New System.Windows.Forms.Padding(4)
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
        Me.spContainer001.Size = New System.Drawing.Size(1288, 503)
        Me.spContainer001.SplitterDistance = 179
        Me.spContainer001.TabIndex = 6
        '
        'dtgOperaciones
        '
        Me.dtgOperaciones.AllowUserToAddRows = False
        Me.dtgOperaciones.AllowUserToDeleteRows = False
        Me.dtgOperaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.CCLNT, Me.CNFCVL, Me.TCMPCL, Me.REFCNT, Me.QDAPVL, Me.TOBSE1, Me.SESTRG, Me.CUSCRT, Me.CULUSA})
        Me.dtgOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.dtgOperaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgOperaciones.Name = "dtgOperaciones"
        Me.dtgOperaciones.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgOperaciones.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOperaciones.Size = New System.Drawing.Size(1288, 179)
        Me.dtgOperaciones.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgOperaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOperaciones.TabIndex = 6
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CodCompañia"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CCLNT
        '
        Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cod. Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Width = 122
        '
        'CNFCVL
        '
        Me.CNFCVL.DataPropertyName = "CNFCVL"
        Me.CNFCVL.HeaderText = "Correlativo"
        Me.CNFCVL.Name = "CNFCVL"
        Me.CNFCVL.ReadOnly = True
        Me.CNFCVL.Width = 70
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Cliente"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        Me.TCMPCL.Width = 88
        '
        'REFCNT
        '
        Me.REFCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REFCNT.DataPropertyName = "REFCNT"
        Me.REFCNT.HeaderText = "Fecha Corte (Valorización)"
        Me.REFCNT.Name = "REFCNT"
        Me.REFCNT.ReadOnly = True
        Me.REFCNT.Width = 215
        '
        'QDAPVL
        '
        Me.QDAPVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QDAPVL.DataPropertyName = "QDAPVL"
        Me.QDAPVL.HeaderText = "Tiempo Aprobación Valorización (días)"
        Me.QDAPVL.Name = "QDAPVL"
        Me.QDAPVL.ReadOnly = True
        Me.QDAPVL.Width = 301
        '
        'TOBSE1
        '
        Me.TOBSE1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBSE1.DataPropertyName = "TOBSE1"
        Me.TOBSE1.HeaderText = "Observación"
        Me.TOBSE1.Name = "TOBSE1"
        Me.TOBSE1.ReadOnly = True
        Me.TOBSE1.Width = 124
        '
        'SESTRG
        '
        Me.SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "Estado"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Width = 87
        '
        'CUSCRT
        '
        Me.CUSCRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "Usuario Creador"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.ReadOnly = True
        Me.CUSCRT.Width = 149
        '
        'CULUSA
        '
        Me.CULUSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "Usuario Actualizador"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.ReadOnly = True
        Me.CULUSA.Width = 180
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.UcCliente_TxtF011)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.txtObservacion)
        Me.KryptonPanel2.Controls.Add(Me.txtTiempoAprobacion)
        Me.KryptonPanel2.Controls.Add(Me.txtFchCorte)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel2.Controls.Add(Me.lblCompania)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 52)
        Me.KryptonPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(1288, 202)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 8
        '
        'UcCliente_TxtF011
        '
        Me.UcCliente_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente_TxtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcCliente_TxtF011.CCMPN = "EZ"
        Me.UcCliente_TxtF011.Location = New System.Drawing.Point(217, 20)
        Me.UcCliente_TxtF011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCliente_TxtF011.Name = "UcCliente_TxtF011"
        Me.UcCliente_TxtF011.pAccesoPorUsuario = False
        Me.UcCliente_TxtF011.pCDDRSP_CodClienteSAP = ""
        Me.UcCliente_TxtF011.pRequerido = False
        Me.UcCliente_TxtF011.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente_TxtF011.pVisualizaNegocio = False
        Me.UcCliente_TxtF011.Size = New System.Drawing.Size(300, 26)
        Me.UcCliente_TxtF011.TabIndex = 0
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 20)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 24)
        Me.KryptonLabel3.TabIndex = 89
        Me.KryptonLabel3.Text = "Cliente :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cliente :"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(638, 20)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservacion.MaxLength = 50
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(458, 104)
        Me.txtObservacion.TabIndex = 3
        '
        'txtTiempoAprobacion
        '
        Me.txtTiempoAprobacion.Location = New System.Drawing.Point(217, 88)
        Me.txtTiempoAprobacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTiempoAprobacion.MaxLength = 3
        Me.txtTiempoAprobacion.Name = "txtTiempoAprobacion"
        Me.txtTiempoAprobacion.Size = New System.Drawing.Size(300, 26)
        Me.txtTiempoAprobacion.TabIndex = 2
        '
        'txtFchCorte
        '
        Me.txtFchCorte.Location = New System.Drawing.Point(217, 54)
        Me.txtFchCorte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFchCorte.MaxLength = 20
        Me.txtFchCorte.Name = "txtFchCorte"
        Me.txtFchCorte.Size = New System.Drawing.Size(300, 26)
        Me.txtFchCorte.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 88)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(190, 24)
        Me.KryptonLabel1.TabIndex = 51
        Me.KryptonLabel1.Text = "Tiempo Aprobación(días) :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tiempo Aprobación(días) :"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(11, 54)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(96, 24)
        Me.KryptonLabel9.TabIndex = 50
        Me.KryptonLabel9.Text = "Fecha Corte:"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Fecha Corte:"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(526, 20)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(104, 24)
        Me.lblCompania.TabIndex = 36
        Me.lblCompania.Text = "Observación :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Observación :"
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator3, Me.btnGuardar, Me.ToolStripSeparator4, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnAnularCancelar})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(1288, 27)
        Me.ToolStrip3.TabIndex = 7
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(76, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnAnularCancelar
        '
        Me.btnAnularCancelar.Image = CType(resources.GetObject("btnAnularCancelar.Image"), System.Drawing.Image)
        Me.btnAnularCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnularCancelar.Name = "btnAnularCancelar"
        Me.btnAnularCancelar.Size = New System.Drawing.Size(122, 24)
        Me.btnAnularCancelar.Text = "Anular/Cerrar"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1288, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(215, 22)
        Me.ToolStripLabel1.Text = "Informacion de Mantenimiento"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.tss001, Me.btnExportar, Me.tss002})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 111)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1288, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'tss001
        '
        Me.tss001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss001.Name = "tss001"
        Me.tss001.Size = New System.Drawing.Size(6, 27)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(127, 24)
        Me.btnExportar.Text = "Exportar Excel"
        '
        'tss002
        '
        Me.tss002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss002.Name = "tss002"
        Me.tss002.Size = New System.Drawing.Size(6, 27)
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Margin = New System.Windows.Forms.Padding(4)
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
        Me.HGFiltro.Size = New System.Drawing.Size(1288, 111)
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
        Me.cmbEstado.ItemHeight = 20
        Me.cmbEstado.Location = New System.Drawing.Point(931, 11)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(237, 28)
        Me.cmbEstado.TabIndex = 90
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(852, 12)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(65, 24)
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
        Me.UcCliente.Location = New System.Drawing.Point(460, 10)
        Me.UcCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCliente.Name = "UcCliente"
        Me.UcCliente.pAccesoPorUsuario = False
        Me.UcCliente.pCDDRSP_CodClienteSAP = ""
        Me.UcCliente.pRequerido = False
        Me.UcCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente.pVisualizaNegocio = False
        Me.UcCliente.Size = New System.Drawing.Size(364, 26)
        Me.UcCliente.TabIndex = 86
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(381, 11)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(66, 24)
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
        Me.UcCompania.Location = New System.Drawing.Point(103, 6)
        Me.UcCompania.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania.Name = "UcCompania"
        BeCompania2.CCMPN_CodigoCompania = ""
        BeCompania2.Orden = -1
        BeCompania2.TCMPCM_DescripcionCompania = ""
        Me.UcCompania.oBeCompania = BeCompania2
        Me.UcCompania.Size = New System.Drawing.Size(271, 30)
        Me.UcCompania.TabIndex = 0
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(7, 11)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Text = "Compañia :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia :"
        '
        'frmAprobacionValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 641)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAprobacionValorizacion"
        Me.Text = "Aprobación de Valorización"
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
    Friend WithEvents UcCliente_TxtF011 As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNFCVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QDAPVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
