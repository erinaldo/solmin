<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListServicios
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgRubro = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.tsSep_05 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tsSep_06 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.tslRubroPorCliente = New System.Windows.Forms.ToolStripLabel
        Me.TaServicios = New System.Windows.Forms.TabControl
        Me.tabClientes = New System.Windows.Forms.TabPage
        Me.dtgServiciosXRubro = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tslDetalle = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminarDet = New System.Windows.Forms.ToolStripButton
        Me.tsS03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificarDet = New System.Windows.Forms.ToolStripButton
        Me.tsS04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregarDet = New System.Windows.Forms.ToolStripButton
        Me.tsS05 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ucCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
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
        Me.NRRUBR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMRUB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRSRRB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMSER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVNV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TSRVIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IAFCDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IPRCDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDSRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dtgRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.TaServicios.SuspendLayout()
        Me.tabClientes.SuspendLayout()
        CType(Me.dtgServiciosXRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(880, 492)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 48)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtgRubro)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tsMenuOpciones)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.TaServicios)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(880, 444)
        Me.KryptonSplitContainer1.SplitterDistance = 189
        Me.KryptonSplitContainer1.TabIndex = 6
        '
        'dtgRubro
        '
        Me.dtgRubro.AllowUserToAddRows = False
        Me.dtgRubro.AllowUserToDeleteRows = False
        Me.dtgRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRubro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRRUBR, Me.NOMRUB, Me.CANTIDAD, Me.CCMPN})
        Me.dtgRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgRubro.Location = New System.Drawing.Point(0, 25)
        Me.dtgRubro.Margin = New System.Windows.Forms.Padding(0)
        Me.dtgRubro.Name = "dtgRubro"
        Me.dtgRubro.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgRubro.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgRubro.Size = New System.Drawing.Size(880, 164)
        Me.dtgRubro.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgRubro.TabIndex = 0
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.tsSep_05, Me.btnExportarExcel, Me.tsSep_06, Me.btnEliminar, Me.tssSep_03, Me.btnModificar, Me.tssSep_04, Me.btnAgregar, Me.tssSep_02, Me.tslRubroPorCliente})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(880, 25)
        Me.tsMenuOpciones.TabIndex = 27
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_CT.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'tsSep_05
        '
        Me.tsSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep_05.Name = "tsSep_05"
        Me.tsSep_05.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(99, 22)
        Me.btnExportarExcel.Text = "Exportar Excel"
        '
        'tsSep_06
        '
        Me.tsSep_06.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep_06.Name = "tsSep_06"
        Me.tsSep_06.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
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
        Me.btnModificar.Image = Global.SOLMIN_CT.My.Resources.Resources.ok
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
        Me.btnAgregar.Image = Global.SOLMIN_CT.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'tslRubroPorCliente
        '
        Me.tslRubroPorCliente.Name = "tslRubroPorCliente"
        Me.tslRubroPorCliente.Size = New System.Drawing.Size(107, 22)
        Me.tslRubroPorCliente.Text = "Servicios Generales"
        '
        'TaServicios
        '
        Me.TaServicios.Controls.Add(Me.tabClientes)
        Me.TaServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaServicios.Location = New System.Drawing.Point(0, 25)
        Me.TaServicios.Name = "TaServicios"
        Me.TaServicios.SelectedIndex = 0
        Me.TaServicios.Size = New System.Drawing.Size(880, 225)
        Me.TaServicios.TabIndex = 74
        '
        'tabClientes
        '
        Me.tabClientes.Controls.Add(Me.dtgServiciosXRubro)
        Me.tabClientes.Location = New System.Drawing.Point(4, 22)
        Me.tabClientes.Name = "tabClientes"
        Me.tabClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClientes.Size = New System.Drawing.Size(872, 199)
        Me.tabClientes.TabIndex = 0
        Me.tabClientes.Text = "Servicios"
        Me.tabClientes.UseVisualStyleBackColor = True
        '
        'dtgServiciosXRubro
        '
        Me.dtgServiciosXRubro.AllowUserToAddRows = False
        Me.dtgServiciosXRubro.AllowUserToDeleteRows = False
        Me.dtgServiciosXRubro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRSRRB, Me.NOMSER, Me.CSRVNV, Me.TCMTRF, Me.TSRVIN, Me.IAFCDT, Me.IPRCDT, Me.CDSRSP, Me.TDSRSP})
        Me.dtgServiciosXRubro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgServiciosXRubro.Location = New System.Drawing.Point(3, 3)
        Me.dtgServiciosXRubro.Margin = New System.Windows.Forms.Padding(0)
        Me.dtgServiciosXRubro.Name = "dtgServiciosXRubro"
        Me.dtgServiciosXRubro.ReadOnly = True
        Me.dtgServiciosXRubro.RowHeadersWidth = 25
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgServiciosXRubro.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgServiciosXRubro.Size = New System.Drawing.Size(866, 193)
        Me.dtgServiciosXRubro.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgServiciosXRubro.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslDetalle, Me.btnEliminarDet, Me.tsS03, Me.btnModificarDet, Me.tsS04, Me.btnAgregarDet, Me.tsS05})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(880, 25)
        Me.ToolStrip1.TabIndex = 73
        '
        'tslDetalle
        '
        Me.tslDetalle.Name = "tslDetalle"
        Me.tslDetalle.Size = New System.Drawing.Size(114, 22)
        Me.tslDetalle.Text = "Servicios Específicos"
        '
        'btnEliminarDet
        '
        Me.btnEliminarDet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarDet.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnEliminarDet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarDet.Name = "btnEliminarDet"
        Me.btnEliminarDet.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminarDet.Text = "Eliminar"
        '
        'tsS03
        '
        Me.tsS03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsS03.Name = "tsS03"
        Me.tsS03.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificarDet
        '
        Me.btnModificarDet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificarDet.Image = Global.SOLMIN_CT.My.Resources.Resources.ok
        Me.btnModificarDet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificarDet.Name = "btnModificarDet"
        Me.btnModificarDet.Size = New System.Drawing.Size(78, 22)
        Me.btnModificarDet.Text = "Modificar"
        '
        'tsS04
        '
        Me.tsS04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsS04.Name = "tsS04"
        Me.tsS04.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregarDet
        '
        Me.btnAgregarDet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregarDet.Image = Global.SOLMIN_CT.My.Resources.Resources.edit_add
        Me.btnAgregarDet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregarDet.Name = "btnAgregarDet"
        Me.btnAgregarDet.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregarDet.Text = "Agregar"
        '
        'tsS05
        '
        Me.tsS05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsS05.Name = "tsS05"
        Me.tsS05.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.lblDivision)
        Me.KryptonPanel2.Controls.Add(Me.UcDivision)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel2.Controls.Add(Me.ucCompania)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(880, 48)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 5
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(373, 12)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(63, 20)
        Me.lblDivision.TabIndex = 52
        Me.lblDivision.Text = "División  :"
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División  :"
        '
        'UcDivision
        '
        Me.UcDivision.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision.CDVSN_ANTERIOR = Nothing
        Me.UcDivision.Compania = ""
        Me.UcDivision.Division = Nothing
        Me.UcDivision.DivisionDefault = Nothing
        Me.UcDivision.DivisionDescripcion = Nothing
        Me.UcDivision.ItemTodos = False
        Me.UcDivision.Location = New System.Drawing.Point(437, 12)
        Me.UcDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision.Name = "UcDivision"
        Me.UcDivision.obeDivision = Nothing
        Me.UcDivision.pHabilitado = True
        Me.UcDivision.pRequerido = False
        Me.UcDivision.Size = New System.Drawing.Size(250, 23)
        Me.UcDivision.TabIndex = 1
        Me.UcDivision.Usuario = ""
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(7, 12)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel9.TabIndex = 50
        Me.KryptonLabel9.Text = "Compania :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Compania :"
        '
        'ucCompania
        '
        Me.ucCompania.BackColor = System.Drawing.Color.Transparent
        Me.ucCompania.CCMPN_ANTERIOR = Nothing
        Me.ucCompania.CCMPN_CodigoCompania = Nothing
        Me.ucCompania.CCMPN_CompaniaDefault = "EZ"
        Me.ucCompania.CCMPN_Descripcion = Nothing
        Me.ucCompania.Habilitar = True
        Me.ucCompania.Location = New System.Drawing.Point(76, 12)
        Me.ucCompania.MinimumSize = New System.Drawing.Size(175, 27)
        Me.ucCompania.Name = "ucCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.ucCompania.oBeCompania = BeCompania1
        Me.ucCompania.Size = New System.Drawing.Size(274, 27)
        Me.ucCompania.TabIndex = 0
        Me.ucCompania.Usuario = ""
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripLabel1.Tag = ""
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.tsbGrabar.Text = "&Grabar"
        Me.tsbGrabar.ToolTipText = "Grabar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRRUBR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMRUB"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Rubro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRSRRB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NOMSER"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TCMTRF"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Rubro de venta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CSRVNV"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cod. Rubro AS400"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 13
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TCMTRF"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Rubro de venta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TSRVIN"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cod. Material"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IAFCDT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe minimo detracción"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 107
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IPRCDT"
        DataGridViewCellStyle6.Format = "%"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn10.HeaderText = "Porcentaje detracción"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 182
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IPRCDT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.NullValue = "0"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn11.HeaderText = "Porcentaje detracción"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 151
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cod.MacroServicio"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "MacroServicio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'NRRUBR
        '
        Me.NRRUBR.DataPropertyName = "NRRUBR"
        Me.NRRUBR.HeaderText = "Código"
        Me.NRRUBR.Name = "NRRUBR"
        Me.NRRUBR.ReadOnly = True
        '
        'NOMRUB
        '
        Me.NOMRUB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMRUB.DataPropertyName = "NOMRUB"
        Me.NOMRUB.HeaderText = "Servicios generales"
        Me.NOMRUB.Name = "NOMRUB"
        Me.NOMRUB.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.DataPropertyName = "CANTIDAD"
        Me.CANTIDAD.HeaderText = "Cantidad "
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'NRSRRB
        '
        Me.NRSRRB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRSRRB.DataPropertyName = "NRSRRB"
        Me.NRSRRB.HeaderText = "Código"
        Me.NRSRRB.Name = "NRSRRB"
        Me.NRSRRB.ReadOnly = True
        Me.NRSRRB.Width = 75
        '
        'NOMSER
        '
        Me.NOMSER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMSER.DataPropertyName = "NOMSER"
        Me.NOMSER.HeaderText = "Servicio"
        Me.NOMSER.Name = "NOMSER"
        Me.NOMSER.ReadOnly = True
        '
        'CSRVNV
        '
        Me.CSRVNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CSRVNV.DataPropertyName = "CSRVNV"
        Me.CSRVNV.HeaderText = "Cod. Rubro AS400"
        Me.CSRVNV.Name = "CSRVNV"
        Me.CSRVNV.ReadOnly = True
        '
        'TCMTRF
        '
        Me.TCMTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "Rubro de venta"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.ReadOnly = True
        '
        'TSRVIN
        '
        Me.TSRVIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TSRVIN.DataPropertyName = "TSRVIN"
        Me.TSRVIN.HeaderText = "Cod. Material"
        Me.TSRVIN.Name = "TSRVIN"
        Me.TSRVIN.ReadOnly = True
        Me.TSRVIN.Width = 107
        '
        'IAFCDT
        '
        Me.IAFCDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IAFCDT.DataPropertyName = "IAFCDT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IAFCDT.DefaultCellStyle = DataGridViewCellStyle2
        Me.IAFCDT.HeaderText = "Importe mínimo detracción"
        Me.IAFCDT.Name = "IAFCDT"
        Me.IAFCDT.ReadOnly = True
        Me.IAFCDT.Width = 182
        '
        'IPRCDT
        '
        Me.IPRCDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IPRCDT.DataPropertyName = "IPRCDT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = "0"
        Me.IPRCDT.DefaultCellStyle = DataGridViewCellStyle3
        Me.IPRCDT.HeaderText = "Porcentaje detracción"
        Me.IPRCDT.Name = "IPRCDT"
        Me.IPRCDT.ReadOnly = True
        Me.IPRCDT.Width = 151
        '
        'CDSRSP
        '
        Me.CDSRSP.DataPropertyName = "CDSRSP"
        Me.CDSRSP.HeaderText = "Cod.MacroServicio"
        Me.CDSRSP.Name = "CDSRSP"
        Me.CDSRSP.ReadOnly = True
        '
        'TDSRSP
        '
        Me.TDSRSP.DataPropertyName = "TDSRSP"
        Me.TDSRSP.HeaderText = "MacroServicio"
        Me.TDSRSP.Name = "TDSRSP"
        Me.TDSRSP.ReadOnly = True
        '
        'frmListServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 492)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListServicios"
        Me.Text = "Servicios"
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
        CType(Me.dtgRubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.TaServicios.ResumeLayout(False)
        Me.tabClientes.ResumeLayout(False)
        CType(Me.dtgServiciosXRubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
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
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Public WithEvents ucCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtgRubro As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tslDetalle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminarDet As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsS03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificarDet As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsS04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregarDet As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsS05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslRubroPorCliente As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TaServicios As System.Windows.Forms.TabControl
    Friend WithEvents tabClientes As System.Windows.Forms.TabPage
    Friend WithEvents dtgServiciosXRubro As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep_06 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NRRUBR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMRUB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRSRRB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMSER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSRVIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IAFCDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPRCDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDSRSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSRSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
