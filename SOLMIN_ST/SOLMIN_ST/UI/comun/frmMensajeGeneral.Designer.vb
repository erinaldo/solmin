<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajeGeneral
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
    Me.txtMensaje = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.txtMensaje)
    Me.KryptonPanel.Controls.Add(Me.btnCancelar)
    Me.KryptonPanel.Controls.Add(Me.btnAceptar)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(406, 100)
    Me.KryptonPanel.TabIndex = 0
    '
    'txtMensaje
    '
    Me.txtMensaje.Location = New System.Drawing.Point(5, 5)
    Me.txtMensaje.Multiline = True
    Me.txtMensaje.Name = "txtMensaje"
    Me.txtMensaje.Size = New System.Drawing.Size(395, 60)
    Me.txtMensaje.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtMensaje.StateCommon.Border.Color1 = System.Drawing.Color.White
    Me.txtMensaje.StateCommon.Border.Color2 = System.Drawing.Color.White
    Me.txtMensaje.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtMensaje.StateCommon.Content.Color1 = System.Drawing.Color.Red
    Me.txtMensaje.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMensaje.TabIndex = 2
    '
    'btnCancelar
    '
    Me.btnCancelar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate
    Me.btnCancelar.Location = New System.Drawing.Point(332, 72)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(68, 25)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.Values.ExtraText = ""
    Me.btnCancelar.Values.Image = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnCancelar.Values.Text = "Cancelar"
    '
    'btnAceptar
    '
    Me.btnAceptar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate
    Me.btnAceptar.Location = New System.Drawing.Point(261, 72)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(68, 25)
    Me.btnAceptar.TabIndex = 0
    Me.btnAceptar.Text = "Aceptar"
    Me.btnAceptar.Values.ExtraText = ""
    Me.btnAceptar.Values.Image = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnAceptar.Values.Text = "Aceptar"
    '
    'frmMensajeGeneral
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(406, 100)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(412, 124)
    Me.MinimumSize = New System.Drawing.Size(412, 124)
    Me.Name = "frmMensajeGeneral"
    Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mensaje"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
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
  Friend WithEvents txtMensaje As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
