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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnExportarExcel = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnProcesarReporte = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ctlContratista = New Ransa.Utilitario.ucAyuda
        Me.ctlPasajero = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProceso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.pbxProceso = New System.Windows.Forms.PictureBox
        Me.cboMedioTransporteFiltro = New System.Windows.Forms.ComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ctlCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwProceso = New System.ComponentModel.BackgroundWorker
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.APENOM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHPSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRAPSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderGroupFiltro.Panel.SuspendLayout()
        Me.HeaderGroupFiltro.SuspendLayout()
        CType(Me.pbxProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gwdDatos)
        Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1028, 614)
        Me.KryptonPanel.TabIndex = 0
        '
        'gwdDatos
        '
        Me.gwdDatos.AccessibleDescription = ""
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToResizeColumns = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.APENOM, Me.RUTA, Me.FCHPSA, Me.HRAPSA, Me.TNMMDT, Me.TCMTRT, Me.NGUITR, Me.TPRVCL, Me.TCMPCL})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 130)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersVisible = False
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowTemplate.Height = 16
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1028, 484)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 7
        '
        'HeaderGroupFiltro
        '
        Me.HeaderGroupFiltro.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnExportarExcel, Me.btnProcesarReporte})
        Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderGroupFiltro.HeaderVisiblePrimary = False
        Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
        '
        'HeaderGroupFiltro.Panel
        '
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctlContratista)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctlPasajero)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblProceso)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.pbxProceso)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboMedioTransporteFiltro)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel9)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbCompania)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctlCliente)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
        Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1028, 130)
        Me.HeaderGroupFiltro.TabIndex = 2
        Me.HeaderGroupFiltro.Text = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
        Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
        Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
        Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
        Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.ExtraText = ""
        Me.btnExportarExcel.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
        Me.btnExportarExcel.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnExportarExcel.Text = "Exportar Excel"
        Me.btnExportarExcel.ToolTipImage = Nothing
        Me.btnExportarExcel.UniqueName = "9AD8358DE4664A0B9AD8358DE4664A0B"
        '
        'btnProcesarReporte
        '
        Me.btnProcesarReporte.ExtraText = ""
        Me.btnProcesarReporte.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnProcesarReporte.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnProcesarReporte.Text = "Buscar"
        Me.btnProcesarReporte.ToolTipImage = Nothing
        Me.btnProcesarReporte.UniqueName = "CBB1A0C83247479DCBB1A0C83247479D"
        '
        'ctlContratista
        '
        Me.ctlContratista.BackColor = System.Drawing.Color.Transparent
        Me.ctlContratista.DataSource = Nothing
        Me.ctlContratista.DispleyMember = ""
        Me.ctlContratista.ListColumnas = Nothing
        Me.ctlContratista.Location = New System.Drawing.Point(450, 40)
        Me.ctlContratista.Name = "ctlContratista"
        Me.ctlContratista.Obligatorio = False
        Me.ctlContratista.Size = New System.Drawing.Size(251, 21)
        Me.ctlContratista.TabIndex = 143
        Me.ctlContratista.ValueMember = ""
        '
        'ctlPasajero
        '
        Me.ctlPasajero.BackColor = System.Drawing.Color.Transparent
        Me.ctlPasajero.DataSource = Nothing
        Me.ctlPasajero.DispleyMember = ""
        Me.ctlPasajero.ListColumnas = Nothing
        Me.ctlPasajero.Location = New System.Drawing.Point(85, 70)
        Me.ctlPasajero.Name = "ctlPasajero"
        Me.ctlPasajero.Obligatorio = False
        Me.ctlPasajero.Size = New System.Drawing.Size(238, 21)
        Me.ctlPasajero.TabIndex = 142
        Me.ctlPasajero.ValueMember = ""
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(10, 71)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel1.TabIndex = 141
        Me.KryptonLabel1.Text = "Pasajero"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Pasajero"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(343, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel3.TabIndex = 139
        Me.KryptonLabel3.Text = "Contratista"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Contratista"
        '
        'lblProceso
        '
        Me.lblProceso.Location = New System.Drawing.Point(647, 71)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(18, 19)
        Me.lblProceso.TabIndex = 121
        Me.lblProceso.Text = "..."
        Me.lblProceso.Values.ExtraText = ""
        Me.lblProceso.Values.Image = Nothing
        Me.lblProceso.Values.Text = "..."
        Me.lblProceso.Visible = False
        '
        'pbxProceso
        '
        Me.pbxProceso.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbxProceso.Image = Global.SOLMIN_ST.My.Resources.Resources.mozilla_blu
        Me.pbxProceso.Location = New System.Drawing.Point(615, 68)
        Me.pbxProceso.Name = "pbxProceso"
        Me.pbxProceso.Size = New System.Drawing.Size(29, 24)
        Me.pbxProceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxProceso.TabIndex = 120
        Me.pbxProceso.TabStop = False
        Me.pbxProceso.Visible = False
        '
        'cboMedioTransporteFiltro
        '
        Me.cboMedioTransporteFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedioTransporteFiltro.FormattingEnabled = True
        Me.cboMedioTransporteFiltro.Location = New System.Drawing.Point(450, 70)
        Me.cboMedioTransporteFiltro.Name = "cboMedioTransporteFiltro"
        Me.cboMedioTransporteFiltro.Size = New System.Drawing.Size(155, 21)
        Me.cboMedioTransporteFiltro.TabIndex = 138
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(343, 72)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(98, 17)
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 137
        Me.KryptonLabel9.Text = "Medio Transporte"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Medio Transporte"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(85, 6)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(238, 23)
        Me.cmbCompania.TabIndex = 134
        Me.cmbCompania.Usuario = ""
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(709, 42)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(40, 17)
        Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel20.TabIndex = 105
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
        Me.dtpFechaFin.Location = New System.Drawing.Point(871, 40)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 7
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(760, 40)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 6
        '
        'ctlCliente
        '
        Me.ctlCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctlCliente.BackColor = System.Drawing.Color.Transparent
        Me.ctlCliente.CCMPN = "EZ"
        Me.ctlCliente.Location = New System.Drawing.Point(85, 40)
        Me.ctlCliente.Name = "ctlCliente"
        Me.ctlCliente.pAccesoPorUsuario = False
        Me.ctlCliente.pRequerido = False
        Me.ctlCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.ctlCliente.Size = New System.Drawing.Size(238, 21)
        Me.ctlCliente.TabIndex = 4
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(10, 9)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(60, 17)
        Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel19.TabIndex = 103
        Me.KryptonLabel19.Text = "Compañía"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Compañía"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(10, 42)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 105
        Me.KryptonLabel5.Text = "Cliente"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cliente"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(847, 42)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 105
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'bgwProceso
        '
        Me.bgwProceso.WorkerReportsProgress = True
        Me.bgwProceso.WorkerSupportsCancellation = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "APENOM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pasajero"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUTA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Contratista"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMPCL"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HRAPSA"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 95
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TNMMDT"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Salida"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 127
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Hora Salida"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NGUITR"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn7.HeaderText = "Medio Transporte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 134
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TPRVCL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Transportista"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Guía de Transporte"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'APENOM
        '
        Me.APENOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.APENOM.DataPropertyName = "APENOM"
        Me.APENOM.HeaderText = "Pasajero"
        Me.APENOM.Name = "APENOM"
        Me.APENOM.ReadOnly = True
        Me.APENOM.Width = 200
        '
        'RUTA
        '
        Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RUTA.DataPropertyName = "RUTA"
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.ReadOnly = True
        Me.RUTA.Width = 200
        '
        'FCHPSA
        '
        Me.FCHPSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FCHPSA.DataPropertyName = "FCHPSA"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FCHPSA.DefaultCellStyle = DataGridViewCellStyle21
        Me.FCHPSA.HeaderText = "Fecha Salida"
        Me.FCHPSA.Name = "FCHPSA"
        Me.FCHPSA.ReadOnly = True
        '
        'HRAPSA
        '
        Me.HRAPSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HRAPSA.DataPropertyName = "HRAPSA"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HRAPSA.DefaultCellStyle = DataGridViewCellStyle22
        Me.HRAPSA.HeaderText = "Hora Salida"
        Me.HRAPSA.Name = "HRAPSA"
        Me.HRAPSA.ReadOnly = True
        Me.HRAPSA.Width = 95
        '
        'TNMMDT
        '
        Me.TNMMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMMDT.DataPropertyName = "TNMMDT"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TNMMDT.DefaultCellStyle = DataGridViewCellStyle23
        Me.TNMMDT.HeaderText = "Medio Transporte"
        Me.TNMMDT.Name = "TNMMDT"
        Me.TNMMDT.ReadOnly = True
        Me.TNMMDT.Width = 127
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 200
        '
        'NGUITR
        '
        Me.NGUITR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUITR.DataPropertyName = "NGUITR"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NGUITR.DefaultCellStyle = DataGridViewCellStyle24
        Me.NGUITR.HeaderText = "Guía de Transporte"
        Me.NGUITR.Name = "NGUITR"
        Me.NGUITR.ReadOnly = True
        Me.NGUITR.Width = 134
        '
        'TPRVCL
        '
        Me.TPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TPRVCL.DataPropertyName = "TPRVCL"
        Me.TPRVCL.HeaderText = "Contratista"
        Me.TPRVCL.Name = "TPRVCL"
        Me.TPRVCL.ReadOnly = True
        Me.TPRVCL.Width = 200
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Cliente"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        Me.TCMPCL.Width = 200
        '
        'frmConsultaPasajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 614)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConsultaPasajero"
        Me.Text = "Consulta Pasajero"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
        Me.HeaderGroupFiltro.Panel.PerformLayout()
        CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderGroupFiltro.ResumeLayout(False)
        CType(Me.pbxProceso, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnExportarExcel As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnProcesarReporte As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents lblProceso As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents pbxProceso As System.Windows.Forms.PictureBox
  Friend WithEvents cboMedioTransporteFiltro As System.Windows.Forms.ComboBox
  Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
  Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents ctlCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents ctlPasajero As Ransa.Utilitario.ucAyuda
  Friend WithEvents ctlContratista As Ransa.Utilitario.ucAyuda
  Friend WithEvents bgwProceso As System.ComponentModel.BackgroundWorker
  Friend WithEvents APENOM As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FCHPSA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HRAPSA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
