<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPasajero
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.dtgGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.SELECCIONAR = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Me.NPRGVJ = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FSLDRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.HSLDRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NMBPER = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NCRRRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NCRRIN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MenuBar_0 = New System.Windows.Forms.ToolStrip
    Me.btnSalir = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnProcesar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnBuscar = New System.Windows.Forms.ToolStripButton
    Me.panelFiltro = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.txtRuta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtFiltroProgramacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.dtpFechaFiltroFin = New System.Windows.Forms.DateTimePicker
    Me.lblGuia = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.KryptonLabel51 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblNombre = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.UcCliente_GuiaRemision = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.dtpFechaFiltroInicio = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.dtgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MenuBar_0.SuspendLayout()
    CType(Me.panelFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panelFiltro.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.dtgGuiaRemision)
    Me.KryptonPanel.Controls.Add(Me.MenuBar_0)
    Me.KryptonPanel.Controls.Add(Me.panelFiltro)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(667, 302)
    Me.KryptonPanel.TabIndex = 0
    '
    'dtgGuiaRemision
    '
    Me.dtgGuiaRemision.AllowUserToAddRows = False
    Me.dtgGuiaRemision.AllowUserToDeleteRows = False
    Me.dtgGuiaRemision.AllowUserToResizeColumns = False
    Me.dtgGuiaRemision.AllowUserToResizeRows = False
    Me.dtgGuiaRemision.ColumnHeadersHeight = 25
    Me.dtgGuiaRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.dtgGuiaRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SELECCIONAR, Me.NPRGVJ, Me.RUTA, Me.FSLDRT, Me.HSLDRT, Me.NMBPER, Me.NCRRRT, Me.NCRRIN})
    Me.dtgGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgGuiaRemision.Location = New System.Drawing.Point(0, 95)
    Me.dtgGuiaRemision.Name = "dtgGuiaRemision"
    Me.dtgGuiaRemision.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    Me.dtgGuiaRemision.RowHeadersVisible = False
    Me.dtgGuiaRemision.RowHeadersWidth = 20
    Me.dtgGuiaRemision.Size = New System.Drawing.Size(667, 207)
    Me.dtgGuiaRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgGuiaRemision.TabIndex = 3
    '
    'SELECCIONAR
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.NullValue = False
    Me.SELECCIONAR.DefaultCellStyle = DataGridViewCellStyle1
    Me.SELECCIONAR.FalseValue = Nothing
    Me.SELECCIONAR.HeaderText = ""
    Me.SELECCIONAR.IndeterminateValue = Nothing
    Me.SELECCIONAR.Name = "SELECCIONAR"
    Me.SELECCIONAR.TrueValue = Nothing
    Me.SELECCIONAR.Width = 25
    '
    'NPRGVJ
    '
    Me.NPRGVJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NPRGVJ.DataPropertyName = "NPRGVJ"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.NPRGVJ.DefaultCellStyle = DataGridViewCellStyle2
    Me.NPRGVJ.HeaderText = "N° Programación Viaje"
    Me.NPRGVJ.Name = "NPRGVJ"
    Me.NPRGVJ.Width = 150
    '
    'RUTA
    '
    Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.RUTA.DataPropertyName = "RUTA"
    Me.RUTA.HeaderText = "Ruta"
    Me.RUTA.Name = "RUTA"
    Me.RUTA.Visible = False
    Me.RUTA.Width = 200
    '
    'FSLDRT
    '
    Me.FSLDRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.FSLDRT.DataPropertyName = "FSLDRT_S"
    Me.FSLDRT.HeaderText = "Fecha Viaje"
    Me.FSLDRT.Name = "FSLDRT"
    Me.FSLDRT.Width = 94
    '
    'HSLDRT
    '
    Me.HSLDRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.HSLDRT.DataPropertyName = "HSLDRT_S"
    Me.HSLDRT.HeaderText = "Hora Viaje"
    Me.HSLDRT.Name = "HSLDRT"
    Me.HSLDRT.Width = 89
    '
    'NMBPER
    '
    Me.NMBPER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.NMBPER.DataPropertyName = "NMBPER"
    Me.NMBPER.HeaderText = "Pasajero"
    Me.NMBPER.Name = "NMBPER"
    Me.NMBPER.ReadOnly = True
    '
    'NCRRRT
    '
    Me.NCRRRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NCRRRT.DataPropertyName = "NCRRRT"
    Me.NCRRRT.HeaderText = "Correlativo Ruta"
    Me.NCRRRT.Name = "NCRRRT"
    Me.NCRRRT.ReadOnly = True
    Me.NCRRRT.Visible = False
    Me.NCRRRT.Width = 119
    '
    'NCRRIN
    '
    Me.NCRRIN.DataPropertyName = "NCRRIN"
    Me.NCRRIN.HeaderText = "Correlativo Ingreso"
    Me.NCRRIN.Name = "NCRRIN"
    Me.NCRRIN.Visible = False
    '
    'MenuBar_0
    '
    Me.MenuBar_0.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar_0.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.ToolStripSeparator1, Me.btnProcesar, Me.ToolStripSeparator2, Me.btnBuscar})
    Me.MenuBar_0.Location = New System.Drawing.Point(0, 70)
    Me.MenuBar_0.Name = "MenuBar_0"
    Me.MenuBar_0.Size = New System.Drawing.Size(667, 25)
    Me.MenuBar_0.TabIndex = 9
    Me.MenuBar_0.Text = "ToolStrip1"
    '
    'btnSalir
    '
    Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSalir.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
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
    'btnProcesar
    '
    Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnProcesar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnProcesar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
    Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesar.Name = "btnProcesar"
    Me.btnProcesar.Size = New System.Drawing.Size(77, 22)
    Me.btnProcesar.Text = "Procesar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnBuscar
    '
    Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.search
    Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
    Me.btnBuscar.Text = "Buscar"
    '
    'panelFiltro
    '
    Me.panelFiltro.Controls.Add(Me.txtRuta)
    Me.panelFiltro.Controls.Add(Me.KryptonLabel3)
    Me.panelFiltro.Controls.Add(Me.txtFiltroProgramacion)
    Me.panelFiltro.Controls.Add(Me.dtpFechaFiltroFin)
    Me.panelFiltro.Controls.Add(Me.lblGuia)
    Me.panelFiltro.Controls.Add(Me.KryptonLabel51)
    Me.panelFiltro.Controls.Add(Me.lblNombre)
    Me.panelFiltro.Controls.Add(Me.UcCliente_GuiaRemision)
    Me.panelFiltro.Controls.Add(Me.dtpFechaFiltroInicio)
    Me.panelFiltro.Controls.Add(Me.KryptonLabel1)
    Me.panelFiltro.Controls.Add(Me.KryptonLabel2)
    Me.panelFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.panelFiltro.Location = New System.Drawing.Point(0, 0)
    Me.panelFiltro.Name = "panelFiltro"
    Me.panelFiltro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
    Me.panelFiltro.Size = New System.Drawing.Size(667, 70)
    Me.panelFiltro.StateCommon.Color1 = System.Drawing.Color.White
    Me.panelFiltro.TabIndex = 2
    '
    'txtRuta
    '
    Me.txtRuta.Enabled = False
    Me.txtRuta.Location = New System.Drawing.Point(75, 40)
    Me.txtRuta.Name = "txtRuta"
    Me.txtRuta.Size = New System.Drawing.Size(310, 21)
    Me.txtRuta.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtRuta.StateDisabled.Border.Color1 = System.Drawing.Color.Blue
    Me.txtRuta.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtRuta.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
    Me.txtRuta.StateDisabled.Content.Color1 = System.Drawing.Color.Black
    Me.txtRuta.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtRuta.TabIndex = 12
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(10, 40)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(33, 19)
    Me.KryptonLabel3.TabIndex = 9
    Me.KryptonLabel3.Text = "Ruta"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Ruta"
    '
    'txtFiltroProgramacion
    '
    Me.txtFiltroProgramacion.Enabled = False
    Me.txtFiltroProgramacion.Location = New System.Drawing.Point(560, 39)
    Me.txtFiltroProgramacion.MaxLength = 15
    Me.txtFiltroProgramacion.Name = "txtFiltroProgramacion"
    Me.txtFiltroProgramacion.Size = New System.Drawing.Size(88, 21)
    Me.txtFiltroProgramacion.TabIndex = 5
    Me.txtFiltroProgramacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtFiltroProgramacion.Visible = False
    '
    'dtpFechaFiltroFin
    '
    Me.dtpFechaFiltroFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFiltroFin.Location = New System.Drawing.Point(560, 8)
    Me.dtpFechaFiltroFin.Name = "dtpFechaFiltroFin"
    Me.dtpFechaFiltroFin.Size = New System.Drawing.Size(88, 20)
    Me.dtpFechaFiltroFin.TabIndex = 6
    '
    'lblGuia
    '
    Me.lblGuia.Checked = False
    Me.lblGuia.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.lblGuia.Location = New System.Drawing.Point(430, 40)
    Me.lblGuia.Name = "lblGuia"
    Me.lblGuia.Size = New System.Drawing.Size(109, 19)
    Me.lblGuia.TabIndex = 4
    Me.lblGuia.Text = "N° Programación"
    Me.lblGuia.Values.ExtraText = ""
    Me.lblGuia.Values.Image = Nothing
    Me.lblGuia.Values.Text = "N° Programación"
    '
    'KryptonLabel51
    '
    Me.KryptonLabel51.Location = New System.Drawing.Point(407, 9)
    Me.KryptonLabel51.Name = "KryptonLabel51"
    Me.KryptonLabel51.Size = New System.Drawing.Size(39, 19)
    Me.KryptonLabel51.TabIndex = 2
    Me.KryptonLabel51.Text = "Fecha"
    Me.KryptonLabel51.Values.ExtraText = ""
    Me.KryptonLabel51.Values.Image = Nothing
    Me.KryptonLabel51.Values.Text = "Fecha"
    '
    'lblNombre
    '
    Me.lblNombre.Location = New System.Drawing.Point(10, 9)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(45, 19)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "Cliente"
    Me.lblNombre.Values.ExtraText = ""
    Me.lblNombre.Values.Image = Nothing
    Me.lblNombre.Values.Text = "Cliente"
    '
    'UcCliente_GuiaRemision
    '
    Me.UcCliente_GuiaRemision.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.UcCliente_GuiaRemision.BackColor = System.Drawing.Color.Transparent
    Me.UcCliente_GuiaRemision.CCMPN = "EZ"
    Me.UcCliente_GuiaRemision.Location = New System.Drawing.Point(75, 8)
    Me.UcCliente_GuiaRemision.Name = "UcCliente_GuiaRemision"
    Me.UcCliente_GuiaRemision.pAccesoPorUsuario = False
    Me.UcCliente_GuiaRemision.pRequerido = False
    Me.UcCliente_GuiaRemision.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.UcCliente_GuiaRemision.Size = New System.Drawing.Size(310, 21)
    Me.UcCliente_GuiaRemision.TabIndex = 1
    '
    'dtpFechaFiltroInicio
    '
    Me.dtpFechaFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFiltroInicio.Location = New System.Drawing.Point(451, 8)
    Me.dtpFechaFiltroInicio.Name = "dtpFechaFiltroInicio"
    Me.dtpFechaFiltroInicio.Size = New System.Drawing.Size(88, 20)
    Me.dtpFechaFiltroInicio.TabIndex = 3
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(538, 9)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(20, 19)
    Me.KryptonLabel1.TabIndex = 7
    Me.KryptonLabel1.Text = "Al"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Al"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(540, 40)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(18, 19)
    Me.KryptonLabel2.TabIndex = 8
    Me.KryptonLabel2.Text = " - "
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = " - "
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NPRGVJ"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridViewTextBoxColumn1.HeaderText = "N° Programación Viaje"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUTA"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Ruta"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.Visible = False
    Me.DataGridViewTextBoxColumn2.Width = 200
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "FSLDRT_S"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Viaje"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "HSLDRT_S"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Hora Viaje"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "NMBPER"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Pasajero"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "NCRRRT"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Correlativo Ruta"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    Me.DataGridViewTextBoxColumn6.Visible = False
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "NCRRIN"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Correlativo Ingreso"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.Visible = False
    '
    'frmConsultaPasajero
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(667, 302)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmConsultaPasajero"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Consulta Pasajero"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.dtgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MenuBar_0.ResumeLayout(False)
    Me.MenuBar_0.PerformLayout()
    CType(Me.panelFiltro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panelFiltro.ResumeLayout(False)
    Me.panelFiltro.PerformLayout()
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
  Friend WithEvents panelFiltro As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents lblGuia As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents KryptonLabel51 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblNombre As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents UcCliente_GuiaRemision As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents txtFiltroProgramacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents dtpFechaFiltroInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtgGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents dtpFechaFiltroFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents MenuBar_0 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents SELECCIONAR As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
  Friend WithEvents NPRGVJ As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FSLDRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HSLDRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NMBPER As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCRRRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCRRIN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtRuta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
