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
    Me.TNMBAR = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.URLARC = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.IMGS = New System.Windows.Forms.DataGridViewImageColumn
    Me.tsAdjuntarDocumentos = New System.Windows.Forms.ToolStrip
    Me.btnAnularDoc = New System.Windows.Forms.ToolStripButton
    Me.btnAdjuntarGuia = New System.Windows.Forms.ToolStripButton
    Me.tssVistaPrevia = New System.Windows.Forms.ToolStripSeparator
    Me.tslblDetalleTitulo = New System.Windows.Forms.ToolStripLabel
    Me.TabPagImages = New System.Windows.Forms.TabPage
    Me.dtgImagenes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.TOBSMD = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn
    Me.URLARC_I = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TNMBAR_I = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.tsImages = New System.Windows.Forms.ToolStrip
    Me.btnAnularImg = New System.Windows.Forms.ToolStripButton
    Me.tsbAdjuntarImages = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    Me.TabDocumentos.SuspendLayout()
    Me.TabPagDoc.SuspendLayout()
    CType(Me.dtgDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tsAdjuntarDocumentos.SuspendLayout()
    Me.TabPagImages.SuspendLayout()
    CType(Me.dtgImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tsImages.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.TabDocumentos)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(501, 312)
    Me.KryptonPanel.TabIndex = 0
    '
    'TabDocumentos
    '
    Me.TabDocumentos.Controls.Add(Me.TabPagImages)
    Me.TabDocumentos.Controls.Add(Me.TabPagDoc)
    Me.TabDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabDocumentos.Location = New System.Drawing.Point(0, 0)
    Me.TabDocumentos.Name = "TabDocumentos"
    Me.TabDocumentos.SelectedIndex = 0
    Me.TabDocumentos.Size = New System.Drawing.Size(501, 312)
    Me.TabDocumentos.TabIndex = 0
    '
    'TabPagDoc
    '
    Me.TabPagDoc.Controls.Add(Me.dtgDocumentos)
    Me.TabPagDoc.Controls.Add(Me.tsAdjuntarDocumentos)
    Me.TabPagDoc.Location = New System.Drawing.Point(4, 22)
    Me.TabPagDoc.Name = "TabPagDoc"
    Me.TabPagDoc.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPagDoc.Size = New System.Drawing.Size(493, 286)
    Me.TabPagDoc.TabIndex = 0
    Me.TabPagDoc.Text = "Documentos"
    Me.TabPagDoc.UseVisualStyleBackColor = True
    '
    'dtgDocumentos
    '
    Me.dtgDocumentos.AllowUserToAddRows = False
    Me.dtgDocumentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dtgDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dtgDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOBS, Me.TNMBAR, Me.URLARC, Me.IMGS})
    Me.dtgDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgDocumentos.Location = New System.Drawing.Point(3, 28)
    Me.dtgDocumentos.Name = "dtgDocumentos"
    Me.dtgDocumentos.RowHeadersWidth = 10
    Me.dtgDocumentos.Size = New System.Drawing.Size(487, 255)
    Me.dtgDocumentos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgDocumentos.TabIndex = 1
    '
    'TOBS
    '
    Me.TOBS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TOBS.DataPropertyName = "TOBSMD"
    Me.TOBS.HeaderText = "Observaciones"
    Me.TOBS.MinimumWidth = 20
    Me.TOBS.Name = "TOBS"
    Me.TOBS.ReadOnly = True
    '
    'TNMBAR
    '
    Me.TNMBAR.DataPropertyName = "TNMBAR"
    Me.TNMBAR.HeaderText = "TNMBAR"
    Me.TNMBAR.Name = "TNMBAR"
    Me.TNMBAR.Visible = False
    '
    'URLARC
    '
    Me.URLARC.DataPropertyName = "URLARC"
    Me.URLARC.HeaderText = "URLARC"
    Me.URLARC.Name = "URLARC"
    Me.URLARC.Visible = False
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
    'tsAdjuntarDocumentos
    '
    Me.tsAdjuntarDocumentos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsAdjuntarDocumentos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsAdjuntarDocumentos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAnularDoc, Me.btnAdjuntarGuia, Me.tssVistaPrevia, Me.tslblDetalleTitulo})
    Me.tsAdjuntarDocumentos.Location = New System.Drawing.Point(3, 3)
    Me.tsAdjuntarDocumentos.Name = "tsAdjuntarDocumentos"
    Me.tsAdjuntarDocumentos.Size = New System.Drawing.Size(487, 25)
    Me.tsAdjuntarDocumentos.TabIndex = 76
    '
    'btnAnularDoc
    '
    Me.btnAnularDoc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAnularDoc.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnAnularDoc.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAnularDoc.Name = "btnAnularDoc"
    Me.btnAnularDoc.Size = New System.Drawing.Size(61, 22)
    Me.btnAnularDoc.Text = "Anular"
    '
    'btnAdjuntarGuia
    '
    Me.btnAdjuntarGuia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAdjuntarGuia.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.btnAdjuntarGuia.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAdjuntarGuia.Name = "btnAdjuntarGuia"
    Me.btnAdjuntarGuia.Size = New System.Drawing.Size(140, 22)
    Me.btnAdjuntarGuia.Text = "Adjuntar Documentos"
    '
    'tssVistaPrevia
    '
    Me.tssVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.tssVistaPrevia.Name = "tssVistaPrevia"
    Me.tssVistaPrevia.Size = New System.Drawing.Size(6, 25)
    Me.tssVistaPrevia.Visible = False
    '
    'tslblDetalleTitulo
    '
    Me.tslblDetalleTitulo.Name = "tslblDetalleTitulo"
    Me.tslblDetalleTitulo.Size = New System.Drawing.Size(74, 22)
    Me.tslblDetalleTitulo.Text = "Transportista"
    '
    'TabPagImages
    '
    Me.TabPagImages.Controls.Add(Me.dtgImagenes)
    Me.TabPagImages.Controls.Add(Me.tsImages)
    Me.TabPagImages.Location = New System.Drawing.Point(4, 22)
    Me.TabPagImages.Name = "TabPagImages"
    Me.TabPagImages.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPagImages.Size = New System.Drawing.Size(493, 286)
    Me.TabPagImages.TabIndex = 1
    Me.TabPagImages.Text = "Imagenes"
    Me.TabPagImages.UseVisualStyleBackColor = True
    '
    'dtgImagenes
    '
    Me.dtgImagenes.AllowUserToAddRows = False
    Me.dtgImagenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
    Me.dtgImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dtgImagenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TOBSMD, Me.Column4, Me.URLARC_I, Me.TNMBAR_I})
    Me.dtgImagenes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgImagenes.Location = New System.Drawing.Point(3, 28)
    Me.dtgImagenes.Name = "dtgImagenes"
    Me.dtgImagenes.RowHeadersWidth = 10
    Me.dtgImagenes.Size = New System.Drawing.Size(487, 255)
    Me.dtgImagenes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgImagenes.TabIndex = 0
    '
    'TOBSMD
    '
    Me.TOBSMD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TOBSMD.DataPropertyName = "TOBSMD"
    Me.TOBSMD.HeaderText = "Observaciones"
    Me.TOBSMD.MinimumWidth = 40
    Me.TOBSMD.Name = "TOBSMD"
    Me.TOBSMD.ReadOnly = True
    '
    'Column4
    '
    Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
    Me.Column4.DataPropertyName = "IMG"
    Me.Column4.HeaderText = "Imagen"
    Me.Column4.MinimumWidth = 40
    Me.Column4.Name = "Column4"
    Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.Column4.Width = 74
    '
    'URLARC_I
    '
    Me.URLARC_I.DataPropertyName = "URLARC"
    Me.URLARC_I.HeaderText = "URLARC_I"
    Me.URLARC_I.Name = "URLARC_I"
    Me.URLARC_I.Visible = False
    '
    'TNMBAR_I
    '
    Me.TNMBAR_I.DataPropertyName = "TNMBAR"
    Me.TNMBAR_I.HeaderText = "TNMBAR_I"
    Me.TNMBAR_I.Name = "TNMBAR_I"
    Me.TNMBAR_I.Visible = False
    '
    'tsImages
    '
    Me.tsImages.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.tsImages.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.tsImages.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAnularImg, Me.tsbAdjuntarImages, Me.ToolStripSeparator2, Me.ToolStripLabel2})
    Me.tsImages.Location = New System.Drawing.Point(3, 3)
    Me.tsImages.Name = "tsImages"
    Me.tsImages.Size = New System.Drawing.Size(487, 25)
    Me.tsImages.TabIndex = 77
    '
    'btnAnularImg
    '
    Me.btnAnularImg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnAnularImg.Image = Global.SOLMIN_ST.My.Resources.Resources.button_cancel
    Me.btnAnularImg.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAnularImg.Name = "btnAnularImg"
    Me.btnAnularImg.Size = New System.Drawing.Size(61, 22)
    Me.btnAnularImg.Text = "Anular"
    '
    'tsbAdjuntarImages
    '
    Me.tsbAdjuntarImages.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.tsbAdjuntarImages.Image = Global.SOLMIN_ST.My.Resources.Resources.db_add
    Me.tsbAdjuntarImages.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tsbAdjuntarImages.Name = "tsbAdjuntarImages"
    Me.tsbAdjuntarImages.Size = New System.Drawing.Size(124, 22)
    Me.tsbAdjuntarImages.Text = "Adjuntar Imagenes"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    Me.ToolStripSeparator2.Visible = False
    '
    'ToolStripLabel2
    '
    Me.ToolStripLabel2.Name = "ToolStripLabel2"
    Me.ToolStripLabel2.Size = New System.Drawing.Size(74, 22)
    Me.ToolStripLabel2.Text = "Transportista"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTOBSMD"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Observaciones"
    Me.DataGridViewTextBoxColumn1.MinimumWidth = 20
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSTOBSMD"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Observaciones"
    Me.DataGridViewTextBoxColumn2.MinimumWidth = 40
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Visible = False
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "URLARC"
    Me.DataGridViewTextBoxColumn3.HeaderText = "URLARC"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.Visible = False
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSTOBSMD"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Observaciones"
    Me.DataGridViewTextBoxColumn4.MinimumWidth = 40
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "URLARC"
    Me.DataGridViewTextBoxColumn5.HeaderText = "URLARC_I"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.Visible = False
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "TNMBAR"
    Me.DataGridViewTextBoxColumn6.HeaderText = "TNMBAR_I"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.Visible = False
    '
    'frmAdjuntarDocumento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(501, 312)
    Me.Controls.Add(Me.KryptonPanel)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAdjuntarDocumento"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Adjuntar Documentos"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.TabDocumentos.ResumeLayout(False)
    Me.TabPagDoc.ResumeLayout(False)
    Me.TabPagDoc.PerformLayout()
    CType(Me.dtgDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tsAdjuntarDocumentos.ResumeLayout(False)
    Me.tsAdjuntarDocumentos.PerformLayout()
    Me.TabPagImages.ResumeLayout(False)
    Me.TabPagImages.PerformLayout()
    CType(Me.dtgImagenes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tsImages.ResumeLayout(False)
    Me.tsImages.PerformLayout()
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
    Private WithEvents tsAdjuntarDocumentos As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdjuntarGuia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssVistaPrevia As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblDetalleTitulo As System.Windows.Forms.ToolStripLabel
    Private WithEvents tsImages As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAdjuntarImages As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOBS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents URLARC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMGS As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TOBSMD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents URLARC_I As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TNMBAR_I As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAnularDoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnularImg As System.Windows.Forms.ToolStripButton
End Class
