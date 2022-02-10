<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTarifario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewTarifario))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup5 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnExportarXLS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtgTarifario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCNTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TARIFA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.dtgClienteGrupo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup16 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonPanel5 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.UcClienteGrupo = New Ransa.Controls.GrupoCliente.ucClienteGrupo_TxtF01
        Me.cmbPlanta = New System.Windows.Forms.ComboBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnBuscar = New System.Windows.Forms.PictureBox
        Me.cmbDivision = New System.Windows.Forms.ComboBox
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New System.Windows.Forms.ComboBox
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup5.Panel.SuspendLayout()
        Me.KryptonHeaderGroup5.SuspendLayout()
        CType(Me.dtgTarifario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.dtgClienteGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup16.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup16.Panel.SuspendLayout()
        Me.KryptonHeaderGroup16.SuspendLayout()
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel5.SuspendLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup5)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup16)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1008, 666)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup5
        '
        Me.KryptonHeaderGroup5.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnExportarXLS})
        Me.KryptonHeaderGroup5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup5.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup5.Location = New System.Drawing.Point(0, 100)
        Me.KryptonHeaderGroup5.Name = "KryptonHeaderGroup5"
        '
        'KryptonHeaderGroup5.Panel
        '
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.dtgTarifario)
        Me.KryptonHeaderGroup5.Size = New System.Drawing.Size(1008, 381)
        Me.KryptonHeaderGroup5.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup5.TabIndex = 36
        Me.KryptonHeaderGroup5.Text = "Tarifario"
        Me.KryptonHeaderGroup5.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup5.ValuesPrimary.Heading = "Tarifario"
        Me.KryptonHeaderGroup5.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup5.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup5.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup5.ValuesSecondary.Image = Nothing
        '
        'btnExportarXLS
        '
        Me.btnExportarXLS.ExtraText = ""
        Me.btnExportarXLS.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportarXLS.Text = "Exportar"
        Me.btnExportarXLS.ToolTipImage = Nothing
        Me.btnExportarXLS.UniqueName = "73F0580B40724EC573F0580B40724EC5"
        '
        'dtgTarifario
        '
        Me.dtgTarifario.AllowUserToAddRows = False
        Me.dtgTarifario.AllowUserToDeleteRows = False
        Me.dtgTarifario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTarifario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCNTRT, Me.SERVICIO, Me.TPLNTA, Me.TARIFA, Me.MONEDA, Me.MONTO, Me.DESTAR, Me.TOBS})
        Me.dtgTarifario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgTarifario.Location = New System.Drawing.Point(0, 0)
        Me.dtgTarifario.Name = "dtgTarifario"
        Me.dtgTarifario.ReadOnly = True
        Me.dtgTarifario.Size = New System.Drawing.Size(1006, 346)
        Me.dtgTarifario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgTarifario.TabIndex = 21
        '
        'NCNTRT
        '
        Me.NCNTRT.DataPropertyName = "NCNTRT"
        Me.NCNTRT.HeaderText = "Contrato"
        Me.NCNTRT.Name = "NCNTRT"
        Me.NCNTRT.ReadOnly = True
        '
        'SERVICIO
        '
        Me.SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SERVICIO.DataPropertyName = "SERVICIO"
        Me.SERVICIO.HeaderText = "Servicio"
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.ReadOnly = True
        Me.SERVICIO.Width = 250
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "Planta"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.ReadOnly = True
        '
        'TARIFA
        '
        Me.TARIFA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TARIFA.DataPropertyName = "TARIFA"
        Me.TARIFA.HeaderText = "Tarifa"
        Me.TARIFA.Name = "TARIFA"
        Me.TARIFA.ReadOnly = True
        Me.TARIFA.Width = 250
        '
        'MONEDA
        '
        Me.MONEDA.DataPropertyName = "MONEDA"
        Me.MONEDA.HeaderText = "Moneda"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        '
        'MONTO
        '
        Me.MONTO.DataPropertyName = "MONTO"
        Me.MONTO.HeaderText = "Monto"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'DESTAR
        '
        Me.DESTAR.DataPropertyName = "DESTAR"
        Me.DESTAR.HeaderText = "Descripcion"
        Me.DESTAR.Name = "DESTAR"
        Me.DESTAR.ReadOnly = True
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observaciones"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        Me.TOBS.Width = 150
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 481)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtgClienteGrupo)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1008, 185)
        Me.KryptonHeaderGroup1.StateDisabled.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.KryptonHeaderGroup1.TabIndex = 37
        Me.KryptonHeaderGroup1.Text = "Clientes por Grupo"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Clientes por Grupo"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'dtgClienteGrupo
        '
        Me.dtgClienteGrupo.AllowUserToAddRows = False
        Me.dtgClienteGrupo.AllowUserToDeleteRows = False
        Me.dtgClienteGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClienteGrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Cliente, Me.Descripcion, Me.RUC, Me.Direccion})
        Me.dtgClienteGrupo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgClienteGrupo.Location = New System.Drawing.Point(0, 0)
        Me.dtgClienteGrupo.Name = "dtgClienteGrupo"
        Me.dtgClienteGrupo.ReadOnly = True
        Me.dtgClienteGrupo.Size = New System.Drawing.Size(1006, 166)
        Me.dtgClienteGrupo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgClienteGrupo.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "CCLNT"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 50
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente.DataPropertyName = "TCMPCL"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "TMTVBJ"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 120
        '
        'RUC
        '
        Me.RUC.DataPropertyName = "NRUC"
        Me.RUC.HeaderText = "RUC"
        Me.RUC.Name = "RUC"
        Me.RUC.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "TDRCCB"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 300
        '
        'KryptonHeaderGroup16
        '
        Me.KryptonHeaderGroup16.AutoSize = True
        Me.KryptonHeaderGroup16.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup16.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup16.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup16.Name = "KryptonHeaderGroup16"
        '
        'KryptonHeaderGroup16.Panel
        '
        Me.KryptonHeaderGroup16.Panel.Controls.Add(Me.KryptonPanel5)
        Me.KryptonHeaderGroup16.Size = New System.Drawing.Size(1008, 100)
        Me.KryptonHeaderGroup16.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup16.TabIndex = 35
        Me.KryptonHeaderGroup16.Text = "Filtro"
        Me.KryptonHeaderGroup16.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup16.ValuesPrimary.Heading = "Filtro"
        Me.KryptonHeaderGroup16.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup16.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup16.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup16.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "CBECCF99C9E54407CBECCF99C9E54407"
        '
        'KryptonPanel5
        '
        Me.KryptonPanel5.Controls.Add(Me.UcClienteGrupo)
        Me.KryptonPanel5.Controls.Add(Me.cmbPlanta)
        Me.KryptonPanel5.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel5.Controls.Add(Me.btnBuscar)
        Me.KryptonPanel5.Controls.Add(Me.cmbDivision)
        Me.KryptonPanel5.Controls.Add(Me.lblDivision)
        Me.KryptonPanel5.Controls.Add(Me.cmbCompania)
        Me.KryptonPanel5.Controls.Add(Me.lblCompania)
        Me.KryptonPanel5.Controls.Add(Me.cmbMoneda)
        Me.KryptonPanel5.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel5.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel5.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel5.Name = "KryptonPanel5"
        Me.KryptonPanel5.Size = New System.Drawing.Size(1006, 75)
        Me.KryptonPanel5.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel5.TabIndex = 26
        '
        'UcClienteGrupo
        '
        Me.UcClienteGrupo.CCMPN = "EZ"
        Me.UcClienteGrupo.Location = New System.Drawing.Point(85, 40)
        Me.UcClienteGrupo.Name = "UcClienteGrupo"
        Me.UcClienteGrupo.pAccesoPorUsuario = False
        Me.UcClienteGrupo.pRequerido = True
        Me.UcClienteGrupo.pTipoCliente = Ransa.Controls.GrupoCliente.ucClienteGrupo_TxtF01.eTipoCliente.Normal
        Me.UcClienteGrupo.Size = New System.Drawing.Size(289, 21)
        Me.UcClienteGrupo.TabIndex = 46
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlanta.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(761, 7)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(145, 22)
        Me.cmbPlanta.TabIndex = 44
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(705, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel1.TabIndex = 45
        Me.KryptonLabel1.Text = "Planta :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Planta :"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(927, 10)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(53, 52)
        Me.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.TabStop = False
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDivision.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbDivision.FormattingEnabled = True
        Me.cmbDivision.Location = New System.Drawing.Point(459, 7)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(216, 22)
        Me.cmbDivision.TabIndex = 41
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(397, 13)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(55, 19)
        Me.lblDivision.TabIndex = 42
        Me.lblDivision.Text = "División :"
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "División :"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompania.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbCompania.FormattingEnabled = True
        Me.cmbCompania.Location = New System.Drawing.Point(85, 7)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(286, 22)
        Me.cmbCompania.TabIndex = 39
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(11, 13)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 19)
        Me.lblCompania.TabIndex = 40
        Me.lblCompania.Text = "Compañia :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia :"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(459, 40)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(216, 22)
        Me.cmbMoneda.TabIndex = 38
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(397, 46)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel9.TabIndex = 37
        Me.KryptonLabel9.Text = "Moneda :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Moneda :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(11, 46)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel8.TabIndex = 36
        Me.KryptonLabel8.Text = "Cliente :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Cliente :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NCNTRT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TPLNTA"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TARIFA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MONEDA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MONTO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DESTAR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 120
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 300
        '
        'frmNewTarifario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 666)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmNewTarifario"
        Me.Text = "Tarifario"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.ResumeLayout(False)
        CType(Me.dtgTarifario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.dtgClienteGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup16.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup16.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup16.ResumeLayout(False)
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel5.ResumeLayout(False)
        Me.KryptonPanel5.PerformLayout()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonHeaderGroup16 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel5 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonHeaderGroup5 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnExportarXLS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbCompania As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDivision As System.Windows.Forms.ComboBox
    Friend WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtgTarifario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgClienteGrupo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcClienteGrupo As Ransa.Controls.GrupoCliente.ucClienteGrupo_TxtF01
    Friend WithEvents NCNTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARIFA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class