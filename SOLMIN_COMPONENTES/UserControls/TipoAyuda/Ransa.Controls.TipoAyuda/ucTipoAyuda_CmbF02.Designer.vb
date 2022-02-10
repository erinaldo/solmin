<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTipoAyuda_CmbF02
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
        Me.cmbTipoAyuda = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbTipoAyuda
        '
        Me.cmbTipoAyuda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoAyuda.FormattingEnabled = True
        Me.cmbTipoAyuda.Location = New System.Drawing.Point(0, 0)
        Me.cmbTipoAyuda.Name = "cmbTipoAyuda"
        Me.cmbTipoAyuda.Size = New System.Drawing.Size(276, 21)
        Me.cmbTipoAyuda.TabIndex = 0
        '
        'ucTipoAyuda_CmbF02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.cmbTipoAyuda)
        Me.Name = "ucTipoAyuda_CmbF02"
        Me.Size = New System.Drawing.Size(279, 21)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbTipoAyuda As System.Windows.Forms.ComboBox

End Class
