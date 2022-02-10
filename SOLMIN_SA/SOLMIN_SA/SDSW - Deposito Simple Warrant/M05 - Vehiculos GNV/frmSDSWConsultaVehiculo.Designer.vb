<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSAWConsultaVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSAWConsultaVehiculo))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgConsulta = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsnCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsnReporte = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgvVehiculos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCHSVHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMDLODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMCMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTINODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMAUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECESTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSLMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ORIGENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SPRGINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstVehiculos = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.VNCHSVH = New System.Data.DataColumn
        Me.VTMARCA = New System.Data.DataColumn
        Me.VTMDLO = New System.Data.DataColumn
        Me.VCALMCM = New System.Data.DataColumn
        Me.VCALMAU = New System.Data.DataColumn
        Me.VFINMOV = New System.Data.DataColumn
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.hgBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaI = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaF = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtvin = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblestado = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgConsulta.Panel.SuspendLayout()
        Me.hgConsulta.SuspendLayout()
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgBusqueda.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgBusqueda.Panel.SuspendLayout()
        Me.hgBusqueda.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgConsulta)
        Me.KryptonPanel.Controls.Add(Me.hgBusqueda)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(811, 398)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgConsulta
        '
        Me.hgConsulta.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsnCerrar, Me.bsnReporte})
        Me.hgConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgConsulta.Location = New System.Drawing.Point(0, 94)
        Me.hgConsulta.Name = "hgConsulta"
        '
        'hgConsulta.Panel
        '
        Me.hgConsulta.Panel.Controls.Add(Me.dgvVehiculos)
        Me.hgConsulta.Size = New System.Drawing.Size(811, 304)
        Me.hgConsulta.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgConsulta.TabIndex = 1
        Me.hgConsulta.Text = "Consulta"
        Me.hgConsulta.ValuesPrimary.Description = ""
        Me.hgConsulta.ValuesPrimary.Heading = "Consulta"
        Me.hgConsulta.ValuesPrimary.Image = CType(resources.GetObject("hgConsulta.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgConsulta.ValuesSecondary.Description = ""
        Me.hgConsulta.ValuesSecondary.Heading = ""
        Me.hgConsulta.ValuesSecondary.Image = Nothing
        '
        'bsnCerrar
        '
        Me.bsnCerrar.ExtraText = ""
        Me.bsnCerrar.Image = CType(resources.GetObject("bsnCerrar.Image"), System.Drawing.Image)
        Me.bsnCerrar.Text = "Cerrar"
        Me.bsnCerrar.ToolTipImage = Nothing
        Me.bsnCerrar.UniqueName = "3254728CBB3C48193254728CBB3C4819"
        '
        'bsnReporte
        '
        Me.bsnReporte.ExtraText = ""
        Me.bsnReporte.Image = CType(resources.GetObject("bsnReporte.Image"), System.Drawing.Image)
        Me.bsnReporte.Text = "Reporte"
        Me.bsnReporte.ToolTipImage = Nothing
        Me.bsnReporte.UniqueName = "630EA39CA08042FA630EA39CA08042FA"
        '
        'dgvVehiculos
        '
        Me.dgvVehiculos.AllowUserToAddRows = False
        Me.dgvVehiculos.AllowUserToDeleteRows = False
        Me.dgvVehiculos.AllowUserToResizeRows = False
        Me.dgvVehiculos.AutoGenerateColumns = False
        Me.dgvVehiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCHSVHDataGridViewTextBoxColumn, Me.TMARCADataGridViewTextBoxColumn, Me.TMDLODataGridViewTextBoxColumn, Me.CALMCMDataGridViewTextBoxColumn, Me.DESTINODataGridViewTextBoxColumn, Me.CALMAUDataGridViewTextBoxColumn, Me.FECESTDataGridViewTextBoxColumn, Me.FINMOVDataGridViewTextBoxColumn, Me.FSLMOVDataGridViewTextBoxColumn, Me.ORIGENDataGridViewTextBoxColumn, Me.SPRGINDataGridViewTextBoxColumn})
        Me.dgvVehiculos.DataMember = "Vehiculo"
        Me.dgvVehiculos.DataSource = Me.dstVehiculos
        Me.dgvVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVehiculos.Location = New System.Drawing.Point(0, 0)
        Me.dgvVehiculos.MultiSelect = False
        Me.dgvVehiculos.Name = "dgvVehiculos"
        Me.dgvVehiculos.ReadOnly = True
        Me.dgvVehiculos.RowHeadersWidth = 20
        Me.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehiculos.Size = New System.Drawing.Size(809, 268)
        Me.dgvVehiculos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvVehiculos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvVehiculos.TabIndex = 0
        '
        'NCHSVHDataGridViewTextBoxColumn
        '
        Me.NCHSVHDataGridViewTextBoxColumn.DataPropertyName = "NCHSVH"
        Me.NCHSVHDataGridViewTextBoxColumn.HeaderText = "VIN"
        Me.NCHSVHDataGridViewTextBoxColumn.Name = "NCHSVHDataGridViewTextBoxColumn"
        Me.NCHSVHDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.CALMCMDataGridViewTextBoxColumn.HeaderText = "Codigo Almacen"
        Me.CALMCMDataGridViewTextBoxColumn.Name = "CALMCMDataGridViewTextBoxColumn"
        Me.CALMCMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DESTINODataGridViewTextBoxColumn
        '
        Me.DESTINODataGridViewTextBoxColumn.DataPropertyName = "DESTINO"
        Me.DESTINODataGridViewTextBoxColumn.HeaderText = "Destino"
        Me.DESTINODataGridViewTextBoxColumn.Name = "DESTINODataGridViewTextBoxColumn"
        Me.DESTINODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CALMAUDataGridViewTextBoxColumn
        '
        Me.CALMAUDataGridViewTextBoxColumn.DataPropertyName = "CALMAU"
        Me.CALMAUDataGridViewTextBoxColumn.HeaderText = "CALMAU"
        Me.CALMAUDataGridViewTextBoxColumn.Name = "CALMAUDataGridViewTextBoxColumn"
        Me.CALMAUDataGridViewTextBoxColumn.ReadOnly = True
        Me.CALMAUDataGridViewTextBoxColumn.Visible = False
        '
        'FECESTDataGridViewTextBoxColumn
        '
        Me.FECESTDataGridViewTextBoxColumn.DataPropertyName = "FECEST"
        Me.FECESTDataGridViewTextBoxColumn.HeaderText = "Fecha Estimada"
        Me.FECESTDataGridViewTextBoxColumn.Name = "FECESTDataGridViewTextBoxColumn"
        Me.FECESTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FINMOVDataGridViewTextBoxColumn
        '
        Me.FINMOVDataGridViewTextBoxColumn.DataPropertyName = "FINMOV"
        Me.FINMOVDataGridViewTextBoxColumn.HeaderText = "Fecha Ingreso"
        Me.FINMOVDataGridViewTextBoxColumn.Name = "FINMOVDataGridViewTextBoxColumn"
        Me.FINMOVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FSLMOVDataGridViewTextBoxColumn
        '
        Me.FSLMOVDataGridViewTextBoxColumn.DataPropertyName = "FSLMOV"
        Me.FSLMOVDataGridViewTextBoxColumn.HeaderText = "Fecha Salida"
        Me.FSLMOVDataGridViewTextBoxColumn.Name = "FSLMOVDataGridViewTextBoxColumn"
        Me.FSLMOVDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ORIGENDataGridViewTextBoxColumn
        '
        Me.ORIGENDataGridViewTextBoxColumn.DataPropertyName = "ORIGEN"
        Me.ORIGENDataGridViewTextBoxColumn.HeaderText = "ORIGEN"
        Me.ORIGENDataGridViewTextBoxColumn.Name = "ORIGENDataGridViewTextBoxColumn"
        Me.ORIGENDataGridViewTextBoxColumn.ReadOnly = True
        Me.ORIGENDataGridViewTextBoxColumn.Visible = False
        '
        'SPRGINDataGridViewTextBoxColumn
        '
        Me.SPRGINDataGridViewTextBoxColumn.DataPropertyName = "SPRGIN"
        Me.SPRGINDataGridViewTextBoxColumn.HeaderText = "Flag"
        Me.SPRGINDataGridViewTextBoxColumn.Name = "SPRGINDataGridViewTextBoxColumn"
        Me.SPRGINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dstVehiculos
        '
        Me.dstVehiculos.DataSetName = "NewDataSet"
        Me.dstVehiculos.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.VNCHSVH, Me.VTMARCA, Me.VTMDLO, Me.VCALMCM, Me.VCALMAU, Me.VFINMOV, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
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
        'VFINMOV
        '
        Me.VFINMOV.Caption = "FINMOV"
        Me.VFINMOV.ColumnName = "FINMOV"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "ORIGEN"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "DESTINO"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FSLMOV"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FECEST"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "SPRGIN"
        '
        'hgBusqueda
        '
        Me.hgBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.hgBusqueda.Name = "hgBusqueda"
        '
        'hgBusqueda.Panel
        '
        Me.hgBusqueda.Panel.Controls.Add(Me.KryptonPanel1)
        Me.hgBusqueda.Panel.Controls.Add(Me.cboEstado)
        Me.hgBusqueda.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgBusqueda.Panel.Controls.Add(Me.txtvin)
        Me.hgBusqueda.Panel.Controls.Add(Me.btnActualizar)
        Me.hgBusqueda.Panel.Controls.Add(Me.lblestado)
        Me.hgBusqueda.Size = New System.Drawing.Size(811, 94)
        Me.hgBusqueda.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBusqueda.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgBusqueda.TabIndex = 0
        Me.hgBusqueda.Text = "Busqueda"
        Me.hgBusqueda.ValuesPrimary.Description = ""
        Me.hgBusqueda.ValuesPrimary.Heading = "Busqueda"
        Me.hgBusqueda.ValuesPrimary.Image = CType(resources.GetObject("hgBusqueda.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgBusqueda.ValuesSecondary.Description = ""
        Me.hgBusqueda.ValuesSecondary.Heading = ""
        Me.hgBusqueda.ValuesSecondary.Image = Nothing
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dtpInicio)
        Me.KryptonPanel1.Controls.Add(Me.dtpFinal)
        Me.KryptonPanel1.Controls.Add(Me.lblFechaI)
        Me.KryptonPanel1.Controls.Add(Me.lblFechaF)
        Me.KryptonPanel1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(181, 64)
        Me.KryptonPanel1.TabIndex = 27
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarMonthBackground = System.Drawing.SystemColors.Menu
        Me.dtpInicio.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop
        Me.dtpInicio.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLight
        Me.dtpInicio.CustomFormat = ""
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(83, 9)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpInicio.TabIndex = 1
        Me.dtpInicio.Value = New Date(2010, 5, 10, 8, 40, 0, 0)
        '
        'dtpFinal
        '
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFinal.Location = New System.Drawing.Point(83, 37)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtpFinal.TabIndex = 2
        '
        'lblFechaI
        '
        Me.lblFechaI.Location = New System.Drawing.Point(3, 13)
        Me.lblFechaI.Name = "lblFechaI"
        Me.lblFechaI.Size = New System.Drawing.Size(71, 19)
        Me.lblFechaI.TabIndex = 1
        Me.lblFechaI.Text = "Fecha Inicio:"
        Me.lblFechaI.Values.ExtraText = ""
        Me.lblFechaI.Values.Image = Nothing
        Me.lblFechaI.Values.Text = "Fecha Inicio:"
        '
        'lblFechaF
        '
        Me.lblFechaF.Location = New System.Drawing.Point(4, 43)
        Me.lblFechaF.Name = "lblFechaF"
        Me.lblFechaF.Size = New System.Drawing.Size(68, 19)
        Me.lblFechaF.TabIndex = 2
        Me.lblFechaF.Text = "Fecha Final:"
        Me.lblFechaF.Values.ExtraText = ""
        Me.lblFechaF.Values.Image = Nothing
        Me.lblFechaF.Values.Text = "Fecha Final:"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownWidth = 85
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 13
        Me.cboEstado.Location = New System.Drawing.Point(250, 45)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(85, 21)
        Me.cboEstado.TabIndex = 4
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(374, 47)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(29, 19)
        Me.KryptonLabel1.TabIndex = 26
        Me.KryptonLabel1.Text = "Vin:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Vin:"
        '
        'txtvin
        '
        Me.txtvin.Location = New System.Drawing.Point(410, 47)
        Me.txtvin.Name = "txtvin"
        Me.txtvin.Size = New System.Drawing.Size(140, 21)
        Me.txtvin.TabIndex = 3
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnActualizar.Location = New System.Drawing.Point(726, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 55)
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
        'lblestado
        '
        Me.lblestado.Location = New System.Drawing.Point(204, 50)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(46, 19)
        Me.lblestado.TabIndex = 0
        Me.lblestado.Text = "Estado:"
        Me.lblestado.Values.ExtraText = ""
        Me.lblestado.Values.Image = Nothing
        Me.lblestado.Values.Text = "Estado:"
        '
        'frmSAWConsultaVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 398)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmSAWConsultaVehiculo"
        Me.Text = "Consulta Vehiculo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgConsulta.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.Panel.ResumeLayout(False)
        CType(Me.hgConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgConsulta.ResumeLayout(False)
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgBusqueda.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBusqueda.Panel.ResumeLayout(False)
        Me.hgBusqueda.Panel.PerformLayout()
        CType(Me.hgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgBusqueda.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents dgvVehiculos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents bsnCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblFechaF As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaI As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblestado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtvin As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents VFINMOV As System.Data.DataColumn
    Friend WithEvents VCALMAU As System.Data.DataColumn
    Friend WithEvents VCALMCM As System.Data.DataColumn
    Friend WithEvents VTMDLO As System.Data.DataColumn
    Friend WithEvents VTMARCA As System.Data.DataColumn
    Friend WithEvents VNCHSVH As System.Data.DataColumn
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents dstVehiculos As System.Data.DataSet
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents NCHSVHDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMARCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMDLODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMCMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTINODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMAUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECESTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSLMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SPRGINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsnReporte As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
End Class
