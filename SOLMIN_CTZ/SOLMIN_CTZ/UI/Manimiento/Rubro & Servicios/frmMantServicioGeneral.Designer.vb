<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantServicioGeneral
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
        Me.grupMantRubroPorCliente = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtRubro = New System.Windows.Forms.TextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.grupMantRubroPorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupMantRubroPorCliente.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupMantRubroPorCliente.Panel.SuspendLayout()
        Me.grupMantRubroPorCliente.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.grupMantRubroPorCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(431, 78)
        Me.KryptonPanel.TabIndex = 0
        '
        'grupMantRubroPorCliente
        '
        Me.grupMantRubroPorCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grupMantRubroPorCliente.Location = New System.Drawing.Point(0, 0)
        Me.grupMantRubroPorCliente.Name = "grupMantRubroPorCliente"
        '
        'grupMantRubroPorCliente.Panel
        '
        Me.grupMantRubroPorCliente.Panel.Controls.Add(Me.txtRubro)
        Me.grupMantRubroPorCliente.Panel.Controls.Add(Me.KryptonLabel6)
        Me.grupMantRubroPorCliente.Panel.Controls.Add(Me.ToolStrip2)
        Me.grupMantRubroPorCliente.Size = New System.Drawing.Size(431, 78)
        Me.grupMantRubroPorCliente.TabIndex = 30
        '
        'txtRubro
        '
        Me.txtRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRubro.Location = New System.Drawing.Point(107, 38)
        Me.txtRubro.MaxLength = 100
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(312, 18)
        Me.txtRubro.TabIndex = 52
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 37)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(98, 19)
        Me.KryptonLabel6.TabIndex = 51
        Me.KryptonLabel6.Text = "Servicio general  :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Servicio general  :"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.ToolStripButton1, Me.btnGrabar, Me.ToolStripSeparator1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(429, 25)
        Me.ToolStrip2.TabIndex = 1
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripLabel2.Tag = ""
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "&Salir"
        Me.ToolStripButton1.ToolTipText = "Salir"
        '
        'btnGrabar
        '
        Me.btnGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGrabar.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(62, 22)
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.ToolTipText = "Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'frmMantServicioGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 78)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMantServicioGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Servicios Generales"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.grupMantRubroPorCliente.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupMantRubroPorCliente.Panel.ResumeLayout(False)
        Me.grupMantRubroPorCliente.Panel.PerformLayout()
        CType(Me.grupMantRubroPorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupMantRubroPorCliente.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents grupMantRubroPorCliente As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents txtRubro As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
