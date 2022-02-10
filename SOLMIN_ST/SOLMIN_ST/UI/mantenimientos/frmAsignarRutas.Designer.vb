<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarRutas
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboLugarorigen = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboLugarDestino = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtHoraRegistro = New System.Windows.Forms.MaskedTextBox
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCuposDisponibles = New SOLMIN_ST.TextField
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.MenuBar)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(432, 226)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel28)
        Me.KryptonPanel1.Controls.Add(Me.cboLugarorigen)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel30)
        Me.KryptonPanel1.Controls.Add(Me.cboLugarDestino)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel29)
        Me.KryptonPanel1.Controls.Add(Me.txtHoraRegistro)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel27)
        Me.KryptonPanel1.Controls.Add(Me.dtpFecha)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel26)
        Me.KryptonPanel1.Controls.Add(Me.txtCuposDisponibles)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(432, 201)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 10
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(19, 18)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(95, 19)
        Me.KryptonLabel28.TabIndex = 0
        Me.KryptonLabel28.Text = "Localidad Origen"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Localidad Origen"
        '
        'cboLugarorigen
        '
        Me.cboLugarorigen.BackColor = System.Drawing.Color.Transparent
        Me.cboLugarorigen.DataSource = Nothing
        Me.cboLugarorigen.DispleyMember = ""
        Me.cboLugarorigen.ListColumnas = Nothing
        Me.cboLugarorigen.Location = New System.Drawing.Point(149, 17)
        Me.cboLugarorigen.Name = "cboLugarorigen"
        Me.cboLugarorigen.Obligatorio = False
        Me.cboLugarorigen.Size = New System.Drawing.Size(251, 21)
        Me.cboLugarorigen.TabIndex = 5
        Me.cboLugarorigen.ValueMember = ""
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(19, 123)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(83, 19)
        Me.KryptonLabel30.TabIndex = 3
        Me.KryptonLabel30.Text = "Hora de Salida"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Hora de Salida"
        '
        'cboLugarDestino
        '
        Me.cboLugarDestino.BackColor = System.Drawing.Color.Transparent
        Me.cboLugarDestino.DataSource = Nothing
        Me.cboLugarDestino.DispleyMember = ""
        Me.cboLugarDestino.ListColumnas = Nothing
        Me.cboLugarDestino.Location = New System.Drawing.Point(149, 52)
        Me.cboLugarDestino.Name = "cboLugarDestino"
        Me.cboLugarDestino.Obligatorio = False
        Me.cboLugarDestino.Size = New System.Drawing.Size(251, 21)
        Me.cboLugarDestino.TabIndex = 6
        Me.cboLugarDestino.ValueMember = ""
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(19, 53)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(99, 19)
        Me.KryptonLabel29.TabIndex = 1
        Me.KryptonLabel29.Text = "Localidad Destino"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Localidad Destino"
        '
        'txtHoraRegistro
        '
        Me.txtHoraRegistro.Location = New System.Drawing.Point(149, 122)
        Me.txtHoraRegistro.Mask = "00:00:00"
        Me.txtHoraRegistro.Name = "txtHoraRegistro"
        Me.txtHoraRegistro.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraRegistro.Size = New System.Drawing.Size(88, 20)
        Me.txtHoraRegistro.TabIndex = 8
        Me.txtHoraRegistro.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(19, 88)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(88, 19)
        Me.KryptonLabel27.TabIndex = 2
        Me.KryptonLabel27.Text = "Fecha de Salida"
        Me.KryptonLabel27.Values.ExtraText = ""
        Me.KryptonLabel27.Values.Image = Nothing
        Me.KryptonLabel27.Values.Text = "Fecha de Salida"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(149, 87)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(19, 158)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(103, 19)
        Me.KryptonLabel26.TabIndex = 4
        Me.KryptonLabel26.Text = "Cupos Disponibles"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Cupos Disponibles"
        '
        'txtCuposDisponibles
        '
        Me.txtCuposDisponibles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuposDisponibles.Location = New System.Drawing.Point(149, 157)
        Me.txtCuposDisponibles.MaxLength = 4
        Me.txtCuposDisponibles.Name = "txtCuposDisponibles"
        Me.txtCuposDisponibles.Size = New System.Drawing.Size(88, 21)
        Me.txtCuposDisponibles.TabIndex = 9
        Me.txtCuposDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCuposDisponibles.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.btnGuardar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(432, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 22)
        Me.btnSalir.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'frmAsignarRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAsignarRutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignación de Rutas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboLugarorigen As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboLugarDestino As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoraRegistro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCuposDisponibles As SOLMIN_ST.TextField
End Class
