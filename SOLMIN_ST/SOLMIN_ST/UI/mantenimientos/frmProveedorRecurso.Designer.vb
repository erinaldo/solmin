<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorRecurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorRecurso))
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SINDRC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUCPR2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SINDRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANT_TRACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANT_ACOPLADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANT_EQUIPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADO_HOMOLOGACION = New System.Windows.Forms.DataGridViewImageColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnNuevoProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnEliminarProv = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnExportar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.txtRazonSocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtRUC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabAlquiler = New System.Windows.Forms.TabControl
        Me.tabUnidAlquiler = New System.Windows.Forms.TabPage
        Me.gwdUnidAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCMPN_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPRCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLRCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MARCA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPO_UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECINI_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECFIN_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ASIG = New System.Windows.Forms.DataGridViewImageColumn
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscarUndAlq = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbAsignacion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.txtPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoRecurso = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarUnidades = New System.Windows.Forms.ToolStripButton
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
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.KryptonComboBox2 = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonCheckBox1 = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.TabAlquiler.SuspendLayout()
        Me.tabUnidAlquiler.SuspendLayout()
        CType(Me.gwdUnidAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(984, 690)
        Me.KryptonPanel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gwdDatos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup2)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 690)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.TabIndex = 0
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.CTRSPT, Me.NRUCTR, Me.TCMTRT, Me.SINDRC_S, Me.TDRCTR, Me.RUCPR2, Me.SINDRC, Me.CANT_TRACTO, Me.CANT_ACOPLADO, Me.CANT_EQUIPO, Me.ESTADO_HOMOLOGACION, Me.SESTRG, Me.Column1})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 108)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(984, 256)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 5
        '
        'CCMPN
        '
        Me.CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.FillWeight = 80.0!
        Me.CCMPN.HeaderText = "Compañía"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 91
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Código"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        Me.CTRSPT.Width = 75
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Width = 59
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Razón Social"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 102
        '
        'SINDRC_S
        '
        Me.SINDRC_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SINDRC_S.DataPropertyName = "SINDRC_S"
        Me.SINDRC_S.HeaderText = "Tipo"
        Me.SINDRC_S.Name = "SINDRC_S"
        Me.SINDRC_S.ReadOnly = True
        Me.SINDRC_S.Width = 60
        '
        'TDRCTR
        '
        Me.TDRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDRCTR.DataPropertyName = "TDRCTR"
        Me.TDRCTR.HeaderText = "Dirección"
        Me.TDRCTR.Name = "TDRCTR"
        Me.TDRCTR.ReadOnly = True
        Me.TDRCTR.Width = 86
        '
        'RUCPR2
        '
        Me.RUCPR2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUCPR2.DataPropertyName = "RUCPR2"
        Me.RUCPR2.HeaderText = "Cuenta Acreedora SAP"
        Me.RUCPR2.Name = "RUCPR2"
        Me.RUCPR2.ReadOnly = True
        Me.RUCPR2.Width = 155
        '
        'SINDRC
        '
        Me.SINDRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SINDRC.DataPropertyName = "SINDRC"
        Me.SINDRC.HeaderText = "SINDRC"
        Me.SINDRC.Name = "SINDRC"
        Me.SINDRC.ReadOnly = True
        Me.SINDRC.Visible = False
        Me.SINDRC.Width = 77
        '
        'CANT_TRACTO
        '
        Me.CANT_TRACTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_TRACTO.DataPropertyName = "CANT_TRACTO"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CANT_TRACTO.DefaultCellStyle = DataGridViewCellStyle1
        Me.CANT_TRACTO.HeaderText = "Cant. Tracto"
        Me.CANT_TRACTO.Name = "CANT_TRACTO"
        Me.CANT_TRACTO.ReadOnly = True
        Me.CANT_TRACTO.Width = 101
        '
        'CANT_ACOPLADO
        '
        Me.CANT_ACOPLADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_ACOPLADO.DataPropertyName = "CANT_ACOPLADO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CANT_ACOPLADO.DefaultCellStyle = DataGridViewCellStyle2
        Me.CANT_ACOPLADO.HeaderText = "Cant. Acoplado"
        Me.CANT_ACOPLADO.Name = "CANT_ACOPLADO"
        Me.CANT_ACOPLADO.ReadOnly = True
        Me.CANT_ACOPLADO.Width = 118
        '
        'CANT_EQUIPO
        '
        Me.CANT_EQUIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_EQUIPO.DataPropertyName = "CANT_EQUIPO"
        Me.CANT_EQUIPO.HeaderText = "Cant. Equipo"
        Me.CANT_EQUIPO.Name = "CANT_EQUIPO"
        Me.CANT_EQUIPO.ReadOnly = True
        Me.CANT_EQUIPO.Width = 104
        '
        'ESTADO_HOMOLOGACION
        '
        Me.ESTADO_HOMOLOGACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO_HOMOLOGACION.DataPropertyName = "ESTADO_HOMOLOGACION"
        Me.ESTADO_HOMOLOGACION.HeaderText = "Homologación"
        Me.ESTADO_HOMOLOGACION.Image = Global.SOLMIN_ST.My.Resources.Resources.text_block
        Me.ESTADO_HOMOLOGACION.Name = "ESTADO_HOMOLOGACION"
        Me.ESTADO_HOMOLOGACION.ReadOnly = True
        Me.ESTADO_HOMOLOGACION.Width = 97
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "SESTRG"
        Me.SESTRG.HeaderText = "SESTRG"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnNuevoProv, Me.btnEliminarProv, Me.btnExportar, Me.btnBuscar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonCheckBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonComboBox2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonTextBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtRazonSocial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtRUC)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(984, 108)
        Me.KryptonHeaderGroup1.TabIndex = 1
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnNuevoProv
        '
        Me.btnNuevoProv.ExtraText = ""
        Me.btnNuevoProv.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnNuevoProv.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoProv.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnNuevoProv.Text = "Nuevo"
        Me.btnNuevoProv.ToolTipImage = Nothing
        Me.btnNuevoProv.UniqueName = "578FB980BBF14157578FB980BBF14157"
        '
        'btnEliminarProv
        '
        Me.btnEliminarProv.ExtraText = ""
        Me.btnEliminarProv.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnEliminarProv.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminarProv.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnEliminarProv.Text = "Eliminar"
        Me.btnEliminarProv.ToolTipImage = Nothing
        Me.btnEliminarProv.UniqueName = "0CF7CD77EC054B7C0CF7CD77EC054B7C"
        '
        'btnExportar
        '
        Me.btnExportar.ExtraText = ""
        Me.btnExportar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnExportar.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
        Me.btnExportar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.ToolTipImage = Nothing
        Me.btnExportar.UniqueName = "B70445ED53F049E5B70445ED53F049E5"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "6C5F317DD7BC40196C5F317DD7BC4019"
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(784, 41)
        Me.KryptonTextBox1.MaxLength = 15
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(115, 22)
        Me.KryptonTextBox1.TabIndex = 145
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(739, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel3.TabIndex = 144
        Me.KryptonLabel3.Text = "Placa"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Placa"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel5.Location = New System.Drawing.Point(545, 42)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel5.TabIndex = 142
        Me.KryptonLabel5.Text = "Tipo Recurso"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Tipo Recurso"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(342, 10)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel2.TabIndex = 138
        Me.KryptonLabel2.Text = "División"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "División"
        '
        'cmbDivision
        '
        Me.cmbDivision.BackColor = System.Drawing.Color.Transparent
        Me.cmbDivision.CDVSN_ANTERIOR = Nothing
        Me.cmbDivision.Compania = ""
        Me.cmbDivision.Division = Nothing
        Me.cmbDivision.DivisionDefault = Nothing
        Me.cmbDivision.DivisionDescripcion = Nothing
        Me.cmbDivision.ItemTodos = False
        Me.cmbDivision.Location = New System.Drawing.Point(427, 12)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.obeDivision = Nothing
        Me.cmbDivision.pHabilitado = True
        Me.cmbDivision.pRequerido = False
        Me.cmbDivision.Size = New System.Drawing.Size(223, 23)
        Me.cmbDivision.TabIndex = 139
        Me.cmbDivision.Usuario = ""
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(294, 39)
        Me.txtRazonSocial.MaxLength = 40
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(216, 22)
        Me.txtRazonSocial.TabIndex = 133
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(209, 41)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(79, 20)
        Me.KryptonLabel1.TabIndex = 132
        Me.KryptonLabel1.Text = "Razón Social"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Razón Social"
        '
        'txtRUC
        '
        Me.txtRUC.Location = New System.Drawing.Point(73, 39)
        Me.txtRUC.MaxLength = 15
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(130, 22)
        Me.txtRUC.TabIndex = 131
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Habilitar = True
        Me.cmbCompania.Location = New System.Drawing.Point(73, 11)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.cmbCompania.oBeCompania = BeCompania1
        Me.cmbCompania.Size = New System.Drawing.Size(252, 24)
        Me.cmbCompania.TabIndex = 130
        Me.cmbCompania.Usuario = ""
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(6, 41)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel7.TabIndex = 126
        Me.KryptonLabel7.Text = "RUC"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "RUC"
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.Location = New System.Drawing.Point(6, 13)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 20)
        Me.lblCompania.TabIndex = 124
        Me.lblCompania.Text = "Compañía"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía"
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom
        Me.KryptonHeaderGroup2.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.TabAlquiler)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(984, 322)
        Me.KryptonHeaderGroup2.TabIndex = 2
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Unidades para Alquiler"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'TabAlquiler
        '
        Me.TabAlquiler.Controls.Add(Me.tabUnidAlquiler)
        Me.TabAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAlquiler.Location = New System.Drawing.Point(0, 25)
        Me.TabAlquiler.Name = "TabAlquiler"
        Me.TabAlquiler.SelectedIndex = 0
        Me.TabAlquiler.Size = New System.Drawing.Size(982, 274)
        Me.TabAlquiler.TabIndex = 0
        '
        'tabUnidAlquiler
        '
        Me.tabUnidAlquiler.Controls.Add(Me.gwdUnidAlquiler)
        Me.tabUnidAlquiler.Controls.Add(Me.KryptonHeaderGroup3)
        Me.tabUnidAlquiler.Location = New System.Drawing.Point(4, 22)
        Me.tabUnidAlquiler.Name = "tabUnidAlquiler"
        Me.tabUnidAlquiler.Padding = New System.Windows.Forms.Padding(3)
        Me.tabUnidAlquiler.Size = New System.Drawing.Size(974, 248)
        Me.tabUnidAlquiler.TabIndex = 1
        Me.tabUnidAlquiler.Text = "Unidades para Alquiler"
        Me.tabUnidAlquiler.UseVisualStyleBackColor = True
        '
        'gwdUnidAlquiler
        '
        Me.gwdUnidAlquiler.AllowUserToAddRows = False
        Me.gwdUnidAlquiler.AllowUserToDeleteRows = False
        Me.gwdUnidAlquiler.AllowUserToOrderColumns = True
        Me.gwdUnidAlquiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdUnidAlquiler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdUnidAlquiler.ColumnHeadersHeight = 30
        Me.gwdUnidAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdUnidAlquiler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN_1, Me.CDVSN, Me.STPRCS, Me.TDSDES, Me.NPLRCS, Me.MARCA, Me.TIPO_UNIDAD, Me.FECINI_S, Me.FECFIN_S, Me.DataGridViewTextBoxColumn12, Me.ASIG})
        Me.gwdUnidAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdUnidAlquiler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdUnidAlquiler.Location = New System.Drawing.Point(3, 46)
        Me.gwdUnidAlquiler.MultiSelect = False
        Me.gwdUnidAlquiler.Name = "gwdUnidAlquiler"
        Me.gwdUnidAlquiler.ReadOnly = True
        Me.gwdUnidAlquiler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdUnidAlquiler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gwdUnidAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdUnidAlquiler.Size = New System.Drawing.Size(968, 199)
        Me.gwdUnidAlquiler.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdUnidAlquiler.TabIndex = 5
        '
        'CCMPN_1
        '
        Me.CCMPN_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN_1.DataPropertyName = "CCMPN"
        Me.CCMPN_1.FillWeight = 80.0!
        Me.CCMPN_1.HeaderText = "Compañía"
        Me.CCMPN_1.Name = "CCMPN_1"
        Me.CCMPN_1.ReadOnly = True
        Me.CCMPN_1.Visible = False
        Me.CCMPN_1.Width = 91
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'STPRCS
        '
        Me.STPRCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STPRCS.DataPropertyName = "STPRCS"
        Me.STPRCS.HeaderText = "STPRCS"
        Me.STPRCS.Name = "STPRCS"
        Me.STPRCS.ReadOnly = True
        Me.STPRCS.Visible = False
        Me.STPRCS.Width = 77
        '
        'TDSDES
        '
        Me.TDSDES.DataPropertyName = "TDSDES"
        Me.TDSDES.HeaderText = "Tipo Recurso"
        Me.TDSDES.Name = "TDSDES"
        Me.TDSDES.ReadOnly = True
        '
        'NPLRCS
        '
        Me.NPLRCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLRCS.DataPropertyName = "NPLRCS"
        Me.NPLRCS.HeaderText = "Placa"
        Me.NPLRCS.Name = "NPLRCS"
        Me.NPLRCS.ReadOnly = True
        Me.NPLRCS.Width = 64
        '
        'MARCA
        '
        Me.MARCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MARCA.DataPropertyName = "MARCA"
        Me.MARCA.HeaderText = "Marca"
        Me.MARCA.Name = "MARCA"
        Me.MARCA.ReadOnly = True
        Me.MARCA.Width = 69
        '
        'TIPO_UNIDAD
        '
        Me.TIPO_UNIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_UNIDAD.DataPropertyName = "TIPO_UNIDAD"
        Me.TIPO_UNIDAD.HeaderText = "Tipo Unidad"
        Me.TIPO_UNIDAD.Name = "TIPO_UNIDAD"
        Me.TIPO_UNIDAD.ReadOnly = True
        Me.TIPO_UNIDAD.Width = 101
        '
        'FECINI_S
        '
        Me.FECINI_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI_S.DataPropertyName = "FECINI_S"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECINI_S.DefaultCellStyle = DataGridViewCellStyle3
        Me.FECINI_S.HeaderText = "Fecha Inicio Asignación"
        Me.FECINI_S.Name = "FECINI_S"
        Me.FECINI_S.ReadOnly = True
        Me.FECINI_S.Width = 161
        '
        'FECFIN_S
        '
        Me.FECFIN_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN_S.DataPropertyName = "FECFIN_S"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FECFIN_S.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECFIN_S.HeaderText = "Fecha Fin Asignación"
        Me.FECFIN_S.Name = "FECFIN_S"
        Me.FECFIN_S.ReadOnly = True
        Me.FECFIN_S.Width = 148
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CUSCRT"
        Me.DataGridViewTextBoxColumn12.HeaderText = " "
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'ASIG
        '
        Me.ASIG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ASIG.HeaderText = "Asignación"
        Me.ASIG.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.ASIG.Name = "ASIG"
        Me.ASIG.ReadOnly = True
        Me.ASIG.Width = 76
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1, Me.ButtonSpecHeaderGroup2})
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.btnBuscarUndAlq)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.cmbAsignacion)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.txtPlaca)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.cmbTipoRecurso)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(968, 43)
        Me.KryptonHeaderGroup3.TabIndex = 6
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.ButtonSpecHeaderGroup1.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
        Me.ButtonSpecHeaderGroup1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.ButtonSpecHeaderGroup1.Text = "Exportar"
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.UniqueName = "B70445ED53F049E5B70445ED53F049E5"
        '
        'ButtonSpecHeaderGroup2
        '
        Me.ButtonSpecHeaderGroup2.ExtraText = ""
        Me.ButtonSpecHeaderGroup2.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.ButtonSpecHeaderGroup2.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.ButtonSpecHeaderGroup2.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.ButtonSpecHeaderGroup2.Text = "Buscar"
        Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup2.UniqueName = "6C5F317DD7BC40196C5F317DD7BC4019"
        '
        'btnBuscarUndAlq
        '
        Me.btnBuscarUndAlq.Location = New System.Drawing.Point(639, 8)
        Me.btnBuscarUndAlq.Name = "btnBuscarUndAlq"
        Me.btnBuscarUndAlq.Size = New System.Drawing.Size(70, 25)
        Me.btnBuscarUndAlq.TabIndex = 144
        Me.btnBuscarUndAlq.Text = "Buscar"
        Me.btnBuscarUndAlq.Values.ExtraText = ""
        Me.btnBuscarUndAlq.Values.Image = Nothing
        Me.btnBuscarUndAlq.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscarUndAlq.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscarUndAlq.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscarUndAlq.Values.Text = "Buscar"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel4.Location = New System.Drawing.Point(432, 11)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel4.TabIndex = 143
        Me.KryptonLabel4.Text = "Asignación"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Asignación"
        '
        'cmbAsignacion
        '
        Me.cmbAsignacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAsignacion.DropDownWidth = 121
        Me.cmbAsignacion.FormattingEnabled = False
        Me.cmbAsignacion.ItemHeight = 15
        Me.cmbAsignacion.Location = New System.Drawing.Point(511, 9)
        Me.cmbAsignacion.Name = "cmbAsignacion"
        Me.cmbAsignacion.Size = New System.Drawing.Size(100, 23)
        Me.cmbAsignacion.TabIndex = 142
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(270, 11)
        Me.txtPlaca.MaxLength = 15
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(115, 22)
        Me.txtPlaca.TabIndex = 141
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel6.Location = New System.Drawing.Point(225, 11)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel6.TabIndex = 140
        Me.KryptonLabel6.Text = "Placa"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Placa"
        '
        'cmbTipoRecurso
        '
        Me.cmbTipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoRecurso.DropDownWidth = 121
        Me.cmbTipoRecurso.FormattingEnabled = False
        Me.cmbTipoRecurso.ItemHeight = 15
        Me.cmbTipoRecurso.Location = New System.Drawing.Point(95, 8)
        Me.cmbTipoRecurso.Name = "cmbTipoRecurso"
        Me.cmbTipoRecurso.Size = New System.Drawing.Size(100, 23)
        Me.cmbTipoRecurso.TabIndex = 138
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel9.Location = New System.Drawing.Point(8, 11)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel9.TabIndex = 124
        Me.KryptonLabel9.Text = "Tipo Recurso"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Tipo Recurso"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator1, Me.btnEliminar, Me.ToolStripSeparator2, Me.btnExportarUnidades})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(982, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportarUnidades
        '
        Me.btnExportarUnidades.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
        Me.btnExportarUnidades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarUnidades.Name = "btnExportarUnidades"
        Me.btnExportarUnidades.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarUnidades.Text = "Exportar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Compañía"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TDRCTR"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RUCPR2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cuenta Acreedora SAP"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SINDRC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SINDRC"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SINDRC_S"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tipo Prov."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CANT_TRACTO"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cant. Tracto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CANT_ACOPLADO"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cant. Acoplado"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CANT_EQUIPO"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cant. Equipo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CULUSA"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Usuario Actualizador"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = " "
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 5
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn15.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Compañía"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "STPRCS"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NPLRCS"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TIPO_UNIDAD"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Tipo Unidad"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "FECINI_S"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fecha Inicio Asignación"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FECFIN_S"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Fecha Fin Asignación"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "CUSCRT"
        Me.DataGridViewTextBoxColumn21.HeaderText = " "
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.DataPropertyName = "ESTADO_HOMOLOGACION"
        Me.DataGridViewImageColumn1.HeaderText = "Homologación"
        Me.DataGridViewImageColumn1.Image = Global.SOLMIN_ST.My.Resources.Resources.text_block
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = "Asignación"
        Me.DataGridViewImageColumn2.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'KryptonComboBox2
        '
        Me.KryptonComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KryptonComboBox2.DropDownWidth = 121
        Me.KryptonComboBox2.FormattingEnabled = False
        Me.KryptonComboBox2.ItemHeight = 15
        Me.KryptonComboBox2.Location = New System.Drawing.Point(633, 40)
        Me.KryptonComboBox2.Name = "KryptonComboBox2"
        Me.KryptonComboBox2.Size = New System.Drawing.Size(100, 23)
        Me.KryptonComboBox2.TabIndex = 146
        '
        'KryptonCheckBox1
        '
        Me.KryptonCheckBox1.Checked = False
        Me.KryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.KryptonCheckBox1.Location = New System.Drawing.Point(519, 43)
        Me.KryptonCheckBox1.Name = "KryptonCheckBox1"
        Me.KryptonCheckBox1.Size = New System.Drawing.Size(19, 13)
        Me.KryptonCheckBox1.TabIndex = 147
        Me.KryptonCheckBox1.Values.ExtraText = ""
        Me.KryptonCheckBox1.Values.Image = Nothing
        Me.KryptonCheckBox1.Values.Text = ""
        '
        'frmProveedorRecurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 690)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmProveedorRecurso"
        Me.Text = "Proveedor - Recursos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        Me.TabAlquiler.ResumeLayout(False)
        Me.tabUnidAlquiler.ResumeLayout(False)
        CType(Me.gwdUnidAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup3.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnExportar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtRazonSocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRUC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabAlquiler As System.Windows.Forms.TabControl
    Friend WithEvents tabUnidAlquiler As System.Windows.Forms.TabPage
    Friend WithEvents gwdUnidAlquiler As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarUnidades As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoRecurso As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscarUndAlq As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbAsignacion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
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
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNuevoProv As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnEliminarProv As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents CCMPN_1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPRCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLRCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_UNIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECINI_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFIN_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ASIG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINDRC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUCPR2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINDRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_TRACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_ACOPLADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_EQUIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_HOMOLOGACION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonComboBox1 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonComboBox2 As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonCheckBox1 As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
End Class
