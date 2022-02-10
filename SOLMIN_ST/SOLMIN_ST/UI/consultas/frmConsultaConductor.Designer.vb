<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaConductor
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
        Me.Panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtpFechaAtencionServicio = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01()
        Me.btnNuevoContudtor1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblConductor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBarGuia = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.MenuBarGuia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.dtpFechaAtencionServicio)
        Me.Panel.Controls.Add(Me.KryptonLabel4)
        Me.Panel.Controls.Add(Me.cmbConductor)
        Me.Panel.Controls.Add(Me.btnNuevoContudtor1)
        Me.Panel.Controls.Add(Me.lblConductor)
        Me.Panel.Controls.Add(Me.MenuBarGuia)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(544, 153)
        Me.Panel.StateCommon.Color1 = System.Drawing.Color.White
        Me.Panel.TabIndex = 0
        '
        'dtpFechaAtencionServicio
        '
        Me.dtpFechaAtencionServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencionServicio.Location = New System.Drawing.Point(239, 78)
        Me.dtpFechaAtencionServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaAtencionServicio.Name = "dtpFechaAtencionServicio"
        Me.dtpFechaAtencionServicio.Size = New System.Drawing.Size(119, 22)
        Me.dtpFechaAtencionServicio.TabIndex = 162
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(89, 77)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(144, 26)
        Me.KryptonLabel4.TabIndex = 161
        Me.KryptonLabel4.Text = "F. Atención Servicio"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "F. Atención Servicio"
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Location = New System.Drawing.Point(96, 39)
        Me.cmbConductor.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(387, 26)
        Me.cmbConductor.TabIndex = 154
        '
        'btnNuevoContudtor1
        '
        Me.btnNuevoContudtor1.Location = New System.Drawing.Point(492, 37)
        Me.btnNuevoContudtor1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoContudtor1.Name = "btnNuevoContudtor1"
        Me.btnNuevoContudtor1.OverrideDefault.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.Size = New System.Drawing.Size(40, 31)
        Me.btnNuevoContudtor1.StateDisabled.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.StateNormal.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.StatePressed.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.StateTracking.Back.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoContudtor1.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.btnNuevoContudtor1.TabIndex = 20
        Me.btnNuevoContudtor1.Values.ExtraText = ""
        Me.btnNuevoContudtor1.Values.Image = Nothing
        Me.btnNuevoContudtor1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnNuevoContudtor1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnNuevoContudtor1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnNuevoContudtor1.Values.Text = ""
        '
        'lblConductor
        '
        Me.lblConductor.Location = New System.Drawing.Point(7, 42)
        Me.lblConductor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(83, 26)
        Me.lblConductor.TabIndex = 18
        Me.lblConductor.Text = "Conductor "
        Me.lblConductor.Values.ExtraText = ""
        Me.lblConductor.Values.Image = Nothing
        Me.lblConductor.Values.Text = "Conductor "
        '
        'MenuBarGuia
        '
        Me.MenuBarGuia.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBarGuia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBarGuia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBarGuia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.btnAceptar})
        Me.MenuBarGuia.Location = New System.Drawing.Point(0, 0)
        Me.MenuBarGuia.Name = "MenuBarGuia"
        Me.MenuBarGuia.Size = New System.Drawing.Size(544, 27)
        Me.MenuBarGuia.TabIndex = 17
        Me.MenuBarGuia.TabStop = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 24)
        Me.btnCancelar.Text = " Cancelar"
        '
        'Separator1
        '
        Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(89, 24)
        Me.btnAceptar.Text = " Aceptar"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'frmConsultaConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 153)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(541, 100)
        Me.Name = "frmConsultaConductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Seleccionar Conductor"
        CType(Me.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.MenuBarGuia.ResumeLayout(False)
        Me.MenuBarGuia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents Panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents MenuBarGuia As System.Windows.Forms.ToolStrip
  Friend WithEvents btnNuevoContudtor1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblConductor As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
  Friend WithEvents dtpFechaAtencionServicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
