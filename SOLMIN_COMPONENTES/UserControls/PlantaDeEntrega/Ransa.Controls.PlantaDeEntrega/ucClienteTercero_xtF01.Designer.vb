<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClienteTercero_xtF01
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
        Me.txtClienteTercero = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaPlantaDeEntrega = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SuspendLayout()
        '
        'txtClienteTercero
        '
        Me.txtClienteTercero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClienteTercero.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPlantaDeEntrega})
        Me.txtClienteTercero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtClienteTercero, True)
        Me.txtClienteTercero.Location = New System.Drawing.Point(0, 0)
        Me.txtClienteTercero.MaxLength = 50
        Me.txtClienteTercero.Name = "txtClienteTercero"
        Me.txtClienteTercero.Size = New System.Drawing.Size(258, 21)
        Me.txtClienteTercero.TabIndex = 55
        Me.TypeValidator.SetTypes(Me.txtClienteTercero, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
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
        'ucClienteTercero_xtF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtClienteTercero)
        Me.Name = "ucClienteTercero_xtF01"
        Me.Size = New System.Drawing.Size(258, 19)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents txtClienteTercero As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaPlantaDeEntrega As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
