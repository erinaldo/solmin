<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRuteoPorPuntoEntrega
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRuteoPorPuntoEntrega))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgMercaderiaSeleccionada = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.brnRuteo = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgRuteoxPedido = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.check = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.CDPEPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCLIP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLCLP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCLIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABRUT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CRUTAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRAINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HRAFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GPSLON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGUIMIENTO = New System.Windows.Forms.DataGridViewImageColumn
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderiaSeleccionada.Panel.SuspendLayout()
        Me.hgMercaderiaSeleccionada.SuspendLayout()
        CType(Me.dtgRuteoxPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgMercaderiaSeleccionada)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1115, 573)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgMercaderiaSeleccionada
        '
        Me.hgMercaderiaSeleccionada.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.brnRuteo, Me.btnImprimir})
        Me.hgMercaderiaSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderiaSeleccionada.HeaderVisibleSecondary = False
        Me.hgMercaderiaSeleccionada.Location = New System.Drawing.Point(0, 29)
        Me.hgMercaderiaSeleccionada.Name = "hgMercaderiaSeleccionada"
        '
        'hgMercaderiaSeleccionada.Panel
        '
        Me.hgMercaderiaSeleccionada.Panel.Controls.Add(Me.dtgRuteoxPedido)
        Me.hgMercaderiaSeleccionada.Size = New System.Drawing.Size(1115, 544)
        Me.hgMercaderiaSeleccionada.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderiaSeleccionada.TabIndex = 1
        Me.hgMercaderiaSeleccionada.Text = "Ruteo Por Pedido"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Heading = "Ruteo Por Pedido"
        Me.hgMercaderiaSeleccionada.ValuesPrimary.Image = Nothing
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Description = ""
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Heading = "Description"
        Me.hgMercaderiaSeleccionada.ValuesSecondary.Image = Nothing
        '
        'brnRuteo
        '
        Me.brnRuteo.ExtraText = ""
        Me.brnRuteo.Image = Global.SOLMIN_SA.My.Resources.Resources.Procesar
        Me.brnRuteo.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.brnRuteo.Text = "Grafico Ruteo"
        Me.brnRuteo.ToolTipImage = Nothing
        Me.brnRuteo.UniqueName = "8E80FD25531B45AC8E80FD25531B45AC"
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.Image = Global.SOLMIN_SA.My.Resources.Resources.printer2
        Me.btnImprimir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "BD3CE31CEDC947A4BD3CE31CEDC947A4"
        '
        'dtgRuteoxPedido
        '
        Me.dtgRuteoxPedido.AllowUserToAddRows = False
        Me.dtgRuteoxPedido.AllowUserToDeleteRows = False
        Me.dtgRuteoxPedido.AllowUserToResizeColumns = False
        Me.dtgRuteoxPedido.AllowUserToResizeRows = False
        Me.dtgRuteoxPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgRuteoxPedido.ColumnHeadersHeight = 33
        Me.dtgRuteoxPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgRuteoxPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.CDPEPL, Me.DESCLIP, Me.CCLNT, Me.CPLNCL, Me.CPRVCL, Me.CPLCLP, Me.TCMPPL, Me.DESCLIT, Me.TCMPCP, Me.TABRUT, Me.CRUTAT, Me.NCRRRT, Me.HRAINI, Me.HRAFIN, Me.GPSLAT, Me.GPSLON, Me.SEGUIMIENTO})
        Me.dtgRuteoxPedido.DataMember = "dtMercaderiaSeleccionadas"
        Me.dtgRuteoxPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgRuteoxPedido.Location = New System.Drawing.Point(0, 0)
        Me.dtgRuteoxPedido.Name = "dtgRuteoxPedido"
        Me.dtgRuteoxPedido.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgRuteoxPedido.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgRuteoxPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgRuteoxPedido.Size = New System.Drawing.Size(1113, 514)
        Me.dtgRuteoxPedido.StandardTab = True
        Me.dtgRuteoxPedido.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgRuteoxPedido.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgRuteoxPedido.TabIndex = 0
        '
        'check
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.check.DefaultCellStyle = DataGridViewCellStyle1
        Me.check.FalseValue = "N"
        Me.check.HeaderText = "Chk"
        Me.check.IndeterminateValue = "N"
        Me.check.Name = "check"
        Me.check.TrueValue = "S"
        Me.check.Width = 37
        '
        'CDPEPL
        '
        Me.CDPEPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CDPEPL.DataPropertyName = "PNCDPEPL"
        Me.CDPEPL.HeaderText = "Codigo Pedido"
        Me.CDPEPL.Name = "CDPEPL"
        Me.CDPEPL.Width = 104
        '
        'DESCLIP
        '
        Me.DESCLIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESCLIP.DataPropertyName = "PSDESCLIP"
        Me.DESCLIP.HeaderText = "Cliente"
        Me.DESCLIP.Name = "DESCLIP"
        Me.DESCLIP.ReadOnly = True
        Me.DESCLIP.Width = 72
        '
        'CCLNT
        '
        Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT.DataPropertyName = "PNCCLNT"
        Me.CCLNT.HeaderText = "Codigo Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 104
        '
        'CPLNCL
        '
        Me.CPLNCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPLNCL.DataPropertyName = "PNCPLNCL"
        Me.CPLNCL.HeaderText = "Planta Propia"
        Me.CPLNCL.Name = "CPLNCL"
        Me.CPLNCL.ReadOnly = True
        Me.CPLNCL.Visible = False
        Me.CPLNCL.Width = 96
        '
        'CPRVCL
        '
        Me.CPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPRVCL.DataPropertyName = "PNCPRVCL"
        Me.CPRVCL.HeaderText = "Cliente Tercero"
        Me.CPRVCL.Name = "CPRVCL"
        Me.CPRVCL.ReadOnly = True
        Me.CPRVCL.Visible = False
        Me.CPRVCL.Width = 103
        '
        'CPLCLP
        '
        Me.CPLCLP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPLCLP.DataPropertyName = "PNCPLCLP"
        DataGridViewCellStyle2.NullValue = "0"
        Me.CPLCLP.DefaultCellStyle = DataGridViewCellStyle2
        Me.CPLCLP.HeaderText = "Planta Tercero"
        Me.CPLCLP.Name = "CPLCLP"
        Me.CPLCLP.ReadOnly = True
        Me.CPLCLP.Visible = False
        '
        'TCMPPL
        '
        Me.TCMPPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPPL.DataPropertyName = "PSTCMPPL"
        Me.TCMPPL.HeaderText = "Planta Propio"
        Me.TCMPPL.Name = "TCMPPL"
        Me.TCMPPL.ReadOnly = True
        Me.TCMPPL.Width = 97
        '
        'DESCLIT
        '
        Me.DESCLIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESCLIT.DataPropertyName = "PSDESCLIT"
        Me.DESCLIT.HeaderText = "Cliente Propio Tercero"
        Me.DESCLIT.Name = "DESCLIT"
        Me.DESCLIT.ReadOnly = True
        Me.DESCLIT.Width = 137
        '
        'TCMPCP
        '
        Me.TCMPCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMPCP.DataPropertyName = "PSTCMPCP"
        Me.TCMPCP.HeaderText = "Planta Tercero"
        Me.TCMPCP.Name = "TCMPCP"
        Me.TCMPCP.ReadOnly = True
        '
        'TABRUT
        '
        Me.TABRUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TABRUT.DataPropertyName = "PSTABRUT"
        Me.TABRUT.HeaderText = "Descripcion Ruta"
        Me.TABRUT.Name = "TABRUT"
        Me.TABRUT.ReadOnly = True
        Me.TABRUT.Width = 113
        '
        'CRUTAT
        '
        Me.CRUTAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CRUTAT.DataPropertyName = "PSCRUTAT"
        Me.CRUTAT.HeaderText = "Codigo Ruta"
        Me.CRUTAT.Name = "CRUTAT"
        Me.CRUTAT.ReadOnly = True
        Me.CRUTAT.Width = 93
        '
        'NCRRRT
        '
        Me.NCRRRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRRT.DataPropertyName = "PNNCRRRT_S"
        Me.NCRRRT.HeaderText = " Correlativo Ruta"
        Me.NCRRRT.Name = "NCRRRT"
        Me.NCRRRT.ReadOnly = True
        Me.NCRRRT.Width = 112
        '
        'HRAINI
        '
        Me.HRAINI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HRAINI.DataPropertyName = "PNHRAINI_S"
        Me.HRAINI.HeaderText = "Hora Inicio"
        Me.HRAINI.Name = "HRAINI"
        Me.HRAINI.ReadOnly = True
        Me.HRAINI.Width = 85
        '
        'HRAFIN
        '
        Me.HRAFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HRAFIN.DataPropertyName = "PNHRAFIN_S"
        Me.HRAFIN.HeaderText = "Hora Fin"
        Me.HRAFIN.Name = "HRAFIN"
        Me.HRAFIN.ReadOnly = True
        Me.HRAFIN.Width = 74
        '
        'GPSLAT
        '
        Me.GPSLAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GPSLAT.DataPropertyName = "PSGPSLAT"
        Me.GPSLAT.HeaderText = "Latitud"
        Me.GPSLAT.Name = "GPSLAT"
        Me.GPSLAT.ReadOnly = True
        Me.GPSLAT.Width = 72
        '
        'GPSLON
        '
        Me.GPSLON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GPSLON.DataPropertyName = "PSGPSLON"
        Me.GPSLON.HeaderText = "Longitud"
        Me.GPSLON.Name = "GPSLON"
        Me.GPSLON.ReadOnly = True
        Me.GPSLON.Width = 83
        '
        'SEGUIMIENTO
        '
        Me.SEGUIMIENTO.HeaderText = "SEGUIMIENTO"
        Me.SEGUIMIENTO.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok
        Me.SEGUIMIENTO.Name = "SEGUIMIENTO"
        Me.SEGUIMIENTO.ReadOnly = True
        Me.SEGUIMIENTO.Width = 89
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Collapsed = True
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.khgFiltros.Panel.Controls.Add(Me.btnProcesar)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFecha)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Size = New System.Drawing.Size(1115, 29)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 0
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(364, 21)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(113, 19)
        Me.KryptonLabel7.TabIndex = 2
        Me.KryptonLabel7.Text = "Fecha de Despacho :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Fecha de Despacho :"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(1026, 15)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(71, 74)
        Me.btnProcesar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnProcesar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnProcesar.TabIndex = 4
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = "Consulta"
        Me.btnProcesar.Values.Image = CType(resources.GetObject("btnProcesar.Values.Image"), System.Drawing.Image)
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(483, 20)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(67, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(265, 21)
        Me.txtCliente.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 19)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PNCDPEPL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo Pedido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSDESCLIP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PNCCLNT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PNCPLNCL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Planta Propia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PNCPRVCL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cliente Tercero"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PNCPLCLP"
        DataGridViewCellStyle4.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Planta Tercero"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSTCMPPL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Planta Propio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PSDESCLIT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cliente Propio Tercero"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSTCMPCP"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Planta Tercero"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSTABRUT"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Descripcion Ruta"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PSCRUTAT"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codigo Ruta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PNNCRRRT_S"
        Me.DataGridViewTextBoxColumn12.HeaderText = " Correlativo Ruta"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PNHRAINI_S"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Hora Inicio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PNHRAFIN_S"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Hora Fin"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PSGPSLAT"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Latitud"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PSGPSLON"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Longitud"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'frmRuteoPorPuntoEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 573)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRuteoPorPuntoEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ruteo Por Punto de Entrega"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgMercaderiaSeleccionada.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.Panel.ResumeLayout(False)
        CType(Me.hgMercaderiaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderiaSeleccionada.ResumeLayout(False)
        CType(Me.dtgRuteoxPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents hgMercaderiaSeleccionada As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgRuteoxPedido As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents brnRuteo As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents check As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents CDPEPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCLIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLCLP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCLIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABRUT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRUTAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRAINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRAFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GPSLON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGUIMIENTO As System.Windows.Forms.DataGridViewImageColumn
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
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
