<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionCicloWAP
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
        Me.panelInformacionCiclo = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtCiclo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtHoraCreacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaCreacion = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlacaTracto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.panelInformacionCiclo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInformacionCiclo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelInformacionCiclo
        '
        Me.panelInformacionCiclo.Controls.Add(Me.txtCiclo)
        Me.panelInformacionCiclo.Controls.Add(Me.KryptonLabel4)
        Me.panelInformacionCiclo.Controls.Add(Me.txtHoraCreacion)
        Me.panelInformacionCiclo.Controls.Add(Me.KryptonLabel3)
        Me.panelInformacionCiclo.Controls.Add(Me.dtpFechaCreacion)
        Me.panelInformacionCiclo.Controls.Add(Me.KryptonLabel2)
        Me.panelInformacionCiclo.Controls.Add(Me.txtPlacaTracto)
        Me.panelInformacionCiclo.Controls.Add(Me.KryptonLabel1)
        Me.panelInformacionCiclo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelInformacionCiclo.Location = New System.Drawing.Point(0, 0)
        Me.panelInformacionCiclo.Name = "panelInformacionCiclo"
        Me.panelInformacionCiclo.Size = New System.Drawing.Size(199, 130)
        Me.panelInformacionCiclo.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelInformacionCiclo.TabIndex = 0
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(96, 14)
        Me.txtCiclo.MaxLength = 15
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.ReadOnly = True
        Me.txtCiclo.Size = New System.Drawing.Size(88, 19)
        Me.txtCiclo.TabIndex = 1
        Me.txtCiclo.TabStop = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(4, 13)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(35, 16)
        Me.KryptonLabel4.TabIndex = 6
        Me.KryptonLabel4.Text = "Ciclo"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Ciclo"
        '
        'txtHoraCreacion
        '
        Me.txtHoraCreacion.Location = New System.Drawing.Point(96, 102)
        Me.txtHoraCreacion.Name = "txtHoraCreacion"
        Me.txtHoraCreacion.ReadOnly = True
        Me.txtHoraCreacion.Size = New System.Drawing.Size(88, 19)
        Me.txtHoraCreacion.TabIndex = 4
        Me.txtHoraCreacion.TabStop = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 103)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(83, 16)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Hora Creación"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hora Creación"
        '
        'dtpFechaCreacion
        '
        Me.dtpFechaCreacion.Enabled = False
        Me.dtpFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCreacion.Location = New System.Drawing.Point(96, 72)
        Me.dtpFechaCreacion.Name = "dtpFechaCreacion"
        Me.dtpFechaCreacion.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaCreacion.TabIndex = 3
        Me.dtpFechaCreacion.TabStop = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 73)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(90, 16)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Text = "Fecha Creación"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha Creación"
        '
        'txtPlacaTracto
        '
        Me.txtPlacaTracto.Location = New System.Drawing.Point(96, 43)
        Me.txtPlacaTracto.MaxLength = 15
        Me.txtPlacaTracto.Name = "txtPlacaTracto"
        Me.txtPlacaTracto.ReadOnly = True
        Me.txtPlacaTracto.Size = New System.Drawing.Size(88, 19)
        Me.txtPlacaTracto.TabIndex = 2
        Me.txtPlacaTracto.TabStop = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 43)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(71, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Placa Tracto"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Placa Tracto"
        '
        'frmInformacionCicloWAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 130)
        Me.Controls.Add(Me.panelInformacionCiclo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInformacionCicloWAP"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información Ciclo WAP"
        CType(Me.panelInformacionCiclo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInformacionCiclo.ResumeLayout(False)
        Me.panelInformacionCiclo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents panelInformacionCiclo As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

  Public Sub New()

    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents txtHoraCreacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaCreacion As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPlacaTracto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCiclo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
