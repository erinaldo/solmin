<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValeCombustible
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValeCombustible))
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContGuia = New System.Windows.Forms.SplitContainer
        Me.PanelGrilla = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnImprimir_1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnSalir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cmbPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cmbDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.cmbConductor = New Ransa.Controls.Transportista.ucConductor_TxtF01
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.ctbTracto = New Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
        Me.ctbTransportista = New Ransa.Controls.Transportista.ucTransportista_TxtF01
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabValeCombustible = New System.Windows.Forms.TabControl
        Me.TabVale = New System.Windows.Forms.TabPage
        Me.panel_Mantenimiento = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonTextBox5 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox4 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtGalonesSolicitado = New System.Windows.Forms.TextBox
        Me.txtGalonesAsignados = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cboTipoPedido = New System.Windows.Forms.ComboBox
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonTextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtVale = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnBuscarOpcion = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOperacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroLiquidacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ctbTipoCombustible = New CodeTextBox.CodeTextBox
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ctbCentroCosto = New CodeTextBox.CodeTextBox
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.MenuBar = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.Separator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.Separator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.Separator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton
        Me.Separator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAsignarCombustible = New System.Windows.Forms.ToolStripButton
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
        Me.NRSCVL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECSLC_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPCMB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QGLNSL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QGLNVL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NLQCMB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLQDCN_S = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPVHT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLVEH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CBRCND = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSVLCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBSCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContGuia.Panel1.SuspendLayout()
        Me.SplitContGuia.Panel2.SuspendLayout()
        Me.SplitContGuia.SuspendLayout()
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGrilla.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.TabValeCombustible.SuspendLayout()
        Me.TabVale.SuspendLayout()
        CType(Me.panel_Mantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Mantenimiento.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContGuia
        '
        Me.SplitContGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContGuia.Location = New System.Drawing.Point(0, 0)
        Me.SplitContGuia.Name = "SplitContGuia"
        Me.SplitContGuia.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContGuia.Panel1
        '
        Me.SplitContGuia.Panel1.Controls.Add(Me.PanelGrilla)
        Me.SplitContGuia.Panel1.Controls.Add(Me.PanelFiltros)
        '
        'SplitContGuia.Panel2
        '
        Me.SplitContGuia.Panel2.Controls.Add(Me.HeaderDatos)
        Me.SplitContGuia.Size = New System.Drawing.Size(950, 679)
        Me.SplitContGuia.SplitterDistance = 374
        Me.SplitContGuia.TabIndex = 103
        Me.SplitContGuia.TabStop = False
        '
        'PanelGrilla
        '
        Me.PanelGrilla.Controls.Add(Me.gwdDatos)
        Me.PanelGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrilla.Location = New System.Drawing.Point(0, 128)
        Me.PanelGrilla.Name = "PanelGrilla"
        Me.PanelGrilla.Size = New System.Drawing.Size(950, 246)
        Me.PanelGrilla.TabIndex = 100
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRSCVL, Me.FECSLC_S, Me.CCNTCS, Me.CTPCMB, Me.TCNTCS, Me.QGLNSL, Me.QGLNVL, Me.NOPRCN, Me.NORSRT, Me.RUTA, Me.NLQCMB, Me.FLQDCN_S, Me.STPVHT, Me.CTRSPT, Me.NRUCTR, Me.TCMTRT, Me.NPLVEH, Me.CBRCNT, Me.CBRCND, Me.SSVLCM, Me.TOBSCR, Me.CCMPN})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidth = 30
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.RowTemplate.Height = 16
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(950, 246)
        Me.gwdDatos.StandardTab = True
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 0
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnImprimir_1, Me.btnBuscar, Me.btnSalir})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbDivision)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbConductor)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel24)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboEstado)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbTracto)
        Me.PanelFiltros.Panel.Controls.Add(Me.ctbTransportista)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaFin)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel7)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel8)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.PanelFiltros.Size = New System.Drawing.Size(950, 128)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Heading"
        Me.PanelFiltros.ValuesPrimary.Description = ""
        Me.PanelFiltros.ValuesPrimary.Heading = "Heading"
        Me.PanelFiltros.ValuesPrimary.Image = CType(resources.GetObject("PanelFiltros.ValuesPrimary.Image"), System.Drawing.Image)
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Description"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnImprimir_1
        '
        Me.btnImprimir_1.ExtraText = ""
        Me.btnImprimir_1.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnImprimir_1.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimir_1.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnImprimir_1.Text = "Imprimir"
        Me.btnImprimir_1.ToolTipImage = Nothing
        Me.btnImprimir_1.UniqueName = "757F46D1C7094A4F757F46D1C7094A4F"
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "C49AE56CFD9D4BE2C49AE56CFD9D4BE2"
        '
        'btnSalir
        '
        Me.btnSalir.ExtraText = ""
        Me.btnSalir.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnSalir.Image = Global.SOLMIN_ST.My.Resources.Resources._exit
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.ToolTipImage = Nothing
        Me.btnSalir.UniqueName = "C77D8122AF8A4DC8C77D8122AF8A4DC8"
        Me.btnSalir.Visible = False
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cmbPlanta.CodigoCompania = ""
        Me.cmbPlanta.CodigoDivision = ""
        Me.cmbPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cmbPlanta.DescripcionPlanta = ""
        Me.cmbPlanta.ItemTodos = False
        Me.cmbPlanta.Location = New System.Drawing.Point(687, 10)
        Me.cmbPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbPlanta.Name = "cmbPlanta"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.cmbPlanta.obePlanta = BePlanta1
        Me.cmbPlanta.pHabilitado = True
        Me.cmbPlanta.Planta = 0
        Me.cmbPlanta.PlantaDefault = -1
        Me.cmbPlanta.pRequerido = False
        Me.cmbPlanta.Size = New System.Drawing.Size(192, 23)
        Me.cmbPlanta.TabIndex = 153
        Me.cmbPlanta.Usuario = ""
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
        Me.cmbDivision.Location = New System.Drawing.Point(388, 11)
        Me.cmbDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.obeDivision = Nothing
        Me.cmbDivision.pHabilitado = True
        Me.cmbDivision.pRequerido = False
        Me.cmbDivision.Size = New System.Drawing.Size(238, 23)
        Me.cmbDivision.TabIndex = 152
        Me.cmbDivision.Usuario = ""
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Habilitar = True
        Me.cmbCompania.Location = New System.Drawing.Point(80, 10)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.cmbCompania.oBeCompania = BeCompania1
        Me.cmbCompania.Size = New System.Drawing.Size(251, 24)
        Me.cmbCompania.TabIndex = 151
        Me.cmbCompania.Usuario = ""
        '
        'cmbConductor
        '
        Me.cmbConductor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbConductor.BackColor = System.Drawing.Color.Transparent
        Me.cmbConductor.Location = New System.Drawing.Point(80, 71)
        Me.cmbConductor.Name = "cmbConductor"
        Me.cmbConductor.pRequerido = False
        Me.cmbConductor.Size = New System.Drawing.Size(251, 22)
        Me.cmbConductor.TabIndex = 150
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(336, 71)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(47, 22)
        Me.KryptonLabel24.TabIndex = 16
        Me.KryptonLabel24.Text = "Estado"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.DropDownWidth = 121
        Me.cboEstado.FormattingEnabled = False
        Me.cboEstado.ItemHeight = 15
        Me.cboEstado.Location = New System.Drawing.Point(388, 69)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.cboEstado.Size = New System.Drawing.Size(121, 23)
        Me.cboEstado.TabIndex = 17
        '
        'ctbTracto
        '
        Me.ctbTracto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTracto.BackColor = System.Drawing.Color.Transparent
        Me.ctbTracto.Location = New System.Drawing.Point(388, 40)
        Me.ctbTracto.Name = "ctbTracto"
        Me.ctbTracto.pRequerido = False
        Me.ctbTracto.Size = New System.Drawing.Size(236, 22)
        Me.ctbTracto.TabIndex = 9
        '
        'ctbTransportista
        '
        Me.ctbTransportista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctbTransportista.BackColor = System.Drawing.Color.Transparent
        Me.ctbTransportista.Location = New System.Drawing.Point(80, 40)
        Me.ctbTransportista.Name = "ctbTransportista"
        Me.ctbTransportista.pNroRegPorPaginas = 0
        Me.ctbTransportista.pRequerido = False
        Me.ctbTransportista.Size = New System.Drawing.Size(251, 22)
        Me.ctbTransportista.TabIndex = 7
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(4, 41)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(82, 22)
        Me.KryptonLabel5.TabIndex = 6
        Me.KryptonLabel5.Text = "Transportista"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Transportista"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(687, 39)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaInicio.TabIndex = 11
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(795, 39)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
        Me.dtpFechaFin.TabIndex = 13
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(632, 41)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(40, 19)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 10
        Me.KryptonLabel2.Text = "Fecha"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(773, 41)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(20, 19)
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 12
        Me.KryptonLabel4.Text = "Al"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Al"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(632, 11)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(44, 22)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Planta"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Planta"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(336, 11)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(54, 22)
        Me.KryptonLabel7.TabIndex = 2
        Me.KryptonLabel7.Text = "División"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "División"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(4, 11)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(66, 22)
        Me.KryptonLabel8.TabIndex = 0
        Me.KryptonLabel8.Text = "Compañía"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Compañía"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(336, 41)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(45, 22)
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Text = "Tracto"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Tracto"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 71)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel3.TabIndex = 14
        Me.KryptonLabel3.Text = "Conductor"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Conductor"
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.TabValeCombustible)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(950, 301)
        Me.HeaderDatos.TabIndex = 0
        Me.HeaderDatos.Text = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Mantenimiento"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'TabValeCombustible
        '
        Me.TabValeCombustible.Controls.Add(Me.TabVale)
        Me.TabValeCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabValeCombustible.Location = New System.Drawing.Point(0, 25)
        Me.TabValeCombustible.Name = "TabValeCombustible"
        Me.TabValeCombustible.SelectedIndex = 0
        Me.TabValeCombustible.Size = New System.Drawing.Size(948, 251)
        Me.TabValeCombustible.TabIndex = 1
        '
        'TabVale
        '
        Me.TabVale.Controls.Add(Me.panel_Mantenimiento)
        Me.TabVale.Location = New System.Drawing.Point(4, 22)
        Me.TabVale.Name = "TabVale"
        Me.TabVale.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVale.Size = New System.Drawing.Size(940, 225)
        Me.TabVale.TabIndex = 1
        Me.TabVale.Text = "Vale Combustible"
        Me.TabVale.UseVisualStyleBackColor = True
        '
        'panel_Mantenimiento
        '
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonButton1)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonTextBox5)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonTextBox4)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonTextBox3)
        Me.panel_Mantenimiento.Controls.Add(Me.txtGalonesSolicitado)
        Me.panel_Mantenimiento.Controls.Add(Me.txtGalonesAsignados)
        Me.panel_Mantenimiento.Controls.Add(Me.cboTipoPedido)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel26)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel25)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonTextBox2)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonTextBox1)
        Me.panel_Mantenimiento.Controls.Add(Me.txtVale)
        Me.panel_Mantenimiento.Controls.Add(Me.txtObservacion)
        Me.panel_Mantenimiento.Controls.Add(Me.btnBuscarOpcion)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel23)
        Me.panel_Mantenimiento.Controls.Add(Me.txtCodigo)
        Me.panel_Mantenimiento.Controls.Add(Me.txtOrdenServicio)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel14)
        Me.panel_Mantenimiento.Controls.Add(Me.txtOperacion)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel22)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel13)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel21)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel19)
        Me.panel_Mantenimiento.Controls.Add(Me.dtpFechaLiquidacion)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel18)
        Me.panel_Mantenimiento.Controls.Add(Me.txtNroLiquidacion)
        Me.panel_Mantenimiento.Controls.Add(Me.ctbTipoCombustible)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel9)
        Me.panel_Mantenimiento.Controls.Add(Me.ctbCentroCosto)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonBorderEdge1)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel15)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel12)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel11)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel10)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel16)
        Me.panel_Mantenimiento.Controls.Add(Me.dtpFecha)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel17)
        Me.panel_Mantenimiento.Controls.Add(Me.KryptonLabel20)
        Me.panel_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_Mantenimiento.Location = New System.Drawing.Point(3, 3)
        Me.panel_Mantenimiento.Name = "panel_Mantenimiento"
        Me.panel_Mantenimiento.Size = New System.Drawing.Size(934, 219)
        Me.panel_Mantenimiento.StateCommon.Color1 = System.Drawing.SystemColors.ControlLightLight
        Me.panel_Mantenimiento.TabIndex = 0
        '
        'KryptonButton1
        '
        Me.KryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3
        Me.KryptonButton1.Enabled = False
        Me.KryptonButton1.Location = New System.Drawing.Point(830, 16)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(25, 22)
        Me.KryptonButton1.TabIndex = 160
        Me.KryptonButton1.Tag = ""
        Me.KryptonButton1.Values.ExtraText = ""
        Me.KryptonButton1.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.KryptonButton1.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.KryptonButton1.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.KryptonButton1.Values.Text = ""
        '
        'KryptonTextBox5
        '
        Me.KryptonTextBox5.Enabled = False
        Me.KryptonTextBox5.Location = New System.Drawing.Point(544, 73)
        Me.KryptonTextBox5.Name = "KryptonTextBox5"
        Me.KryptonTextBox5.Size = New System.Drawing.Size(311, 22)
        Me.KryptonTextBox5.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.KryptonTextBox5.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox5.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox5.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox5.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.KryptonTextBox5.TabIndex = 159
        '
        'KryptonTextBox4
        '
        Me.KryptonTextBox4.Enabled = False
        Me.KryptonTextBox4.Location = New System.Drawing.Point(544, 45)
        Me.KryptonTextBox4.Name = "KryptonTextBox4"
        Me.KryptonTextBox4.Size = New System.Drawing.Size(311, 22)
        Me.KryptonTextBox4.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.KryptonTextBox4.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox4.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox4.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox4.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.KryptonTextBox4.TabIndex = 158
        '
        'KryptonTextBox3
        '
        Me.KryptonTextBox3.Enabled = False
        Me.KryptonTextBox3.Location = New System.Drawing.Point(544, 16)
        Me.KryptonTextBox3.Name = "KryptonTextBox3"
        Me.KryptonTextBox3.Size = New System.Drawing.Size(280, 22)
        Me.KryptonTextBox3.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.KryptonTextBox3.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox3.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox3.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox3.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.KryptonTextBox3.TabIndex = 157
        '
        'txtGalonesSolicitado
        '
        Me.txtGalonesSolicitado.Location = New System.Drawing.Point(128, 107)
        Me.txtGalonesSolicitado.Name = "txtGalonesSolicitado"
        Me.txtGalonesSolicitado.Size = New System.Drawing.Size(86, 20)
        Me.txtGalonesSolicitado.TabIndex = 154
        '
        'txtGalonesAsignados
        '
        Me.txtGalonesAsignados.Enabled = False
        Me.txtGalonesAsignados.Location = New System.Drawing.Point(332, 106)
        Me.txtGalonesAsignados.Name = "txtGalonesAsignados"
        Me.txtGalonesAsignados.Size = New System.Drawing.Size(85, 22)
        Me.txtGalonesAsignados.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtGalonesAsignados.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtGalonesAsignados.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtGalonesAsignados.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtGalonesAsignados.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtGalonesAsignados.TabIndex = 11
        Me.txtGalonesAsignados.Tag = ""
        Me.txtGalonesAsignados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTipoPedido
        '
        Me.cboTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPedido.FormattingEnabled = True
        Me.cboTipoPedido.Location = New System.Drawing.Point(128, 134)
        Me.cboTipoPedido.Name = "cboTipoPedido"
        Me.cboTipoPedido.Size = New System.Drawing.Size(137, 21)
        Me.cboTipoPedido.TabIndex = 154
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(12, 189)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(108, 22)
        Me.KryptonLabel26.TabIndex = 156
        Me.KryptonLabel26.Text = "Localidad Destino"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Localidad Destino"
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(8, 161)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(103, 22)
        Me.KryptonLabel25.TabIndex = 155
        Me.KryptonLabel25.Text = "Localidad Origen"
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Localidad Origen"
        '
        'KryptonTextBox2
        '
        Me.KryptonTextBox2.Enabled = False
        Me.KryptonTextBox2.Location = New System.Drawing.Point(128, 189)
        Me.KryptonTextBox2.Name = "KryptonTextBox2"
        Me.KryptonTextBox2.Size = New System.Drawing.Size(289, 22)
        Me.KryptonTextBox2.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.KryptonTextBox2.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox2.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox2.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox2.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.KryptonTextBox2.TabIndex = 154
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Enabled = False
        Me.KryptonTextBox1.Location = New System.Drawing.Point(128, 161)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(289, 22)
        Me.KryptonTextBox1.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.KryptonTextBox1.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox1.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.KryptonTextBox1.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox1.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.KryptonTextBox1.TabIndex = 153
        '
        'txtVale
        '
        Me.txtVale.Enabled = False
        Me.txtVale.Location = New System.Drawing.Point(128, 15)
        Me.txtVale.Name = "txtVale"
        Me.txtVale.Size = New System.Drawing.Size(84, 22)
        Me.txtVale.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtVale.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtVale.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtVale.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtVale.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtVale.TabIndex = 1
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Enabled = False
        Me.txtObservacion.Location = New System.Drawing.Point(544, 103)
        Me.txtObservacion.MaxLength = 25
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(311, 22)
        Me.txtObservacion.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtObservacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtObservacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtObservacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtObservacion.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtObservacion.TabIndex = 25
        '
        'btnBuscarOpcion
        '
        Me.btnBuscarOpcion.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3
        Me.btnBuscarOpcion.Enabled = False
        Me.btnBuscarOpcion.Location = New System.Drawing.Point(393, 133)
        Me.btnBuscarOpcion.Name = "btnBuscarOpcion"
        Me.btnBuscarOpcion.Size = New System.Drawing.Size(25, 22)
        Me.btnBuscarOpcion.TabIndex = 16
        Me.btnBuscarOpcion.Tag = ""
        Me.btnBuscarOpcion.Values.ExtraText = ""
        Me.btnBuscarOpcion.Values.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscarOpcion.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscarOpcion.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscarOpcion.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscarOpcion.Values.Text = ""
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(455, 104)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel23.TabIndex = 24
        Me.KryptonLabel23.Text = "Observación"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Observación"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(281, 133)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(112, 22)
        Me.txtCodigo.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtCodigo.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodigo.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodigo.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCodigo.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtCodigo.TabIndex = 15
        '
        'txtOrdenServicio
        '
        Me.txtOrdenServicio.Enabled = False
        Me.txtOrdenServicio.Location = New System.Drawing.Point(767, 133)
        Me.txtOrdenServicio.Name = "txtOrdenServicio"
        Me.txtOrdenServicio.Size = New System.Drawing.Size(88, 22)
        Me.txtOrdenServicio.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtOrdenServicio.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOrdenServicio.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOrdenServicio.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtOrdenServicio.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtOrdenServicio.TabIndex = 29
        Me.txtOrdenServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(648, 134)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(125, 22)
        Me.KryptonLabel14.TabIndex = 28
        Me.KryptonLabel14.Text = "N° Orden de Servicio"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "N° Orden de Servicio"
        '
        'txtOperacion
        '
        Me.txtOperacion.Enabled = False
        Me.txtOperacion.Location = New System.Drawing.Point(544, 133)
        Me.txtOperacion.Name = "txtOperacion"
        Me.txtOperacion.Size = New System.Drawing.Size(88, 22)
        Me.txtOperacion.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtOperacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOperacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOperacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtOperacion.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtOperacion.TabIndex = 27
        Me.txtOperacion.Tag = ""
        Me.txtOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(455, 134)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(84, 22)
        Me.KryptonLabel22.TabIndex = 26
        Me.KryptonLabel22.Text = "N° Operación"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "N° Operación"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(8, 135)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(103, 22)
        Me.KryptonLabel13.TabIndex = 12
        Me.KryptonLabel13.Text = "Tipo Pedido Vale"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Tipo Pedido Vale"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(8, 16)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(124, 22)
        Me.KryptonLabel21.TabIndex = 0
        Me.KryptonLabel21.Text = "N° Vale Combustible"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "N° Vale Combustible"
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(222, 107)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(114, 22)
        Me.KryptonLabel19.TabIndex = 10
        Me.KryptonLabel19.Text = "Galones Asignados"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Galones Asignados"
        '
        'dtpFechaLiquidacion
        '
        Me.dtpFechaLiquidacion.Enabled = False
        Me.dtpFechaLiquidacion.Location = New System.Drawing.Point(767, 161)
        Me.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion"
        Me.dtpFechaLiquidacion.Size = New System.Drawing.Size(88, 22)
        Me.dtpFechaLiquidacion.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.dtpFechaLiquidacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtpFechaLiquidacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dtpFechaLiquidacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dtpFechaLiquidacion.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dtpFechaLiquidacion.TabIndex = 33
        Me.dtpFechaLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(648, 162)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(108, 22)
        Me.KryptonLabel18.TabIndex = 32
        Me.KryptonLabel18.Text = "Fecha Liquidación"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Fecha Liquidación"
        '
        'txtNroLiquidacion
        '
        Me.txtNroLiquidacion.Enabled = False
        Me.txtNroLiquidacion.Location = New System.Drawing.Point(544, 161)
        Me.txtNroLiquidacion.Name = "txtNroLiquidacion"
        Me.txtNroLiquidacion.Size = New System.Drawing.Size(88, 22)
        Me.txtNroLiquidacion.StateDisabled.Back.Color1 = System.Drawing.SystemColors.Control
        Me.txtNroLiquidacion.StateDisabled.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNroLiquidacion.StateDisabled.Border.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNroLiquidacion.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroLiquidacion.StateDisabled.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.txtNroLiquidacion.TabIndex = 31
        Me.txtNroLiquidacion.Tag = ""
        Me.txtNroLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ctbTipoCombustible
        '
        Me.ctbTipoCombustible.BackColor = System.Drawing.Color.White
        Me.ctbTipoCombustible.Codigo = ""
        Me.ctbTipoCombustible.ControlHeight = 23
        Me.ctbTipoCombustible.ControlImage = True
        Me.ctbTipoCombustible.ControlReadOnly = False
        Me.ctbTipoCombustible.Descripcion = ""
        Me.ctbTipoCombustible.DisplayColumnVisible = True
        Me.ctbTipoCombustible.DisplayMember = ""
        Me.ctbTipoCombustible.Enabled = False
        Me.ctbTipoCombustible.KeyColumnWidth = 100
        Me.ctbTipoCombustible.KeyField = ""
        Me.ctbTipoCombustible.KeySearch = True
        Me.ctbTipoCombustible.Location = New System.Drawing.Point(128, 74)
        Me.ctbTipoCombustible.Name = "ctbTipoCombustible"
        Me.ctbTipoCombustible.Size = New System.Drawing.Size(289, 23)
        Me.ctbTipoCombustible.TabIndex = 7
        Me.ctbTipoCombustible.TextBackColor = System.Drawing.Color.White
        Me.ctbTipoCombustible.TextForeColor = System.Drawing.SystemColors.WindowText
        Me.ctbTipoCombustible.ValueColumnVisible = True
        Me.ctbTipoCombustible.ValueColumnWidth = 600
        Me.ctbTipoCombustible.ValueField = ""
        Me.ctbTipoCombustible.ValueMember = ""
        Me.ctbTipoCombustible.ValueSearch = True
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(455, 162)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(90, 22)
        Me.KryptonLabel9.TabIndex = 30
        Me.KryptonLabel9.Text = "N° Liquidación"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "N° Liquidación"
        '
        'ctbCentroCosto
        '
        Me.ctbCentroCosto.BackColor = System.Drawing.Color.White
        Me.ctbCentroCosto.Codigo = ""
        Me.ctbCentroCosto.ControlHeight = 23
        Me.ctbCentroCosto.ControlImage = True
        Me.ctbCentroCosto.ControlReadOnly = False
        Me.ctbCentroCosto.Descripcion = ""
        Me.ctbCentroCosto.DisplayColumnVisible = True
        Me.ctbCentroCosto.DisplayMember = ""
        Me.ctbCentroCosto.Enabled = False
        Me.ctbCentroCosto.KeyColumnWidth = 100
        Me.ctbCentroCosto.KeyField = ""
        Me.ctbCentroCosto.KeySearch = True
        Me.ctbCentroCosto.Location = New System.Drawing.Point(128, 42)
        Me.ctbCentroCosto.Name = "ctbCentroCosto"
        Me.ctbCentroCosto.Size = New System.Drawing.Size(289, 23)
        Me.ctbCentroCosto.TabIndex = 5
        Me.ctbCentroCosto.TextBackColor = System.Drawing.Color.White
        Me.ctbCentroCosto.TextForeColor = System.Drawing.SystemColors.WindowText
        Me.ctbCentroCosto.ValueColumnVisible = True
        Me.ctbCentroCosto.ValueColumnWidth = 600
        Me.ctbCentroCosto.ValueField = ""
        Me.ctbCentroCosto.ValueMember = ""
        Me.ctbCentroCosto.ValueSearch = True
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(440, 8)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(1, 175)
        Me.KryptonBorderEdge1.TabIndex = 17
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(455, 72)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel15.TabIndex = 22
        Me.KryptonLabel15.Text = "Conductor"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Conductor"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(8, 107)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(116, 22)
        Me.KryptonLabel12.TabIndex = 8
        Me.KryptonLabel12.Text = "Galones Solicitados"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Galones Solicitados"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(8, 77)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(107, 22)
        Me.KryptonLabel11.TabIndex = 6
        Me.KryptonLabel11.Text = "Tipo Combustible"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Tipo Combustible"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(8, 45)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(99, 22)
        Me.KryptonLabel10.TabIndex = 4
        Me.KryptonLabel10.Text = "Centro de Costo"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Centro de Costo"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(455, 44)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(45, 22)
        Me.KryptonLabel16.TabIndex = 20
        Me.KryptonLabel16.Text = "Tracto"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Tracto"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(333, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(455, 16)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(82, 22)
        Me.KryptonLabel17.TabIndex = 18
        Me.KryptonLabel17.Text = "Transportista"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Transportista"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(222, 14)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(108, 22)
        Me.KryptonLabel20.TabIndex = 2
        Me.KryptonLabel20.Text = "Fecha Vale Comb."
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Fecha Vale Comb."
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.Separator1, Me.btnModificar, Me.btnGuardar, Me.Separator2, Me.btnCancelar, Me.Separator3, Me.btnEliminar, Me.Separator4, Me.btnImprimir, Me.Separator5, Me.btnAsignarCombustible})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(948, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(65, 22)
        Me.btnNuevo.Text = " Nuevo"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 22)
        Me.btnGuardar.Text = " Guardar"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = " Cancelar"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(73, 22)
        Me.btnEliminar.Text = " Eliminar"
        '
        'Separator4
        '
        Me.Separator4.Name = "Separator4"
        Me.Separator4.Size = New System.Drawing.Size(6, 25)
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.SOLMIN_ST.My.Resources.Resources.printer2
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(76, 22)
        Me.btnImprimir.Text = " Imprimir"
        '
        'Separator5
        '
        Me.Separator5.Name = "Separator5"
        Me.Separator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnAsignarCombustible
        '
        Me.btnAsignarCombustible.Image = Global.SOLMIN_ST.My.Resources.Resources.cell_layout
        Me.btnAsignarCombustible.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAsignarCombustible.Name = "btnAsignarCombustible"
        Me.btnAsignarCombustible.Size = New System.Drawing.Size(141, 22)
        Me.btnAsignarCombustible.Text = " Asignar Combustible"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRSCVL"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Vale"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FECSLC"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Vale"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CTPCMB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Combustible"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QGLNSL"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn4.HeaderText = "Galones Solicitados"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 15
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CCNTCS"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cod. Centro Costo"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QGLNSL"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn6.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 15
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CCNTCS"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn7.HeaderText = "P / T"
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 15
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CTRSPT"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cod. Transportista"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "STPVHT"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn9.HeaderText = "Transportista"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NPLVEH"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tracto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CBRCNT"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn11.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TCMTRT"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn12.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SSVLCM"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn13.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CBRCNT"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn14.HeaderText = "Brevete"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CBRCND"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewTextBoxColumn15.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NCRTRC"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn16.HeaderText = "NCRTRC"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SSVLCM"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn17.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CBRCND"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NCRTRC"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn19.HeaderText = "NCRTRC"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SSVLCM"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridViewTextBoxColumn20.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "TOBSCR"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridViewTextBoxColumn21.HeaderText = "Observación"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'NRSCVL
        '
        Me.NRSCVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRSCVL.DataPropertyName = "NRSCVL"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NRSCVL.DefaultCellStyle = DataGridViewCellStyle1
        Me.NRSCVL.HeaderText = "N° Vale"
        Me.NRSCVL.MaxInputLength = 20
        Me.NRSCVL.Name = "NRSCVL"
        Me.NRSCVL.ReadOnly = True
        Me.NRSCVL.Width = 75
        '
        'FECSLC_S
        '
        Me.FECSLC_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECSLC_S.DataPropertyName = "FECSLC_S"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FECSLC_S.DefaultCellStyle = DataGridViewCellStyle2
        Me.FECSLC_S.HeaderText = "Fecha Vale"
        Me.FECSLC_S.MaxInputLength = 10
        Me.FECSLC_S.Name = "FECSLC_S"
        Me.FECSLC_S.ReadOnly = True
        Me.FECSLC_S.Width = 92
        '
        'CCNTCS
        '
        Me.CCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCNTCS.DataPropertyName = "CCNTCS"
        Me.CCNTCS.HeaderText = "Cod. Centro Costo"
        Me.CCNTCS.Name = "CCNTCS"
        Me.CCNTCS.ReadOnly = True
        Me.CCNTCS.Visible = False
        Me.CCNTCS.Width = 134
        '
        'CTPCMB
        '
        Me.CTPCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTPCMB.DataPropertyName = "CTPCMB"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.CTPCMB.DefaultCellStyle = DataGridViewCellStyle3
        Me.CTPCMB.HeaderText = "Tipo Combustible"
        Me.CTPCMB.MaxInputLength = 100
        Me.CTPCMB.Name = "CTPCMB"
        Me.CTPCMB.ReadOnly = True
        Me.CTPCMB.Width = 131
        '
        'TCNTCS
        '
        Me.TCNTCS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCNTCS.DataPropertyName = "TCNTCS"
        Me.TCNTCS.HeaderText = "Centro Costo"
        Me.TCNTCS.Name = "TCNTCS"
        Me.TCNTCS.ReadOnly = True
        Me.TCNTCS.Width = 106
        '
        'QGLNSL
        '
        Me.QGLNSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QGLNSL.DataPropertyName = "QGLNSL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.QGLNSL.DefaultCellStyle = DataGridViewCellStyle4
        Me.QGLNSL.HeaderText = "Galones Solicitados"
        Me.QGLNSL.MaxInputLength = 15
        Me.QGLNSL.Name = "QGLNSL"
        Me.QGLNSL.ReadOnly = True
        Me.QGLNSL.Width = 138
        '
        'QGLNVL
        '
        Me.QGLNVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QGLNVL.DataPropertyName = "QGLNVL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.QGLNVL.DefaultCellStyle = DataGridViewCellStyle5
        Me.QGLNVL.HeaderText = "Galones Asignados"
        Me.QGLNVL.Name = "QGLNVL"
        Me.QGLNVL.ReadOnly = True
        Me.QGLNVL.Width = 136
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NOPRCN.DefaultCellStyle = DataGridViewCellStyle6
        Me.NOPRCN.HeaderText = "N° Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 108
        '
        'NORSRT
        '
        Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSRT.DataPropertyName = "NORSRT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NORSRT.DefaultCellStyle = DataGridViewCellStyle7
        Me.NORSRT.HeaderText = "N° Orden Servicio"
        Me.NORSRT.Name = "NORSRT"
        Me.NORSRT.ReadOnly = True
        Me.NORSRT.Width = 130
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
        'NLQCMB
        '
        Me.NLQCMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NLQCMB.DataPropertyName = "NLQCMB"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NLQCMB.DefaultCellStyle = DataGridViewCellStyle8
        Me.NLQCMB.HeaderText = "N° Liquidación Combustible"
        Me.NLQCMB.Name = "NLQCMB"
        Me.NLQCMB.ReadOnly = True
        Me.NLQCMB.Width = 186
        '
        'FLQDCN_S
        '
        Me.FLQDCN_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FLQDCN_S.DataPropertyName = "FLQDCN_S"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FLQDCN_S.DefaultCellStyle = DataGridViewCellStyle9
        Me.FLQDCN_S.HeaderText = "Fecha Liquidación"
        Me.FLQDCN_S.Name = "FLQDCN_S"
        Me.FLQDCN_S.ReadOnly = True
        Me.FLQDCN_S.Width = 132
        '
        'STPVHT
        '
        Me.STPVHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STPVHT.DataPropertyName = "STPVHT"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.STPVHT.DefaultCellStyle = DataGridViewCellStyle10
        Me.STPVHT.HeaderText = "P / T"
        Me.STPVHT.Name = "STPVHT"
        Me.STPVHT.ReadOnly = True
        Me.STPVHT.Width = 61
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Cod. Transportista"
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        Me.CTRSPT.Visible = False
        Me.CTRSPT.Width = 133
        '
        'NRUCTR
        '
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NRUCTR.DefaultCellStyle = DataGridViewCellStyle11
        Me.NRUCTR.HeaderText = "RUC Transportista"
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.HeaderText = "Transportista"
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Width = 105
        '
        'NPLVEH
        '
        Me.NPLVEH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NPLVEH.DataPropertyName = "NPLVEH"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.NPLVEH.DefaultCellStyle = DataGridViewCellStyle12
        Me.NPLVEH.HeaderText = "Tracto"
        Me.NPLVEH.Name = "NPLVEH"
        Me.NPLVEH.ReadOnly = True
        Me.NPLVEH.Width = 70
        '
        'CBRCNT
        '
        Me.CBRCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CBRCNT.DataPropertyName = "CBRCNT"
        Me.CBRCNT.HeaderText = "Brevete"
        Me.CBRCNT.Name = "CBRCNT"
        Me.CBRCNT.ReadOnly = True
        Me.CBRCNT.Width = 75
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
        'SSVLCM
        '
        Me.SSVLCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SSVLCM.DataPropertyName = "SSVLCM"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.SSVLCM.DefaultCellStyle = DataGridViewCellStyle13
        Me.SSVLCM.HeaderText = "Status"
        Me.SSVLCM.Name = "SSVLCM"
        Me.SSVLCM.ReadOnly = True
        Me.SSVLCM.Width = 68
        '
        'TOBSCR
        '
        Me.TOBSCR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBSCR.DataPropertyName = "TOBSCR"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.TOBSCR.DefaultCellStyle = DataGridViewCellStyle14
        Me.TOBSCR.HeaderText = "Observación"
        Me.TOBSCR.Name = "TOBSCR"
        Me.TOBSCR.ReadOnly = True
        Me.TOBSCR.Visible = False
        Me.TOBSCR.Width = 102
        '
        'CCMPN
        '
        Me.CCMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 79
        '
        'frmValeCombustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 679)
        Me.Controls.Add(Me.SplitContGuia)
        Me.Name = "frmValeCombustible"
        Me.Text = "Vale de Combustible"
        Me.SplitContGuia.Panel1.ResumeLayout(False)
        Me.SplitContGuia.Panel2.ResumeLayout(False)
        Me.SplitContGuia.ResumeLayout(False)
        CType(Me.PanelGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGrilla.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.Panel.ResumeLayout(False)
        Me.PanelFiltros.Panel.PerformLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltros.ResumeLayout(False)
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.TabValeCombustible.ResumeLayout(False)
        Me.TabVale.ResumeLayout(False)
        CType(Me.panel_Mantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Mantenimiento.ResumeLayout(False)
        Me.panel_Mantenimiento.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
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
    Friend WithEvents SplitContGuia As System.Windows.Forms.SplitContainer
    Friend WithEvents PanelGrilla As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnSalir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TabValeCombustible As System.Windows.Forms.TabControl
    Friend WithEvents TabVale As System.Windows.Forms.TabPage
    Friend WithEvents panel_Mantenimiento As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
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
    Friend WithEvents ctbTransportista As Ransa.Controls.Transportista.ucTransportista_TxtF01
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnImprimir_1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ctbTracto As Ransa.Controls.Transportista.ucTractoTransportista_TxtF01
    Friend WithEvents txtGalonesAsignados As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroLiquidacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ctbTipoCombustible As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ctbCentroCosto As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtVale As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Separator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAsignarCombustible As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOperacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnBuscarOpcion As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbConductor As Ransa.Controls.Transportista.ucConductor_TxtF01
    Friend WithEvents cmbPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cmbDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cboTipoPedido As System.Windows.Forms.ComboBox
    Friend WithEvents txtGalonesSolicitado As System.Windows.Forms.TextBox
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonTextBox5 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox4 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonTextBox3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents NRSCVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECSLC_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPCMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QGLNSL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QGLNVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NLQCMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLQDCN_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPVHT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLVEH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CBRCND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSVLCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
