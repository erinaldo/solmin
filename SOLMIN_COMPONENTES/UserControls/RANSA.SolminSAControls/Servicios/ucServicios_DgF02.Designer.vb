<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucServicios_DgF02
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucServicios_DgF02))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblServicios = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmbServiciosDisponibles = New System.Windows.Forms.ToolStripComboBox
        Me.lblQtaAtendida = New System.Windows.Forms.ToolStripLabel
        Me.txtQtaAtendida = New System.Windows.Forms.ToolStripTextBox
        Me.dstServicio = New System.Data.DataSet
        Me.dtRZSC30 = New System.Data.DataTable
        Me.NRTFSV = New System.Data.DataColumn
        Me.NOMSER = New System.Data.DataColumn
        Me.QCNESP = New System.Data.DataColumn
        Me.TUNDIT = New System.Data.DataColumn
        Me.QATNAN = New System.Data.DataColumn
        Me.dgServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NRTFSV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NOMSER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNESP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QATNAN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dstServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRZSC30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.AutoSize = False
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblServicios, Me.btnEliminar, Me.tssSep_01, Me.btnAgregar, Me.cmbServiciosDisponibles, Me.lblQtaAtendida, Me.txtQtaAtendida})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(684, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblServicios
        '
        Me.lblServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(73, 22)
        Me.lblServicios.Text = "SERVICIOS"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.ToolTipText = "Eliminar Servicio"
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
        Me.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(23, 22)
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.ToolTipText = "Registrar Servicio al Cliente"
        '
        'cmbServiciosDisponibles
        '
        Me.cmbServiciosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServiciosDisponibles.DropDownWidth = 500
        Me.cmbServiciosDisponibles.Name = "cmbServiciosDisponibles"
        Me.cmbServiciosDisponibles.Size = New System.Drawing.Size(400, 25)
        '
        'lblQtaAtendida
        '
        Me.lblQtaAtendida.Name = "lblQtaAtendida"
        Me.lblQtaAtendida.Size = New System.Drawing.Size(61, 22)
        Me.lblQtaAtendida.Text = " Cantidad : "
        '
        'txtQtaAtendida
        '
        Me.txtQtaAtendida.CausesValidation = False
        Me.txtQtaAtendida.Name = "txtQtaAtendida"
        Me.txtQtaAtendida.Size = New System.Drawing.Size(70, 25)
        Me.txtQtaAtendida.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dstServicio
        '
        Me.dstServicio.DataSetName = "dstServicio"
        Me.dstServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtRZSC30})
        '
        'dtRZSC30
        '
        Me.dtRZSC30.Columns.AddRange(New System.Data.DataColumn() {Me.NRTFSV, Me.NOMSER, Me.QCNESP, Me.TUNDIT, Me.QATNAN})
        Me.dtRZSC30.TableName = "dtRZSC30"
        '
        'NRTFSV
        '
        Me.NRTFSV.ColumnName = "NRTFSV"
        Me.NRTFSV.DataType = GetType(Long)
        Me.NRTFSV.DefaultValue = CType(0, Long)
        '
        'NOMSER
        '
        Me.NOMSER.ColumnName = "NOMSER"
        Me.NOMSER.DefaultValue = ""
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
        'QATNAN
        '
        Me.QATNAN.ColumnName = "QATNAN"
        Me.QATNAN.DataType = GetType(Decimal)
        Me.QATNAN.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
        '
        'dgServicio
        '
        Me.dgServicio.AllowUserToAddRows = False
        Me.dgServicio.AllowUserToDeleteRows = False
        Me.dgServicio.AllowUserToResizeColumns = False
        Me.dgServicio.AllowUserToResizeRows = False
        Me.dgServicio.AutoGenerateColumns = False
        Me.dgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NRTFSV, Me.M_NOMSER, Me.M_QCNESP, Me.M_TUNDIT, Me.M_QATNAN})
        Me.dgServicio.DataMember = "dtRZSC30"
        Me.dgServicio.DataSource = Me.dstServicio
        Me.dgServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicio.Location = New System.Drawing.Point(0, 25)
        Me.dgServicio.MultiSelect = False
        Me.dgServicio.Name = "dgServicio"
        Me.dgServicio.ReadOnly = True
        Me.dgServicio.RowHeadersWidth = 20
        Me.dgServicio.RowTemplate.ReadOnly = True
        Me.dgServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgServicio.Size = New System.Drawing.Size(684, 214)
        Me.dgServicio.StandardTab = True
        Me.dgServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgServicio.TabIndex = 27
        '
        'M_NRTFSV
        '
        Me.M_NRTFSV.DataPropertyName = "NRTFSV"
        Me.M_NRTFSV.HeaderText = "Tarifa"
        Me.M_NRTFSV.Name = "M_NRTFSV"
        Me.M_NRTFSV.ReadOnly = True
        Me.M_NRTFSV.Width = 63
        '
        'M_NOMSER
        '
        Me.M_NOMSER.DataPropertyName = "NOMSER"
        Me.M_NOMSER.HeaderText = "Servicio"
        Me.M_NOMSER.Name = "M_NOMSER"
        Me.M_NOMSER.ReadOnly = True
        Me.M_NOMSER.Width = 74
        '
        'M_QCNESP
        '
        Me.M_QCNESP.DataPropertyName = "QCNESP"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.M_QCNESP.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_QCNESP.HeaderText = "Cant. Base"
        Me.M_QCNESP.Name = "M_QCNESP"
        Me.M_QCNESP.ReadOnly = True
        Me.M_QCNESP.Width = 88
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.DataPropertyName = "TUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 70
        '
        'M_QATNAN
        '
        Me.M_QATNAN.DataPropertyName = "QATNAN"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.M_QATNAN.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_QATNAN.HeaderText = "Cant. Atendida"
        Me.M_QATNAN.Name = "M_QATNAN"
        Me.M_QATNAN.ReadOnly = True
        Me.M_QATNAN.Width = 106
        '
        'ucServicios_DgF02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgServicio)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucServicios_DgF02"
        Me.Size = New System.Drawing.Size(684, 239)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dstServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRZSC30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblServicios As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dstServicio As System.Data.DataSet
    Friend WithEvents dtRZSC30 As System.Data.DataTable
    Friend WithEvents NRTFSV As System.Data.DataColumn
    Friend WithEvents NOMSER As System.Data.DataColumn
    Friend WithEvents QCNESP As System.Data.DataColumn
    Friend WithEvents TUNDIT As System.Data.DataColumn
    Friend WithEvents QATNAN As System.Data.DataColumn
    Friend WithEvents lblQtaAtendida As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtQtaAtendida As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmbServiciosDisponibles As System.Windows.Forms.ToolStripComboBox
    Private WithEvents dgServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents M_NRTFSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NOMSER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNESP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QATNAN As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
