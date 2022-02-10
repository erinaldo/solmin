<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacionesxProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperacionesxProveedor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdOperacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtTipoRecurso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.ckbFechaOperacion = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFechaCierre = New System.Windows.Forms.DateTimePicker
        Me.TxtObservacionCierreAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.TxtUsuarioCerrarAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox4 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCliente_TxtF011 = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.chkSel = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINCOP_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FATNSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTOP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.gwdOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.gwdOperacion)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(998, 401)
        Me.KryptonPanel.TabIndex = 0
        '
        'gwdOperacion
        '
        Me.gwdOperacion.AllowUserToAddRows = False
        Me.gwdOperacion.AllowUserToDeleteRows = False
        Me.gwdOperacion.AllowUserToOrderColumns = True
        Me.gwdOperacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdOperacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdOperacion.ColumnHeadersHeight = 30
        Me.gwdOperacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdOperacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSel, Me.NRUCTR, Me.TCMTRT, Me.NOPRCN, Me.FINCOP_S, Me.FATNSR, Me.NORSRT, Me.CCLNT, Me.CCLNT_S, Me.RUTA, Me.NPLCUN, Me.NPLCAC, Me.CBRCNT, Me.CBRCND, Me.SESTOP, Me.Column1})
        Me.gwdOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdOperacion.Location = New System.Drawing.Point(0, 186)
        Me.gwdOperacion.MultiSelect = False
        Me.gwdOperacion.Name = "gwdOperacion"
        Me.gwdOperacion.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gwdOperacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdOperacion.Size = New System.Drawing.Size(998, 215)
        Me.gwdOperacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdOperacion.TabIndex = 6
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnBuscar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Panel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaCierre)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.TxtObservacionCierreAlquiler)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.TxtUsuarioCerrarAlquiler)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(998, 186)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "27D223D3957F43C827D223D3957F43C8"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "ECB84A76B8C746EFECB84A76B8C746EF"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.txtTipoRecurso)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.txtPlaca)
        Me.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.Panel1.Controls.Add(Me.dtpFechaInicio)
        Me.Panel1.Controls.Add(Me.dtpFechaFin)
        Me.Panel1.Controls.Add(Me.ckbFechaOperacion)
        Me.Panel1.Controls.Add(Me.KryptonLabel18)
        Me.Panel1.Controls.Add(Me.txtClienteFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(996, 54)
        Me.Panel1.TabIndex = 0
        '
        'txtTipoRecurso
        '
        Me.txtTipoRecurso.Enabled = False
        Me.txtTipoRecurso.Location = New System.Drawing.Point(367, 16)
        Me.txtTipoRecurso.MaxLength = 15
        Me.txtTipoRecurso.Name = "txtTipoRecurso"
        Me.txtTipoRecurso.Size = New System.Drawing.Size(88, 22)
        Me.txtTipoRecurso.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(318, 18)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Tipo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo"
        '
        'txtPlaca
        '
        Me.txtPlaca.Enabled = False
        Me.txtPlaca.Location = New System.Drawing.Point(506, 16)
        Me.txtPlaca.MaxLength = 15
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(126, 22)
        Me.txtPlaca.TabIndex = 5
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel6.Location = New System.Drawing.Point(461, 18)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Placa"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Placa"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(716, 17)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.dtpFechaInicio.TabIndex = 7
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(826, 16)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 21)
        Me.dtpFechaFin.TabIndex = 8
        '
        'ckbFechaOperacion
        '
        Me.ckbFechaOperacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbFechaOperacion.Location = New System.Drawing.Point(652, 18)
        Me.ckbFechaOperacion.Name = "ckbFechaOperacion"
        Me.ckbFechaOperacion.Size = New System.Drawing.Size(58, 20)
        Me.ckbFechaOperacion.TabIndex = 6
        Me.ckbFechaOperacion.Text = "Fecha:"
        Me.ckbFechaOperacion.Values.ExtraText = ""
        Me.ckbFechaOperacion.Values.Image = Nothing
        Me.ckbFechaOperacion.Values.Text = "Fecha:"
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(11, 18)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel18.TabIndex = 0
        Me.KryptonLabel18.Text = "Cliente "
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Cliente "
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Location = New System.Drawing.Point(100, 16)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.Size = New System.Drawing.Size(212, 22)
        Me.txtClienteFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 2)
        Me.Label1.TabIndex = 1
        '
        'dtpFechaCierre
        '
        Me.dtpFechaCierre.Enabled = False
        Me.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCierre.Location = New System.Drawing.Point(298, 68)
        Me.dtpFechaCierre.Name = "dtpFechaCierre"
        Me.dtpFechaCierre.Size = New System.Drawing.Size(105, 20)
        Me.dtpFechaCierre.TabIndex = 5
        '
        'TxtObservacionCierreAlquiler
        '
        Me.TxtObservacionCierreAlquiler.Location = New System.Drawing.Point(100, 94)
        Me.TxtObservacionCierreAlquiler.MaxLength = 240
        Me.TxtObservacionCierreAlquiler.Multiline = True
        Me.TxtObservacionCierreAlquiler.Name = "TxtObservacionCierreAlquiler"
        Me.TxtObservacionCierreAlquiler.Size = New System.Drawing.Size(443, 50)
        Me.TxtObservacionCierreAlquiler.TabIndex = 7
        '
        'TxtUsuarioCerrarAlquiler
        '
        Me.TxtUsuarioCerrarAlquiler.Location = New System.Drawing.Point(100, 66)
        Me.TxtUsuarioCerrarAlquiler.Name = "TxtUsuarioCerrarAlquiler"
        Me.TxtUsuarioCerrarAlquiler.ReadOnly = True
        Me.TxtUsuarioCerrarAlquiler.Size = New System.Drawing.Size(135, 22)
        Me.TxtUsuarioCerrarAlquiler.TabIndex = 3
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(11, 94)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel5.TabIndex = 6
        Me.KryptonLabel5.Text = "Observación:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Observación:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(241, 68)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel4.TabIndex = 4
        Me.KryptonLabel4.Text = "Fecha:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Fecha:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 68)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(55, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Usuario:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Usuario:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NRUCTR"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FINCOP_S"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha Operación"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 114
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NORSRT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "O/S"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 115
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CCLNT_S"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 114
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RUTA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Placa Tracto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CBRCNT"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CBRCND"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SESTOP"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Estado Op."
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.HeaderText = " "
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(316, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 153
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(98, 116)
        Me.KryptonTextBox1.MaxLength = 240
        Me.KryptonTextBox1.Multiline = True
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(323, 52)
        Me.KryptonTextBox1.TabIndex = 152
        '
        'KryptonTextBox2
        '
        Me.KryptonTextBox2.Location = New System.Drawing.Point(98, 88)
        Me.KryptonTextBox2.Name = "KryptonTextBox2"
        Me.KryptonTextBox2.ReadOnly = True
        Me.KryptonTextBox2.Size = New System.Drawing.Size(150, 22)
        Me.KryptonTextBox2.TabIndex = 151
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 116)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel2.TabIndex = 150
        Me.KryptonLabel2.Text = "Observación:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Observación:"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(265, 88)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel7.TabIndex = 149
        Me.KryptonLabel7.Text = "Fecha:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Fecha:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(11, 88)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(55, 20)
        Me.KryptonLabel8.TabIndex = 148
        Me.KryptonLabel8.Text = "Usuario:"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Usuario:"
        '
        'KryptonTextBox3
        '
        Me.KryptonTextBox3.Enabled = False
        Me.KryptonTextBox3.Location = New System.Drawing.Point(59, 46)
        Me.KryptonTextBox3.MaxLength = 15
        Me.KryptonTextBox3.Name = "KryptonTextBox3"
        Me.KryptonTextBox3.Size = New System.Drawing.Size(88, 22)
        Me.KryptonTextBox3.TabIndex = 147
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel9.Location = New System.Drawing.Point(10, 48)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel9.TabIndex = 146
        Me.KryptonLabel9.Text = "Tipo"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Tipo"
        '
        'KryptonTextBox4
        '
        Me.KryptonTextBox4.Enabled = False
        Me.KryptonTextBox4.Location = New System.Drawing.Point(198, 46)
        Me.KryptonTextBox4.MaxLength = 15
        Me.KryptonTextBox4.Name = "KryptonTextBox4"
        Me.KryptonTextBox4.Size = New System.Drawing.Size(126, 22)
        Me.KryptonTextBox4.TabIndex = 145
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel10.Location = New System.Drawing.Point(153, 46)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel10.TabIndex = 144
        Me.KryptonLabel10.Text = "Placa"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Placa"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(472, 20)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(93, 21)
        Me.DateTimePicker2.TabIndex = 121
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(571, 20)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(95, 21)
        Me.DateTimePicker3.TabIndex = 123
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(354, 22)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(115, 20)
        Me.KryptonCheckBox1.TabIndex = 120
        Me.KryptonCheckBox1.Text = "Fecha Operación"
        Me.KryptonCheckBox1.Values.ExtraText = ""
        Me.KryptonCheckBox1.Values.Image = Nothing
        Me.KryptonCheckBox1.Values.Text = "Fecha Operación"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(10, 22)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel11.TabIndex = 118
        Me.KryptonLabel11.Text = "Cliente "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Cliente "
        '
        'UcCliente_TxtF011
        '
        Me.UcCliente_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente_TxtF011.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente_TxtF011.CCMPN = "EZ"
        Me.UcCliente_TxtF011.Location = New System.Drawing.Point(59, 20)
        Me.UcCliente_TxtF011.Name = "UcCliente_TxtF011"
        Me.UcCliente_TxtF011.pAccesoPorUsuario = False
        Me.UcCliente_TxtF011.pRequerido = False
        Me.UcCliente_TxtF011.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente_TxtF011.Size = New System.Drawing.Size(265, 22)
        Me.UcCliente_TxtF011.TabIndex = 119
        '
        'chkSel
        '
        Me.chkSel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chkSel.HeaderText = " "
        Me.chkSel.Name = "chkSel"
        Me.chkSel.Width = 20
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "NRUCTR"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.Visible = False
        Me.NRUCTR.Width = 82
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Proveedor"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 90
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 91
        '
        'FINCOP_S
        '
        Me.FINCOP_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FINCOP_S.DataPropertyName = "FINCOP_S"
        Me.FINCOP_S.HeaderText = "Fecha Ope."
        Me.FINCOP_S.Name = "FINCOP_S"
        Me.FINCOP_S.ReadOnly = True
        Me.FINCOP_S.Width = 95
        '
        'FATNSR
        '
        Me.FATNSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FATNSR.DataPropertyName = "FATNSR"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FATNSR.DefaultCellStyle = DataGridViewCellStyle1
        Me.FATNSR.HeaderText = "Fecha Atención"
        Me.FATNSR.Name = "FATNSR"
        Me.FATNSR.ReadOnly = True
        Me.FATNSR.Width = 118
        '
        'NORSRT
        '
        Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSRT.DataPropertyName = "NORSRT"
        Me.NORSRT.HeaderText = "O/S"
        Me.NORSRT.Name = "NORSRT"
        Me.NORSRT.ReadOnly = True
        Me.NORSRT.Width = 56
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.Visible = False
        '
        'CCLNT_S
        '
        Me.CCLNT_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT_S.DataPropertyName = "CCLNT_S"
        Me.CCLNT_S.HeaderText = "Cliente"
        Me.CCLNT_S.Name = "CCLNT_S"
        Me.CCLNT_S.ReadOnly = True
        Me.CCLNT_S.Width = 73
        '
        'RUTA
        '
        Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUTA.DataPropertyName = "RUTA"
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.ReadOnly = True
        Me.RUTA.Width = 60
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Placa Tracto"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 101
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        Me.NPLCAC.HeaderText = "Placa Acoplado"
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Width = 118
        '
        'CBRCNT
        '
        Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "CBRCNT"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.Visible = False
        Me.CBRCNT.Width = 82
        '
        'CBRCND
        '
        Me.CBRCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCND.DataPropertyName = "CBRCND"
        Me.CBRCND.HeaderText = "Conductor"
        Me.CBRCND.Name = "CBRCND"
        Me.CBRCND.ReadOnly = True
        Me.CBRCND.Width = 93
        '
        'SESTOP
        '
        Me.SESTOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTOP.DataPropertyName = "SESTOP"
        Me.SESTOP.HeaderText = "Estado Op."
        Me.SESTOP.Name = "SESTOP"
        Me.SESTOP.ReadOnly = True
        Me.SESTOP.Width = 93
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmOperacionesxProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 401)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmOperacionesxProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de Operaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.gwdOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents gwdOperacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtObservacionCierreAlquiler As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtUsuarioCerrarAlquiler As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox4 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCliente_TxtF011 As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTipoRecurso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbFechaOperacion As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents chkSel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINCOP_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FATNSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
