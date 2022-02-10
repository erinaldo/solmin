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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtReferencia1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblRef = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.pnlDetraccion = New System.Windows.Forms.Panel()
        Me.lblPorcentajeDetraccion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblValorReferencia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumFactura = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtReferencia2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtgDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.pnlDetraccion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReferencia1
        '
        Me.txtReferencia1.Location = New System.Drawing.Point(136, 43)
        Me.txtReferencia1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReferencia1.MaxLength = 280
        Me.txtReferencia1.Multiline = True
        Me.txtReferencia1.Name = "txtReferencia1"
        Me.txtReferencia1.Size = New System.Drawing.Size(744, 84)
        Me.txtReferencia1.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia1.TabIndex = 4
        '
        'lblRef
        '
        Me.lblRef.Location = New System.Drawing.Point(4, 43)
        Me.lblRef.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.GroupBox1.Controls.Add(Me.lblOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.txtOCompra)
        Me.GroupBox1.Controls.Add(Me.pnlDetraccion)
        Me.GroupBox1.Controls.Add(Me.lblNumFactura)
        Me.GroupBox1.Controls.Add(Me.lblRef)
        Me.GroupBox1.Controls.Add(Me.txtReferencia1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1285, 127)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(3, 12)
        Me.lblOrdenCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(120, 24)
        Me.lblOrdenCompra.TabIndex = 8
        Me.lblOrdenCompra.Text = "Orden Compra :"
        Me.lblOrdenCompra.Values.ExtraText = ""
        Me.lblOrdenCompra.Values.Image = Nothing
        Me.lblOrdenCompra.Values.Text = "Orden Compra :"
        '
        'txtOCompra
        '
        Me.txtOCompra.Location = New System.Drawing.Point(136, 12)
        Me.txtOCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOCompra.MaxLength = 20
        Me.txtOCompra.Name = "txtOCompra"
        Me.txtOCompra.Size = New System.Drawing.Size(318, 26)
        Me.txtOCompra.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOCompra.TabIndex = 7
        '
        'pnlDetraccion
        '
        Me.pnlDetraccion.Controls.Add(Me.lblPorcentajeDetraccion)
        Me.pnlDetraccion.Controls.Add(Me.Label4)
        Me.pnlDetraccion.Controls.Add(Me.lblValorReferencia)
        Me.pnlDetraccion.Controls.Add(Me.Label1)
        Me.pnlDetraccion.Location = New System.Drawing.Point(885, 70)
        Me.pnlDetraccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDetraccion.Name = "pnlDetraccion"
        Me.pnlDetraccion.Size = New System.Drawing.Size(392, 27)
        Me.pnlDetraccion.TabIndex = 6
        Me.pnlDetraccion.Visible = False
        '
        'lblPorcentajeDetraccion
        '
        Me.lblPorcentajeDetraccion.AutoSize = True
        Me.lblPorcentajeDetraccion.Location = New System.Drawing.Point(283, 4)
        Me.lblPorcentajeDetraccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPorcentajeDetraccion.Name = "lblPorcentajeDetraccion"
        Me.lblPorcentajeDetraccion.Size = New System.Drawing.Size(36, 17)
        Me.lblPorcentajeDetraccion.TabIndex = 3
        Me.lblPorcentajeDetraccion.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(201, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "% SPOT:"
        '
        'lblValorReferencia
        '
        Me.lblValorReferencia.AutoSize = True
        Me.lblValorReferencia.Location = New System.Drawing.Point(120, 4)
        Me.lblValorReferencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorReferencia.Name = "lblValorReferencia"
        Me.lblValorReferencia.Size = New System.Drawing.Size(0, 17)
        Me.lblValorReferencia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor Ref.(s/.):"
        '
        'lblNumFactura
        '
        Me.lblNumFactura.Location = New System.Drawing.Point(913, 30)
        Me.lblNumFactura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNumFactura.Name = "lblNumFactura"
        Me.lblNumFactura.Size = New System.Drawing.Size(323, 47)
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
        Me.GroupBox2.Location = New System.Drawing.Point(4, 121)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1285, 260)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        '
        'txtReferencia2
        '
        Me.txtReferencia2.Location = New System.Drawing.Point(8, 176)
        Me.txtReferencia2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReferencia2.Multiline = True
        Me.txtReferencia2.Name = "txtReferencia2"
        Me.txtReferencia2.Size = New System.Drawing.Size(1269, 78)
        Me.txtReferencia2.StateNormal.Content.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia2.TabIndex = 64
        '
        'dtgDetalle
        '
        Me.dtgDetalle.AllowUserToAddRows = False
        Me.dtgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDetalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDetalle.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtgDetalle.GridColor = System.Drawing.Color.White
        Me.dtgDetalle.Location = New System.Drawing.Point(8, 22)
        Me.dtgDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgDetalle.Name = "dtgDetalle"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgDetalle.RowHeadersVisible = False
        Me.dtgDetalle.RowHeadersWidth = 20
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgDetalle.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgDetalle.Size = New System.Drawing.Size(1269, 153)
        Me.dtgDetalle.TabIndex = 63
        '
        'ctrlFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ctrlFactura"
        Me.Size = New System.Drawing.Size(1293, 385)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlDetraccion.ResumeLayout(False)
        Me.pnlDetraccion.PerformLayout()
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
    Friend WithEvents pnlDetraccion As System.Windows.Forms.Panel
    Friend WithEvents lblValorReferencia As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPorcentajeDetraccion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
