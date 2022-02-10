<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreFacturacionTransporte
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
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtNIT = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.KryptonLabel4)
    Me.panel.Controls.Add(Me.KryptonLabel3)
    Me.panel.Controls.Add(Me.KryptonLabel2)
    Me.panel.Controls.Add(Me.KryptonLabel1)
    Me.panel.Controls.Add(Me.txtPreFactura)
    Me.panel.Controls.Add(Me.txtOperacion)
    Me.panel.Controls.Add(Me.txtNIT)
    Me.panel.Controls.Add(Me.txtCliente)
    Me.panel.Controls.Add(Me.MenuBar)
    Me.panel.Controls.Add(Me.btnCerrar)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(454, 180)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 1
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(8, 136)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(92, 16)
    Me.KryptonLabel4.TabIndex = 11
    Me.KryptonLabel4.Text = "N° Pre - Factura"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "N° Pre - Factura"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(8, 104)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(78, 16)
    Me.KryptonLabel3.TabIndex = 10
    Me.KryptonLabel3.Text = "N° Operación"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "N° Operación"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(8, 72)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(44, 16)
    Me.KryptonLabel2.TabIndex = 9
    Me.KryptonLabel2.Text = "N° NIT"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "N° NIT"
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(8, 40)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(46, 16)
    Me.KryptonLabel1.TabIndex = 8
    Me.KryptonLabel1.Text = "Cliente"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Cliente"
    '
    'txtPreFactura
    '
    Me.txtPreFactura.Enabled = False
    Me.txtPreFactura.Location = New System.Drawing.Point(104, 135)
    Me.txtPreFactura.Name = "txtPreFactura"
    Me.txtPreFactura.Size = New System.Drawing.Size(128, 19)
    Me.txtPreFactura.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ActiveCaptionText
    Me.txtPreFactura.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtPreFactura.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtPreFactura.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtPreFactura.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtPreFactura.TabIndex = 7
    Me.txtPreFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtOperacion
    '
    Me.txtOperacion.Enabled = False
    Me.txtOperacion.Location = New System.Drawing.Point(104, 103)
    Me.txtOperacion.Name = "txtOperacion"
    Me.txtOperacion.Size = New System.Drawing.Size(328, 19)
    Me.txtOperacion.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ActiveCaptionText
    Me.txtOperacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtOperacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtOperacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtOperacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtOperacion.TabIndex = 6
    '
    'txtNIT
    '
    Me.txtNIT.Enabled = False
    Me.txtNIT.Location = New System.Drawing.Point(104, 71)
    Me.txtNIT.Name = "txtNIT"
    Me.txtNIT.Size = New System.Drawing.Size(128, 19)
    Me.txtNIT.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ActiveCaptionText
    Me.txtNIT.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtNIT.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtNIT.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtNIT.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtNIT.TabIndex = 5
    Me.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtCliente
    '
    Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCliente.Enabled = False
    Me.txtCliente.Location = New System.Drawing.Point(104, 39)
    Me.txtCliente.Name = "txtCliente"
    Me.txtCliente.Size = New System.Drawing.Size(328, 19)
    Me.txtCliente.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ActiveCaptionText
    Me.txtCliente.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtCliente.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
    Me.txtCliente.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtCliente.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtCliente.TabIndex = 4
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.btnAceptar, Me.ToolStripLabel1})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(454, 25)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(72, 22)
    Me.btnCancelar.Text = " Cancelar"
    '
    'Separator1
    '
    Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.Separator1.Name = "Separator1"
    Me.Separator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(64, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'btnCerrar
    '
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Location = New System.Drawing.Point(184, 0)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "."
    Me.btnCerrar.Values.ExtraText = ""
    Me.btnCerrar.Values.Image = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnCerrar.Values.Text = "."
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(214, 22)
    Me.ToolStripLabel1.Text = " CLIENTE CON FACTURACIÓN ESPECIAL"
    '
    'frmPreFacturacionTransporte
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(454, 180)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmPreFacturacionTransporte"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Pre - Factura"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    Me.ResumeLayout(False)

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
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPreFactura As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtNIT As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
