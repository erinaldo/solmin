<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaMasivaProveedor
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
        Me.tpCargaProv = New System.Windows.Forms.TabPage()
        Me.dgvCargaProv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_CARGA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAZON_SOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PROV_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCargaProv.SuspendLayout()
        CType(Me.dgvCargaProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnexportar, Me.btnGuardar, Me.btnCargaArchivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1327, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.Cancelar
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnexportar
        '
        Me.btnexportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnexportar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.excelicon
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(89, 24)
        Me.btnexportar.Text = "Exportar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCargaArchivo.Image = Global.Ransa.Controls.Proveedor.My.Resources.Resources.GenerarReporte
        Me.btnCargaArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(158, 24)
        Me.btnCargaArchivo.Text = "Abrir Archivo Excel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCargaProv)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 703)
        Me.TabControl1.TabIndex = 6
        '
        'tpCargaProv
        '
        Me.tpCargaProv.Controls.Add(Me.dgvCargaProv)
        Me.tpCargaProv.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaProv.Name = "tpCargaProv"
        Me.tpCargaProv.Size = New System.Drawing.Size(1319, 674)
        Me.tpCargaProv.TabIndex = 2
        Me.tpCargaProv.Text = "Carga Inv. Porveedor"
        Me.tpCargaProv.UseVisualStyleBackColor = True
        '
        'dgvCargaProv
        '
        Me.dgvCargaProv.AllowUserToAddRows = False
        Me.dgvCargaProv.AllowUserToDeleteRows = False
        Me.dgvCargaProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaProv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_UBIC, Me.RESULT_REG_UBIC, Me.RUC, Me.RAZON_SOCIAL, Me.DIRECCION, Me.COD_CLIENTE, Me.COD_PROV_CLIENTE, Me.DataGridViewTextBoxColumn10})
        Me.dgvCargaProv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargaProv.Location = New System.Drawing.Point(0, 0)
        Me.dgvCargaProv.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCargaProv.Name = "dgvCargaProv"
        Me.dgvCargaProv.ReadOnly = True
        Me.dgvCargaProv.Size = New System.Drawing.Size(1319, 674)
        Me.dgvCargaProv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCargaProv.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OBS_CARGA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Carga"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OBS_REGISTRO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RUC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ruc Prov."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RAZON_SOCIAL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Razón Social"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DIRECCION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "COD_CLIENTE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cod. Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "COD_PROVEEDOR_CLIENTE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cod. Proveedor Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.HeaderText = ""
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
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
        'RUC
        '
        Me.RUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUC.DataPropertyName = "RUC"
        Me.RUC.HeaderText = "Ruc Prov."
        Me.RUC.Name = "RUC"
        Me.RUC.ReadOnly = True
        Me.RUC.Width = 102
        '
        'RAZON_SOCIAL
        '
        Me.RAZON_SOCIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL"
        Me.RAZON_SOCIAL.HeaderText = "Razón Social"
        Me.RAZON_SOCIAL.Name = "RAZON_SOCIAL"
        Me.RAZON_SOCIAL.ReadOnly = True
        Me.RAZON_SOCIAL.Width = 127
        '
        'DIRECCION
        '
        Me.DIRECCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DIRECCION.DataPropertyName = "DIRECCION"
        Me.DIRECCION.HeaderText = "Dirección"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Width = 105
        '
        'COD_CLIENTE
        '
        Me.COD_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_CLIENTE.DataPropertyName = "COD_CLIENTE"
        Me.COD_CLIENTE.HeaderText = "Cod. Cliente"
        Me.COD_CLIENTE.Name = "COD_CLIENTE"
        Me.COD_CLIENTE.ReadOnly = True
        Me.COD_CLIENTE.Visible = False
        Me.COD_CLIENTE.Width = 122
        '
        'COD_PROV_CLIENTE
        '
        Me.COD_PROV_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_PROV_CLIENTE.DataPropertyName = "COD_PROV_CLIENTE"
        Me.COD_PROV_CLIENTE.HeaderText = "Cod. Prov.Cliente"
        Me.COD_PROV_CLIENTE.Name = "COD_PROV_CLIENTE"
        Me.COD_PROV_CLIENTE.ReadOnly = True
        Me.COD_PROV_CLIENTE.Visible = False
        Me.COD_PROV_CLIENTE.Width = 154
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmCargaMasivaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 730)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCargaMasivaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Carga Masiva Porveedor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpCargaProv.ResumeLayout(False)
        CType(Me.dgvCargaProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCargaArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCargaProv As System.Windows.Forms.TabPage
    Friend WithEvents dgvCargaProv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_CARGA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RAZON_SOCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_PROV_CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
