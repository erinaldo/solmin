<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpcionAgregarGuia
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
    Me.panelOpcion = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.groupElegir = New ComponentFactory.Krypton.Toolkit.KryptonGroup
    Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.btnOperacion = New ComponentFactory.Krypton.Toolkit.KryptonButton
    Me.rbtnOperacion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.rbtnSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.Separador = New System.Windows.Forms.ToolStripSeparator
    Me.btnAceptar = New System.Windows.Forms.ToolStripButton
    CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panelOpcion.SuspendLayout()
    CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.groupElegir.Panel.SuspendLayout()
    Me.groupElegir.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    Me.SuspendLayout()
    '
    'panelOpcion
    '
    Me.panelOpcion.Controls.Add(Me.groupElegir)
    Me.panelOpcion.Controls.Add(Me.MenuBar)
    Me.panelOpcion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panelOpcion.Location = New System.Drawing.Point(0, 0)
    Me.panelOpcion.Name = "panelOpcion"
    Me.panelOpcion.Size = New System.Drawing.Size(234, 86)
    Me.panelOpcion.StateCommon.Color1 = System.Drawing.Color.White
    Me.panelOpcion.TabIndex = 0
    '
    'groupElegir
    '
    Me.groupElegir.Dock = System.Windows.Forms.DockStyle.Fill
    Me.groupElegir.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
    Me.groupElegir.Location = New System.Drawing.Point(0, 25)
    Me.groupElegir.Name = "groupElegir"
    Me.groupElegir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    '
    'groupElegir.Panel
    '
    Me.groupElegir.Panel.Controls.Add(Me.btnCerrar)
    Me.groupElegir.Panel.Controls.Add(Me.btnOperacion)
    Me.groupElegir.Panel.Controls.Add(Me.rbtnOperacion)
    Me.groupElegir.Panel.Controls.Add(Me.txtOperacion)
    Me.groupElegir.Panel.Controls.Add(Me.rbtnSolicitud)
    Me.groupElegir.Size = New System.Drawing.Size(234, 61)
    Me.groupElegir.TabIndex = 426
    '
    'btnCerrar
    '
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Location = New System.Drawing.Point(220, -25)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(8, 25)
    Me.btnCerrar.TabIndex = 428
    Me.btnCerrar.Text = "."
    Me.btnCerrar.Values.ExtraText = ""
    Me.btnCerrar.Values.Image = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnCerrar.Values.Text = "."
    '
    'btnOperacion
    '
    Me.btnOperacion.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3
    Me.btnOperacion.Enabled = False
    Me.btnOperacion.Location = New System.Drawing.Point(192, 29)
    Me.btnOperacion.Name = "btnOperacion"
    Me.btnOperacion.Size = New System.Drawing.Size(25, 22)
    Me.btnOperacion.TabIndex = 427
    Me.btnOperacion.Values.ExtraText = ""
    Me.btnOperacion.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
    Me.btnOperacion.Values.ImageStates.ImageCheckedNormal = Nothing
    Me.btnOperacion.Values.ImageStates.ImageCheckedPressed = Nothing
    Me.btnOperacion.Values.ImageStates.ImageCheckedTracking = Nothing
    Me.btnOperacion.Values.Text = ""
    '
    'rbtnOperacion
    '
    Me.rbtnOperacion.Location = New System.Drawing.Point(14, 31)
    Me.rbtnOperacion.Name = "rbtnOperacion"
    Me.rbtnOperacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    Me.rbtnOperacion.Size = New System.Drawing.Size(74, 19)
    Me.rbtnOperacion.TabIndex = 1
    Me.rbtnOperacion.TabStop = False
    Me.rbtnOperacion.Tag = ""
    Me.rbtnOperacion.Text = "Operación"
    Me.rbtnOperacion.Values.ExtraText = ""
    Me.rbtnOperacion.Values.Image = Nothing
    Me.rbtnOperacion.Values.Text = "Operación"
    '
    'txtOperacion
    '
    Me.txtOperacion.Enabled = False
    Me.txtOperacion.Location = New System.Drawing.Point(91, 30)
    Me.txtOperacion.MaxLength = 10
    Me.txtOperacion.Name = "txtOperacion"
    Me.txtOperacion.Size = New System.Drawing.Size(100, 21)
    Me.txtOperacion.TabIndex = 6
    Me.txtOperacion.TabStop = False
    '
    'rbtnSolicitud
    '
    Me.rbtnSolicitud.Checked = True
    Me.rbtnSolicitud.Location = New System.Drawing.Point(14, 5)
    Me.rbtnSolicitud.Name = "rbtnSolicitud"
    Me.rbtnSolicitud.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    Me.rbtnSolicitud.Size = New System.Drawing.Size(65, 19)
    Me.rbtnSolicitud.TabIndex = 0
    Me.rbtnSolicitud.TabStop = False
    Me.rbtnSolicitud.Tag = ""
    Me.rbtnSolicitud.Text = "Solicitud"
    Me.rbtnSolicitud.Values.ExtraText = ""
    Me.rbtnSolicitud.Values.Image = Nothing
    Me.rbtnSolicitud.Values.Text = "Solicitud"
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separador, Me.btnAceptar})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(234, 25)
    Me.MenuBar.TabIndex = 5
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'Separador
    '
    Me.Separador.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.Separador.Name = "Separador"
    Me.Separador.Size = New System.Drawing.Size(6, 25)
    '
    'btnAceptar
    '
    Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(66, 22)
    Me.btnAceptar.Text = "Aceptar"
    '
    'frmOpcionAgregarGuia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(234, 86)
    Me.ControlBox = False
    Me.Controls.Add(Me.panelOpcion)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(240, 110)
    Me.MinimumSize = New System.Drawing.Size(240, 110)
    Me.Name = "frmOpcionAgregarGuia"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Opción de Registrar"
    CType(Me.panelOpcion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panelOpcion.ResumeLayout(False)
    Me.panelOpcion.PerformLayout()
    CType(Me.groupElegir.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.groupElegir.Panel.ResumeLayout(False)
    Me.groupElegir.Panel.PerformLayout()
    CType(Me.groupElegir, System.ComponentModel.ISupportInitialize).EndInit()
    Me.groupElegir.ResumeLayout(False)
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
  Friend WithEvents panelOpcion As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents groupElegir As ComponentFactory.Krypton.Toolkit.KryptonGroup
  Friend WithEvents rbtnOperacion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbtnSolicitud As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents btnOperacion As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separador As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
