<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCalendario
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.dgvCalendario = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM01 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM02 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM03 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM04 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM05 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM06 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIASEM07 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTitulo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(466, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 22)
        '
        'dgvCalendario
        '
        Me.dgvCalendario.AllowUserToAddRows = False
        Me.dgvCalendario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCalendario.BackgroundColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCalendario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalendario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DIASEM01, Me.DIASEM02, Me.DIASEM03, Me.DIASEM04, Me.DIASEM05, Me.DIASEM06, Me.DIASEM07})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCalendario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCalendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCalendario.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dgvCalendario.Location = New System.Drawing.Point(0, 25)
        Me.dgvCalendario.MultiSelect = False
        Me.dgvCalendario.Name = "dgvCalendario"
        Me.dgvCalendario.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCalendario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCalendario.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCalendario.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCalendario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCalendario.Size = New System.Drawing.Size(466, 185)
        Me.dgvCalendario.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DIASEM01"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dom"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DIASEM02"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lun"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 59
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DIASEM03"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Mar"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DIASEM04"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mié"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DIASEM05"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Jue"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DIASEM06"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vie"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 59
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DIASEM07"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sáb"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DIASEM01
        '
        Me.DIASEM01.DataPropertyName = "DIASEM01"
        Me.DIASEM01.HeaderText = "Dom"
        Me.DIASEM01.Name = "DIASEM01"
        Me.DIASEM01.ReadOnly = True
        Me.DIASEM01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM01.Width = 60
        '
        'DIASEM02
        '
        Me.DIASEM02.DataPropertyName = "DIASEM02"
        Me.DIASEM02.HeaderText = "Lun"
        Me.DIASEM02.Name = "DIASEM02"
        Me.DIASEM02.ReadOnly = True
        Me.DIASEM02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM02.Width = 59
        '
        'DIASEM03
        '
        Me.DIASEM03.DataPropertyName = "DIASEM03"
        Me.DIASEM03.HeaderText = "Mar"
        Me.DIASEM03.Name = "DIASEM03"
        Me.DIASEM03.ReadOnly = True
        Me.DIASEM03.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM03.Width = 60
        '
        'DIASEM04
        '
        Me.DIASEM04.DataPropertyName = "DIASEM04"
        Me.DIASEM04.HeaderText = "Mié"
        Me.DIASEM04.Name = "DIASEM04"
        Me.DIASEM04.ReadOnly = True
        Me.DIASEM04.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM04.Width = 60
        '
        'DIASEM05
        '
        Me.DIASEM05.DataPropertyName = "DIASEM05"
        Me.DIASEM05.HeaderText = "Jue"
        Me.DIASEM05.Name = "DIASEM05"
        Me.DIASEM05.ReadOnly = True
        Me.DIASEM05.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM05.Width = 60
        '
        'DIASEM06
        '
        Me.DIASEM06.DataPropertyName = "DIASEM06"
        Me.DIASEM06.HeaderText = "Vie"
        Me.DIASEM06.Name = "DIASEM06"
        Me.DIASEM06.ReadOnly = True
        Me.DIASEM06.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM06.Width = 59
        '
        'DIASEM07
        '
        Me.DIASEM07.DataPropertyName = "DIASEM07"
        Me.DIASEM07.HeaderText = "Sáb"
        Me.DIASEM07.Name = "DIASEM07"
        Me.DIASEM07.ReadOnly = True
        Me.DIASEM07.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIASEM07.Width = 60
        '
        'ucCalendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.dgvCalendario)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ucCalendario"
        Me.Size = New System.Drawing.Size(466, 210)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgvCalendario As System.Windows.Forms.DataGridView
    Friend WithEvents DIASEM01 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASEM02 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASEM03 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASEM04 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASEM05 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASEM06 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIASEM07 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
