<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_CboUsuario
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
        Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaUsuario = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.bsaNewProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaUsuario, Me.bsaNewProv})
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUsuario.Location = New System.Drawing.Point(0, 0)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuario.MaxLength = 25
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(388, 26)
        Me.txtUsuario.TabIndex = 59
        '
        'bsaUsuario
        '
        Me.bsaUsuario.ExtraText = ""
        Me.bsaUsuario.Image = Nothing
        Me.bsaUsuario.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaUsuario.Text = ""
        Me.bsaUsuario.ToolTipImage = Nothing
        Me.bsaUsuario.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaUsuario.UniqueName = "6B2527A567DC46316B2527A567DC4631"
        '
        'bsaNewProv
        '
        Me.bsaNewProv.ExtraText = ""
        Me.bsaNewProv.Image = Nothing
        Me.bsaNewProv.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaNewProv.Text = ""
        Me.bsaNewProv.ToolTipImage = Nothing
        Me.bsaNewProv.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMax
        Me.bsaNewProv.UniqueName = "29A6D582C4D0404329A6D582C4D04043"
        Me.bsaNewProv.Visible = False
        '
        'uc_CboUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtUsuario)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "uc_CboUsuario"
        Me.Size = New System.Drawing.Size(388, 27)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaUsuario As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents bsaNewProv As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
