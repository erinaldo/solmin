<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProveedor_DgCab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProveedor_DgCab))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion()
        Me.dgProveedor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.PNCPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSSTPORL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTDRPRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSCPRPCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssSep_02, Me.btnBuscar, Me.btnEliminar, Me.btnAgregar, Me.lblTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(725, 27)
        Me.tsMenuOpciones.TabIndex = 24
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 27)
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 24)
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 24)
        Me.btnAgregar.Text = "Agregar"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(203, 24)
        Me.lblTitulo.Text = "Proveedores Relacionados"
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 463)
        Me.UcPaginacion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(725, 31)
        Me.UcPaginacion.TabIndex = 25
        '
        'dgProveedor
        '
        Me.dgProveedor.AllowUserToAddRows = False
        Me.dgProveedor.AllowUserToDeleteRows = False
        Me.dgProveedor.AllowUserToResizeColumns = False
        Me.dgProveedor.AllowUserToResizeRows = False
        Me.dgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCPRVCL, Me.PSSTPORL, Me.PNNRUCPR, Me.PSTPRVCL, Me.PSTDRPRC, Me.PNCCLNT, Me.PSCPRPCL})
        Me.dgProveedor.DataMember = "dtMercaderia"
        Me.dgProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgProveedor.Location = New System.Drawing.Point(0, 27)
        Me.dgProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgProveedor.MultiSelect = False
        Me.dgProveedor.Name = "dgProveedor"
        Me.dgProveedor.ReadOnly = True
        Me.dgProveedor.RowHeadersWidth = 20
        Me.dgProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgProveedor.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProveedor.Size = New System.Drawing.Size(725, 436)
        Me.dgProveedor.StandardTab = True
        Me.dgProveedor.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgProveedor.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProveedor.TabIndex = 64
        '
        'PNCPRVCL
        '
        Me.PNCPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCPRVCL.DataPropertyName = "PNCPRVCL"
        Me.PNCPRVCL.HeaderText = "Id Proveedor"
        Me.PNCPRVCL.Name = "PNCPRVCL"
        Me.PNCPRVCL.ReadOnly = True
        Me.PNCPRVCL.Width = 127
        '
        'PSSTPORL
        '
        Me.PSSTPORL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSSTPORL.DataPropertyName = "PSSTPORL"
        Me.PSSTPORL.HeaderText = "Tipo"
        Me.PSSTPORL.Name = "PSSTPORL"
        Me.PSSTPORL.ReadOnly = True
        Me.PSSTPORL.Width = 72
        '
        'PNNRUCPR
        '
        Me.PNNRUCPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNRUCPR.DataPropertyName = "PNNRUCPR"
        Me.PNNRUCPR.HeaderText = "RUC"
        Me.PNNRUCPR.Name = "PNNRUCPR"
        Me.PNNRUCPR.ReadOnly = True
        Me.PNNRUCPR.Width = 70
        '
        'PSTPRVCL
        '
        Me.PSTPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTPRVCL.DataPropertyName = "PSTPRVCL"
        Me.PSTPRVCL.HeaderText = "Descripción"
        Me.PSTPRVCL.Name = "PSTPRVCL"
        Me.PSTPRVCL.ReadOnly = True
        Me.PSTPRVCL.Width = 120
        '
        'PSTDRPRC
        '
        Me.PSTDRPRC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTDRPRC.DataPropertyName = "PSTDRPRC"
        Me.PSTDRPRC.HeaderText = "Dirección"
        Me.PSTDRPRC.Name = "PSTDRPRC"
        Me.PSTDRPRC.ReadOnly = True
        Me.PSTDRPRC.Width = 105
        '
        'PNCCLNT
        '
        Me.PNCCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "PNCCLNT"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        Me.PNCCLNT.Width = 105
        '
        'PSCPRPCL
        '
        Me.PSCPRPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCPRPCL.DataPropertyName = "PSCPRPCL"
        Me.PSCPRPCL.HeaderText = "Cód. Cliente - Proveedor"
        Me.PSCPRPCL.Name = "PSCPRPCL"
        Me.PSCPRPCL.ReadOnly = True
        Me.PSCPRPCL.Width = 204
        '
        'ucProveedor_DgCab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgProveedor)
        Me.Controls.Add(Me.UcPaginacion)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucProveedor_DgCab"
        Me.Size = New System.Drawing.Size(725, 494)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
  Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
  Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
  Friend WithEvents dgProveedor As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PNCPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSTPORL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDRPRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCPRPCL As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
