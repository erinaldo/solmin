<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicioAlmacen
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnGuiaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtGuiaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblGuiaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtHoraSalida = New System.Windows.Forms.MaskedTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraAtencion = New System.Windows.Forms.MaskedTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaAsignacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtFechaSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblFecha_2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.lblFecha_1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
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
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(539, 252)
        Me.KryptonPanel.TabIndex = 1
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGuiaTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtGuiaTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblGuiaTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtHoraSalida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaSalida)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtHoraAtencion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaAtencion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFechaAsignacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFechaSolicitud)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFecha_2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFecha_1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.MenuBar)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(539, 252)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "    "
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "    "
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "     "
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnGuiaTransporte
        '
        Me.btnGuiaTransporte.Location = New System.Drawing.Point(261, 156)
        Me.btnGuiaTransporte.Name = "btnGuiaTransporte"
        Me.btnGuiaTransporte.Size = New System.Drawing.Size(160, 25)
        Me.btnGuiaTransporte.TabIndex = 6
        Me.btnGuiaTransporte.Text = "Generar Guía Transporte"
        Me.btnGuiaTransporte.Values.ExtraText = ""
        Me.btnGuiaTransporte.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.runprog
        Me.btnGuiaTransporte.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuiaTransporte.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuiaTransporte.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuiaTransporte.Values.Text = "Generar Guía Transporte"
        '
        'txtGuiaTransporte
        '
        Me.txtGuiaTransporte.Location = New System.Drawing.Point(115, 158)
        Me.txtGuiaTransporte.MaxLength = 10
        Me.txtGuiaTransporte.Name = "txtGuiaTransporte"
        Me.txtGuiaTransporte.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.txtGuiaTransporte.Size = New System.Drawing.Size(88, 26)
        Me.txtGuiaTransporte.TabIndex = 5
        '
        'lblGuiaTransporte
        '
        Me.lblGuiaTransporte.Location = New System.Drawing.Point(8, 159)
        Me.lblGuiaTransporte.Name = "lblGuiaTransporte"
        Me.lblGuiaTransporte.Size = New System.Drawing.Size(120, 26)
        Me.lblGuiaTransporte.TabIndex = 113
        Me.lblGuiaTransporte.Text = "Guía Transporte"
        Me.lblGuiaTransporte.Values.ExtraText = ""
        Me.lblGuiaTransporte.Values.Image = Nothing
        Me.lblGuiaTransporte.Values.Text = "Guía Transporte"
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.Location = New System.Drawing.Point(345, 119)
        Me.txtHoraSalida.Mask = "00:00:00"
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraSalida.Size = New System.Drawing.Size(76, 22)
        Me.txtHoraSalida.TabIndex = 4
        Me.txtHoraSalida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(224, 120)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(89, 26)
        Me.KryptonLabel6.TabIndex = 111
        Me.KryptonLabel6.Text = "Hora Salida"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Hora Salida"
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(115, 119)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(88, 24)
        Me.dtpFechaSalida.TabIndex = 3
        '
        'txtHoraAtencion
        '
        Me.txtHoraAtencion.Location = New System.Drawing.Point(345, 79)
        Me.txtHoraAtencion.Mask = "00:00:00"
        Me.txtHoraAtencion.Name = "txtHoraAtencion"
        Me.txtHoraAtencion.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtHoraAtencion.Size = New System.Drawing.Size(76, 22)
        Me.txtHoraAtencion.TabIndex = 2
        Me.txtHoraAtencion.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(224, 80)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(110, 26)
        Me.KryptonLabel1.TabIndex = 21
        Me.KryptonLabel1.Text = "Hora Atención"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Hora Atención"
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAtencion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(115, 79)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(88, 24)
        Me.dtpFechaAtencion.TabIndex = 1
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(8, 120)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(96, 26)
        Me.KryptonLabel5.TabIndex = 14
        Me.KryptonLabel5.Text = "Fecha Salida"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Fecha Salida"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(8, 80)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(116, 26)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Text = "Fecha Atención"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha Atención"
        '
        'txtFechaAsignacion
        '
        Me.txtFechaAsignacion.Enabled = False
        Me.txtFechaAsignacion.Location = New System.Drawing.Point(376, 30)
        Me.txtFechaAsignacion.Name = "txtFechaAsignacion"
        Me.txtFechaAsignacion.Size = New System.Drawing.Size(100, 26)
        Me.txtFechaAsignacion.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaAsignacion.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtFechaAsignacion.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaAsignacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFechaAsignacion.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtFechaAsignacion.TabIndex = 12
        Me.txtFechaAsignacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(134, 28)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(100, 26)
        Me.txtFechaSolicitud.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaSolicitud.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
        Me.txtFechaSolicitud.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaSolicitud.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtFechaSolicitud.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtFechaSolicitud.TabIndex = 11
        Me.txtFechaSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFecha_2
        '
        Me.lblFecha_2.Location = New System.Drawing.Point(240, 35)
        Me.lblFecha_2.Name = "lblFecha_2"
        Me.lblFecha_2.Size = New System.Drawing.Size(130, 26)
        Me.lblFecha_2.TabIndex = 9
        Me.lblFecha_2.Text = "Fecha Asignación"
        Me.lblFecha_2.Values.ExtraText = ""
        Me.lblFecha_2.Values.Image = Nothing
        Me.lblFecha_2.Values.Text = "Fecha Asignación"
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(8, 60)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(450, 1)
        Me.KryptonBorderEdge1.TabIndex = 8
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'lblFecha_1
        '
        Me.lblFecha_1.Location = New System.Drawing.Point(8, 30)
        Me.lblFecha_1.Name = "lblFecha_1"
        Me.lblFecha_1.Size = New System.Drawing.Size(114, 26)
        Me.lblFecha_1.TabIndex = 6
        Me.lblFecha_1.Text = "Fecha Solicitud"
        Me.lblFecha_1.Values.ExtraText = ""
        Me.lblFecha_1.Values.Image = Nothing
        Me.lblFecha_1.Values.Text = "Fecha Solicitud"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.ToolStripSeparator1, Me.btnCancelar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(537, 27)
        Me.MenuBar.TabIndex = 7
        Me.MenuBar.TabStop = True
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnProcesar
        '
        Me.btnProcesar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(89, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmServicioAlmacen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(539, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmServicioAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirmación Servicio Almacén"
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
  Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents txtFechaSolicitud As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblFecha_2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
  Friend WithEvents lblFecha_1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents txtFechaAsignacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaAtencion As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtGuiaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblGuiaTransporte As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtHoraSalida As System.Windows.Forms.MaskedTextBox
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtHoraAtencion As System.Windows.Forms.MaskedTextBox
  Friend WithEvents btnGuiaTransporte As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
