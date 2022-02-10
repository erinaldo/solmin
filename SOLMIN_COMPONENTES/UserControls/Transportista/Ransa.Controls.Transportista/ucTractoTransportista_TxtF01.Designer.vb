<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTractoTransportista_TxtF01
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
        Me.txtTractoTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTractoTransportista = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SuspendLayout()
        '
        'txtTractoTransportista
        '
        Me.txtTractoTransportista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTractoTransportista.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTractoTransportista})
        Me.txtTractoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTractoTransportista, True)
        Me.txtTractoTransportista.Location = New System.Drawing.Point(0, 0)
        Me.txtTractoTransportista.MaxLength = 50
        Me.txtTractoTransportista.Name = "txtTractoTransportista"
        Me.txtTractoTransportista.Size = New System.Drawing.Size(258, 19)
        Me.txtTractoTransportista.TabIndex = 55
        Me.TypeValidator.SetTypes(Me.txtTractoTransportista, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaTractoTransportista
        '
        Me.bsaTractoTransportista.ExtraText = ""
        Me.bsaTractoTransportista.Image = Nothing
        Me.bsaTractoTransportista.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaTractoTransportista.Text = ""
        Me.bsaTractoTransportista.ToolTipImage = Nothing
        Me.bsaTractoTransportista.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTractoTransportista.UniqueName = "6B2527A567DC46316B2527A567DC4631"
        '
        'ucTractoTransportista_TxtF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtTractoTransportista)
        Me.Name = "ucTractoTransportista_TxtF01"
        Me.Size = New System.Drawing.Size(258, 19)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents txtTractoTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTractoTransportista As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
