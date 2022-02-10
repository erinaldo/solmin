<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColumaEmbarqueAduanas
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgColumna = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK_COLUMNA = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NMRCRL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMBCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMVAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NSEPRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPCRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QANCOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCheck = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminarItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCopiaPerfil = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAgregarCheck = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.btnRenumerar = New System.Windows.Forms.ToolStripButton
        Me.txtNumeracionAvance = New System.Windows.Forms.ToolStripTextBox
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgColumna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgColumna)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(953, 597)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgColumna
        '
        Me.dtgColumna.AllowUserToAddRows = False
        Me.dtgColumna.AllowUserToDeleteRows = False
        Me.dtgColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgColumna.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK_COLUMNA, Me.NMRCRL, Me.TNMBCM, Me.NOMVAR, Me.NSEPRE, Me.TCOLUM, Me.TDITIN, Me.STPCRE, Me.QANCOL})
        Me.dtgColumna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgColumna.Location = New System.Drawing.Point(0, 86)
        Me.dtgColumna.MultiSelect = False
        Me.dtgColumna.Name = "dtgColumna"
        Me.dtgColumna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgColumna.Size = New System.Drawing.Size(953, 511)
        Me.dtgColumna.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgColumna.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgColumna.TabIndex = 37
        '
        'CHK_COLUMNA
        '
        Me.CHK_COLUMNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHK_COLUMNA.HeaderText = "Check"
        Me.CHK_COLUMNA.Name = "CHK_COLUMNA"
        Me.CHK_COLUMNA.Width = 48
        '
        'NMRCRL
        '
        Me.NMRCRL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRCRL.DataPropertyName = "NMRCRL"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NMRCRL.DefaultCellStyle = DataGridViewCellStyle1
        Me.NMRCRL.HeaderText = "Código"
        Me.NMRCRL.Name = "NMRCRL"
        Me.NMRCRL.ReadOnly = True
        Me.NMRCRL.Width = 74
        '
        'TNMBCM
        '
        Me.TNMBCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMBCM.DataPropertyName = "TNMBCM"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TNMBCM.DefaultCellStyle = DataGridViewCellStyle2
        Me.TNMBCM.HeaderText = "Código-Seg"
        Me.TNMBCM.Name = "TNMBCM"
        Me.TNMBCM.ReadOnly = True
        Me.TNMBCM.Width = 97
        '
        'NOMVAR
        '
        Me.NOMVAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOMVAR.DataPropertyName = "NOMVAR"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NOMVAR.DefaultCellStyle = DataGridViewCellStyle3
        Me.NOMVAR.HeaderText = "Descripción"
        Me.NOMVAR.Name = "NOMVAR"
        Me.NOMVAR.ReadOnly = True
        Me.NOMVAR.Width = 96
        '
        'NSEPRE
        '
        Me.NSEPRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NSEPRE.DataPropertyName = "NSEPRE"
        Me.NSEPRE.HeaderText = "Orden-Seg"
        Me.NSEPRE.Name = "NSEPRE"
        Me.NSEPRE.Width = 92
        '
        'TCOLUM
        '
        Me.TCOLUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCOLUM.DataPropertyName = "TCOLUM"
        Me.TCOLUM.HeaderText = "Descripción(Español)-Seg"
        Me.TCOLUM.Name = "TCOLUM"
        Me.TCOLUM.Width = 166
        '
        'TDITIN
        '
        Me.TDITIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDITIN.DataPropertyName = "TDITIN"
        Me.TDITIN.HeaderText = "Descripción(Inglés)-Seg"
        Me.TDITIN.Name = "TDITIN"
        Me.TDITIN.Width = 156
        '
        'STPCRE
        '
        Me.STPCRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STPCRE.DataPropertyName = "STPCRE"
        Me.STPCRE.HeaderText = "Visible-Seg"
        Me.STPCRE.Name = "STPCRE"
        Me.STPCRE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STPCRE.Width = 93
        '
        'QANCOL
        '
        Me.QANCOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QANCOL.DataPropertyName = "QANCOL"
        Me.QANCOL.HeaderText = "Tamaño"
        Me.QANCOL.Name = "QANCOL"
        Me.QANCOL.Width = 76
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheck, Me.ToolStripLabel2, Me.tsbBuscar, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.btnEliminarItem, Me.ToolStripSeparator3, Me.btnCopiaPerfil, Me.ToolStripSeparator4, Me.tsbAgregarCheck, Me.ToolStripSeparator5, Me.tsbGuardar, Me.btnRenumerar, Me.txtNumeracionAvance})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 61)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(953, 25)
        Me.ToolStrip1.TabIndex = 36
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.btnNoMarcarItems
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(92, 22)
        Me.btnCheck.Text = "Check Todos"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(234, 22)
        Me.ToolStripLabel2.Tag = ""
        Me.ToolStripLabel2.Text = "   Columnas--> Visible(S) | No Visible(N) "
        '
        'tsbBuscar
        '
        Me.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(61, 22)
        Me.tsbBuscar.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminarItem
        '
        Me.btnEliminarItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarItem.Image = Global.SOLMIN_SC.My.Resources.Resources.db_remove
        Me.btnEliminarItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarItem.Name = "btnEliminarItem"
        Me.btnEliminarItem.Size = New System.Drawing.Size(93, 22)
        Me.btnEliminarItem.Text = "Eliminar Item"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnCopiaPerfil
        '
        Me.btnCopiaPerfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCopiaPerfil.Image = Global.SOLMIN_SC.My.Resources.Resources.observaciones
        Me.btnCopiaPerfil.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopiaPerfil.Name = "btnCopiaPerfil"
        Me.btnCopiaPerfil.Size = New System.Drawing.Size(90, 22)
        Me.btnCopiaPerfil.Text = "Copiar Perfil"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAgregarCheck
        '
        Me.tsbAgregarCheck.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregarCheck.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
        Me.tsbAgregarCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarCheck.Name = "tsbAgregarCheck"
        Me.tsbAgregarCheck.Size = New System.Drawing.Size(68, 22)
        Me.tsbAgregarCheck.Text = "&Agregar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.fileexport
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'btnRenumerar
        '
        Me.btnRenumerar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnRenumerar.Image = Global.SOLMIN_SC.My.Resources.Resources.cell_layout
        Me.btnRenumerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRenumerar.Name = "btnRenumerar"
        Me.btnRenumerar.Size = New System.Drawing.Size(90, 22)
        Me.btnRenumerar.Text = "Re- Ordenar"
        '
        'txtNumeracionAvance
        '
        Me.txtNumeracionAvance.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtNumeracionAvance.Name = "txtNumeracionAvance"
        Me.txtNumeracionAvance.Size = New System.Drawing.Size(100, 25)
        Me.txtNumeracionAvance.ToolTipText = "Incremento"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(953, 61)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 9
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(8, 8)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel24.TabIndex = 54
        Me.KryptonLabel24.Text = "Compañía:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Compañía:"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(77, 8)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(276, 23)
        Me.cmbCompania.TabIndex = 53
        Me.cmbCompania.Usuario = ""
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(426, 10)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(256, 21)
        Me.cmbCliente.TabIndex = 39
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(370, 10)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente :"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NMRCRL"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Orden"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TNMBCM"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NSEPRE"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCOLUM"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción(Español)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TDITIN"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción(Inglés)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "STPCRE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STPCRE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Visible"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QANCOL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tamaño"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'frmColumaEmbarqueAduanas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 597)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmColumaEmbarqueAduanas"
        Me.Text = "Columnas Embarque"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgColumna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgColumna As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregarCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCopiaPerfil As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminarItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CHK_COLUMNA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NMRCRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMVAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSEPRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCOLUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPCRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QANCOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRenumerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtNumeracionAvance As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
