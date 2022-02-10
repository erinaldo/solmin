<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaRegistroIncidencias
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
        Me.UcRegistroDeIncidencias1 = New Ransa.Controls.Incidencia.ucRegistroDeIncidencias
        Me.SuspendLayout()
        '
        'UcRegistroDeIncidencias1
        '
        Me.UcRegistroDeIncidencias1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcRegistroDeIncidencias1.Location = New System.Drawing.Point(0, 0)
        Me.UcRegistroDeIncidencias1.Name = "UcRegistroDeIncidencias1"
        Me.UcRegistroDeIncidencias1.pUsuario = Nothing
        Me.UcRegistroDeIncidencias1.Size = New System.Drawing.Size(867, 604)
        Me.UcRegistroDeIncidencias1.TabIndex = 0
        '
        'frmListaRegistroIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 604)
        Me.Controls.Add(Me.UcRegistroDeIncidencias1)
        Me.Name = "frmListaRegistroIncidencias"
        Me.Text = "Registro de incidencias"
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
    Friend WithEvents UcRegistroDeIncidencias1 As Ransa.Controls.Incidencia.ucRegistroDeIncidencias
End Class
