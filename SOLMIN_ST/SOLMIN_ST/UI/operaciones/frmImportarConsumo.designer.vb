<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarConsumo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.tabCostos = New System.Windows.Forms.TabControl
        Me.tabCostoNeumatico = New System.Windows.Forms.TabPage
        Me.dgwDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.FECREG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDETRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCRVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NROSER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRFMED = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRFDIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QATNAN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMPUNI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMPTTL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabCostoMantenimiento = New System.Windows.Forms.TabPage
        Me.dgwCosMan = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.FECREG1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TTRBES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNBPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SINDRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCTR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOPRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMTOTD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMTOTS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TFAMIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dbMes = New System.Windows.Forms.ComboBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ndAnio = New System.Windows.Forms.NumericUpDown
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.NmCount2 = New System.Windows.Forms.NumericUpDown
        Me.CmbXlsHoja = New System.Windows.Forms.ComboBox
        Me.NmCount = New System.Windows.Forms.NumericUpDown
        Me.btnAbrirCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.TxtRutaXlsCabecera = New System.Windows.Forms.TextBox
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tabCostos.SuspendLayout()
        Me.tabCostoNeumatico.SuspendLayout()
        CType(Me.dgwDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCostoMantenimiento.SuspendLayout()
        CType(Me.dgwCosMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmCount2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NmCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.tabCostos)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(779, 491)
        Me.KryptonPanel.TabIndex = 0
        '
        'tabCostos
        '
        Me.tabCostos.Controls.Add(Me.tabCostoNeumatico)
        Me.tabCostos.Controls.Add(Me.tabCostoMantenimiento)
        Me.tabCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCostos.Location = New System.Drawing.Point(0, 102)
        Me.tabCostos.Name = "tabCostos"
        Me.tabCostos.SelectedIndex = 0
        Me.tabCostos.Size = New System.Drawing.Size(779, 389)
        Me.tabCostos.TabIndex = 5
        '
        'tabCostoNeumatico
        '
        Me.tabCostoNeumatico.Controls.Add(Me.dgwDatos)
        Me.tabCostoNeumatico.Location = New System.Drawing.Point(4, 22)
        Me.tabCostoNeumatico.Name = "tabCostoNeumatico"
        Me.tabCostoNeumatico.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCostoNeumatico.Size = New System.Drawing.Size(771, 363)
        Me.tabCostoNeumatico.TabIndex = 0
        Me.tabCostoNeumatico.Text = "Consumo de Neumáticos"
        Me.tabCostoNeumatico.UseVisualStyleBackColor = True
        '
        'dgwDatos
        '
        Me.dgwDatos.AllowUserToAddRows = False
        Me.dgwDatos.AllowUserToDeleteRows = False
        Me.dgwDatos.AllowUserToOrderColumns = True
        Me.dgwDatos.ColumnHeadersHeight = 30
        Me.dgwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECREG, Me.NPLCUN, Me.TDETRA, Me.TCRVTA, Me.NROSER, Me.TMRCTR, Me.TRFMED, Me.TRFDIS, Me.QATNAN, Me.TOBS, Me.IMPUNI, Me.IMPTTL})
        Me.dgwDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDatos.Location = New System.Drawing.Point(3, 3)
        Me.dgwDatos.Name = "dgwDatos"
        Me.dgwDatos.RowHeadersVisible = False
        Me.dgwDatos.RowHeadersWidth = 30
        Me.dgwDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDatos.Size = New System.Drawing.Size(765, 357)
        Me.dgwDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwDatos.TabIndex = 3
        '
        'FECREG
        '
        Me.FECREG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECREG.DataPropertyName = "FECREG"
        Me.FECREG.HeaderText = "Fecha"
        Me.FECREG.Name = "FECREG"
        Me.FECREG.ReadOnly = True
        Me.FECREG.Width = 66
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Unidades"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 85
        '
        'TDETRA
        '
        Me.TDETRA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDETRA.DataPropertyName = "TDETRA"
        Me.TDETRA.HeaderText = "Tipo Unidad"
        Me.TDETRA.Name = "TDETRA"
        Me.TDETRA.ReadOnly = True
        Me.TDETRA.Width = 99
        '
        'TCRVTA
        '
        Me.TCRVTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA.DataPropertyName = "TCRVTA"
        Me.TCRVTA.HeaderText = "Operación"
        Me.TCRVTA.Name = "TCRVTA"
        Me.TCRVTA.ReadOnly = True
        Me.TCRVTA.Width = 90
        '
        'NROSER
        '
        Me.NROSER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NROSER.DataPropertyName = "NROSER"
        Me.NROSER.HeaderText = "Códigos"
        Me.NROSER.Name = "NROSER"
        Me.NROSER.ReadOnly = True
        Me.NROSER.Width = 79
        '
        'TMRCTR
        '
        Me.TMRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCTR.DataPropertyName = "TMRCTR"
        Me.TMRCTR.HeaderText = "Marca"
        Me.TMRCTR.Name = "TMRCTR"
        Me.TMRCTR.ReadOnly = True
        Me.TMRCTR.Width = 67
        '
        'TRFMED
        '
        Me.TRFMED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TRFMED.DataPropertyName = "TRFMED"
        Me.TRFMED.HeaderText = "Medida"
        Me.TRFMED.Name = "TRFMED"
        Me.TRFMED.ReadOnly = True
        Me.TRFMED.Width = 75
        '
        'TRFDIS
        '
        Me.TRFDIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TRFDIS.DataPropertyName = "TRFDIS"
        Me.TRFDIS.HeaderText = "Diseño"
        Me.TRFDIS.Name = "TRFDIS"
        Me.TRFDIS.ReadOnly = True
        Me.TRFDIS.Width = 72
        '
        'QATNAN
        '
        Me.QATNAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QATNAN.DataPropertyName = "QATNAN"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.QATNAN.DefaultCellStyle = DataGridViewCellStyle1
        Me.QATNAN.HeaderText = "Cantidad"
        Me.QATNAN.Name = "QATNAN"
        Me.QATNAN.ReadOnly = True
        Me.QATNAN.Width = 83
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observación"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        '
        'IMPUNI
        '
        Me.IMPUNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPUNI.DataPropertyName = "IMPUNI"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.IMPUNI.DefaultCellStyle = DataGridViewCellStyle2
        Me.IMPUNI.HeaderText = "Precio Unitario Soles"
        Me.IMPUNI.Name = "IMPUNI"
        Me.IMPUNI.ReadOnly = True
        Me.IMPUNI.Width = 142
        '
        'IMPTTL
        '
        Me.IMPTTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPTTL.DataPropertyName = "IMPTTL"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.IMPTTL.DefaultCellStyle = DataGridViewCellStyle3
        Me.IMPTTL.HeaderText = "Total Soles"
        Me.IMPTTL.Name = "IMPTTL"
        Me.IMPTTL.ReadOnly = True
        Me.IMPTTL.Width = 91
        '
        'tabCostoMantenimiento
        '
        Me.tabCostoMantenimiento.Controls.Add(Me.dgwCosMan)
        Me.tabCostoMantenimiento.Location = New System.Drawing.Point(4, 22)
        Me.tabCostoMantenimiento.Name = "tabCostoMantenimiento"
        Me.tabCostoMantenimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCostoMantenimiento.Size = New System.Drawing.Size(771, 363)
        Me.tabCostoMantenimiento.TabIndex = 1
        Me.tabCostoMantenimiento.Text = "Consumo de Mantenimiento"
        Me.tabCostoMantenimiento.UseVisualStyleBackColor = True
        '
        'dgwCosMan
        '
        Me.dgwCosMan.AllowUserToAddRows = False
        Me.dgwCosMan.AllowUserToDeleteRows = False
        Me.dgwCosMan.AllowUserToOrderColumns = True
        Me.dgwCosMan.ColumnHeadersHeight = 30
        Me.dgwCosMan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwCosMan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECREG1, Me.TCNTCS, Me.TTRBES, Me.SESTCT, Me.TNBPRV, Me.NPLCUN1, Me.SINDRC, Me.TMRCTR1, Me.TOPRC, Me.IMTOTD, Me.IMTOTS, Me.TFAMIL})
        Me.dgwCosMan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwCosMan.Location = New System.Drawing.Point(3, 3)
        Me.dgwCosMan.Name = "dgwCosMan"
        Me.dgwCosMan.RowHeadersVisible = False
        Me.dgwCosMan.RowHeadersWidth = 30
        Me.dgwCosMan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgwCosMan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwCosMan.Size = New System.Drawing.Size(765, 357)
        Me.dgwCosMan.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwCosMan.TabIndex = 4
        '
        'FECREG1
        '
        Me.FECREG1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECREG1.DataPropertyName = "FECREG"
        Me.FECREG1.HeaderText = "Mes"
        Me.FECREG1.Name = "FECREG1"
        Me.FECREG1.ReadOnly = True
        Me.FECREG1.Width = 57
        '
        'TCNTCS
        '
        Me.TCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCNTCS.DataPropertyName = "TCNTCS"
        Me.TCNTCS.HeaderText = "Centro de Costo"
        Me.TCNTCS.Name = "TCNTCS"
        Me.TCNTCS.ReadOnly = True
        Me.TCNTCS.Width = 120
        '
        'TTRBES
        '
        Me.TTRBES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TTRBES.DataPropertyName = "TTRBES"
        Me.TTRBES.HeaderText = "Detalle de Trabajo"
        Me.TTRBES.Name = "TTRBES"
        Me.TTRBES.ReadOnly = True
        Me.TTRBES.Width = 129
        '
        'SESTCT
        '
        Me.SESTCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTCT.DataPropertyName = "SESTCT"
        Me.SESTCT.HeaderText = "Contrato de Mantenimiento"
        Me.SESTCT.Name = "SESTCT"
        Me.SESTCT.ReadOnly = True
        Me.SESTCT.Width = 180
        '
        'TNBPRV
        '
        Me.TNBPRV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNBPRV.DataPropertyName = "TNBPRV"
        Me.TNBPRV.HeaderText = "Proveedor"
        Me.TNBPRV.Name = "TNBPRV"
        Me.TNBPRV.ReadOnly = True
        Me.TNBPRV.Width = 88
        '
        'NPLCUN1
        '
        Me.NPLCUN1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN1.DataPropertyName = "NPLCUN"
        Me.NPLCUN1.HeaderText = "Unidad"
        Me.NPLCUN1.Name = "NPLCUN1"
        Me.NPLCUN1.ReadOnly = True
        Me.NPLCUN1.Width = 74
        '
        'SINDRC
        '
        Me.SINDRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SINDRC.DataPropertyName = "SINDRC"
        Me.SINDRC.HeaderText = "Propietario"
        Me.SINDRC.Name = "SINDRC"
        Me.SINDRC.ReadOnly = True
        Me.SINDRC.Width = 93
        '
        'TMRCTR1
        '
        Me.TMRCTR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCTR1.DataPropertyName = "TMRCTR"
        Me.TMRCTR1.HeaderText = "Marca"
        Me.TMRCTR1.Name = "TMRCTR1"
        Me.TMRCTR1.ReadOnly = True
        Me.TMRCTR1.Width = 67
        '
        'TOPRC
        '
        Me.TOPRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOPRC.DataPropertyName = "TOPRC"
        Me.TOPRC.HeaderText = "Operación"
        Me.TOPRC.Name = "TOPRC"
        Me.TOPRC.ReadOnly = True
        Me.TOPRC.Width = 90
        '
        'IMTOTD
        '
        Me.IMTOTD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMTOTD.DataPropertyName = "IMTOTD"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.IMTOTD.DefaultCellStyle = DataGridViewCellStyle4
        Me.IMTOTD.HeaderText = "Monto Dólares"
        Me.IMTOTD.Name = "IMTOTD"
        Me.IMTOTD.ReadOnly = True
        Me.IMTOTD.Width = 113
        '
        'IMTOTS
        '
        Me.IMTOTS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMTOTS.DataPropertyName = "IMTOTS"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.IMTOTS.DefaultCellStyle = DataGridViewCellStyle5
        Me.IMTOTS.HeaderText = "Monto Soles"
        Me.IMTOTS.Name = "IMTOTS"
        Me.IMTOTS.ReadOnly = True
        Me.IMTOTS.Width = 101
        '
        'TFAMIL
        '
        Me.TFAMIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TFAMIL.DataPropertyName = "TFAMIL"
        Me.TFAMIL.HeaderText = "Familia"
        Me.TFAMIL.Name = "TFAMIL"
        Me.TFAMIL.ReadOnly = True
        Me.TFAMIL.Width = 72
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesar, Me.btnCancelar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.dbMes)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.ndAnio)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Panel.Controls.Add(Me.NmCount2)
        Me.PanelFiltros.Panel.Controls.Add(Me.CmbXlsHoja)
        Me.PanelFiltros.Panel.Controls.Add(Me.NmCount)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnAbrirCabecera)
        Me.PanelFiltros.Panel.Controls.Add(Me.btnExcelCabecera)
        Me.PanelFiltros.Panel.Controls.Add(Me.TxtRutaXlsCabecera)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.PanelFiltros.Size = New System.Drawing.Size(779, 102)
        Me.PanelFiltros.TabIndex = 3
        Me.PanelFiltros.Text = "INFORMACIÓN DE JUNTA"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "INFORMACIÓN DE JUNTA"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnProcesar
        '
        Me.btnProcesar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.[False]
        Me.btnProcesar.ExtraText = ""
        Me.btnProcesar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.ToolTipImage = Nothing
        Me.btnProcesar.UniqueName = "F07ED250E10C4000F07ED250E10C4000"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "C77D8122AF8A4DC8C77D8122AF8A4DC8"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(72, 11)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(73, 19)
        Me.lblCompania.TabIndex = 131
        Me.lblCompania.Text = "lblCompania"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "lblCompania"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 19)
        Me.KryptonLabel1.TabIndex = 130
        Me.KryptonLabel1.Text = "Compañía : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañía : "
        '
        'dbMes
        '
        Me.dbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dbMes.FormattingEnabled = True
        Me.dbMes.Location = New System.Drawing.Point(477, 11)
        Me.dbMes.Name = "dbMes"
        Me.dbMes.Size = New System.Drawing.Size(113, 21)
        Me.dbMes.TabIndex = 129
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(436, 11)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(37, 19)
        Me.KryptonLabel3.TabIndex = 128
        Me.KryptonLabel3.Text = "Mes : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Mes : "
        '
        'ndAnio
        '
        Me.ndAnio.Location = New System.Drawing.Point(284, 11)
        Me.ndAnio.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.ndAnio.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.ndAnio.Name = "ndAnio"
        Me.ndAnio.ReadOnly = True
        Me.ndAnio.Size = New System.Drawing.Size(53, 20)
        Me.ndAnio.TabIndex = 127
        Me.ndAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ndAnio.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(244, 11)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(36, 19)
        Me.KryptonLabel6.TabIndex = 126
        Me.KryptonLabel6.Text = "Año : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Año : "
        '
        'NmCount2
        '
        Me.NmCount2.BackColor = System.Drawing.SystemColors.Window
        Me.NmCount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NmCount2.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.NmCount2.Location = New System.Drawing.Point(769, 12)
        Me.NmCount2.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmCount2.Name = "NmCount2"
        Me.NmCount2.Size = New System.Drawing.Size(54, 20)
        Me.NmCount2.TabIndex = 59
        Me.NmCount2.Visible = False
        '
        'CmbXlsHoja
        '
        Me.CmbXlsHoja.FormattingEnabled = True
        Me.CmbXlsHoja.Location = New System.Drawing.Point(790, 35)
        Me.CmbXlsHoja.Name = "CmbXlsHoja"
        Me.CmbXlsHoja.Size = New System.Drawing.Size(104, 21)
        Me.CmbXlsHoja.TabIndex = 58
        Me.CmbXlsHoja.Visible = False
        '
        'NmCount
        '
        Me.NmCount.BackColor = System.Drawing.SystemColors.Window
        Me.NmCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NmCount.Cursor = System.Windows.Forms.Cursors.NoMoveVert
        Me.NmCount.Location = New System.Drawing.Point(826, 12)
        Me.NmCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NmCount.Name = "NmCount"
        Me.NmCount.Size = New System.Drawing.Size(68, 20)
        Me.NmCount.TabIndex = 57
        Me.NmCount.Visible = False
        '
        'btnAbrirCabecera
        '
        Me.btnAbrirCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirCabecera.Location = New System.Drawing.Point(690, 12)
        Me.btnAbrirCabecera.Name = "btnAbrirCabecera"
        Me.btnAbrirCabecera.Size = New System.Drawing.Size(74, 47)
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnAbrirCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnAbrirCabecera.TabIndex = 56
        Me.btnAbrirCabecera.Text = "&Abrir"
        Me.btnAbrirCabecera.Values.ExtraText = "Consulta"
        Me.btnAbrirCabecera.Values.Image = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAbrirCabecera.Values.Text = "&Abrir"
        '
        'btnExcelCabecera
        '
        Me.btnExcelCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelCabecera.Location = New System.Drawing.Point(608, 12)
        Me.btnExcelCabecera.Name = "btnExcelCabecera"
        Me.btnExcelCabecera.Size = New System.Drawing.Size(74, 47)
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnExcelCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnExcelCabecera.TabIndex = 55
        Me.btnExcelCabecera.Text = "&Cargar"
        Me.btnExcelCabecera.Values.ExtraText = "Consulta"
        Me.btnExcelCabecera.Values.Image = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExcelCabecera.Values.Text = "&Cargar"
        '
        'TxtRutaXlsCabecera
        '
        Me.TxtRutaXlsCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRutaXlsCabecera.Location = New System.Drawing.Point(77, 39)
        Me.TxtRutaXlsCabecera.Name = "TxtRutaXlsCabecera"
        Me.TxtRutaXlsCabecera.Size = New System.Drawing.Size(514, 20)
        Me.TxtRutaXlsCabecera.TabIndex = 54
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(10, 39)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(62, 19)
        Me.lblTipoAlmacen.TabIndex = 53
        Me.lblTipoAlmacen.Text = "Cabecera : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Cabecera : "
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'frmImportarConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 491)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmImportarConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Costo Neumático de Excel"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.tabCostos.ResumeLayout(False)
        Me.tabCostoNeumatico.ResumeLayout(False)
        CType(Me.dgwDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCostoMantenimiento.ResumeLayout(False)
        CType(Me.dgwCosMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.ndAnio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmCount2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NmCount, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dbMes As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ndAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NmCount2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CmbXlsHoja As System.Windows.Forms.ComboBox
    Friend WithEvents NmCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAbrirCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TxtRutaXlsCabecera As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tabCostos As System.Windows.Forms.TabControl
    Friend WithEvents tabCostoNeumatico As System.Windows.Forms.TabPage
    Friend WithEvents dgwDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents FECREG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDETRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROSER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRFMED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRFDIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QATNAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPUNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPTTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabCostoMantenimiento As System.Windows.Forms.TabPage
    Friend WithEvents dgwCosMan As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents FECREG1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TTRBES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNBPRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINDRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCTR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOPRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMTOTD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMTOTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFAMIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
End Class
