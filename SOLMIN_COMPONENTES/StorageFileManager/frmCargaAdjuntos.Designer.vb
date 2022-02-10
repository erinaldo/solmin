<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaAdjuntos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaAdjuntos))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCheckAll = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtnro_imagen = New System.Windows.Forms.ToolStripTextBox()
        Me.lbladjuntar = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cbomotivo = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtglistaDoc = New System.Windows.Forms.DataGridView()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VERIMG = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TNMBAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MTVIMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRIMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NMRGIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPIMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPFILE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMTVIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCAPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboOrigen = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtglistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NMRGIM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Archivo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NCRIMG"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TNMBAR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ref."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MTVIMG"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Acción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "REFDOC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ref."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VERIMG"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Acción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TPFILE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TIPIMG"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IMTVIM"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TPFILE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MMCAPL"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IMTVIM"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "MMCAPL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "VERIMG"
        Me.DataGridViewImageColumn1.HeaderText = "Acción"
        Me.DataGridViewImageColumn1.Image = Global.StorageFileManager.My.Resources.Resources.eye
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCheckAll, Me.btnCancelar, Me.btnEliminar, Me.ToolStripLabel1, Me.txtnro_imagen, Me.lbladjuntar, Me.cboOrigen})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1113, 28)
        Me.MenuBar.TabIndex = 4
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCheckAll
        '
        Me.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCheckAll.Image = CType(resources.GetObject("btnCheckAll.Image"), System.Drawing.Image)
        Me.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(74, 25)
        Me.btnCheckAll.Text = "Check All"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.StorageFileManager.My.Resources.Resources.cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 25)
        Me.btnCancelar.Text = " Cancelar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.StorageFileManager.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 25)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(91, 25)
        Me.ToolStripLabel1.Text = "Nro Imagen:"
        '
        'txtnro_imagen
        '
        Me.txtnro_imagen.Name = "txtnro_imagen"
        Me.txtnro_imagen.ReadOnly = True
        Me.txtnro_imagen.Size = New System.Drawing.Size(100, 28)
        '
        'lbladjuntar
        '
        Me.lbladjuntar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladjuntar.Name = "lbladjuntar"
        Me.lbladjuntar.Size = New System.Drawing.Size(21, 25)
        Me.lbladjuntar.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSeleccionar)
        Me.Panel1.Controls.Add(Me.txtref)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.cbomotivo)
        Me.Panel1.Controls.Add(Me.KryptonLabel19)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1113, 89)
        Me.Panel1.TabIndex = 5
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.White
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Image = Global.StorageFileManager.My.Resources.Resources.fileopen
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(383, 49)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(127, 28)
        Me.btnSeleccionar.TabIndex = 114
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(83, 52)
        Me.txtref.Margin = New System.Windows.Forms.Padding(4)
        Me.txtref.MaxLength = 20
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(292, 22)
        Me.txtref.TabIndex = 110
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 53)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(36, 21)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 109
        Me.KryptonLabel1.Text = "Ref."
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Ref."
        '
        'cbomotivo
        '
        Me.cbomotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomotivo.Enabled = False
        Me.cbomotivo.FormattingEnabled = True
        Me.cbomotivo.Location = New System.Drawing.Point(83, 18)
        Me.cbomotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbomotivo.Name = "cbomotivo"
        Me.cbomotivo.Size = New System.Drawing.Size(292, 24)
        Me.cbomotivo.TabIndex = 108
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(13, 21)
        Me.KryptonLabel19.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(52, 21)
        Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel19.TabIndex = 105
        Me.KryptonLabel19.Text = "Motivo"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Motivo"
        '
        'dtglistaDoc
        '
        Me.dtglistaDoc.AllowUserToAddRows = False
        Me.dtglistaDoc.AllowUserToDeleteRows = False
        Me.dtglistaDoc.AllowUserToResizeRows = False
        Me.dtglistaDoc.BackgroundColor = System.Drawing.Color.White
        Me.dtglistaDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistaDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.VERIMG, Me.TNMBAR, Me.MTVIMG, Me.REFDOC, Me.NCRIMG, Me.NMRGIM, Me.TIPIMG, Me.TPFILE, Me.IMTVIM, Me.COL, Me.MMCAPL})
        Me.dtglistaDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglistaDoc.GridColor = System.Drawing.Color.White
        Me.dtglistaDoc.Location = New System.Drawing.Point(0, 117)
        Me.dtglistaDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.dtglistaDoc.MultiSelect = False
        Me.dtglistaDoc.Name = "dtglistaDoc"
        Me.dtglistaDoc.RowHeadersVisible = False
        Me.dtglistaDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtglistaDoc.Size = New System.Drawing.Size(1113, 410)
        Me.dtglistaDoc.TabIndex = 6
        '
        'Sel
        '
        Me.Sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Sel.DataPropertyName = "SEL"
        Me.Sel.FalseValue = "false"
        Me.Sel.HeaderText = "Check"
        Me.Sel.MinimumWidth = 10
        Me.Sel.Name = "Sel"
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.TrueValue = "true"
        Me.Sel.Width = 76
        '
        'VERIMG
        '
        Me.VERIMG.DataPropertyName = "VERIMG"
        Me.VERIMG.HeaderText = "Visualizar"
        Me.VERIMG.Image = Global.StorageFileManager.My.Resources.Resources.eye
        Me.VERIMG.Name = "VERIMG"
        Me.VERIMG.ReadOnly = True
        Me.VERIMG.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VERIMG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TNMBAR
        '
        Me.TNMBAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TNMBAR.DataPropertyName = "TNMBAR"
        Me.TNMBAR.HeaderText = "Archivo"
        Me.TNMBAR.Name = "TNMBAR"
        Me.TNMBAR.ReadOnly = True
        Me.TNMBAR.Width = 84
        '
        'MTVIMG
        '
        Me.MTVIMG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MTVIMG.DataPropertyName = "MTVIMG"
        Me.MTVIMG.HeaderText = "Motivo"
        Me.MTVIMG.Name = "MTVIMG"
        Me.MTVIMG.ReadOnly = True
        Me.MTVIMG.Width = 78
        '
        'REFDOC
        '
        Me.REFDOC.DataPropertyName = "REFDOC"
        Me.REFDOC.HeaderText = "Referencia"
        Me.REFDOC.Name = "REFDOC"
        Me.REFDOC.ReadOnly = True
        Me.REFDOC.Width = 200
        '
        'NCRIMG
        '
        Me.NCRIMG.DataPropertyName = "NCRIMG"
        Me.NCRIMG.HeaderText = "NCRIMG"
        Me.NCRIMG.Name = "NCRIMG"
        Me.NCRIMG.ReadOnly = True
        Me.NCRIMG.Visible = False
        '
        'NMRGIM
        '
        Me.NMRGIM.DataPropertyName = "NMRGIM"
        Me.NMRGIM.HeaderText = "NMRGIM"
        Me.NMRGIM.Name = "NMRGIM"
        Me.NMRGIM.ReadOnly = True
        Me.NMRGIM.Visible = False
        '
        'TIPIMG
        '
        Me.TIPIMG.DataPropertyName = "TIPIMG"
        Me.TIPIMG.HeaderText = "TIPIMG"
        Me.TIPIMG.Name = "TIPIMG"
        Me.TIPIMG.ReadOnly = True
        Me.TIPIMG.Visible = False
        '
        'TPFILE
        '
        Me.TPFILE.DataPropertyName = "TPFILE"
        Me.TPFILE.HeaderText = "TPFILE"
        Me.TPFILE.Name = "TPFILE"
        Me.TPFILE.ReadOnly = True
        Me.TPFILE.Visible = False
        '
        'IMTVIM
        '
        Me.IMTVIM.DataPropertyName = "IMTVIM"
        Me.IMTVIM.HeaderText = "IMTVIM"
        Me.IMTVIM.Name = "IMTVIM"
        Me.IMTVIM.ReadOnly = True
        Me.IMTVIM.Visible = False
        '
        'COL
        '
        Me.COL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COL.HeaderText = ""
        Me.COL.Name = "COL"
        Me.COL.ReadOnly = True
        '
        'MMCAPL
        '
        Me.MMCAPL.DataPropertyName = "MMCAPL"
        Me.MMCAPL.HeaderText = "MMCAPL"
        Me.MMCAPL.Name = "MMCAPL"
        Me.MMCAPL.ReadOnly = True
        Me.MMCAPL.Visible = False
        '
        'cboOrigen
        '
        Me.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigen.DropDownWidth = 121
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(121, 28)
        '
        'frmCargaAdjuntos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1113, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtglistaDoc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuBar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCargaAdjuntos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjuntar archivos"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtglistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
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
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbomotivo As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents dtglistaDoc As System.Windows.Forms.DataGridView
    Friend WithEvents txtnro_imagen As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lbladjuntar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnCheckAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sel As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VERIMG As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TNMBAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MTVIMG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRIMG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMRGIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPIMG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPFILE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMTVIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMCAPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboOrigen As System.Windows.Forms.ToolStripComboBox
End Class
