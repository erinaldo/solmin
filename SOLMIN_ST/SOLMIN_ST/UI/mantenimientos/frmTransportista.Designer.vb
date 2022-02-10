<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransportista
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransportista))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABTRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLFTRP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SINDRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRACTOS_ASIGNADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACOPLADOS_ASIGNADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHOFERES_ASIGNADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUCPR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO_HOMOLOGACION = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.TabTransportista = New System.Windows.Forms.TabControl()
        Me.TabDatosTransportista = New System.Windows.Forms.TabPage()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.chkTercero = New System.Windows.Forms.CheckBox()
        Me.cboTranspAS400 = New CodeTextBox.CodeTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonBorderEdge5 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.KryptonBorderEdge4 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.txtTelefonoTransportista = New SOLMIN_ST.TextField()
        Me.txtDireccionTransportista = New SOLMIN_ST.TextField()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescripcion = New SOLMIN_ST.TextField()
        Me.txtRazonSocial = New SOLMIN_ST.TextField()
        Me.txtNroRuc = New SOLMIN_ST.TextField()
        Me.txtCodigoTransportista = New SOLMIN_ST.TextField()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabVehiculos = New System.Windows.Forms.TabPage()
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.gwdResTractosTransportista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NRUCTR_VH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEJSUN_VH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPLACP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCHOFER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBS_VH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCHCRT_VH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRACRT_VH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonHeader1 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.TabAcoplados = New System.Windows.Forms.TabPage()
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.gwdResAcopladosTransportista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCVH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NEJSUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECINI_AC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECFIN_AC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonHeader2 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.TabConductores = New System.Windows.Forms.TabPage()
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.gwdResConductoresTransportista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TNMCMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAPPAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAPMAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECINI_CH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECFIN_CH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOBSCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCHCRT_TRACTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRACRT_TRACTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KryptonHeader3 = New ComponentFactory.Krypton.Toolkit.KryptonHeader()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.Separator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimirTR = New System.Windows.Forms.ToolStripButton()
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnImprimirTRTodos = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnExportarExcel = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnHabilitar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnBusqueda = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPlanta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.cmbDivision = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbCompania = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFiltroTransportista = New SOLMIN_ST.TextField()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.TabTransportista.SuspendLayout()
        Me.TabDatosTransportista.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.TabVehiculos.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.gwdResTractosTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAcoplados.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.gwdResAcopladosTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConductores.SuspendLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        CType(Me.gwdResConductoresTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(998, 720)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.gwdDatos)
        Me.KryptonPanel1.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel1.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(998, 720)
        Me.KryptonPanel1.TabIndex = 1
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTRSPT, Me.NRUCTR, Me.TCMTRT, Me.TABTRT, Me.TLFTRP, Me.TDRCTR, Me.SINDRC, Me.TRACTOS_ASIGNADOS, Me.ACOPLADOS_ASIGNADOS, Me.CHOFERES_ASIGNADOS, Me.CCMPN, Me.CDVSN, Me.CPLNDV, Me.RUCPR2, Me.ESTADO_HOMOLOGACION, Me.SESTRG})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 100)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(998, 320)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 5
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Código"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        Me.CTRSPT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTRSPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTRSPT.Width = 68
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NRUCTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRUCTR.Width = 47
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.FillWeight = 300.0!
        Me.TCMTRT.HeaderText = "Razón social"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TCMTRT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCMTRT.Width = 102
        '
        'TABTRT
        '
        Me.TABTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TABTRT.DataPropertyName = "TABTRT"
        Me.TABTRT.HeaderText = "Descripción Abrev."
        Me.TABTRT.Name = "TABTRT"
        Me.TABTRT.ReadOnly = True
        '
        'TLFTRP
        '
        Me.TLFTRP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TLFTRP.DataPropertyName = "TLFTRP"
        Me.TLFTRP.HeaderText = "Teléfono"
        Me.TLFTRP.Name = "TLFTRP"
        Me.TLFTRP.ReadOnly = True
        '
        'TDRCTR
        '
        Me.TDRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDRCTR.DataPropertyName = "TDRCTR"
        Me.TDRCTR.FillWeight = 50.0!
        Me.TDRCTR.HeaderText = "Dirección"
        Me.TDRCTR.Name = "TDRCTR"
        Me.TDRCTR.ReadOnly = True
        Me.TDRCTR.Width = 105
        '
        'SINDRC
        '
        Me.SINDRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SINDRC.DataPropertyName = "SINDRC"
        Me.SINDRC.HeaderText = "SINDRC"
        Me.SINDRC.Name = "SINDRC"
        Me.SINDRC.ReadOnly = True
        Me.SINDRC.Visible = False
        Me.SINDRC.Width = 94
        '
        'TRACTOS_ASIGNADOS
        '
        Me.TRACTOS_ASIGNADOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TRACTOS_ASIGNADOS.DataPropertyName = "TRACTOS_ASIGNADOS"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TRACTOS_ASIGNADOS.DefaultCellStyle = DataGridViewCellStyle1
        Me.TRACTOS_ASIGNADOS.HeaderText = "Tractos Asignados"
        Me.TRACTOS_ASIGNADOS.Name = "TRACTOS_ASIGNADOS"
        Me.TRACTOS_ASIGNADOS.ReadOnly = True
        Me.TRACTOS_ASIGNADOS.Width = 162
        '
        'ACOPLADOS_ASIGNADOS
        '
        Me.ACOPLADOS_ASIGNADOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ACOPLADOS_ASIGNADOS.DataPropertyName = "ACOPLADOS_ASIGNADOS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ACOPLADOS_ASIGNADOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.ACOPLADOS_ASIGNADOS.HeaderText = "Acoplados Asignados"
        Me.ACOPLADOS_ASIGNADOS.Name = "ACOPLADOS_ASIGNADOS"
        Me.ACOPLADOS_ASIGNADOS.ReadOnly = True
        Me.ACOPLADOS_ASIGNADOS.Width = 186
        '
        'CHOFERES_ASIGNADOS
        '
        Me.CHOFERES_ASIGNADOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CHOFERES_ASIGNADOS.DataPropertyName = "CHOFERES_ASIGNADOS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CHOFERES_ASIGNADOS.DefaultCellStyle = DataGridViewCellStyle3
        Me.CHOFERES_ASIGNADOS.HeaderText = "Choferes Asignados"
        Me.CHOFERES_ASIGNADOS.Name = "CHOFERES_ASIGNADOS"
        Me.CHOFERES_ASIGNADOS.ReadOnly = True
        Me.CHOFERES_ASIGNADOS.Width = 173
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSB"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "CPLNDV"
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.ReadOnly = True
        Me.CPLNDV.Visible = False
        '
        'RUCPR2
        '
        Me.RUCPR2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUCPR2.DataPropertyName = "RUCPR2"
        Me.RUCPR2.HeaderText = "Cuenta Acreedor SAP"
        Me.RUCPR2.Name = "RUCPR2"
        Me.RUCPR2.ReadOnly = True
        Me.RUCPR2.Visible = False
        Me.RUCPR2.Width = 183
        '
        'ESTADO_HOMOLOGACION
        '
        Me.ESTADO_HOMOLOGACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADO_HOMOLOGACION.DataPropertyName = "ESTADO_HOMOLOGACION"
        Me.ESTADO_HOMOLOGACION.HeaderText = "Estado Homologación"
        Me.ESTADO_HOMOLOGACION.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.ESTADO_HOMOLOGACION.Name = "ESTADO_HOMOLOGACION"
        Me.ESTADO_HOMOLOGACION.ReadOnly = True
        Me.ESTADO_HOMOLOGACION.Width = 168
        '
        'SESTRG
        '
        Me.SESTRG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTRG.DataPropertyName = "SESTRG"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SESTRG.DefaultCellStyle = DataGridViewCellStyle4
        Me.SESTRG.HeaderText = "Estado"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Width = 87
        '
        'HeaderDatos
        '
        Me.HeaderDatos.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 420)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.TabTransportista)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(998, 300)
        Me.HeaderDatos.TabIndex = 3
        Me.HeaderDatos.Text = "Información a Registrar"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información a Registrar"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Global.SOLMIN_ST.My.Resources.Resources.edit_add
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.UniqueName = "891F91AE0D1B4285891F91AE0D1B4285"
        '
        'TabTransportista
        '
        Me.TabTransportista.Controls.Add(Me.TabDatosTransportista)
        Me.TabTransportista.Controls.Add(Me.TabVehiculos)
        Me.TabTransportista.Controls.Add(Me.TabAcoplados)
        Me.TabTransportista.Controls.Add(Me.TabConductores)
        Me.TabTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTransportista.ImageList = Me.ImageList1
        Me.TabTransportista.Location = New System.Drawing.Point(0, 27)
        Me.TabTransportista.Name = "TabTransportista"
        Me.TabTransportista.SelectedIndex = 0
        Me.TabTransportista.Size = New System.Drawing.Size(996, 244)
        Me.TabTransportista.TabIndex = 2
        '
        'TabDatosTransportista
        '
        Me.TabDatosTransportista.Controls.Add(Me.KryptonHeaderGroup1)
        Me.TabDatosTransportista.ImageIndex = 3
        Me.TabDatosTransportista.Location = New System.Drawing.Point(4, 26)
        Me.TabDatosTransportista.Name = "TabDatosTransportista"
        Me.TabDatosTransportista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDatosTransportista.Size = New System.Drawing.Size(988, 214)
        Me.TabDatosTransportista.TabIndex = 0
        Me.TabDatosTransportista.Text = "Datos del Transportista"
        Me.TabDatosTransportista.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chkTercero)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboTranspAS400)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonBorderEdge4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTelefonoTransportista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccionTransportista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtRazonSocial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroRuc)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigoTransportista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(982, 208)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Información General del Transportista"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'chkTercero
        '
        Me.chkTercero.AutoSize = True
        Me.chkTercero.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.chkTercero.Checked = True
        Me.chkTercero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTercero.Location = New System.Drawing.Point(765, 14)
        Me.chkTercero.Name = "chkTercero"
        Me.chkTercero.Size = New System.Drawing.Size(95, 21)
        Me.chkTercero.TabIndex = 19
        Me.chkTercero.Text = "Es Tercero"
        Me.chkTercero.UseVisualStyleBackColor = False
        '
        'cboTranspAS400
        '
        Me.cboTranspAS400.Codigo = ""
        Me.cboTranspAS400.ControlHeight = 23
        Me.cboTranspAS400.ControlImage = True
        Me.cboTranspAS400.ControlReadOnly = False
        Me.cboTranspAS400.Descripcion = ""
        Me.cboTranspAS400.DisplayColumnVisible = True
        Me.cboTranspAS400.DisplayMember = ""
        Me.cboTranspAS400.KeyColumnWidth = 100
        Me.cboTranspAS400.KeyField = ""
        Me.cboTranspAS400.KeySearch = True
        Me.cboTranspAS400.Location = New System.Drawing.Point(130, 70)
        Me.cboTranspAS400.Name = "cboTranspAS400"
        Me.cboTranspAS400.Size = New System.Drawing.Size(280, 23)
        Me.cboTranspAS400.TabIndex = 18
        Me.cboTranspAS400.TextBackColor = System.Drawing.Color.Empty
        Me.cboTranspAS400.TextForeColor = System.Drawing.Color.Empty
        Me.cboTranspAS400.ValueColumnVisible = True
        Me.cboTranspAS400.ValueColumnWidth = 600
        Me.cboTranspAS400.ValueField = ""
        Me.cboTranspAS400.ValueMember = ""
        Me.cboTranspAS400.ValueSearch = True
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(430, 72)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(71, 26)
        Me.KryptonLabel8.TabIndex = 17
        Me.KryptonLabel8.Text = "Teléfono"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Teléfono"
        '
        'KryptonBorderEdge5
        '
        Me.KryptonBorderEdge5.Location = New System.Drawing.Point(749, 11)
        Me.KryptonBorderEdge5.Name = "KryptonBorderEdge5"
        Me.KryptonBorderEdge5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge5.Size = New System.Drawing.Size(1, 80)
        Me.KryptonBorderEdge5.TabIndex = 16
        Me.KryptonBorderEdge5.Text = "KryptonBorderEdge4"
        '
        'KryptonBorderEdge4
        '
        Me.KryptonBorderEdge4.Location = New System.Drawing.Point(420, 10)
        Me.KryptonBorderEdge4.Name = "KryptonBorderEdge4"
        Me.KryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge4.Size = New System.Drawing.Size(1, 110)
        Me.KryptonBorderEdge4.TabIndex = 16
        Me.KryptonBorderEdge4.Text = "KryptonBorderEdge4"
        '
        'txtTelefonoTransportista
        '
        Me.txtTelefonoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefonoTransportista.Location = New System.Drawing.Point(526, 71)
        Me.txtTelefonoTransportista.MaxLength = 15
        Me.txtTelefonoTransportista.Name = "txtTelefonoTransportista"
        Me.txtTelefonoTransportista.Size = New System.Drawing.Size(210, 26)
        Me.txtTelefonoTransportista.TabIndex = 13
        Me.txtTelefonoTransportista.Text = "0"
        Me.txtTelefonoTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtDireccionTransportista
        '
        Me.txtDireccionTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionTransportista.Location = New System.Drawing.Point(526, 42)
        Me.txtDireccionTransportista.MaxLength = 30
        Me.txtDireccionTransportista.Name = "txtDireccionTransportista"
        Me.txtDireccionTransportista.Size = New System.Drawing.Size(210, 26)
        Me.txtDireccionTransportista.TabIndex = 12
        Me.txtDireccionTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(430, 43)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(129, 26)
        Me.KryptonLabel9.TabIndex = 8
        Me.KryptonLabel9.Text = "Dirección Transp."
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Dirección Transp."
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(526, 14)
        Me.txtDescripcion.MaxLength = 20
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(210, 26)
        Me.txtDescripcion.TabIndex = 7
        Me.txtDescripcion.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Location = New System.Drawing.Point(130, 42)
        Me.txtRazonSocial.MaxLength = 40
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(280, 26)
        Me.txtRazonSocial.TabIndex = 6
        Me.txtRazonSocial.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtNroRuc
        '
        Me.txtNroRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroRuc.Location = New System.Drawing.Point(130, 14)
        Me.txtNroRuc.MaxLength = 11
        Me.txtNroRuc.Name = "txtNroRuc"
        Me.txtNroRuc.Size = New System.Drawing.Size(120, 26)
        Me.txtNroRuc.TabIndex = 5
        Me.txtNroRuc.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtCodigoTransportista
        '
        Me.txtCodigoTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTransportista.Location = New System.Drawing.Point(130, 102)
        Me.txtCodigoTransportista.MaxLength = 10
        Me.txtCodigoTransportista.Name = "txtCodigoTransportista"
        Me.txtCodigoTransportista.Size = New System.Drawing.Size(120, 26)
        Me.txtCodigoTransportista.TabIndex = 4
        Me.txtCodigoTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(430, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(91, 26)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Text = "Descripción"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Descripción"
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(8, 72)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(143, 26)
        Me.KryptonLabel14.TabIndex = 2
        Me.KryptonLabel14.Text = "Cód. Transp. AS400"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Cód. Transp. AS400"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(8, 43)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(97, 26)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Razón Social"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Razón Social"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(8, 103)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(157, 26)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Text = "Cuenta Acreedor SAP"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cuenta Acreedor SAP"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(82, 26)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Nro  R.U.C"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro  R.U.C"
        '
        'TabVehiculos
        '
        Me.TabVehiculos.Controls.Add(Me.KryptonHeaderGroup2)
        Me.TabVehiculos.ImageIndex = 1
        Me.TabVehiculos.Location = New System.Drawing.Point(4, 26)
        Me.TabVehiculos.Name = "TabVehiculos"
        Me.TabVehiculos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVehiculos.Size = New System.Drawing.Size(988, 214)
        Me.TabVehiculos.TabIndex = 1
        Me.TabVehiculos.Text = "Vehículos por Transportista"
        Me.TabVehiculos.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.gwdResTractosTransportista)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonHeader1)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(982, 208)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'gwdResTractosTransportista
        '
        Me.gwdResTractosTransportista.AllowUserToAddRows = False
        Me.gwdResTractosTransportista.AllowUserToDeleteRows = False
        Me.gwdResTractosTransportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdResTractosTransportista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdResTractosTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdResTractosTransportista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRUCTR_VH, Me.NPLCUN, Me.TMRCTR, Me.NEJSUN_VH, Me.NPLACP, Me.CBRCND, Me.NOMCHOFER, Me.FECINI, Me.FECFIN, Me.SESTCM, Me.TOBS_VH, Me.FCHCRT_VH, Me.HRACRT_VH})
        Me.gwdResTractosTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdResTractosTransportista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdResTractosTransportista.Location = New System.Drawing.Point(0, 24)
        Me.gwdResTractosTransportista.MultiSelect = False
        Me.gwdResTractosTransportista.Name = "gwdResTractosTransportista"
        Me.gwdResTractosTransportista.ReadOnly = True
        Me.gwdResTractosTransportista.RowHeadersWidth = 24
        Me.gwdResTractosTransportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdResTractosTransportista.Size = New System.Drawing.Size(980, 155)
        Me.gwdResTractosTransportista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdResTractosTransportista.TabIndex = 0
        '
        'NRUCTR_VH
        '
        Me.NRUCTR_VH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR_VH.DataPropertyName = "NRUCTR"
        Me.NRUCTR_VH.HeaderText = "Ruc"
        Me.NRUCTR_VH.Name = "NRUCTR_VH"
        Me.NRUCTR_VH.ReadOnly = True
        Me.NRUCTR_VH.Visible = False
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Placa Vehículo"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        Me.NPLCUN.Width = 126
        '
        'TMRCTR
        '
        Me.TMRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCTR.DataPropertyName = "TMRCTR"
        Me.TMRCTR.HeaderText = "Marca"
        Me.TMRCTR.Name = "TMRCTR"
        Me.TMRCTR.ReadOnly = True
        Me.TMRCTR.Width = 83
        '
        'NEJSUN_VH
        '
        Me.NEJSUN_VH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NEJSUN_VH.DataPropertyName = "NEJSUN"
        Me.NEJSUN_VH.HeaderText = "Ejes"
        Me.NEJSUN_VH.Name = "NEJSUN_VH"
        Me.NEJSUN_VH.ReadOnly = True
        Me.NEJSUN_VH.Width = 68
        '
        'NPLACP
        '
        Me.NPLACP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLACP.DataPropertyName = "NPLACP"
        Me.NPLACP.HeaderText = "Placa Acoplado"
        Me.NPLACP.Name = "NPLACP"
        Me.NPLACP.ReadOnly = True
        Me.NPLACP.Width = 134
        '
        'CBRCND
        '
        Me.CBRCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCND.DataPropertyName = "CBRCNT"
        Me.CBRCND.HeaderText = "Brevete Conductor"
        Me.CBRCND.Name = "CBRCND"
        Me.CBRCND.ReadOnly = True
        Me.CBRCND.Width = 151
        '
        'NOMCHOFER
        '
        Me.NOMCHOFER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOMCHOFER.DataPropertyName = "NOMCHOFER"
        Me.NOMCHOFER.HeaderText = "Nombre Conductor"
        Me.NOMCHOFER.Name = "NOMCHOFER"
        Me.NOMCHOFER.ReadOnly = True
        Me.NOMCHOFER.Width = 156
        '
        'FECINI
        '
        Me.FECINI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI.DataPropertyName = "FECINI"
        Me.FECINI.HeaderText = "Fec. Ini. Asignación"
        Me.FECINI.MinimumWidth = 100
        Me.FECINI.Name = "FECINI"
        Me.FECINI.ReadOnly = True
        Me.FECINI.Width = 153
        '
        'FECFIN
        '
        Me.FECFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN.DataPropertyName = "FECFIN"
        Me.FECFIN.HeaderText = "Fec. Fin Asignación"
        Me.FECFIN.MinimumWidth = 100
        Me.FECFIN.Name = "FECFIN"
        Me.FECFIN.ReadOnly = True
        Me.FECFIN.Width = 153
        '
        'SESTCM
        '
        Me.SESTCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTCM.DataPropertyName = "SESTCM"
        Me.SESTCM.HeaderText = "Estado Asignación"
        Me.SESTCM.MinimumWidth = 100
        Me.SESTCM.Name = "SESTCM"
        Me.SESTCM.ReadOnly = True
        Me.SESTCM.Width = 150
        '
        'TOBS_VH
        '
        Me.TOBS_VH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBS_VH.DataPropertyName = "TOBS"
        Me.TOBS_VH.HeaderText = "Observaciones"
        Me.TOBS_VH.Name = "TOBS_VH"
        Me.TOBS_VH.ReadOnly = True
        '
        'FCHCRT_VH
        '
        Me.FCHCRT_VH.DataPropertyName = "FCHCRT"
        Me.FCHCRT_VH.HeaderText = "FCHCRT"
        Me.FCHCRT_VH.Name = "FCHCRT_VH"
        Me.FCHCRT_VH.ReadOnly = True
        Me.FCHCRT_VH.Visible = False
        '
        'HRACRT_VH
        '
        Me.HRACRT_VH.DataPropertyName = "HRACRT"
        Me.HRACRT_VH.HeaderText = "HRACRT"
        Me.HRACRT_VH.Name = "HRACRT_VH"
        Me.HRACRT_VH.ReadOnly = True
        Me.HRACRT_VH.Visible = False
        '
        'KryptonHeader1
        '
        Me.KryptonHeader1.AutoSize = False
        Me.KryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader1.Name = "KryptonHeader1"
        Me.KryptonHeader1.Size = New System.Drawing.Size(980, 24)
        Me.KryptonHeader1.TabIndex = 3
        Me.KryptonHeader1.Text = "Listado de Vehiculos Asignados al Transportista"
        Me.KryptonHeader1.Values.Description = ""
        Me.KryptonHeader1.Values.Heading = "Listado de Vehiculos Asignados al Transportista"
        Me.KryptonHeader1.Values.Image = Nothing
        '
        'TabAcoplados
        '
        Me.TabAcoplados.Controls.Add(Me.KryptonHeaderGroup3)
        Me.TabAcoplados.ImageIndex = 2
        Me.TabAcoplados.Location = New System.Drawing.Point(4, 26)
        Me.TabAcoplados.Name = "TabAcoplados"
        Me.TabAcoplados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAcoplados.Size = New System.Drawing.Size(988, 214)
        Me.TabAcoplados.TabIndex = 2
        Me.TabAcoplados.Text = "Acoplados por Transportista"
        Me.TabAcoplados.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.gwdResAcopladosTransportista)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonHeader2)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(982, 208)
        Me.KryptonHeaderGroup3.TabIndex = 1
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'gwdResAcopladosTransportista
        '
        Me.gwdResAcopladosTransportista.AllowUserToAddRows = False
        Me.gwdResAcopladosTransportista.AllowUserToDeleteRows = False
        Me.gwdResAcopladosTransportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdResAcopladosTransportista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdResAcopladosTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdResAcopladosTransportista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NPLCAC, Me.TMRCVH, Me.NEJSUN, Me.FECINI_AC, Me.FECFIN_AC, Me.SESTAC, Me.TOBS, Me.FCHCRT, Me.HRACRT})
        Me.gwdResAcopladosTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdResAcopladosTransportista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdResAcopladosTransportista.Location = New System.Drawing.Point(0, 24)
        Me.gwdResAcopladosTransportista.MultiSelect = False
        Me.gwdResAcopladosTransportista.Name = "gwdResAcopladosTransportista"
        Me.gwdResAcopladosTransportista.ReadOnly = True
        Me.gwdResAcopladosTransportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdResAcopladosTransportista.Size = New System.Drawing.Size(980, 155)
        Me.gwdResAcopladosTransportista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdResAcopladosTransportista.TabIndex = 7
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        Me.NPLCAC.FillWeight = 180.0!
        Me.NPLCAC.HeaderText = "Placa Acoplado"
        Me.NPLCAC.MinimumWidth = 100
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NPLCAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NPLCAC.Width = 111
        '
        'TMRCVH
        '
        Me.TMRCVH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCVH.DataPropertyName = "TMRCVH"
        Me.TMRCVH.HeaderText = "Marca"
        Me.TMRCVH.Name = "TMRCVH"
        Me.TMRCVH.ReadOnly = True
        Me.TMRCVH.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TMRCVH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TMRCVH.Width = 60
        '
        'NEJSUN
        '
        Me.NEJSUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NEJSUN.DataPropertyName = "NEJSUN"
        Me.NEJSUN.HeaderText = "Ejes"
        Me.NEJSUN.Name = "NEJSUN"
        Me.NEJSUN.ReadOnly = True
        Me.NEJSUN.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NEJSUN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NEJSUN.Width = 45
        '
        'FECINI_AC
        '
        Me.FECINI_AC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI_AC.DataPropertyName = "FECINI"
        Me.FECINI_AC.HeaderText = "Fec. Ini. Asignación"
        Me.FECINI_AC.MinimumWidth = 120
        Me.FECINI_AC.Name = "FECINI_AC"
        Me.FECINI_AC.ReadOnly = True
        Me.FECINI_AC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FECINI_AC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FECINI_AC.Width = 130
        '
        'FECFIN_AC
        '
        Me.FECFIN_AC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN_AC.DataPropertyName = "FECFIN"
        Me.FECFIN_AC.HeaderText = "Fec. Fin Asignación"
        Me.FECFIN_AC.MinimumWidth = 120
        Me.FECFIN_AC.Name = "FECFIN_AC"
        Me.FECFIN_AC.ReadOnly = True
        Me.FECFIN_AC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FECFIN_AC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FECFIN_AC.Width = 130
        '
        'SESTAC
        '
        Me.SESTAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTAC.DataPropertyName = "SESTAC"
        Me.SESTAC.HeaderText = "Estado Asignación"
        Me.SESTAC.MinimumWidth = 120
        Me.SESTAC.Name = "SESTAC"
        Me.SESTAC.ReadOnly = True
        Me.SESTAC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SESTAC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SESTAC.Width = 127
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Observaciones"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        '
        'FCHCRT
        '
        Me.FCHCRT.DataPropertyName = "FCHCRT"
        Me.FCHCRT.HeaderText = "FCHCRT"
        Me.FCHCRT.Name = "FCHCRT"
        Me.FCHCRT.ReadOnly = True
        Me.FCHCRT.Visible = False
        '
        'HRACRT
        '
        Me.HRACRT.DataPropertyName = "HRACRT"
        Me.HRACRT.HeaderText = "HRACRT"
        Me.HRACRT.Name = "HRACRT"
        Me.HRACRT.ReadOnly = True
        Me.HRACRT.Visible = False
        '
        'KryptonHeader2
        '
        Me.KryptonHeader2.AutoSize = False
        Me.KryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader2.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader2.Name = "KryptonHeader2"
        Me.KryptonHeader2.Size = New System.Drawing.Size(980, 24)
        Me.KryptonHeader2.TabIndex = 10
        Me.KryptonHeader2.Text = "Listado de Acoplados Asignados al Transportista"
        Me.KryptonHeader2.Values.Description = ""
        Me.KryptonHeader2.Values.Heading = "Listado de Acoplados Asignados al Transportista"
        Me.KryptonHeader2.Values.Image = Nothing
        '
        'TabConductores
        '
        Me.TabConductores.Controls.Add(Me.KryptonHeaderGroup4)
        Me.TabConductores.ImageIndex = 0
        Me.TabConductores.Location = New System.Drawing.Point(4, 26)
        Me.TabConductores.Name = "TabConductores"
        Me.TabConductores.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConductores.Size = New System.Drawing.Size(988, 214)
        Me.TabConductores.TabIndex = 3
        Me.TabConductores.Text = "Conductores por Transportista"
        Me.TabConductores.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup4.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.gwdResConductoresTransportista)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.KryptonHeader3)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(982, 208)
        Me.KryptonHeaderGroup4.TabIndex = 1
        Me.KryptonHeaderGroup4.Text = "Heading"
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup4.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        '
        'gwdResConductoresTransportista
        '
        Me.gwdResConductoresTransportista.AllowUserToAddRows = False
        Me.gwdResConductoresTransportista.AllowUserToDeleteRows = False
        Me.gwdResConductoresTransportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdResConductoresTransportista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdResConductoresTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gwdResConductoresTransportista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CBRCNT, Me.TNMCMC, Me.TAPPAC, Me.TAPMAC, Me.FECINI_CH, Me.FECFIN_CH, Me.SESTCH, Me.TOBSCH, Me.FCHCRT_TRACTO, Me.HRACRT_TRACTO})
        Me.gwdResConductoresTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdResConductoresTransportista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdResConductoresTransportista.Location = New System.Drawing.Point(0, 24)
        Me.gwdResConductoresTransportista.MultiSelect = False
        Me.gwdResConductoresTransportista.Name = "gwdResConductoresTransportista"
        Me.gwdResConductoresTransportista.ReadOnly = True
        Me.gwdResConductoresTransportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdResConductoresTransportista.Size = New System.Drawing.Size(980, 155)
        Me.gwdResConductoresTransportista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdResConductoresTransportista.TabIndex = 7
        '
        'CBRCNT
        '
        Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "Brevete"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.ReadOnly = True
        Me.CBRCNT.Width = 92
        '
        'TNMCMC
        '
        Me.TNMCMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMCMC.DataPropertyName = "TNMCMC"
        Me.TNMCMC.HeaderText = "Nombres"
        Me.TNMCMC.Name = "TNMCMC"
        Me.TNMCMC.ReadOnly = True
        Me.TNMCMC.Width = 103
        '
        'TAPPAC
        '
        Me.TAPPAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TAPPAC.DataPropertyName = "TAPPAC"
        Me.TAPPAC.HeaderText = "A Paterno"
        Me.TAPPAC.Name = "TAPPAC"
        Me.TAPPAC.ReadOnly = True
        Me.TAPPAC.Width = 98
        '
        'TAPMAC
        '
        Me.TAPMAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TAPMAC.DataPropertyName = "TAPMAC"
        Me.TAPMAC.HeaderText = "A Materno"
        Me.TAPMAC.Name = "TAPMAC"
        Me.TAPMAC.ReadOnly = True
        Me.TAPMAC.Width = 104
        '
        'FECINI_CH
        '
        Me.FECINI_CH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI_CH.DataPropertyName = "FECINI"
        Me.FECINI_CH.HeaderText = "Fec. Ini. Asignación"
        Me.FECINI_CH.Name = "FECINI_CH"
        Me.FECINI_CH.ReadOnly = True
        Me.FECINI_CH.Width = 153
        '
        'FECFIN_CH
        '
        Me.FECFIN_CH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN_CH.DataPropertyName = "FECFIN"
        Me.FECFIN_CH.HeaderText = "Fec. Fin Asignación"
        Me.FECFIN_CH.Name = "FECFIN_CH"
        Me.FECFIN_CH.ReadOnly = True
        Me.FECFIN_CH.Width = 153
        '
        'SESTCH
        '
        Me.SESTCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTCH.DataPropertyName = "SESTCH"
        Me.SESTCH.HeaderText = "Estado Asignación"
        Me.SESTCH.Name = "SESTCH"
        Me.SESTCH.ReadOnly = True
        Me.SESTCH.Width = 150
        '
        'TOBSCH
        '
        Me.TOBSCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBSCH.DataPropertyName = "TOBS"
        Me.TOBSCH.HeaderText = "Observaciones"
        Me.TOBSCH.Name = "TOBSCH"
        Me.TOBSCH.ReadOnly = True
        '
        'FCHCRT_TRACTO
        '
        Me.FCHCRT_TRACTO.DataPropertyName = "FCHCRT"
        Me.FCHCRT_TRACTO.HeaderText = "FCHCRT"
        Me.FCHCRT_TRACTO.Name = "FCHCRT_TRACTO"
        Me.FCHCRT_TRACTO.ReadOnly = True
        Me.FCHCRT_TRACTO.Visible = False
        '
        'HRACRT_TRACTO
        '
        Me.HRACRT_TRACTO.DataPropertyName = "HRACRT"
        Me.HRACRT_TRACTO.HeaderText = "HRACRT"
        Me.HRACRT_TRACTO.Name = "HRACRT_TRACTO"
        Me.HRACRT_TRACTO.ReadOnly = True
        Me.HRACRT_TRACTO.Visible = False
        '
        'KryptonHeader3
        '
        Me.KryptonHeader3.AutoSize = False
        Me.KryptonHeader3.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeader3.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeader3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeader3.Name = "KryptonHeader3"
        Me.KryptonHeader3.Size = New System.Drawing.Size(980, 24)
        Me.KryptonHeader3.TabIndex = 10
        Me.KryptonHeader3.Text = "Listado de Conductores Asignados al Transportista"
        Me.KryptonHeader3.Values.Description = ""
        Me.KryptonHeader3.Values.Heading = "Listado de Conductores Asignados al Transportista"
        Me.KryptonHeader3.Values.Image = Nothing
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "truckdriver.jpg")
        Me.ImageList1.Images.SetKeyName(1, "truck1.jpg")
        Me.ImageList1.Images.SetKeyName(2, "colorman.png")
        Me.ImageList1.Images.SetKeyName(3, "add_user.png")
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.Separator1, Me.btnGuardar, Me.Separator2, Me.btnCancelar, Me.Separator3, Me.btnEliminar, Me.Separator4, Me.btnImprimirTR})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(996, 27)
        Me.MenuBar.TabIndex = 1
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(76, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'Separator4
        '
        Me.Separator4.Name = "Separator4"
        Me.Separator4.Size = New System.Drawing.Size(6, 27)
        '
        'btnImprimirTR
        '
        Me.btnImprimirTR.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimirTR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimirTR.Name = "btnImprimirTR"
        Me.btnImprimirTR.Size = New System.Drawing.Size(90, 24)
        Me.btnImprimirTR.Text = "Imprimir"
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimirTRTodos, Me.btnExportarExcel, Me.btnHabilitar, Me.btnBusqueda})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboEstado)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbDivision)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtFiltroTransportista)
        Me.PanelFiltros.Size = New System.Drawing.Size(998, 100)
        Me.PanelFiltros.TabIndex = 1
        Me.PanelFiltros.Text = "Filtro de Consulta"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "Filtro de Consulta"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = ""
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnImprimirTRTodos
        '
        Me.btnImprimirTRTodos.ExtraText = ""
        Me.btnImprimirTRTodos.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnImprimirTRTodos.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimirTRTodos.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnImprimirTRTodos.Text = "Imprimir"
        Me.btnImprimirTRTodos.ToolTipImage = Nothing
        Me.btnImprimirTRTodos.UniqueName = "278409E8F99745D8278409E8F99745D8"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.ExtraText = ""
        Me.btnExportarExcel.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
        Me.btnExportarExcel.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnExportarExcel.Text = "Exportar"
        Me.btnExportarExcel.ToolTipImage = Nothing
        Me.btnExportarExcel.UniqueName = "B70B9D192F0B4267B70B9D192F0B4267"
        '
        'btnHabilitar
        '
        Me.btnHabilitar.ExtraText = ""
        Me.btnHabilitar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnHabilitar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnHabilitar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnHabilitar.Text = "Activar"
        Me.btnHabilitar.ToolTipImage = Nothing
        Me.btnHabilitar.UniqueName = "1EB255BE318E424A1EB255BE318E424A"
        '
        'btnBusqueda
        '
        Me.btnBusqueda.ExtraText = ""
        Me.btnBusqueda.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBusqueda.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBusqueda.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBusqueda.Text = "Buscar"
        Me.btnBusqueda.ToolTipImage = Nothing
        Me.btnBusqueda.UniqueName = "48D786B7A80C494348D786B7A80C4943"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel7.Location = New System.Drawing.Point(360, 38)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(60, 26)
        Me.KryptonLabel7.TabIndex = 66
        Me.KryptonLabel7.Text = "Estado:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Estado:"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(434, 39)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 25)
        Me.cboEstado.TabIndex = 65
        '
        'cmbPlanta
        '
        Me.cmbPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.DropDownWidth = 156
        Me.cmbPlanta.FormattingEnabled = False
        Me.cmbPlanta.ItemHeight = 20
        Me.cmbPlanta.Location = New System.Drawing.Point(712, 10)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(216, 28)
        Me.cmbPlanta.TabIndex = 64
        Me.cmbPlanta.TabStop = False
        '
        'cmbDivision
        '
        Me.cmbDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDivision.DropDownWidth = 156
        Me.cmbDivision.FormattingEnabled = False
        Me.cmbDivision.ItemHeight = 20
        Me.cmbDivision.Location = New System.Drawing.Point(434, 10)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Size = New System.Drawing.Size(216, 28)
        Me.cmbDivision.TabIndex = 62
        Me.cmbDivision.TabStop = False
        '
        'lblPlanta
        '
        Me.lblPlanta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanta.Location = New System.Drawing.Point(657, 11)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(54, 26)
        Me.lblPlanta.TabIndex = 63
        Me.lblPlanta.Text = "Planta"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel6.Location = New System.Drawing.Point(360, 11)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(65, 26)
        Me.KryptonLabel6.TabIndex = 61
        Me.KryptonLabel6.Text = "División"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "División"
        '
        'cmbCompania
        '
        Me.cmbCompania.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompania.DropDownWidth = 156
        Me.cmbCompania.FormattingEnabled = False
        Me.cmbCompania.ItemHeight = 20
        Me.cmbCompania.Location = New System.Drawing.Point(122, 10)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(228, 28)
        Me.cmbCompania.TabIndex = 60
        Me.cmbCompania.TabStop = False
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.Location = New System.Drawing.Point(7, 11)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(81, 26)
        Me.lblCompania.TabIndex = 59
        Me.lblCompania.Text = "Compañía"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañía"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(7, 43)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(141, 26)
        Me.KryptonLabel5.TabIndex = 58
        Me.KryptonLabel5.Text = "Razon Social / RUC"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Razon Social / RUC"
        '
        'txtFiltroTransportista
        '
        Me.txtFiltroTransportista.Location = New System.Drawing.Point(122, 42)
        Me.txtFiltroTransportista.Name = "txtFiltroTransportista"
        Me.txtFiltroTransportista.Size = New System.Drawing.Size(228, 26)
        Me.txtFiltroTransportista.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFiltroTransportista.TabIndex = 57
        Me.txtFiltroTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn3.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razón social"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TABTRT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción Abrev."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TLFTRP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TDRCTR"
        Me.DataGridViewTextBoxColumn6.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ST18str"
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ST18tot"
        Me.DataGridViewTextBoxColumn8.HeaderText = ""
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ruc"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Placa Vehículo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TMRCTR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NEJSUN"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Ejes"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NPLACP"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Brevete Conductor"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NOMCHOFER"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn15.HeaderText = "Nombre Conductor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SESTCM"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn21.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Placa"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn22.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TMRCVH"
        Me.DataGridViewTextBoxColumn23.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn23.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn23.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NEJSUN"
        Me.DataGridViewTextBoxColumn24.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn24.HeaderText = "Ejes"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn24.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn26.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "SESTAC"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn27.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn28.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn28.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn28.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn29.FillWeight = 180.0!
        Me.DataGridViewTextBoxColumn29.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn30.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn30.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn31.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "TNMCMC"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "TAPPAC"
        Me.DataGridViewTextBoxColumn33.HeaderText = "A Paterno"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TAPMAC"
        Me.DataGridViewTextBoxColumn34.HeaderText = "A Materno"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Vehículo"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "FECINI"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Fec. Ini. Asignación"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "FECFIN"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Fec. Fin Asignación"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "SESTCH"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Estado Asignación"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn40.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn41.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn42.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn43.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "TOBS"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "FCHCRT"
        Me.DataGridViewTextBoxColumn45.HeaderText = "FCHCRT"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Visible = False
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn46.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Visible = False
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "HRACRT"
        Me.DataGridViewTextBoxColumn47.HeaderText = "HRACRT"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Visible = False
        '
        'frmTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 720)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTransportista"
        Me.Text = "Transportista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.TabTransportista.ResumeLayout(False)
        Me.TabDatosTransportista.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.TabVehiculos.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.gwdResTractosTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAcoplados.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.gwdResAcopladosTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConductores.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        CType(Me.gwdResConductoresTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
  Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
  Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
  Friend WithEvents Separator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtFiltroTransportista As SOLMIN_ST.TextField
  Friend WithEvents btnBusqueda As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents TabTransportista As System.Windows.Forms.TabControl
  Friend WithEvents TabDatosTransportista As System.Windows.Forms.TabPage
  Friend WithEvents TabVehiculos As System.Windows.Forms.TabPage
  Friend WithEvents TabAcoplados As System.Windows.Forms.TabPage
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents TabConductores As System.Windows.Forms.TabPage
  Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents txtTelefonoTransportista As SOLMIN_ST.TextField
  Friend WithEvents txtDireccionTransportista As SOLMIN_ST.TextField
  Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtDescripcion As SOLMIN_ST.TextField
  Friend WithEvents txtRazonSocial As SOLMIN_ST.TextField
  Friend WithEvents txtNroRuc As SOLMIN_ST.TextField
  Friend WithEvents txtCodigoTransportista As SOLMIN_ST.TextField
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents KryptonHeader1 As ComponentFactory.Krypton.Toolkit.KryptonHeader
  Friend WithEvents gwdResTractosTransportista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents KryptonBorderEdge4 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
  Friend WithEvents KryptonHeader2 As ComponentFactory.Krypton.Toolkit.KryptonHeader
  Friend WithEvents gwdResAcopladosTransportista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents KryptonHeader3 As ComponentFactory.Krypton.Toolkit.KryptonHeader
  Friend WithEvents gwdResConductoresTransportista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents cboTranspAS400 As CodeTextBox.CodeTextBox
  Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NRUCTR_VH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NEJSUN_VH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLACP As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NOMCHOFER As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SESTCM As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TOBS_VH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FCHCRT_VH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HRACRT_VH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TMRCVH As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NEJSUN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FECINI_AC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FECFIN_AC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SESTAC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents FCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents HRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chkTercero As System.Windows.Forms.CheckBox
  Friend WithEvents KryptonBorderEdge5 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
  Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Separator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimirTRTodos As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnExportarExcel As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnImprimirTR As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMCMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAPPAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAPMAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECINI_CH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFIN_CH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHCRT_TRACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRACRT_TRACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbCompania As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPlanta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbDivision As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHabilitar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLFTRP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SINDRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRACTOS_ASIGNADOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACOPLADOS_ASIGNADOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHOFERES_ASIGNADOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUCPR2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO_HOMOLOGACION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
