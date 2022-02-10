<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemOC_DgF01
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucItemOC_DgF01))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dstItemOC = New System.Data.DataSet
        Me.dtItemOC = New System.Data.DataTable
        Me.NRITOC = New System.Data.DataColumn
        Me.TCITCL = New System.Data.DataColumn
        Me.TCITPR = New System.Data.DataColumn
        Me.TDITES = New System.Data.DataColumn
        Me.TDITIN = New System.Data.DataColumn
        Me.CPTDAR = New System.Data.DataColumn
        Me.QCNTIT = New System.Data.DataColumn
        Me.TUNDIT = New System.Data.DataColumn
        Me.IVUNIT = New System.Data.DataColumn
        Me.IVTOIT = New System.Data.DataColumn
        Me.QTOLMAX = New System.Data.DataColumn
        Me.QTOLMIN = New System.Data.DataColumn
        Me.FMPDME = New System.Data.DataColumn
        Me.FMPIME = New System.Data.DataColumn
        Me.TLUGOR = New System.Data.DataColumn
        Me.TLUGEN = New System.Data.DataColumn
        Me.QCNPEN = New System.Data.DataColumn
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblItemOC = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.btnMarcarItems = New System.Windows.Forms.ToolStripButton
        Me.dgItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.M_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPTDAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNPEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNREC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDAITM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVUNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTOLMAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTOLMIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FMPDME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FMPIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGenerarBulto = New System.Windows.Forms.ToolStripButton
        CType(Me.dstItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dstItemOC
        '
        Me.dstItemOC.DataSetName = "dstOrdenCompra"
        Me.dstItemOC.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstItemOC.Tables.AddRange(New System.Data.DataTable() {Me.dtItemOC})
        '
        'dtItemOC
        '
        Me.dtItemOC.Columns.AddRange(New System.Data.DataColumn() {Me.NRITOC, Me.TCITCL, Me.TCITPR, Me.TDITES, Me.TDITIN, Me.CPTDAR, Me.QCNTIT, Me.TUNDIT, Me.IVUNIT, Me.IVTOIT, Me.QTOLMAX, Me.QTOLMIN, Me.FMPDME, Me.FMPIME, Me.TLUGOR, Me.TLUGEN, Me.QCNPEN})
        Me.dtItemOC.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtItemOC.TableName = "dtItemOC"
        '
        'NRITOC
        '
        Me.NRITOC.ColumnName = "NRITOC"
        Me.NRITOC.DataType = GetType(Integer)
        Me.NRITOC.DefaultValue = 0
        '
        'TCITCL
        '
        Me.TCITCL.ColumnName = "TCITCL"
        Me.TCITCL.DefaultValue = ""
        '
        'TCITPR
        '
        Me.TCITPR.ColumnName = "TCITPR"
        Me.TCITPR.DefaultValue = ""
        '
        'TDITES
        '
        Me.TDITES.ColumnName = "TDITES"
        Me.TDITES.DefaultValue = ""
        '
        'TDITIN
        '
        Me.TDITIN.ColumnName = "TDITIN"
        '
        'CPTDAR
        '
        Me.CPTDAR.ColumnName = "CPTDAR"
        Me.CPTDAR.DefaultValue = ""
        '
        'QCNTIT
        '
        Me.QCNTIT.ColumnName = "QCNTIT"
        Me.QCNTIT.DataType = GetType(Decimal)
        Me.QCNTIT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNDIT
        '
        Me.TUNDIT.ColumnName = "TUNDIT"
        Me.TUNDIT.DefaultValue = ""
        '
        'IVUNIT
        '
        Me.IVUNIT.ColumnName = "IVUNIT"
        Me.IVUNIT.DataType = GetType(Decimal)
        Me.IVUNIT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'IVTOIT
        '
        Me.IVTOIT.ColumnName = "IVTOIT"
        Me.IVTOIT.DataType = GetType(Decimal)
        Me.IVTOIT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'QTOLMAX
        '
        Me.QTOLMAX.ColumnName = "QTOLMAX"
        Me.QTOLMAX.DataType = GetType(Decimal)
        Me.QTOLMAX.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'QTOLMIN
        '
        Me.QTOLMIN.ColumnName = "QTOLMIN"
        Me.QTOLMIN.DataType = GetType(Decimal)
        Me.QTOLMIN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'FMPDME
        '
        Me.FMPDME.ColumnName = "FMPDME"
        Me.FMPDME.DataType = GetType(Date)
        '
        'FMPIME
        '
        Me.FMPIME.ColumnName = "FMPIME"
        Me.FMPIME.DataType = GetType(Date)
        '
        'TLUGOR
        '
        Me.TLUGOR.ColumnName = "TLUGOR"
        Me.TLUGOR.DefaultValue = ""
        '
        'TLUGEN
        '
        Me.TLUGEN.ColumnName = "TLUGEN"
        Me.TLUGEN.DefaultValue = ""
        '
        'QCNPEN
        '
        Me.QCNPEN.ColumnName = "QCNPEN"
        Me.QCNPEN.DataType = GetType(Decimal)
        Me.QCNPEN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItemOC, Me.btnEliminar, Me.tssSep_02, Me.btnEditar, Me.tssSep_01, Me.btnAgregar, Me.btnMarcarItems, Me.ToolStripSeparator1, Me.btnGenerarBulto})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(525, 25)
        Me.tsMenuOpciones.TabIndex = 22
        '
        'lblItemOC
        '
        Me.lblItemOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemOC.Name = "lblItemOC"
        Me.lblItemOC.Size = New System.Drawing.Size(51, 22)
        Me.lblItemOC.Text = "ITEM(s)"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 22)
        Me.btnEditar.Text = "&Modificar"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'btnMarcarItems
        '
        Me.btnMarcarItems.BackgroundImage = CType(resources.GetObject("btnMarcarItems.BackgroundImage"), System.Drawing.Image)
        Me.btnMarcarItems.CheckOnClick = True
        Me.btnMarcarItems.Image = CType(resources.GetObject("btnMarcarItems.Image"), System.Drawing.Image)
        Me.btnMarcarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarItems.Name = "btnMarcarItems"
        Me.btnMarcarItems.Size = New System.Drawing.Size(96, 22)
        Me.btnMarcarItems.Text = " &Marcar Todos"
        '
        'dgItemOC
        '
        Me.dgItemOC.AllowUserToAddRows = False
        Me.dgItemOC.AllowUserToDeleteRows = False
        Me.dgItemOC.AutoGenerateColumns = False
        Me.dgItemOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHK, Me.M_NRITOC, Me.M_TCITCL, Me.M_TCITPR, Me.M_TDITES, Me.M_TDITIN, Me.M_CPTDAR, Me.M_QCNTIT, Me.M_TUNDIT, Me.M_QCNPEN, Me.M_QCNREC, Me.M_TDAITM, Me.M_IVUNIT, Me.M_IVTOIT, Me.M_QTOLMAX, Me.M_QTOLMIN, Me.M_FMPDME, Me.M_FMPIME, Me.M_TLUGOR, Me.M_TLUGEN})
        Me.dgItemOC.DataMember = "dtItemOC"
        Me.dgItemOC.DataSource = Me.dstItemOC
        Me.dgItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemOC.Location = New System.Drawing.Point(0, 25)
        Me.dgItemOC.MultiSelect = False
        Me.dgItemOC.Name = "dgItemOC"
        Me.dgItemOC.RowHeadersWidth = 20
        Me.dgItemOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemOC.Size = New System.Drawing.Size(525, 210)
        Me.dgItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemOC.TabIndex = 23
        '
        'M_CHK
        '
        Me.M_CHK.DataPropertyName = "CHK"
        Me.M_CHK.FalseValue = "FALSE"
        Me.M_CHK.HeaderText = "Chk"
        Me.M_CHK.Name = "M_CHK"
        Me.M_CHK.ReadOnly = True
        Me.M_CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.M_CHK.TrueValue = "TRUE"
        Me.M_CHK.Width = 30
        '
        'M_NRITOC
        '
        Me.M_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NRITOC.DataPropertyName = "NRITOC"
        Me.M_NRITOC.HeaderText = "Item"
        Me.M_NRITOC.Name = "M_NRITOC"
        Me.M_NRITOC.ReadOnly = True
        Me.M_NRITOC.Width = 56
        '
        'M_TCITCL
        '
        Me.M_TCITCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITCL.DataPropertyName = "TCITCL"
        Me.M_TCITCL.HeaderText = "Cód. Cliente"
        Me.M_TCITCL.Name = "M_TCITCL"
        Me.M_TCITCL.ReadOnly = True
        Me.M_TCITCL.Width = 93
        '
        'M_TCITPR
        '
        Me.M_TCITPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITPR.DataPropertyName = "TCITPR"
        Me.M_TCITPR.HeaderText = "Cód. Proveedor"
        Me.M_TCITPR.Name = "M_TCITPR"
        Me.M_TCITPR.ReadOnly = True
        Me.M_TCITPR.Visible = False
        '
        'M_TDITES
        '
        Me.M_TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITES.DataPropertyName = "TDITES"
        Me.M_TDITES.HeaderText = "Descripción"
        Me.M_TDITES.Name = "M_TDITES"
        Me.M_TDITES.ReadOnly = True
        Me.M_TDITES.Width = 92
        '
        'M_TDITIN
        '
        Me.M_TDITIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITIN.DataPropertyName = "TDITIN"
        Me.M_TDITIN.HeaderText = "Descripción (IN)"
        Me.M_TDITIN.Name = "M_TDITIN"
        Me.M_TDITIN.ReadOnly = True
        Me.M_TDITIN.Visible = False
        '
        'M_CPTDAR
        '
        Me.M_CPTDAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CPTDAR.DataPropertyName = "CPTDAR"
        Me.M_CPTDAR.HeaderText = "Part. Arancelaria"
        Me.M_CPTDAR.Name = "M_CPTDAR"
        Me.M_CPTDAR.ReadOnly = True
        Me.M_CPTDAR.Visible = False
        '
        'M_QCNTIT
        '
        Me.M_QCNTIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNTIT.DataPropertyName = "QCNTIT"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = "0.00"
        Me.M_QCNTIT.DefaultCellStyle = DataGridViewCellStyle17
        Me.M_QCNTIT.HeaderText = "Cantidad"
        Me.M_QCNTIT.Name = "M_QCNTIT"
        Me.M_QCNTIT.ReadOnly = True
        Me.M_QCNTIT.Width = 78
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNDIT.DataPropertyName = "TUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 70
        '
        'M_QCNPEN
        '
        Me.M_QCNPEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNPEN.DataPropertyName = "QCNPEN"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = "0.00"
        Me.M_QCNPEN.DefaultCellStyle = DataGridViewCellStyle18
        Me.M_QCNPEN.HeaderText = "Cant. Pendiente"
        Me.M_QCNPEN.Name = "M_QCNPEN"
        Me.M_QCNPEN.ReadOnly = True
        Me.M_QCNPEN.Width = 112
        '
        'M_QCNREC
        '
        Me.M_QCNREC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNREC.DataPropertyName = "QCNREC"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle19.Format = "N2"
        DataGridViewCellStyle19.NullValue = "0.00"
        Me.M_QCNREC.DefaultCellStyle = DataGridViewCellStyle19
        Me.M_QCNREC.HeaderText = "Cant. Recibida"
        Me.M_QCNREC.MaxInputLength = 10
        Me.M_QCNREC.Name = "M_QCNREC"
        Me.M_QCNREC.ReadOnly = True
        Me.M_QCNREC.Width = 106
        '
        'M_TDAITM
        '
        Me.M_TDAITM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDAITM.DataPropertyName = "TDAITM"
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.M_TDAITM.DefaultCellStyle = DataGridViewCellStyle20
        Me.M_TDAITM.HeaderText = "Observaciones"
        Me.M_TDAITM.MaxInputLength = 300
        Me.M_TDAITM.Name = "M_TDAITM"
        Me.M_TDAITM.ReadOnly = True
        Me.M_TDAITM.Width = 107
        '
        'M_IVUNIT
        '
        Me.M_IVUNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVUNIT.DataPropertyName = "IVUNIT"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0.00"
        Me.M_IVUNIT.DefaultCellStyle = DataGridViewCellStyle21
        Me.M_IVUNIT.HeaderText = "Imp. Unitario"
        Me.M_IVUNIT.Name = "M_IVUNIT"
        Me.M_IVUNIT.ReadOnly = True
        Me.M_IVUNIT.Width = 95
        '
        'M_IVTOIT
        '
        Me.M_IVTOIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVTOIT.DataPropertyName = "IVTOIT"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = "0.00"
        Me.M_IVTOIT.DefaultCellStyle = DataGridViewCellStyle22
        Me.M_IVTOIT.HeaderText = "Imp. Total"
        Me.M_IVTOIT.Name = "M_IVTOIT"
        Me.M_IVTOIT.ReadOnly = True
        Me.M_IVTOIT.Width = 83
        '
        'M_QTOLMAX
        '
        Me.M_QTOLMAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.M_QTOLMAX.DataPropertyName = "QTOLMAX"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = "0.00"
        Me.M_QTOLMAX.DefaultCellStyle = DataGridViewCellStyle23
        Me.M_QTOLMAX.HeaderText = "Tolerancia Máx."
        Me.M_QTOLMAX.Name = "M_QTOLMAX"
        Me.M_QTOLMAX.ReadOnly = True
        Me.M_QTOLMAX.Visible = False
        '
        'M_QTOLMIN
        '
        Me.M_QTOLMIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QTOLMIN.DataPropertyName = "QTOLMIN"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = "0.00"
        Me.M_QTOLMIN.DefaultCellStyle = DataGridViewCellStyle24
        Me.M_QTOLMIN.HeaderText = "Tolerancia Mín."
        Me.M_QTOLMIN.Name = "M_QTOLMIN"
        Me.M_QTOLMIN.ReadOnly = True
        Me.M_QTOLMIN.Visible = False
        '
        'M_FMPDME
        '
        Me.M_FMPDME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FMPDME.DataPropertyName = "FMPDME"
        Me.M_FMPDME.HeaderText = "Fch. Est. Entrega"
        Me.M_FMPDME.Name = "M_FMPDME"
        Me.M_FMPDME.ReadOnly = True
        Me.M_FMPDME.Width = 118
        '
        'M_FMPIME
        '
        Me.M_FMPIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FMPIME.DataPropertyName = "FMPIME"
        Me.M_FMPIME.HeaderText = "Fch. Req. Planta"
        Me.M_FMPIME.Name = "M_FMPIME"
        Me.M_FMPIME.ReadOnly = True
        Me.M_FMPIME.Width = 116
        '
        'M_TLUGOR
        '
        Me.M_TLUGOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGOR.DataPropertyName = "TLUGOR"
        Me.M_TLUGOR.HeaderText = "Lugar Origen"
        Me.M_TLUGOR.Name = "M_TLUGOR"
        Me.M_TLUGOR.ReadOnly = True
        Me.M_TLUGOR.Visible = False
        '
        'M_TLUGEN
        '
        Me.M_TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGEN.DataPropertyName = "TLUGEN"
        Me.M_TLUGEN.HeaderText = "Lugar Entrega"
        Me.M_TLUGEN.Name = "M_TLUGEN"
        Me.M_TLUGEN.ReadOnly = True
        Me.M_TLUGEN.Width = 103
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGenerarBulto
        '
        Me.btnGenerarBulto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenerarBulto.Image = CType(resources.GetObject("btnGenerarBulto.Image"), System.Drawing.Image)
        Me.btnGenerarBulto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarBulto.Name = "btnGenerarBulto"
        Me.btnGenerarBulto.Size = New System.Drawing.Size(92, 22)
        Me.btnGenerarBulto.Text = "&Generar Bulto"
        '
        'ucItemOC_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgItemOC)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucItemOC_DgF01"
        Me.Size = New System.Drawing.Size(525, 235)
        CType(Me.dstItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dstItemOC As System.Data.DataSet
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblItemOC As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents NRITOC As System.Data.DataColumn
    Private WithEvents TCITCL As System.Data.DataColumn
    Private WithEvents TCITPR As System.Data.DataColumn
    Private WithEvents TDITES As System.Data.DataColumn
    Private WithEvents TDITIN As System.Data.DataColumn
    Private WithEvents CPTDAR As System.Data.DataColumn
    Private WithEvents QCNTIT As System.Data.DataColumn
    Private WithEvents TUNDIT As System.Data.DataColumn
    Private WithEvents IVUNIT As System.Data.DataColumn
    Private WithEvents IVTOIT As System.Data.DataColumn
    Private WithEvents QTOLMAX As System.Data.DataColumn
    Private WithEvents QTOLMIN As System.Data.DataColumn
    Private WithEvents FMPDME As System.Data.DataColumn
    Private WithEvents FMPIME As System.Data.DataColumn
    Private WithEvents TLUGOR As System.Data.DataColumn
    Private WithEvents TLUGEN As System.Data.DataColumn
    Friend WithEvents btnMarcarItems As System.Windows.Forms.ToolStripButton
    Private WithEvents QCNPEN As System.Data.DataColumn
    Private WithEvents dtItemOC As System.Data.DataTable
    Private WithEvents dgItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPTDAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNPEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDAITM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVUNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVTOIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTOLMAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTOLMIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FMPDME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FMPIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGenerarBulto As System.Windows.Forms.ToolStripButton

End Class
