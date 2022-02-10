<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenMensualAlm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumenMensualAlm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgClienteSOLMIN = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnBusca = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbDepositoSimple = New System.Windows.Forms.ToolStripDropDownButton
        Me.tsmStockDS = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmIngresos = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDespachos = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAlmTransito = New System.Windows.Forms.ToolStripDropDownButton
        Me.tsmStock = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmIngresoAT = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDespachosAT = New System.Windows.Forms.ToolStripMenuItem
        Me.tss02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnMarcarItems = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cmbRegionVenta = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblanio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgClienteSOLMIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgClienteSOLMIN)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(868, 474)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgClienteSOLMIN
        '
        Me.dtgClienteSOLMIN.AllowUserToAddRows = False
        Me.dtgClienteSOLMIN.AllowUserToDeleteRows = False
        Me.dtgClienteSOLMIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClienteSOLMIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.CCLNT, Me.TCMPCL, Me.NRUC})
        Me.dtgClienteSOLMIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgClienteSOLMIN.Location = New System.Drawing.Point(0, 99)
        Me.dtgClienteSOLMIN.Name = "dtgClienteSOLMIN"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgClienteSOLMIN.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgClienteSOLMIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgClienteSOLMIN.Size = New System.Drawing.Size(868, 375)
        Me.dtgClienteSOLMIN.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgClienteSOLMIN.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgClienteSOLMIN.TabIndex = 6
        '
        'CHK
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.CHK.DefaultCellStyle = DataGridViewCellStyle1
        Me.CHK.FalseValue = Nothing
        Me.CHK.HeaderText = "Chk"
        Me.CHK.IndeterminateValue = Nothing
        Me.CHK.Name = "CHK"
        Me.CHK.TrueValue = Nothing
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cod. Cliente"
        Me.CCLNT.Name = "CCLNT"
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Descripción"
        Me.TCMPCL.Name = "TCMPCL"
        '
        'NRUC
        '
        Me.NRUC.DataPropertyName = "NRUC"
        Me.NRUC.HeaderText = "RUC"
        Me.NRUC.Name = "NRUC"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBusca, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.tsbDepositoSimple, Me.ToolStripSeparator1, Me.tsbAlmTransito, Me.tss02, Me.btnMarcarItems})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 74)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(868, 25)
        Me.ToolStrip2.TabIndex = 5
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnBusca
        '
        Me.btnBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBusca.Image = Global.SOLMIN_CT.My.Resources.Resources.search
        Me.btnBusca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(62, 22)
        Me.btnBusca.Text = "Buscar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton1.Text = "Exportar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDepositoSimple
        '
        Me.tsbDepositoSimple.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbDepositoSimple.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmStockDS, Me.tsmIngresos, Me.tsmDespachos})
        Me.tsbDepositoSimple.Image = Global.SOLMIN_CT.My.Resources.Resources.DepositoSimple
        Me.tsbDepositoSimple.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDepositoSimple.Name = "tsbDepositoSimple"
        Me.tsbDepositoSimple.Size = New System.Drawing.Size(122, 22)
        Me.tsbDepositoSimple.Text = "Almacén Simple"
        '
        'tsmStockDS
        '
        Me.tsmStockDS.Name = "tsmStockDS"
        Me.tsmStockDS.Size = New System.Drawing.Size(131, 22)
        Me.tsmStockDS.Text = "Stock"
        '
        'tsmIngresos
        '
        Me.tsmIngresos.Name = "tsmIngresos"
        Me.tsmIngresos.Size = New System.Drawing.Size(131, 22)
        Me.tsmIngresos.Text = "Recepción"
        '
        'tsmDespachos
        '
        Me.tsmDespachos.Name = "tsmDespachos"
        Me.tsmDespachos.Size = New System.Drawing.Size(131, 22)
        Me.tsmDespachos.Text = "Despachos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAlmTransito
        '
        Me.tsbAlmTransito.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAlmTransito.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmStock, Me.tsmIngresoAT, Me.tsmDespachosAT})
        Me.tsbAlmTransito.Image = Global.SOLMIN_CT.My.Resources.Resources.AlmacenTransito
        Me.tsbAlmTransito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAlmTransito.Name = "tsbAlmTransito"
        Me.tsbAlmTransito.Size = New System.Drawing.Size(145, 22)
        Me.tsbAlmTransito.Text = "Almacén de Transito"
        '
        'tsmStock
        '
        Me.tsmStock.Name = "tsmStock"
        Me.tsmStock.Size = New System.Drawing.Size(131, 22)
        Me.tsmStock.Text = "Stock"
        '
        'tsmIngresoAT
        '
        Me.tsmIngresoAT.Name = "tsmIngresoAT"
        Me.tsmIngresoAT.Size = New System.Drawing.Size(131, 22)
        Me.tsmIngresoAT.Text = "Recepción"
        '
        'tsmDespachosAT
        '
        Me.tsmDespachosAT.Name = "tsmDespachosAT"
        Me.tsmDespachosAT.Size = New System.Drawing.Size(131, 22)
        Me.tsmDespachosAT.Text = "Despachos"
        '
        'tss02
        '
        Me.tss02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss02.Name = "tss02"
        Me.tss02.Size = New System.Drawing.Size(6, 25)
        '
        'btnMarcarItems
        '
        Me.btnMarcarItems.BackgroundImage = CType(resources.GetObject("btnMarcarItems.BackgroundImage"), System.Drawing.Image)
        Me.btnMarcarItems.CheckOnClick = True
        Me.btnMarcarItems.Image = CType(resources.GetObject("btnMarcarItems.Image"), System.Drawing.Image)
        Me.btnMarcarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarItems.Name = "btnMarcarItems"
        Me.btnMarcarItems.Size = New System.Drawing.Size(103, 22)
        Me.btnMarcarItems.Text = " &Marcar Todos"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.AutoSize = True
        Me.KryptonHeaderGroup2.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonPanel2)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(868, 74)
        Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Filtros"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.Image = Nothing
        Me.ButtonSpecHeaderGroup2.Text = ""
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecHeaderGroup2.UniqueName = "2950BF82E9514DB92950BF82E9514DB9"
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.cmbRegionVenta)
        Me.KryptonPanel2.Controls.Add(Me.txtAnio)
        Me.KryptonPanel2.Controls.Add(Me.lblanio)
        Me.KryptonPanel2.Controls.Add(Me.UcCompania)
        Me.KryptonPanel2.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel2.Controls.Add(Me.lblCompania)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(866, 49)
        Me.KryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel2.TabIndex = 0
        '
        'cmbRegionVenta
        '
        Me.cmbRegionVenta.CheckOnClick = True
        Me.cmbRegionVenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbRegionVenta.DropDownHeight = 1
        Me.cmbRegionVenta.FormattingEnabled = True
        Me.cmbRegionVenta.IntegralHeight = False
        Me.cmbRegionVenta.Location = New System.Drawing.Point(426, 9)
        Me.cmbRegionVenta.Name = "cmbRegionVenta"
        Me.cmbRegionVenta.Size = New System.Drawing.Size(237, 21)
        Me.cmbRegionVenta.TabIndex = 128
        Me.cmbRegionVenta.ValueSeparator = ", "
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(1030, 9)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(66, 22)
        Me.txtAnio.StateActive.Back.Color1 = System.Drawing.Color.White
        Me.txtAnio.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.TabIndex = 127
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAnio.Visible = False
        '
        'lblanio
        '
        Me.lblanio.Location = New System.Drawing.Point(990, 12)
        Me.lblanio.Name = "lblanio"
        Me.lblanio.Size = New System.Drawing.Size(39, 20)
        Me.lblanio.TabIndex = 126
        Me.lblanio.Text = "Año :"
        Me.lblanio.Values.ExtraText = ""
        Me.lblanio.Values.Image = Nothing
        Me.lblanio.Values.Text = "Año :"
        Me.lblanio.Visible = False
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Habilitar = True
        Me.UcCompania.Location = New System.Drawing.Point(90, 6)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        Me.UcCompania.Size = New System.Drawing.Size(237, 24)
        Me.UcCompania.TabIndex = 88
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(357, 9)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(63, 20)
        Me.KryptonLabel3.TabIndex = 42
        Me.KryptonLabel3.Text = "Negocio :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Negocio :"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(12, 9)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(72, 20)
        Me.lblCompania.TabIndex = 0
        Me.lblCompania.Text = "Compañia :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRUC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmResumenMensualAlm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 474)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmResumenMensualAlm"
        Me.Text = "Resumen Mensual de Almacenes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgClienteSOLMIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cmbRegionVenta As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblanio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBusca As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtgClienteSOLMIN As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsbAlmTransito As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmStock As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmIngresoAT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDepositoSimple As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmStockDS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmIngresos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDespachos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDespachosAT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMarcarItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents CHK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
