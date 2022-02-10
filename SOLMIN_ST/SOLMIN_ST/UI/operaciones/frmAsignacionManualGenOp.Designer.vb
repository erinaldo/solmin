<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionManualGenOp
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.hgReasignarRecurso = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtnro_viajes = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.tlsBarraHerramienta = New System.Windows.Forms.ToolStrip()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.mtb_hora_ini_op = New System.Windows.Forms.MaskedTextBox()
        Me.dtp_fecha_ini_op = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgReasignarRecurso.Panel.SuspendLayout()
        Me.hgReasignarRecurso.SuspendLayout()
        Me.tlsBarraHerramienta.SuspendLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'hgReasignarRecurso
        '
        Me.hgReasignarRecurso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgReasignarRecurso.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.hgReasignarRecurso.HeaderVisiblePrimary = False
        Me.hgReasignarRecurso.Location = New System.Drawing.Point(0, 0)
        Me.hgReasignarRecurso.Margin = New System.Windows.Forms.Padding(4)
        Me.hgReasignarRecurso.Name = "hgReasignarRecurso"
        '
        'hgReasignarRecurso.Panel
        '
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.mtb_hora_ini_op)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.dtp_fecha_ini_op)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.KryptonLabel28)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.txtnro_viajes)
        Me.hgReasignarRecurso.Panel.Controls.Add(Me.tlsBarraHerramienta)
        Me.hgReasignarRecurso.Size = New System.Drawing.Size(476, 218)
        Me.hgReasignarRecurso.TabIndex = 0
        Me.hgReasignarRecurso.Text = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Description = ""
        Me.hgReasignarRecurso.ValuesPrimary.Heading = "    "
        Me.hgReasignarRecurso.ValuesPrimary.Image = Nothing
        Me.hgReasignarRecurso.ValuesSecondary.Description = ""
        Me.hgReasignarRecurso.ValuesSecondary.Heading = "     "
        Me.hgReasignarRecurso.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(28, 109)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(85, 26)
        Me.KryptonLabel4.TabIndex = 164
        Me.KryptonLabel4.Text = "Nro Viajes:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Nro Viajes:"
        '
        'txtnro_viajes
        '
        Me.txtnro_viajes.Location = New System.Drawing.Point(179, 109)
        Me.txtnro_viajes.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnro_viajes.Name = "txtnro_viajes"
        Me.txtnro_viajes.ReadOnly = True
        Me.txtnro_viajes.Size = New System.Drawing.Size(147, 26)
        Me.txtnro_viajes.TabIndex = 163
        '
        'tlsBarraHerramienta
        '
        Me.tlsBarraHerramienta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tlsBarraHerramienta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsBarraHerramienta.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsBarraHerramienta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.btnCancelar})
        Me.tlsBarraHerramienta.Location = New System.Drawing.Point(0, 0)
        Me.tlsBarraHerramienta.Name = "tlsBarraHerramienta"
        Me.tlsBarraHerramienta.Size = New System.Drawing.Size(474, 27)
        Me.tlsBarraHerramienta.TabIndex = 0
        Me.tlsBarraHerramienta.TabStop = True
        Me.tlsBarraHerramienta.Text = "ToolStrip1"
        '
        'btnProcesar
        '
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(88, 24)
        Me.btnProcesar.Text = "Generar:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgReasignarRecurso)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(476, 218)
        Me.KryptonPanel.TabIndex = 3
        '
        'mtb_hora_ini_op
        '
        Me.mtb_hora_ini_op.Location = New System.Drawing.Point(179, 79)
        Me.mtb_hora_ini_op.Margin = New System.Windows.Forms.Padding(4)
        Me.mtb_hora_ini_op.Mask = "00:00"
        Me.mtb_hora_ini_op.Name = "mtb_hora_ini_op"
        Me.mtb_hora_ini_op.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.mtb_hora_ini_op.Size = New System.Drawing.Size(77, 22)
        Me.mtb_hora_ini_op.TabIndex = 170
        '
        'dtp_fecha_ini_op
        '
        Me.dtp_fecha_ini_op.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_ini_op.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fecha_ini_op.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_ini_op.Location = New System.Drawing.Point(179, 43)
        Me.dtp_fecha_ini_op.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_fecha_ini_op.Name = "dtp_fecha_ini_op"
        Me.dtp_fecha_ini_op.Size = New System.Drawing.Size(124, 24)
        Me.dtp_fecha_ini_op.TabIndex = 169
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(28, 41)
        Me.KryptonLabel28.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(108, 26)
        Me.KryptonLabel28.TabIndex = 168
        Me.KryptonLabel28.Text = "F. Ini Atención"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "F. Ini Atención"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(28, 75)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(134, 26)
        Me.KryptonLabel1.TabIndex = 171
        Me.KryptonLabel1.Text = "Hora Ini Atención:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Hora Ini Atención:"
        '
        'frmAsignacionManualGenOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(727, 666)
        Me.MinimumSize = New System.Drawing.Size(400, 250)
        Me.Name = "frmAsignacionManualGenOp"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Operación"
        CType(Me.hgReasignarRecurso.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.Panel.ResumeLayout(False)
        Me.hgReasignarRecurso.Panel.PerformLayout()
        CType(Me.hgReasignarRecurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgReasignarRecurso.ResumeLayout(False)
        Me.tlsBarraHerramienta.ResumeLayout(False)
        Me.tlsBarraHerramienta.PerformLayout()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager



    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents hgReasignarRecurso As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents tlsBarraHerramienta As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtnro_viajes As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents mtb_hora_ini_op As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtp_fecha_ini_op As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
