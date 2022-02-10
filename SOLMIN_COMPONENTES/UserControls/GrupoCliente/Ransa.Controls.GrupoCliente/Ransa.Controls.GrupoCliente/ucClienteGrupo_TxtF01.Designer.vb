<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClienteGrupo_TxtF01
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
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaCliente = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaCliente})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(0, 0)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(289, 21)
        Me.txtCliente.TabIndex = 56
        '
        'bsaCliente
        '
        Me.bsaCliente.ExtraText = ""
        Me.bsaCliente.Image = Nothing
        Me.bsaCliente.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaCliente.Text = ""
        Me.bsaCliente.ToolTipImage = Nothing
        Me.bsaCliente.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaCliente.UniqueName = "6B2527A567DC46316B2527A567DC4631"
        '
        'ucClienteGrupo_TxtF01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtCliente)
        Me.Name = "ucClienteGrupo_TxtF01"
        Me.Size = New System.Drawing.Size(289, 22)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaCliente As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

End Class
