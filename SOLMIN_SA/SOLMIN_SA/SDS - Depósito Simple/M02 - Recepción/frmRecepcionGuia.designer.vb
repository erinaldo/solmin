<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionGuia
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaProcesar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgMercaderiaGuia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Procesar = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QBLTSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVUNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCLL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPDP6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Activo = New System.Windows.Forms.DataGridViewButtonColumn
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblContratos = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboContratos = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoRecepcionListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblTipoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaZonaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblGuíaRemisión = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgMercaderia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgMercaderia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgMercaderia.Panel.SuspendLayout()
        Me.hgMercaderia.SuspendLayout()
        CType(Me.dgMercaderiaGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgMercaderia)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(823, 597)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgMercaderia
        '
        Me.hgMercaderia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaProcesar, Me.bsaBuscar, Me.bsaCancelar})
        Me.hgMercaderia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgMercaderia.HeaderVisibleSecondary = False
        Me.hgMercaderia.Location = New System.Drawing.Point(0, 126)
        Me.hgMercaderia.Name = "hgMercaderia"
        '
        'hgMercaderia.Panel
        '
        Me.hgMercaderia.Panel.Controls.Add(Me.dgMercaderiaGuia)
        Me.hgMercaderia.Size = New System.Drawing.Size(823, 471)
        Me.hgMercaderia.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgMercaderia.TabIndex = 7
        Me.hgMercaderia.ValuesPrimary.Description = ""
        Me.hgMercaderia.ValuesPrimary.Heading = ""
        Me.hgMercaderia.ValuesPrimary.Image = Nothing
        Me.hgMercaderia.ValuesSecondary.Description = ""
        Me.hgMercaderia.ValuesSecondary.Heading = "Description"
        Me.hgMercaderia.ValuesSecondary.Image = Nothing
        '
        'bsaProcesar
        '
        Me.bsaProcesar.ExtraText = ""
        Me.bsaProcesar.Image = Nothing
        Me.bsaProcesar.Text = "Procesar"
        Me.bsaProcesar.ToolTipImage = Nothing
        Me.bsaProcesar.UniqueName = "445F8163635F41C3445F8163635F41C3"
        '
        'bsaBuscar
        '
        Me.bsaBuscar.ExtraText = ""
        Me.bsaBuscar.Image = Nothing
        Me.bsaBuscar.Text = "Buscar"
        Me.bsaBuscar.ToolTipImage = Nothing
        Me.bsaBuscar.UniqueName = "1305ED461EDE49991305ED461EDE4999"
        '
        'bsaCancelar
        '
        Me.bsaCancelar.ExtraText = ""
        Me.bsaCancelar.Image = Nothing
        Me.bsaCancelar.Text = "Cancelar"
        Me.bsaCancelar.ToolTipImage = Nothing
        Me.bsaCancelar.UniqueName = "B5D5C37BDCC049A4B5D5C37BDCC049A4"
        '
        'dgMercaderiaGuia
        '
        Me.dgMercaderiaGuia.AllowUserToAddRows = False
        Me.dgMercaderiaGuia.AllowUserToDeleteRows = False
        Me.dgMercaderiaGuia.AllowUserToResizeRows = False
        Me.dgMercaderiaGuia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderiaGuia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Procesar, Me.NRITOC, Me.TCITCL, Me.TMRCD2, Me.TOBS, Me.QBLTSR, Me.CUNCN5, Me.PESO, Me.CUNPS5, Me.IVUNIT, Me.CUNVL5, Me.NORDSR, Me.NORCML, Me.NCNTR, Me.NCRCTC, Me.NAUTR, Me.FUNDS2, Me.CMRCD, Me.NRUCLL, Me.CTPDP6, Me.Activo})
        Me.dgMercaderiaGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderiaGuia.Location = New System.Drawing.Point(0, 0)
        Me.dgMercaderiaGuia.MultiSelect = False
        Me.dgMercaderiaGuia.Name = "dgMercaderiaGuia"
        Me.dgMercaderiaGuia.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgMercaderiaGuia.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgMercaderiaGuia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMercaderiaGuia.Size = New System.Drawing.Size(821, 443)
        Me.dgMercaderiaGuia.StandardTab = True
        Me.dgMercaderiaGuia.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgMercaderiaGuia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderiaGuia.TabIndex = 6
        '
        'Procesar
        '
        Me.Procesar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.Procesar.DefaultCellStyle = DataGridViewCellStyle1
        Me.Procesar.FalseValue = Nothing
        Me.Procesar.HeaderText = "Procesar"
        Me.Procesar.IndeterminateValue = Nothing
        Me.Procesar.Name = "Procesar"
        Me.Procesar.TrueValue = Nothing
        Me.Procesar.Width = 60
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "NRITOC"
        Me.NRITOC.HeaderText = "Item Cliente"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.Visible = False
        Me.NRITOC.Width = 91
        '
        'TCITCL
        '
        Me.TCITCL.DataPropertyName = "TCITCL"
        Me.TCITCL.HeaderText = "Cod. Mercadería"
        Me.TCITCL.Name = "TCITCL"
        Me.TCITCL.ReadOnly = True
        Me.TCITCL.Width = 120
        '
        'TMRCD2
        '
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Nombre Mercadería"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        Me.TMRCD2.Width = 137
        '
        'TOBS
        '
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observación"
        Me.TOBS.Name = "TOBS"
        '
        'QBLTSR
        '
        Me.QBLTSR.DataPropertyName = "QBLTSR"
        Me.QBLTSR.HeaderText = "Cantidad"
        Me.QBLTSR.MaxInputLength = 15
        Me.QBLTSR.Name = "QBLTSR"
        Me.QBLTSR.ReadOnly = True
        Me.QBLTSR.Width = 83
        '
        'CUNCN5
        '
        Me.CUNCN5.DataPropertyName = "CUNCN5"
        Me.CUNCN5.HeaderText = "U. Cantidad"
        Me.CUNCN5.MaxInputLength = 5
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.Width = 97
        '
        'PESO
        '
        Me.PESO.DataPropertyName = "PESO"
        Me.PESO.HeaderText = "Peso"
        Me.PESO.MaxInputLength = 15
        Me.PESO.Name = "PESO"
        Me.PESO.Width = 60
        '
        'CUNPS5
        '
        Me.CUNPS5.DataPropertyName = "CUNPS5"
        Me.CUNPS5.HeaderText = "U. Peso"
        Me.CUNPS5.MaxInputLength = 5
        Me.CUNPS5.Name = "CUNPS5"
        Me.CUNPS5.Width = 74
        '
        'IVUNIT
        '
        Me.IVUNIT.DataPropertyName = "IVUNIT"
        Me.IVUNIT.HeaderText = "Valor"
        Me.IVUNIT.MaxInputLength = 15
        Me.IVUNIT.Name = "IVUNIT"
        Me.IVUNIT.Width = 63
        '
        'CUNVL5
        '
        Me.CUNVL5.DataPropertyName = "CUNVL5"
        Me.CUNVL5.HeaderText = "U. Valor"
        Me.CUNVL5.MaxInputLength = 5
        Me.CUNVL5.Name = "CUNVL5"
        Me.CUNVL5.Width = 77
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "O / S"
        Me.NORDSR.MaxInputLength = 10
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NORDSR.Width = 61
        '
        'NORCML
        '
        Me.NORCML.DataPropertyName = "NORCML"
        Me.NORCML.HeaderText = "O / C"
        Me.NORCML.Name = "NORCML"
        Me.NORCML.ReadOnly = True
        Me.NORCML.Visible = False
        Me.NORCML.Width = 62
        '
        'NCNTR
        '
        Me.NCNTR.DataPropertyName = "NCNTR"
        Me.NCNTR.HeaderText = "N° Contrato"
        Me.NCNTR.Name = "NCNTR"
        Me.NCNTR.Visible = False
        Me.NCNTR.Width = 91
        '
        'NCRCTC
        '
        Me.NCRCTC.DataPropertyName = "NCRCTC"
        Me.NCRCTC.HeaderText = "N° Corre. Contrato"
        Me.NCRCTC.Name = "NCRCTC"
        Me.NCRCTC.Visible = False
        Me.NCRCTC.Width = 122
        '
        'NAUTR
        '
        Me.NAUTR.DataPropertyName = "NAUTR"
        Me.NAUTR.HeaderText = "N° Autorización"
        Me.NAUTR.Name = "NAUTR"
        Me.NAUTR.Visible = False
        Me.NAUTR.Width = 109
        '
        'FUNDS2
        '
        Me.FUNDS2.DataPropertyName = "FUNDS2"
        Me.FUNDS2.HeaderText = "FUNDS2"
        Me.FUNDS2.Name = "FUNDS2"
        Me.FUNDS2.Visible = False
        Me.FUNDS2.Width = 79
        '
        'CMRCD
        '
        Me.CMRCD.DataPropertyName = "CMRCD"
        Me.CMRCD.HeaderText = "Cód. Ransa"
        Me.CMRCD.Name = "CMRCD"
        Me.CMRCD.Visible = False
        Me.CMRCD.Width = 92
        '
        'NRUCLL
        '
        Me.NRUCLL.DataPropertyName = "NRUCLL"
        Me.NRUCLL.HeaderText = "RUC Cliente"
        Me.NRUCLL.Name = "NRUCLL"
        Me.NRUCLL.Visible = False
        Me.NRUCLL.Width = 94
        '
        'CTPDP6
        '
        Me.CTPDP6.DataPropertyName = "CTPDP6"
        Me.CTPDP6.HeaderText = "CTPDP6"
        Me.CTPDP6.MaxInputLength = 5
        Me.CTPDP6.Name = "CTPDP6"
        Me.CTPDP6.Visible = False
        Me.CTPDP6.Width = 78
        '
        'Activo
        '
        Me.Activo.HeaderText = "Crear O/S"
        Me.Activo.Name = "Activo"
        Me.Activo.Width = 66
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.lblContratos)
        Me.hgFiltros.Panel.Controls.Add(Me.cboContratos)
        Me.hgFiltros.Panel.Controls.Add(Me.txtTipoRecepcion)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoRecepcion)
        Me.hgFiltros.Panel.Controls.Add(Me.txtZonaAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblZonaAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Panel.Controls.Add(Me.txtGuiaRemision)
        Me.hgFiltros.Panel.Controls.Add(Me.lblGuíaRemisión)
        Me.hgFiltros.Panel.Controls.Add(Me.btnCrearOS)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Size = New System.Drawing.Size(823, 126)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 1
        Me.hgFiltros.Text = "Información"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Información"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'lblContratos
        '
        Me.lblContratos.Location = New System.Drawing.Point(24, 86)
        Me.lblContratos.Name = "lblContratos"
        Me.lblContratos.Size = New System.Drawing.Size(72, 19)
        Me.lblContratos.TabIndex = 37
        Me.lblContratos.Text = "C. Vigentes : "
        Me.lblContratos.Values.ExtraText = ""
        Me.lblContratos.Values.Image = Nothing
        Me.lblContratos.Values.Text = "C. Vigentes : "
        '
        'cboContratos
        '
        Me.cboContratos.DropDownWidth = 121
        Me.cboContratos.FormattingEnabled = False
        Me.cboContratos.ItemHeight = 13
        Me.cboContratos.Location = New System.Drawing.Point(112, 83)
        Me.cboContratos.Name = "cboContratos"
        Me.cboContratos.Size = New System.Drawing.Size(121, 21)
        'Me.cboContratos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboContratos.TabIndex = 36
        '
        'txtTipoRecepcion
        '
        Me.txtTipoRecepcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoRecepcionListar})
        Me.txtTipoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoRecepcion, True)
        Me.txtTipoRecepcion.Location = New System.Drawing.Point(482, 58)
        Me.txtTipoRecepcion.MaxLength = 50
        Me.txtTipoRecepcion.Name = "txtTipoRecepcion"
        Me.txtTipoRecepcion.Size = New System.Drawing.Size(254, 21)
        Me.txtTipoRecepcion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoRecepcion.TabIndex = 5
        Me.TypeValidator.SetTypes(Me.txtTipoRecepcion, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaTipoRecepcionListar
        '
        Me.bsaTipoRecepcionListar.ExtraText = ""
        Me.bsaTipoRecepcionListar.Image = Nothing
        Me.bsaTipoRecepcionListar.Text = ""
        Me.bsaTipoRecepcionListar.ToolTipImage = Nothing
        Me.bsaTipoRecepcionListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoRecepcionListar.UniqueName = "F84D5E6A34EE4F36F84D5E6A34EE4F36"
        '
        'lblTipoRecepcion
        '
        Me.lblTipoRecepcion.Location = New System.Drawing.Point(402, 61)
        Me.lblTipoRecepcion.Name = "lblTipoRecepcion"
        Me.lblTipoRecepcion.Size = New System.Drawing.Size(61, 19)
        Me.lblTipoRecepcion.TabIndex = 35
        Me.lblTipoRecepcion.Text = "Tipo Rec. : "
        Me.lblTipoRecepcion.Values.ExtraText = ""
        Me.lblTipoRecepcion.Values.Image = Nothing
        Me.lblTipoRecepcion.Values.Text = "Tipo Rec. : "
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaZonaAlmacenListar})
        Me.txtZonaAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtZonaAlmacen, True)
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(482, 33)
        Me.txtZonaAlmacen.MaxLength = 50
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(254, 21)
        Me.txtZonaAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtZonaAlmacen.TabIndex = 4
        Me.TypeValidator.SetTypes(Me.txtZonaAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaZonaAlmacenListar
        '
        Me.bsaZonaAlmacenListar.ExtraText = ""
        Me.bsaZonaAlmacenListar.Image = Nothing
        Me.bsaZonaAlmacenListar.Text = ""
        Me.bsaZonaAlmacenListar.ToolTipImage = Nothing
        Me.bsaZonaAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaZonaAlmacenListar.UniqueName = "F84D5E6A34EE4F36F84D5E6A34EE4F36"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAlmacenListar})
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtAlmacen, True)
        Me.txtAlmacen.Location = New System.Drawing.Point(112, 58)
        Me.txtAlmacen.MaxLength = 50
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(254, 21)
        Me.txtAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlmacen.TabIndex = 3
        Me.TypeValidator.SetTypes(Me.txtAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaAlmacenListar
        '
        Me.bsaAlmacenListar.ExtraText = ""
        Me.bsaAlmacenListar.Image = Nothing
        Me.bsaAlmacenListar.Text = ""
        Me.bsaAlmacenListar.ToolTipImage = Nothing
        Me.bsaAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaAlmacenListar.UniqueName = "9BC1C9592405475E9BC1C9592405475E"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoAlmacenListar})
        Me.txtTipoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoAlmacen, True)
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(112, 33)
        Me.txtTipoAlmacen.MaxLength = 50
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(254, 21)
        Me.txtTipoAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAlmacen.TabIndex = 2
        Me.TypeValidator.SetTypes(Me.txtTipoAlmacen, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'bsaTipoAlmacenListar
        '
        Me.bsaTipoAlmacenListar.ExtraText = ""
        Me.bsaTipoAlmacenListar.Image = Nothing
        Me.bsaTipoAlmacenListar.Text = ""
        Me.bsaTipoAlmacenListar.ToolTipImage = Nothing
        Me.bsaTipoAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoAlmacenListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(24, 61)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(59, 19)
        Me.lblAlmacen.TabIndex = 31
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(402, 36)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(41, 19)
        Me.lblZonaAlmacen.TabIndex = 33
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(24, 36)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(38, 19)
        Me.lblTipoAlmacen.TabIndex = 29
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'txtGuiaRemision
        '
        Me.txtGuiaRemision.Location = New System.Drawing.Point(112, 8)
        Me.txtGuiaRemision.MaxLength = 10
        Me.txtGuiaRemision.Name = "txtGuiaRemision"
        Me.txtGuiaRemision.Size = New System.Drawing.Size(104, 21)
        Me.txtGuiaRemision.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGuiaRemision.TabIndex = 1
        Me.TypeValidator.SetTypes(Me.txtGuiaRemision, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Normal)
        '
        'lblGuíaRemisión
        '
        Me.lblGuíaRemisión.Location = New System.Drawing.Point(24, 11)
        Me.lblGuíaRemisión.Name = "lblGuíaRemisión"
        Me.lblGuíaRemisión.Size = New System.Drawing.Size(59, 19)
        Me.lblGuíaRemisión.TabIndex = 2
        Me.lblGuíaRemisión.Text = "No. Guía : "
        Me.lblGuíaRemisión.Values.ExtraText = ""
        Me.lblGuíaRemisión.Values.Image = Nothing
        Me.lblGuíaRemisión.Values.Text = "No. Guía : "
        '
        'btnCrearOS
        '
        Me.btnCrearOS.Location = New System.Drawing.Point(720, 33)
        Me.btnCrearOS.Name = "btnCrearOS"
        Me.btnCrearOS.Size = New System.Drawing.Size(16, 19)
        Me.btnCrearOS.TabIndex = 38
        Me.btnCrearOS.Text = "..."
        Me.btnCrearOS.Values.ExtraText = ""
        Me.btnCrearOS.Values.Image = Nothing
        Me.btnCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCrearOS.Values.Text = "..."
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(198, 10)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(15, 19)
        Me.txtCliente.TabIndex = 28
        Me.txtCliente.Text = "?"
        Me.txtCliente.Values.ExtraText = ""
        Me.txtCliente.Values.Image = Nothing
        Me.txtCliente.Values.Text = "?"
        Me.txtCliente.Visible = False
        '
        'frmRecepcionGuia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 597)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRecepcionGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información Guía de Remisión"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgMercaderia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderia.Panel.ResumeLayout(False)
        CType(Me.hgMercaderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgMercaderia.ResumeLayout(False)
        CType(Me.dgMercaderiaGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
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
  Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents lblGuíaRemisión As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
  Friend WithEvents dgMercaderiaGuia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents hgMercaderia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents txtGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents bsaProcesar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents bsaCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaTipoRecepcionListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents lblTipoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaZonaAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents txtTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaTipoAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblContratos As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboContratos As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents Procesar As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
  Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QBLTSR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents PESO As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents IVUNIT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRUCLL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CTPDP6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
  Public WithEvents Activo As System.Windows.Forms.DataGridViewButtonColumn
End Class
