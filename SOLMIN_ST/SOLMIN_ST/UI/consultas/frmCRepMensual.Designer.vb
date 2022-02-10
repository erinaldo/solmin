<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRepMensual
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
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GUIACLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ORDENCOMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CANTIDADBULTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PESOBRUTO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.VOLUMEN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MERCADERIA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ACOPLADO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ORIGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECHASOLICITUDUNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECHAASIGNACIONUNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECHASALIDA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECHALLEGADA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FECHASOLICITADADESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.PLACA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CHOFER = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TIPOTRANSPORTISTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.IMPORTEFLETE = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.IMPORTESERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnImprimir = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
    Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.cboTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
    Me.txtNumeroPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
    Me.ctlCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.cboDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.cboCia = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupTabs.Panel.SuspendLayout()
    Me.HeaderGroupTabs.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupFiltro.Panel.SuspendLayout()
    Me.HeaderGroupFiltro.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupTabs)
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1051, 613)
    Me.KryptonPanel.TabIndex = 0
    '
    'HeaderGroupTabs
    '
    Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 133)
    Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
    '
    'HeaderGroupTabs.Panel
    '
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
    Me.HeaderGroupTabs.Size = New System.Drawing.Size(1051, 480)
    Me.HeaderGroupTabs.TabIndex = 3
    Me.HeaderGroupTabs.Text = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Description = ""
    Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
    Me.HeaderGroupTabs.ValuesSecondary.Description = ""
    Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
    Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1049, 430)
    Me.TabControl1.TabIndex = 1
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.gwdDatos)
    Me.TabPage1.ImageIndex = 4
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(1041, 404)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Consulta en Pantalla"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'gwdDatos
    '
    Me.gwdDatos.AccessibleDescription = ""
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToDeleteRows = False
    Me.gwdDatos.AllowUserToResizeColumns = False
    Me.gwdDatos.AllowUserToResizeRows = False
    Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.gwdDatos.ColumnHeadersHeight = 20
    Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN, Me.NGUITR, Me.GUIACLIENTE, Me.ORDENCOMPRA, Me.CANTIDADBULTOS, Me.PESOBRUTO, Me.VOLUMEN, Me.MERCADERIA, Me.ACOPLADO, Me.ORIGEN, Me.DESTINO, Me.FECHASOLICITUDUNIDAD, Me.FECHAASIGNACIONUNIDAD, Me.FECHASALIDA, Me.FECHALLEGADA, Me.FECHASOLICITADADESTINO, Me.PLACA, Me.CHOFER, Me.TIPOTRANSPORTISTA, Me.IMPORTEFLETE, Me.IMPORTESERVICIO})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatos.Location = New System.Drawing.Point(3, 3)
    Me.gwdDatos.MultiSelect = False
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersWidth = 20
    Me.gwdDatos.RowTemplate.Height = 16
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(1035, 398)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 6
    '
    'NOPRCN
    '
    Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NOPRCN.DataPropertyName = "NOPRCN"
    Me.NOPRCN.HeaderText = "Nro Operac."
    Me.NOPRCN.Name = "NOPRCN"
    Me.NOPRCN.ReadOnly = True
    Me.NOPRCN.Width = 98
    '
    'NGUITR
    '
    Me.NGUITR.DataPropertyName = "NGUITR"
    Me.NGUITR.HeaderText = "G. Tran."
    Me.NGUITR.Name = "NGUITR"
    Me.NGUITR.ReadOnly = True
    Me.NGUITR.Width = 75
    '
    'GUIACLIENTE
    '
    Me.GUIACLIENTE.DataPropertyName = "GUIACLIENTE"
    Me.GUIACLIENTE.HeaderText = "Guía Cliente"
    Me.GUIACLIENTE.Name = "GUIACLIENTE"
    Me.GUIACLIENTE.ReadOnly = True
    Me.GUIACLIENTE.Width = 99
    '
    'ORDENCOMPRA
    '
    Me.ORDENCOMPRA.DataPropertyName = "ORDENCOMPRA"
    Me.ORDENCOMPRA.HeaderText = "Ord. Compra"
    Me.ORDENCOMPRA.Name = "ORDENCOMPRA"
    Me.ORDENCOMPRA.ReadOnly = True
    Me.ORDENCOMPRA.Width = 102
    '
    'CANTIDADBULTOS
    '
    Me.CANTIDADBULTOS.DataPropertyName = "CANTIDADBULTOS"
    Me.CANTIDADBULTOS.HeaderText = "Bultos"
    Me.CANTIDADBULTOS.Name = "CANTIDADBULTOS"
    Me.CANTIDADBULTOS.ReadOnly = True
    Me.CANTIDADBULTOS.Width = 69
    '
    'PESOBRUTO
    '
    Me.PESOBRUTO.DataPropertyName = "PESOBRUTO"
    Me.PESOBRUTO.HeaderText = "Peso"
    Me.PESOBRUTO.Name = "PESOBRUTO"
    Me.PESOBRUTO.ReadOnly = True
    Me.PESOBRUTO.Width = 60
    '
    'VOLUMEN
    '
    Me.VOLUMEN.DataPropertyName = "VOLUMEN"
    Me.VOLUMEN.HeaderText = "Volumen"
    Me.VOLUMEN.Name = "VOLUMEN"
    Me.VOLUMEN.ReadOnly = True
    Me.VOLUMEN.Width = 82
    '
    'MERCADERIA
    '
    Me.MERCADERIA.DataPropertyName = "MERCADERIA"
    Me.MERCADERIA.HeaderText = "Mercadería"
    Me.MERCADERIA.Name = "MERCADERIA"
    Me.MERCADERIA.ReadOnly = True
    Me.MERCADERIA.Width = 93
    '
    'ACOPLADO
    '
    Me.ACOPLADO.DataPropertyName = "ACOPLADO"
    Me.ACOPLADO.HeaderText = "Acoplado"
    Me.ACOPLADO.Name = "ACOPLADO"
    Me.ACOPLADO.ReadOnly = True
    Me.ACOPLADO.Width = 85
    '
    'ORIGEN
    '
    Me.ORIGEN.DataPropertyName = "ORIGEN"
    Me.ORIGEN.HeaderText = "Origen"
    Me.ORIGEN.Name = "ORIGEN"
    Me.ORIGEN.ReadOnly = True
    Me.ORIGEN.Width = 72
    '
    'DESTINO
    '
    Me.DESTINO.DataPropertyName = "DESTINO"
    Me.DESTINO.HeaderText = "Destino"
    Me.DESTINO.Name = "DESTINO"
    Me.DESTINO.ReadOnly = True
    Me.DESTINO.Width = 76
    '
    'FECHASOLICITUDUNIDAD
    '
    Me.FECHASOLICITUDUNIDAD.DataPropertyName = "FECHASOLICITUDUNIDAD"
    Me.FECHASOLICITUDUNIDAD.HeaderText = "Sol. Unid"
    Me.FECHASOLICITUDUNIDAD.Name = "FECHASOLICITUDUNIDAD"
    Me.FECHASOLICITUDUNIDAD.ReadOnly = True
    Me.FECHASOLICITUDUNIDAD.Width = 83
    '
    'FECHAASIGNACIONUNIDAD
    '
    Me.FECHAASIGNACIONUNIDAD.DataPropertyName = "FECHAASIGNACIONUNIDAD"
    Me.FECHAASIGNACIONUNIDAD.HeaderText = "Asig. Unid."
    Me.FECHAASIGNACIONUNIDAD.Name = "FECHAASIGNACIONUNIDAD"
    Me.FECHAASIGNACIONUNIDAD.ReadOnly = True
    Me.FECHAASIGNACIONUNIDAD.Width = 92
    '
    'FECHASALIDA
    '
    Me.FECHASALIDA.DataPropertyName = "FECHASALIDA"
    Me.FECHASALIDA.HeaderText = "Salida"
    Me.FECHASALIDA.Name = "FECHASALIDA"
    Me.FECHASALIDA.ReadOnly = True
    Me.FECHASALIDA.Width = 67
    '
    'FECHALLEGADA
    '
    Me.FECHALLEGADA.DataPropertyName = "FECHALLEGADA"
    Me.FECHALLEGADA.HeaderText = "Llegada"
    Me.FECHALLEGADA.Name = "FECHALLEGADA"
    Me.FECHALLEGADA.ReadOnly = True
    Me.FECHALLEGADA.Width = 76
    '
    'FECHASOLICITADADESTINO
    '
    Me.FECHASOLICITADADESTINO.DataPropertyName = "FECHASOLICITADADESTINO"
    Me.FECHASOLICITADADESTINO.HeaderText = "Fec. Dest."
    Me.FECHASOLICITADADESTINO.Name = "FECHASOLICITADADESTINO"
    Me.FECHASOLICITADADESTINO.ReadOnly = True
    Me.FECHASOLICITADADESTINO.Width = 85
    '
    'PLACA
    '
    Me.PLACA.DataPropertyName = "PLACA"
    Me.PLACA.HeaderText = "Placa"
    Me.PLACA.Name = "PLACA"
    Me.PLACA.ReadOnly = True
    Me.PLACA.Width = 62
    '
    'CHOFER
    '
    Me.CHOFER.DataPropertyName = "CHOFER"
    Me.CHOFER.HeaderText = "Chofer"
    Me.CHOFER.Name = "CHOFER"
    Me.CHOFER.ReadOnly = True
    Me.CHOFER.Width = 71
    '
    'TIPOTRANSPORTISTA
    '
    Me.TIPOTRANSPORTISTA.DataPropertyName = "TIPOTRANSPORTISTA"
    Me.TIPOTRANSPORTISTA.HeaderText = "Tip. Tran."
    Me.TIPOTRANSPORTISTA.Name = "TIPOTRANSPORTISTA"
    Me.TIPOTRANSPORTISTA.ReadOnly = True
    Me.TIPOTRANSPORTISTA.Width = 82
    '
    'IMPORTEFLETE
    '
    Me.IMPORTEFLETE.DataPropertyName = "IMPORTEFLETE"
    Me.IMPORTEFLETE.HeaderText = "Imp. Flete"
    Me.IMPORTEFLETE.Name = "IMPORTEFLETE"
    Me.IMPORTEFLETE.ReadOnly = True
    Me.IMPORTEFLETE.Width = 86
    '
    'IMPORTESERVICIO
    '
    Me.IMPORTESERVICIO.DataPropertyName = "IMPORTESERVICIO"
    Me.IMPORTESERVICIO.HeaderText = "Imp. Serv."
    Me.IMPORTESERVICIO.Name = "IMPORTESERVICIO"
    Me.IMPORTESERVICIO.ReadOnly = True
    Me.IMPORTESERVICIO.Width = 85
    '
    'Panel2
    '
    Me.Panel2.AutoSize = True
    Me.Panel2.Controls.Add(Me.MenuBar)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1049, 25)
    Me.Panel2.TabIndex = 4
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnImprimir, Me.ToolStripSeparator4, Me.btnExportarExcel})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(1049, 25)
    Me.MenuBar.TabIndex = 2
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnProcesarReporte
    '
    Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
    Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesarReporte.Name = "btnProcesarReporte"
    Me.btnProcesarReporte.Size = New System.Drawing.Size(114, 22)
    Me.btnProcesarReporte.Text = "Procesar Reporte"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnImprimir
    '
    Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
    Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(113, 22)
    Me.btnImprimir.Text = "Imprimir Reporte"
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
    '
    'btnExportarExcel
    '
    Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
    Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnExportarExcel.Name = "btnExportarExcel"
    Me.btnExportarExcel.Size = New System.Drawing.Size(98, 22)
    Me.btnExportarExcel.Text = "Exportar Excel"
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
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboTransportista)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtNumeroPlaca)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel20)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaInicio)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel4)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.dtpFechaFin)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctlCliente)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel19)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboPlanta)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboDivision)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboCia)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel6)
    Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1051, 133)
    Me.HeaderGroupFiltro.TabIndex = 0
    Me.HeaderGroupFiltro.Text = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
    Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
    Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
    '
    'cboTransportista
    '
    Me.cboTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cboTransportista.BackColor = System.Drawing.Color.Transparent
    Me.cboTransportista.Location = New System.Drawing.Point(112, 42)
    Me.cboTransportista.Name = "cboTransportista"
    Me.cboTransportista.pNroRegPorPaginas = 0
    Me.cboTransportista.pRequerido = False
    Me.cboTransportista.Size = New System.Drawing.Size(176, 21)
    Me.cboTransportista.TabIndex = 106
    '
    'txtNumeroPlaca
    '
    Me.txtNumeroPlaca.Location = New System.Drawing.Point(112, 73)
    Me.txtNumeroPlaca.MaxLength = 16
    Me.txtNumeroPlaca.Name = "txtNumeroPlaca"
    Me.txtNumeroPlaca.Size = New System.Drawing.Size(176, 21)
    Me.txtNumeroPlaca.TabIndex = 5
    '
    'KryptonLabel20
    '
    Me.KryptonLabel20.Location = New System.Drawing.Point(315, 75)
    Me.KryptonLabel20.Name = "KryptonLabel20"
    Me.KryptonLabel20.Size = New System.Drawing.Size(40, 17)
    Me.KryptonLabel20.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel20.TabIndex = 105
    Me.KryptonLabel20.Text = "Fecha"
    Me.KryptonLabel20.Values.ExtraText = ""
    Me.KryptonLabel20.Values.Image = Nothing
    Me.KryptonLabel20.Values.Text = "Fecha"
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(645, 15)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(41, 17)
    Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel3.TabIndex = 103
    Me.KryptonLabel3.Text = "Planta"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Planta"
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(410, 73)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaInicio.TabIndex = 6
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(500, 75)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
    Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel4.TabIndex = 105
    Me.KryptonLabel4.Text = "Al"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Al"
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(526, 73)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaFin.TabIndex = 7
    '
    'ctlCliente
    '
    Me.ctlCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ctlCliente.BackColor = System.Drawing.Color.Transparent
    Me.ctlCliente.CCMPN = ""
    Me.ctlCliente.Location = New System.Drawing.Point(417, 40)
    Me.ctlCliente.Name = "ctlCliente"
    Me.ctlCliente.pAccesoPorUsuario = False
    Me.ctlCliente.pRequerido = False
    Me.ctlCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.ctlCliente.Size = New System.Drawing.Size(176, 21)
    Me.ctlCliente.TabIndex = 4
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(313, 15)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(49, 17)
    Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel1.TabIndex = 103
    Me.KryptonLabel1.Text = "División"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "División"
    '
    'KryptonLabel19
    '
    Me.KryptonLabel19.Location = New System.Drawing.Point(11, 15)
    Me.KryptonLabel19.Name = "KryptonLabel19"
    Me.KryptonLabel19.Size = New System.Drawing.Size(60, 17)
    Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel19.TabIndex = 103
    Me.KryptonLabel19.Text = "Compañía"
    Me.KryptonLabel19.Values.ExtraText = ""
    Me.KryptonLabel19.Values.Image = Nothing
    Me.KryptonLabel19.Values.Text = "Compañía"
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(11, 77)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(36, 17)
    Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel2.TabIndex = 105
    Me.KryptonLabel2.Text = "Placa"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Placa"
    '
    'cboPlanta
    '
    Me.cboPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPlanta.DropDownWidth = 121
    Me.cboPlanta.FormattingEnabled = False
    Me.cboPlanta.ItemHeight = 13
    Me.cboPlanta.Location = New System.Drawing.Point(689, 11)
    Me.cboPlanta.Name = "cboPlanta"
    Me.cboPlanta.Size = New System.Drawing.Size(171, 21)
    Me.cboPlanta.TabIndex = 2
    '
    'cboDivision
    '
    Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDivision.DropDownWidth = 121
    Me.cboDivision.FormattingEnabled = False
    Me.cboDivision.ItemHeight = 13
    Me.cboDivision.Location = New System.Drawing.Point(417, 11)
    Me.cboDivision.Name = "cboDivision"
    Me.cboDivision.Size = New System.Drawing.Size(176, 21)
    Me.cboDivision.TabIndex = 1
    '
    'cboCia
    '
    Me.cboCia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCia.DropDownWidth = 121
    Me.cboCia.FormattingEnabled = False
    Me.cboCia.ItemHeight = 13
    Me.cboCia.Location = New System.Drawing.Point(112, 11)
    Me.cboCia.Name = "cboCia"
    Me.cboCia.Size = New System.Drawing.Size(176, 21)
    Me.cboCia.TabIndex = 0
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(313, 44)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
    Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel5.TabIndex = 105
    Me.KryptonLabel5.Text = "Cliente"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Cliente"
    '
    'KryptonLabel6
    '
    Me.KryptonLabel6.Location = New System.Drawing.Point(11, 44)
    Me.KryptonLabel6.Name = "KryptonLabel6"
    Me.KryptonLabel6.Size = New System.Drawing.Size(76, 17)
    Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel6.TabIndex = 105
    Me.KryptonLabel6.Text = "Transportista"
    Me.KryptonLabel6.Values.ExtraText = ""
    Me.KryptonLabel6.Values.Image = Nothing
    Me.KryptonLabel6.Values.Text = "Transportista"
    '
    'frmCRepMensual
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1051, 613)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmCRepMensual"
    Me.Text = "Reporte Mensual"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.Panel.ResumeLayout(False)
    Me.HeaderGroupTabs.Panel.PerformLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ctlCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboCia As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtNumeroPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GUIACLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORDENCOMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADBULTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESOBRUTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VOLUMEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MERCADERIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACOPLADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHASOLICITUDUNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAASIGNACIONUNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHASALIDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHALLEGADA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHASOLICITADADESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHOFER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOTRANSPORTISTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTEFLETE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTESERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01



  
End Class
