<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarClienteContrato
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.dtgRelacionCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CCLNT_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPCL_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRUC_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMTVBJ_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.dtgRelacionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(793, 284)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 27)
        Me.KryptonGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtgRelacionCliente)
        Me.KryptonGroup1.Size = New System.Drawing.Size(793, 257)
        Me.KryptonGroup1.TabIndex = 56
        '
        'dtgRelacionCliente
        '
        Me.dtgRelacionCliente.AllowUserToAddRows = False
        Me.dtgRelacionCliente.AllowUserToDeleteRows = False
        Me.dtgRelacionCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRelacionCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chk, Me.CCLNT_R, Me.TCMPCL_R, Me.NRUC_R, Me.TMTVBJ_R, Me.Fill})
        Me.dtgRelacionCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgRelacionCliente.Location = New System.Drawing.Point(0, 0)
        Me.dtgRelacionCliente.Margin = New System.Windows.Forms.Padding(0)
        Me.dtgRelacionCliente.Name = "dtgRelacionCliente"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgRelacionCliente.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgRelacionCliente.Size = New System.Drawing.Size(791, 255)
        Me.dtgRelacionCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgRelacionCliente.TabIndex = 5
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.tsbGrabar, Me.ToolStripSeparator2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(793, 27)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 24)
        Me.ToolStripLabel1.Tag = ""
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(62, 24)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(78, 24)
        Me.tsbGrabar.Text = "&Grabar"
        Me.tsbGrabar.ToolTipText = "Grabar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Chk
        '
        Me.Chk.Frozen = True
        Me.Chk.HeaderText = "Chk"
        Me.Chk.Name = "Chk"
        Me.Chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chk.Width = 40
        '
        'CCLNT_R
        '
        Me.CCLNT_R.DataPropertyName = "CCLNT"
        Me.CCLNT_R.HeaderText = "Código"
        Me.CCLNT_R.Name = "CCLNT_R"
        Me.CCLNT_R.ReadOnly = True
        '
        'TCMPCL_R
        '
        Me.TCMPCL_R.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TCMPCL_R.DataPropertyName = "TCMPCL"
        Me.TCMPCL_R.HeaderText = "Nombre Cliente"
        Me.TCMPCL_R.Name = "TCMPCL_R"
        Me.TCMPCL_R.ReadOnly = True
        Me.TCMPCL_R.Width = 300
        '
        'NRUC_R
        '
        Me.NRUC_R.DataPropertyName = "NRUC"
        Me.NRUC_R.HeaderText = "Nro. RUC"
        Me.NRUC_R.Name = "NRUC_R"
        Me.NRUC_R.ReadOnly = True
        '
        'TMTVBJ_R
        '
        Me.TMTVBJ_R.DataPropertyName = "TMTVBJ"
        Me.TMTVBJ_R.HeaderText = "Descripción"
        Me.TMTVBJ_R.Name = "TMTVBJ_R"
        Me.TMTVBJ_R.ReadOnly = True
        Me.TMTVBJ_R.Visible = False
        '
        'Fill
        '
        Me.Fill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fill.HeaderText = ""
        Me.Fill.Name = "Fill"
        Me.Fill.ReadOnly = True
        '
        'frmAgregarClienteContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 284)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAgregarClienteContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cliente Contrato"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.dtgRelacionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dtgRelacionCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Chk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CCLNT_R As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL_R As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUC_R As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMTVBJ_R As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fill As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
