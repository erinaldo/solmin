<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCuentaOC
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCuentaOC))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgCuentasOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExcel = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_05 = New System.Windows.Forms.ToolStripSeparator
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.dgCuentasDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IPRCTJ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.UcPaginacionDetalle = New Ransa.Utilitario.UCPaginacion
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblFechaFin = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkFechas = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.chkDistribucion = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.cbxLugarEntrega = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblLote = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPIMSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPPOSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTCST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTCSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTCSF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCTAFE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINCVG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FFINVG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNCTAMA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCCNCOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNELPEP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNGFSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCCEBEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgCuentasOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgCuentasDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(882, 620)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 125)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgCuentasOC)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.UcPaginacion)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.dgCuentasDetalle)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.UcPaginacionDetalle)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(882, 495)
        Me.KryptonSplitContainer1.SplitterDistance = 251
        Me.KryptonSplitContainer1.TabIndex = 72
        '
        'dgCuentasOC
        '
        Me.dgCuentasOC.AllowUserToAddRows = False
        Me.dgCuentasOC.AllowUserToDeleteRows = False
        Me.dgCuentasOC.AllowUserToResizeColumns = False
        Me.dgCuentasOC.AllowUserToResizeRows = False
        Me.dgCuentasOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCuentasOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCuentasOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORCML, Me.TLUGEN, Me.PSTPIMSA, Me.PSTPPOSA, Me.TCTCST, Me.TCTCSA, Me.TCTCSF, Me.TCTAFE, Me.FINCVG, Me.FFINVG, Me.PSNCTAMA, Me.PSCCNCOS, Me.PSNELPEP, Me.PSNORSAP, Me.PSNGFSAP, Me.PSCCEBEN, Me.NSEQIN})
        Me.dgCuentasOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCuentasOC.Location = New System.Drawing.Point(0, 25)
        Me.dgCuentasOC.MultiSelect = False
        Me.dgCuentasOC.Name = "dgCuentasOC"
        Me.dgCuentasOC.ReadOnly = True
        Me.dgCuentasOC.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuentasOC.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCuentasOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuentasOC.Size = New System.Drawing.Size(882, 201)
        Me.dgCuentasOC.StandardTab = True
        Me.dgCuentasOC.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgCuentasOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgCuentasOC.TabIndex = 67
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssSep_01, Me.btnExcel, Me.tssSep_02, Me.btnEliminar, Me.tssSep_03, Me.btnModificar, Me.tssSep_04, Me.btnAgregar, Me.tssSep_05, Me.lblTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(882, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnExcel
        '
        Me.btnExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(87, 22)
        Me.btnExcel.Text = "Importar CI"
        Me.btnExcel.Visible = False
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        Me.tssSep_02.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'tssSep_04
        '
        Me.tssSep_04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_04.Name = "tssSep_04"
        Me.tssSep_04.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'tssSep_05
        '
        Me.tssSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_05.Name = "tssSep_05"
        Me.tssSep_05.Size = New System.Drawing.Size(6, 25)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(122, 22)
        Me.lblTitulo.Text = "Ordenes de Compra "
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 226)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(882, 25)
        Me.UcPaginacion.TabIndex = 70
        '
        'dgCuentasDetalle
        '
        Me.dgCuentasDetalle.AllowUserToAddRows = False
        Me.dgCuentasDetalle.AllowUserToDeleteRows = False
        Me.dgCuentasDetalle.AllowUserToResizeColumns = False
        Me.dgCuentasDetalle.AllowUserToResizeRows = False
        Me.dgCuentasDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCuentasDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCuentasDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.NCRRDT, Me.CCLNT, Me.IPRCTJ})
        Me.dgCuentasDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCuentasDetalle.Location = New System.Drawing.Point(0, 25)
        Me.dgCuentasDetalle.MultiSelect = False
        Me.dgCuentasDetalle.Name = "dgCuentasDetalle"
        Me.dgCuentasDetalle.ReadOnly = True
        Me.dgCuentasDetalle.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCuentasDetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCuentasDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuentasDetalle.Size = New System.Drawing.Size(882, 189)
        Me.dgCuentasDetalle.StandardTab = True
        Me.dgCuentasDetalle.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgCuentasDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgCuentasDetalle.TabIndex = 68
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSTCTCST"
        Me.DataGridViewTextBoxColumn3.HeaderText = "C.I Terrestre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSTCTCSA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "C.I Aereo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSTCTCSF"
        Me.DataGridViewTextBoxColumn5.HeaderText = "C.I  Fluvial"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSTCTAFE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "C.I Afectación"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PNNSEQIN"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PNNSEQIN"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'NCRRDT
        '
        Me.NCRRDT.DataPropertyName = "PNNCRRDT"
        Me.NCRRDT.HeaderText = "NCRRDT"
        Me.NCRRDT.Name = "NCRRDT"
        Me.NCRRDT.ReadOnly = True
        Me.NCRRDT.Visible = False
        Me.NCRRDT.Width = 78
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "PNCCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 68
        '
        'IPRCTJ
        '
        Me.IPRCTJ.DataPropertyName = "PNIPRCTJ"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.IPRCTJ.DefaultCellStyle = DataGridViewCellStyle2
        Me.IPRCTJ.HeaderText = "Porcentaje"
        Me.IPRCTJ.Name = "IPRCTJ"
        Me.IPRCTJ.ReadOnly = True
        Me.IPRCTJ.Width = 92
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripLabel1})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(882, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 71
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton1.Text = "Eliminar"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton2.Text = "Modificar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton3.Text = "Agregar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(225, 22)
        Me.ToolStripLabel1.Text = " Lista Cuentas por Ordenes de Compra"
        '
        'UcPaginacionDetalle
        '
        Me.UcPaginacionDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacionDetalle.Location = New System.Drawing.Point(0, 214)
        Me.UcPaginacionDetalle.Name = "UcPaginacionDetalle"
        Me.UcPaginacionDetalle.PageCount = 0
        Me.UcPaginacionDetalle.PageNumber = 1
        Me.UcPaginacionDetalle.PageSize = 20
        Me.UcPaginacionDetalle.Size = New System.Drawing.Size(882, 25)
        Me.UcPaginacionDetalle.TabIndex = 66
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtOc)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFin)
        Me.khgFiltros.Panel.Controls.Add(Me.chkFechas)
        Me.khgFiltros.Panel.Controls.Add(Me.chkDistribucion)
        Me.khgFiltros.Panel.Controls.Add(Me.DtFechaFin)
        Me.khgFiltros.Panel.Controls.Add(Me.DtFechaIni)
        Me.khgFiltros.Panel.Controls.Add(Me.cbxLugarEntrega)
        Me.khgFiltros.Panel.Controls.Add(Me.lblLote)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Size = New System.Drawing.Size(882, 125)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 5
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
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(35, 42)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(115, 20)
        Me.KryptonLabel1.TabIndex = 95
        Me.KryptonLabel1.Text = "Orden de Compra :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Orden de Compra :"
        '
        'txtOc
        '
        Me.txtOc.Location = New System.Drawing.Point(155, 44)
        Me.txtOc.Name = "txtOc"
        Me.txtOc.Size = New System.Drawing.Size(261, 22)
        Me.txtOc.TabIndex = 7
        '
        'lblFechaFin
        '
        Me.lblFechaFin.Location = New System.Drawing.Point(639, 43)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(41, 20)
        Me.lblFechaFin.TabIndex = 5
        Me.lblFechaFin.Text = "Hasta "
        Me.lblFechaFin.Values.ExtraText = ""
        Me.lblFechaFin.Values.Image = Nothing
        Me.lblFechaFin.Values.Text = "Hasta "
        Me.lblFechaFin.Visible = False
        '
        'chkFechas
        '
        Me.chkFechas.Checked = False
        Me.chkFechas.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFechas.Location = New System.Drawing.Point(451, 44)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(90, 20)
        Me.chkFechas.TabIndex = 3
        Me.chkFechas.Text = "Fecha Inicio:"
        Me.chkFechas.Values.ExtraText = ""
        Me.chkFechas.Values.Image = Nothing
        Me.chkFechas.Values.Text = "Fecha Inicio:"
        Me.chkFechas.Visible = False
        '
        'chkDistribucion
        '
        Me.chkDistribucion.Checked = False
        Me.chkDistribucion.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDistribucion.Location = New System.Drawing.Point(451, 18)
        Me.chkDistribucion.Name = "chkDistribucion"
        Me.chkDistribucion.Size = New System.Drawing.Size(111, 20)
        Me.chkDistribucion.TabIndex = 1
        Me.chkDistribucion.Text = "Por Distribución"
        Me.chkDistribucion.Values.ExtraText = ""
        Me.chkDistribucion.Values.Image = Nothing
        Me.chkDistribucion.Values.Text = "Por Distribución"
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Enabled = False
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(683, 43)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.DtFechaFin.TabIndex = 6
        Me.DtFechaFin.Visible = False
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Enabled = False
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(537, 43)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(92, 20)
        Me.DtFechaIni.TabIndex = 4
        Me.DtFechaIni.Visible = False
        '
        'cbxLugarEntrega
        '
        Me.cbxLugarEntrega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxLugarEntrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxLugarEntrega.DropDownWidth = 537
        Me.cbxLugarEntrega.FormattingEnabled = False
        Me.cbxLugarEntrega.ItemHeight = 15
        Me.cbxLugarEntrega.Location = New System.Drawing.Point(155, 69)
        Me.cbxLugarEntrega.Name = "cbxLugarEntrega"
        Me.cbxLugarEntrega.Size = New System.Drawing.Size(261, 23)
        Me.cbxLugarEntrega.TabIndex = 2
        Me.cbxLugarEntrega.Visible = False
        '
        'lblLote
        '
        Me.lblLote.Location = New System.Drawing.Point(104, 68)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(40, 20)
        Me.lblLote.TabIndex = 83
        Me.lblLote.Text = "Lote :"
        Me.lblLote.Values.ExtraText = ""
        Me.lblLote.Values.Image = Nothing
        Me.lblLote.Values.Text = "Lote :"
        Me.lblLote.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(155, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(261, 22)
        Me.txtCliente.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(96, 17)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel4.TabIndex = 82
        Me.KryptonLabel4.Text = "Cliente :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente :"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(793, 17)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(84, 68)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "PSNORCML"
        Me.NORCML.HeaderText = "Orden de Compra"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        Me.NORCML.Width = 131
        '
        'TLUGEN
        '
        Me.TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLUGEN.DataPropertyName = "PSTLUGEN"
        Me.TLUGEN.HeaderText = "Lote"
        Me.TLUGEN.MinimumWidth = 100
        Me.TLUGEN.Name = "TLUGEN"
        Me.TLUGEN.ReadOnly = True
        '
        'PSTPIMSA
        '
        Me.PSTPIMSA.DataPropertyName = "PSTPIMSA"
        Me.PSTPIMSA.HeaderText = "Tipo de C.I "
        Me.PSTPIMSA.Name = "PSTPIMSA"
        Me.PSTPIMSA.ReadOnly = True
        Me.PSTPIMSA.Width = 96
        '
        'PSTPPOSA
        '
        Me.PSTPPOSA.DataPropertyName = "PSTPPOSA"
        Me.PSTPPOSA.HeaderText = "Tipo Posición"
        Me.PSTPPOSA.Name = "PSTPPOSA"
        Me.PSTPPOSA.ReadOnly = True
        Me.PSTPPOSA.Width = 108
        '
        'TCTCST
        '
        Me.TCTCST.DataPropertyName = "PSTCTCST"
        Me.TCTCST.HeaderText = "C.I Terrestre"
        Me.TCTCST.Name = "TCTCST"
        Me.TCTCST.ReadOnly = True
        Me.TCTCST.Width = 99
        '
        'TCTCSA
        '
        Me.TCTCSA.DataPropertyName = "PSTCTCSA"
        Me.TCTCSA.HeaderText = "C.I Aereo"
        Me.TCTCSA.Name = "TCTCSA"
        Me.TCTCSA.ReadOnly = True
        Me.TCTCSA.Width = 84
        '
        'TCTCSF
        '
        Me.TCTCSF.DataPropertyName = "PSTCTCSF"
        Me.TCTCSF.HeaderText = "C.I  Fluvial"
        Me.TCTCSF.Name = "TCTCSF"
        Me.TCTCSF.ReadOnly = True
        Me.TCTCSF.Width = 90
        '
        'TCTAFE
        '
        Me.TCTAFE.DataPropertyName = "PSTCTAFE"
        Me.TCTAFE.HeaderText = "C.I Afectación"
        Me.TCTAFE.Name = "TCTAFE"
        Me.TCTAFE.ReadOnly = True
        Me.TCTAFE.Width = 110
        '
        'FINCVG
        '
        Me.FINCVG.DataPropertyName = "PSFINCVG"
        Me.FINCVG.HeaderText = "Fecha Ini Vig."
        Me.FINCVG.Name = "FINCVG"
        Me.FINCVG.ReadOnly = True
        Me.FINCVG.Width = 106
        '
        'FFINVG
        '
        Me.FFINVG.DataPropertyName = "PSFFINVG"
        Me.FFINVG.HeaderText = "Fecha Fin Vig."
        Me.FFINVG.Name = "FFINVG"
        Me.FFINVG.ReadOnly = True
        Me.FFINVG.Width = 109
        '
        'PSNCTAMA
        '
        Me.PSNCTAMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNCTAMA.DataPropertyName = "PSNCTAMA"
        Me.PSNCTAMA.HeaderText = "Cta Mayor"
        Me.PSNCTAMA.Name = "PSNCTAMA"
        Me.PSNCTAMA.ReadOnly = True
        Me.PSNCTAMA.Width = 91
        '
        'PSCCNCOS
        '
        Me.PSCCNCOS.DataPropertyName = "PSCCNCOS"
        Me.PSCCNCOS.HeaderText = "Código CeCo SAP"
        Me.PSCCNCOS.Name = "PSCCNCOS"
        Me.PSCCNCOS.ReadOnly = True
        Me.PSCCNCOS.Width = 131
        '
        'PSNELPEP
        '
        Me.PSNELPEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNELPEP.DataPropertyName = "PSNELPEP"
        Me.PSNELPEP.HeaderText = "Nro. Elemento PEP"
        Me.PSNELPEP.Name = "PSNELPEP"
        Me.PSNELPEP.ReadOnly = True
        Me.PSNELPEP.Width = 135
        '
        'PSNORSAP
        '
        Me.PSNORSAP.DataPropertyName = "PSNORSAP"
        Me.PSNORSAP.HeaderText = "Nr. Orden SAP"
        Me.PSNORSAP.Name = "PSNORSAP"
        Me.PSNORSAP.ReadOnly = True
        Me.PSNORSAP.Width = 112
        '
        'PSNGFSAP
        '
        Me.PSNGFSAP.DataPropertyName = "PSNGFSAP"
        Me.PSNGFSAP.HeaderText = "Nr. Grafo SAP"
        Me.PSNGFSAP.Name = "PSNGFSAP"
        Me.PSNGFSAP.ReadOnly = True
        Me.PSNGFSAP.Width = 108
        '
        'PSCCEBEN
        '
        Me.PSCCEBEN.DataPropertyName = "PSCCEBEN"
        Me.PSCCEBEN.HeaderText = "Código CeBe SAP"
        Me.PSCCEBEN.Name = "PSCCEBEN"
        Me.PSCCEBEN.ReadOnly = True
        Me.PSCCEBEN.Visible = False
        Me.PSCCEBEN.Width = 129
        '
        'NSEQIN
        '
        Me.NSEQIN.DataPropertyName = "PNNSEQIN"
        Me.NSEQIN.HeaderText = "PNNSEQIN"
        Me.NSEQIN.Name = "NSEQIN"
        Me.NSEQIN.ReadOnly = True
        Me.NSEQIN.Visible = False
        Me.NSEQIN.Width = 94
        '
        'frmListaCuentaOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 620)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaCuentaOC"
        Me.Text = "Listado de Cuentas de Imputación por Ordenes de Compra"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgCuentasOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgCuentasDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
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
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UcPaginacionDetalle As Ransa.Utilitario.UCPaginacion
    Friend WithEvents dgCuentasOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxLugarEntrega As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents lblLote As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkDistribucion As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dgCuentasDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblFechaFin As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkFechas As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPRCTJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPIMSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPPOSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTCSF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCTAFE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINCVG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFINVG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNCTAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCNCOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNELPEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNGFSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCEBEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
