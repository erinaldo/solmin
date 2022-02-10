<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDespachoPedidoSDS
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgPedidos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNCDPEPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNFCHSPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNFDSPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRFTPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNDCFCC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTOBSMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnImprimirEtiqueta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAnular = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAtender = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgListaDespachos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPODEPOSITO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSDESCLI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCPLNCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCMPPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQPLANTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTDRCPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSTPORL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImportarPedido = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImportarPedidoIndividual = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPedidoInterfazSap = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPendienteDespacho = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDesMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblRefPedido = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRefPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbDeposito = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderiaSeleccionada.Panel.SuspendLayout()
        Me.hgMercaderiaSeleccionada.SuspendLayout()
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtgListaDespachos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.KryptonPanel.Size = New System.Drawing.Size(892, 579)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToPrimary
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderiaSeleccionada.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.hgMercaderiaSeleccionada.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.hgMercaderiaSeleccionada.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.hgMercaderiaSeleccionada.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.hgMercaderiaSeleccionada.HeaderVisiblePrimary = False
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 372)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        Me.hgMercaderiaSeleccionada.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dtgPedidos)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(892, 207)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 58
        Me.hgMercaderiaSeleccionada.Text = "Pedidos Pendientes"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = "Pedidos Pendientes"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = Nothing
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        '
        'dtgPedidos
        '
        Me.dtgPedidos.AllowUserToAddRows = False
        Me.dtgPedidos.AllowUserToDeleteRows = False
        Me.dtgPedidos.AllowUserToResizeColumns = False
        Me.dtgPedidos.AllowUserToResizeRows = False
        Me.dtgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPedidos.ColumnHeadersHeight = 33
        Me.dtgPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCDPEPL, Me.PNFCHSPE, Me.PNFDSPAL, Me.PSNRFTPD, Me.PSNRFRPD, Me.PNNDCFCC, Me.PSNORCML, Me.PSTOBSMD, Me.CANTIDAD, Me.Estado})
        Me.dtgPedidos.DataMember = "dtMercaderiaSeleccionadas"
        Me.dtgPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPedidos.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.List
        Me.dtgPedidos.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPedidos.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.List
        Me.dtgPedidos.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.List
        Me.dtgPedidos.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.List
        Me.dtgPedidos.Location = New System.Drawing.Point(0, 0)
        Me.dtgPedidos.MultiSelect = False
        Me.dtgPedidos.Name = "dtgPedidos"
        Me.dtgPedidos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.dtgPedidos.ReadOnly = True
        Me.dtgPedidos.RowHeadersWidth = 20
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPedidos.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dtgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPedidos.Size = New System.Drawing.Size(890, 205)
        Me.dtgPedidos.StandardTab = True
        Me.dtgPedidos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgPedidos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPedidos.TabIndex = 24
        '
        'PNCDPEPL
        '
        Me.PNCDPEPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PNCDPEPL.DataPropertyName = "PNCDPEPL"
        Me.PNCDPEPL.HeaderText = "Pedido"
        Me.PNCDPEPL.Name = "PNCDPEPL"
        Me.PNCDPEPL.ReadOnly = True
        Me.PNCDPEPL.Width = 72
        '
        'PNFCHSPE
        '
        Me.PNFCHSPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PNFCHSPE.DataPropertyName = "PNFCHSPE"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PNFCHSPE.DefaultCellStyle = DataGridViewCellStyle12
        Me.PNFCHSPE.HeaderText = "Fecha Pedido"
        Me.PNFCHSPE.Name = "PNFCHSPE"
        Me.PNFCHSPE.ReadOnly = True
        Me.PNFCHSPE.Width = 97
        '
        'PNFDSPAL
        '
        Me.PNFDSPAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PNFDSPAL.DataPropertyName = "PNFDSPAL"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PNFDSPAL.DefaultCellStyle = DataGridViewCellStyle13
        Me.PNFDSPAL.HeaderText = "Fecha Despacho"
        Me.PNFDSPAL.Name = "PNFDSPAL"
        Me.PNFDSPAL.ReadOnly = True
        Me.PNFDSPAL.Width = 110
        '
        'PSNRFTPD
        '
        Me.PSNRFTPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PSNRFTPD.DataPropertyName = "PSNRFTPD"
        Me.PSNRFTPD.HeaderText = "Tipo de Referencia"
        Me.PSNRFTPD.Name = "PSNRFTPD"
        Me.PSNRFTPD.ReadOnly = True
        Me.PSNRFTPD.Width = 120
        '
        'PSNRFRPD
        '
        Me.PSNRFRPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PSNRFRPD.DataPropertyName = "PSNRFRPD"
        Me.PSNRFRPD.HeaderText = "Referencia Pedido"
        Me.PSNRFRPD.Name = "PSNRFRPD"
        Me.PSNRFRPD.ReadOnly = True
        Me.PSNRFRPD.Width = 150
        '
        'PNNDCFCC
        '
        Me.PNNDCFCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PNNDCFCC.DataPropertyName = "PNNDCFCC"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.NullValue = "0"
        Me.PNNDCFCC.DefaultCellStyle = DataGridViewCellStyle14
        Me.PNNDCFCC.HeaderText = "Factura"
        Me.PNNDCFCC.Name = "PNNDCFCC"
        Me.PNNDCFCC.ReadOnly = True
        Me.PNNDCFCC.Width = 74
        '
        'PSNORCML
        '
        Me.PSNORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PSNORCML.DataPropertyName = "PSNORCML"
        Me.PSNORCML.HeaderText = "Orden de Compra"
        Me.PSNORCML.Name = "PSNORCML"
        Me.PSNORCML.ReadOnly = True
        Me.PSNORCML.Width = 118
        '
        'PSTOBSMD
        '
        Me.PSTOBSMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTOBSMD.DataPropertyName = "PSTOBSMD"
        Me.PSTOBSMD.HeaderText = "Observaciones"
        Me.PSTOBSMD.Name = "PSTOBSMD"
        Me.PSTOBSMD.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CANTIDAD.DataPropertyName = "CANTIDAD"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = "0"
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle15
        Me.CANTIDAD.HeaderText = "Cantidad de " & Global.Microsoft.VisualBasic.ChrW(10) & "     Items"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        Me.CANTIDAD.Width = 102
        '
        'Estado
        '
        Me.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 71
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnImprimirEtiqueta, Me.ToolStripSeparator4, Me.btnImprimir, Me.ToolStripSeparator5, Me.btnAnular, Me.ToolStripSeparator6, Me.btnAtender, Me.ToolStripSeparator7, Me.ToolStripLabel2})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 347)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(892, 25)
        Me.ToolStrip2.TabIndex = 57
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnImprimirEtiqueta
        '
        Me.btnImprimirEtiqueta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimirEtiqueta.Image = Global.SOLMIN_SA.My.Resources.Resources.ico_impresora
        Me.btnImprimirEtiqueta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirEtiqueta.Name = "btnImprimirEtiqueta"
        Me.btnImprimirEtiqueta.Size = New System.Drawing.Size(97, 22)
        Me.btnImprimirEtiqueta.Text = "Imp. Etiqueta"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.Image = Global.SOLMIN_SA.My.Resources.Resources.printer2
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(73, 22)
        Me.btnImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnAnular
        '
        Me.btnAnular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAnular.Image = Global.SOLMIN_SA.My.Resources.Resources.cancel
        Me.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(62, 22)
        Me.btnAnular.Text = "Anular"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnAtender
        '
        Me.btnAtender.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAtender.Image = Global.SOLMIN_SA.My.Resources.Resources.accept
        Me.btnAtender.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(69, 22)
        Me.btnAtender.Text = "Atender"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(129, 22)
        Me.ToolStripLabel2.Text = "Pedidos Pendientes"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToPrimary
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.KryptonHeaderGroup1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.KryptonHeaderGroup1.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 159)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        Me.KryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgListaDespachos)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(892, 188)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 56
        Me.KryptonHeaderGroup1.Text = "Lista Despachos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Lista Despachos"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'dtgListaDespachos
        '
        Me.dtgListaDespachos.AllowUserToAddRows = False
        Me.dtgListaDespachos.AllowUserToDeleteRows = False
        Me.dtgListaDespachos.AllowUserToResizeRows = False
        Me.dtgListaDespachos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgListaDespachos.ColumnHeadersHeight = 33
        Me.dtgListaDespachos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTE, Me.TIPODEPOSITO, Me.PNCCLNT, Me.PSDESCLI, Me.PNCPLNCL, Me.PSTCMPPL, Me.PNQPLANTA, Me.PSTDRCPL, Me.PSSTPORL})
        Me.dtgListaDespachos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgListaDespachos.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.List
        Me.dtgListaDespachos.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgListaDespachos.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.List
        Me.dtgListaDespachos.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.List
        Me.dtgListaDespachos.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.List
        Me.dtgListaDespachos.Location = New System.Drawing.Point(0, 0)
        Me.dtgListaDespachos.MultiSelect = False
        Me.dtgListaDespachos.Name = "dtgListaDespachos"
        Me.dtgListaDespachos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.dtgListaDespachos.ReadOnly = True
        Me.dtgListaDespachos.RowHeadersWidth = 20
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgListaDespachos.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dtgListaDespachos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListaDespachos.Size = New System.Drawing.Size(890, 186)
        Me.dtgListaDespachos.StandardTab = True
        Me.dtgListaDespachos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgListaDespachos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgListaDespachos.TabIndex = 6
        '
        'CLIENTE
        '
        Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CLIENTE.DataPropertyName = "CLIENTE"
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Visible = False
        Me.CLIENTE.Width = 76
        '
        'TIPODEPOSITO
        '
        Me.TIPODEPOSITO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TIPODEPOSITO.DataPropertyName = "TIPODEPOSITO"
        Me.TIPODEPOSITO.HeaderText = "TIPODEPOSITO"
        Me.TIPODEPOSITO.Name = "TIPODEPOSITO"
        Me.TIPODEPOSITO.ReadOnly = True
        Me.TIPODEPOSITO.Visible = False
        Me.TIPODEPOSITO.Width = 111
        '
        'PNCCLNT
        '
        Me.PNCCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "Cliente Propio " & Global.Microsoft.VisualBasic.ChrW(10) & "       Tercero"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Width = 180
        '
        'PSDESCLI
        '
        Me.PSDESCLI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSDESCLI.DataPropertyName = "PSDESCLI"
        Me.PSDESCLI.HeaderText = "Cliente"
        Me.PSDESCLI.Name = "PSDESCLI"
        Me.PSDESCLI.ReadOnly = True
        Me.PSDESCLI.Width = 73
        '
        'PNCPLNCL
        '
        Me.PNCPLNCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCPLNCL.DataPropertyName = "PNCPLNCL"
        Me.PNCPLNCL.HeaderText = "Cod. Planta"
        Me.PNCPLNCL.Name = "PNCPLNCL"
        Me.PNCPLNCL.ReadOnly = True
        Me.PNCPLNCL.Width = 97
        '
        'PSTCMPPL
        '
        Me.PSTCMPPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTCMPPL.DataPropertyName = "PSTCMPPL"
        Me.PSTCMPPL.HeaderText = "Planta"
        Me.PSTCMPPL.Name = "PSTCMPPL"
        Me.PSTCMPPL.ReadOnly = True
        Me.PSTCMPPL.Width = 69
        '
        'PNQPLANTA
        '
        Me.PNQPLANTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PNQPLANTA.DataPropertyName = "PNQPLANTA"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N0"
        DataGridViewCellStyle17.NullValue = "0"
        Me.PNQPLANTA.DefaultCellStyle = DataGridViewCellStyle17
        Me.PNQPLANTA.HeaderText = "Cant. Pedidos"
        Me.PNQPLANTA.Name = "PNQPLANTA"
        Me.PNQPLANTA.ReadOnly = True
        Me.PNQPLANTA.Width = 99
        '
        'PSTDRCPL
        '
        Me.PSTDRCPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTDRCPL.DataPropertyName = "PSTDRCPL"
        Me.PSTDRCPL.HeaderText = "Dirección Planta"
        Me.PSTDRCPL.Name = "PSTDRCPL"
        Me.PSTDRCPL.ReadOnly = True
        '
        'PSSTPORL
        '
        Me.PSSTPORL.DataPropertyName = "PSSTPORL"
        Me.PSSTPORL.HeaderText = "PSSTPORL"
        Me.PSSTPORL.Name = "PSSTPORL"
        Me.PSSTPORL.ReadOnly = True
        Me.PSSTPORL.Visible = False
        Me.PSSTPORL.Width = 91
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizar, Me.ToolStripSeparator1, Me.btnImportarPedido, Me.ToolStripSeparator2, Me.btnImportarPedidoIndividual, Me.ToolStripSeparator3, Me.btnPedidoInterfazSap, Me.ToolStripSeparator9, Me.btnPendienteDespacho, Me.ToolStripLabel1, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 134)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(892, 25)
        Me.ToolStrip1.TabIndex = 55
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnActualizar
        '
        Me.btnActualizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnActualizar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(62, 22)
        Me.btnActualizar.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnImportarPedido
        '
        Me.btnImportarPedido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImportarPedido.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnImportarPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportarPedido.Name = "btnImportarPedido"
        Me.btnImportarPedido.Size = New System.Drawing.Size(118, 22)
        Me.btnImportarPedido.Text = "Importar Pedidos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnImportarPedidoIndividual
        '
        Me.btnImportarPedidoIndividual.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImportarPedidoIndividual.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.btnImportarPedidoIndividual.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportarPedidoIndividual.Name = "btnImportarPedidoIndividual"
        Me.btnImportarPedidoIndividual.Size = New System.Drawing.Size(113, 22)
        Me.btnImportarPedidoIndividual.Text = "Importar Pedido"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnPedidoInterfazSap
        '
        Me.btnPedidoInterfazSap.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPedidoInterfazSap.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnPedidoInterfazSap.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPedidoInterfazSap.Name = "btnPedidoInterfazSap"
        Me.btnPedidoInterfazSap.Size = New System.Drawing.Size(130, 22)
        Me.btnPedidoInterfazSap.Text = "Pedido Interfaz SAP"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btnPendienteDespacho
        '
        Me.btnPendienteDespacho.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPendienteDespacho.Image = Global.SOLMIN_SA.My.Resources.Resources.printer2
        Me.btnPendienteDespacho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPendienteDespacho.Name = "btnPendienteDespacho"
        Me.btnPendienteDespacho.Size = New System.Drawing.Size(140, 22)
        Me.btnPendienteDespacho.Text = "Pendientes Despacho"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripLabel1.Text = "Lista Despachos"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.CollapseTarget = ComponentFactory.Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToPrimary
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.khgFiltros.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.khgFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary
        Me.khgFiltros.HeaderStyleSecondary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        Me.khgFiltros.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.txtPedido)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.txtDesMercaderia)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodMercaderia)
        Me.khgFiltros.Panel.Controls.Add(Me.lblRefPedido)
        Me.khgFiltros.Panel.Controls.Add(Me.txtRefPedido)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbDeposito)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.khgFiltros.Size = New System.Drawing.Size(892, 134)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 1
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
        Me.bsaOcultarFiltros.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Inherit
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'txtPedido
        '
        Me.txtPedido.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtPedido.Location = New System.Drawing.Point(88, 75)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtPedido.Size = New System.Drawing.Size(225, 20)
        Me.txtPedido.TabIndex = 45
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KryptonLabel6.Location = New System.Drawing.Point(13, 74)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonLabel6.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel6.TabIndex = 44
        Me.KryptonLabel6.Text = "N° Pedido:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° Pedido:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KryptonLabel4.Location = New System.Drawing.Point(316, 46)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonLabel4.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel4.TabIndex = 43
        Me.KryptonLabel4.Text = "Des. Item :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Des. Item :"
        '
        'txtDesMercaderia
        '
        Me.txtDesMercaderia.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtDesMercaderia.Location = New System.Drawing.Point(384, 46)
        Me.txtDesMercaderia.Name = "txtDesMercaderia"
        Me.txtDesMercaderia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtDesMercaderia.Size = New System.Drawing.Size(403, 20)
        Me.txtDesMercaderia.TabIndex = 42
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 45)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonLabel3.Size = New System.Drawing.Size(69, 20)
        Me.KryptonLabel3.TabIndex = 41
        Me.KryptonLabel3.Text = "Cod. Item :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cod. Item :"
        '
        'txtCodMercaderia
        '
        Me.txtCodMercaderia.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtCodMercaderia.Location = New System.Drawing.Point(88, 46)
        Me.txtCodMercaderia.Name = "txtCodMercaderia"
        Me.txtCodMercaderia.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtCodMercaderia.Size = New System.Drawing.Size(225, 20)
        Me.txtCodMercaderia.TabIndex = 40
        '
        'lblRefPedido
        '
        Me.lblRefPedido.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblRefPedido.Location = New System.Drawing.Point(568, 19)
        Me.lblRefPedido.Name = "lblRefPedido"
        Me.lblRefPedido.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblRefPedido.Size = New System.Drawing.Size(92, 20)
        Me.lblRefPedido.TabIndex = 39
        Me.lblRefPedido.Text = "Pedido Cliente: "
        Me.lblRefPedido.Values.ExtraText = ""
        Me.lblRefPedido.Values.Image = Nothing
        Me.lblRefPedido.Values.Text = "Pedido Cliente: "
        '
        'txtRefPedido
        '
        Me.txtRefPedido.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtRefPedido.Location = New System.Drawing.Point(666, 18)
        Me.txtRefPedido.Name = "txtRefPedido"
        Me.txtRefPedido.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtRefPedido.Size = New System.Drawing.Size(121, 20)
        Me.txtRefPedido.TabIndex = 38
        '
        'cmbDeposito
        '
        '  Me.cmbDeposito.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.cmbDeposito.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl
        Me.cmbDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeposito.DropDownWidth = 121
        Me.cmbDeposito.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        'Me.cmbDeposito.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem
        Me.cmbDeposito.Location = New System.Drawing.Point(384, 18)
        Me.cmbDeposito.Name = "cmbDeposito"
        Me.cmbDeposito.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.cmbDeposito.Size = New System.Drawing.Size(181, 21)
        Me.cmbDeposito.TabIndex = 37
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(88, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(225, 22)
        Me.txtCliente.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KryptonLabel2.Location = New System.Drawing.Point(316, 19)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonLabel2.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Deposito : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Deposito : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 20)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 1
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.KryptonLabel5.Location = New System.Drawing.Point(797, 63)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 30)
        Me.KryptonLabel5.TabIndex = 35
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = ""
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CLIENTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CLIENTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 76
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TIPODEPOSITO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TIPODEPOSITO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 111
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PNCCLNT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente Propio " & Global.Microsoft.VisualBasic.ChrW(10) & "Tercero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PNCPLNCL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cod. Planta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSTCMPPL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Planta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSTDRCPL"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N0"
        DataGridViewCellStyle19.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn6.HeaderText = "Direción PLanta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PNCDPEPL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pedido"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PNFCHSPE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Pedido"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 105
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PNFDSPAL"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Entrega"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 109
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSNRFRPD"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn10.HeaderText = "Referencia Pedido"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PSTOBSMD"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 71
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PSTOBSMD"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CANTIDAD"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N0"
        DataGridViewCellStyle22.NullValue = "0"
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn14.HeaderText = "Cantidad de " & Global.Microsoft.VisualBasic.ChrW(10) & "     Items"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 102
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 71
        '
        'frmDespachoPedidoSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 579)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmDespachoPedidoSDS"
        Me.Text = "Despachos x Pedidos Web "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.Panel.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.ResumeLayout(False)
        CType(Me.dtgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtgListaDespachos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDeposito As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents txtRefPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRefPedido As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDesMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgPedidos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNCDPEPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNFCHSPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNFDSPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRFTPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNDCFCC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTOBSMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgListaDespachos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImportarPedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImportarPedidoIndividual As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPendienteDespacho As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnImprimirEtiqueta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAtender As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPODEPOSITO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSDESCLI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPLNCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMPPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPLANTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDRCPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSTPORL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPedidoInterfazSap As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
End Class
