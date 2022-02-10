<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRePacking
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRePacking))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.hgBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgItemsBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.dstAlmacen = New System.Data.DataSet()
        Me.dtBultoItemsSaldo = New System.Data.DataTable()
        Me.MNORCML = New System.Data.DataColumn()
        Me.MNRITOC = New System.Data.DataColumn()
        Me.MCIDPAQ = New System.Data.DataColumn()
        Me.MTDITES = New System.Data.DataColumn()
        Me.MQBLTSR = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dtgPaquetesDeBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.txtCantidadAreaOcupadaNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadAreaOcupadaNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadRecibidaNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCodigoRecepcionNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadRecibidaNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUnidadBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblVolumenBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaRecepcionNuevo = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblUnidadBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUnidadVolumenNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaRecepcionNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPesoBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadVolumenNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTipoBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUbicacionReferencialNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtVolumenBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTipoBultoNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUbicacionReferencialNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDescripcionWaybillNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCodigoRecepcionNuevo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescripcionWaybillNuevo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.hgBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtUbicacionReferencialOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblUbicacionReferencialOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescripcionWaybillOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDescripcionWaybillOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPesoBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCodigoRecepcionOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCodigoRecepcionOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaRecepcionOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUnidadBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaRecepcionOrigen = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.txtUnidadBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTipoBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblVolumenBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtVolumenBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtTipoBultoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadRecibidaOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUnidadVolumenOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadVolumenOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCantidadRecibidaOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadAreaOcupadaOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadAreaOcupadaOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnAgregar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.R_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.R_QBLTRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TDAITM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBITEM = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NRSITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQCTPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTLRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTANC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTALT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQVOLMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQPSOMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIM_REPACKING = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNCRRIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgBultoNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBultoNuevo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgBultoNuevo.Panel.SuspendLayout()
        Me.hgBultoNuevo.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgItemsBultoNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBultoItemsSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgPaquetesDeBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBultoOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBultoOrigen.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgBultoOrigen.Panel.SuspendLayout()
        Me.hgBultoOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgBultoNuevo)
        Me.KryptonPanel.Controls.Add(Me.hgBultoOrigen)
        Me.KryptonPanel.Controls.Add(Me.btnAgregar)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1123, 607)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgBultoNuevo
        '
        Me.hgBultoNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgBultoNuevo.HeaderVisibleSecondary = False
        Me.hgBultoNuevo.Location = New System.Drawing.Point(0, 133)
        Me.hgBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.hgBultoNuevo.Name = "hgBultoNuevo"
        '
        'hgBultoNuevo.Panel
        '
        Me.hgBultoNuevo.Panel.Controls.Add(Me.TabControl1)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtCantidadAreaOcupadaNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblCantidadAreaOcupadaNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtCantidadRecibidaNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtCodigoRecepcionNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblCantidadRecibidaNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtPesoBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtUnidadBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblVolumenBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtFechaRecepcionNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblUnidadBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblUnidadVolumenNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblFechaRecepcionNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblPesoBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtUnidadVolumenNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtTipoBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtUbicacionReferencialNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtVolumenBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblTipoBultoNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblUbicacionReferencialNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblDescripcionWaybillNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.lblCodigoRecepcionNuevo)
        Me.hgBultoNuevo.Panel.Controls.Add(Me.txtDescripcionWaybillNuevo)
        Me.hgBultoNuevo.Size = New System.Drawing.Size(1123, 375)
        Me.hgBultoNuevo.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBultoNuevo.TabIndex = 0
        Me.hgBultoNuevo.Text = "Bulto Nuevo"
        Me.hgBultoNuevo.ValuesPrimary.Description = ""
        Me.hgBultoNuevo.ValuesPrimary.Heading = "Bulto Nuevo"
        Me.hgBultoNuevo.ValuesPrimary.Image = Nothing
        Me.hgBultoNuevo.ValuesSecondary.Description = ""
        Me.hgBultoNuevo.ValuesSecondary.Heading = "Description"
        Me.hgBultoNuevo.ValuesSecondary.Image = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 107)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1095, 225)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgItemsBultoNuevo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1087, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgItemsBultoNuevo
        '
        Me.dgItemsBultoNuevo.AllowUserToAddRows = False
        Me.dgItemsBultoNuevo.AllowUserToDeleteRows = False
        Me.dgItemsBultoNuevo.AllowUserToResizeColumns = False
        Me.dgItemsBultoNuevo.AllowUserToResizeRows = False
        Me.dgItemsBultoNuevo.AutoGenerateColumns = False
        Me.dgItemsBultoNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemsBultoNuevo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.R_NORCML, Me.R_NRITOC, Me.R_CIDPAQ, Me.R_TDITES, Me.R_QBLTSR, Me.R_QBLTRP, Me.D_TDAITM, Me.SUBITEM, Me.NRSITEM})
        Me.dgItemsBultoNuevo.DataMember = "dtBultoItemsSaldo"
        Me.dgItemsBultoNuevo.DataSource = Me.dstAlmacen
        Me.dgItemsBultoNuevo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemsBultoNuevo.Location = New System.Drawing.Point(3, 3)
        Me.dgItemsBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgItemsBultoNuevo.MultiSelect = False
        Me.dgItemsBultoNuevo.Name = "dgItemsBultoNuevo"
        Me.dgItemsBultoNuevo.RowHeadersWidth = 20
        Me.dgItemsBultoNuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemsBultoNuevo.Size = New System.Drawing.Size(1081, 190)
        Me.dgItemsBultoNuevo.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgItemsBultoNuevo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemsBultoNuevo.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dgItemsBultoNuevo.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dgItemsBultoNuevo.StateCommon.HeaderRow.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dgItemsBultoNuevo.TabIndex = 11
        '
        'dstAlmacen
        '
        Me.dstAlmacen.DataSetName = "dstAlmacen"
        Me.dstAlmacen.Tables.AddRange(New System.Data.DataTable() {Me.dtBultoItemsSaldo})
        '
        'dtBultoItemsSaldo
        '
        Me.dtBultoItemsSaldo.Columns.AddRange(New System.Data.DataColumn() {Me.MNORCML, Me.MNRITOC, Me.MCIDPAQ, Me.MTDITES, Me.MQBLTSR, Me.DataColumn1})
        Me.dtBultoItemsSaldo.TableName = "dtBultoItemsSaldo"
        '
        'MNORCML
        '
        Me.MNORCML.ColumnName = "NORCML"
        Me.MNORCML.DefaultValue = ""
        Me.MNORCML.ReadOnly = True
        '
        'MNRITOC
        '
        Me.MNRITOC.ColumnName = "NRITOC"
        Me.MNRITOC.DataType = GetType(Integer)
        '
        'MCIDPAQ
        '
        Me.MCIDPAQ.ColumnName = "CIDPAQ"
        '
        'MTDITES
        '
        Me.MTDITES.ColumnName = "TDITES"
        Me.MTDITES.DefaultValue = ""
        '
        'MQBLTSR
        '
        Me.MQBLTSR.ColumnName = "QBLTSR"
        Me.MQBLTSR.DataType = GetType(Decimal)
        Me.MQBLTSR.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "TDAITM"
        Me.DataColumn1.DefaultValue = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgPaquetesDeBulto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1087, 196)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dimensiones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtgPaquetesDeBulto
        '
        Me.dtgPaquetesDeBulto.AllowUserToAddRows = False
        Me.dtgPaquetesDeBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPaquetesDeBulto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgPaquetesDeBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPaquetesDeBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNQCTPQT, Me.PNQMTLRG, Me.PNQMTANC, Me.PNQMTALT, Me.PNQVOLMR, Me.PNQPSOMR, Me.DIM_REPACKING, Me.PNNCRRIN, Me.Column1})
        Me.dtgPaquetesDeBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPaquetesDeBulto.Location = New System.Drawing.Point(3, 3)
        Me.dtgPaquetesDeBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgPaquetesDeBulto.Name = "dtgPaquetesDeBulto"
        Me.dtgPaquetesDeBulto.RowHeadersWidth = 20
        Me.dtgPaquetesDeBulto.RowTemplate.Height = 24
        Me.dtgPaquetesDeBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgPaquetesDeBulto.Size = New System.Drawing.Size(1081, 190)
        Me.dtgPaquetesDeBulto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgPaquetesDeBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPaquetesDeBulto.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dtgPaquetesDeBulto.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPaquetesDeBulto.StateCommon.HeaderRow.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dtgPaquetesDeBulto.TabIndex = 2
        '
        'txtCantidadAreaOcupadaNuevo
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadAreaOcupadaNuevo, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadAreaOcupadaNuevo, True)
        Me.txtCantidadAreaOcupadaNuevo.Location = New System.Drawing.Point(1009, 11)
        Me.txtCantidadAreaOcupadaNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadAreaOcupadaNuevo.Name = "txtCantidadAreaOcupadaNuevo"
        Me.txtCantidadAreaOcupadaNuevo.Size = New System.Drawing.Size(91, 26)
        Me.txtCantidadAreaOcupadaNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadAreaOcupadaNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadAreaOcupadaNuevo.TabIndex = 4
        Me.txtCantidadAreaOcupadaNuevo.Text = "0.00"
        Me.txtCantidadAreaOcupadaNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadAreaOcupadaNuevo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidadAreaOcupadaNuevo
        '
        Me.lblCantidadAreaOcupadaNuevo.Location = New System.Drawing.Point(883, 15)
        Me.lblCantidadAreaOcupadaNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadAreaOcupadaNuevo.Name = "lblCantidadAreaOcupadaNuevo"
        Me.lblCantidadAreaOcupadaNuevo.Size = New System.Drawing.Size(116, 24)
        Me.lblCantidadAreaOcupadaNuevo.TabIndex = 32
        Me.lblCantidadAreaOcupadaNuevo.Text = "Área Ocupada : "
        Me.lblCantidadAreaOcupadaNuevo.Values.ExtraText = ""
        Me.lblCantidadAreaOcupadaNuevo.Values.Image = Nothing
        Me.lblCantidadAreaOcupadaNuevo.Values.Text = "Área Ocupada : "
        '
        'txtCantidadRecibidaNuevo
        '
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadRecibidaNuevo, True)
        Me.txtCantidadRecibidaNuevo.Location = New System.Drawing.Point(813, 11)
        Me.txtCantidadRecibidaNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadRecibidaNuevo.Name = "txtCantidadRecibidaNuevo"
        Me.txtCantidadRecibidaNuevo.Size = New System.Drawing.Size(61, 26)
        Me.txtCantidadRecibidaNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadRecibidaNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadRecibidaNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCantidadRecibidaNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCantidadRecibidaNuevo.TabIndex = 3
        Me.txtCantidadRecibidaNuevo.Text = "0"
        Me.txtCantidadRecibidaNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadRecibidaNuevo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtCodigoRecepcionNuevo
        '
        Me.txtCodigoRecepcionNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoRecepcionNuevo.Location = New System.Drawing.Point(112, 11)
        Me.txtCodigoRecepcionNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoRecepcionNuevo.MaxLength = 20
        Me.txtCodigoRecepcionNuevo.Name = "txtCodigoRecepcionNuevo"
        Me.txtCodigoRecepcionNuevo.Size = New System.Drawing.Size(135, 26)
        Me.txtCodigoRecepcionNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoRecepcionNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoRecepcionNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCodigoRecepcionNuevo.TabIndex = 0
        '
        'lblCantidadRecibidaNuevo
        '
        Me.lblCantidadRecibidaNuevo.Location = New System.Drawing.Point(703, 15)
        Me.lblCantidadRecibidaNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadRecibidaNuevo.Name = "lblCantidadRecibidaNuevo"
        Me.lblCantidadRecibidaNuevo.Size = New System.Drawing.Size(95, 24)
        Me.lblCantidadRecibidaNuevo.TabIndex = 30
        Me.lblCantidadRecibidaNuevo.Text = "Nro. Bultos : "
        Me.lblCantidadRecibidaNuevo.Values.ExtraText = ""
        Me.lblCantidadRecibidaNuevo.Values.Image = Nothing
        Me.lblCantidadRecibidaNuevo.Values.Text = "Nro. Bultos : "
        '
        'txtPesoBultoNuevo
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoBultoNuevo, 2)
        Me.txtPesoBultoNuevo.Location = New System.Drawing.Point(112, 42)
        Me.txtPesoBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoBultoNuevo.Name = "txtPesoBultoNuevo"
        Me.txtPesoBultoNuevo.Size = New System.Drawing.Size(91, 26)
        Me.txtPesoBultoNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPesoBultoNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtPesoBultoNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPesoBultoNuevo.TabIndex = 5
        Me.txtPesoBultoNuevo.Text = "0.00"
        Me.txtPesoBultoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoBultoNuevo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtUnidadBultoNuevo
        '
        Me.txtUnidadBultoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadBultoNuevo.Enabled = False
        Me.txtUnidadBultoNuevo.Location = New System.Drawing.Point(332, 42)
        Me.txtUnidadBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadBultoNuevo.MaxLength = 10
        Me.txtUnidadBultoNuevo.Name = "txtUnidadBultoNuevo"
        Me.txtUnidadBultoNuevo.ReadOnly = True
        Me.txtUnidadBultoNuevo.Size = New System.Drawing.Size(105, 26)
        Me.txtUnidadBultoNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnidadBultoNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtUnidadBultoNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUnidadBultoNuevo.TabIndex = 6
        '
        'lblVolumenBultoNuevo
        '
        Me.lblVolumenBultoNuevo.Location = New System.Drawing.Point(445, 46)
        Me.lblVolumenBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVolumenBultoNuevo.Name = "lblVolumenBultoNuevo"
        Me.lblVolumenBultoNuevo.Size = New System.Drawing.Size(80, 24)
        Me.lblVolumenBultoNuevo.TabIndex = 38
        Me.lblVolumenBultoNuevo.Text = "Volumen : "
        Me.lblVolumenBultoNuevo.Values.ExtraText = ""
        Me.lblVolumenBultoNuevo.Values.Image = Nothing
        Me.lblVolumenBultoNuevo.Values.Text = "Volumen : "
        '
        'txtFechaRecepcionNuevo
        '
        Me.txtFechaRecepcionNuevo.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaRecepcionNuevo.Enabled = False
        Me.txtFechaRecepcionNuevo.Location = New System.Drawing.Point(332, 11)
        Me.txtFechaRecepcionNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaRecepcionNuevo.Mask = "##/##/####"
        Me.txtFechaRecepcionNuevo.Name = "txtFechaRecepcionNuevo"
        Me.txtFechaRecepcionNuevo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaRecepcionNuevo.Size = New System.Drawing.Size(105, 26)
        Me.txtFechaRecepcionNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaRecepcionNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaRecepcionNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtFechaRecepcionNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRecepcionNuevo.TabIndex = 1
        Me.txtFechaRecepcionNuevo.Text = "  /  /"
        '
        'lblUnidadBultoNuevo
        '
        Me.lblUnidadBultoNuevo.Location = New System.Drawing.Point(255, 46)
        Me.lblUnidadBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUnidadBultoNuevo.Name = "lblUnidadBultoNuevo"
        Me.lblUnidadBultoNuevo.Size = New System.Drawing.Size(68, 24)
        Me.lblUnidadBultoNuevo.TabIndex = 36
        Me.lblUnidadBultoNuevo.Text = "Unidad : "
        Me.lblUnidadBultoNuevo.Values.ExtraText = ""
        Me.lblUnidadBultoNuevo.Values.Image = Nothing
        Me.lblUnidadBultoNuevo.Values.Text = "Unidad : "
        '
        'lblUnidadVolumenNuevo
        '
        Me.lblUnidadVolumenNuevo.Location = New System.Drawing.Point(703, 46)
        Me.lblUnidadVolumenNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUnidadVolumenNuevo.Name = "lblUnidadVolumenNuevo"
        Me.lblUnidadVolumenNuevo.Size = New System.Drawing.Size(68, 24)
        Me.lblUnidadVolumenNuevo.TabIndex = 40
        Me.lblUnidadVolumenNuevo.Text = "Unidad : "
        Me.lblUnidadVolumenNuevo.Values.ExtraText = ""
        Me.lblUnidadVolumenNuevo.Values.Image = Nothing
        Me.lblUnidadVolumenNuevo.Values.Text = "Unidad : "
        '
        'lblFechaRecepcionNuevo
        '
        Me.lblFechaRecepcionNuevo.Location = New System.Drawing.Point(255, 15)
        Me.lblFechaRecepcionNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaRecepcionNuevo.Name = "lblFechaRecepcionNuevo"
        Me.lblFechaRecepcionNuevo.Size = New System.Drawing.Size(58, 24)
        Me.lblFechaRecepcionNuevo.TabIndex = 26
        Me.lblFechaRecepcionNuevo.Text = "Fecha :"
        Me.lblFechaRecepcionNuevo.Values.ExtraText = ""
        Me.lblFechaRecepcionNuevo.Values.Image = Nothing
        Me.lblFechaRecepcionNuevo.Values.Text = "Fecha :"
        '
        'lblPesoBultoNuevo
        '
        Me.lblPesoBultoNuevo.Location = New System.Drawing.Point(12, 46)
        Me.lblPesoBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPesoBultoNuevo.Name = "lblPesoBultoNuevo"
        Me.lblPesoBultoNuevo.Size = New System.Drawing.Size(91, 24)
        Me.lblPesoBultoNuevo.TabIndex = 34
        Me.lblPesoBultoNuevo.Text = "Peso Bulto : "
        Me.lblPesoBultoNuevo.Values.ExtraText = ""
        Me.lblPesoBultoNuevo.Values.Image = Nothing
        Me.lblPesoBultoNuevo.Values.Text = "Peso Bulto : "
        '
        'txtUnidadVolumenNuevo
        '
        Me.txtUnidadVolumenNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadVolumenNuevo.Enabled = False
        Me.txtUnidadVolumenNuevo.Location = New System.Drawing.Point(813, 42)
        Me.txtUnidadVolumenNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadVolumenNuevo.MaxLength = 10
        Me.txtUnidadVolumenNuevo.Name = "txtUnidadVolumenNuevo"
        Me.txtUnidadVolumenNuevo.ReadOnly = True
        Me.txtUnidadVolumenNuevo.Size = New System.Drawing.Size(105, 26)
        Me.txtUnidadVolumenNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnidadVolumenNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtUnidadVolumenNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUnidadVolumenNuevo.TabIndex = 8
        '
        'txtTipoBultoNuevo
        '
        Me.txtTipoBultoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoBultoNuevo.Location = New System.Drawing.Point(535, 11)
        Me.txtTipoBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoBultoNuevo.MaxLength = 10
        Me.txtTipoBultoNuevo.Name = "txtTipoBultoNuevo"
        Me.txtTipoBultoNuevo.Size = New System.Drawing.Size(159, 26)
        Me.txtTipoBultoNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoBultoNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoBultoNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtTipoBultoNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoBultoNuevo.TabIndex = 2
        '
        'txtUbicacionReferencialNuevo
        '
        Me.txtUbicacionReferencialNuevo.Enabled = False
        Me.txtUbicacionReferencialNuevo.Location = New System.Drawing.Point(635, 73)
        Me.txtUbicacionReferencialNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbicacionReferencialNuevo.MaxLength = 17
        Me.txtUbicacionReferencialNuevo.Name = "txtUbicacionReferencialNuevo"
        Me.txtUbicacionReferencialNuevo.ReadOnly = True
        Me.txtUbicacionReferencialNuevo.Size = New System.Drawing.Size(465, 26)
        Me.txtUbicacionReferencialNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUbicacionReferencialNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUbicacionReferencialNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtUbicacionReferencialNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUbicacionReferencialNuevo.TabIndex = 9
        '
        'txtVolumenBultoNuevo
        '
        Me.TypeValidator.SetDecimales(Me.txtVolumenBultoNuevo, 2)
        Me.txtVolumenBultoNuevo.Location = New System.Drawing.Point(535, 42)
        Me.txtVolumenBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolumenBultoNuevo.Name = "txtVolumenBultoNuevo"
        Me.txtVolumenBultoNuevo.Size = New System.Drawing.Size(91, 26)
        Me.txtVolumenBultoNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVolumenBultoNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtVolumenBultoNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtVolumenBultoNuevo.TabIndex = 7
        Me.txtVolumenBultoNuevo.Text = "0.00"
        Me.txtVolumenBultoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtVolumenBultoNuevo, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblTipoBultoNuevo
        '
        Me.lblTipoBultoNuevo.Location = New System.Drawing.Point(445, 15)
        Me.lblTipoBultoNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoBultoNuevo.Name = "lblTipoBultoNuevo"
        Me.lblTipoBultoNuevo.Size = New System.Drawing.Size(49, 24)
        Me.lblTipoBultoNuevo.TabIndex = 28
        Me.lblTipoBultoNuevo.Text = "Tipo : "
        Me.lblTipoBultoNuevo.Values.ExtraText = ""
        Me.lblTipoBultoNuevo.Values.Image = Nothing
        Me.lblTipoBultoNuevo.Values.Text = "Tipo : "
        '
        'lblUbicacionReferencialNuevo
        '
        Me.lblUbicacionReferencialNuevo.Location = New System.Drawing.Point(539, 76)
        Me.lblUbicacionReferencialNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUbicacionReferencialNuevo.Name = "lblUbicacionReferencialNuevo"
        Me.lblUbicacionReferencialNuevo.Size = New System.Drawing.Size(86, 24)
        Me.lblUbicacionReferencialNuevo.TabIndex = 44
        Me.lblUbicacionReferencialNuevo.Text = "Ubicación : "
        Me.lblUbicacionReferencialNuevo.Values.ExtraText = ""
        Me.lblUbicacionReferencialNuevo.Values.Image = Nothing
        Me.lblUbicacionReferencialNuevo.Values.Text = "Ubicación : "
        '
        'lblDescripcionWaybillNuevo
        '
        Me.lblDescripcionWaybillNuevo.Location = New System.Drawing.Point(12, 76)
        Me.lblDescripcionWaybillNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDescripcionWaybillNuevo.Name = "lblDescripcionWaybillNuevo"
        Me.lblDescripcionWaybillNuevo.Size = New System.Drawing.Size(67, 24)
        Me.lblDescripcionWaybillNuevo.TabIndex = 42
        Me.lblDescripcionWaybillNuevo.Text = "Detalle : "
        Me.lblDescripcionWaybillNuevo.Values.ExtraText = ""
        Me.lblDescripcionWaybillNuevo.Values.Image = Nothing
        Me.lblDescripcionWaybillNuevo.Values.Text = "Detalle : "
        '
        'lblCodigoRecepcionNuevo
        '
        Me.lblCodigoRecepcionNuevo.Location = New System.Drawing.Point(12, 15)
        Me.lblCodigoRecepcionNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodigoRecepcionNuevo.Name = "lblCodigoRecepcionNuevo"
        Me.lblCodigoRecepcionNuevo.Size = New System.Drawing.Size(90, 24)
        Me.lblCodigoRecepcionNuevo.TabIndex = 24
        Me.lblCodigoRecepcionNuevo.Text = "Cód. Bulto : "
        Me.lblCodigoRecepcionNuevo.Values.ExtraText = ""
        Me.lblCodigoRecepcionNuevo.Values.Image = Nothing
        Me.lblCodigoRecepcionNuevo.Values.Text = "Cód. Bulto : "
        '
        'txtDescripcionWaybillNuevo
        '
        Me.txtDescripcionWaybillNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionWaybillNuevo.Location = New System.Drawing.Point(112, 73)
        Me.txtDescripcionWaybillNuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcionWaybillNuevo.MaxLength = 40
        Me.txtDescripcionWaybillNuevo.Name = "txtDescripcionWaybillNuevo"
        Me.txtDescripcionWaybillNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDescripcionWaybillNuevo.Size = New System.Drawing.Size(415, 26)
        Me.txtDescripcionWaybillNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcionWaybillNuevo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcionWaybillNuevo.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtDescripcionWaybillNuevo.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescripcionWaybillNuevo.TabIndex = 43
        '
        'hgBultoOrigen
        '
        Me.hgBultoOrigen.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgBultoOrigen.HeaderVisibleSecondary = False
        Me.hgBultoOrigen.Location = New System.Drawing.Point(0, 0)
        Me.hgBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.hgBultoOrigen.Name = "hgBultoOrigen"
        '
        'hgBultoOrigen.Panel
        '
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtUbicacionReferencialOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblUbicacionReferencialOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtDescripcionWaybillOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblDescripcionWaybillOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblPesoBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtPesoBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtCodigoRecepcionOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblCodigoRecepcionOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblFechaRecepcionOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblUnidadBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtFechaRecepcionOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtUnidadBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblTipoBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblVolumenBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtVolumenBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtTipoBultoOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblCantidadRecibidaOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblUnidadVolumenOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtUnidadVolumenOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtCantidadRecibidaOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.lblCantidadAreaOcupadaOrigen)
        Me.hgBultoOrigen.Panel.Controls.Add(Me.txtCantidadAreaOcupadaOrigen)
        Me.hgBultoOrigen.Size = New System.Drawing.Size(1123, 133)
        Me.hgBultoOrigen.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBultoOrigen.TabIndex = 0
        Me.hgBultoOrigen.Text = "Bulto Origen"
        Me.hgBultoOrigen.ValuesPrimary.Description = ""
        Me.hgBultoOrigen.ValuesPrimary.Heading = "Bulto Origen"
        Me.hgBultoOrigen.ValuesPrimary.Image = Nothing
        Me.hgBultoOrigen.ValuesSecondary.Description = ""
        Me.hgBultoOrigen.ValuesSecondary.Heading = "Description"
        Me.hgBultoOrigen.ValuesSecondary.Image = Nothing
        '
        'txtUbicacionReferencialOrigen
        '
        Me.txtUbicacionReferencialOrigen.Enabled = False
        Me.txtUbicacionReferencialOrigen.Location = New System.Drawing.Point(635, 73)
        Me.txtUbicacionReferencialOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbicacionReferencialOrigen.MaxLength = 17
        Me.txtUbicacionReferencialOrigen.Name = "txtUbicacionReferencialOrigen"
        Me.txtUbicacionReferencialOrigen.ReadOnly = True
        Me.txtUbicacionReferencialOrigen.Size = New System.Drawing.Size(464, 26)
        Me.txtUbicacionReferencialOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUbicacionReferencialOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUbicacionReferencialOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtUbicacionReferencialOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUbicacionReferencialOrigen.TabIndex = 9
        '
        'lblUbicacionReferencialOrigen
        '
        Me.lblUbicacionReferencialOrigen.Location = New System.Drawing.Point(539, 76)
        Me.lblUbicacionReferencialOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUbicacionReferencialOrigen.Name = "lblUbicacionReferencialOrigen"
        Me.lblUbicacionReferencialOrigen.Size = New System.Drawing.Size(86, 24)
        Me.lblUbicacionReferencialOrigen.TabIndex = 21
        Me.lblUbicacionReferencialOrigen.Text = "Ubicación : "
        Me.lblUbicacionReferencialOrigen.Values.ExtraText = ""
        Me.lblUbicacionReferencialOrigen.Values.Image = Nothing
        Me.lblUbicacionReferencialOrigen.Values.Text = "Ubicación : "
        '
        'txtDescripcionWaybillOrigen
        '
        Me.txtDescripcionWaybillOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionWaybillOrigen.Enabled = False
        Me.txtDescripcionWaybillOrigen.Location = New System.Drawing.Point(112, 73)
        Me.txtDescripcionWaybillOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcionWaybillOrigen.MaxLength = 40
        Me.txtDescripcionWaybillOrigen.Name = "txtDescripcionWaybillOrigen"
        Me.txtDescripcionWaybillOrigen.ReadOnly = True
        Me.txtDescripcionWaybillOrigen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDescripcionWaybillOrigen.Size = New System.Drawing.Size(415, 26)
        Me.txtDescripcionWaybillOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcionWaybillOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcionWaybillOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtDescripcionWaybillOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDescripcionWaybillOrigen.TabIndex = 8
        '
        'lblDescripcionWaybillOrigen
        '
        Me.lblDescripcionWaybillOrigen.Location = New System.Drawing.Point(12, 76)
        Me.lblDescripcionWaybillOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDescripcionWaybillOrigen.Name = "lblDescripcionWaybillOrigen"
        Me.lblDescripcionWaybillOrigen.Size = New System.Drawing.Size(67, 24)
        Me.lblDescripcionWaybillOrigen.TabIndex = 19
        Me.lblDescripcionWaybillOrigen.Text = "Detalle : "
        Me.lblDescripcionWaybillOrigen.Values.ExtraText = ""
        Me.lblDescripcionWaybillOrigen.Values.Image = Nothing
        Me.lblDescripcionWaybillOrigen.Values.Text = "Detalle : "
        '
        'lblPesoBultoOrigen
        '
        Me.lblPesoBultoOrigen.Location = New System.Drawing.Point(12, 46)
        Me.lblPesoBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPesoBultoOrigen.Name = "lblPesoBultoOrigen"
        Me.lblPesoBultoOrigen.Size = New System.Drawing.Size(91, 24)
        Me.lblPesoBultoOrigen.TabIndex = 11
        Me.lblPesoBultoOrigen.Text = "Peso Bulto : "
        Me.lblPesoBultoOrigen.Values.ExtraText = ""
        Me.lblPesoBultoOrigen.Values.Image = Nothing
        Me.lblPesoBultoOrigen.Values.Text = "Peso Bulto : "
        '
        'txtPesoBultoOrigen
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoBultoOrigen, 2)
        Me.txtPesoBultoOrigen.Enabled = False
        Me.txtPesoBultoOrigen.Location = New System.Drawing.Point(112, 42)
        Me.txtPesoBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoBultoOrigen.Name = "txtPesoBultoOrigen"
        Me.txtPesoBultoOrigen.ReadOnly = True
        Me.txtPesoBultoOrigen.Size = New System.Drawing.Size(91, 26)
        Me.txtPesoBultoOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPesoBultoOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtPesoBultoOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtPesoBultoOrigen.TabIndex = 5
        Me.txtPesoBultoOrigen.Text = "0.00"
        Me.txtPesoBultoOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoBultoOrigen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtCodigoRecepcionOrigen
        '
        Me.txtCodigoRecepcionOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoRecepcionOrigen.Enabled = False
        Me.txtCodigoRecepcionOrigen.Location = New System.Drawing.Point(112, 11)
        Me.txtCodigoRecepcionOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoRecepcionOrigen.MaxLength = 20
        Me.txtCodigoRecepcionOrigen.Name = "txtCodigoRecepcionOrigen"
        Me.txtCodigoRecepcionOrigen.ReadOnly = True
        Me.txtCodigoRecepcionOrigen.Size = New System.Drawing.Size(135, 26)
        Me.txtCodigoRecepcionOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoRecepcionOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoRecepcionOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCodigoRecepcionOrigen.TabIndex = 0
        '
        'lblCodigoRecepcionOrigen
        '
        Me.lblCodigoRecepcionOrigen.Location = New System.Drawing.Point(12, 15)
        Me.lblCodigoRecepcionOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodigoRecepcionOrigen.Name = "lblCodigoRecepcionOrigen"
        Me.lblCodigoRecepcionOrigen.Size = New System.Drawing.Size(90, 24)
        Me.lblCodigoRecepcionOrigen.TabIndex = 1
        Me.lblCodigoRecepcionOrigen.Text = "Cód. Bulto : "
        Me.lblCodigoRecepcionOrigen.Values.ExtraText = ""
        Me.lblCodigoRecepcionOrigen.Values.Image = Nothing
        Me.lblCodigoRecepcionOrigen.Values.Text = "Cód. Bulto : "
        '
        'lblFechaRecepcionOrigen
        '
        Me.lblFechaRecepcionOrigen.Location = New System.Drawing.Point(255, 15)
        Me.lblFechaRecepcionOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaRecepcionOrigen.Name = "lblFechaRecepcionOrigen"
        Me.lblFechaRecepcionOrigen.Size = New System.Drawing.Size(58, 24)
        Me.lblFechaRecepcionOrigen.TabIndex = 3
        Me.lblFechaRecepcionOrigen.Text = "Fecha :"
        Me.lblFechaRecepcionOrigen.Values.ExtraText = ""
        Me.lblFechaRecepcionOrigen.Values.Image = Nothing
        Me.lblFechaRecepcionOrigen.Values.Text = "Fecha :"
        '
        'lblUnidadBultoOrigen
        '
        Me.lblUnidadBultoOrigen.Location = New System.Drawing.Point(255, 46)
        Me.lblUnidadBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUnidadBultoOrigen.Name = "lblUnidadBultoOrigen"
        Me.lblUnidadBultoOrigen.Size = New System.Drawing.Size(68, 24)
        Me.lblUnidadBultoOrigen.TabIndex = 13
        Me.lblUnidadBultoOrigen.Text = "Unidad : "
        Me.lblUnidadBultoOrigen.Values.ExtraText = ""
        Me.lblUnidadBultoOrigen.Values.Image = Nothing
        Me.lblUnidadBultoOrigen.Values.Text = "Unidad : "
        '
        'txtFechaRecepcionOrigen
        '
        Me.txtFechaRecepcionOrigen.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaRecepcionOrigen.Enabled = False
        Me.txtFechaRecepcionOrigen.Location = New System.Drawing.Point(332, 11)
        Me.txtFechaRecepcionOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaRecepcionOrigen.Mask = "##/##/####"
        Me.txtFechaRecepcionOrigen.Name = "txtFechaRecepcionOrigen"
        Me.txtFechaRecepcionOrigen.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaRecepcionOrigen.Size = New System.Drawing.Size(105, 26)
        Me.txtFechaRecepcionOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaRecepcionOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaRecepcionOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtFechaRecepcionOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRecepcionOrigen.TabIndex = 1
        Me.txtFechaRecepcionOrigen.Text = "  /  /"
        '
        'txtUnidadBultoOrigen
        '
        Me.txtUnidadBultoOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadBultoOrigen.Enabled = False
        Me.txtUnidadBultoOrigen.Location = New System.Drawing.Point(332, 42)
        Me.txtUnidadBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadBultoOrigen.MaxLength = 10
        Me.txtUnidadBultoOrigen.Name = "txtUnidadBultoOrigen"
        Me.txtUnidadBultoOrigen.ReadOnly = True
        Me.txtUnidadBultoOrigen.Size = New System.Drawing.Size(105, 26)
        Me.txtUnidadBultoOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnidadBultoOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtUnidadBultoOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUnidadBultoOrigen.TabIndex = 6
        '
        'lblTipoBultoOrigen
        '
        Me.lblTipoBultoOrigen.Location = New System.Drawing.Point(445, 15)
        Me.lblTipoBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoBultoOrigen.Name = "lblTipoBultoOrigen"
        Me.lblTipoBultoOrigen.Size = New System.Drawing.Size(49, 24)
        Me.lblTipoBultoOrigen.TabIndex = 5
        Me.lblTipoBultoOrigen.Text = "Tipo : "
        Me.lblTipoBultoOrigen.Values.ExtraText = ""
        Me.lblTipoBultoOrigen.Values.Image = Nothing
        Me.lblTipoBultoOrigen.Values.Text = "Tipo : "
        '
        'lblVolumenBultoOrigen
        '
        Me.lblVolumenBultoOrigen.Location = New System.Drawing.Point(445, 46)
        Me.lblVolumenBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVolumenBultoOrigen.Name = "lblVolumenBultoOrigen"
        Me.lblVolumenBultoOrigen.Size = New System.Drawing.Size(80, 24)
        Me.lblVolumenBultoOrigen.TabIndex = 15
        Me.lblVolumenBultoOrigen.Text = "Volumen : "
        Me.lblVolumenBultoOrigen.Values.ExtraText = ""
        Me.lblVolumenBultoOrigen.Values.Image = Nothing
        Me.lblVolumenBultoOrigen.Values.Text = "Volumen : "
        '
        'txtVolumenBultoOrigen
        '
        Me.TypeValidator.SetDecimales(Me.txtVolumenBultoOrigen, 2)
        Me.txtVolumenBultoOrigen.Enabled = False
        Me.txtVolumenBultoOrigen.Location = New System.Drawing.Point(535, 42)
        Me.txtVolumenBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolumenBultoOrigen.Name = "txtVolumenBultoOrigen"
        Me.txtVolumenBultoOrigen.ReadOnly = True
        Me.txtVolumenBultoOrigen.Size = New System.Drawing.Size(91, 26)
        Me.txtVolumenBultoOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVolumenBultoOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtVolumenBultoOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtVolumenBultoOrigen.TabIndex = 7
        Me.txtVolumenBultoOrigen.Text = "0.00"
        Me.txtVolumenBultoOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtVolumenBultoOrigen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtTipoBultoOrigen
        '
        Me.txtTipoBultoOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoBultoOrigen.Enabled = False
        Me.txtTipoBultoOrigen.Location = New System.Drawing.Point(535, 11)
        Me.txtTipoBultoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoBultoOrigen.MaxLength = 10
        Me.txtTipoBultoOrigen.Name = "txtTipoBultoOrigen"
        Me.txtTipoBultoOrigen.ReadOnly = True
        Me.txtTipoBultoOrigen.Size = New System.Drawing.Size(159, 26)
        Me.txtTipoBultoOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoBultoOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoBultoOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtTipoBultoOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTipoBultoOrigen.TabIndex = 2
        '
        'lblCantidadRecibidaOrigen
        '
        Me.lblCantidadRecibidaOrigen.Location = New System.Drawing.Point(703, 15)
        Me.lblCantidadRecibidaOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadRecibidaOrigen.Name = "lblCantidadRecibidaOrigen"
        Me.lblCantidadRecibidaOrigen.Size = New System.Drawing.Size(95, 24)
        Me.lblCantidadRecibidaOrigen.TabIndex = 7
        Me.lblCantidadRecibidaOrigen.Text = "Nro. Bultos : "
        Me.lblCantidadRecibidaOrigen.Values.ExtraText = ""
        Me.lblCantidadRecibidaOrigen.Values.Image = Nothing
        Me.lblCantidadRecibidaOrigen.Values.Text = "Nro. Bultos : "
        '
        'lblUnidadVolumenOrigen
        '
        Me.lblUnidadVolumenOrigen.Location = New System.Drawing.Point(703, 46)
        Me.lblUnidadVolumenOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUnidadVolumenOrigen.Name = "lblUnidadVolumenOrigen"
        Me.lblUnidadVolumenOrigen.Size = New System.Drawing.Size(68, 24)
        Me.lblUnidadVolumenOrigen.TabIndex = 17
        Me.lblUnidadVolumenOrigen.Text = "Unidad : "
        Me.lblUnidadVolumenOrigen.Values.ExtraText = ""
        Me.lblUnidadVolumenOrigen.Values.Image = Nothing
        Me.lblUnidadVolumenOrigen.Values.Text = "Unidad : "
        '
        'txtUnidadVolumenOrigen
        '
        Me.txtUnidadVolumenOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadVolumenOrigen.Enabled = False
        Me.txtUnidadVolumenOrigen.Location = New System.Drawing.Point(812, 42)
        Me.txtUnidadVolumenOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadVolumenOrigen.MaxLength = 10
        Me.txtUnidadVolumenOrigen.Name = "txtUnidadVolumenOrigen"
        Me.txtUnidadVolumenOrigen.ReadOnly = True
        Me.txtUnidadVolumenOrigen.Size = New System.Drawing.Size(105, 26)
        Me.txtUnidadVolumenOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnidadVolumenOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtUnidadVolumenOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtUnidadVolumenOrigen.TabIndex = 18
        '
        'txtCantidadRecibidaOrigen
        '
        Me.txtCantidadRecibidaOrigen.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadRecibidaOrigen, True)
        Me.txtCantidadRecibidaOrigen.Location = New System.Drawing.Point(812, 11)
        Me.txtCantidadRecibidaOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadRecibidaOrigen.Name = "txtCantidadRecibidaOrigen"
        Me.txtCantidadRecibidaOrigen.ReadOnly = True
        Me.txtCantidadRecibidaOrigen.Size = New System.Drawing.Size(61, 26)
        Me.txtCantidadRecibidaOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadRecibidaOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadRecibidaOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCantidadRecibidaOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCantidadRecibidaOrigen.TabIndex = 3
        Me.txtCantidadRecibidaOrigen.Text = "0"
        Me.txtCantidadRecibidaOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadRecibidaOrigen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblCantidadAreaOcupadaOrigen
        '
        Me.lblCantidadAreaOcupadaOrigen.Location = New System.Drawing.Point(882, 15)
        Me.lblCantidadAreaOcupadaOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadAreaOcupadaOrigen.Name = "lblCantidadAreaOcupadaOrigen"
        Me.lblCantidadAreaOcupadaOrigen.Size = New System.Drawing.Size(116, 24)
        Me.lblCantidadAreaOcupadaOrigen.TabIndex = 9
        Me.lblCantidadAreaOcupadaOrigen.Text = "Área Ocupada : "
        Me.lblCantidadAreaOcupadaOrigen.Values.ExtraText = ""
        Me.lblCantidadAreaOcupadaOrigen.Values.Image = Nothing
        Me.lblCantidadAreaOcupadaOrigen.Values.Text = "Área Ocupada : "
        '
        'txtCantidadAreaOcupadaOrigen
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadAreaOcupadaOrigen, 2)
        Me.txtCantidadAreaOcupadaOrigen.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadAreaOcupadaOrigen, True)
        Me.txtCantidadAreaOcupadaOrigen.Location = New System.Drawing.Point(1008, 11)
        Me.txtCantidadAreaOcupadaOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadAreaOcupadaOrigen.Name = "txtCantidadAreaOcupadaOrigen"
        Me.txtCantidadAreaOcupadaOrigen.Size = New System.Drawing.Size(91, 26)
        Me.txtCantidadAreaOcupadaOrigen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadAreaOcupadaOrigen.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadAreaOcupadaOrigen.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtCantidadAreaOcupadaOrigen.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCantidadAreaOcupadaOrigen.TabIndex = 4
        Me.txtCantidadAreaOcupadaOrigen.Text = "0.00"
        Me.txtCantidadAreaOcupadaOrigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadAreaOcupadaOrigen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(899, 545)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 54)
        Me.btnAgregar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAgregar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAgregar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAgregar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.ToolTip1.SetToolTip(Me.btnAgregar, "Realiza el Re-PacKing")
        Me.btnAgregar.Values.ExtraText = ""
        Me.btnAgregar.Values.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok1
        Me.btnAgregar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregar.Values.Text = "Agregar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(1007, 545)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 54)
        Me.btnCancelar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnCancelar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "&Cancelar"
        Me.ToolTip1.SetToolTip(Me.btnCancelar, "Cancela el Re-Packing")
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'R_NORCML
        '
        Me.R_NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.R_NORCML.DataPropertyName = "NORCML"
        Me.R_NORCML.HeaderText = "Nro. O/C"
        Me.R_NORCML.Name = "R_NORCML"
        Me.R_NORCML.ReadOnly = True
        Me.R_NORCML.Width = 89
        '
        'R_NRITOC
        '
        Me.R_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.R_NRITOC.DataPropertyName = "NRITOC"
        Me.R_NRITOC.HeaderText = "Item"
        Me.R_NRITOC.Name = "R_NRITOC"
        Me.R_NRITOC.Width = 67
        '
        'R_CIDPAQ
        '
        Me.R_CIDPAQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.R_CIDPAQ.DataPropertyName = "CIDPAQ"
        Me.R_CIDPAQ.HeaderText = "Código"
        Me.R_CIDPAQ.Name = "R_CIDPAQ"
        Me.R_CIDPAQ.Visible = False
        Me.R_CIDPAQ.Width = 80
        '
        'R_TDITES
        '
        Me.R_TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.R_TDITES.DataPropertyName = "TDITES"
        Me.R_TDITES.HeaderText = "Descripción"
        Me.R_TDITES.Name = "R_TDITES"
        Me.R_TDITES.Width = 107
        '
        'R_QBLTSR
        '
        Me.R_QBLTSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.R_QBLTSR.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N5"
        DataGridViewCellStyle1.NullValue = "0"
        Me.R_QBLTSR.DefaultCellStyle = DataGridViewCellStyle1
        Me.R_QBLTSR.HeaderText = "Cant. Inicial"
        Me.R_QBLTSR.Name = "R_QBLTSR"
        Me.R_QBLTSR.Width = 111
        '
        'R_QBLTRP
        '
        Me.R_QBLTRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0"
        Me.R_QBLTRP.DefaultCellStyle = DataGridViewCellStyle2
        Me.R_QBLTRP.HeaderText = "Re-Packing"
        Me.R_QBLTRP.Name = "R_QBLTRP"
        Me.R_QBLTRP.Width = 105
        '
        'D_TDAITM
        '
        Me.D_TDAITM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.D_TDAITM.DataPropertyName = "TDAITM"
        Me.D_TDAITM.FillWeight = 250.0!
        Me.D_TDAITM.HeaderText = "Observación"
        Me.D_TDAITM.Name = "D_TDAITM"
        Me.D_TDAITM.Width = 313
        '
        'SUBITEM
        '
        Me.SUBITEM.HeaderText = "SubItem"
        Me.SUBITEM.Image = Global.SOLMIN_SA.My.Resources.Resources.EnBlanco
        Me.SUBITEM.Name = "SUBITEM"
        Me.SUBITEM.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SUBITEM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SUBITEM.Width = 83
        '
        'NRSITEM
        '
        Me.NRSITEM.DataPropertyName = "NRSITEM"
        Me.NRSITEM.HeaderText = "NRSITEM"
        Me.NRSITEM.Name = "NRSITEM"
        Me.NRSITEM.Visible = False
        '
        'PNQCTPQT
        '
        Me.PNQCTPQT.DataPropertyName = "PNQCTPQT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PNQCTPQT.DefaultCellStyle = DataGridViewCellStyle3
        Me.PNQCTPQT.HeaderText = "Cantidad Paquete"
        Me.PNQCTPQT.Name = "PNQCTPQT"
        Me.PNQCTPQT.ReadOnly = True
        Me.PNQCTPQT.Width = 143
        '
        'PNQMTLRG
        '
        Me.PNQMTLRG.DataPropertyName = "PNQMTLRG"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PNQMTLRG.DefaultCellStyle = DataGridViewCellStyle4
        Me.PNQMTLRG.HeaderText = "Largo (mts)"
        Me.PNQMTLRG.Name = "PNQMTLRG"
        Me.PNQMTLRG.ReadOnly = True
        Me.PNQMTLRG.Width = 107
        '
        'PNQMTANC
        '
        Me.PNQMTANC.DataPropertyName = "PNQMTANC"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PNQMTANC.DefaultCellStyle = DataGridViewCellStyle5
        Me.PNQMTANC.HeaderText = "Ancho (mts)"
        Me.PNQMTANC.Name = "PNQMTANC"
        Me.PNQMTANC.ReadOnly = True
        Me.PNQMTANC.Width = 110
        '
        'PNQMTALT
        '
        Me.PNQMTALT.DataPropertyName = "PNQMTALT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PNQMTALT.DefaultCellStyle = DataGridViewCellStyle6
        Me.PNQMTALT.HeaderText = "Alto (mts)"
        Me.PNQMTALT.Name = "PNQMTALT"
        Me.PNQMTALT.ReadOnly = True
        Me.PNQMTALT.Width = 99
        '
        'PNQVOLMR
        '
        Me.PNQVOLMR.DataPropertyName = "VOLUMENPAQUETE"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N3"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PNQVOLMR.DefaultCellStyle = DataGridViewCellStyle7
        Me.PNQVOLMR.HeaderText = "Volumen Paquete"
        Me.PNQVOLMR.Name = "PNQVOLMR"
        Me.PNQVOLMR.ReadOnly = True
        Me.PNQVOLMR.Width = 142
        '
        'PNQPSOMR
        '
        Me.PNQPSOMR.DataPropertyName = "PNQPSOMR"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N3"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PNQPSOMR.DefaultCellStyle = DataGridViewCellStyle8
        Me.PNQPSOMR.HeaderText = "Peso Paquete"
        Me.PNQPSOMR.Name = "PNQPSOMR"
        Me.PNQPSOMR.ReadOnly = True
        Me.PNQPSOMR.Width = 118
        '
        'DIM_REPACKING
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle9.Format = "N3"
        DataGridViewCellStyle9.NullValue = "0"
        Me.DIM_REPACKING.DefaultCellStyle = DataGridViewCellStyle9
        Me.DIM_REPACKING.HeaderText = "Re-packing"
        Me.DIM_REPACKING.Name = "DIM_REPACKING"
        Me.DIM_REPACKING.Width = 105
        '
        'PNNCRRIN
        '
        Me.PNNCRRIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNCRRIN.DataPropertyName = "PNNCRRIN"
        Me.PNNCRRIN.HeaderText = "PNNCRRIN"
        Me.PNNCRRIN.Name = "PNNCRRIN"
        Me.PNNCRRIN.ReadOnly = True
        Me.PNNCRRIN.Visible = False
        Me.PNNCRRIN.Width = 99
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmRePacking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(1123, 607)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRePacking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Packing de Bultos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgBultoNuevo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBultoNuevo.Panel.ResumeLayout(False)
        Me.hgBultoNuevo.Panel.PerformLayout()
        CType(Me.hgBultoNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBultoNuevo.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgItemsBultoNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBultoItemsSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgPaquetesDeBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgBultoOrigen.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBultoOrigen.Panel.ResumeLayout(False)
        Me.hgBultoOrigen.Panel.PerformLayout()
        CType(Me.hgBultoOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBultoOrigen.ResumeLayout(False)
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
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents hgBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtCantidadRecibidaOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoRecepcionOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidadRecibidaOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUnidadBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblVolumenBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaRecepcionOrigen As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblUnidadBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUnidadVolumenOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaRecepcionOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPesoBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadVolumenOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUbicacionReferencialOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtVolumenBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTipoBultoOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUbicacionReferencialOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDescripcionWaybillOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigoRecepcionOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcionWaybillOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents hgBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtCantidadRecibidaNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoRecepcionNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidadRecibidaNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUnidadBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblVolumenBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaRecepcionNuevo As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblUnidadBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUnidadVolumenNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaRecepcionNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPesoBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadVolumenNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTipoBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUbicacionReferencialNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtVolumenBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblTipoBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUbicacionReferencialNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDescripcionWaybillNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigoRecepcionNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcionWaybillNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dstAlmacen As System.Data.DataSet
    Friend WithEvents dtBultoItemsSaldo As System.Data.DataTable
    Friend WithEvents txtCantidadAreaOcupadaNuevo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidadAreaOcupadaNuevo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCantidadAreaOcupadaOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidadAreaOcupadaOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MNORCML As System.Data.DataColumn
    Friend WithEvents MNRITOC As System.Data.DataColumn
    Friend WithEvents MCIDPAQ As System.Data.DataColumn
    Friend WithEvents MTDITES As System.Data.DataColumn
    Friend WithEvents MQBLTSR As System.Data.DataColumn
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgItemsBultoNuevo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtgPaquetesDeBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents R_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_CIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_QBLTRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TDAITM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SUBITEM As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NRSITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQCTPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTLRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTANC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTALT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQVOLMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPSOMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIM_REPACKING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNCRRIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
