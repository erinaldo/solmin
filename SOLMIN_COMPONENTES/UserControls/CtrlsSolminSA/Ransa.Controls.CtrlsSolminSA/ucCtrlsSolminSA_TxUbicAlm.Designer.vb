<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCtrlsSolminSA_TxUbicAlm
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
        Me.txtUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaBuscarUbicacion = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.bgwGetData = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'txtUbicacion
        '
        Me.txtUbicacion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaBuscarUbicacion})
        Me.TypeValidator.SetEnterTAB(Me.txtUbicacion, True)
        Me.txtUbicacion.Location = New System.Drawing.Point(0, 0)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(284, 19)
        Me.txtUbicacion.TabIndex = 0
        Me.TypeValidator.SetTypes(Me.txtUbicacion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaBuscarUbicacion
        '
        Me.bsaBuscarUbicacion.ExtraText = ""
        Me.bsaBuscarUbicacion.Image = Nothing
        Me.bsaBuscarUbicacion.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
        Me.bsaBuscarUbicacion.Text = ""
        Me.bsaBuscarUbicacion.ToolTipImage = Nothing
        Me.bsaBuscarUbicacion.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaBuscarUbicacion.UniqueName = "7DBCA8F7A5F941C77DBCA8F7A5F941C7"
        '
        'bgwGetData
        '
        '
        'ucCtrlsSolminSA_TxUbicAlm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtUbicacion)
        Me.Name = "ucCtrlsSolminSA_TxUbicAlm"
        Me.Size = New System.Drawing.Size(284, 19)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Private WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtUbicacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaBuscarUbicacion As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bgwGetData As System.ComponentModel.BackgroundWorker

End Class
