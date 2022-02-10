<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaOC
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
        Me.UcItemOC_DgF01_Importar1 = New Ransa.Controls.OrdenCompra.ucItemOC_DgF01_Importar
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.UcItemOC_DgF01_Importar1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(989, 608)
        Me.KryptonPanel.TabIndex = 0
        '
        'UcItemOC_DgF01_Importar1
        '
        Me.UcItemOC_DgF01_Importar1.ActivarBotonSalir = True
        Me.UcItemOC_DgF01_Importar1.BackColor = System.Drawing.Color.Transparent
        Me.UcItemOC_DgF01_Importar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcItemOC_DgF01_Importar1.Location = New System.Drawing.Point(0, 0)
        Me.UcItemOC_DgF01_Importar1.Name = "UcItemOC_DgF01_Importar1"
        Me.UcItemOC_DgF01_Importar1.Size = New System.Drawing.Size(989, 608)
        Me.UcItemOC_DgF01_Importar1.TabIndex = 25
        '
        'frmListaOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 608)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.Name = "frmListaOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Items"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents UcItemOC_DgF01_Importar1 As Ransa.Controls.OrdenCompra.ucItemOC_DgF01_Importar
End Class
