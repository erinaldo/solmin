<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarLiqMasivo
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaArchivo = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCargaVale = New System.Windows.Forms.TabPage()
        Me.dgvCargaVale = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.RESULT_CARGA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLACA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUC_RAZON_SOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRIFO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_VALE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_COMB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_VALE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_GAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTO_GAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECINTO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECINTO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECINTO3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_UREA1_LT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTO_UREA1_GL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_UREA2_LT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTO_UREA2_GL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCargaVale.SuspendLayout()
        CType(Me.dgvCargaVale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OBS_CARGA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Carga"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUC_GRIFO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ruc Grifo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "OBS_REGISTRO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NRO_VALE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nro Vale"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALMACEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnexportar, Me.btnGuardar, Me.btnCargaArchivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1447, 32)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnexportar
        '
        Me.btnexportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnexportar.Image = Global.SOLMIN_ST.My.Resources.Resources.excel1
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(102, 29)
        Me.btnexportar.Text = "Exportar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 29)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCargaArchivo.Image = Global.SOLMIN_ST.My.Resources.Resources.GenerarReporte
        Me.btnCargaArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(183, 29)
        Me.btnCargaArchivo.Text = "Abrir Archivo Excel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCargaVale)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1447, 616)
        Me.TabControl1.TabIndex = 13
        '
        'tpCargaVale
        '
        Me.tpCargaVale.Controls.Add(Me.dgvCargaVale)
        Me.tpCargaVale.Location = New System.Drawing.Point(4, 29)
        Me.tpCargaVale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpCargaVale.Name = "tpCargaVale"
        Me.tpCargaVale.Size = New System.Drawing.Size(1439, 583)
        Me.tpCargaVale.TabIndex = 2
        Me.tpCargaVale.Text = "Carga"
        Me.tpCargaVale.UseVisualStyleBackColor = True
        '
        'dgvCargaVale
        '
        Me.dgvCargaVale.AllowUserToAddRows = False
        Me.dgvCargaVale.AllowUserToDeleteRows = False
        Me.dgvCargaVale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaVale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_UBIC, Me.RESULT_REG_UBIC, Me.PLACA, Me.RUC_RAZON_SOCIAL, Me.GRIFO, Me.NRO_VALE, Me.TIPO_COMB, Me.FECHA_VALE, Me.CANT_GAL, Me.COSTO_GAL, Me.PRECINTO1, Me.PRECINTO2, Me.PRECINTO3, Me.CANT_UREA1_LT, Me.COSTO_UREA1_GL, Me.CANT_UREA2_LT, Me.COSTO_UREA2_GL, Me.DataGridViewTextBoxColumn10})
        Me.dgvCargaVale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargaVale.Location = New System.Drawing.Point(0, 0)
        Me.dgvCargaVale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvCargaVale.Name = "dgvCargaVale"
        Me.dgvCargaVale.ReadOnly = True
        Me.dgvCargaVale.Size = New System.Drawing.Size(1439, 583)
        Me.dgvCargaVale.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCargaVale.TabIndex = 3
        '
        'RESULT_CARGA_UBIC
        '
        Me.RESULT_CARGA_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_CARGA_UBIC.DataPropertyName = "OBS_CARGA"
        Me.RESULT_CARGA_UBIC.HeaderText = "Carga"
        Me.RESULT_CARGA_UBIC.Name = "RESULT_CARGA_UBIC"
        Me.RESULT_CARGA_UBIC.ReadOnly = True
        Me.RESULT_CARGA_UBIC.Width = 98
        '
        'RESULT_REG_UBIC
        '
        Me.RESULT_REG_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_REG_UBIC.DataPropertyName = "OBS_REGISTRO"
        Me.RESULT_REG_UBIC.HeaderText = "Registro"
        Me.RESULT_REG_UBIC.Name = "RESULT_REG_UBIC"
        Me.RESULT_REG_UBIC.ReadOnly = True
        Me.RESULT_REG_UBIC.Width = 117
        '
        'PLACA
        '
        Me.PLACA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PLACA.DataPropertyName = "PLACA"
        Me.PLACA.HeaderText = "Placa"
        Me.PLACA.Name = "PLACA"
        Me.PLACA.ReadOnly = True
        Me.PLACA.Width = 92
        '
        'RUC_RAZON_SOCIAL
        '
        Me.RUC_RAZON_SOCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUC_RAZON_SOCIAL.DataPropertyName = "RUC_RAZON_SOCIAL"
        Me.RUC_RAZON_SOCIAL.HeaderText = "Ruc Razón Social"
        Me.RUC_RAZON_SOCIAL.Name = "RUC_RAZON_SOCIAL"
        Me.RUC_RAZON_SOCIAL.ReadOnly = True
        Me.RUC_RAZON_SOCIAL.Width = 186
        '
        'GRIFO
        '
        Me.GRIFO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GRIFO.DataPropertyName = "GRIFO"
        Me.GRIFO.HeaderText = "Estación"
        Me.GRIFO.Name = "GRIFO"
        Me.GRIFO.ReadOnly = True
        Me.GRIFO.Width = 117
        '
        'NRO_VALE
        '
        Me.NRO_VALE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRO_VALE.DataPropertyName = "NRO_VALE"
        Me.NRO_VALE.HeaderText = "Nro Vale"
        Me.NRO_VALE.Name = "NRO_VALE"
        Me.NRO_VALE.ReadOnly = True
        Me.NRO_VALE.Width = 119
        '
        'TIPO_COMB
        '
        Me.TIPO_COMB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_COMB.DataPropertyName = "TIPO_COMB"
        Me.TIPO_COMB.HeaderText = "Tipo Comb."
        Me.TIPO_COMB.Name = "TIPO_COMB"
        Me.TIPO_COMB.ReadOnly = True
        Me.TIPO_COMB.Width = 145
        '
        'FECHA_VALE
        '
        Me.FECHA_VALE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FECHA_VALE.DataPropertyName = "FECHA_VALE"
        Me.FECHA_VALE.HeaderText = "Fecha Vale"
        Me.FECHA_VALE.Name = "FECHA_VALE"
        Me.FECHA_VALE.ReadOnly = True
        Me.FECHA_VALE.Width = 134
        '
        'CANT_GAL
        '
        Me.CANT_GAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_GAL.DataPropertyName = "CANT_GAL"
        Me.CANT_GAL.HeaderText = "Cant. Galones"
        Me.CANT_GAL.Name = "CANT_GAL"
        Me.CANT_GAL.ReadOnly = True
        Me.CANT_GAL.Width = 160
        '
        'COSTO_GAL
        '
        Me.COSTO_GAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COSTO_GAL.DataPropertyName = "COSTO_GAL"
        Me.COSTO_GAL.HeaderText = "Costo x Gal"
        Me.COSTO_GAL.Name = "COSTO_GAL"
        Me.COSTO_GAL.ReadOnly = True
        Me.COSTO_GAL.Width = 142
        '
        'PRECINTO1
        '
        Me.PRECINTO1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PRECINTO1.DataPropertyName = "PRECINTO1"
        Me.PRECINTO1.HeaderText = "Precinto1"
        Me.PRECINTO1.Name = "PRECINTO1"
        Me.PRECINTO1.ReadOnly = True
        Me.PRECINTO1.Width = 126
        '
        'PRECINTO2
        '
        Me.PRECINTO2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PRECINTO2.DataPropertyName = "PRECINTO2"
        Me.PRECINTO2.HeaderText = "Precinto2"
        Me.PRECINTO2.Name = "PRECINTO2"
        Me.PRECINTO2.ReadOnly = True
        Me.PRECINTO2.Width = 126
        '
        'PRECINTO3
        '
        Me.PRECINTO3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PRECINTO3.DataPropertyName = "PRECINTO3"
        Me.PRECINTO3.HeaderText = "Precinto3"
        Me.PRECINTO3.Name = "PRECINTO3"
        Me.PRECINTO3.ReadOnly = True
        Me.PRECINTO3.Width = 126
        '
        'CANT_UREA1_LT
        '
        Me.CANT_UREA1_LT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_UREA1_LT.DataPropertyName = "CANT_UREA1_LT"
        Me.CANT_UREA1_LT.HeaderText = "Cant. Úrea(1) Lt"
        Me.CANT_UREA1_LT.Name = "CANT_UREA1_LT"
        Me.CANT_UREA1_LT.ReadOnly = True
        Me.CANT_UREA1_LT.Width = 172
        '
        'COSTO_UREA1_GL
        '
        Me.COSTO_UREA1_GL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COSTO_UREA1_GL.DataPropertyName = "COSTO_UREA1_GL"
        Me.COSTO_UREA1_GL.HeaderText = "Costo Úrea(1) Gl"
        Me.COSTO_UREA1_GL.Name = "COSTO_UREA1_GL"
        Me.COSTO_UREA1_GL.ReadOnly = True
        Me.COSTO_UREA1_GL.Width = 181
        '
        'CANT_UREA2_LT
        '
        Me.CANT_UREA2_LT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANT_UREA2_LT.DataPropertyName = "CANT_UREA2_LT"
        Me.CANT_UREA2_LT.HeaderText = "Cant Úrea(2) Lt"
        Me.CANT_UREA2_LT.Name = "CANT_UREA2_LT"
        Me.CANT_UREA2_LT.ReadOnly = True
        Me.CANT_UREA2_LT.Width = 168
        '
        'COSTO_UREA2_GL
        '
        Me.COSTO_UREA2_GL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COSTO_UREA2_GL.DataPropertyName = "COSTO_UREA2_GL"
        Me.COSTO_UREA2_GL.HeaderText = "Costo Úrea(2) Gl"
        Me.COSTO_UREA2_GL.Name = "COSTO_UREA2_GL"
        Me.COSTO_UREA2_GL.ReadOnly = True
        Me.COSTO_UREA2_GL.Width = 181
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmGenerarLiqMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1447, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmGenerarLiqMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Carga Masivo"
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
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCargaArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCargaVale As System.Windows.Forms.TabPage
    Friend WithEvents dgvCargaVale As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents RESULT_CARGA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUC_RAZON_SOCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GRIFO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_VALE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_COMB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHA_VALE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_GAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COSTO_GAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECINTO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECINTO2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECINTO3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_UREA1_LT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COSTO_UREA1_GL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANT_UREA2_LT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COSTO_UREA2_GL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
