<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcesarDespachoMasivo
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QSLMC2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UBICA1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SITUAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtFechaDespacho = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(971, 406)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.dgMercaderias)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonGroup1.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(971, 406)
        Me.KryptonGroup1.TabIndex = 0
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgMercaderias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CMRCLR, Me.TMRCD2, Me.QSLMC2, Me.CUNCN5, Me.NORDSR, Me.CFMCLR, Me.TFMCLR, Me.CGRCLR, Me.TGRCLR, Me.CTPALM, Me.CALMC, Me.CZNALM, Me.UBICA1, Me.SITUAC, Me.Column1})
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(0, 129)
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.ReadOnly = True
        Me.dgMercaderias.Size = New System.Drawing.Size(969, 275)
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.TabIndex = 18
        '
        'CMRCLR
        '
        Me.CMRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMRCLR.DataPropertyName = "CMRCLR"
        Me.CMRCLR.HeaderText = "Cod. Mercadería"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        Me.CMRCLR.Width = 113
        '
        'TMRCD2
        '
        Me.TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Descripción"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        Me.TMRCD2.Width = 98
        '
        'QSLMC2
        '
        Me.QSLMC2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QSLMC2.DataPropertyName = "QSLMC2"
        Me.QSLMC2.HeaderText = "Cantidad"
        Me.QSLMC2.Name = "QSLMC2"
        Me.QSLMC2.ReadOnly = True
        Me.QSLMC2.Width = 84
        '
        'CUNCN5
        '
        Me.CUNCN5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNCN5.DataPropertyName = "CUNCN5"
        Me.CUNCN5.HeaderText = "Unid."
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.ReadOnly = True
        Me.CUNCN5.Width = 64
        '
        'NORDSR
        '
        Me.NORDSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "Orden Servicio"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        Me.NORDSR.Width = 104
        '
        'CFMCLR
        '
        Me.CFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CFMCLR.DataPropertyName = "CFMCLR"
        Me.CFMCLR.HeaderText = "Cod. Familia"
        Me.CFMCLR.Name = "CFMCLR"
        Me.CFMCLR.ReadOnly = True
        Me.CFMCLR.Visible = False
        '
        'TFMCLR
        '
        Me.TFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TFMCLR.DataPropertyName = "TFMCLR"
        Me.TFMCLR.HeaderText = "Familia"
        Me.TFMCLR.Name = "TFMCLR"
        Me.TFMCLR.ReadOnly = True
        Me.TFMCLR.Visible = False
        '
        'CGRCLR
        '
        Me.CGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGRCLR.DataPropertyName = "CGRCLR"
        Me.CGRCLR.HeaderText = "Cod. Grupo"
        Me.CGRCLR.Name = "CGRCLR"
        Me.CGRCLR.ReadOnly = True
        Me.CGRCLR.Visible = False
        '
        'TGRCLR
        '
        Me.TGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TGRCLR.DataPropertyName = "TGRCLR"
        Me.TGRCLR.HeaderText = "Grupo"
        Me.TGRCLR.Name = "TGRCLR"
        Me.TGRCLR.ReadOnly = True
        Me.TGRCLR.Visible = False
        '
        'CTPALM
        '
        Me.CTPALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTPALM.DataPropertyName = "CTPALM"
        Me.CTPALM.HeaderText = "Tipo Almacén"
        Me.CTPALM.Name = "CTPALM"
        Me.CTPALM.ReadOnly = True
        Me.CTPALM.Width = 101
        '
        'CALMC
        '
        Me.CALMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CALMC.DataPropertyName = "CALMC"
        Me.CALMC.HeaderText = "Almacén"
        Me.CALMC.Name = "CALMC"
        Me.CALMC.ReadOnly = True
        Me.CALMC.Width = 83
        '
        'CZNALM
        '
        Me.CZNALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CZNALM.DataPropertyName = "CZNALM"
        Me.CZNALM.HeaderText = "Zona"
        Me.CZNALM.Name = "CZNALM"
        Me.CZNALM.ReadOnly = True
        Me.CZNALM.Width = 63
        '
        'UBICA1
        '
        Me.UBICA1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBICA1.DataPropertyName = "UBICA1"
        Me.UBICA1.HeaderText = "Ref. Ubicación"
        Me.UBICA1.Name = "UBICA1"
        Me.UBICA1.ReadOnly = True
        Me.UBICA1.Visible = False
        '
        'SITUAC
        '
        Me.SITUAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SITUAC.DataPropertyName = "SITUAC"
        Me.SITUAC.HeaderText = "Situación"
        Me.SITUAC.Name = "SITUAC"
        Me.SITUAC.ReadOnly = True
        Me.SITUAC.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtFechaDespacho)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtObservacion)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup2.Size = New System.Drawing.Size(969, 104)
        Me.KryptonGroup2.TabIndex = 17
        '
        'txtFechaDespacho
        '
        Me.txtFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDespacho.Location = New System.Drawing.Point(114, 9)
        Me.txtFechaDespacho.Name = "txtFechaDespacho"
        Me.txtFechaDespacho.Size = New System.Drawing.Size(96, 20)
        Me.txtFechaDespacho.TabIndex = 16
        Me.txtFechaDespacho.Value = New Date(2014, 10, 16, 0, 0, 0, 0)
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 9)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(99, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "Fecha Despacho"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha Despacho"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(114, 39)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(491, 54)
        Me.txtObservacion.TabIndex = 14
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(12, 31)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(78, 20)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Text = "Observación"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Observación"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(969, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnProcesar
        '
        Me.btnProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnProcesar.Image = Global.SOLMIN_SA.My.Resources.Resources.runprog
        Me.btnProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(72, 22)
        Me.btnProcesar.Text = "Procesar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(140, 22)
        Me.ToolStripLabel1.Text = "Datos Pedido - Despacho"
        '
        'frmProcesarDespachoMasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 406)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmProcesarDespachoMasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Despacho Masivo"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
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
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFechaDespacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QSLMC2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SITUAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
