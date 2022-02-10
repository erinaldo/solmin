<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAyudaConectado
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
        Me.txtAyuda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAyuda = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.SuspendLayout()
        '
        'txtAyuda
        '
        Me.txtAyuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAyuda.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAyuda})
        Me.txtAyuda.Location = New System.Drawing.Point(0, 0)
        Me.txtAyuda.Name = "txtAyuda"
        Me.txtAyuda.Size = New System.Drawing.Size(157, 21)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtAyuda)
        Me.Name = "ucAyuda"
        Me.Size = New System.Drawing.Size(158, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAyuda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAyuda As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
