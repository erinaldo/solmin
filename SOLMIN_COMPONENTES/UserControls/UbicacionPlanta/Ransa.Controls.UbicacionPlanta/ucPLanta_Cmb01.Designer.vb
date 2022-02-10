<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPLanta_Cmb01
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
        Me.cmbPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'cmbPlanta
        '
        Me.cmbPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlanta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.DropDownWidth = 156
        Me.cmbPlanta.FormattingEnabled = False
        Me.cmbPlanta.ItemHeight = 17
        Me.cmbPlanta.Location = New System.Drawing.Point(0, 0)
        Me.cmbPlanta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(200, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(379, 25)
        Me.cmbPlanta.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlanta.TabIndex = 14
        Me.cmbPlanta.TabStop = False
        '
        'ucPLanta_Cmb01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cmbPlanta)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(200, 26)
        Me.Name = "ucPLanta_Cmb01"
        Me.Size = New System.Drawing.Size(379, 26)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
