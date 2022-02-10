<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaMasivaVale
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cboCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnAsignar = New System.Windows.Forms.ToolStripButton()
        Me.btnGenLiq = New System.Windows.Forms.ToolStripButton()
        Me.btnImport = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpValesPendiente = New System.Windows.Forms.TabPage()
        Me.dtgVales = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.NLQCMB_V = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCUN_V = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NVLGRF_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCRCMB_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGRFO_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGRFO_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_REF_GRIFO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCMPPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPCMB_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QGLCNM_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSGNMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSTGLN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUB_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_DOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCCT1_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDCCT1_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRCN1_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRCN2_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRCN3_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPOD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpValesPendiente.SuspendLayout()
        CType(Me.dtgVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.txtVehiculo)
        Me.Panel1.Controls.Add(Me.lblVehiculo)
        Me.Panel1.Controls.Add(Me.cboDivision)
        Me.Panel1.Controls.Add(Me.cboCompania)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1286, 77)
        Me.Panel1.TabIndex = 11
        '
        'cboDivision
        '
        Me.cboDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.DropDownWidth = 211
        Me.cboDivision.FormattingEnabled = False
        Me.cboDivision.ItemHeight = 20
        Me.cboDivision.Location = New System.Drawing.Point(541, 11)
        Me.cboDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(316, 28)
        Me.cboDivision.TabIndex = 451
        Me.cboDivision.TabStop = False
        '
        'cboCompania
        '
        Me.cboCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompania.DropDownWidth = 248
        Me.cboCompania.FormattingEnabled = False
        Me.cboCompania.ItemHeight = 20
        Me.cboCompania.Location = New System.Drawing.Point(111, 11)
        Me.cboCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCompania.Name = "cboCompania"
        Me.cboCompania.Size = New System.Drawing.Size(331, 28)
        Me.cboCompania.TabIndex = 449
        Me.cboCompania.TabStop = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(18, 14)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(81, 24)
        Me.KryptonLabel1.TabIndex = 448
        Me.KryptonLabel1.Text = "Compañía"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañía"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(460, 14)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(65, 24)
        Me.KryptonLabel5.TabIndex = 450
        Me.KryptonLabel5.Text = "División"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnexportar, Me.btnEliminar, Me.btnAsignar, Me.btnGenLiq, Me.btnImport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 77)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1286, 27)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnexportar
        '
        Me.btnexportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnexportar.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(89, 24)
        Me.btnexportar.Text = "Exportar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnAsignar
        '
        Me.btnAsignar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAsignar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAsignar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(115, 24)
        Me.btnAsignar.Text = "Asignar Vale"
        Me.btnAsignar.Visible = False
        '
        'btnGenLiq
        '
        Me.btnGenLiq.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenLiq.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnGenLiq.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenLiq.Name = "btnGenLiq"
        Me.btnGenLiq.Size = New System.Drawing.Size(109, 24)
        Me.btnGenLiq.Text = "Generar Liq"
        Me.btnGenLiq.Visible = False
        '
        'btnImport
        '
        Me.btnImport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImport.Image = Global.SOLMIN_ST.My.Resources.Resources.GenerarReporte
        Me.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(129, 24)
        Me.btnImport.Text = "Importar Vales"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpValesPendiente)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 104)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1286, 414)
        Me.TabControl1.TabIndex = 13
        '
        'tpValesPendiente
        '
        Me.tpValesPendiente.Controls.Add(Me.dtgVales)
        Me.tpValesPendiente.Location = New System.Drawing.Point(4, 25)
        Me.tpValesPendiente.Name = "tpValesPendiente"
        Me.tpValesPendiente.Size = New System.Drawing.Size(1278, 385)
        Me.tpValesPendiente.TabIndex = 3
        Me.tpValesPendiente.Text = "Vales Pend. Asignación"
        Me.tpValesPendiente.UseVisualStyleBackColor = True
        '
        'dtgVales
        '
        Me.dtgVales.AllowUserToAddRows = False
        Me.dtgVales.AllowUserToDeleteRows = False
        Me.dtgVales.AllowUserToOrderColumns = True
        Me.dtgVales.AllowUserToResizeRows = False
        Me.dtgVales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgVales.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dtgVales.ColumnHeadersHeight = 30
        Me.dtgVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.NLQCMB_V, Me.NPLCUN_V, Me.NRITEM, Me.NVLGRF_A, Me.FCRCMB_A, Me.CGRFO_A, Me.TGRFO_A, Me.COD_REF_GRIFO, Me.DataGridViewTextBoxColumn8, Me.DCMPPR, Me.CTPCMB_A, Me.QGLCNM_1, Me.TSGNMN, Me.CSTGLN, Me.SUB_TOTAL, Me.TIPO_DOC, Me.NDCCT1_A, Me.FDCCT1_A, Me.NPRCN1_A, Me.NPRCN2_A, Me.NPRCN3_A, Me.CCMPN_A, Me.CDVSN_A, Me.CTPOD1})
        Me.dtgVales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgVales.Location = New System.Drawing.Point(0, 0)
        Me.dtgVales.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgVales.Name = "dtgVales"
        Me.dtgVales.RowHeadersVisible = False
        Me.dtgVales.RowHeadersWidth = 30
        Me.dtgVales.Size = New System.Drawing.Size(1278, 385)
        Me.dtgVales.StandardTab = True
        Me.dtgVales.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgVales.TabIndex = 4
        '
        'CHK
        '
        Me.CHK.HeaderText = "Chk"
        Me.CHK.Name = "CHK"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OBS_CARGA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Carga"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 119
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUC_GRIFO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ruc Grifo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OBS_REGISTRO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 101
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NRO_VALE"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro Vale"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 91
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALMACEN"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 112
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IMPORTE"
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TGRFO"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NRUCPR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ruc Razón Social"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 155
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NRUCPR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ruc Razón Social"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 155
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DCMPPR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 127
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CTPCMB"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tipo Combustible"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 160
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "QGLNCM"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cant. Comb (Gal)"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 155
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TSGNMN"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 97
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CSTGLN"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Costo x Galón"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 134
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SUB_TOTAL"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Sub Total"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 104
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TIPO_DOC"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo Documento"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 154
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NDCCTS"
        Me.DataGridViewTextBoxColumn17.HeaderText = "N° Documento"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 141
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FDCCT1"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Fecha Documento"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 162
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NPRCN1"
        Me.DataGridViewTextBoxColumn19.HeaderText = "N° Precinto 1"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 129
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NPRCN2"
        Me.DataGridViewTextBoxColumn20.HeaderText = "N° Precinto 2"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 129
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NPRCN3"
        Me.DataGridViewTextBoxColumn21.HeaderText = "N° Precinto 3"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 129
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Cod. Compañia"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Cod. Division"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CTPOD1"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CTPOD1"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'NLQCMB_V
        '
        Me.NLQCMB_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NLQCMB_V.DataPropertyName = "NLQCMB"
        Me.NLQCMB_V.HeaderText = "Liquidación"
        Me.NLQCMB_V.Name = "NLQCMB_V"
        Me.NLQCMB_V.ReadOnly = True
        Me.NLQCMB_V.Visible = False
        Me.NLQCMB_V.Width = 119
        '
        'NPLCUN_V
        '
        Me.NPLCUN_V.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN_V.DataPropertyName = "NPLCUN"
        Me.NPLCUN_V.HeaderText = "PLaca"
        Me.NPLCUN_V.Name = "NPLCUN_V"
        Me.NPLCUN_V.ReadOnly = True
        Me.NPLCUN_V.Width = 80
        '
        'NRITEM
        '
        Me.NRITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRITEM.DataPropertyName = "NRITEM"
        Me.NRITEM.HeaderText = "Nro Item"
        Me.NRITEM.Name = "NRITEM"
        Me.NRITEM.ReadOnly = True
        Me.NRITEM.Width = 101
        '
        'NVLGRF_A
        '
        Me.NVLGRF_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NVLGRF_A.DataPropertyName = "NVLGRS"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NVLGRF_A.DefaultCellStyle = DataGridViewCellStyle10
        Me.NVLGRF_A.HeaderText = "N° Vale"
        Me.NVLGRF_A.Name = "NVLGRF_A"
        Me.NVLGRF_A.ReadOnly = True
        Me.NVLGRF_A.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NVLGRF_A.Width = 91
        '
        'FCRCMB_A
        '
        Me.FCRCMB_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FCRCMB_A.DataPropertyName = "FCRCMB"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.FCRCMB_A.DefaultCellStyle = DataGridViewCellStyle11
        Me.FCRCMB_A.HeaderText = "Fecha Vale"
        Me.FCRCMB_A.Name = "FCRCMB_A"
        Me.FCRCMB_A.ReadOnly = True
        Me.FCRCMB_A.Width = 112
        '
        'CGRFO_A
        '
        Me.CGRFO_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGRFO_A.DataPropertyName = "CGRFO"
        Me.CGRFO_A.HeaderText = "Cod. Grifo"
        Me.CGRFO_A.Name = "CGRFO_A"
        Me.CGRFO_A.ReadOnly = True
        Me.CGRFO_A.Width = 109
        '
        'TGRFO_A
        '
        Me.TGRFO_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TGRFO_A.DataPropertyName = "TGRFO"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.TGRFO_A.DefaultCellStyle = DataGridViewCellStyle12
        Me.TGRFO_A.HeaderText = "Grifo"
        Me.TGRFO_A.Name = "TGRFO_A"
        Me.TGRFO_A.ReadOnly = True
        Me.TGRFO_A.Width = 75
        '
        'COD_REF_GRIFO
        '
        Me.COD_REF_GRIFO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_REF_GRIFO.DataPropertyName = "COD_REF_GRIFO"
        Me.COD_REF_GRIFO.HeaderText = "Cod Ref Grifo"
        Me.COD_REF_GRIFO.Name = "COD_REF_GRIFO"
        Me.COD_REF_GRIFO.ReadOnly = True
        Me.COD_REF_GRIFO.Visible = False
        Me.COD_REF_GRIFO.Width = 132
        '
        'DCMPPR
        '
        Me.DCMPPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DCMPPR.DataPropertyName = "DCMPPR"
        Me.DCMPPR.HeaderText = "Razón Social"
        Me.DCMPPR.Name = "DCMPPR"
        Me.DCMPPR.ReadOnly = True
        Me.DCMPPR.Width = 127
        '
        'CTPCMB_A
        '
        Me.CTPCMB_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTPCMB_A.DataPropertyName = "CTPCMB"
        Me.CTPCMB_A.HeaderText = "Tipo Combustible"
        Me.CTPCMB_A.Name = "CTPCMB_A"
        Me.CTPCMB_A.ReadOnly = True
        Me.CTPCMB_A.Width = 160
        '
        'QGLCNM_1
        '
        Me.QGLCNM_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QGLCNM_1.DataPropertyName = "QGLNCM"
        Me.QGLCNM_1.HeaderText = "Cant. Comb (Gal)"
        Me.QGLCNM_1.Name = "QGLCNM_1"
        Me.QGLCNM_1.ReadOnly = True
        Me.QGLCNM_1.Width = 155
        '
        'TSGNMN
        '
        Me.TSGNMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TSGNMN.DataPropertyName = "TSGNMN"
        Me.TSGNMN.HeaderText = "Moneda"
        Me.TSGNMN.Name = "TSGNMN"
        Me.TSGNMN.ReadOnly = True
        Me.TSGNMN.Width = 97
        '
        'CSTGLN
        '
        Me.CSTGLN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CSTGLN.DataPropertyName = "CSTGLN"
        Me.CSTGLN.HeaderText = "Costo x Galón"
        Me.CSTGLN.Name = "CSTGLN"
        Me.CSTGLN.ReadOnly = True
        Me.CSTGLN.Width = 134
        '
        'SUB_TOTAL
        '
        Me.SUB_TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SUB_TOTAL.DataPropertyName = "SUB_TOTAL"
        Me.SUB_TOTAL.HeaderText = "Sub Total"
        Me.SUB_TOTAL.Name = "SUB_TOTAL"
        Me.SUB_TOTAL.ReadOnly = True
        Me.SUB_TOTAL.Width = 104
        '
        'TIPO_DOC
        '
        Me.TIPO_DOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_DOC.DataPropertyName = "TIPO_DOC"
        Me.TIPO_DOC.HeaderText = "Tipo Documento"
        Me.TIPO_DOC.Name = "TIPO_DOC"
        Me.TIPO_DOC.ReadOnly = True
        Me.TIPO_DOC.Width = 154
        '
        'NDCCT1_A
        '
        Me.NDCCT1_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDCCT1_A.DataPropertyName = "NDCCTS"
        Me.NDCCT1_A.HeaderText = "N° Documento"
        Me.NDCCT1_A.Name = "NDCCT1_A"
        Me.NDCCT1_A.ReadOnly = True
        Me.NDCCT1_A.Width = 141
        '
        'FDCCT1_A
        '
        Me.FDCCT1_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FDCCT1_A.DataPropertyName = "FDCCT1"
        Me.FDCCT1_A.HeaderText = "Fecha Documento"
        Me.FDCCT1_A.Name = "FDCCT1_A"
        Me.FDCCT1_A.ReadOnly = True
        Me.FDCCT1_A.Width = 162
        '
        'NPRCN1_A
        '
        Me.NPRCN1_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRCN1_A.DataPropertyName = "NPRCN1"
        Me.NPRCN1_A.HeaderText = "N° Precinto 1"
        Me.NPRCN1_A.Name = "NPRCN1_A"
        Me.NPRCN1_A.ReadOnly = True
        Me.NPRCN1_A.Width = 129
        '
        'NPRCN2_A
        '
        Me.NPRCN2_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRCN2_A.DataPropertyName = "NPRCN2"
        Me.NPRCN2_A.HeaderText = "N° Precinto 2"
        Me.NPRCN2_A.Name = "NPRCN2_A"
        Me.NPRCN2_A.ReadOnly = True
        Me.NPRCN2_A.Width = 129
        '
        'NPRCN3_A
        '
        Me.NPRCN3_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPRCN3_A.DataPropertyName = "NPRCN3"
        Me.NPRCN3_A.HeaderText = "N° Precinto 3"
        Me.NPRCN3_A.Name = "NPRCN3_A"
        Me.NPRCN3_A.ReadOnly = True
        Me.NPRCN3_A.Width = 129
        '
        'CCMPN_A
        '
        Me.CCMPN_A.DataPropertyName = "CCMPN"
        Me.CCMPN_A.HeaderText = "Cod. Compañia"
        Me.CCMPN_A.Name = "CCMPN_A"
        Me.CCMPN_A.ReadOnly = True
        Me.CCMPN_A.Visible = False
        '
        'CDVSN_A
        '
        Me.CDVSN_A.DataPropertyName = "CDVSN"
        Me.CDVSN_A.HeaderText = "Cod. Division"
        Me.CDVSN_A.Name = "CDVSN_A"
        Me.CDVSN_A.ReadOnly = True
        Me.CDVSN_A.Visible = False
        '
        'CTPOD1
        '
        Me.CTPOD1.DataPropertyName = "CTPOD1"
        Me.CTPOD1.HeaderText = "CTPOD1"
        Me.CTPOD1.Name = "CTPOD1"
        Me.CTPOD1.ReadOnly = True
        Me.CTPOD1.Visible = False
        '
        'txtVehiculo
        '
        Me.txtVehiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVehiculo.Location = New System.Drawing.Point(111, 46)
        Me.txtVehiculo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVehiculo.MaxLength = 6
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(140, 26)
        Me.txtVehiculo.TabIndex = 453
        '
        'lblVehiculo
        '
        Me.lblVehiculo.Location = New System.Drawing.Point(18, 46)
        Me.lblVehiculo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVehiculo.Name = "lblVehiculo"
        Me.lblVehiculo.Size = New System.Drawing.Size(70, 24)
        Me.lblVehiculo.TabIndex = 452
        Me.lblVehiculo.Text = "Vehículo"
        Me.lblVehiculo.Values.ExtraText = ""
        Me.lblVehiculo.Values.Image = Nothing
        Me.lblVehiculo.Values.Text = "Vehículo"
        '
        'frmCargaMasivaVale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 518)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCargaMasivaVale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Solicitud Carga Vale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpValesPendiente.ResumeLayout(False)
        CType(Me.dtgVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpValesPendiente As System.Windows.Forms.TabPage
    Friend WithEvents dtgVales As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGenLiq As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImport As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAsignar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NLQCMB_V As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN_V As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NVLGRF_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCRCMB_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGRFO_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGRFO_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_REF_GRIFO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCMPPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPCMB_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QGLCNM_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSGNMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSTGLN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUB_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_DOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCCT1_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDCCT1_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRCN1_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRCN2_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRCN3_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN_A As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPOD1 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents txtVehiculo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblVehiculo As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
