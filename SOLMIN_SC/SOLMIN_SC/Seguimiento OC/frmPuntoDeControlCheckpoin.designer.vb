Imports Ransa.Utilitario

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPuntoDeControlCheckpoin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPuntoDeControlCheckpoin))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgCheckpointCliente = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.tssSeparadorSalir = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton
        Me.tsseparadorEliminar = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tssSeparadorGrabar = New System.Windows.Forms.ToolStripSeparator
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalendarViewColumn1 = New Ransa.Utilitario.CalendarViewColumn
        Me.CalendarViewColumn2 = New Ransa.Utilitario.CalendarViewColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MESTDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NESTDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTDESES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DFECEST = New Ransa.Utilitario.CalendarViewColumn
        Me.DFECREA = New Ransa.Utilitario.CalendarViewColumn
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LOG = New System.Windows.Forms.DataGridViewImageColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgCheckpointCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgCheckpointCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 25)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(792, 281)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgCheckpointCliente
        '
        Me.dtgCheckpointCliente.AllowUserToAddRows = False
        Me.dtgCheckpointCliente.AllowUserToDeleteRows = False
        Me.dtgCheckpointCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCheckpointCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MESTDO, Me.NESTDO, Me.PSTDESES, Me.DFECEST, Me.DFECREA, Me.TOBS, Me.LOG})
        Me.dtgCheckpointCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgCheckpointCliente.Location = New System.Drawing.Point(0, 0)
        Me.dtgCheckpointCliente.Name = "dtgCheckpointCliente"
        Me.dtgCheckpointCliente.RowHeadersWidth = 25
        Me.dtgCheckpointCliente.Size = New System.Drawing.Size(792, 281)
        Me.dtgCheckpointCliente.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgCheckpointCliente.TabIndex = 1
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbSalir, Me.tssSeparadorSalir, Me.tsbEliminar, Me.tsseparadorEliminar, Me.tsbGrabar, Me.ToolStripSeparator1, Me.tssSeparadorGrabar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(792, 25)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Checkponts"
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.SOLMIN_SC.My.Resources.Resources._exit
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
        'tsbEliminar
        '
        Me.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(68, 22)
        Me.tsbEliminar.Text = "&Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsseparadorEliminar
        '
        Me.tsseparadorEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsseparadorEliminar.Name = "tsseparadorEliminar"
        Me.tsseparadorEliminar.Size = New System.Drawing.Size(6, 25)
        Me.tsseparadorEliminar.Visible = False
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.SOLMIN_SC.My.Resources.Resources.filesave
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.tsbGrabar.Text = "&Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tssSeparadorGrabar
        '
        Me.tssSeparadorGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparadorGrabar.Name = "tssSeparadorGrabar"
        Me.tssSeparadorGrabar.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PNMESTDO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MESTDO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PNNESTDO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSTDESES"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'CalendarViewColumn1
        '
        Me.CalendarViewColumn1.DataPropertyName = "PSDFECEST"
        Me.CalendarViewColumn1.HeaderText = "Fecha Estimada"
        Me.CalendarViewColumn1.Name = "CalendarViewColumn1"
        Me.CalendarViewColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarViewColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CalendarViewColumn2
        '
        Me.CalendarViewColumn2.DataPropertyName = "PSDFECREA"
        Me.CalendarViewColumn2.HeaderText = "Fecha Real"
        Me.CalendarViewColumn2.Name = "CalendarViewColumn2"
        Me.CalendarViewColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CalendarViewColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSTOBS"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 250
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'MESTDO
        '
        Me.MESTDO.DataPropertyName = "PNMESTDO"
        Me.MESTDO.HeaderText = "MESTDO"
        Me.MESTDO.Name = "MESTDO"
        Me.MESTDO.Visible = False
        '
        'NESTDO
        '
        Me.NESTDO.DataPropertyName = "PNNESTDO"
        Me.NESTDO.HeaderText = "CODIGO"
        Me.NESTDO.Name = "NESTDO"
        Me.NESTDO.Visible = False
        '
        'PSTDESES
        '
        Me.PSTDESES.DataPropertyName = "PSTDESES"
        Me.PSTDESES.HeaderText = "Punto de Control"
        Me.PSTDESES.Name = "PSTDESES"
        Me.PSTDESES.ReadOnly = True
        Me.PSTDESES.Width = 300
        '
        'DFECEST
        '
        Me.DFECEST.DataPropertyName = "PSFECESTIMADA"
        Me.DFECEST.HeaderText = "Fecha Estimada"
        Me.DFECEST.Name = "DFECEST"
        Me.DFECEST.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DFECEST.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DFECREA
        '
        Me.DFECREA.DataPropertyName = "PSFECREAL"
        Me.DFECREA.HeaderText = "Fecha Real"
        Me.DFECREA.Name = "DFECREA"
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
        '
        'LOG
        '
        Me.LOG.HeaderText = "Log"
        Me.LOG.Image = Global.SOLMIN_SC.My.Resources.Resources.cell_layout
        Me.LOG.Name = "LOG"
        '
        'frmPuntoDeControlCheckpoin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 306)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 340)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 340)
        Me.Name = "frmPuntoDeControlCheckpoin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editar Seguimiento de Checkpoint "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.dtgCheckpointCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsseparadorEliminar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tssSeparadorGrabar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalendarViewColumn1 As Ransa.Utilitario.CalendarViewColumn
    Friend WithEvents CalendarViewColumn2 As Ransa.Utilitario.CalendarViewColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MESTDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NESTDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTDESES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DFECEST As Ransa.Utilitario.CalendarViewColumn
    Friend WithEvents DFECREA As Ransa.Utilitario.CalendarViewColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LOG As System.Windows.Forms.DataGridViewImageColumn
End Class
