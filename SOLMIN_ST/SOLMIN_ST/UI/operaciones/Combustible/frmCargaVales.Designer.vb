<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaVales
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaArchivo = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCargaVale = New System.Windows.Forms.TabPage()
        Me.dgvCargaVale = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_CARGA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRUCPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_VALE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCargaVale.SuspendLayout()
        CType(Me.dgvCargaVale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnexportar, Me.btnGuardar, Me.btnCargaArchivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(968, 27)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnexportar
        '
        Me.btnexportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnexportar.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(89, 24)
        Me.btnexportar.Text = "Exportar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCargaArchivo.Image = Global.SOLMIN_ST.My.Resources.Resources.GenerarReporte
        Me.btnCargaArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(158, 24)
        Me.btnCargaArchivo.Text = "Abrir Archivo Excel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCargaVale)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(968, 923)
        Me.TabControl1.TabIndex = 10
        '
        'tpCargaVale
        '
        Me.tpCargaVale.Controls.Add(Me.dgvCargaVale)
        Me.tpCargaVale.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaVale.Name = "tpCargaVale"
        Me.tpCargaVale.Size = New System.Drawing.Size(960, 894)
        Me.tpCargaVale.TabIndex = 2
        Me.tpCargaVale.Text = "Carga Importe Vale"
        Me.tpCargaVale.UseVisualStyleBackColor = True
        '
        'dgvCargaVale
        '
        Me.dgvCargaVale.AllowUserToAddRows = False
        Me.dgvCargaVale.AllowUserToDeleteRows = False
        Me.dgvCargaVale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaVale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_UBIC, Me.RESULT_REG_UBIC, Me.NRUCPR, Me.REFCNT, Me.NRO_VALE, Me.IMPORTE, Me.DataGridViewTextBoxColumn10})
        Me.dgvCargaVale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargaVale.Location = New System.Drawing.Point(0, 0)
        Me.dgvCargaVale.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCargaVale.Name = "dgvCargaVale"
        Me.dgvCargaVale.ReadOnly = True
        Me.dgvCargaVale.Size = New System.Drawing.Size(960, 894)
        Me.dgvCargaVale.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCargaVale.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OBS_CARGA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Carga"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 81
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUC_GRIFO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ruc Grifo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 97
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OBS_REGISTRO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 142
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NRO_VALE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro Vale"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 144
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALMACEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 92
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IMPORTE"
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'RESULT_CARGA_UBIC
        '
        Me.RESULT_CARGA_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_CARGA_UBIC.DataPropertyName = "OBS_CARGA"
        Me.RESULT_CARGA_UBIC.HeaderText = "Carga"
        Me.RESULT_CARGA_UBIC.Name = "RESULT_CARGA_UBIC"
        Me.RESULT_CARGA_UBIC.ReadOnly = True
        Me.RESULT_CARGA_UBIC.Width = 81
        '
        'RESULT_REG_UBIC
        '
        Me.RESULT_REG_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_REG_UBIC.DataPropertyName = "OBS_REGISTRO"
        Me.RESULT_REG_UBIC.HeaderText = "Registro"
        Me.RESULT_REG_UBIC.Name = "RESULT_REG_UBIC"
        Me.RESULT_REG_UBIC.ReadOnly = True
        Me.RESULT_REG_UBIC.Width = 97
        '
        'NRUCPR
        '
        Me.NRUCPR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCPR.DataPropertyName = "RUC_RAZON_SOCIAL"
        Me.NRUCPR.HeaderText = "Ruc Razón Social"
        Me.NRUCPR.Name = "NRUCPR"
        Me.NRUCPR.ReadOnly = True
        Me.NRUCPR.Width = 142
        '
        'REFCNT
        '
        Me.REFCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REFCNT.DataPropertyName = "REF_GRIFO"
        Me.REFCNT.HeaderText = "Estación"
        Me.REFCNT.Name = "REFCNT"
        Me.REFCNT.ReadOnly = True
        Me.REFCNT.Width = 97
        '
        'NRO_VALE
        '
        Me.NRO_VALE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRO_VALE.DataPropertyName = "NRO_VALE"
        Me.NRO_VALE.HeaderText = "Nro Vale"
        Me.NRO_VALE.Name = "NRO_VALE"
        Me.NRO_VALE.ReadOnly = True
        Me.NRO_VALE.Width = 92
        '
        'IMPORTE
        '
        Me.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPORTE.DataPropertyName = "IMPORTE"
        Me.IMPORTE.HeaderText = "Importe"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        Me.IMPORTE.Width = 95
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmCargaVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 950)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCargaVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualizar Vale Pendiente Cierre"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpCargaVale.ResumeLayout(False)
        CType(Me.dgvCargaVale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCargaArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCargaVale As System.Windows.Forms.TabPage
    Friend WithEvents dgvCargaVale As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_CARGA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCPR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_VALE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
