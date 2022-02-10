<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseSiDetalle
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
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.HGPrincipal = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.HGAbajo = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.SuspendLayout()
        CType(Me.HGPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGPrincipal.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGPrincipal.SuspendLayout()
        CType(Me.HGAbajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGAbajo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGAbajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.HGAbajo)
        Me.KryptonPanel.Controls.Add(Me.HGPrincipal)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(829, 507)
        Me.KryptonPanel.TabIndex = 0
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Name = "HGFiltro"
        Me.HGFiltro.Size = New System.Drawing.Size(829, 136)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 0
        Me.HGFiltro.Text = "Filtro"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Filtro"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'HGPrincipal
        '
        Me.HGPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGPrincipal.HeaderVisibleSecondary = False
        Me.HGPrincipal.Location = New System.Drawing.Point(0, 136)
        Me.HGPrincipal.Name = "HGPrincipal"
        Me.HGPrincipal.Size = New System.Drawing.Size(829, 371)
        Me.HGPrincipal.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGPrincipal.TabIndex = 1
        Me.HGPrincipal.Text = "[]"
        Me.HGPrincipal.ValuesPrimary.Description = ""
        Me.HGPrincipal.ValuesPrimary.Heading = "[]"
        Me.HGPrincipal.ValuesPrimary.Image = Nothing
        Me.HGPrincipal.ValuesSecondary.Description = ""
        Me.HGPrincipal.ValuesSecondary.Heading = "Description"
        Me.HGPrincipal.ValuesSecondary.Image = Nothing
        '
        'HGAbajo
        '
        Me.HGAbajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HGAbajo.HeaderVisibleSecondary = False
        Me.HGAbajo.Location = New System.Drawing.Point(0, 371)
        Me.HGAbajo.Name = "HGAbajo"
        Me.HGAbajo.Size = New System.Drawing.Size(829, 136)
        Me.HGAbajo.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGAbajo.TabIndex = 2
        Me.HGAbajo.Text = "[]"
        Me.HGAbajo.ValuesPrimary.Description = ""
        Me.HGAbajo.ValuesPrimary.Heading = "[]"
        Me.HGAbajo.ValuesPrimary.Image = Nothing
        Me.HGAbajo.ValuesSecondary.Description = ""
        Me.HGAbajo.ValuesSecondary.Heading = "Description"
        Me.HGAbajo.ValuesSecondary.Image = Nothing
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 507)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmBase"
        Me.Text = "[]"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        CType(Me.HGPrincipal.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGPrincipal.ResumeLayout(False)
        CType(Me.HGAbajo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HGAbajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGAbajo.ResumeLayout(False)
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
    Public WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Public WithEvents HGAbajo As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Public WithEvents HGPrincipal As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
End Class
