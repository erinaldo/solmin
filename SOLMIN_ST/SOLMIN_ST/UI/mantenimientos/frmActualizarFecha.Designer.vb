<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarFecha
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lbl_6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaRealSalida = New System.Windows.Forms.DateTimePicker
        Me.lbl_4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnActualizar = New System.Windows.Forms.ToolStripButton
        Me.dtpFechaEstimadaSalida = New System.Windows.Forms.DateTimePicker
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblDiasEstimados = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtHoraFin = New System.Windows.Forms.MaskedTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtHoraInicio = New System.Windows.Forms.MaskedTextBox
        Me.dtpFechaRealLlegada = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaEstimadaLlegada = New System.Windows.Forms.DateTimePicker
        Me.lbl_5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl_3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txt_2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txt_1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lbl_2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.lbl_1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCalcularFecha = New System.Windows.Forms.ToolStripButton
        Me.lblmensaje = New System.Windows.Forms.Label
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'lbl_6
        '
        Me.lbl_6.Location = New System.Drawing.Point(258, 125)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(147, 22)
        Me.lbl_6.TabIndex = 111
        Me.lbl_6.Text = "Fecha Real Llegada (RTA)"
        Me.lbl_6.Values.ExtraText = ""
        Me.lbl_6.Values.Image = Nothing
        Me.lbl_6.Values.Text = "Fecha Real Llegada (RTA)"
        '
        'dtpFechaRealSalida
        '
        Me.dtpFechaRealSalida.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRealSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRealSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRealSalida.Location = New System.Drawing.Point(155, 124)
        Me.dtpFechaRealSalida.Name = "dtpFechaRealSalida"
        Me.dtpFechaRealSalida.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaRealSalida.TabIndex = 3
        '
        'lbl_4
        '
        Me.lbl_4.Location = New System.Drawing.Point(258, 79)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(172, 22)
        Me.lbl_4.TabIndex = 21
        Me.lbl_4.Text = "Fecha Estimada Llegada (ETA)"
        Me.lbl_4.Values.ExtraText = ""
        Me.lbl_4.Values.Image = Nothing
        Me.lbl_4.Values.Text = "Fecha Estimada Llegada (ETA)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(79, 22)
        Me.btnActualizar.Text = "Actualizar"
        '
        'dtpFechaEstimadaSalida
        '
        Me.dtpFechaEstimadaSalida.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEstimadaSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEstimadaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEstimadaSalida.Location = New System.Drawing.Point(155, 78)
        Me.dtpFechaEstimadaSalida.Name = "dtpFechaEstimadaSalida"
        Me.dtpFechaEstimadaSalida.Size = New System.Drawing.Size(88, 21)
        Me.dtpFechaEstimadaSalida.TabIndex = 1
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(524, 243)
        Me.KryptonPanel.TabIndex = 2
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblmensaje)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDiasEstimados)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtHoraFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtHoraInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaRealLlegada)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaEstimadaLlegada)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lbl_6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaRealSalida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lbl_4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaEstimadaSalida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lbl_5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lbl_3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txt_2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txt_1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lbl_2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lbl_1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.MenuBar)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(524, 243)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "    "
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "    "
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "     "
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'lblDiasEstimados
        '
        Me.lblDiasEstimados.AutoSize = True
        Me.lblDiasEstimados.Location = New System.Drawing.Point(186, 191)
        Me.lblDiasEstimados.Name = "lblDiasEstimados"
        Me.lblDiasEstimados.Size = New System.Drawing.Size(33, 13)
        Me.lblDiasEstimados.TabIndex = 119
        Me.lblDiasEstimados.Text = "[xxxx]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "Días de Duración Estimados : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(296, 162)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(89, 22)
        Me.KryptonLabel1.TabIndex = 117
        Me.KryptonLabel1.Text = "Hora Fin (RTA)"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Hora Fin (RTA)"
        '
        'txtHoraFin
        '
        Me.txtHoraFin.Enabled = False
        Me.txtHoraFin.Location = New System.Drawing.Point(420, 164)
        Me.txtHoraFin.Mask = "00:00"
        Me.txtHoraFin.Name = "txtHoraFin"
        Me.txtHoraFin.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraFin.Size = New System.Drawing.Size(67, 20)
        Me.txtHoraFin.TabIndex = 116
        Me.txtHoraFin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(29, 162)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel9.TabIndex = 115
        Me.KryptonLabel9.Text = "Hora Inicio (RTS)"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Hora Inicio (RTS)"
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(153, 164)
        Me.txtHoraInicio.Mask = "00:00"
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraInicio.Size = New System.Drawing.Size(67, 20)
        Me.txtHoraInicio.TabIndex = 114
        Me.txtHoraInicio.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'dtpFechaRealLlegada
        '
        Me.dtpFechaRealLlegada.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRealLlegada.Checked = False
        Me.dtpFechaRealLlegada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRealLlegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRealLlegada.Location = New System.Drawing.Point(419, 124)
        Me.dtpFechaRealLlegada.Name = "dtpFechaRealLlegada"
        Me.dtpFechaRealLlegada.ShowCheckBox = True
        Me.dtpFechaRealLlegada.Size = New System.Drawing.Size(96, 21)
        Me.dtpFechaRealLlegada.TabIndex = 113
        '
        'dtpFechaEstimadaLlegada
        '
        Me.dtpFechaEstimadaLlegada.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEstimadaLlegada.Checked = False
        Me.dtpFechaEstimadaLlegada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEstimadaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEstimadaLlegada.Location = New System.Drawing.Point(419, 78)
        Me.dtpFechaEstimadaLlegada.Name = "dtpFechaEstimadaLlegada"
        Me.dtpFechaEstimadaLlegada.ShowCheckBox = True
        Me.dtpFechaEstimadaLlegada.Size = New System.Drawing.Size(96, 21)
        Me.dtpFechaEstimadaLlegada.TabIndex = 112
        '
        'lbl_5
        '
        Me.lbl_5.Location = New System.Drawing.Point(3, 125)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(136, 22)
        Me.lbl_5.TabIndex = 14
        Me.lbl_5.Text = "Fecha Real Salida (RTS)"
        Me.lbl_5.Values.ExtraText = ""
        Me.lbl_5.Values.Image = Nothing
        Me.lbl_5.Values.Text = "Fecha Real Salida (RTS)"
        '
        'lbl_3
        '
        Me.lbl_3.Location = New System.Drawing.Point(3, 79)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(160, 22)
        Me.lbl_3.TabIndex = 13
        Me.lbl_3.Text = "Fecha Estimada Salida (ETS)"
        Me.lbl_3.Values.ExtraText = ""
        Me.lbl_3.Values.Image = Nothing
        Me.lbl_3.Values.Text = "Fecha Estimada Salida (ETS)"
        '
        'txt_2
        '
        Me.txt_2.Enabled = False
        Me.txt_2.Location = New System.Drawing.Point(420, 32)
        Me.txt_2.Name = "txt_2"
        Me.txt_2.Size = New System.Drawing.Size(95, 22)
        Me.txt_2.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_2.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txt_2.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_2.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txt_2.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txt_2.TabIndex = 12
        Me.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_1
        '
        Me.txt_1.Enabled = False
        Me.txt_1.Location = New System.Drawing.Point(80, 32)
        Me.txt_1.Name = "txt_1"
        Me.txt_1.Size = New System.Drawing.Size(245, 22)
        Me.txt_1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_1.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txt_1.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_1.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txt_1.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txt_1.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_1.TabIndex = 11
        Me.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_2
        '
        Me.lbl_2.Location = New System.Drawing.Point(328, 33)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(97, 22)
        Me.lbl_2.TabIndex = 9
        Me.lbl_2.Text = "Guía Transporte"
        Me.lbl_2.Values.ExtraText = ""
        Me.lbl_2.Values.Image = Nothing
        Me.lbl_2.Values.Text = "Guía Transporte"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(12, 60)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(500, 1)
        Me.KryptonBorderEdge1.TabIndex = 8
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'lbl_1
        '
        Me.lbl_1.Location = New System.Drawing.Point(3, 33)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(82, 22)
        Me.lbl_1.TabIndex = 6
        Me.lbl_1.Text = "Transportista"
        Me.lbl_1.Values.ExtraText = ""
        Me.lbl_1.Values.Image = Nothing
        Me.lbl_1.Values.Text = "Transportista"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizar, Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator2, Me.btnCalcularFecha})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(522, 25)
        Me.MenuBar.TabIndex = 7
        Me.MenuBar.TabStop = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCalcularFecha
        '
        Me.btnCalcularFecha.Image = Global.SOLMIN_ST.My.Resources.Resources.flecha
        Me.btnCalcularFecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCalcularFecha.Name = "btnCalcularFecha"
        Me.btnCalcularFecha.Size = New System.Drawing.Size(93, 22)
        Me.btnCalcularFecha.Text = "Calcular ETA"
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.Color.Red
        Me.lblmensaje.Location = New System.Drawing.Point(265, 191)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(29, 13)
        Me.lblmensaje.TabIndex = 120
        Me.lblmensaje.Text = "msg"
        '
        'frmActualizarFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmActualizarFecha"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de Información"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents lbl_6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaRealSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnActualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpFechaEstimadaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lbl_5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbl_3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txt_2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txt_1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lbl_2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents lbl_1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpFechaRealLlegada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEstimadaLlegada As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoraFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHoraInicio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCalcularFecha As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblDiasEstimados As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
End Class
