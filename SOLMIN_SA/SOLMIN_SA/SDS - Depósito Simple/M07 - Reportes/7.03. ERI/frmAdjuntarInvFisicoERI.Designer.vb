<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdjuntarInvFisicoERI
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdjuntarInvFisicoERI))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.kbAbrir = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.kbConsulta = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtRuta = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.txtNroDocEri = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbProcesar = New System.Windows.Forms.ToolStripButton
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dgDetInventario = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.PSCORRELA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PNQSFMC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.tsReporte.SuspendLayout()
        CType(Me.dgDetInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.kbAbrir)
        Me.khgFiltros.Panel.Controls.Add(Me.kbConsulta)
        Me.khgFiltros.Panel.Controls.Add(Me.txtRuta)
        Me.khgFiltros.Panel.Controls.Add(Me.txtNroDocEri)
        Me.khgFiltros.Panel.Controls.Add(Me.tsReporte)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(826, 125)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 60
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'kbAbrir
        '
        Me.kbAbrir.Enabled = False
        Me.kbAbrir.Location = New System.Drawing.Point(709, 38)
        Me.kbAbrir.Name = "kbAbrir"
        Me.kbAbrir.Size = New System.Drawing.Size(90, 25)
        Me.kbAbrir.TabIndex = 82
        Me.kbAbrir.Text = "Abrir"
        Me.kbAbrir.Values.ExtraText = ""
        Me.kbAbrir.Values.Image = Nothing
        Me.kbAbrir.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbAbrir.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbAbrir.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbAbrir.Values.Text = "Abrir"
        '
        'kbConsulta
        '
        Me.kbConsulta.Location = New System.Drawing.Point(613, 38)
        Me.kbConsulta.Name = "kbConsulta"
        Me.kbConsulta.Size = New System.Drawing.Size(90, 25)
        Me.kbConsulta.TabIndex = 81
        Me.kbConsulta.Text = "Consulta"
        Me.kbConsulta.Values.ExtraText = ""
        Me.kbConsulta.Values.Image = Nothing
        Me.kbConsulta.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.kbConsulta.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.kbConsulta.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.kbConsulta.Values.Text = "Consulta"
        '
        'txtRuta
        '
        Me.txtRuta.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtRuta.Enabled = False
        Me.txtRuta.HideSelection = False
        Me.txtRuta.Location = New System.Drawing.Point(150, 41)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtRuta.Size = New System.Drawing.Size(457, 22)
        Me.txtRuta.TabIndex = 80
        '
        'txtNroDocEri
        '
        Me.txtNroDocEri.Culture = New System.Globalization.CultureInfo("en-US")
        Me.txtNroDocEri.Enabled = False
        Me.txtNroDocEri.Location = New System.Drawing.Point(150, 13)
        Me.txtNroDocEri.Name = "txtNroDocEri"
        Me.txtNroDocEri.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtNroDocEri.Size = New System.Drawing.Size(198, 22)
        Me.txtNroDocEri.TabIndex = 79
        '
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbProcesar})
        Me.tsReporte.Location = New System.Drawing.Point(0, 69)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(824, 25)
        Me.tsReporte.TabIndex = 78
        '
        'tsbProcesar
        '
        Me.tsbProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbProcesar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbProcesar.Enabled = False
        Me.tsbProcesar.Image = CType(resources.GetObject("tsbProcesar.Image"), System.Drawing.Image)
        Me.tsbProcesar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProcesar.Name = "tsbProcesar"
        Me.tsbProcesar.Size = New System.Drawing.Size(56, 22)
        Me.tsbProcesar.Text = "Procesar"
        Me.tsbProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(67, 41)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel3.TabIndex = 74
        Me.KryptonLabel3.Text = "Archivo Xls : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Archivo Xls : "
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(56, 15)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(88, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Nro. Doc. ERI : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Nro. Doc. ERI : "
        '
        'dgDetInventario
        '
        Me.dgDetInventario.AllowUserToAddRows = False
        Me.dgDetInventario.AllowUserToDeleteRows = False
        Me.dgDetInventario.AllowUserToResizeColumns = False
        Me.dgDetInventario.AllowUserToResizeRows = False
        Me.dgDetInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDetInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PSCORRELA, Me.PSCMRCLR, Me.PSTMRCD2, Me.PNQSFMC, Me.PSCUNCN5})
        Me.dgDetInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDetInventario.Location = New System.Drawing.Point(0, 125)
        Me.dgDetInventario.MultiSelect = False
        Me.dgDetInventario.Name = "dgDetInventario"
        Me.dgDetInventario.ReadOnly = True
        Me.dgDetInventario.RowHeadersWidth = 20
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDetInventario.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDetInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetInventario.Size = New System.Drawing.Size(826, 362)
        Me.dgDetInventario.StandardTab = True
        Me.dgDetInventario.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgDetInventario.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgDetInventario.TabIndex = 72
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'PSCORRELA
        '
        Me.PSCORRELA.DataPropertyName = "PSCORRELA"
        Me.PSCORRELA.HeaderText = "Nro. Correlativo"
        Me.PSCORRELA.Name = "PSCORRELA"
        Me.PSCORRELA.ReadOnly = True
        Me.PSCORRELA.Width = 120
        '
        'PSCMRCLR
        '
        Me.PSCMRCLR.DataPropertyName = "PSCMRCLR"
        Me.PSCMRCLR.HeaderText = "Cod. Mercadería"
        Me.PSCMRCLR.Name = "PSCMRCLR"
        Me.PSCMRCLR.ReadOnly = True
        Me.PSCMRCLR.Width = 123
        '
        'PSTMRCD2
        '
        Me.PSTMRCD2.DataPropertyName = "PSTMRCD2"
        Me.PSTMRCD2.HeaderText = "Mercadería"
        Me.PSTMRCD2.Name = "PSTMRCD2"
        Me.PSTMRCD2.ReadOnly = True
        Me.PSTMRCD2.Width = 95
        '
        'PNQSFMC
        '
        Me.PNQSFMC.DataPropertyName = "PNQSFMC"
        DataGridViewCellStyle1.NullValue = "0.000"
        Me.PNQSFMC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNQSFMC.HeaderText = "Stock Fisico"
        Me.PNQSFMC.Name = "PNQSFMC"
        Me.PNQSFMC.ReadOnly = True
        Me.PNQSFMC.Width = 98
        '
        'PSCUNCN5
        '
        Me.PSCUNCN5.DataPropertyName = "PSCUNCN5"
        Me.PSCUNCN5.HeaderText = "Unidad Medida"
        Me.PSCUNCN5.Name = "PSCUNCN5"
        Me.PSCUNCN5.ReadOnly = True
        Me.PSCUNCN5.Width = 117
        '
        'frmAdjuntarInvFisicoERI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 487)
        Me.Controls.Add(Me.dgDetInventario)
        Me.Controls.Add(Me.khgFiltros)
        Me.Name = "frmAdjuntarInvFisicoERI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adjuntar inventario Fisico"
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.dgDetInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtNroDocEri As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbProcesar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtRuta As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents kbAbrir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents kbConsulta As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents dgDetInventario As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PSCORRELA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQSFMC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
