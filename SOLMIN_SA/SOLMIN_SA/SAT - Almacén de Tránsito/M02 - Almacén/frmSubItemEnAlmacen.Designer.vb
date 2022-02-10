<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubItemEnAlmacen
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
        Me.UcSubItemOcEnAlmacen_DgF011 = New Ransa.Controls.OrdenCompra.ucSubItemOcEnAlmacen_DgF01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.UcSubItemOcEnAlmacen_DgF011)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(692, 216)
        Me.KryptonPanel.TabIndex = 0
        '
        'UcSubItemOcEnAlmacen_DgF011
        '
        Me.UcSubItemOcEnAlmacen_DgF011.BackColor = System.Drawing.Color.Transparent
        Me.UcSubItemOcEnAlmacen_DgF011.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcSubItemOcEnAlmacen_DgF011.Location = New System.Drawing.Point(0, 0)
        Me.UcSubItemOcEnAlmacen_DgF011.Name = "UcSubItemOcEnAlmacen_DgF011"
        Me.UcSubItemOcEnAlmacen_DgF011.Size = New System.Drawing.Size(692, 216)
        Me.UcSubItemOcEnAlmacen_DgF011.TabIndex = 0
        '
        'frmSubItemEnAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 216)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 250)
        Me.Name = "frmSubItemEnAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubItems En Almacen"
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
    Friend WithEvents UcSubItemOcEnAlmacen_DgF011 As Ransa.Controls.OrdenCompra.ucSubItemOcEnAlmacen_DgF01
End Class
