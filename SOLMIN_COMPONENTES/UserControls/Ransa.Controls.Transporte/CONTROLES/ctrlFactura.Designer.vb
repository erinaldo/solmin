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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtReferencia1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblRef = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNumFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtReferencia2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.dtgDetalle = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReferencia1
        '
        Me.txtReferencia1.Location = New System.Drawing.Point(80, 15)
        Me.txtReferencia1.Multiline = True
        Me.txtReferencia1.Name = "txtReferencia1"
        Me.txtReferencia1.Size = New System.Drawing.Size(587, 63)
        Me.txtReferencia1.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia1.TabIndex = 4
        '
        'lblRef
        '
        Me.lblRef.Location = New System.Drawing.Point(6, 15)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(71, 16)
        Me.lblRef.TabIndex = 3
        Me.lblRef.Text = "Referencia :"
        Me.lblRef.Values.ExtraText = ""
        Me.lblRef.Values.Image = Nothing
        Me.lblRef.Values.Text = "Referencia :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNumFactura)
        Me.GroupBox1.Controls.Add(Me.lblRef)
        Me.GroupBox1.Controls.Add(Me.txtReferencia1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 85)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'lblNumFactura
        '
        Me.lblNumFactura.Location = New System.Drawing.Point(685, 26)
        Me.lblNumFactura.Name = "lblNumFactura"
        Me.lblNumFactura.Size = New System.Drawing.Size(259, 38)
        Me.lblNumFactura.StateNormal.ShortText.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumFactura.TabIndex = 5
        Me.lblNumFactura.Text = "139 N°0073890"
        Me.lblNumFactura.Values.ExtraText = ""
        Me.lblNumFactura.Values.Image = Nothing
        Me.lblNumFactura.Values.Text = "139 N°0073890"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReferencia2)
        Me.GroupBox2.Controls.Add(Me.dtgDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(964, 207)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        '
        'txtReferencia2
        '
        Me.txtReferencia2.Location = New System.Drawing.Point(6, 140)
        Me.txtReferencia2.Multiline = True
        Me.txtReferencia2.Name = "txtReferencia2"
        Me.txtReferencia2.Size = New System.Drawing.Size(952, 63)
        Me.txtReferencia2.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia2.TabIndex = 64
        '
        'dtgDetalle
        '
        Me.dtgDetalle.AllowUserToAddRows = False
        Me.dtgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDetalle.GridColor = System.Drawing.Color.White
        Me.dtgDetalle.Location = New System.Drawing.Point(6, 10)
        Me.dtgDetalle.Name = "dtgDetalle"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgDetalle.RowHeadersVisible = False
        Me.dtgDetalle.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalle.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgDetalle.Size = New System.Drawing.Size(952, 124)
        Me.dtgDetalle.TabIndex = 63
        '
        'ctrlFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ctrlFactura"
        Me.Size = New System.Drawing.Size(970, 300)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtReferencia1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblRef As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtReferencia2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNumFactura As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
