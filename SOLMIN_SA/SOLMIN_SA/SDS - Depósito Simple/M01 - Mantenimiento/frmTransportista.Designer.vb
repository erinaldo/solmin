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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransportista))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabDetalle = New System.Windows.Forms.TabControl
        Me.tabChofer = New System.Windows.Forms.TabPage
        Me.dgChofer = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNNBRVCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTNMBCH = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNLELCHSTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCTRSP_CHOFER = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacionChofer = New Ransa.Utilitario.UCPaginacion
        Me.tabVehiculo = New System.Windows.Forms.TabPage
        Me.dgVehiculo = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PSNPLCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNANOCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTMRCCM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNSESTRG_VEHICULO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNBRVC1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNPLCAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCTRSP_VEHICULO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UcPaginacionVehiculo = New Ransa.Utilitario.UCPaginacion
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip
        Me.btnDetEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnDetModificar = New System.Windows.Forms.ToolStripButton
        Me.btnDetAgregar = New System.Windows.Forms.ToolStripButton
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion
        Me.dgTRansportista = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PNCTRSP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNRUCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCMPTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNLBELT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTABRTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTDRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRGMRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRGINT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNTLFTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNTLFT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNFAXTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCNTTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCNTT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCRGTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCRGT2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSSESTTR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtruc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripción = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabDetalle.SuspendLayout()
        Me.tabChofer.SuspendLayout()
        CType(Me.dgChofer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVehiculo.SuspendLayout()
        CType(Me.dgVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpcionesDetalle.SuspendLayout()
        CType(Me.dgTRansportista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
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
        Me.KryptonPanel.Controls.Add(Me.UcPaginacion)
        Me.KryptonPanel.Controls.Add(Me.dgTRansportista)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(948, 768)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabDetalle
        '
        Me.TabDetalle.Controls.Add(Me.tabChofer)
        Me.TabDetalle.Controls.Add(Me.tabVehiculo)
        Me.TabDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDetalle.Location = New System.Drawing.Point(0, 435)
        Me.TabDetalle.Name = "TabDetalle"
        Me.TabDetalle.SelectedIndex = 0
        Me.TabDetalle.Size = New System.Drawing.Size(948, 333)
        Me.TabDetalle.TabIndex = 69
        '
        'tabChofer
        '
        Me.tabChofer.Controls.Add(Me.dgChofer)
        Me.tabChofer.Controls.Add(Me.UcPaginacionChofer)
        Me.tabChofer.Location = New System.Drawing.Point(4, 22)
        Me.tabChofer.Name = "tabChofer"
        Me.tabChofer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChofer.Size = New System.Drawing.Size(940, 307)
        Me.tabChofer.TabIndex = 0
        Me.tabChofer.Text = "Chofer"
        Me.tabChofer.UseVisualStyleBackColor = True
        '
        'dgChofer
        '
        Me.dgChofer.AllowUserToAddRows = False
        Me.dgChofer.AllowUserToDeleteRows = False
        Me.dgChofer.AllowUserToResizeColumns = False
        Me.dgChofer.AllowUserToResizeRows = False
        Me.dgChofer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgChofer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNBRVCH, Me.PSTNMBCH, Me.PSNLELCHSTR, Me.PSSESTRG, Me.PNCTRSP_CHOFER})
        Me.dgChofer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgChofer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgChofer.Location = New System.Drawing.Point(3, 3)
        Me.dgChofer.MultiSelect = False
        Me.dgChofer.Name = "dgChofer"
        Me.dgChofer.ReadOnly = True
        Me.dgChofer.RowHeadersWidth = 20
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgChofer.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgChofer.Size = New System.Drawing.Size(934, 276)
        Me.dgChofer.StandardTab = True
        Me.dgChofer.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgChofer.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgChofer.TabIndex = 67
        '
        'PNNBRVCH
        '
        Me.PNNBRVCH.DataPropertyName = "PSNBRVCH"
        Me.PNNBRVCH.HeaderText = "Brevete"
        Me.PNNBRVCH.Name = "PNNBRVCH"
        Me.PNNBRVCH.ReadOnly = True
        Me.PNNBRVCH.Width = 73
        '
        'PSTNMBCH
        '
        Me.PSTNMBCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTNMBCH.DataPropertyName = "PSTNMBCH"
        Me.PSTNMBCH.HeaderText = "Descripción"
        Me.PSTNMBCH.Name = "PSTNMBCH"
        Me.PSTNMBCH.ReadOnly = True
        '
        'PSNLELCHSTR
        '
        Me.PSNLELCHSTR.DataPropertyName = "PSNLELCHSTR"
        Me.PSNLELCHSTR.HeaderText = "DNI"
        Me.PSNLELCHSTR.Name = "PSNLELCHSTR"
        Me.PSNLELCHSTR.ReadOnly = True
        Me.PSNLELCHSTR.Width = 55
        '
        'PSSESTRG
        '
        Me.PSSESTRG.DataPropertyName = "PSSESTRG"
        Me.PSSESTRG.HeaderText = "Estado"
        Me.PSSESTRG.Name = "PSSESTRG"
        Me.PSSESTRG.ReadOnly = True
        Me.PSSESTRG.Width = 69
        '
        'PNCTRSP_CHOFER
        '
        Me.PNCTRSP_CHOFER.DataPropertyName = "PNCTRSP"
        Me.PNCTRSP_CHOFER.HeaderText = "PNCTRSP"
        Me.PNCTRSP_CHOFER.Name = "PNCTRSP_CHOFER"
        Me.PNCTRSP_CHOFER.ReadOnly = True
        Me.PNCTRSP_CHOFER.Visible = False
        Me.PNCTRSP_CHOFER.Width = 87
        '
        'UcPaginacionChofer
        '
        Me.UcPaginacionChofer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacionChofer.Location = New System.Drawing.Point(3, 279)
        Me.UcPaginacionChofer.Name = "UcPaginacionChofer"
        Me.UcPaginacionChofer.PageCount = 0
        Me.UcPaginacionChofer.PageNumber = 1
        Me.UcPaginacionChofer.PageSize = 20
        Me.UcPaginacionChofer.Size = New System.Drawing.Size(934, 25)
        Me.UcPaginacionChofer.TabIndex = 66
        '
        'tabVehiculo
        '
        Me.tabVehiculo.Controls.Add(Me.dgVehiculo)
        Me.tabVehiculo.Controls.Add(Me.UcPaginacionVehiculo)
        Me.tabVehiculo.Location = New System.Drawing.Point(4, 22)
        Me.tabVehiculo.Name = "tabVehiculo"
        Me.tabVehiculo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVehiculo.Size = New System.Drawing.Size(940, 307)
        Me.tabVehiculo.TabIndex = 1
        Me.tabVehiculo.Text = "Vehículo"
        Me.tabVehiculo.UseVisualStyleBackColor = True
        '
        'dgVehiculo
        '
        Me.dgVehiculo.AllowUserToAddRows = False
        Me.dgVehiculo.AllowUserToDeleteRows = False
        Me.dgVehiculo.AllowUserToResizeColumns = False
        Me.dgVehiculo.AllowUserToResizeRows = False
        Me.dgVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgVehiculo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSNPLCCM, Me.PNNANOCM, Me.PSTMRCCM, Me.PNSESTRG_VEHICULO, Me.PSNBRVC1, Me.PSNPLCAC, Me.PNCTRSP_VEHICULO})
        Me.dgVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVehiculo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgVehiculo.Location = New System.Drawing.Point(3, 3)
        Me.dgVehiculo.MultiSelect = False
        Me.dgVehiculo.Name = "dgVehiculo"
        Me.dgVehiculo.ReadOnly = True
        Me.dgVehiculo.RowHeadersWidth = 20
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgVehiculo.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVehiculo.Size = New System.Drawing.Size(934, 276)
        Me.dgVehiculo.StandardTab = True
        Me.dgVehiculo.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgVehiculo.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgVehiculo.TabIndex = 68
        '
        'PSNPLCCM
        '
        Me.PSNPLCCM.DataPropertyName = "PSNPLCCM"
        Me.PSNPLCCM.HeaderText = "Placa"
        Me.PSNPLCCM.Name = "PSNPLCCM"
        Me.PSNPLCCM.ReadOnly = True
        Me.PSNPLCCM.Width = 63
        '
        'PNNANOCM
        '
        Me.PNNANOCM.DataPropertyName = "PNNANOCM"
        Me.PNNANOCM.HeaderText = "N° Año"
        Me.PNNANOCM.Name = "PNNANOCM"
        Me.PNNANOCM.ReadOnly = True
        Me.PNNANOCM.Width = 70
        '
        'PSTMRCCM
        '
        Me.PSTMRCCM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTMRCCM.DataPropertyName = "PSTMRCCM"
        Me.PSTMRCCM.HeaderText = "Descripción Marca"
        Me.PSTMRCCM.Name = "PSTMRCCM"
        Me.PSTMRCCM.ReadOnly = True
        '
        'PNSESTRG_VEHICULO
        '
        Me.PNSESTRG_VEHICULO.DataPropertyName = "PNSESTRG"
        Me.PNSESTRG_VEHICULO.HeaderText = "Estado"
        Me.PNSESTRG_VEHICULO.Name = "PNSESTRG_VEHICULO"
        Me.PNSESTRG_VEHICULO.ReadOnly = True
        Me.PNSESTRG_VEHICULO.Width = 69
        '
        'PSNBRVC1
        '
        Me.PSNBRVC1.DataPropertyName = "PSNBRVC1"
        Me.PSNBRVC1.HeaderText = "Brevete Chofer"
        Me.PSNBRVC1.Name = "PSNBRVC1"
        Me.PSNBRVC1.ReadOnly = True
        Me.PSNBRVC1.Visible = False
        Me.PSNBRVC1.Width = 107
        '
        'PSNPLCAC
        '
        Me.PSNPLCAC.DataPropertyName = "PSNPLCAC"
        Me.PSNPLCAC.HeaderText = "Placa Acoplado"
        Me.PSNPLCAC.Name = "PSNPLCAC"
        Me.PSNPLCAC.ReadOnly = True
        Me.PSNPLCAC.Visible = False
        Me.PSNPLCAC.Width = 111
        '
        'PNCTRSP_VEHICULO
        '
        Me.PNCTRSP_VEHICULO.DataPropertyName = "PNCTRSP"
        Me.PNCTRSP_VEHICULO.HeaderText = "PNCTRSP"
        Me.PNCTRSP_VEHICULO.Name = "PNCTRSP_VEHICULO"
        Me.PNCTRSP_VEHICULO.ReadOnly = True
        Me.PNCTRSP_VEHICULO.Visible = False
        Me.PNCTRSP_VEHICULO.Width = 87
        '
        'UcPaginacionVehiculo
        '
        Me.UcPaginacionVehiculo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacionVehiculo.Location = New System.Drawing.Point(3, 279)
        Me.UcPaginacionVehiculo.Name = "UcPaginacionVehiculo"
        Me.UcPaginacionVehiculo.PageCount = 0
        Me.UcPaginacionVehiculo.PageNumber = 1
        Me.UcPaginacionVehiculo.PageSize = 20
        Me.UcPaginacionVehiculo.Size = New System.Drawing.Size(934, 25)
        Me.UcPaginacionVehiculo.TabIndex = 67
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnDetEliminar, Me.btnDetModificar, Me.btnDetAgregar})
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 410)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(948, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 68
        '
        'btnDetEliminar
        '
        Me.btnDetEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDetEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnDetEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetEliminar.Name = "btnDetEliminar"
        Me.btnDetEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnDetEliminar.Text = "Eliminar"
        '
        'btnDetModificar
        '
        Me.btnDetModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDetModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnDetModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetModificar.Name = "btnDetModificar"
        Me.btnDetModificar.Size = New System.Drawing.Size(70, 22)
        Me.btnDetModificar.Text = "Modificar"
        '
        'btnDetAgregar
        '
        Me.btnDetAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDetAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnDetAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetAgregar.Name = "btnDetAgregar"
        Me.btnDetAgregar.Size = New System.Drawing.Size(64, 22)
        Me.btnDetAgregar.Text = "Agregar"
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 385)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(948, 25)
        Me.UcPaginacion.TabIndex = 65
        '
        'dgTRansportista
        '
        Me.dgTRansportista.AllowUserToAddRows = False
        Me.dgTRansportista.AllowUserToDeleteRows = False
        Me.dgTRansportista.AllowUserToResizeColumns = False
        Me.dgTRansportista.AllowUserToResizeRows = False
        Me.dgTRansportista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgTRansportista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCTRSP, Me.PNNRUCT, Me.PSTCMPTR, Me.PSTCMPCL, Me.PSNLBELT, Me.PNCCLNT, Me.PSTABRTR, Me.PSTDRCTR, Me.PSNRGMRT, Me.PSNRGINT, Me.PSNTLFTR, Me.PSNTLFT2, Me.PSNFAXTR, Me.PSTCNTTR, Me.PSTCNTT2, Me.PSTCRGTR, Me.PSTCRGT2, Me.PSSESTTR})
        Me.dgTRansportista.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgTRansportista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgTRansportista.Location = New System.Drawing.Point(0, 136)
        Me.dgTRansportista.MultiSelect = False
        Me.dgTRansportista.Name = "dgTRansportista"
        Me.dgTRansportista.ReadOnly = True
        Me.dgTRansportista.RowHeadersWidth = 20
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTRansportista.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgTRansportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTRansportista.Size = New System.Drawing.Size(948, 249)
        Me.dgTRansportista.StandardTab = True
        Me.dgTRansportista.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgTRansportista.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgTRansportista.TabIndex = 64
        '
        'PNCTRSP
        '
        Me.PNCTRSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCTRSP.DataPropertyName = "PNCTRSP"
        Me.PNCTRSP.HeaderText = "Transportista"
        Me.PNCTRSP.Name = "PNCTRSP"
        Me.PNCTRSP.ReadOnly = True
        Me.PNCTRSP.Width = 97
        '
        'PNNRUCT
        '
        Me.PNNRUCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNRUCT.DataPropertyName = "PNNRUCT"
        Me.PNNRUCT.HeaderText = "RUC"
        Me.PNNRUCT.Name = "PNNRUCT"
        Me.PNNRUCT.ReadOnly = True
        Me.PNNRUCT.Width = 59
        '
        'PSTCMPTR
        '
        Me.PSTCMPTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PSTCMPTR.DataPropertyName = "PSTCMPTR"
        Me.PSTCMPTR.HeaderText = "Descripción"
        Me.PSTCMPTR.Name = "PSTCMPTR"
        Me.PSTCMPTR.ReadOnly = True
        '
        'PSTCMPCL
        '
        Me.PSTCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTCMPCL.DataPropertyName = "PSTCMPCL"
        Me.PSTCMPCL.HeaderText = "Cliente"
        Me.PSTCMPCL.Name = "PSTCMPCL"
        Me.PSTCMPCL.ReadOnly = True
        Me.PSTCMPCL.Width = 68
        '
        'PSNLBELT
        '
        Me.PSNLBELT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSNLBELT.DataPropertyName = "PSNLBELT"
        Me.PSNLBELT.HeaderText = "DNI"
        Me.PSNLBELT.Name = "PSNLBELT"
        Me.PSNLBELT.ReadOnly = True
        Me.PSNLBELT.Width = 55
        '
        'PNCCLNT
        '
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "PNCCLNT"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        Me.PNCCLNT.Width = 86
        '
        'PSTABRTR
        '
        Me.PSTABRTR.DataPropertyName = "PSTABRTR"
        Me.PSTABRTR.HeaderText = "PSTABRTR"
        Me.PSTABRTR.Name = "PSTABRTR"
        Me.PSTABRTR.ReadOnly = True
        Me.PSTABRTR.Visible = False
        Me.PSTABRTR.Width = 94
        '
        'PSTDRCTR
        '
        Me.PSTDRCTR.DataPropertyName = "PSTDRCTR"
        Me.PSTDRCTR.HeaderText = "PSTDRCTR"
        Me.PSTDRCTR.Name = "PSTDRCTR"
        Me.PSTDRCTR.ReadOnly = True
        Me.PSTDRCTR.Visible = False
        Me.PSTDRCTR.Width = 95
        '
        'PSNRGMRT
        '
        Me.PSNRGMRT.DataPropertyName = "PSNRGMRT"
        Me.PSNRGMRT.HeaderText = "PSNRGMRT"
        Me.PSNRGMRT.Name = "PSNRGMRT"
        Me.PSNRGMRT.ReadOnly = True
        Me.PSNRGMRT.Visible = False
        Me.PSNRGMRT.Width = 98
        '
        'PSNRGINT
        '
        Me.PSNRGINT.DataPropertyName = "PSNRGINT"
        Me.PSNRGINT.HeaderText = "PSNRGINT"
        Me.PSNRGINT.Name = "PSNRGINT"
        Me.PSNRGINT.ReadOnly = True
        Me.PSNRGINT.Visible = False
        Me.PSNRGINT.Width = 92
        '
        'PSNTLFTR
        '
        Me.PSNTLFTR.DataPropertyName = "PSNTLFTR"
        Me.PSNTLFTR.HeaderText = "PSNTLFTR"
        Me.PSNTLFTR.Name = "PSNTLFTR"
        Me.PSNTLFTR.ReadOnly = True
        Me.PSNTLFTR.Visible = False
        Me.PSNTLFTR.Width = 92
        '
        'PSNTLFT2
        '
        Me.PSNTLFT2.DataPropertyName = "PSNTLFT2"
        Me.PSNTLFT2.HeaderText = "PSNTLFT2"
        Me.PSNTLFT2.Name = "PSNTLFT2"
        Me.PSNTLFT2.ReadOnly = True
        Me.PSNTLFT2.Visible = False
        Me.PSNTLFT2.Width = 90
        '
        'PSNFAXTR
        '
        Me.PSNFAXTR.HeaderText = "PSNFAXTR"
        Me.PSNFAXTR.Name = "PSNFAXTR"
        Me.PSNFAXTR.ReadOnly = True
        Me.PSNFAXTR.Visible = False
        Me.PSNFAXTR.Width = 93
        '
        'PSTCNTTR
        '
        Me.PSTCNTTR.HeaderText = "PSTCNTTR"
        Me.PSTCNTTR.Name = "PSTCNTTR"
        Me.PSTCNTTR.ReadOnly = True
        Me.PSTCNTTR.Visible = False
        Me.PSTCNTTR.Width = 94
        '
        'PSTCNTT2
        '
        Me.PSTCNTT2.HeaderText = "PSTCNTT2"
        Me.PSTCNTT2.Name = "PSTCNTT2"
        Me.PSTCNTT2.ReadOnly = True
        Me.PSTCNTT2.Visible = False
        Me.PSTCNTT2.Width = 92
        '
        'PSTCRGTR
        '
        Me.PSTCRGTR.DataPropertyName = "PSTCRGTR"
        Me.PSTCRGTR.HeaderText = "PSTCRGTR"
        Me.PSTCRGTR.Name = "PSTCRGTR"
        Me.PSTCRGTR.ReadOnly = True
        Me.PSTCRGTR.Visible = False
        Me.PSTCRGTR.Width = 95
        '
        'PSTCRGT2
        '
        Me.PSTCRGT2.DataPropertyName = "PSTCRGT2"
        Me.PSTCRGT2.HeaderText = "PSTCRGT2"
        Me.PSTCRGT2.Name = "PSTCRGT2"
        Me.PSTCRGT2.ReadOnly = True
        Me.PSTCRGT2.Visible = False
        Me.PSTCRGT2.Width = 93
        '
        'PSSESTTR
        '
        Me.PSSESTTR.DataPropertyName = "PSSESTTR"
        Me.PSSESTTR.HeaderText = "PSSESTTR"
        Me.PSSESTTR.Name = "PSSESTTR"
        Me.PSSESTTR.ReadOnly = True
        Me.PSSESTTR.Visible = False
        Me.PSSESTTR.Width = 93
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssSep_02, Me.btnEliminar, Me.btnModificar, Me.btnAgregar, Me.lblTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 111)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(948, 25)
        Me.tsMenuOpciones.TabIndex = 24
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(70, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(118, 22)
        Me.lblTitulo.Text = "Lista Transportistas"
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
        Me.khgFiltros.Panel.Controls.Add(Me.txtruc)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.txtDescripción)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCodigo)
        Me.khgFiltros.Panel.Controls.Add(Me.btnActualizar)
        Me.khgFiltros.Size = New System.Drawing.Size(948, 111)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 4
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
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(337, 14)
        Me.txtruc.MaxLength = 15
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(179, 19)
        Me.txtruc.TabIndex = 80
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(221, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(110, 16)
        Me.KryptonLabel1.TabIndex = 79
        Me.KryptonLabel1.Text = "RUC Transportista : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "RUC Transportista : "
        '
        'txtDescripción
        '
        Me.txtDescripción.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripción.Location = New System.Drawing.Point(104, 42)
        Me.txtDescripción.MaxLength = 30
        Me.txtDescripción.Name = "txtDescripción"
        Me.txtDescripción.Size = New System.Drawing.Size(412, 19)
        Me.txtDescripción.TabIndex = 78
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 42)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(73, 16)
        Me.KryptonLabel3.TabIndex = 77
        Me.KryptonLabel3.Text = "Descripción: "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Descripción: "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 17)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel2.TabIndex = 76
        Me.KryptonLabel2.Text = "Código : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Código : "
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(104, 14)
        Me.txtCodigo.MaxLength = 15
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(111, 19)
        Me.txtCodigo.TabIndex = 75
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(839, 14)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(84, 68)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 73
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'frmTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 768)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransportista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transportista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabDetalle.ResumeLayout(False)
        Me.tabChofer.ResumeLayout(False)
        CType(Me.dgChofer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVehiculo.ResumeLayout(False)
        CType(Me.dgVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpcionesDetalle.ResumeLayout(False)
        Me.tsMenuOpcionesDetalle.PerformLayout()
        CType(Me.dgTRansportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents txtCodigo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dgTRansportista As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripción As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TabDetalle As System.Windows.Forms.TabControl
    Friend WithEvents tabChofer As System.Windows.Forms.TabPage
    Friend WithEvents tabVehiculo As System.Windows.Forms.TabPage
    Friend WithEvents txtruc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dgChofer As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacionChofer As Ransa.Utilitario.UCPaginacion
    Friend WithEvents dgVehiculo As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacionVehiculo As RANSA.Utilitario.UCPaginacion
    Friend WithEvents btnDetAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PNNBRVCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTNMBCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNLELCHSTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCTRSP_CHOFER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNPLCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNANOCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTMRCCM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNSESTRG_VEHICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNBRVC1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNPLCAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCTRSP_VEHICULO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCTRSP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRUCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMPTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNLBELT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTABRTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRGMRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRGINT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNTLFTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNTLFT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNFAXTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCNTTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCNTT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCRGTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCRGT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSESTTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDetModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDetEliminar As System.Windows.Forms.ToolStripButton
End Class
