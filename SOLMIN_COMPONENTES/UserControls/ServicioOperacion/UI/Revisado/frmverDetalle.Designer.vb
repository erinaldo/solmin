<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmverDetalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.txtOC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOC
        '
        Me.txtOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOC.Location = New System.Drawing.Point(0, 0)
        Me.txtOC.Multiline = True
        Me.txtOC.Name = "txtOC"
        Me.txtOC.ReadOnly = True
        Me.txtOC.Size = New System.Drawing.Size(514, 518)
        Me.txtOC.TabIndex = 0
        '
        'frmverDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 518)
        Me.Controls.Add(Me.txtOC)
        Me.Name = "frmverDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "lista OC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOC As System.Windows.Forms.TextBox
End Class
