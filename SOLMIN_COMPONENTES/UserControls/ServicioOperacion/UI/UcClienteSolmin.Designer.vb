<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCclienteSolmin
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgClientes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportar = New System.Windows.Forms.ToolStripSplitButton
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContratosTarifaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcClienteGrupo = New Ransa.Controls.GrupoCliente.ucClienteGrupo_TxtF01
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
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
        Me.cmbRegionVenta = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        Me.UcCliente_TxtF011 = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCRVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCNTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.imgTarifa = New System.Windows.Forms.DataGridViewImageColumn
        Me.img = New System.Windows.Forms.DataGridViewImageColumn
        Me.NRCTCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRCTSL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CRGVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgClientes)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1077, 600)
        Me.KryptonPanel.TabIndex = 1
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowUserToAddRows = False
        Me.dtgClientes.AllowUserToDeleteRows = False
        Me.dtgClientes.AllowUserToOrderColumns = True
        Me.dtgClientes.AllowUserToResizeRows = False
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.DESCAR, Me.TCRVTA, Me.CCLNT, Me.TCMPCL, Me.NRUC, Me.NCNTRT, Me.DESCTR, Me.FECINI, Me.FECFIN, Me.imgTarifa, Me.img, Me.NRCTCL, Me.NRCTSL, Me.CRGVTA})
        Me.dtgClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgClientes.Location = New System.Drawing.Point(0, 107)
        Me.dtgClientes.Name = "dtgClientes"
        Me.dtgClientes.ReadOnly = True
        Me.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgClientes.Size = New System.Drawing.Size(1077, 493)
        Me.dtgClientes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgClientes.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator2, Me.tsbExportar, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 82)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1077, 25)
        Me.ToolStrip1.TabIndex = 71
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbExportar
        '
        Me.tsbExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ContratosTarifaToolStripMenuItem})
        Me.tsbExportar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.icono_exp_excel
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(82, 22)
        Me.tsbExportar.Text = "Exportar"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ContratosTarifaToolStripMenuItem
        '
        Me.ContratosTarifaToolStripMenuItem.Name = "ContratosTarifaToolStripMenuItem"
        Me.ContratosTarifaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ContratosTarifaToolStripMenuItem.Text = "Contratos / Tarifa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbRegionVenta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcClienteGrupo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCliente_TxtF011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1077, 82)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 70
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(448, 15)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel2.TabIndex = 93
        Me.KryptonLabel2.Text = "Negocio:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Negocio:"
        '
        'UcClienteGrupo
        '
        Me.UcClienteGrupo.CCMPN = "EZ"
        Me.UcClienteGrupo.Location = New System.Drawing.Point(107, 48)
        Me.UcClienteGrupo.Name = "UcClienteGrupo"
        Me.UcClienteGrupo.pAccesoPorUsuario = False
        Me.UcClienteGrupo.pRequerido = False
        Me.UcClienteGrupo.pTipoCliente = Ransa.Controls.GrupoCliente.ucClienteGrupo_TxtF01.eTipoCliente.Normal
        Me.UcClienteGrupo.Size = New System.Drawing.Size(297, 22)
        Me.UcClienteGrupo.TabIndex = 92
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(52, 48)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(51, 20)
        Me.lblCompania.TabIndex = 91
        Me.lblCompania.Text = "Grupo :"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Grupo :"
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Habilitar = True
        Me.UcCompania.Location = New System.Drawing.Point(107, 13)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        Me.UcCompania.Size = New System.Drawing.Size(297, 29)
        Me.UcCompania.TabIndex = 88
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(35, 16)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel3.TabIndex = 6
        Me.KryptonLabel3.Text = "Compañia : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Compañia : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(450, 50)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Estado"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 60
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Estado"
        Me.DataGridViewImageColumn2.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.cell_layout
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRCTCL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NRCTCL"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESCAR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NCNTRT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DESCTR"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción de Contrato"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NCNTRT"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contrato"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fin Fin Vigencia"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 90
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NRCTCL"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NRCTCL"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NRCTSL"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NRCTSL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "NRCTSL"
        Me.DataGridViewTextBoxColumn11.HeaderText = "NRCTSL"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CRGVTA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'cmbRegionVenta
        '
        Me.cmbRegionVenta.CheckOnClick = True
        Me.cmbRegionVenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbRegionVenta.DropDownHeight = 1
        Me.cmbRegionVenta.FormattingEnabled = True
        Me.cmbRegionVenta.IntegralHeight = False
        Me.cmbRegionVenta.Location = New System.Drawing.Point(517, 15)
        Me.cmbRegionVenta.Name = "cmbRegionVenta"
        Me.cmbRegionVenta.Size = New System.Drawing.Size(297, 21)
        Me.cmbRegionVenta.TabIndex = 94
        Me.cmbRegionVenta.ValueSeparator = ", "
        '
        'UcCliente_TxtF011
        '
        Me.UcCliente_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCliente_TxtF011.BackColor = System.Drawing.Color.Transparent
        Me.UcCliente_TxtF011.CCMPN = "EZ"
        Me.UcCliente_TxtF011.Location = New System.Drawing.Point(517, 50)
        Me.UcCliente_TxtF011.Name = "UcCliente_TxtF011"
        Me.UcCliente_TxtF011.pAccesoPorUsuario = False
        Me.UcCliente_TxtF011.pRequerido = False
        Me.UcCliente_TxtF011.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcCliente_TxtF011.Size = New System.Drawing.Size(297, 22)
        Me.UcCliente_TxtF011.TabIndex = 1
        '
        'CCMPN
        '
        Me.CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "Compania"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 91
        '
        'DESCAR
        '
        Me.DESCAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESCAR.DataPropertyName = "DESCAR"
        Me.DESCAR.HeaderText = "Grupo"
        Me.DESCAR.Name = "DESCAR"
        Me.DESCAR.ReadOnly = True
        Me.DESCAR.Width = 69
        '
        'TCRVTA
        '
        Me.TCRVTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA.DataPropertyName = "TCRVTA"
        Me.TCRVTA.HeaderText = "Negocio"
        Me.TCRVTA.Name = "TCRVTA"
        Me.TCRVTA.ReadOnly = True
        Me.TCRVTA.Width = 81
        '
        'CCLNT
        '
        Me.CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Width = 73
        '
        'TCMPCL
        '
        Me.TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Descripción"
        Me.TCMPCL.MinimumWidth = 200
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        '
        'NRUC
        '
        Me.NRUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUC.DataPropertyName = "NRUC"
        Me.NRUC.HeaderText = "Ruc"
        Me.NRUC.Name = "NRUC"
        Me.NRUC.ReadOnly = True
        Me.NRUC.Width = 56
        '
        'NCNTRT
        '
        Me.NCNTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCNTRT.DataPropertyName = "NCNTRT"
        Me.NCNTRT.HeaderText = "Contrato"
        Me.NCNTRT.Name = "NCNTRT"
        Me.NCNTRT.ReadOnly = True
        Me.NCNTRT.Width = 83
        '
        'DESCTR
        '
        Me.DESCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESCTR.DataPropertyName = "DESCTR"
        Me.DESCTR.HeaderText = "Descripción de Contrato"
        Me.DESCTR.MinimumWidth = 200
        Me.DESCTR.Name = "DESCTR"
        Me.DESCTR.ReadOnly = True
        Me.DESCTR.Width = 200
        '
        'FECINI
        '
        Me.FECINI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI.DataPropertyName = "FECINI"
        Me.FECINI.HeaderText = "Fec Ini Vigencia"
        Me.FECINI.Name = "FECINI"
        Me.FECINI.ReadOnly = True
        Me.FECINI.Width = 118
        '
        'FECFIN
        '
        Me.FECFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN.DataPropertyName = "FECFIN"
        Me.FECFIN.HeaderText = "Fec Fin Vigencia"
        Me.FECFIN.Name = "FECFIN"
        Me.FECFIN.ReadOnly = True
        Me.FECFIN.Width = 111
        '
        'imgTarifa
        '
        Me.imgTarifa.HeaderText = "Tarifa"
        Me.imgTarifa.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.unsortedList
        Me.imgTarifa.Name = "imgTarifa"
        Me.imgTarifa.ReadOnly = True
        Me.imgTarifa.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.imgTarifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.imgTarifa.Width = 50
        '
        'img
        '
        Me.img.HeaderText = "Estado"
        Me.img.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.cell_layout
        Me.img.Name = "img"
        Me.img.ReadOnly = True
        Me.img.Width = 50
        '
        'NRCTCL
        '
        Me.NRCTCL.DataPropertyName = "NRCTCL"
        Me.NRCTCL.HeaderText = "NRCTCL"
        Me.NRCTCL.Name = "NRCTCL"
        Me.NRCTCL.ReadOnly = True
        Me.NRCTCL.Visible = False
        '
        'NRCTSL
        '
        Me.NRCTSL.DataPropertyName = "NRCTSL"
        Me.NRCTSL.HeaderText = "NRCTSL"
        Me.NRCTSL.Name = "NRCTSL"
        Me.NRCTSL.ReadOnly = True
        Me.NRCTSL.Visible = False
        '
        'CRGVTA
        '
        Me.CRGVTA.DataPropertyName = "CRGVTA"
        Me.CRGVTA.HeaderText = "CRGVTA"
        Me.CRGVTA.Name = "CRGVTA"
        Me.CRGVTA.ReadOnly = True
        Me.CRGVTA.Visible = False
        '
        'UCclienteSolmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "UCclienteSolmin"
        Me.Size = New System.Drawing.Size(1077, 600)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtgClientes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCliente_TxtF011 As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcClienteGrupo As Ransa.Controls.GrupoCliente.ucClienteGrupo_TxtF01
    Friend WithEvents cmbRegionVenta As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContratosTarifaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imgTarifa As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents NRCTCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRCTSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRGVTA As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
