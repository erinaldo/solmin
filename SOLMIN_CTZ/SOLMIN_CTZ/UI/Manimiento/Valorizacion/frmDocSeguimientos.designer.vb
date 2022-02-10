<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocSeguimientos
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocSeguimientos))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.dtgValorizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NROVLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCVLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QDAPVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMP_SOL_NRO_SEG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMP_DOL_NRO_SEG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO_VLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROSGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_ENVIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA_ENVIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_ENVIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aprobador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_APROB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA_APROB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBS_ENVIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBS_APROB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENVIOS = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.UsuarioRegistrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAnulacion = New System.Windows.Forms.ToolStripButton()
        Me.TabGrupoClientes = New System.Windows.Forms.TabControl()
        Me.tabOpValorizacion = New System.Windows.Forms.TabPage()
        Me.dtgOpValorizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabNroEnvio = New System.Windows.Forms.TabPage()
        Me.dtgEnvioValorizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Division = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Planta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreLiquidacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroConsistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteSoles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDolares = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TabDocSeg = New System.Windows.Forms.TabPage()
        Me.kdgvdocseg = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NROSGV_DS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENVIOS_DS = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEliminarDet = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.lblNroValorización = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroValorizacion = New System.Windows.Forms.TextBox()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnEnviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPorCobranza = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPorCobrador = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPorCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExportar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReporte = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRptRegVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRptServCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRptModFact = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dtgValorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabGrupoClientes.SuspendLayout()
        Me.tabOpValorizacion.SuspendLayout()
        CType(Me.dtgOpValorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNroEnvio.SuspendLayout()
        CType(Me.dtgEnvioValorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDocSeg.SuspendLayout()
        CType(Me.kdgvdocseg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1134, 722)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 77)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtgValorizacion)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.TabGrupoClientes)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1134, 645)
        Me.KryptonSplitContainer1.SplitterDistance = 285
        Me.KryptonSplitContainer1.TabIndex = 3
        '
        'dtgValorizacion
        '
        Me.dtgValorizacion.AllowUserToAddRows = False
        Me.dtgValorizacion.AllowUserToDeleteRows = False
        Me.dtgValorizacion.AllowUserToResizeRows = False
        Me.dtgValorizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROVLR, Me.CCMPN, Me.CCLNT, Me.CLIENTE, Me.DOCVLR, Me.REFCNT, Me.QDAPVL, Me.IMP_SOL_NRO_SEG, Me.IMP_DOL_NRO_SEG, Me.ESTADO_VLR, Me.NROSGV, Me.Destino, Me.FECHA_ENVIO, Me.HORA_ENVIO, Me.USUARIO_ENVIO, Me.Aprobador, Me.FECHA_APROB, Me.HORA_APROB, Me.TOBS_ENVIO, Me.TOBS_APROB, Me.ENVIOS, Me.UsuarioRegistrado, Me.CULUSA, Me.NCRRDE, Me.NCRRDA})
        Me.dtgValorizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgValorizacion.Location = New System.Drawing.Point(0, 27)
        Me.dtgValorizacion.Margin = New System.Windows.Forms.Padding(0)
        Me.dtgValorizacion.Name = "dtgValorizacion"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgValorizacion.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgValorizacion.Size = New System.Drawing.Size(1134, 258)
        Me.dtgValorizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgValorizacion.TabIndex = 6
        '
        'NROVLR
        '
        Me.NROVLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NROVLR.DataPropertyName = "NROVLR"
        Me.NROVLR.HeaderText = "Nro Valorización"
        Me.NROVLR.Name = "NROVLR"
        Me.NROVLR.Width = 152
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "Compañia"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.Visible = False
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CodCliente"
        Me.CCLNT.Name = "CCLNT"
        '
        'CLIENTE
        '
        Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLIENTE.DataPropertyName = "CLIENTE"
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Width = 88
        '
        'DOCVLR
        '
        Me.DOCVLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DOCVLR.DataPropertyName = "DOCVLR"
        Me.DOCVLR.HeaderText = "N° Doc Valoriz."
        Me.DOCVLR.Name = "DOCVLR"
        Me.DOCVLR.Width = 142
        '
        'REFCNT
        '
        Me.REFCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REFCNT.DataPropertyName = "REFCNT"
        Me.REFCNT.HeaderText = "Fecha Cierre"
        Me.REFCNT.Name = "REFCNT"
        Me.REFCNT.Width = 123
        '
        'QDAPVL
        '
        Me.QDAPVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QDAPVL.DataPropertyName = "QDAPVL"
        Me.QDAPVL.HeaderText = "Tiempo Aprobación"
        Me.QDAPVL.Name = "QDAPVL"
        Me.QDAPVL.Width = 175
        '
        'IMP_SOL_NRO_SEG
        '
        Me.IMP_SOL_NRO_SEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMP_SOL_NRO_SEG.DataPropertyName = "IMP_SOL_NRO_SEG"
        Me.IMP_SOL_NRO_SEG.HeaderText = "Imp. S/. Doc. Seg"
        Me.IMP_SOL_NRO_SEG.Name = "IMP_SOL_NRO_SEG"
        Me.IMP_SOL_NRO_SEG.Width = 155
        '
        'IMP_DOL_NRO_SEG
        '
        Me.IMP_DOL_NRO_SEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMP_DOL_NRO_SEG.DataPropertyName = "IMP_DOL_NRO_SEG"
        Me.IMP_DOL_NRO_SEG.HeaderText = "Imp. $ Doc. Seg."
        Me.IMP_DOL_NRO_SEG.Name = "IMP_DOL_NRO_SEG"
        Me.IMP_DOL_NRO_SEG.Width = 149
        '
        'ESTADO_VLR
        '
        Me.ESTADO_VLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO_VLR.DataPropertyName = "ESTADO_VLR"
        Me.ESTADO_VLR.HeaderText = "Estado"
        Me.ESTADO_VLR.Name = "ESTADO_VLR"
        Me.ESTADO_VLR.Width = 87
        '
        'NROSGV
        '
        Me.NROSGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NROSGV.DataPropertyName = "NROSGV"
        Me.NROSGV.HeaderText = "Nro Doc. Seg"
        Me.NROSGV.Name = "NROSGV"
        Me.NROSGV.Width = 130
        '
        'Destino
        '
        Me.Destino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Destino.DataPropertyName = "DESTINO"
        Me.Destino.HeaderText = "Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.Width = 93
        '
        'FECHA_ENVIO
        '
        Me.FECHA_ENVIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHA_ENVIO.DataPropertyName = "FECHA_ENVIO"
        Me.FECHA_ENVIO.HeaderText = "Fecha Envío"
        Me.FECHA_ENVIO.Name = "FECHA_ENVIO"
        Me.FECHA_ENVIO.Visible = False
        '
        'HORA_ENVIO
        '
        Me.HORA_ENVIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HORA_ENVIO.DataPropertyName = "HORA_ENVIO"
        Me.HORA_ENVIO.HeaderText = "Hora Envío"
        Me.HORA_ENVIO.Name = "HORA_ENVIO"
        Me.HORA_ENVIO.Visible = False
        '
        'USUARIO_ENVIO
        '
        Me.USUARIO_ENVIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUARIO_ENVIO.DataPropertyName = "USUARIO_ENVIO"
        Me.USUARIO_ENVIO.HeaderText = "Usuario Envío"
        Me.USUARIO_ENVIO.Name = "USUARIO_ENVIO"
        Me.USUARIO_ENVIO.Visible = False
        '
        'Aprobador
        '
        Me.Aprobador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Aprobador.DataPropertyName = "APROBADOR"
        Me.Aprobador.HeaderText = "Aprobador"
        Me.Aprobador.Name = "Aprobador"
        Me.Aprobador.Visible = False
        '
        'FECHA_APROB
        '
        Me.FECHA_APROB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHA_APROB.DataPropertyName = "FECHA_APROB"
        Me.FECHA_APROB.HeaderText = "Fecha Aprobación"
        Me.FECHA_APROB.Name = "FECHA_APROB"
        Me.FECHA_APROB.Visible = False
        '
        'HORA_APROB
        '
        Me.HORA_APROB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HORA_APROB.DataPropertyName = "HORA_APROB"
        Me.HORA_APROB.HeaderText = "Hora Aprobación"
        Me.HORA_APROB.Name = "HORA_APROB"
        Me.HORA_APROB.Visible = False
        '
        'TOBS_ENVIO
        '
        Me.TOBS_ENVIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBS_ENVIO.DataPropertyName = "TOBS_ENVIO"
        Me.TOBS_ENVIO.HeaderText = "Obs Envío"
        Me.TOBS_ENVIO.Name = "TOBS_ENVIO"
        Me.TOBS_ENVIO.Visible = False
        '
        'TOBS_APROB
        '
        Me.TOBS_APROB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBS_APROB.DataPropertyName = "TOBS_APROB"
        Me.TOBS_APROB.HeaderText = "Obs Aprobación"
        Me.TOBS_APROB.Name = "TOBS_APROB"
        Me.TOBS_APROB.Visible = False
        '
        'ENVIOS
        '
        Me.ENVIOS.DataPropertyName = "ENVIOS"
        Me.ENVIOS.HeaderText = "Envíos"
        Me.ENVIOS.Name = "ENVIOS"
        '
        'UsuarioRegistrado
        '
        Me.UsuarioRegistrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UsuarioRegistrado.DataPropertyName = "CUSCRT"
        Me.UsuarioRegistrado.HeaderText = "Usuario Registrado"
        Me.UsuarioRegistrado.Name = "UsuarioRegistrado"
        Me.UsuarioRegistrado.Width = 168
        '
        'CULUSA
        '
        Me.CULUSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "Usuario Actualización"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.Width = 185
        '
        'NCRRDE
        '
        Me.NCRRDE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRDE.DataPropertyName = "NCRRDE"
        Me.NCRRDE.HeaderText = "NCRRDE"
        Me.NCRRDE.Name = "NCRRDE"
        Me.NCRRDE.Visible = False
        '
        'NCRRDA
        '
        Me.NCRRDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRDA.DataPropertyName = "NCRRDA"
        Me.NCRRDA.HeaderText = "NCRRDA"
        Me.NCRRDA.Name = "NCRRDA"
        Me.NCRRDA.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAnulacion})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1134, 27)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAnulacion
        '
        Me.btnAnulacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAnulacion.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnAnulacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnulacion.Name = "btnAnulacion"
        Me.btnAnulacion.Size = New System.Drawing.Size(76, 24)
        Me.btnAnulacion.Text = "Anular"
        '
        'TabGrupoClientes
        '
        Me.TabGrupoClientes.Controls.Add(Me.tabOpValorizacion)
        Me.TabGrupoClientes.Controls.Add(Me.tabNroEnvio)
        Me.TabGrupoClientes.Controls.Add(Me.TabDocSeg)
        Me.TabGrupoClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabGrupoClientes.Location = New System.Drawing.Point(0, 27)
        Me.TabGrupoClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.TabGrupoClientes.Name = "TabGrupoClientes"
        Me.TabGrupoClientes.SelectedIndex = 0
        Me.TabGrupoClientes.Size = New System.Drawing.Size(1134, 328)
        Me.TabGrupoClientes.TabIndex = 74
        '
        'tabOpValorizacion
        '
        Me.tabOpValorizacion.Controls.Add(Me.dtgOpValorizacion)
        Me.tabOpValorizacion.Location = New System.Drawing.Point(4, 25)
        Me.tabOpValorizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.tabOpValorizacion.Name = "tabOpValorizacion"
        Me.tabOpValorizacion.Padding = New System.Windows.Forms.Padding(4)
        Me.tabOpValorizacion.Size = New System.Drawing.Size(1126, 299)
        Me.tabOpValorizacion.TabIndex = 0
        Me.tabOpValorizacion.Text = "Op. por Valorización"
        Me.tabOpValorizacion.UseVisualStyleBackColor = True
        '
        'dtgOpValorizacion
        '
        Me.dtgOpValorizacion.AllowUserToAddRows = False
        Me.dtgOpValorizacion.AllowUserToDeleteRows = False
        Me.dtgOpValorizacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgOpValorizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65})
        Me.dtgOpValorizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOpValorizacion.Location = New System.Drawing.Point(4, 4)
        Me.dtgOpValorizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgOpValorizacion.Name = "dtgOpValorizacion"
        Me.dtgOpValorizacion.ReadOnly = True
        Me.dtgOpValorizacion.RowHeadersWidth = 25
        Me.dtgOpValorizacion.Size = New System.Drawing.Size(1118, 291)
        Me.dtgOpValorizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOpValorizacion.TabIndex = 70
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "DIVISION"
        Me.DataGridViewTextBoxColumn55.HeaderText = "División"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "TPOPER"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "PLANTA"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "NDCPRF"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Pre-Factura"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "NPRLQD"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Pre-Liquidación"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        Me.DataGridViewTextBoxColumn60.Visible = False
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "NSECFC"
        Me.DataGridViewTextBoxColumn61.HeaderText = "NroConsistencia"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "TotSoles"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Importe (S/)"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "TotDolares"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Importe ($/)"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "SESTOP_DESC"
        Me.DataGridViewTextBoxColumn64.HeaderText = "Estado OP."
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "CUSCRT"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Usuario Registro"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.ReadOnly = True
        '
        'tabNroEnvio
        '
        Me.tabNroEnvio.Controls.Add(Me.dtgEnvioValorizacion)
        Me.tabNroEnvio.Controls.Add(Me.dgVehiculo)
        Me.tabNroEnvio.Location = New System.Drawing.Point(4, 25)
        Me.tabNroEnvio.Margin = New System.Windows.Forms.Padding(4)
        Me.tabNroEnvio.Name = "tabNroEnvio"
        Me.tabNroEnvio.Padding = New System.Windows.Forms.Padding(4)
        Me.tabNroEnvio.Size = New System.Drawing.Size(1551, 277)
        Me.tabNroEnvio.TabIndex = 1
        Me.tabNroEnvio.Text = "Op. por Nro Envío"
        Me.tabNroEnvio.UseVisualStyleBackColor = True
        '
        'dtgEnvioValorizacion
        '
        Me.dtgEnvioValorizacion.AllowUserToAddRows = False
        Me.dtgEnvioValorizacion.AllowUserToDeleteRows = False
        Me.dtgEnvioValorizacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgEnvioValorizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Division, Me.Tipo, Me.Planta, Me.Operacion, Me.PreFactura, Me.PreLiquidacion, Me.NroConsistencia, Me.ImporteSoles, Me.ImporteDolares, Me.EstadoOP, Me.UsuarioRegistro})
        Me.dtgEnvioValorizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgEnvioValorizacion.Location = New System.Drawing.Point(4, 4)
        Me.dtgEnvioValorizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgEnvioValorizacion.Name = "dtgEnvioValorizacion"
        Me.dtgEnvioValorizacion.ReadOnly = True
        Me.dtgEnvioValorizacion.RowHeadersWidth = 25
        Me.dtgEnvioValorizacion.Size = New System.Drawing.Size(1543, 269)
        Me.dtgEnvioValorizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgEnvioValorizacion.TabIndex = 69
        '
        'Division
        '
        Me.Division.DataPropertyName = "DIVISION"
        Me.Division.HeaderText = "División"
        Me.Division.Name = "Division"
        Me.Division.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "TPOPER"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Planta
        '
        Me.Planta.DataPropertyName = "PLANTA"
        Me.Planta.HeaderText = "Planta"
        Me.Planta.Name = "Planta"
        Me.Planta.ReadOnly = True
        '
        'Operacion
        '
        Me.Operacion.DataPropertyName = "NOPRCN"
        Me.Operacion.HeaderText = "Operación"
        Me.Operacion.Name = "Operacion"
        Me.Operacion.ReadOnly = True
        '
        'PreFactura
        '
        Me.PreFactura.DataPropertyName = "NDCPRF"
        Me.PreFactura.HeaderText = "Pre-Factura"
        Me.PreFactura.Name = "PreFactura"
        Me.PreFactura.ReadOnly = True
        '
        'PreLiquidacion
        '
        Me.PreLiquidacion.DataPropertyName = "NPRLQD"
        Me.PreLiquidacion.HeaderText = "Pre-Liquidación"
        Me.PreLiquidacion.Name = "PreLiquidacion"
        Me.PreLiquidacion.ReadOnly = True
        Me.PreLiquidacion.Visible = False
        '
        'NroConsistencia
        '
        Me.NroConsistencia.DataPropertyName = "NSECFC"
        Me.NroConsistencia.HeaderText = "NroConsistencia"
        Me.NroConsistencia.Name = "NroConsistencia"
        Me.NroConsistencia.ReadOnly = True
        '
        'ImporteSoles
        '
        Me.ImporteSoles.DataPropertyName = "IVLDCS"
        Me.ImporteSoles.HeaderText = "Importe (S/)"
        Me.ImporteSoles.Name = "ImporteSoles"
        Me.ImporteSoles.ReadOnly = True
        '
        'ImporteDolares
        '
        Me.ImporteDolares.DataPropertyName = "IVLDCD"
        Me.ImporteDolares.HeaderText = "Importe ($/)"
        Me.ImporteDolares.Name = "ImporteDolares"
        Me.ImporteDolares.ReadOnly = True
        '
        'EstadoOP
        '
        Me.EstadoOP.DataPropertyName = "SESTOP_DESC"
        Me.EstadoOP.HeaderText = "Estado OP."
        Me.EstadoOP.Name = "EstadoOP"
        Me.EstadoOP.ReadOnly = True
        '
        'UsuarioRegistro
        '
        Me.UsuarioRegistro.DataPropertyName = "CUSCRT"
        Me.UsuarioRegistro.HeaderText = "Usuario Registro"
        Me.UsuarioRegistro.Name = "UsuarioRegistro"
        Me.UsuarioRegistro.ReadOnly = True
        '
        'dgVehiculo
        '
        Me.dgVehiculo.AllowUserToAddRows = False
        Me.dgVehiculo.AllowUserToDeleteRows = False
        Me.dgVehiculo.AllowUserToResizeColumns = False
        Me.dgVehiculo.AllowUserToResizeRows = False
        Me.dgVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVehiculo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgVehiculo.Location = New System.Drawing.Point(4, 4)
        Me.dgVehiculo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgVehiculo.MultiSelect = False
        Me.dgVehiculo.Name = "dgVehiculo"
        Me.dgVehiculo.ReadOnly = True
        Me.dgVehiculo.RowHeadersWidth = 20
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgVehiculo.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculo.Size = New System.Drawing.Size(1543, 269)
        Me.dgVehiculo.StandardTab = True
        Me.dgVehiculo.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgVehiculo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgVehiculo.TabIndex = 68
        '
        'TabDocSeg
        '
        Me.TabDocSeg.Controls.Add(Me.kdgvdocseg)
        Me.TabDocSeg.Location = New System.Drawing.Point(4, 25)
        Me.TabDocSeg.Name = "TabDocSeg"
        Me.TabDocSeg.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDocSeg.Size = New System.Drawing.Size(1126, 299)
        Me.TabDocSeg.TabIndex = 2
        Me.TabDocSeg.Text = "Doc. Seguimientos"
        Me.TabDocSeg.UseVisualStyleBackColor = True
        '
        'kdgvdocseg
        '
        Me.kdgvdocseg.AllowUserToAddRows = False
        Me.kdgvdocseg.AllowUserToDeleteRows = False
        Me.kdgvdocseg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.kdgvdocseg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROSGV_DS, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.ENVIOS_DS})
        Me.kdgvdocseg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdgvdocseg.Location = New System.Drawing.Point(3, 3)
        Me.kdgvdocseg.Margin = New System.Windows.Forms.Padding(4)
        Me.kdgvdocseg.Name = "kdgvdocseg"
        Me.kdgvdocseg.ReadOnly = True
        Me.kdgvdocseg.RowHeadersWidth = 25
        Me.kdgvdocseg.Size = New System.Drawing.Size(1120, 293)
        Me.kdgvdocseg.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdgvdocseg.TabIndex = 70
        '
        'NROSGV_DS
        '
        Me.NROSGV_DS.DataPropertyName = "NROSGV"
        Me.NROSGV_DS.HeaderText = "Nro. Doc. Seg"
        Me.NROSGV_DS.Name = "NROSGV_DS"
        Me.NROSGV_DS.ReadOnly = True
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "IVLDCS"
        Me.DataGridViewTextBoxColumn73.HeaderText = "Importe (S/)"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.ReadOnly = True
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "IVLDCD"
        Me.DataGridViewTextBoxColumn74.HeaderText = "Importe ($/)"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        Me.DataGridViewTextBoxColumn74.ReadOnly = True
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "SESTOP_DESC"
        Me.DataGridViewTextBoxColumn75.HeaderText = "Estado OP."
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        Me.DataGridViewTextBoxColumn75.ReadOnly = True
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "CUSCRT"
        Me.DataGridViewTextBoxColumn76.HeaderText = "Usuario Registro"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        Me.DataGridViewTextBoxColumn76.ReadOnly = True
        '
        'ENVIOS_DS
        '
        Me.ENVIOS_DS.HeaderText = "Envíos"
        Me.ENVIOS_DS.Name = "ENVIOS_DS"
        Me.ENVIOS_DS.ReadOnly = True
        Me.ENVIOS_DS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENVIOS_DS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminarDet})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1134, 27)
        Me.ToolStrip1.TabIndex = 73
        '
        'btnEliminarDet
        '
        Me.btnEliminarDet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarDet.Image = CType(resources.GetObject("btnEliminarDet.Image"), System.Drawing.Image)
        Me.btnEliminarDet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarDet.Name = "btnEliminarDet"
        Me.btnEliminarDet.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminarDet.Text = "Eliminar"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblNroValorización)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtNroValorizacion)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1134, 77)
        Me.KryptonHeaderGroup2.StateDisabled.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 0
        Me.KryptonHeaderGroup2.Text = "Filtros"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup1.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
        '
        'lblNroValorización
        '
        Me.lblNroValorización.Location = New System.Drawing.Point(12, 13)
        Me.lblNroValorización.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNroValorización.Name = "lblNroValorización"
        Me.lblNroValorización.Size = New System.Drawing.Size(127, 26)
        Me.lblNroValorización.TabIndex = 10
        Me.lblNroValorización.Text = "N° Valorización. :"
        Me.lblNroValorización.Values.ExtraText = ""
        Me.lblNroValorización.Values.Image = Nothing
        Me.lblNroValorización.Values.Text = "N° Valorización. :"
        '
        'txtNroValorizacion
        '
        Me.txtNroValorizacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtNroValorizacion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNroValorizacion.Location = New System.Drawing.Point(162, 14)
        Me.txtNroValorizacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroValorizacion.MaxLength = 10
        Me.txtNroValorizacion.Name = "txtNroValorizacion"
        Me.txtNroValorizacion.Size = New System.Drawing.Size(179, 22)
        Me.txtNroValorizacion.TabIndex = 9
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.miniToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(1039, 25)
        Me.miniToolStrip.TabIndex = 0
        '
        'btnEnviar
        '
        Me.btnEnviar.AutoSize = False
        Me.btnEnviar.Image = Global.SOLMIN_CT.My.Resources.Resources.txt2
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(152, 22)
        Me.btnEnviar.Text = "Enviar"
        '
        'btnPorCobranza
        '
        Me.btnPorCobranza.Name = "btnPorCobranza"
        Me.btnPorCobranza.Size = New System.Drawing.Size(140, 22)
        Me.btnPorCobranza.Text = "A Cobranzas"
        '
        'btnPorCobrador
        '
        Me.btnPorCobrador.Name = "btnPorCobrador"
        Me.btnPorCobrador.Size = New System.Drawing.Size(140, 22)
        Me.btnPorCobrador.Text = "Al Cobrador"
        '
        'btnPorCliente
        '
        Me.btnPorCliente.Name = "btnPorCliente"
        Me.btnPorCliente.Size = New System.Drawing.Size(140, 22)
        Me.btnPorCliente.Text = "Al Cliente"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(167, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(500, 200)
        Me.btnExportar.Text = "Exportar"
        '
        'tsmReporte
        '
        Me.tsmReporte.Image = Global.SOLMIN_CT.My.Resources.Resources.doc
        Me.tsmReporte.Name = "tsmReporte"
        Me.tsmReporte.Size = New System.Drawing.Size(167, 22)
        Me.tsmReporte.Text = "Entrega Cobranza"
        '
        'btnRptRegVenta
        '
        Me.btnRptRegVenta.Name = "btnRptRegVenta"
        Me.btnRptRegVenta.Size = New System.Drawing.Size(181, 22)
        Me.btnRptRegVenta.Text = "Registro Venta"
        '
        'btnRptServCliente
        '
        Me.btnRptServCliente.Name = "btnRptServCliente"
        Me.btnRptServCliente.Size = New System.Drawing.Size(181, 22)
        Me.btnRptServCliente.Text = "Servicio/Cliente"
        '
        'btnRptModFact
        '
        Me.btnRptModFact.Name = "btnRptModFact"
        Me.btnRptModFact.Size = New System.Drawing.Size(181, 22)
        Me.btnRptModFact.Text = "Módulo Facturación"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NSECFC1"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Consistencia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Área"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NROVLR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DOCVLR"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "REFCNT"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QDAPVL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ESTADO_VLR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IMP_SOL_OP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DIVISION"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IMP_DOL_OP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CPLNDV"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IMP_DOL_NRO_SEG"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CMNDA"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NROSGV"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CCNTCS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NSECFC"
        Me.DataGridViewTextBoxColumn14.HeaderText = "N° Consistencia"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn15.HeaderText = "N° Operación"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 80
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "GUIA"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Guía"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fecha Inicio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Fecha Fín" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TDSDES"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Tipo de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Servicio"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CHOFER"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Chofer / Proveedor"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PLACA"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn21.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "UNIDAD"
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn22.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn22.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 60
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn23.FillWeight = 60.90909!
        Me.DataGridViewTextBoxColumn23.HeaderText = "Tipo de Bulto"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        Me.DataGridViewTextBoxColumn23.Width = 180
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "QREFFW"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn24.HeaderText = "Cantidad de Bulto"
        Me.DataGridViewTextBoxColumn24.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        Me.DataGridViewTextBoxColumn24.Width = 80
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn25.FillWeight = 60.90909!
        Me.DataGridViewTextBoxColumn25.HeaderText = "Orden de Compra"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        Me.DataGridViewTextBoxColumn25.Width = 90
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 50
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 150
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "TLUGEN"
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn28.FillWeight = 60.90909!
        Me.DataGridViewTextBoxColumn28.HeaderText = "Unidad Operativa"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        Me.DataGridViewTextBoxColumn28.Width = 65
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "QBLTSR"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Cantidad Item"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        Me.DataGridViewTextBoxColumn29.Width = 65
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "QPSOBL"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Peso(Kg)./Bulto"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        Me.DataGridViewTextBoxColumn30.Width = 65
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "DESCWB"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Referencia de Mercadería"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Servicios"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "IVLSRV"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Tarifa"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TIPBTO"
        Me.DataGridViewTextBoxColumn34.FillWeight = 60.90909!
        Me.DataGridViewTextBoxColumn34.HeaderText = "MONT27"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Visible = False
        Me.DataGridViewTextBoxColumn34.Width = 180
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "QREFFW"
        Me.DataGridViewTextBoxColumn35.HeaderText = "MONT10"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "NORCML"
        Me.DataGridViewTextBoxColumn36.FillWeight = 60.90909!
        Me.DataGridViewTextBoxColumn36.HeaderText = "CONT20"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "NRITOC"
        Me.DataGridViewTextBoxColumn37.HeaderText = "CONT40"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ESTUNI"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Visible = False
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "TLUGEN"
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn39.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn39.FillWeight = 60.90909!
        Me.DataGridViewTextBoxColumn39.HeaderText = "EMBBLT"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Visible = False
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "QBLTSR"
        Me.DataGridViewTextBoxColumn40.HeaderText = "PALETI"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        Me.DataGridViewTextBoxColumn40.Width = 33
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "TMNDA"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        Me.DataGridViewTextBoxColumn41.Width = 50
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn42.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Servicios"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        Me.DataGridViewTextBoxColumn43.Width = 34
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "IVLSRV"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Tarifa"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Visible = False
        Me.DataGridViewTextBoxColumn44.Width = 60
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "IVLSRV"
        Me.DataGridViewTextBoxColumn45.HeaderText = "MONT27"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Visible = False
        Me.DataGridViewTextBoxColumn45.Width = 33
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "QATNAN"
        Me.DataGridViewTextBoxColumn46.HeaderText = "MONT10"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Visible = False
        Me.DataGridViewTextBoxColumn46.Width = 34
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "QATNAN"
        Me.DataGridViewTextBoxColumn47.HeaderText = "CONT20"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Visible = False
        Me.DataGridViewTextBoxColumn47.Width = 33
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "SESTOP_DESC"
        Me.DataGridViewTextBoxColumn48.HeaderText = "CONT40"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Visible = False
        Me.DataGridViewTextBoxColumn48.Width = 34
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "TMNDA"
        Me.DataGridViewTextBoxColumn49.HeaderText = "ESTUNI"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Visible = False
        Me.DataGridViewTextBoxColumn49.Width = 33
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn50.HeaderText = "EMBBLT"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Visible = False
        Me.DataGridViewTextBoxColumn50.Width = 34
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn51.HeaderText = "PALETI"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Visible = False
        Me.DataGridViewTextBoxColumn51.Width = 33
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "TMNDA"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Visible = False
        Me.DataGridViewTextBoxColumn52.Width = 50
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn53.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 70
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn54.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Width = 70
        '
        'frmDocSeguimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 722)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDocSeguimientos"
        Me.Text = "Doc. Seguimientos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dtgValorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabGrupoClientes.ResumeLayout(False)
        Me.tabOpValorizacion.ResumeLayout(False)
        CType(Me.dtgOpValorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNroEnvio.ResumeLayout(False)
        CType(Me.dtgEnvioValorizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDocSeg.ResumeLayout(False)
        CType(Me.kdgvdocseg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblNroValorización As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroValorizacion As System.Windows.Forms.TextBox
    Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents dtgValorizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnAnulacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEnviar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPorCobranza As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPorCobrador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPorCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmReporte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRptRegVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRptServCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRptModFact As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEliminarDet As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabGrupoClientes As System.Windows.Forms.TabControl
    Friend WithEvents tabOpValorizacion As System.Windows.Forms.TabPage
    Friend WithEvents tabNroEnvio As System.Windows.Forms.TabPage
    Friend WithEvents dtgEnvioValorizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgVehiculo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtgOpValorizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Division As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Planta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreLiquidacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroConsistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteSoles As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDolares As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROVLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCVLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QDAPVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMP_SOL_NRO_SEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMP_DOL_NRO_SEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_VLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROSGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_ENVIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA_ENVIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_ENVIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aprobador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_APROB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORA_APROB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS_ENVIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS_APROB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENVIOS As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents UsuarioRegistrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRDE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabDocSeg As System.Windows.Forms.TabPage
    Friend WithEvents kdgvdocseg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NROSGV_DS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENVIOS_DS As System.Windows.Forms.DataGridViewLinkColumn
End Class
