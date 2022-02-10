<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_CboAplicacion
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
    Me.txtAplicacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.bsaAplicacion = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.bsaNewProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.SuspendLayout()
    '
    'txtAplicacion
    '
    Me.txtAplicacion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAplicacion, Me.bsaNewProv})
    Me.txtAplicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtAplicacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtAplicacion.Location = New System.Drawing.Point(0, 0)
    Me.txtAplicacion.MaxLength = 25
    Me.txtAplicacion.Name = "txtAplicacion"
    Me.txtAplicacion.Size = New System.Drawing.Size(299, 21)
    Me.txtAplicacion.TabIndex = 55
    '
    'bsaAplicacion
    '
    Me.bsaAplicacion.ExtraText = ""
    Me.bsaAplicacion.Image = Nothing
    Me.bsaAplicacion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.bsaAplicacion.Text = ""
    Me.bsaAplicacion.ToolTipImage = Nothing
    Me.bsaAplicacion.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.bsaAplicacion.UniqueName = "6B2527A567DC46316B2527A567DC4631"
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
    'uc_CboAplicacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtAplicacion)
    Me.Name = "uc_CboAplicacion"
    Me.Size = New System.Drawing.Size(299, 21)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtAplicacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaAplicacion As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents bsaNewProv As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
