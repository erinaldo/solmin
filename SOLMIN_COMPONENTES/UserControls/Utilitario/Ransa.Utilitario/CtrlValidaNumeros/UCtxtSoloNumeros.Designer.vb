<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtxtSoloNumeros
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
        Me.txtSoloNumeros = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.SuspendLayout()
        '
        'txtSoloNumeros
        '
        Me.txtSoloNumeros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSoloNumeros.Location = New System.Drawing.Point(0, 0)
        Me.txtSoloNumeros.Name = "txtSoloNumeros"
        Me.txtSoloNumeros.Size = New System.Drawing.Size(281, 21)
        Me.txtSoloNumeros.TabIndex = 0
        Me.txtSoloNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UCtxtSoloNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtSoloNumeros)
        Me.Name = "UCtxtSoloNumeros"
        Me.Size = New System.Drawing.Size(281, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSoloNumeros As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
