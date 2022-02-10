<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucItemsWaybill_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucItemsWaybill_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblItemsWaybill = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.dstItemsBulto = New System.Data.DataSet
        Me.dtItemsBulto = New System.Data.DataTable
        Me.CREFFW = New System.Data.DataColumn
        Me.NORCML = New System.Data.DataColumn
        Me.NRITOC = New System.Data.DataColumn
        Me.CIDPAQ = New System.Data.DataColumn
        Me.TDITES = New System.Data.DataColumn
        Me.QBLTSR = New System.Data.DataColumn
        Me.QPEPQT = New System.Data.DataColumn
        Me.TUNPSO = New System.Data.DataColumn
        Me.QVOPQT = New System.Data.DataColumn
        Me.TUNVOL = New System.Data.DataColumn
        Me.TLUGEN = New System.Data.DataColumn
        Me.NGRPRV = New System.Data.DataColumn
        Me.dgItemsBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CIDPAQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QPEPQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNPSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QVOPQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNVOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGRPRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dstItemsBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtItemsBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgItemsBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblItemsWaybill, Me.btnEliminar, Me.tssSep_01, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(428, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblItemsWaybill
        '
        Me.lblItemsWaybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsWaybill.Name = "lblItemsWaybill"
        Me.lblItemsWaybill.Size = New System.Drawing.Size(98, 22)
        Me.lblItemsWaybill.Text = "ITEMS BULTOS"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'dstItemsBulto
        '
        Me.dstItemsBulto.DataSetName = "dstItemsBulto"
        Me.dstItemsBulto.Tables.AddRange(New System.Data.DataTable() {Me.dtItemsBulto})
        '
        'dtItemsBulto
        '
        Me.dtItemsBulto.Columns.AddRange(New System.Data.DataColumn() {Me.CREFFW, Me.NORCML, Me.NRITOC, Me.CIDPAQ, Me.TDITES, Me.QBLTSR, Me.QPEPQT, Me.TUNPSO, Me.QVOPQT, Me.TUNVOL, Me.TLUGEN, Me.NGRPRV})
        Me.dtItemsBulto.TableName = "dtItemsBulto"
        '
        'CREFFW
        '
        Me.CREFFW.Caption = "Bulto"
        Me.CREFFW.ColumnName = "CREFFW"
        Me.CREFFW.DefaultValue = ""
        '
        'NORCML
        '
        Me.NORCML.Caption = "Nro. O/C"
        Me.NORCML.ColumnName = "NORCML"
        Me.NORCML.DefaultValue = ""
        '
        'NRITOC
        '
        Me.NRITOC.Caption = "Nro. Item O/C"
        Me.NRITOC.ColumnName = "NRITOC"
        Me.NRITOC.DataType = GetType(Integer)
        Me.NRITOC.DefaultValue = 0
        '
        'CIDPAQ
        '
        Me.CIDPAQ.Caption = "Cód. Paquete"
        Me.CIDPAQ.ColumnName = "CIDPAQ"
        Me.CIDPAQ.DefaultValue = ""
        '
        'TDITES
        '
        Me.TDITES.Caption = "Descripción"
        Me.TDITES.ColumnName = "TDITES"
        Me.TDITES.DefaultValue = ""
        '
        'QBLTSR
        '
        Me.QBLTSR.Caption = "Cantidad"
        Me.QBLTSR.ColumnName = "QBLTSR"
        Me.QBLTSR.DataType = GetType(Decimal)
        Me.QBLTSR.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'QPEPQT
        '
        Me.QPEPQT.Caption = "Peso"
        Me.QPEPQT.ColumnName = "QPEPQT"
        Me.QPEPQT.DataType = GetType(Decimal)
        Me.QPEPQT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TUNPSO
        '
        Me.TUNPSO.Caption = " Unidad "
        Me.TUNPSO.ColumnName = "TUNPSO"
        Me.TUNPSO.DefaultValue = ""
        '
        'QVOPQT
        '
        Me.QVOPQT.Caption = "Volumen"
        Me.QVOPQT.ColumnName = "QVOPQT"
        Me.QVOPQT.DataType = GetType(Decimal)
        Me.QVOPQT.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'TUNVOL
        '
        Me.TUNVOL.Caption = " Unidad "
        Me.TUNVOL.ColumnName = "TUNVOL"
        Me.TUNVOL.DefaultValue = ""
        '
        'TLUGEN
        '
        Me.TLUGEN.Caption = "Lugar Entrega"
        Me.TLUGEN.ColumnName = "TLUGEN"
        Me.TLUGEN.DefaultValue = ""
        '
        'NGRPRV
        '
        Me.NGRPRV.Caption = "Guia Proveedor"
        Me.NGRPRV.ColumnName = "NGRPRV"
        Me.NGRPRV.DefaultValue = ""
        '
        'dgItemsBulto
        '
        Me.dgItemsBulto.AllowUserToAddRows = False
        Me.dgItemsBulto.AllowUserToDeleteRows = False
        Me.dgItemsBulto.AllowUserToOrderColumns = True
        Me.dgItemsBulto.AllowUserToResizeColumns = False
        Me.dgItemsBulto.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip
        Me.dgItemsBulto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgItemsBulto.AutoGenerateColumns = False
        Me.dgItemsBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgItemsBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgItemsBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CREFFW, Me.M_NORCML, Me.M_NRITOC, Me.M_CIDPAQ, Me.M_TDITES, Me.M_QBLTSR, Me.M_QPEPQT, Me.M_TUNPSO, Me.M_QVOPQT, Me.M_TUNVOL, Me.M_TLUGEN, Me.M_NGRPRV})
        Me.dgItemsBulto.DataMember = "dtItemsBulto"
        Me.dgItemsBulto.DataSource = Me.dstItemsBulto
        Me.dgItemsBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemsBulto.Location = New System.Drawing.Point(0, 25)
        Me.dgItemsBulto.MultiSelect = False
        Me.dgItemsBulto.Name = "dgItemsBulto"
        Me.dgItemsBulto.ReadOnly = True
        Me.dgItemsBulto.RowHeadersWidth = 20
        Me.dgItemsBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemsBulto.Size = New System.Drawing.Size(428, 214)
        Me.dgItemsBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgItemsBulto.TabIndex = 26
        '
        'M_CREFFW
        '
        Me.M_CREFFW.DataPropertyName = "CREFFW"
        Me.M_CREFFW.HeaderText = "Bulto"
        Me.M_CREFFW.Name = "M_CREFFW"
        Me.M_CREFFW.ReadOnly = True
        Me.M_CREFFW.Visible = False
        Me.M_CREFFW.Width = 60
        '
        'M_NORCML
        '
        Me.M_NORCML.DataPropertyName = "NORCML"
        Me.M_NORCML.HeaderText = "Nro. O/C"
        Me.M_NORCML.Name = "M_NORCML"
        Me.M_NORCML.ReadOnly = True
        Me.M_NORCML.Width = 81
        '
        'M_NRITOC
        '
        Me.M_NRITOC.DataPropertyName = "NRITOC"
        Me.M_NRITOC.HeaderText = "Nro. Item O/C"
        Me.M_NRITOC.Name = "M_NRITOC"
        Me.M_NRITOC.ReadOnly = True
        Me.M_NRITOC.Width = 106
        '
        'M_CIDPAQ
        '
        Me.M_CIDPAQ.DataPropertyName = "CIDPAQ"
        Me.M_CIDPAQ.HeaderText = "Cód. Paquete"
        Me.M_CIDPAQ.Name = "M_CIDPAQ"
        Me.M_CIDPAQ.ReadOnly = True
        Me.M_CIDPAQ.Width = 105
        '
        'M_TDITES
        '
        Me.M_TDITES.DataPropertyName = "TDITES"
        Me.M_TDITES.HeaderText = "Descripción"
        Me.M_TDITES.Name = "M_TDITES"
        Me.M_TDITES.ReadOnly = True
        Me.M_TDITES.Width = 96
        '
        'M_QBLTSR
        '
        Me.M_QBLTSR.DataPropertyName = "QBLTSR"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.M_QBLTSR.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QBLTSR.HeaderText = "Cantidad"
        Me.M_QBLTSR.Name = "M_QBLTSR"
        Me.M_QBLTSR.ReadOnly = True
        Me.M_QBLTSR.Width = 83
        '
        'M_QPEPQT
        '
        Me.M_QPEPQT.DataPropertyName = "QPEPQT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.M_QPEPQT.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_QPEPQT.HeaderText = "Peso"
        Me.M_QPEPQT.Name = "M_QPEPQT"
        Me.M_QPEPQT.ReadOnly = True
        Me.M_QPEPQT.Width = 60
        '
        'M_TUNPSO
        '
        Me.M_TUNPSO.DataPropertyName = "TUNPSO"
        Me.M_TUNPSO.HeaderText = "Unidad"
        Me.M_TUNPSO.Name = "M_TUNPSO"
        Me.M_TUNPSO.ReadOnly = True
        Me.M_TUNPSO.Width = 74
        '
        'M_QVOPQT
        '
        Me.M_QVOPQT.DataPropertyName = "QVOPQT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.M_QVOPQT.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_QVOPQT.HeaderText = " Volumen "
        Me.M_QVOPQT.Name = "M_QVOPQT"
        Me.M_QVOPQT.ReadOnly = True
        Me.M_QVOPQT.Width = 88
        '
        'M_TUNVOL
        '
        Me.M_TUNVOL.DataPropertyName = "TUNVOL"
        Me.M_TUNVOL.HeaderText = "Unidad"
        Me.M_TUNVOL.Name = "M_TUNVOL"
        Me.M_TUNVOL.ReadOnly = True
        Me.M_TUNVOL.Width = 74
        '
        'M_TLUGEN
        '
        Me.M_TLUGEN.DataPropertyName = "TLUGEN"
        Me.M_TLUGEN.HeaderText = "Lugar Entrega"
        Me.M_TLUGEN.Name = "M_TLUGEN"
        Me.M_TLUGEN.ReadOnly = True
        Me.M_TLUGEN.Width = 108
        '
        'M_NGRPRV
        '
        Me.M_NGRPRV.DataPropertyName = "NGRPRV"
        Me.M_NGRPRV.HeaderText = "Guia Proveedor"
        Me.M_NGRPRV.Name = "M_NGRPRV"
        Me.M_NGRPRV.ReadOnly = True
        Me.M_NGRPRV.Visible = False
        Me.M_NGRPRV.Width = 110
        '
        'ucItemsWaybill_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgItemsBulto)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucItemsWaybill_DgF01"
        Me.Size = New System.Drawing.Size(428, 239)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dstItemsBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtItemsBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgItemsBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblItemsWaybill As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dstItemsBulto As System.Data.DataSet
    Friend WithEvents dtItemsBulto As System.Data.DataTable
    Friend WithEvents CREFFW As System.Data.DataColumn
    Friend WithEvents NORCML As System.Data.DataColumn
    Friend WithEvents NRITOC As System.Data.DataColumn
    Friend WithEvents CIDPAQ As System.Data.DataColumn
    Friend WithEvents TDITES As System.Data.DataColumn
    Friend WithEvents QBLTSR As System.Data.DataColumn

    Friend WithEvents QPEPQT As System.Data.DataColumn
    Friend WithEvents TUNPSO As System.Data.DataColumn
    Friend WithEvents QVOPQT As System.Data.DataColumn
    Friend WithEvents TUNVOL As System.Data.DataColumn

    Friend WithEvents TLUGEN As System.Data.DataColumn
    Friend WithEvents NGRPRV As System.Data.DataColumn
    Friend WithEvents dgItemsBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView


    Private WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents M_CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CIDPAQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QPEPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNPSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QVOPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNVOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGRPRV As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
