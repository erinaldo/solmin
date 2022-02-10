<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuntoDeControlCheckpoinMasivo
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPTDAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNPEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVUNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTOLMAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTOLMIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FMPDME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FMPIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCTCST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtObs = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtpFechaReal = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFechaEstimada = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCheckpoint = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorSalir = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tssSeparadorGrabar = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dgItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(584, 342)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dgItemOC)
        Me.KryptonPanel1.Controls.Add(Me.GroupBox1)
        Me.KryptonPanel1.Controls.Add(Me.Label3)
        Me.KryptonPanel1.Controls.Add(Me.cmbCheckpoint)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(584, 317)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 46
        '
        'dgItemOC
        '
        Me.dgItemOC.AllowUserToAddRows = False
        Me.dgItemOC.AllowUserToDeleteRows = False
        Me.dgItemOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NRITOC, Me.M_TCITCL, Me.M_TCITPR, Me.M_TDITES, Me.M_TDITIN, Me.M_CPTDAR, Me.M_QCNTIT, Me.M_TUNDIT, Me.M_QCNPEN, Me.M_IVUNIT, Me.M_IVTOIT, Me.M_QTOLMAX, Me.M_QTOLMIN, Me.M_FMPDME, Me.M_FMPIME, Me.M_TLUGOR, Me.M_TLUGEN, Me.M_TCTCST})
        Me.dgItemOC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgItemOC.Location = New System.Drawing.Point(0, 166)
        Me.dgItemOC.MultiSelect = False
        Me.dgItemOC.Name = "dgItemOC"
        Me.dgItemOC.RowHeadersWidth = 20
        Me.dgItemOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemOC.Size = New System.Drawing.Size(584, 151)
        Me.dgItemOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemOC.TabIndex = 68
        '
        'M_NRITOC
        '
        Me.M_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NRITOC.DataPropertyName = "PNNRITOC"
        Me.M_NRITOC.HeaderText = "Item"
        Me.M_NRITOC.Name = "M_NRITOC"
        Me.M_NRITOC.ReadOnly = True
        Me.M_NRITOC.Width = 60
        '
        'M_TCITCL
        '
        Me.M_TCITCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITCL.DataPropertyName = "PSTCITCL"
        Me.M_TCITCL.HeaderText = "Cód. Cliente"
        Me.M_TCITCL.Name = "M_TCITCL"
        Me.M_TCITCL.ReadOnly = True
        Me.M_TCITCL.Width = 101
        '
        'M_TCITPR
        '
        Me.M_TCITPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITPR.DataPropertyName = "PSTCITPR"
        Me.M_TCITPR.HeaderText = "Cód. Proveedor"
        Me.M_TCITPR.Name = "M_TCITPR"
        Me.M_TCITPR.ReadOnly = True
        Me.M_TCITPR.Visible = False
        '
        'M_TDITES
        '
        Me.M_TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITES.DataPropertyName = "PSTDITES"
        Me.M_TDITES.HeaderText = "Descripción"
        Me.M_TDITES.Name = "M_TDITES"
        Me.M_TDITES.ReadOnly = True
        Me.M_TDITES.Width = 98
        '
        'M_TDITIN
        '
        Me.M_TDITIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITIN.DataPropertyName = "PSTDITIN"
        Me.M_TDITIN.HeaderText = "Descripción (IN)"
        Me.M_TDITIN.Name = "M_TDITIN"
        Me.M_TDITIN.ReadOnly = True
        Me.M_TDITIN.Visible = False
        '
        'M_CPTDAR
        '
        Me.M_CPTDAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CPTDAR.DataPropertyName = "PSCPTDAR"
        Me.M_CPTDAR.HeaderText = "Part. Arancelaria"
        Me.M_CPTDAR.Name = "M_CPTDAR"
        Me.M_CPTDAR.ReadOnly = True
        Me.M_CPTDAR.Visible = False
        '
        'M_QCNTIT
        '
        Me.M_QCNTIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNTIT.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.M_QCNTIT.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_QCNTIT.HeaderText = "Cantidad"
        Me.M_QCNTIT.Name = "M_QCNTIT"
        Me.M_QCNTIT.ReadOnly = True
        Me.M_QCNTIT.Width = 84
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNDIT.DataPropertyName = "PSTUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 74
        '
        'M_QCNPEN
        '
        Me.M_QCNPEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNPEN.DataPropertyName = "PNQCNPEN"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.M_QCNPEN.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QCNPEN.HeaderText = "Cant. Pendiente"
        Me.M_QCNPEN.Name = "M_QCNPEN"
        Me.M_QCNPEN.ReadOnly = True
        Me.M_QCNPEN.Width = 120
        '
        'M_IVUNIT
        '
        Me.M_IVUNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVUNIT.DataPropertyName = "PNIVUNIT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.M_IVUNIT.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_IVUNIT.HeaderText = "Imp. Unitario"
        Me.M_IVUNIT.Name = "M_IVUNIT"
        Me.M_IVUNIT.ReadOnly = True
        Me.M_IVUNIT.Width = 105
        '
        'M_IVTOIT
        '
        Me.M_IVTOIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVTOIT.DataPropertyName = "PNIVTOIT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.M_IVTOIT.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_IVTOIT.HeaderText = "Imp. Total"
        Me.M_IVTOIT.Name = "M_IVTOIT"
        Me.M_IVTOIT.ReadOnly = True
        Me.M_IVTOIT.Width = 90
        '
        'M_QTOLMAX
        '
        Me.M_QTOLMAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.M_QTOLMAX.DataPropertyName = "PNQTOLMAX"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.M_QTOLMAX.DefaultCellStyle = DataGridViewCellStyle5
        Me.M_QTOLMAX.HeaderText = "Tolerancia Máx."
        Me.M_QTOLMAX.Name = "M_QTOLMAX"
        Me.M_QTOLMAX.ReadOnly = True
        Me.M_QTOLMAX.Visible = False
        '
        'M_QTOLMIN
        '
        Me.M_QTOLMIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QTOLMIN.DataPropertyName = "PNQTOLMIN"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.M_QTOLMIN.DefaultCellStyle = DataGridViewCellStyle6
        Me.M_QTOLMIN.HeaderText = "Tolerancia Mín."
        Me.M_QTOLMIN.Name = "M_QTOLMIN"
        Me.M_QTOLMIN.ReadOnly = True
        Me.M_QTOLMIN.Visible = False
        '
        'M_FMPDME
        '
        Me.M_FMPDME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FMPDME.DataPropertyName = "FechaEstimadaEntrega"
        Me.M_FMPDME.HeaderText = "Fch. Est. Entrega"
        Me.M_FMPDME.Name = "M_FMPDME"
        Me.M_FMPDME.ReadOnly = True
        Me.M_FMPDME.Width = 122
        '
        'M_FMPIME
        '
        Me.M_FMPIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FMPIME.DataPropertyName = "FechaReqPlanta"
        Me.M_FMPIME.HeaderText = "Fch. Req. Planta"
        Me.M_FMPIME.Name = "M_FMPIME"
        Me.M_FMPIME.ReadOnly = True
        Me.M_FMPIME.Width = 120
        '
        'M_TLUGOR
        '
        Me.M_TLUGOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGOR.DataPropertyName = "PSTLUGOR"
        Me.M_TLUGOR.HeaderText = "Lugar Origen"
        Me.M_TLUGOR.Name = "M_TLUGOR"
        Me.M_TLUGOR.ReadOnly = True
        Me.M_TLUGOR.Visible = False
        '
        'M_TLUGEN
        '
        Me.M_TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGEN.DataPropertyName = "PSTLUGEN"
        Me.M_TLUGEN.HeaderText = "Lugar Entrega"
        Me.M_TLUGEN.Name = "M_TLUGEN"
        Me.M_TLUGEN.ReadOnly = True
        Me.M_TLUGEN.Width = 109
        '
        'M_TCTCST
        '
        Me.M_TCTCST.DataPropertyName = "PSTCTCST"
        Me.M_TCTCST.HeaderText = "Centro de Costo"
        Me.M_TCTCST.Name = "M_TCTCST"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.dtpFechaReal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEstimada)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(64, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 111)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Fecha Estimada :"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(101, 53)
        Me.txtObs.MaxLength = 250
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(293, 43)
        Me.txtObs.TabIndex = 65
        '
        'dtpFechaReal
        '
        Me.dtpFechaReal.Checked = False
        Me.dtpFechaReal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReal.Location = New System.Drawing.Point(294, 24)
        Me.dtpFechaReal.Name = "dtpFechaReal"
        Me.dtpFechaReal.ShowCheckBox = True
        Me.dtpFechaReal.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaReal.TabIndex = 45
        Me.dtpFechaReal.Value = New Date(2008, 1, 1, 9, 55, 0, 0)
        Me.dtpFechaReal.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(225, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Fecha Real :"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(6, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Observación :"
        '
        'dtpFechaEstimada
        '
        Me.dtpFechaEstimada.Checked = False
        Me.dtpFechaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEstimada.Location = New System.Drawing.Point(101, 21)
        Me.dtpFechaEstimada.Name = "dtpFechaEstimada"
        Me.dtpFechaEstimada.ShowCheckBox = True
        Me.dtpFechaEstimada.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaEstimada.TabIndex = 63
        Me.dtpFechaEstimada.Value = New Date(2008, 1, 1, 9, 55, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(61, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Punto de Control :"
        '
        'cmbCheckpoint
        '
        Me.cmbCheckpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCheckpoint.DropDownWidth = 121
        Me.cmbCheckpoint.FormattingEnabled = False
        Me.cmbCheckpoint.ItemHeight = 15
        Me.cmbCheckpoint.Location = New System.Drawing.Point(165, 11)
        Me.cmbCheckpoint.Name = "cmbCheckpoint"
        Me.cmbCheckpoint.Size = New System.Drawing.Size(343, 23)
        Me.cmbCheckpoint.TabIndex = 62
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.tssSeparadorSalir, Me.tsbGrabar, Me.ToolStripSeparator1, Me.tssSeparadorGrabar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(584, 25)
        Me.tsMenuOpciones.TabIndex = 45
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Punto de Control "
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'tssSeparadorSalir
        '
        Me.tssSeparadorSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorSalir.Name = "tssSeparadorSalir"
        Me.tssSeparadorSalir.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.SOLMIN_SC.My.Resources.Resources.filesave
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.tsbGrabar.Text = "&Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tssSeparadorGrabar
        '
        Me.tssSeparadorGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorGrabar.Name = "tssSeparadorGrabar"
        Me.tssSeparadorGrabar.Size = New System.Drawing.Size(6, 25)
        '
        'frmPuntoDeControlCheckpoinMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 342)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 380)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 380)
        Me.Name = "frmPuntoDeControlCheckpoinMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Seguimiento de Checkpoint "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dgItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaReal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCheckpoint As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEstimada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObs As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadorSalir As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSeparadorGrabar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents dgItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPTDAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNPEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVUNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVTOIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTOLMAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTOLMIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FMPDME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FMPIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCTCST As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
