<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucServicios_Mercaderia_DgF01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucServicios_Mercaderia_DgF01))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblMercaderia = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.cbxTipoCodigo = New System.Windows.Forms.ToolStripComboBox
        Me.txtCodigo = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.dgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.dstMercaderia = New System.Data.DataSet
        Me.dtMercaderia = New System.Data.DataTable
        Me.CMRCLR = New System.Data.DataColumn
        Me.TMRCD2 = New System.Data.DataColumn
        Me.CMRCD = New System.Data.DataColumn
        Me.CTPOAT = New System.Data.DataColumn
        Me.NORDSR = New System.Data.DataColumn
        Me.NSLCSR = New System.Data.DataColumn
        Me.CTPALM = New System.Data.DataColumn
        Me.CALMC = New System.Data.DataColumn
        Me.QTRMC = New System.Data.DataColumn
        Me.CUNCN5 = New System.Data.DataColumn
        Me.QTRMP = New System.Data.DataColumn
        Me.CUNPS5 = New System.Data.DataColumn
        Me.NGUIRN = New System.Data.DataColumn
        Me.SESTRG = New System.Data.DataColumn
        Me.M_CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPOAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NSLCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMercaderia, Me.btnEliminar, Me.cbxTipoCodigo, Me.txtCodigo, Me.ToolStripSeparator1, Me.btnAgregar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(458, 25)
        Me.tsMenuOpciones.TabIndex = 25
        '
        'lblMercaderia
        '
        Me.lblMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMercaderia.Name = "lblMercaderia"
        Me.lblMercaderia.Size = New System.Drawing.Size(88, 22)
        Me.lblMercaderia.Text = "MERCADERIA"
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
        '
        'cbxTipoCodigo
        '
        Me.cbxTipoCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTipoCodigo.Items.AddRange(New Object() {"S - Nro. O/S , Nro. SOLIC.", "G - Nro. GUÍA RANSA"})
        Me.cbxTipoCodigo.Name = "cbxTipoCodigo"
        Me.cbxTipoCodigo.Size = New System.Drawing.Size(200, 25)
        Me.cbxTipoCodigo.ToolTipText = "Seleccione Bulto / Paleta / Nro. Guía"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 25)
        Me.txtCodigo.ToolTipText = "Código (Presones Enter para registrar)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(23, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'dgMercaderia
        '
        Me.dgMercaderia.AllowUserToAddRows = False
        Me.dgMercaderia.AllowUserToDeleteRows = False
        Me.dgMercaderia.AllowUserToResizeColumns = False
        Me.dgMercaderia.AllowUserToResizeRows = False
        Me.dgMercaderia.AutoGenerateColumns = False
        Me.dgMercaderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMercaderia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CMRCLR, Me.M_TMRCD2, Me.M_CMRCD, Me.M_CTPOAT, Me.M_NORDSR, Me.M_NSLCSR, Me.M_CTPALM, Me.M_CALMC, Me.M_QTRMC, Me.M_CUNCN5, Me.M_QTRMP, Me.M_CUNPS5, Me.M_NGUIRN, Me.M_SESTRG})
        Me.dgMercaderia.DataMember = "dtMercaderia"
        Me.dgMercaderia.DataSource = Me.dstMercaderia
        Me.dgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderia.Location = New System.Drawing.Point(0, 25)
        Me.dgMercaderia.MultiSelect = False
        Me.dgMercaderia.Name = "dgMercaderia"
        Me.dgMercaderia.ReadOnly = True
        Me.dgMercaderia.RowHeadersWidth = 20
        Me.dgMercaderia.RowTemplate.ReadOnly = True
        Me.dgMercaderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgMercaderia.Size = New System.Drawing.Size(458, 214)
        Me.dgMercaderia.StandardTab = True
        Me.dgMercaderia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderia.TabIndex = 26
        '
        'dstMercaderia
        '
        Me.dstMercaderia.DataSetName = "dstMercaderia"
        Me.dstMercaderia.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dstMercaderia.Tables.AddRange(New System.Data.DataTable() {Me.dtMercaderia})
        '
        'dtMercaderia
        '
        Me.dtMercaderia.Columns.AddRange(New System.Data.DataColumn() {Me.CMRCLR, Me.TMRCD2, Me.CMRCD, Me.CTPOAT, Me.NORDSR, Me.NSLCSR, Me.CTPALM, Me.CALMC, Me.QTRMC, Me.CUNCN5, Me.QTRMP, Me.CUNPS5, Me.NGUIRN, Me.SESTRG})
        Me.dtMercaderia.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.dtMercaderia.TableName = "dtMercaderia"
        '
        'CMRCLR
        '
        Me.CMRCLR.ColumnName = "CMRCLR"
        Me.CMRCLR.DefaultValue = ""
        '
        'TMRCD2
        '
        Me.TMRCD2.ColumnName = "TMRCD2"
        Me.TMRCD2.DefaultValue = ""
        '
        'CMRCD
        '
        Me.CMRCD.ColumnName = "CMRCD"
        Me.CMRCD.DefaultValue = ""
        '
        'CTPOAT
        '
        Me.CTPOAT.ColumnName = "CTPOAT"
        Me.CTPOAT.DefaultValue = ""
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
        'QTRMC
        '
        Me.QTRMC.ColumnName = "QTRMC"
        Me.QTRMC.DataType = GetType(Decimal)
        Me.QTRMC.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
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
        Me.QTRMP.DefaultValue = New Decimal(New Integer() {0, 0, 0, 131072})
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
        'SESTRG
        '
        Me.SESTRG.ColumnName = "SESTRG"
        Me.SESTRG.DefaultValue = ""
        '
        'M_CMRCLR
        '
        Me.M_CMRCLR.DataPropertyName = "CMRCLR"
        Me.M_CMRCLR.HeaderText = "Mercadería"
        Me.M_CMRCLR.Name = "M_CMRCLR"
        Me.M_CMRCLR.ReadOnly = True
        Me.M_CMRCLR.Width = 91
        '
        'M_TMRCD2
        '
        Me.M_TMRCD2.DataPropertyName = "TMRCD2"
        Me.M_TMRCD2.HeaderText = "Descripción"
        Me.M_TMRCD2.Name = "M_TMRCD2"
        Me.M_TMRCD2.ReadOnly = True
        Me.M_TMRCD2.Width = 92
        '
        'M_CMRCD
        '
        Me.M_CMRCD.DataPropertyName = "CMRCD"
        Me.M_CMRCD.HeaderText = "Cód. Ransa"
        Me.M_CMRCD.Name = "M_CMRCD"
        Me.M_CMRCD.ReadOnly = True
        Me.M_CMRCD.Width = 92
        '
        'M_CTPOAT
        '
        Me.M_CTPOAT.DataPropertyName = "CTPOAT"
        Me.M_CTPOAT.HeaderText = "Tipo Autorización"
        Me.M_CTPOAT.Name = "M_CTPOAT"
        Me.M_CTPOAT.ReadOnly = True
        Me.M_CTPOAT.Width = 118
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
        Me.M_CTPALM.HeaderText = "Tipo Alm."
        Me.M_CTPALM.Name = "M_CTPALM"
        Me.M_CTPALM.ReadOnly = True
        Me.M_CTPALM.Width = 80
        '
        'M_CALMC
        '
        Me.M_CALMC.DataPropertyName = "CALMC"
        Me.M_CALMC.HeaderText = "Almacén"
        Me.M_CALMC.Name = "M_CALMC"
        Me.M_CALMC.ReadOnly = True
        Me.M_CALMC.Width = 77
        '
        'M_QTRMC
        '
        Me.M_QTRMC.DataPropertyName = "QTRMC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.M_QTRMC.DefaultCellStyle = DataGridViewCellStyle1
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.M_QTRMP.DefaultCellStyle = DataGridViewCellStyle2
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
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "SESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 80
        '
        'ucServicios_Mercaderia_DgF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.dgMercaderia)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "ucServicios_Mercaderia_DgF01"
        Me.Size = New System.Drawing.Size(458, 239)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblMercaderia As System.Windows.Forms.ToolStripLabel
    Private WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents cbxTipoCodigo As System.Windows.Forms.ToolStripComboBox
    Private WithEvents txtCodigo As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Private WithEvents dgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents dstMercaderia As System.Data.DataSet
    Private WithEvents dtMercaderia As System.Data.DataTable
    Friend WithEvents CMRCLR As System.Data.DataColumn
    Friend WithEvents TMRCD2 As System.Data.DataColumn
    Friend WithEvents CMRCD As System.Data.DataColumn
    Friend WithEvents CTPOAT As System.Data.DataColumn
    Friend WithEvents NORDSR As System.Data.DataColumn
    Friend WithEvents NSLCSR As System.Data.DataColumn
    Friend WithEvents CTPALM As System.Data.DataColumn
    Friend WithEvents CALMC As System.Data.DataColumn
    Friend WithEvents QTRMC As System.Data.DataColumn
    Friend WithEvents CUNCN5 As System.Data.DataColumn
    Friend WithEvents QTRMP As System.Data.DataColumn
    Friend WithEvents CUNPS5 As System.Data.DataColumn
    Friend WithEvents NGUIRN As System.Data.DataColumn
    Friend WithEvents SESTRG As System.Data.DataColumn
    Friend WithEvents M_CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPOAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NSLCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
