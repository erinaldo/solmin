<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperacionesXPreDoc
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
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblLote = New System.Windows.Forms.ToolStripLabel()
        Me.btnExportar = New System.Windows.Forms.ToolStripButton()
        Me.dtgOpPendientes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTOP_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRLQD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSGNMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVLSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABTPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCMFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNIMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBar.SuspendLayout()
        CType(Me.dtgOpPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.Separator1, Me.ToolStripLabel1, Me.lblLote, Me.btnExportar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(641, 27)
        Me.MenuBar.TabIndex = 7
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 24)
        Me.btnCancelar.Text = "Cerrar"
        '
        'Separator1
        '
        Me.Separator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 24)
        '
        'lblLote
        '
        Me.lblLote.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(0, 24)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.icono_exp_excel
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 24)
        Me.btnExportar.Text = "Exportar"
        '
        'dtgOpPendientes
        '
        Me.dtgOpPendientes.AllowUserToAddRows = False
        Me.dtgOpPendientes.AllowUserToDeleteRows = False
        Me.dtgOpPendientes.AllowUserToResizeColumns = False
        Me.dtgOpPendientes.AllowUserToResizeRows = False
        Me.dtgOpPendientes.ColumnHeadersHeight = 25
        Me.dtgOpPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgOpPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN, Me.SERVICIO, Me.TCMPDV, Me.TPLNTA, Me.SESTOP_DESC, Me.NDCPRF, Me.NPRLQD, Me.NSECFC, Me.TCMTRF, Me.TSGNMN, Me.IVLSRV, Me.TABTPD, Me.NDCMFC, Me.MONEDA, Me.PNIMDOC, Me.Column1})
        Me.dtgOpPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOpPendientes.Location = New System.Drawing.Point(0, 27)
        Me.dtgOpPendientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtgOpPendientes.Name = "dtgOpPendientes"
        Me.dtgOpPendientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgOpPendientes.RowHeadersVisible = False
        Me.dtgOpPendientes.RowHeadersWidth = 20
        Me.dtgOpPendientes.Size = New System.Drawing.Size(641, 294)
        Me.dtgOpPendientes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOpPendientes.TabIndex = 110
        Me.dtgOpPendientes.TabStop = False
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 111
        '
        'SERVICIO
        '
        Me.SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SERVICIO.DataPropertyName = "TCMTRF"
        Me.SERVICIO.HeaderText = "Servicio"
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.ReadOnly = True
        Me.SERVICIO.Width = 94
        '
        'TCMPDV
        '
        Me.TCMPDV.DataPropertyName = "TCMPDV"
        Me.TCMPDV.HeaderText = "TCMPDV"
        Me.TCMPDV.Name = "TCMPDV"
        Me.TCMPDV.Visible = False
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "TPLNTA"
        Me.TPLNTA.HeaderText = "TPLNTA"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.Visible = False
        '
        'SESTOP_DESC
        '
        Me.SESTOP_DESC.DataPropertyName = "SESTOP_DESC"
        Me.SESTOP_DESC.HeaderText = "SESTOP_DESC"
        Me.SESTOP_DESC.Name = "SESTOP_DESC"
        Me.SESTOP_DESC.Visible = False
        '
        'NDCPRF
        '
        Me.NDCPRF.DataPropertyName = "NDCPRF"
        Me.NDCPRF.HeaderText = "NDCPRF"
        Me.NDCPRF.Name = "NDCPRF"
        Me.NDCPRF.Visible = False
        '
        'NPRLQD
        '
        Me.NPRLQD.DataPropertyName = "NPRLQD"
        Me.NPRLQD.HeaderText = "NPRLQD"
        Me.NPRLQD.Name = "NPRLQD"
        Me.NPRLQD.Visible = False
        '
        'NSECFC
        '
        Me.NSECFC.DataPropertyName = "NSECFC"
        Me.NSECFC.HeaderText = "NSECFC"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.Visible = False
        '
        'TCMTRF
        '
        Me.TCMTRF.DataPropertyName = "TCMTRF"
        Me.TCMTRF.HeaderText = "TCMTRF"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.Visible = False
        '
        'TSGNMN
        '
        Me.TSGNMN.DataPropertyName = "TSGNMN"
        Me.TSGNMN.HeaderText = "TSGNMN"
        Me.TSGNMN.Name = "TSGNMN"
        Me.TSGNMN.Visible = False
        '
        'IVLSRV
        '
        Me.IVLSRV.DataPropertyName = "IVLSRV"
        Me.IVLSRV.HeaderText = "IVLSRV"
        Me.IVLSRV.Name = "IVLSRV"
        Me.IVLSRV.Visible = False
        '
        'TABTPD
        '
        Me.TABTPD.DataPropertyName = "TABTPD"
        Me.TABTPD.HeaderText = "TABTPD"
        Me.TABTPD.Name = "TABTPD"
        Me.TABTPD.Visible = False
        '
        'NDCMFC
        '
        Me.NDCMFC.DataPropertyName = "NDCMFC"
        Me.NDCMFC.HeaderText = "NDCMFC"
        Me.NDCMFC.Name = "NDCMFC"
        Me.NDCMFC.Visible = False
        '
        'MONEDA
        '
        Me.MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA.DataPropertyName = "TSGNMN"
        Me.MONEDA.HeaderText = "Moneda"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        Me.MONEDA.Width = 97
        '
        'PNIMDOC
        '
        Me.PNIMDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNIMDOC.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PNIMDOC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNIMDOC.HeaderText = "Importe Doc"
        Me.PNIMDOC.Name = "PNIMDOC"
        Me.PNIMDOC.ReadOnly = True
        Me.PNIMDOC.Width = 126
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmOperacionesXPreDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 321)
        Me.Controls.Add(Me.dtgOpPendientes)
        Me.Controls.Add(Me.MenuBar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmOperacionesXPreDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones por Pre-Documento"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        CType(Me.dtgOpPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Separator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblLote As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtgOpPendientes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOP_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRLQD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSGNMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVLSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCMFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNIMDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
