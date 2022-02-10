<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCompania_Cmb01
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 156
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 20
        Me.cmbCompania.Location = New System.Drawing.Point(0, 0)
        Me.cmbCompania.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(541, 28)
        Me.cmbCompania.TabIndex = 15
        Me.cmbCompania.TabStop = False
        '
        'ucCompania_Cmb01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.cmbCompania)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(200, 28)
        Me.Name = "ucCompania_Cmb01"
        Me.Size = New System.Drawing.Size(541, 28)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
