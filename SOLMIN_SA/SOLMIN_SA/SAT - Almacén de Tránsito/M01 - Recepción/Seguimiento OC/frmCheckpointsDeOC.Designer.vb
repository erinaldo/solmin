<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckpointsDeOC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckpointsDeOC))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dgOrdenesCompras = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.M_NORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaOrdenDeCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDSCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDEFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TTINTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NREFCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_REFDO1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_NTPDES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVCOTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOCO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOIM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacion2 = New Ransa.Utilitario.UCPaginacion
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tssExportarExcel = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAnular = New System.Windows.Forms.ToolStripButton
        Me.tssAnular = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorEliminar = New System.Windows.Forms.ToolStripSeparator
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorNuevo = New System.Windows.Forms.ToolStripSeparator
        Me.tslblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.Modulo01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Modulo02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabDetalle = New System.Windows.Forms.TabControl
        Me.tabDetalleOc = New System.Windows.Forms.TabPage
        Me.dgItemOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.tsbAnularItems = New System.Windows.Forms.ToolStripButton
        Me.tssAnularItems = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminarCheckpoint = New System.Windows.Forms.ToolStripButton
        Me.tssElimininarCheckpoint = New System.Windows.Forms.ToolStripSeparator
        Me.tslblDetalleTitulo = New System.Windows.Forms.ToolStripLabel
        Me.tsbPuntoDeControl = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorPuntoDeControl = New System.Windows.Forms.ToolStripSeparator
        Me.btnMarcarItems = New System.Windows.Forms.ToolStripButton
        Me.btnEnSeguimiento = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadoEnSeguimiento = New System.Windows.Forms.ToolStripSeparator
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaStatusOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbTipoOc = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.chkFechaOc = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.lblOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaOrdenCompraLimpiar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.NRITOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.M_NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCITPR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FLGPEN = New System.Windows.Forms.DataGridViewImageColumn
        Me.BITACORA = New System.Windows.Forms.DataGridViewImageColumn
        Me.M_TDITIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_CPTDAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNTIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TUNDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QCNPEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVUNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_IVTOIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTOLMAX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_QTOLMIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FMPDME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_FMPIME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TLUGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.M_TCTCST = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.dgOrdenesCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspListadoMercaderia.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.tabDetalleOc.SuspendLayout()
        CType(Me.dgItemOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        'CType(Me.cmbTipoOc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(961, 584)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 148)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dgOrdenesCompras)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.UcPaginacion2)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.tspListadoMercaderia)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.TabDetalle)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(961, 436)
        Me.KryptonSplitContainer1.SplitterDistance = 206
        Me.KryptonSplitContainer1.TabIndex = 81
        '
        'dgOrdenesCompras
        '
        Me.dgOrdenesCompras.AllowUserToAddRows = False
        Me.dgOrdenesCompras.AllowUserToDeleteRows = False
        Me.dgOrdenesCompras.AllowUserToResizeColumns = False
        Me.dgOrdenesCompras.AllowUserToResizeRows = False
        Me.dgOrdenesCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOrdenesCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgOrdenesCompras.ColumnHeadersHeight = 40
        Me.dgOrdenesCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NORCML, Me.FechaOrdenDeCompra, Me.M_TPRVCL, Me.M_NRUCPR, Me.M_TDSCML, Me.M_TDEFIN, Me.M_CMNDA1, Me.M_TTINTC, Me.M_NREFCL, Me.M_REFDO1, Me.M_NTPDES, Me.M_IVCOTO, Me.M_IVTOCO, Me.M_IVTOIM, Me.M_SESTRG})
        Me.dgOrdenesCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenesCompras.Location = New System.Drawing.Point(0, 25)
        Me.dgOrdenesCompras.MultiSelect = False
        Me.dgOrdenesCompras.Name = "dgOrdenesCompras"
        Me.dgOrdenesCompras.ReadOnly = True
        Me.dgOrdenesCompras.RowHeadersWidth = 20
        Me.dgOrdenesCompras.RowTemplate.ReadOnly = True
        Me.dgOrdenesCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgOrdenesCompras.Size = New System.Drawing.Size(961, 158)
        Me.dgOrdenesCompras.StandardTab = True
        Me.dgOrdenesCompras.TabIndex = 79
        '
        'M_NORCML
        '
        Me.M_NORCML.DataPropertyName = "PSNORCML"
        Me.M_NORCML.HeaderText = "Orden Compra"
        Me.M_NORCML.Name = "M_NORCML"
        Me.M_NORCML.ReadOnly = True
        Me.M_NORCML.Width = 103
        '
        'FechaOrdenDeCompra
        '
        Me.FechaOrdenDeCompra.DataPropertyName = "FechaOrdenDeCompra"
        Me.FechaOrdenDeCompra.HeaderText = "Fecha"
        Me.FechaOrdenDeCompra.Name = "FechaOrdenDeCompra"
        Me.FechaOrdenDeCompra.ReadOnly = True
        Me.FechaOrdenDeCompra.Width = 66
        '
        'M_TPRVCL
        '
        Me.M_TPRVCL.DataPropertyName = "PSTPRVCL"
        Me.M_TPRVCL.HeaderText = "Proveedor"
        Me.M_TPRVCL.Name = "M_TPRVCL"
        Me.M_TPRVCL.ReadOnly = True
        Me.M_TPRVCL.Width = 88
        '
        'M_NRUCPR
        '
        Me.M_NRUCPR.DataPropertyName = "PSNRUCPR"
        Me.M_NRUCPR.HeaderText = "RUC Proveedor"
        Me.M_NRUCPR.Name = "M_NRUCPR"
        Me.M_NRUCPR.ReadOnly = True
        Me.M_NRUCPR.Visible = False
        Me.M_NRUCPR.Width = 104
        '
        'M_TDSCML
        '
        Me.M_TDSCML.DataPropertyName = "PSTDSCML"
        Me.M_TDSCML.HeaderText = "Descripción"
        Me.M_TDSCML.Name = "M_TDSCML"
        Me.M_TDSCML.ReadOnly = True
        Me.M_TDSCML.Width = 96
        '
        'M_TDEFIN
        '
        Me.M_TDEFIN.DataPropertyName = "PSTDEFIN"
        Me.M_TDEFIN.HeaderText = "Destino Final"
        Me.M_TDEFIN.Name = "M_TDEFIN"
        Me.M_TDEFIN.ReadOnly = True
        Me.M_TDEFIN.Width = 96
        '
        'M_CMNDA1
        '
        Me.M_CMNDA1.DataPropertyName = "PSTMNDA"
        Me.M_CMNDA1.HeaderText = "Moneda"
        Me.M_CMNDA1.Name = "M_CMNDA1"
        Me.M_CMNDA1.ReadOnly = True
        Me.M_CMNDA1.Width = 79
        '
        'M_TTINTC
        '
        Me.M_TTINTC.DataPropertyName = "PSTTINTC"
        Me.M_TTINTC.HeaderText = "Term. Inter."
        Me.M_TTINTC.Name = "M_TTINTC"
        Me.M_TTINTC.ReadOnly = True
        Me.M_TTINTC.Width = 86
        '
        'M_NREFCL
        '
        Me.M_NREFCL.DataPropertyName = "PSNREFCL"
        Me.M_NREFCL.HeaderText = "Referencia Cliente"
        Me.M_NREFCL.Name = "M_NREFCL"
        Me.M_NREFCL.ReadOnly = True
        Me.M_NREFCL.Width = 119
        '
        'M_REFDO1
        '
        Me.M_REFDO1.DataPropertyName = "PSREFDO1"
        Me.M_REFDO1.HeaderText = "Ref. Documento"
        Me.M_REFDO1.Name = "M_REFDO1"
        Me.M_REFDO1.ReadOnly = True
        Me.M_REFDO1.Width = 110
        '
        'M_NTPDES
        '
        Me.M_NTPDES.DataPropertyName = "PSPRIORIDAD"
        Me.M_NTPDES.HeaderText = "Prioridad"
        Me.M_NTPDES.Name = "M_NTPDES"
        Me.M_NTPDES.ReadOnly = True
        Me.M_NTPDES.Width = 83
        '
        'M_IVCOTO
        '
        Me.M_IVCOTO.DataPropertyName = "PNIVCOTO"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.M_IVCOTO.DefaultCellStyle = DataGridViewCellStyle1
        Me.M_IVCOTO.HeaderText = "Costo Total"
        Me.M_IVCOTO.Name = "M_IVCOTO"
        Me.M_IVCOTO.ReadOnly = True
        Me.M_IVCOTO.Width = 87
        '
        'M_IVTOCO
        '
        Me.M_IVTOCO.DataPropertyName = "PNIVTOCO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.M_IVTOCO.DefaultCellStyle = DataGridViewCellStyle2
        Me.M_IVTOCO.HeaderText = "Costo Compra"
        Me.M_IVTOCO.Name = "M_IVTOCO"
        Me.M_IVTOCO.ReadOnly = True
        Me.M_IVTOCO.Width = 101
        '
        'M_IVTOIM
        '
        Me.M_IVTOIM.DataPropertyName = "PNIVTOIM"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.M_IVTOIM.DefaultCellStyle = DataGridViewCellStyle3
        Me.M_IVTOIM.HeaderText = "Impuesto"
        Me.M_IVTOIM.Name = "M_IVTOIM"
        Me.M_IVTOIM.ReadOnly = True
        Me.M_IVTOIM.Width = 84
        '
        'M_SESTRG
        '
        Me.M_SESTRG.DataPropertyName = "PSSESTRG"
        Me.M_SESTRG.HeaderText = "Situación"
        Me.M_SESTRG.Name = "M_SESTRG"
        Me.M_SESTRG.ReadOnly = True
        Me.M_SESTRG.Width = 84
        '
        'UcPaginacion2
        '
        Me.UcPaginacion2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion2.Location = New System.Drawing.Point(0, 183)
        Me.UcPaginacion2.Name = "UcPaginacion2"
        Me.UcPaginacion2.PageCount = 0
        Me.UcPaginacion2.PageNumber = 1
        Me.UcPaginacion2.PageSize = 20
        Me.UcPaginacion2.Size = New System.Drawing.Size(961, 23)
        Me.UcPaginacion2.TabIndex = 81
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.tssExportarExcel, Me.tsbAnular, Me.tssAnular, Me.tsbEliminar, Me.tssSeparadorEliminar, Me.tsbNuevo, Me.tssSeparadorNuevo, Me.tslblTitulo, Me.ToolStripSplitButton1})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(961, 25)
        Me.tspListadoMercaderia.TabIndex = 80
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(189, 22)
        Me.tsbExportarExcel.Text = "Reporte Seguimiento OC Local"
        Me.tsbExportarExcel.ToolTipText = "Exportar a  excel  orden de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " compra pendientes de entrega"
        Me.tsbExportarExcel.Visible = False
        '
        'tssExportarExcel
        '
        Me.tssExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssExportarExcel.Name = "tssExportarExcel"
        Me.tssExportarExcel.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAnular
        '
        Me.tsbAnular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnular.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnular.Name = "tsbAnular"
        Me.tsbAnular.Size = New System.Drawing.Size(62, 22)
        Me.tsbAnular.Text = "Anular"
        Me.tsbAnular.Visible = False
        '
        'tssAnular
        '
        Me.tssAnular.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssAnular.Name = "tssAnular"
        Me.tssAnular.Size = New System.Drawing.Size(6, 25)
        Me.tssAnular.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tssSeparadorEliminar
        '
        Me.tssSeparadorEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorEliminar.Name = "tssSeparadorEliminar"
        Me.tssSeparadorEliminar.Size = New System.Drawing.Size(6, 25)
        Me.tssSeparadorEliminar.Visible = False
        '
        'tsbNuevo
        '
        Me.tsbNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbNuevo.Image = Global.SOLMIN_SA.My.Resources.Resources.db_add
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(62, 22)
        Me.tsbNuevo.Text = "Nuevo"
        Me.tsbNuevo.Visible = False
        '
        'tssSeparadorNuevo
        '
        Me.tssSeparadorNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorNuevo.Name = "tssSeparadorNuevo"
        Me.tssSeparadorNuevo.Size = New System.Drawing.Size(6, 25)
        Me.tssSeparadorNuevo.Visible = False
        '
        'tslblTitulo
        '
        Me.tslblTitulo.Name = "tslblTitulo"
        Me.tslblTitulo.Size = New System.Drawing.Size(141, 22)
        Me.tslblTitulo.Text = "Lista de Orden de Compra"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Modulo01ToolStripMenuItem, Me.Modulo02ToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripSplitButton1.Text = "Reporte "
        '
        'Modulo01ToolStripMenuItem
        '
        Me.Modulo01ToolStripMenuItem.Name = "Modulo01ToolStripMenuItem"
        Me.Modulo01ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.Modulo01ToolStripMenuItem.Text = "Modelo 01"
        '
        'Modulo02ToolStripMenuItem
        '
        Me.Modulo02ToolStripMenuItem.Name = "Modulo02ToolStripMenuItem"
        Me.Modulo02ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.Modulo02ToolStripMenuItem.Text = "Modelo 02"
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.tabDetalleOc)
        Me.TabDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDetalle.Location = New System.Drawing.Point(0, 25)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.SelectedIndex = 0
        Me.TabDetalle.Size = New System.Drawing.Size(961, 200)
        Me.TabDetalle.TabIndex = 78
        '
        'tabDetalleOc
        '
        Me.tabDetalleOc.Controls.Add(Me.dgItemOC)
        Me.tabDetalleOc.Controls.Add(Me.UcPaginacion1)
        Me.tabDetalleOc.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalleOc.Name = "tabDetalleOc"
        Me.tabDetalleOc.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalleOc.Size = New System.Drawing.Size(953, 174)
        Me.tabDetalleOc.TabIndex = 0
        Me.tabDetalleOc.Text = "Items"
        Me.tabDetalleOc.UseVisualStyleBackColor = True
        '
        'dgItemOC
        '
        Me.dgItemOC.AllowUserToAddRows = False
        Me.dgItemOC.AllowUserToDeleteRows = False
        Me.dgItemOC.ColumnHeadersHeight = 40
        Me.dgItemOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_CHK, Me.M_NRITOC, Me.M_TCITCL, Me.M_TCITPR, Me.M_TDITES, Me.FLGPEN, Me.BITACORA, Me.M_TDITIN, Me.M_CPTDAR, Me.M_QCNTIT, Me.M_TUNDIT, Me.M_QCNPEN, Me.M_IVUNIT, Me.M_IVTOIT, Me.M_QTOLMAX, Me.M_QTOLMIN, Me.M_FMPDME, Me.M_FMPIME, Me.M_TLUGOR, Me.M_TLUGEN, Me.M_TCTCST})
        Me.dgItemOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgItemOC.Location = New System.Drawing.Point(3, 3)
        Me.dgItemOC.MultiSelect = False
        Me.dgItemOC.Name = "dgItemOC"
        Me.dgItemOC.RowHeadersWidth = 20
        Me.dgItemOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgItemOC.Size = New System.Drawing.Size(947, 145)
        Me.dgItemOC.TabIndex = 27
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(3, 148)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(947, 23)
        Me.UcPaginacion1.TabIndex = 26
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAnularItems, Me.tssAnularItems, Me.tsbEliminarCheckpoint, Me.tssElimininarCheckpoint, Me.tslblDetalleTitulo, Me.tsbPuntoDeControl, Me.tssSeparadorPuntoDeControl, Me.btnMarcarItems, Me.btnEnSeguimiento, Me.tssSeparadoEnSeguimiento})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(961, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 79
        Me.tsMenuOpcionesDetalle.Text = "Detalle Guía de Remisión"
        '
        'tsbAnularItems
        '
        Me.tsbAnularItems.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAnularItems.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.tsbAnularItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAnularItems.Name = "tsbAnularItems"
        Me.tsbAnularItems.Size = New System.Drawing.Size(94, 22)
        Me.tsbAnularItems.Text = "Anular Items"
        Me.tsbAnularItems.Visible = False
        '
        'tssAnularItems
        '
        Me.tssAnularItems.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssAnularItems.Name = "tssAnularItems"
        Me.tssAnularItems.Size = New System.Drawing.Size(6, 25)
        Me.tssAnularItems.Visible = False
        '
        'tsbEliminarCheckpoint
        '
        Me.tsbEliminarCheckpoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminarCheckpoint.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.tsbEliminarCheckpoint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarCheckpoint.Name = "tsbEliminarCheckpoint"
        Me.tsbEliminarCheckpoint.Size = New System.Drawing.Size(70, 22)
        Me.tsbEliminarCheckpoint.Text = "Eliminar"
        Me.tsbEliminarCheckpoint.Visible = False
        '
        'tssElimininarCheckpoint
        '
        Me.tssElimininarCheckpoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssElimininarCheckpoint.Name = "tssElimininarCheckpoint"
        Me.tssElimininarCheckpoint.Size = New System.Drawing.Size(6, 25)
        Me.tssElimininarCheckpoint.Visible = False
        '
        'tslblDetalleTitulo
        '
        Me.tslblDetalleTitulo.Name = "tslblDetalleTitulo"
        Me.tslblDetalleTitulo.Size = New System.Drawing.Size(76, 22)
        Me.tslblDetalleTitulo.Text = "Lista de Items"
        '
        'tsbPuntoDeControl
        '
        Me.tsbPuntoDeControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbPuntoDeControl.Image = Global.SOLMIN_SA.My.Resources.Resources.PuntoDeContol
        Me.tsbPuntoDeControl.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPuntoDeControl.Name = "tsbPuntoDeControl"
        Me.tsbPuntoDeControl.Size = New System.Drawing.Size(124, 22)
        Me.tsbPuntoDeControl.Text = "Editar Checkpoints"
        '
        'tssSeparadorPuntoDeControl
        '
        Me.tssSeparadorPuntoDeControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorPuntoDeControl.Name = "tssSeparadorPuntoDeControl"
        Me.tssSeparadorPuntoDeControl.Size = New System.Drawing.Size(6, 25)
        '
        'btnMarcarItems
        '
        Me.btnMarcarItems.BackgroundImage = CType(resources.GetObject("btnMarcarItems.BackgroundImage"), System.Drawing.Image)
        Me.btnMarcarItems.CheckOnClick = True
        Me.btnMarcarItems.Image = CType(resources.GetObject("btnMarcarItems.Image"), System.Drawing.Image)
        Me.btnMarcarItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMarcarItems.Name = "btnMarcarItems"
        Me.btnMarcarItems.Size = New System.Drawing.Size(99, 22)
        Me.btnMarcarItems.Text = " &Marcar Todos"
        '
        'btnEnSeguimiento
        '
        Me.btnEnSeguimiento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEnSeguimiento.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnEnSeguimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnSeguimiento.Name = "btnEnSeguimiento"
        Me.btnEnSeguimiento.Size = New System.Drawing.Size(190, 22)
        Me.btnEnSeguimiento.Text = "Cambiar estado de seguimiento"
        '
        'tssSeparadoEnSeguimiento
        '
        Me.tssSeparadoEnSeguimiento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadoEnSeguimiento.Name = "tssSeparadoEnSeguimiento"
        Me.tssSeparadoEnSeguimiento.Size = New System.Drawing.Size(6, 25)
        '
        'hgFiltros
        '
        Me.hgFiltros.AutoSize = True
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaStatusOcultarFiltros, Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel6)
        Me.hgFiltros.Panel.Controls.Add(Me.cmbTipoOc)
        Me.hgFiltros.Panel.Controls.Add(Me.chkFechaOc)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgFiltros.Panel.Controls.Add(Me.dteFechaInicial)
        Me.hgFiltros.Panel.Controls.Add(Me.dteFechaFinal)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgFiltros.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.hgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.txtProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.hgFiltros.Panel.Controls.Add(Me.txtFechaFinal)
        Me.hgFiltros.Panel.Controls.Add(Me.lblOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.txtOrdenCompra)
        Me.hgFiltros.Panel.Controls.Add(Me.lblCliente)
        Me.hgFiltros.Panel.Controls.Add(Me.lblProveedor)
        Me.hgFiltros.Panel.Controls.Add(Me.KryptonLabel5)
        Me.hgFiltros.Size = New System.Drawing.Size(961, 148)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 1
        Me.hgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        '
        'bsaStatusOcultarFiltros
        '
        Me.bsaStatusOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaStatusOcultarFiltros.Text = "Ocultar"
        Me.bsaStatusOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaStatusOcultarFiltros.UniqueName = "035391BBFC7044C3035391BBFC7044C3"
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "EC0877FED5AD46CBEC0877FED5AD46CB"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(7, 97)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel6.TabIndex = 63
        Me.KryptonLabel6.Values.Text = "Tipo O/C : "
        '
        'cmbTipoOc
        '
        Me.cmbTipoOc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoOc.DropDownWidth = 121
        Me.cmbTipoOc.Location = New System.Drawing.Point(81, 89)
        Me.cmbTipoOc.Name = "cmbTipoOc"
        Me.cmbTipoOc.Size = New System.Drawing.Size(253, 22)
        Me.cmbTipoOc.TabIndex = 62
        '
        'chkFechaOc
        '
        Me.chkFechaOc.Checked = True
        Me.chkFechaOc.CheckPosition = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.chkFechaOc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFechaOc.Location = New System.Drawing.Point(336, 64)
        Me.chkFechaOc.Name = "chkFechaOc"
        Me.chkFechaOc.Size = New System.Drawing.Size(96, 19)
        Me.chkFechaOc.TabIndex = 61
        Me.chkFechaOc.Values.Text = "Fecha de O/C :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(545, 64)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(37, 19)
        Me.KryptonLabel4.TabIndex = 60
        Me.KryptonLabel4.Values.Text = "hasta"
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(452, 63)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.dteFechaInicial.TabIndex = 57
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(588, 64)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(99, 20)
        Me.dteFechaFinal.TabIndex = 58
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(694, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(47, 19)
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Values.Text = "Planta : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(366, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(55, 19)
        Me.KryptonLabel2.TabIndex = 56
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 19)
        Me.KryptonLabel1.TabIndex = 55
        Me.KryptonLabel1.Values.Text = "Compañia : "
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(748, 9)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = False
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(180, 23)
        Me.UcPLanta_Cmb011.TabIndex = 14
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'UcDivision_Cmb011
        '
        Me.UcDivision_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision_Cmb011.CDVSN_ANTERIOR = Nothing
        Me.UcDivision_Cmb011.Compania = ""
        Me.UcDivision_Cmb011.Division = Nothing
        Me.UcDivision_Cmb011.DivisionDefault = Nothing
        Me.UcDivision_Cmb011.DivisionDescripcion = Nothing
        Me.UcDivision_Cmb011.ItemTodos = False
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(426, 9)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.pHabilitado = True
        Me.UcDivision_Cmb011.pRequerido = False
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(262, 23)
        Me.UcDivision_Cmb011.TabIndex = 12
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = ""
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(81, 9)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(253, 26)
        Me.UcCompania_Cmb011.TabIndex = 11
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(81, 37)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(253, 21)
        Me.txtCliente.TabIndex = 15
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(426, 37)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = False
        Me.txtProveedor.Size = New System.Drawing.Size(262, 21)
        Me.txtProveedor.TabIndex = 19
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(880, 40)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 69)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 24
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.Location = New System.Drawing.Point(1014, 84)
        Me.txtFechaFinal.Mask = "00/00/0000"
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaFinal.Size = New System.Drawing.Size(73, 22)
        Me.txtFechaFinal.TabIndex = 22
        Me.txtFechaFinal.Text = "  /  /"
        Me.txtFechaFinal.Visible = False
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Location = New System.Drawing.Point(12, 66)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(60, 19)
        Me.lblOrdenCompra.TabIndex = 3
        Me.lblOrdenCompra.Values.Text = "Nro. O/C : "
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaOrdenCompraLimpiar})
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.Location = New System.Drawing.Point(81, 63)
        Me.txtOrdenCompra.MaxLength = 100
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(253, 22)
        Me.txtOrdenCompra.TabIndex = 17
        '
        'bsaOrdenCompraLimpiar
        '
        Me.bsaOrdenCompraLimpiar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaOrdenCompraLimpiar.UniqueName = "DD3C34848EF94820DD3C34848EF94820"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(23, 39)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(354, 39)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(67, 19)
        Me.lblProveedor.TabIndex = 5
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.AutoSize = False
        Me.KryptonLabel5.Location = New System.Drawing.Point(694, 11)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(31, 76)
        Me.KryptonLabel5.TabIndex = 39
        Me.KryptonLabel5.Values.Text = ""
        '
        'NRITOCDataGridViewTextBoxColumn
        '
        Me.NRITOCDataGridViewTextBoxColumn.DataPropertyName = "NRITOC"
        Me.NRITOCDataGridViewTextBoxColumn.HeaderText = "NRITOC"
        Me.NRITOCDataGridViewTextBoxColumn.Name = "NRITOCDataGridViewTextBoxColumn"
        '
        'M_CHK
        '
        Me.M_CHK.DataPropertyName = "CHK"
        Me.M_CHK.FalseValue = "FALSE"
        Me.M_CHK.HeaderText = "Chk"
        Me.M_CHK.Name = "M_CHK"
        Me.M_CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.M_CHK.TrueValue = "TRUE"
        Me.M_CHK.Width = 30
        '
        'M_NRITOC
        '
        Me.M_NRITOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_NRITOC.DataPropertyName = "PNNRITOC"
        Me.M_NRITOC.HeaderText = "Item"
        Me.M_NRITOC.Name = "M_NRITOC"
        Me.M_NRITOC.ReadOnly = True
        Me.M_NRITOC.Width = 58
        '
        'M_TCITCL
        '
        Me.M_TCITCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITCL.DataPropertyName = "PSTCITCL"
        Me.M_TCITCL.HeaderText = "Cód. Cliente"
        Me.M_TCITCL.Name = "M_TCITCL"
        Me.M_TCITCL.ReadOnly = True
        Me.M_TCITCL.Width = 92
        '
        'M_TCITPR
        '
        Me.M_TCITPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TCITPR.DataPropertyName = "PSTCITPR"
        Me.M_TCITPR.HeaderText = "Cód. Proveedor"
        Me.M_TCITPR.Name = "M_TCITPR"
        Me.M_TCITPR.ReadOnly = True
        Me.M_TCITPR.Visible = False
        Me.M_TCITPR.Width = 106
        '
        'M_TDITES
        '
        Me.M_TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITES.DataPropertyName = "PSTDITES"
        Me.M_TDITES.HeaderText = "Descripción"
        Me.M_TDITES.Name = "M_TDITES"
        Me.M_TDITES.ReadOnly = True
        Me.M_TDITES.Width = 96
        '
        'FLGPEN
        '
        Me.FLGPEN.HeaderText = "En seguimiento"
        Me.FLGPEN.Image = Global.SOLMIN_SA.My.Resources.Resources.EnBlanco
        Me.FLGPEN.Name = "FLGPEN"
        Me.FLGPEN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FLGPEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BITACORA
        '
        Me.BITACORA.HeaderText = "Bitacora"
        Me.BITACORA.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.BITACORA.Name = "BITACORA"
        '
        'M_TDITIN
        '
        Me.M_TDITIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TDITIN.DataPropertyName = "PSTDITIN"
        Me.M_TDITIN.HeaderText = "Descripción (IN)"
        Me.M_TDITIN.Name = "M_TDITIN"
        Me.M_TDITIN.ReadOnly = True
        Me.M_TDITIN.Visible = False
        Me.M_TDITIN.Width = 107
        '
        'M_CPTDAR
        '
        Me.M_CPTDAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_CPTDAR.DataPropertyName = "PSCPTDAR"
        Me.M_CPTDAR.HeaderText = "Part. Arancelaria"
        Me.M_CPTDAR.Name = "M_CPTDAR"
        Me.M_CPTDAR.ReadOnly = True
        Me.M_CPTDAR.Visible = False
        Me.M_CPTDAR.Width = 110
        '
        'M_QCNTIT
        '
        Me.M_QCNTIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNTIT.DataPropertyName = "PNQCNTIT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.M_QCNTIT.DefaultCellStyle = DataGridViewCellStyle4
        Me.M_QCNTIT.HeaderText = "Cantidad"
        Me.M_QCNTIT.Name = "M_QCNTIT"
        Me.M_QCNTIT.ReadOnly = True
        Me.M_QCNTIT.Width = 83
        '
        'M_TUNDIT
        '
        Me.M_TUNDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TUNDIT.DataPropertyName = "PSTUNDIT"
        Me.M_TUNDIT.HeaderText = "Unidad"
        Me.M_TUNDIT.Name = "M_TUNDIT"
        Me.M_TUNDIT.ReadOnly = True
        Me.M_TUNDIT.Width = 74
        '
        'M_QCNPEN
        '
        Me.M_QCNPEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QCNPEN.DataPropertyName = "PNQCNPEN"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.M_QCNPEN.DefaultCellStyle = DataGridViewCellStyle5
        Me.M_QCNPEN.HeaderText = "Cant. Pendiente"
        Me.M_QCNPEN.Name = "M_QCNPEN"
        Me.M_QCNPEN.ReadOnly = True
        Me.M_QCNPEN.Width = 109
        '
        'M_IVUNIT
        '
        Me.M_IVUNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVUNIT.DataPropertyName = "PNIVUNIT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.M_IVUNIT.DefaultCellStyle = DataGridViewCellStyle6
        Me.M_IVUNIT.HeaderText = "Imp. Unitario"
        Me.M_IVUNIT.Name = "M_IVUNIT"
        Me.M_IVUNIT.ReadOnly = True
        Me.M_IVUNIT.Width = 95
        '
        'M_IVTOIT
        '
        Me.M_IVTOIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_IVTOIT.DataPropertyName = "PNIVTOIT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.M_IVTOIT.DefaultCellStyle = DataGridViewCellStyle7
        Me.M_IVTOIT.HeaderText = "Imp. Total"
        Me.M_IVTOIT.Name = "M_IVTOIT"
        Me.M_IVTOIT.ReadOnly = True
        Me.M_IVTOIT.Width = 80
        '
        'M_QTOLMAX
        '
        Me.M_QTOLMAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.M_QTOLMAX.DataPropertyName = "PNQTOLMAX"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0.00"
        Me.M_QTOLMAX.DefaultCellStyle = DataGridViewCellStyle8
        Me.M_QTOLMAX.HeaderText = "Tolerancia Máx."
        Me.M_QTOLMAX.Name = "M_QTOLMAX"
        Me.M_QTOLMAX.ReadOnly = True
        Me.M_QTOLMAX.Visible = False
        Me.M_QTOLMAX.Width = 5
        '
        'M_QTOLMIN
        '
        Me.M_QTOLMIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_QTOLMIN.DataPropertyName = "PNQTOLMIN"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.00"
        Me.M_QTOLMIN.DefaultCellStyle = DataGridViewCellStyle9
        Me.M_QTOLMIN.HeaderText = "Tolerancia Mín."
        Me.M_QTOLMIN.Name = "M_QTOLMIN"
        Me.M_QTOLMIN.ReadOnly = True
        Me.M_QTOLMIN.Visible = False
        Me.M_QTOLMIN.Width = 105
        '
        'M_FMPDME
        '
        Me.M_FMPDME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FMPDME.DataPropertyName = "FechaEstimadaEntrega"
        Me.M_FMPDME.HeaderText = "Fch. Est. Entrega"
        Me.M_FMPDME.Name = "M_FMPDME"
        Me.M_FMPDME.ReadOnly = True
        Me.M_FMPDME.Width = 111
        '
        'M_FMPIME
        '
        Me.M_FMPIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_FMPIME.DataPropertyName = "FechaReqPlanta"
        Me.M_FMPIME.HeaderText = "Fch. Req. Planta"
        Me.M_FMPIME.Name = "M_FMPIME"
        Me.M_FMPIME.ReadOnly = True
        Me.M_FMPIME.Width = 109
        '
        'M_TLUGOR
        '
        Me.M_TLUGOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGOR.DataPropertyName = "PSTLUGOR"
        Me.M_TLUGOR.HeaderText = "Lugar Origen"
        Me.M_TLUGOR.Name = "M_TLUGOR"
        Me.M_TLUGOR.ReadOnly = True
        Me.M_TLUGOR.Visible = False
        Me.M_TLUGOR.Width = 96
        '
        'M_TLUGEN
        '
        Me.M_TLUGEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.M_TLUGEN.DataPropertyName = "PSTLUGEN"
        Me.M_TLUGEN.HeaderText = "Lugar Entrega"
        Me.M_TLUGEN.Name = "M_TLUGEN"
        Me.M_TLUGEN.ReadOnly = True
        '
        'M_TCTCST
        '
        Me.M_TCTCST.DataPropertyName = "PSTCTCST"
        Me.M_TCTCST.HeaderText = "Centro de Costo"
        Me.M_TCTCST.Name = "M_TCTCST"
        Me.M_TCTCST.ReadOnly = True
        '
        'frmCheckpointsDeOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 584)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmCheckpointsDeOC"
        Me.Text = "Seguimiento de OC Local"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.dgOrdenesCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.tabDetalleOc.ResumeLayout(False)
        CType(Me.dgItemOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
        'CType(Me.cmbTipoOc, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents bsaStatusOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As RANSA.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents UcDivision_Cmb011 As RANSA.Controls.UbicacionPlanta.ucDivision_Cmb01
    Friend WithEvents UcCompania_Cmb011 As RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtProveedor As RANSA.Controls.Proveedor.ucProveedor_TxtF01
    Private WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents lblOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents bsaOrdenCompraLimpiar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents NRITOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dgOrdenesCompras As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents UcPaginacion2 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssExportarExcel As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssAnular As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadorEliminar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadorNuevo As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblTitulo As System.Windows.Forms.ToolStripLabel
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAnularItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssAnularItems As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEliminarCheckpoint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssElimininarCheckpoint As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblDetalleTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabDetalle As System.Windows.Forms.TabControl
    Friend WithEvents tabDetalleOc As System.Windows.Forms.TabPage
    Private WithEvents dgItemOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents M_NORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaOrdenDeCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDSCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDEFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TTINTC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NREFCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_REFDO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_NTPDES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVCOTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVTOCO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVTOIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsbPuntoDeControl As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadorPuntoDeControl As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnMarcarItems As System.Windows.Forms.ToolStripButton
    Private WithEvents txtFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnEnSeguimiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadoEnSeguimiento As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkFechaOc As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents Modulo01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Modulo02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbTipoOc As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents M_CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents M_NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCITPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FLGPEN As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents BITACORA As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents M_TDITIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_CPTDAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNTIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TUNDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QCNPEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVUNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_IVTOIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTOLMAX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_QTOLMIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FMPDME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_FMPIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TLUGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents M_TCTCST As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
