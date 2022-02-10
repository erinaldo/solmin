<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlquilerUnidad
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlquilerUnidad))
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NRALQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REFDO1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPRCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDSDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLRCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVNV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNCS1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCHASG_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FVALIN_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FVALFI_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMNALQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QCNALQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IRVALQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMP_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESALQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESALQ_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORINS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSRCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGAPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGAPR_APR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSAPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUSCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CULUSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBRES2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBRES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBRE3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripDropDownButton
        Me.btnExportarAlquiler = New System.Windows.Forms.ToolStripMenuItem
        Me.btnExportarAlquilerDetalle = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEnviarSAP = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAprobarAlquiler = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnLiquidarPago = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnAnularRefPedido = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnExportar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbTipoRecurso = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaAsigInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaAsigFin = New System.Windows.Forms.DateTimePicker
        Me.ckbFechaAsignacion = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtNroAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbProveedorFiltro = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbEstadoAlq = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabAlquiler = New System.Windows.Forms.TabControl
        Me.tabDatosAlquiler = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox4 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnProveedorAsignado = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtTipo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCentroCosto = New Ransa.Utilitario.ucAyuda
        Me.txtNroAlquiler1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.btnRecursosAsignados = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cmbMoneda = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbServicio = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaAsignacion = New System.Windows.Forms.DateTimePicker
        Me.grpLiquidacion = New System.Windows.Forms.GroupBox
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMoneda = New System.Windows.Forms.TextBox
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtRefOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDocumentoLiq = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtImporteLiq = New System.Windows.Forms.TextBox
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtReferenciaSAP = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNroLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtOrdenInterna = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaLiq = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblOrdenInterna = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblReferenciaSAP = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlaca = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tabOperacion = New System.Windows.Forms.TabPage
        Me.gwdOperacionesXAlquiler = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NRUCTR1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRALQT1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINCOP_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTOP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnNuevoAlquiler = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardarAlquiler = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelarAlquiler = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminarAlquiler = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCerrarAlquiler = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminarOperacion = New System.Windows.Forms.ToolStripButton
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
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.TabAlquiler.SuspendLayout()
        Me.tabDatosAlquiler.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpLiquidacion.SuspendLayout()
        Me.tabOperacion.SuspendLayout()
        CType(Me.gwdOperacionesXAlquiler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1156, 661)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1156, 661)
        Me.SplitContainer1.SplitterDistance = 265
        Me.SplitContainer1.TabIndex = 1
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
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRALQT, Me.REFDO1, Me.CCMPN, Me.CDVSN, Me.CPLNDV, Me.NRUCTR, Me.TCMTRT, Me.STPRCS, Me.TDSDES, Me.NPLRCS, Me.CSRVNV, Me.TCMTRF, Me.CCNCS1, Me.FCHASG_S, Me.FVALIN_S, Me.FVALFI_S, Me.CMNALQ, Me.TMNDA, Me.QCNALQ, Me.IRVALQ, Me.IMP_TOTAL, Me.SESALQ, Me.SESALQ_S, Me.NORINS, Me.NOPRCN1, Me.CUSRCR, Me.FLGAPR, Me.FLGAPR_APR, Me.CUSAPR, Me.CUSCRT, Me.CULUSA, Me.TOBS, Me.TOBRES2, Me.TOBRES, Me.TOBRE3})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 126)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1156, 139)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 4
        '
        'NRALQT
        '
        Me.NRALQT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRALQT.DataPropertyName = "NRALQT"
        Me.NRALQT.FillWeight = 80.0!
        Me.NRALQT.HeaderText = "Nro. Alquiler"
        Me.NRALQT.Name = "NRALQT"
        Me.NRALQT.ReadOnly = True
        Me.NRALQT.Width = 103
        '
        'REFDO1
        '
        Me.REFDO1.DataPropertyName = "REFDO1"
        Me.REFDO1.HeaderText = "REFDO1 "
        Me.REFDO1.Name = "REFDO1"
        Me.REFDO1.ReadOnly = True
        Me.REFDO1.Visible = False
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
        Me.CDVSN.HeaderText = "CDVSN"
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
        'NRUCTR
        '
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "NRUCTR"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Visible = False
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Proveedor"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 90
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
        Me.TDSDES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TDSDES.DataPropertyName = "TDSDES"
        Me.TDSDES.HeaderText = "Tipo Recurso"
        Me.TDSDES.Name = "TDSDES"
        Me.TDSDES.ReadOnly = True
        Me.TDSDES.Width = 105
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
        'CSRVNV
        '
        Me.CSRVNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CSRVNV.DataPropertyName = "CSRVNV"
        Me.CSRVNV.HeaderText = "CSRVNV"
        Me.CSRVNV.Name = "CSRVNV"
        Me.CSRVNV.ReadOnly = True
        Me.CSRVNV.Visible = False
        Me.CSRVNV.Width = 80
        '
        'TCMTRF
        '
        Me.TCMTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "Servicio"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.ReadOnly = True
        Me.TCMTRF.Visible = False
        Me.TCMTRF.Width = 77
        '
        'CCNCS1
        '
        Me.CCNCS1.DataPropertyName = "CCNCS1"
        Me.CCNCS1.HeaderText = "CCNCS1"
        Me.CCNCS1.Name = "CCNCS1"
        Me.CCNCS1.ReadOnly = True
        Me.CCNCS1.Visible = False
        '
        'FCHASG_S
        '
        Me.FCHASG_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FCHASG_S.DataPropertyName = "FCHASG_S"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FCHASG_S.DefaultCellStyle = DataGridViewCellStyle1
        Me.FCHASG_S.HeaderText = "Fecha Asignación"
        Me.FCHASG_S.Name = "FCHASG_S"
        Me.FCHASG_S.ReadOnly = True
        Me.FCHASG_S.Width = 129
        '
        'FVALIN_S
        '
        Me.FVALIN_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FVALIN_S.DataPropertyName = "FVALIN_S"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FVALIN_S.DefaultCellStyle = DataGridViewCellStyle2
        Me.FVALIN_S.HeaderText = "Fecha de Inicio"
        Me.FVALIN_S.Name = "FVALIN_S"
        Me.FVALIN_S.ReadOnly = True
        Me.FVALIN_S.Width = 115
        '
        'FVALFI_S
        '
        Me.FVALFI_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FVALFI_S.DataPropertyName = "FVALFI_S"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FVALFI_S.DefaultCellStyle = DataGridViewCellStyle3
        Me.FVALFI_S.HeaderText = "Fecha Fin"
        Me.FVALFI_S.Name = "FVALFI_S"
        Me.FVALFI_S.ReadOnly = True
        Me.FVALFI_S.Width = 86
        '
        'CMNALQ
        '
        Me.CMNALQ.DataPropertyName = "CMNALQ"
        Me.CMNALQ.HeaderText = "CMNALQ"
        Me.CMNALQ.Name = "CMNALQ"
        Me.CMNALQ.ReadOnly = True
        Me.CMNALQ.Visible = False
        '
        'TMNDA
        '
        Me.TMNDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMNDA.DataPropertyName = "TMNDA"
        Me.TMNDA.HeaderText = "Moneda"
        Me.TMNDA.Name = "TMNDA"
        Me.TMNDA.ReadOnly = True
        Me.TMNDA.Width = 80
        '
        'QCNALQ
        '
        Me.QCNALQ.DataPropertyName = "QCNALQ"
        Me.QCNALQ.HeaderText = "QCNALQ"
        Me.QCNALQ.Name = "QCNALQ"
        Me.QCNALQ.ReadOnly = True
        Me.QCNALQ.Visible = False
        '
        'IRVALQ
        '
        Me.IRVALQ.DataPropertyName = "IRVALQ"
        Me.IRVALQ.HeaderText = "IRVALQ"
        Me.IRVALQ.Name = "IRVALQ"
        Me.IRVALQ.ReadOnly = True
        Me.IRVALQ.Visible = False
        '
        'IMP_TOTAL
        '
        Me.IMP_TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMP_TOTAL.DataPropertyName = "IMP_TOTAL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IMP_TOTAL.DefaultCellStyle = DataGridViewCellStyle4
        Me.IMP_TOTAL.HeaderText = "Importe Total"
        Me.IMP_TOTAL.Name = "IMP_TOTAL"
        Me.IMP_TOTAL.ReadOnly = True
        Me.IMP_TOTAL.Width = 107
        '
        'SESALQ
        '
        Me.SESALQ.DataPropertyName = "SESALQ"
        Me.SESALQ.HeaderText = "SESALQ"
        Me.SESALQ.Name = "SESALQ"
        Me.SESALQ.ReadOnly = True
        Me.SESALQ.Visible = False
        '
        'SESALQ_S
        '
        Me.SESALQ_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESALQ_S.DataPropertyName = "SESALQ_S"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SESALQ_S.DefaultCellStyle = DataGridViewCellStyle5
        Me.SESALQ_S.HeaderText = "Estado Alquiler"
        Me.SESALQ_S.Name = "SESALQ_S"
        Me.SESALQ_S.ReadOnly = True
        Me.SESALQ_S.Width = 115
        '
        'NORINS
        '
        Me.NORINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORINS.DataPropertyName = "NORINS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = Nothing
        Me.NORINS.DefaultCellStyle = DataGridViewCellStyle6
        Me.NORINS.HeaderText = "Orden Interna"
        Me.NORINS.Name = "NORINS"
        Me.NORINS.ReadOnly = True
        Me.NORINS.Width = 109
        '
        'NOPRCN1
        '
        Me.NOPRCN1.DataPropertyName = "NOPRCN"
        Me.NOPRCN1.HeaderText = "NOPRCN"
        Me.NOPRCN1.Name = "NOPRCN1"
        Me.NOPRCN1.ReadOnly = True
        Me.NOPRCN1.Visible = False
        '
        'CUSRCR
        '
        Me.CUSRCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUSRCR.DataPropertyName = "CUSRCR"
        Me.CUSRCR.HeaderText = "Usuario cierre"
        Me.CUSRCR.Name = "CUSRCR"
        Me.CUSRCR.ReadOnly = True
        Me.CUSRCR.Width = 108
        '
        'FLGAPR
        '
        Me.FLGAPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLGAPR.DataPropertyName = "FLGAPR"
        Me.FLGAPR.HeaderText = "FLGAPR"
        Me.FLGAPR.Name = "FLGAPR"
        Me.FLGAPR.ReadOnly = True
        Me.FLGAPR.Visible = False
        Me.FLGAPR.Width = 78
        '
        'FLGAPR_APR
        '
        Me.FLGAPR_APR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLGAPR_APR.DataPropertyName = "FLGAPR_APR"
        Me.FLGAPR_APR.HeaderText = "Aprobación"
        Me.FLGAPR_APR.Name = "FLGAPR_APR"
        Me.FLGAPR_APR.ReadOnly = True
        Me.FLGAPR_APR.Width = 98
        '
        'CUSAPR
        '
        Me.CUSAPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUSAPR.DataPropertyName = "CUSAPR"
        Me.CUSAPR.HeaderText = "Usuario aprobador"
        Me.CUSAPR.Name = "CUSAPR"
        Me.CUSAPR.ReadOnly = True
        Me.CUSAPR.Width = 134
        '
        'CUSCRT
        '
        Me.CUSCRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUSCRT.DataPropertyName = "CUSCRT"
        Me.CUSCRT.HeaderText = "Usuario Creador"
        Me.CUSCRT.Name = "CUSCRT"
        Me.CUSCRT.ReadOnly = True
        Me.CUSCRT.Width = 121
        '
        'CULUSA
        '
        Me.CULUSA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CULUSA.DataPropertyName = "CULUSA"
        Me.CULUSA.HeaderText = "Usuario Actualizador"
        Me.CULUSA.Name = "CULUSA"
        Me.CULUSA.ReadOnly = True
        Me.CULUSA.Width = 145
        '
        'TOBS
        '
        Me.TOBS.DataPropertyName = "TOBS"
        Me.TOBS.HeaderText = "Obs. alquiler"
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        '
        'TOBRES2
        '
        Me.TOBRES2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBRES2.DataPropertyName = "TOBRES2"
        Me.TOBRES2.HeaderText = "Obs. aprobación"
        Me.TOBRES2.Name = "TOBRES2"
        Me.TOBRES2.ReadOnly = True
        Me.TOBRES2.Width = 123
        '
        'TOBRES
        '
        Me.TOBRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBRES.DataPropertyName = "TOBRES"
        Me.TOBRES.HeaderText = "Obs. cierre"
        Me.TOBRES.Name = "TOBRES"
        Me.TOBRES.ReadOnly = True
        Me.TOBRES.Width = 92
        '
        'TOBRE3
        '
        Me.TOBRE3.DataPropertyName = "TOBRE3"
        Me.TOBRE3.HeaderText = "Obs. envio pedido"
        Me.TOBRE3.Name = "TOBRE3"
        Me.TOBRE3.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar1, Me.ToolStripSeparator6, Me.btnExportarExcel, Me.ToolStripSeparator7, Me.btnEnviarSAP, Me.ToolStripSeparator8, Me.btnAprobarAlquiler})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 101)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1156, 25)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.TabStop = True
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar1.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar1.Text = "Buscar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportarAlquiler, Me.btnExportarAlquilerDetalle})
        Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(79, 22)
        Me.btnExportarExcel.Text = "Exportar"
        Me.btnExportarExcel.ToolTipText = "Exportar Excel"
        '
        'btnExportarAlquiler
        '
        Me.btnExportarAlquiler.Name = "btnExportarAlquiler"
        Me.btnExportarAlquiler.Size = New System.Drawing.Size(154, 22)
        Me.btnExportarAlquiler.Text = "Alquiler"
        '
        'btnExportarAlquilerDetalle
        '
        Me.btnExportarAlquilerDetalle.Name = "btnExportarAlquilerDetalle"
        Me.btnExportarAlquilerDetalle.Size = New System.Drawing.Size(154, 22)
        Me.btnExportarAlquilerDetalle.Text = "Alquiler Detalle"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'btnEnviarSAP
        '
        Me.btnEnviarSAP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEnviarSAP.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnEnviarSAP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnviarSAP.Name = "btnEnviarSAP"
        Me.btnEnviarSAP.Size = New System.Drawing.Size(120, 22)
        Me.btnEnviarSAP.Text = "Envio Pedido SAP"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btnAprobarAlquiler
        '
        Me.btnAprobarAlquiler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAprobarAlquiler.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
        Me.btnAprobarAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAprobarAlquiler.Name = "btnAprobarAlquiler"
        Me.btnAprobarAlquiler.Size = New System.Drawing.Size(114, 22)
        Me.btnAprobarAlquiler.Text = "Aprobar Alquiler"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnLiquidarPago, Me.btnAnularRefPedido, Me.btnExportar, Me.btnBuscar})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbTipoRecurso)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel23)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonTextBox2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel20)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaAsigInicio)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFechaAsigFin)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ckbFechaAsignacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroAlquiler)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel14)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbProveedorFiltro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel13)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbEstadoAlq)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1156, 101)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup1.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'btnLiquidarPago
        '
        Me.btnLiquidarPago.ExtraText = ""
        Me.btnLiquidarPago.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnLiquidarPago.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnLiquidarPago.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnLiquidarPago.Text = "Enviar Pedido SAP"
        Me.btnLiquidarPago.ToolTipImage = Nothing
        Me.btnLiquidarPago.UniqueName = "F09E316F532845B8F09E316F532845B8"
        '
        'btnAnularRefPedido
        '
        Me.btnAnularRefPedido.ExtraText = ""
        Me.btnAnularRefPedido.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnAnularRefPedido.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnAnularRefPedido.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnAnularRefPedido.Text = "Anular Ref. Pedido"
        Me.btnAnularRefPedido.ToolTipImage = Nothing
        Me.btnAnularRefPedido.UniqueName = "DC03EF9318504DADDC03EF9318504DAD"
        Me.btnAnularRefPedido.Visible = False
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
        'cmbTipoRecurso
        '
        Me.cmbTipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoRecurso.DropDownWidth = 121
        Me.cmbTipoRecurso.FormattingEnabled = False
        Me.cmbTipoRecurso.ItemHeight = 15
        Me.cmbTipoRecurso.Location = New System.Drawing.Point(106, 68)
        Me.cmbTipoRecurso.Name = "cmbTipoRecurso"
        Me.cmbTipoRecurso.Size = New System.Drawing.Size(97, 23)
        Me.cmbTipoRecurso.TabIndex = 153
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel23.Location = New System.Drawing.Point(11, 69)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(81, 22)
        Me.KryptonLabel23.TabIndex = 152
        Me.KryptonLabel23.Text = "Tipo Recurso"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Tipo Recurso"
        '
        'KryptonTextBox2
        '
        Me.KryptonTextBox2.Location = New System.Drawing.Point(259, 69)
        Me.KryptonTextBox2.MaxLength = 10
        Me.KryptonTextBox2.Name = "KryptonTextBox2"
        Me.KryptonTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.KryptonTextBox2.TabIndex = 150
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(209, 71)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(41, 22)
        Me.KryptonLabel20.TabIndex = 148
        Me.KryptonLabel20.Text = "Placa:"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Placa:"
        '
        'dtpFechaAsigInicio
        '
        Me.dtpFechaAsigInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAsigInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAsigInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsigInicio.Location = New System.Drawing.Point(637, 42)
        Me.dtpFechaAsigInicio.Name = "dtpFechaAsigInicio"
        Me.dtpFechaAsigInicio.Size = New System.Drawing.Size(93, 21)
        Me.dtpFechaAsigInicio.TabIndex = 146
        '
        'dtpFechaAsigFin
        '
        Me.dtpFechaAsigFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAsigFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAsigFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsigFin.Location = New System.Drawing.Point(735, 42)
        Me.dtpFechaAsigFin.Name = "dtpFechaAsigFin"
        Me.dtpFechaAsigFin.Size = New System.Drawing.Size(95, 21)
        Me.dtpFechaAsigFin.TabIndex = 147
        '
        'ckbFechaAsignacion
        '
        Me.ckbFechaAsignacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbFechaAsignacion.Location = New System.Drawing.Point(576, 41)
        Me.ckbFechaAsignacion.Name = "ckbFechaAsignacion"
        Me.ckbFechaAsignacion.Size = New System.Drawing.Size(55, 22)
        Me.ckbFechaAsignacion.TabIndex = 145
        Me.ckbFechaAsignacion.Text = "Fecha"
        Me.ckbFechaAsignacion.Values.ExtraText = ""
        Me.ckbFechaAsignacion.Values.Image = Nothing
        Me.ckbFechaAsignacion.Values.Text = "Fecha"
        '
        'txtNroAlquiler
        '
        Me.txtNroAlquiler.Location = New System.Drawing.Point(462, 41)
        Me.txtNroAlquiler.MaxLength = 10
        Me.txtNroAlquiler.Name = "txtNroAlquiler"
        Me.txtNroAlquiler.Size = New System.Drawing.Size(100, 22)
        Me.txtNroAlquiler.TabIndex = 142
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(385, 41)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(79, 22)
        Me.KryptonLabel14.TabIndex = 141
        Me.KryptonLabel14.Text = "Nro. Alquiler"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Nro. Alquiler"
        '
        'cmbProveedorFiltro
        '
        Me.cmbProveedorFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbProveedorFiltro.BackColor = System.Drawing.Color.Transparent
        Me.cmbProveedorFiltro.Location = New System.Drawing.Point(106, 43)
        Me.cmbProveedorFiltro.Name = "cmbProveedorFiltro"
        Me.cmbProveedorFiltro.pNroRegPorPaginas = 0
        Me.cmbProveedorFiltro.pRequerido = False
        Me.cmbProveedorFiltro.Size = New System.Drawing.Size(253, 22)
        Me.cmbProveedorFiltro.TabIndex = 140
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(8, 43)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(67, 22)
        Me.KryptonLabel13.TabIndex = 139
        Me.KryptonLabel13.Text = "Proveedor"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Proveedor"
        '
        'cmbEstadoAlq
        '
        Me.cmbEstadoAlq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoAlq.DropDownWidth = 121
        Me.cmbEstadoAlq.FormattingEnabled = False
        Me.cmbEstadoAlq.ItemHeight = 15
        Me.cmbEstadoAlq.Location = New System.Drawing.Point(944, 38)
        Me.cmbEstadoAlq.Name = "cmbEstadoAlq"
        Me.cmbEstadoAlq.Size = New System.Drawing.Size(148, 23)
        Me.cmbEstadoAlq.TabIndex = 138
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(846, 42)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(92, 22)
        Me.KryptonLabel12.TabIndex = 131
        Me.KryptonLabel12.Text = "Estado Alquiler"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Estado Alquiler"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Habilitar = True
        Me.cmbCompania.Location = New System.Drawing.Point(106, 15)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.cmbCompania.oBeCompania = BeCompania1
        Me.cmbCompania.Size = New System.Drawing.Size(253, 24)
        Me.cmbCompania.TabIndex = 130
        Me.cmbCompania.Usuario = ""
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CodSedeSAP = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(766, 13)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDSPSP_CodSedeSAP = Nothing
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.cmbPlanta.obePlanta = BePlanta1
        Me.cmbPlanta.pHabilitado = True
        Me.cmbPlanta.Planta = 0
        Me.cmbPlanta.PlantaDefault = -1
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.TabIndex = 129
        Me.cmbPlanta.Usuario = ""
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(706, 14)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(44, 22)
        Me.KryptonLabel6.TabIndex = 128
        Me.KryptonLabel6.Text = "Planta"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Planta"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(385, 15)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(54, 22)
        Me.KryptonLabel7.TabIndex = 126
        Me.KryptonLabel7.Text = "División"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "División"
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
        Me.cmbDivision.Location = New System.Drawing.Point(462, 15)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.obeDivision = Nothing
        Me.cmbDivision.pHabilitado = True
        Me.cmbDivision.pRequerido = False
        Me.cmbDivision.Size = New System.Drawing.Size(223, 23)
        Me.cmbDivision.TabIndex = 127
        Me.cmbDivision.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompania.Location = New System.Drawing.Point(8, 17)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 22)
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
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1156, 392)
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Información del Alquiler"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'TabAlquiler
        '
        Me.TabAlquiler.Controls.Add(Me.tabDatosAlquiler)
        Me.TabAlquiler.Controls.Add(Me.tabOperacion)
        Me.TabAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAlquiler.Location = New System.Drawing.Point(0, 25)
        Me.TabAlquiler.Name = "TabAlquiler"
        Me.TabAlquiler.SelectedIndex = 0
        Me.TabAlquiler.Size = New System.Drawing.Size(1154, 342)
        Me.TabAlquiler.TabIndex = 0
        '
        'tabDatosAlquiler
        '
        Me.tabDatosAlquiler.Controls.Add(Me.KryptonHeaderGroup3)
        Me.tabDatosAlquiler.Location = New System.Drawing.Point(4, 22)
        Me.tabDatosAlquiler.Name = "tabDatosAlquiler"
        Me.tabDatosAlquiler.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDatosAlquiler.Size = New System.Drawing.Size(1146, 316)
        Me.tabDatosAlquiler.TabIndex = 0
        Me.tabDatosAlquiler.Text = "Datos Alquiler"
        Me.tabDatosAlquiler.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Panel1)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(1140, 310)
        Me.KryptonHeaderGroup3.TabIndex = 0
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.KryptonLabel22)
        Me.Panel1.Controls.Add(Me.KryptonTextBox4)
        Me.Panel1.Controls.Add(Me.KryptonLabel21)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.KryptonTextBox3)
        Me.Panel1.Controls.Add(Me.btnProveedorAsignado)
        Me.Panel1.Controls.Add(Me.txtProveedor)
        Me.Panel1.Controls.Add(Me.txtTipo)
        Me.Panel1.Controls.Add(Me.KryptonLabel18)
        Me.Panel1.Controls.Add(Me.cmbCentroCosto)
        Me.Panel1.Controls.Add(Me.txtNroAlquiler1)
        Me.Panel1.Controls.Add(Me.txtImporte)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.btnRecursosAsignados)
        Me.Panel1.Controls.Add(Me.cmbMoneda)
        Me.Panel1.Controls.Add(Me.KryptonLabel17)
        Me.Panel1.Controls.Add(Me.cmbServicio)
        Me.Panel1.Controls.Add(Me.KryptonLabel16)
        Me.Panel1.Controls.Add(Me.dtpFechaAsignacion)
        Me.Panel1.Controls.Add(Me.grpLiquidacion)
        Me.Panel1.Controls.Add(Me.txtPlaca)
        Me.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 308)
        Me.Panel1.TabIndex = 0
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(6, 172)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel22.TabIndex = 162
        Me.KryptonLabel22.Text = "Observación alq."
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Observación alq."
        '
        'KryptonTextBox4
        '
        Me.KryptonTextBox4.Location = New System.Drawing.Point(111, 41)
        Me.KryptonTextBox4.MaxLength = 100
        Me.KryptonTextBox4.Name = "KryptonTextBox4"
        Me.KryptonTextBox4.Size = New System.Drawing.Size(264, 22)
        Me.KryptonTextBox4.TabIndex = 161
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(6, 41)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(67, 22)
        Me.KryptonLabel21.TabIndex = 160
        Me.KryptonLabel21.Text = "Referencia"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Referencia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel5)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 41)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fecha vigencia"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(6, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 19)
        Me.Button1.TabIndex = 160
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(37, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(45, 22)
        Me.KryptonLabel4.TabIndex = 159
        Me.KryptonLabel4.Text = "Desde"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Desde"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(213, 15)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(77, 20)
        Me.dtpFechaFin.TabIndex = 102
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(79, 15)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaInicio.TabIndex = 101
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(166, 15)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(41, 22)
        Me.KryptonLabel5.TabIndex = 100
        Me.KryptonLabel5.Text = "Hasta"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Hasta"
        '
        'KryptonTextBox3
        '
        Me.KryptonTextBox3.Location = New System.Drawing.Point(111, 168)
        Me.KryptonTextBox3.MaxLength = 250
        Me.KryptonTextBox3.Multiline = True
        Me.KryptonTextBox3.Name = "KryptonTextBox3"
        Me.KryptonTextBox3.Size = New System.Drawing.Size(586, 92)
        Me.KryptonTextBox3.TabIndex = 157
        '
        'btnProveedorAsignado
        '
        Me.btnProveedorAsignado.Location = New System.Drawing.Point(348, 69)
        Me.btnProveedorAsignado.Name = "btnProveedorAsignado"
        Me.btnProveedorAsignado.Size = New System.Drawing.Size(27, 23)
        Me.btnProveedorAsignado.TabIndex = 156
        Me.btnProveedorAsignado.Values.ExtraText = ""
        Me.btnProveedorAsignado.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnProveedorAsignado.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProveedorAsignado.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProveedorAsignado.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProveedorAsignado.Values.Text = ""
        '
        'txtProveedor
        '
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Location = New System.Drawing.Point(111, 70)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(235, 22)
        Me.txtProveedor.TabIndex = 155
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(111, 99)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(89, 22)
        Me.txtTipo.TabIndex = 154
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(6, 129)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(47, 22)
        Me.KryptonLabel18.TabIndex = 153
        Me.KryptonLabel18.Text = "Ce. Be."
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Ce. Be."
        '
        'cmbCentroCosto
        '
        Me.cmbCentroCosto.BackColor = System.Drawing.Color.Transparent
        Me.cmbCentroCosto.DataSource = Nothing
        Me.cmbCentroCosto.DispleyMember = ""
        Me.cmbCentroCosto.Etiquetas_Form = Nothing
        Me.cmbCentroCosto.ListColumnas = Nothing
        Me.cmbCentroCosto.Location = New System.Drawing.Point(111, 129)
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.Obligatorio = False
        Me.cmbCentroCosto.PopupHeight = 0
        Me.cmbCentroCosto.PopupWidth = 0
        Me.cmbCentroCosto.Size = New System.Drawing.Size(269, 21)
        Me.cmbCentroCosto.SizeFont = 0
        Me.cmbCentroCosto.TabIndex = 152
        Me.cmbCentroCosto.ValueMember = ""
        '
        'txtNroAlquiler1
        '
        Me.txtNroAlquiler1.Enabled = False
        Me.txtNroAlquiler1.Location = New System.Drawing.Point(111, 13)
        Me.txtNroAlquiler1.Name = "txtNroAlquiler1"
        Me.txtNroAlquiler1.Size = New System.Drawing.Size(105, 22)
        Me.txtNroAlquiler1.TabIndex = 150
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(559, 64)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(131, 20)
        Me.txtImporte.TabIndex = 149
        Me.txtImporte.Text = "0"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(446, 64)
        Me.txtCantidad.MaxLength = 12
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(42, 20)
        Me.txtCantidad.TabIndex = 148
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRecursosAsignados
        '
        Me.btnRecursosAsignados.Location = New System.Drawing.Point(353, 99)
        Me.btnRecursosAsignados.Name = "btnRecursosAsignados"
        Me.btnRecursosAsignados.Size = New System.Drawing.Size(27, 22)
        Me.btnRecursosAsignados.TabIndex = 147
        Me.btnRecursosAsignados.Values.ExtraText = ""
        Me.btnRecursosAsignados.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnRecursosAsignados.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnRecursosAsignados.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnRecursosAsignados.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnRecursosAsignados.Values.Text = ""
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.DropDownWidth = 121
        Me.cmbMoneda.FormattingEnabled = False
        Me.cmbMoneda.ItemHeight = 15
        Me.cmbMoneda.Location = New System.Drawing.Point(446, 93)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(128, 23)
        Me.cmbMoneda.TabIndex = 146
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(381, 64)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(59, 22)
        Me.KryptonLabel17.TabIndex = 117
        Me.KryptonLabel17.Text = "Cantidad"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Cantidad"
        '
        'cmbServicio
        '
        Me.cmbServicio.BackColor = System.Drawing.Color.Transparent
        Me.cmbServicio.DataSource = Nothing
        Me.cmbServicio.DispleyMember = ""
        Me.cmbServicio.Etiquetas_Form = Nothing
        Me.cmbServicio.ListColumnas = Nothing
        Me.cmbServicio.Location = New System.Drawing.Point(446, 35)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Obligatorio = False
        Me.cmbServicio.PopupHeight = 0
        Me.cmbServicio.PopupWidth = 0
        Me.cmbServicio.Size = New System.Drawing.Size(246, 21)
        Me.cmbServicio.SizeFont = 0
        Me.cmbServicio.TabIndex = 116
        Me.cmbServicio.ValueMember = ""
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(381, 36)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(53, 22)
        Me.KryptonLabel16.TabIndex = 115
        Me.KryptonLabel16.Text = "Servicio"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Servicio"
        '
        'dtpFechaAsignacion
        '
        Me.dtpFechaAsignacion.Enabled = False
        Me.dtpFechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsignacion.Location = New System.Drawing.Point(286, 15)
        Me.dtpFechaAsignacion.Name = "dtpFechaAsignacion"
        Me.dtpFechaAsignacion.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaAsignacion.TabIndex = 113
        '
        'grpLiquidacion
        '
        Me.grpLiquidacion.BackColor = System.Drawing.Color.Transparent
        Me.grpLiquidacion.Controls.Add(Me.KryptonLabel24)
        Me.grpLiquidacion.Controls.Add(Me.txtMoneda)
        Me.grpLiquidacion.Controls.Add(Me.KryptonTextBox1)
        Me.grpLiquidacion.Controls.Add(Me.txtRefOperacion)
        Me.grpLiquidacion.Controls.Add(Me.txtDocumentoLiq)
        Me.grpLiquidacion.Controls.Add(Me.KryptonLabel19)
        Me.grpLiquidacion.Controls.Add(Me.KryptonLabel15)
        Me.grpLiquidacion.Controls.Add(Me.txtImporteLiq)
        Me.grpLiquidacion.Controls.Add(Me.KryptonLabel8)
        Me.grpLiquidacion.Controls.Add(Me.txtServicio)
        Me.grpLiquidacion.Controls.Add(Me.txtReferenciaSAP)
        Me.grpLiquidacion.Controls.Add(Me.txtNroLiquidacion)
        Me.grpLiquidacion.Controls.Add(Me.txtOrdenInterna)
        Me.grpLiquidacion.Controls.Add(Me.lblServicio)
        Me.grpLiquidacion.Controls.Add(Me.lblFechaLiq)
        Me.grpLiquidacion.Controls.Add(Me.lblLiquidacion)
        Me.grpLiquidacion.Controls.Add(Me.lblOrdenInterna)
        Me.grpLiquidacion.Controls.Add(Me.lblReferenciaSAP)
        Me.grpLiquidacion.Location = New System.Drawing.Point(710, 13)
        Me.grpLiquidacion.Name = "grpLiquidacion"
        Me.grpLiquidacion.Size = New System.Drawing.Size(414, 202)
        Me.grpLiquidacion.TabIndex = 110
        Me.grpLiquidacion.TabStop = False
        Me.grpLiquidacion.Text = "Ref. Pedido SAP"
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(219, 135)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(56, 22)
        Me.KryptonLabel24.TabIndex = 161
        Me.KryptonLabel24.Text = "Moneda"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Moneda"
        '
        'txtMoneda
        '
        Me.txtMoneda.Enabled = False
        Me.txtMoneda.ForeColor = System.Drawing.Color.Black
        Me.txtMoneda.Location = New System.Drawing.Point(312, 135)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(89, 20)
        Me.txtMoneda.TabIndex = 160
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Enabled = False
        Me.KryptonTextBox1.Location = New System.Drawing.Point(312, 53)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(89, 22)
        Me.KryptonTextBox1.TabIndex = 159
        '
        'txtRefOperacion
        '
        Me.txtRefOperacion.Enabled = False
        Me.txtRefOperacion.Location = New System.Drawing.Point(312, 23)
        Me.txtRefOperacion.Name = "txtRefOperacion"
        Me.txtRefOperacion.Size = New System.Drawing.Size(89, 22)
        Me.txtRefOperacion.TabIndex = 156
        '
        'txtDocumentoLiq
        '
        Me.txtDocumentoLiq.Enabled = False
        Me.txtDocumentoLiq.Location = New System.Drawing.Point(109, 159)
        Me.txtDocumentoLiq.Name = "txtDocumentoLiq"
        Me.txtDocumentoLiq.Size = New System.Drawing.Size(100, 22)
        Me.txtDocumentoLiq.TabIndex = 158
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(219, 23)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(91, 22)
        Me.KryptonLabel19.TabIndex = 155
        Me.KryptonLabel19.Text = "Ref. Operación"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Ref. Operación"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(16, 159)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel15.TabIndex = 157
        Me.KryptonLabel15.Text = "Doc Pago "
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Doc Pago "
        '
        'txtImporteLiq
        '
        Me.txtImporteLiq.Enabled = False
        Me.txtImporteLiq.Location = New System.Drawing.Point(109, 135)
        Me.txtImporteLiq.Name = "txtImporteLiq"
        Me.txtImporteLiq.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteLiq.TabIndex = 157
        Me.txtImporteLiq.Text = "0"
        Me.txtImporteLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(16, 135)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(54, 22)
        Me.KryptonLabel8.TabIndex = 156
        Me.KryptonLabel8.Text = "Importe"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Importe"
        '
        'txtServicio
        '
        Me.txtServicio.Enabled = False
        Me.txtServicio.Location = New System.Drawing.Point(109, 107)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(201, 22)
        Me.txtServicio.TabIndex = 155
        '
        'txtReferenciaSAP
        '
        Me.txtReferenciaSAP.Enabled = False
        Me.txtReferenciaSAP.Location = New System.Drawing.Point(109, 79)
        Me.txtReferenciaSAP.Name = "txtReferenciaSAP"
        Me.txtReferenciaSAP.Size = New System.Drawing.Size(89, 22)
        Me.txtReferenciaSAP.TabIndex = 154
        '
        'txtNroLiquidacion
        '
        Me.txtNroLiquidacion.Enabled = False
        Me.txtNroLiquidacion.Location = New System.Drawing.Point(109, 53)
        Me.txtNroLiquidacion.Name = "txtNroLiquidacion"
        Me.txtNroLiquidacion.Size = New System.Drawing.Size(89, 22)
        Me.txtNroLiquidacion.TabIndex = 152
        Me.txtNroLiquidacion.Text = "0"
        '
        'txtOrdenInterna
        '
        Me.txtOrdenInterna.Enabled = False
        Me.txtOrdenInterna.Location = New System.Drawing.Point(109, 27)
        Me.txtOrdenInterna.Name = "txtOrdenInterna"
        Me.txtOrdenInterna.Size = New System.Drawing.Size(89, 22)
        Me.txtOrdenInterna.TabIndex = 151
        '
        'lblServicio
        '
        Me.lblServicio.Location = New System.Drawing.Point(16, 106)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(53, 22)
        Me.lblServicio.TabIndex = 116
        Me.lblServicio.Text = "Servicio "
        Me.lblServicio.Values.ExtraText = ""
        Me.lblServicio.Values.Image = Nothing
        Me.lblServicio.Values.Text = "Servicio "
        '
        'lblFechaLiq
        '
        Me.lblFechaLiq.Location = New System.Drawing.Point(219, 51)
        Me.lblFechaLiq.Name = "lblFechaLiq"
        Me.lblFechaLiq.Size = New System.Drawing.Size(64, 22)
        Me.lblFechaLiq.TabIndex = 113
        Me.lblFechaLiq.Text = "Fecha Liq."
        Me.lblFechaLiq.Values.ExtraText = ""
        Me.lblFechaLiq.Values.Image = Nothing
        Me.lblFechaLiq.Values.Text = "Fecha Liq."
        '
        'lblLiquidacion
        '
        Me.lblLiquidacion.Location = New System.Drawing.Point(16, 53)
        Me.lblLiquidacion.Name = "lblLiquidacion"
        Me.lblLiquidacion.Size = New System.Drawing.Size(90, 22)
        Me.lblLiquidacion.TabIndex = 0
        Me.lblLiquidacion.Text = "N° Liquidación "
        Me.lblLiquidacion.Values.ExtraText = ""
        Me.lblLiquidacion.Values.Image = Nothing
        Me.lblLiquidacion.Values.Text = "N° Liquidación "
        '
        'lblOrdenInterna
        '
        Me.lblOrdenInterna.Location = New System.Drawing.Point(16, 29)
        Me.lblOrdenInterna.Name = "lblOrdenInterna"
        Me.lblOrdenInterna.Size = New System.Drawing.Size(87, 22)
        Me.lblOrdenInterna.TabIndex = 114
        Me.lblOrdenInterna.Text = "Orden Interna "
        Me.lblOrdenInterna.Values.ExtraText = ""
        Me.lblOrdenInterna.Values.Image = Nothing
        Me.lblOrdenInterna.Values.Text = "Orden Interna "
        '
        'lblReferenciaSAP
        '
        Me.lblReferenciaSAP.Location = New System.Drawing.Point(16, 81)
        Me.lblReferenciaSAP.Name = "lblReferenciaSAP"
        Me.lblReferenciaSAP.Size = New System.Drawing.Size(92, 22)
        Me.lblReferenciaSAP.TabIndex = 1
        Me.lblReferenciaSAP.Text = "Referencia SAP "
        Me.lblReferenciaSAP.Values.ExtraText = ""
        Me.lblReferenciaSAP.Values.Image = Nothing
        Me.lblReferenciaSAP.Values.Text = "Referencia SAP "
        '
        'txtPlaca
        '
        Me.txtPlaca.Enabled = False
        Me.txtPlaca.Location = New System.Drawing.Point(202, 99)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(149, 22)
        Me.txtPlaca.TabIndex = 108
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(494, 64)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(54, 22)
        Me.KryptonLabel11.TabIndex = 102
        Me.KryptonLabel11.Text = "Importe"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Importe"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(383, 98)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(56, 22)
        Me.KryptonLabel10.TabIndex = 101
        Me.KryptonLabel10.Text = "Moneda"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Moneda"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(6, 99)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(39, 22)
        Me.KryptonLabel9.TabIndex = 100
        Me.KryptonLabel9.Text = "Placa"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Placa"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(238, 15)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(42, 22)
        Me.KryptonLabel3.TabIndex = 93
        Me.KryptonLabel3.Text = "Fecha "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(6, 69)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(67, 22)
        Me.KryptonLabel2.TabIndex = 92
        Me.KryptonLabel2.Text = "Proveedor"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Proveedor"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(79, 22)
        Me.KryptonLabel1.TabIndex = 91
        Me.KryptonLabel1.Text = "Nro. Alquiler"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Nro. Alquiler"
        '
        'tabOperacion
        '
        Me.tabOperacion.Controls.Add(Me.gwdOperacionesXAlquiler)
        Me.tabOperacion.Location = New System.Drawing.Point(4, 22)
        Me.tabOperacion.Name = "tabOperacion"
        Me.tabOperacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOperacion.Size = New System.Drawing.Size(1146, 318)
        Me.tabOperacion.TabIndex = 1
        Me.tabOperacion.Text = "Operaciones por Alquiler"
        Me.tabOperacion.UseVisualStyleBackColor = True
        '
        'gwdOperacionesXAlquiler
        '
        Me.gwdOperacionesXAlquiler.AllowUserToAddRows = False
        Me.gwdOperacionesXAlquiler.AllowUserToDeleteRows = False
        Me.gwdOperacionesXAlquiler.AllowUserToOrderColumns = True
        Me.gwdOperacionesXAlquiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdOperacionesXAlquiler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdOperacionesXAlquiler.ColumnHeadersHeight = 30
        Me.gwdOperacionesXAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdOperacionesXAlquiler.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRUCTR1, Me.NRALQT1, Me.NCRRRT, Me.DataGridViewTextBoxColumn34, Me.NOPRCN, Me.FINCOP_S, Me.NORSRT, Me.CCLNT, Me.CCLNT_S, Me.RUTA, Me.NPLCUN, Me.NPLCAC, Me.CBRCNT, Me.CBRCND, Me.SESTOP, Me.Column1})
        Me.gwdOperacionesXAlquiler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdOperacionesXAlquiler.Location = New System.Drawing.Point(3, 3)
        Me.gwdOperacionesXAlquiler.MultiSelect = False
        Me.gwdOperacionesXAlquiler.Name = "gwdOperacionesXAlquiler"
        Me.gwdOperacionesXAlquiler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gwdOperacionesXAlquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdOperacionesXAlquiler.Size = New System.Drawing.Size(1140, 312)
        Me.gwdOperacionesXAlquiler.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdOperacionesXAlquiler.TabIndex = 7
        '
        'NRUCTR1
        '
        Me.NRUCTR1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR1.DataPropertyName = "NRUCTR"
        Me.NRUCTR1.HeaderText = "NRUCTR"
        Me.NRUCTR1.Name = "NRUCTR1"
        Me.NRUCTR1.Visible = False
        Me.NRUCTR1.Width = 82
        '
        'NRALQT1
        '
        Me.NRALQT1.DataPropertyName = "NRALQT"
        Me.NRALQT1.HeaderText = "NRALQT"
        Me.NRALQT1.Name = "NRALQT1"
        Me.NRALQT1.ReadOnly = True
        Me.NRALQT1.Visible = False
        '
        'NCRRRT
        '
        Me.NCRRRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRRT.DataPropertyName = "NCRRRT"
        Me.NCRRRT.HeaderText = "Corr."
        Me.NCRRRT.Name = "NCRRRT"
        Me.NCRRRT.ReadOnly = True
        Me.NCRRRT.Width = 62
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Transportista"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Width = 104
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 91
        '
        'FINCOP_S
        '
        Me.FINCOP_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FINCOP_S.DataPropertyName = "FINCOP_S"
        Me.FINCOP_S.HeaderText = "Fecha Operación"
        Me.FINCOP_S.Name = "FINCOP_S"
        Me.FINCOP_S.ReadOnly = True
        Me.FINCOP_S.Width = 125
        '
        'NORSRT
        '
        Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSRT.DataPropertyName = "NORSRT"
        Me.NORSRT.HeaderText = "O/S"
        Me.NORSRT.Name = "NORSRT"
        Me.NORSRT.ReadOnly = True
        Me.NORSRT.Width = 56
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.Visible = False
        '
        'CCLNT_S
        '
        Me.CCLNT_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCLNT_S.DataPropertyName = "CCLNT_S"
        Me.CCLNT_S.HeaderText = "Cliente"
        Me.CCLNT_S.Name = "CCLNT_S"
        Me.CCLNT_S.ReadOnly = True
        Me.CCLNT_S.Width = 73
        '
        'RUTA
        '
        Me.RUTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUTA.DataPropertyName = "RUTA"
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.ReadOnly = True
        Me.RUTA.Width = 60
        '
        'NPLCUN
        '
        Me.NPLCUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCUN.DataPropertyName = "NPLCUN"
        Me.NPLCUN.HeaderText = "Placa Tracto"
        Me.NPLCUN.Name = "NPLCUN"
        Me.NPLCUN.ReadOnly = True
        '
        'NPLCAC
        '
        Me.NPLCAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLCAC.DataPropertyName = "NPLCAC"
        Me.NPLCAC.HeaderText = "Placa Acoplado"
        Me.NPLCAC.Name = "NPLCAC"
        Me.NPLCAC.ReadOnly = True
        Me.NPLCAC.Width = 118
        '
        'CBRCNT
        '
        Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "CBRCNT"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.Visible = False
        Me.CBRCNT.Width = 82
        '
        'CBRCND
        '
        Me.CBRCND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCND.DataPropertyName = "CBRCND"
        Me.CBRCND.HeaderText = "Conductor"
        Me.CBRCND.Name = "CBRCND"
        Me.CBRCND.ReadOnly = True
        Me.CBRCND.Width = 93
        '
        'SESTOP
        '
        Me.SESTOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTOP.DataPropertyName = "SESTOP"
        Me.SESTOP.HeaderText = "Estado Op."
        Me.SESTOP.Name = "SESTOP"
        Me.SESTOP.ReadOnly = True
        Me.SESTOP.Width = 93
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevoAlquiler, Me.btnModificar, Me.ToolStripSeparator1, Me.btnGuardarAlquiler, Me.ToolStripSeparator2, Me.btnCancelarAlquiler, Me.ToolStripSeparator3, Me.btnEliminarAlquiler, Me.ToolStripSeparator4, Me.btnCerrarAlquiler, Me.ToolStripSeparator5, Me.btnEliminarOperacion})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1154, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnNuevoAlquiler
        '
        Me.btnNuevoAlquiler.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevoAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevoAlquiler.Name = "btnNuevoAlquiler"
        Me.btnNuevoAlquiler.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevoAlquiler.Text = "Nuevo"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardarAlquiler
        '
        Me.btnGuardarAlquiler.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnGuardarAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarAlquiler.Name = "btnGuardarAlquiler"
        Me.btnGuardarAlquiler.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardarAlquiler.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelarAlquiler
        '
        Me.btnCancelarAlquiler.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelarAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarAlquiler.Name = "btnCancelarAlquiler"
        Me.btnCancelarAlquiler.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelarAlquiler.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminarAlquiler
        '
        Me.btnEliminarAlquiler.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminarAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarAlquiler.Name = "btnEliminarAlquiler"
        Me.btnEliminarAlquiler.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminarAlquiler.Text = "Eliminar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnCerrarAlquiler
        '
        Me.btnCerrarAlquiler.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnCerrarAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrarAlquiler.Name = "btnCerrarAlquiler"
        Me.btnCerrarAlquiler.Size = New System.Drawing.Size(103, 22)
        Me.btnCerrarAlquiler.Text = "Cerrar Alquiler"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminarOperacion
        '
        Me.btnEliminarOperacion.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminarOperacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarOperacion.Name = "btnEliminarOperacion"
        Me.btnEliminarOperacion.Size = New System.Drawing.Size(60, 22)
        Me.btnEliminarOperacion.Text = "Quitar"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRALQT"
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro. Alquiler"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CPLNDV"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NRUCTR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NPLRCS"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Fin"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FVALIN_S"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FVALFI_S"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CMNALQ"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ref. SAP"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TMNDA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IMP_TOTAL"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha SAP"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CCNCS1"
        Me.DataGridViewTextBoxColumn12.HeaderText = "CCNCS1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SESALQ_S"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn13.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Corr."
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NORINS"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn14.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NLQDCN"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn15.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CUSCRT"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn16.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CULUSA"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "N0"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn17.HeaderText = "KM x Ruta"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CUSCRT"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn18.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = " "
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CULUSA"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn19.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NRALQT"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn20.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn20.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NRUCTR"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Format = "N0"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn21.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "TCMTRT"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Format = "N0"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn22.HeaderText = "KM x Ruta"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "STPRCS"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Format = "N0"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn23.HeaderText = " "
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TDSDES"
        Me.DataGridViewTextBoxColumn24.HeaderText = "KM x Ruta"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "NRALQT"
        Me.DataGridViewTextBoxColumn25.HeaderText = " "
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "NCRRRT"
        Me.DataGridViewTextBoxColumn26.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn26.HeaderText = "Corr."
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn27.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn27.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "CCNCST"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "CRUTA"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "NKMRTA"
        Me.DataGridViewTextBoxColumn30.HeaderText = "KM x Ruta"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn31.HeaderText = "SESTRG"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "SESTRG"
        Me.DataGridViewTextBoxColumn32.HeaderText = " "
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "FVALIN_S"
        Me.DataGridViewTextBoxColumn33.HeaderText = " "
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "CCLNT_S"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "RUTA"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Placa Tracto"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Visible = False
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn39.HeaderText = "CBRCNT"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Visible = False
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "CBRCND"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "SESTOP"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Estado Op."
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "SESTOP"
        Me.DataGridViewTextBoxColumn42.HeaderText = " "
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "NPLCUN"
        Me.DataGridViewTextBoxColumn43.HeaderText = " "
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "NPLCAC"
        Me.DataGridViewTextBoxColumn44.HeaderText = "Placa Acoplado"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "CBRCNT"
        Me.DataGridViewTextBoxColumn45.HeaderText = "CBRCNT"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Visible = False
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "CBRCND"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "SESTOP"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Estado Op."
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn48.HeaderText = " "
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'frmAlquilerUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 661)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAlquilerUnidad"
        Me.Text = "Alquiler de Unidades"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
        Me.tabDatosAlquiler.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpLiquidacion.ResumeLayout(False)
        Me.grpLiquidacion.PerformLayout()
        Me.tabOperacion.ResumeLayout(False)
        CType(Me.gwdOperacionesXAlquiler, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TabAlquiler As System.Windows.Forms.TabControl
    Friend WithEvents tabDatosAlquiler As System.Windows.Forms.TabPage
    Friend WithEvents tabOperacion As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevoAlquiler As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardarAlquiler As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelarAlquiler As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminarAlquiler As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCerrarAlquiler As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminarOperacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents btnExportar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpLiquidacion As System.Windows.Forms.GroupBox
    Friend WithEvents lblLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblReferenciaSAP As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaLiq As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbEstadoAlq As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtNroAlquiler As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbProveedorFiltro As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaAsignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbServicio As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblOrdenInterna As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbMoneda As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents btnRecursosAsignados As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNroAlquiler1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtReferenciaSAP As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNroLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtOrdenInterna As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents dtpFechaAsigInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaAsigFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbFechaAsignacion As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCentroCosto As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnLiquidarPago As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtPlaca As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtImporteLiq As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDocumentoLiq As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRefOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAnularRefPedido As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnProveedorAsignado As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents gwdOperacionesXAlquiler As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnviarSAP As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnExportarAlquiler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExportarAlquilerDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBuscar1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAprobarAlquiler As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonTextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoRecurso As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NRUCTR1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRALQT1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINCOP_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonTextBox3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox4 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NRALQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFDO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPRCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDSDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLRCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNCS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCHASG_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FVALIN_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FVALFI_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNALQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QCNALQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IRVALQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMP_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESALQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESALQ_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORINS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSRCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGAPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGAPR_APR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSAPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUSCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CULUSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBRES2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBRES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBRE3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
End Class
