<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucWaybill_DgF02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucWaybill_DgF02))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblWaybill = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.txtCodigo = New System.Windows.Forms.ToolStripTextBox
        Me.cbxTipoCodigo = New System.Windows.Forms.ToolStripComboBox
        Me.lblAgregar = New System.Windows.Forms.ToolStripLabel
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.dstWayBill = New System.Data.DataSet
        Me.dtWayBill = New System.Data.DataTable
        Me.CREFFW = New System.Data.DataColumn
        Me.DESCWB = New System.Data.DataColumn
        Me.TUBRFR = New System.Data.DataColumn
        Me.QREFFW = New System.Data.DataColumn
        Me.TIPBTO = New System.Data.DataColumn
        Me.QPSOBL = New System.Data.DataColumn
        Me.TUNPSO = New System.Data.DataColumn
        Me.QVLBTO = New System.Data.DataColumn
        Me.TUNVOL = New System.Data.DataColumn
        Me.QAROCP = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.dgWayBill = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_DESCWB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUBRFR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TIPBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QPSOBL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QVLBTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QAROCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dstWayBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtWayBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgWayBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblWaybill, Me.btnEliminar, Me.tssSep_01, Me.txtCodigo, Me.cbxTipoCodigo, Me.lblAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(428, 25)
        Me.tsMenuOpciones.TabIndex = 24
        '
        'lblWaybill
        '
        Me.lblWaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaybill.Name = "lblWaybill"
        Me.lblWaybill.Size = New System.Drawing.Size(56, 22)
        Me.lblWaybill.Text = "BULTOS"
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
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'txtCodigo
        '
        Me.txtCodigo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 25)
        '
        'cbxTipoCodigo
        '
        Me.cbxTipoCodigo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cbxTipoCodigo.Items.AddRange(New Object() {"BULTO", "PALETA", "G. REMISION"})
        Me.cbxTipoCodigo.Name = "cbxTipoCodigo"
        Me.cbxTipoCodigo.Size = New System.Drawing.Size(120, 25)
        '
        'lblAgregar
        '
        Me.lblAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblAgregar.Image = CType(resources.GetObject("lblAgregar.Image"), System.Drawing.Image)
        Me.lblAgregar.Name = "lblAgregar"
        Me.lblAgregar.Size = New System.Drawing.Size(60, 22)
        Me.lblAgregar.Text = "&Agregar"
        '
        'dstWayBill
        '
        Me.dstWayBill.DataSetName = "dstWayBill"
        Me.dstWayBill.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstWayBill.Tables.AddRange(New System.Data.DataTable() {Me.dtWayBill})
        '
        'dtWayBill
        '
        Me.dtWayBill.Columns.AddRange(New System.Data.DataColumn() {Me.CREFFW, Me.DESCWB, Me.TUBRFR, Me.QREFFW, Me.TIPBTO, Me.QPSOBL, Me.TUNPSO, Me.QVLBTO, Me.TUNVOL, Me.QAROCP, Me.SESTRG})
        Me.dtWayBill.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtWayBill.TableName = "dtWayBill"
        '
        'CREFFW
        '
        Me.CREFFW.ColumnName = "CREFFW"
        Me.CREFFW.DefaultValue = ""
        '
        'DESCWB
        '
        Me.DESCWB.ColumnName = "DESCWB"
        Me.DESCWB.DefaultValue = ""
        '
        'TUBRFR
        '
        Me.TUBRFR.ColumnName = "TUBRFR"
        Me.TUBRFR.DefaultValue = ""
        '
        'QREFFW
        '
        Me.QREFFW.ColumnName = "QREFFW"
        Me.QREFFW.DataType = GetType(Decimal)
        Me.QREFFW.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TIPBTO
        '
        Me.TIPBTO.ColumnName = "TIPBTO"
        Me.TIPBTO.DefaultValue = ""
        '
        'QPSOBL
        '
        Me.QPSOBL.ColumnName = "QPSOBL"
        Me.QPSOBL.DataType = GetType(Decimal)
        Me.QPSOBL.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNPSO
        '
        Me.TUNPSO.ColumnName = "TUNPSO"
        Me.TUNPSO.DefaultValue = ""
        '
        'QVLBTO
        '
        Me.QVLBTO.ColumnName = "QVLBTO"
        Me.QVLBTO.DataType = GetType(Decimal)
        Me.QVLBTO.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'TUNVOL
        '
        Me.TUNVOL.ColumnName = "TUNVOL"
        Me.TUNVOL.DefaultValue = ""
        '
        'QAROCP
        '
        Me.QAROCP.ColumnName = "QAROCP"
        Me.QAROCP.DataType = GetType(Decimal)
        Me.QAROCP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'dgWayBill
        '
        Me.dgWayBill.AllowUserToAddRows = False
        Me.dgWayBill.AllowUserToDeleteRows = False
        Me.dgWayBill.AllowUserToResizeColumns = False
        Me.dgWayBill.AllowUserToResizeRows = False
        Me.dgWayBill.AutoGenerateColumns = False
        Me.dgWayBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgWayBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgWayBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CREFFW, Me.M_DESCWB, Me.M_TUBRFR, Me.M_QREFFW, Me.M_TIPBTO, Me.M_QPSOBL, Me.M_TUNPSO, Me.M_QVLBTO, Me.M_TUNVOL, Me.M_QAROCP, Me.M_SESTRG})
        Me.dgWayBill.DataMember = "dtWayBill"
        Me.dgWayBill.DataSource = Me.dstWayBill
        Me.dgWayBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgWayBill.Location = New System.Drawing.Point(0, 25)
        Me.dgWayBill.MultiSelect = False
        Me.dgWayBill.Name = "dgWayBill"
        Me.dgWayBill.ReadOnly = True
        Me.dgWayBill.RowHeadersWidth = 20
        Me.dgWayBill.RowTemplate.ReadOnly = True
        Me.dgWayBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgWayBill.Size = New System.Drawing.Size(428, 214)
        Me.dgWayBill.StandardTab = True
        Me.dgWayBill.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgWayBill.TabIndex = 25
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.Frozen = True
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Width = 60
        '
        'M_DESCWB
        '
        Me.M_DESCWB.DataPropertyName = "DESCWB"
        Me.M_DESCWB.HeaderText = "Descripción"
        Me.M_DESCWB.Name = "M_DESCWB"
        Me.M_DESCWB.ReadOnly = True
        Me.M_DESCWB.Width = 92
        '
        'M_TUBRFR
        '
        Me.M_TUBRFR.DataPropertyName = "TUBRFR"
        Me.M_TUBRFR.HeaderText = "Ubicación"
        Me.M_TUBRFR.Name = "M_TUBRFR"
        Me.M_TUBRFR.ReadOnly = True
        Me.M_TUBRFR.Width = 84
        '
        'M_QREFFW
        '
        Me.M_QREFFW.DataPropertyName = "QREFFW"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.M_QREFFW.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_QREFFW.HeaderText = "Cantidad"
        Me.M_QREFFW.Name = "M_QREFFW"
        Me.M_QREFFW.ReadOnly = True
        Me.M_QREFFW.Width = 78
        '
        'M_TIPBTO
        '
        Me.M_TIPBTO.DataPropertyName = "TIPBTO"
        Me.M_TIPBTO.HeaderText = "Tipo Bulto"
        Me.M_TIPBTO.Name = "M_TIPBTO"
        Me.M_TIPBTO.ReadOnly = True
        Me.M_TIPBTO.Width = 84
        '
        'M_QPSOBL
        '
        Me.M_QPSOBL.DataPropertyName = "QPSOBL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.M_QPSOBL.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QPSOBL.HeaderText = "Peso"
        Me.M_QPSOBL.Name = "M_QPSOBL"
        Me.M_QPSOBL.ReadOnly = True
        Me.M_QPSOBL.Width = 60
        '
        'M_TUNPSO
        '
        Me.M_TUNPSO.DataPropertyName = "TUNPSO"
        Me.M_TUNPSO.HeaderText = "Unidad"
        Me.M_TUNPSO.Name = "M_TUNPSO"
        Me.M_TUNPSO.ReadOnly = True
        Me.M_TUNPSO.Width = 70
        '
        'M_QVLBTO
        '
        Me.M_QVLBTO.DataPropertyName = "QVLBTO"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.M_QVLBTO.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QVLBTO.HeaderText = "Volumen"
        Me.M_QVLBTO.Name = "M_QVLBTO"
        Me.M_QVLBTO.ReadOnly = True
        Me.M_QVLBTO.Width = 77
        '
        'M_TUNVOL
        '
        Me.M_TUNVOL.DataPropertyName = "TUNVOL"
        Me.M_TUNVOL.HeaderText = "Unidad"
        Me.M_TUNVOL.Name = "M_TUNVOL"
        Me.M_TUNVOL.ReadOnly = True
        Me.M_TUNVOL.Width = 70
        '
        'M_QAROCP
        '
        Me.M_QAROCP.DataPropertyName = "QAROCP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.M_QAROCP.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_QAROCP.HeaderText = "Área Ocupada"
        Me.M_QAROCP.Name = "M_QAROCP"
        Me.M_QAROCP.ReadOnly = True
        Me.M_QAROCP.Width = 105
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 80
        '
        'ucWaybill_DgF02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgWayBill)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucWaybill_DgF02"
        Me.Size = New System.Drawing.Size(428, 239)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dstWayBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtWayBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgWayBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblWaybill As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents dstWayBill As System.Data.DataSet
    Private WithEvents dtWayBill As System.Data.DataTable
    Friend WithEvents CREFFW As System.Data.DataColumn
    Friend WithEvents DESCWB As System.Data.DataColumn
    Friend WithEvents TUBRFR As System.Data.DataColumn
    Friend WithEvents QREFFW As System.Data.DataColumn
    Friend WithEvents TIPBTO As System.Data.DataColumn
    Friend WithEvents QPSOBL As System.Data.DataColumn
    Friend WithEvents TUNPSO As System.Data.DataColumn
    Friend WithEvents QVLBTO As System.Data.DataColumn
    Friend WithEvents TUNVOL As System.Data.DataColumn
    Friend WithEvents QAROCP As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Private WithEvents dgWayBill As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_DESCWB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUBRFR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TIPBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPSOBL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QVLBTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QAROCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents lblAgregar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCodigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cbxTipoCodigo As System.Windows.Forms.ToolStripComboBox

End Class
