<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSolicOrdenServicios_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSolicOrdenServicios_DgF01))
        Me.tsMenuOS = New System.Windows.Forms.ToolStrip
        Me.lblTituloSolicOS = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.dgListaSolicOrdenesServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FRLZSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstSolicOrdenServicio = New System.Data.DataSet
        Me.dtOrdenServicio = New System.Data.DataTable
        Me.CTPOAT = New System.Data.DataColumn
        Me.FRLZSR = New System.Data.DataColumn
        Me.NORDSR = New System.Data.DataColumn
        Me.NSLCSR = New System.Data.DataColumn
        Me.CTPALM = New System.Data.DataColumn
        Me.CALMC = New System.Data.DataColumn
        Me.CMRCD = New System.Data.DataColumn
        Me.QTRMC = New System.Data.DataColumn
        Me.CUNCN5 = New System.Data.DataColumn
        Me.QTRMP = New System.Data.DataColumn
        Me.CUNPS5 = New System.Data.DataColumn
        Me.NGUIRN = New System.Data.DataColumn
        Me.NGUICL = New System.Data.DataColumn
        Me.btnEliminarMovimiento = New System.Windows.Forms.ToolStripButton
        Me.tsMenuOS.SuspendLayout()
        CType(Me.dgListaSolicOrdenesServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstSolicOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOS
        '
        Me.tsMenuOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTituloSolicOS, Me.btnEliminarMovimiento})
        Me.tsMenuOS.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOS.Name = "tsMenuOS"
        Me.tsMenuOS.Size = New System.Drawing.Size(509, 25)
        Me.tsMenuOS.TabIndex = 55
        Me.tsMenuOS.Text = "ToolStrip1"
        '
        'lblTituloSolicOS
        '
        Me.lblTituloSolicOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTituloSolicOS.Name = "lblTituloSolicOS"
        Me.lblTituloSolicOS.Size = New System.Drawing.Size(205, 22)
        Me.lblTituloSolicOS.Text = "Solicitud Orden de Servicios"
        '
        'dgListaSolicOrdenesServicio
        '
        Me.dgListaSolicOrdenesServicio.AllowUserToAddRows = False
        Me.dgListaSolicOrdenesServicio.AllowUserToDeleteRows = False
        Me.dgListaSolicOrdenesServicio.AllowUserToResizeColumns = False
        Me.dgListaSolicOrdenesServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgListaSolicOrdenesServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgListaSolicOrdenesServicio.AutoGenerateColumns = False
        Me.dgListaSolicOrdenesServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgListaSolicOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CTPOAT, Me.M_FRLZSR, Me.M_NORDSR, Me.M_NSLCSR, Me.M_CTPALM, Me.M_CALMC, Me.M_CMRCD, Me.M_QTRMC, Me.M_CUNCN5, Me.M_QTRMP, Me.M_CUNPS5, Me.M_NGUIRN, Me.M_NGUICL})
        Me.dgListaSolicOrdenesServicio.DataMember = "dtOrdenServicio"
        Me.dgListaSolicOrdenesServicio.DataSource = Me.dstSolicOrdenServicio
        Me.dgListaSolicOrdenesServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaSolicOrdenesServicio.Location = New System.Drawing.Point(0, 25)
        Me.dgListaSolicOrdenesServicio.MultiSelect = False
        Me.dgListaSolicOrdenesServicio.Name = "dgListaSolicOrdenesServicio"
        Me.dgListaSolicOrdenesServicio.ReadOnly = True
        Me.dgListaSolicOrdenesServicio.RowHeadersWidth = 20
        Me.dgListaSolicOrdenesServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaSolicOrdenesServicio.Size = New System.Drawing.Size(509, 137)
        Me.dgListaSolicOrdenesServicio.StandardTab = True
        Me.dgListaSolicOrdenesServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgListaSolicOrdenesServicio.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgListaSolicOrdenesServicio.TabIndex = 56
        '
        'M_CTPOAT
        '
        Me.M_CTPOAT.DataPropertyName = "CTPOAT"
        Me.M_CTPOAT.HeaderText = "Tipo Mov."
        Me.M_CTPOAT.Name = "M_CTPOAT"
        Me.M_CTPOAT.ReadOnly = True
        Me.M_CTPOAT.Width = 84
        '
        'M_FRLZSR
        '
        Me.M_FRLZSR.DataPropertyName = "FRLZSR"
        Me.M_FRLZSR.HeaderText = "Fecha"
        Me.M_FRLZSR.Name = "M_FRLZSR"
        Me.M_FRLZSR.ReadOnly = True
        Me.M_FRLZSR.Width = 66
        '
        'M_NORDSR
        '
        Me.M_NORDSR.DataPropertyName = "NORDSR"
        Me.M_NORDSR.HeaderText = "Nro. O/S"
        Me.M_NORDSR.Name = "M_NORDSR"
        Me.M_NORDSR.ReadOnly = True
        Me.M_NORDSR.Width = 79
        '
        'M_NSLCSR
        '
        Me.M_NSLCSR.DataPropertyName = "NSLCSR"
        Me.M_NSLCSR.HeaderText = "Nro. Solic."
        Me.M_NSLCSR.Name = "M_NSLCSR"
        Me.M_NSLCSR.ReadOnly = True
        Me.M_NSLCSR.Width = 85
        '
        'M_CTPALM
        '
        Me.M_CTPALM.DataPropertyName = "CTPALM"
        Me.M_CTPALM.HeaderText = "Tipo Almacén"
        Me.M_CTPALM.Name = "M_CTPALM"
        Me.M_CTPALM.ReadOnly = True
        Me.M_CTPALM.Width = 101
        '
        'M_CALMC
        '
        Me.M_CALMC.DataPropertyName = "CALMC"
        Me.M_CALMC.HeaderText = "Almacén"
        Me.M_CALMC.Name = "M_CALMC"
        Me.M_CALMC.ReadOnly = True
        Me.M_CALMC.Width = 77
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Cód. Ransa"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Width = 92
        '
        'M_QTRMC
        '
        Me.M_QTRMC.DataPropertyName = "QTRMC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = "0.0000"
        Me.M_QTRMC.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QTRMC.HeaderText = "Cantidad"
        Me.M_QTRMC.Name = "M_QTRMC"
        Me.M_QTRMC.ReadOnly = True
        Me.M_QTRMC.Width = 78
        '
        'M_CUNCN5
        '
        Me.M_CUNCN5.DataPropertyName = "CUNCN5"
        Me.M_CUNCN5.HeaderText = "Unidad"
        Me.M_CUNCN5.Name = "M_CUNCN5"
        Me.M_CUNCN5.ReadOnly = True
        Me.M_CUNCN5.Width = 70
        '
        'M_QTRMP
        '
        Me.M_QTRMP.DataPropertyName = "QTRMP"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0.0000"
        Me.M_QTRMP.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QTRMP.HeaderText = "Peso"
        Me.M_QTRMP.Name = "M_QTRMP"
        Me.M_QTRMP.ReadOnly = True
        Me.M_QTRMP.Width = 60
        '
        'M_CUNPS5
        '
        Me.M_CUNPS5.DataPropertyName = "CUNPS5"
        Me.M_CUNPS5.HeaderText = "Unidad"
        Me.M_CUNPS5.Name = "M_CUNPS5"
        Me.M_CUNPS5.ReadOnly = True
        Me.M_CUNPS5.Width = 70
        '
        'M_NGUIRN
        '
        Me.M_NGUIRN.DataPropertyName = "NGUIRN"
        Me.M_NGUIRN.HeaderText = "Nro. Guía Ransa"
        Me.M_NGUIRN.Name = "M_NGUIRN"
        Me.M_NGUIRN.ReadOnly = True
        Me.M_NGUIRN.Width = 117
        '
        'M_NGUICL
        '
        Me.M_NGUICL.DataPropertyName = "NGUICL"
        Me.M_NGUICL.HeaderText = "Nro. Guía Cliente"
        Me.M_NGUICL.Name = "M_NGUICL"
        Me.M_NGUICL.ReadOnly = True
        Me.M_NGUICL.Width = 118
        '
        'dstSolicOrdenServicio
        '
        Me.dstSolicOrdenServicio.DataSetName = "dstSolicOrdenServicio"
        Me.dstSolicOrdenServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenServicio})
        '
        'dtOrdenServicio
        '
        Me.dtOrdenServicio.Columns.AddRange(New System.Data.DataColumn() {Me.CTPOAT, Me.FRLZSR, Me.NORDSR, Me.NSLCSR, Me.CTPALM, Me.CALMC, Me.CMRCD, Me.QTRMC, Me.CUNCN5, Me.QTRMP, Me.CUNPS5, Me.NGUIRN, Me.NGUICL})
        Me.dtOrdenServicio.TableName = "dtOrdenServicio"
        '
        'CTPOAT
        '
        Me.CTPOAT.ColumnName = "CTPOAT"
        Me.CTPOAT.DefaultValue = ""
        '
        'FRLZSR
        '
        Me.FRLZSR.ColumnName = "FRLZSR"
        Me.FRLZSR.DataType = GetType(Date)
        '
        'NORDSR
        '
        Me.NORDSR.ColumnName = "NORDSR"
        Me.NORDSR.DataType = GetType(Long)
        Me.NORDSR.DefaultValue = CType(0, Long)
        '
        'NSLCSR
        '
        Me.NSLCSR.ColumnName = "NSLCSR"
        Me.NSLCSR.DataType = GetType(Integer)
        Me.NSLCSR.DefaultValue = 0
        '
        'CTPALM
        '
        Me.CTPALM.ColumnName = "CTPALM"
        Me.CTPALM.DefaultValue = ""
        '
        'CALMC
        '
        Me.CALMC.ColumnName = "CALMC"
        Me.CALMC.DefaultValue = ""
        '
        'CMRCD
        '
        Me.CMRCD.ColumnName = "CMRCD"
        Me.CMRCD.DefaultValue = ""
        '
        'QTRMC
        '
        Me.QTRMC.ColumnName = "QTRMC"
        Me.QTRMC.DataType = GetType(Decimal)
        Me.QTRMC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'CUNCN5
        '
        Me.CUNCN5.ColumnName = "CUNCN5"
        Me.CUNCN5.DefaultValue = ""
        '
        'QTRMP
        '
        Me.QTRMP.ColumnName = "QTRMP"
        Me.QTRMP.DataType = GetType(Decimal)
        Me.QTRMP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 262144})
        '
        'CUNPS5
        '
        Me.CUNPS5.ColumnName = "CUNPS5"
        Me.CUNPS5.DefaultValue = ""
        '
        'NGUIRN
        '
        Me.NGUIRN.ColumnName = "NGUIRN"
        Me.NGUIRN.DataType = GetType(Long)
        Me.NGUIRN.DefaultValue = CType(0, Long)
        '
        'NGUICL
        '
        Me.NGUICL.ColumnName = "NGUICL"
        Me.NGUICL.DefaultValue = ""
        '
        'btnEliminarMovimiento
        '
        Me.btnEliminarMovimiento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarMovimiento.Image = CType(resources.GetObject("btnEliminarMovimiento.Image"), System.Drawing.Image)
        Me.btnEliminarMovimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarMovimiento.Name = "btnEliminarMovimiento"
        Me.btnEliminarMovimiento.Size = New System.Drawing.Size(120, 22)
        Me.btnEliminarMovimiento.Text = "&Eliminar Movimiento"
        '
        'ucSolicOrdenServicios_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgListaSolicOrdenesServicio)
        Me.Controls.Add(Me.tsMenuOS)
        Me.Name = "ucSolicOrdenServicios_DgF01"
        Me.Size = New System.Drawing.Size(509, 162)
        Me.tsMenuOS.ResumeLayout(False)
        Me.tsMenuOS.PerformLayout()
        CType(Me.dgListaSolicOrdenesServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstSolicOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenuOS As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTituloSolicOS As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents dgListaSolicOrdenesServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dstSolicOrdenServicio As System.Data.DataSet
    Friend WithEvents dtOrdenServicio As System.Data.DataTable
    Friend WithEvents CTPOAT As System.Data.DataColumn
    Friend WithEvents FRLZSR As System.Data.DataColumn
    Friend WithEvents NORDSR As System.Data.DataColumn
    Friend WithEvents NSLCSR As System.Data.DataColumn
    Friend WithEvents CTPALM As System.Data.DataColumn
    Friend WithEvents CALMC As System.Data.DataColumn
    Friend WithEvents CMRCD As System.Data.DataColumn
    Friend WithEvents QTRMC As System.Data.DataColumn
    Friend WithEvents CUNCN5 As System.Data.DataColumn
    Friend WithEvents QTRMP As System.Data.DataColumn
    Friend WithEvents CUNPS5 As System.Data.DataColumn
    Friend WithEvents NGUIRN As System.Data.DataColumn
    Friend WithEvents NGUICL As System.Data.DataColumn
    Friend WithEvents M_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FRLZSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminarMovimiento As System.Windows.Forms.ToolStripButton

End Class
