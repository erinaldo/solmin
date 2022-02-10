<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacenesSDS
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgStockAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.D_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TCMPAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QSLMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QAUTCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_CUNCN7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QSLMP2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QAUTPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_CUNPS7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_QDSVGN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_STPING = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.D_TOBSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtStockPorAlmacen = New System.Data.DataTable
        Me.DSTASEL = New System.Data.DataColumn
        Me.DNORDSR = New System.Data.DataColumn
        Me.DCTPALM = New System.Data.DataColumn
        Me.DTALMC = New System.Data.DataColumn
        Me.DCALMC = New System.Data.DataColumn
        Me.DTCMPAL = New System.Data.DataColumn
        Me.DCZNALM = New System.Data.DataColumn
        Me.DTCMZNA = New System.Data.DataColumn
        Me.DQSLMC2 = New System.Data.DataColumn
        Me.DCUNCN7 = New System.Data.DataColumn
        Me.DQSLMP2 = New System.Data.DataColumn
        Me.DCUNPS7 = New System.Data.DataColumn
        Me.DQDSVGN = New System.Data.DataColumn
        Me.DQAUTCN = New System.Data.DataColumn
        Me.DQAUTPS = New System.Data.DataColumn
        Me.DSTPING = New System.Data.DataColumn
        Me.DTOBSRV = New System.Data.DataColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgStockAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStockPorAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgStockAlmacen)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(492, 266)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgStockAlmacen
        '
        Me.dtgStockAlmacen.AllowUserToAddRows = False
        Me.dtgStockAlmacen.AllowUserToDeleteRows = False
        Me.dtgStockAlmacen.AllowUserToResizeColumns = False
        Me.dtgStockAlmacen.AllowUserToResizeRows = False
        Me.dtgStockAlmacen.AutoGenerateColumns = False
        Me.dtgStockAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgStockAlmacen.ColumnHeadersHeight = 33
        Me.dtgStockAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_NORDSR, Me.D_CTPALM, Me.D_TALMC, Me.D_CALMC, Me.D_TCMPAL, Me.D_CZNALM, Me.D_TCMZNA, Me.D_QSLMC2, Me.D_QAUTCN, Me.D_CUNCN7, Me.D_QSLMP2, Me.D_QAUTPS, Me.D_CUNPS7, Me.D_QDSVGN, Me.D_STPING, Me.D_TOBSRV})
        Me.dtgStockAlmacen.DataMember = "dtStockPorAlmacen"
        Me.dtgStockAlmacen.DataSource = Me.dstMercaderia
        Me.dtgStockAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgStockAlmacen.Location = New System.Drawing.Point(0, 25)
        Me.dtgStockAlmacen.MultiSelect = False
        Me.dtgStockAlmacen.Name = "dtgStockAlmacen"
        Me.dtgStockAlmacen.RowHeadersWidth = 20
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgStockAlmacen.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgStockAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgStockAlmacen.Size = New System.Drawing.Size(492, 241)
        Me.dtgStockAlmacen.StandardTab = True
        Me.dtgStockAlmacen.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgStockAlmacen.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dtgStockAlmacen.TabIndex = 28
        '
        'D_NORDSR
        '
        Me.D_NORDSR.DataPropertyName = "NORDSR"
        Me.D_NORDSR.HeaderText = "Orden Servicio"
        Me.D_NORDSR.MaxInputLength = 10
        Me.D_NORDSR.Name = "D_NORDSR"
        Me.D_NORDSR.ReadOnly = True
        Me.D_NORDSR.Visible = False
        Me.D_NORDSR.Width = 102
        '
        'D_CTPALM
        '
        Me.D_CTPALM.DataPropertyName = "CTPALM"
        Me.D_CTPALM.HeaderText = "Tipo"
        Me.D_CTPALM.MaxInputLength = 2
        Me.D_CTPALM.Name = "D_CTPALM"
        Me.D_CTPALM.ReadOnly = True
        Me.D_CTPALM.Width = 58
        '
        'D_TALMC
        '
        Me.D_TALMC.DataPropertyName = "TALMC"
        Me.D_TALMC.HeaderText = "Detalle"
        Me.D_TALMC.MaxInputLength = 50
        Me.D_TALMC.Name = "D_TALMC"
        Me.D_TALMC.ReadOnly = True
        Me.D_TALMC.Visible = False
        Me.D_TALMC.Width = 72
        '
        'D_CALMC
        '
        Me.D_CALMC.DataPropertyName = "CALMC"
        Me.D_CALMC.HeaderText = "Almacén"
        Me.D_CALMC.MaxInputLength = 2
        Me.D_CALMC.Name = "D_CALMC"
        Me.D_CALMC.ReadOnly = True
        Me.D_CALMC.Width = 79
        '
        'D_TCMPAL
        '
        Me.D_TCMPAL.DataPropertyName = "TCMPAL"
        Me.D_TCMPAL.HeaderText = "Detalle"
        Me.D_TCMPAL.MaxInputLength = 50
        Me.D_TCMPAL.Name = "D_TCMPAL"
        Me.D_TCMPAL.ReadOnly = True
        Me.D_TCMPAL.Visible = False
        Me.D_TCMPAL.Width = 72
        '
        'D_CZNALM
        '
        Me.D_CZNALM.DataPropertyName = "CZNALM"
        Me.D_CZNALM.HeaderText = "Zona"
        Me.D_CZNALM.MaxInputLength = 2
        Me.D_CZNALM.Name = "D_CZNALM"
        Me.D_CZNALM.ReadOnly = True
        Me.D_CZNALM.Width = 62
        '
        'D_TCMZNA
        '
        Me.D_TCMZNA.DataPropertyName = "TCMZNA"
        Me.D_TCMZNA.HeaderText = "Detalle"
        Me.D_TCMZNA.Name = "D_TCMZNA"
        Me.D_TCMZNA.ReadOnly = True
        Me.D_TCMZNA.Visible = False
        Me.D_TCMZNA.Width = 72
        '
        'D_QSLMC2
        '
        Me.D_QSLMC2.DataPropertyName = "QSLMC2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.D_QSLMC2.DefaultCellStyle = DataGridViewCellStyle1
        Me.D_QSLMC2.HeaderText = "S. Cant."
        Me.D_QSLMC2.MaxInputLength = 10
        Me.D_QSLMC2.Name = "D_QSLMC2"
        Me.D_QSLMC2.ReadOnly = True
        Me.D_QSLMC2.Width = 70
        '
        'D_QAUTCN
        '
        Me.D_QAUTCN.DataPropertyName = "QAUTCN"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.D_QAUTCN.DefaultCellStyle = DataGridViewCellStyle2
        Me.D_QAUTCN.HeaderText = "Cant."
        Me.D_QAUTCN.MaxInputLength = 10
        Me.D_QAUTCN.Name = "D_QAUTCN"
        Me.D_QAUTCN.Visible = False
        Me.D_QAUTCN.Width = 63
        '
        'D_CUNCN7
        '
        Me.D_CUNCN7.DataPropertyName = "CUNCN7"
        Me.D_CUNCN7.HeaderText = "Uni."
        Me.D_CUNCN7.MaxInputLength = 10
        Me.D_CUNCN7.Name = "D_CUNCN7"
        Me.D_CUNCN7.ReadOnly = True
        Me.D_CUNCN7.Width = 57
        '
        'D_QSLMP2
        '
        Me.D_QSLMP2.DataPropertyName = "QSLMP2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.D_QSLMP2.DefaultCellStyle = DataGridViewCellStyle3
        Me.D_QSLMP2.HeaderText = "S. Peso"
        Me.D_QSLMP2.MaxInputLength = 10
        Me.D_QSLMP2.Name = "D_QSLMP2"
        Me.D_QSLMP2.ReadOnly = True
        Me.D_QSLMP2.Width = 67
        '
        'D_QAUTPS
        '
        Me.D_QAUTPS.DataPropertyName = "QAUTPS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.D_QAUTPS.DefaultCellStyle = DataGridViewCellStyle4
        Me.D_QAUTPS.HeaderText = "Peso"
        Me.D_QAUTPS.MaxInputLength = 10
        Me.D_QAUTPS.Name = "D_QAUTPS"
        Me.D_QAUTPS.Visible = False
        Me.D_QAUTPS.Width = 60
        '
        'D_CUNPS7
        '
        Me.D_CUNPS7.DataPropertyName = "CUNPS7"
        Me.D_CUNPS7.HeaderText = "Uni."
        Me.D_CUNPS7.MaxInputLength = 10
        Me.D_CUNPS7.Name = "D_CUNPS7"
        Me.D_CUNPS7.ReadOnly = True
        Me.D_CUNPS7.Width = 57
        '
        'D_QDSVGN
        '
        Me.D_QDSVGN.DataPropertyName = "QDSVGN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.D_QDSVGN.DefaultCellStyle = DataGridViewCellStyle5
        Me.D_QDSVGN.HeaderText = "Vigencia"
        Me.D_QDSVGN.MaxInputLength = 2
        Me.D_QDSVGN.Name = "D_QDSVGN"
        Me.D_QDSVGN.Visible = False
        Me.D_QDSVGN.Width = 80
        '
        'D_STPING
        '
        Me.D_STPING.DataPropertyName = "STPING"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_STPING.DefaultCellStyle = DataGridViewCellStyle6
        Me.D_STPING.HeaderText = "Mov."
        Me.D_STPING.MaxInputLength = 1
        Me.D_STPING.Name = "D_STPING"
        Me.D_STPING.Visible = False
        Me.D_STPING.Width = 61
        '
        'D_TOBSRV
        '
        Me.D_TOBSRV.DataPropertyName = "TOBSRV"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_TOBSRV.DefaultCellStyle = DataGridViewCellStyle7
        Me.D_TOBSRV.HeaderText = "Obs."
        Me.D_TOBSRV.MaxInputLength = 25
        Me.D_TOBSRV.Name = "D_TOBSRV"
        Me.D_TOBSRV.Visible = False
        Me.D_TOBSRV.Width = 60
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtStockPorAlmacen})
        '
        'dtStockPorAlmacen
        '
        Me.dtStockPorAlmacen.Columns.AddRange(New System.Data.DataColumn() {Me.DSTASEL, Me.DNORDSR, Me.DCTPALM, Me.DTALMC, Me.DCALMC, Me.DTCMPAL, Me.DCZNALM, Me.DTCMZNA, Me.DQSLMC2, Me.DCUNCN7, Me.DQSLMP2, Me.DCUNPS7, Me.DQDSVGN, Me.DQAUTCN, Me.DQAUTPS, Me.DSTPING, Me.DTOBSRV})
        Me.dtStockPorAlmacen.TableName = "dtStockPorAlmacen"
        '
        'DSTASEL
        '
        Me.DSTASEL.ColumnName = "STASEL"
        Me.DSTASEL.DataType = GetType(Integer)
        Me.DSTASEL.DefaultValue = 0
        '
        'DNORDSR
        '
        Me.DNORDSR.ColumnName = "NORDSR"
        Me.DNORDSR.DataType = GetType(Long)
        Me.DNORDSR.DefaultValue = CType(0, Long)
        '
        'DCTPALM
        '
        Me.DCTPALM.ColumnName = "CTPALM"
        '
        'DTALMC
        '
        Me.DTALMC.ColumnName = "TALMC"
        '
        'DCALMC
        '
        Me.DCALMC.ColumnName = "CALMC"
        '
        'DTCMPAL
        '
        Me.DTCMPAL.ColumnName = "TCMPAL"
        '
        'DCZNALM
        '
        Me.DCZNALM.ColumnName = "CZNALM"
        '
        'DTCMZNA
        '
        Me.DTCMZNA.ColumnName = "TCMZNA"
        '
        'DQSLMC2
        '
        Me.DQSLMC2.ColumnName = "QSLMC2"
        Me.DQSLMC2.DataType = GetType(Decimal)
        Me.DQSLMC2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DCUNCN7
        '
        Me.DCUNCN7.ColumnName = "CUNCN7"
        '
        'DQSLMP2
        '
        Me.DQSLMP2.ColumnName = "QSLMP2"
        Me.DQSLMP2.DataType = GetType(Decimal)
        Me.DQSLMP2.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DCUNPS7
        '
        Me.DCUNPS7.ColumnName = "CUNPS7"
        '
        'DQDSVGN
        '
        Me.DQDSVGN.ColumnName = "QDSVGN"
        Me.DQDSVGN.DataType = GetType(Decimal)
        Me.DQDSVGN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DQAUTCN
        '
        Me.DQAUTCN.ColumnName = "QAUTCN"
        Me.DQAUTCN.DataType = GetType(Decimal)
        Me.DQAUTCN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DQAUTPS
        '
        Me.DQAUTPS.ColumnName = "QAUTPS"
        Me.DQAUTPS.DataType = GetType(Decimal)
        Me.DQAUTPS.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'DSTPING
        '
        Me.DSTPING.ColumnName = "STPING"
        '
        'DTOBSRV
        '
        Me.DTOBSRV.ColumnName = "TOBSRV"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.ToolStripSeparator1, Me.tsbAceptar, Me.ToolStripSeparator2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(492, 25)
        Me.tsMenuOpciones.TabIndex = 30
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel1.Tag = "Almacenes"
        Me.ToolStripLabel1.Text = "Almacenes"
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAceptar
        '
        Me.tsbAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAceptar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok
        Me.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptar.Name = "tsbAceptar"
        Me.tsbAceptar.Size = New System.Drawing.Size(66, 22)
        Me.tsbAceptar.Text = "&Aceptar"
        Me.tsbAceptar.ToolTipText = "Grabar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmAlmacenesSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 266)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "frmAlmacenesSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacenes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgStockAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStockPorAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dstMercaderia As System.Data.DataSet
    Friend WithEvents dtStockPorAlmacen As System.Data.DataTable
    Friend WithEvents DSTASEL As System.Data.DataColumn
    Friend WithEvents DNORDSR As System.Data.DataColumn
    Friend WithEvents DCTPALM As System.Data.DataColumn
    Friend WithEvents DTALMC As System.Data.DataColumn
    Friend WithEvents DCALMC As System.Data.DataColumn
    Friend WithEvents DTCMPAL As System.Data.DataColumn
    Friend WithEvents DCZNALM As System.Data.DataColumn
    Friend WithEvents DTCMZNA As System.Data.DataColumn
    Friend WithEvents DQSLMC2 As System.Data.DataColumn
    Friend WithEvents DCUNCN7 As System.Data.DataColumn
    Friend WithEvents DQSLMP2 As System.Data.DataColumn
    Friend WithEvents DCUNPS7 As System.Data.DataColumn
    Friend WithEvents DQDSVGN As System.Data.DataColumn
    Friend WithEvents DQAUTCN As System.Data.DataColumn
    Friend WithEvents DQAUTPS As System.Data.DataColumn
    Friend WithEvents DSTPING As System.Data.DataColumn
    Friend WithEvents DTOBSRV As System.Data.DataColumn
    Friend WithEvents dtgStockAlmacen As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents D_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TCMPAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QSLMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QAUTCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CUNCN7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QSLMP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QAUTPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_CUNPS7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_QDSVGN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_STPING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TOBSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
