<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarGastos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarGastos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tspBotones = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorDos = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvListarGastos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.Check = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.NRFSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CGSTOS_SAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COD_GASTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TGSTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDMNDA_SAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COD_MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMNDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IGSTOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOBDCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tspBotones.SuspendLayout()
        CType(Me.dgvListarGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tspBotones
        '
        Me.tspBotones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspBotones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.tssSeparadorDos, Me.btnAceptar})
        Me.tspBotones.Location = New System.Drawing.Point(0, 0)
        Me.tspBotones.Name = "tspBotones"
        Me.tspBotones.Size = New System.Drawing.Size(942, 25)
        Me.tspBotones.TabIndex = 2
        Me.tspBotones.TabStop = True
        Me.tspBotones.Text = "tspBotones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.Text = " &Cancelar"
        '
        'tssSeparadorDos
        '
        Me.tssSeparadorDos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorDos.Name = "tssSeparadorDos"
        Me.tssSeparadorDos.Size = New System.Drawing.Size(6, 25)
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(68, 22)
        Me.btnAceptar.Text = "&Aceptar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Gasto"
        Me.DataGridViewTextBoxColumn1.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Gasto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 118
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Moneda"
        Me.DataGridViewTextBoxColumn2.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 101
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ImporteGastos"
        Me.DataGridViewTextBoxColumn3.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe Gastos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 101
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaInicio"
        Me.DataGridViewTextBoxColumn4.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaFin"
        Me.DataGridViewTextBoxColumn5.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Fin"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 118
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn6.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 101
        '
        'dgvListarGastos
        '
        Me.dgvListarGastos.AllowUserToAddRows = False
        Me.dgvListarGastos.AllowUserToDeleteRows = False
        Me.dgvListarGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarGastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarGastos.ColumnHeadersHeight = 30
        Me.dgvListarGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListarGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check, Me.NRFSAP, Me.NOPRCN, Me.CGSTOS_SAP, Me.COD_GASTO, Me.TGSTOS, Me.CDMNDA_SAP, Me.COD_MONEDA, Me.TMNDA, Me.IGSTOS, Me.FECINI, Me.FECFIN, Me.TOBDCT, Me.Column1})
        Me.dgvListarGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarGastos.Location = New System.Drawing.Point(0, 25)
        Me.dgvListarGastos.MultiSelect = False
        Me.dgvListarGastos.Name = "dgvListarGastos"
        Me.dgvListarGastos.RowHeadersWidth = 20
        Me.dgvListarGastos.RowTemplate.Height = 16
        Me.dgvListarGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvListarGastos.Size = New System.Drawing.Size(942, 184)
        Me.dgvListarGastos.StandardTab = True
        Me.dgvListarGastos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvListarGastos.TabIndex = 4
        '
        'Check
        '
        Me.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.Check.DefaultCellStyle = DataGridViewCellStyle1
        Me.Check.FalseValue = Nothing
        Me.Check.FillWeight = 65.88163!
        Me.Check.HeaderText = ""
        Me.Check.IndeterminateValue = Nothing
        Me.Check.MinimumWidth = 25
        Me.Check.Name = "Check"
        Me.Check.TrueValue = Nothing
        Me.Check.Width = 25
        '
        'NRFSAP
        '
        Me.NRFSAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRFSAP.DataPropertyName = "NRFSAP"
        Me.NRFSAP.HeaderText = "Ref Ped. SAP"
        Me.NRFSAP.Name = "NRFSAP"
        Me.NRFSAP.ReadOnly = True
        Me.NRFSAP.Width = 103
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Número Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 138
        '
        'CGSTOS_SAP
        '
        Me.CGSTOS_SAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGSTOS_SAP.DataPropertyName = "CGSTOS_SAP"
        Me.CGSTOS_SAP.HeaderText = "Cod. Gasto (SAP)"
        Me.CGSTOS_SAP.Name = "CGSTOS_SAP"
        Me.CGSTOS_SAP.ReadOnly = True
        Me.CGSTOS_SAP.Width = 126
        '
        'COD_GASTO
        '
        Me.COD_GASTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_GASTO.DataPropertyName = "COD_GASTO"
        Me.COD_GASTO.HeaderText = "Cod. Gasto"
        Me.COD_GASTO.Name = "COD_GASTO"
        Me.COD_GASTO.ReadOnly = True
        Me.COD_GASTO.Width = 94
        '
        'TGSTOS
        '
        Me.TGSTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TGSTOS.DataPropertyName = "TGSTOS"
        Me.TGSTOS.FillWeight = 97.1754!
        Me.TGSTOS.HeaderText = "Gasto"
        Me.TGSTOS.Name = "TGSTOS"
        Me.TGSTOS.ReadOnly = True
        Me.TGSTOS.Width = 66
        '
        'CDMNDA_SAP
        '
        Me.CDMNDA_SAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CDMNDA_SAP.DataPropertyName = "CDMNDA_SAP"
        Me.CDMNDA_SAP.HeaderText = "Moneda (SAP)"
        Me.CDMNDA_SAP.Name = "CDMNDA_SAP"
        Me.CDMNDA_SAP.ReadOnly = True
        Me.CDMNDA_SAP.Width = 112
        '
        'COD_MONEDA
        '
        Me.COD_MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_MONEDA.DataPropertyName = "COD_MONEDA"
        Me.COD_MONEDA.HeaderText = "COD_MONEDA"
        Me.COD_MONEDA.Name = "COD_MONEDA"
        Me.COD_MONEDA.ReadOnly = True
        Me.COD_MONEDA.Visible = False
        Me.COD_MONEDA.Width = 117
        '
        'TMNDA
        '
        Me.TMNDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMNDA.DataPropertyName = "TMNDA"
        Me.TMNDA.FillWeight = 97.1754!
        Me.TMNDA.HeaderText = "Moneda"
        Me.TMNDA.Name = "TMNDA"
        Me.TMNDA.ReadOnly = True
        Me.TMNDA.Width = 80
        '
        'IGSTOS
        '
        Me.IGSTOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IGSTOS.DataPropertyName = "IGSTOS"
        Me.IGSTOS.FillWeight = 97.1754!
        Me.IGSTOS.HeaderText = "Importe Gastos"
        Me.IGSTOS.Name = "IGSTOS"
        Me.IGSTOS.ReadOnly = True
        Me.IGSTOS.Width = 116
        '
        'FECINI
        '
        Me.FECINI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECINI.DataPropertyName = "FECINI"
        Me.FECINI.FillWeight = 97.1754!
        Me.FECINI.HeaderText = "Fecha Inicio"
        Me.FECINI.Name = "FECINI"
        Me.FECINI.ReadOnly = True
        Me.FECINI.Width = 99
        '
        'FECFIN
        '
        Me.FECFIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECFIN.DataPropertyName = "FECFIN"
        Me.FECFIN.FillWeight = 97.1754!
        Me.FECFIN.HeaderText = "Fecha Fin"
        Me.FECFIN.Name = "FECFIN"
        Me.FECFIN.ReadOnly = True
        Me.FECFIN.Width = 86
        '
        'TOBDCT
        '
        Me.TOBDCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOBDCT.DataPropertyName = "TOBDCT"
        Me.TOBDCT.FillWeight = 97.1754!
        Me.TOBDCT.HeaderText = "Observaciones"
        Me.TOBDCT.Name = "TOBDCT"
        Me.TOBDCT.ReadOnly = True
        Me.TOBDCT.Width = 113
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'frmListarGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 209)
        Me.Controls.Add(Me.dgvListarGastos)
        Me.Controls.Add(Me.tspBotones)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarGastos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listados de Gastos"
        Me.tspBotones.ResumeLayout(False)
        Me.tspBotones.PerformLayout()
        CType(Me.dgvListarGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tspBotones As System.Windows.Forms.ToolStrip
    Friend WithEvents tssSeparadorDos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvListarGastos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Check As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NRFSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGSTOS_SAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_GASTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGSTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDMNDA_SAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMNDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGSTOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBDCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
