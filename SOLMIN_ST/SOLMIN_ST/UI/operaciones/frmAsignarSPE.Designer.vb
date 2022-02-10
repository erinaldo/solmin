<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarSPE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarSPE))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvListaSPE = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tspBotones = New System.Windows.Forms.ToolStrip
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorDos = New System.Windows.Forms.ToolStripSeparator
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPSLPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NMSLPE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AEJINS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRFSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ISLPES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TADSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvListaSPE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListaSPE
        '
        Me.dgvListaSPE.AllowUserToAddRows = False
        Me.dgvListaSPE.AllowUserToDeleteRows = False
        Me.dgvListaSPE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaSPE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaSPE.ColumnHeadersHeight = 30
        Me.dgvListaSPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaSPE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN, Me.TPSLPE, Me.NMSLPE, Me.AEJINS, Me.NRFSAP, Me.ISLPES, Me.TADSAP})
        Me.dgvListaSPE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaSPE.Location = New System.Drawing.Point(0, 25)
        Me.dgvListaSPE.MultiSelect = False
        Me.dgvListaSPE.Name = "dgvListaSPE"
        Me.dgvListaSPE.RowHeadersWidth = 20
        Me.dgvListaSPE.RowTemplate.Height = 16
        Me.dgvListaSPE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaSPE.Size = New System.Drawing.Size(852, 205)
        Me.dgvListaSPE.StandardTab = True
        Me.dgvListaSPE.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvListaSPE.TabIndex = 6
        '
        'tspBotones
        '
        Me.tspBotones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.tspBotones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspBotones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.tssSeparadorDos, Me.btnAceptar})
        Me.tspBotones.Location = New System.Drawing.Point(0, 0)
        Me.tspBotones.Name = "tspBotones"
        Me.tspBotones.Size = New System.Drawing.Size(852, 25)
        Me.tspBotones.TabIndex = 5
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn6.FillWeight = 97.1754!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 101
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
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 91
        '
        'TPSLPE
        '
        Me.TPSLPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TPSLPE.DataPropertyName = "TPSLPE"
        Me.TPSLPE.HeaderText = "Tipo"
        Me.TPSLPE.Name = "TPSLPE"
        Me.TPSLPE.ReadOnly = True
        Me.TPSLPE.Width = 60
        '
        'NMSLPE
        '
        Me.NMSLPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NMSLPE.DataPropertyName = "NMSLPE"
        Me.NMSLPE.HeaderText = "SPE"
        Me.NMSLPE.Name = "NMSLPE"
        Me.NMSLPE.ReadOnly = True
        Me.NMSLPE.Width = 55
        '
        'AEJINS
        '
        Me.AEJINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AEJINS.DataPropertyName = "AEJINS"
        Me.AEJINS.HeaderText = "Periodo"
        Me.AEJINS.Name = "AEJINS"
        Me.AEJINS.ReadOnly = True
        Me.AEJINS.Width = 77
        '
        'NRFSAP
        '
        Me.NRFSAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRFSAP.DataPropertyName = "NRFSAP"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NRFSAP.DefaultCellStyle = DataGridViewCellStyle1
        Me.NRFSAP.HeaderText = "Ref Ped SAP"
        Me.NRFSAP.Name = "NRFSAP"
        Me.NRFSAP.ReadOnly = True
        '
        'ISLPES
        '
        Me.ISLPES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ISLPES.DataPropertyName = "ISLPES"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ISLPES.DefaultCellStyle = DataGridViewCellStyle2
        Me.ISLPES.HeaderText = "Importe Ped SAP"
        Me.ISLPES.Name = "ISLPES"
        Me.ISLPES.ReadOnly = True
        Me.ISLPES.Width = 125
        '
        'TADSAP
        '
        Me.TADSAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TADSAP.DataPropertyName = "TADSAP"
        Me.TADSAP.HeaderText = "Obs SAP"
        Me.TADSAP.Name = "TADSAP"
        Me.TADSAP.ReadOnly = True
        Me.TADSAP.Width = 81
        '
        'frmAsignarSPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 230)
        Me.Controls.Add(Me.dgvListaSPE)
        Me.Controls.Add(Me.tspBotones)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsignarSPE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Asignar SPE"
        CType(Me.dgvListaSPE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspBotones.ResumeLayout(False)
        Me.tspBotones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListaSPE As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tspBotones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadorDos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPSLPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NMSLPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AEJINS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRFSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISLPES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TADSAP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
