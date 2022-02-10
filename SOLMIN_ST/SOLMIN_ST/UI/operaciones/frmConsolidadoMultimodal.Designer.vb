<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidadoMultimodal
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsolidadoMultimodal))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwProceso = New System.ComponentModel.BackgroundWorker
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.C_NMOPMM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_FCOPMM_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_TOBRCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.C_SESTOP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCSOTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECOST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLCLOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLCLDS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMMDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnAceptar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnProcesarConsulta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtAcoplado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTransportista = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtMedioTransporte = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProceso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.pbxProceso = New System.Windows.Forms.PictureBox
        Me.txtNroOperacionMM = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.ckbRangoFechas = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.pbxProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgwProceso
        '
        Me.bgwProceso.WorkerReportsProgress = True
        Me.bgwProceso.WorkerSupportsCancellation = True
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.C_NMOPMM, Me.C_CCLNT, Me.C_TCMPCL, Me.C_FCOPMM_S, Me.C_TOBRCP, Me.C_SESTOP, Me.NCSOTR, Me.FECOST, Me.CLCLOR, Me.CLCLDS, Me.TNMMDT, Me.NPLCUN, Me.NPLCAC, Me.CBRCND, Me.CBRCNT, Me.NORSRT, Me.NGUITR, Me.NOPRCN, Me.NRUCTR})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.Location = New System.Drawing.Point(0, 180)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowTemplate.Height = 16
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(811, 306)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 0
        Me.gwdDatos.TabStop = False
        '
        'chkSelect
        '
        Me.chkSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.chkSelect.HeaderText = "Select"
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkSelect.Width = 50
        '
        'C_NMOPMM
        '
        Me.C_NMOPMM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.C_NMOPMM.DataPropertyName = "NMOPMM"
        Me.C_NMOPMM.HeaderText = "N° Op. Multimodal"
        Me.C_NMOPMM.Name = "C_NMOPMM"
        Me.C_NMOPMM.ReadOnly = True
        Me.C_NMOPMM.Width = 132
        '
        'C_CCLNT
        '
        Me.C_CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.C_CCLNT.DataPropertyName = "CCLNT"
        Me.C_CCLNT.HeaderText = "Cód. Cliente"
        Me.C_CCLNT.Name = "C_CCLNT"
        Me.C_CCLNT.ReadOnly = True
        Me.C_CCLNT.Visible = False
        Me.C_CCLNT.Width = 99
        '
        'C_TCMPCL
        '
        Me.C_TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.C_TCMPCL.DataPropertyName = "TCMPCL"
        Me.C_TCMPCL.HeaderText = "Cliente"
        Me.C_TCMPCL.Name = "C_TCMPCL"
        Me.C_TCMPCL.ReadOnly = True
        Me.C_TCMPCL.Width = 72
        '
        'C_FCOPMM_S
        '
        Me.C_FCOPMM_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.C_FCOPMM_S.DataPropertyName = "FECOST"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.C_FCOPMM_S.DefaultCellStyle = DataGridViewCellStyle6
        Me.C_FCOPMM_S.HeaderText = "Fecha  Multimodal"
        Me.C_FCOPMM_S.Name = "C_FCOPMM_S"
        Me.C_FCOPMM_S.ReadOnly = True
        Me.C_FCOPMM_S.Width = 131
        '
        'C_TOBRCP
        '
        Me.C_TOBRCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.C_TOBRCP.DataPropertyName = "TOBS"
        Me.C_TOBRCP.HeaderText = "Observaciones"
        Me.C_TOBRCP.Name = "C_TOBRCP"
        Me.C_TOBRCP.ReadOnly = True
        Me.C_TOBRCP.Visible = False
        Me.C_TOBRCP.Width = 111
        '
        'C_SESTOP
        '
        Me.C_SESTOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.C_SESTOP.DataPropertyName = "SESTOP"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.C_SESTOP.DefaultCellStyle = DataGridViewCellStyle7
        Me.C_SESTOP.HeaderText = "Estado"
        Me.C_SESTOP.Name = "C_SESTOP"
        Me.C_SESTOP.ReadOnly = True
        Me.C_SESTOP.Visible = False
        Me.C_SESTOP.Width = 71
        '
        'NCSOTR
        '
        Me.NCSOTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCSOTR.DataPropertyName = "NCSOTR"
        Me.NCSOTR.HeaderText = "Nro Solicitud "
        Me.NCSOTR.Name = "NCSOTR"
        Me.NCSOTR.ReadOnly = True
        Me.NCSOTR.Width = 106
        '
        'FECOST
        '
        Me.FECOST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECOST.DataPropertyName = "FECOST"
        Me.FECOST.HeaderText = "Fecha Solicitud"
        Me.FECOST.Name = "FECOST"
        Me.FECOST.ReadOnly = True
        Me.FECOST.Width = 114
        '
        'CLCLOR
        '
        Me.CLCLOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLCLOR.DataPropertyName = "CLCLOR"
        Me.CLCLOR.HeaderText = "Localidad Origen"
        Me.CLCLOR.Name = "CLCLOR"
        Me.CLCLOR.ReadOnly = True
        Me.CLCLOR.Width = 124
        '
        'CLCLDS
        '
        Me.CLCLDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLCLDS.DataPropertyName = "CLCLDS"
        Me.CLCLDS.HeaderText = "Localidad Entrega"
        Me.CLCLDS.Name = "CLCLDS"
        Me.CLCLDS.ReadOnly = True
        Me.CLCLDS.Width = 128
        '
        'TNMMDT
        '
        Me.TNMMDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMMDT.DataPropertyName = "TNMMDT"
        Me.TNMMDT.HeaderText = "Medio de Transporte"
        Me.TNMMDT.Name = "TNMMDT"
        Me.TNMMDT.ReadOnly = True
        Me.TNMMDT.Width = 143
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Tracto"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 67
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        Me.NPLCAC.HeaderText = "Acoplado"
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Width = 85
        '
        'CBRCND
        '
        Me.CBRCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCND.DataPropertyName = "CBRCND"
        Me.CBRCND.HeaderText = "Conductor"
        Me.CBRCND.Name = "CBRCND"
        Me.CBRCND.ReadOnly = True
        Me.CBRCND.Width = 91
        '
        'CBRCNT
        '
        Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "Brevete"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.ReadOnly = True
        Me.CBRCNT.Width = 74
        '
        'NORSRT
        '
        Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSRT.DataPropertyName = "NORSRT"
        Me.NORSRT.HeaderText = "Orden de Servicio"
        Me.NORSRT.Name = "NORSRT"
        Me.NORSRT.ReadOnly = True
        Me.NORSRT.Width = 127
        '
        'NGUITR
        '
        Me.NGUITR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NGUITR.DataPropertyName = "NGUITR"
        Me.NGUITR.HeaderText = "Guía Transporte"
        Me.NGUITR.Name = "NGUITR"
        Me.NGUITR.ReadOnly = True
        Me.NGUITR.Width = 118
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Nro Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 112
        '
        'NRUCTR
        '
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "NRUCTR"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.Visible = False
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAceptar, Me.btnSalir, Me.btnProcesarConsulta})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.txtAcoplado)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtPlaca)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtTransportista)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtMedioTransporte)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblProceso)
        Me.PanelFiltros.Panel.Controls.Add(Me.pbxProceso)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroOperacionMM)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtClienteFiltro)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaFin)
        Me.PanelFiltros.Panel.Controls.Add(Me.ckbRangoFechas)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel21)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.PanelFiltros.Size = New System.Drawing.Size(811, 180)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.ExtraText = ""
        Me.btnAceptar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipImage = Nothing
        Me.btnAceptar.UniqueName = "A8893F9EF7DA4FF3A8893F9EF7DA4FF3"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "713965A537DE4585713965A537DE4585"
        '
        'btnProcesarConsulta
        '
        Me.btnProcesarConsulta.ExtraText = ""
        Me.btnProcesarConsulta.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesarConsulta.Image = CType(resources.GetObject("btnProcesarConsulta.Image"), System.Drawing.Image)
        Me.btnProcesarConsulta.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnProcesarConsulta.Text = "Buscar"
        Me.btnProcesarConsulta.ToolTipImage = Nothing
        Me.btnProcesarConsulta.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'txtAcoplado
        '
        Me.txtAcoplado.Enabled = False
        Me.txtAcoplado.Location = New System.Drawing.Point(605, 36)
        Me.txtAcoplado.Name = "txtAcoplado"
        Me.txtAcoplado.Size = New System.Drawing.Size(113, 21)
        Me.txtAcoplado.TabIndex = 144
        '
        'txtPlaca
        '
        Me.txtPlaca.Enabled = False
        Me.txtPlaca.Location = New System.Drawing.Point(462, 36)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(113, 21)
        Me.txtPlaca.TabIndex = 143
        '
        'txtTransportista
        '
        Me.txtTransportista.Enabled = False
        Me.txtTransportista.Location = New System.Drawing.Point(179, 36)
        Me.txtTransportista.Name = "txtTransportista"
        Me.txtTransportista.Size = New System.Drawing.Size(244, 21)
        Me.txtTransportista.TabIndex = 142
        '
        'txtMedioTransporte
        '
        Me.txtMedioTransporte.Enabled = False
        Me.txtMedioTransporte.Location = New System.Drawing.Point(11, 36)
        Me.txtMedioTransporte.Name = "txtMedioTransporte"
        Me.txtMedioTransporte.Size = New System.Drawing.Size(113, 21)
        Me.txtMedioTransporte.TabIndex = 141
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(605, 11)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(58, 19)
        Me.KryptonLabel4.TabIndex = 140
        Me.KryptonLabel4.Text = "Acoplado"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Acoplado"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(462, 11)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(36, 19)
        Me.KryptonLabel3.TabIndex = 139
        Me.KryptonLabel3.Text = "Placa"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Placa"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(179, 11)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(75, 19)
        Me.KryptonLabel2.TabIndex = 138
        Me.KryptonLabel2.Text = "Transportista"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Transportista"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(113, 19)
        Me.KryptonLabel1.TabIndex = 137
        Me.KryptonLabel1.Text = "Medio de transporte"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Medio de transporte"
        '
        'lblProceso
        '
        Me.lblProceso.Location = New System.Drawing.Point(50, 120)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(18, 19)
        Me.lblProceso.TabIndex = 136
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
        Me.pbxProceso.Location = New System.Drawing.Point(11, 118)
        Me.pbxProceso.Name = "pbxProceso"
        Me.pbxProceso.Size = New System.Drawing.Size(33, 30)
        Me.pbxProceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxProceso.TabIndex = 135
        Me.pbxProceso.TabStop = False
        Me.pbxProceso.Visible = False
        '
        'txtNroOperacionMM
        '
        Me.txtNroOperacionMM.Location = New System.Drawing.Point(609, 96)
        Me.txtNroOperacionMM.MaxLength = 10
        Me.txtNroOperacionMM.Name = "txtNroOperacionMM"
        Me.txtNroOperacionMM.Size = New System.Drawing.Size(90, 21)
        Me.txtNroOperacionMM.TabIndex = 134
        Me.txtNroOperacionMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(609, 70)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(138, 19)
        Me.KryptonLabel6.TabIndex = 133
        Me.KryptonLabel6.Text = "N° Operación Multimodal"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "N° Operación Multimodal"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Location = New System.Drawing.Point(11, 95)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.Size = New System.Drawing.Size(265, 21)
        Me.txtClienteFiltro.TabIndex = 10
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(334, 96)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.dtpFechaInicio.TabIndex = 12
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(466, 95)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(95, 21)
        Me.dtpFechaFin.TabIndex = 14
        '
        'ckbRangoFechas
        '
        Me.ckbRangoFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbRangoFechas.Location = New System.Drawing.Point(334, 70)
        Me.ckbRangoFechas.Name = "ckbRangoFechas"
        Me.ckbRangoFechas.Size = New System.Drawing.Size(183, 19)
        Me.ckbRangoFechas.TabIndex = 11
        Me.ckbRangoFechas.Text = "Fecha de Operacion Multimodal"
        Me.ckbRangoFechas.Values.ExtraText = ""
        Me.ckbRangoFechas.Values.Image = Nothing
        Me.ckbRangoFechas.Values.Text = "Fecha de Operacion Multimodal"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(436, 96)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(19, 19)
        Me.KryptonLabel21.TabIndex = 13
        Me.KryptonLabel21.Text = "al"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "al"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(11, 70)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 9
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NMOPMM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Multimodal"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cód. Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FCOPMM_S"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha  Multimodal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ITINERA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Itinerario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NRORTA"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nro Rutas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOBRCP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SESTOP"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NCSOTR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nro Solicitud "
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FECOST"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha Solicitud"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CLCLOR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Localidad Origen"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TDRCOR"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Dirección Origen"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CLCLDS"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Localidad Entrega"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TDRENT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Dirección Entrega"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TNMMDT"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Medio de Transporte"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tracto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Acoplado"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CBRCND"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NORSRT"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Orden de Servicio"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "QMRCDR"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Cantidad Merc."
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CUNDMD"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Unidad Medida"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "CTPOSR"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Tipo Servicio"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NGUITR"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Guía Transporte"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Nro Operación"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "NPLNMT"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Nro Planeamiento"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "NORINS"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Nro Orden Interna"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn28.HeaderText = "NRUCTR"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'frmConsolidadoMultimodal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 486)
        Me.Controls.Add(Me.gwdDatos)
        Me.Controls.Add(Me.PanelFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConsolidadoMultimodal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Consolidado Multimodal"
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.pbxProceso, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bgwProceso As System.ComponentModel.BackgroundWorker
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnProcesarConsulta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbRangoFechas As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOperacionMM As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProceso As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pbxProceso As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAcoplado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTransportista As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMedioTransporte As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents C_NMOPMM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_FCOPMM_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_TOBRCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_SESTOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCSOTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECOST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLCLOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLCLDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMMDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
