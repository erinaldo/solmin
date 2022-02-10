<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTipoTransporte
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
        Me.cboTipoTransporte = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.SuspendLayout()
        '
        'cboTipoTransporte
        '
        Me.cboTipoTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoTransporte.DropDownWidth = 149
        Me.cboTipoTransporte.FormattingEnabled = False
        Me.cboTipoTransporte.ItemHeight = 13
        Me.cboTipoTransporte.Location = New System.Drawing.Point(0, 0)
        Me.cboTipoTransporte.Name = "cboTipoTransporte"
        Me.cboTipoTransporte.Size = New System.Drawing.Size(170, 21)
        Me.cboTipoTransporte.TabIndex = 0
        '
        'ucTipoTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cboTipoTransporte)
        Me.Name = "ucTipoTransporte"
        Me.Size = New System.Drawing.Size(170, 21)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboTipoTransporte As ComponentFactory.Krypton.Toolkit.KryptonComboBox

End Class
