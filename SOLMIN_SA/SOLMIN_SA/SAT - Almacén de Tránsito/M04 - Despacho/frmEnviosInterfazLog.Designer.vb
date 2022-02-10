<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnviosInterfazLog
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip()
        Me.dgGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(797, 25)
        Me.tspListadoMercaderia.TabIndex = 80
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'dgGuiasRemision
        '
        Me.dgGuiasRemision.AllowUserToAddRows = False
        Me.dgGuiasRemision.AllowUserToDeleteRows = False
        Me.dgGuiasRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGuiasRemision.Location = New System.Drawing.Point(0, 25)
        Me.dgGuiasRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.dgGuiasRemision.MultiSelect = False
        Me.dgGuiasRemision.Name = "dgGuiasRemision"
        Me.dgGuiasRemision.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGuiasRemision.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGuiasRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRemision.Size = New System.Drawing.Size(797, 436)
        Me.dgGuiasRemision.StandardTab = True
        Me.dgGuiasRemision.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRemision.TabIndex = 81
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 72
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Usuario"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 92
        '
        'Column4
        '
        Me.Column4.HeaderText = "Mensaje"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 97
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'frmEnviosInterfazLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 461)
        Me.Controls.Add(Me.dgGuiasRemision)
        Me.Controls.Add(Me.tspListadoMercaderia)
        Me.Name = "frmEnviosInterfazLog"
        Me.Text = "Interfaz Envío"
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents dgGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
