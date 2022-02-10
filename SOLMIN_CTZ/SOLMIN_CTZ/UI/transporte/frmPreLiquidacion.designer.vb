<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreLiquidacion
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UcPreLiquidacion1 = New Ransa.Controls.Transporte.ucPreLiquidacion
        Me.SuspendLayout()
        '
        'UcPreLiquidacion1
        '
        Me.UcPreLiquidacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPreLiquidacion1.Location = New System.Drawing.Point(0, 0)
        Me.UcPreLiquidacion1.Name = "UcPreLiquidacion1"
        Me.UcPreLiquidacion1.pSystem_Prefix = Nothing
        Me.UcPreLiquidacion1.pUsuario = Nothing
        Me.UcPreLiquidacion1.Size = New System.Drawing.Size(912, 566)
        Me.UcPreLiquidacion1.TabIndex = 0
        '
        'frmPreLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 566)
        Me.Controls.Add(Me.UcPreLiquidacion1)
        Me.Name = "frmPreLiquidacion"
        Me.Text = "Pre Liquidacion"
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents UcPreLiquidacion1 As Ransa.Controls.Transporte.ucPreLiquidacion
End Class
