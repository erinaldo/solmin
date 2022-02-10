<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjuntarDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjuntarDocumento))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabDocumentos = New System.Windows.Forms.TabControl
        Me.TabPagDoc = New System.Windows.Forms.TabPage
        Me.dtgDocumentos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.TOBS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMGS = New System.Windows.Forms.DataGridViewImageColumn
        Me.TabPagImages = New System.Windows.Forms.TabPage
        Me.dtgImagenes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.TOBSMD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMG = New System.Windows.Forms.DataGridViewImageColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnEliminarDocumento = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAdjuntarDocumento = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabDocumentos.SuspendLayout()
        Me.TabPagDoc.SuspendLayout()
        CType(Me.dtgDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagImages.SuspendLayout()
        CType(Me.dtgImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabDocumentos)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(505, 311)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabDocumentos
        '
        Me.TabDocumentos.Controls.Add(Me.TabPagDoc)
        Me.TabDocumentos.Controls.Add(Me.TabPagImages)
        Me.TabDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDocumentos.Location = New System.Drawing.Point(0, 25)
        Me.TabDocumentos.Name = "TabDocumentos"
        Me.TabDocumentos.SelectedIndex = 0
        Me.TabDocumentos.Size = New System.Drawing.Size(505, 286)
        Me.TabDocumentos.TabIndex = 0
        '
        'TabPagDoc
        '
        Me.TabPagDoc.Controls.Add(Me.dtgDocumentos)
        Me.TabPagDoc.Location = New System.Drawing.Point(4, 22)
        Me.TabPagDoc.Name = "TabPagDoc"
        Me.TabPagDoc.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagDoc.Size = New System.Drawing.Size(497, 260)
        Me.TabPagDoc.TabIndex = 0
        Me.TabPagDoc.Text = "Documentos"
        Me.TabPagDoc.UseVisualStyleBackColor = True
        '
        'dtgDocumentos
        '
        Me.dtgDocumentos.AllowUserToAddRows = False
        Me.dtgDocumentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOBS, Me.IMGS})
        Me.dtgDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgDocumentos.Location = New System.Drawing.Point(3, 3)
        Me.dtgDocumentos.Name = "dtgDocumentos"
        Me.dtgDocumentos.RowHeadersWidth = 10
        Me.dtgDocumentos.Size = New System.Drawing.Size(491, 254)
        Me.dtgDocumentos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgDocumentos.TabIndex = 1
        '
        'TOBS
        '
        Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBS.DataPropertyName = "PSTOBSMD"
        Me.TOBS.HeaderText = "Observaciones"
        Me.TOBS.MinimumWidth = 20
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ReadOnly = True
        '
        'IMGS
        '
        Me.IMGS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IMGS.HeaderText = "Imagen"
        Me.IMGS.Image = CType(resources.GetObject("IMGS.Image"), System.Drawing.Image)
        Me.IMGS.MinimumWidth = 20
        Me.IMGS.Name = "IMGS"
        Me.IMGS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IMGS.Width = 74
        '
        'TabPagImages
        '
        Me.TabPagImages.Controls.Add(Me.dtgImagenes)
        Me.TabPagImages.Location = New System.Drawing.Point(4, 22)
        Me.TabPagImages.Name = "TabPagImages"
        Me.TabPagImages.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagImages.Size = New System.Drawing.Size(497, 260)
        Me.TabPagImages.TabIndex = 1
        Me.TabPagImages.Text = "Imagenes"
        Me.TabPagImages.UseVisualStyleBackColor = True
        '
        'dtgImagenes
        '
        Me.dtgImagenes.AllowUserToAddRows = False
        Me.dtgImagenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgImagenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOBSMD, Me.IMG})
        Me.dtgImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgImagenes.Location = New System.Drawing.Point(3, 3)
        Me.dtgImagenes.Name = "dtgImagenes"
        Me.dtgImagenes.RowHeadersWidth = 10
        Me.dtgImagenes.Size = New System.Drawing.Size(491, 254)
        Me.dtgImagenes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgImagenes.TabIndex = 0
        '
        'TOBSMD
        '
        Me.TOBSMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TOBSMD.DataPropertyName = "PSTOBSMD"
        Me.TOBSMD.HeaderText = "Observaciones"
        Me.TOBSMD.MinimumWidth = 40
        Me.TOBSMD.Name = "TOBSMD"
        Me.TOBSMD.ReadOnly = True
        '
        'IMG
        '
        Me.IMG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMG.DataPropertyName = "IMG"
        Me.IMG.HeaderText = "Imagen"
        Me.IMG.MinimumWidth = 40
        Me.IMG.Name = "IMG"
        Me.IMG.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IMG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IMG.Width = 74
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalir, Me.tss03, Me.btnEliminarDocumento, Me.ToolStripSeparator3, Me.btnAdjuntarDocumento, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(505, 25)
        Me.ToolStrip1.TabIndex = 77
        '
        'btnEliminarDocumento
        '
        Me.btnEliminarDocumento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarDocumento.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnEliminarDocumento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarDocumento.Name = "btnEliminarDocumento"
        Me.btnEliminarDocumento.Size = New System.Drawing.Size(71, 22)
        Me.btnEliminarDocumento.Text = "Eliminar "
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnAdjuntarDocumento
        '
        Me.btnAdjuntarDocumento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdjuntarDocumento.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.doc2
        Me.btnAdjuntarDocumento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjuntarDocumento.Name = "btnAdjuntarDocumento"
        Me.btnAdjuntarDocumento.Size = New System.Drawing.Size(140, 22)
        Me.btnAdjuntarDocumento.Text = "Adjuntar Documentos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        Me.ToolStripSeparator4.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTOBSMD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSTOBSMD"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'btnSalir
        '
        Me.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalir.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources._exit
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(49, 22)
        Me.btnSalir.Text = "Salir"
        '
        'tss03
        '
        Me.tss03.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 25)
        '
        'frmAdjuntarDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 311)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdjuntarDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjuntar Documentos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabDocumentos.ResumeLayout(False)
        Me.TabPagDoc.ResumeLayout(False)
        CType(Me.dtgDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagImages.ResumeLayout(False)
        CType(Me.dtgImagenes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabDocumentos As System.Windows.Forms.TabControl
    Friend WithEvents TabPagDoc As System.Windows.Forms.TabPage
    Friend WithEvents dtgDocumentos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents TabPagImages As System.Windows.Forms.TabPage
    Friend WithEvents dtgImagenes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMGS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TOBSMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMG As System.Windows.Forms.DataGridViewImageColumn
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEliminarDocumento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAdjuntarDocumento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
End Class
