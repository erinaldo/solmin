<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTipoMaterial_Cmb01
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
        Me.cmbTipoMaterial = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'cmbTipoMaterial
        '
        Me.cmbTipoMaterial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMaterial.DropDownWidth = 100
        Me.cmbTipoMaterial.FormattingEnabled = False
        Me.cmbTipoMaterial.ItemHeight = 15
        Me.cmbTipoMaterial.Location = New System.Drawing.Point(0, 1)
        Me.cmbTipoMaterial.Name = "cmbTipoMaterial"
        Me.cmbTipoMaterial.Size = New System.Drawing.Size(100, 23)
        Me.cmbTipoMaterial.TabIndex = 15
        Me.cmbTipoMaterial.TabStop = False
        '
        'ucTipoMaterial_Cmb01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.cmbTipoMaterial)
        Me.MinimumSize = New System.Drawing.Size(100, 23)
        Me.Name = "ucTipoMaterial_Cmb01"
        Me.Size = New System.Drawing.Size(100, 23)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbTipoMaterial As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
