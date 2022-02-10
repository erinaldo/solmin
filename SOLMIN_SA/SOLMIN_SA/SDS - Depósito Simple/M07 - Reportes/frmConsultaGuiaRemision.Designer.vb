<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaGuiaRemision
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaGuiaRemision))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabDetalle = New System.Windows.Forms.TabControl
        Me.tabDetalleGR = New System.Windows.Forms.TabPage
        Me.dgDetalleGR = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTRMP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNPS6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabObservaciones = New System.Windows.Forms.TabPage
        Me.dgObservacionGR = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.TOBSGS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.btnVistaPrevia = New System.Windows.Forms.ToolStripButton
        Me.dgGuiasRemision = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DNGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ORIGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDPEPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TNMBCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lblt2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lbl1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroGuia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnConsultar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
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
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.tabDetalleGR.SuspendLayout()
        CType(Me.dgDetalleGR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabObservaciones.SuspendLayout()
        CType(Me.dgObservacionGR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabDetalle)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.KryptonPanel.Controls.Add(Me.dgGuiasRemision)
        Me.KryptonPanel.Controls.Add(Me.tspListadoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1026, 726)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.tabDetalleGR)
        Me.TabDetalle.Controls.Add(Me.tabObservaciones)
        Me.TabDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDetalle.Location = New System.Drawing.Point(0, 575)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.SelectedIndex = 0
        Me.TabDetalle.Size = New System.Drawing.Size(1026, 151)
        Me.TabDetalle.TabIndex = 75
        '
        'tabDetalleGR
        '
        Me.tabDetalleGR.Controls.Add(Me.dgDetalleGR)
        Me.tabDetalleGR.Location = New System.Drawing.Point(4, 22)
        Me.tabDetalleGR.Name = "tabDetalleGR"
        Me.tabDetalleGR.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDetalleGR.Size = New System.Drawing.Size(1018, 125)
        Me.tabDetalleGR.TabIndex = 0
        Me.tabDetalleGR.Text = "Detalle G/R"
        Me.tabDetalleGR.UseVisualStyleBackColor = True
        '
        'dgDetalleGR
        '
        Me.dgDetalleGR.AllowUserToAddRows = False
        Me.dgDetalleGR.AllowUserToDeleteRows = False
        Me.dgDetalleGR.AllowUserToResizeColumns = False
        Me.dgDetalleGR.AllowUserToResizeRows = False
        Me.dgDetalleGR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDetalleGR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CMRCLR, Me.DMRCLR, Me.QTRMC, Me.CUNCN6, Me.QTRMP, Me.CUNPS6})
        Me.dgDetalleGR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetalleGR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDetalleGR.Location = New System.Drawing.Point(3, 3)
        Me.dgDetalleGR.MultiSelect = False
        Me.dgDetalleGR.Name = "dgDetalleGR"
        Me.dgDetalleGR.ReadOnly = True
        Me.dgDetalleGR.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetalleGR.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDetalleGR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetalleGR.Size = New System.Drawing.Size(1012, 119)
        Me.dgDetalleGR.StandardTab = True
        Me.dgDetalleGR.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDetalleGR.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDetalleGR.TabIndex = 67
        '
        'CMRCLR
        '
        Me.CMRCLR.DataPropertyName = "PSCMRCLR"
        Me.CMRCLR.HeaderText = "Codigo"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        Me.CMRCLR.Width = 69
        '
        'DMRCLR
        '
        Me.DMRCLR.DataPropertyName = "PSDMRCLR"
        Me.DMRCLR.HeaderText = "Descripcion de Mercaderia"
        Me.DMRCLR.Name = "DMRCLR"
        Me.DMRCLR.ReadOnly = True
        Me.DMRCLR.Width = 163
        '
        'QTRMC
        '
        Me.QTRMC.DataPropertyName = "PNQTRMC"
        Me.QTRMC.HeaderText = "Can. Transaccion"
        Me.QTRMC.Name = "QTRMC"
        Me.QTRMC.ReadOnly = True
        Me.QTRMC.Width = 120
        '
        'CUNCN6
        '
        Me.CUNCN6.DataPropertyName = "PSCUNCN6"
        Me.CUNCN6.HeaderText = "Cod. Unid. Cant."
        Me.CUNCN6.Name = "CUNCN6"
        Me.CUNCN6.ReadOnly = True
        Me.CUNCN6.Width = 114
        '
        'QTRMP
        '
        Me.QTRMP.DataPropertyName = "PNQTRMP"
        Me.QTRMP.HeaderText = "Peso Transaccion"
        Me.QTRMP.Name = "QTRMP"
        Me.QTRMP.ReadOnly = True
        Me.QTRMP.Width = 122
        '
        'CUNPS6
        '
        Me.CUNPS6.DataPropertyName = "PSCUNPS6"
        Me.CUNPS6.HeaderText = "Cod. Unid. Peso"
        Me.CUNPS6.Name = "CUNPS6"
        Me.CUNPS6.ReadOnly = True
        Me.CUNPS6.Width = 113
        '
        'tabObservaciones
        '
        Me.tabObservaciones.Controls.Add(Me.dgObservacionGR)
        Me.tabObservaciones.Controls.Add(Me.dgVehiculo)
        Me.tabObservaciones.Location = New System.Drawing.Point(4, 22)
        Me.tabObservaciones.Name = "tabObservaciones"
        Me.tabObservaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabObservaciones.Size = New System.Drawing.Size(1018, 228)
        Me.tabObservaciones.TabIndex = 1
        Me.tabObservaciones.Text = "Observaciones"
        Me.tabObservaciones.UseVisualStyleBackColor = True
        '
        'dgObservacionGR
        '
        Me.dgObservacionGR.AllowUserToAddRows = False
        Me.dgObservacionGR.AllowUserToDeleteRows = False
        Me.dgObservacionGR.AllowUserToResizeColumns = False
        Me.dgObservacionGR.AllowUserToResizeRows = False
        Me.dgObservacionGR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgObservacionGR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOBSGS})
        Me.dgObservacionGR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgObservacionGR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgObservacionGR.Location = New System.Drawing.Point(3, 3)
        Me.dgObservacionGR.MultiSelect = False
        Me.dgObservacionGR.Name = "dgObservacionGR"
        Me.dgObservacionGR.ReadOnly = True
        Me.dgObservacionGR.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgObservacionGR.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgObservacionGR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgObservacionGR.Size = New System.Drawing.Size(1012, 222)
        Me.dgObservacionGR.StandardTab = True
        Me.dgObservacionGR.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgObservacionGR.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgObservacionGR.TabIndex = 69
        '
        'TOBSGS
        '
        Me.TOBSGS.DataPropertyName = "PSTOBSGS"
        Me.TOBSGS.HeaderText = "Observacion de Guia Salida"
        Me.TOBSGS.Name = "TOBSGS"
        Me.TOBSGS.ReadOnly = True
        Me.TOBSGS.Width = 168
        '
        'dgVehiculo
        '
        Me.dgVehiculo.AllowUserToAddRows = False
        Me.dgVehiculo.AllowUserToDeleteRows = False
        Me.dgVehiculo.AllowUserToResizeColumns = False
        Me.dgVehiculo.AllowUserToResizeRows = False
        Me.dgVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVehiculo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgVehiculo.Location = New System.Drawing.Point(3, 3)
        Me.dgVehiculo.MultiSelect = False
        Me.dgVehiculo.Name = "dgVehiculo"
        Me.dgVehiculo.ReadOnly = True
        Me.dgVehiculo.RowHeadersWidth = 20
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgVehiculo.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculo.Size = New System.Drawing.Size(1012, 222)
        Me.dgVehiculo.StandardTab = True
        Me.dgVehiculo.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgVehiculo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgVehiculo.TabIndex = 68
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVistaPrevia})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 550)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(1026, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 74
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnVistaPrevia.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.btnVistaPrevia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(80, 22)
        Me.btnVistaPrevia.Text = "VistaPrevia"
        '
        'dgGuiasRemision
        '
        Me.dgGuiasRemision.AllowUserToAddRows = False
        Me.dgGuiasRemision.AllowUserToDeleteRows = False
        Me.dgGuiasRemision.AllowUserToResizeColumns = False
        Me.dgGuiasRemision.AllowUserToResizeRows = False
        Me.dgGuiasRemision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGuiasRemision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCLNT, Me.NGUIRM, Me.DNGUIRM, Me.FGUIRM, Me.ORIGEN, Me.DESTINO, Me.CDPEPL, Me.TCMPTR, Me.NPLCCM, Me.NBRVCH, Me.TNMBCH, Me.SESTRG})
        Me.dgGuiasRemision.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgGuiasRemision.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgGuiasRemision.Location = New System.Drawing.Point(0, 140)
        Me.dgGuiasRemision.MultiSelect = False
        Me.dgGuiasRemision.Name = "dgGuiasRemision"
        Me.dgGuiasRemision.ReadOnly = True
        Me.dgGuiasRemision.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGuiasRemision.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgGuiasRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuiasRemision.Size = New System.Drawing.Size(1026, 410)
        Me.dgGuiasRemision.StandardTab = True
        Me.dgGuiasRemision.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgGuiasRemision.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgGuiasRemision.TabIndex = 70
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "PNCCLNT"
        Me.CCLNT.HeaderText = "PNCCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 86
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "PNNGUIRM"
        Me.NGUIRM.HeaderText = "PNNGUIRM"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.ReadOnly = True
        Me.NGUIRM.Visible = False
        Me.NGUIRM.Width = 95
        '
        'DNGUIRM
        '
        Me.DNGUIRM.DataPropertyName = "PSDNGUIRM"
        Me.DNGUIRM.HeaderText = "# Guia"
        Me.DNGUIRM.Name = "DNGUIRM"
        Me.DNGUIRM.ReadOnly = True
        Me.DNGUIRM.Width = 68
        '
        'FGUIRM
        '
        Me.FGUIRM.DataPropertyName = "PNFGUIRM"
        Me.FGUIRM.HeaderText = "Fecha"
        Me.FGUIRM.Name = "FGUIRM"
        Me.FGUIRM.ReadOnly = True
        Me.FGUIRM.Width = 66
        '
        'ORIGEN
        '
        Me.ORIGEN.DataPropertyName = "PSORIGEN"
        Me.ORIGEN.HeaderText = "Origen"
        Me.ORIGEN.Name = "ORIGEN"
        Me.ORIGEN.ReadOnly = True
        Me.ORIGEN.Width = 67
        '
        'DESTINO
        '
        Me.DESTINO.DataPropertyName = "PSDESTINO"
        Me.DESTINO.HeaderText = "Destino"
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.ReadOnly = True
        Me.DESTINO.Width = 72
        '
        'CDPEPL
        '
        Me.CDPEPL.DataPropertyName = "PNCDPEPL"
        Me.CDPEPL.HeaderText = "Pedido"
        Me.CDPEPL.Name = "CDPEPL"
        Me.CDPEPL.ReadOnly = True
        Me.CDPEPL.Width = 69
        '
        'TCMPTR
        '
        Me.TCMPTR.DataPropertyName = "PSTCMPTR"
        Me.TCMPTR.HeaderText = "Transporte"
        Me.TCMPTR.Name = "TCMPTR"
        Me.TCMPTR.ReadOnly = True
        Me.TCMPTR.Width = 87
        '
        'NPLCCM
        '
        Me.NPLCCM.DataPropertyName = "PSNPLCCM"
        Me.NPLCCM.HeaderText = "Placa"
        Me.NPLCCM.Name = "NPLCCM"
        Me.NPLCCM.ReadOnly = True
        Me.NPLCCM.Width = 63
        '
        'NBRVCH
        '
        Me.NBRVCH.DataPropertyName = "PSNBRVCH"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.NBRVCH.DefaultCellStyle = DataGridViewCellStyle4
        Me.NBRVCH.HeaderText = "Brevete"
        Me.NBRVCH.Name = "NBRVCH"
        Me.NBRVCH.ReadOnly = True
        Me.NBRVCH.Width = 73
        '
        'TNMBCH
        '
        Me.TNMBCH.DataPropertyName = "PSTNMBCH"
        Me.TNMBCH.HeaderText = "Conductor"
        Me.TNMBCH.Name = "TNMBCH"
        Me.TNMBCH.ReadOnly = True
        Me.TNMBCH.Width = 85
        '
        'SESTRG
        '
        Me.SESTRG.DataPropertyName = "PSSESTRG"
        Me.SESTRG.HeaderText = "Estado"
        Me.SESTRG.Name = "SESTRG"
        Me.SESTRG.ReadOnly = True
        Me.SESTRG.Width = 69
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 115)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(1026, 25)
        Me.tspListadoMercaderia.TabIndex = 60
        Me.tspListadoMercaderia.Text = "ToolStrip1"
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaFin)
        Me.khgFiltros.Panel.Controls.Add(Me.dtpFechaInicio)
        Me.khgFiltros.Panel.Controls.Add(Me.lblt2)
        Me.khgFiltros.Panel.Controls.Add(Me.lbl1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroGuia)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.btnConsultar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(1026, 115)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 2
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(279, 46)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaFin.TabIndex = 88
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(90, 45)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(89, 20)
        Me.dtpFechaInicio.TabIndex = 87
        '
        'lblt2
        '
        Me.lblt2.Location = New System.Drawing.Point(192, 49)
        Me.lblt2.Name = "lblt2"
        Me.lblt2.Size = New System.Drawing.Size(80, 16)
        Me.lblt2.TabIndex = 86
        Me.lblt2.Text = "Fecha Hasta :"
        Me.lblt2.Values.ExtraText = ""
        Me.lblt2.Values.Image = Nothing
        Me.lblt2.Values.Text = "Fecha Hasta :"
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(10, 48)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(77, 16)
        Me.lbl1.TabIndex = 85
        Me.lbl1.Text = "Fecha Inicio :"
        Me.lbl1.Values.ExtraText = ""
        Me.lbl1.Values.Image = Nothing
        Me.lbl1.Values.Text = "Fecha Inicio :"
        '
        'txtNroGuia
        '
        Me.txtNroGuia.Location = New System.Drawing.Point(477, 16)
        Me.txtNroGuia.MaxLength = 10
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.Size = New System.Drawing.Size(234, 19)
        Me.txtNroGuia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNroGuia.TabIndex = 76
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(408, 18)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel3.TabIndex = 75
        Me.KryptonLabel3.Text = "Nro Guia : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Nro Guia : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(755, 84)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(6, 2)
        Me.KryptonLabel1.TabIndex = 74
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = ""
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Location = New System.Drawing.Point(934, 7)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(79, 69)
        Me.btnConsultar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnConsultar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnConsultar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnConsultar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnConsultar.TabIndex = 73
        Me.btnConsultar.Text = "&Procesar"
        Me.btnConsultar.Values.ExtraText = "Consulta"
        Me.btnConsultar.Values.Image = CType(resources.GetObject("btnConsultar.Values.Image"), System.Drawing.Image)
        Me.btnConsultar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnConsultar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnConsultar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnConsultar.Values.Text = "&Procesar"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(90, 15)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(278, 19)
        Me.txtCliente.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(11, 18)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Detalle"
        Me.DataGridViewImageColumn1.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "Ver Detalle Inventario de Mercadería"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CMRCLR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TMRCD2"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Mercadería"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SALDO_QSLMC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Saldo Inventario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 113
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QSERIESXMERCADERIA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Saldo Serie"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QUBICADOSXMERCADERIA"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Saldo Ubicación"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 114
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SALDO_QCMMC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Saldo Comprometido"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 133
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SALDO_QWRMC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Saldo Warrant"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 104
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SALDO"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "Saldo Disponible"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 115
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TFMCLR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Familia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TGRCLR"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SITUAC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TCMPCL"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TCMPCL"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 79
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CCLNT"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CCLNT"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 71
        '
        'frmConsultaGuiaRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 726)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaGuiaRemision"
        Me.Text = "Consulta de Guía de remisión"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.tabDetalleGR.ResumeLayout(False)
        CType(Me.dgDetalleGR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabObservaciones.ResumeLayout(False)
        CType(Me.dgObservacionGR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
        CType(Me.dgGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnConsultar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
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
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroGuia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblt2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbl1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabDetalle As System.Windows.Forms.TabControl
    Friend WithEvents tabDetalleGR As System.Windows.Forms.TabPage
    Friend WithEvents dgDetalleGR As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tabObservaciones As System.Windows.Forms.TabPage
    Friend WithEvents dgVehiculo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgGuiasRemision As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgObservacionGR As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDPEPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTRMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBSGS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
