<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlFactura
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtReferencia1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblRef = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSpot = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblNumFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReferencia2 = New System.Windows.Forms.Button()
        Me.txtReferencia2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtgDetalle = New System.Windows.Forms.DataGridView()
        Me.lblDirServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnReferencia1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReferencia1
        '
        Me.txtReferencia1.Location = New System.Drawing.Point(149, 16)
        Me.txtReferencia1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencia1.Multiline = True
        Me.txtReferencia1.Name = "txtReferencia1"
        Me.txtReferencia1.Size = New System.Drawing.Size(693, 100)
        Me.txtReferencia1.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia1.TabIndex = 4
        '
        'lblRef
        '
        Me.lblRef.Location = New System.Drawing.Point(8, 14)
        Me.lblRef.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(90, 24)
        Me.lblRef.TabIndex = 3
        Me.lblRef.Text = "Referencia :"
        Me.lblRef.Values.ExtraText = ""
        Me.lblRef.Values.Image = Nothing
        Me.lblRef.Values.Text = "Referencia :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSpot)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel2)
        Me.GroupBox1.Controls.Add(Me.lblNumFactura)
        Me.GroupBox1.Controls.Add(Me.lblRef)
        Me.GroupBox1.Controls.Add(Me.txtReferencia1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1285, 120)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'lblSpot
        '
        Me.lblSpot.Location = New System.Drawing.Point(1022, 84)
        Me.lblSpot.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSpot.Name = "lblSpot"
        Me.lblSpot.Size = New System.Drawing.Size(48, 19)
        Me.lblSpot.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpot.TabIndex = 7
        Me.lblSpot.Text = "SPOT"
        Me.lblSpot.Values.ExtraText = ""
        Me.lblSpot.Values.Image = Nothing
        Me.lblSpot.Values.Text = "SPOT"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(955, 81)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Text = "% SPOT:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "% SPOT:"
        '
        'lblNumFactura
        '
        Me.lblNumFactura.Location = New System.Drawing.Point(945, 36)
        Me.lblNumFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNumFactura.Name = "lblNumFactura"
        Me.lblNumFactura.Size = New System.Drawing.Size(323, 47)
        Me.lblNumFactura.StateNormal.ShortText.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumFactura.TabIndex = 5
        Me.lblNumFactura.Text = "139 N°0073890"
        Me.lblNumFactura.Values.ExtraText = ""
        Me.lblNumFactura.Values.Image = Nothing
        Me.lblNumFactura.Values.Text = "139 N°0073890"
        '
        'txtOCompra
        '
        Me.txtOCompra.Location = New System.Drawing.Point(153, 4)
        Me.txtOCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOCompra.MaxLength = 20
        Me.txtOCompra.Name = "txtOCompra"
        Me.txtOCompra.Size = New System.Drawing.Size(262, 26)
        Me.txtOCompra.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCompra.TabIndex = 8
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 4)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(142, 24)
        Me.KryptonLabel1.TabIndex = 7
        Me.KryptonLabel1.Text = "Orden de Compra :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Orden de Compra :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReferencia2)
        Me.GroupBox2.Controls.Add(Me.txtReferencia2)
        Me.GroupBox2.Controls.Add(Me.dtgDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 153)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1285, 273)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        '
        'btnReferencia2
        '
        Me.btnReferencia2.Location = New System.Drawing.Point(1184, 168)
        Me.btnReferencia2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReferencia2.Name = "btnReferencia2"
        Me.btnReferencia2.Size = New System.Drawing.Size(95, 23)
        Me.btnReferencia2.TabIndex = 77
        Me.btnReferencia2.Text = "Referencia"
        Me.btnReferencia2.UseVisualStyleBackColor = True
        Me.btnReferencia2.Visible = False
        '
        'txtReferencia2
        '
        Me.txtReferencia2.Location = New System.Drawing.Point(8, 195)
        Me.txtReferencia2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferencia2.Multiline = True
        Me.txtReferencia2.Name = "txtReferencia2"
        Me.txtReferencia2.Size = New System.Drawing.Size(1269, 67)
        Me.txtReferencia2.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia2.TabIndex = 64
        '
        'dtgDetalle
        '
        Me.dtgDetalle.AllowUserToAddRows = False
        Me.dtgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgDetalle.GridColor = System.Drawing.Color.White
        Me.dtgDetalle.Location = New System.Drawing.Point(8, 14)
        Me.dtgDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgDetalle.Name = "dtgDetalle"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgDetalle.RowHeadersVisible = False
        Me.dtgDetalle.RowHeadersWidth = 20
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalle.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgDetalle.Size = New System.Drawing.Size(1269, 153)
        Me.dtgDetalle.TabIndex = 63
        '
        'lblDirServicio
        '
        Me.lblDirServicio.Location = New System.Drawing.Point(423, 4)
        Me.lblDirServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDirServicio.Name = "lblDirServicio"
        Me.lblDirServicio.Size = New System.Drawing.Size(18, 24)
        Me.lblDirServicio.TabIndex = 6
        Me.lblDirServicio.Text = "-"
        Me.lblDirServicio.Values.ExtraText = ""
        Me.lblDirServicio.Values.Image = Nothing
        Me.lblDirServicio.Values.Text = "-"
        '
        'btnReferencia1
        '
        Me.btnReferencia1.Location = New System.Drawing.Point(1188, 4)
        Me.btnReferencia1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReferencia1.Name = "btnReferencia1"
        Me.btnReferencia1.Size = New System.Drawing.Size(95, 28)
        Me.btnReferencia1.TabIndex = 76
        Me.btnReferencia1.Text = "Referencia"
        Me.btnReferencia1.UseVisualStyleBackColor = True
        Me.btnReferencia1.Visible = False
        '
        'ctrlFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnReferencia1)
        Me.Controls.Add(Me.txtOCompra)
        Me.Controls.Add(Me.lblDirServicio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ctrlFactura"
        Me.Size = New System.Drawing.Size(1293, 441)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReferencia1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRef As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtReferencia2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNumFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnReferencia2 As System.Windows.Forms.Button
    Friend WithEvents lblDirServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnReferencia1 As System.Windows.Forms.Button
    Friend WithEvents lblSpot As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
