<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDivision_Cmb01
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
        Me.cmbDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'cmbDivision
        '
        Me.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDivision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.DropDownWidth = 156
        Me.cmbDivision.FormattingEnabled = False
        Me.cmbDivision.ItemHeight = 20
        Me.cmbDivision.Location = New System.Drawing.Point(0, 0)
        Me.cmbDivision.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(200, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(373, 28)
        Me.cmbDivision.TabIndex = 14
        Me.cmbDivision.TabStop = False
        '
        'ucDivision_Cmb01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cmbDivision)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(200, 26)
        Me.Name = "ucDivision_Cmb01"
        Me.Size = New System.Drawing.Size(373, 28)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
