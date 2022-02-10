<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOrdenServicios_DgF01
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.dstOrdenServicio = New System.Data.DataSet
        Me.dtOrdenServicio = New System.Data.DataTable
        Me.NORDSR = New System.Data.DataColumn
        Me.NCNTR = New System.Data.DataColumn
        Me.NCRCTC = New System.Data.DataColumn
        Me.NAUTR = New System.Data.DataColumn
        Me.FEMORS = New System.Data.DataColumn
        Me.CTPDP6 = New System.Data.DataColumn
        Me.QMRCD1 = New System.Data.DataColumn
        Me.QPSMR1 = New System.Data.DataColumn
        Me.QVLMR1 = New System.Data.DataColumn
        Me.FUNDS2 = New System.Data.DataColumn
        Me.FUNCTL = New System.Data.DataColumn
        Me.QSLMC = New System.Data.DataColumn
        Me.CUNCN5 = New System.Data.DataColumn
        Me.QSLMP = New System.Data.DataColumn
        Me.CUNPS5 = New System.Data.DataColumn
        Me.QSLMV = New System.Data.DataColumn
        Me.CUNVL5 = New System.Data.DataColumn
        Me.dgListaOrdenesServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FEMORS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPDP6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QMRCD1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QPSMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QVLMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FUNCTL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QSLMV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOS = New System.Windows.Forms.ToolStrip
        Me.lblTituloSolOS = New System.Windows.Forms.ToolStripLabel
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'dstOrdenServicio
        '
        Me.dstOrdenServicio.DataSetName = "NewDataSet"
        Me.dstOrdenServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenServicio})
        '
        'dtOrdenServicio
        '
        Me.dtOrdenServicio.Columns.AddRange(New System.Data.DataColumn() {Me.NORDSR, Me.NCNTR, Me.NCRCTC, Me.NAUTR, Me.FEMORS, Me.CTPDP6, Me.QMRCD1, Me.QPSMR1, Me.QVLMR1, Me.FUNDS2, Me.FUNCTL, Me.QSLMC, Me.CUNCN5, Me.QSLMP, Me.CUNPS5, Me.QSLMV, Me.CUNVL5})
        Me.dtOrdenServicio.TableName = "dtOrdenServicio"
        '
        'NORDSR
        '
        Me.NORDSR.ColumnName = "NORDSR"
        Me.NORDSR.DataType = GetType(Long)
        Me.NORDSR.DefaultValue = CType(0, Long)
        '
        'NCNTR
        '
        Me.NCNTR.ColumnName = "NCNTR"
        Me.NCNTR.DataType = GetType(Long)
        Me.NCNTR.DefaultValue = CType(0, Long)
        '
        'NCRCTC
        '
        Me.NCRCTC.ColumnName = "NCRCTC"
        Me.NCRCTC.DataType = GetType(Integer)
        Me.NCRCTC.DefaultValue = 0
        '
        'NAUTR
        '
        Me.NAUTR.ColumnName = "NAUTR"
        Me.NAUTR.DataType = GetType(Long)
        Me.NAUTR.DefaultValue = CType(0, Long)
        '
        'FEMORS
        '
        Me.FEMORS.ColumnName = "FEMORS"
        Me.FEMORS.DataType = GetType(Date)
        '
        'CTPDP6
        '
        Me.CTPDP6.ColumnName = "CTPDP6"
        Me.CTPDP6.DefaultValue = ""
        '
        'QMRCD1
        '
        Me.QMRCD1.ColumnName = "QMRCD1"
        Me.QMRCD1.DataType = GetType(Decimal)
        Me.QMRCD1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'QPSMR1
        '
        Me.QPSMR1.ColumnName = "QPSMR1"
        Me.QPSMR1.DataType = GetType(Decimal)
        Me.QPSMR1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'QVLMR1
        '
        Me.QVLMR1.ColumnName = "QVLMR1"
        Me.QVLMR1.DataType = GetType(Decimal)
        Me.QVLMR1.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'FUNDS2
        '
        Me.FUNDS2.ColumnName = "FUNDS2"
        Me.FUNDS2.DefaultValue = ""
        '
        'FUNCTL
        '
        Me.FUNCTL.ColumnName = "FUNCTL"
        Me.FUNCTL.DefaultValue = ""
        '
        'QSLMC
        '
        Me.QSLMC.ColumnName = "QSLMC"
        Me.QSLMC.DataType = GetType(Decimal)
        Me.QSLMC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'CUNCN5
        '
        Me.CUNCN5.ColumnName = "CUNCN5"
        Me.CUNCN5.DefaultValue = ""
        '
        'QSLMP
        '
        Me.QSLMP.ColumnName = "QSLMP"
        Me.QSLMP.DataType = GetType(Decimal)
        Me.QSLMP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'CUNPS5
        '
        Me.CUNPS5.ColumnName = "CUNPS5"
        Me.CUNPS5.DefaultValue = ""
        '
        'QSLMV
        '
        Me.QSLMV.ColumnName = "QSLMV"
        Me.QSLMV.DataType = GetType(Decimal)
        Me.QSLMV.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'CUNVL5
        '
        Me.CUNVL5.ColumnName = "CUNVL5"
        '
        'dgListaOrdenesServicio
        '
        Me.dgListaOrdenesServicio.AllowUserToAddRows = False
        Me.dgListaOrdenesServicio.AllowUserToDeleteRows = False
        Me.dgListaOrdenesServicio.AllowUserToResizeColumns = False
        Me.dgListaOrdenesServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgListaOrdenesServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgListaOrdenesServicio.AutoGenerateColumns = False
        Me.dgListaOrdenesServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgListaOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NORDSR, Me.M_NCNTR, Me.M_NCRCTC, Me.M_NAUTR, Me.M_FEMORS, Me.M_CTPDP6, Me.M_QMRCD1, Me.M_QPSMR1, Me.M_QVLMR1, Me.M_FUNDS2, Me.M_FUNCTL, Me.M_QSLMC, Me.M_CUNCN5, Me.M_QSLMP, Me.M_CUNPS5, Me.M_QSLMV, Me.M_CUNVL5})
        Me.dgListaOrdenesServicio.DataMember = "dtOrdenServicio"
        Me.dgListaOrdenesServicio.DataSource = Me.dstOrdenServicio
        Me.dgListaOrdenesServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaOrdenesServicio.Location = New System.Drawing.Point(0, 25)
        Me.dgListaOrdenesServicio.MultiSelect = False
        Me.dgListaOrdenesServicio.Name = "dgListaOrdenesServicio"
        Me.dgListaOrdenesServicio.ReadOnly = True
        Me.dgListaOrdenesServicio.RowHeadersWidth = 20
        Me.dgListaOrdenesServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaOrdenesServicio.Size = New System.Drawing.Size(509, 137)
        Me.dgListaOrdenesServicio.StandardTab = True
        Me.dgListaOrdenesServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgListaOrdenesServicio.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgListaOrdenesServicio.TabIndex = 53
        '
        'M_NORDSR
        '
        Me.M_NORDSR.DataPropertyName = "NORDSR"
        Me.M_NORDSR.HeaderText = "Nro. O/S"
        Me.M_NORDSR.Name = "M_NORDSR"
        Me.M_NORDSR.ReadOnly = True
        Me.M_NORDSR.Width = 79
        '
        'M_NCNTR
        '
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Width = 76
        '
        'M_NCRCTC
        '
        Me.M_NCRCTC.DataPropertyName = "NCRCTC"
        Me.M_NCRCTC.HeaderText = "Corr. Contrato"
        Me.M_NCRCTC.Name = "M_NCRCTC"
        Me.M_NCRCTC.ReadOnly = True
        Me.M_NCRCTC.Visible = False
        Me.M_NCRCTC.Width = 101
        '
        'M_NAUTR
        '
        Me.M_NAUTR.DataPropertyName = "NAUTR"
        Me.M_NAUTR.HeaderText = "Autorización"
        Me.M_NAUTR.Name = "M_NAUTR"
        Me.M_NAUTR.ReadOnly = True
        Me.M_NAUTR.Visible = False
        Me.M_NAUTR.Width = 94
        '
        'M_FEMORS
        '
        Me.M_FEMORS.DataPropertyName = "FEMORS"
        DataGridViewCellStyle2.Format = "d"
        Me.M_FEMORS.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_FEMORS.HeaderText = "Fecha"
        Me.M_FEMORS.Name = "M_FEMORS"
        Me.M_FEMORS.ReadOnly = True
        Me.M_FEMORS.Width = 66
        '
        'M_CTPDP6
        '
        Me.M_CTPDP6.DataPropertyName = "CTPDP6"
        Me.M_CTPDP6.HeaderText = "Tipo Depósito"
        Me.M_CTPDP6.Name = "M_CTPDP6"
        Me.M_CTPDP6.ReadOnly = True
        Me.M_CTPDP6.Visible = False
        Me.M_CTPDP6.Width = 102
        '
        'M_QMRCD1
        '
        Me.M_QMRCD1.DataPropertyName = "QMRCD1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0.0000"
        Me.M_QMRCD1.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QMRCD1.HeaderText = "Cant. Declarada"
        Me.M_QMRCD1.Name = "M_QMRCD1"
        Me.M_QMRCD1.ReadOnly = True
        Me.M_QMRCD1.Visible = False
        Me.M_QMRCD1.Width = 113
        '
        'M_QPSMR1
        '
        Me.M_QPSMR1.DataPropertyName = "QPSMR1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = "0.0000"
        Me.M_QPSMR1.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_QPSMR1.HeaderText = "Peso Declarado"
        Me.M_QPSMR1.Name = "M_QPSMR1"
        Me.M_QPSMR1.ReadOnly = True
        Me.M_QPSMR1.Visible = False
        Me.M_QPSMR1.Width = 112
        '
        'M_QVLMR1
        '
        Me.M_QVLMR1.DataPropertyName = "QVLMR1"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N4"
        DataGridViewCellStyle5.NullValue = "0.0000"
        Me.M_QVLMR1.DefaultCellStyle = DataGridViewCellStyle5
        Me.M_QVLMR1.HeaderText = "Valor Declarado"
        Me.M_QVLMR1.Name = "M_QVLMR1"
        Me.M_QVLMR1.ReadOnly = True
        Me.M_QVLMR1.Visible = False
        Me.M_QVLMR1.Width = 112
        '
        'M_FUNDS2
        '
        Me.M_FUNDS2.DataPropertyName = "FUNDS2"
        Me.M_FUNDS2.HeaderText = "Unidad Despacho"
        Me.M_FUNDS2.Name = "M_FUNDS2"
        Me.M_FUNDS2.ReadOnly = True
        Me.M_FUNDS2.Width = 122
        '
        'M_FUNCTL
        '
        Me.M_FUNCTL.DataPropertyName = "FUNCTL"
        Me.M_FUNCTL.HeaderText = "Control Lote"
        Me.M_FUNCTL.Name = "M_FUNCTL"
        Me.M_FUNCTL.ReadOnly = True
        Me.M_FUNCTL.Width = 93
        '
        'M_QSLMC
        '
        Me.M_QSLMC.DataPropertyName = "QSLMC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N4"
        DataGridViewCellStyle6.NullValue = "0.0000"
        Me.M_QSLMC.DefaultCellStyle = DataGridViewCellStyle6
        Me.M_QSLMC.HeaderText = "Saldo Cantidad"
        Me.M_QSLMC.Name = "M_QSLMC"
        Me.M_QSLMC.ReadOnly = True
        Me.M_QSLMC.Width = 108
        '
        'M_CUNCN5
        '
        Me.M_CUNCN5.DataPropertyName = "CUNCN5"
        Me.M_CUNCN5.HeaderText = "Unidad Cant."
        Me.M_CUNCN5.Name = "M_CUNCN5"
        Me.M_CUNCN5.ReadOnly = True
        Me.M_CUNCN5.Width = 98
        '
        'M_QSLMP
        '
        Me.M_QSLMP.DataPropertyName = "QSLMP"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N4"
        DataGridViewCellStyle7.NullValue = "0.0000"
        Me.M_QSLMP.DefaultCellStyle = DataGridViewCellStyle7
        Me.M_QSLMP.HeaderText = "Saldo Peso"
        Me.M_QSLMP.Name = "M_QSLMP"
        Me.M_QSLMP.ReadOnly = True
        Me.M_QSLMP.Width = 90
        '
        'M_CUNPS5
        '
        Me.M_CUNPS5.DataPropertyName = "CUNPS5"
        Me.M_CUNPS5.HeaderText = "Unidad Peso"
        Me.M_CUNPS5.Name = "M_CUNPS5"
        Me.M_CUNPS5.ReadOnly = True
        Me.M_CUNPS5.Width = 97
        '
        'M_QSLMV
        '
        Me.M_QSLMV.DataPropertyName = "QSLMV"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N4"
        DataGridViewCellStyle8.NullValue = "0.0000"
        Me.M_QSLMV.DefaultCellStyle = DataGridViewCellStyle8
        Me.M_QSLMV.HeaderText = "Saldo Valor"
        Me.M_QSLMV.Name = "M_QSLMV"
        Me.M_QSLMV.ReadOnly = True
        Me.M_QSLMV.Width = 90
        '
        'M_CUNVL5
        '
        Me.M_CUNVL5.DataPropertyName = "CUNVL5"
        Me.M_CUNVL5.HeaderText = "Unidad Valor"
        Me.M_CUNVL5.Name = "M_CUNVL5"
        Me.M_CUNVL5.ReadOnly = True
        Me.M_CUNVL5.Width = 97
        '
        'tsMenuOS
        '
        Me.tsMenuOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTituloSolOS})
        Me.tsMenuOS.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOS.Name = "tsMenuOS"
        Me.tsMenuOS.Size = New System.Drawing.Size(509, 25)
        Me.tsMenuOS.TabIndex = 54
        Me.tsMenuOS.Text = "ToolStrip1"
        '
        'lblTituloSolOS
        '
        Me.lblTituloSolOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTituloSolOS.Name = "lblTituloSolOS"
        Me.lblTituloSolOS.Size = New System.Drawing.Size(141, 22)
        Me.lblTituloSolOS.Text = "Orden de Servicios"
        '
        'ucOrdenServicios_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgListaOrdenesServicio)
        Me.Controls.Add(Me.tsMenuOS)
        Me.Name = "ucOrdenServicios_DgF01"
        Me.Size = New System.Drawing.Size(509, 162)
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOS.ResumeLayout(False)
        Me.tsMenuOS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents dstOrdenServicio As System.Data.DataSet
    Friend WithEvents dtOrdenServicio As System.Data.DataTable
    Friend WithEvents dgListaOrdenesServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsMenuOS As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTituloSolOS As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NORDSR As System.Data.DataColumn
    Friend WithEvents NCNTR As System.Data.DataColumn
    Friend WithEvents NCRCTC As System.Data.DataColumn
    Friend WithEvents NAUTR As System.Data.DataColumn
    Friend WithEvents FEMORS As System.Data.DataColumn
    Friend WithEvents CTPDP6 As System.Data.DataColumn
    Friend WithEvents QMRCD1 As System.Data.DataColumn
    Friend WithEvents QPSMR1 As System.Data.DataColumn
    Friend WithEvents QVLMR1 As System.Data.DataColumn
    Friend WithEvents FUNDS2 As System.Data.DataColumn
    Friend WithEvents FUNCTL As System.Data.DataColumn
    Friend WithEvents QSLMC As System.Data.DataColumn
    Friend WithEvents CUNCN5 As System.Data.DataColumn
    Friend WithEvents QSLMP As System.Data.DataColumn
    Friend WithEvents CUNPS5 As System.Data.DataColumn
    Friend WithEvents QSLMV As System.Data.DataColumn
    Friend WithEvents CUNVL5 As System.Data.DataColumn
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FEMORS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPDP6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QMRCD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPSMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QVLMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FUNCTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QSLMV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
