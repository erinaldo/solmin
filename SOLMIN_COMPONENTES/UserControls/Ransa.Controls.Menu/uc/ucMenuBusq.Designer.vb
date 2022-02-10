<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMenuBusq
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMenuBusq))
        Me.dgvMenus = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsCabecera = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnOpcion = New System.Windows.Forms.ToolStripButton()
        Me.lblMenus = New System.Windows.Forms.ToolStripLabel()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCMNU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMTMNU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MENUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPCION = New System.Windows.Forms.DataGridViewImageColumn()
        Me.USUARIOS = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvMenus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMenus
        '
        Me.dgvMenus.AllowUserToAddRows = False
        Me.dgvMenus.AllowUserToDeleteRows = False
        Me.dgvMenus.AllowUserToResizeColumns = False
        Me.dgvMenus.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvMenus.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMenus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMenus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MMCAPL, Me.MMCMNU, Me.MMTMNU, Me.MENUS, Me.OPCION, Me.USUARIOS})
        Me.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMenus.Location = New System.Drawing.Point(0, 27)
        Me.dgvMenus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvMenus.MultiSelect = False
        Me.dgvMenus.Name = "dgvMenus"
        Me.dgvMenus.ReadOnly = True
        Me.dgvMenus.RowHeadersWidth = 10
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvMenus.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMenus.Size = New System.Drawing.Size(1021, 326)
        Me.dgvMenus.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvMenus.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvMenus.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.SystemColors.WindowText
        Me.dgvMenus.TabIndex = 71
        '
        'tsCabecera
        '
        Me.tsCabecera.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tsCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsCabecera.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnOpcion, Me.lblMenus, Me.btnExportar, Me.btnEliminar, Me.btnModificar, Me.btnNuevo})
        Me.tsCabecera.Location = New System.Drawing.Point(0, 0)
        Me.tsCabecera.Name = "tsCabecera"
        Me.tsCabecera.Size = New System.Drawing.Size(1021, 27)
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
        'btnOpcion
        '
        Me.btnOpcion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnOpcion.Image = Global.Ransa.Controls.Menu.My.Resources.Resources.ark_selectall
        Me.btnOpcion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(95, 24)
        Me.btnOpcion.Text = "Opciones"
        '
        'lblMenus
        '
        Me.lblMenus.Name = "lblMenus"
        Me.lblMenus.Size = New System.Drawing.Size(119, 24)
        Me.lblMenus.Text = "Listado de Menú"
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
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MMCMNU"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.FillWeight = 101.5228!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MMTMNU"
        Me.DataGridViewTextBoxColumn3.FillWeight = 99.49239!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 270
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MENUS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "# Menús"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'MMCAPL
        '
        Me.MMCAPL.DataPropertyName = "MMCAPL"
        Me.MMCAPL.HeaderText = "MMCAPL"
        Me.MMCAPL.MinimumWidth = 2
        Me.MMCAPL.Name = "MMCAPL"
        Me.MMCAPL.ReadOnly = True
        Me.MMCAPL.Visible = False
        '
        'MMCMNU
        '
        Me.MMCMNU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MMCMNU.DataPropertyName = "MMCMNU"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MMCMNU.DefaultCellStyle = DataGridViewCellStyle2
        Me.MMCMNU.HeaderText = "Código"
        Me.MMCMNU.MinimumWidth = 50
        Me.MMCMNU.Name = "MMCMNU"
        Me.MMCMNU.ReadOnly = True
        Me.MMCMNU.Width = 91
        '
        'MMTMNU
        '
        Me.MMTMNU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MMTMNU.DataPropertyName = "MMTMNU"
        Me.MMTMNU.HeaderText = "Descripción"
        Me.MMTMNU.MinimumWidth = 450
        Me.MMTMNU.Name = "MMTMNU"
        Me.MMTMNU.ReadOnly = True
        '
        'MENUS
        '
        Me.MENUS.DataPropertyName = "MENUS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.MENUS.DefaultCellStyle = DataGridViewCellStyle3
        Me.MENUS.HeaderText = "# Menús"
        Me.MENUS.MinimumWidth = 2
        Me.MENUS.Name = "MENUS"
        Me.MENUS.ReadOnly = True
        Me.MENUS.Visible = False
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        Me.USUARIOS.DefaultCellStyle = DataGridViewCellStyle4
        Me.USUARIOS.HeaderText = "# Usuarios"
        Me.USUARIOS.MinimumWidth = 300
        Me.USUARIOS.Name = "USUARIOS"
        Me.USUARIOS.ReadOnly = True
        Me.USUARIOS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.USUARIOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.USUARIOS.Visible = False
        Me.USUARIOS.Width = 300
        '
        'ucMenuBusq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvMenus)
        Me.Controls.Add(Me.tsCabecera)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucMenuBusq"
        Me.Size = New System.Drawing.Size(1021, 353)
        CType(Me.dgvMenus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsCabecera.ResumeLayout(False)
        Me.tsCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMenus As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsCabecera As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblMenus As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnOpcion As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCMNU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMTMNU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MENUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OPCION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents USUARIOS As System.Windows.Forms.DataGridViewImageColumn

End Class
