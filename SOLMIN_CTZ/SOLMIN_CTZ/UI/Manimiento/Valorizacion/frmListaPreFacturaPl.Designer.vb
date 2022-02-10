<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPreFacturaPl
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.dgwPreFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSubDocCliente = New System.Windows.Forms.TextBox()
        Me.txtDocCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cblTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.btnPreLiquidacion = New System.Windows.Forms.ToolStripButton()
        Me.btnConsistencia = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDCPRF_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOS_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOD_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderDatos
        '
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.dgwPreFacturacion)
        Me.HeaderDatos.Panel.Controls.Add(Me.Panel1)
        Me.HeaderDatos.Panel.Controls.Add(Me.MenuBar)
        Me.HeaderDatos.Size = New System.Drawing.Size(877, 611)
        Me.HeaderDatos.TabIndex = 1
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = ""
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'dgwPreFacturacion
        '
        Me.dgwPreFacturacion.AllowUserToAddRows = False
        Me.dgwPreFacturacion.AllowUserToDeleteRows = False
        Me.dgwPreFacturacion.AllowUserToOrderColumns = True
        Me.dgwPreFacturacion.AllowUserToResizeColumns = False
        Me.dgwPreFacturacion.AllowUserToResizeRows = False
        Me.dgwPreFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgwPreFacturacion.ColumnHeadersHeight = 25
        Me.dgwPreFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgwPreFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDCPRF, Me.NSECFC, Me.FDCPRF_S, Me.IMPOCOS_D, Me.IMPOCOD_D, Me.VLR_SOL, Me.VLR_DOL, Me.Column1})
        Me.dgwPreFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwPreFacturacion.Location = New System.Drawing.Point(0, 82)
        Me.dgwPreFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwPreFacturacion.MultiSelect = False
        Me.dgwPreFacturacion.Name = "dgwPreFacturacion"
        Me.dgwPreFacturacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwPreFacturacion.ReadOnly = True
        Me.dgwPreFacturacion.RowHeadersVisible = False
        Me.dgwPreFacturacion.RowHeadersWidth = 20
        Me.dgwPreFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPreFacturacion.Size = New System.Drawing.Size(875, 524)
        Me.dgwPreFacturacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwPreFacturacion.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.txtSubDocCliente)
        Me.Panel1.Controls.Add(Me.txtDocCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cblTipoDoc)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 55)
        Me.Panel1.TabIndex = 2
        '
        'txtSubDocCliente
        '
        Me.txtSubDocCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubDocCliente.Location = New System.Drawing.Point(666, 16)
        Me.txtSubDocCliente.MaxLength = 20
        Me.txtSubDocCliente.Name = "txtSubDocCliente"
        Me.txtSubDocCliente.Size = New System.Drawing.Size(230, 22)
        Me.txtSubDocCliente.TabIndex = 2
        Me.txtSubDocCliente.Visible = False
        '
        'txtDocCliente
        '
        Me.txtDocCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocCliente.Location = New System.Drawing.Point(313, 16)
        Me.txtDocCliente.MaxLength = 20
        Me.txtDocCliente.Name = "txtDocCliente"
        Me.txtDocCliente.Size = New System.Drawing.Size(218, 22)
        Me.txtDocCliente.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(542, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sub Doc. Cliente:"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Doc. Cliente:"
        '
        'cblTipoDoc
        '
        Me.cblTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblTipoDoc.FormattingEnabled = True
        Me.cblTipoDoc.Location = New System.Drawing.Point(78, 14)
        Me.cblTipoDoc.Name = "cblTipoDoc"
        Me.cblTipoDoc.Size = New System.Drawing.Size(134, 24)
        Me.cblTipoDoc.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo Doc:"
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar, Me.btnPreLiquidacion, Me.btnConsistencia})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(875, 27)
        Me.MenuBar.TabIndex = 0
        Me.MenuBar.TabStop = True
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 24)
        Me.btnCerrar.Text = "Cancelar"
        Me.btnCerrar.ToolTipText = "Cancelar"
        '
        'btnPreLiquidacion
        '
        Me.btnPreLiquidacion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPreLiquidacion.Image = Global.SOLMIN_CT.My.Resources.Resources.button_ok
        Me.btnPreLiquidacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreLiquidacion.Name = "btnPreLiquidacion"
        Me.btnPreLiquidacion.Size = New System.Drawing.Size(112, 24)
        Me.btnPreLiquidacion.Text = " Procesar PL"
        Me.btnPreLiquidacion.ToolTipText = " Pre - Liquidar"
        '
        'btnConsistencia
        '
        Me.btnConsistencia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnConsistencia.Image = Global.SOLMIN_CT.My.Resources.Resources.cell_layout
        Me.btnConsistencia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsistencia.Name = "btnConsistencia"
        Me.btnConsistencia.Size = New System.Drawing.Size(134, 24)
        Me.btnConsistencia.Text = "Consistencia PL"
        Me.btnConsistencia.ToolTipText = "Consistencia Pre - Liquidar"
        Me.btnConsistencia.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NDCPRF"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro de Pre. Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FDCPRF_S"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IMPOCOS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N5"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe por Cobrar S/."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IMPOCOD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N5"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe por Cobrar $"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VLR_SOL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Valorización S/."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VLR_DOL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valorización $."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'NDCPRF
        '
        Me.NDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDCPRF.DataPropertyName = "NDCPRF"
        Me.NDCPRF.HeaderText = "Nro Pre. Factura"
        Me.NDCPRF.Name = "NDCPRF"
        Me.NDCPRF.ReadOnly = True
        Me.NDCPRF.Width = 146
        '
        'NSECFC
        '
        Me.NSECFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NSECFC.DataPropertyName = "NSECFC"
        Me.NSECFC.HeaderText = "Nro Consistencia"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.ReadOnly = True
        Me.NSECFC.Width = 153
        '
        'FDCPRF_S
        '
        Me.FDCPRF_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FDCPRF_S.DataPropertyName = "FDCPRF_S"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.FDCPRF_S.DefaultCellStyle = DataGridViewCellStyle1
        Me.FDCPRF_S.HeaderText = "Fecha"
        Me.FDCPRF_S.Name = "FDCPRF_S"
        Me.FDCPRF_S.ReadOnly = True
        Me.FDCPRF_S.Visible = False
        Me.FDCPRF_S.Width = 80
        '
        'IMPOCOS_D
        '
        Me.IMPOCOS_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOS_D.DataPropertyName = "IMPOCOS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N5"
        Me.IMPOCOS_D.DefaultCellStyle = DataGridViewCellStyle2
        Me.IMPOCOS_D.HeaderText = "Importe por Cobrar S/."
        Me.IMPOCOS_D.Name = "IMPOCOS_D"
        Me.IMPOCOS_D.ReadOnly = True
        Me.IMPOCOS_D.Width = 192
        '
        'IMPOCOD_D
        '
        Me.IMPOCOD_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOD_D.DataPropertyName = "IMPOCOD"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N5"
        Me.IMPOCOD_D.DefaultCellStyle = DataGridViewCellStyle3
        Me.IMPOCOD_D.HeaderText = "Importe por Cobrar $"
        Me.IMPOCOD_D.Name = "IMPOCOD_D"
        Me.IMPOCOD_D.ReadOnly = True
        Me.IMPOCOD_D.Width = 183
        '
        'VLR_SOL
        '
        Me.VLR_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_SOL.DataPropertyName = "VLR_SOL"
        Me.VLR_SOL.HeaderText = "Valorización S/."
        Me.VLR_SOL.Name = "VLR_SOL"
        Me.VLR_SOL.ReadOnly = True
        Me.VLR_SOL.Visible = False
        Me.VLR_SOL.Width = 144
        '
        'VLR_DOL
        '
        Me.VLR_DOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_DOL.DataPropertyName = "VLR_DOL"
        Me.VLR_DOL.HeaderText = "Valorización $."
        Me.VLR_DOL.Name = "VLR_DOL"
        Me.VLR_DOL.ReadOnly = True
        Me.VLR_DOL.Visible = False
        Me.VLR_DOL.Width = 138
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmListaPreFacturaPl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 611)
        Me.Controls.Add(Me.HeaderDatos)
        Me.Name = "frmListaPreFacturaPl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pendientes PL"
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        Me.HeaderDatos.Panel.PerformLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgwPreFacturacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSubDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDocCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cblTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPreLiquidacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnConsistencia As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDCPRF_S As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOS_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOD_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
