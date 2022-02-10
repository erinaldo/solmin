<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOpcionMain
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.Uc_CboMenu = New Ransa.Controls.Menu.uc_CboMenu
        Me.Uc_CboAplicacion = New Ransa.Controls.Menu.uc_CboAplicacion
        Me.txtCodigo = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.UcOpcionBusq = New Ransa.Controls.Menu.ucOpcionBusq
        Me.dgvUsuario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CHK_USUARIO = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMCMNU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMCOPC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMCUSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMNUSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DES_APLC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DES_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DES_OPCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSVIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSADI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSCHG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSELI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSOP1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSOP2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STSOP3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tsCabecera = New System.Windows.Forms.ToolStrip
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.btnCheck = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboMenu)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Uc_CboAplicacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCodigo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(696, 91)
        Me.KryptonHeaderGroup1.TabIndex = 39
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'Uc_CboMenu
        '
        Me.Uc_CboMenu.Location = New System.Drawing.Point(411, 9)
        Me.Uc_CboMenu.Name = "Uc_CboMenu"
        Me.Uc_CboMenu.pPSMMCAPL = ""
        Me.Uc_CboMenu.Size = New System.Drawing.Size(239, 22)
        Me.Uc_CboMenu.TabIndex = 3
        '
        'Uc_CboAplicacion
        '
        Me.Uc_CboAplicacion.Location = New System.Drawing.Point(80, 9)
        Me.Uc_CboAplicacion.Name = "Uc_CboAplicacion"
        Me.Uc_CboAplicacion.Size = New System.Drawing.Size(262, 22)
        Me.Uc_CboAplicacion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(80, 37)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.NUMDECIMALES = 0
        Me.txtCodigo.NUMENTEROS = 2
        Me.txtCodigo.Size = New System.Drawing.Size(47, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(223, 38)
        Me.txtDescripcion.MaxLength = 25
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(427, 21)
        Me.txtDescripcion.TabIndex = 7
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(360, 9)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel6.TabIndex = 2
        Me.KryptonLabel6.Text = "Menú :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Menú :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(143, 38)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel2.TabIndex = 6
        Me.KryptonLabel2.Text = "Opción :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Opción :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(7, 9)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(67, 19)
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Text = "Aplicación :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Aplicación :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 34)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(52, 19)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Código :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Código :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 91)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcOpcionBusq)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvUsuario)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsCabecera)
        Me.SplitContainer1.Size = New System.Drawing.Size(696, 411)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 40
        '
        'UcOpcionBusq
        '
        Me.UcOpcionBusq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcOpcionBusq.Location = New System.Drawing.Point(0, 0)
        Me.UcOpcionBusq.Name = "UcOpcionBusq"
        Me.UcOpcionBusq.pInfo_MMCAPL_CodApl = ""
        Me.UcOpcionBusq.pInfo_MMCMNU_CodMenu = ""
        Me.UcOpcionBusq.pInfo_MMCOPC_CodOpc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcOpcionBusq.pInfo_MMDAPL = ""
        Me.UcOpcionBusq.pInfo_MMDOPC = "0"
        Me.UcOpcionBusq.pInfo_MMTMNU = ""
        Me.UcOpcionBusq.pnumReg = CType(0, Long)
        Me.UcOpcionBusq.pVerBotonBuscar = True
        Me.UcOpcionBusq.pVerBotonEliminar = True
        'Me.UcOpcionBusq.pVerBotonExportar = True
        Me.UcOpcionBusq.pVerBotonModificar = True
        Me.UcOpcionBusq.pVerBotonNuevo = True
        Me.UcOpcionBusq.Size = New System.Drawing.Size(696, 221)
        Me.UcOpcionBusq.TabIndex = 0
        '
        'dgvUsuario
        '
        Me.dgvUsuario.AllowUserToAddRows = False
        Me.dgvUsuario.AllowUserToDeleteRows = False
        Me.dgvUsuario.AllowUserToResizeColumns = False
        Me.dgvUsuario.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvUsuario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK_USUARIO, Me.MMCAPL, Me.MMCMNU, Me.MMCOPC, Me.MMCUSR, Me.MMNUSR, Me.DES_APLC, Me.DES_MENU, Me.DES_OPCN, Me.STSVIS, Me.STSADI, Me.STSCHG, Me.STSELI, Me.STSOP1, Me.STSOP2, Me.STSOP3})
        Me.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuario.Location = New System.Drawing.Point(0, 25)
        Me.dgvUsuario.MultiSelect = False
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.RowHeadersWidth = 10
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvUsuario.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuario.Size = New System.Drawing.Size(696, 161)
        Me.dgvUsuario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvUsuario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvUsuario.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dgvUsuario.TabIndex = 77
        '
        'CHK_USUARIO
        '
        Me.CHK_USUARIO.FillWeight = 73.70112!
        Me.CHK_USUARIO.HeaderText = "Check"
        Me.CHK_USUARIO.MinimumWidth = 40
        Me.CHK_USUARIO.Name = "CHK_USUARIO"
        '
        'MMCAPL
        '
        Me.MMCAPL.DataPropertyName = "MMCAPL"
        Me.MMCAPL.HeaderText = "MMCAPL"
        Me.MMCAPL.Name = "MMCAPL"
        Me.MMCAPL.ReadOnly = True
        Me.MMCAPL.Visible = False
        '
        'MMCMNU
        '
        Me.MMCMNU.DataPropertyName = "MMCMNU"
        Me.MMCMNU.HeaderText = "MMCMNU"
        Me.MMCMNU.Name = "MMCMNU"
        Me.MMCMNU.ReadOnly = True
        Me.MMCMNU.Visible = False
        '
        'MMCOPC
        '
        Me.MMCOPC.DataPropertyName = "MMCOPC"
        Me.MMCOPC.HeaderText = "MMCOPC"
        Me.MMCOPC.Name = "MMCOPC"
        Me.MMCOPC.ReadOnly = True
        Me.MMCOPC.Visible = False
        '
        'MMCUSR
        '
        Me.MMCUSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMCUSR.DataPropertyName = "MMCUSR"
        Me.MMCUSR.FillWeight = 263.9594!
        Me.MMCUSR.HeaderText = "Usuario"
        Me.MMCUSR.MinimumWidth = 40
        Me.MMCUSR.Name = "MMCUSR"
        Me.MMCUSR.ReadOnly = True
        Me.MMCUSR.Width = 76
        '
        'MMNUSR
        '
        Me.MMNUSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMNUSR.DataPropertyName = "MMNUSR"
        Me.MMNUSR.FillWeight = 73.70112!
        Me.MMNUSR.HeaderText = "Nombre"
        Me.MMNUSR.MinimumWidth = 120
        Me.MMNUSR.Name = "MMNUSR"
        Me.MMNUSR.ReadOnly = True
        Me.MMNUSR.Width = 120
        '
        'DES_APLC
        '
        Me.DES_APLC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DES_APLC.DataPropertyName = "DES_APLC"
        Me.DES_APLC.FillWeight = 73.70112!
        Me.DES_APLC.HeaderText = "Aplicación"
        Me.DES_APLC.MinimumWidth = 150
        Me.DES_APLC.Name = "DES_APLC"
        Me.DES_APLC.ReadOnly = True
        Me.DES_APLC.Width = 150
        '
        'DES_MENU
        '
        Me.DES_MENU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DES_MENU.DataPropertyName = "DES_MENU"
        Me.DES_MENU.FillWeight = 73.70112!
        Me.DES_MENU.HeaderText = "Menú"
        Me.DES_MENU.MinimumWidth = 150
        Me.DES_MENU.Name = "DES_MENU"
        Me.DES_MENU.ReadOnly = True
        Me.DES_MENU.Width = 150
        '
        'DES_OPCN
        '
        Me.DES_OPCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DES_OPCN.DataPropertyName = "DES_OPCN"
        Me.DES_OPCN.FillWeight = 73.70112!
        Me.DES_OPCN.HeaderText = "Opción"
        Me.DES_OPCN.MinimumWidth = 100
        Me.DES_OPCN.Name = "DES_OPCN"
        Me.DES_OPCN.ReadOnly = True
        '
        'STSVIS
        '
        Me.STSVIS.DataPropertyName = "STSVIS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSVIS.DefaultCellStyle = DataGridViewCellStyle2
        Me.STSVIS.FillWeight = 73.70112!
        Me.STSVIS.HeaderText = "Visualizar"
        Me.STSVIS.MinimumWidth = 50
        Me.STSVIS.Name = "STSVIS"
        Me.STSVIS.ReadOnly = True
        '
        'STSADI
        '
        Me.STSADI.DataPropertyName = "STSADI"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSADI.DefaultCellStyle = DataGridViewCellStyle3
        Me.STSADI.FillWeight = 73.70112!
        Me.STSADI.HeaderText = "Adicionar"
        Me.STSADI.MinimumWidth = 50
        Me.STSADI.Name = "STSADI"
        Me.STSADI.ReadOnly = True
        '
        'STSCHG
        '
        Me.STSCHG.DataPropertyName = "STSCHG"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSCHG.DefaultCellStyle = DataGridViewCellStyle4
        Me.STSCHG.FillWeight = 73.70112!
        Me.STSCHG.HeaderText = "Cambiar"
        Me.STSCHG.MinimumWidth = 50
        Me.STSCHG.Name = "STSCHG"
        Me.STSCHG.ReadOnly = True
        '
        'STSELI
        '
        Me.STSELI.DataPropertyName = "STSELI"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSELI.DefaultCellStyle = DataGridViewCellStyle5
        Me.STSELI.FillWeight = 73.70112!
        Me.STSELI.HeaderText = "Eliminar"
        Me.STSELI.MinimumWidth = 50
        Me.STSELI.Name = "STSELI"
        Me.STSELI.ReadOnly = True
        '
        'STSOP1
        '
        Me.STSOP1.DataPropertyName = "STSOP1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSOP1.DefaultCellStyle = DataGridViewCellStyle6
        Me.STSOP1.FillWeight = 73.70112!
        Me.STSOP1.HeaderText = "Opción 1"
        Me.STSOP1.MinimumWidth = 50
        Me.STSOP1.Name = "STSOP1"
        Me.STSOP1.ReadOnly = True
        '
        'STSOP2
        '
        Me.STSOP2.DataPropertyName = "STSOP2"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSOP2.DefaultCellStyle = DataGridViewCellStyle7
        Me.STSOP2.FillWeight = 73.70112!
        Me.STSOP2.HeaderText = "Opción 2"
        Me.STSOP2.MinimumWidth = 50
        Me.STSOP2.Name = "STSOP2"
        Me.STSOP2.ReadOnly = True
        '
        'STSOP3
        '
        Me.STSOP3.DataPropertyName = "STSOP3"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.STSOP3.DefaultCellStyle = DataGridViewCellStyle8
        Me.STSOP3.FillWeight = 225.3283!
        Me.STSOP3.HeaderText = "Opción 3"
        Me.STSOP3.MinimumWidth = 50
        Me.STSOP3.Name = "STSOP3"
        Me.STSOP3.ReadOnly = True
        '
        'tsCabecera
        '
        Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportar, Me.btnEliminar, Me.btnModificar, Me.btnNuevo, Me.btnCheck, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
        Me.tsCabecera.Name = "tsCabecera"
        Me.tsCabecera.Size = New System.Drawing.Size(696, 25)
        Me.tsCabecera.TabIndex = 76
        Me.tsCabecera.Text = "ToolStrip1"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(76, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnNuevo.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnCheck
        '
        Me.btnCheck.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.btnNoMarcarItems
        Me.btnCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(92, 22)
        Me.btnCheck.Text = "Check Todos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel1.Text = "Usuarios"
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.excel1
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'ucOpcionMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Name = "ucOpcionMain"
        Me.Size = New System.Drawing.Size(696, 502)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCabecera.ResumeLayout(False)
        Me.tsCabecera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents Uc_CboMenu As Ransa.Controls.Menu.uc_CboMenu
  Friend WithEvents Uc_CboAplicacion As Ransa.Controls.Menu.uc_CboAplicacion
  Friend WithEvents txtCodigo As Ransa.Utilitario.clsTextBoxNumero
  Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents UcOpcionBusq As Ransa.Controls.Menu.ucOpcionBusq
  Friend WithEvents dgvUsuario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
  Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnCheck As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CHK_USUARIO As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCMNU As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCOPC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMCUSR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents MMNUSR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DES_APLC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DES_MENU As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DES_OPCN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSVIS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSADI As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSCHG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSELI As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSOP1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents STSOP2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STSOP3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton

End Class
