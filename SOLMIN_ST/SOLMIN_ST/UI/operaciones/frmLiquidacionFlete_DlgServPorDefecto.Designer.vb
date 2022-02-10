<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmliquidacionFlete_DlgServPorDefecto
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmliquidacionFlete_DlgServPorDefecto))
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dgServiciosPorDefecto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.M_CHKBOX = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.M_NCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_FCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_FVGCTZ = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_CMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_TCMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_QMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_CUNDMD = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_CSRCTZ = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_CMNTRN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_ITRSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_SSRVFE = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_TRFSRG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.M_SFCTTR = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.dstServicios = New System.Data.DataSet
    Me.dtServicios = New System.Data.DataTable
    Me.CHKBOX = New System.Data.DataColumn
    Me.NCTZCN = New System.Data.DataColumn
    Me.FCTZCN = New System.Data.DataColumn
    Me.FVGCTZ = New System.Data.DataColumn
    Me.CUNDMD = New System.Data.DataColumn
    Me.CMRCDR = New System.Data.DataColumn
    Me.TCMRCD = New System.Data.DataColumn
    Me.QMRCDR = New System.Data.DataColumn
    Me.CSRCTZ = New System.Data.DataColumn
    Me.TCMTRF = New System.Data.DataColumn
    Me.CMNTRN = New System.Data.DataColumn
    Me.ITRSRT = New System.Data.DataColumn
    Me.SSRVFE = New System.Data.DataColumn
    Me.TRFSRG = New System.Data.DataColumn
    Me.SFCTTR = New System.Data.DataColumn
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnAgregarServLiqu = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnModificarServLiqu = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminarServLiqu = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
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
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dgServiciosPorDefecto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dstServicios, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dtServicios, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dgServiciosPorDefecto)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.btnCancelar)
    Me.KryptonPanel.Controls.Add(Me.btnAceptar)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(918, 306)
    Me.KryptonPanel.TabIndex = 0
    '
    'dgServiciosPorDefecto
    '
    Me.dgServiciosPorDefecto.AllowUserToAddRows = False
    Me.dgServiciosPorDefecto.AllowUserToDeleteRows = False
    Me.dgServiciosPorDefecto.AllowUserToOrderColumns = True
    Me.dgServiciosPorDefecto.AllowUserToResizeColumns = False
    Me.dgServiciosPorDefecto.AllowUserToResizeRows = False
    Me.dgServiciosPorDefecto.AutoGenerateColumns = False
    Me.dgServiciosPorDefecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgServiciosPorDefecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dgServiciosPorDefecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHKBOX, Me.M_NCTZCN, Me.M_FCTZCN, Me.M_FVGCTZ, Me.M_CMRCDR, Me.M_TCMRCD, Me.M_QMRCDR, Me.M_CUNDMD, Me.M_CSRCTZ, Me.M_TCMTRF, Me.M_CMNTRN, Me.M_ITRSRT, Me.M_SSRVFE, Me.M_TRFSRG, Me.M_SFCTTR})
    Me.dgServiciosPorDefecto.DataMember = "dtServicios"
    Me.dgServiciosPorDefecto.DataSource = Me.dstServicios
    Me.dgServiciosPorDefecto.Dock = System.Windows.Forms.DockStyle.Top
    Me.dgServiciosPorDefecto.Location = New System.Drawing.Point(0, 25)
    Me.dgServiciosPorDefecto.MultiSelect = False
    Me.dgServiciosPorDefecto.Name = "dgServiciosPorDefecto"
    Me.dgServiciosPorDefecto.ReadOnly = True
    Me.dgServiciosPorDefecto.RowHeadersWidth = 20
    Me.dgServiciosPorDefecto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgServiciosPorDefecto.Size = New System.Drawing.Size(918, 223)
    Me.dgServiciosPorDefecto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dgServiciosPorDefecto.TabIndex = 27
    '
    'M_CHKBOX
    '
    Me.M_CHKBOX.DataPropertyName = "CHKBOX"
    Me.M_CHKBOX.FalseValue = "N"
    Me.M_CHKBOX.HeaderText = "Selec."
    Me.M_CHKBOX.IndeterminateValue = "N"
    Me.M_CHKBOX.Name = "M_CHKBOX"
    Me.M_CHKBOX.ReadOnly = True
    Me.M_CHKBOX.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.M_CHKBOX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.M_CHKBOX.TrueValue = "S"
    Me.M_CHKBOX.Width = 65
    '
    'M_NCTZCN
    '
    Me.M_NCTZCN.DataPropertyName = "NCTZCN"
    Me.M_NCTZCN.HeaderText = "Cotización"
    Me.M_NCTZCN.Name = "M_NCTZCN"
    Me.M_NCTZCN.ReadOnly = True
    Me.M_NCTZCN.Visible = False
    Me.M_NCTZCN.Width = 85
    '
    'M_FCTZCN
    '
    Me.M_FCTZCN.DataPropertyName = "FCTZCN"
    DataGridViewCellStyle1.Format = "d"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.M_FCTZCN.DefaultCellStyle = DataGridViewCellStyle1
    Me.M_FCTZCN.HeaderText = "Fecha Cotiz."
    Me.M_FCTZCN.Name = "M_FCTZCN"
    Me.M_FCTZCN.ReadOnly = True
    Me.M_FCTZCN.Visible = False
    Me.M_FCTZCN.Width = 95
    '
    'M_FVGCTZ
    '
    Me.M_FVGCTZ.DataPropertyName = "FVGCTZ"
    DataGridViewCellStyle2.Format = "d"
    Me.M_FVGCTZ.DefaultCellStyle = DataGridViewCellStyle2
    Me.M_FVGCTZ.HeaderText = "Fecha Vigencia"
    Me.M_FVGCTZ.Name = "M_FVGCTZ"
    Me.M_FVGCTZ.ReadOnly = True
    Me.M_FVGCTZ.Visible = False
    Me.M_FVGCTZ.Width = 110
    '
    'M_CMRCDR
    '
    Me.M_CMRCDR.DataPropertyName = "CMRCDR"
    Me.M_CMRCDR.HeaderText = "Mercadería"
    Me.M_CMRCDR.Name = "M_CMRCDR"
    Me.M_CMRCDR.ReadOnly = True
    Me.M_CMRCDR.Visible = False
    Me.M_CMRCDR.Width = 91
    '
    'M_TCMRCD
    '
    Me.M_TCMRCD.DataPropertyName = "TCMRCD"
    Me.M_TCMRCD.HeaderText = "Descripción Mercadería"
    Me.M_TCMRCD.Name = "M_TCMRCD"
    Me.M_TCMRCD.ReadOnly = True
    Me.M_TCMRCD.Visible = False
    Me.M_TCMRCD.Width = 150
    '
    'M_QMRCDR
    '
    Me.M_QMRCDR.DataPropertyName = "QMRCDR"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "N4"
    Me.M_QMRCDR.DefaultCellStyle = DataGridViewCellStyle3
    Me.M_QMRCDR.HeaderText = "Cantidad"
    Me.M_QMRCDR.Name = "M_QMRCDR"
    Me.M_QMRCDR.ReadOnly = True
    Me.M_QMRCDR.Width = 83
    '
    'M_CUNDMD
    '
    Me.M_CUNDMD.DataPropertyName = "CUNDMD"
    Me.M_CUNDMD.HeaderText = "Unidad"
    Me.M_CUNDMD.Name = "M_CUNDMD"
    Me.M_CUNDMD.ReadOnly = True
    Me.M_CUNDMD.Width = 74
    '
    'M_CSRCTZ
    '
    Me.M_CSRCTZ.DataPropertyName = "CSRCTZ"
    Me.M_CSRCTZ.HeaderText = "Servicio"
    Me.M_CSRCTZ.Name = "M_CSRCTZ"
    Me.M_CSRCTZ.ReadOnly = True
    Me.M_CSRCTZ.Width = 75
    '
    'M_TCMTRF
    '
    Me.M_TCMTRF.DataPropertyName = "TCMTRF"
    Me.M_TCMTRF.HeaderText = "Descripción Servicio"
    Me.M_TCMTRF.Name = "M_TCMTRF"
    Me.M_TCMTRF.ReadOnly = True
    Me.M_TCMTRF.Width = 138
    '
    'M_CMNTRN
    '
    Me.M_CMNTRN.DataPropertyName = "CMNTRN"
    Me.M_CMNTRN.HeaderText = "Moneda"
    Me.M_CMNTRN.Name = "M_CMNTRN"
    Me.M_CMNTRN.ReadOnly = True
    Me.M_CMNTRN.Width = 79
    '
    'M_ITRSRT
    '
    Me.M_ITRSRT.DataPropertyName = "ITRSRT"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle4.Format = "N4"
    Me.M_ITRSRT.DefaultCellStyle = DataGridViewCellStyle4
    Me.M_ITRSRT.HeaderText = "Importe"
    Me.M_ITRSRT.Name = "M_ITRSRT"
    Me.M_ITRSRT.ReadOnly = True
    Me.M_ITRSRT.Width = 76
    '
    'M_SSRVFE
    '
    Me.M_SSRVFE.DataPropertyName = "SSRVFE"
    Me.M_SSRVFE.HeaderText = "Status"
    Me.M_SSRVFE.Name = "M_SSRVFE"
    Me.M_SSRVFE.ReadOnly = True
    Me.M_SSRVFE.Visible = False
    Me.M_SSRVFE.Width = 66
    '
    'M_TRFSRG
    '
    Me.M_TRFSRG.DataPropertyName = "TRFSRG"
    Me.M_TRFSRG.HeaderText = "Referencia"
    Me.M_TRFSRG.Name = "M_TRFSRG"
    Me.M_TRFSRG.ReadOnly = True
    Me.M_TRFSRG.Width = 90
    '
    'M_SFCTTR
    '
    Me.M_SFCTTR.DataPropertyName = "SFCTTR"
    Me.M_SFCTTR.FalseValue = "N"
    Me.M_SFCTTR.HeaderText = "St. Fact."
    Me.M_SFCTTR.IndeterminateValue = "N"
    Me.M_SFCTTR.Name = "M_SFCTTR"
    Me.M_SFCTTR.ReadOnly = True
    Me.M_SFCTTR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.M_SFCTTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.M_SFCTTR.TrueValue = "S"
    Me.M_SFCTTR.Width = 76
    '
    'dstServicios
    '
    Me.dstServicios.DataSetName = "dstServicios"
    Me.dstServicios.Tables.AddRange(New System.Data.DataTable() {Me.dtServicios})
    '
    'dtServicios
    '
    Me.dtServicios.Columns.AddRange(New System.Data.DataColumn() {Me.CHKBOX, Me.NCTZCN, Me.FCTZCN, Me.FVGCTZ, Me.CUNDMD, Me.CMRCDR, Me.TCMRCD, Me.QMRCDR, Me.CSRCTZ, Me.TCMTRF, Me.CMNTRN, Me.ITRSRT, Me.SSRVFE, Me.TRFSRG, Me.SFCTTR})
    Me.dtServicios.TableName = "dtServicios"
    '
    'CHKBOX
    '
    Me.CHKBOX.ColumnName = "CHKBOX"
    Me.CHKBOX.DefaultValue = ""
    '
    'NCTZCN
    '
    Me.NCTZCN.ColumnName = "NCTZCN"
    Me.NCTZCN.DataType = GetType(Long)
    Me.NCTZCN.DefaultValue = CType(0, Long)
    '
    'FCTZCN
    '
    Me.FCTZCN.ColumnName = "FCTZCN"
    Me.FCTZCN.DataType = GetType(Date)
    '
    'FVGCTZ
    '
    Me.FVGCTZ.ColumnName = "FVGCTZ"
    Me.FVGCTZ.DataType = GetType(Date)
    '
    'CUNDMD
    '
    Me.CUNDMD.ColumnName = "CUNDMD"
    Me.CUNDMD.DefaultValue = ""
    '
    'CMRCDR
    '
    Me.CMRCDR.ColumnName = "CMRCDR"
    Me.CMRCDR.DefaultValue = ""
    '
    'TCMRCD
    '
    Me.TCMRCD.ColumnName = "TCMRCD"
    Me.TCMRCD.DefaultValue = ""
    '
    'QMRCDR
    '
    Me.QMRCDR.ColumnName = "QMRCDR"
    Me.QMRCDR.DataType = GetType(Decimal)
    Me.QMRCDR.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
    '
    'CSRCTZ
    '
    Me.CSRCTZ.ColumnName = "CSRCTZ"
    Me.CSRCTZ.DataType = GetType(Integer)
    Me.CSRCTZ.DefaultValue = 0
    '
    'TCMTRF
    '
    Me.TCMTRF.ColumnName = "TCMTRF"
    Me.TCMTRF.DefaultValue = ""
    '
    'CMNTRN
    '
    Me.CMNTRN.ColumnName = "CMNTRN"
    Me.CMNTRN.DataType = GetType(Integer)
    Me.CMNTRN.DefaultValue = 0
    '
    'ITRSRT
    '
    Me.ITRSRT.ColumnName = "ITRSRT"
    Me.ITRSRT.DataType = GetType(Decimal)
    Me.ITRSRT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
    '
    'SSRVFE
    '
    Me.SSRVFE.ColumnName = "SSRVFE"
    Me.SSRVFE.DefaultValue = ""
    '
    'TRFSRG
    '
    Me.TRFSRG.ColumnName = "TRFSRG"
    Me.TRFSRG.DefaultValue = ""
    '
    'SFCTTR
    '
    Me.SFCTTR.ColumnName = "SFCTTR"
    Me.SFCTTR.DefaultValue = ""
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarServLiqu, Me.ToolStripSeparator1, Me.btnModificarServLiqu, Me.ToolStripSeparator2, Me.btnEliminarServLiqu, Me.ToolStripSeparator3})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(918, 25)
    Me.ToolStrip1.TabIndex = 31
    Me.ToolStrip1.TabStop = True
    '
    'btnAgregarServLiqu
    '
    Me.btnAgregarServLiqu.Image = CType(resources.GetObject("btnAgregarServLiqu.Image"), System.Drawing.Image)
    Me.btnAgregarServLiqu.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAgregarServLiqu.Name = "btnAgregarServLiqu"
    Me.btnAgregarServLiqu.Size = New System.Drawing.Size(60, 22)
    Me.btnAgregarServLiqu.Text = "Nuevo"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnModificarServLiqu
    '
    Me.btnModificarServLiqu.Image = CType(resources.GetObject("btnModificarServLiqu.Image"), System.Drawing.Image)
    Me.btnModificarServLiqu.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnModificarServLiqu.Name = "btnModificarServLiqu"
    Me.btnModificarServLiqu.Size = New System.Drawing.Size(76, 22)
    Me.btnModificarServLiqu.Text = "Modificar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnEliminarServLiqu
    '
    Me.btnEliminarServLiqu.Image = CType(resources.GetObject("btnEliminarServLiqu.Image"), System.Drawing.Image)
    Me.btnEliminarServLiqu.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminarServLiqu.Name = "btnEliminarServLiqu"
    Me.btnEliminarServLiqu.Size = New System.Drawing.Size(68, 22)
    Me.btnEliminarServLiqu.Text = "Eliminar"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.Location = New System.Drawing.Point(816, 267)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
    Me.btnCancelar.TabIndex = 29
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.Values.ExtraText = ""
    Me.btnCancelar.Values.Image = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnCancelar.Values.Text = "&Cancelar"
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.Location = New System.Drawing.Point(720, 267)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
    Me.btnAceptar.TabIndex = 28
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.Values.ExtraText = ""
    Me.btnAceptar.Values.Image = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnAceptar.Values.Text = "&Aceptar"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NCTZCN"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Cotización"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Width = 85
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "FCTZCN"
    DataGridViewCellStyle5.Format = "d"
    DataGridViewCellStyle5.NullValue = Nothing
    Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
    Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Cotiz."
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Visible = False
    Me.DataGridViewTextBoxColumn2.Width = 95
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "FVGCTZ"
    DataGridViewCellStyle6.Format = "d"
    Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
    Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Vigencia"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    Me.DataGridViewTextBoxColumn3.Visible = False
    Me.DataGridViewTextBoxColumn3.Width = 110
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "CUNDMD"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Unidad"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    Me.DataGridViewTextBoxColumn4.Width = 70
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "CMRCDR"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Mercadería"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    Me.DataGridViewTextBoxColumn5.Width = 91
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCMRCD"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle7.Format = "N4"
    Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
    Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción Mercadería"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    Me.DataGridViewTextBoxColumn6.Width = 150
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "QMRCDR"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle8.Format = "N4"
    Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
    Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    Me.DataGridViewTextBoxColumn7.Width = 78
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "CSRCTZ"
    Me.DataGridViewTextBoxColumn8.HeaderText = "Servicio"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    Me.DataGridViewTextBoxColumn8.Width = 74
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "TCMTRF"
    Me.DataGridViewTextBoxColumn9.HeaderText = "Descripción Servicio"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    Me.DataGridViewTextBoxColumn9.Width = 133
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "CMNTRN"
    Me.DataGridViewTextBoxColumn10.HeaderText = "Moneda"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    Me.DataGridViewTextBoxColumn10.Width = 75
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "ITRSRT"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle9.Format = "N4"
    Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle9
    Me.DataGridViewTextBoxColumn11.HeaderText = "Importe"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
    Me.DataGridViewTextBoxColumn11.Width = 71
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.DataPropertyName = "SSRVFE"
    Me.DataGridViewTextBoxColumn12.HeaderText = "Status"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.ReadOnly = True
    Me.DataGridViewTextBoxColumn12.Visible = False
    Me.DataGridViewTextBoxColumn12.Width = 66
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.DataPropertyName = "TRFSRG"
    Me.DataGridViewTextBoxColumn13.HeaderText = "Referencia"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.ReadOnly = True
    Me.DataGridViewTextBoxColumn13.Width = 88
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.DataPropertyName = "SFCTTR"
    Me.DataGridViewTextBoxColumn14.HeaderText = "St. Fact."
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.Width = 76
    '
    'frmliquidacionFlete_DlgServPorDefecto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(918, 306)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmliquidacionFlete_DlgServPorDefecto"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Servicios Fijos por Cliente"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dgServiciosPorDefecto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dstServicios, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dtServicios, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
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
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents dstServicios As System.Data.DataSet
    Friend WithEvents dtServicios As System.Data.DataTable
    Friend WithEvents NCTZCN As System.Data.DataColumn
    Friend WithEvents CHKBOX As System.Data.DataColumn
    Friend WithEvents FCTZCN As System.Data.DataColumn
    Friend WithEvents FVGCTZ As System.Data.DataColumn
    Friend WithEvents CUNDMD As System.Data.DataColumn
    Friend WithEvents CMRCDR As System.Data.DataColumn
    Friend WithEvents TCMRCD As System.Data.DataColumn
    Friend WithEvents QMRCDR As System.Data.DataColumn
    Friend WithEvents CSRCTZ As System.Data.DataColumn
    Friend WithEvents TCMTRF As System.Data.DataColumn
    Friend WithEvents CMNTRN As System.Data.DataColumn
    Friend WithEvents ITRSRT As System.Data.DataColumn
    Friend WithEvents SSRVFE As System.Data.DataColumn
    Friend WithEvents TRFSRG As System.Data.DataColumn
    Friend WithEvents SFCTTR As System.Data.DataColumn
    Friend WithEvents dgServiciosPorDefecto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAgregarServLiqu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificarServLiqu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminarServLiqu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
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
    Friend WithEvents M_CHKBOX As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_NCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FVGCTZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNDMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CSRCTZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMNTRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_ITRSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SSRVFE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TRFSRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SFCTTR As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
