<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cbomotivo = New System.Windows.Forms.ComboBox()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dtglistaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dtglistaDoc, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(871, 410)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'dtglistaDoc
        '
        Me.dtglistaDoc.AllowUserToAddRows = False
        Me.dtglistaDoc.AllowUserToDeleteRows = False
        Me.dtglistaDoc.BackgroundColor = System.Drawing.Color.White
        Me.dtglistaDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistaDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sel, Me.VERIMG, Me.TNMBAR, Me.MTVIMG, Me.REFDOC, Me.NCRIMG, Me.NMRGIM, Me.TIPIMG, Me.TPFILE, Me.IMTVIM, Me.COL, Me.MMCAPL})
        Me.dtglistaDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglistaDoc.GridColor = System.Drawing.Color.White
        Me.dtglistaDoc.Location = New System.Drawing.Point(4, 164)
        Me.dtglistaDoc.Margin = New System.Windows.Forms.Padding(4)
        Me.dtglistaDoc.MultiSelect = False
        Me.dtglistaDoc.Name = "dtglistaDoc"
        Me.dtglistaDoc.RowHeadersVisible = False
        Me.dtglistaDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtglistaDoc.Size = New System.Drawing.Size(863, 242)
        Me.dtglistaDoc.TabIndex = 1
        '
        'Sel
        '
        Me.Sel.DataPropertyName = "SEL"
        Me.Sel.FalseValue = "false"
        Me.Sel.HeaderText = "Check"
        Me.Sel.Name = "Sel"
        Me.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Sel.TrueValue = "true"
        Me.Sel.Width = 50
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.14286!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.85714!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 599.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtruta, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.KryptonLabel1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.KryptonLabel2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.cbomotivo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtref, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSeleccionar, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.KryptonLabel19, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(863, 152)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'txtruta
        '
        Me.txtruta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtruta.Enabled = False
        Me.txtruta.Location = New System.Drawing.Point(62, 118)
        Me.txtruta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(197, 22)
        Me.txtruta.TabIndex = 109
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 61)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(36, 21)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 105
        Me.KryptonLabel1.Text = "Ref."
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Ref."
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(4, 118)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(50, 21)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 106
        Me.KryptonLabel2.Text = "Examinar"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Examinar"
        '
        'cbomotivo
        '
        Me.cbomotivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbomotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomotivo.FormattingEnabled = True
        Me.cbomotivo.Location = New System.Drawing.Point(62, 4)
        Me.cbomotivo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbomotivo.Name = "cbomotivo"
        Me.cbomotivo.Size = New System.Drawing.Size(197, 24)
        Me.cbomotivo.TabIndex = 107
        '
        'txtref
        '
        Me.txtref.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtref.Location = New System.Drawing.Point(62, 61)
        Me.txtref.Margin = New System.Windows.Forms.Padding(4)
        Me.txtref.MaxLength = 20
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(197, 22)
        Me.txtref.TabIndex = 108
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.White
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Image = Global.StorageFileManager.My.Resources.Resources.fileopen
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(267, 118)
        Me.btnSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(127, 28)
        Me.btnSeleccionar.TabIndex = 110
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(4, 4)
        Me.KryptonLabel19.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(50, 21)
        Me.KryptonLabel19.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel19.TabIndex = 104
        Me.KryptonLabel19.Text = "Motivo"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Motivo"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnCancelar, Me.ToolStripSeparator4, Me.ToolStripSeparator2, Me.btnEliminar, Me.ToolStripLabel1})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(948, 27)
        Me.MenuBar.TabIndex = 3
        Me.MenuBar.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.StorageFileManager.My.Resources.Resources.cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 24)
        Me.btnCancelar.Text = " Cancelar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        Me.ToolStripSeparator2.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.StorageFileManager.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminar.Text = "Eliminar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 24)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 520)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dtglistaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtglistaDoc As System.Windows.Forms.DataGridView
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
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbomotivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
