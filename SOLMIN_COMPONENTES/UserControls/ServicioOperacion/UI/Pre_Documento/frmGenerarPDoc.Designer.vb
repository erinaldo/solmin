<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarPDoc
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cblTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtDocRef = New System.Windows.Forms.TextBox()
        Me.txtMon = New System.Windows.Forms.TextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOC = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtgOpPendientes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNIMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPOPER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRGU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRROP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSRVC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgOpPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Operación"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.miniToolStrip.Location = New System.Drawing.Point(0, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(630, 25)
        Me.miniToolStrip.TabIndex = 4
        Me.miniToolStrip.TabStop = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnProcesar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(875, 27)
        Me.ToolStrip1.TabIndex = 107
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(89, 24)
        Me.btnProcesar.Text = "Procesar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.txtImporte)
        Me.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.Panel1.Controls.Add(Me.cblTipoDoc)
        Me.Panel1.Controls.Add(Me.txtDocRef)
        Me.Panel1.Controls.Add(Me.txtMon)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.txtOC)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 100)
        Me.Panel1.TabIndex = 108
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(25, 15)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(79, 24)
        Me.KryptonLabel4.TabIndex = 41
        Me.KryptonLabel4.Text = "Tipo Doc.:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Tipo Doc.:"
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.SystemColors.Window
        Me.txtImporte.Enabled = False
        Me.txtImporte.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtImporte.Location = New System.Drawing.Point(488, 51)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.MaxLength = 10
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(212, 22)
        Me.txtImporte.TabIndex = 37
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(341, 49)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(97, 24)
        Me.KryptonLabel5.TabIndex = 32
        Me.KryptonLabel5.Text = "Importe Doc"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Importe Doc"
        '
        'cblTipoDoc
        '
        Me.cblTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblTipoDoc.FormattingEnabled = True
        Me.cblTipoDoc.Location = New System.Drawing.Point(127, 15)
        Me.cblTipoDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cblTipoDoc.Name = "cblTipoDoc"
        Me.cblTipoDoc.Size = New System.Drawing.Size(183, 24)
        Me.cblTipoDoc.TabIndex = 40
        '
        'txtDocRef
        '
        Me.txtDocRef.BackColor = System.Drawing.SystemColors.Window
        Me.txtDocRef.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDocRef.Location = New System.Drawing.Point(731, 37)
        Me.txtDocRef.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDocRef.MaxLength = 10
        Me.txtDocRef.Name = "txtDocRef"
        Me.txtDocRef.Size = New System.Drawing.Size(122, 22)
        Me.txtDocRef.TabIndex = 39
        Me.txtDocRef.Visible = False
        '
        'txtMon
        '
        Me.txtMon.BackColor = System.Drawing.SystemColors.Window
        Me.txtMon.Enabled = False
        Me.txtMon.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtMon.Location = New System.Drawing.Point(127, 49)
        Me.txtMon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMon.MaxLength = 10
        Me.txtMon.Name = "txtMon"
        Me.txtMon.Size = New System.Drawing.Size(183, 22)
        Me.txtMon.TabIndex = 35
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(25, 47)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel2.TabIndex = 36
        Me.KryptonLabel2.Text = "Moneda"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Moneda"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(729, 15)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(124, 24)
        Me.KryptonLabel3.TabIndex = 38
        Me.KryptonLabel3.Text = "Sub Doc Cliente:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Sub Doc Cliente:"
        Me.KryptonLabel3.Visible = False
        '
        'txtOC
        '
        Me.txtOC.BackColor = System.Drawing.SystemColors.Window
        Me.txtOC.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtOC.Location = New System.Drawing.Point(488, 15)
        Me.txtOC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOC.MaxLength = 20
        Me.txtOC.Name = "txtOC"
        Me.txtOC.Size = New System.Drawing.Size(212, 22)
        Me.txtOC.TabIndex = 34
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(341, 15)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(97, 24)
        Me.KryptonLabel1.TabIndex = 33
        Me.KryptonLabel1.Text = "Doc. Cliente:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Doc. Cliente:"
        '
        'dtgOpPendientes
        '
        Me.dtgOpPendientes.AllowUserToAddRows = False
        Me.dtgOpPendientes.AllowUserToDeleteRows = False
        Me.dtgOpPendientes.AllowUserToResizeColumns = False
        Me.dtgOpPendientes.AllowUserToResizeRows = False
        Me.dtgOpPendientes.ColumnHeadersHeight = 25
        Me.dtgOpPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgOpPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOPRCN, Me.SERVICIO, Me.MONEDA, Me.PNIMDOC, Me.TPOPER, Me.NGUITR, Me.NGUIRM, Me.NCRRGU, Me.NCRROP, Me.CDVSN, Me.CPLNDV, Me.CSRVC, Me.CMNDA1, Me.Column1})
        Me.dtgOpPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOpPendientes.Location = New System.Drawing.Point(0, 127)
        Me.dtgOpPendientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgOpPendientes.Name = "dtgOpPendientes"
        Me.dtgOpPendientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgOpPendientes.RowHeadersVisible = False
        Me.dtgOpPendientes.RowHeadersWidth = 20
        Me.dtgOpPendientes.Size = New System.Drawing.Size(875, 413)
        Me.dtgOpPendientes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOpPendientes.TabIndex = 109
        Me.dtgOpPendientes.TabStop = False
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "PNNOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 111
        '
        'SERVICIO
        '
        Me.SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SERVICIO.DataPropertyName = "SERVICIO"
        Me.SERVICIO.HeaderText = "Servicio"
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.ReadOnly = True
        Me.SERVICIO.Width = 94
        '
        'MONEDA
        '
        Me.MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA.DataPropertyName = "MONEDA"
        Me.MONEDA.HeaderText = "Moneda"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        Me.MONEDA.Width = 97
        '
        'PNIMDOC
        '
        Me.PNIMDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNIMDOC.DataPropertyName = "PNIVLSRV"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PNIMDOC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNIMDOC.HeaderText = "Importe Doc"
        Me.PNIMDOC.Name = "PNIMDOC"
        Me.PNIMDOC.ReadOnly = True
        Me.PNIMDOC.Width = 126
        '
        'TPOPER
        '
        Me.TPOPER.DataPropertyName = "PSTPOPER"
        Me.TPOPER.HeaderText = "TPOPER"
        Me.TPOPER.Name = "TPOPER"
        Me.TPOPER.Visible = False
        '
        'NGUITR
        '
        Me.NGUITR.DataPropertyName = "PNNGUITR"
        Me.NGUITR.HeaderText = "NGUITR"
        Me.NGUITR.Name = "NGUITR"
        Me.NGUITR.Visible = False
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "PNNGUIRM"
        Me.NGUIRM.HeaderText = "NGUIRM"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.Visible = False
        '
        'NCRRGU
        '
        Me.NCRRGU.DataPropertyName = "PNNCRRGU"
        Me.NCRRGU.HeaderText = "NCRRGU"
        Me.NCRRGU.Name = "NCRRGU"
        Me.NCRRGU.Visible = False
        '
        'NCRROP
        '
        Me.NCRROP.DataPropertyName = "PNNCRROP"
        Me.NCRROP.HeaderText = "NCRROP"
        Me.NCRROP.Name = "NCRROP"
        Me.NCRROP.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "PSCDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.Visible = False
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "PNCPLNDV"
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.Visible = False
        '
        'CSRVC
        '
        Me.CSRVC.DataPropertyName = "PNCSRVC"
        Me.CSRVC.HeaderText = "CSRVC"
        Me.CSRVC.Name = "CSRVC"
        Me.CSRVC.Visible = False
        '
        'CMNDA1
        '
        Me.CMNDA1.DataPropertyName = "PNCMNDA1"
        Me.CMNDA1.HeaderText = "CMNDA1"
        Me.CMNDA1.Name = "CMNDA1"
        Me.CMNDA1.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmGenerarPDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 540)
        Me.Controls.Add(Me.dtgOpPendientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGenerarPDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesar Pre-Documento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgOpPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cblTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtDocRef As System.Windows.Forms.TextBox
    Friend WithEvents txtMon As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOC As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgOpPendientes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNIMDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPOPER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRROP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
