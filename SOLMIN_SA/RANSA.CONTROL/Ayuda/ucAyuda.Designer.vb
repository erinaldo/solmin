<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAyuda
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
        Me.txtAyuda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnAyuda = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.SuspendLayout()
        '
        'txtAyuda
        '
        Me.txtAyuda.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAyuda})
        Me.txtAyuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAyuda.Location = New System.Drawing.Point(0, 0)
        Me.txtAyuda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAyuda.Name = "txtAyuda"
        Me.txtAyuda.Size = New System.Drawing.Size(211, 26)
        Me.txtAyuda.TabIndex = 0
        '
        'btnAyuda
        '
        Me.btnAyuda.ExtraText = ""
        Me.btnAyuda.Image = Nothing
        Me.btnAyuda.Text = ""
        Me.btnAyuda.ToolTipImage = Nothing
        Me.btnAyuda.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAyuda.UniqueName = "49E3634C8A8344A049E3634C8A8344A0"
        '
        'ucAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtAyuda)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucAyuda"
        Me.Size = New System.Drawing.Size(211, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAyuda As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents txtAyuda As ComponentFactory.Krypton.Toolkit.KryptonTextBox

End Class
