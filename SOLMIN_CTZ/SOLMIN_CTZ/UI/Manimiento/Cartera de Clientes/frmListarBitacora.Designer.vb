<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarBitacora
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NRITOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TFCOBS = New SOLMIN_CT.CalendarColumn
        Me.TOBS_B = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_04 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.mskDatFinContrato = New System.Windows.Forms.MaskedTextBox
        Me.mskDatIniContrato = New System.Windows.Forms.MaskedTextBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDatNumContrato = New System.Windows.Forms.TextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.dtgObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(597, 435)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.dtgObservaciones)
        Me.KryptonPanel1.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonGroup1)
        Me.KryptonPanel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(597, 435)
        Me.KryptonPanel1.TabIndex = 1
        '
        'dtgObservaciones
        '
        Me.dtgObservaciones.AllowUserToAddRows = False
        Me.dtgObservaciones.AllowUserToDeleteRows = False
        Me.dtgObservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgObservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgObservaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRITOC, Me.TFCOBS, Me.TOBS_B})
        Me.dtgObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgObservaciones.Location = New System.Drawing.Point(0, 120)
        Me.dtgObservaciones.Name = "dtgObservaciones"
        Me.dtgObservaciones.Size = New System.Drawing.Size(597, 315)
        Me.dtgObservaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgObservaciones.TabIndex = 1
        '
        'NRITOC
        '
        Me.NRITOC.DataPropertyName = "NRITOC"
        Me.NRITOC.HeaderText = "NRITOC"
        Me.NRITOC.Name = "NRITOC"
        Me.NRITOC.ReadOnly = True
        Me.NRITOC.Visible = False
        '
        'TFCOBS
        '
        Me.TFCOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TFCOBS.DataPropertyName = "TFCOBS"
        Me.TFCOBS.HeaderText = "Fecha"
        Me.TFCOBS.Name = "TFCOBS"
        Me.TFCOBS.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TFCOBS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TFCOBS.Width = 70
        '
        'TOBS_B
        '
        Me.TOBS_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBS_B.DataPropertyName = "TOBS"
        Me.TOBS_B.HeaderText = "Observaciones"
        Me.TOBS_B.Name = "TOBS_B"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminar, Me.tssSep_03, Me.btnGuardar, Me.tssSep_04, Me.btnAgregar, Me.tssSep_02})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 95)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(597, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
        Me.btnEliminar.Text = "&Eliminar"
        '
        'tssSep_03
        '
        Me.tssSep_03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_03.Name = "tssSep_03"
        Me.tssSep_03.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 22)
        Me.btnGuardar.Text = "&AGuardar"
        '
        'tssSep_04
        '
        Me.tssSep_04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_04.Name = "tssSep_04"
        Me.tssSep_04.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_CT.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(68, 22)
        Me.btnAgregar.Text = "&Agregar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.mskDatFinContrato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.mskDatIniContrato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDatNumContrato)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Size = New System.Drawing.Size(597, 70)
        Me.KryptonGroup1.TabIndex = 57
        '
        'mskDatFinContrato
        '
        Me.mskDatFinContrato.BackColor = System.Drawing.Color.White
        Me.mskDatFinContrato.Location = New System.Drawing.Point(498, 19)
        Me.mskDatFinContrato.Mask = "00/00/0000"
        Me.mskDatFinContrato.Name = "mskDatFinContrato"
        Me.mskDatFinContrato.ReadOnly = True
        Me.mskDatFinContrato.Size = New System.Drawing.Size(82, 20)
        Me.mskDatFinContrato.TabIndex = 3
        Me.mskDatFinContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskDatFinContrato.ValidatingType = GetType(Date)
        '
        'mskDatIniContrato
        '
        Me.mskDatIniContrato.BackColor = System.Drawing.Color.White
        Me.mskDatIniContrato.Location = New System.Drawing.Point(396, 19)
        Me.mskDatIniContrato.Mask = "00/00/0000"
        Me.mskDatIniContrato.Name = "mskDatIniContrato"
        Me.mskDatIniContrato.ReadOnly = True
        Me.mskDatIniContrato.Size = New System.Drawing.Size(82, 20)
        Me.mskDatIniContrato.TabIndex = 2
        Me.mskDatIniContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskDatIniContrato.ValidatingType = GetType(Date)
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(322, 19)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(58, 19)
        Me.KryptonLabel5.TabIndex = 1
        Me.KryptonLabel5.Text = "Vigencia :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Vigencia :"
        '
        'txtDatNumContrato
        '
        Me.txtDatNumContrato.BackColor = System.Drawing.Color.White
        Me.txtDatNumContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDatNumContrato.Location = New System.Drawing.Point(118, 19)
        Me.txtDatNumContrato.MaxLength = 15
        Me.txtDatNumContrato.Name = "txtDatNumContrato"
        Me.txtDatNumContrato.ReadOnly = True
        Me.txtDatNumContrato.Size = New System.Drawing.Size(184, 18)
        Me.txtDatNumContrato.TabIndex = 0
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(26, 19)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(76, 19)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "N° Contrato :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "N° Contrato :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.ToolStripSeparator2})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(597, 25)
        Me.tsMenuOpciones.TabIndex = 56
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 22)
        Me.ToolStripLabel1.Tag = ""
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_CT.My.Resources.Resources.salir
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmListarBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 435)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarBitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar de Bitacora"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.dtgObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents mskDatFinContrato As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDatIniContrato As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDatNumContrato As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents dtgObservaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents NRITOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFCOBS As SOLMIN_CT.CalendarColumn
    Friend WithEvents TOBS_B As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
