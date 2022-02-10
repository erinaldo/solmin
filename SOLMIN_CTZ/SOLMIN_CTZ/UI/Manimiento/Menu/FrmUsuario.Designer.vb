<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
    Me.components = New System.ComponentModel.Container
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.UcUsuarioBusq1 = New Ransa.Controls.Menu.ucUsuarioBusq
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.UcUsuarioBusq1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(881, 626)
    Me.KryptonPanel.TabIndex = 0
    '
    'UcUsuarioBusq1
    '
    Me.UcUsuarioBusq1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UcUsuarioBusq1.Location = New System.Drawing.Point(0, 0)
    Me.UcUsuarioBusq1.Name = "UcUsuarioBusq1"
    Me.UcUsuarioBusq1.pInfo_MMCUSR = ""
    Me.UcUsuarioBusq1.pInfo_MMNUSR = ""
    Me.UcUsuarioBusq1.pnumReg = CType(0, Long)
    Me.UcUsuarioBusq1.pVerBotonBuscar = True
    Me.UcUsuarioBusq1.pVerBotonEliminar = True
    Me.UcUsuarioBusq1.pVerBotonExportar = True
    Me.UcUsuarioBusq1.pVerBotonModificar = True
    Me.UcUsuarioBusq1.pVerBotonNuevo = True
    Me.UcUsuarioBusq1.Size = New System.Drawing.Size(881, 626)
    Me.UcUsuarioBusq1.TabIndex = 0
    '
    'FrmUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(881, 626)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "FrmUsuario"
    Me.Text = "Usuarios"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
  End Sub
  Friend WithEvents UcUsuarioBusq1 As Ransa.Controls.Menu.ucUsuarioBusq
End Class
