<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoSeguimientoGPS
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
    Me.txtHoraRegistro = New System.Windows.Forms.MaskedTextBox
    Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtVelocidad = New System.Windows.Forms.TextBox
    Me.dtFechaGPS = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtLongitud = New System.Windows.Forms.TextBox
    Me.txtLatitud = New System.Windows.Forms.TextBox
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.btnSalir = New System.Windows.Forms.ToolStripButton
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.txtHoraRegistro)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel11)
    Me.KryptonPanel.Controls.Add(Me.txtVelocidad)
    Me.KryptonPanel.Controls.Add(Me.dtFechaGPS)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel8)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel7)
    Me.KryptonPanel.Controls.Add(Me.txtLongitud)
    Me.KryptonPanel.Controls.Add(Me.txtLatitud)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
    Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(392, 186)
    Me.KryptonPanel.TabIndex = 0
    '
    'txtHoraRegistro
    '
    Me.txtHoraRegistro.Location = New System.Drawing.Point(101, 65)
    Me.txtHoraRegistro.Mask = "00:00:00"
    Me.txtHoraRegistro.Name = "txtHoraRegistro"
    Me.txtHoraRegistro.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
    Me.txtHoraRegistro.Size = New System.Drawing.Size(80, 20)
    Me.txtHoraRegistro.TabIndex = 25
    Me.txtHoraRegistro.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
    '
    'KryptonLabel11
    '
    Me.KryptonLabel11.Location = New System.Drawing.Point(187, 65)
    Me.KryptonLabel11.Name = "KryptonLabel11"
    Me.KryptonLabel11.Size = New System.Drawing.Size(64, 19)
    Me.KryptonLabel11.TabIndex = 24
    Me.KryptonLabel11.Text = "(hh:mm:ss)"
    Me.KryptonLabel11.Values.ExtraText = ""
    Me.KryptonLabel11.Values.Image = Nothing
    Me.KryptonLabel11.Values.Text = "(hh:mm:ss)"
    '
    'txtVelocidad
    '
    Me.txtVelocidad.Location = New System.Drawing.Point(101, 139)
    Me.txtVelocidad.MaxLength = 16
    Me.txtVelocidad.Name = "txtVelocidad"
    Me.txtVelocidad.Size = New System.Drawing.Size(176, 20)
    Me.txtVelocidad.TabIndex = 21
    '
    'dtFechaGPS
    '
    Me.dtFechaGPS.CalendarMonthBackground = System.Drawing.SystemColors.Info
    Me.dtFechaGPS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtFechaGPS.Location = New System.Drawing.Point(101, 39)
    Me.dtFechaGPS.Name = "dtFechaGPS"
    Me.dtFechaGPS.Size = New System.Drawing.Size(176, 20)
    Me.dtFechaGPS.TabIndex = 17
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(6, 66)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(58, 19)
    Me.KryptonLabel8.TabIndex = 14
    Me.KryptonLabel8.Text = "Hora GPS"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Hora GPS"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(6, 41)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(62, 19)
    Me.KryptonLabel7.TabIndex = 13
    Me.KryptonLabel7.Text = "Fecha GPS"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "Fecha GPS"
    '
    'txtLongitud
    '
    Me.txtLongitud.BackColor = System.Drawing.SystemColors.Info
    Me.txtLongitud.Location = New System.Drawing.Point(101, 113)
    Me.txtLongitud.MaxLength = 15
    Me.txtLongitud.Name = "txtLongitud"
    Me.txtLongitud.Size = New System.Drawing.Size(250, 20)
    Me.txtLongitud.TabIndex = 11
    '
    'txtLatitud
    '
    Me.txtLatitud.BackColor = System.Drawing.SystemColors.Info
    Me.txtLatitud.Location = New System.Drawing.Point(101, 91)
    Me.txtLatitud.MaxLength = 15
    Me.txtLatitud.Name = "txtLatitud"
    Me.txtLatitud.Size = New System.Drawing.Size(250, 20)
    Me.txtLatitud.TabIndex = 10
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(6, 139)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(93, 19)
    Me.KryptonLabel6.TabIndex = 6
    Me.KryptonLabel6.Text = "Velocidad(km/h)"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Velocidad(km/h)"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(6, 113)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(55, 19)
    Me.KryptonLabel5.TabIndex = 5
    Me.KryptonLabel5.Text = "Longitud"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Longitud"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(6, 90)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(45, 19)
    Me.KryptonLabel4.TabIndex = 4
    Me.KryptonLabel4.Text = "Latitud"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Latitud"
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuardar, Me.Separator1, Me.btnCancelar, Me.btnSalir})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(392, 25)
    Me.ToolStrip1.TabIndex = 0
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnGuardar
    '
    Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
    Me.btnGuardar.Text = "Guardar"
    '
    'Separator1
    '
    Me.Separator1.Name = "Separator1"
    Me.Separator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnCancelar
    '
    Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'btnSalir
    '
    Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
    Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(49, 22)
    Me.btnSalir.Text = "Salir"
    Me.btnSalir.Visible = False
    '
    'frmNuevoSeguimientoGPS
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(392, 186)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(400, 220)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(400, 220)
    Me.Name = "frmNuevoSeguimientoGPS"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Mantenimiento GPS"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtLongitud As System.Windows.Forms.TextBox
    Friend WithEvents txtLatitud As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtFechaGPS As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVelocidad As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoraRegistro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
End Class
