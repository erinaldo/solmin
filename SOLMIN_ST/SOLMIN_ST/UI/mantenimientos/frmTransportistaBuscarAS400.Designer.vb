<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransportistaBuscarAS400
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransportistaBuscarAS400))
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion()
        Me.KryptonHeaderGroup5 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtruc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtrazonsocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtcod = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUCPR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup5.Panel.SuspendLayout()
        Me.KryptonHeaderGroup5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 563)
        Me.UcPaginacion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(866, 34)
        Me.UcPaginacion1.TabIndex = 8
        '
        'KryptonHeaderGroup5
        '
        Me.KryptonHeaderGroup5.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup5.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup5.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup5.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup5.Name = "KryptonHeaderGroup5"
        '
        'KryptonHeaderGroup5.Panel
        '
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtruc)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtrazonsocial)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtcod)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonHeaderGroup5.Size = New System.Drawing.Size(866, 91)
        Me.KryptonHeaderGroup5.TabIndex = 9
        Me.KryptonHeaderGroup5.Text = "Heading"
        Me.KryptonHeaderGroup5.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup5.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup5.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup5.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup5.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup5.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup5.ValuesSecondary.Image = Nothing
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(346, 22)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(171, 26)
        Me.txtruc.TabIndex = 5
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(275, 22)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(44, 24)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Text = "RUC:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "RUC:"
        '
        'txtrazonsocial
        '
        Me.txtrazonsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrazonsocial.Location = New System.Drawing.Point(127, 54)
        Me.txtrazonsocial.MaxLength = 100
        Me.txtrazonsocial.Name = "txtrazonsocial"
        Me.txtrazonsocial.Size = New System.Drawing.Size(390, 26)
        Me.txtrazonsocial.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 56)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(101, 24)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Razón Social:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Razón Social:"
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Location = New System.Drawing.Point(127, 22)
        Me.txtcod.MaxLength = 6
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(129, 26)
        Me.txtcod.TabIndex = 1
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(8, 22)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(64, 24)
        Me.KryptonLabel12.TabIndex = 0
        Me.KryptonLabel12.Text = "Código:"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Código:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnAceptar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 91)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(866, 27)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTRSPT, Me.NRUCTR, Me.TCMTRT, Me.RUCPR2, Me.Column1})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 118)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.Size = New System.Drawing.Size(866, 445)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 11
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Código"
        Me.CTRSPT.MinimumWidth = 50
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        Me.CTRSPT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTRSPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTRSPT.Width = 68
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.MinimumWidth = 60
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NRUCTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRUCTR.Width = 60
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.FillWeight = 300.0!
        Me.TCMTRT.HeaderText = "Razón social"
        Me.TCMTRT.MinimumWidth = 200
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TCMTRT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCMTRT.Width = 200
        '
        'RUCPR2
        '
        Me.RUCPR2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUCPR2.DataPropertyName = "RUCPR2"
        Me.RUCPR2.HeaderText = "Código SAP"
        Me.RUCPR2.Name = "RUCPR2"
        Me.RUCPR2.ReadOnly = True
        Me.RUCPR2.Width = 121
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUCPR2"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código SAP"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 60
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn4.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón social"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.HeaderText = ""
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'frmTransportistaBuscarAS400
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 597)
        Me.Controls.Add(Me.gwdDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.KryptonHeaderGroup5)
        Me.Controls.Add(Me.UcPaginacion1)
        Me.Name = "frmTransportistaBuscarAS400"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Transportista"
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup5.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents KryptonHeaderGroup5 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtruc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtrazonsocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtcod As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUCPR2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
