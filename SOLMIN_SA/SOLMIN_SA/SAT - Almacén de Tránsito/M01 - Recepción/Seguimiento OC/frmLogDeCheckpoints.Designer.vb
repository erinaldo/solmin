<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogDeCheckpoints
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
        Me.dtgCheckpointCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorSalir = New System.Windows.Forms.ToolStripSeparator
        Me.txtCheckoints = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.NESTDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DFECEST = New Ransa.Utilitario.CalendarViewColumn
        Me.DFECREA = New Ransa.Utilitario.CalendarViewColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgCheckpointCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgCheckpointCliente)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(577, 260)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgCheckpointCliente
        '
        Me.dtgCheckpointCliente.AllowUserToAddRows = False
        Me.dtgCheckpointCliente.AllowUserToDeleteRows = False
        Me.dtgCheckpointCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCheckpointCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NESTDO, Me.DFECEST, Me.DFECREA, Me.TOBS})
        Me.dtgCheckpointCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCheckpointCliente.Location = New System.Drawing.Point(0, 25)
        Me.dtgCheckpointCliente.Name = "dtgCheckpointCliente"
        Me.dtgCheckpointCliente.ReadOnly = True
        Me.dtgCheckpointCliente.RowHeadersWidth = 25
        Me.dtgCheckpointCliente.Size = New System.Drawing.Size(577, 235)
        Me.dtgCheckpointCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgCheckpointCliente.TabIndex = 2
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.tssSeparadorSalir, Me.txtCheckoints})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(577, 25)
        Me.tsMenuOpciones.TabIndex = 46
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
        Me.tsbSalir.Image = Global.SOLMIN_SA.My.Resources.Resources._exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'tssSeparadorSalir
        '
        Me.tssSeparadorSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorSalir.Name = "tssSeparadorSalir"
        Me.tssSeparadorSalir.Size = New System.Drawing.Size(6, 25)
        '
        'txtCheckoints
        '
        Me.txtCheckoints.Name = "txtCheckoints"
        Me.txtCheckoints.Size = New System.Drawing.Size(10, 22)
        Me.txtCheckoints.Text = " "
        '
        'NESTDO
        '
        Me.NESTDO.DataPropertyName = "PNNESTDO"
        Me.NESTDO.HeaderText = "CODIGO"
        Me.NESTDO.Name = "NESTDO"
        Me.NESTDO.ReadOnly = True
        Me.NESTDO.Visible = False
        '
        'DFECEST
        '
        Me.DFECEST.DataPropertyName = "PSFECESTIMADA"
        Me.DFECEST.HeaderText = "Fecha Estimada"
        Me.DFECEST.Name = "DFECEST"
        Me.DFECEST.ReadOnly = True
        Me.DFECEST.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DFECEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DFECREA
        '
        Me.DFECREA.DataPropertyName = "PSFECREAL"
        Me.DFECREA.HeaderText = "Fecha Real"
        Me.DFECREA.Name = "DFECREA"
        Me.DFECREA.ReadOnly = True
        Me.DFECREA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DFECREA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DFECREA.Visible = False
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBS.DataPropertyName = "PSTOBEST"
        Me.TOBS.HeaderText = "Observaciones"
        Me.TOBS.MaxInputLength = 250
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        '
        'frmLogDeCheckpoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 260)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogDeCheckpoints"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incidencias Checkpoint"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgCheckpointCliente, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtgCheckpointCliente As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparadorSalir As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtCheckoints As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NESTDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DFECEST As Ransa.Utilitario.CalendarViewColumn
    Friend WithEvents DFECREA As Ransa.Utilitario.CalendarViewColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
