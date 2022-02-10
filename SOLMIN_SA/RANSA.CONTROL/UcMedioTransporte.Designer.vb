<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMedioTransporte
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
        Me.txtMedioTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnAyuda = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.SuspendLayout()
        '
        'txtMedioTransporte
        '
        Me.txtMedioTransporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedioTransporte.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAyuda})
        Me.txtMedioTransporte.Location = New System.Drawing.Point(0, 0)
        Me.txtMedioTransporte.Name = "txtMedioTransporte"
        Me.txtMedioTransporte.Size = New System.Drawing.Size(162, 21)
        Me.txtMedioTransporte.TabIndex = 27
        '
        'btnAyuda
        '
        Me.btnAyuda.ExtraText = ""
        Me.btnAyuda.Image = Nothing
        Me.btnAyuda.Text = ""
        Me.btnAyuda.ToolTipImage = Nothing
        Me.btnAyuda.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAyuda.UniqueName = "C1EB01B205CE4D7DC1EB01B205CE4D7D"
        '
        'UcMedioTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtMedioTransporte)
        Me.Name = "UcMedioTransporte"
        Me.Size = New System.Drawing.Size(165, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMedioTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAyuda As ComponentFactory.Krypton.Toolkit.ButtonSpecAny

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class
