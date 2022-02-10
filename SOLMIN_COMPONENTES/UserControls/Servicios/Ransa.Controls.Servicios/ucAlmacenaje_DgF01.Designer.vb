<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAlmacenaje_DgF01
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAlmacenaje_DgF01))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.dstAlmacenaje = New System.Data.DataSet
        Me.RZSC32 = New System.Data.DataTable
        Me.NPRALM = New System.Data.DataColumn
        Me.CCMPN = New System.Data.DataColumn
        Me.CDVSN = New System.Data.DataColumn
        Me.CPLNDV = New System.Data.DataColumn
        Me.STPODP = New System.Data.DataColumn
        Me.NANPRC = New System.Data.DataColumn
        Me.NMES = New System.Data.DataColumn
        Me.FECINI = New System.Data.DataColumn
        Me.FECFIN = New System.Data.DataColumn
        Me.OBSERV = New System.Data.DataColumn
        Me.NDIALI = New System.Data.DataColumn
        Me.STPOFC = New System.Data.DataColumn
        Me.TQAROC = New System.Data.DataColumn
        Me.TQPSOB = New System.Data.DataColumn
        Me.TQVLBT = New System.Data.DataColumn
        Me.TNDPER = New System.Data.DataColumn
        Me.TNDAFA = New System.Data.DataColumn
        Me.NOPRCN = New System.Data.DataColumn
        Me.NRTFSV = New System.Data.DataColumn
        Me.QCNESP = New System.Data.DataColumn
        Me.TUNDIT = New System.Data.DataColumn
        Me.STPOUN = New System.Data.DataColumn
        Me.CMNDA1 = New System.Data.DataColumn
        Me.NMONOC = New System.Data.DataColumn
        Me.VALUNI = New System.Data.DataColumn
        Me.IMPFACT = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.dgAlmacenaje = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NPRALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STPODP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NANPRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NMES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_OBSERV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NDIALI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STPOFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TQAROC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TQPSOB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TQVLBT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TNDPER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TNDAFA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRTFSV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNESP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_STPOUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NMONOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_VALUNI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IMPFACT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblAlmacenaje = New System.Windows.Forms.ToolStripLabel
        Me.btnTransferir = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnVistaPrevia = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        CType(Me.dstAlmacenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RZSC32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAlmacenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dstAlmacenaje
        '
        Me.dstAlmacenaje.DataSetName = "dstAlmacenaje"
        Me.dstAlmacenaje.Tables.AddRange(New System.Data.DataTable() {Me.RZSC32})
        '
        'RZSC32
        '
        Me.RZSC32.Columns.AddRange(New System.Data.DataColumn() {Me.NPRALM, Me.CCMPN, Me.CDVSN, Me.CPLNDV, Me.STPODP, Me.NANPRC, Me.NMES, Me.FECINI, Me.FECFIN, Me.OBSERV, Me.NDIALI, Me.STPOFC, Me.TQAROC, Me.TQPSOB, Me.TQVLBT, Me.TNDPER, Me.TNDAFA, Me.NOPRCN, Me.NRTFSV, Me.QCNESP, Me.TUNDIT, Me.STPOUN, Me.CMNDA1, Me.NMONOC, Me.VALUNI, Me.IMPFACT, Me.SESTRG})
        Me.RZSC32.TableName = "RZSC32"
        '
        'NPRALM
        '
        Me.NPRALM.ColumnName = "NPRALM"
        Me.NPRALM.DataType = GetType(Long)
        Me.NPRALM.DefaultValue = CType(0, Long)
        '
        'CCMPN
        '
        Me.CCMPN.ColumnName = "CCMPN"
        Me.CCMPN.DefaultValue = ""
        '
        'CDVSN
        '
        Me.CDVSN.ColumnName = "CDVSN"
        Me.CDVSN.DefaultValue = ""
        '
        'CPLNDV
        '
        Me.CPLNDV.ColumnName = "CPLNDV"
        Me.CPLNDV.DataType = GetType(Integer)
        Me.CPLNDV.DefaultValue = 0
        '
        'STPODP
        '
        Me.STPODP.ColumnName = "STPODP"
        Me.STPODP.DefaultValue = ""
        '
        'NANPRC
        '
        Me.NANPRC.ColumnName = "NANPRC"
        Me.NANPRC.DataType = GetType(Integer)
        Me.NANPRC.DefaultValue = 0
        '
        'NMES
        '
        Me.NMES.ColumnName = "NMES"
        Me.NMES.DataType = GetType(Integer)
        Me.NMES.DefaultValue = 0
        '
        'FECINI
        '
        Me.FECINI.ColumnName = "FECINI"
        Me.FECINI.DataType = GetType(Date)
        '
        'FECFIN
        '
        Me.FECFIN.ColumnName = "FECFIN"
        Me.FECFIN.DataType = GetType(Date)
        '
        'OBSERV
        '
        Me.OBSERV.ColumnName = "OBSERV"
        Me.OBSERV.DefaultValue = ""
        '
        'NDIALI
        '
        Me.NDIALI.ColumnName = "NDIALI"
        Me.NDIALI.DataType = GetType(Decimal)
        Me.NDIALI.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'STPOFC
        '
        Me.STPOFC.ColumnName = "STPOFC"
        Me.STPOFC.DefaultValue = ""
        '
        'TQAROC
        '
        Me.TQAROC.ColumnName = "TQAROC"
        Me.TQAROC.DataType = GetType(Decimal)
        Me.TQAROC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'TQPSOB
        '
        Me.TQPSOB.ColumnName = "TQPSOB"
        Me.TQPSOB.DataType = GetType(Decimal)
        Me.TQPSOB.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'TQVLBT
        '
        Me.TQVLBT.ColumnName = "TQVLBT"
        Me.TQVLBT.DataType = GetType(Decimal)
        Me.TQVLBT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'TNDPER
        '
        Me.TNDPER.ColumnName = "TNDPER"
        Me.TNDPER.DataType = GetType(Decimal)
        Me.TNDPER.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TNDAFA
        '
        Me.TNDAFA.ColumnName = "TNDAFA"
        Me.TNDAFA.DataType = GetType(Decimal)
        Me.TNDAFA.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'NOPRCN
        '
        Me.NOPRCN.ColumnName = "NOPRCN"
        Me.NOPRCN.DataType = GetType(Long)
        Me.NOPRCN.DefaultValue = CType(0, Long)
        '
        'NRTFSV
        '
        Me.NRTFSV.ColumnName = "NRTFSV"
        Me.NRTFSV.DataType = GetType(Long)
        Me.NRTFSV.DefaultValue = CType(0, Long)
        '
        'QCNESP
        '
        Me.QCNESP.ColumnName = "QCNESP"
        Me.QCNESP.DataType = GetType(Decimal)
        Me.QCNESP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNDIT
        '
        Me.TUNDIT.ColumnName = "TUNDIT"
        Me.TUNDIT.DefaultValue = ""
        '
        'STPOUN
        '
        Me.STPOUN.ColumnName = "STPOUN"
        Me.STPOUN.DefaultValue = ""
        '
        'CMNDA1
        '
        Me.CMNDA1.ColumnName = "CMNDA1"
        Me.CMNDA1.DataType = GetType(Integer)
        Me.CMNDA1.DefaultValue = 0
        '
        'NMONOC
        '
        Me.NMONOC.ColumnName = "NMONOC"
        Me.NMONOC.DefaultValue = ""
        '
        'VALUNI
        '
        Me.VALUNI.ColumnName = "VALUNI"
        Me.VALUNI.DataType = GetType(Decimal)
        Me.VALUNI.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'IMPFACT
        '
        Me.IMPFACT.ColumnName = "IMPFACT"
        Me.IMPFACT.DataType = GetType(Decimal)
        Me.IMPFACT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'dgAlmacenaje
        '
        Me.dgAlmacenaje.AllowUserToAddRows = False
        Me.dgAlmacenaje.AllowUserToDeleteRows = False
        Me.dgAlmacenaje.AllowUserToResizeColumns = False
        Me.dgAlmacenaje.AllowUserToResizeRows = False
        Me.dgAlmacenaje.AutoGenerateColumns = False
        Me.dgAlmacenaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgAlmacenaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgAlmacenaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NPRALM, Me.M_CCMPN, Me.M_CDVSN, Me.M_CPLNDV, Me.M_STPODP, Me.M_NANPRC, Me.M_NMES, Me.M_FECINI, Me.M_FECFIN, Me.M_OBSERV, Me.M_NDIALI, Me.M_STPOFC, Me.M_TQAROC, Me.M_TQPSOB, Me.M_TQVLBT, Me.M_TNDPER, Me.M_TNDAFA, Me.M_NOPRCN, Me.M_NRTFSV, Me.M_QCNESP, Me.M_TUNDIT, Me.M_STPOUN, Me.M_CMNDA1, Me.M_NMONOC, Me.M_VALUNI, Me.M_IMPFACT, Me.M_SESTRG})
        Me.dgAlmacenaje.DataMember = "RZSC32"
        Me.dgAlmacenaje.DataSource = Me.dstAlmacenaje
        Me.dgAlmacenaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAlmacenaje.Location = New System.Drawing.Point(0, 25)
        Me.dgAlmacenaje.MultiSelect = False
        Me.dgAlmacenaje.Name = "dgAlmacenaje"
        Me.dgAlmacenaje.ReadOnly = True
        Me.dgAlmacenaje.RowHeadersWidth = 20
        Me.dgAlmacenaje.RowTemplate.ReadOnly = True
        Me.dgAlmacenaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgAlmacenaje.Size = New System.Drawing.Size(589, 210)
        Me.dgAlmacenaje.StandardTab = True
        Me.dgAlmacenaje.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgAlmacenaje.TabIndex = 26
        '
        'M_NPRALM
        '
        Me.M_NPRALM.DataPropertyName = "NPRALM"
        Me.M_NPRALM.HeaderText = "Operación"
        Me.M_NPRALM.Name = "M_NPRALM"
        Me.M_NPRALM.ReadOnly = True
        Me.M_NPRALM.Width = 85
        '
        'M_CCMPN
        '
        Me.M_CCMPN.DataPropertyName = "CCMPN"
        Me.M_CCMPN.HeaderText = "Compañía"
        Me.M_CCMPN.Name = "M_CCMPN"
        Me.M_CCMPN.ReadOnly = True
        Me.M_CCMPN.Visible = False
        Me.M_CCMPN.Width = 85
        '
        'M_CDVSN
        '
        Me.M_CDVSN.DataPropertyName = "CDVSN"
        Me.M_CDVSN.HeaderText = "División"
        Me.M_CDVSN.Name = "M_CDVSN"
        Me.M_CDVSN.ReadOnly = True
        Me.M_CDVSN.Visible = False
        Me.M_CDVSN.Width = 73
        '
        'M_CPLNDV
        '
        Me.M_CPLNDV.DataPropertyName = "CPLNDV"
        Me.M_CPLNDV.HeaderText = "Planta"
        Me.M_CPLNDV.Name = "M_CPLNDV"
        Me.M_CPLNDV.ReadOnly = True
        Me.M_CPLNDV.Visible = False
        Me.M_CPLNDV.Width = 66
        '
        'M_STPODP
        '
        Me.M_STPODP.DataPropertyName = "STPODP"
        Me.M_STPODP.HeaderText = "Almacén"
        Me.M_STPODP.Name = "M_STPODP"
        Me.M_STPODP.ReadOnly = True
        Me.M_STPODP.Visible = False
        Me.M_STPODP.Width = 77
        '
        'M_NANPRC
        '
        Me.M_NANPRC.DataPropertyName = "NANPRC"
        Me.M_NANPRC.HeaderText = "Año"
        Me.M_NANPRC.Name = "M_NANPRC"
        Me.M_NANPRC.ReadOnly = True
        Me.M_NANPRC.Width = 55
        '
        'M_NMES
        '
        Me.M_NMES.DataPropertyName = "NMES"
        Me.M_NMES.HeaderText = "Mes"
        Me.M_NMES.Name = "M_NMES"
        Me.M_NMES.ReadOnly = True
        Me.M_NMES.Width = 56
        '
        'M_FECINI
        '
        Me.M_FECINI.DataPropertyName = "FECINI"
        DataGridViewCellStyle1.Format = "d"
        Me.M_FECINI.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_FECINI.HeaderText = "Fch. Inic. Proc."
        Me.M_FECINI.Name = "M_FECINI"
        Me.M_FECINI.ReadOnly = True
        Me.M_FECINI.Width = 108
        '
        'M_FECFIN
        '
        Me.M_FECFIN.DataPropertyName = "FECFIN"
        DataGridViewCellStyle2.Format = "d"
        Me.M_FECFIN.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_FECFIN.HeaderText = "Fch. Fin. Proc."
        Me.M_FECFIN.Name = "M_FECFIN"
        Me.M_FECFIN.ReadOnly = True
        Me.M_FECFIN.Width = 105
        '
        'M_OBSERV
        '
        Me.M_OBSERV.DataPropertyName = "OBSERV"
        Me.M_OBSERV.HeaderText = "Observación"
        Me.M_OBSERV.Name = "M_OBSERV"
        Me.M_OBSERV.ReadOnly = True
        Me.M_OBSERV.Width = 96
        '
        'M_NDIALI
        '
        Me.M_NDIALI.DataPropertyName = "NDIALI"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.M_NDIALI.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_NDIALI.HeaderText = "Días Libres"
        Me.M_NDIALI.Name = "M_NDIALI"
        Me.M_NDIALI.ReadOnly = True
        Me.M_NDIALI.Width = 90
        '
        'M_STPOFC
        '
        Me.M_STPOFC.DataPropertyName = "STPOFC"
        Me.M_STPOFC.HeaderText = "Status"
        Me.M_STPOFC.Name = "M_STPOFC"
        Me.M_STPOFC.ReadOnly = True
        Me.M_STPOFC.Width = 66
        '
        'M_TQAROC
        '
        Me.M_TQAROC.DataPropertyName = "TQAROC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = "0.0000"
        Me.M_TQAROC.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_TQAROC.HeaderText = "Tot. Área"
        Me.M_TQAROC.Name = "M_TQAROC"
        Me.M_TQAROC.ReadOnly = True
        Me.M_TQAROC.Width = 80
        '
        'M_TQPSOB
        '
        Me.M_TQPSOB.DataPropertyName = "TQPSOB"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = "0.0000"
        Me.M_TQPSOB.DefaultCellStyle = DataGridViewCellStyle5
        Me.M_TQPSOB.HeaderText = "Tot. Peso"
        Me.M_TQPSOB.Name = "M_TQPSOB"
        Me.M_TQPSOB.ReadOnly = True
        Me.M_TQPSOB.Width = 82
        '
        'M_TQVLBT
        '
        Me.M_TQVLBT.DataPropertyName = "TQVLBT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = "0.0000"
        Me.M_TQVLBT.DefaultCellStyle = DataGridViewCellStyle6
        Me.M_TQVLBT.HeaderText = "Tot. Volumen"
        Me.M_TQVLBT.Name = "M_TQVLBT"
        Me.M_TQVLBT.ReadOnly = True
        Me.M_TQVLBT.Width = 99
        '
        'M_TNDPER
        '
        Me.M_TNDPER.DataPropertyName = "TNDPER"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.M_TNDPER.DefaultCellStyle = DataGridViewCellStyle7
        Me.M_TNDPER.HeaderText = "Permanencia"
        Me.M_TNDPER.Name = "M_TNDPER"
        Me.M_TNDPER.ReadOnly = True
        Me.M_TNDPER.Width = 98
        '
        'M_TNDAFA
        '
        Me.M_TNDAFA.DataPropertyName = "TNDAFA"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.M_TNDAFA.DefaultCellStyle = DataGridViewCellStyle8
        Me.M_TNDAFA.HeaderText = "Días a Fact."
        Me.M_TNDAFA.Name = "M_TNDAFA"
        Me.M_TNDAFA.ReadOnly = True
        Me.M_TNDAFA.Width = 95
        '
        'M_NOPRCN
        '
        Me.M_NOPRCN.DataPropertyName = "NOPRCN"
        Me.M_NOPRCN.HeaderText = "Oper. Servicio"
        Me.M_NOPRCN.Name = "M_NOPRCN"
        Me.M_NOPRCN.ReadOnly = True
        Me.M_NOPRCN.Width = 103
        '
        'M_NRTFSV
        '
        Me.M_NRTFSV.DataPropertyName = "NRTFSV"
        Me.M_NRTFSV.HeaderText = "Tarifa"
        Me.M_NRTFSV.Name = "M_NRTFSV"
        Me.M_NRTFSV.ReadOnly = True
        Me.M_NRTFSV.Width = 63
        '
        'M_QCNESP
        '
        Me.M_QCNESP.DataPropertyName = "QCNESP"
        Me.M_QCNESP.HeaderText = "Cant. Base"
        Me.M_QCNESP.Name = "M_QCNESP"
        Me.M_QCNESP.ReadOnly = True
        Me.M_QCNESP.Visible = False
        Me.M_QCNESP.Width = 88
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.DataPropertyName = "TUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Visible = False
        Me.M_TUNDIT.Width = 70
        '
        'M_STPOUN
        '
        Me.M_STPOUN.DataPropertyName = "STPOUN"
        Me.M_STPOUN.HeaderText = "St. Unid."
        Me.M_STPOUN.Name = "M_STPOUN"
        Me.M_STPOUN.ReadOnly = True
        Me.M_STPOUN.Width = 77
        '
        'M_CMNDA1
        '
        Me.M_CMNDA1.DataPropertyName = "CMNDA1"
        Me.M_CMNDA1.HeaderText = "Moneda"
        Me.M_CMNDA1.Name = "M_CMNDA1"
        Me.M_CMNDA1.ReadOnly = True
        Me.M_CMNDA1.Visible = False
        Me.M_CMNDA1.Width = 75
        '
        'M_NMONOC
        '
        Me.M_NMONOC.DataPropertyName = "NMONOC"
        Me.M_NMONOC.HeaderText = "Moneda"
        Me.M_NMONOC.Name = "M_NMONOC"
        Me.M_NMONOC.ReadOnly = True
        Me.M_NMONOC.Width = 75
        '
        'M_VALUNI
        '
        Me.M_VALUNI.DataPropertyName = "VALUNI"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N4"
        DataGridViewCellStyle9.NullValue = "0.0000"
        Me.M_VALUNI.DefaultCellStyle = DataGridViewCellStyle9
        Me.M_VALUNI.HeaderText = "Valor Ref. Unit."
        Me.M_VALUNI.Name = "M_VALUNI"
        Me.M_VALUNI.ReadOnly = True
        Me.M_VALUNI.Width = 108
        '
        'M_IMPFACT
        '
        Me.M_IMPFACT.DataPropertyName = "IMPFACT"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N4"
        DataGridViewCellStyle10.NullValue = "0.0000"
        Me.M_IMPFACT.DefaultCellStyle = DataGridViewCellStyle10
        Me.M_IMPFACT.HeaderText = "Imp. a Fact."
        Me.M_IMPFACT.Name = "M_IMPFACT"
        Me.M_IMPFACT.ReadOnly = True
        Me.M_IMPFACT.Width = 92
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 80
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblAlmacenaje, Me.btnTransferir, Me.tssSeparador03, Me.btnVistaPrevia, Me.tssSeparador02, Me.btnEliminar, Me.tssSeparador01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(589, 25)
        Me.tsMenuOpciones.TabIndex = 27
        '
        'lblAlmacenaje
        '
        Me.lblAlmacenaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacenaje.Name = "lblAlmacenaje"
        Me.lblAlmacenaje.Size = New System.Drawing.Size(87, 22)
        Me.lblAlmacenaje.Text = "ALMACENAJE"
        '
        'btnTransferir
        '
        Me.btnTransferir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnTransferir.Image = CType(resources.GetObject("btnTransferir.Image"), System.Drawing.Image)
        Me.btnTransferir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Size = New System.Drawing.Size(92, 22)
        Me.btnTransferir.Text = "&Transferencia"
        '
        'tssSeparador03
        '
        Me.tssSeparador03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador03.Name = "tssSeparador03"
        Me.tssSeparador03.Size = New System.Drawing.Size(6, 25)
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnVistaPrevia.Image = CType(resources.GetObject("btnVistaPrevia.Image"), System.Drawing.Image)
        Me.btnVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(82, 22)
        Me.btnVistaPrevia.Text = "&Vista previa"
        '
        'tssSeparador02
        '
        Me.tssSeparador02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador02.Name = "tssSeparador02"
        Me.tssSeparador02.Size = New System.Drawing.Size(6, 25)
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
        'tssSeparador01
        '
        Me.tssSeparador01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador01.Name = "tssSeparador01"
        Me.tssSeparador01.Size = New System.Drawing.Size(6, 25)
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
        'ucAlmacenaje_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgAlmacenaje)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucAlmacenaje_DgF01"
        Me.Size = New System.Drawing.Size(589, 235)
        CType(Me.dstAlmacenaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RZSC32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAlmacenaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents dstAlmacenaje As System.Data.DataSet
    Friend WithEvents RZSC32 As System.Data.DataTable
    Private WithEvents dgAlmacenaje As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblAlmacenaje As System.Windows.Forms.ToolStripLabel
    Private WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador02 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnTransferir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador03 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnVistaPrevia As System.Windows.Forms.ToolStripButton
    Friend WithEvents NPRALM As System.Data.DataColumn
    Friend WithEvents CCMPN As System.Data.DataColumn
    Friend WithEvents CDVSN As System.Data.DataColumn
    Friend WithEvents CPLNDV As System.Data.DataColumn
    Friend WithEvents STPODP As System.Data.DataColumn
    Friend WithEvents NANPRC As System.Data.DataColumn
    Friend WithEvents NMES As System.Data.DataColumn
    Friend WithEvents FECINI As System.Data.DataColumn
    Friend WithEvents FECFIN As System.Data.DataColumn
    Friend WithEvents OBSERV As System.Data.DataColumn
    Friend WithEvents NDIALI As System.Data.DataColumn
    Friend WithEvents STPOFC As System.Data.DataColumn
    Friend WithEvents TQAROC As System.Data.DataColumn
    Friend WithEvents TQPSOB As System.Data.DataColumn
    Friend WithEvents TQVLBT As System.Data.DataColumn
    Friend WithEvents TNDPER As System.Data.DataColumn
    Friend WithEvents TNDAFA As System.Data.DataColumn
    Friend WithEvents NOPRCN As System.Data.DataColumn
    Friend WithEvents NRTFSV As System.Data.DataColumn
    Friend WithEvents QCNESP As System.Data.DataColumn
    Friend WithEvents TUNDIT As System.Data.DataColumn
    Friend WithEvents STPOUN As System.Data.DataColumn
    Friend WithEvents CMNDA1 As System.Data.DataColumn
    Friend WithEvents NMONOC As System.Data.DataColumn
    Friend WithEvents VALUNI As System.Data.DataColumn
    Friend WithEvents IMPFACT As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Friend WithEvents M_NPRALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_STPODP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NANPRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NMES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_OBSERV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NDIALI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_STPOFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TQAROC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TQPSOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TQVLBT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TNDPER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TNDAFA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRTFSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNESP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_STPOUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NMONOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_VALUNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IMPFACT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
