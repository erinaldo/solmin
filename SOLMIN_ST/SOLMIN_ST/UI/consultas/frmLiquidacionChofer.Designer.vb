<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionChofer
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
    Me.txtConductor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.txtTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblCombAsignado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblCombustible = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtNroLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblPapeleta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblGrifo = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCerrarLiquidacion = New System.Windows.Forms.ToolStripButton
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panel
    '
    Me.panel.Controls.Add(Me.txtConductor)
    Me.panel.Controls.Add(Me.txtAcoplado)
    Me.panel.Controls.Add(Me.txtTracto)
    Me.panel.Controls.Add(Me.lblCombAsignado)
    Me.panel.Controls.Add(Me.lblCombustible)
    Me.panel.Controls.Add(Me.txtNroLiquidacion)
    Me.panel.Controls.Add(Me.lblPapeleta)
    Me.panel.Controls.Add(Me.lblGrifo)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 25)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(382, 129)
    Me.panel.StateCommon.Color1 = System.Drawing.Color.White
    Me.panel.TabIndex = 2
    '
    'txtConductor
    '
    Me.txtConductor.Enabled = False
    Me.txtConductor.Location = New System.Drawing.Point(112, 95)
    Me.txtConductor.Name = "txtConductor"
    Me.txtConductor.Size = New System.Drawing.Size(256, 19)
    Me.txtConductor.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtConductor.StateDisabled.Border.Color1 = System.Drawing.SystemColors.MenuHighlight
    Me.txtConductor.StateDisabled.Border.Color2 = System.Drawing.SystemColors.MenuHighlight
    Me.txtConductor.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtConductor.StateDisabled.Content.Color1 = System.Drawing.Color.White
    Me.txtConductor.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.txtConductor.TabIndex = 11
    '
    'txtAcoplado
    '
    Me.txtAcoplado.Enabled = False
    Me.txtAcoplado.Location = New System.Drawing.Point(112, 66)
    Me.txtAcoplado.Name = "txtAcoplado"
    Me.txtAcoplado.Size = New System.Drawing.Size(111, 19)
    Me.txtAcoplado.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtAcoplado.StateDisabled.Border.Color1 = System.Drawing.SystemColors.MenuHighlight
    Me.txtAcoplado.StateDisabled.Border.Color2 = System.Drawing.SystemColors.MenuHighlight
    Me.txtAcoplado.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtAcoplado.StateDisabled.Content.Color1 = System.Drawing.Color.White
    Me.txtAcoplado.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.txtAcoplado.TabIndex = 10
    '
    'txtTracto
    '
    Me.txtTracto.Enabled = False
    Me.txtTracto.Location = New System.Drawing.Point(112, 37)
    Me.txtTracto.Name = "txtTracto"
    Me.txtTracto.Size = New System.Drawing.Size(111, 19)
    Me.txtTracto.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtTracto.StateDisabled.Border.Color1 = System.Drawing.SystemColors.MenuHighlight
    Me.txtTracto.StateDisabled.Border.Color2 = System.Drawing.SystemColors.MenuHighlight
    Me.txtTracto.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtTracto.StateDisabled.Content.Color1 = System.Drawing.Color.White
    Me.txtTracto.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.txtTracto.TabIndex = 9
    '
    'lblCombAsignado
    '
    Me.lblCombAsignado.Location = New System.Drawing.Point(13, 96)
    Me.lblCombAsignado.Name = "lblCombAsignado"
    Me.lblCombAsignado.Size = New System.Drawing.Size(62, 16)
    Me.lblCombAsignado.TabIndex = 8
    Me.lblCombAsignado.Text = "Conductor"
    Me.lblCombAsignado.Values.ExtraText = ""
    Me.lblCombAsignado.Values.Image = Nothing
    Me.lblCombAsignado.Values.Text = "Conductor"
    '
    'lblCombustible
    '
    Me.lblCombustible.Location = New System.Drawing.Point(13, 67)
    Me.lblCombustible.Name = "lblCombustible"
    Me.lblCombustible.Size = New System.Drawing.Size(57, 16)
    Me.lblCombustible.TabIndex = 6
    Me.lblCombustible.Text = "Acoplado"
    Me.lblCombustible.Values.ExtraText = ""
    Me.lblCombustible.Values.Image = Nothing
    Me.lblCombustible.Values.Text = "Acoplado"
    '
    'txtNroLiquidacion
    '
    Me.txtNroLiquidacion.Enabled = False
    Me.txtNroLiquidacion.Location = New System.Drawing.Point(112, 9)
    Me.txtNroLiquidacion.MaxLength = 10
    Me.txtNroLiquidacion.Name = "txtNroLiquidacion"
    Me.txtNroLiquidacion.Size = New System.Drawing.Size(111, 19)
    Me.txtNroLiquidacion.StateDisabled.Back.Color1 = System.Drawing.Color.White
    Me.txtNroLiquidacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.MenuHighlight
    Me.txtNroLiquidacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.MenuHighlight
    Me.txtNroLiquidacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtNroLiquidacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtNroLiquidacion.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
    Me.txtNroLiquidacion.TabIndex = 1
    Me.txtNroLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblPapeleta
    '
    Me.lblPapeleta.Location = New System.Drawing.Point(13, 10)
    Me.lblPapeleta.Name = "lblPapeleta"
    Me.lblPapeleta.Size = New System.Drawing.Size(98, 16)
    Me.lblPapeleta.TabIndex = 0
    Me.lblPapeleta.Text = "N° Liquidación G."
    Me.lblPapeleta.Values.ExtraText = ""
    Me.lblPapeleta.Values.Image = Nothing
    Me.lblPapeleta.Values.Text = "N° Liquidación G."
    '
    'lblGrifo
    '
    Me.lblGrifo.Location = New System.Drawing.Point(13, 38)
    Me.lblGrifo.Name = "lblGrifo"
    Me.lblGrifo.Size = New System.Drawing.Size(42, 16)
    Me.lblGrifo.TabIndex = 4
    Me.lblGrifo.Text = "Tracto"
    Me.lblGrifo.Values.ExtraText = ""
    Me.lblGrifo.Values.Image = Nothing
    Me.lblGrifo.Values.Text = "Tracto"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(69, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnCerrarLiquidacion})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(382, 25)
    Me.MenuBar.TabIndex = 1
    Me.MenuBar.TabStop = True
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCerrarLiquidacion
    '
    Me.btnCerrarLiquidacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCerrarLiquidacion.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnCerrarLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCerrarLiquidacion.Name = "btnCerrarLiquidacion"
    Me.btnCerrarLiquidacion.Size = New System.Drawing.Size(64, 22)
    Me.btnCerrarLiquidacion.Text = "Aceptar"
    '
    'frmLiquidacionChofer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(382, 154)
    Me.ControlBox = False
    Me.Controls.Add(Me.panel)
    Me.Controls.Add(Me.MenuBar)
    Me.Name = "frmLiquidacionChofer"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Liquidación de Chofer"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    Me.panel.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
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
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents lblCombAsignado As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblCombustible As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtNroLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblPapeleta As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblGrifo As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCerrarLiquidacion As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtConductor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents txtTracto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
