<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVigenciaAlquiler
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
        Me.txtPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroAlquiler1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.txtObs = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.txtPlaca)
        Me.KryptonPanel.Controls.Add(Me.txtTipo)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel22)
        Me.KryptonPanel.Controls.Add(Me.txtNroAlquiler1)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaFin)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.dtpFechaInicio)
        Me.KryptonPanel.Controls.Add(Me.txtObs)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(579, 228)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'txtPlaca
        '
        Me.txtPlaca.Enabled = False
        Me.txtPlaca.Location = New System.Drawing.Point(208, 69)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(116, 22)
        Me.txtPlaca.TabIndex = 171
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(109, 69)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(93, 22)
        Me.txtTipo.TabIndex = 170
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(8, 74)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel3.TabIndex = 169
        Me.KryptonLabel3.Text = "Unidad"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Unidad"
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(8, 149)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(101, 20)
        Me.KryptonLabel22.TabIndex = 168
        Me.KryptonLabel22.Text = "Observación alq."
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Observación alq."
        '
        'txtNroAlquiler1
        '
        Me.txtNroAlquiler1.Enabled = False
        Me.txtNroAlquiler1.Location = New System.Drawing.Point(109, 42)
        Me.txtNroAlquiler1.Name = "txtNroAlquiler1"
        Me.txtNroAlquiler1.Size = New System.Drawing.Size(93, 22)
        Me.txtNroAlquiler1.TabIndex = 167
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(8, 43)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel2.TabIndex = 166
        Me.KryptonLabel2.Text = "Nro. Alquiler"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Nro. Alquiler"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 98)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel1.TabIndex = 165
        Me.KryptonLabel1.Text = "Fecha vigencia"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha vigencia"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(248, 98)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(77, 20)
        Me.dtpFechaFin.TabIndex = 102
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(208, 98)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 20)
        Me.KryptonLabel5.TabIndex = 100
        Me.KryptonLabel5.Text = "Hasta"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Hasta"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(109, 97)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaInicio.TabIndex = 101
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(109, 122)
        Me.txtObs.MaxLength = 250
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(441, 93)
        Me.txtObs.TabIndex = 163
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(579, 25)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.TabStop = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "Aceptar"
        '
        'frmVigenciaAlquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 228)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmVigenciaAlquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vigencia alquiler"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObs As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroAlquiler1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
