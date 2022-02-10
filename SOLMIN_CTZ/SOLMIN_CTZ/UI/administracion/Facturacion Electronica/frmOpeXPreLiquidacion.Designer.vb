<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpeXPreLiquidacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblLote = New System.Windows.Forms.ToolStripLabel()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.OPERACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NROVLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCVLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGVLR_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SEGVLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBar.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.ToolStripLabel1, Me.lblLote, Me.btnExportar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1395, 27)
        Me.MenuBar.TabIndex = 7
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 24)
        Me.btnCancelar.Text = "Cerrar"
        '
        'Separator1
        '
        Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 24)
        '
        'lblLote
        '
        Me.lblLote.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(0, 24)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 24)
        Me.btnExportar.Text = "Exportar"
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AllowUserToOrderColumns = True
        Me.gwdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OPERACION, Me.IMPOCOS, Me.IMPOCOD, Me.VLR_SOL, Me.VLR_DOL, Me.NROVLR, Me.DOCVLR, Me.SEGVLR_DESC, Me.STATUS, Me.SEGVLR, Me.Column1})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.Location = New System.Drawing.Point(0, 27)
        Me.gwdDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersVisible = False
        Me.gwdDatos.RowHeadersWidth = 20
        Me.gwdDatos.RowTemplate.Height = 16
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1395, 294)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 9
        '
        'OPERACION
        '
        Me.OPERACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OPERACION.DataPropertyName = "NOPRCN"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.OPERACION.DefaultCellStyle = DataGridViewCellStyle1
        Me.OPERACION.HeaderText = "Nro Operación"
        Me.OPERACION.Name = "OPERACION"
        Me.OPERACION.ReadOnly = True
        Me.OPERACION.Width = 140
        '
        'IMPOCOS
        '
        Me.IMPOCOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOS.DataPropertyName = "TOTAL_SOL"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N5"
        Me.IMPOCOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.IMPOCOS.HeaderText = "Importe Cobro S/."
        Me.IMPOCOS.Name = "IMPOCOS"
        Me.IMPOCOS.ReadOnly = True
        Me.IMPOCOS.Width = 161
        '
        'IMPOCOD
        '
        Me.IMPOCOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOD.DataPropertyName = "TOTAL_DOL"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N5"
        Me.IMPOCOD.DefaultCellStyle = DataGridViewCellStyle3
        Me.IMPOCOD.HeaderText = "Importe Cobro $"
        Me.IMPOCOD.Name = "IMPOCOD"
        Me.IMPOCOD.ReadOnly = True
        Me.IMPOCOD.Width = 152
        '
        'VLR_SOL
        '
        Me.VLR_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_SOL.DataPropertyName = "VLR_SOL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.VLR_SOL.DefaultCellStyle = DataGridViewCellStyle4
        Me.VLR_SOL.HeaderText = "Valorización S/."
        Me.VLR_SOL.Name = "VLR_SOL"
        Me.VLR_SOL.ReadOnly = True
        Me.VLR_SOL.Width = 144
        '
        'VLR_DOL
        '
        Me.VLR_DOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_DOL.DataPropertyName = "VLR_DOL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.VLR_DOL.DefaultCellStyle = DataGridViewCellStyle5
        Me.VLR_DOL.HeaderText = "Valorización $."
        Me.VLR_DOL.Name = "VLR_DOL"
        Me.VLR_DOL.ReadOnly = True
        Me.VLR_DOL.Width = 138
        '
        'NROVLR
        '
        Me.NROVLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NROVLR.DataPropertyName = "NROVLR"
        Me.NROVLR.HeaderText = "N° Valorización"
        Me.NROVLR.Name = "NROVLR"
        Me.NROVLR.ReadOnly = True
        Me.NROVLR.Width = 144
        '
        'DOCVLR
        '
        Me.DOCVLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DOCVLR.DataPropertyName = "DOCVLR"
        Me.DOCVLR.HeaderText = "Doc Valoriz."
        Me.DOCVLR.Name = "DOCVLR"
        Me.DOCVLR.ReadOnly = True
        Me.DOCVLR.Width = 121
        '
        'SEGVLR_DESC
        '
        Me.SEGVLR_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEGVLR_DESC.DataPropertyName = "SEGVLR_DESC"
        Me.SEGVLR_DESC.HeaderText = "Estado Valoriz."
        Me.SEGVLR_DESC.Name = "SEGVLR_DESC"
        Me.SEGVLR_DESC.ReadOnly = True
        Me.SEGVLR_DESC.Width = 139
        '
        'STATUS
        '
        Me.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STATUS.HeaderText = "Actual Vs Valorizado"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        Me.STATUS.Width = 155
        '
        'SEGVLR
        '
        Me.SEGVLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEGVLR.DataPropertyName = "SEGVLR"
        Me.SEGVLR.HeaderText = "SEGVLR"
        Me.SEGVLR.Name = "SEGVLR"
        Me.SEGVLR.ReadOnly = True
        Me.SEGVLR.Visible = False
        Me.SEGVLR.Width = 93
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmOpeXPreLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 321)
        Me.Controls.Add(Me.gwdDatos)
        Me.Controls.Add(Me.MenuBar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmOpeXPreLiquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Operaciones por Pre-Liquidación"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblLote As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents OPERACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NROVLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOCVLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGVLR_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SEGVLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
