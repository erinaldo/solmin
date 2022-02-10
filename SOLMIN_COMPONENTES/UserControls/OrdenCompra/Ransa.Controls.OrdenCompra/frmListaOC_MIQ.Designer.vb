<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaOC_MIQ
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaOC_MIQ))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.kdgvOC = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.btnImport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtOC = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.rbOC = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rbFechaOC = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.SNROOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DEMIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CINCOTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CMONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPAIORI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SPROV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DFECCRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DFECACT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SARECOM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CURG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnExist = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.kdgvOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.kdgvOC)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip2)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(944, 625)
        Me.KryptonPanel.TabIndex = 0
        '
        'kdgvOC
        '
        Me.kdgvOC.AllowUserToAddRows = False
        Me.kdgvOC.AllowUserToDeleteRows = False
        Me.kdgvOC.AllowUserToResizeColumns = False
        Me.kdgvOC.AllowUserToResizeRows = False
        Me.kdgvOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.kdgvOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNROOC, Me.DEMIS, Me.CINCOTE, Me.CMONEDA, Me.CPAIORI, Me.SPROV, Me.DFECCRE, Me.DFECACT, Me.SARECOM, Me.CURG, Me.btnExist})
        Me.kdgvOC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kdgvOC.Location = New System.Drawing.Point(0, 121)
        Me.kdgvOC.Name = "kdgvOC"
        Me.kdgvOC.Size = New System.Drawing.Size(944, 504)
        Me.kdgvOC.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.kdgvOC.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdgvOC.TabIndex = 5
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnImport, Me.ToolStripLabel1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(944, 25)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnImport
        '
        Me.btnImport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImport.Image = Global.Ransa.Controls.OrdenCompra.My.Resources.Resources.ImportarYRC
        Me.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(90, 22)
        Me.btnImport.Text = "Importar OC"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "OC MIQ"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.GroupBox1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(944, 71)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.KryptonLabel1)
        Me.GroupBox1.Controls.Add(Me.txtOC)
        Me.GroupBox1.Controls.Add(Me.rbOC)
        Me.GroupBox1.Controls.Add(Me.rbFechaOC)
        Me.GroupBox1.Controls.Add(Me.dtFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtFechaIni)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 54)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(546, 18)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(20, 19)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Text = "Al"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Al"
        '
        'txtOC
        '
        Me.txtOC.Location = New System.Drawing.Point(111, 17)
        Me.txtOC.MaxLength = 35
        Me.txtOC.Name = "txtOC"
        Me.txtOC.Size = New System.Drawing.Size(192, 21)
        Me.txtOC.TabIndex = 15
        '
        'rbOC
        '
        Me.rbOC.Location = New System.Drawing.Point(6, 18)
        Me.rbOC.Name = "rbOC"
        Me.rbOC.Size = New System.Drawing.Size(99, 19)
        Me.rbOC.TabIndex = 14
        Me.rbOC.Text = "Orden Compra:"
        Me.rbOC.Values.ExtraText = ""
        Me.rbOC.Values.Image = Nothing
        Me.rbOC.Values.Text = "Orden Compra:"
        '
        'rbFechaOC
        '
        Me.rbFechaOC.Location = New System.Drawing.Point(320, 18)
        Me.rbFechaOC.Name = "rbFechaOC"
        Me.rbFechaOC.Size = New System.Drawing.Size(123, 19)
        Me.rbFechaOC.TabIndex = 13
        Me.rbFechaOC.Text = "Fecha Actualización:"
        Me.rbFechaOC.Values.ExtraText = ""
        Me.rbFechaOC.Values.Image = Nothing
        Me.rbFechaOC.Values.Text = "Fecha Actualización:"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(575, 17)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(86, 20)
        Me.dtFechaFin.TabIndex = 12
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(449, 17)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(86, 20)
        Me.dtFechaIni.TabIndex = 11
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(944, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCerrar
        '
        Me.btnCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(58, 22)
        Me.btnCerrar.Text = "Cerrar"
        '
        'SNROOC
        '
        Me.SNROOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SNROOC.DataPropertyName = "SNROOC"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.SNROOC.DefaultCellStyle = DataGridViewCellStyle1
        Me.SNROOC.HeaderText = "Nro Orden Compra"
        Me.SNROOC.Name = "SNROOC"
        Me.SNROOC.ReadOnly = True
        Me.SNROOC.Width = 123
        '
        'DEMIS
        '
        Me.DEMIS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DEMIS.DataPropertyName = "DEMIS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DEMIS.DefaultCellStyle = DataGridViewCellStyle2
        Me.DEMIS.HeaderText = "Fecha OC"
        Me.DEMIS.Name = "DEMIS"
        Me.DEMIS.ReadOnly = True
        Me.DEMIS.Width = 79
        '
        'CINCOTE
        '
        Me.CINCOTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CINCOTE.DataPropertyName = "CINCOTE"
        Me.CINCOTE.HeaderText = "INCOTERM"
        Me.CINCOTE.Name = "CINCOTE"
        Me.CINCOTE.ReadOnly = True
        Me.CINCOTE.Width = 91
        '
        'CMONEDA
        '
        Me.CMONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMONEDA.DataPropertyName = "CMONEDA"
        Me.CMONEDA.HeaderText = "Moneda"
        Me.CMONEDA.Name = "CMONEDA"
        Me.CMONEDA.ReadOnly = True
        Me.CMONEDA.Visible = False
        Me.CMONEDA.Width = 79
        '
        'CPAIORI
        '
        Me.CPAIORI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPAIORI.DataPropertyName = "CPAIORI"
        Me.CPAIORI.HeaderText = "País Origen"
        Me.CPAIORI.Name = "CPAIORI"
        Me.CPAIORI.ReadOnly = True
        Me.CPAIORI.Visible = False
        Me.CPAIORI.Width = 88
        '
        'SPROV
        '
        Me.SPROV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SPROV.DataPropertyName = "SPROV"
        Me.SPROV.HeaderText = "Proveedor"
        Me.SPROV.Name = "SPROV"
        Me.SPROV.ReadOnly = True
        '
        'DFECCRE
        '
        Me.DFECCRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DFECCRE.DataPropertyName = "DFECCRE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DFECCRE.DefaultCellStyle = DataGridViewCellStyle3
        Me.DFECCRE.HeaderText = "F. Creación"
        Me.DFECCRE.Name = "DFECCRE"
        Me.DFECCRE.ReadOnly = True
        Me.DFECCRE.Width = 86
        '
        'DFECACT
        '
        Me.DFECACT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DFECACT.DataPropertyName = "DFECACT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DFECACT.DefaultCellStyle = DataGridViewCellStyle4
        Me.DFECACT.HeaderText = "F. Actualización"
        Me.DFECACT.Name = "DFECACT"
        Me.DFECACT.ReadOnly = True
        Me.DFECACT.Width = 107
        '
        'SARECOM
        '
        Me.SARECOM.DataPropertyName = "SARECOM"
        Me.SARECOM.HeaderText = "SARECOM"
        Me.SARECOM.Name = "SARECOM"
        Me.SARECOM.ReadOnly = True
        Me.SARECOM.Visible = False
        '
        'CURG
        '
        Me.CURG.DataPropertyName = "CURG"
        Me.CURG.HeaderText = "CURG"
        Me.CURG.Name = "CURG"
        Me.CURG.ReadOnly = True
        Me.CURG.Visible = False
        '
        'btnExist
        '
        Me.btnExist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.btnExist.HeaderText = ""
        Me.btnExist.Image = CType(resources.GetObject("btnExist.Image"), System.Drawing.Image)
        Me.btnExist.Name = "btnExist"
        Me.btnExist.Width = 7
        '
        'frmListaOC_MIQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 625)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaOC_MIQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Importar"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.kdgvOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents kdgvOC As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOC As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents rbOC As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbFechaOC As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SNROOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEMIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINCOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPAIORI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SPROV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DFECCRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DFECACT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SARECOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExist As System.Windows.Forms.DataGridViewImageColumn
End Class
