<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManAplicacion
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmManAplicacion))
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.mnuAplicacionMenu = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonManager2 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel2.SuspendLayout()
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel1.SuspendLayout()
    Me.mnuAplicacionMenu.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.KryptonPanel2)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(353, 112)
    Me.KryptonPanel.TabIndex = 0
    '
    'KryptonPanel2
    '
    Me.KryptonPanel2.Controls.Add(Me.KryptonPanel1)
    Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel2.Name = "KryptonPanel2"
    Me.KryptonPanel2.Size = New System.Drawing.Size(353, 112)
    Me.KryptonPanel2.TabIndex = 1
    '
    'KryptonPanel1
    '
    Me.KryptonPanel1.Controls.Add(Me.txtDescripcion)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
    Me.KryptonPanel1.Controls.Add(Me.txtCodigo)
    Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
    Me.KryptonPanel1.Controls.Add(Me.mnuAplicacionMenu)
    Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel1.Name = "KryptonPanel1"
    Me.KryptonPanel1.Size = New System.Drawing.Size(353, 112)
    Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel1.TabIndex = 1
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(116, 68)
    Me.txtDescripcion.MaxLength = 25
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(212, 21)
    Me.txtDescripcion.TabIndex = 1
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(22, 66)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(68, 19)
    Me.KryptonLabel1.TabIndex = 62
    Me.KryptonLabel1.Text = "Descripción"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Descripción"
    '
    'txtCodigo
    '
    Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigo.Location = New System.Drawing.Point(116, 39)
    Me.txtCodigo.MaxLength = 2
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(47, 21)
    Me.txtCodigo.TabIndex = 0
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(22, 41)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(47, 19)
    Me.KryptonLabel5.TabIndex = 60
    Me.KryptonLabel5.Text = "Código"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Código"
    '
    'mnuAplicacionMenu
    '
    Me.mnuAplicacionMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.mnuAplicacionMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnuAplicacionMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
    Me.mnuAplicacionMenu.Location = New System.Drawing.Point(0, 0)
    Me.mnuAplicacionMenu.Name = "mnuAplicacionMenu"
    Me.mnuAplicacionMenu.Size = New System.Drawing.Size(353, 25)
    Me.mnuAplicacionMenu.TabIndex = 10
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'FrmManAplicacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(353, 112)
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "FrmManAplicacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento Aplicación"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel2.ResumeLayout(False)
    CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel1.ResumeLayout(False)
    Me.KryptonPanel1.PerformLayout()
    Me.mnuAplicacionMenu.ResumeLayout(False)
    Me.mnuAplicacionMenu.PerformLayout()
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
  Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents mnuAplicacionMenu As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
  Friend WithEvents KryptonManager2 As ComponentFactory.Krypton.Toolkit.KryptonManager
End Class
