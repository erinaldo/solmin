<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaViajesRealizados
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaViajesRealizados))
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.panel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ControlVisorLiquidacion = New SOLMIN_ST.Control_Visor_Reporte
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
    Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.cboDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.cboCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.ctbOrigenCon2 = New CodeTextBox.CodeTextBox
    Me.ctbOrigenCon1 = New CodeTextBox.CodeTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.rbtCliente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbtFecha = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel.SuspendLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupTabs.Panel.SuspendLayout()
    Me.HeaderGroupTabs.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupFiltro.Panel.SuspendLayout()
    Me.HeaderGroupFiltro.SuspendLayout()
    Me.SuspendLayout()
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(173, 62)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaFin.TabIndex = 6
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(1, 64)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(40, 17)
    Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel2.TabIndex = 103
    Me.KryptonLabel2.Text = "Fecha"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Fecha"
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(150, 64)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
    Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel4.TabIndex = 105
    Me.KryptonLabel4.Text = "Al"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Al"
    '
    'panel
    '
    Me.panel.Controls.Add(Me.HeaderGroupTabs)
    Me.panel.Controls.Add(Me.HeaderGroupFiltro)
    Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.panel.Location = New System.Drawing.Point(0, 0)
    Me.panel.Name = "panel"
    Me.panel.Size = New System.Drawing.Size(941, 505)
    Me.panel.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaptionText
    Me.panel.TabIndex = 1
    '
    'HeaderGroupTabs
    '
    Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 112)
    Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
    '
    'HeaderGroupTabs.Panel
    '
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.ControlVisorLiquidacion)
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
    Me.HeaderGroupTabs.Size = New System.Drawing.Size(941, 393)
    Me.HeaderGroupTabs.TabIndex = 5
    Me.HeaderGroupTabs.Text = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Description = ""
    Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
    Me.HeaderGroupTabs.ValuesSecondary.Description = ""
    Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
    Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
    '
    'ControlVisorLiquidacion
    '
    Me.ControlVisorLiquidacion.BackColor = System.Drawing.Color.Transparent
    Me.ControlVisorLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ControlVisorLiquidacion.Location = New System.Drawing.Point(0, 25)
    Me.ControlVisorLiquidacion.Name = "ControlVisorLiquidacion"
    Me.ControlVisorLiquidacion.Size = New System.Drawing.Size(939, 346)
    Me.ControlVisorLiquidacion.TabIndex = 5
    '
    'Panel2
    '
    Me.Panel2.AutoSize = True
    Me.Panel2.Controls.Add(Me.MenuBar)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(939, 25)
    Me.Panel2.TabIndex = 4
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(939, 25)
    Me.MenuBar.TabIndex = 2
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnProcesarReporte
    '
    Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesarReporte.Name = "btnProcesarReporte"
    Me.btnProcesarReporte.Size = New System.Drawing.Size(110, 22)
    Me.btnProcesarReporte.Text = "Procesar Reporte"
    '
    'HeaderGroupFiltro
    '
    Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
    Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
    '
    'HeaderGroupFiltro.Panel
    '
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.rbtFecha)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.rbtCliente)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel9)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboPlanta)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboDivision)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboCompania)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel6)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel7)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel8)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctbOrigenCon2)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctbOrigenCon1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtCliente)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
    Me.HeaderGroupFiltro.Size = New System.Drawing.Size(941, 112)
    Me.HeaderGroupFiltro.TabIndex = 4
    Me.HeaderGroupFiltro.Text = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
    Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
    Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
    '
    'KryptonLabel9
    '
    Me.KryptonLabel9.Location = New System.Drawing.Point(339, 64)
    Me.KryptonLabel9.Name = "KryptonLabel9"
    Me.KryptonLabel9.Size = New System.Drawing.Size(50, 16)
    Me.KryptonLabel9.TabIndex = 116
    Me.KryptonLabel9.Text = "Agrupar"
    Me.KryptonLabel9.Values.ExtraText = ""
    Me.KryptonLabel9.Values.Image = Nothing
    Me.KryptonLabel9.Values.Text = "Agrupar"
    '
    'cboPlanta
    '
    Me.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPlanta.DropDownWidth = 232
    Me.cboPlanta.FormattingEnabled = False
    Me.cboPlanta.ItemHeight = 13
    Me.cboPlanta.Location = New System.Drawing.Point(691, 6)
    Me.cboPlanta.Name = "cboPlanta"
    Me.cboPlanta.Size = New System.Drawing.Size(236, 21)
    Me.cboPlanta.TabIndex = 115
    Me.cboPlanta.TabStop = False
    '
    'cboDivision
    '
    Me.cboDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDivision.DropDownWidth = 211
    Me.cboDivision.FormattingEnabled = False
    Me.cboDivision.ItemHeight = 13
    Me.cboDivision.Location = New System.Drawing.Point(391, 6)
    Me.cboDivision.Name = "cboDivision"
    Me.cboDivision.Size = New System.Drawing.Size(241, 21)
    Me.cboDivision.TabIndex = 114
    Me.cboDivision.TabStop = False
    '
    'cboCompania
    '
    Me.cboCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCompania.DropDownWidth = 248
    Me.cboCompania.FormattingEnabled = False
    Me.cboCompania.ItemHeight = 13
    Me.cboCompania.Location = New System.Drawing.Point(64, 6)
    Me.cboCompania.Name = "cboCompania"
    Me.cboCompania.Size = New System.Drawing.Size(272, 21)
    Me.cboCompania.TabIndex = 110
    Me.cboCompania.TabStop = False
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(634, 8)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(42, 16)
    Me.KryptonLabel6.TabIndex = 112
    Me.KryptonLabel6.Text = "Planta"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Planta"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(339, 8)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(50, 16)
    Me.KryptonLabel7.TabIndex = 113
    Me.KryptonLabel7.Text = "División"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "División"
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(1, 8)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(62, 16)
    Me.KryptonLabel8.TabIndex = 111
    Me.KryptonLabel8.Text = "Compañía"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Compañía"
    '
    'ctbOrigenCon2
    '
    Me.ctbOrigenCon2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.ctbOrigenCon2.Codigo = ""
    Me.ctbOrigenCon2.ControlHeight = 23
    Me.ctbOrigenCon2.ControlImage = True
    Me.ctbOrigenCon2.ControlReadOnly = False
    Me.ctbOrigenCon2.Descripcion = ""
    Me.ctbOrigenCon2.DisplayColumnVisible = True
    Me.ctbOrigenCon2.DisplayMember = ""
    Me.ctbOrigenCon2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
    Me.ctbOrigenCon2.KeyColumnWidth = 100
    Me.ctbOrigenCon2.KeyField = ""
    Me.ctbOrigenCon2.KeySearch = True
    Me.ctbOrigenCon2.Location = New System.Drawing.Point(691, 33)
    Me.ctbOrigenCon2.Name = "ctbOrigenCon2"
    Me.ctbOrigenCon2.Size = New System.Drawing.Size(236, 23)
    Me.ctbOrigenCon2.TabIndex = 107
    Me.ctbOrigenCon2.Tag = ""
    Me.ctbOrigenCon2.TextBackColor = System.Drawing.Color.Empty
    Me.ctbOrigenCon2.TextForeColor = System.Drawing.Color.Empty
    Me.ctbOrigenCon2.ValueColumnVisible = True
    Me.ctbOrigenCon2.ValueColumnWidth = 600
    Me.ctbOrigenCon2.ValueField = ""
    Me.ctbOrigenCon2.ValueMember = ""
    Me.ctbOrigenCon2.ValueSearch = True
    '
    'ctbOrigenCon1
    '
    Me.ctbOrigenCon1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.ctbOrigenCon1.Codigo = ""
    Me.ctbOrigenCon1.ControlHeight = 23
    Me.ctbOrigenCon1.ControlImage = True
    Me.ctbOrigenCon1.ControlReadOnly = False
    Me.ctbOrigenCon1.Descripcion = ""
    Me.ctbOrigenCon1.DisplayColumnVisible = True
    Me.ctbOrigenCon1.DisplayMember = ""
    Me.ctbOrigenCon1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
    Me.ctbOrigenCon1.KeyColumnWidth = 100
    Me.ctbOrigenCon1.KeyField = ""
    Me.ctbOrigenCon1.KeySearch = True
    Me.ctbOrigenCon1.Location = New System.Drawing.Point(391, 33)
    Me.ctbOrigenCon1.Name = "ctbOrigenCon1"
    Me.ctbOrigenCon1.Size = New System.Drawing.Size(241, 23)
    Me.ctbOrigenCon1.TabIndex = 106
    Me.ctbOrigenCon1.Tag = ""
    Me.ctbOrigenCon1.TextBackColor = System.Drawing.Color.Empty
    Me.ctbOrigenCon1.TextForeColor = System.Drawing.Color.Empty
    Me.ctbOrigenCon1.ValueColumnVisible = True
    Me.ctbOrigenCon1.ValueColumnWidth = 600
    Me.ctbOrigenCon1.ValueField = ""
    Me.ctbOrigenCon1.ValueMember = ""
    Me.ctbOrigenCon1.ValueSearch = True
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(634, 36)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(52, 16)
    Me.KryptonLabel1.TabIndex = 108
    Me.KryptonLabel1.Text = "Destino:"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Destino:"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(339, 36)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(47, 16)
    Me.KryptonLabel3.TabIndex = 109
    Me.KryptonLabel3.Text = "Origen:"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Origen:"
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(64, 62)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaInicio.TabIndex = 5
    '
    'txtCliente
    '
    Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtCliente.BackColor = System.Drawing.Color.Transparent
    Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
    Me.txtCliente.Location = New System.Drawing.Point(64, 35)
    Me.txtCliente.Name = "txtCliente"
    Me.txtCliente.pAccesoPorUsuario = False
    Me.txtCliente.pRequerido = False
    Me.txtCliente.Size = New System.Drawing.Size(272, 19)
    Me.txtCliente.TabIndex = 3
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
    Me.KryptonLabel5.Location = New System.Drawing.Point(1, 36)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
    Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel5.TabIndex = 105
    Me.KryptonLabel5.Text = "Cliente"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Cliente"
    '
    'rbtCliente
    '
    Me.rbtCliente.Checked = True
    Me.rbtCliente.Location = New System.Drawing.Point(391, 64)
    Me.rbtCliente.Name = "rbtCliente"
    Me.rbtCliente.Size = New System.Drawing.Size(58, 16)
    Me.rbtCliente.TabIndex = 117
    Me.rbtCliente.Text = "Cliente"
    Me.rbtCliente.Values.ExtraText = ""
    Me.rbtCliente.Values.Image = Nothing
    Me.rbtCliente.Values.Text = "Cliente"
    '
    'rbtFecha
    '
    Me.rbtFecha.Location = New System.Drawing.Point(456, 64)
    Me.rbtFecha.Name = "rbtFecha"
    Me.rbtFecha.Size = New System.Drawing.Size(54, 16)
    Me.rbtFecha.TabIndex = 118
    Me.rbtFecha.Text = "Fecha"
    Me.rbtFecha.Values.ExtraText = ""
    Me.rbtFecha.Values.Image = Nothing
    Me.rbtFecha.Values.Text = "Fecha"
    '
    'frmConsultaUnidadesAtendidas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(941, 505)
    Me.Controls.Add(Me.panel)
    Me.MinimumSize = New System.Drawing.Size(900, 480)
    Me.Name = "frmConsultaUnidadesAtendidas"
    Me.Text = "Consulta Viajes Realizados"
    CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel.ResumeLayout(False)
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.Panel.ResumeLayout(False)
    Me.HeaderGroupTabs.Panel.PerformLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
    Me.HeaderGroupFiltro.Panel.PerformLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.ResumeLayout(False)
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
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents panel As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents ControlVisorLiquidacion As SOLMIN_ST.Control_Visor_Reporte
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
  Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents ctbOrigenCon2 As CodeTextBox.CodeTextBox
  Friend WithEvents ctbOrigenCon1 As CodeTextBox.CodeTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents cboDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents cboCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents rbtFecha As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbtCliente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
