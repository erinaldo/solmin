<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPlantaDeEntrega_TxtF01
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
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.txtPlantaDeEntrega = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaPlantaDeEntrega = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager()
        Me.SuspendLayout()
        '
        'txtPlantaDeEntrega
        '
        Me.txtPlantaDeEntrega.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPlantaDeEntrega})
        Me.txtPlantaDeEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtPlantaDeEntrega, True)
        Me.txtPlantaDeEntrega.Location = New System.Drawing.Point(0, 0)
        Me.txtPlantaDeEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPlantaDeEntrega.MaxLength = 50
        Me.txtPlantaDeEntrega.Name = "txtPlantaDeEntrega"
        Me.txtPlantaDeEntrega.Size = New System.Drawing.Size(344, 26)
        Me.txtPlantaDeEntrega.TabIndex = 55
        '
        'bsaPlantaDeEntrega
        '
        Me.bsaPlantaDeEntrega.ExtraText = ""
        Me.bsaPlantaDeEntrega.Image = Nothing
        Me.bsaPlantaDeEntrega.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaPlantaDeEntrega.Text = ""
        Me.bsaPlantaDeEntrega.ToolTipImage = Nothing
        Me.bsaPlantaDeEntrega.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaPlantaDeEntrega.UniqueName = "6B2527A567DC46316B2527A567DC4631"
        '
        'ucPlantaDeEntrega_TxtF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtPlantaDeEntrega)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucPlantaDeEntrega_TxtF01"
        Me.Size = New System.Drawing.Size(344, 23)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents txtPlantaDeEntrega As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaPlantaDeEntrega As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
