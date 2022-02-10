<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_AgenteAduana
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
    Me.txtAgenteAduana = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.bsaAgenciaAduana = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.bsaNewProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.SuspendLayout()
    '
    'txtAgenteAduana
    '
    Me.txtAgenteAduana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtAgenteAduana.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAgenciaAduana, Me.bsaNewProv})
    Me.txtAgenteAduana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtAgenteAduana.Location = New System.Drawing.Point(0, 0)
    Me.txtAgenteAduana.MaxLength = 50
    Me.txtAgenteAduana.Name = "txtAgenteAduana"
    Me.txtAgenteAduana.Size = New System.Drawing.Size(299, 21)
    Me.txtAgenteAduana.TabIndex = 55
    '
    'bsaAgenciaAduana
    '
    Me.bsaAgenciaAduana.ExtraText = ""
    Me.bsaAgenciaAduana.Image = Nothing
    Me.bsaAgenciaAduana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.bsaAgenciaAduana.Text = ""
    Me.bsaAgenciaAduana.ToolTipImage = Nothing
    Me.bsaAgenciaAduana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.bsaAgenciaAduana.UniqueName = "6B2527A567DC46316B2527A567DC4631"
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
    'uc_AgenteAduana
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.txtAgenteAduana)
    Me.Name = "uc_AgenteAduana"
    Me.Size = New System.Drawing.Size(299, 22)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtAgenteAduana As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaAgenciaAduana As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents bsaNewProv As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
