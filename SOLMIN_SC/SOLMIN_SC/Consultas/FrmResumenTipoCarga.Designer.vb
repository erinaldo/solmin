<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResumenTipoCarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResumenTipoCarga))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabResultado = New System.Windows.Forms.TabControl
        Me.TabDatos = New System.Windows.Forms.TabPage
        Me.dtgDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNNORSCI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSPUERTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSPAIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNFLETE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNVOLUMEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNPESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTRANSPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSFORWARDER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSMERCADERIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTIPO_CARGA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSFECHA_ORDEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboTipoOperacion = New System.Windows.Forms.ComboBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabResultado.SuspendLayout()
        Me.TabDatos.SuspendLayout()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabResultado)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(954, 537)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabResultado
        '
        Me.TabResultado.Controls.Add(Me.TabDatos)
        Me.TabResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabResultado.Location = New System.Drawing.Point(0, 102)
        Me.TabResultado.Name = "TabResultado"
        Me.TabResultado.SelectedIndex = 0
        Me.TabResultado.Size = New System.Drawing.Size(954, 435)
        Me.TabResultado.TabIndex = 15
        '
        'TabDatos
        '
        Me.TabDatos.Controls.Add(Me.dtgDatos)
        Me.TabDatos.Location = New System.Drawing.Point(4, 22)
        Me.TabDatos.Name = "TabDatos"
        Me.TabDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatos.Size = New System.Drawing.Size(946, 409)
        Me.TabDatos.TabIndex = 2
        Me.TabDatos.Text = "Datos"
        Me.TabDatos.UseVisualStyleBackColor = True
        '
        'dtgDatos
        '
        Me.dtgDatos.AllowUserToAddRows = False
        Me.dtgDatos.AllowUserToDeleteRows = False
        Me.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNORSCI, Me.PSPUERTO, Me.PSPAIS, Me.PNFLETE, Me.PNVOLUMEN, Me.PNPESO, Me.PSTRANSPORTE, Me.PSFORWARDER, Me.PSMERCADERIA, Me.PSTIPO_CARGA, Me.PSFECHA_ORDEN})
        Me.dtgDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgDatos.Location = New System.Drawing.Point(3, 3)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.ReadOnly = True
        Me.dtgDatos.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtgDatos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgDatos.Size = New System.Drawing.Size(940, 403)
        Me.dtgDatos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDatos.TabIndex = 70
        '
        'PNNORSCI
        '
        Me.PNNORSCI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNORSCI.DataPropertyName = "PNNORSCI"
        Me.PNNORSCI.HeaderText = "Embarque"
        Me.PNNORSCI.Name = "PNNORSCI"
        Me.PNNORSCI.ReadOnly = True
        Me.PNNORSCI.Width = 88
        '
        'PSPUERTO
        '
        Me.PSPUERTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSPUERTO.DataPropertyName = "PSPUERTO"
        Me.PSPUERTO.HeaderText = "Puerto"
        Me.PSPUERTO.Name = "PSPUERTO"
        Me.PSPUERTO.ReadOnly = True
        Me.PSPUERTO.Width = 70
        '
        'PSPAIS
        '
        Me.PSPAIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSPAIS.DataPropertyName = "PSPAIS"
        Me.PSPAIS.HeaderText = "País"
        Me.PSPAIS.Name = "PSPAIS"
        Me.PSPAIS.ReadOnly = True
        Me.PSPAIS.Width = 56
        '
        'PNFLETE
        '
        Me.PNFLETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNFLETE.DataPropertyName = "PNFLETE"
        Me.PNFLETE.HeaderText = "Flete"
        Me.PNFLETE.Name = "PNFLETE"
        Me.PNFLETE.ReadOnly = True
        Me.PNFLETE.Width = 61
        '
        'PNVOLUMEN
        '
        Me.PNVOLUMEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNVOLUMEN.DataPropertyName = "PNVOLUMEN"
        Me.PNVOLUMEN.HeaderText = "Volumen"
        Me.PNVOLUMEN.Name = "PNVOLUMEN"
        Me.PNVOLUMEN.ReadOnly = True
        Me.PNVOLUMEN.Width = 82
        '
        'PNPESO
        '
        Me.PNPESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNPESO.DataPropertyName = "PNPESO"
        Me.PNPESO.HeaderText = "Peso"
        Me.PNPESO.Name = "PNPESO"
        Me.PNPESO.ReadOnly = True
        Me.PNPESO.Width = 60
        '
        'PSTRANSPORTE
        '
        Me.PSTRANSPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTRANSPORTE.DataPropertyName = "PSTRANSPORTE"
        Me.PSTRANSPORTE.HeaderText = "Transporte"
        Me.PSTRANSPORTE.Name = "PSTRANSPORTE"
        Me.PSTRANSPORTE.ReadOnly = True
        Me.PSTRANSPORTE.Width = 91
        '
        'PSFORWARDER
        '
        Me.PSFORWARDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSFORWARDER.DataPropertyName = "PSFORWARDER"
        Me.PSFORWARDER.HeaderText = "Forwarder"
        Me.PSFORWARDER.Name = "PSFORWARDER"
        Me.PSFORWARDER.ReadOnly = True
        Me.PSFORWARDER.Width = 89
        '
        'PSMERCADERIA
        '
        Me.PSMERCADERIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSMERCADERIA.DataPropertyName = "PSMERCADERIA"
        Me.PSMERCADERIA.HeaderText = "Mercadería"
        Me.PSMERCADERIA.Name = "PSMERCADERIA"
        Me.PSMERCADERIA.ReadOnly = True
        Me.PSMERCADERIA.Width = 93
        '
        'PSTIPO_CARGA
        '
        Me.PSTIPO_CARGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTIPO_CARGA.DataPropertyName = "PSTIPO_CARGA"
        Me.PSTIPO_CARGA.HeaderText = "Tipo Carga"
        Me.PSTIPO_CARGA.Name = "PSTIPO_CARGA"
        Me.PSTIPO_CARGA.ReadOnly = True
        Me.PSTIPO_CARGA.Width = 91
        '
        'PSFECHA_ORDEN
        '
        Me.PSFECHA_ORDEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSFECHA_ORDEN.DataPropertyName = "PSFECHA_ORDEN"
        Me.PSFECHA_ORDEN.HeaderText = "Fecha Orden"
        Me.PSFECHA_ORDEN.Name = "PSFECHA_ORDEN"
        Me.PSFECHA_ORDEN.ReadOnly = True
        Me.PSFECHA_ORDEN.Width = 102
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator1, Me.btnExportar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 77)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboTipoOperacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecIni)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(954, 77)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 13
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(454, 33)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel1.TabIndex = 83
        Me.KryptonLabel1.Text = "Inicio:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Inicio:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(364, 33)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(86, 19)
        Me.KryptonLabel3.TabIndex = 82
        Me.KryptonLabel3.Text = "Fecha Apertura"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha Apertura"
        '
        'cboTipoOperacion
        '
        Me.cboTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoOperacion.FormattingEnabled = True
        Me.cboTipoOperacion.Location = New System.Drawing.Point(459, 6)
        Me.cboTipoOperacion.Name = "cboTipoOperacion"
        Me.cboTipoOperacion.Size = New System.Drawing.Size(138, 21)
        Me.cboTipoOperacion.TabIndex = 81
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(364, 6)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel5.TabIndex = 80
        Me.KryptonLabel5.Text = "Tipo :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Tipo :"
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(82, 31)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(276, 21)
        Me.cmbCliente.TabIndex = 71
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(9, 6)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel24.TabIndex = 52
        Me.KryptonLabel24.Text = "Compañía:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Compañía:"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Habilitar = True
        Me.cmbCompania.Location = New System.Drawing.Point(82, 3)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(276, 23)
        Me.cmbCompania.TabIndex = 51
        Me.cmbCompania.Usuario = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(598, 33)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(27, 19)
        Me.KryptonLabel2.TabIndex = 49
        Me.KryptonLabel2.Text = "Fin:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fin:"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(9, 33)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 19)
        Me.lblCliente.TabIndex = 45
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente:"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecFin.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpFecFin.CustomFormat = "MM/yyyy"
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(631, 32)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecFin.TabIndex = 13
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecIni.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpFecIni.CustomFormat = "MM/yyyy"
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(499, 32)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecIni.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PNNORSCI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Embarque"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSPUERTO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Puerto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSPAIS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "País"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PNFLETE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Flete"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PNVOLUMEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PNPESO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSTRANSPORTE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Transporte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PSFORWARDER"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Forwarder"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSMERCADERIA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSTIPO_CARGA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo Carga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PSFECHA_ORDEN"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha Orden"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton1.Text = "Enviar"
        '
        'FrmResumenTipoCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 537)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "FrmResumenTipoCarga"
        Me.Text = "Resumen Carga"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabResultado.ResumeLayout(False)
        Me.TabDatos.ResumeLayout(False)
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents TabResultado As System.Windows.Forms.TabControl
    Friend WithEvents TabDatos As System.Windows.Forms.TabPage
    Friend WithEvents dtgDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNORSCI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSPUERTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSPAIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNFLETE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNVOLUMEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNPESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTRANSPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSFORWARDER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSMERCADERIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTIPO_CARGA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PSFECHA_ORDEN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
