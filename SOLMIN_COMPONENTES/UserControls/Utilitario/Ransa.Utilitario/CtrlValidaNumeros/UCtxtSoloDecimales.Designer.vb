<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtxtSoloDecimales
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
        Me.txtDecimales = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.SuspendLayout()
        '
        'txtDecimales
        '
        Me.txtDecimales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDecimales.Location = New System.Drawing.Point(0, 0)
        Me.txtDecimales.MaxLength = 30
        Me.txtDecimales.Name = "txtDecimales"
        Me.txtDecimales.Size = New System.Drawing.Size(58, 21)
        Me.txtDecimales.TabIndex = 0
        Me.txtDecimales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UCtxtSoloDecimales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtDecimales)
        Me.Name = "UCtxtSoloDecimales"
        Me.Size = New System.Drawing.Size(58, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtDecimales As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
