<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarVehiculo
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarVehiculo))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.PanelBuscar = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.V_NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_CTPCRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_TCMCRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_SESTCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGUIMIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_GPSLAT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_GPSLON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_FECGPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.V_HORGPS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UBICACION = New System.Windows.Forms.DataGridViewImageColumn
        Me.V_CTITRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnProcesarConsulta = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSeparador = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ctbTipoCarroceria = New CodeTextBox.CodeTextBox
        Me.ctbTransportista = New CodeTextBox.CodeTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroPlaca = New SOLMIN_ST.TextField
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.PanelBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelBuscar.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBuscar.Panel.SuspendLayout()
        Me.PanelBuscar.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.PanelBuscar)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(822, 422)
        Me.KryptonPanel.TabIndex = 0
        '
        'PanelBuscar
        '
        Me.PanelBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBuscar.Location = New System.Drawing.Point(0, 60)
        Me.PanelBuscar.Name = "PanelBuscar"
        '
        'PanelBuscar.Panel
        '
        Me.PanelBuscar.Panel.Controls.Add(Me.gwdDatos)
        Me.PanelBuscar.Size = New System.Drawing.Size(822, 362)
        Me.PanelBuscar.TabIndex = 8
        Me.PanelBuscar.ValuesPrimary.Description = ""
        Me.PanelBuscar.ValuesPrimary.Heading = ""
        Me.PanelBuscar.ValuesPrimary.Image = Nothing
        Me.PanelBuscar.ValuesSecondary.Description = ""
        Me.PanelBuscar.ValuesSecondary.Heading = ""
        Me.PanelBuscar.ValuesSecondary.Image = Nothing
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.AllowUserToResizeRows = False
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.V_NPLCUN, Me.V_CTPCRA, Me.V_TCMCRA, Me.V_NRUCTR, Me.V_TCMTRT, Me.V_CTRSPT, Me.V_SESTCM, Me.SEGUIMIENTO, Me.V_GPSLAT, Me.V_GPSLON, Me.V_FECGPS, Me.V_HORGPS, Me.UBICACION, Me.V_CTITRA})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersVisible = False
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(820, 354)
        Me.gwdDatos.StandardTab = True
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 8
        '
        'V_NPLCUN
        '
        Me.V_NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.V_NPLCUN.DataPropertyName = "NPLCUN"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.V_NPLCUN.DefaultCellStyle = DataGridViewCellStyle13
        Me.V_NPLCUN.HeaderText = "N° Placa"
        Me.V_NPLCUN.MaxInputLength = 100
        Me.V_NPLCUN.Name = "V_NPLCUN"
        Me.V_NPLCUN.ReadOnly = True
        Me.V_NPLCUN.Width = 78
        '
        'V_CTPCRA
        '
        Me.V_CTPCRA.DataPropertyName = "CTPCRA"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.V_CTPCRA.DefaultCellStyle = DataGridViewCellStyle14
        Me.V_CTPCRA.HeaderText = "Cod. Tipo Carroceria"
        Me.V_CTPCRA.MaxInputLength = 100
        Me.V_CTPCRA.Name = "V_CTPCRA"
        Me.V_CTPCRA.ReadOnly = True
        Me.V_CTPCRA.Visible = False
        '
        'V_TCMCRA
        '
        Me.V_TCMCRA.DataPropertyName = "TCMCRA"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.V_TCMCRA.DefaultCellStyle = DataGridViewCellStyle15
        Me.V_TCMCRA.HeaderText = "Tipo Carroceria"
        Me.V_TCMCRA.MaxInputLength = 250
        Me.V_TCMCRA.Name = "V_TCMCRA"
        Me.V_TCMCRA.ReadOnly = True
        '
        'V_NRUCTR
        '
        Me.V_NRUCTR.DataPropertyName = "NRUCTR"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.V_NRUCTR.DefaultCellStyle = DataGridViewCellStyle16
        Me.V_NRUCTR.HeaderText = "Compañia Transporte"
        Me.V_NRUCTR.MaxInputLength = 100
        Me.V_NRUCTR.Name = "V_NRUCTR"
        Me.V_NRUCTR.ReadOnly = True
        Me.V_NRUCTR.Visible = False
        '
        'V_TCMTRT
        '
        Me.V_TCMTRT.DataPropertyName = "TCMTRT"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.V_TCMTRT.DefaultCellStyle = DataGridViewCellStyle17
        Me.V_TCMTRT.HeaderText = "Nombre Cia. Transporte"
        Me.V_TCMTRT.MaxInputLength = 100
        Me.V_TCMTRT.Name = "V_TCMTRT"
        Me.V_TCMTRT.ReadOnly = True
        '
        'V_CTRSPT
        '
        Me.V_CTRSPT.DataPropertyName = "CTRSPT"
        Me.V_CTRSPT.HeaderText = "Codigo Compañia"
        Me.V_CTRSPT.MaxInputLength = 100
        Me.V_CTRSPT.Name = "V_CTRSPT"
        Me.V_CTRSPT.ReadOnly = True
        Me.V_CTRSPT.Visible = False
        '
        'V_SESTCM
        '
        Me.V_SESTCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.V_SESTCM.DataPropertyName = "SESTCM"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.V_SESTCM.DefaultCellStyle = DataGridViewCellStyle18
        Me.V_SESTCM.HeaderText = "Estado"
        Me.V_SESTCM.MaxInputLength = 100
        Me.V_SESTCM.Name = "V_SESTCM"
        Me.V_SESTCM.ReadOnly = True
        Me.V_SESTCM.Width = 69
        '
        'SEGUIMIENTO
        '
        Me.SEGUIMIENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEGUIMIENTO.HeaderText = "Seguimiento"
        Me.SEGUIMIENTO.Name = "SEGUIMIENTO"
        Me.SEGUIMIENTO.ReadOnly = True
        Me.SEGUIMIENTO.Width = 94
        '
        'V_GPSLAT
        '
        Me.V_GPSLAT.DataPropertyName = "GPSLAT"
        Me.V_GPSLAT.HeaderText = "Latitud"
        Me.V_GPSLAT.Name = "V_GPSLAT"
        Me.V_GPSLAT.ReadOnly = True
        Me.V_GPSLAT.Visible = False
        '
        'V_GPSLON
        '
        Me.V_GPSLON.DataPropertyName = "GPSLON"
        Me.V_GPSLON.HeaderText = "Longitud"
        Me.V_GPSLON.Name = "V_GPSLON"
        Me.V_GPSLON.ReadOnly = True
        Me.V_GPSLON.Visible = False
        '
        'V_FECGPS
        '
        Me.V_FECGPS.DataPropertyName = "FECGPS"
        Me.V_FECGPS.HeaderText = "Fecha GPS"
        Me.V_FECGPS.Name = "V_FECGPS"
        Me.V_FECGPS.ReadOnly = True
        Me.V_FECGPS.Visible = False
        '
        'V_HORGPS
        '
        Me.V_HORGPS.DataPropertyName = "HORGPS"
        Me.V_HORGPS.HeaderText = "Hora GPS"
        Me.V_HORGPS.Name = "V_HORGPS"
        Me.V_HORGPS.ReadOnly = True
        Me.V_HORGPS.Visible = False
        '
        'UBICACION
        '
        Me.UBICACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBICACION.HeaderText = "Ubicación GPS"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        Me.UBICACION.Width = 84
        '
        'V_CTITRA
        '
        Me.V_CTITRA.DataPropertyName = "CTITRA"
        Me.V_CTITRA.HeaderText = "Config. Vehicular"
        Me.V_CTITRA.MaxInputLength = 100
        Me.V_CTITRA.Name = "V_CTITRA"
        Me.V_CTITRA.ReadOnly = True
        Me.V_CTITRA.Visible = False
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnProcesarConsulta, Me.btnSeparador, Me.btnSalir})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbTipoCarroceria)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbTransportista)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtNroPlaca)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel20)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel17)
        Me.PanelFiltros.Panel.Controls.Add(Me.btn_cerrar)
        Me.PanelFiltros.Size = New System.Drawing.Size(822, 60)
        Me.PanelFiltros.TabIndex = 7
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = ""
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnProcesarConsulta
        '
        Me.btnProcesarConsulta.ExtraText = ""
        Me.btnProcesarConsulta.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnProcesarConsulta.Image = CType(resources.GetObject("btnProcesarConsulta.Image"), System.Drawing.Image)
        Me.btnProcesarConsulta.Text = "Busqueda"
        Me.btnProcesarConsulta.ToolTipImage = Nothing
        Me.btnProcesarConsulta.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'btnSeparador
        '
        Me.btnSeparador.ExtraText = ""
        Me.btnSeparador.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSeparador.Image = Nothing
        Me.btnSeparador.Text = ".    "
        Me.btnSeparador.ToolTipImage = Nothing
        Me.btnSeparador.UniqueName = "E9DCB32270384B8CE9DCB32270384B8C"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "096C58D1AE4B4989096C58D1AE4B4989"
        '
        'ctbTipoCarroceria
        '
        Me.ctbTipoCarroceria.Codigo = ""
        Me.ctbTipoCarroceria.ControlHeight = 23
        Me.ctbTipoCarroceria.ControlImage = True
        Me.ctbTipoCarroceria.ControlReadOnly = False
        Me.ctbTipoCarroceria.Descripcion = ""
        Me.ctbTipoCarroceria.DisplayColumnVisible = True
        Me.ctbTipoCarroceria.DisplayMember = ""
        Me.ctbTipoCarroceria.KeyColumnWidth = 100
        Me.ctbTipoCarroceria.KeyField = ""
        Me.ctbTipoCarroceria.KeySearch = True
        Me.ctbTipoCarroceria.Location = New System.Drawing.Point(224, 4)
        Me.ctbTipoCarroceria.Name = "ctbTipoCarroceria"
        Me.ctbTipoCarroceria.Size = New System.Drawing.Size(240, 23)
        Me.ctbTipoCarroceria.TabIndex = 2
        Me.ctbTipoCarroceria.TabStop = True
        Me.ctbTipoCarroceria.TextBackColor = System.Drawing.Color.Empty
        Me.ctbTipoCarroceria.TextForeColor = System.Drawing.Color.Empty
        Me.ctbTipoCarroceria.ValueColumnVisible = True
        Me.ctbTipoCarroceria.ValueColumnWidth = 600
        Me.ctbTipoCarroceria.ValueField = ""
        Me.ctbTipoCarroceria.ValueMember = ""
        Me.ctbTipoCarroceria.ValueSearch = True
        '
        'ctbTransportista
        '
        Me.ctbTransportista.Codigo = ""
        Me.ctbTransportista.ControlHeight = 23
        Me.ctbTransportista.ControlImage = True
        Me.ctbTransportista.ControlReadOnly = False
        Me.ctbTransportista.Descripcion = ""
        Me.ctbTransportista.DisplayColumnVisible = True
        Me.ctbTransportista.DisplayMember = ""
        Me.ctbTransportista.KeyColumnWidth = 100
        Me.ctbTransportista.KeyField = ""
        Me.ctbTransportista.KeySearch = True
        Me.ctbTransportista.Location = New System.Drawing.Point(584, 4)
        Me.ctbTransportista.Name = "ctbTransportista"
        Me.ctbTransportista.Size = New System.Drawing.Size(230, 23)
        Me.ctbTransportista.TabIndex = 3
        Me.ctbTransportista.TabStop = True
        Me.ctbTransportista.TextBackColor = System.Drawing.Color.Empty
        Me.ctbTransportista.TextForeColor = System.Drawing.Color.Empty
        Me.ctbTransportista.ValueColumnVisible = True
        Me.ctbTransportista.ValueColumnWidth = 600
        Me.ctbTransportista.ValueField = ""
        Me.ctbTransportista.ValueMember = ""
        Me.ctbTransportista.ValueSearch = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(144, 6)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(79, 16)
        Me.KryptonLabel1.TabIndex = 100
        Me.KryptonLabel1.TabStop = False
        Me.KryptonLabel1.Text = "Tipo Vehiculo"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tipo Vehiculo"
        '
        'txtNroPlaca
        '
        Me.txtNroPlaca.Location = New System.Drawing.Point(59, 5)
        Me.txtNroPlaca.MaxLength = 6
        Me.txtNroPlaca.Name = "txtNroPlaca"
        Me.txtNroPlaca.Size = New System.Drawing.Size(69, 19)
        Me.txtNroPlaca.TabIndex = 1
        Me.txtNroPlaca.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(465, 6)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(120, 16)
        Me.KryptonLabel20.TabIndex = 100
        Me.KryptonLabel20.TabStop = False
        Me.KryptonLabel20.Text = "Compañia Transporte"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Compañia Transporte"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(4, 6)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(54, 16)
        Me.KryptonLabel17.TabIndex = 100
        Me.KryptonLabel17.TabStop = False
        Me.KryptonLabel17.Text = "N° Placa"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "N° Placa"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cerrar.Location = New System.Drawing.Point(184, 8)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(16, 16)
        Me.btn_cerrar.TabIndex = 103
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'frmBuscarVehiculo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_cerrar
        Me.ClientSize = New System.Drawing.Size(822, 422)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Vehículos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.PanelBuscar.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscar.Panel.ResumeLayout(False)
        CType(Me.PanelBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBuscar.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
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
  Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents btnProcesarConsulta As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtNroPlaca As SOLMIN_ST.TextField
  Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btn_cerrar As System.Windows.Forms.Button
  Friend WithEvents PanelBuscar As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents ctbTipoCarroceria As CodeTextBox.CodeTextBox
  Friend WithEvents ctbTransportista As CodeTextBox.CodeTextBox
  Friend WithEvents btnSeparador As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents V_NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_CTPCRA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_TCMCRA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_SESTCM As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SEGUIMIENTO As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_GPSLAT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_GPSLON As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_FECGPS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents V_HORGPS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents UBICACION As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents V_CTITRA As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
