<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuadreOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuadreOS))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgIngreso = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaabriring = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsacerraring = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblpesoing = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblvaloring = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblcantidading = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgvingreso = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPALMDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMNDA1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QMRCD1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPSMR1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QVLMR1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstconsulta = New System.Data.DataSet
        Me.ingreso = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.salida = New System.Data.DataTable
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.resumendol = New System.Data.DataTable
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.resumensol = New System.Data.DataTable
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.hgSalida = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaabrirsal = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsacerrarsal = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.lblvalordesp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblpesodesp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblcantdesp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblpesoaut = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblvaloraut = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblcantaut = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgvsalida = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NAUTRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCLDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NLBRCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPALMDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QAUTCNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QAUTPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QAUTVLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTTDSCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTTDSPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTTDSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgResumen = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblsalsol = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblingsol = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblsaldol = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblingdol = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgvsoles = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CTPALMDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INGRESODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SALIDADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvdolares = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CTPALMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.INGRESODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SALIDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hgConsulta = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgIngreso.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgIngreso.Panel.SuspendLayout()
        Me.hgIngreso.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dgvingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ingreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resumendol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resumensol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSalida.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgSalida.Panel.SuspendLayout()
        Me.hgSalida.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.dgvsalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgResumen.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgResumen.Panel.SuspendLayout()
        Me.hgResumen.SuspendLayout()
        CType(Me.dgvsoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgConsulta.Panel.SuspendLayout()
        Me.hgConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgIngreso)
        Me.KryptonPanel.Controls.Add(Me.hgSalida)
        Me.KryptonPanel.Controls.Add(Me.hgResumen)
        Me.KryptonPanel.Controls.Add(Me.hgConsulta)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(929, 517)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgIngreso
        '
        Me.hgIngreso.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaabriring, Me.bsacerraring})
        Me.hgIngreso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgIngreso.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgIngreso.HeaderVisibleSecondary = False
        Me.hgIngreso.Location = New System.Drawing.Point(0, 467)
        Me.hgIngreso.Name = "hgIngreso"
        '
        'hgIngreso.Panel
        '
        Me.hgIngreso.Panel.Controls.Add(Me.KryptonPanel1)
        Me.hgIngreso.Panel.Controls.Add(Me.dgvingreso)
        Me.hgIngreso.Size = New System.Drawing.Size(929, 28)
        Me.hgIngreso.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgIngreso.TabIndex = 52
        Me.hgIngreso.Text = "Ingresos"
        Me.hgIngreso.ValuesPrimary.Description = ""
        Me.hgIngreso.ValuesPrimary.Heading = "Ingresos"
        Me.hgIngreso.ValuesPrimary.Image = Nothing
        Me.hgIngreso.ValuesSecondary.Description = ""
        Me.hgIngreso.ValuesSecondary.Heading = "Description"
        Me.hgIngreso.ValuesSecondary.Image = Nothing
        '
        'bsaabriring
        '
        Me.bsaabriring.ExtraText = ""
        Me.bsaabriring.Image = Nothing
        Me.bsaabriring.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaabriring.Text = "Abrir"
        Me.bsaabriring.ToolTipImage = Nothing
        Me.bsaabriring.UniqueName = "49109C2ABC6347EB49109C2ABC6347EB"
        '
        'bsacerraring
        '
        Me.bsacerraring.ExtraText = ""
        Me.bsacerraring.Image = Nothing
        Me.bsacerraring.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsacerraring.Text = "Cerrar"
        Me.bsacerraring.ToolTipImage = Nothing
        Me.bsacerraring.UniqueName = "56680ACD7BF4419D56680ACD7BF4419D"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.lblpesoing)
        Me.KryptonPanel1.Controls.Add(Me.lblvaloring)
        Me.KryptonPanel1.Controls.Add(Me.lblcantidading)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 163)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(927, 54)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 6
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(447, 2)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(47, 16)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Text = "Totales"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Totales"
        '
        'lblpesoing
        '
        Me.lblpesoing.Location = New System.Drawing.Point(583, 2)
        Me.lblpesoing.Name = "lblpesoing"
        Me.lblpesoing.Size = New System.Drawing.Size(16, 16)
        Me.lblpesoing.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblpesoing.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesoing.TabIndex = 7
        Me.lblpesoing.Text = "0"
        Me.lblpesoing.Values.ExtraText = ""
        Me.lblpesoing.Values.Image = Nothing
        Me.lblpesoing.Values.Text = "0"
        '
        'lblvaloring
        '
        Me.lblvaloring.Location = New System.Drawing.Point(647, 2)
        Me.lblvaloring.Name = "lblvaloring"
        Me.lblvaloring.Size = New System.Drawing.Size(16, 16)
        Me.lblvaloring.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblvaloring.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvaloring.TabIndex = 6
        Me.lblvaloring.Text = "0"
        Me.lblvaloring.Values.ExtraText = ""
        Me.lblvaloring.Values.Image = Nothing
        Me.lblvaloring.Values.Text = "0"
        '
        'lblcantidading
        '
        Me.lblcantidading.Location = New System.Drawing.Point(515, 2)
        Me.lblcantidading.Name = "lblcantidading"
        Me.lblcantidading.Size = New System.Drawing.Size(16, 16)
        Me.lblcantidading.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblcantidading.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidading.TabIndex = 5
        Me.lblcantidading.Text = "0"
        Me.lblcantidading.Values.ExtraText = ""
        Me.lblcantidading.Values.Image = Nothing
        Me.lblcantidading.Values.Text = "0"
        '
        'dgvingreso
        '
        Me.dgvingreso.AllowUserToAddRows = False
        Me.dgvingreso.AllowUserToDeleteRows = False
        Me.dgvingreso.AllowUserToResizeColumns = False
        Me.dgvingreso.AllowUserToResizeRows = False
        Me.dgvingreso.AutoGenerateColumns = False
        Me.dgvingreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvingreso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSRDataGridViewTextBoxColumn, Me.TCMPCLDataGridViewTextBoxColumn, Me.CTPALMDataGridViewTextBoxColumn2, Me.CALMCDataGridViewTextBoxColumn2, Me.CMNDA1DataGridViewTextBoxColumn, Me.QMRCD1DataGridViewTextBoxColumn, Me.QPSMR1DataGridViewTextBoxColumn, Me.QVLMR1DataGridViewTextBoxColumn})
        Me.dgvingreso.DataMember = "ingreso"
        Me.dgvingreso.DataSource = Me.dstconsulta
        Me.dgvingreso.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvingreso.Location = New System.Drawing.Point(0, 0)
        Me.dgvingreso.MultiSelect = False
        Me.dgvingreso.Name = "dgvingreso"
        Me.dgvingreso.RowHeadersWidth = 20
        Me.dgvingreso.Size = New System.Drawing.Size(927, 163)
        Me.dgvingreso.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvingreso.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvingreso.TabIndex = 0
        '
        'NORDSRDataGridViewTextBoxColumn
        '
        Me.NORDSRDataGridViewTextBoxColumn.DataPropertyName = "NORDSR"
        Me.NORDSRDataGridViewTextBoxColumn.HeaderText = "N° Orden"
        Me.NORDSRDataGridViewTextBoxColumn.Name = "NORDSRDataGridViewTextBoxColumn"
        Me.NORDSRDataGridViewTextBoxColumn.Width = 80
        '
        'TCMPCLDataGridViewTextBoxColumn
        '
        Me.TCMPCLDataGridViewTextBoxColumn.DataPropertyName = "TCMPCL"
        Me.TCMPCLDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.TCMPCLDataGridViewTextBoxColumn.Name = "TCMPCLDataGridViewTextBoxColumn"
        Me.TCMPCLDataGridViewTextBoxColumn.Width = 68
        '
        'CTPALMDataGridViewTextBoxColumn2
        '
        Me.CTPALMDataGridViewTextBoxColumn2.DataPropertyName = "CTPALM"
        Me.CTPALMDataGridViewTextBoxColumn2.HeaderText = "Tipo Almacen"
        Me.CTPALMDataGridViewTextBoxColumn2.Name = "CTPALMDataGridViewTextBoxColumn2"
        Me.CTPALMDataGridViewTextBoxColumn2.Width = 101
        '
        'CALMCDataGridViewTextBoxColumn2
        '
        Me.CALMCDataGridViewTextBoxColumn2.DataPropertyName = "CALMC"
        Me.CALMCDataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.CALMCDataGridViewTextBoxColumn2.Name = "CALMCDataGridViewTextBoxColumn2"
        Me.CALMCDataGridViewTextBoxColumn2.Width = 77
        '
        'CMNDA1DataGridViewTextBoxColumn
        '
        Me.CMNDA1DataGridViewTextBoxColumn.DataPropertyName = "CMNDA1"
        Me.CMNDA1DataGridViewTextBoxColumn.HeaderText = "Moneda"
        Me.CMNDA1DataGridViewTextBoxColumn.Name = "CMNDA1DataGridViewTextBoxColumn"
        Me.CMNDA1DataGridViewTextBoxColumn.Width = 75
        '
        'QMRCD1DataGridViewTextBoxColumn
        '
        Me.QMRCD1DataGridViewTextBoxColumn.DataPropertyName = "QMRCD1"
        Me.QMRCD1DataGridViewTextBoxColumn.HeaderText = "Cantidad "
        Me.QMRCD1DataGridViewTextBoxColumn.Name = "QMRCD1DataGridViewTextBoxColumn"
        Me.QMRCD1DataGridViewTextBoxColumn.Width = 81
        '
        'QPSMR1DataGridViewTextBoxColumn
        '
        Me.QPSMR1DataGridViewTextBoxColumn.DataPropertyName = "QPSMR1"
        Me.QPSMR1DataGridViewTextBoxColumn.HeaderText = "Peso"
        Me.QPSMR1DataGridViewTextBoxColumn.Name = "QPSMR1DataGridViewTextBoxColumn"
        Me.QPSMR1DataGridViewTextBoxColumn.Width = 60
        '
        'QVLMR1DataGridViewTextBoxColumn
        '
        Me.QVLMR1DataGridViewTextBoxColumn.DataPropertyName = "QVLMR1"
        Me.QVLMR1DataGridViewTextBoxColumn.HeaderText = "Valor"
        Me.QVLMR1DataGridViewTextBoxColumn.Name = "QVLMR1DataGridViewTextBoxColumn"
        Me.QVLMR1DataGridViewTextBoxColumn.Width = 60
        '
        'dstconsulta
        '
        Me.dstconsulta.DataSetName = "dstconsulta"
        Me.dstconsulta.Tables.AddRange(New System.Data.DataTable() {Me.ingreso, Me.salida, Me.resumendol, Me.resumensol})
        '
        'ingreso
        '
        Me.ingreso.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn26})
        Me.ingreso.TableName = "ingreso"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NORDSR"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TCMPCL"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CTPALM"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CMNDA1"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "QMRCD1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "QPSMR1"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "QVLMR1"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "CALMC"
        '
        'salida
        '
        Me.salida.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn27})
        Me.salida.TableName = "salida"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "NAUTR"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "TCMPCL"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "NLBRCA"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "CTPALM"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "QAUTCN"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "QAUTPS"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "QAUTVL"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "QTTDSC"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "QTTDSP"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "QTTDSV"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "CALMC"
        '
        'resumendol
        '
        Me.resumendol.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.resumendol.TableName = "resumendol"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "CTPALM"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "CALMC"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "INGRESO"
        Me.DataColumn20.DataType = GetType(Double)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "SALIDA"
        Me.DataColumn21.DataType = GetType(Double)
        '
        'resumensol
        '
        Me.resumensol.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25})
        Me.resumensol.TableName = "resumensol"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "CTPALM"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "CALMC"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "INGRESO"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "SALIDA"
        '
        'hgSalida
        '
        Me.hgSalida.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaabrirsal, Me.bsacerrarsal})
        Me.hgSalida.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgSalida.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgSalida.HeaderVisibleSecondary = False
        Me.hgSalida.Location = New System.Drawing.Point(0, 495)
        Me.hgSalida.Name = "hgSalida"
        '
        'hgSalida.Panel
        '
        Me.hgSalida.Panel.Controls.Add(Me.KryptonPanel2)
        Me.hgSalida.Panel.Controls.Add(Me.dgvsalida)
        Me.hgSalida.Size = New System.Drawing.Size(929, 22)
        Me.hgSalida.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgSalida.TabIndex = 51
        Me.hgSalida.Text = "Salidas"
        Me.hgSalida.ValuesPrimary.Description = ""
        Me.hgSalida.ValuesPrimary.Heading = "Salidas"
        Me.hgSalida.ValuesPrimary.Image = Nothing
        Me.hgSalida.ValuesSecondary.Description = ""
        Me.hgSalida.ValuesSecondary.Heading = "Description"
        Me.hgSalida.ValuesSecondary.Image = Nothing
        '
        'bsaabrirsal
        '
        Me.bsaabrirsal.ExtraText = ""
        Me.bsaabrirsal.Image = Nothing
        Me.bsaabrirsal.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaabrirsal.Text = "Abrir"
        Me.bsaabrirsal.ToolTipImage = Nothing
        Me.bsaabrirsal.UniqueName = "630F576774124C26630F576774124C26"
        '
        'bsacerrarsal
        '
        Me.bsacerrarsal.ExtraText = ""
        Me.bsacerrarsal.Image = Nothing
        Me.bsacerrarsal.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsacerrarsal.Text = "Cerrar"
        Me.bsacerrarsal.ToolTipImage = Nothing
        Me.bsacerrarsal.UniqueName = "7AED61BC1B4949597AED61BC1B494959"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.lblvalordesp)
        Me.KryptonPanel2.Controls.Add(Me.lblpesodesp)
        Me.KryptonPanel2.Controls.Add(Me.lblcantdesp)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel2.Controls.Add(Me.lblpesoaut)
        Me.KryptonPanel2.Controls.Add(Me.lblvaloraut)
        Me.KryptonPanel2.Controls.Add(Me.lblcantaut)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 265)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(927, 54)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 7
        '
        'lblvalordesp
        '
        Me.lblvalordesp.Location = New System.Drawing.Point(827, 3)
        Me.lblvalordesp.Name = "lblvalordesp"
        Me.lblvalordesp.Size = New System.Drawing.Size(16, 16)
        Me.lblvalordesp.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblvalordesp.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalordesp.TabIndex = 11
        Me.lblvalordesp.Text = "0"
        Me.lblvalordesp.Values.ExtraText = ""
        Me.lblvalordesp.Values.Image = Nothing
        Me.lblvalordesp.Values.Text = "0"
        '
        'lblpesodesp
        '
        Me.lblpesodesp.Location = New System.Drawing.Point(744, 2)
        Me.lblpesodesp.Name = "lblpesodesp"
        Me.lblpesodesp.Size = New System.Drawing.Size(16, 16)
        Me.lblpesodesp.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblpesodesp.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesodesp.TabIndex = 10
        Me.lblpesodesp.Text = "0"
        Me.lblpesodesp.Values.ExtraText = ""
        Me.lblpesodesp.Values.Image = Nothing
        Me.lblpesodesp.Values.Text = "0"
        '
        'lblcantdesp
        '
        Me.lblcantdesp.Location = New System.Drawing.Point(658, 2)
        Me.lblcantdesp.Name = "lblcantdesp"
        Me.lblcantdesp.Size = New System.Drawing.Size(16, 16)
        Me.lblcantdesp.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblcantdesp.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantdesp.TabIndex = 9
        Me.lblcantdesp.Text = "0"
        Me.lblcantdesp.Values.ExtraText = ""
        Me.lblcantdesp.Values.Image = Nothing
        Me.lblcantdesp.Values.Text = "0"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(336, 2)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(47, 16)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 8
        Me.KryptonLabel2.Text = "Totales"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Totales"
        '
        'lblpesoaut
        '
        Me.lblpesoaut.Location = New System.Drawing.Point(499, 3)
        Me.lblpesoaut.Name = "lblpesoaut"
        Me.lblpesoaut.Size = New System.Drawing.Size(16, 16)
        Me.lblpesoaut.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblpesoaut.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesoaut.TabIndex = 7
        Me.lblpesoaut.Text = "0"
        Me.lblpesoaut.Values.ExtraText = ""
        Me.lblpesoaut.Values.Image = Nothing
        Me.lblpesoaut.Values.Text = "0"
        '
        'lblvaloraut
        '
        Me.lblvaloraut.Location = New System.Drawing.Point(574, 2)
        Me.lblvaloraut.Name = "lblvaloraut"
        Me.lblvaloraut.Size = New System.Drawing.Size(16, 16)
        Me.lblvaloraut.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblvaloraut.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvaloraut.TabIndex = 6
        Me.lblvaloraut.Text = "0"
        Me.lblvaloraut.Values.ExtraText = ""
        Me.lblvaloraut.Values.Image = Nothing
        Me.lblvaloraut.Values.Text = "0"
        '
        'lblcantaut
        '
        Me.lblcantaut.Location = New System.Drawing.Point(414, 2)
        Me.lblcantaut.Name = "lblcantaut"
        Me.lblcantaut.Size = New System.Drawing.Size(16, 16)
        Me.lblcantaut.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblcantaut.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantaut.TabIndex = 5
        Me.lblcantaut.Text = "0"
        Me.lblcantaut.Values.ExtraText = ""
        Me.lblcantaut.Values.Image = Nothing
        Me.lblcantaut.Values.Text = "0"
        '
        'dgvsalida
        '
        Me.dgvsalida.AllowUserToAddRows = False
        Me.dgvsalida.AllowUserToDeleteRows = False
        Me.dgvsalida.AllowUserToResizeColumns = False
        Me.dgvsalida.AllowUserToResizeRows = False
        Me.dgvsalida.AutoGenerateColumns = False
        Me.dgvsalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvsalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAUTRDataGridViewTextBoxColumn, Me.TCMPCLDataGridViewTextBoxColumn1, Me.NLBRCADataGridViewTextBoxColumn, Me.CTPALMDataGridViewTextBoxColumn3, Me.CALMCDataGridViewTextBoxColumn3, Me.QAUTCNDataGridViewTextBoxColumn, Me.QAUTPSDataGridViewTextBoxColumn, Me.QAUTVLDataGridViewTextBoxColumn, Me.QTTDSCDataGridViewTextBoxColumn, Me.QTTDSPDataGridViewTextBoxColumn, Me.QTTDSVDataGridViewTextBoxColumn})
        Me.dgvsalida.DataMember = "salida"
        Me.dgvsalida.DataSource = Me.dstconsulta
        Me.dgvsalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvsalida.Location = New System.Drawing.Point(0, 0)
        Me.dgvsalida.MultiSelect = False
        Me.dgvsalida.Name = "dgvsalida"
        Me.dgvsalida.ReadOnly = True
        Me.dgvsalida.RowHeadersWidth = 20
        Me.dgvsalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvsalida.Size = New System.Drawing.Size(927, 265)
        Me.dgvsalida.StandardTab = True
        Me.dgvsalida.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvsalida.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvsalida.TabIndex = 0
        '
        'NAUTRDataGridViewTextBoxColumn
        '
        Me.NAUTRDataGridViewTextBoxColumn.DataPropertyName = "NAUTR"
        Me.NAUTRDataGridViewTextBoxColumn.HeaderText = "N° Aut"
        Me.NAUTRDataGridViewTextBoxColumn.Name = "NAUTRDataGridViewTextBoxColumn"
        Me.NAUTRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NAUTRDataGridViewTextBoxColumn.Width = 67
        '
        'TCMPCLDataGridViewTextBoxColumn1
        '
        Me.TCMPCLDataGridViewTextBoxColumn1.DataPropertyName = "TCMPCL"
        Me.TCMPCLDataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.TCMPCLDataGridViewTextBoxColumn1.Name = "TCMPCLDataGridViewTextBoxColumn1"
        Me.TCMPCLDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TCMPCLDataGridViewTextBoxColumn1.Width = 68
        '
        'NLBRCADataGridViewTextBoxColumn
        '
        Me.NLBRCADataGridViewTextBoxColumn.DataPropertyName = "NLBRCA"
        Me.NLBRCADataGridViewTextBoxColumn.HeaderText = "N° Liberación"
        Me.NLBRCADataGridViewTextBoxColumn.Name = "NLBRCADataGridViewTextBoxColumn"
        Me.NLBRCADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CTPALMDataGridViewTextBoxColumn3
        '
        Me.CTPALMDataGridViewTextBoxColumn3.DataPropertyName = "CTPALM"
        Me.CTPALMDataGridViewTextBoxColumn3.HeaderText = "Tipo Alm"
        Me.CTPALMDataGridViewTextBoxColumn3.Name = "CTPALMDataGridViewTextBoxColumn3"
        Me.CTPALMDataGridViewTextBoxColumn3.ReadOnly = True
        Me.CTPALMDataGridViewTextBoxColumn3.Width = 77
        '
        'CALMCDataGridViewTextBoxColumn3
        '
        Me.CALMCDataGridViewTextBoxColumn3.DataPropertyName = "CALMC"
        Me.CALMCDataGridViewTextBoxColumn3.HeaderText = "Cod Almacen"
        Me.CALMCDataGridViewTextBoxColumn3.Name = "CALMCDataGridViewTextBoxColumn3"
        Me.CALMCDataGridViewTextBoxColumn3.ReadOnly = True
        Me.CALMCDataGridViewTextBoxColumn3.Width = 99
        '
        'QAUTCNDataGridViewTextBoxColumn
        '
        Me.QAUTCNDataGridViewTextBoxColumn.DataPropertyName = "QAUTCN"
        Me.QAUTCNDataGridViewTextBoxColumn.HeaderText = "Cant Aut"
        Me.QAUTCNDataGridViewTextBoxColumn.Name = "QAUTCNDataGridViewTextBoxColumn"
        Me.QAUTCNDataGridViewTextBoxColumn.ReadOnly = True
        Me.QAUTCNDataGridViewTextBoxColumn.Width = 77
        '
        'QAUTPSDataGridViewTextBoxColumn
        '
        Me.QAUTPSDataGridViewTextBoxColumn.DataPropertyName = "QAUTPS"
        Me.QAUTPSDataGridViewTextBoxColumn.HeaderText = "Peso Aut"
        Me.QAUTPSDataGridViewTextBoxColumn.Name = "QAUTPSDataGridViewTextBoxColumn"
        Me.QAUTPSDataGridViewTextBoxColumn.ReadOnly = True
        Me.QAUTPSDataGridViewTextBoxColumn.Width = 79
        '
        'QAUTVLDataGridViewTextBoxColumn
        '
        Me.QAUTVLDataGridViewTextBoxColumn.DataPropertyName = "QAUTVL"
        Me.QAUTVLDataGridViewTextBoxColumn.HeaderText = "Valor Aut"
        Me.QAUTVLDataGridViewTextBoxColumn.Name = "QAUTVLDataGridViewTextBoxColumn"
        Me.QAUTVLDataGridViewTextBoxColumn.ReadOnly = True
        Me.QAUTVLDataGridViewTextBoxColumn.Width = 79
        '
        'QTTDSCDataGridViewTextBoxColumn
        '
        Me.QTTDSCDataGridViewTextBoxColumn.DataPropertyName = "QTTDSC"
        Me.QTTDSCDataGridViewTextBoxColumn.HeaderText = "Cant Desp"
        Me.QTTDSCDataGridViewTextBoxColumn.Name = "QTTDSCDataGridViewTextBoxColumn"
        Me.QTTDSCDataGridViewTextBoxColumn.ReadOnly = True
        Me.QTTDSCDataGridViewTextBoxColumn.Width = 86
        '
        'QTTDSPDataGridViewTextBoxColumn
        '
        Me.QTTDSPDataGridViewTextBoxColumn.DataPropertyName = "QTTDSP"
        Me.QTTDSPDataGridViewTextBoxColumn.HeaderText = "Peso Desp"
        Me.QTTDSPDataGridViewTextBoxColumn.Name = "QTTDSPDataGridViewTextBoxColumn"
        Me.QTTDSPDataGridViewTextBoxColumn.ReadOnly = True
        Me.QTTDSPDataGridViewTextBoxColumn.Width = 88
        '
        'QTTDSVDataGridViewTextBoxColumn
        '
        Me.QTTDSVDataGridViewTextBoxColumn.DataPropertyName = "QTTDSV"
        Me.QTTDSVDataGridViewTextBoxColumn.HeaderText = "Valor Desp"
        Me.QTTDSVDataGridViewTextBoxColumn.Name = "QTTDSVDataGridViewTextBoxColumn"
        Me.QTTDSVDataGridViewTextBoxColumn.ReadOnly = True
        Me.QTTDSVDataGridViewTextBoxColumn.Width = 88
        '
        'hgResumen
        '
        Me.hgResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgResumen.Location = New System.Drawing.Point(0, 106)
        Me.hgResumen.Name = "hgResumen"
        '
        'hgResumen.Panel
        '
        Me.hgResumen.Panel.Controls.Add(Me.lblsalsol)
        Me.hgResumen.Panel.Controls.Add(Me.lblingsol)
        Me.hgResumen.Panel.Controls.Add(Me.lblsaldol)
        Me.hgResumen.Panel.Controls.Add(Me.lblingdol)
        Me.hgResumen.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgResumen.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgResumen.Panel.Controls.Add(Me.dgvsoles)
        Me.hgResumen.Panel.Controls.Add(Me.dgvdolares)
        Me.hgResumen.Size = New System.Drawing.Size(929, 411)
        Me.hgResumen.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgResumen.StateCommon.HeaderSecondary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgResumen.TabIndex = 1
        Me.hgResumen.Text = "Resumen"
        Me.hgResumen.ValuesPrimary.Description = ""
        Me.hgResumen.ValuesPrimary.Heading = "Resumen"
        Me.hgResumen.ValuesPrimary.Image = Nothing
        Me.hgResumen.ValuesSecondary.Description = ""
        Me.hgResumen.ValuesSecondary.Heading = ""
        Me.hgResumen.ValuesSecondary.Image = Nothing
        '
        'lblsalsol
        '
        Me.lblsalsol.Location = New System.Drawing.Point(827, 242)
        Me.lblsalsol.Name = "lblsalsol"
        Me.lblsalsol.Size = New System.Drawing.Size(16, 16)
        Me.lblsalsol.TabIndex = 40
        Me.lblsalsol.Text = "0"
        Me.lblsalsol.Values.ExtraText = ""
        Me.lblsalsol.Values.Image = Nothing
        Me.lblsalsol.Values.Text = "0"
        '
        'lblingsol
        '
        Me.lblingsol.Location = New System.Drawing.Point(720, 242)
        Me.lblingsol.Name = "lblingsol"
        Me.lblingsol.Size = New System.Drawing.Size(16, 16)
        Me.lblingsol.TabIndex = 39
        Me.lblingsol.Text = "0"
        Me.lblingsol.Values.ExtraText = ""
        Me.lblingsol.Values.Image = Nothing
        Me.lblingsol.Values.Text = "0"
        '
        'lblsaldol
        '
        Me.lblsaldol.Location = New System.Drawing.Point(315, 242)
        Me.lblsaldol.Name = "lblsaldol"
        Me.lblsaldol.Size = New System.Drawing.Size(16, 16)
        Me.lblsaldol.TabIndex = 38
        Me.lblsaldol.Text = "0"
        Me.lblsaldol.Values.ExtraText = ""
        Me.lblsaldol.Values.Image = Nothing
        Me.lblsaldol.Values.Text = "0"
        '
        'lblingdol
        '
        Me.lblingdol.Location = New System.Drawing.Point(226, 242)
        Me.lblingdol.Name = "lblingdol"
        Me.lblingdol.Size = New System.Drawing.Size(16, 16)
        Me.lblingdol.TabIndex = 37
        Me.lblingdol.Text = "0"
        Me.lblingdol.Values.ExtraText = ""
        Me.lblingdol.Values.Image = Nothing
        Me.lblingdol.Values.Text = "0"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(687, 28)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(39, 16)
        Me.KryptonLabel4.TabIndex = 36
        Me.KryptonLabel4.Text = "Soles"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Soles"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(146, 28)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Dolares"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Dolares"
        '
        'dgvsoles
        '
        Me.dgvsoles.AllowUserToAddRows = False
        Me.dgvsoles.AllowUserToDeleteRows = False
        Me.dgvsoles.AllowUserToResizeColumns = False
        Me.dgvsoles.AllowUserToResizeRows = False
        Me.dgvsoles.AutoGenerateColumns = False
        Me.dgvsoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvsoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTPALMDataGridViewTextBoxColumn1, Me.CALMCDataGridViewTextBoxColumn1, Me.INGRESODataGridViewTextBoxColumn1, Me.SALIDADataGridViewTextBoxColumn1})
        Me.dgvsoles.DataMember = "resumensol"
        Me.dgvsoles.DataSource = Me.dstconsulta
        Me.dgvsoles.Location = New System.Drawing.Point(533, 59)
        Me.dgvsoles.Name = "dgvsoles"
        Me.dgvsoles.RowHeadersWidth = 20
        Me.dgvsoles.Size = New System.Drawing.Size(368, 133)
        Me.dgvsoles.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvsoles.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvsoles.TabIndex = 1
        '
        'CTPALMDataGridViewTextBoxColumn1
        '
        Me.CTPALMDataGridViewTextBoxColumn1.DataPropertyName = "CTPALM"
        Me.CTPALMDataGridViewTextBoxColumn1.HeaderText = "Tipo Almacen"
        Me.CTPALMDataGridViewTextBoxColumn1.Name = "CTPALMDataGridViewTextBoxColumn1"
        Me.CTPALMDataGridViewTextBoxColumn1.Width = 101
        '
        'CALMCDataGridViewTextBoxColumn1
        '
        Me.CALMCDataGridViewTextBoxColumn1.DataPropertyName = "CALMC"
        Me.CALMCDataGridViewTextBoxColumn1.HeaderText = "Cod Almacen"
        Me.CALMCDataGridViewTextBoxColumn1.Name = "CALMCDataGridViewTextBoxColumn1"
        Me.CALMCDataGridViewTextBoxColumn1.Width = 99
        '
        'INGRESODataGridViewTextBoxColumn1
        '
        Me.INGRESODataGridViewTextBoxColumn1.DataPropertyName = "INGRESO"
        Me.INGRESODataGridViewTextBoxColumn1.HeaderText = "Ingreso"
        Me.INGRESODataGridViewTextBoxColumn1.Name = "INGRESODataGridViewTextBoxColumn1"
        Me.INGRESODataGridViewTextBoxColumn1.Width = 71
        '
        'SALIDADataGridViewTextBoxColumn1
        '
        Me.SALIDADataGridViewTextBoxColumn1.DataPropertyName = "SALIDA"
        Me.SALIDADataGridViewTextBoxColumn1.HeaderText = "Salida"
        Me.SALIDADataGridViewTextBoxColumn1.Name = "SALIDADataGridViewTextBoxColumn1"
        Me.SALIDADataGridViewTextBoxColumn1.Width = 65
        '
        'dgvdolares
        '
        Me.dgvdolares.AllowUserToAddRows = False
        Me.dgvdolares.AllowUserToDeleteRows = False
        Me.dgvdolares.AllowUserToResizeColumns = False
        Me.dgvdolares.AllowUserToResizeRows = False
        Me.dgvdolares.AutoGenerateColumns = False
        Me.dgvdolares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvdolares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdolares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTPALMDataGridViewTextBoxColumn, Me.CALMCDataGridViewTextBoxColumn, Me.INGRESODataGridViewTextBoxColumn, Me.SALIDADataGridViewTextBoxColumn})
        Me.dgvdolares.DataMember = "resumendol"
        Me.dgvdolares.DataSource = Me.dstconsulta
        Me.dgvdolares.Location = New System.Drawing.Point(11, 59)
        Me.dgvdolares.Name = "dgvdolares"
        Me.dgvdolares.RowHeadersWidth = 20
        Me.dgvdolares.Size = New System.Drawing.Size(368, 139)
        Me.dgvdolares.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvdolares.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvdolares.TabIndex = 0
        '
        'CTPALMDataGridViewTextBoxColumn
        '
        Me.CTPALMDataGridViewTextBoxColumn.DataPropertyName = "CTPALM"
        Me.CTPALMDataGridViewTextBoxColumn.HeaderText = "Tipo Almacen"
        Me.CTPALMDataGridViewTextBoxColumn.Name = "CTPALMDataGridViewTextBoxColumn"
        Me.CTPALMDataGridViewTextBoxColumn.Width = 101
        '
        'CALMCDataGridViewTextBoxColumn
        '
        Me.CALMCDataGridViewTextBoxColumn.DataPropertyName = "CALMC"
        Me.CALMCDataGridViewTextBoxColumn.HeaderText = "Cod Almacen"
        Me.CALMCDataGridViewTextBoxColumn.Name = "CALMCDataGridViewTextBoxColumn"
        Me.CALMCDataGridViewTextBoxColumn.Width = 99
        '
        'INGRESODataGridViewTextBoxColumn
        '
        Me.INGRESODataGridViewTextBoxColumn.DataPropertyName = "INGRESO"
        Me.INGRESODataGridViewTextBoxColumn.HeaderText = "Ingreso"
        Me.INGRESODataGridViewTextBoxColumn.Name = "INGRESODataGridViewTextBoxColumn"
        Me.INGRESODataGridViewTextBoxColumn.Width = 71
        '
        'SALIDADataGridViewTextBoxColumn
        '
        Me.SALIDADataGridViewTextBoxColumn.DataPropertyName = "SALIDA"
        Me.SALIDADataGridViewTextBoxColumn.HeaderText = "Salida"
        Me.SALIDADataGridViewTextBoxColumn.Name = "SALIDADataGridViewTextBoxColumn"
        Me.SALIDADataGridViewTextBoxColumn.Width = 65
        '
        'hgConsulta
        '
        Me.hgConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgConsulta.Location = New System.Drawing.Point(0, 0)
        Me.hgConsulta.Name = "hgConsulta"
        '
        'hgConsulta.Panel
        '
        Me.hgConsulta.Panel.Controls.Add(Me.dtpfecha)
        Me.hgConsulta.Panel.Controls.Add(Me.KryptonLabel8)
        Me.hgConsulta.Panel.Controls.Add(Me.btnActualizar)
        Me.hgConsulta.Size = New System.Drawing.Size(929, 106)
        Me.hgConsulta.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgConsulta.TabIndex = 0
        Me.hgConsulta.Text = "Consulta"
        Me.hgConsulta.ValuesPrimary.Description = ""
        Me.hgConsulta.ValuesPrimary.Heading = "Consulta"
        Me.hgConsulta.ValuesPrimary.Image = Nothing
        Me.hgConsulta.ValuesSecondary.Description = ""
        Me.hgConsulta.ValuesSecondary.Heading = ""
        Me.hgConsulta.ValuesSecondary.Image = Nothing
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(62, 49)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(89, 20)
        Me.dtpfecha.TabIndex = 35
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(11, 53)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(45, 16)
        Me.KryptonLabel8.TabIndex = 34
        Me.KryptonLabel8.Text = "Fecha:"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Fecha:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(813, 17)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(103, 52)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 33
        Me.btnActualizar.Text = "&Procesar Consulta"
        Me.btnActualizar.Values.ExtraText = ""
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar Consulta"
        '
        'frmCuadreOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 517)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCuadreOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Orden"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgIngreso.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgIngreso.Panel.ResumeLayout(False)
        CType(Me.hgIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgIngreso.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dgvingreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ingreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resumendol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resumensol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgSalida.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSalida.Panel.ResumeLayout(False)
        CType(Me.hgSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSalida.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.dgvsalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgResumen.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgResumen.Panel.ResumeLayout(False)
        Me.hgResumen.Panel.PerformLayout()
        CType(Me.hgResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgResumen.ResumeLayout(False)
        CType(Me.dgvsoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.Panel.ResumeLayout(False)
        Me.hgConsulta.Panel.PerformLayout()
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.ResumeLayout(False)
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
    Friend WithEvents hgConsulta As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgResumen As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgSalida As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgIngreso As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvsoles As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgvdolares As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaabriring As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsacerraring As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaabrirsal As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsacerrarsal As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dgvingreso As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgvsalida As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dstconsulta As System.Data.DataSet
    Friend WithEvents ingreso As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents salida As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents resumendol As System.Data.DataTable
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents resumensol As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents NORDSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALMDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QMRCD1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPSMR1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QVLMR1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblpesoing As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblvaloring As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblcantidading As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblpesodesp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblcantdesp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblpesoaut As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblvaloraut As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblcantaut As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblvalordesp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents NAUTRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCLDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NLBRCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALMDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAUTCNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAUTPSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QAUTVLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTTDSCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTTDSPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTTDSVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALMDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INGRESODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALIDADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INGRESODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALIDADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblsalsol As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblingsol As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblsaldol As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblingdol As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
