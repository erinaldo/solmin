<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleBultoDia
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HGDetalle = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.dtgDetalleBultos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.HGInformacion = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtGuiaProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblGuiaProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.lblFecha = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SEL = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Me.CREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NSEQIN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.FREFFW = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TCMZNA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QSLCNB = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HGDetalle.Panel.SuspendLayout()
    Me.HGDetalle.SuspendLayout()
    CType(Me.dtgDetalleBultos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HGInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HGInformacion.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HGInformacion.Panel.SuspendLayout()
    Me.HGInformacion.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HGDetalle)
    Me.KryptonPanel.Controls.Add(Me.HGInformacion)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1035, 470)
    Me.KryptonPanel.TabIndex = 0
    '
    'HGDetalle
    '
    Me.HGDetalle.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar, Me.btnProcesar, Me.btnSalir})
    Me.HGDetalle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HGDetalle.HeaderVisibleSecondary = False
    Me.HGDetalle.Location = New System.Drawing.Point(0, 60)
    Me.HGDetalle.Name = "HGDetalle"
    '
    'HGDetalle.Panel
    '
    Me.HGDetalle.Panel.Controls.Add(Me.dtgDetalleBultos)
    Me.HGDetalle.Size = New System.Drawing.Size(1035, 410)
    Me.HGDetalle.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.HGDetalle.TabIndex = 1
    Me.HGDetalle.Text = "Detalles"
    Me.HGDetalle.ValuesPrimary.Description = ""
    Me.HGDetalle.ValuesPrimary.Heading = "Detalles"
    Me.HGDetalle.ValuesPrimary.Image = Nothing
    Me.HGDetalle.ValuesSecondary.Description = ""
    Me.HGDetalle.ValuesSecondary.Heading = "Description"
    Me.HGDetalle.ValuesSecondary.Image = Nothing
    '
    'btnBuscar
    '
    Me.btnBuscar.ExtraText = ""
    Me.btnBuscar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.search
    Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.ToolTipImage = Nothing
    Me.btnBuscar.UniqueName = "4399C34B6A3748DE4399C34B6A3748DE"
    '
    'btnProcesar
    '
    Me.btnProcesar.ExtraText = ""
    Me.btnProcesar.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_ok
    Me.btnProcesar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.btnProcesar.Text = "Procesar"
    Me.btnProcesar.ToolTipImage = Nothing
    Me.btnProcesar.UniqueName = "EF2378936C374870EF2378936C374870"
    '
    'btnSalir
    '
    Me.btnSalir.ExtraText = ""
    Me.btnSalir.Image = Global.CTL_GUIA_DE_TRANSPORTISTA.My.Resources.Resources.button_cancel
    Me.btnSalir.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.NavigatorStack
    Me.btnSalir.Text = "Cancelar"
    Me.btnSalir.ToolTipImage = Nothing
    Me.btnSalir.UniqueName = "163CEB874C0E47F6163CEB874C0E47F6"
    '
    'dtgDetalleBultos
    '
    Me.dtgDetalleBultos.AllowUserToAddRows = False
    Me.dtgDetalleBultos.AllowUserToDeleteRows = False
    Me.dtgDetalleBultos.ColumnHeadersHeight = 30
    Me.dtgDetalleBultos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SEL, Me.CREFFW, Me.NSEQIN, Me.FREFFW, Me.TCMZNA, Me.NORCML, Me.NRITOC, Me.TDITES, Me.QSLCNB})
    Me.dtgDetalleBultos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgDetalleBultos.Location = New System.Drawing.Point(0, 0)
    Me.dtgDetalleBultos.Name = "dtgDetalleBultos"
    Me.dtgDetalleBultos.RowHeadersVisible = False
    Me.dtgDetalleBultos.Size = New System.Drawing.Size(1033, 377)
    Me.dtgDetalleBultos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgDetalleBultos.TabIndex = 0
    '
    'HGInformacion
    '
    Me.HGInformacion.Dock = System.Windows.Forms.DockStyle.Top
    Me.HGInformacion.HeaderVisibleSecondary = False
    Me.HGInformacion.Location = New System.Drawing.Point(0, 0)
    Me.HGInformacion.Name = "HGInformacion"
    '
    'HGInformacion.Panel
    '
    Me.HGInformacion.Panel.Controls.Add(Me.txtGuiaProveedor)
    Me.HGInformacion.Panel.Controls.Add(Me.lblGuiaProveedor)
    Me.HGInformacion.Panel.Controls.Add(Me.txtBulto)
    Me.HGInformacion.Panel.Controls.Add(Me.dtpFechaFin)
    Me.HGInformacion.Panel.Controls.Add(Me.KryptonLabel4)
    Me.HGInformacion.Panel.Controls.Add(Me.dtpFechaInicio)
    Me.HGInformacion.Panel.Controls.Add(Me.lblFecha)
    Me.HGInformacion.Panel.Controls.Add(Me.lblBulto)
    Me.HGInformacion.Panel.Controls.Add(Me.txtCliente)
    Me.HGInformacion.Panel.Controls.Add(Me.lblCliente)
    Me.HGInformacion.Size = New System.Drawing.Size(1035, 60)
    Me.HGInformacion.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.HGInformacion.TabIndex = 0
    Me.HGInformacion.Text = "Filtros"
    Me.HGInformacion.ValuesPrimary.Description = ""
    Me.HGInformacion.ValuesPrimary.Heading = "Filtros"
    Me.HGInformacion.ValuesPrimary.Image = Nothing
    Me.HGInformacion.ValuesSecondary.Description = ""
    Me.HGInformacion.ValuesSecondary.Heading = "Description"
    Me.HGInformacion.ValuesSecondary.Image = Nothing
    '
    'txtGuiaProveedor
    '
    Me.txtGuiaProveedor.Location = New System.Drawing.Point(443, 9)
    Me.txtGuiaProveedor.MaxLength = 10
    Me.txtGuiaProveedor.Name = "txtGuiaProveedor"
    Me.txtGuiaProveedor.Size = New System.Drawing.Size(100, 21)
    Me.txtGuiaProveedor.TabIndex = 10
    '
    'lblGuiaProveedor
    '
    Me.lblGuiaProveedor.Location = New System.Drawing.Point(347, 10)
    Me.lblGuiaProveedor.Name = "lblGuiaProveedor"
    Me.lblGuiaProveedor.Size = New System.Drawing.Size(87, 19)
    Me.lblGuiaProveedor.TabIndex = 9
    Me.lblGuiaProveedor.Text = "Guía Proveedor"
    Me.lblGuiaProveedor.Values.ExtraText = ""
    Me.lblGuiaProveedor.Values.Image = Nothing
    Me.lblGuiaProveedor.Values.Text = "Guía Proveedor"
    '
    'txtBulto
    '
    Me.txtBulto.Location = New System.Drawing.Point(596, 9)
    Me.txtBulto.MaxLength = 20
    Me.txtBulto.Name = "txtBulto"
    Me.txtBulto.Size = New System.Drawing.Size(134, 21)
    Me.txtBulto.TabIndex = 8
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(931, 9)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(90, 20)
    Me.dtpFechaFin.TabIndex = 7
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(907, 10)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(20, 19)
    Me.KryptonLabel4.TabIndex = 6
    Me.KryptonLabel4.Text = "Al"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Al"
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(814, 9)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(90, 20)
    Me.dtpFechaInicio.TabIndex = 5
    '
    'lblFecha
    '
    Me.lblFecha.Location = New System.Drawing.Point(737, 10)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(74, 19)
    Me.lblFecha.TabIndex = 4
    Me.lblFecha.Text = "Rango Fecha"
    Me.lblFecha.Values.ExtraText = ""
    Me.lblFecha.Values.Image = Nothing
    Me.lblFecha.Values.Text = "Rango Fecha"
    '
    'lblBulto
    '
    Me.lblBulto.Location = New System.Drawing.Point(553, 10)
    Me.lblBulto.Name = "lblBulto"
    Me.lblBulto.Size = New System.Drawing.Size(36, 19)
    Me.lblBulto.TabIndex = 2
    Me.lblBulto.Text = "Bulto"
    Me.lblBulto.Values.ExtraText = ""
    Me.lblBulto.Values.Image = Nothing
    Me.lblBulto.Values.Text = "Bulto"
    '
    'txtCliente
    '
    Me.txtCliente.Location = New System.Drawing.Point(57, 9)
    Me.txtCliente.Name = "txtCliente"
    Me.txtCliente.ReadOnly = True
    Me.txtCliente.Size = New System.Drawing.Size(280, 21)
    Me.txtCliente.StateActive.Back.Color1 = System.Drawing.Color.LemonChiffon
    Me.txtCliente.TabIndex = 1
    '
    'lblCliente
    '
    Me.lblCliente.Location = New System.Drawing.Point(7, 10)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(45, 19)
    Me.lblCliente.TabIndex = 0
    Me.lblCliente.Text = "Cliente"
    Me.lblCliente.Values.ExtraText = ""
    Me.lblCliente.Values.Image = Nothing
    Me.lblCliente.Values.Text = "Cliente"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "CREFFW"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Bulto"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "FREFFW"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "QREFFW"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Cant. Recibida"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "TIPBTO"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo Bulto"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "QPSOBL"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Peso"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "TUNPSO"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Unid. Peso"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "NORCML"
    Me.DataGridViewTextBoxColumn7.HeaderText = "O/C"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "NRITOC"
    Me.DataGridViewTextBoxColumn8.HeaderText = "Item"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "TDITES"
    Me.DataGridViewTextBoxColumn9.HeaderText = "Desc. Item"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "TUNDIT"
    Me.DataGridViewTextBoxColumn10.HeaderText = "Unid. Item"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "NGUIRM"
    Me.DataGridViewTextBoxColumn11.HeaderText = "Guia Remisión"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.Visible = False
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.DataPropertyName = "CMEDTS"
    Me.DataGridViewTextBoxColumn12.HeaderText = "Medio Sug."
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.Visible = False
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.DataPropertyName = "MEDTRANS"
    Me.DataGridViewTextBoxColumn13.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.Visible = False
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.DataPropertyName = "CMEDTC"
    Me.DataGridViewTextBoxColumn14.HeaderText = "Medio Confirmado"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.Visible = False
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.DataPropertyName = "MEDTRANC"
    Me.DataGridViewTextBoxColumn15.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.Visible = False
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.DataPropertyName = "TCTCST"
    Me.DataGridViewTextBoxColumn16.HeaderText = "Medio Imputación Terrestre"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.Visible = False
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.DataPropertyName = "TCTCSA"
    Me.DataGridViewTextBoxColumn17.HeaderText = "Medio Imputación Aereo"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.Visible = False
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.DataPropertyName = "TCTCSF"
    Me.DataGridViewTextBoxColumn18.HeaderText = "Medio Imputación Fluvial"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.Visible = False
    '
    'SEL
    '
    Me.SEL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.NullValue = False
    Me.SEL.DefaultCellStyle = DataGridViewCellStyle1
    Me.SEL.FalseValue = Nothing
    Me.SEL.HeaderText = "SEL"
    Me.SEL.IndeterminateValue = Nothing
    Me.SEL.Name = "SEL"
    Me.SEL.TrueValue = Nothing
    Me.SEL.Width = 34
    '
    'CREFFW
    '
    Me.CREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CREFFW.DataPropertyName = "CREFFW"
    Me.CREFFW.HeaderText = "Bulto"
    Me.CREFFW.Name = "CREFFW"
    Me.CREFFW.ReadOnly = True
    Me.CREFFW.Width = 64
    '
    'NSEQIN
    '
    Me.NSEQIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NSEQIN.DataPropertyName = "NSEQIN"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.NSEQIN.DefaultCellStyle = DataGridViewCellStyle2
    Me.NSEQIN.HeaderText = "Correlativo Bulto"
    Me.NSEQIN.Name = "NSEQIN"
    Me.NSEQIN.Width = 123
    '
    'FREFFW
    '
    Me.FREFFW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.FREFFW.DataPropertyName = "FREFFW"
    Me.FREFFW.HeaderText = "Fecha"
    Me.FREFFW.Name = "FREFFW"
    Me.FREFFW.ReadOnly = True
    Me.FREFFW.Width = 66
    '
    'TCMZNA
    '
    Me.TCMZNA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.TCMZNA.DataPropertyName = "TCMZNA"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.TCMZNA.DefaultCellStyle = DataGridViewCellStyle3
    Me.TCMZNA.HeaderText = "Zona"
    Me.TCMZNA.Name = "TCMZNA"
    Me.TCMZNA.Width = 62
    '
    'NORCML
    '
    Me.NORCML.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NORCML.DataPropertyName = "NORCML"
    Me.NORCML.HeaderText = "O/C"
    Me.NORCML.Name = "NORCML"
    Me.NORCML.ReadOnly = True
    Me.NORCML.Width = 56
    '
    'NRITOC
    '
    Me.NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.NRITOC.DataPropertyName = "NRITOC"
    Me.NRITOC.HeaderText = "Item"
    Me.NRITOC.Name = "NRITOC"
    Me.NRITOC.ReadOnly = True
    Me.NRITOC.Width = 58
    '
    'TDITES
    '
    Me.TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TDITES.DataPropertyName = "TDITES"
    Me.TDITES.HeaderText = "Desc. Item"
    Me.TDITES.Name = "TDITES"
    Me.TDITES.ReadOnly = True
    '
    'QSLCNB
    '
    Me.QSLCNB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.QSLCNB.DataPropertyName = "QSLCNB"
    Me.QSLCNB.HeaderText = "Cant. Item"
    Me.QSLCNB.Name = "QSLCNB"
    Me.QSLCNB.ReadOnly = True
    Me.QSLCNB.Width = 88
    '
    'frmDetalleBultoDia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1035, 470)
    Me.ControlBox = False
    Me.Controls.Add(Me.KryptonPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmDetalleBultoDia"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Detalle de Bulto x Dia"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGDetalle.Panel.ResumeLayout(False)
    CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGDetalle.ResumeLayout(False)
    CType(Me.dtgDetalleBultos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.HGInformacion.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGInformacion.Panel.ResumeLayout(False)
    Me.HGInformacion.Panel.PerformLayout()
    CType(Me.HGInformacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGInformacion.ResumeLayout(False)
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
  Friend WithEvents HGInformacion As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents HGDetalle As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents lblBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtgDetalleBultos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFecha As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
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
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents txtBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtGuiaProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblGuiaProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents SEL As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
  Friend WithEvents CREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NSEQIN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FREFFW As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCMZNA As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QSLCNB As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
