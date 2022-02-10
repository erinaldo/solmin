<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_CboMenu
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
    Me.txtMenu = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.bsaMenu = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.bsaNewProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.SuspendLayout()
    '
    'txtMenu
    '
    Me.txtMenu.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaMenu, Me.bsaNewProv})
    Me.txtMenu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtMenu.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtMenu.Location = New System.Drawing.Point(0, 0)
    Me.txtMenu.MaxLength = 25
    Me.txtMenu.Name = "txtMenu"
    Me.txtMenu.Size = New System.Drawing.Size(299, 21)
    Me.txtMenu.TabIndex = 57
    '
    'bsaMenu
    '
    Me.bsaMenu.ExtraText = ""
    Me.bsaMenu.Image = Nothing
    Me.bsaMenu.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.bsaMenu.Text = ""
    Me.bsaMenu.ToolTipImage = Nothing
    Me.bsaMenu.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.bsaMenu.UniqueName = "6B2527A567DC46316B2527A567DC4631"
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
    'uc_CboMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtMenu)
    Me.Name = "uc_CboMenu"
    Me.Size = New System.Drawing.Size(299, 22)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtMenu As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaMenu As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents bsaNewProv As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
