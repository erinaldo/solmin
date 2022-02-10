<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlComboBox
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
        Me.txtKey = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbValue = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(0, 0)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(53, 21)
        Me.txtKey.TabIndex = 2
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbValue
        '
        Me.cmbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValue.DropDownWidth = 216
        Me.cmbValue.FormattingEnabled = False
        Me.cmbValue.ItemHeight = 13
        Me.cmbValue.Location = New System.Drawing.Point(54, 0)
        Me.cmbValue.Name = "cmbValue"
        Me.cmbValue.Size = New System.Drawing.Size(216, 21)
        Me.cmbValue.TabIndex = 3
        '
        'ctrlComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.cmbValue)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlComboBox"
        Me.Size = New System.Drawing.Size(271, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKey As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbValue As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
