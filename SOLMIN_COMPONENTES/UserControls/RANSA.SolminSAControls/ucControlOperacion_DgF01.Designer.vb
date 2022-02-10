<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucControlOperacion_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucControlOperacion_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblControlOperaciones = New System.Windows.Forms.ToolStripLabel
        Me.btnAbrirOperacion = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCerrarOperacion = New System.Windows.Forms.ToolStripButton
        Me.dstControlOperaciones = New System.Data.DataSet
        Me.dtRZO090 = New System.Data.DataTable
        Me.CCLNT = New System.Data.DataColumn
        Me.TCMPCL = New System.Data.DataColumn
        Me.FTRMOP = New System.Data.DataColumn
        Me.STPODP = New System.Data.DataColumn
        Me.CTPOAT = New System.Data.DataColumn
        Me.NOPRSP = New System.Data.DataColumn
        Me.QTAMOV = New System.Data.DataColumn
        Me.QQBLTO = New System.Data.DataColumn
        Me.QQPESO = New System.Data.DataColumn
        Me.dgControlOperaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.M_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FTRMOP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STPODP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NOPRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTAMOV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QQBLTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QQPESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dstControlOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRZO090, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgControlOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblControlOperaciones, Me.btnAbrirOperacion, Me.tssSep_01, Me.btnCerrarOperacion})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(566, 25)
        Me.tsMenuOpciones.TabIndex = 1
        '
        'lblControlOperaciones
        '
        Me.lblControlOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlOperaciones.Name = "lblControlOperaciones"
        Me.lblControlOperaciones.Size = New System.Drawing.Size(152, 22)
        Me.lblControlOperaciones.Text = "Control de Operaciones : "
        '
        'btnAbrirOperacion
        '
        Me.btnAbrirOperacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAbrirOperacion.Image = CType(resources.GetObject("btnAbrirOperacion.Image"), System.Drawing.Image)
        Me.btnAbrirOperacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbrirOperacion.Name = "btnAbrirOperacion"
        Me.btnAbrirOperacion.Size = New System.Drawing.Size(123, 22)
        Me.btnAbrirOperacion.Text = "  &Re-Abrir Operación"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnCerrarOperacion
        '
        Me.btnCerrarOperacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrarOperacion.Image = CType(resources.GetObject("btnCerrarOperacion.Image"), System.Drawing.Image)
        Me.btnCerrarOperacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrarOperacion.Name = "btnCerrarOperacion"
        Me.btnCerrarOperacion.Size = New System.Drawing.Size(113, 22)
        Me.btnCerrarOperacion.Text = "  &Cerrar Operación"
        '
        'dstControlOperaciones
        '
        Me.dstControlOperaciones.DataSetName = "dstControlOperaciones"
        Me.dstControlOperaciones.Tables.AddRange(New System.Data.DataTable() {Me.dtRZO090})
        '
        'dtRZO090
        '
        Me.dtRZO090.Columns.AddRange(New System.Data.DataColumn() {Me.CCLNT, Me.TCMPCL, Me.FTRMOP, Me.STPODP, Me.CTPOAT, Me.NOPRSP, Me.QTAMOV, Me.QQBLTO, Me.QQPESO})
        Me.dtRZO090.TableName = "dtRZO090"
        '
        'CCLNT
        '
        Me.CCLNT.ColumnName = "CCLNT"
        Me.CCLNT.DataType = GetType(Long)
        Me.CCLNT.DefaultValue = CType(0, Long)
        '
        'TCMPCL
        '
        Me.TCMPCL.ColumnName = "TCMPCL"
        Me.TCMPCL.DefaultValue = ""
        '
        'FTRMOP
        '
        Me.FTRMOP.ColumnName = "FTRMOP"
        Me.FTRMOP.DataType = GetType(Date)
        '
        'STPODP
        '
        Me.STPODP.ColumnName = "STPODP"
        Me.STPODP.DefaultValue = ""
        '
        'CTPOAT
        '
        Me.CTPOAT.ColumnName = "CTPOAT"
        Me.CTPOAT.DefaultValue = ""
        '
        'NOPRSP
        '
        Me.NOPRSP.ColumnName = "NOPRSP"
        Me.NOPRSP.DataType = GetType(Long)
        Me.NOPRSP.DefaultValue = CType(0, Long)
        '
        'QTAMOV
        '
        Me.QTAMOV.ColumnName = "QTAMOV"
        Me.QTAMOV.DataType = GetType(Decimal)
        Me.QTAMOV.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'QQBLTO
        '
        Me.QQBLTO.ColumnName = "QQBLTO"
        Me.QQBLTO.DataType = GetType(Decimal)
        Me.QQBLTO.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'QQPESO
        '
        Me.QQPESO.ColumnName = "QQPESO"
        Me.QQPESO.DataType = GetType(Decimal)
        Me.QQPESO.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dgControlOperaciones
        '
        Me.dgControlOperaciones.AllowUserToAddRows = False
        Me.dgControlOperaciones.AllowUserToDeleteRows = False
        Me.dgControlOperaciones.AllowUserToResizeColumns = False
        Me.dgControlOperaciones.AllowUserToResizeRows = False
        Me.dgControlOperaciones.AutoGenerateColumns = False
        Me.dgControlOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgControlOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgControlOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHK, Me.M_CCLNT, Me.M_TCMPCL, Me.M_FTRMOP, Me.M_STPODP, Me.M_CTPOAT, Me.M_NOPRSP, Me.M_QTAMOV, Me.M_QQBLTO, Me.M_QQPESO})
        Me.dgControlOperaciones.DataMember = "dtRZO090"
        Me.dgControlOperaciones.DataSource = Me.dstControlOperaciones
        Me.dgControlOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgControlOperaciones.Location = New System.Drawing.Point(0, 25)
        Me.dgControlOperaciones.MultiSelect = False
        Me.dgControlOperaciones.Name = "dgControlOperaciones"
        Me.dgControlOperaciones.ReadOnly = True
        Me.dgControlOperaciones.RowHeadersWidth = 20
        Me.dgControlOperaciones.RowTemplate.ReadOnly = True
        Me.dgControlOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgControlOperaciones.Size = New System.Drawing.Size(566, 208)
        Me.dgControlOperaciones.StandardTab = True
        Me.dgControlOperaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgControlOperaciones.TabIndex = 2
        '
        'M_CHK
        '
        Me.M_CHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.M_CHK.FalseValue = "False"
        Me.M_CHK.HeaderText = "CHK"
        Me.M_CHK.Name = "M_CHK"
        Me.M_CHK.ReadOnly = True
        Me.M_CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.M_CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.M_CHK.TrueValue = "True"
        Me.M_CHK.Width = 40
        '
        'M_CCLNT
        '
        Me.M_CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CCLNT.DataPropertyName = "CCLNT"
        Me.M_CCLNT.HeaderText = "Cliente"
        Me.M_CCLNT.Name = "M_CCLNT"
        Me.M_CCLNT.ReadOnly = True
        Me.M_CCLNT.Width = 68
        '
        'M_TCMPCL
        '
        Me.M_TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCMPCL.DataPropertyName = "TCMPCL"
        Me.M_TCMPCL.HeaderText = "Razón Social"
        Me.M_TCMPCL.Name = "M_TCMPCL"
        Me.M_TCMPCL.ReadOnly = True
        Me.M_TCMPCL.Width = 99
        '
        'M_FTRMOP
        '
        Me.M_FTRMOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FTRMOP.DataPropertyName = "FTRMOP"
        Me.M_FTRMOP.HeaderText = "Fecha Cierre"
        Me.M_FTRMOP.Name = "M_FTRMOP"
        Me.M_FTRMOP.ReadOnly = True
        Me.M_FTRMOP.Visible = False
        Me.M_FTRMOP.Width = 96
        '
        'M_STPODP
        '
        Me.M_STPODP.DataPropertyName = "STPODP"
        Me.M_STPODP.HeaderText = "Tipo Almacén"
        Me.M_STPODP.Name = "M_STPODP"
        Me.M_STPODP.ReadOnly = True
        Me.M_STPODP.Visible = False
        Me.M_STPODP.Width = 101
        '
        'M_CTPOAT
        '
        Me.M_CTPOAT.DataPropertyName = "CTPOAT"
        Me.M_CTPOAT.HeaderText = "Tipo Operación"
        Me.M_CTPOAT.Name = "M_CTPOAT"
        Me.M_CTPOAT.ReadOnly = True
        Me.M_CTPOAT.Visible = False
        Me.M_CTPOAT.Width = 109
        '
        'M_NOPRSP
        '
        Me.M_NOPRSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NOPRSP.DataPropertyName = "NOPRSP"
        Me.M_NOPRSP.HeaderText = "Nro. Operación"
        Me.M_NOPRSP.Name = "M_NOPRSP"
        Me.M_NOPRSP.ReadOnly = True
        Me.M_NOPRSP.Width = 108
        '
        'M_QTAMOV
        '
        Me.M_QTAMOV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QTAMOV.DataPropertyName = "QTAMOV"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N4"
        DataGridViewCellStyle1.NullValue = "0.0000"
        Me.M_QTAMOV.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_QTAMOV.HeaderText = "Movimientos"
        Me.M_QTAMOV.Name = "M_QTAMOV"
        Me.M_QTAMOV.ReadOnly = True
        Me.M_QTAMOV.Width = 95
        '
        'M_QQBLTO
        '
        Me.M_QQBLTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QQBLTO.DataPropertyName = "QQBLTO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = "0.0000"
        Me.M_QQBLTO.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QQBLTO.HeaderText = "Cant. Bultos"
        Me.M_QQBLTO.Name = "M_QQBLTO"
        Me.M_QQBLTO.ReadOnly = True
        Me.M_QQBLTO.Width = 93
        '
        'M_QQPESO
        '
        Me.M_QQPESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QQPESO.DataPropertyName = "QQPESO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0.0000"
        Me.M_QQPESO.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QQPESO.HeaderText = "Cant. Peso"
        Me.M_QQPESO.Name = "M_QQPESO"
        Me.M_QQPESO.ReadOnly = True
        Me.M_QQPESO.Width = 88
        '
        'ucControlOperacion_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgControlOperaciones)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucControlOperacion_DgF01"
        Me.Size = New System.Drawing.Size(566, 233)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dstControlOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRZO090, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgControlOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblControlOperaciones As System.Windows.Forms.ToolStripLabel
    Private WithEvents dgControlOperaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents btnAbrirOperacion As System.Windows.Forms.ToolStripButton
    Private WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnCerrarOperacion As System.Windows.Forms.ToolStripButton
    Private WithEvents dstControlOperaciones As System.Data.DataSet
    Private WithEvents dtRZO090 As System.Data.DataTable
    Private WithEvents CCLNT As System.Data.DataColumn
    Private WithEvents TCMPCL As System.Data.DataColumn
    Private WithEvents FTRMOP As System.Data.DataColumn
    Private WithEvents STPODP As System.Data.DataColumn
    Private WithEvents CTPOAT As System.Data.DataColumn
    Private WithEvents NOPRSP As System.Data.DataColumn
    Private WithEvents QTAMOV As System.Data.DataColumn
    Private WithEvents QQBLTO As System.Data.DataColumn
    Private WithEvents QQPESO As System.Data.DataColumn
    Private WithEvents M_CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents M_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_FTRMOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_STPODP As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_NOPRSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_QTAMOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_QQBLTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents M_QQPESO As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
