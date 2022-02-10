<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaConfigValorizacion
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
        Me.dtglistado = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.CNFCVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REFCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QDAPVL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtglistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtglistado
        '
        Me.dtglistado.AllowUserToAddRows = False
        Me.dtglistado.AllowUserToDeleteRows = False
        Me.dtglistado.AllowUserToResizeRows = False
        Me.dtglistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNFCVL, Me.REFCNT, Me.QDAPVL, Me.DataGridViewTextBoxColumn61})
        Me.dtglistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglistado.Location = New System.Drawing.Point(0, 27)
        Me.dtglistado.Margin = New System.Windows.Forms.Padding(0)
        Me.dtglistado.Name = "dtglistado"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtglistado.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtglistado.Size = New System.Drawing.Size(741, 316)
        Me.dtglistado.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtglistado.TabIndex = 11
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(741, 27)
        Me.ToolStrip2.TabIndex = 10
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources._exit
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'CNFCVL
        '
        Me.CNFCVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNFCVL.DataPropertyName = "CNFCVL"
        Me.CNFCVL.HeaderText = "Corr."
        Me.CNFCVL.Name = "CNFCVL"
        Me.CNFCVL.ReadOnly = True
        Me.CNFCVL.Width = 73
        '
        'REFCNT
        '
        Me.REFCNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REFCNT.DataPropertyName = "REFCNT"
        Me.REFCNT.HeaderText = "Config. valorización"
        Me.REFCNT.Name = "REFCNT"
        Me.REFCNT.ReadOnly = True
        Me.REFCNT.Width = 173
        '
        'QDAPVL
        '
        Me.QDAPVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QDAPVL.DataPropertyName = "QDAPVL"
        Me.QDAPVL.HeaderText = "Días aprobación"
        Me.QDAPVL.Name = "QDAPVL"
        Me.QDAPVL.ReadOnly = True
        Me.QDAPVL.Width = 151
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn61.HeaderText = ""
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        '
        'frmListaConfigValorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 343)
        Me.Controls.Add(Me.dtglistado)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "frmListaConfigValorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Config. Valorización"
        CType(Me.dtglistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtglistado As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents CNFCVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QDAPVL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
