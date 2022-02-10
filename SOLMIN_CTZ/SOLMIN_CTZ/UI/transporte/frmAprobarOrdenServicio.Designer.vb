<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAprobarOrdenServicio
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
        Me.UcAprobarOrdenServicio1 = New Ransa.Controls.Transporte.ucAprobarOrdenServicio()
        Me.SuspendLayout()
        '
        'UcAprobarOrdenServicio1
        '
        Me.UcAprobarOrdenServicio1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcAprobarOrdenServicio1.Location = New System.Drawing.Point(0, 0)
        Me.UcAprobarOrdenServicio1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcAprobarOrdenServicio1.Name = "UcAprobarOrdenServicio1"
        Me.UcAprobarOrdenServicio1.pNameFormulario = ""
        Me.UcAprobarOrdenServicio1.pSystem_Prefix = Nothing
        Me.UcAprobarOrdenServicio1.pUsuario = Nothing
        Me.UcAprobarOrdenServicio1.Size = New System.Drawing.Size(1341, 566)
        Me.UcAprobarOrdenServicio1.TabIndex = 0
        '
        'frmAprobarOrdenServicio
        '
        Me.ClientSize = New System.Drawing.Size(1341, 566)
        Me.Controls.Add(Me.UcAprobarOrdenServicio1)
        Me.Name = "frmAprobarOrdenServicio"
        Me.Text = "Aprobar Orden Servicio"
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
    Friend WithEvents UcAprobarOrdenServicio1 As Ransa.Controls.Transporte.ucAprobarOrdenServicio

End Class
