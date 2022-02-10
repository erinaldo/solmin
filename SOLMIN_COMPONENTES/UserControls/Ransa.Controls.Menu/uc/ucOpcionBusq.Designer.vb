<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOpcionBusq
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucOpcionBusq))
        Me.dgvOpciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsCabecera = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnExport = New System.Windows.Forms.ToolStripSplitButton()
        Me.btnExportOpcion = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExportUsuarioOpcion = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOpcion = New System.Windows.Forms.ToolStripLabel()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
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
        Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMDAPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMTMNU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCMNU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCOPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMDOPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMTOPCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMDAIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMDMIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMNPVB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIOS = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MMNPRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMTOPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCMIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCAIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMTVAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMNFUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMNPGM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URLIMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvOpciones
        '
        Me.dgvOpciones.AllowUserToAddRows = False
        Me.dgvOpciones.AllowUserToDeleteRows = False
        Me.dgvOpciones.AllowUserToResizeColumns = False
        Me.dgvOpciones.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvOpciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOpciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOpciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMCAPL, Me.MMDAPL, Me.MMTMNU, Me.MMCMNU, Me.MMCOPC, Me.MMDOPC, Me.MMTOPCD, Me.MMDAIN, Me.MMDMIN, Me.MMNPVB, Me.USUARIOS, Me.MMNPRO, Me.MMTOPC, Me.MMCMIN, Me.MMCAIN, Me.MMTVAR, Me.MMNFUN, Me.MMNPGM, Me.URLIMG})
        Me.dgvOpciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOpciones.Location = New System.Drawing.Point(0, 27)
        Me.dgvOpciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvOpciones.MultiSelect = False
        Me.dgvOpciones.Name = "dgvOpciones"
        Me.dgvOpciones.ReadOnly = True
        Me.dgvOpciones.RowHeadersWidth = 10
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvOpciones.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOpciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOpciones.Size = New System.Drawing.Size(760, 305)
        Me.dgvOpciones.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvOpciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvOpciones.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dgvOpciones.TabIndex = 71
        '
        'tsCabecera
        '
        Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCabecera.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExport, Me.lblOpcion, Me.btnEliminar, Me.btnModificar, Me.btnNuevo})
        Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
        Me.tsCabecera.Name = "tsCabecera"
        Me.tsCabecera.Size = New System.Drawing.Size(760, 27)
        Me.tsCabecera.TabIndex = 70
        Me.tsCabecera.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnExport
        '
        Me.btnExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportOpcion, Me.btnExportUsuarioOpcion})
        Me.btnExport.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.excel1
        Me.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 24)
        Me.btnExport.Text = "Exportar"
        '
        'btnExportOpcion
        '
        Me.btnExportOpcion.Name = "btnExportOpcion"
        Me.btnExportOpcion.Size = New System.Drawing.Size(197, 26)
        Me.btnExportOpcion.Text = "Opciones"
        '
        'btnExportUsuarioOpcion
        '
        Me.btnExportUsuarioOpcion.Name = "btnExportUsuarioOpcion"
        Me.btnExportUsuarioOpcion.Size = New System.Drawing.Size(197, 26)
        Me.btnExportUsuarioOpcion.Text = "Usuario x Opción"
        '
        'lblOpcion
        '
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(142, 24)
        Me.lblOpcion.Text = "Listado de opciones"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 24)
        Me.btnModificar.Text = "Modificar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnNuevo.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(76, 24)
        Me.btnNuevo.Text = "Nuevo"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MMCAPL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MMCAPL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MMDAPL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MMDAPL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MMTMNU"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MMTMNU"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MMCMNU"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MMCMNU"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MMCOPC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MMDOPC"
        Me.DataGridViewTextBoxColumn6.FillWeight = 178.7234!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 270
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MMNPVB"
        Me.DataGridViewTextBoxColumn7.FillWeight = 21.2766!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nombre Programa"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 270
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MMCAIN"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MMCAIN"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MMCMIN"
        Me.DataGridViewTextBoxColumn9.HeaderText = "MMCMIN"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 250
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MMTOPC"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MMTOPC"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 250
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "MMTVAR"
        Me.DataGridViewTextBoxColumn11.HeaderText = "MMTVAR"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "MMNPRO"
        Me.DataGridViewTextBoxColumn12.HeaderText = "MMNPRO"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "MMNFUN"
        Me.DataGridViewTextBoxColumn13.HeaderText = "MMNFUN"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MMNPGM"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MMNPGM"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "URLIMG"
        Me.DataGridViewTextBoxColumn15.HeaderText = "URLIMG"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "MMNPGM"
        Me.DataGridViewTextBoxColumn16.HeaderText = "MMNPGM"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "URLIMG"
        Me.DataGridViewTextBoxColumn17.HeaderText = "URLIMG"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "URLIMG"
        Me.DataGridViewTextBoxColumn18.HeaderText = "URLIMG"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'MMCAPL
        '
        Me.MMCAPL.DataPropertyName = "MMCAPL"
        Me.MMCAPL.HeaderText = "MMCAPL"
        Me.MMCAPL.Name = "MMCAPL"
        Me.MMCAPL.ReadOnly = True
        Me.MMCAPL.Visible = False
        '
        'MMDAPL
        '
        Me.MMDAPL.DataPropertyName = "MMDAPL"
        Me.MMDAPL.HeaderText = "MMDAPL"
        Me.MMDAPL.Name = "MMDAPL"
        Me.MMDAPL.ReadOnly = True
        Me.MMDAPL.Visible = False
        '
        'MMTMNU
        '
        Me.MMTMNU.DataPropertyName = "MMTMNU"
        Me.MMTMNU.HeaderText = "MMTMNU"
        Me.MMTMNU.Name = "MMTMNU"
        Me.MMTMNU.ReadOnly = True
        Me.MMTMNU.Visible = False
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
        Me.MMCOPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMCOPC.DataPropertyName = "MMCOPC"
        Me.MMCOPC.HeaderText = "Código"
        Me.MMCOPC.MinimumWidth = 50
        Me.MMCOPC.Name = "MMCOPC"
        Me.MMCOPC.ReadOnly = True
        Me.MMCOPC.Width = 91
        '
        'MMDOPC
        '
        Me.MMDOPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MMDOPC.DataPropertyName = "MMDOPC"
        Me.MMDOPC.HeaderText = "Descripción"
        Me.MMDOPC.MinimumWidth = 200
        Me.MMDOPC.Name = "MMDOPC"
        Me.MMDOPC.ReadOnly = True
        '
        'MMTOPCD
        '
        Me.MMTOPCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMTOPCD.DataPropertyName = "MMTOPCD"
        Me.MMTOPCD.HeaderText = "Tipo"
        Me.MMTOPCD.MinimumWidth = 50
        Me.MMTOPCD.Name = "MMTOPCD"
        Me.MMTOPCD.ReadOnly = True
        Me.MMTOPCD.Width = 72
        '
        'MMDAIN
        '
        Me.MMDAIN.DataPropertyName = "MMDAIN"
        Me.MMDAIN.HeaderText = "Aplicación Inicial"
        Me.MMDAIN.MinimumWidth = 180
        Me.MMDAIN.Name = "MMDAIN"
        Me.MMDAIN.ReadOnly = True
        '
        'MMDMIN
        '
        Me.MMDMIN.DataPropertyName = "MMDMIN"
        Me.MMDMIN.HeaderText = "Menú Inicial"
        Me.MMDMIN.MinimumWidth = 180
        Me.MMDMIN.Name = "MMDMIN"
        Me.MMDMIN.ReadOnly = True
        '
        'MMNPVB
        '
        Me.MMNPVB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMNPVB.DataPropertyName = "MMNPVB"
        Me.MMNPVB.HeaderText = "Nombre Programa"
        Me.MMNPVB.MinimumWidth = 200
        Me.MMNPVB.Name = "MMNPVB"
        Me.MMNPVB.ReadOnly = True
        Me.MMNPVB.Width = 200
        '
        'USUARIOS
        '
        Me.USUARIOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUARIOS.DataPropertyName = "USUARIOS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        Me.USUARIOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.USUARIOS.HeaderText = "# Usuarios"
        Me.USUARIOS.MinimumWidth = 300
        Me.USUARIOS.Name = "USUARIOS"
        Me.USUARIOS.ReadOnly = True
        Me.USUARIOS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.USUARIOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.USUARIOS.Visible = False
        Me.USUARIOS.Width = 300
        '
        'MMNPRO
        '
        Me.MMNPRO.DataPropertyName = "MMNPRO"
        Me.MMNPRO.HeaderText = "MMNPRO"
        Me.MMNPRO.Name = "MMNPRO"
        Me.MMNPRO.ReadOnly = True
        Me.MMNPRO.Visible = False
        '
        'MMTOPC
        '
        Me.MMTOPC.DataPropertyName = "MMTOPC"
        Me.MMTOPC.HeaderText = "MMTOPC"
        Me.MMTOPC.Name = "MMTOPC"
        Me.MMTOPC.ReadOnly = True
        Me.MMTOPC.Visible = False
        '
        'MMCMIN
        '
        Me.MMCMIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMCMIN.DataPropertyName = "MMCMIN"
        Me.MMCMIN.HeaderText = "Cod. Menú Inicial"
        Me.MMCMIN.MinimumWidth = 180
        Me.MMCMIN.Name = "MMCMIN"
        Me.MMCMIN.ReadOnly = True
        Me.MMCMIN.Visible = False
        Me.MMCMIN.Width = 180
        '
        'MMCAIN
        '
        Me.MMCAIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMCAIN.DataPropertyName = "MMCAIN"
        Me.MMCAIN.HeaderText = "Cod. Aplicación Inicial"
        Me.MMCAIN.MinimumWidth = 180
        Me.MMCAIN.Name = "MMCAIN"
        Me.MMCAIN.ReadOnly = True
        Me.MMCAIN.Visible = False
        Me.MMCAIN.Width = 189
        '
        'MMTVAR
        '
        Me.MMTVAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMTVAR.DataPropertyName = "MMTVAR"
        Me.MMTVAR.HeaderText = "MMTVAR"
        Me.MMTVAR.MinimumWidth = 50
        Me.MMTVAR.Name = "MMTVAR"
        Me.MMTVAR.ReadOnly = True
        Me.MMTVAR.Visible = False
        Me.MMTVAR.Width = 103
        '
        'MMNFUN
        '
        Me.MMNFUN.DataPropertyName = "MMNFUN"
        Me.MMNFUN.HeaderText = "MMNFUN"
        Me.MMNFUN.Name = "MMNFUN"
        Me.MMNFUN.ReadOnly = True
        Me.MMNFUN.Visible = False
        '
        'MMNPGM
        '
        Me.MMNPGM.DataPropertyName = "MMNPGM"
        Me.MMNPGM.HeaderText = "MMNPGM"
        Me.MMNPGM.Name = "MMNPGM"
        Me.MMNPGM.ReadOnly = True
        Me.MMNPGM.Visible = False
        '
        'URLIMG
        '
        Me.URLIMG.DataPropertyName = "URLIMG"
        Me.URLIMG.HeaderText = "URLIMG"
        Me.URLIMG.Name = "URLIMG"
        Me.URLIMG.ReadOnly = True
        Me.URLIMG.Visible = False
        '
        'ucOpcionBusq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvOpciones)
        Me.Controls.Add(Me.tsCabecera)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucOpcionBusq"
        Me.Size = New System.Drawing.Size(760, 332)
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCabecera.ResumeLayout(False)
        Me.tsCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvOpciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblOpcion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents btnExport As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents btnExportOpcion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExportUsuarioOpcion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDAPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMTMNU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCMNU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCOPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDOPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMTOPCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDAIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDMIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMNPVB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USUARIOS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents MMNPRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMTOPC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCMIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCAIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMTVAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMNFUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMNPGM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents URLIMG As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
