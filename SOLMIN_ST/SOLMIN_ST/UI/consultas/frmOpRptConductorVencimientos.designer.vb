<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpRptConductorVencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpRptConductorVencimientos))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.cboRecordMedico = New CodeTextBox.CodeTextBox
        Me.cboPases = New CodeTextBox.CodeTextBox
        Me.cboCapacitaciones = New CodeTextBox.CodeTextBox
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpLimiteFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpLimiteInicial = New System.Windows.Forms.DateTimePicker
        Me.rbtnVacunas = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnPases = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbtnCapacitaciones = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cboRecordMedico)
        Me.KryptonPanel.Controls.Add(Me.cboPases)
        Me.KryptonPanel.Controls.Add(Me.cboCapacitaciones)
        Me.KryptonPanel.Controls.Add(Me.btnCancelar)
        Me.KryptonPanel.Controls.Add(Me.btnAceptar)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.dtpLimiteFinal)
        Me.KryptonPanel.Controls.Add(Me.dtpLimiteInicial)
        Me.KryptonPanel.Controls.Add(Me.rbtnVacunas)
        Me.KryptonPanel.Controls.Add(Me.rbtnPases)
        Me.KryptonPanel.Controls.Add(Me.rbtnCapacitaciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(353, 189)
        Me.KryptonPanel.TabIndex = 0
        '
        'cboRecordMedico
        '
        Me.cboRecordMedico.Codigo = ""
        Me.cboRecordMedico.ControlHeight = 23
        Me.cboRecordMedico.ControlImage = True
        Me.cboRecordMedico.ControlReadOnly = False
        Me.cboRecordMedico.Descripcion = ""
        Me.cboRecordMedico.DisplayColumnVisible = True
        Me.cboRecordMedico.DisplayMember = ""
        Me.cboRecordMedico.Enabled = False
        Me.cboRecordMedico.KeyColumnWidth = 100
        Me.cboRecordMedico.KeyField = ""
        Me.cboRecordMedico.KeySearch = True
        Me.cboRecordMedico.Location = New System.Drawing.Point(131, 74)
        Me.cboRecordMedico.Name = "cboRecordMedico"
        Me.cboRecordMedico.Size = New System.Drawing.Size(200, 23)
        Me.cboRecordMedico.TabIndex = 71
        Me.cboRecordMedico.Tag = ""
        Me.cboRecordMedico.TextBackColor = System.Drawing.Color.Empty
        Me.cboRecordMedico.TextForeColor = System.Drawing.Color.Empty
        Me.cboRecordMedico.ValueColumnVisible = True
        Me.cboRecordMedico.ValueColumnWidth = 600
        Me.cboRecordMedico.ValueField = ""
        Me.cboRecordMedico.ValueMember = ""
        Me.cboRecordMedico.ValueSearch = True
        '
        'cboPases
        '
        Me.cboPases.Codigo = ""
        Me.cboPases.ControlHeight = 23
        Me.cboPases.ControlImage = True
        Me.cboPases.ControlReadOnly = False
        Me.cboPases.Descripcion = ""
        Me.cboPases.DisplayColumnVisible = True
        Me.cboPases.DisplayMember = ""
        Me.cboPases.Enabled = False
        Me.cboPases.KeyColumnWidth = 100
        Me.cboPases.KeyField = ""
        Me.cboPases.KeySearch = True
        Me.cboPases.Location = New System.Drawing.Point(131, 44)
        Me.cboPases.Name = "cboPases"
        Me.cboPases.Size = New System.Drawing.Size(200, 23)
        Me.cboPases.TabIndex = 71
        Me.cboPases.TextBackColor = System.Drawing.Color.Empty
        Me.cboPases.TextForeColor = System.Drawing.Color.Empty
        Me.cboPases.ValueColumnVisible = True
        Me.cboPases.ValueColumnWidth = 600
        Me.cboPases.ValueField = ""
        Me.cboPases.ValueMember = ""
        Me.cboPases.ValueSearch = True
        '
        'cboCapacitaciones
        '
        Me.cboCapacitaciones.Codigo = ""
        Me.cboCapacitaciones.ControlHeight = 23
        Me.cboCapacitaciones.ControlImage = True
        Me.cboCapacitaciones.ControlReadOnly = False
        Me.cboCapacitaciones.Descripcion = ""
        Me.cboCapacitaciones.DisplayColumnVisible = True
        Me.cboCapacitaciones.DisplayMember = ""
        Me.cboCapacitaciones.Enabled = False
        Me.cboCapacitaciones.KeyColumnWidth = 100
        Me.cboCapacitaciones.KeyField = ""
        Me.cboCapacitaciones.KeySearch = True
        Me.cboCapacitaciones.Location = New System.Drawing.Point(131, 15)
        Me.cboCapacitaciones.Name = "cboCapacitaciones"
        Me.cboCapacitaciones.Size = New System.Drawing.Size(200, 23)
        Me.cboCapacitaciones.TabIndex = 71
        Me.cboCapacitaciones.TextBackColor = System.Drawing.Color.Empty
        Me.cboCapacitaciones.TextForeColor = System.Drawing.Color.Empty
        Me.cboCapacitaciones.ValueColumnVisible = True
        Me.cboCapacitaciones.ValueColumnWidth = 600
        Me.cboCapacitaciones.ValueField = ""
        Me.cboCapacitaciones.ValueMember = ""
        Me.cboCapacitaciones.ValueSearch = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(196, 152)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(81, 152)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 25)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.Values.ExtraText = ""
        Me.btnAceptar.Values.Image = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAceptar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAceptar.Values.Text = "Aceptar"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(177, 114)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(40, 16)
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Text = "Hasta"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Hasta"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(32, 114)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(43, 16)
        Me.KryptonLabel1.TabIndex = 5
        Me.KryptonLabel1.Text = "Desde"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Desde"
        '
        'dtpLimiteFinal
        '
        Me.dtpLimiteFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLimiteFinal.Location = New System.Drawing.Point(223, 110)
        Me.dtpLimiteFinal.Name = "dtpLimiteFinal"
        Me.dtpLimiteFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtpLimiteFinal.TabIndex = 5
        '
        'dtpLimiteInicial
        '
        Me.dtpLimiteInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLimiteInicial.Location = New System.Drawing.Point(81, 110)
        Me.dtpLimiteInicial.Name = "dtpLimiteInicial"
        Me.dtpLimiteInicial.Size = New System.Drawing.Size(90, 20)
        Me.dtpLimiteInicial.TabIndex = 4
        '
        'rbtnVacunas
        '
        Me.rbtnVacunas.Location = New System.Drawing.Point(16, 77)
        Me.rbtnVacunas.Name = "rbtnVacunas"
        Me.rbtnVacunas.Size = New System.Drawing.Size(66, 16)
        Me.rbtnVacunas.TabIndex = 2
        Me.rbtnVacunas.Tag = "cboRecordMedico"
        Me.rbtnVacunas.Text = "Vacunas"
        Me.rbtnVacunas.Values.ExtraText = ""
        Me.rbtnVacunas.Values.Image = Nothing
        Me.rbtnVacunas.Values.Text = "Vacunas"
        '
        'rbtnPases
        '
        Me.rbtnPases.Location = New System.Drawing.Point(16, 47)
        Me.rbtnPases.Name = "rbtnPases"
        Me.rbtnPases.Size = New System.Drawing.Size(54, 16)
        Me.rbtnPases.TabIndex = 1
        Me.rbtnPases.Tag = "cboPases"
        Me.rbtnPases.Text = "Pases"
        Me.rbtnPases.Values.ExtraText = ""
        Me.rbtnPases.Values.Image = Nothing
        Me.rbtnPases.Values.Text = "Pases"
        '
        'rbtnCapacitaciones
        '
        Me.rbtnCapacitaciones.Location = New System.Drawing.Point(16, 18)
        Me.rbtnCapacitaciones.Name = "rbtnCapacitaciones"
        Me.rbtnCapacitaciones.Size = New System.Drawing.Size(100, 16)
        Me.rbtnCapacitaciones.TabIndex = 0
        Me.rbtnCapacitaciones.Tag = "cboCapacitaciones"
        Me.rbtnCapacitaciones.Text = "Capacitaciones"
        Me.rbtnCapacitaciones.Values.ExtraText = ""
        Me.rbtnCapacitaciones.Values.Image = Nothing
        Me.rbtnCapacitaciones.Values.Text = "Capacitaciones"
        '
        'frmOpRptConductorVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOpRptConductorVencimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opciones Reporte Vencimientos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
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
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpLimiteFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLimiteInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbtnVacunas As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnPases As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnCapacitaciones As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cboRecordMedico As CodeTextBox.CodeTextBox
    Friend WithEvents cboPases As CodeTextBox.CodeTextBox
    Friend WithEvents cboCapacitaciones As CodeTextBox.CodeTextBox
End Class
