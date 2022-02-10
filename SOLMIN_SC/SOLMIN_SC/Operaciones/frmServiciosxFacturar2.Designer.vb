<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiciosxFacturar2
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
        Me.UcServicioPorFacturar = New Ransa.Controls.ServicioOperacion.UCServicioPorFacturar
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.UcServicioPorFacturar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(759, 488)
        Me.KryptonPanel.TabIndex = 0
        '
        'UcServicioPorFacturar
        '
        Me.UcServicioPorFacturar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcServicioPorFacturar.Location = New System.Drawing.Point(0, 0)
        Me.UcServicioPorFacturar.Name = "UcServicioPorFacturar"
        Me.UcServicioPorFacturar.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Todos
        Me.UcServicioPorFacturar.pTipoAlmacen = Ransa.Controls.ServicioOperacion.Comun.eTipoAlmacen.NoAplica
        Me.UcServicioPorFacturar.pUsuario = "SOLMIN"
        Me.UcServicioPorFacturar.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.Defaults
        Me.UcServicioPorFacturar.Size = New System.Drawing.Size(759, 488)
        Me.UcServicioPorFacturar.TabIndex = 0
        '
        'frmServiciosxFacturar2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 488)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmServiciosxFacturar2"
        Me.Text = "Facturación de Operaciones"
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
    Friend WithEvents UcServicioPorFacturar As Ransa.Controls.ServicioOperacion.UCServicioPorFacturar
End Class
