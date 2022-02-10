<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPreFac
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.TbtnQuitarPreFactura = New System.Windows.Forms.ToolStripButton()
        Me.btnAdPreFactura = New System.Windows.Forms.ToolStripButton()
        Me.dgwPreFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOS_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOD_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRVTA_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EN_VLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRGVTA_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.TbtnQuitarPreFactura, Me.btnAdPreFactura})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(851, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'TbtnQuitarPreFactura
        '
        Me.TbtnQuitarPreFactura.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TbtnQuitarPreFactura.Image = Global.SOLMIN_CT.My.Resources.Resources.anular1
        Me.TbtnQuitarPreFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnQuitarPreFactura.Name = "TbtnQuitarPreFactura"
        Me.TbtnQuitarPreFactura.Size = New System.Drawing.Size(134, 24)
        Me.TbtnQuitarPreFactura.Text = "Quitar Consistencia"
        '
        'btnAdPreFactura
        '
        Me.btnAdPreFactura.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdPreFactura.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnAdPreFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdPreFactura.Name = "btnAdPreFactura"
        Me.btnAdPreFactura.Size = New System.Drawing.Size(143, 24)
        Me.btnAdPreFactura.Text = "Agregar Consistencia"
        '
        'dgwPreFacturacion
        '
        Me.dgwPreFacturacion.AllowUserToAddRows = False
        Me.dgwPreFacturacion.AllowUserToDeleteRows = False
        Me.dgwPreFacturacion.AllowUserToOrderColumns = True
        Me.dgwPreFacturacion.AllowUserToResizeColumns = False
        Me.dgwPreFacturacion.AllowUserToResizeRows = False
        Me.dgwPreFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgwPreFacturacion.ColumnHeadersHeight = 30
        Me.dgwPreFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwPreFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.CCLNT, Me.NSECFC, Me.FSECFC, Me.IMPOCOS_D, Me.IMPOCOD_D, Me.TCRVTA_D, Me.VLR_SOL, Me.VLR_DOL, Me.VLR_CANT, Me.EN_VLR, Me.CRGVTA_D, Me.Column1})
        Me.dgwPreFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwPreFacturacion.Location = New System.Drawing.Point(0, 27)
        Me.dgwPreFacturacion.MultiSelect = False
        Me.dgwPreFacturacion.Name = "dgwPreFacturacion"
        Me.dgwPreFacturacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwPreFacturacion.RowHeadersVisible = False
        Me.dgwPreFacturacion.RowHeadersWidth = 20
        Me.dgwPreFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPreFacturacion.Size = New System.Drawing.Size(851, 234)
        Me.dgwPreFacturacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwPreFacturacion.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NDCPRF"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Pre - Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FDCPRF"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 126
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IMPOCOS"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N5"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe por Cobrar S/."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 67
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IMPOCOD"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N5"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe por Cobrar $"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 155
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn5.HeaderText = "Organización Venta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 147
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VLR_SOL"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valorización S/."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 138
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VLR_DOL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Valorización $/."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 116
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VLR_CANT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "VLR_CANT"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 116
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EN_VLR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "En Valorización"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 93
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CRGVTA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 115
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn11.HeaderText = ""
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.HeaderText = ""
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'chk
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.NullValue = False
        Me.chk.DefaultCellStyle = DataGridViewCellStyle19
        Me.chk.FalseValue = "N"
        Me.chk.HeaderText = "Selec."
        Me.chk.IndeterminateValue = "N"
        Me.chk.Name = "chk"
        Me.chk.TrueValue = "S"
        Me.chk.Width = 47
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.Visible = False
        Me.CCLNT.Width = 74
        '
        'NSECFC
        '
        Me.NSECFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NSECFC.DataPropertyName = "NSECFC"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NSECFC.DefaultCellStyle = DataGridViewCellStyle20
        Me.NSECFC.HeaderText = "Nro Consistencia"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.Width = 126
        '
        'FSECFC
        '
        Me.FSECFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FSECFC.DataPropertyName = "FSECFC"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FSECFC.DefaultCellStyle = DataGridViewCellStyle21
        Me.FSECFC.HeaderText = "Fecha"
        Me.FSECFC.Name = "FSECFC"
        Me.FSECFC.ReadOnly = True
        Me.FSECFC.Width = 67
        '
        'IMPOCOS_D
        '
        Me.IMPOCOS_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOS_D.DataPropertyName = "TOTAL_SOL"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N5"
        Me.IMPOCOS_D.DefaultCellStyle = DataGridViewCellStyle22
        Me.IMPOCOS_D.HeaderText = "Importe por Cobrar S/."
        Me.IMPOCOS_D.Name = "IMPOCOS_D"
        Me.IMPOCOS_D.ReadOnly = True
        Me.IMPOCOS_D.Width = 155
        '
        'IMPOCOD_D
        '
        Me.IMPOCOD_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOD_D.DataPropertyName = "TOTAL_DOL"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N5"
        Me.IMPOCOD_D.DefaultCellStyle = DataGridViewCellStyle23
        Me.IMPOCOD_D.HeaderText = "Importe por Cobrar $"
        Me.IMPOCOD_D.Name = "IMPOCOD_D"
        Me.IMPOCOD_D.ReadOnly = True
        Me.IMPOCOD_D.Width = 147
        '
        'TCRVTA_D
        '
        Me.TCRVTA_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA_D.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TCRVTA_D.DefaultCellStyle = DataGridViewCellStyle24
        Me.TCRVTA_D.HeaderText = "Organización Venta"
        Me.TCRVTA_D.Name = "TCRVTA_D"
        Me.TCRVTA_D.Width = 138
        '
        'VLR_SOL
        '
        Me.VLR_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_SOL.DataPropertyName = "VLR_SOL"
        Me.VLR_SOL.HeaderText = "Valorización S/."
        Me.VLR_SOL.Name = "VLR_SOL"
        Me.VLR_SOL.ReadOnly = True
        Me.VLR_SOL.Visible = False
        Me.VLR_SOL.Width = 116
        '
        'VLR_DOL
        '
        Me.VLR_DOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_DOL.DataPropertyName = "VLR_DOL"
        Me.VLR_DOL.HeaderText = "Valorización $/."
        Me.VLR_DOL.Name = "VLR_DOL"
        Me.VLR_DOL.ReadOnly = True
        Me.VLR_DOL.Visible = False
        Me.VLR_DOL.Width = 116
        '
        'VLR_CANT
        '
        Me.VLR_CANT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_CANT.DataPropertyName = "VLR_CANT"
        Me.VLR_CANT.HeaderText = "VLR_CANT"
        Me.VLR_CANT.Name = "VLR_CANT"
        Me.VLR_CANT.ReadOnly = True
        Me.VLR_CANT.Visible = False
        Me.VLR_CANT.Width = 93
        '
        'EN_VLR
        '
        Me.EN_VLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EN_VLR.DataPropertyName = "EN_VLR"
        Me.EN_VLR.HeaderText = "En Valorización"
        Me.EN_VLR.Name = "EN_VLR"
        Me.EN_VLR.ReadOnly = True
        Me.EN_VLR.Visible = False
        Me.EN_VLR.Width = 115
        '
        'CRGVTA_D
        '
        Me.CRGVTA_D.DataPropertyName = "CRGVTA"
        Me.CRGVTA_D.HeaderText = "CRGVTA"
        Me.CRGVTA_D.Name = "CRGVTA_D"
        Me.CRGVTA_D.Visible = False
        Me.CRGVTA_D.Width = 80
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmConsultaPreFac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 261)
        Me.Controls.Add(Me.dgwPreFacturacion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmConsultaPreFac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Consistencia"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TbtnQuitarPreFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdPreFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgwPreFacturacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chk As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOS_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOD_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_CANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EN_VLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRGVTA_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
