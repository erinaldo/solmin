<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_CboOpcion
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
    Me.txtOpcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.bsaOpcion = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.bsaNewProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.SuspendLayout()
    '
    'txtOpcion
    '
    Me.txtOpcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaOpcion, Me.bsaNewProv})
    Me.txtOpcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtOpcion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtOpcion.Location = New System.Drawing.Point(0, 0)
    Me.txtOpcion.MaxLength = 25
    Me.txtOpcion.Name = "txtOpcion"
    Me.txtOpcion.Size = New System.Drawing.Size(299, 21)
    Me.txtOpcion.TabIndex = 58
    '
    'bsaOpcion
    '
    Me.bsaOpcion.ExtraText = ""
    Me.bsaOpcion.Image = Nothing
    Me.bsaOpcion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.bsaOpcion.Text = ""
    Me.bsaOpcion.ToolTipImage = Nothing
    Me.bsaOpcion.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.bsaOpcion.UniqueName = "6B2527A567DC46316B2527A567DC4631"
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
    'uc_CboOpcion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtOpcion)
    Me.Name = "uc_CboOpcion"
    Me.Size = New System.Drawing.Size(299, 22)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtOpcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaOpcion As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents bsaNewProv As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
