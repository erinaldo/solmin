<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltroOperacion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiltroOperacion))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dtgDocumentos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAceptar_ = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar_ = New System.Windows.Forms.ToolStripButton()
        Me.btnMarcarItems = New System.Windows.Forms.ToolStripButton()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtGuiaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtNroOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboEstadoChk = New SOLMIN_ST.CheckComboBoxTest.CheckedComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboMedioTransporteFiltro = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboPlanta = New SOLMIN_ST.CheckComboBoxTest.CheckedComboBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ctlCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINCOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUITS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTTP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_O = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM_IMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCSOTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgDocumentos)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1122, 564)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgDocumentos
        '
        Me.dtgDocumentos.AllowUserToAddRows = False
        Me.dtgDocumentos.AllowUserToDeleteRows = False
        Me.dtgDocumentos.AllowUserToResizeRows = False
        Me.dtgDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSel, Me.NOPRCN, Me.FINCOP, Me.TCMPCL, Me.NGUITR, Me.NGUITS, Me.SESTTP, Me.NMRGIM_S, Me.NMRGIM_O, Me.NMRGIM_IMG, Me.NCSOTR, Me.Column1})
        Me.dtgDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDocumentos.Location = New System.Drawing.Point(0, 191)
        Me.dtgDocumentos.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgDocumentos.MultiSelect = False
        Me.dtgDocumentos.Name = "dtgDocumentos"
        Me.dtgDocumentos.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dtgDocumentos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDocumentos.Size = New System.Drawing.Size(1122, 373)
        Me.dtgDocumentos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgDocumentos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDocumentos.TabIndex = 7
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator3, Me.btnAceptar_, Me.ToolStripSeparator4, Me.btnBuscar_, Me.btnMarcarItems})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 164)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1122, 27)
        Me.ToolStrip2.TabIndex = 21
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnAceptar_
        '
        Me.btnAceptar_.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar_.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnAceptar_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar_.Name = "btnAceptar_"
        Me.btnAceptar_.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar_.Text = "Aceptar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'btnBuscar_
        '
        Me.btnBuscar_.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar_.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar_.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar_.Name = "btnBuscar_"
        Me.btnBuscar_.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar_.Text = "Buscar"
        '
        'btnMarcarItems
        '
        Me.btnMarcarItems.BackgroundImage = CType(resources.GetObject("btnMarcarItems.BackgroundImage"), System.Drawing.Image)
        Me.btnMarcarItems.CheckOnClick = True
        Me.btnMarcarItems.Image = CType(resources.GetObject("btnMarcarItems.Image"), System.Drawing.Image)
        Me.btnMarcarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarItems.Name = "btnMarcarItems"
        Me.btnMarcarItems.Size = New System.Drawing.Size(127, 24)
        Me.btnMarcarItems.Text = " &Marcar Todos"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel20)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtGuiaTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroOperacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboEstadoChk)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboMedioTransporteFiltro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ctlCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1122, 164)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(15, 122)
        Me.KryptonLabel20.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(48, 23)
        Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel20.TabIndex = 171
        Me.KryptonLabel20.Text = "Fecha"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(271, 118)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(111, 24)
        Me.dtpFechaFin.TabIndex = 7
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(124, 118)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(111, 24)
        Me.dtpFechaInicio.TabIndex = 6
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(240, 122)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(23, 23)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 170
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'txtGuiaTransporte
        '
        Me.txtGuiaTransporte.Location = New System.Drawing.Point(568, 82)
        Me.txtGuiaTransporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuiaTransporte.MaxLength = 12
        Me.txtGuiaTransporte.Name = "txtGuiaTransporte"
        Me.txtGuiaTransporte.Size = New System.Drawing.Size(196, 26)
        Me.txtGuiaTransporte.TabIndex = 5
        Me.txtGuiaTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Location = New System.Drawing.Point(124, 82)
        Me.txtNroOperacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.Size = New System.Drawing.Size(107, 26)
        Me.txtNroOperacion.TabIndex = 4
        Me.txtNroOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(15, 82)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(104, 26)
        Me.KryptonLabel6.TabIndex = 164
        Me.KryptonLabel6.Text = "N° Operación"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° Operación"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(435, 82)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(120, 26)
        Me.KryptonLabel7.TabIndex = 166
        Me.KryptonLabel7.Text = "Guía Transporte"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Guía Transporte"
        '
        'cboEstadoChk
        '
        Me.cboEstadoChk.CheckOnClick = True
        Me.cboEstadoChk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboEstadoChk.DropDownHeight = 1
        Me.cboEstadoChk.FormattingEnabled = True
        Me.cboEstadoChk.IntegralHeight = False
        Me.cboEstadoChk.Location = New System.Drawing.Point(124, 49)
        Me.cboEstadoChk.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstadoChk.Name = "cboEstadoChk"
        Me.cboEstadoChk.Size = New System.Drawing.Size(297, 23)
        Me.cboEstadoChk.TabIndex = 2
        Me.cboEstadoChk.ValueSeparator = ", "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 50)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(57, 26)
        Me.KryptonLabel2.TabIndex = 162
        Me.KryptonLabel2.Text = "Estado"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Estado"
        '
        'cboMedioTransporteFiltro
        '
        Me.cboMedioTransporteFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedioTransporteFiltro.FormattingEnabled = True
        Me.cboMedioTransporteFiltro.Location = New System.Drawing.Point(568, 49)
        Me.cboMedioTransporteFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMedioTransporteFiltro.Name = "cboMedioTransporteFiltro"
        Me.cboMedioTransporteFiltro.Size = New System.Drawing.Size(345, 24)
        Me.cboMedioTransporteFiltro.TabIndex = 3
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(435, 50)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(120, 23)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 160
        Me.KryptonLabel9.Text = "Medio Transporte"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Medio Transporte"
        '
        'cboPlanta
        '
        Me.cboPlanta.CheckOnClick = True
        Me.cboPlanta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboPlanta.DropDownHeight = 1
        Me.cboPlanta.FormattingEnabled = True
        Me.cboPlanta.IntegralHeight = False
        Me.cboPlanta.Location = New System.Drawing.Point(124, 14)
        Me.cboPlanta.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPlanta.Name = "cboPlanta"
        Me.cboPlanta.Size = New System.Drawing.Size(297, 23)
        Me.cboPlanta.TabIndex = 0
        Me.cboPlanta.ValueSeparator = ", "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 17)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 23)
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 158
        Me.KryptonLabel3.Text = "Planta"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Planta"
        '
        'ctlCliente
        '
        Me.ctlCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctlCliente.BackColor = System.Drawing.Color.Transparent
        Me.ctlCliente.CCMPN = "EZ"
        Me.ctlCliente.Location = New System.Drawing.Point(568, 14)
        Me.ctlCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.ctlCliente.Name = "ctlCliente"
        Me.ctlCliente.pAccesoPorUsuario = False
        Me.ctlCliente.pCDDRSP_CodClienteSAP = ""
        Me.ctlCliente.pRequerido = False
        Me.ctlCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.ctlCliente.pVisualizaNegocio = False
        Me.ctlCliente.Size = New System.Drawing.Size(347, 26)
        Me.ctlCliente.TabIndex = 1
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(435, 20)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(54, 23)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 157
        Me.KryptonLabel5.Text = "Cliente"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cliente"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FINCOP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Operación"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente Operación"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NGUITR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Guía Transportista"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'chkSel
        '
        Me.chkSel.HeaderText = "Sel."
        Me.chkSel.Name = "chkSel"
        Me.chkSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkSel.Width = 35
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.Width = 111
        '
        'FINCOP
        '
        Me.FINCOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FINCOP.DataPropertyName = "FINCOP"
        Me.FINCOP.HeaderText = "Fecha Operación"
        Me.FINCOP.Name = "FINCOP"
        Me.FINCOP.Width = 140
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Cliente Operación"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.Width = 148
        '
        'NGUITR
        '
        Me.NGUITR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUITR.DataPropertyName = "NGUITR"
        Me.NGUITR.HeaderText = "Id G. Transportista"
        Me.NGUITR.Name = "NGUITR"
        Me.NGUITR.Width = 148
        '
        'NGUITS
        '
        Me.NGUITS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUITS.DataPropertyName = "NGUITS"
        Me.NGUITS.HeaderText = "Guía Transportista"
        Me.NGUITS.Name = "NGUITS"
        Me.NGUITS.ReadOnly = True
        Me.NGUITS.Width = 148
        '
        'SESTTP
        '
        Me.SESTTP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTTP.DataPropertyName = "SESTTP"
        Me.SESTTP.HeaderText = "Área Origen"
        Me.SESTTP.Name = "SESTTP"
        Me.SESTTP.Width = 113
        '
        'NMRGIM_S
        '
        Me.NMRGIM_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMRGIM_S.DataPropertyName = "NMRGIM_S"
        Me.NMRGIM_S.HeaderText = "NMRGIM_S"
        Me.NMRGIM_S.Name = "NMRGIM_S"
        Me.NMRGIM_S.ReadOnly = True
        Me.NMRGIM_S.Visible = False
        Me.NMRGIM_S.Width = 116
        '
        'NMRGIM_O
        '
        Me.NMRGIM_O.DataPropertyName = "NMRGIM_O"
        Me.NMRGIM_O.HeaderText = "NMRGIM_O"
        Me.NMRGIM_O.Name = "NMRGIM_O"
        Me.NMRGIM_O.ReadOnly = True
        Me.NMRGIM_O.Visible = False
        '
        'NMRGIM_IMG
        '
        Me.NMRGIM_IMG.DataPropertyName = "NMRGIM_IMG"
        Me.NMRGIM_IMG.HeaderText = "NMRGIM_IMG"
        Me.NMRGIM_IMG.Name = "NMRGIM_IMG"
        Me.NMRGIM_IMG.ReadOnly = True
        Me.NMRGIM_IMG.Visible = False
        '
        'NCSOTR
        '
        Me.NCSOTR.DataPropertyName = "NCSOTR"
        Me.NCSOTR.HeaderText = "NCSOTR"
        Me.NCSOTR.Name = "NCSOTR"
        Me.NCSOTR.ReadOnly = True
        Me.NCSOTR.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmFiltroOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 564)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroOperacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtro de Operacion"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGuiaTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstadoChk As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboMedioTransporteFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboPlanta As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctlCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgDocumentos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar_ As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuscar_ As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMarcarItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINCOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUITS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTTP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_O As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM_IMG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCSOTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
