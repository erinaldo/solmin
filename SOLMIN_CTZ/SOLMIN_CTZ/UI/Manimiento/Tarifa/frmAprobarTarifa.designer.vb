<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprobarTarifa
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gvDetTarifa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NCRRSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA_COBRAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIFA_COBRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA_PAGAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIFA_PAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIFA_COBRO_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARIFA_PAGO_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRG_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRG_POR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtOS = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01()
        Me.cboCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnAdjuntar = New System.Windows.Forms.ToolStripButton()
        Me.btnAprobar = New System.Windows.Forms.ToolStripButton()
        Me.btnRechazar = New System.Windows.Forms.ToolStripButton()
        Me.btnCheck = New System.Windows.Forms.ToolStripButton()
        Me.gvTarifa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRCTSL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRTFSV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_IMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRVTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRGVAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APRBSG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO_DES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gvDetTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.gvTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetTarifa
        '
        Me.gvDetTarifa.AllowUserToAddRows = False
        Me.gvDetTarifa.AllowUserToDeleteRows = False
        Me.gvDetTarifa.AllowUserToOrderColumns = True
        Me.gvDetTarifa.ColumnHeadersHeight = 35
        Me.gvDetTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvDetTarifa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCRRSR, Me.SERVICIO, Me.MONEDA_COBRAR, Me.TARIFA_COBRO, Me.MONEDA_PAGAR, Me.TARIFA_PAGO, Me.RUTA, Me.TARIFA_COBRO_SOL, Me.TARIFA_PAGO_SOL, Me.MRG_SOL, Me.MRG_POR, Me.Column2})
        Me.gvDetTarifa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvDetTarifa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gvDetTarifa.Location = New System.Drawing.Point(0, 25)
        Me.gvDetTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.gvDetTarifa.Name = "gvDetTarifa"
        Me.gvDetTarifa.ReadOnly = True
        Me.gvDetTarifa.RowHeadersWidth = 20
        Me.gvDetTarifa.RowTemplate.Height = 16
        Me.gvDetTarifa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gvDetTarifa.Size = New System.Drawing.Size(1443, 322)
        Me.gvDetTarifa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gvDetTarifa.TabIndex = 9
        Me.gvDetTarifa.TabStop = False
        '
        'NCRRSR
        '
        Me.NCRRSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRSR.DataPropertyName = "NCRRSR"
        Me.NCRRSR.HeaderText = "N° Item"
        Me.NCRRSR.Name = "NCRRSR"
        Me.NCRRSR.ReadOnly = True
        Me.NCRRSR.Visible = False
        Me.NCRRSR.Width = 93
        '
        'SERVICIO
        '
        Me.SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SERVICIO.DataPropertyName = "SERVICIO"
        Me.SERVICIO.HeaderText = "Servicio"
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.ReadOnly = True
        Me.SERVICIO.Width = 94
        '
        'MONEDA_COBRAR
        '
        Me.MONEDA_COBRAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA_COBRAR.DataPropertyName = "MONEDA_COBRAR"
        Me.MONEDA_COBRAR.HeaderText = "Mon. Cobro"
        Me.MONEDA_COBRAR.Name = "MONEDA_COBRAR"
        Me.MONEDA_COBRAR.ReadOnly = True
        Me.MONEDA_COBRAR.Visible = False
        Me.MONEDA_COBRAR.Width = 120
        '
        'TARIFA_COBRO
        '
        Me.TARIFA_COBRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TARIFA_COBRO.DataPropertyName = "TARIFA_COBRO"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.TARIFA_COBRO.DefaultCellStyle = DataGridViewCellStyle1
        Me.TARIFA_COBRO.HeaderText = "Tarifa Cobro"
        Me.TARIFA_COBRO.Name = "TARIFA_COBRO"
        Me.TARIFA_COBRO.ReadOnly = True
        Me.TARIFA_COBRO.Visible = False
        Me.TARIFA_COBRO.Width = 123
        '
        'MONEDA_PAGAR
        '
        Me.MONEDA_PAGAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA_PAGAR.DataPropertyName = "MONEDA_PAGAR"
        Me.MONEDA_PAGAR.HeaderText = "Mon. Pago"
        Me.MONEDA_PAGAR.Name = "MONEDA_PAGAR"
        Me.MONEDA_PAGAR.ReadOnly = True
        Me.MONEDA_PAGAR.Visible = False
        Me.MONEDA_PAGAR.Width = 112
        '
        'TARIFA_PAGO
        '
        Me.TARIFA_PAGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TARIFA_PAGO.DataPropertyName = "TARIFA_PAGO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TARIFA_PAGO.DefaultCellStyle = DataGridViewCellStyle2
        Me.TARIFA_PAGO.HeaderText = "Tarifa Pago"
        Me.TARIFA_PAGO.Name = "TARIFA_PAGO"
        Me.TARIFA_PAGO.ReadOnly = True
        Me.TARIFA_PAGO.Visible = False
        Me.TARIFA_PAGO.Width = 115
        '
        'RUTA
        '
        Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUTA.DataPropertyName = "RUTA"
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.ReadOnly = True
        Me.RUTA.Width = 72
        '
        'TARIFA_COBRO_SOL
        '
        Me.TARIFA_COBRO_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TARIFA_COBRO_SOL.DataPropertyName = "TARIFA_COBRO_SOL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.TARIFA_COBRO_SOL.DefaultCellStyle = DataGridViewCellStyle3
        Me.TARIFA_COBRO_SOL.HeaderText = "Tarifa Cobro (S/.)"
        Me.TARIFA_COBRO_SOL.Name = "TARIFA_COBRO_SOL"
        Me.TARIFA_COBRO_SOL.ReadOnly = True
        Me.TARIFA_COBRO_SOL.Width = 154
        '
        'TARIFA_PAGO_SOL
        '
        Me.TARIFA_PAGO_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TARIFA_PAGO_SOL.DataPropertyName = "TARIFA_PAGO_SOL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.TARIFA_PAGO_SOL.DefaultCellStyle = DataGridViewCellStyle4
        Me.TARIFA_PAGO_SOL.HeaderText = "Tarifa Pago(S/.)"
        Me.TARIFA_PAGO_SOL.Name = "TARIFA_PAGO_SOL"
        Me.TARIFA_PAGO_SOL.ReadOnly = True
        Me.TARIFA_PAGO_SOL.Width = 142
        '
        'MRG_SOL
        '
        Me.MRG_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MRG_SOL.DataPropertyName = "MRG_SOL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.MRG_SOL.DefaultCellStyle = DataGridViewCellStyle5
        Me.MRG_SOL.HeaderText = "Diferencia (S/.)"
        Me.MRG_SOL.Name = "MRG_SOL"
        Me.MRG_SOL.ReadOnly = True
        Me.MRG_SOL.Width = 141
        '
        'MRG_POR
        '
        Me.MRG_POR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MRG_POR.DataPropertyName = "MRG_POR"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.MRG_POR.DefaultCellStyle = DataGridViewCellStyle6
        Me.MRG_POR.HeaderText = "Margen (%)"
        Me.MRG_POR.Name = "MRG_POR"
        Me.MRG_POR.ReadOnly = True
        Me.MRG_POR.Width = 119
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 135)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gvTarifa)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gvDetTarifa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1443, 637)
        Me.SplitContainer1.SplitterDistance = 285
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1443, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel1.Text = "Servicios"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1443, 772)
        Me.KryptonPanel.TabIndex = 2
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
        Me.PanelFiltros.Panel.Controls.Add(Me.txtOS)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboDivision)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Size = New System.Drawing.Size(1443, 135)
        Me.PanelFiltros.TabIndex = 3
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Órdenes de Servicio"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(553, 59)
        Me.txtOS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOS.MaxLength = 10
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(146, 26)
        Me.txtOS.TabIndex = 41
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(473, 59)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(37, 24)
        Me.KryptonLabel3.TabIndex = 39
        Me.KryptonLabel3.Text = "O/S"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "O/S"
        '
        'cboDivision
        '
        Me.cboDivision.BackColor = System.Drawing.Color.Transparent
        Me.cboDivision.CDVSN_ANTERIOR = Nothing
        Me.cboDivision.Compania = ""
        Me.cboDivision.Division = Nothing
        Me.cboDivision.DivisionDefault = Nothing
        Me.cboDivision.DivisionDescripcion = Nothing
        Me.cboDivision.ItemTodos = False
        Me.cboDivision.Location = New System.Drawing.Point(553, 17)
        Me.cboDivision.Margin = New System.Windows.Forms.Padding(5)
        Me.cboDivision.MinimumSize = New System.Drawing.Size(200, 26)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.obeDivision = Nothing
        Me.cboDivision.pHabilitado = True
        Me.cboDivision.pRequerido = False
        Me.cboDivision.Size = New System.Drawing.Size(336, 31)
        Me.cboDivision.TabIndex = 36
        Me.cboDivision.Usuario = ""
        '
        'cboCompania
        '
        Me.cboCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cboCompania.CCMPN_ANTERIOR = Nothing
        Me.cboCompania.CCMPN_CodigoCompania = Nothing
        Me.cboCompania.CCMPN_CompaniaDefault = "EZ"
        Me.cboCompania.CCMPN_Descripcion = Nothing
        Me.cboCompania.Habilitar = True
        Me.cboCompania.Location = New System.Drawing.Point(105, 17)
        Me.cboCompania.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCompania.MinimumSize = New System.Drawing.Size(200, 28)
        Me.cboCompania.Name = "cboCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.cboCompania.oBeCompania = BeCompania1
        Me.cboCompania.Size = New System.Drawing.Size(344, 31)
        Me.cboCompania.TabIndex = 35
        Me.cboCompania.Usuario = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(105, 57)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(344, 26)
        Me.txtCliente.TabIndex = 7
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 59)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 24)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Cliente"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cliente"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(15, 21)
        Me.lblCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(81, 24)
        Me.lblCompania.TabIndex = 2
        Me.lblCompania.Text = "Compañia"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(473, 20)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(65, 24)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Text = "División"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NORSRT"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = " O / S"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CCNCST"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ce. Co Propio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CCNCS1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ce. Co Tercero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ESTADOOS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado O / S"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MARGEN"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.HeaderText = "Margen Min Permitido (%)"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 160
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NCTZCN"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn6.HeaderText = "N° Cotización"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 160
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NCRRCT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "N° Correlativo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TUNDVH"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unidad Vehicular"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MERCAD"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "QMRCDR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "UNIMED"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Unidad de medida"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PMRCDR"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FFACTURA"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Param. Facturación"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FPAGO"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Param. Pago"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SEGURO"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Seguro"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NCRRSR"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn16.HeaderText = "N° Item"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ORIGEN"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn18.HeaderText = "Localidad de Origen"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "DESTINO"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn19.HeaderText = "Localidad de Destino"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "MONEDA"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn20.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ITRSRT"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn21.HeaderText = "Importe Cobrar  "
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 120
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CMNLQT"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn22.HeaderText = "CMNLQT"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ILSFTR"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn23.HeaderText = "Importe a Pagar"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "MONTOCOBRO_SOLES"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn26.HeaderText = "Importe Cobrar (S/.)"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "MONTOCOBRO_SOLES"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn25.HeaderText = "Tipo de cambio"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "MONTOCOBRO_SOLES"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn24.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn24.HeaderText = "Moneda Pagar"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "MONTOPAGO_SOLES"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn27.HeaderText = "Importe Pagar (S/.)"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "ORIGEN"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Localidad de Origen"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "MARGENPOR"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn28.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn28.HeaderText = "Margen (%)"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "SSRVFE"
        Me.DataGridViewTextBoxColumn64.HeaderText = "SSRVFE"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Visible = False
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "DESTINO"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Localidad de Destino"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "MONEDA"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "CSRCTZ"
        Me.DataGridViewTextBoxColumn47.HeaderText = "CSRCTZ"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        Me.DataGridViewTextBoxColumn47.Visible = False
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "ITRSRT"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N2"
        Me.DataGridViewTextBoxColumn48.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn48.HeaderText = "Importe Cobrar  "
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        Me.DataGridViewTextBoxColumn48.Visible = False
        Me.DataGridViewTextBoxColumn48.Width = 120
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "CMRCDR"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "N2"
        Me.DataGridViewTextBoxColumn49.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn49.HeaderText = "CMRCDR"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        Me.DataGridViewTextBoxColumn49.Visible = False
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "TOBSSR"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn50.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn50.HeaderText = "TOBSSR"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        Me.DataGridViewTextBoxColumn50.Visible = False
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "CUNSRA"
        Me.DataGridViewTextBoxColumn59.HeaderText = "CUNSRA"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        Me.DataGridViewTextBoxColumn59.Visible = False
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "QDSTVR"
        Me.DataGridViewTextBoxColumn60.HeaderText = "QDSTVR"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        Me.DataGridViewTextBoxColumn60.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "MARCA"
        Me.DataGridViewTextBoxColumn29.HeaderText = "MARCA"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "CSTNDT"
        Me.DataGridViewTextBoxColumn61.HeaderText = "CSTNDT"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        Me.DataGridViewTextBoxColumn61.Visible = False
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "SSRVFE"
        Me.DataGridViewTextBoxColumn63.HeaderText = "SSRVFE"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        Me.DataGridViewTextBoxColumn63.Visible = False
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "ILQSMT"
        Me.DataGridViewTextBoxColumn58.HeaderText = "ILQSMT"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Visible = False
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "ILQFMX"
        Me.DataGridViewTextBoxColumn57.HeaderText = "ILQFMX"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Visible = False
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "ILCFTR"
        Me.DataGridViewTextBoxColumn56.HeaderText = "ILCFTR"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Visible = False
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "CLCLOR"
        Me.DataGridViewTextBoxColumn51.HeaderText = "CLCLOR"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Visible = False
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "CLCLDS"
        Me.DataGridViewTextBoxColumn52.HeaderText = "CLCLDS"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Visible = False
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "CMNTRN"
        Me.DataGridViewTextBoxColumn53.HeaderText = "CMNTRN"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Visible = False
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "CMNLQT"
        Me.DataGridViewTextBoxColumn54.HeaderText = "CMNLQT"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        Me.DataGridViewTextBoxColumn54.Visible = False
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "ILSFTR"
        Me.DataGridViewTextBoxColumn55.HeaderText = "ILSFTR"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Visible = False
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "SFCRTV"
        Me.DataGridViewTextBoxColumn62.HeaderText = "SFCRTV"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        Me.DataGridViewTextBoxColumn62.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "MARCA"
        Me.DataGridViewTextBoxColumn30.HeaderText = "MARCA"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnRechazar, Me.btnAprobar, Me.btnAdjuntar, Me.btnCheck})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1443, 27)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_CT.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnAdjuntar
        '
        Me.btnAdjuntar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdjuntar.Image = Global.SOLMIN_CT.My.Resources.Resources.Agregar2
        Me.btnAdjuntar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(90, 24)
        Me.btnAdjuntar.Text = "Adjuntar"
        '
        'btnAprobar
        '
        Me.btnAprobar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAprobar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(88, 24)
        Me.btnAprobar.Text = "Aprobar"
        '
        'btnRechazar
        '
        Me.btnRechazar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRechazar.Image = Global.SOLMIN_CT.My.Resources.Resources.cell_layout
        Me.btnRechazar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(130, 24)
        Me.btnRechazar.Text = "Cancelar Envío"
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.SOLMIN_CT.My.Resources.Resources.btnMarcarItems
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(110, 24)
        Me.btnCheck.Text = "Check Todo"
        '
        'gvTarifa
        '
        Me.gvTarifa.AllowUserToAddRows = False
        Me.gvTarifa.AllowUserToDeleteRows = False
        Me.gvTarifa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gvTarifa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvTarifa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.TCMPCL, Me.NRCTSL, Me.NRTFSV, Me.NORSRT, Me.NMRGIM_IMG, Me.TCRVTA, Me.FFACTURA, Me.FPAGO, Me.MRGVAL, Me.APRBSG, Me.ESTADO_DES, Me.CCMPN, Me.NMRGIM, Me.Column1})
        Me.gvTarifa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvTarifa.Location = New System.Drawing.Point(0, 27)
        Me.gvTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.gvTarifa.Name = "gvTarifa"
        Me.gvTarifa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvTarifa.Size = New System.Drawing.Size(1443, 258)
        Me.gvTarifa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gvTarifa.TabIndex = 10
        '
        'CHK
        '
        Me.CHK.HeaderText = "Check"
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK.Width = 81
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
        'NRCTSL
        '
        Me.NRCTSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRCTSL.DataPropertyName = "NRCTSL"
        Me.NRCTSL.HeaderText = "Contrato"
        Me.NRCTSL.Name = "NRCTSL"
        Me.NRCTSL.ReadOnly = True
        '
        'NRTFSV
        '
        Me.NRTFSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRTFSV.DataPropertyName = "NRTFSV"
        Me.NRTFSV.HeaderText = "Tarifa"
        Me.NRTFSV.Name = "NRTFSV"
        Me.NRTFSV.ReadOnly = True
        Me.NRTFSV.Width = 78
        '
        'NORSRT
        '
        Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSRT.DataPropertyName = "NORSRT"
        Me.NORSRT.HeaderText = "O / S"
        Me.NORSRT.Name = "NORSRT"
        Me.NORSRT.ReadOnly = True
        Me.NORSRT.Width = 63
        '
        'NMRGIM_IMG
        '
        Me.NMRGIM_IMG.DataPropertyName = "NMRGIM_DESC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NMRGIM_IMG.DefaultCellStyle = DataGridViewCellStyle7
        Me.NMRGIM_IMG.HeaderText = "Adjunto"
        Me.NMRGIM_IMG.Name = "NMRGIM_IMG"
        Me.NMRGIM_IMG.ReadOnly = True
        Me.NMRGIM_IMG.Width = 95
        '
        'TCRVTA
        '
        Me.TCRVTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA.DataPropertyName = "TCRVTA"
        Me.TCRVTA.HeaderText = "Negocio"
        Me.TCRVTA.Name = "TCRVTA"
        Me.TCRVTA.ReadOnly = True
        Me.TCRVTA.Width = 99
        '
        'FFACTURA
        '
        Me.FFACTURA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FFACTURA.DataPropertyName = "FFACTURA"
        Me.FFACTURA.HeaderText = "Param. Fact"
        Me.FFACTURA.Name = "FFACTURA"
        Me.FFACTURA.ReadOnly = True
        Me.FFACTURA.Width = 107
        '
        'FPAGO
        '
        Me.FPAGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FPAGO.DataPropertyName = "FPAGO"
        Me.FPAGO.HeaderText = "Param. Pago"
        Me.FPAGO.Name = "FPAGO"
        Me.FPAGO.ReadOnly = True
        Me.FPAGO.Width = 113
        '
        'MRGVAL
        '
        Me.MRGVAL.DataPropertyName = "MRGVAL"
        Me.MRGVAL.HeaderText = "Mrg aprobación"
        Me.MRGVAL.Name = "MRGVAL"
        Me.MRGVAL.ReadOnly = True
        Me.MRGVAL.Width = 137
        '
        'APRBSG
        '
        Me.APRBSG.DataPropertyName = "APRBSG"
        Me.APRBSG.HeaderText = "Aprobador sugerido"
        Me.APRBSG.Name = "APRBSG"
        Me.APRBSG.ReadOnly = True
        Me.APRBSG.Width = 162
        '
        'ESTADO_DES
        '
        Me.ESTADO_DES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO_DES.DataPropertyName = "ESTADO_DES"
        Me.ESTADO_DES.HeaderText = "Estado"
        Me.ESTADO_DES.Name = "ESTADO_DES"
        Me.ESTADO_DES.ReadOnly = True
        Me.ESTADO_DES.Width = 87
        '
        'CCMPN
        '
        Me.CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'NMRGIM
        '
        Me.NMRGIM.DataPropertyName = "NMRGIM"
        Me.NMRGIM.HeaderText = "NMRGIM"
        Me.NMRGIM.Name = "NMRGIM"
        Me.NMRGIM.ReadOnly = True
        Me.NMRGIM.Visible = False
        Me.NMRGIM.Width = 102
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmAprobarTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 772)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAprobarTarifa"
        Me.Text = "Aprobar Tarifa"
        CType(Me.gvDetTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.gvTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvDetTarifa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtOS As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents cboCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents NCRRSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA_COBRAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA_COBRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA_PAGAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA_PAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA_COBRO_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA_PAGO_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MRG_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MRG_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvTarifa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRCTSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRTFSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_IMG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MRGVAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APRBSG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_DES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRechazar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdjuntar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
End Class
