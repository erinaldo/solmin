<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucCotizacion
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucCotizacion))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim BePlanta1 As Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta = New Ransa.TypeDef.UbicacionPlanta.Planta.bePlanta
        Dim BeCompania1 As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania = New Ransa.TypeDef.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCTZCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FVGCTZ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNCLC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCNTRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SFLZNP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCBRMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SFSANF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCTZTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.TabcCotizacion = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.PanelMantenimiento = New System.Windows.Forms.Panel
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.KryptonBorderEdge2 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbnTrasladoOrdinario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbnTrasladoMulti = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.cmbTipoCobro = New System.Windows.Forms.ComboBox
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlantaFacturacion = New CodeTextBox.CodeTextBox
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbMoneda = New CodeTextBox.CodeTextBox
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.chkCotizacionTarifario = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtNroContrato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkServicioAfecto = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtContacto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.chkFleteZonaPrimaria = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.dtpFecCotizacion = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaVigencia = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dtgDetalleCotizacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NCTZCN_DET = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRRCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNDMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CFRMPG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCMPSG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TUNDVH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLSGC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPRCS1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRFMRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINCSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STPOMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCRGMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPTSCR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPTSDS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FENTMR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCNDTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SRSTRC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPOSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPSBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNDRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CVPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NVJES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPUNV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CFRAPG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MERCAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UNIMED = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PMRCDR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FFACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FPAGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSGRCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEGURO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORSRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNCST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNCS1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADOOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnServicioCotizacion = New System.Windows.Forms.DataGridViewImageColumn
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
        Me.btnCopiarCotizacion = New System.Windows.Forms.ToolStripButton
        Me.btnGenerarOSDetalleCotizacion = New System.Windows.Forms.ToolStripButton
        Me.PanelFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.cboPlanta = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.cboDivision = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.cboCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.ckbRangoFechas = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtClienteFiltro = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.cmbEstado = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn
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
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        Me.TabcCotizacion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.PanelMantenimiento.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgDetalleCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuBar.SuspendLayout()
        CType(Me.PanelFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltros.Panel.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgCotizacion)
        Me.KryptonPanel.Controls.Add(Me.HeaderDatos)
        Me.KryptonPanel.Controls.Add(Me.PanelFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1044, 728)
        Me.KryptonPanel.TabIndex = 1
        '
        'dtgCotizacion
        '
        Me.dtgCotizacion.AllowUserToAddRows = False
        Me.dtgCotizacion.AllowUserToDeleteRows = False
        Me.dtgCotizacion.AllowUserToOrderColumns = True
        Me.dtgCotizacion.ColumnHeadersHeight = 35
        Me.dtgCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgCotizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCTZCN, Me.CCLNT, Me.CLIENTE, Me.CMNDA, Me.MONEDA, Me.FCTZCN, Me.FVGCTZ, Me.TCNCLC, Me.NCNTRT, Me.CPLNFC, Me.SFLZNP, Me.SCBRMD, Me.SFSANF, Me.SCTZTR, Me.SESTCT, Me.CCMPN, Me.CDVSN, Me.CPLNDV})
        Me.dtgCotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCotizacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgCotizacion.Location = New System.Drawing.Point(0, 99)
        Me.dtgCotizacion.MultiSelect = False
        Me.dtgCotizacion.Name = "dtgCotizacion"
        Me.dtgCotizacion.ReadOnly = True
        Me.dtgCotizacion.RowHeadersWidth = 20
        Me.dtgCotizacion.RowTemplate.Height = 16
        Me.dtgCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCotizacion.Size = New System.Drawing.Size(1044, 334)
        Me.dtgCotizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgCotizacion.TabIndex = 1
        Me.dtgCotizacion.TabStop = False
        '
        'NCTZCN
        '
        Me.NCTZCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCTZCN.DataPropertyName = "NCTZCN"
        Me.NCTZCN.HeaderText = "N° Cotización"
        Me.NCTZCN.Name = "NCTZCN"
        Me.NCTZCN.ReadOnly = True
        Me.NCTZCN.Width = 109
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'CLIENTE
        '
        Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIENTE.DataPropertyName = "CLIENTE"
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        '
        'CMNDA
        '
        Me.CMNDA.DataPropertyName = "CMNDA"
        Me.CMNDA.HeaderText = "CMNDA"
        Me.CMNDA.Name = "CMNDA"
        Me.CMNDA.ReadOnly = True
        Me.CMNDA.Visible = False
        '
        'MONEDA
        '
        Me.MONEDA.DataPropertyName = "MONEDA"
        Me.MONEDA.HeaderText = "Moneda"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        '
        'FCTZCN
        '
        Me.FCTZCN.DataPropertyName = "FCTZCN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FCTZCN.DefaultCellStyle = DataGridViewCellStyle1
        Me.FCTZCN.HeaderText = "Fecha Cotización"
        Me.FCTZCN.Name = "FCTZCN"
        Me.FCTZCN.ReadOnly = True
        '
        'FVGCTZ
        '
        Me.FVGCTZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FVGCTZ.DataPropertyName = "FVGCTZ"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FVGCTZ.DefaultCellStyle = DataGridViewCellStyle2
        Me.FVGCTZ.HeaderText = "Fecha de Vigencia"
        Me.FVGCTZ.Name = "FVGCTZ"
        Me.FVGCTZ.ReadOnly = True
        Me.FVGCTZ.Width = 131
        '
        'TCNCLC
        '
        Me.TCNCLC.DataPropertyName = "TCNCLC"
        Me.TCNCLC.HeaderText = "TCNCLC"
        Me.TCNCLC.Name = "TCNCLC"
        Me.TCNCLC.ReadOnly = True
        Me.TCNCLC.Visible = False
        '
        'NCNTRT
        '
        Me.NCNTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCNTRT.DataPropertyName = "NCNTRT"
        Me.NCNTRT.HeaderText = "Número de contrato"
        Me.NCNTRT.Name = "NCNTRT"
        Me.NCNTRT.ReadOnly = True
        Me.NCNTRT.Width = 144
        '
        'CPLNFC
        '
        Me.CPLNFC.DataPropertyName = "CPLNFC"
        Me.CPLNFC.HeaderText = "CPLNFC"
        Me.CPLNFC.Name = "CPLNFC"
        Me.CPLNFC.ReadOnly = True
        Me.CPLNFC.Visible = False
        '
        'SFLZNP
        '
        Me.SFLZNP.DataPropertyName = "SFLZNP"
        Me.SFLZNP.HeaderText = "SFLZNP"
        Me.SFLZNP.Name = "SFLZNP"
        Me.SFLZNP.ReadOnly = True
        Me.SFLZNP.Visible = False
        '
        'SCBRMD
        '
        Me.SCBRMD.DataPropertyName = "SCBRMD"
        Me.SCBRMD.HeaderText = "SCBRMD"
        Me.SCBRMD.Name = "SCBRMD"
        Me.SCBRMD.ReadOnly = True
        Me.SCBRMD.Visible = False
        '
        'SFSANF
        '
        Me.SFSANF.DataPropertyName = "SFSANF"
        Me.SFSANF.HeaderText = "SFSANF"
        Me.SFSANF.Name = "SFSANF"
        Me.SFSANF.ReadOnly = True
        Me.SFSANF.Visible = False
        '
        'SCTZTR
        '
        Me.SCTZTR.DataPropertyName = "SCTZTR"
        Me.SCTZTR.HeaderText = "SCTZTR"
        Me.SCTZTR.Name = "SCTZTR"
        Me.SCTZTR.ReadOnly = True
        Me.SCTZTR.Visible = False
        '
        'SESTCT
        '
        Me.SESTCT.DataPropertyName = "SESTCT"
        Me.SESTCT.HeaderText = "SESTCT"
        Me.SESTCT.Name = "SESTCT"
        Me.SESTCT.ReadOnly = True
        Me.SESTCT.Visible = False
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
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 433)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.TabcCotizacion)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(1044, 295)
        Me.HeaderDatos.TabIndex = 2
        Me.HeaderDatos.Text = "Número de cotización : 0001253 / Número de RUC: 10203202522"
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = "Número de cotización : 0001253 / Número de RUC: 10203202522"
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'TabcCotizacion
        '
        Me.TabcCotizacion.Controls.Add(Me.TabPage1)
        Me.TabcCotizacion.Controls.Add(Me.TabPage2)
        Me.TabcCotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabcCotizacion.Location = New System.Drawing.Point(0, 25)
        Me.TabcCotizacion.Name = "TabcCotizacion"
        Me.TabcCotizacion.SelectedIndex = 0
        Me.TabcCotizacion.Size = New System.Drawing.Size(1042, 245)
        Me.TabcCotizacion.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PanelMantenimiento)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1034, 219)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cotización"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PanelMantenimiento
        '
        Me.PanelMantenimiento.BackColor = System.Drawing.Color.White
        Me.PanelMantenimiento.Controls.Add(Me.KryptonBorderEdge1)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonBorderEdge2)
        Me.PanelMantenimiento.Controls.Add(Me.GroupBox1)
        Me.PanelMantenimiento.Controls.Add(Me.cmbTipoCobro)
        Me.PanelMantenimiento.Controls.Add(Me.txtCliente)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel6)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel23)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel24)
        Me.PanelMantenimiento.Controls.Add(Me.txtPlantaFacturacion)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel22)
        Me.PanelMantenimiento.Controls.Add(Me.cmbMoneda)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel25)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel4)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel8)
        Me.PanelMantenimiento.Controls.Add(Me.chkCotizacionTarifario)
        Me.PanelMantenimiento.Controls.Add(Me.txtNroContrato)
        Me.PanelMantenimiento.Controls.Add(Me.chkServicioAfecto)
        Me.PanelMantenimiento.Controls.Add(Me.txtContacto)
        Me.PanelMantenimiento.Controls.Add(Me.chkFleteZonaPrimaria)
        Me.PanelMantenimiento.Controls.Add(Me.dtpFecCotizacion)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel3)
        Me.PanelMantenimiento.Controls.Add(Me.dtpFechaVigencia)
        Me.PanelMantenimiento.Controls.Add(Me.KryptonLabel10)
        Me.PanelMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMantenimiento.Location = New System.Drawing.Point(3, 3)
        Me.PanelMantenimiento.Name = "PanelMantenimiento"
        Me.PanelMantenimiento.Size = New System.Drawing.Size(1028, 213)
        Me.PanelMantenimiento.TabIndex = 0
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(665, 24)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(250, 1)
        Me.KryptonBorderEdge1.TabIndex = 15
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'KryptonBorderEdge2
        '
        Me.KryptonBorderEdge2.Location = New System.Drawing.Point(525, 23)
        Me.KryptonBorderEdge2.Name = "KryptonBorderEdge2"
        Me.KryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.KryptonBorderEdge2.Size = New System.Drawing.Size(1, 180)
        Me.KryptonBorderEdge2.TabIndex = 13
        Me.KryptonBorderEdge2.Text = "KryptonBorderEdge2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnTrasladoOrdinario)
        Me.GroupBox1.Controls.Add(Me.rbnTrasladoMulti)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 50)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización"
        '
        'rbnTrasladoOrdinario
        '
        Me.rbnTrasladoOrdinario.Checked = True
        Me.rbnTrasladoOrdinario.Location = New System.Drawing.Point(10, 25)
        Me.rbnTrasladoOrdinario.Name = "rbnTrasladoOrdinario"
        Me.rbnTrasladoOrdinario.Size = New System.Drawing.Size(75, 22)
        Me.rbnTrasladoOrdinario.TabIndex = 0
        Me.rbnTrasladoOrdinario.Text = "Ordinario"
        Me.rbnTrasladoOrdinario.Values.ExtraText = ""
        Me.rbnTrasladoOrdinario.Values.Image = Nothing
        Me.rbnTrasladoOrdinario.Values.Text = "Ordinario"
        '
        'rbnTrasladoMulti
        '
        Me.rbnTrasladoMulti.Location = New System.Drawing.Point(95, 25)
        Me.rbnTrasladoMulti.Name = "rbnTrasladoMulti"
        Me.rbnTrasladoMulti.Size = New System.Drawing.Size(86, 22)
        Me.rbnTrasladoMulti.TabIndex = 1
        Me.rbnTrasladoMulti.Text = "Multimodal"
        Me.rbnTrasladoMulti.Values.ExtraText = ""
        Me.rbnTrasladoMulti.Values.Image = Nothing
        Me.rbnTrasladoMulti.Values.Text = "Multimodal"
        '
        'cmbTipoCobro
        '
        Me.cmbTipoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCobro.FormattingEnabled = True
        Me.cmbTipoCobro.Location = New System.Drawing.Point(665, 88)
        Me.cmbTipoCobro.Name = "cmbTipoCobro"
        Me.cmbTipoCobro.Size = New System.Drawing.Size(245, 21)
        Me.cmbTipoCobro.TabIndex = 20
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(115, 23)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = False
        Me.txtCliente.pRequerido = False
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(394, 22)
        Me.txtCliente.TabIndex = 1
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(11, 24)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(48, 22)
        Me.KryptonLabel6.TabIndex = 0
        Me.KryptonLabel6.Text = "Cliente"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Cliente"
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(271, 55)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(56, 22)
        Me.KryptonLabel23.TabIndex = 4
        Me.KryptonLabel23.Text = "Moneda"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Moneda"
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(9, 122)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(101, 22)
        Me.KryptonLabel24.TabIndex = 10
        Me.KryptonLabel24.Text = "Contacto Cliente"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Contacto Cliente"
        '
        'txtPlantaFacturacion
        '
        Me.txtPlantaFacturacion.Codigo = ""
        Me.txtPlantaFacturacion.ControlHeight = 23
        Me.txtPlantaFacturacion.ControlImage = True
        Me.txtPlantaFacturacion.ControlReadOnly = False
        Me.txtPlantaFacturacion.Descripcion = ""
        Me.txtPlantaFacturacion.DisplayColumnVisible = True
        Me.txtPlantaFacturacion.DisplayMember = ""
        Me.txtPlantaFacturacion.KeyColumnWidth = 100
        Me.txtPlantaFacturacion.KeyField = ""
        Me.txtPlantaFacturacion.KeySearch = True
        Me.txtPlantaFacturacion.Location = New System.Drawing.Point(665, 53)
        Me.txtPlantaFacturacion.Name = "txtPlantaFacturacion"
        Me.txtPlantaFacturacion.Size = New System.Drawing.Size(245, 23)
        Me.txtPlantaFacturacion.TabIndex = 18
        Me.txtPlantaFacturacion.TextBackColor = System.Drawing.Color.Empty
        Me.txtPlantaFacturacion.TextForeColor = System.Drawing.Color.Empty
        Me.txtPlantaFacturacion.ValueColumnVisible = True
        Me.txtPlantaFacturacion.ValueColumnWidth = 600
        Me.txtPlantaFacturacion.ValueField = ""
        Me.txtPlantaFacturacion.ValueMember = ""
        Me.txtPlantaFacturacion.ValueSearch = True
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(9, 55)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(76, 22)
        Me.KryptonLabel22.TabIndex = 2
        Me.KryptonLabel22.Text = "N° Contrato"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "N° Contrato"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Codigo = ""
        Me.cmbMoneda.ControlHeight = 23
        Me.cmbMoneda.ControlImage = True
        Me.cmbMoneda.ControlReadOnly = False
        Me.cmbMoneda.Descripcion = ""
        Me.cmbMoneda.DisplayColumnVisible = True
        Me.cmbMoneda.DisplayMember = ""
        Me.cmbMoneda.KeyColumnWidth = 100
        Me.cmbMoneda.KeyField = ""
        Me.cmbMoneda.KeySearch = True
        Me.cmbMoneda.Location = New System.Drawing.Point(365, 53)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(144, 23)
        Me.cmbMoneda.TabIndex = 5
        Me.cmbMoneda.TextBackColor = System.Drawing.Color.Empty
        Me.cmbMoneda.TextForeColor = System.Drawing.Color.Empty
        Me.cmbMoneda.ValueColumnVisible = True
        Me.cmbMoneda.ValueColumnWidth = 600
        Me.cmbMoneda.ValueField = ""
        Me.cmbMoneda.ValueMember = ""
        Me.cmbMoneda.ValueSearch = True
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(9, 89)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(102, 22)
        Me.KryptonLabel25.TabIndex = 6
        Me.KryptonLabel25.Text = "Fecha Cotización"
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Fecha Cotización"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(540, 19)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(120, 20)
        Me.KryptonLabel4.StateNormal.ShortText.Color1 = System.Drawing.Color.Navy
        Me.KryptonLabel4.StateNormal.ShortText.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 14
        Me.KryptonLabel4.Text = "Detalle Cotización."
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Detalle Cotización."
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(271, 89)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(94, 22)
        Me.KryptonLabel8.TabIndex = 8
        Me.KryptonLabel8.Text = "Fecha Vigencia:"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Fecha Vigencia:"
        '
        'chkCotizacionTarifario
        '
        Me.chkCotizacionTarifario.Checked = False
        Me.chkCotizacionTarifario.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkCotizacionTarifario.Location = New System.Drawing.Point(927, 6)
        Me.chkCotizacionTarifario.Name = "chkCotizacionTarifario"
        Me.chkCotizacionTarifario.Size = New System.Drawing.Size(84, 22)
        Me.chkCotizacionTarifario.TabIndex = 16
        Me.chkCotizacionTarifario.Text = "Cotiz.Tarifa"
        Me.chkCotizacionTarifario.Values.ExtraText = ""
        Me.chkCotizacionTarifario.Values.Image = Nothing
        Me.chkCotizacionTarifario.Values.Text = "Cotiz.Tarifa"
        Me.chkCotizacionTarifario.Visible = False
        '
        'txtNroContrato
        '
        Me.txtNroContrato.Enabled = False
        Me.txtNroContrato.Location = New System.Drawing.Point(115, 54)
        Me.txtNroContrato.MaxLength = 15
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Size = New System.Drawing.Size(144, 22)
        Me.txtNroContrato.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtNroContrato.StateDisabled.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNroContrato.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtNroContrato.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroContrato.TabIndex = 3
        '
        'chkServicioAfecto
        '
        Me.chkServicioAfecto.Checked = False
        Me.chkServicioAfecto.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkServicioAfecto.Location = New System.Drawing.Point(665, 122)
        Me.chkServicioAfecto.Name = "chkServicioAfecto"
        Me.chkServicioAfecto.Size = New System.Drawing.Size(105, 22)
        Me.chkServicioAfecto.TabIndex = 21
        Me.chkServicioAfecto.Tag = " "
        Me.chkServicioAfecto.Text = "Servicio Afecto"
        Me.chkServicioAfecto.Values.ExtraText = ""
        Me.chkServicioAfecto.Values.Image = Nothing
        Me.chkServicioAfecto.Values.Text = "Servicio Afecto"
        '
        'txtContacto
        '
        Me.txtContacto.Enabled = False
        Me.txtContacto.Location = New System.Drawing.Point(115, 121)
        Me.txtContacto.MaxLength = 40
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(394, 22)
        Me.txtContacto.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.txtContacto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtContacto.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.TabIndex = 11
        '
        'chkFleteZonaPrimaria
        '
        Me.chkFleteZonaPrimaria.Checked = False
        Me.chkFleteZonaPrimaria.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFleteZonaPrimaria.Location = New System.Drawing.Point(790, 122)
        Me.chkFleteZonaPrimaria.Name = "chkFleteZonaPrimaria"
        Me.chkFleteZonaPrimaria.Size = New System.Drawing.Size(129, 22)
        Me.chkFleteZonaPrimaria.TabIndex = 22
        Me.chkFleteZonaPrimaria.Text = "Flete Zona Primaria"
        Me.chkFleteZonaPrimaria.Values.ExtraText = ""
        Me.chkFleteZonaPrimaria.Values.Image = Nothing
        Me.chkFleteZonaPrimaria.Values.Text = "Flete Zona Primaria"
        '
        'dtpFecCotizacion
        '
        Me.dtpFecCotizacion.Enabled = False
        Me.dtpFecCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCotizacion.Location = New System.Drawing.Point(117, 88)
        Me.dtpFecCotizacion.Name = "dtpFecCotizacion"
        Me.dtpFecCotizacion.Size = New System.Drawing.Size(144, 20)
        Me.dtpFecCotizacion.TabIndex = 7
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(542, 89)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(87, 22)
        Me.KryptonLabel3.TabIndex = 19
        Me.KryptonLabel3.Text = "Tipo de cobro "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo de cobro "
        '
        'dtpFechaVigencia
        '
        Me.dtpFechaVigencia.Enabled = False
        Me.dtpFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVigencia.Location = New System.Drawing.Point(365, 88)
        Me.dtpFechaVigencia.Name = "dtpFechaVigencia"
        Me.dtpFechaVigencia.Size = New System.Drawing.Size(144, 20)
        Me.dtpFechaVigencia.TabIndex = 9
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(542, 55)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(110, 22)
        Me.KryptonLabel10.TabIndex = 17
        Me.KryptonLabel10.Text = "Planta Facturación"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Planta Facturación"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dtgDetalleCotizacion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1034, 221)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle Cotización"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dtgDetalleCotizacion
        '
        Me.dtgDetalleCotizacion.AllowUserToAddRows = False
        Me.dtgDetalleCotizacion.AllowUserToDeleteRows = False
        Me.dtgDetalleCotizacion.AllowUserToOrderColumns = True
        Me.dtgDetalleCotizacion.ColumnHeadersHeight = 35
        Me.dtgDetalleCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgDetalleCotizacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCTZCN_DET, Me.NCRRCT, Me.CMRCDR, Me.CUNDMD, Me.CFRMPG, Me.CCMPSG, Me.TUNDVH, Me.NPLSGC, Me.QPRCS1, Me.VMRCDR, Me.LMRCDR, Me.TRFMRC, Me.FINCSR, Me.STPOMR, Me.FCRGMR, Me.NPTSCR, Me.NPTSDS, Me.FENTMR, Me.SCNDTR, Me.TMRCDR, Me.SRSTRC, Me.CTPOSR, Me.CTPSBS, Me.CCNDRT, Me.CVPRCN, Me.NVJES, Me.CTPUNV, Me.CFRAPG, Me.MERCAD, Me.QMRCDR, Me.UNIMED, Me.PMRCDR, Me.FFACTURA, Me.FPAGO, Me.SSGRCT, Me.SEGURO, Me.NORSRT, Me.CCNCST, Me.CCNCS1, Me.SESTOS, Me.ESTADOOS, Me.btnServicioCotizacion})
        Me.dtgDetalleCotizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDetalleCotizacion.Location = New System.Drawing.Point(3, 3)
        Me.dtgDetalleCotizacion.MultiSelect = False
        Me.dtgDetalleCotizacion.Name = "dtgDetalleCotizacion"
        Me.dtgDetalleCotizacion.ReadOnly = True
        Me.dtgDetalleCotizacion.RowHeadersWidth = 20
        Me.dtgDetalleCotizacion.RowTemplate.Height = 16
        Me.dtgDetalleCotizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDetalleCotizacion.Size = New System.Drawing.Size(1028, 215)
        Me.dtgDetalleCotizacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDetalleCotizacion.TabIndex = 6
        Me.dtgDetalleCotizacion.TabStop = False
        '
        'NCTZCN_DET
        '
        Me.NCTZCN_DET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCTZCN_DET.DataPropertyName = "NCTZCN"
        Me.NCTZCN_DET.HeaderText = "N° Cotización"
        Me.NCTZCN_DET.Name = "NCTZCN_DET"
        Me.NCTZCN_DET.ReadOnly = True
        Me.NCTZCN_DET.Visible = False
        Me.NCTZCN_DET.Width = 109
        '
        'NCRRCT
        '
        Me.NCRRCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRCT.DataPropertyName = "NCRRCT"
        Me.NCRRCT.HeaderText = "N° Correlativo"
        Me.NCRRCT.Name = "NCRRCT"
        Me.NCRRCT.ReadOnly = True
        Me.NCRRCT.Width = 111
        '
        'CMRCDR
        '
        Me.CMRCDR.DataPropertyName = "CMRCDR"
        Me.CMRCDR.HeaderText = "CMRCDR"
        Me.CMRCDR.Name = "CMRCDR"
        Me.CMRCDR.ReadOnly = True
        Me.CMRCDR.Visible = False
        '
        'CUNDMD
        '
        Me.CUNDMD.DataPropertyName = "CUNDMD"
        Me.CUNDMD.HeaderText = "CUNDMD"
        Me.CUNDMD.Name = "CUNDMD"
        Me.CUNDMD.ReadOnly = True
        Me.CUNDMD.Visible = False
        '
        'CFRMPG
        '
        Me.CFRMPG.DataPropertyName = "CFRMPG"
        Me.CFRMPG.HeaderText = "CFRMPG"
        Me.CFRMPG.Name = "CFRMPG"
        Me.CFRMPG.ReadOnly = True
        Me.CFRMPG.Visible = False
        '
        'CCMPSG
        '
        Me.CCMPSG.DataPropertyName = "CCMPSG"
        Me.CCMPSG.HeaderText = "CCMPSG"
        Me.CCMPSG.Name = "CCMPSG"
        Me.CCMPSG.ReadOnly = True
        Me.CCMPSG.Visible = False
        '
        'TUNDVH
        '
        Me.TUNDVH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TUNDVH.DataPropertyName = "TUNDVH"
        Me.TUNDVH.HeaderText = "Unidad Vehicular"
        Me.TUNDVH.Name = "TUNDVH"
        Me.TUNDVH.ReadOnly = True
        Me.TUNDVH.Width = 126
        '
        'NPLSGC
        '
        Me.NPLSGC.DataPropertyName = "NPLSGC"
        Me.NPLSGC.HeaderText = "NPLSGC"
        Me.NPLSGC.Name = "NPLSGC"
        Me.NPLSGC.ReadOnly = True
        Me.NPLSGC.Visible = False
        '
        'QPRCS1
        '
        Me.QPRCS1.DataPropertyName = "QPRCS1"
        Me.QPRCS1.HeaderText = "QPRCS1"
        Me.QPRCS1.Name = "QPRCS1"
        Me.QPRCS1.ReadOnly = True
        Me.QPRCS1.Visible = False
        '
        'VMRCDR
        '
        Me.VMRCDR.DataPropertyName = "VMRCDR"
        Me.VMRCDR.HeaderText = "VMRCDR"
        Me.VMRCDR.Name = "VMRCDR"
        Me.VMRCDR.ReadOnly = True
        Me.VMRCDR.Visible = False
        '
        'LMRCDR
        '
        Me.LMRCDR.DataPropertyName = "LMRCDR"
        Me.LMRCDR.HeaderText = "LMRCDR"
        Me.LMRCDR.Name = "LMRCDR"
        Me.LMRCDR.ReadOnly = True
        Me.LMRCDR.Visible = False
        '
        'TRFMRC
        '
        Me.TRFMRC.DataPropertyName = "TRFMRC"
        Me.TRFMRC.HeaderText = "TRFMRC"
        Me.TRFMRC.Name = "TRFMRC"
        Me.TRFMRC.ReadOnly = True
        Me.TRFMRC.Visible = False
        '
        'FINCSR
        '
        Me.FINCSR.DataPropertyName = "FINCSR"
        Me.FINCSR.HeaderText = "FINCSR"
        Me.FINCSR.Name = "FINCSR"
        Me.FINCSR.ReadOnly = True
        Me.FINCSR.Visible = False
        '
        'STPOMR
        '
        Me.STPOMR.DataPropertyName = "STPOMR"
        Me.STPOMR.HeaderText = "STPOMR"
        Me.STPOMR.Name = "STPOMR"
        Me.STPOMR.ReadOnly = True
        Me.STPOMR.Visible = False
        '
        'FCRGMR
        '
        Me.FCRGMR.DataPropertyName = "FCRGMR"
        Me.FCRGMR.HeaderText = "FCRGMR"
        Me.FCRGMR.Name = "FCRGMR"
        Me.FCRGMR.ReadOnly = True
        Me.FCRGMR.Visible = False
        '
        'NPTSCR
        '
        Me.NPTSCR.DataPropertyName = "NPTSCR"
        Me.NPTSCR.HeaderText = "NPTSCR"
        Me.NPTSCR.Name = "NPTSCR"
        Me.NPTSCR.ReadOnly = True
        Me.NPTSCR.Visible = False
        '
        'NPTSDS
        '
        Me.NPTSDS.DataPropertyName = "NPTSDS"
        Me.NPTSDS.HeaderText = "NPTSDS"
        Me.NPTSDS.Name = "NPTSDS"
        Me.NPTSDS.ReadOnly = True
        Me.NPTSDS.Visible = False
        '
        'FENTMR
        '
        Me.FENTMR.DataPropertyName = "FENTMR"
        Me.FENTMR.HeaderText = "FENTMR"
        Me.FENTMR.Name = "FENTMR"
        Me.FENTMR.ReadOnly = True
        Me.FENTMR.Visible = False
        '
        'SCNDTR
        '
        Me.SCNDTR.DataPropertyName = "SCNDTR"
        Me.SCNDTR.HeaderText = "SCNDTR"
        Me.SCNDTR.Name = "SCNDTR"
        Me.SCNDTR.ReadOnly = True
        Me.SCNDTR.Visible = False
        '
        'TMRCDR
        '
        Me.TMRCDR.DataPropertyName = "TMRCDR"
        Me.TMRCDR.HeaderText = "TMRCDR"
        Me.TMRCDR.Name = "TMRCDR"
        Me.TMRCDR.ReadOnly = True
        Me.TMRCDR.Visible = False
        '
        'SRSTRC
        '
        Me.SRSTRC.DataPropertyName = "SRSTRC"
        Me.SRSTRC.HeaderText = "SRSTRC"
        Me.SRSTRC.Name = "SRSTRC"
        Me.SRSTRC.ReadOnly = True
        Me.SRSTRC.Visible = False
        '
        'CTPOSR
        '
        Me.CTPOSR.DataPropertyName = "CTPOSR"
        Me.CTPOSR.HeaderText = "CTPOSR"
        Me.CTPOSR.Name = "CTPOSR"
        Me.CTPOSR.ReadOnly = True
        Me.CTPOSR.Visible = False
        '
        'CTPSBS
        '
        Me.CTPSBS.DataPropertyName = "CTPSBS"
        Me.CTPSBS.HeaderText = "CTPSBS"
        Me.CTPSBS.Name = "CTPSBS"
        Me.CTPSBS.ReadOnly = True
        Me.CTPSBS.Visible = False
        '
        'CCNDRT
        '
        Me.CCNDRT.DataPropertyName = "CCNDRT"
        Me.CCNDRT.HeaderText = "CCNDRT"
        Me.CCNDRT.Name = "CCNDRT"
        Me.CCNDRT.ReadOnly = True
        Me.CCNDRT.Visible = False
        '
        'CVPRCN
        '
        Me.CVPRCN.DataPropertyName = "CVPRCN"
        Me.CVPRCN.HeaderText = "CVPRCN"
        Me.CVPRCN.Name = "CVPRCN"
        Me.CVPRCN.ReadOnly = True
        Me.CVPRCN.Visible = False
        '
        'NVJES
        '
        Me.NVJES.DataPropertyName = "NVJES"
        Me.NVJES.HeaderText = "NVJES"
        Me.NVJES.Name = "NVJES"
        Me.NVJES.ReadOnly = True
        Me.NVJES.Visible = False
        '
        'CTPUNV
        '
        Me.CTPUNV.DataPropertyName = "CTPUNV"
        Me.CTPUNV.HeaderText = "CTPUNV"
        Me.CTPUNV.Name = "CTPUNV"
        Me.CTPUNV.ReadOnly = True
        Me.CTPUNV.Visible = False
        '
        'CFRAPG
        '
        Me.CFRAPG.DataPropertyName = "CFRAPG"
        Me.CFRAPG.HeaderText = "CFRAPG"
        Me.CFRAPG.Name = "CFRAPG"
        Me.CFRAPG.ReadOnly = True
        Me.CFRAPG.Visible = False
        '
        'MERCAD
        '
        Me.MERCAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MERCAD.DataPropertyName = "MERCAD"
        Me.MERCAD.HeaderText = "Producto"
        Me.MERCAD.Name = "MERCAD"
        Me.MERCAD.ReadOnly = True
        Me.MERCAD.Width = 85
        '
        'QMRCDR
        '
        Me.QMRCDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QMRCDR.DataPropertyName = "QMRCDR"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.QMRCDR.DefaultCellStyle = DataGridViewCellStyle3
        Me.QMRCDR.HeaderText = "Cantidad"
        Me.QMRCDR.Name = "QMRCDR"
        Me.QMRCDR.ReadOnly = True
        Me.QMRCDR.Width = 84
        '
        'UNIMED
        '
        Me.UNIMED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UNIMED.DataPropertyName = "UNIMED"
        Me.UNIMED.HeaderText = "Unidad de Medida"
        Me.UNIMED.Name = "UNIMED"
        Me.UNIMED.ReadOnly = True
        Me.UNIMED.Width = 133
        '
        'PMRCDR
        '
        Me.PMRCDR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PMRCDR.DataPropertyName = "PMRCDR"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PMRCDR.DefaultCellStyle = DataGridViewCellStyle4
        Me.PMRCDR.HeaderText = "Peso"
        Me.PMRCDR.Name = "PMRCDR"
        Me.PMRCDR.ReadOnly = True
        Me.PMRCDR.Width = 61
        '
        'FFACTURA
        '
        Me.FFACTURA.DataPropertyName = "FFACTURA"
        Me.FFACTURA.HeaderText = "Parám. Facturación"
        Me.FFACTURA.Name = "FFACTURA"
        Me.FFACTURA.ReadOnly = True
        '
        'FPAGO
        '
        Me.FPAGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FPAGO.DataPropertyName = "FPAGO"
        Me.FPAGO.HeaderText = "Parám. Pago"
        Me.FPAGO.Name = "FPAGO"
        Me.FPAGO.ReadOnly = True
        Me.FPAGO.Width = 103
        '
        'SSGRCT
        '
        Me.SSGRCT.DataPropertyName = "SSGRCT"
        Me.SSGRCT.HeaderText = "SSGRCT"
        Me.SSGRCT.Name = "SSGRCT"
        Me.SSGRCT.ReadOnly = True
        Me.SSGRCT.Visible = False
        '
        'SEGURO
        '
        Me.SEGURO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEGURO.DataPropertyName = "SEGURO"
        Me.SEGURO.HeaderText = "Seguro"
        Me.SEGURO.Name = "SEGURO"
        Me.SEGURO.ReadOnly = True
        Me.SEGURO.Width = 73
        '
        'NORSRT
        '
        Me.NORSRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORSRT.DataPropertyName = "NORSRT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NORSRT.DefaultCellStyle = DataGridViewCellStyle5
        Me.NORSRT.HeaderText = " O / S"
        Me.NORSRT.Name = "NORSRT"
        Me.NORSRT.ReadOnly = True
        Me.NORSRT.Width = 65
        '
        'CCNCST
        '
        Me.CCNCST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCNCST.DataPropertyName = "CCNCST"
        Me.CCNCST.HeaderText = "Ce. Co Propio"
        Me.CCNCST.Name = "CCNCST"
        Me.CCNCST.ReadOnly = True
        Me.CCNCST.Width = 109
        '
        'CCNCS1
        '
        Me.CCNCS1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CCNCS1.DataPropertyName = "CCNCS1"
        Me.CCNCS1.HeaderText = "Ce. Co Tercero"
        Me.CCNCS1.Name = "CCNCS1"
        Me.CCNCS1.ReadOnly = True
        Me.CCNCS1.Width = 114
        '
        'SESTOS
        '
        Me.SESTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SESTOS.DataPropertyName = "SESTOS"
        Me.SESTOS.HeaderText = "SESTOS"
        Me.SESTOS.Name = "SESTOS"
        Me.SESTOS.ReadOnly = True
        Me.SESTOS.Visible = False
        Me.SESTOS.Width = 76
        '
        'ESTADOOS
        '
        Me.ESTADOOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESTADOOS.DataPropertyName = "ESTADOOS"
        Me.ESTADOOS.HeaderText = "Estado O / S"
        Me.ESTADOOS.Name = "ESTADOOS"
        Me.ESTADOOS.ReadOnly = True
        '
        'btnServicioCotizacion
        '
        Me.btnServicioCotizacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.btnServicioCotizacion.HeaderText = "Servicios"
        Me.btnServicioCotizacion.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnServicioCotizacion.Name = "btnServicioCotizacion"
        Me.btnServicioCotizacion.ReadOnly = True
        Me.btnServicioCotizacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnServicioCotizacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnServicioCotizacion.Width = 82
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.Separator1, Me.btnModificar, Me.btnGuardar, Me.Separator2, Me.btnCancelar, Me.Separator3, Me.btnEliminar, Me.Separator4, Me.btnImprimir, Me.Separator5, Me.btnCopiarCotizacion, Me.btnGenerarOSDetalleCotizacion})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1042, 25)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.TabStop = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'Separator1
        '
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'Separator2
        '
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources._stop
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Separator3
        '
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Visible = False
        '
        'Separator4
        '
        Me.Separator4.Name = "Separator4"
        Me.Separator4.Size = New System.Drawing.Size(6, 25)
        Me.Separator4.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.printer2
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(73, 22)
        Me.btnImprimir.Text = "Imprimir"
        '
        'Separator5
        '
        Me.Separator5.Name = "Separator5"
        Me.Separator5.Size = New System.Drawing.Size(6, 25)
        '
        'btnCopiarCotizacion
        '
        Me.btnCopiarCotizacion.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.Agregar2
        Me.btnCopiarCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopiarCotizacion.Name = "btnCopiarCotizacion"
        Me.btnCopiarCotizacion.Size = New System.Drawing.Size(121, 22)
        Me.btnCopiarCotizacion.Text = "Copiar Cotización"
        '
        'btnGenerarOSDetalleCotizacion
        '
        Me.btnGenerarOSDetalleCotizacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenerarOSDetalleCotizacion.Enabled = False
        Me.btnGenerarOSDetalleCotizacion.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnGenerarOSDetalleCotizacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerarOSDetalleCotizacion.Name = "btnGenerarOSDetalleCotizacion"
        Me.btnGenerarOSDetalleCotizacion.Size = New System.Drawing.Size(86, 22)
        Me.btnGenerarOSDetalleCotizacion.Text = "Generar OS"
        '
        'PanelFiltros
        '
        Me.PanelFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnBuscar})
        Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltros.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.PanelFiltros.HeaderVisiblePrimary = False
        Me.PanelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltros.Name = "PanelFiltros"
        '
        'PanelFiltros.Panel
        '
        Me.PanelFiltros.Panel.Controls.Add(Me.cboPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboDivision)
        Me.PanelFiltros.Panel.Controls.Add(Me.cboCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.ckbRangoFechas)
        Me.PanelFiltros.Panel.Controls.Add(Me.txtClienteFiltro)
        Me.PanelFiltros.Panel.Controls.Add(Me.cmbEstado)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblPlanta)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.PanelFiltros.Panel.Controls.Add(Me.lblCompania)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.PanelFiltros.Panel.Controls.Add(Me.dtpFechaFin)
        Me.PanelFiltros.Panel.Controls.Add(Me.KryptonLabel21)
        Me.PanelFiltros.Size = New System.Drawing.Size(1044, 99)
        Me.PanelFiltros.TabIndex = 0
        Me.PanelFiltros.Text = "Lista de Gastos de Ruta"
        Me.PanelFiltros.ValuesPrimary.Description = "Lista de Gastos de Ruta"
        Me.PanelFiltros.ValuesPrimary.Heading = "Lista de Gastos de Ruta"
        Me.PanelFiltros.ValuesPrimary.Image = Nothing
        Me.PanelFiltros.ValuesSecondary.Description = ""
        Me.PanelFiltros.ValuesSecondary.Heading = "Lista de Contratos"
        Me.PanelFiltros.ValuesSecondary.Image = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.ExtraText = ""
        Me.btnBuscar.HeaderLocation = ComponentFactory.Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.btnBuscar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.search
        Me.btnBuscar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.ToolTipImage = Nothing
        Me.btnBuscar.UniqueName = "1E7B5DC088DB4E1F1E7B5DC088DB4E1F"
        '
        'cboPlanta
        '
        Me.cboPlanta.BackColor = System.Drawing.Color.Transparent
        Me.cboPlanta.CodigoCompania = ""
        Me.cboPlanta.CodigoDivision = ""
        Me.cboPlanta.CPLNDV_ANTERIOR = Nothing
        Me.cboPlanta.DescripcionPlanta = ""
        Me.cboPlanta.ItemTodos = False
        Me.cboPlanta.Location = New System.Drawing.Point(775, 9)
        Me.cboPlanta.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cboPlanta.Name = "cboPlanta"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.cboPlanta.obePlanta = BePlanta1
        Me.cboPlanta.pHabilitado = True
        Me.cboPlanta.Planta = 0
        Me.cboPlanta.PlantaDefault = -1
        Me.cboPlanta.pRequerido = False
        Me.cboPlanta.Size = New System.Drawing.Size(210, 23)
        Me.cboPlanta.TabIndex = 5
        Me.cboPlanta.Usuario = ""
        '
        'cboDivision
        '
        Me.cboDivision.BackColor = System.Drawing.Color.Transparent
        Me.cboDivision.CDVSN_ANTERIOR = Nothing
        Me.cboDivision.Compania = ""
        Me.cboDivision.Division = Nothing
        Me.cboDivision.DivisionDefault = Nothing
        Me.cboDivision.DivisionDescripcion = Nothing
        Me.cboDivision.ItemTodos = False
        Me.cboDivision.Location = New System.Drawing.Point(431, 10)
        Me.cboDivision.MinimumSize = New System.Drawing.Size(150, 21)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.obeDivision = Nothing
        Me.cboDivision.pHabilitado = True
        Me.cboDivision.pRequerido = False
        Me.cboDivision.Size = New System.Drawing.Size(206, 26)
        Me.cboDivision.TabIndex = 3
        Me.cboDivision.Usuario = ""
        '
        'cboCompania
        '
        Me.cboCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cboCompania.CCMPN_ANTERIOR = Nothing
        Me.cboCompania.CCMPN_CodigoCompania = Nothing
        Me.cboCompania.CCMPN_CompaniaDefault = Nothing
        Me.cboCompania.CCMPN_Descripcion = Nothing
        Me.cboCompania.Habilitar = True
        Me.cboCompania.Location = New System.Drawing.Point(75, 9)
        Me.cboCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cboCompania.Name = "cboCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.cboCompania.oBeCompania = BeCompania1
        Me.cboCompania.Size = New System.Drawing.Size(285, 27)
        Me.cboCompania.TabIndex = 1
        Me.cboCompania.Usuario = ""
        '
        'ckbRangoFechas
        '
        Me.ckbRangoFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbRangoFechas.Location = New System.Drawing.Point(650, 43)
        Me.ckbRangoFechas.Name = "ckbRangoFechas"
        Me.ckbRangoFechas.Size = New System.Drawing.Size(125, 20)
        Me.ckbRangoFechas.TabIndex = 10
        Me.ckbRangoFechas.Text = "Fechas de vigencia"
        Me.ckbRangoFechas.Values.ExtraText = ""
        Me.ckbRangoFechas.Values.Image = Nothing
        Me.ckbRangoFechas.Values.Text = "Fechas de vigencia"
        '
        'txtClienteFiltro
        '
        Me.txtClienteFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtClienteFiltro.BackColor = System.Drawing.Color.Transparent
        Me.txtClienteFiltro.CCMPN = "EZ"
        Me.txtClienteFiltro.Location = New System.Drawing.Point(76, 42)
        Me.txtClienteFiltro.Name = "txtClienteFiltro"
        Me.txtClienteFiltro.pAccesoPorUsuario = False
        Me.txtClienteFiltro.pRequerido = False
        Me.txtClienteFiltro.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtClienteFiltro.Size = New System.Drawing.Size(284, 22)
        Me.txtClienteFiltro.TabIndex = 7
        '
        'cmbEstado
        '
        Me.cmbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.DropDownWidth = 156
        Me.cmbEstado.FormattingEnabled = False
        Me.cmbEstado.ItemHeight = 15
        Me.cmbEstado.Location = New System.Drawing.Point(431, 42)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(206, 23)
        Me.cmbEstado.TabIndex = 9
        Me.cmbEstado.TabStop = False
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(642, 11)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(44, 20)
        Me.lblPlanta.TabIndex = 4
        Me.lblPlanta.Text = "Planta"
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(7, 43)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Text = "Cliente"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Cliente"
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(7, 11)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 20)
        Me.lblCompania.TabIndex = 0
        Me.lblCompania.Text = "Compañia"
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(370, 43)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(47, 20)
        Me.KryptonLabel1.TabIndex = 8
        Me.KryptonLabel1.Text = "Estado"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Estado"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(370, 11)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel5.TabIndex = 2
        Me.KryptonLabel5.Text = "División"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(775, 42)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(93, 21)
        Me.dtpFechaInicio.TabIndex = 11
        Me.dtpFechaInicio.TabStop = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CalendarFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(893, 42)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(92, 21)
        Me.dtpFechaFin.TabIndex = 13
        Me.dtpFechaFin.TabStop = False
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(871, 43)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(20, 20)
        Me.KryptonLabel21.TabIndex = 12
        Me.KryptonLabel21.Text = "al"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "al"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NMSLPE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° Cotización"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CMNDA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CMNDA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CMNDA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FCTZCN"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Cotización"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FVGCTZ"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "Número de Contrato"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NCNTRT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Número de Contrato"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TCNCLC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TCNCLC"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CPLNFC"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CPLNFC"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SFLZNP"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SFLZNP"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SCBRMD"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SCBRMD"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SFSANF"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SFSANF"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SCTZTR"
        Me.DataGridViewTextBoxColumn14.HeaderText = "SCTZTR"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "SESTCT"
        Me.DataGridViewTextBoxColumn15.HeaderText = "SESTCT"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn16.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn17.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CPLNDV"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "NCTZCN"
        Me.DataGridViewTextBoxColumn19.HeaderText = "N° Cotización"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NCRRCT"
        Me.DataGridViewTextBoxColumn20.HeaderText = "N° Correlativo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "CMRCDR"
        Me.DataGridViewTextBoxColumn21.HeaderText = "CMRCDR"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "CUNDMD"
        Me.DataGridViewTextBoxColumn22.HeaderText = "CUNDMD"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "CFRMPG"
        Me.DataGridViewTextBoxColumn23.HeaderText = "CFRMPG"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "CCMPSG"
        Me.DataGridViewTextBoxColumn24.HeaderText = "CCMPSG"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "NPLSGC"
        Me.DataGridViewTextBoxColumn25.HeaderText = "NPLSGC"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "QPRCS1"
        Me.DataGridViewTextBoxColumn26.HeaderText = "QPRCS1"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "VMRCDR"
        Me.DataGridViewTextBoxColumn27.HeaderText = "VMRCDR"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "LMRCDR"
        Me.DataGridViewTextBoxColumn28.HeaderText = "LMRCDR"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "TRFMRC"
        Me.DataGridViewTextBoxColumn29.HeaderText = "TRFMRC"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "FINCSR"
        Me.DataGridViewTextBoxColumn30.HeaderText = "FINCSR"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "STPOMR"
        Me.DataGridViewTextBoxColumn31.HeaderText = "STPOMR"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "FCRGMR"
        Me.DataGridViewTextBoxColumn32.HeaderText = "FCRGMR"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "NPTSCR"
        Me.DataGridViewTextBoxColumn33.HeaderText = "NPTSCR"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "NPTSDS"
        Me.DataGridViewTextBoxColumn34.HeaderText = "NPTSDS"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        Me.DataGridViewTextBoxColumn34.Visible = False
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "FENTMR"
        Me.DataGridViewTextBoxColumn35.HeaderText = "FENTMR"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "SCNDTR"
        Me.DataGridViewTextBoxColumn36.HeaderText = "SCNDTR"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "TMRCDR"
        Me.DataGridViewTextBoxColumn37.HeaderText = "TMRCDR"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        Me.DataGridViewTextBoxColumn37.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "SRSTRC"
        Me.DataGridViewTextBoxColumn38.HeaderText = "SRSTRC"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        Me.DataGridViewTextBoxColumn38.Visible = False
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "CTPOSR"
        Me.DataGridViewTextBoxColumn39.HeaderText = "CTPOSR"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        Me.DataGridViewTextBoxColumn39.Visible = False
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "CTPSBS"
        Me.DataGridViewTextBoxColumn40.HeaderText = "CTPSBS"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        Me.DataGridViewTextBoxColumn40.Visible = False
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "CCNDRT"
        Me.DataGridViewTextBoxColumn41.HeaderText = "CCNDRT"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        Me.DataGridViewTextBoxColumn41.Visible = False
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "CVPRCN"
        Me.DataGridViewTextBoxColumn42.HeaderText = "CVPRCN"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        Me.DataGridViewTextBoxColumn42.Visible = False
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "NVJES"
        Me.DataGridViewTextBoxColumn43.HeaderText = "NVJES"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        Me.DataGridViewTextBoxColumn43.Visible = False
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "CTPUNV"
        Me.DataGridViewTextBoxColumn44.HeaderText = "CTPUNV"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        Me.DataGridViewTextBoxColumn44.Visible = False
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "CFRAPG"
        Me.DataGridViewTextBoxColumn45.HeaderText = "CFRAPG"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        Me.DataGridViewTextBoxColumn45.Visible = False
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "MERCAD"
        Me.DataGridViewTextBoxColumn46.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        Me.DataGridViewTextBoxColumn46.Visible = False
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "QMRCDR"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn47.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn47.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "UNIMED"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn48.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn48.HeaderText = "Unidad de Medida"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "PMRCDR"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn49.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn49.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "FPAGO"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn50.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn50.HeaderText = "Forma de Pago"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "FFACTURA"
        Me.DataGridViewTextBoxColumn51.HeaderText = "CFRAPG"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        Me.DataGridViewTextBoxColumn51.Visible = False
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "SSGRCT"
        Me.DataGridViewTextBoxColumn52.HeaderText = "SSGRCT"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Visible = False
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "SEGURO"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Seguro"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Visible = False
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "NORSRT"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn54.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn54.HeaderText = "Orden de Servicio"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "SESTOS"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn55.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn55.HeaderText = "SESTOS"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Visible = False
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "ESTADOOS"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Estado OS"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        Me.DataGridViewTextBoxColumn56.Visible = False
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "ESTADOOS"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Estado OS"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "SESTOS"
        Me.DataGridViewTextBoxColumn58.HeaderText = "SESTOS"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Visible = False
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "ESTADOOS"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Estado OS"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        '
        'ucCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "ucCotizacion"
        Me.Size = New System.Drawing.Size(1044, 728)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.dtgCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        Me.TabcCotizacion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.PanelMantenimiento.ResumeLayout(False)
        Me.PanelMantenimiento.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dtgDetalleCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtgCotizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCTZCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FVGCTZ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNCLC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFLZNP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCBRMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SFSANF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCTZTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabcCotizacion As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PanelMantenimiento As System.Windows.Forms.Panel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents KryptonBorderEdge2 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnTrasladoOrdinario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbnTrasladoMulti As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents cmbTipoCobro As System.Windows.Forms.ComboBox
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlantaFacturacion As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbMoneda As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkCotizacionTarifario As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtNroContrato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkServicioAfecto As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtContacto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkFleteZonaPrimaria As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dtpFecCotizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtgDetalleCotizacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
    Friend WithEvents Separator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCopiarCotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGenerarOSDetalleCotizacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cboPlanta As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents cboDivision As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents cboCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents ckbRangoFechas As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtClienteFiltro As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents cmbEstado As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCTZCN_DET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNDMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFRMPG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPSG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TUNDVH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLSGC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPRCS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRFMRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINCSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STPOMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCRGMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPTSCR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPTSDS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FENTMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCNDTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SRSTRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPOSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPSBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNDRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CVPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NVJES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPUNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFRAPG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MERCAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIMED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMRCDR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFACTURA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FPAGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSGRCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGURO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORSRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNCST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNCS1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADOOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnServicioCotizacion As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

End Class
