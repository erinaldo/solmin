<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonRadioButton1 = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.SuspendLayout()
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(83, 16)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "KryptonLabel1"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "KryptonLabel1"
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(20, 40)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(100, 19)
        Me.KryptonTextBox1.TabIndex = 1
        Me.KryptonTextBox1.Text = "KryptonTextBox1"
        '
        'KryptonRadioButton1
        '
        Me.KryptonRadioButton1.Location = New System.Drawing.Point(24, 60)
        Me.KryptonRadioButton1.Name = "KryptonRadioButton1"
        Me.KryptonRadioButton1.Size = New System.Drawing.Size(130, 16)
        Me.KryptonRadioButton1.TabIndex = 2
        Me.KryptonRadioButton1.Text = "KryptonRadioButton1"
        Me.KryptonRadioButton1.Values.ExtraText = ""
        Me.KryptonRadioButton1.Values.Image = Nothing
        Me.KryptonRadioButton1.Values.Text = "KryptonRadioButton1"
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.Checked = False
        Me.KryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(20, 88)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(120, 16)
        Me.KryptonCheckBox1.TabIndex = 3
        Me.KryptonCheckBox1.Text = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Values.ExtraText = ""
        Me.KryptonCheckBox1.Values.Image = Nothing
        Me.KryptonCheckBox1.Values.Text = "KryptonCheckBox1"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonCheckBox1)
        Me.Controls.Add(Me.KryptonRadioButton1)
        Me.Controls.Add(Me.KryptonTextBox1)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Name = "UserControl1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonRadioButton1 As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox

End Class
