<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServEspPorPromedio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServEspPorPromedio))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NRTFSV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VALCTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNDMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QATNAN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TSGNMN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVLSRV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRROP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.lblServicios = New System.Windows.Forms.ToolStripLabel
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.cmbServicio = New System.Windows.Forms.ToolStripComboBox
        Me.dtgBultos_Dinamico = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFormaTarifa = New System.Windows.Forms.ToolStripComboBox
        Me.lblPeso = New System.Windows.Forms.ToolStripLabel
        Me.txtPeso = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblVolumen = New System.Windows.Forms.ToolStripLabel
        Me.txtVolumen = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.lblArea = New System.Windows.Forms.ToolStripLabel
        Me.txtArea = New System.Windows.Forms.ToolStripTextBox
        Me.hgTitulo = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbZona = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        Me.cmbAlmacen = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.btnCalcularProm = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtFechaSalida = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtFechaRecepcion = New System.Windows.Forms.DateTimePicker
        Me.lblFechaOperacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaOperacion = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbUnidadMedida = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMontoTotal = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ucClienteFacturar = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.cmbPlanta = New System.Windows.Forms.ComboBox
        Me.lblClienteFact = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcClienteOperacion = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.Panel2.SuspendLayout()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dtgBultos_Dinamico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.hgTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgTitulo.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgTitulo.Panel.SuspendLayout()
        Me.hgTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup3)
        Me.KryptonPanel.Controls.Add(Me.hgTitulo)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(762, 535)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 210)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(762, 325)
        Me.KryptonHeaderGroup3.TabIndex = 4
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Promedios"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer2.Panel1
        '
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.dgServicio)
        Me.KryptonSplitContainer2.Panel1.Controls.Add(Me.tsMenuOpciones)
        '
        'KryptonSplitContainer2.Panel2
        '
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.dtgBultos_Dinamico)
        Me.KryptonSplitContainer2.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer2.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(760, 302)
        Me.KryptonSplitContainer2.SplitterDistance = 162
        Me.KryptonSplitContainer2.TabIndex = 1
        '
        'dgServicio
        '
        Me.dgServicio.AllowUserToAddRows = False
        Me.dgServicio.AllowUserToDeleteRows = False
        Me.dgServicio.AllowUserToResizeColumns = False
        Me.dgServicio.AllowUserToResizeRows = False
        Me.dgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRTFSV, Me.DESTAR, Me.VALCTE, Me.CUNDMD, Me.QATNAN, Me.TSGNMN, Me.CCNTCS, Me.IVLSRV, Me.NOPRCN, Me.NCRROP})
        Me.dgServicio.DataMember = "dtRZSC30"
        Me.dgServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicio.Location = New System.Drawing.Point(0, 25)
        Me.dgServicio.MultiSelect = False
        Me.dgServicio.Name = "dgServicio"
        Me.dgServicio.ReadOnly = True
        Me.dgServicio.RowHeadersWidth = 20
        Me.dgServicio.RowTemplate.ReadOnly = True
        Me.dgServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgServicio.Size = New System.Drawing.Size(760, 137)
        Me.dgServicio.StandardTab = True
        Me.dgServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgServicio.TabIndex = 1
        '
        'NRTFSV
        '
        Me.NRTFSV.DataPropertyName = "NRTFSV"
        Me.NRTFSV.HeaderText = "Tarifa"
        Me.NRTFSV.Name = "NRTFSV"
        Me.NRTFSV.ReadOnly = True
        Me.NRTFSV.Width = 66
        '
        'DESTAR
        '
        Me.DESTAR.DataPropertyName = "DESTAR"
        Me.DESTAR.HeaderText = "Servicio"
        Me.DESTAR.Name = "DESTAR"
        Me.DESTAR.ReadOnly = True
        Me.DESTAR.Width = 77
        '
        'VALCTE
        '
        Me.VALCTE.DataPropertyName = "VALCTE"
        Me.VALCTE.HeaderText = "Valor"
        Me.VALCTE.Name = "VALCTE"
        Me.VALCTE.ReadOnly = True
        Me.VALCTE.Width = 63
        '
        'CUNDMD
        '
        Me.CUNDMD.DataPropertyName = "CUNDMD"
        Me.CUNDMD.HeaderText = "Unidad"
        Me.CUNDMD.Name = "CUNDMD"
        Me.CUNDMD.ReadOnly = True
        Me.CUNDMD.Width = 74
        '
        'QATNAN
        '
        Me.QATNAN.DataPropertyName = "QATNAN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.QATNAN.DefaultCellStyle = DataGridViewCellStyle1
        Me.QATNAN.HeaderText = "Cant. Atendida"
        Me.QATNAN.MaxInputLength = 15
        Me.QATNAN.Name = "QATNAN"
        Me.QATNAN.ReadOnly = True
        Me.QATNAN.Width = 115
        '
        'TSGNMN
        '
        Me.TSGNMN.DataPropertyName = "TSGNMN"
        Me.TSGNMN.HeaderText = "Moneda"
        Me.TSGNMN.Name = "TSGNMN"
        Me.TSGNMN.ReadOnly = True
        Me.TSGNMN.Width = 80
        '
        'CCNTCS
        '
        Me.CCNTCS.DataPropertyName = "CCNTCS"
        Me.CCNTCS.HeaderText = "Centro de Costo"
        Me.CCNTCS.Name = "CCNTCS"
        Me.CCNTCS.ReadOnly = True
        Me.CCNTCS.Width = 122
        '
        'IVLSRV
        '
        Me.IVLSRV.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.IVLSRV.DefaultCellStyle = DataGridViewCellStyle2
        Me.IVLSRV.HeaderText = "Importe Valor Servicio"
        Me.IVLSRV.Name = "IVLSRV"
        Me.IVLSRV.ReadOnly = True
        Me.IVLSRV.Width = 152
        '
        'NOPRCN
        '
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "NOPRCN"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Visible = False
        Me.NOPRCN.Width = 81
        '
        'NCRROP
        '
        Me.NCRROP.DataPropertyName = "NCRROP"
        Me.NCRROP.HeaderText = "NCRROP"
        Me.NCRROP.Name = "NCRROP"
        Me.NCRROP.ReadOnly = True
        Me.NCRROP.Visible = False
        Me.NCRROP.Width = 80
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.AutoSize = False
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblServicios, Me.btnEliminar, Me.tssSep_01, Me.btnAgregar, Me.cmbServicio})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(760, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'lblServicios
        '
        Me.lblServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicios.Name = "lblServicios"
        Me.lblServicios.Size = New System.Drawing.Size(59, 22)
        Me.lblServicios.Text = "Servicios"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.ToolTipText = "Eliminar Servicio"
        '
        'tssSep_01
        '
        Me.tssSep_01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_01.Name = "tssSep_01"
        Me.tssSep_01.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.edit_add
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.ToolTipText = "Registrar Servicio al Cliente"
        '
        'cmbServicio
        '
        Me.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicio.DropDownWidth = 500
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(340, 25)
        '
        'dtgBultos_Dinamico
        '
        Me.dtgBultos_Dinamico.AllowUserToAddRows = False
        Me.dtgBultos_Dinamico.AllowUserToDeleteRows = False
        Me.dtgBultos_Dinamico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgBultos_Dinamico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBultos_Dinamico.Location = New System.Drawing.Point(0, 25)
        Me.dtgBultos_Dinamico.Name = "dtgBultos_Dinamico"
        Me.dtgBultos_Dinamico.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBultos_Dinamico.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgBultos_Dinamico.Size = New System.Drawing.Size(760, 110)
        Me.dtgBultos_Dinamico.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgBultos_Dinamico.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cmbFormaTarifa, Me.lblPeso, Me.txtPeso, Me.ToolStripSeparator1, Me.lblVolumen, Me.txtVolumen, Me.ToolStripSeparator2, Me.lblArea, Me.txtArea})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(760, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripLabel1.Text = "Tarifar Segun el :"
        '
        'cmbFormaTarifa
        '
        Me.cmbFormaTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormaTarifa.Name = "cmbFormaTarifa"
        Me.cmbFormaTarifa.Size = New System.Drawing.Size(170, 25)
        '
        'lblPeso
        '
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(38, 22)
        Me.lblPeso.Text = "Peso :"
        '
        'txtPeso
        '
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 25)
        Me.txtPeso.Text = "0"
        Me.txtPeso.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblVolumen
        '
        Me.lblVolumen.Name = "lblVolumen"
        Me.lblVolumen.Size = New System.Drawing.Size(73, 22)
        Me.lblVolumen.Text = "    Volumen :"
        '
        'txtVolumen
        '
        Me.txtVolumen.Name = "txtVolumen"
        Me.txtVolumen.Size = New System.Drawing.Size(100, 25)
        Me.txtVolumen.Text = "0"
        Me.txtVolumen.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lblArea
        '
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(52, 22)
        Me.lblArea.Text = "    Area : "
        '
        'txtArea
        '
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 25)
        Me.txtArea.Text = "0"
        Me.txtArea.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'hgTitulo
        '
        Me.hgTitulo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnGuardar, Me.btnCancelar})
        Me.hgTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgTitulo.HeaderVisibleSecondary = False
        Me.hgTitulo.Location = New System.Drawing.Point(0, 0)
        Me.hgTitulo.Name = "hgTitulo"
        '
        'hgTitulo.Panel
        '
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel8)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgTitulo.Panel.Controls.Add(Me.cmbZona)
        Me.hgTitulo.Panel.Controls.Add(Me.cmbAlmacen)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel7)
        Me.hgTitulo.Panel.Controls.Add(Me.cmbTipoAlmacen)
        Me.hgTitulo.Panel.Controls.Add(Me.btnCalcularProm)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgTitulo.Panel.Controls.Add(Me.dtFechaSalida)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgTitulo.Panel.Controls.Add(Me.dtFechaRecepcion)
        Me.hgTitulo.Panel.Controls.Add(Me.lblFechaOperacion)
        Me.hgTitulo.Panel.Controls.Add(Me.dteFechaOperacion)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgTitulo.Panel.Controls.Add(Me.cmbUnidadMedida)
        Me.hgTitulo.Panel.Controls.Add(Me.lblPlanta)
        Me.hgTitulo.Panel.Controls.Add(Me.txtMontoTotal)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgTitulo.Panel.Controls.Add(Me.ucClienteFacturar)
        Me.hgTitulo.Panel.Controls.Add(Me.cmbPlanta)
        Me.hgTitulo.Panel.Controls.Add(Me.lblClienteFact)
        Me.hgTitulo.Panel.Controls.Add(Me.UcClienteOperacion)
        Me.hgTitulo.Panel.Controls.Add(Me.KryptonLabel6)
        Me.hgTitulo.Size = New System.Drawing.Size(762, 210)
        Me.hgTitulo.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgTitulo.TabIndex = 0
        Me.hgTitulo.Text = " "
        Me.hgTitulo.ValuesPrimary.Description = " "
        Me.hgTitulo.ValuesPrimary.Heading = " "
        Me.hgTitulo.ValuesPrimary.Image = Nothing
        Me.hgTitulo.ValuesSecondary.Description = ""
        Me.hgTitulo.ValuesSecondary.Heading = "Description"
        Me.hgTitulo.ValuesSecondary.Image = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.save_all
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.ToolTipTitle = "Guardar"
        Me.btnGuardar.UniqueName = "B05B66968A27484AB05B66968A27484A"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.salir
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.ToolTipStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip
        Me.btnCancelar.ToolTipTitle = "Cancelar"
        Me.btnCancelar.UniqueName = "96C39D3CA1D348A696C39D3CA1D348A6"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(11, 115)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel8.TabIndex = 18
        Me.KryptonLabel8.Text = "Zona : "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Zona : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(359, 89)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel5.TabIndex = 16
        Me.KryptonLabel5.Text = "Almacen : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Almacen : "
        '
        'cmbZona
        '
        Me.cmbZona.CheckOnClick = True
        Me.cmbZona.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbZona.DropDownHeight = 1
        Me.cmbZona.FormattingEnabled = True
        Me.cmbZona.IntegralHeight = False
        Me.cmbZona.Location = New System.Drawing.Point(119, 115)
        Me.cmbZona.Name = "cmbZona"
        Me.cmbZona.Size = New System.Drawing.Size(232, 21)
        Me.cmbZona.TabIndex = 19
        Me.cmbZona.ValueSeparator = ", "
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.CheckOnClick = True
        Me.cmbAlmacen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbAlmacen.DropDownHeight = 1
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.IntegralHeight = False
        Me.cmbAlmacen.Location = New System.Drawing.Point(462, 89)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(234, 21)
        Me.cmbAlmacen.TabIndex = 17
        Me.cmbAlmacen.ValueSeparator = ", "
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(11, 92)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel7.TabIndex = 14
        Me.KryptonLabel7.Text = "Tipo Almacen : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Tipo Almacen : "
        '
        'cmbTipoAlmacen
        '
        Me.cmbTipoAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoAlmacen.DropDownWidth = 226
        Me.cmbTipoAlmacen.FormattingEnabled = False
        Me.cmbTipoAlmacen.ItemHeight = 15
        Me.cmbTipoAlmacen.Location = New System.Drawing.Point(119, 89)
        Me.cmbTipoAlmacen.Name = "cmbTipoAlmacen"
        Me.cmbTipoAlmacen.Size = New System.Drawing.Size(232, 23)
        Me.cmbTipoAlmacen.TabIndex = 15
        '
        'btnCalcularProm
        '
        Me.btnCalcularProm.Location = New System.Drawing.Point(641, 115)
        Me.btnCalcularProm.Name = "btnCalcularProm"
        Me.btnCalcularProm.Size = New System.Drawing.Size(55, 34)
        Me.btnCalcularProm.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularProm.TabIndex = 20
        Me.btnCalcularProm.Text = "Calcular " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datos"
        Me.ToolTip1.SetToolTip(Me.btnCalcularProm, "Calculo de Pesos/Volumen/Area")
        Me.btnCalcularProm.Values.ExtraText = ""
        Me.btnCalcularProm.Values.Image = Nothing
        Me.btnCalcularProm.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCalcularProm.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCalcularProm.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCalcularProm.Values.Text = "Calcular " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datos"
        Me.btnCalcularProm.Visible = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(216, 61)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(47, 20)
        Me.KryptonLabel4.TabIndex = 10
        Me.KryptonLabel4.Text = "Hasta : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Hasta : "
        '
        'dtFechaSalida
        '
        Me.dtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaSalida.Location = New System.Drawing.Point(266, 61)
        Me.dtFechaSalida.Name = "dtFechaSalida"
        Me.dtFechaSalida.Size = New System.Drawing.Size(86, 20)
        Me.dtFechaSalida.TabIndex = 11
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 61)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(114, 20)
        Me.KryptonLabel3.TabIndex = 8
        Me.KryptonLabel3.Text = "Rango Fechas  De :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Rango Fechas  De :"
        '
        'dtFechaRecepcion
        '
        Me.dtFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaRecepcion.Location = New System.Drawing.Point(119, 61)
        Me.dtFechaRecepcion.Name = "dtFechaRecepcion"
        Me.dtFechaRecepcion.Size = New System.Drawing.Size(87, 20)
        Me.dtFechaRecepcion.TabIndex = 9
        '
        'lblFechaOperacion
        '
        Me.lblFechaOperacion.Location = New System.Drawing.Point(359, 7)
        Me.lblFechaOperacion.Name = "lblFechaOperacion"
        Me.lblFechaOperacion.Size = New System.Drawing.Size(48, 20)
        Me.lblFechaOperacion.TabIndex = 2
        Me.lblFechaOperacion.Text = "Fecha : "
        Me.lblFechaOperacion.Values.ExtraText = ""
        Me.lblFechaOperacion.Values.Image = Nothing
        Me.lblFechaOperacion.Values.Text = "Fecha : "
        '
        'dteFechaOperacion
        '
        Me.dteFechaOperacion.Enabled = False
        Me.dteFechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaOperacion.Location = New System.Drawing.Point(462, 7)
        Me.dteFechaOperacion.Name = "dteFechaOperacion"
        Me.dteFechaOperacion.Size = New System.Drawing.Size(99, 20)
        Me.dteFechaOperacion.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(359, 62)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel1.TabIndex = 12
        Me.KryptonLabel1.Text = "Unidad : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Unidad : "
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidadMedida.DropDownWidth = 226
        Me.cmbUnidadMedida.FormattingEnabled = False
        Me.cmbUnidadMedida.ItemHeight = 15
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(462, 62)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(234, 23)
        Me.cmbUnidadMedida.TabIndex = 13
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(11, 7)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(50, 20)
        Me.lblPlanta.TabIndex = 0
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(119, 141)
        Me.txtMontoTotal.MaxLength = 15
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.ReadOnly = True
        Me.txtMontoTotal.Size = New System.Drawing.Size(87, 22)
        Me.txtMontoTotal.TabIndex = 22
        Me.txtMontoTotal.Text = "0"
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 143)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel2.TabIndex = 21
        Me.KryptonLabel2.Text = "Monto Total:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Monto Total:"
        '
        'ucClienteFacturar
        '
        Me.ucClienteFacturar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucClienteFacturar.BackColor = System.Drawing.Color.Transparent
        Me.ucClienteFacturar.Location = New System.Drawing.Point(462, 34)
        Me.ucClienteFacturar.Name = "ucClienteFacturar"
        Me.ucClienteFacturar.pAccesoPorUsuario = False
        Me.ucClienteFacturar.pRequerido = True
        Me.ucClienteFacturar.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.ucClienteFacturar.Size = New System.Drawing.Size(234, 22)
        Me.ucClienteFacturar.TabIndex = 7
        '
        'cmbPlanta
        '
        Me.cmbPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlanta.Enabled = False
        Me.cmbPlanta.FormattingEnabled = True
        Me.cmbPlanta.Location = New System.Drawing.Point(119, 7)
        Me.cmbPlanta.Name = "cmbPlanta"
        Me.cmbPlanta.Size = New System.Drawing.Size(233, 21)
        Me.cmbPlanta.TabIndex = 1
        '
        'lblClienteFact
        '
        Me.lblClienteFact.Location = New System.Drawing.Point(359, 36)
        Me.lblClienteFact.Name = "lblClienteFact"
        Me.lblClienteFact.Size = New System.Drawing.Size(111, 20)
        Me.lblClienteFact.TabIndex = 6
        Me.lblClienteFact.Text = "Cliente a Facturar :"
        Me.lblClienteFact.Values.ExtraText = ""
        Me.lblClienteFact.Values.Image = Nothing
        Me.lblClienteFact.Values.Text = "Cliente a Facturar :"
        '
        'UcClienteOperacion
        '
        Me.UcClienteOperacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteOperacion.BackColor = System.Drawing.Color.Transparent
        Me.UcClienteOperacion.Enabled = False
        Me.UcClienteOperacion.Location = New System.Drawing.Point(119, 34)
        Me.UcClienteOperacion.Name = "UcClienteOperacion"
        Me.UcClienteOperacion.pAccesoPorUsuario = False
        Me.UcClienteOperacion.pRequerido = True
        Me.UcClienteOperacion.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.UcClienteOperacion.Size = New System.Drawing.Size(233, 22)
        Me.UcClienteOperacion.TabIndex = 5
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(11, 34)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(114, 20)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Text = "Cliente Operación :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Cliente Operación :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRTFSV"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tarifa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 66
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DESTAR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "VALCTE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Valor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 63
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CUNDMD"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QATNAN"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cant. Atendida"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 15
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 115
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TSGNMN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CCNTCS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Centro de Costo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 122
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe Valor Servicio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 152
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NOPRCN"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 85
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NCRROP"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NCRROP"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 83
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TEDESC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Column3"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Column4"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Column5"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Column6"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Column7"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Column8"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Column9"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Column10"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Column11"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Column12"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Column13"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Column14"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Column15"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Column16"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "Column17"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "Column18"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "Column19"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "Column20"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "Column21"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "Column22"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "Column23"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.HeaderText = "Column24"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.HeaderText = "Column25"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.HeaderText = "Column26"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.HeaderText = "Column27"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.HeaderText = "Column28"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.HeaderText = "Column29"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.HeaderText = "Column30"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.HeaderText = "Column31"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.HeaderText = "Promedio"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.HeaderText = "Maximo"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.HeaderText = "Minimo"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'frmServEspPorPromedio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 535)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmServEspPorPromedio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicio de Almacenaje x Promedios"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer2.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.dgServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dtgBultos_Dinamico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.hgTitulo.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTitulo.Panel.ResumeLayout(False)
        Me.hgTitulo.Panel.PerformLayout()
        CType(Me.hgTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgTitulo.ResumeLayout(False)
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
    Friend WithEvents hgTitulo As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents cmbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents UcClienteOperacion As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblClienteFact As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents ucClienteFacturar As Ransa.Controls.Cliente.ucCliente_TxtF01
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dgServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents lblServicios As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_01 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbServicio As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMontoTotal As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbUnidadMedida As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
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
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dtFechaSalida As System.Windows.Forms.DateTimePicker
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dtFechaRecepcion As System.Windows.Forms.DateTimePicker
    Private WithEvents lblFechaOperacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents dteFechaOperacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgBultos_Dinamico As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblPeso As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtPeso As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblVolumen As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtVolumen As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblArea As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtArea As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCalcularProm As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbFormaTarifa As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbZona As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents cmbAlmacen As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Private WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Private WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NRTFSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALCTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNDMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QATNAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSGNMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVLSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRROP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
