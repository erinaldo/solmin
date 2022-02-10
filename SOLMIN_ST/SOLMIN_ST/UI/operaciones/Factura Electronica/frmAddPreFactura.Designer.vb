<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPreFactura
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgwPreFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.TabListaLiquidacion = New System.Windows.Forms.TabControl()
        Me.tabPreFactura = New System.Windows.Forms.TabPage()
        Me.panelGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
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
        Me.chk = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.NDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOS_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPOCOD_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCRVTA_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EN_VLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRGVTA_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabListaLiquidacion.SuspendLayout()
        Me.tabPreFactura.SuspendLayout()
        CType(Me.panelGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGuiaRemision.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgwPreFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.NDCPRF, Me.FDCPRF, Me.IMPOCOS_D, Me.IMPOCOD_D, Me.VLR_SOL, Me.VLR_DOL, Me.TCRVTA_D, Me.EN_VLR, Me.VLR_CANT, Me.CRGVTA_D, Me.Column1})
        Me.dgwPreFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwPreFacturacion.Location = New System.Drawing.Point(0, 0)
        Me.dgwPreFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwPreFacturacion.MultiSelect = False
        Me.dgwPreFacturacion.Name = "dgwPreFacturacion"
        Me.dgwPreFacturacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwPreFacturacion.RowHeadersVisible = False
        Me.dgwPreFacturacion.RowHeadersWidth = 20
        Me.dgwPreFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPreFacturacion.Size = New System.Drawing.Size(1009, 310)
        Me.dgwPreFacturacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwPreFacturacion.TabIndex = 0
        '
        'TabListaLiquidacion
        '
        Me.TabListaLiquidacion.Controls.Add(Me.tabPreFactura)
        Me.TabListaLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabListaLiquidacion.Location = New System.Drawing.Point(0, 27)
        Me.TabListaLiquidacion.Margin = New System.Windows.Forms.Padding(4)
        Me.TabListaLiquidacion.Name = "TabListaLiquidacion"
        Me.TabListaLiquidacion.SelectedIndex = 0
        Me.TabListaLiquidacion.Size = New System.Drawing.Size(1025, 347)
        Me.TabListaLiquidacion.TabIndex = 3
        '
        'tabPreFactura
        '
        Me.tabPreFactura.Controls.Add(Me.panelGuiaRemision)
        Me.tabPreFactura.Location = New System.Drawing.Point(4, 25)
        Me.tabPreFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPreFactura.Name = "tabPreFactura"
        Me.tabPreFactura.Padding = New System.Windows.Forms.Padding(4)
        Me.tabPreFactura.Size = New System.Drawing.Size(1017, 318)
        Me.tabPreFactura.TabIndex = 1
        Me.tabPreFactura.Text = "Lista Pre Factura"
        Me.tabPreFactura.UseVisualStyleBackColor = True
        '
        'panelGuiaRemision
        '
        Me.panelGuiaRemision.Controls.Add(Me.dgwPreFacturacion)
        Me.panelGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelGuiaRemision.Location = New System.Drawing.Point(4, 4)
        Me.panelGuiaRemision.Margin = New System.Windows.Forms.Padding(4)
        Me.panelGuiaRemision.Name = "panelGuiaRemision"
        Me.panelGuiaRemision.Size = New System.Drawing.Size(1009, 310)
        Me.panelGuiaRemision.StateCommon.Color1 = System.Drawing.Color.Transparent
        Me.panelGuiaRemision.TabIndex = 1
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnAceptar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1025, 27)
        Me.MenuBar.TabIndex = 2
        Me.MenuBar.TabStop = True
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 24)
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.ToolTipText = "Pre Liquidar"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NDCPRF"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Pre - Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FDCPRF_S"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IMPOCOS"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N5"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe por Cobrar S/."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IMPOCOD"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N5"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe por Cobrar $"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VLR_SOL"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn5.HeaderText = "Valorización S/."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VLR_DOL"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valorización $."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn7.HeaderText = "Organización Venta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EN_VLR"
        Me.DataGridViewTextBoxColumn8.HeaderText = "En Valoriz."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "VLR_CANT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "VLR_CANT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 111
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CRGVTA"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 96
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.HeaderText = ""
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'chk
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.chk.DefaultCellStyle = DataGridViewCellStyle1
        Me.chk.FalseValue = "N"
        Me.chk.HeaderText = "Selec."
        Me.chk.IndeterminateValue = "N"
        Me.chk.Name = "chk"
        Me.chk.TrueValue = "S"
        Me.chk.Width = 57
        '
        'NDCPRF
        '
        Me.NDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NDCPRF.DataPropertyName = "NDCPRF"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NDCPRF.DefaultCellStyle = DataGridViewCellStyle2
        Me.NDCPRF.HeaderText = "Nro Pre - Factura"
        Me.NDCPRF.Name = "NDCPRF"
        Me.NDCPRF.Width = 153
        '
        'FDCPRF
        '
        Me.FDCPRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FDCPRF.DataPropertyName = "FDCPRF_S"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FDCPRF.DefaultCellStyle = DataGridViewCellStyle3
        Me.FDCPRF.HeaderText = "Fecha"
        Me.FDCPRF.Name = "FDCPRF"
        Me.FDCPRF.ReadOnly = True
        Me.FDCPRF.Width = 80
        '
        'IMPOCOS_D
        '
        Me.IMPOCOS_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOS_D.DataPropertyName = "IMPOCOS"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N5"
        Me.IMPOCOS_D.DefaultCellStyle = DataGridViewCellStyle4
        Me.IMPOCOS_D.HeaderText = "Importe por Cobrar S/."
        Me.IMPOCOS_D.Name = "IMPOCOS_D"
        Me.IMPOCOS_D.ReadOnly = True
        Me.IMPOCOS_D.Width = 192
        '
        'IMPOCOD_D
        '
        Me.IMPOCOD_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPOCOD_D.DataPropertyName = "IMPOCOD"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N5"
        Me.IMPOCOD_D.DefaultCellStyle = DataGridViewCellStyle5
        Me.IMPOCOD_D.HeaderText = "Importe por Cobrar $"
        Me.IMPOCOD_D.Name = "IMPOCOD_D"
        Me.IMPOCOD_D.ReadOnly = True
        Me.IMPOCOD_D.Width = 183
        '
        'VLR_SOL
        '
        Me.VLR_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_SOL.DataPropertyName = "VLR_SOL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.VLR_SOL.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.VLR_DOL.DefaultCellStyle = DataGridViewCellStyle7
        Me.VLR_DOL.HeaderText = "Valorización $."
        Me.VLR_DOL.Name = "VLR_DOL"
        Me.VLR_DOL.ReadOnly = True
        Me.VLR_DOL.Visible = False
        Me.VLR_DOL.Width = 138
        '
        'TCRVTA_D
        '
        Me.TCRVTA_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA_D.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TCRVTA_D.DefaultCellStyle = DataGridViewCellStyle8
        Me.TCRVTA_D.HeaderText = "Organización Venta"
        Me.TCRVTA_D.Name = "TCRVTA_D"
        Me.TCRVTA_D.Width = 171
        '
        'EN_VLR
        '
        Me.EN_VLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EN_VLR.DataPropertyName = "EN_VLR"
        Me.EN_VLR.HeaderText = "En Valoriz."
        Me.EN_VLR.Name = "EN_VLR"
        Me.EN_VLR.ReadOnly = True
        Me.EN_VLR.Visible = False
        Me.EN_VLR.Width = 110
        '
        'VLR_CANT
        '
        Me.VLR_CANT.DataPropertyName = "VLR_CANT"
        Me.VLR_CANT.HeaderText = "VLR_CANT"
        Me.VLR_CANT.Name = "VLR_CANT"
        Me.VLR_CANT.ReadOnly = True
        Me.VLR_CANT.Visible = False
        Me.VLR_CANT.Width = 111
        '
        'CRGVTA_D
        '
        Me.CRGVTA_D.DataPropertyName = "CRGVTA"
        Me.CRGVTA_D.HeaderText = "CRGVTA"
        Me.CRGVTA_D.Name = "CRGVTA_D"
        Me.CRGVTA_D.Visible = False
        Me.CRGVTA_D.Width = 96
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmAddPreFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 374)
        Me.Controls.Add(Me.TabListaLiquidacion)
        Me.Controls.Add(Me.MenuBar)
        Me.Name = "frmAddPreFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Pre-Factura"
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabListaLiquidacion.ResumeLayout(False)
        Me.tabPreFactura.ResumeLayout(False)
        CType(Me.panelGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGuiaRemision.ResumeLayout(False)
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgwPreFacturacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TabListaLiquidacion As System.Windows.Forms.TabControl
    Friend WithEvents tabPreFactura As System.Windows.Forms.TabPage
    Friend WithEvents panelGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOS_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOD_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EN_VLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_CANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRGVTA_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
