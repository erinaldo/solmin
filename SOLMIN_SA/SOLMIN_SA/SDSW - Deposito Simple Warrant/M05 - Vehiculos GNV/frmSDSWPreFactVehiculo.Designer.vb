<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWPreFactVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWPreFactVehiculo))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgConsulta = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaGrabar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaMarcar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaDesmarcar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgvPreFactura = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.NCHSVHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMDLODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMAUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDRALCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCDRMVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstVehiculos = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.VNCHSVH = New System.Data.DataColumn
        Me.VTMARCA = New System.Data.DataColumn
        Me.VTMDLO = New System.Data.DataColumn
        Me.VCALMCM = New System.Data.DataColumn
        Me.VCALMAU = New System.Data.DataColumn
        Me.VFCDRMV = New System.Data.DataColumn
        Me.VTDRALC = New System.Data.DataColumn
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.hgBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaF = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.lblFechaI = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgConsulta.Panel.SuspendLayout()
        Me.hgConsulta.SuspendLayout()
        CType(Me.dgvPreFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.hgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBusqueda.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgBusqueda.Panel.SuspendLayout()
        Me.hgBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgConsulta)
        Me.KryptonPanel.Controls.Add(Me.hgBusqueda)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(859, 414)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgConsulta
        '
        Me.hgConsulta.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaGrabar, Me.bsaMarcar, Me.bsaDesmarcar})
        Me.hgConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgConsulta.Location = New System.Drawing.Point(0, 94)
        Me.hgConsulta.Name = "hgConsulta"
        '
        'hgConsulta.Panel
        '
        Me.hgConsulta.Panel.Controls.Add(Me.dgvPreFactura)
        Me.hgConsulta.Panel.Controls.Add(Me.KryptonPanel1)
        Me.hgConsulta.Size = New System.Drawing.Size(859, 320)
        Me.hgConsulta.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgConsulta.TabIndex = 1
        Me.hgConsulta.Text = "Lista"
        Me.hgConsulta.ValuesPrimary.Description = ""
        Me.hgConsulta.ValuesPrimary.Heading = "Lista"
        '     Me.hgConsulta.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.clipboard_list
        Me.hgConsulta.ValuesSecondary.Description = ""
        Me.hgConsulta.ValuesSecondary.Heading = ""
        Me.hgConsulta.ValuesSecondary.Image = Nothing
        '
        'bsaGrabar
        '
        Me.bsaGrabar.ExtraText = ""
        Me.bsaGrabar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.bsaGrabar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaGrabar.Text = "Grabar"
        Me.bsaGrabar.ToolTipImage = Nothing
        Me.bsaGrabar.UniqueName = "737E0B349D7E4C5E737E0B349D7E4C5E"
        '
        'bsaMarcar
        '
        Me.bsaMarcar.ExtraText = ""
        '      Me.bsaMarcar.Image = Global.SOLMIN_SA.My.Resources.Resources._40px_Black_check_svg
        Me.bsaMarcar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaMarcar.Text = "Marcar"
        Me.bsaMarcar.ToolTipImage = Nothing
        Me.bsaMarcar.UniqueName = "A63ECE7BCE214FEBA63ECE7BCE214FEB"
        Me.bsaMarcar.Visible = False
        '
        'bsaDesmarcar
        '
        Me.bsaDesmarcar.ExtraText = ""
        '   Me.bsaDesmarcar.Image = Global.SOLMIN_SA.My.Resources.Resources.aspa
        Me.bsaDesmarcar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaDesmarcar.Text = "Desmarcar"
        Me.bsaDesmarcar.ToolTipImage = Nothing
        Me.bsaDesmarcar.UniqueName = "26E33EE54DCB409326E33EE54DCB4093"
        Me.bsaDesmarcar.Visible = False
        '
        'dgvPreFactura
        '
        Me.dgvPreFactura.AllowUserToAddRows = False
        Me.dgvPreFactura.AllowUserToDeleteRows = False
        Me.dgvPreFactura.AllowUserToResizeRows = False
        Me.dgvPreFactura.AutoGenerateColumns = False
        Me.dgvPreFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.NCHSVHDataGridViewTextBoxColumn, Me.TMARCADataGridViewTextBoxColumn, Me.TMDLODataGridViewTextBoxColumn, Me.CALMCMDataGridViewTextBoxColumn, Me.CALMAUDataGridViewTextBoxColumn, Me.TDRALCDataGridViewTextBoxColumn, Me.FCDRMVDataGridViewTextBoxColumn})
        Me.dgvPreFactura.DataMember = "Vehiculo"
        Me.dgvPreFactura.DataSource = Me.dstVehiculos
        Me.dgvPreFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPreFactura.Location = New System.Drawing.Point(0, 0)
        Me.dgvPreFactura.MultiSelect = False
        Me.dgvPreFactura.Name = "dgvPreFactura"
        Me.dgvPreFactura.ReadOnly = True
        Me.dgvPreFactura.RowHeadersWidth = 20
        Me.dgvPreFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPreFactura.Size = New System.Drawing.Size(857, 264)
        Me.dgvPreFactura.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvPreFactura.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgvPreFactura.TabIndex = 2
        '
        'CHK
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.CHK.DefaultCellStyle = DataGridViewCellStyle1
        Me.CHK.FalseValue = Nothing
        Me.CHK.HeaderText = "Chk"
        Me.CHK.IndeterminateValue = Nothing
        Me.CHK.Name = "CHK"
        Me.CHK.ReadOnly = True
        Me.CHK.TrueValue = Nothing
        Me.CHK.Visible = False
        '
        'NCHSVHDataGridViewTextBoxColumn
        '
        Me.NCHSVHDataGridViewTextBoxColumn.DataPropertyName = "NCHSVH"
        Me.NCHSVHDataGridViewTextBoxColumn.HeaderText = "VIN"
        Me.NCHSVHDataGridViewTextBoxColumn.Name = "NCHSVHDataGridViewTextBoxColumn"
        Me.NCHSVHDataGridViewTextBoxColumn.ReadOnly = True
        Me.NCHSVHDataGridViewTextBoxColumn.Width = 200
        '
        'TMARCADataGridViewTextBoxColumn
        '
        Me.TMARCADataGridViewTextBoxColumn.DataPropertyName = "TMARCA"
        Me.TMARCADataGridViewTextBoxColumn.HeaderText = "TMARCA"
        Me.TMARCADataGridViewTextBoxColumn.Name = "TMARCADataGridViewTextBoxColumn"
        Me.TMARCADataGridViewTextBoxColumn.ReadOnly = True
        Me.TMARCADataGridViewTextBoxColumn.Visible = False
        '
        'TMDLODataGridViewTextBoxColumn
        '
        Me.TMDLODataGridViewTextBoxColumn.DataPropertyName = "TMDLO"
        Me.TMDLODataGridViewTextBoxColumn.HeaderText = "TMDLO"
        Me.TMDLODataGridViewTextBoxColumn.Name = "TMDLODataGridViewTextBoxColumn"
        Me.TMDLODataGridViewTextBoxColumn.ReadOnly = True
        Me.TMDLODataGridViewTextBoxColumn.Visible = False
        '
        'CALMCMDataGridViewTextBoxColumn
        '
        Me.CALMCMDataGridViewTextBoxColumn.DataPropertyName = "CALMCM"
        Me.CALMCMDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CALMCMDataGridViewTextBoxColumn.Name = "CALMCMDataGridViewTextBoxColumn"
        Me.CALMCMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CALMAUDataGridViewTextBoxColumn
        '
        Me.CALMAUDataGridViewTextBoxColumn.DataPropertyName = "CALMAU"
        Me.CALMAUDataGridViewTextBoxColumn.HeaderText = "CALMAU"
        Me.CALMAUDataGridViewTextBoxColumn.Name = "CALMAUDataGridViewTextBoxColumn"
        Me.CALMAUDataGridViewTextBoxColumn.ReadOnly = True
        Me.CALMAUDataGridViewTextBoxColumn.Visible = False
        '
        'TDRALCDataGridViewTextBoxColumn
        '
        Me.TDRALCDataGridViewTextBoxColumn.DataPropertyName = "TDRALC"
        Me.TDRALCDataGridViewTextBoxColumn.HeaderText = "Almacen"
        Me.TDRALCDataGridViewTextBoxColumn.Name = "TDRALCDataGridViewTextBoxColumn"
        Me.TDRALCDataGridViewTextBoxColumn.ReadOnly = True
        Me.TDRALCDataGridViewTextBoxColumn.Width = 300
        '
        'FCDRMVDataGridViewTextBoxColumn
        '
        Me.FCDRMVDataGridViewTextBoxColumn.DataPropertyName = "FCDRMV"
        Me.FCDRMVDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FCDRMVDataGridViewTextBoxColumn.Name = "FCDRMVDataGridViewTextBoxColumn"
        Me.FCDRMVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dstVehiculos
        '
        Me.dstVehiculos.DataSetName = "NewDataSet"
        Me.dstVehiculos.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.VNCHSVH, Me.VTMARCA, Me.VTMDLO, Me.VCALMCM, Me.VCALMAU, Me.VFCDRMV, Me.VTDRALC})
        Me.DataTable1.TableName = "Vehiculo"
        '
        'VNCHSVH
        '
        Me.VNCHSVH.ColumnName = "NCHSVH"
        '
        'VTMARCA
        '
        Me.VTMARCA.ColumnName = "TMARCA"
        '
        'VTMDLO
        '
        Me.VTMDLO.ColumnName = "TMDLO"
        '
        'VCALMCM
        '
        Me.VCALMCM.ColumnName = "CALMCM"
        '
        'VCALMAU
        '
        Me.VCALMAU.ColumnName = "CALMAU"
        '
        'VFCDRMV
        '
        Me.VFCDRMV.Caption = "FCDRMV"
        Me.VFCDRMV.ColumnName = "FCDRMV"
        '
        'VTDRALC
        '
        Me.VTDRALC.ColumnName = "TDRALC"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.lblTotal)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 264)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(857, 23)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(121, 4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 19)
        Me.KryptonLabel7.TabIndex = 2
        Me.KryptonLabel7.Text = "Registros"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Registros"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(86, 19)
        Me.KryptonLabel6.TabIndex = 1
        Me.KryptonLabel6.Text = "Se encontrarón"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Se encontrarón"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(96, 4)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 19)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "000"
        Me.lblTotal.Values.ExtraText = ""
        Me.lblTotal.Values.Image = Nothing
        Me.lblTotal.Values.Text = "000"
        '
        'hgBusqueda
        '
        Me.hgBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.hgBusqueda.Name = "hgBusqueda"
        '
        'hgBusqueda.Panel
        '
        Me.hgBusqueda.Panel.Controls.Add(Me.dtpFinal)
        Me.hgBusqueda.Panel.Controls.Add(Me.lblFechaF)
        Me.hgBusqueda.Panel.Controls.Add(Me.txtCliente)
        Me.hgBusqueda.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgBusqueda.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgBusqueda.Panel.Controls.Add(Me.dtpInicio)
        Me.hgBusqueda.Panel.Controls.Add(Me.lblFechaI)
        Me.hgBusqueda.Panel.Controls.Add(Me.btnActualizar)
        Me.hgBusqueda.Size = New System.Drawing.Size(859, 94)
        Me.hgBusqueda.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBusqueda.TabIndex = 0
        Me.hgBusqueda.Text = "Consulta"
        Me.hgBusqueda.ValuesPrimary.Description = ""
        Me.hgBusqueda.ValuesPrimary.Heading = "Consulta"
        'Me.hgBusqueda.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.ticket_pencil
        Me.hgBusqueda.ValuesSecondary.Description = ""
        Me.hgBusqueda.ValuesSecondary.Heading = ""
        Me.hgBusqueda.ValuesSecondary.Image = Nothing
        '
        'dtpFinal
        '
        Me.dtpFinal.CustomFormat = ""
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(290, 40)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtpFinal.TabIndex = 32
        Me.dtpFinal.Value = New Date(2010, 5, 10, 8, 40, 0, 0)
        '
        'lblFechaF
        '
        Me.lblFechaF.Location = New System.Drawing.Point(211, 44)
        Me.lblFechaF.Name = "lblFechaF"
        Me.lblFechaF.Size = New System.Drawing.Size(68, 19)
        Me.lblFechaF.TabIndex = 33
        Me.lblFechaF.Text = "Fecha Final:"
        Me.lblFechaF.Values.ExtraText = ""
        Me.lblFechaF.Values.Image = Nothing
        Me.lblFechaF.Values.Text = "Fecha Final:"
        '
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(100, 13)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 1
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "AAA4BECF6E674984AAA4BECF6E674984"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(14, 16)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel3.TabIndex = 29
        Me.KryptonLabel3.Text = "Cliente : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Cliente : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(233, 18)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(56, 19)
        Me.KryptonLabel2.TabIndex = 28
        Me.KryptonLabel2.Text = "Almacen:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Almacen:"
        '
        'dtpInicio
        '
        Me.dtpInicio.CustomFormat = ""
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(100, 40)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpInicio.TabIndex = 3
        Me.dtpInicio.Value = New Date(2010, 5, 10, 8, 40, 0, 0)
        '
        'lblFechaI
        '
        Me.lblFechaI.Location = New System.Drawing.Point(16, 44)
        Me.lblFechaI.Name = "lblFechaI"
        Me.lblFechaI.Size = New System.Drawing.Size(71, 19)
        Me.lblFechaI.TabIndex = 24
        Me.lblFechaI.Text = "Fecha Inicio:"
        Me.lblFechaI.Values.ExtraText = ""
        Me.lblFechaI.Values.Image = Nothing
        Me.lblFechaI.Values.Text = "Fecha Inicio:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnActualizar.Location = New System.Drawing.Point(774, 3)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 61)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'frmPreFactVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 414)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmPreFactVehiculo"
        Me.Text = "Generacion Pre - Factura"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.Panel.ResumeLayout(False)
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.ResumeLayout(False)
        CType(Me.dgvPreFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.hgBusqueda.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBusqueda.Panel.ResumeLayout(False)
        Me.hgBusqueda.Panel.PerformLayout()
        CType(Me.hgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBusqueda.ResumeLayout(False)
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
    Friend WithEvents hgConsulta As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgBusqueda As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaGrabar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaMarcar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaDesmarcar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaI As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dstVehiculos As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents VNCHSVH As System.Data.DataColumn
    Friend WithEvents VTMARCA As System.Data.DataColumn
    Friend WithEvents VTMDLO As System.Data.DataColumn
    Friend WithEvents VCALMCM As System.Data.DataColumn
    Friend WithEvents VCALMAU As System.Data.DataColumn
    Friend WithEvents VFCDRMV As System.Data.DataColumn
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgvPreFactura As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents VTDRALC As System.Data.DataColumn
    Friend WithEvents CHK As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NCHSVHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMDLODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMAUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRALCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCDRMVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaF As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
