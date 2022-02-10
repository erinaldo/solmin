<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProveedor_TxtF01
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.txtProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaProveedor = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.bsaNewProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.SuspendLayout()
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProveedor.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaProveedor, Me.bsaNewProv})
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtProveedor, True)
        Me.txtProveedor.Location = New System.Drawing.Point(0, 0)
        Me.txtProveedor.MaxLength = 50
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(258, 19)
        Me.txtProveedor.TabIndex = 54
        Me.TypeValidator.SetTypes(Me.txtProveedor, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaProveedor
        '
        Me.bsaProveedor.ExtraText = ""
        Me.bsaProveedor.Image = Nothing
        Me.bsaProveedor.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaProveedor.Text = ""
        Me.bsaProveedor.ToolTipImage = Nothing
        Me.bsaProveedor.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaProveedor.UniqueName = "6B2527A567DC46316B2527A567DC4631"
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
        'ucProveedor_TxtF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtProveedor)
        Me.Name = "ucProveedor_TxtF01"
        Me.Size = New System.Drawing.Size(258, 19)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaProveedor As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaNewProv As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
