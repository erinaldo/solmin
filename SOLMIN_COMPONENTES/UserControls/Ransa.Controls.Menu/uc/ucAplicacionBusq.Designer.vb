<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAplicacionBusq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucAplicacionBusq))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAplicaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsCabecera = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.btnMenu = New System.Windows.Forms.ToolStripButton()
        Me.lblAplicaciones = New System.Windows.Forms.ToolStripLabel()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMDAPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENUS = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OPCION = New System.Windows.Forms.DataGridViewImageColumn()
        Me.USUARIOS = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvAplicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAplicaciones
        '
        Me.dgvAplicaciones.AllowUserToAddRows = False
        Me.dgvAplicaciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAplicaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAplicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAplicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAplicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMCAPL, Me.MMDAPL, Me.MENUS, Me.OPCION, Me.USUARIOS})
        Me.dgvAplicaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAplicaciones.Location = New System.Drawing.Point(0, 27)
        Me.dgvAplicaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvAplicaciones.MultiSelect = False
        Me.dgvAplicaciones.Name = "dgvAplicaciones"
        Me.dgvAplicaciones.ReadOnly = True
        Me.dgvAplicaciones.RowHeadersWidth = 10
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvAplicaciones.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAplicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAplicaciones.Size = New System.Drawing.Size(817, 229)
        Me.dgvAplicaciones.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvAplicaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvAplicaciones.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dgvAplicaciones.TabIndex = 71
        '
        'tsCabecera
        '
        Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCabecera.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnExportar, Me.btnMenu, Me.lblAplicaciones, Me.btnEliminar, Me.btnModificar, Me.btnNuevo})
        Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
        Me.tsCabecera.Name = "tsCabecera"
        Me.tsCabecera.Size = New System.Drawing.Size(817, 27)
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
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 24)
        Me.btnExportar.Text = "Exportar"
        '
        'btnMenu
        '
        Me.btnMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnMenu.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.ark_selectall
        Me.btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(70, 24)
        Me.btnMenu.Text = "Menú"
        '
        'lblAplicaciones
        '
        Me.lblAplicaciones.Name = "lblAplicaciones"
        Me.lblAplicaciones.Size = New System.Drawing.Size(93, 24)
        Me.lblAplicaciones.Text = "Aplicaciones"
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
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MMCAPL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MMDAPL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 270
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MENUS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "# Menús"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OPCION"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "# Opciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "USUARIOS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "# Usuarios"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'MMCAPL
        '
        Me.MMCAPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMCAPL.DataPropertyName = "MMCAPL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MMCAPL.DefaultCellStyle = DataGridViewCellStyle2
        Me.MMCAPL.HeaderText = "Código"
        Me.MMCAPL.MinimumWidth = 50
        Me.MMCAPL.Name = "MMCAPL"
        Me.MMCAPL.ReadOnly = True
        Me.MMCAPL.Width = 91
        '
        'MMDAPL
        '
        Me.MMDAPL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MMDAPL.DataPropertyName = "MMDAPL"
        Me.MMDAPL.HeaderText = "Descripción"
        Me.MMDAPL.MinimumWidth = 270
        Me.MMDAPL.Name = "MMDAPL"
        Me.MMDAPL.ReadOnly = True
        '
        'MENUS
        '
        Me.MENUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MENUS.DataPropertyName = "MENUS"
        Me.MENUS.HeaderText = "# Menús"
        Me.MENUS.MinimumWidth = 180
        Me.MENUS.Name = "MENUS"
        Me.MENUS.ReadOnly = True
        Me.MENUS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MENUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MENUS.Visible = False
        Me.MENUS.Width = 180
        '
        'OPCION
        '
        Me.OPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OPCION.DataPropertyName = "OPCION"
        Me.OPCION.HeaderText = "# Opciones"
        Me.OPCION.MinimumWidth = 250
        Me.OPCION.Name = "OPCION"
        Me.OPCION.ReadOnly = True
        Me.OPCION.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OPCION.Visible = False
        Me.OPCION.Width = 250
        '
        'USUARIOS
        '
        Me.USUARIOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUARIOS.DataPropertyName = "USUARIOS"
        Me.USUARIOS.HeaderText = "# Usuarios"
        Me.USUARIOS.MinimumWidth = 300
        Me.USUARIOS.Name = "USUARIOS"
        Me.USUARIOS.ReadOnly = True
        Me.USUARIOS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.USUARIOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.USUARIOS.Visible = False
        Me.USUARIOS.Width = 300
        '
        'ucAplicacionBusq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvAplicaciones)
        Me.Controls.Add(Me.tsCabecera)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucAplicacionBusq"
        Me.Size = New System.Drawing.Size(817, 256)
        CType(Me.dgvAplicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCabecera.ResumeLayout(False)
        Me.tsCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAplicaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblAplicaciones As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDAPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MENUS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents OPCION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents USUARIOS As System.Windows.Forms.DataGridViewImageColumn

End Class
