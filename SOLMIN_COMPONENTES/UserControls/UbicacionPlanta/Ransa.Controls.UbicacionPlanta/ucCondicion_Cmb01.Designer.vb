<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCondicion_Cmb01
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
        Me.cmbCondicion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'cmbCondicion
        '
        Me.cmbCondicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCondicion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondicion.DropDownWidth = 100
        Me.cmbCondicion.FormattingEnabled = False
        Me.cmbCondicion.ItemHeight = 15
        Me.cmbCondicion.Location = New System.Drawing.Point(0, 1)
        Me.cmbCondicion.Name = "cmbTipoMaterial"
        Me.cmbCondicion.Size = New System.Drawing.Size(100, 23)
        Me.cmbCondicion.TabIndex = 15
        Me.cmbCondicion.TabStop = False
        '
        'ucCondicion_Cmb01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.cmbCondicion)
        Me.MinimumSize = New System.Drawing.Size(100, 23)
        Me.Name = "ucCondicion_Cmb01"
        Me.Size = New System.Drawing.Size(100, 23)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbCondicion As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
