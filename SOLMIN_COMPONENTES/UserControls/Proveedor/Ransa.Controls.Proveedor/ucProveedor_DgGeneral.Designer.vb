<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProveedor_DgGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucProveedor_DgGeneral))
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btnImportar = New System.Windows.Forms.ToolStripButton()
        Me.UcPaginacion = New Ransa.Utilitario.UCPaginacion()
        Me.dgProveedor = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.PNCPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMCOMPLETO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRCOMPLETO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTPRVCL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTPRCL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTNACPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTDRPRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNCPAIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTNROFX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTLFNO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTEMAI2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTPRSCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTLFNO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSTEMAI3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNNDSDMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSSESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbEliminar, Me.tsbModificar, Me.tsbAgregar, Me.btnImportar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(897, 27)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(125, 24)
        Me.ToolStripLabel1.Tag = "PROVEEDORES"
        Me.ToolStripLabel1.Text = "PROVEEDORES"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(87, 24)
        Me.tsbEliminar.Text = "&Eliminar"
        '
        'tsbModificar
        '
        Me.tsbModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbModificar.Image = CType(resources.GetObject("tsbModificar.Image"), System.Drawing.Image)
        Me.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificar.Name = "tsbModificar"
        Me.tsbModificar.Size = New System.Drawing.Size(97, 24)
        Me.tsbModificar.Text = "&Modificar"
        '
        'tsbAgregar
        '
        Me.tsbAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregar.Image = CType(resources.GetObject("tsbAgregar.Image"), System.Drawing.Image)
        Me.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregar.Name = "tsbAgregar"
        Me.tsbAgregar.Size = New System.Drawing.Size(87, 24)
        Me.tsbAgregar.Text = "&Agregar"
        '
        'btnImportar
        '
        Me.btnImportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImportar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.cofirmacion_2
        Me.btnImportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(91, 24)
        Me.btnImportar.Text = "Importar"
        '
        'UcPaginacion
        '
        Me.UcPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion.Location = New System.Drawing.Point(0, 440)
        Me.UcPaginacion.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPaginacion.Name = "UcPaginacion"
        Me.UcPaginacion.PageCount = 0
        Me.UcPaginacion.PageNumber = 1
        Me.UcPaginacion.PageSize = 20
        Me.UcPaginacion.Size = New System.Drawing.Size(897, 31)
        Me.UcPaginacion.TabIndex = 27
        '
        'dgProveedor
        '
        Me.dgProveedor.AllowUserToAddRows = False
        Me.dgProveedor.AllowUserToDeleteRows = False
        Me.dgProveedor.AllowUserToResizeColumns = False
        Me.dgProveedor.AllowUserToResizeRows = False
        Me.dgProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNCPRVCL, Me.PNNRUCPR, Me.NOMCOMPLETO, Me.DIRCOMPLETO, Me.PSTPRVCL, Me.PSTPRCL1, Me.PSTNACPR, Me.PSTDRPRC, Me.PNCPAIS, Me.PSTNROFX, Me.PSTLFNO1, Me.PSTEMAI2, Me.PSTPRSCN, Me.PSTLFNO2, Me.PSTEMAI3, Me.PNNDSDMP, Me.PSSESTRG})
        Me.dgProveedor.DataMember = "dtRZSC30"
        Me.dgProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProveedor.Location = New System.Drawing.Point(0, 27)
        Me.dgProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.dgProveedor.MultiSelect = False
        Me.dgProveedor.Name = "dgProveedor"
        Me.dgProveedor.ReadOnly = True
        Me.dgProveedor.RowHeadersWidth = 20
        Me.dgProveedor.RowTemplate.ReadOnly = True
        Me.dgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgProveedor.Size = New System.Drawing.Size(897, 413)
        Me.dgProveedor.StandardTab = True
        Me.dgProveedor.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgProveedor.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgProveedor.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgProveedor.TabIndex = 31
        '
        'PNCPRVCL
        '
        Me.PNCPRVCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNCPRVCL.DataPropertyName = "PNCPRVCL"
        Me.PNCPRVCL.HeaderText = "Id Proveedor"
        Me.PNCPRVCL.MaxInputLength = 10
        Me.PNCPRVCL.Name = "PNCPRVCL"
        Me.PNCPRVCL.ReadOnly = True
        Me.PNCPRVCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PNCPRVCL.Width = 104
        '
        'PNNRUCPR
        '
        Me.PNNRUCPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNNRUCPR.DataPropertyName = "PNNRUCPR"
        Me.PNNRUCPR.HeaderText = "Ruc"
        Me.PNNRUCPR.Name = "PNNRUCPR"
        Me.PNNRUCPR.ReadOnly = True
        Me.PNNRUCPR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PNNRUCPR.Width = 43
        '
        'NOMCOMPLETO
        '
        Me.NOMCOMPLETO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOMCOMPLETO.DataPropertyName = "PSNOMCOMPLETO"
        Me.NOMCOMPLETO.HeaderText = "Descripción"
        Me.NOMCOMPLETO.Name = "NOMCOMPLETO"
        Me.NOMCOMPLETO.ReadOnly = True
        Me.NOMCOMPLETO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NOMCOMPLETO.Width = 97
        '
        'DIRCOMPLETO
        '
        Me.DIRCOMPLETO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DIRCOMPLETO.DataPropertyName = "PSDIRCOMPLETO"
        Me.DIRCOMPLETO.HeaderText = "Dirección"
        Me.DIRCOMPLETO.Name = "DIRCOMPLETO"
        Me.DIRCOMPLETO.ReadOnly = True
        Me.DIRCOMPLETO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DIRCOMPLETO.Width = 82
        '
        'PSTPRVCL
        '
        Me.PSTPRVCL.DataPropertyName = "PSTPRVCL"
        Me.PSTPRVCL.HeaderText = "PSTPRVCL"
        Me.PSTPRVCL.Name = "PSTPRVCL"
        Me.PSTPRVCL.ReadOnly = True
        Me.PSTPRVCL.Visible = False
        Me.PSTPRVCL.Width = 108
        '
        'PSTPRCL1
        '
        Me.PSTPRCL1.DataPropertyName = "PSTPRCL1"
        Me.PSTPRCL1.HeaderText = "PSTPRCL1"
        Me.PSTPRCL1.Name = "PSTPRCL1"
        Me.PSTPRCL1.ReadOnly = True
        Me.PSTPRCL1.Visible = False
        Me.PSTPRCL1.Width = 107
        '
        'PSTNACPR
        '
        Me.PSTNACPR.DataPropertyName = "PSTNACPR"
        Me.PSTNACPR.HeaderText = "PSTNACPR"
        Me.PSTNACPR.Name = "PSTNACPR"
        Me.PSTNACPR.ReadOnly = True
        Me.PSTNACPR.Visible = False
        Me.PSTNACPR.Width = 113
        '
        'PSTDRPRC
        '
        Me.PSTDRPRC.DataPropertyName = "PSTDRPRC"
        Me.PSTDRPRC.HeaderText = "PSTDRPRC"
        Me.PSTDRPRC.Name = "PSTDRPRC"
        Me.PSTDRPRC.ReadOnly = True
        Me.PSTDRPRC.Visible = False
        Me.PSTDRPRC.Width = 112
        '
        'PNCPAIS
        '
        Me.PNCPAIS.DataPropertyName = "PNCPAIS"
        Me.PNCPAIS.HeaderText = "PNCPAIS"
        Me.PNCPAIS.Name = "PNCPAIS"
        Me.PNCPAIS.ReadOnly = True
        Me.PNCPAIS.Visible = False
        Me.PNCPAIS.Width = 99
        '
        'PSTNROFX
        '
        Me.PSTNROFX.DataPropertyName = "PSTNROFX"
        Me.PSTNROFX.HeaderText = "PSTNROFX"
        Me.PSTNROFX.Name = "PSTNROFX"
        Me.PSTNROFX.ReadOnly = True
        Me.PSTNROFX.Visible = False
        Me.PSTNROFX.Width = 113
        '
        'PSTLFNO1
        '
        Me.PSTLFNO1.DataPropertyName = "PSTLFNO1"
        Me.PSTLFNO1.HeaderText = "PSTLFNO1"
        Me.PSTLFNO1.Name = "PSTLFNO1"
        Me.PSTLFNO1.ReadOnly = True
        Me.PSTLFNO1.Visible = False
        Me.PSTLFNO1.Width = 110
        '
        'PSTEMAI2
        '
        Me.PSTEMAI2.DataPropertyName = "PSTEMAI2"
        Me.PSTEMAI2.HeaderText = "PSTEMAI2"
        Me.PSTEMAI2.Name = "PSTEMAI2"
        Me.PSTEMAI2.ReadOnly = True
        Me.PSTEMAI2.Visible = False
        Me.PSTEMAI2.Width = 109
        '
        'PSTPRSCN
        '
        Me.PSTPRSCN.DataPropertyName = "PSTPRSCN"
        Me.PSTPRSCN.HeaderText = "PSTPRSCN"
        Me.PSTPRSCN.Name = "PSTPRSCN"
        Me.PSTPRSCN.ReadOnly = True
        Me.PSTPRSCN.Visible = False
        Me.PSTPRSCN.Width = 111
        '
        'PSTLFNO2
        '
        Me.PSTLFNO2.DataPropertyName = "PSTLFNO2"
        Me.PSTLFNO2.HeaderText = "PSTLFNO2"
        Me.PSTLFNO2.Name = "PSTLFNO2"
        Me.PSTLFNO2.ReadOnly = True
        Me.PSTLFNO2.Visible = False
        Me.PSTLFNO2.Width = 110
        '
        'PSTEMAI3
        '
        Me.PSTEMAI3.DataPropertyName = "PSTEMAI3"
        Me.PSTEMAI3.HeaderText = "PSTEMAI3"
        Me.PSTEMAI3.Name = "PSTEMAI3"
        Me.PSTEMAI3.ReadOnly = True
        Me.PSTEMAI3.Visible = False
        Me.PSTEMAI3.Width = 109
        '
        'PNNDSDMP
        '
        Me.PNNDSDMP.DataPropertyName = "PNNDSDMP"
        Me.PNNDSDMP.HeaderText = "PNNDSDMP"
        Me.PNNDSDMP.Name = "PNNDSDMP"
        Me.PNNDSDMP.ReadOnly = True
        Me.PNNDSDMP.Visible = False
        Me.PNNDSDMP.Width = 123
        '
        'PSSESTRG
        '
        Me.PSSESTRG.DataPropertyName = "PSSESTRG"
        Me.PSSESTRG.HeaderText = "PSSESTRG"
        Me.PSSESTRG.Name = "PSSESTRG"
        Me.PSSESTRG.ReadOnly = True
        Me.PSSESTRG.Visible = False
        Me.PSSESTRG.Width = 109
        '
        'ucProveedor_DgGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgProveedor)
        Me.Controls.Add(Me.UcPaginacion)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucProveedor_DgGeneral"
        Me.Size = New System.Drawing.Size(897, 471)
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.dgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents UcPaginacion As Ransa.Utilitario.UCPaginacion
    Private WithEvents dgProveedor As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnImportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PNCPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMCOMPLETO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRCOMPLETO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRVCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRCL1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTNACPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDRPRC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCPAIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTNROFX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTLFNO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTEMAI2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPRSCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTLFNO2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTEMAI3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNDSDMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSSESTRG As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
