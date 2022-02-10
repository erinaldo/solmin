<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjusteCargaInicial
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
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.dgvExcel = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnProcesar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCargarExcel = New System.Windows.Forms.ToolStripButton
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1060, 499)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup2.Location = New System.Drawing.Point(0, 61)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.dgvExcel)
        Me.KryptonGroup2.Panel.Controls.Add(Me.ToolStrip1)
        Me.KryptonGroup2.Size = New System.Drawing.Size(1060, 438)
        Me.KryptonGroup2.TabIndex = 0
        '
        'dgvExcel
        '
        Me.dgvExcel.AllowUserToAddRows = False
        Me.dgvExcel.AllowUserToDeleteRows = False
        Me.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCMRCLR_NEW, Me.PSTMRCD2, Me.PNQTRMC, Me.PSCUNCN5_NEW, Me.PSCFMCLR, Me.PSTFMCLR, Me.PSCGRCLR, Me.PSTGRCLR, Me.PSCTPALM, Me.PSCALMC, Me.PSCZNALM, Me.Column10})
        Me.dgvExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExcel.Location = New System.Drawing.Point(0, 25)
        Me.dgvExcel.Name = "dgvExcel"
        Me.dgvExcel.ReadOnly = True
        Me.dgvExcel.Size = New System.Drawing.Size(1058, 411)
        Me.dgvExcel.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvExcel.TabIndex = 1
        '
        'PSCMRCLR_NEW
        '
        Me.PSCMRCLR_NEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCMRCLR_NEW.DataPropertyName = "PSCMRCLR_NEW"
        Me.PSCMRCLR_NEW.HeaderText = "MERCADERIA"
        Me.PSCMRCLR_NEW.Name = "PSCMRCLR_NEW"
        Me.PSCMRCLR_NEW.ReadOnly = True
        Me.PSCMRCLR_NEW.Width = 108
        '
        'PSTMRCD2
        '
        Me.PSTMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTMRCD2.DataPropertyName = "PSTMRCD2"
        Me.PSTMRCD2.HeaderText = "DESCRIPCION MERCADERIA"
        Me.PSTMRCD2.Name = "PSTMRCD2"
        Me.PSTMRCD2.ReadOnly = True
        Me.PSTMRCD2.Width = 169
        '
        'PNQTRMC
        '
        Me.PNQTRMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PNQTRMC.DataPropertyName = "PNQTRMC"
        Me.PNQTRMC.HeaderText = "CANTIDAD"
        Me.PNQTRMC.Name = "PNQTRMC"
        Me.PNQTRMC.ReadOnly = True
        Me.PNQTRMC.Width = 95
        '
        'PSCUNCN5_NEW
        '
        Me.PSCUNCN5_NEW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCUNCN5_NEW.DataPropertyName = "PSCUNCN5_NEW"
        Me.PSCUNCN5_NEW.HeaderText = "UNIDAD DE MEDIDA"
        Me.PSCUNCN5_NEW.Name = "PSCUNCN5_NEW"
        Me.PSCUNCN5_NEW.ReadOnly = True
        Me.PSCUNCN5_NEW.Width = 132
        '
        'PSCFMCLR
        '
        Me.PSCFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCFMCLR.DataPropertyName = "PSCFMCLR"
        Me.PSCFMCLR.HeaderText = "COD. FAMILIA"
        Me.PSCFMCLR.Name = "PSCFMCLR"
        Me.PSCFMCLR.ReadOnly = True
        Me.PSCFMCLR.Width = 103
        '
        'PSTFMCLR
        '
        Me.PSTFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTFMCLR.DataPropertyName = "PSTFMCLR"
        Me.PSTFMCLR.HeaderText = "FAMILIA"
        Me.PSTFMCLR.Name = "PSTFMCLR"
        Me.PSTFMCLR.ReadOnly = True
        Me.PSTFMCLR.Width = 81
        '
        'PSCGRCLR
        '
        Me.PSCGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCGRCLR.DataPropertyName = "PSCGRCLR"
        Me.PSCGRCLR.HeaderText = "COD. GRUPO"
        Me.PSCGRCLR.Name = "PSCGRCLR"
        Me.PSCGRCLR.ReadOnly = True
        Me.PSCGRCLR.Width = 98
        '
        'PSTGRCLR
        '
        Me.PSTGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSTGRCLR.DataPropertyName = "PSTGRCLR"
        Me.PSTGRCLR.HeaderText = "GRUPO"
        Me.PSTGRCLR.Name = "PSTGRCLR"
        Me.PSTGRCLR.ReadOnly = True
        Me.PSTGRCLR.Width = 75
        '
        'PSCTPALM
        '
        Me.PSCTPALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCTPALM.DataPropertyName = "PSCTPALM"
        Me.PSCTPALM.HeaderText = "TIPO ALMACEN"
        Me.PSCTPALM.Name = "PSCTPALM"
        Me.PSCTPALM.ReadOnly = True
        Me.PSCTPALM.Width = 111
        '
        'PSCALMC
        '
        Me.PSCALMC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCALMC.DataPropertyName = "PSCALMC"
        Me.PSCALMC.HeaderText = "ALMACEN"
        Me.PSCALMC.Name = "PSCALMC"
        Me.PSCALMC.ReadOnly = True
        Me.PSCALMC.Width = 92
        '
        'PSCZNALM
        '
        Me.PSCZNALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PSCZNALM.DataPropertyName = "PSCZNALM"
        Me.PSCZNALM.HeaderText = "ZONA"
        Me.PSCZNALM.Name = "PSCZNALM"
        Me.PSCZNALM.ReadOnly = True
        Me.PSCZNALM.Width = 69
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProcesar, Me.ToolStripSeparator1, Me.btnCargarExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1058, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCargarExcel
        '
        Me.btnCargarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCargarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnCargarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargarExcel.Name = "btnCargarExcel"
        Me.btnCargarExcel.Size = New System.Drawing.Size(91, 22)
        Me.btnCargarExcel.Text = "Cargar Excel"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1060, 61)
        Me.KryptonGroup1.TabIndex = 0
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(71, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(278, 22)
        Me.txtCliente.TabIndex = 7
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 21)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'frmAjusteCargaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 499)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmAjusteCargaInicial"
        Me.Text = "Ajuste Carga Inventario"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCargarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvExcel As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
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
