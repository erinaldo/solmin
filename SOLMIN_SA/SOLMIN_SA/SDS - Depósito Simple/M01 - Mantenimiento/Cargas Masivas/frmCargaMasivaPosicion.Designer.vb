<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaMasivaPosicion
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
        Me.tpCargaUbicacion = New System.Windows.Forms.TabPage()
        Me.dgvCargaInvUbic = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.RESULT_CARGA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ALMACEN_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCargaUbicacion.SuspendLayout()
        CType(Me.dgvCargaInvUbic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnexportar, Me.btnGuardar, Me.btnCargaArchivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1090, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnexportar
        '
        Me.btnexportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnexportar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(89, 24)
        Me.btnexportar.Text = "Exportar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCargaArchivo.Image = Global.SOLMIN_SA.My.Resources.Resources.GenerarReporte
        Me.btnCargaArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(158, 24)
        Me.btnCargaArchivo.Text = "Abrir Archivo Excel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCargaUbicacion)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1090, 703)
        Me.TabControl1.TabIndex = 6
        '
        'tpCargaUbicacion
        '
        Me.tpCargaUbicacion.Controls.Add(Me.dgvCargaInvUbic)
        Me.tpCargaUbicacion.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaUbicacion.Name = "tpCargaUbicacion"
        Me.tpCargaUbicacion.Size = New System.Drawing.Size(1082, 674)
        Me.tpCargaUbicacion.TabIndex = 2
        Me.tpCargaUbicacion.Text = "Carga Inv. por Ubicación"
        Me.tpCargaUbicacion.UseVisualStyleBackColor = True
        '
        'dgvCargaInvUbic
        '
        Me.dgvCargaInvUbic.AllowUserToAddRows = False
        Me.dgvCargaInvUbic.AllowUserToDeleteRows = False
        Me.dgvCargaInvUbic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaInvUbic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_UBIC, Me.RESULT_REG_UBIC, Me.TIPO_ALMACEN_UBIC, Me.ALMACEN_UBIC, Me.ZONA_UBIC, Me.UBICACION, Me.DataGridViewTextBoxColumn10})
        Me.dgvCargaInvUbic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargaInvUbic.Location = New System.Drawing.Point(0, 0)
        Me.dgvCargaInvUbic.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCargaInvUbic.Name = "dgvCargaInvUbic"
        Me.dgvCargaInvUbic.ReadOnly = True
        Me.dgvCargaInvUbic.Size = New System.Drawing.Size(1082, 674)
        Me.dgvCargaInvUbic.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCargaInvUbic.TabIndex = 3
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
        'TIPO_ALMACEN_UBIC
        '
        Me.TIPO_ALMACEN_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_ALMACEN_UBIC.DataPropertyName = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN_UBIC.HeaderText = "Tipo Almacén"
        Me.TIPO_ALMACEN_UBIC.Name = "TIPO_ALMACEN_UBIC"
        Me.TIPO_ALMACEN_UBIC.ReadOnly = True
        Me.TIPO_ALMACEN_UBIC.Width = 134
        '
        'ALMACEN_UBIC
        '
        Me.ALMACEN_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALMACEN_UBIC.DataPropertyName = "ALMACEN"
        Me.ALMACEN_UBIC.HeaderText = "Almacén"
        Me.ALMACEN_UBIC.Name = "ALMACEN_UBIC"
        Me.ALMACEN_UBIC.ReadOnly = True
        '
        'ZONA_UBIC
        '
        Me.ZONA_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZONA_UBIC.DataPropertyName = "ZONA"
        Me.ZONA_UBIC.HeaderText = "Zona"
        Me.ZONA_UBIC.Name = "ZONA_UBIC"
        Me.ZONA_UBIC.ReadOnly = True
        Me.ZONA_UBIC.Width = 76
        '
        'UBICACION
        '
        Me.UBICACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBICACION.DataPropertyName = "UBICACION"
        Me.UBICACION.HeaderText = "Ubicación"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        Me.UBICACION.Width = 108
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'frmCargaMasivaPosicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 730)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCargaMasivaPosicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Carga Masiva Posiciones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpCargaUbicacion.ResumeLayout(False)
        CType(Me.dgvCargaInvUbic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCargaArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCargaUbicacion As System.Windows.Forms.TabPage
    Friend WithEvents dgvCargaInvUbic As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents RESULT_CARGA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ALMACEN_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
