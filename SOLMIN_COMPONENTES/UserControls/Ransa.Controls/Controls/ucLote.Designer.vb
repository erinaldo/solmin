<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLote
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgLote = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.QMRCSL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgLote
        '
        Me.dgLote.AllowUserToAddRows = False
        Me.dgLote.AllowUserToDeleteRows = False
        Me.dgLote.ColumnHeadersHeight = 44
        Me.dgLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QMRCSL, Me.CANTIDAD, Me.Column4, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn77, Me.NCRRIN, Me.Column1})
        Me.dgLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLote.Location = New System.Drawing.Point(0, 0)
        Me.dgLote.Name = "dgLote"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgLote.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgLote.Size = New System.Drawing.Size(703, 326)
        Me.dgLote.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgLote.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgLote.TabIndex = 68
        '
        'QMRCSL
        '
        Me.QMRCSL.DataPropertyName = "QMRCSL"
        Me.QMRCSL.HeaderText = "Stock "
        Me.QMRCSL.Name = "QMRCSL"
        Me.QMRCSL.ReadOnly = True
        Me.QMRCSL.Width = 70
        '
        'CANTIDAD
        '
        Me.CANTIDAD.DataPropertyName = "CANTIDAD"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle1
        Me.CANTIDAD.HeaderText = "Cantidad Atender"
        Me.CANTIDAD.MinimumWidth = 100
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 120
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CRTLTE"
        Me.Column4.HeaderText = "Criterio de Lote"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "SF_FINGAL"
        Me.DataGridViewTextBoxColumn75.HeaderText = "Fecha Ingreso"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        Me.DataGridViewTextBoxColumn75.ReadOnly = True
        Me.DataGridViewTextBoxColumn75.Width = 101
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "SF_FPRDMR"
        Me.DataGridViewTextBoxColumn76.HeaderText = "Fecha Producción"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        Me.DataGridViewTextBoxColumn76.ReadOnly = True
        Me.DataGridViewTextBoxColumn76.Width = 120
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "SF_FVNLTE"
        Me.DataGridViewTextBoxColumn77.HeaderText = "Fecha Vencimiento"
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        Me.DataGridViewTextBoxColumn77.ReadOnly = True
        Me.DataGridViewTextBoxColumn77.Width = 126
        '
        'NCRRIN
        '
        Me.NCRRIN.DataPropertyName = "NCRRIN"
        Me.NCRRIN.HeaderText = "NCRRIN"
        Me.NCRRIN.Name = "NCRRIN"
        Me.NCRRIN.ReadOnly = True
        Me.NCRRIN.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "..."
        Me.Column1.Name = "Column1"
        '
        'ucLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgLote)
        Me.Name = "ucLote"
        Me.Size = New System.Drawing.Size(703, 326)
        CType(Me.dgLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLote As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents QMRCSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
