<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaInventario
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
        Me.dgvResumen = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PSCMRCLR_NEW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQTRMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNCN5_NEW = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCTPALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCALMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCZNALM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtFechaDespacho = New System.Windows.Forms.DateTimePicker
        Me.txtOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1292, 399)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 27)
        Me.KryptonGroup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.dgvResumen)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1292, 372)
        Me.KryptonGroup1.TabIndex = 21
        '
        'dgvResumen
        '
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.AllowUserToDeleteRows = False
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCMRCLR_NEW, Me.PSTMRCD2, Me.PNQTRMC, Me.PSCUNCN5_NEW, Me.PSCFMCLR, Me.PSTFMCLR, Me.PSCGRCLR, Me.PSTGRCLR, Me.PSCTPALM, Me.PSCALMC, Me.PSCZNALM, Me.Column10})
        Me.dgvResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResumen.Location = New System.Drawing.Point(0, 127)
        Me.dgvResumen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.ReadOnly = True
        Me.dgvResumen.Size = New System.Drawing.Size(1290, 243)
        Me.dgvResumen.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvResumen.TabIndex = 23
        '
        'PSCMRCLR_NEW
        '
        Me.PSCMRCLR_NEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCMRCLR_NEW.DataPropertyName = "PSCMRCLR_NEW"
        Me.PSCMRCLR_NEW.HeaderText = "MERCADERIA"
        Me.PSCMRCLR_NEW.Name = "PSCMRCLR_NEW"
        Me.PSCMRCLR_NEW.ReadOnly = True
        Me.PSCMRCLR_NEW.Width = 129
        '
        'PSTMRCD2
        '
        Me.PSTMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTMRCD2.DataPropertyName = "PSTMRCD2"
        Me.PSTMRCD2.HeaderText = "DESCRIPCION MERCADERIA"
        Me.PSTMRCD2.Name = "PSTMRCD2"
        Me.PSTMRCD2.ReadOnly = True
        Me.PSTMRCD2.Width = 205
        '
        'PNQTRMC
        '
        Me.PNQTRMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNQTRMC.DataPropertyName = "PNQTRMC"
        Me.PNQTRMC.HeaderText = "CANTIDAD"
        Me.PNQTRMC.Name = "PNQTRMC"
        Me.PNQTRMC.ReadOnly = True
        Me.PNQTRMC.Width = 112
        '
        'PSCUNCN5_NEW
        '
        Me.PSCUNCN5_NEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCUNCN5_NEW.DataPropertyName = "PSCUNCN5_NEW"
        Me.PSCUNCN5_NEW.HeaderText = "UNIDAD DE MEDIDA"
        Me.PSCUNCN5_NEW.Name = "PSCUNCN5_NEW"
        Me.PSCUNCN5_NEW.ReadOnly = True
        Me.PSCUNCN5_NEW.Width = 112
        '
        'PSCFMCLR
        '
        Me.PSCFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCFMCLR.DataPropertyName = "PSCFMCLR"
        Me.PSCFMCLR.HeaderText = "COD. FAMILIA"
        Me.PSCFMCLR.Name = "PSCFMCLR"
        Me.PSCFMCLR.ReadOnly = True
        Me.PSCFMCLR.Width = 119
        '
        'PSTFMCLR
        '
        Me.PSTFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTFMCLR.DataPropertyName = "PSTFMCLR"
        Me.PSTFMCLR.HeaderText = "FAMILIA"
        Me.PSTFMCLR.Name = "PSTFMCLR"
        Me.PSTFMCLR.ReadOnly = True
        Me.PSTFMCLR.Visible = False
        '
        'PSCGRCLR
        '
        Me.PSCGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCGRCLR.DataPropertyName = "PSCGRCLR"
        Me.PSCGRCLR.HeaderText = "COD. GRUPO"
        Me.PSCGRCLR.Name = "PSCGRCLR"
        Me.PSCGRCLR.ReadOnly = True
        Me.PSCGRCLR.Width = 114
        '
        'PSTGRCLR
        '
        Me.PSTGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTGRCLR.DataPropertyName = "PSTGRCLR"
        Me.PSTGRCLR.HeaderText = "GRUPO"
        Me.PSTGRCLR.Name = "PSTGRCLR"
        Me.PSTGRCLR.ReadOnly = True
        Me.PSTGRCLR.Visible = False
        '
        'PSCTPALM
        '
        Me.PSCTPALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCTPALM.DataPropertyName = "PSCTPALM"
        Me.PSCTPALM.HeaderText = "TIPO ALMACEN"
        Me.PSCTPALM.Name = "PSCTPALM"
        Me.PSCTPALM.ReadOnly = True
        Me.PSCTPALM.Width = 129
        '
        'PSCALMC
        '
        Me.PSCALMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCALMC.DataPropertyName = "PSCALMC"
        Me.PSCALMC.HeaderText = "ALMACEN"
        Me.PSCALMC.Name = "PSCALMC"
        Me.PSCALMC.ReadOnly = True
        Me.PSCALMC.Width = 106
        '
        'PSCZNALM
        '
        Me.PSCZNALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCZNALM.DataPropertyName = "PSCZNALM"
        Me.PSCZNALM.HeaderText = "ZONA"
        Me.PSCZNALM.Name = "PSCZNALM"
        Me.PSCZNALM.ReadOnly = True
        Me.PSCZNALM.Width = 79
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtFechaDespacho)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtOrdenCompra)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup2.Panel.Controls.Add(Me.txtDescripcion)
        Me.KryptonGroup2.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup2.Size = New System.Drawing.Size(1290, 127)
        Me.KryptonGroup2.TabIndex = 22
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(336, 11)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Text = "Ref. O/C"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Ref. O/C"
        '
        'txtFechaDespacho
        '
        Me.txtFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDespacho.Location = New System.Drawing.Point(151, 11)
        Me.txtFechaDespacho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFechaDespacho.Name = "txtFechaDespacho"
        Me.txtFechaDespacho.Size = New System.Drawing.Size(127, 22)
        Me.txtFechaDespacho.TabIndex = 21
        Me.txtFechaDespacho.Value = New Date(2014, 10, 16, 0, 0, 0, 0)
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Enabled = False
        Me.txtOrdenCompra.Location = New System.Drawing.Point(419, 11)
        Me.txtOrdenCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(401, 26)
        Me.txtOrdenCompra.TabIndex = 17
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(19, 44)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(96, 24)
        Me.KryptonLabel4.TabIndex = 19
        Me.KryptonLabel4.Text = "Observación"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Observación"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(151, 44)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(669, 70)
        Me.txtDescripcion.TabIndex = 20
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(19, 11)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(51, 24)
        Me.KryptonLabel3.TabIndex = 16
        Me.KryptonLabel3.Text = "Fecha"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAceptar, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1292, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAceptar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_ok1
        Me.btnAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(81, 24)
        Me.btnAceptar.Text = "Aceptar"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(91, 24)
        Me.ToolStripLabel1.Text = "Datos Carga"
        '
        'frmCargaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 399)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCargaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Inventario"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFechaDespacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dgvResumen As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PSCMRCLR_NEW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQTRMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNCN5_NEW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCTPALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCALMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCZNALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
