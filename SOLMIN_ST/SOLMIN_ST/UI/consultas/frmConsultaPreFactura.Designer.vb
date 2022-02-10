<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPreFactura
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.dgwPreFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TbtnQuitarPreFactura = New System.Windows.Forms.ToolStripButton()
        Me.btnAdPreFactura = New System.Windows.Forms.ToolStripButton()
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
        Me.TCRVTA_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VLR_CANT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EN_VLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRGVTA_D = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgwPreFacturacion)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(989, 401)
        Me.KryptonPanel.TabIndex = 0
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
        Me.dgwPreFacturacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.NDCPRF, Me.FDCPRF, Me.IMPOCOS_D, Me.IMPOCOD_D, Me.TCRVTA_D, Me.VLR_SOL, Me.VLR_DOL, Me.VLR_CANT, Me.EN_VLR, Me.CRGVTA_D, Me.Column1})
        Me.dgwPreFacturacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwPreFacturacion.Location = New System.Drawing.Point(0, 27)
        Me.dgwPreFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwPreFacturacion.MultiSelect = False
        Me.dgwPreFacturacion.Name = "dgwPreFacturacion"
        Me.dgwPreFacturacion.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgwPreFacturacion.RowHeadersVisible = False
        Me.dgwPreFacturacion.RowHeadersWidth = 20
        Me.dgwPreFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwPreFacturacion.Size = New System.Drawing.Size(989, 374)
        Me.dgwPreFacturacion.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgwPreFacturacion.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.TbtnQuitarPreFactura, Me.btnAdPreFactura})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(90, 24)
        Me.ToolStripButton2.Text = "Cancelar"
        '
        'TbtnQuitarPreFactura
        '
        Me.TbtnQuitarPreFactura.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TbtnQuitarPreFactura.Image = Global.SOLMIN_ST.My.Resources.Resources.db_remove
        Me.TbtnQuitarPreFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TbtnQuitarPreFactura.Name = "TbtnQuitarPreFactura"
        Me.TbtnQuitarPreFactura.Size = New System.Drawing.Size(150, 24)
        Me.TbtnQuitarPreFactura.Text = "Quitar Pre Factura"
        '
        'btnAdPreFactura
        '
        Me.btnAdPreFactura.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdPreFactura.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnAdPreFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdPreFactura.Name = "btnAdPreFactura"
        Me.btnAdPreFactura.Size = New System.Drawing.Size(165, 24)
        Me.btnAdPreFactura.Text = "Agregar Pre-Factura"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NDCPRF"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Pre - Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 153
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FDCPRF_S"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IMPOCOS"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N5"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe por Cobrar S/."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IMPOCOD"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N5"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe por Cobrar $"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "Organización Venta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 171
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CRGVTA"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CRGVTA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 144
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VLR_DOL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Valorización $/."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 144
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VLR_CANT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "VLR_CANT"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 111
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EN_VLR"
        Me.DataGridViewTextBoxColumn9.HeaderText = "En Valorización"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 143
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
        Me.FDCPRF.DataPropertyName = "FDCPRF"
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
        'TCRVTA_D
        '
        Me.TCRVTA_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCRVTA_D.DataPropertyName = "TCRVTA"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TCRVTA_D.DefaultCellStyle = DataGridViewCellStyle6
        Me.TCRVTA_D.HeaderText = "Organización Venta"
        Me.TCRVTA_D.Name = "TCRVTA_D"
        Me.TCRVTA_D.Width = 171
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
        Me.VLR_DOL.HeaderText = "Valorización $/."
        Me.VLR_DOL.Name = "VLR_DOL"
        Me.VLR_DOL.ReadOnly = True
        Me.VLR_DOL.Visible = False
        Me.VLR_DOL.Width = 144
        '
        'VLR_CANT
        '
        Me.VLR_CANT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLR_CANT.DataPropertyName = "VLR_CANT"
        Me.VLR_CANT.HeaderText = "VLR_CANT"
        Me.VLR_CANT.Name = "VLR_CANT"
        Me.VLR_CANT.ReadOnly = True
        Me.VLR_CANT.Visible = False
        Me.VLR_CANT.Width = 111
        '
        'EN_VLR
        '
        Me.EN_VLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EN_VLR.DataPropertyName = "EN_VLR"
        Me.EN_VLR.HeaderText = "En Valorización"
        Me.EN_VLR.Name = "EN_VLR"
        Me.EN_VLR.ReadOnly = True
        Me.EN_VLR.Visible = False
        Me.EN_VLR.Width = 143
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
        'frmConsultaPreFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 401)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(18, 435)
        Me.Name = "frmConsultaPreFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Pre - Factura"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgwPreFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TbtnQuitarPreFactura As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgwPreFacturacion As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdPreFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents chk As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOS_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPOCOD_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCRVTA_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VLR_CANT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EN_VLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRGVTA_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
