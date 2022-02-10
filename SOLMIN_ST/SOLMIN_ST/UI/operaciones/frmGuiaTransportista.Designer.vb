<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuiaTransportista
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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtNombreFormulario = New System.Windows.Forms.ToolStripLabel()
        Me.panelGuia = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.MenuBar.SuspendLayout()
        CType(Me.panelGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.txtNombreFormulario})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1416, 27)
        Me.MenuBar.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(62, 24)
        Me.btnSalir.Text = "Salir"
        '
        'txtNombreFormulario
        '
        Me.txtNombreFormulario.Name = "txtNombreFormulario"
        Me.txtNombreFormulario.Size = New System.Drawing.Size(136, 24)
        Me.txtNombreFormulario.Text = "  Guía Transportista"
        '
        'panelGuia
        '
        Me.panelGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelGuia.Location = New System.Drawing.Point(0, 27)
        Me.panelGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.panelGuia.Name = "panelGuia"
        Me.panelGuia.Size = New System.Drawing.Size(1416, 801)
        Me.panelGuia.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelGuia.TabIndex = 1
        '
        'frmGuiaTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1416, 828)
        Me.Controls.Add(Me.panelGuia)
        Me.Controls.Add(Me.MenuBar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGuiaTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.panelGuia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents panelGuia As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents txtNombreFormulario As System.Windows.Forms.ToolStripLabel
End Class
