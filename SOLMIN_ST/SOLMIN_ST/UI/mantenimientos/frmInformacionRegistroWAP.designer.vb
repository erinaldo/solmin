<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionRegistroWAP
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
        Me.panelInformacionRegistro = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.txtCiclo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtHoraRegistro = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaRegistro = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNombre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.panelInformacionRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInformacionRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelInformacionRegistro
        '
        Me.panelInformacionRegistro.Controls.Add(Me.txtCiclo)
        Me.panelInformacionRegistro.Controls.Add(Me.KryptonLabel4)
        Me.panelInformacionRegistro.Controls.Add(Me.txtHoraRegistro)
        Me.panelInformacionRegistro.Controls.Add(Me.KryptonLabel3)
        Me.panelInformacionRegistro.Controls.Add(Me.dtpFechaRegistro)
        Me.panelInformacionRegistro.Controls.Add(Me.KryptonLabel2)
        Me.panelInformacionRegistro.Controls.Add(Me.txtObservacion)
        Me.panelInformacionRegistro.Controls.Add(Me.KryptonLabel5)
        Me.panelInformacionRegistro.Controls.Add(Me.txtNombre)
        Me.panelInformacionRegistro.Controls.Add(Me.KryptonLabel1)
        Me.panelInformacionRegistro.Controls.Add(Me.btnCerrar)
        Me.panelInformacionRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelInformacionRegistro.Location = New System.Drawing.Point(0, 0)
        Me.panelInformacionRegistro.Name = "panelInformacionRegistro"
        Me.panelInformacionRegistro.Size = New System.Drawing.Size(330, 237)
        Me.panelInformacionRegistro.StateCommon.Color1 = System.Drawing.Color.White
        Me.panelInformacionRegistro.TabIndex = 0
        '
        'txtCiclo
        '
        Me.txtCiclo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiclo.Location = New System.Drawing.Point(96, 8)
        Me.txtCiclo.MaxLength = 15
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.ReadOnly = True
        Me.txtCiclo.Size = New System.Drawing.Size(100, 19)
        Me.txtCiclo.TabIndex = 1
        Me.txtCiclo.TabStop = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(4, 12)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(35, 16)
        Me.KryptonLabel4.TabIndex = 10
        Me.KryptonLabel4.Text = "Ciclo"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Ciclo"
        '
        'txtHoraRegistro
        '
        Me.txtHoraRegistro.Location = New System.Drawing.Point(96, 93)
        Me.txtHoraRegistro.Name = "txtHoraRegistro"
        Me.txtHoraRegistro.ReadOnly = True
        Me.txtHoraRegistro.Size = New System.Drawing.Size(100, 19)
        Me.txtHoraRegistro.TabIndex = 4
        Me.txtHoraRegistro.TabStop = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 94)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(83, 16)
        Me.KryptonLabel3.TabIndex = 8
        Me.KryptonLabel3.Text = "Hora Creación"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Hora Creación"
        '
        'dtpFechaRegistro
        '
        Me.dtpFechaRegistro.Enabled = False
        Me.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRegistro.Location = New System.Drawing.Point(96, 64)
        Me.dtpFechaRegistro.Name = "dtpFechaRegistro"
        Me.dtpFechaRegistro.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaRegistro.TabIndex = 3
        Me.dtpFechaRegistro.TabStop = False
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 67)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(90, 16)
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Text = "Fecha Creación"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha Creación"
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Location = New System.Drawing.Point(96, 122)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ReadOnly = True
        Me.txtObservacion.Size = New System.Drawing.Size(224, 103)
        Me.txtObservacion.TabIndex = 2
        Me.txtObservacion.TabStop = False
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 122)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(74, 16)
        Me.KryptonLabel5.TabIndex = 0
        Me.KryptonLabel5.Text = "Observación"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Observación"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(96, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(224, 19)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TabStop = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 40)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(49, 16)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Usuario"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Usuario"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(301, 40)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(8, 8)
        Me.btnCerrar.StateDisabled.Border.Color1 = System.Drawing.Color.Transparent
        Me.btnCerrar.StateDisabled.Border.Color2 = System.Drawing.Color.Transparent
        Me.btnCerrar.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCerrar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent
        Me.btnCerrar.TabIndex = 19
        Me.btnCerrar.Text = "Cerrar Ventana"
        Me.btnCerrar.Values.ExtraText = ""
        Me.btnCerrar.Values.Image = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCerrar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCerrar.Values.Text = "Cerrar Ventana"
        '
        'frmInformacionRegistroWAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(330, 237)
        Me.Controls.Add(Me.panelInformacionRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(336, 261)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(336, 261)
        Me.Name = "frmInformacionRegistroWAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información Registro WAP"
        CType(Me.panelInformacionRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInformacionRegistro.ResumeLayout(False)
        Me.panelInformacionRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents panelInformacionRegistro As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New(ByVal obj As SOLMIN_ST.ENTIDADES.RegistroWAP )

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objRegistroWAP = obj
    End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()
  End Sub
  Friend WithEvents txtNombre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtHoraRegistro As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaRegistro As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCiclo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
