<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarUbicacionUnidad
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
    Me.cboListaCondicion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.txtHora = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker
    Me.txtUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboAcoplados = New Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
    Me.cboVehiculos = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.mnuEnviarArea = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnProcesar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.ckbUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.mnuEnviarArea.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.ckbUbicacion)
    Me.KryptonPanel.Controls.Add(Me.cboListaCondicion)
    Me.KryptonPanel.Controls.Add(Me.txtHora)
    Me.KryptonPanel.Controls.Add(Me.dtpFecha)
    Me.KryptonPanel.Controls.Add(Me.txtUbicacion)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
    Me.KryptonPanel.Controls.Add(Me.cboAcoplados)
    Me.KryptonPanel.Controls.Add(Me.cboVehiculos)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel10)
    Me.KryptonPanel.Controls.Add(Me.mnuEnviarArea)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(413, 203)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'cboListaCondicion
    '
    Me.cboListaCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboListaCondicion.DropDownWidth = 236
    Me.cboListaCondicion.FormattingEnabled = False
    Me.cboListaCondicion.ItemHeight = 13
    Me.cboListaCondicion.Items.AddRange(New Object() {"OP - MINA", "OP - RSA", "IND - SA"})
    Me.cboListaCondicion.Location = New System.Drawing.Point(155, 97)
    Me.cboListaCondicion.Name = "cboListaCondicion"
    Me.cboListaCondicion.Size = New System.Drawing.Size(236, 21)
    Me.cboListaCondicion.TabIndex = 125
    '
    'txtHora
    '
    Me.txtHora.Culture = New System.Globalization.CultureInfo("es-PE")
    Me.txtHora.Enabled = False
    Me.txtHora.Location = New System.Drawing.Point(310, 161)
    Me.txtHora.Mask = "00:00:00"
    Me.txtHora.Name = "txtHora"
    Me.txtHora.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
    Me.txtHora.Size = New System.Drawing.Size(80, 21)
    Me.txtHora.TabIndex = 124
    Me.txtHora.Text = "  :  :"
    Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'dtpFecha
    '
    Me.dtpFecha.Enabled = False
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(155, 161)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
    Me.dtpFecha.TabIndex = 123
    '
    'txtUbicacion
    '
    Me.txtUbicacion.Enabled = False
    Me.txtUbicacion.Location = New System.Drawing.Point(155, 130)
    Me.txtUbicacion.MaxLength = 100
    Me.txtUbicacion.Name = "txtUbicacion"
    Me.txtUbicacion.Size = New System.Drawing.Size(235, 21)
    Me.txtUbicacion.TabIndex = 122
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(255, 162)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(35, 19)
    Me.KryptonLabel7.TabIndex = 121
    Me.KryptonLabel7.Text = "Hora"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Hora"
    '
    'cboAcoplados
    '
    Me.cboAcoplados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cboAcoplados.BackColor = System.Drawing.Color.Transparent
    Me.cboAcoplados.Location = New System.Drawing.Point(155, 65)
    Me.cboAcoplados.Name = "cboAcoplados"
    Me.cboAcoplados.pRequerido = False
    Me.cboAcoplados.Size = New System.Drawing.Size(236, 21)
    Me.cboAcoplados.TabIndex = 120
    '
    'cboVehiculos
    '
    Me.cboVehiculos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cboVehiculos.BackColor = System.Drawing.Color.Transparent
    Me.cboVehiculos.Location = New System.Drawing.Point(155, 34)
    Me.cboVehiculos.Name = "cboVehiculos"
    Me.cboVehiculos.pRequerido = False
    Me.cboVehiculos.Size = New System.Drawing.Size(237, 21)
    Me.cboVehiculos.TabIndex = 119
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(10, 35)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(42, 19)
    Me.KryptonLabel5.TabIndex = 114
    Me.KryptonLabel5.Text = "Tracto"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Tracto"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(10, 98)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(61, 19)
    Me.KryptonLabel6.TabIndex = 116
    Me.KryptonLabel6.Text = "Condición"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Condición"
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(10, 162)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel8.TabIndex = 118
    Me.KryptonLabel8.Text = "Fecha"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Fecha"
    '
    'KryptonLabel10
    '
    Me.KryptonLabel10.Location = New System.Drawing.Point(10, 66)
    Me.KryptonLabel10.Name = "KryptonLabel10"
    Me.KryptonLabel10.Size = New System.Drawing.Size(58, 19)
    Me.KryptonLabel10.TabIndex = 115
    Me.KryptonLabel10.Text = "Acoplado"
    Me.KryptonLabel10.Values.ExtraText = ""
    Me.KryptonLabel10.Values.Image = Nothing
    Me.KryptonLabel10.Values.Text = "Acoplado"
    '
    'mnuEnviarArea
    '
    Me.mnuEnviarArea.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.mnuEnviarArea.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnuEnviarArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnProcesar})
    Me.mnuEnviarArea.Location = New System.Drawing.Point(0, 0)
    Me.mnuEnviarArea.Name = "mnuEnviarArea"
    Me.mnuEnviarArea.Size = New System.Drawing.Size(413, 25)
    Me.mnuEnviarArea.TabIndex = 8
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
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnProcesar
    '
    Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(69, 22)
    Me.btnProcesar.Text = "Guardar"
    '
    'ckbUbicacion
    '
    Me.ckbUbicacion.Checked = False
    Me.ckbUbicacion.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.ckbUbicacion.Location = New System.Drawing.Point(15, 130)
    Me.ckbUbicacion.Name = "ckbUbicacion"
    Me.ckbUbicacion.Size = New System.Drawing.Size(129, 19)
    Me.ckbUbicacion.TabIndex = 126
    Me.ckbUbicacion.Text = "Ubicación Geográfica"
    Me.ckbUbicacion.Values.ExtraText = ""
    Me.ckbUbicacion.Values.Image = Nothing
    Me.ckbUbicacion.Values.Text = "Ubicación Geográfica"
    '
    'frmAsignarUbicacionUnidad
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(413, 203)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmAsignarUbicacionUnidad"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Asignar Ubicación Unidad"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.mnuEnviarArea.ResumeLayout(False)
    Me.mnuEnviarArea.PerformLayout()
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
  Friend WithEvents mnuEnviarArea As System.Windows.Forms.ToolStrip
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents cboListaCondicion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents txtHora As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtUbicacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboAcoplados As Ransa.Controls.Transportista.ucAcopladoTransportista_TxtF01
  Friend WithEvents cboVehiculos As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents ckbUbicacion As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
