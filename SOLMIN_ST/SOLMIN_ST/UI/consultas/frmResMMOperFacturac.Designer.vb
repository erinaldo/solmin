<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResMMOperFacturac
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
    Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HeaderGroupTabs = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFINCOP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFTRMOP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLSESTOP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNPLNMT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNORINS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLTCRVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNRFSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNENMRS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLTRFSRC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLCTPDCF = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNDCMFC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLSESTGU = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNLQDCN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFCHCRR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLCLCLOR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLCLCLDS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLNPLVHT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLCBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLTNMCH2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLTCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLFCHCRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLHRACRT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MNDCO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLIMPCO = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.MNDPA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLIMPPA = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLGASTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.COLGASTOAVC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.ControlVisorVehiculo = New SOLMIN_ST.Control_Visor_Reporte
    Me.TabPage3 = New System.Windows.Forms.TabPage
    Me.Control_Visor_ReporteGrafico = New SOLMIN_ST.Control_Visor_Reporte
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.MenuBar = New System.Windows.Forms.ToolStrip
    Me.btnProcesarReporte = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnImprimir = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
    Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
    Me.HeaderGroupFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboRegionVenta = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.rbnFechaOperacion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.rbnFechaGuiaTransporte = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
    Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.CheckedComboBox1 = New SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
    Me.ctlCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.lblProceso = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.pbxProceso = New System.Windows.Forms.PictureBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cmbEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Me.txtTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
    Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.bgwProceso = New System.ComponentModel.BackgroundWorker
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
    Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupTabs.Panel.SuspendLayout()
    Me.HeaderGroupTabs.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.MenuBar.SuspendLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderGroupFiltro.Panel.SuspendLayout()
    Me.HeaderGroupFiltro.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    CType(Me.pbxProceso, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupTabs)
    Me.KryptonPanel.Controls.Add(Me.HeaderGroupFiltro)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1042, 577)
    Me.KryptonPanel.TabIndex = 0
    '
    'HeaderGroupTabs
    '
    Me.HeaderGroupTabs.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HeaderGroupTabs.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupTabs.Location = New System.Drawing.Point(0, 185)
    Me.HeaderGroupTabs.Name = "HeaderGroupTabs"
    '
    'HeaderGroupTabs.Panel
    '
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.TabControl1)
    Me.HeaderGroupTabs.Panel.Controls.Add(Me.Panel2)
    Me.HeaderGroupTabs.Size = New System.Drawing.Size(1042, 392)
    Me.HeaderGroupTabs.TabIndex = 4
    Me.HeaderGroupTabs.Text = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Description = ""
    Me.HeaderGroupTabs.ValuesPrimary.Heading = "Resultados"
    Me.HeaderGroupTabs.ValuesPrimary.Image = Nothing
    Me.HeaderGroupTabs.ValuesSecondary.Description = ""
    Me.HeaderGroupTabs.ValuesSecondary.Heading = ""
    Me.HeaderGroupTabs.ValuesSecondary.Image = Nothing
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1040, 342)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.gwdDatos)
    Me.TabPage1.ImageIndex = 4
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(1032, 316)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Consulta en Pantalla"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'gwdDatos
    '
    Me.gwdDatos.AccessibleDescription = ""
    Me.gwdDatos.AllowUserToAddRows = False
    Me.gwdDatos.AllowUserToDeleteRows = False
    Me.gwdDatos.AllowUserToResizeColumns = False
    Me.gwdDatos.AllowUserToResizeRows = False
    Me.gwdDatos.ColumnHeadersHeight = 30
    Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPLNDV, Me.COLNOPRCN, Me.COLFINCOP, Me.COLFTRMOP, Me.COLSESTOP, Me.ESTADO, Me.COLNPLNMT, Me.COLNORINS, Me.COLTCRVTA, Me.COLNRFSAP, Me.COLNENMRS, Me.COLTRFSRC, Me.COLNDCPRF, Me.CLIENTE, Me.CCLNFC, Me.COLFDCPRF, Me.COLCTPDCF, Me.COLNDCMFC, Me.COLNGUITR, Me.COLFGUITR, Me.COLNGUIRM, Me.COLFGUIRM, Me.COLSESTGU, Me.COLNLQDCN, Me.COLFCHCRR, Me.COLCLCLOR, Me.COLCLCLDS, Me.COLNPLVHT, Me.COLCBRCNT, Me.COLTNMCH2, Me.COLTCMTRT, Me.COLFCHCRT, Me.COLHRACRT, Me.MNDCO, Me.COLIMPCO, Me.MNDPA, Me.COLIMPPA, Me.COLGASTOS, Me.COLGASTOAVC})
    Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
    Me.gwdDatos.Location = New System.Drawing.Point(3, 3)
    Me.gwdDatos.MultiSelect = False
    Me.gwdDatos.Name = "gwdDatos"
    Me.gwdDatos.ReadOnly = True
    Me.gwdDatos.RowHeadersWidth = 20
    Me.gwdDatos.RowTemplate.Height = 16
    Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.gwdDatos.Size = New System.Drawing.Size(1026, 310)
    Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.gwdDatos.TabIndex = 0
    '
    'CPLNDV
    '
    Me.CPLNDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CPLNDV.DataPropertyName = "CPLNDV"
    Me.CPLNDV.HeaderText = "Planta"
    Me.CPLNDV.Name = "CPLNDV"
    Me.CPLNDV.ReadOnly = True
    Me.CPLNDV.Width = 68
    '
    'COLNOPRCN
    '
    Me.COLNOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNOPRCN.DataPropertyName = "NOPRCN"
    Me.COLNOPRCN.HeaderText = "Número Operación"
    Me.COLNOPRCN.Name = "COLNOPRCN"
    Me.COLNOPRCN.ReadOnly = True
    Me.COLNOPRCN.Width = 134
    '
    'COLFINCOP
    '
    Me.COLFINCOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFINCOP.DataPropertyName = "FINCOP"
    Me.COLFINCOP.HeaderText = "Fecha Inicio Operación"
    Me.COLFINCOP.Name = "COLFINCOP"
    Me.COLFINCOP.ReadOnly = True
    Me.COLFINCOP.Width = 154
    '
    'COLFTRMOP
    '
    Me.COLFTRMOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFTRMOP.DataPropertyName = "LFTRMOP"
    Me.COLFTRMOP.HeaderText = "Fecha Termino Operación"
    Me.COLFTRMOP.Name = "COLFTRMOP"
    Me.COLFTRMOP.ReadOnly = True
    Me.COLFTRMOP.Width = 167
    '
    'COLSESTOP
    '
    Me.COLSESTOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLSESTOP.DataPropertyName = "SESTOP"
    Me.COLSESTOP.HeaderText = "Est."
    Me.COLSESTOP.Name = "COLSESTOP"
    Me.COLSESTOP.ReadOnly = True
    Me.COLSESTOP.Width = 54
    '
    'ESTADO
    '
    Me.ESTADO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.ESTADO.DataPropertyName = "ESTADO"
    Me.ESTADO.HeaderText = "Estado de Operación"
    Me.ESTADO.Name = "ESTADO"
    Me.ESTADO.ReadOnly = True
    Me.ESTADO.Width = 144
    '
    'COLNPLNMT
    '
    Me.COLNPLNMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNPLNMT.DataPropertyName = "NPLNMT"
    Me.COLNPLNMT.HeaderText = "Número de Planeamiento"
    Me.COLNPLNMT.Name = "COLNPLNMT"
    Me.COLNPLNMT.ReadOnly = True
    Me.COLNPLNMT.Width = 166
    '
    'COLNORINS
    '
    Me.COLNORINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNORINS.DataPropertyName = "NORINS"
    Me.COLNORINS.HeaderText = "Numero de O/I"
    Me.COLNORINS.Name = "COLNORINS"
    Me.COLNORINS.ReadOnly = True
    Me.COLNORINS.Width = 112
    '
    'COLTCRVTA
    '
    Me.COLTCRVTA.DataPropertyName = "TCRVTA"
    DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.COLTCRVTA.DefaultCellStyle = DataGridViewCellStyle16
    Me.COLTCRVTA.HeaderText = "Region Venta"
    Me.COLTCRVTA.Name = "COLTCRVTA"
    Me.COLTCRVTA.ReadOnly = True
    '
    'COLNRFSAP
    '
    Me.COLNRFSAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNRFSAP.DataPropertyName = "NRFSAP"
    Me.COLNRFSAP.HeaderText = "Referencia SAP"
    Me.COLNRFSAP.Name = "COLNRFSAP"
    Me.COLNRFSAP.ReadOnly = True
    Me.COLNRFSAP.Width = 112
    '
    'COLNENMRS
    '
    Me.COLNENMRS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNENMRS.DataPropertyName = "NENMRS"
    Me.COLNENMRS.HeaderText = "Número Entrada"
    Me.COLNENMRS.Name = "COLNENMRS"
    Me.COLNENMRS.ReadOnly = True
    Me.COLNENMRS.Width = 120
    '
    'COLTRFSRC
    '
    Me.COLTRFSRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLTRFSRC.DataPropertyName = "TRFSRC"
    Me.COLTRFSRC.HeaderText = "Referencia Servicio al Cliente"
    Me.COLTRFSRC.Name = "COLTRFSRC"
    Me.COLTRFSRC.ReadOnly = True
    Me.COLTRFSRC.Width = 183
    '
    'COLNDCPRF
    '
    Me.COLNDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNDCPRF.DataPropertyName = "NDCPRF"
    Me.COLNDCPRF.HeaderText = "Num Documento Prefacturado"
    Me.COLNDCPRF.Name = "COLNDCPRF"
    Me.COLNDCPRF.ReadOnly = True
    Me.COLNDCPRF.Width = 192
    '
    'CLIENTE
    '
    Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CLIENTE.DataPropertyName = "CCLNT"
    Me.CLIENTE.HeaderText = "Cliente"
    Me.CLIENTE.Name = "CLIENTE"
    Me.CLIENTE.ReadOnly = True
    Me.CLIENTE.Width = 72
    '
    'CCLNFC
    '
    Me.CCLNFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.CCLNFC.DataPropertyName = "CCLNFC"
    Me.CCLNFC.HeaderText = "Cliente a Facturar"
    Me.CCLNFC.Name = "CCLNFC"
    Me.CCLNFC.ReadOnly = True
    Me.CCLNFC.Width = 126
    '
    'COLFDCPRF
    '
    Me.COLFDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFDCPRF.DataPropertyName = "FDCPRF"
    Me.COLFDCPRF.HeaderText = "Fecha de PreFactura"
    Me.COLFDCPRF.Name = "COLFDCPRF"
    Me.COLFDCPRF.ReadOnly = True
    Me.COLFDCPRF.Width = 139
    '
    'COLCTPDCF
    '
    Me.COLCTPDCF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLCTPDCF.DataPropertyName = "CTPDCF"
    Me.COLCTPDCF.HeaderText = "Tipo Documento Facturación"
    Me.COLCTPDCF.Name = "COLCTPDCF"
    Me.COLCTPDCF.ReadOnly = True
    Me.COLCTPDCF.Width = 184
    '
    'COLNDCMFC
    '
    Me.COLNDCMFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNDCMFC.DataPropertyName = "NDCMFC"
    Me.COLNDCMFC.HeaderText = "Num Documento Facturación"
    Me.COLNDCMFC.Name = "COLNDCMFC"
    Me.COLNDCMFC.ReadOnly = True
    Me.COLNDCMFC.Width = 186
    '
    'COLNGUITR
    '
    Me.COLNGUITR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNGUITR.DataPropertyName = "NGUITR"
    Me.COLNGUITR.HeaderText = "Guía Transportista"
    Me.COLNGUITR.Name = "COLNGUITR"
    Me.COLNGUITR.ReadOnly = True
    Me.COLNGUITR.Width = 130
    '
    'COLFGUITR
    '
    Me.COLFGUITR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFGUITR.DataPropertyName = "FGUITR"
    Me.COLFGUITR.HeaderText = "Fecha Guía Transportista"
    Me.COLFGUITR.Name = "COLFGUITR"
    Me.COLFGUITR.ReadOnly = True
    Me.COLFGUITR.Width = 163
    '
    'COLNGUIRM
    '
    Me.COLNGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNGUIRM.DataPropertyName = "NGUIRM"
    Me.COLNGUIRM.HeaderText = "Número Guía Remisión"
    Me.COLNGUIRM.Name = "COLNGUIRM"
    Me.COLNGUIRM.ReadOnly = True
    Me.COLNGUIRM.Width = 154
    '
    'COLFGUIRM
    '
    Me.COLFGUIRM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFGUIRM.DataPropertyName = "FGUIRM"
    Me.COLFGUIRM.HeaderText = "Fecha de Guía Remisión"
    Me.COLFGUIRM.Name = "COLFGUIRM"
    Me.COLFGUIRM.ReadOnly = True
    Me.COLFGUIRM.Width = 159
    '
    'COLSESTGU
    '
    Me.COLSESTGU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLSESTGU.DataPropertyName = "SESTGU"
    Me.COLSESTGU.HeaderText = "Flag Estado Guía Remisión"
    Me.COLSESTGU.Name = "COLSESTGU"
    Me.COLSESTGU.ReadOnly = True
    Me.COLSESTGU.Width = 173
    '
    'COLNLQDCN
    '
    Me.COLNLQDCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNLQDCN.DataPropertyName = "NLQDCN"
    Me.COLNLQDCN.HeaderText = "Numero de Liquidación"
    Me.COLNLQDCN.Name = "COLNLQDCN"
    Me.COLNLQDCN.ReadOnly = True
    Me.COLNLQDCN.Width = 156
    '
    'COLFCHCRR
    '
    Me.COLFCHCRR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFCHCRR.DataPropertyName = "FCHCRR"
    Me.COLFCHCRR.HeaderText = "Fecha Liquidación Transportista"
    Me.COLFCHCRR.Name = "COLFCHCRR"
    Me.COLFCHCRR.ReadOnly = True
    Me.COLFCHCRR.Width = 199
    '
    'COLCLCLOR
    '
    Me.COLCLCLOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLCLCLOR.DataPropertyName = "CLCLOR"
    Me.COLCLCLOR.HeaderText = "Código de Localidad Origen"
    Me.COLCLCLOR.Name = "COLCLCLOR"
    Me.COLCLCLOR.ReadOnly = True
    Me.COLCLCLOR.Width = 181
    '
    'COLCLCLDS
    '
    Me.COLCLCLDS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLCLCLDS.DataPropertyName = "CLCLDS"
    Me.COLCLCLDS.HeaderText = "Código de Localidad Destino"
    Me.COLCLCLDS.Name = "COLCLCLDS"
    Me.COLCLCLDS.ReadOnly = True
    Me.COLCLCLDS.Width = 185
    '
    'COLNPLVHT
    '
    Me.COLNPLVHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLNPLVHT.DataPropertyName = "NPLVHT"
    Me.COLNPLVHT.HeaderText = "Placa Vehículo"
    Me.COLNPLVHT.Name = "COLNPLVHT"
    Me.COLNPLVHT.ReadOnly = True
    Me.COLNPLVHT.Width = 110
    '
    'COLCBRCNT
    '
    Me.COLCBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLCBRCNT.DataPropertyName = "CBRCNT"
    Me.COLCBRCNT.HeaderText = "Brevete Conductor"
    Me.COLCBRCNT.Name = "COLCBRCNT"
    Me.COLCBRCNT.ReadOnly = True
    Me.COLCBRCNT.Width = 132
    '
    'COLTNMCH2
    '
    Me.COLTNMCH2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLTNMCH2.DataPropertyName = "TNMCH2"
    Me.COLTNMCH2.HeaderText = "Des Nombre del Chofe 2"
    Me.COLTNMCH2.Name = "COLTNMCH2"
    Me.COLTNMCH2.ReadOnly = True
    Me.COLTNMCH2.Width = 161
    '
    'COLTCMTRT
    '
    Me.COLTCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLTCMTRT.DataPropertyName = "TCMTRT"
    Me.COLTCMTRT.HeaderText = "Descripción del Transportista"
    Me.COLTCMTRT.Name = "COLTCMTRT"
    Me.COLTCMTRT.ReadOnly = True
    Me.COLTCMTRT.Width = 185
    '
    'COLFCHCRT
    '
    Me.COLFCHCRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLFCHCRT.DataPropertyName = "FCHCRT"
    Me.COLFCHCRT.HeaderText = "Fecha Creación"
    Me.COLFCHCRT.Name = "COLFCHCRT"
    Me.COLFCHCRT.ReadOnly = True
    Me.COLFCHCRT.Width = 114
    '
    'COLHRACRT
    '
    Me.COLHRACRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLHRACRT.DataPropertyName = "HRACRT"
    Me.COLHRACRT.HeaderText = "Hora Creación"
    Me.COLHRACRT.Name = "COLHRACRT"
    Me.COLHRACRT.ReadOnly = True
    Me.COLHRACRT.Width = 109
    '
    'MNDCO
    '
    Me.MNDCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.MNDCO.DataPropertyName = "MNDCO"
    Me.MNDCO.HeaderText = "Moneda"
    Me.MNDCO.Name = "MNDCO"
    Me.MNDCO.ReadOnly = True
    Me.MNDCO.Width = 79
    '
    'COLIMPCO
    '
    Me.COLIMPCO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLIMPCO.DataPropertyName = "IMPCO"
    Me.COLIMPCO.HeaderText = "Tarifa Cobrar"
    Me.COLIMPCO.Name = "COLIMPCO"
    Me.COLIMPCO.ReadOnly = True
    Me.COLIMPCO.Width = 102
    '
    'MNDPA
    '
    Me.MNDPA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.MNDPA.DataPropertyName = "MNDPA"
    Me.MNDPA.HeaderText = "Moneda"
    Me.MNDPA.Name = "MNDPA"
    Me.MNDPA.ReadOnly = True
    Me.MNDPA.Width = 79
    '
    'COLIMPPA
    '
    Me.COLIMPPA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLIMPPA.DataPropertyName = "IMPPA"
    Me.COLIMPPA.HeaderText = "Tarifa Pagar"
    Me.COLIMPPA.Name = "COLIMPPA"
    Me.COLIMPPA.ReadOnly = True
    Me.COLIMPPA.Width = 96
    '
    'COLGASTOS
    '
    Me.COLGASTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLGASTOS.DataPropertyName = "GASTOS"
    Me.COLGASTOS.HeaderText = "Gastos Ruta"
    Me.COLGASTOS.Name = "COLGASTOS"
    Me.COLGASTOS.ReadOnly = True
    Me.COLGASTOS.Width = 98
    '
    'COLGASTOAVC
    '
    Me.COLGASTOAVC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.COLGASTOAVC.DataPropertyName = "GASTOAVC"
    Me.COLGASTOAVC.HeaderText = "Gasto AVC"
    Me.COLGASTOAVC.Name = "COLGASTOAVC"
    Me.COLGASTOAVC.ReadOnly = True
    Me.COLGASTOAVC.Width = 90
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.ControlVisorVehiculo)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Size = New System.Drawing.Size(999, 346)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Detalle"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'ControlVisorVehiculo
    '
    Me.ControlVisorVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ControlVisorVehiculo.Location = New System.Drawing.Point(0, 0)
    Me.ControlVisorVehiculo.Name = "ControlVisorVehiculo"
    Me.ControlVisorVehiculo.Size = New System.Drawing.Size(999, 346)
    Me.ControlVisorVehiculo.TabIndex = 2
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.Control_Visor_ReporteGrafico)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Size = New System.Drawing.Size(999, 346)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "Resumen"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'Control_Visor_ReporteGrafico
    '
    Me.Control_Visor_ReporteGrafico.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Control_Visor_ReporteGrafico.Location = New System.Drawing.Point(0, 0)
    Me.Control_Visor_ReporteGrafico.Name = "Control_Visor_ReporteGrafico"
    Me.Control_Visor_ReporteGrafico.Size = New System.Drawing.Size(999, 346)
    Me.Control_Visor_ReporteGrafico.TabIndex = 3
    '
    'Panel2
    '
    Me.Panel2.AutoSize = True
    Me.Panel2.Controls.Add(Me.MenuBar)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(1040, 25)
    Me.Panel2.TabIndex = 4
    '
    'MenuBar
    '
    Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesarReporte, Me.ToolStripSeparator1, Me.btnImprimir, Me.ToolStripSeparator4, Me.btnExportarExcel})
    Me.MenuBar.Location = New System.Drawing.Point(0, 0)
    Me.MenuBar.Name = "MenuBar"
    Me.MenuBar.Size = New System.Drawing.Size(1040, 25)
    Me.MenuBar.TabIndex = 0
    Me.MenuBar.Text = "ToolStrip1"
    '
    'btnProcesarReporte
    '
    Me.btnProcesarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnProcesarReporte.Image = Global.SOLMIN_ST.My.Resources.Resources.search
    Me.btnProcesarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnProcesarReporte.Name = "btnProcesarReporte"
    Me.btnProcesarReporte.Size = New System.Drawing.Size(61, 22)
    Me.btnProcesarReporte.Text = "Buscar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnImprimir
    '
    Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
    Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(113, 22)
    Me.btnImprimir.Text = "Imprimir Reporte"
    Me.btnImprimir.Visible = False
    '
    'ToolStripSeparator4
    '
    Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
    Me.ToolStripSeparator4.Visible = False
    '
    'btnExportarExcel
    '
    Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnExportarExcel.Image = Global.SOLMIN_ST.My.Resources.Resources.excelicon
    Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnExportarExcel.Name = "btnExportarExcel"
    Me.btnExportarExcel.Size = New System.Drawing.Size(98, 22)
    Me.btnExportarExcel.Text = "Exportar Excel"
    '
    'HeaderGroupFiltro
    '
    Me.HeaderGroupFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.HeaderGroupFiltro.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
    Me.HeaderGroupFiltro.Location = New System.Drawing.Point(0, 0)
    Me.HeaderGroupFiltro.Name = "HeaderGroupFiltro"
    '
    'HeaderGroupFiltro.Panel
    '
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbDivision)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbCompania)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel3)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cboRegionVenta)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel2)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.GroupBox1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.CheckedComboBox1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.ctlCliente)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblProceso)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.pbxProceso)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.cmbEstado)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.txtTransportista)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel8)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblPlanta)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.lblCompania)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel7)
    Me.HeaderGroupFiltro.Panel.Controls.Add(Me.KryptonLabel5)
    Me.HeaderGroupFiltro.Size = New System.Drawing.Size(1042, 185)
    Me.HeaderGroupFiltro.TabIndex = 3
    Me.HeaderGroupFiltro.Text = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Description = ""
    Me.HeaderGroupFiltro.ValuesPrimary.Heading = "Opciones de filtro"
    Me.HeaderGroupFiltro.ValuesPrimary.Image = Nothing
    Me.HeaderGroupFiltro.ValuesSecondary.Description = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Heading = ""
    Me.HeaderGroupFiltro.ValuesSecondary.Image = Nothing
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
    Me.cmbDivision.Location = New System.Drawing.Point(460, 7)
    Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
    Me.cmbDivision.Name = "cmbDivision"
    Me.cmbDivision.Size = New System.Drawing.Size(238, 23)
    Me.cmbDivision.TabIndex = 134
    Me.cmbDivision.Usuario = ""
    '
    'cmbCompania
    '
    Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
    Me.cmbCompania.CCMPN_ANTERIOR = Nothing
    Me.cmbCompania.CCMPN_CodigoCompania = Nothing
    Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
    Me.cmbCompania.CCMPN_Descripcion = Nothing
    Me.cmbCompania.Location = New System.Drawing.Point(119, 7)
    Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
    Me.cmbCompania.Name = "cmbCompania"
    Me.cmbCompania.Size = New System.Drawing.Size(244, 23)
    Me.cmbCompania.TabIndex = 133
    Me.cmbCompania.Usuario = ""
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(11, 80)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(93, 19)
    Me.KryptonLabel3.TabIndex = 130
    Me.KryptonLabel3.Text = "Región de Venta"
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Región de Venta"
    '
    'cboRegionVenta
    '
    Me.cboRegionVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboRegionVenta.DropDownWidth = 238
    Me.cboRegionVenta.FormattingEnabled = False
    Me.cboRegionVenta.ItemHeight = 13
    Me.cboRegionVenta.Location = New System.Drawing.Point(118, 79)
    Me.cboRegionVenta.Name = "cboRegionVenta"
    Me.cboRegionVenta.Size = New System.Drawing.Size(245, 21)
    Me.cboRegionVenta.TabIndex = 129
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(378, 81)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(40, 17)
    Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel2.TabIndex = 128
    Me.KryptonLabel2.Text = "Fecha"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Fecha"
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.White
    Me.GroupBox1.Controls.Add(Me.rbnFechaOperacion)
    Me.GroupBox1.Controls.Add(Me.rbnFechaGuiaTransporte)
    Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
    Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
    Me.GroupBox1.Controls.Add(Me.KryptonLabel4)
    Me.GroupBox1.Location = New System.Drawing.Point(458, 75)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(238, 78)
    Me.GroupBox1.TabIndex = 127
    Me.GroupBox1.TabStop = False
    '
    'rbnFechaOperacion
    '
    Me.rbnFechaOperacion.Checked = True
    Me.rbnFechaOperacion.Location = New System.Drawing.Point(15, 17)
    Me.rbnFechaOperacion.Name = "rbnFechaOperacion"
    Me.rbnFechaOperacion.Size = New System.Drawing.Size(74, 19)
    Me.rbnFechaOperacion.TabIndex = 125
    Me.rbnFechaOperacion.Text = "Operación"
    Me.rbnFechaOperacion.Values.ExtraText = ""
    Me.rbnFechaOperacion.Values.Image = Nothing
    Me.rbnFechaOperacion.Values.Text = "Operación"
    '
    'rbnFechaGuiaTransporte
    '
    Me.rbnFechaGuiaTransporte.Location = New System.Drawing.Point(120, 17)
    Me.rbnFechaGuiaTransporte.Name = "rbnFechaGuiaTransporte"
    Me.rbnFechaGuiaTransporte.Size = New System.Drawing.Size(102, 19)
    Me.rbnFechaGuiaTransporte.TabIndex = 126
    Me.rbnFechaGuiaTransporte.Text = "Guía Transporte"
    Me.rbnFechaGuiaTransporte.Values.ExtraText = ""
    Me.rbnFechaGuiaTransporte.Values.Image = Nothing
    Me.rbnFechaGuiaTransporte.Values.Text = "Guía Transporte"
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(20, 45)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaInicio.TabIndex = 5
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(135, 45)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
    Me.dtpFechaFin.TabIndex = 6
    '
    'KryptonLabel4
    '
    Me.KryptonLabel4.Location = New System.Drawing.Point(109, 47)
    Me.KryptonLabel4.Name = "KryptonLabel4"
    Me.KryptonLabel4.Size = New System.Drawing.Size(20, 17)
    Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel4.TabIndex = 105
    Me.KryptonLabel4.Text = "Al"
    Me.KryptonLabel4.Values.ExtraText = ""
    Me.KryptonLabel4.Values.Image = Nothing
    Me.KryptonLabel4.Values.Text = "Al"
    '
    'CheckedComboBox1
    '
    Me.CheckedComboBox1.CheckOnClick = True
    Me.CheckedComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
    Me.CheckedComboBox1.DropDownHeight = 1
    Me.CheckedComboBox1.FormattingEnabled = True
    Me.CheckedComboBox1.IntegralHeight = False
    Me.CheckedComboBox1.Location = New System.Drawing.Point(823, 8)
    Me.CheckedComboBox1.Name = "CheckedComboBox1"
    Me.CheckedComboBox1.Size = New System.Drawing.Size(180, 21)
    Me.CheckedComboBox1.TabIndex = 124
    Me.CheckedComboBox1.ValueSeparator = ", "
    '
    'ctlCliente
    '
    Me.ctlCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ctlCliente.BackColor = System.Drawing.Color.Transparent
    Me.ctlCliente.CCMPN = "EZ"
    Me.ctlCliente.Location = New System.Drawing.Point(118, 42)
    Me.ctlCliente.Name = "ctlCliente"
    Me.ctlCliente.pAccesoPorUsuario = False
    Me.ctlCliente.pRequerido = False
    Me.ctlCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.ctlCliente.Size = New System.Drawing.Size(245, 21)
    Me.ctlCliente.TabIndex = 120
    '
    'lblProceso
    '
    Me.lblProceso.Location = New System.Drawing.Point(158, 116)
    Me.lblProceso.Name = "lblProceso"
    Me.lblProceso.Size = New System.Drawing.Size(18, 19)
    Me.lblProceso.TabIndex = 119
    Me.lblProceso.Text = "..."
    Me.lblProceso.Values.ExtraText = ""
    Me.lblProceso.Values.Image = Nothing
    Me.lblProceso.Values.Text = "..."
    '
    'pbxProceso
    '
    Me.pbxProceso.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.pbxProceso.Image = Global.SOLMIN_ST.My.Resources.Resources.mozilla_blu
    Me.pbxProceso.Location = New System.Drawing.Point(118, 110)
    Me.pbxProceso.Name = "pbxProceso"
    Me.pbxProceso.Size = New System.Drawing.Size(33, 30)
    Me.pbxProceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.pbxProceso.TabIndex = 118
    Me.pbxProceso.TabStop = False
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.Location = New System.Drawing.Point(723, 43)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(44, 19)
    Me.KryptonLabel1.TabIndex = 117
    Me.KryptonLabel1.Text = "Estado"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Estado"
    '
    'cmbEstado
    '
    Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cmbEstado.DropDownWidth = 238
    Me.cmbEstado.FormattingEnabled = False
    Me.cmbEstado.ItemHeight = 13
    Me.cmbEstado.Location = New System.Drawing.Point(823, 42)
    Me.cmbEstado.Name = "cmbEstado"
    Me.cmbEstado.Size = New System.Drawing.Size(180, 21)
    Me.cmbEstado.TabIndex = 116
    '
    'txtTransportista
    '
    Me.txtTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.txtTransportista.BackColor = System.Drawing.Color.Transparent
    Me.txtTransportista.Location = New System.Drawing.Point(460, 42)
    Me.txtTransportista.Name = "txtTransportista"
    Me.txtTransportista.pNroRegPorPaginas = 0
    Me.txtTransportista.pRequerido = False
    Me.txtTransportista.Size = New System.Drawing.Size(238, 21)
    Me.txtTransportista.TabIndex = 115
    '
    'KryptonLabel8
    '
    Me.KryptonLabel8.Location = New System.Drawing.Point(378, 43)
    Me.KryptonLabel8.Name = "KryptonLabel8"
    Me.KryptonLabel8.Size = New System.Drawing.Size(75, 19)
    Me.KryptonLabel8.TabIndex = 113
    Me.KryptonLabel8.Text = "Transportista"
    Me.KryptonLabel8.Values.ExtraText = ""
    Me.KryptonLabel8.Values.Image = Nothing
    Me.KryptonLabel8.Values.Text = "Transportista"
    '
    'lblPlanta
    '
    Me.lblPlanta.Location = New System.Drawing.Point(723, 9)
    Me.lblPlanta.Name = "lblPlanta"
    Me.lblPlanta.Size = New System.Drawing.Size(41, 19)
    Me.lblPlanta.TabIndex = 111
    Me.lblPlanta.Text = "Planta"
    Me.lblPlanta.Values.ExtraText = ""
    Me.lblPlanta.Values.Image = Nothing
    Me.lblPlanta.Values.Text = "Planta"
    '
    'lblCompania
    '
    Me.lblCompania.Location = New System.Drawing.Point(11, 9)
    Me.lblCompania.Name = "lblCompania"
    Me.lblCompania.Size = New System.Drawing.Size(61, 19)
    Me.lblCompania.TabIndex = 107
    Me.lblCompania.Text = "Compañía"
    Me.lblCompania.Values.ExtraText = ""
    Me.lblCompania.Values.Image = Nothing
    Me.lblCompania.Values.Text = "Compañía"
    '
    'KryptonLabel7
    '
    Me.KryptonLabel7.Location = New System.Drawing.Point(378, 9)
    Me.KryptonLabel7.Name = "KryptonLabel7"
    Me.KryptonLabel7.Size = New System.Drawing.Size(50, 19)
    Me.KryptonLabel7.TabIndex = 109
    Me.KryptonLabel7.Text = "División"
    Me.KryptonLabel7.Values.ExtraText = ""
    Me.KryptonLabel7.Values.Image = Nothing
    Me.KryptonLabel7.Values.Text = "División"
    '
    'KryptonLabel5
    '
    Me.KryptonLabel5.Location = New System.Drawing.Point(11, 44)
    Me.KryptonLabel5.Name = "KryptonLabel5"
    Me.KryptonLabel5.Size = New System.Drawing.Size(44, 17)
    Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonLabel5.TabIndex = 105
    Me.KryptonLabel5.Text = "Cliente"
    Me.KryptonLabel5.Values.ExtraText = ""
    Me.KryptonLabel5.Values.Image = Nothing
    Me.KryptonLabel5.Values.Text = "Cliente"
    '
    'bgwProceso
    '
    Me.bgwProceso.WorkerReportsProgress = True
    Me.bgwProceso.WorkerSupportsCancellation = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOPRCN"
    Me.DataGridViewTextBoxColumn1.HeaderText = "NUMERO OPERACIÓN"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "FINCOP"
    Me.DataGridViewTextBoxColumn2.HeaderText = "FECHA INICIO OPERACIÓN"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "LFTRMOP"
    Me.DataGridViewTextBoxColumn3.HeaderText = "FECHA TERMINO OPERACIÓN"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "SESTOP"
    Me.DataGridViewTextBoxColumn4.HeaderText = "ESTADO OPERACION"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "NPLNMT"
    Me.DataGridViewTextBoxColumn5.HeaderText = "NUMERO DE PLANEAMIENTO"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "TRFSRC"
    Me.DataGridViewTextBoxColumn6.HeaderText = "REFERENCIA SERVICIO AL CLIENTE"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "NDCPRF"
    Me.DataGridViewTextBoxColumn7.HeaderText = "NUM DOCUMENTO PREFACTURADO"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "CCLNT"
    DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle17
    Me.DataGridViewTextBoxColumn8.HeaderText = "CLIENTE"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "CCLNFC"
    DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle18
    Me.DataGridViewTextBoxColumn9.HeaderText = "CLIENTE A FACTURAR"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn10.DataPropertyName = "FDCPRF"
    Me.DataGridViewTextBoxColumn10.HeaderText = "FECHA DE PREFACTURA"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn11.DataPropertyName = "CTPDCF"
    Me.DataGridViewTextBoxColumn11.HeaderText = "TIPO DOCUMENTO FACTURACION"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn12.DataPropertyName = "NDCMFC"
    Me.DataGridViewTextBoxColumn12.HeaderText = "NUM DOCUMENTO FACTURACION"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.ReadOnly = True
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn13.DataPropertyName = "FCHCRT"
    Me.DataGridViewTextBoxColumn13.HeaderText = "FECHA CREACION"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.ReadOnly = True
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn14.DataPropertyName = "HRACRT"
    Me.DataGridViewTextBoxColumn14.HeaderText = "HORA CREACION"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.ReadOnly = True
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn15.DataPropertyName = "NGUITR"
    Me.DataGridViewTextBoxColumn15.HeaderText = "NUMERO GUIA TRANSPORTISTA"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.ReadOnly = True
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn16.DataPropertyName = "FGUITR"
    Me.DataGridViewTextBoxColumn16.HeaderText = "FECHA DE GUIA TRANPORTE"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.ReadOnly = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn17.DataPropertyName = "SESTGU"
    Me.DataGridViewTextBoxColumn17.HeaderText = "FLAG ESTADO DE LA GUIA"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.ReadOnly = True
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn18.DataPropertyName = "NLQDCN"
    Me.DataGridViewTextBoxColumn18.HeaderText = "NUMERO DE LIQUIDACION"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.ReadOnly = True
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn19.DataPropertyName = "CLCLOR"
    Me.DataGridViewTextBoxColumn19.HeaderText = "CODIGO DE LOCALIDAD ORIGEN"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    Me.DataGridViewTextBoxColumn19.ReadOnly = True
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn20.DataPropertyName = "CLCLDS"
    Me.DataGridViewTextBoxColumn20.HeaderText = "CODIGO DE LOCALIDAD DESTINO"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    Me.DataGridViewTextBoxColumn20.ReadOnly = True
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn21.DataPropertyName = "NPLVHT"
    Me.DataGridViewTextBoxColumn21.HeaderText = "PLACA VEHICULO"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    Me.DataGridViewTextBoxColumn21.ReadOnly = True
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn22.DataPropertyName = "CBRCNT"
    Me.DataGridViewTextBoxColumn22.HeaderText = "BREVETE CONDUCTOR"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    Me.DataGridViewTextBoxColumn22.ReadOnly = True
    '
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn23.DataPropertyName = "TNMCH2"
    Me.DataGridViewTextBoxColumn23.HeaderText = "DES NOMBRE DEL CHOFE 2"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    Me.DataGridViewTextBoxColumn23.ReadOnly = True
    '
    'DataGridViewTextBoxColumn24
    '
    Me.DataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn24.DataPropertyName = "TCMTRT"
    Me.DataGridViewTextBoxColumn24.HeaderText = "DESCRIPCION DEL TRANSPORTISTA"
    Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
    Me.DataGridViewTextBoxColumn24.ReadOnly = True
    '
    'DataGridViewTextBoxColumn25
    '
    Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn25.DataPropertyName = "FCHCRT"
    Me.DataGridViewTextBoxColumn25.HeaderText = "FECHA CREACION"
    Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
    Me.DataGridViewTextBoxColumn25.ReadOnly = True
    '
    'DataGridViewTextBoxColumn26
    '
    Me.DataGridViewTextBoxColumn26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn26.DataPropertyName = "HRACRT"
    Me.DataGridViewTextBoxColumn26.HeaderText = "HORA CREACION"
    Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
    Me.DataGridViewTextBoxColumn26.ReadOnly = True
    '
    'DataGridViewTextBoxColumn27
    '
    Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn27.DataPropertyName = "HRACRT"
    Me.DataGridViewTextBoxColumn27.HeaderText = "HORA CREACION"
    Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
    Me.DataGridViewTextBoxColumn27.ReadOnly = True
    '
    'DataGridViewTextBoxColumn28
    '
    Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn28.DataPropertyName = "IMPCO"
    Me.DataGridViewTextBoxColumn28.HeaderText = "TARIFA A PAGAR"
    Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
    Me.DataGridViewTextBoxColumn28.ReadOnly = True
    '
    'DataGridViewTextBoxColumn29
    '
    Me.DataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn29.DataPropertyName = "IMPPA"
    Me.DataGridViewTextBoxColumn29.HeaderText = "TARIFA A COBRAR"
    Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
    Me.DataGridViewTextBoxColumn29.ReadOnly = True
    '
    'DataGridViewTextBoxColumn30
    '
    Me.DataGridViewTextBoxColumn30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn30.DataPropertyName = "GASTOS"
    Me.DataGridViewTextBoxColumn30.HeaderText = "GASTOS RUTA"
    Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
    Me.DataGridViewTextBoxColumn30.ReadOnly = True
    '
    'DataGridViewTextBoxColumn31
    '
    Me.DataGridViewTextBoxColumn31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn31.DataPropertyName = "GASTOAVC"
    Me.DataGridViewTextBoxColumn31.HeaderText = "GASTO AVC"
    Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
    Me.DataGridViewTextBoxColumn31.ReadOnly = True
    '
    'DataGridViewTextBoxColumn32
    '
    Me.DataGridViewTextBoxColumn32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn32.DataPropertyName = "HRACRT"
    Me.DataGridViewTextBoxColumn32.HeaderText = "HORA CREACION"
    Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
    Me.DataGridViewTextBoxColumn32.ReadOnly = True
    '
    'DataGridViewTextBoxColumn33
    '
    Me.DataGridViewTextBoxColumn33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn33.DataPropertyName = "MNDCO"
    Me.DataGridViewTextBoxColumn33.HeaderText = "MONEDA"
    Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
    Me.DataGridViewTextBoxColumn33.ReadOnly = True
    '
    'DataGridViewTextBoxColumn34
    '
    Me.DataGridViewTextBoxColumn34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn34.DataPropertyName = "IMPCO"
    Me.DataGridViewTextBoxColumn34.HeaderText = "TARIFA COBRAR"
    Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
    Me.DataGridViewTextBoxColumn34.ReadOnly = True
    '
    'DataGridViewTextBoxColumn35
    '
    Me.DataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn35.DataPropertyName = "MNDPA"
    Me.DataGridViewTextBoxColumn35.HeaderText = "MONEDA"
    Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
    Me.DataGridViewTextBoxColumn35.ReadOnly = True
    '
    'DataGridViewTextBoxColumn36
    '
    Me.DataGridViewTextBoxColumn36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn36.DataPropertyName = "IMPPA"
    Me.DataGridViewTextBoxColumn36.HeaderText = "TARIFA PAGAR"
    Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
    Me.DataGridViewTextBoxColumn36.ReadOnly = True
    '
    'DataGridViewTextBoxColumn37
    '
    Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn37.DataPropertyName = "GASTOS"
    Me.DataGridViewTextBoxColumn37.HeaderText = "GASTOS RUTA"
    Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
    Me.DataGridViewTextBoxColumn37.ReadOnly = True
    '
    'DataGridViewTextBoxColumn38
    '
    Me.DataGridViewTextBoxColumn38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn38.DataPropertyName = "GASTOAVC"
    Me.DataGridViewTextBoxColumn38.HeaderText = "GASTO AVC"
    Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
    Me.DataGridViewTextBoxColumn38.ReadOnly = True
    '
    'DataGridViewTextBoxColumn39
    '
    Me.DataGridViewTextBoxColumn39.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.DataGridViewTextBoxColumn39.DataPropertyName = "GASTOAVC"
    Me.DataGridViewTextBoxColumn39.HeaderText = "GASTO AVC"
    Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
    Me.DataGridViewTextBoxColumn39.ReadOnly = True
    '
    'frmResMMOperFacturac
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1042, 577)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmResMMOperFacturac"
    Me.Text = "Reporte Mensual de Operaciones - Facturación"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    CType(Me.HeaderGroupTabs.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.Panel.ResumeLayout(False)
    Me.HeaderGroupTabs.Panel.PerformLayout()
    CType(Me.HeaderGroupTabs, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupTabs.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage3.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.MenuBar.ResumeLayout(False)
    Me.MenuBar.PerformLayout()
    CType(Me.HeaderGroupFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.Panel.ResumeLayout(False)
    Me.HeaderGroupFiltro.Panel.PerformLayout()
    CType(Me.HeaderGroupFiltro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderGroupFiltro.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.pbxProceso, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents HeaderGroupFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents HeaderGroupTabs As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
  Friend WithEvents btnProcesarReporte As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cmbEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents Control_Visor_ReporteGrafico As SOLMIN_ST.Control_Visor_Reporte
  Friend WithEvents pbxProceso As System.Windows.Forms.PictureBox
  Friend WithEvents lblProceso As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents bgwProceso As System.ComponentModel.BackgroundWorker
  Friend WithEvents ctlCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
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
  Friend WithEvents CheckedComboBox1 As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox
  Friend WithEvents ControlVisorVehiculo As SOLMIN_ST.Control_Visor_Reporte
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents rbnFechaGuiaTransporte As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents rbnFechaOperacion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
  Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cboRegionVenta As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFINCOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFTRMOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLSESTOP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNPLNMT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNORINS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLTCRVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNRFSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNENMRS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLTRFSRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLCTPDCF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNDCMFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLSESTGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNLQDCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFCHCRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLCLCLOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLCLCLDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLNPLVHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLCBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLTNMCH2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLTCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLFCHCRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLHRACRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNDCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLIMPCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNDPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLIMPPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLGASTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLGASTOAVC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
