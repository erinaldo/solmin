<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRASimple_FRASimple
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
        Me.kdgvRecepcionAS = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.PSTOPMOV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSFRLZSR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNNGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNCDPEPL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNGUICL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRFRPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNRFTPD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.ktbxFFin = New System.Windows.Forms.DateTimePicker
        Me.ktbxFIni = New System.Windows.Forms.DateTimePicker
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.ktbxGuiaIngreso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxBusquedaPor = New System.Windows.Forms.ComboBox
        Me.klblBusquedaPor = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbAceptar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.kdgvRecepcionAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.kdgvRecepcionAS)
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(939, 502)
        Me.KryptonPanel.TabIndex = 0
        '
        'kdgvRecepcionAS
        '
        Me.kdgvRecepcionAS.AllowUserToAddRows = False
        Me.kdgvRecepcionAS.AllowUserToDeleteRows = False
        Me.kdgvRecepcionAS.AllowUserToResizeColumns = False
        Me.kdgvRecepcionAS.AllowUserToResizeRows = False
        Me.kdgvRecepcionAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.kdgvRecepcionAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSTOPMOV, Me.PSFRLZSR, Me.PNNGUIRN, Me.PSNORCCL, Me.PNCDPEPL, Me.PSNGUICL, Me.PSNRFRPD, Me.PSNRFTPD})
        Me.kdgvRecepcionAS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.kdgvRecepcionAS.Location = New System.Drawing.Point(0, 110)
        Me.kdgvRecepcionAS.MultiSelect = False
        Me.kdgvRecepcionAS.Name = "kdgvRecepcionAS"
        Me.kdgvRecepcionAS.ReadOnly = True
        Me.kdgvRecepcionAS.RowHeadersWidth = 20
        Me.kdgvRecepcionAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.kdgvRecepcionAS.Size = New System.Drawing.Size(936, 379)
        Me.kdgvRecepcionAS.StandardTab = True
        Me.kdgvRecepcionAS.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kdgvRecepcionAS.TabIndex = 30
        '
        'PSTOPMOV
        '
        Me.PSTOPMOV.DataPropertyName = "PSTOPMOV"
        Me.PSTOPMOV.HeaderText = "Tipo Movimiento"
        Me.PSTOPMOV.MinimumWidth = 150
        Me.PSTOPMOV.Name = "PSTOPMOV"
        Me.PSTOPMOV.ReadOnly = True
        '
        'PSFRLZSR
        '
        Me.PSFRLZSR.DataPropertyName = "PSFRLZSR"
        Me.PSFRLZSR.HeaderText = "Fecha"
        Me.PSFRLZSR.MinimumWidth = 90
        Me.PSFRLZSR.Name = "PSFRLZSR"
        Me.PSFRLZSR.ReadOnly = True
        '
        'PNNGUIRN
        '
        Me.PNNGUIRN.DataPropertyName = "PNNGUIRN"
        Me.PNNGUIRN.HeaderText = "Guía Ransa"
        Me.PNNGUIRN.MinimumWidth = 110
        Me.PNNGUIRN.Name = "PNNGUIRN"
        Me.PNNGUIRN.ReadOnly = True
        '
        'PSNORCCL
        '
        Me.PSNORCCL.DataPropertyName = "PSNORCCL"
        Me.PSNORCCL.HeaderText = "Orden de Compra"
        Me.PSNORCCL.MinimumWidth = 140
        Me.PSNORCCL.Name = "PSNORCCL"
        Me.PSNORCCL.ReadOnly = True
        '
        'PNCDPEPL
        '
        Me.PNCDPEPL.DataPropertyName = "PNCDPEPL"
        Me.PNCDPEPL.HeaderText = "Pedido"
        Me.PNCDPEPL.MinimumWidth = 100
        Me.PNCDPEPL.Name = "PNCDPEPL"
        Me.PNCDPEPL.ReadOnly = True
        '
        'PSNGUICL
        '
        Me.PSNGUICL.DataPropertyName = "PSNGUICL"
        Me.PSNGUICL.HeaderText = "Guía Remisión"
        Me.PSNGUICL.MinimumWidth = 130
        Me.PSNGUICL.Name = "PSNGUICL"
        Me.PSNGUICL.ReadOnly = True
        '
        'PSNRFRPD
        '
        Me.PSNRFRPD.DataPropertyName = "PSNRFRPD"
        Me.PSNRFRPD.HeaderText = "Nro. Guía Cliente"
        Me.PSNRFRPD.MinimumWidth = 150
        Me.PSNRFRPD.Name = "PSNRFRPD"
        Me.PSNRFRPD.ReadOnly = True
        '
        'PSNRFTPD
        '
        Me.PSNRFTPD.DataPropertyName = "PSNRFTPD"
        Me.PSNRFTPD.HeaderText = "NRFTPD"
        Me.PSNRFTPD.MinimumWidth = 2
        Me.PSNRFTPD.Name = "PSNRFTPD"
        Me.PSNRFTPD.ReadOnly = True
        Me.PSNRFTPD.Visible = False
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.ktbxFFin)
        Me.KryptonPanel1.Controls.Add(Me.ktbxFIni)
        Me.KryptonPanel1.Controls.Add(Me.btnBuscar)
        Me.KryptonPanel1.Controls.Add(Me.ktbxGuiaIngreso)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.cbxBusquedaPor)
        Me.KryptonPanel1.Controls.Add(Me.klblBusquedaPor)
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(939, 85)
        Me.KryptonPanel1.TabIndex = 19
        '
        'ktbxFFin
        '
        Me.ktbxFFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ktbxFFin.Location = New System.Drawing.Point(249, 51)
        Me.ktbxFFin.Name = "ktbxFFin"
        Me.ktbxFFin.Size = New System.Drawing.Size(100, 20)
        Me.ktbxFFin.TabIndex = 7
        '
        'ktbxFIni
        '
        Me.ktbxFIni.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.ktbxFIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ktbxFIni.Location = New System.Drawing.Point(118, 51)
        Me.ktbxFIni.Name = "ktbxFIni"
        Me.ktbxFIni.Size = New System.Drawing.Size(100, 20)
        Me.ktbxFIni.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(588, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ktbxGuiaIngreso
        '
        Me.ktbxGuiaIngreso.Location = New System.Drawing.Point(394, 18)
        Me.ktbxGuiaIngreso.Name = "ktbxGuiaIngreso"
        Me.ktbxGuiaIngreso.Size = New System.Drawing.Size(159, 22)
        Me.ktbxGuiaIngreso.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(226, 51)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(17, 20)
        Me.KryptonLabel2.TabIndex = 5
        Me.KryptonLabel2.Text = "a"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "a"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(18, 51)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(78, 20)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Fecha Mov. :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha Mov. :"
        '
        'cbxBusquedaPor
        '
        Me.cbxBusquedaPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBusquedaPor.FormattingEnabled = True
        Me.cbxBusquedaPor.Location = New System.Drawing.Point(116, 18)
        Me.cbxBusquedaPor.Name = "cbxBusquedaPor"
        Me.cbxBusquedaPor.Size = New System.Drawing.Size(233, 21)
        Me.cbxBusquedaPor.TabIndex = 1
        '
        'klblBusquedaPor
        '
        Me.klblBusquedaPor.Location = New System.Drawing.Point(18, 18)
        Me.klblBusquedaPor.Name = "klblBusquedaPor"
        Me.klblBusquedaPor.Size = New System.Drawing.Size(92, 20)
        Me.klblBusquedaPor.TabIndex = 0
        Me.klblBusquedaPor.Text = "Búsqueda por :"
        Me.klblBusquedaPor.Values.ExtraText = ""
        Me.klblBusquedaPor.Values.Image = Nothing
        Me.klblBusquedaPor.Values.Text = "Búsqueda por :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCancelar, Me.ToolStripSeparator3, Me.tsbAceptar, Me.ToolStripSeparator1})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(939, 25)
        Me.tsMenuOpciones.TabIndex = 18
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(54, 22)
        Me.tsbCancelar.Text = "&Carcelar"
        Me.tsbCancelar.ToolTipText = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAceptar
        '
        Me.tsbAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAceptar.Name = "tsbAceptar"
        Me.tsbAceptar.Size = New System.Drawing.Size(52, 22)
        Me.tsbAceptar.Text = "&Aceptar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ucRASimple_FRASimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 502)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "ucRASimple_FRASimple"
        Me.Text = "Proceso :"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.kdgvRecepcionAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ktbxGuiaIngreso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxBusquedaPor As System.Windows.Forms.ComboBox
    Friend WithEvents klblBusquedaPor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kdgvRecepcionAS As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ktbxFIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents ktbxFFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents PSTOPMOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSFRLZSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNNGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNCDPEPL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNGUICL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRFRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNRFTPD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
