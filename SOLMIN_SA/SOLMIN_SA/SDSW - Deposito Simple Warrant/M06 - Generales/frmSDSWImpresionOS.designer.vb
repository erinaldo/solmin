<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWImpresionOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWImpresionOS))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblcodcliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroOrdServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblNroGuiaSalida = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaVisualizar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dgvGuia = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.NORDSRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NGUIRN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FINGRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDPRDCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dstGuia = New System.Data.DataSet
        Me.dtGuia = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.hgVisorPrevia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.VisorReportesCrystal = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        CType(Me.dgvGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgVisorPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgVisorPrevia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgVisorPrevia.Panel.SuspendLayout()
        Me.hgVisorPrevia.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Controls.Add(Me.hgVisorPrevia)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(866, 622)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup2)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup3)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(866, 124)
        Me.KryptonSplitContainer1.SplitterDistance = 413
        Me.KryptonSplitContainer1.TabIndex = 1
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnActualizar)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblcodcliente)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtNroOrdServicio)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblNroGuiaSalida)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(413, 124)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 0
        Me.KryptonHeaderGroup2.Text = "Consulta"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Consulta"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(327, 17)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 68)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 48
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'lblcodcliente
        '
        Me.lblcodcliente.Location = New System.Drawing.Point(62, 22)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(16, 19)
        Me.lblcodcliente.TabIndex = 47
        Me.lblcodcliente.Text = "0"
        Me.lblcodcliente.Values.ExtraText = ""
        Me.lblcodcliente.Values.Image = Nothing
        Me.lblcodcliente.Values.Text = "0"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(6, 20)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel1.TabIndex = 43
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'txtNroOrdServicio
        '
        Me.txtNroOrdServicio.Location = New System.Drawing.Point(113, 51)
        Me.txtNroOrdServicio.Name = "txtNroOrdServicio"
        Me.txtNroOrdServicio.Size = New System.Drawing.Size(192, 21)
        Me.txtNroOrdServicio.TabIndex = 46
        '
        'lblNroGuiaSalida
        '
        Me.lblNroGuiaSalida.Location = New System.Drawing.Point(6, 51)
        Me.lblNroGuiaSalida.Name = "lblNroGuiaSalida"
        Me.lblNroGuiaSalida.Size = New System.Drawing.Size(45, 19)
        Me.lblNroGuiaSalida.TabIndex = 45
        Me.lblNroGuiaSalida.Text = "N° O/S"
        Me.lblNroGuiaSalida.Values.ExtraText = ""
        Me.lblNroGuiaSalida.Values.Image = Nothing
        Me.lblNroGuiaSalida.Values.Text = "N° O/S"
        '
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(113, 22)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(192, 21)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 44
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "AAA4BECF6E674984AAA4BECF6E674984"
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaVisualizar})
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dgvGuia)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(448, 124)
        Me.KryptonHeaderGroup3.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup3.TabIndex = 0
        Me.KryptonHeaderGroup3.Text = "Guia"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Guia"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'bsaVisualizar
        '
        Me.bsaVisualizar.ExtraText = ""
        Me.bsaVisualizar.Image = Nothing
        Me.bsaVisualizar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaVisualizar.Text = "Visualizar"
        Me.bsaVisualizar.ToolTipImage = Nothing
        Me.bsaVisualizar.UniqueName = "8F4C49C9221F46638F4C49C9221F4663"
        '
        'dgvGuia
        '
        Me.dgvGuia.AllowUserToAddRows = False
        Me.dgvGuia.AllowUserToDeleteRows = False
        Me.dgvGuia.AllowUserToResizeColumns = False
        Me.dgvGuia.AllowUserToResizeRows = False
        Me.dgvGuia.AutoGenerateColumns = False
        Me.dgvGuia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvGuia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NORDSRDataGridViewTextBoxColumn, Me.NGUIRN, Me.FINGRDataGridViewTextBoxColumn, Me.CDPRDCDataGridViewTextBoxColumn})
        Me.dgvGuia.DataMember = "dtGuia"
        Me.dgvGuia.DataSource = Me.dstGuia
        Me.dgvGuia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGuia.Location = New System.Drawing.Point(0, 0)
        Me.dgvGuia.MultiSelect = False
        Me.dgvGuia.Name = "dgvGuia"
        Me.dgvGuia.ReadOnly = True
        Me.dgvGuia.RowHeadersWidth = 20
        Me.dgvGuia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuia.Size = New System.Drawing.Size(446, 91)
        Me.dgvGuia.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgvGuia.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvGuia.TabIndex = 0
        '
        'NORDSRDataGridViewTextBoxColumn
        '
        Me.NORDSRDataGridViewTextBoxColumn.DataPropertyName = "NORDSR"
        Me.NORDSRDataGridViewTextBoxColumn.HeaderText = "N° Orden"
        Me.NORDSRDataGridViewTextBoxColumn.Name = "NORDSRDataGridViewTextBoxColumn"
        Me.NORDSRDataGridViewTextBoxColumn.ReadOnly = True
        Me.NORDSRDataGridViewTextBoxColumn.Width = 84
        '
        'NGUIRN
        '
        Me.NGUIRN.DataPropertyName = "NGUIRN"
        Me.NGUIRN.HeaderText = "N° Guia"
        Me.NGUIRN.Name = "NGUIRN"
        Me.NGUIRN.ReadOnly = True
        Me.NGUIRN.Width = 75
        '
        'FINGRDataGridViewTextBoxColumn
        '
        Me.FINGRDataGridViewTextBoxColumn.DataPropertyName = "FINGR"
        Me.FINGRDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FINGRDataGridViewTextBoxColumn.Name = "FINGRDataGridViewTextBoxColumn"
        Me.FINGRDataGridViewTextBoxColumn.ReadOnly = True
        Me.FINGRDataGridViewTextBoxColumn.Width = 66
        '
        'CDPRDCDataGridViewTextBoxColumn
        '
        Me.CDPRDCDataGridViewTextBoxColumn.DataPropertyName = "CDPRDC"
        Me.CDPRDCDataGridViewTextBoxColumn.HeaderText = "Cod Prod"
        Me.CDPRDCDataGridViewTextBoxColumn.Name = "CDPRDCDataGridViewTextBoxColumn"
        Me.CDPRDCDataGridViewTextBoxColumn.ReadOnly = True
        Me.CDPRDCDataGridViewTextBoxColumn.Width = 84
        '
        'dstGuia
        '
        Me.dstGuia.DataSetName = "dstGuia"
        Me.dstGuia.Tables.AddRange(New System.Data.DataTable() {Me.dtGuia})
        '
        'dtGuia
        '
        Me.dtGuia.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.dtGuia.TableName = "dtGuia"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "NORDSR"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "NGUIRN"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FINGR"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CDPRDC"
        '
        'hgVisorPrevia
        '
        Me.hgVisorPrevia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgVisorPrevia.Location = New System.Drawing.Point(0, 124)
        Me.hgVisorPrevia.Name = "hgVisorPrevia"
        '
        'hgVisorPrevia.Panel
        '
        Me.hgVisorPrevia.Panel.Controls.Add(Me.pcxEspera)
        Me.hgVisorPrevia.Panel.Controls.Add(Me.VisorReportesCrystal)
        Me.hgVisorPrevia.Size = New System.Drawing.Size(866, 498)
        Me.hgVisorPrevia.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgVisorPrevia.TabIndex = 0
        Me.hgVisorPrevia.Text = "Visualizar"
        Me.hgVisorPrevia.ValuesPrimary.Description = ""
        Me.hgVisorPrevia.ValuesPrimary.Heading = "Visualizar"
        Me.hgVisorPrevia.ValuesPrimary.Image = CType(resources.GetObject("hgVisorPrevia.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgVisorPrevia.ValuesSecondary.Description = ""
        Me.hgVisorPrevia.ValuesSecondary.Heading = ""
        Me.hgVisorPrevia.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(381, 181)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 47
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'VisorReportesCrystal
        '
        Me.VisorReportesCrystal.ActiveViewIndex = -1
        Me.VisorReportesCrystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReportesCrystal.DisplayGroupTree = False
        Me.VisorReportesCrystal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorReportesCrystal.Location = New System.Drawing.Point(0, 0)
        Me.VisorReportesCrystal.Name = "VisorReportesCrystal"
        Me.VisorReportesCrystal.SelectionFormula = ""
        Me.VisorReportesCrystal.Size = New System.Drawing.Size(864, 466)
        Me.VisorReportesCrystal.TabIndex = 0
        Me.VisorReportesCrystal.ViewTimeSelectionFormula = ""
        Me.VisorReportesCrystal.Visible = False
        '
        'bgwGifAnimado
        '
        '
        'frmImpresionOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 622)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmImpresionOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion O/S"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        CType(Me.dgvGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgVisorPrevia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgVisorPrevia.Panel.ResumeLayout(False)
        Me.hgVisorPrevia.Panel.PerformLayout()
        CType(Me.hgVisorPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgVisorPrevia.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgVisorPrevia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dgvGuia As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents lblcodcliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOrdServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblNroGuiaSalida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents VisorReportesCrystal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dstGuia As System.Data.DataSet
    Friend WithEvents dtGuia As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents bsaVisualizar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents NORDSRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINGRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDPRDCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
