<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocAdjuntoConductor
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
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPageDocs = New System.Windows.Forms.TabPage
    Me.PnlDocs = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.TabPageImg = New System.Windows.Forms.TabPage
    Me.PnlImg = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnAgregar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCerrar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPageDocs.SuspendLayout()
    CType(Me.PnlDocs, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPageImg.SuspendLayout()
    CType(Me.PnlImg, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.TabControl1)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(687, 473)
    Me.KryptonPanel.TabIndex = 0
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPageDocs)
    Me.TabControl1.Controls.Add(Me.TabPageImg)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(687, 448)
    Me.TabControl1.TabIndex = 6
    '
    'TabPageDocs
    '
    Me.TabPageDocs.AutoScroll = True
    Me.TabPageDocs.Controls.Add(Me.PnlDocs)
    Me.TabPageDocs.Location = New System.Drawing.Point(4, 22)
    Me.TabPageDocs.Name = "TabPageDocs"
    Me.TabPageDocs.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPageDocs.Size = New System.Drawing.Size(679, 422)
    Me.TabPageDocs.TabIndex = 0
    Me.TabPageDocs.Text = "Documentación"
    Me.TabPageDocs.UseVisualStyleBackColor = True
    '
    'PnlDocs
    '
    Me.PnlDocs.AutoScroll = True
    Me.PnlDocs.AutoSize = True
    Me.PnlDocs.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PnlDocs.Location = New System.Drawing.Point(3, 3)
    Me.PnlDocs.Name = "PnlDocs"
    Me.PnlDocs.Size = New System.Drawing.Size(673, 416)
    Me.PnlDocs.TabIndex = 1
    '
    'TabPageImg
    '
    Me.TabPageImg.Controls.Add(Me.PnlImg)
    Me.TabPageImg.Location = New System.Drawing.Point(4, 22)
    Me.TabPageImg.Name = "TabPageImg"
    Me.TabPageImg.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPageImg.Size = New System.Drawing.Size(679, 422)
    Me.TabPageImg.TabIndex = 1
    Me.TabPageImg.Text = "Imagenes"
    Me.TabPageImg.UseVisualStyleBackColor = True
    '
    'PnlImg
    '
    Me.PnlImg.AutoScroll = True
    Me.PnlImg.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PnlImg.Location = New System.Drawing.Point(3, 3)
    Me.PnlImg.Name = "PnlImg"
    Me.PnlImg.Size = New System.Drawing.Size(673, 416)
    Me.PnlImg.TabIndex = 2
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.ToolStripSeparator1, Me.btnEliminar, Me.ToolStripSeparator2, Me.btnCerrar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(687, 25)
    Me.ToolStrip1.TabIndex = 5
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnAgregar
    '
    Me.btnAgregar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
    Me.btnAgregar.Text = "Agregar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnEliminar
    '
    Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
    Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
    Me.btnEliminar.Text = "Eliminar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnCerrar
    '
    Me.btnCerrar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(58, 22)
    Me.btnCerrar.Text = "Cerrar"
    '
    'frmDocAdjuntoConductor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(687, 473)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmDocAdjuntoConductor"
    Me.Text = "Documentos Adjuntos del Conductor"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPageDocs.ResumeLayout(False)
    Me.TabPageDocs.PerformLayout()
    CType(Me.PnlDocs, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPageImg.ResumeLayout(False)
    CType(Me.PnlImg, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDocs As System.Windows.Forms.TabPage
    Friend WithEvents PnlDocs As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents TabPageImg As System.Windows.Forms.TabPage
    Friend WithEvents PnlImg As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
End Class
