<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarArea
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
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker
    Me.txtHora = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboAreaResponsable = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.txtUsuario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.mnuEnviarArea = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnProcesar = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.mnuEnviarArea.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dtpFecha)
    Me.KryptonPanel.Controls.Add(Me.txtHora)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
    Me.KryptonPanel.Controls.Add(Me.cboAreaResponsable)
    Me.KryptonPanel.Controls.Add(Me.txtUsuario)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
    Me.KryptonPanel.Controls.Add(Me.mnuEnviarArea)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(374, 146)
    Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
    Me.KryptonPanel.TabIndex = 0
    '
    'dtpFecha
    '
    Me.dtpFecha.Enabled = False
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(75, 70)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
    Me.dtpFecha.TabIndex = 4
    '
    'txtHora
    '
    Me.txtHora.Enabled = False
    Me.txtHora.Location = New System.Drawing.Point(255, 70)
    Me.txtHora.Name = "txtHora"
    Me.txtHora.ReadOnly = True
    Me.txtHora.Size = New System.Drawing.Size(100, 21)
    Me.txtHora.StateCommon.Back.Color1 = System.Drawing.Color.White
    Me.txtHora.TabIndex = 3
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(205, 71)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(35, 19)
    Me.KryptonLabel4.TabIndex = 2
    Me.KryptonLabel4.Text = "Hora"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Hora"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(15, 71)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel3.TabIndex = 5
    Me.KryptonLabel3.Text = "Fecha"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Fecha"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(15, 104)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(33, 19)
    Me.KryptonLabel2.TabIndex = 0
    Me.KryptonLabel2.Text = "Área"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Área"
    '
    'cboAreaResponsable
    '
    Me.cboAreaResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAreaResponsable.DropDownWidth = 121
    Me.cboAreaResponsable.FormattingEnabled = False
    Me.cboAreaResponsable.ItemHeight = 13
    Me.cboAreaResponsable.Location = New System.Drawing.Point(75, 103)
    Me.cboAreaResponsable.Name = "cboAreaResponsable"
    Me.cboAreaResponsable.Size = New System.Drawing.Size(121, 21)
    Me.cboAreaResponsable.TabIndex = 1
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(75, 35)
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.ReadOnly = True
    Me.txtUsuario.Size = New System.Drawing.Size(280, 21)
    Me.txtUsuario.TabIndex = 6
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(15, 36)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(48, 19)
    Me.KryptonLabel1.TabIndex = 7
    Me.KryptonLabel1.Text = "Usuario"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Usuario"
    '
    'mnuEnviarArea
    '
    Me.mnuEnviarArea.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.mnuEnviarArea.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.mnuEnviarArea.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnProcesar})
    Me.mnuEnviarArea.Location = New System.Drawing.Point(0, 0)
    Me.mnuEnviarArea.Name = "mnuEnviarArea"
    Me.mnuEnviarArea.Size = New System.Drawing.Size(374, 25)
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
    Me.btnProcesar.Size = New System.Drawing.Size(96, 22)
    Me.btnProcesar.Text = "Procesar Pase"
    '
    'frmAsignarArea
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(374, 146)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximumSize = New System.Drawing.Size(380, 170)
    Me.MinimumSize = New System.Drawing.Size(380, 170)
    Me.Name = "frmAsignarArea"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Realizar Pase de Operaciones"
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
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtHora As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboAreaResponsable As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents txtUsuario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
