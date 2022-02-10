<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAcoplado_TxtF01
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
    Me.components = New System.ComponentModel.Container
    Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Me.txtAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.bsaAcoplado = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.SuspendLayout()
    '
    'txtAcoplado
    '
    Me.txtAcoplado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtAcoplado.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAcoplado})
    Me.txtAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.TypeValidator.SetEnterTAB(Me.txtAcoplado, True)
    Me.txtAcoplado.Location = New System.Drawing.Point(0, 0)
    Me.txtAcoplado.MaxLength = 50
    Me.txtAcoplado.Name = "txtAcoplado"
    Me.txtAcoplado.Size = New System.Drawing.Size(258, 21)
    Me.txtAcoplado.TabIndex = 55
    Me.TypeValidator.SetTypes(Me.txtAcoplado, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
    '
    'bsaAcoplado
    '
    Me.bsaAcoplado.ExtraText = ""
    Me.bsaAcoplado.Image = Nothing
    Me.bsaAcoplado.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.bsaAcoplado.Text = ""
    Me.bsaAcoplado.ToolTipImage = Nothing
    Me.bsaAcoplado.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.bsaAcoplado.UniqueName = "6B2527A567DC46316B2527A567DC4631"
    '
    'ucAcoplado_TxtF01
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.BackColor = System.Drawing.Color.Transparent
    Me.Controls.Add(Me.txtAcoplado)
    Me.Name = "ucAcoplado_TxtF01"
    Me.Size = New System.Drawing.Size(258, 19)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents txtAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaAcoplado As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
