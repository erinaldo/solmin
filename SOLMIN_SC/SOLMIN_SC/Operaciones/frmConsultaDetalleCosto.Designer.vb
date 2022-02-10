<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDetalleCosto
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.kgvDetalleCostos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CSRVRL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMTPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO_SOL_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PIGVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMTPOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO_DOL_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.kgvDetalleCostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.kgvDetalleCostos)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1000, 392)
        Me.KryptonPanel.TabIndex = 0
        '
        'kgvDetalleCostos
        '
        Me.kgvDetalleCostos.AllowUserToAddRows = False
        Me.kgvDetalleCostos.AllowUserToDeleteRows = False
        Me.kgvDetalleCostos.AllowUserToResizeColumns = False
        Me.kgvDetalleCostos.AllowUserToResizeRows = False
        Me.kgvDetalleCostos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.kgvDetalleCostos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.kgvDetalleCostos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CSRVRL, Me.TCMTRF, Me.TCMTPD, Me.NUMDOC, Me.MONTO_SOL, Me.MONTO_SOL_FINAL, Me.PIGVA, Me.IMTPOC, Me.MONTO_DOL, Me.MONTO_DOL_FINAL})
        Me.kgvDetalleCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kgvDetalleCostos.Location = New System.Drawing.Point(0, 25)
        Me.kgvDetalleCostos.Name = "kgvDetalleCostos"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold)
        Me.kgvDetalleCostos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.kgvDetalleCostos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.kgvDetalleCostos.Size = New System.Drawing.Size(1000, 367)
        Me.kgvDetalleCostos.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.kgvDetalleCostos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kgvDetalleCostos.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CSRVRL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TCMTRF"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción Servicio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMTPD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NDCCT1"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero Documento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 99
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IMTPOC"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo Cambio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IVLDOL"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 108
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IMPVTD"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn7.HeaderText = "Importe Venta($)"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 56
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IMPVTS"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn8.HeaderText = "Importe Venta(s/.)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 81
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TCMTPD"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Linen
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tipo Documento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn9.Width = 69
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NDCCT1"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Linen
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nro Documento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn10.Width = 102
        '
        'CSRVRL
        '
        Me.CSRVRL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CSRVRL.DataPropertyName = "CSRVRL"
        Me.CSRVRL.HeaderText = "Servicio"
        Me.CSRVRL.Name = "CSRVRL"
        Me.CSRVRL.ReadOnly = True
        Me.CSRVRL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CSRVRL.Width = 56
        '
        'TCMTRF
        '
        Me.TCMTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "Descripción Servicio"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.ReadOnly = True
        Me.TCMTRF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCMTRF.Width = 119
        '
        'TCMTPD
        '
        Me.TCMTPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTPD.DataPropertyName = "TCMTPD"
        Me.TCMTPD.HeaderText = "Tipo Documento"
        Me.TCMTPD.Name = "TCMTPD"
        Me.TCMTPD.ReadOnly = True
        Me.TCMTPD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCMTPD.Width = 102
        '
        'NUMDOC
        '
        Me.NUMDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NUMDOC.DataPropertyName = "NDCCT1"
        Me.NUMDOC.HeaderText = "Nro Documento"
        Me.NUMDOC.Name = "NUMDOC"
        Me.NUMDOC.ReadOnly = True
        Me.NUMDOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NUMDOC.Width = 99
        '
        'MONTO_SOL
        '
        Me.MONTO_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONTO_SOL.DataPropertyName = "IVLSOL"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.MONTO_SOL.DefaultCellStyle = DataGridViewCellStyle1
        Me.MONTO_SOL.HeaderText = "Importe(s/.)"
        Me.MONTO_SOL.Name = "MONTO_SOL"
        Me.MONTO_SOL.ReadOnly = True
        Me.MONTO_SOL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MONTO_SOL.Width = 75
        '
        'MONTO_SOL_FINAL
        '
        Me.MONTO_SOL_FINAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONTO_SOL_FINAL.DataPropertyName = "IMPVTS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige
        Me.MONTO_SOL_FINAL.DefaultCellStyle = DataGridViewCellStyle2
        Me.MONTO_SOL_FINAL.HeaderText = "Importe Venta(s/.)"
        Me.MONTO_SOL_FINAL.Name = "MONTO_SOL_FINAL"
        Me.MONTO_SOL_FINAL.ReadOnly = True
        Me.MONTO_SOL_FINAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MONTO_SOL_FINAL.Width = 108
        '
        'PIGVA
        '
        Me.PIGVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PIGVA.DataPropertyName = "PIGVA"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.PIGVA.DefaultCellStyle = DataGridViewCellStyle3
        Me.PIGVA.HeaderText = "( % IGV)"
        Me.PIGVA.Name = "PIGVA"
        Me.PIGVA.ReadOnly = True
        Me.PIGVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PIGVA.Width = 56
        '
        'IMTPOC
        '
        Me.IMTPOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMTPOC.DataPropertyName = "IMTPOC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IMTPOC.DefaultCellStyle = DataGridViewCellStyle4
        Me.IMTPOC.HeaderText = "Tipo Cambio"
        Me.IMTPOC.Name = "IMTPOC"
        Me.IMTPOC.ReadOnly = True
        Me.IMTPOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IMTPOC.Width = 81
        '
        'MONTO_DOL
        '
        Me.MONTO_DOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONTO_DOL.DataPropertyName = "IVLDOL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Linen
        Me.MONTO_DOL.DefaultCellStyle = DataGridViewCellStyle5
        Me.MONTO_DOL.HeaderText = "Importe($)"
        Me.MONTO_DOL.Name = "MONTO_DOL"
        Me.MONTO_DOL.ReadOnly = True
        Me.MONTO_DOL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MONTO_DOL.Width = 69
        '
        'MONTO_DOL_FINAL
        '
        Me.MONTO_DOL_FINAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONTO_DOL_FINAL.DataPropertyName = "IMPVTD"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Linen
        Me.MONTO_DOL_FINAL.DefaultCellStyle = DataGridViewCellStyle6
        Me.MONTO_DOL_FINAL.HeaderText = "Importe Venta($)"
        Me.MONTO_DOL_FINAL.Name = "MONTO_DOL_FINAL"
        Me.MONTO_DOL_FINAL.ReadOnly = True
        Me.MONTO_DOL_FINAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MONTO_DOL_FINAL.Width = 102
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CTPOD1"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TIPODOC"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 64
        '
        'frmConsultaDetalleCosto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 392)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaDetalleCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle Costo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.kgvDetalleCostos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents kgvDetalleCostos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CSRVRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_SOL_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PIGVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMTPOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_DOL_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
