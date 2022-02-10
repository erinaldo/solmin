<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarCIExcel_PPC
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dgExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.hgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCerrarVentana = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnAbrirCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnExcelCabecera = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.TxtRutaXlsCabecera = New System.Windows.Forms.TextBox
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.Chk = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
        Me.PNCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORCML = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPPOSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTPIMSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNCTAMA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCCNCOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNELPEP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNORSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSNGFSAP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCTCST = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCTCSF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSTCTCSA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCCEBEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dgExcelCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgFiltros.Panel.SuspendLayout()
        Me.hgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dgExcelCabecera)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.hgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(947, 305)
        Me.KryptonPanel.TabIndex = 0
        '
        'dgExcelCabecera
        '
        Me.dgExcelCabecera.AllowUserToAddRows = False
        Me.dgExcelCabecera.AllowUserToDeleteRows = False
        Me.dgExcelCabecera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgExcelCabecera.ColumnHeadersHeight = 25
        Me.dgExcelCabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chk, Me.PNCCLNT, Me.PSNORCML, Me.PSTPPOSA, Me.PSTPIMSA, Me.PSNCTAMA, Me.PSCCNCOS, Me.PSNELPEP, Me.PSNORSAP, Me.PSNGFSAP, Me.PSTCTCST, Me.PSTCTCSF, Me.PSTCTCSA, Me.PSCCEBEN, Me.Column1})
        Me.dgExcelCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgExcelCabecera.Location = New System.Drawing.Point(0, 124)
        Me.dgExcelCabecera.Name = "dgExcelCabecera"
        Me.dgExcelCabecera.ReadOnly = True
        Me.dgExcelCabecera.RowHeadersWidth = 20
        Me.dgExcelCabecera.Size = New System.Drawing.Size(947, 181)
        Me.dgExcelCabecera.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgExcelCabecera.TabIndex = 32
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsbGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 99)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(947, 25)
        Me.tsMenuOpciones.TabIndex = 26
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripLabel1.Tag = "ORDENES DE COMPRA"
        Me.ToolStripLabel1.Text = "ORDENES DE COMPRA"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        Me.tsbGuardar.ToolTipText = "Guardar "
        '
        'hgFiltros
        '
        Me.hgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCerrarVentana})
        Me.hgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgFiltros.HeaderVisibleSecondary = False
        Me.hgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.hgFiltros.Name = "hgFiltros"
        '
        'hgFiltros.Panel
        '
        Me.hgFiltros.Panel.Controls.Add(Me.btnAbrirCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.btnExcelCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.TxtRutaXlsCabecera)
        Me.hgFiltros.Panel.Controls.Add(Me.lblTipoAlmacen)
        Me.hgFiltros.Size = New System.Drawing.Size(947, 99)
        Me.hgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgFiltros.TabIndex = 3
        Me.hgFiltros.Text = "Filtros"
        Me.hgFiltros.ValuesPrimary.Description = ""
        Me.hgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.hgFiltros.ValuesPrimary.Image = Nothing
        Me.hgFiltros.ValuesSecondary.Description = ""
        Me.hgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.hgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaCerrarVentana
        '
        Me.bsaCerrarVentana.ExtraText = ""
        Me.bsaCerrarVentana.Image = Nothing
        Me.bsaCerrarVentana.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrarVentana.Text = "Cerrar"
        Me.bsaCerrarVentana.ToolTipImage = Nothing
        Me.bsaCerrarVentana.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrarVentana.UniqueName = "EC0877FED5AD46CBEC0877FED5AD46CB"
        '
        'btnAbrirCabecera
        '
        Me.btnAbrirCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirCabecera.Location = New System.Drawing.Point(864, 12)
        Me.btnAbrirCabecera.Name = "btnAbrirCabecera"
        Me.btnAbrirCabecera.Size = New System.Drawing.Size(74, 44)
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnAbrirCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnAbrirCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnAbrirCabecera.TabIndex = 48
        Me.btnAbrirCabecera.Text = "&Abrir"
        Me.btnAbrirCabecera.Values.ExtraText = "Consulta"
        Me.btnAbrirCabecera.Values.Image = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAbrirCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAbrirCabecera.Values.Text = "&Abrir"
        '
        'btnExcelCabecera
        '
        Me.btnExcelCabecera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcelCabecera.Location = New System.Drawing.Point(762, 12)
        Me.btnExcelCabecera.Name = "btnExcelCabecera"
        Me.btnExcelCabecera.Size = New System.Drawing.Size(81, 44)
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnExcelCabecera.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnExcelCabecera.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnExcelCabecera.TabIndex = 46
        Me.btnExcelCabecera.Text = "&Cargar"
        Me.btnExcelCabecera.Values.ExtraText = "Consulta"
        Me.btnExcelCabecera.Values.Image = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExcelCabecera.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExcelCabecera.Values.Text = "&Cargar"
        '
        'TxtRutaXlsCabecera
        '
        Me.TxtRutaXlsCabecera.Location = New System.Drawing.Point(74, 25)
        Me.TxtRutaXlsCabecera.Name = "TxtRutaXlsCabecera"
        Me.TxtRutaXlsCabecera.Size = New System.Drawing.Size(650, 20)
        Me.TxtRutaXlsCabecera.TabIndex = 44
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(11, 25)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(67, 20)
        Me.lblTipoAlmacen.TabIndex = 42
        Me.lblTipoAlmacen.Text = "Cabecera : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Cabecera : "
        '
        'Chk
        '
        Me.Chk.DataPropertyName = "CHK"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        Me.Chk.DefaultCellStyle = DataGridViewCellStyle2
        Me.Chk.FalseValue = Nothing
        Me.Chk.HeaderText = "Chk"
        Me.Chk.IndeterminateValue = Nothing
        Me.Chk.Name = "Chk"
        Me.Chk.ReadOnly = True
        Me.Chk.TrueValue = Nothing
        Me.Chk.Visible = False
        '
        'PNCCLNT
        '
        Me.PNCCLNT.DataPropertyName = "PNCCLNT"
        Me.PNCCLNT.HeaderText = "CodigoCliente"
        Me.PNCCLNT.Name = "PNCCLNT"
        Me.PNCCLNT.ReadOnly = True
        Me.PNCCLNT.Visible = False
        '
        'PSNORCML
        '
        Me.PSNORCML.DataPropertyName = "PSNORCML"
        Me.PSNORCML.HeaderText = "Nr. Orden Compra"
        Me.PSNORCML.Name = "PSNORCML"
        Me.PSNORCML.ReadOnly = True
        Me.PSNORCML.Width = 134
        '
        'PSTPPOSA
        '
        Me.PSTPPOSA.DataPropertyName = "PSTPPOSA"
        Me.PSTPPOSA.HeaderText = "Tipo Posición"
        Me.PSTPPOSA.Name = "PSTPPOSA"
        Me.PSTPPOSA.ReadOnly = True
        Me.PSTPPOSA.Width = 108
        '
        'PSTPIMSA
        '
        Me.PSTPIMSA.DataPropertyName = "PSTPIMSA"
        Me.PSTPIMSA.HeaderText = "Tipo CI"
        Me.PSTPIMSA.Name = "PSTPIMSA"
        Me.PSTPIMSA.ReadOnly = True
        Me.PSTPIMSA.Width = 74
        '
        'PSNCTAMA
        '
        Me.PSNCTAMA.DataPropertyName = "PSNCTAMA"
        Me.PSNCTAMA.HeaderText = "Nro. Cuenta Mayor"
        Me.PSNCTAMA.Name = "PSNCTAMA"
        Me.PSNCTAMA.ReadOnly = True
        Me.PSNCTAMA.Width = 137
        '
        'PSCCNCOS
        '
        Me.PSCCNCOS.DataPropertyName = "PSCCNCOS"
        Me.PSCCNCOS.HeaderText = "Código CeCo SAP"
        Me.PSCCNCOS.Name = "PSCCNCOS"
        Me.PSCCNCOS.ReadOnly = True
        Me.PSCCNCOS.Width = 131
        '
        'PSNELPEP
        '
        Me.PSNELPEP.DataPropertyName = "PSNELPEP"
        Me.PSNELPEP.HeaderText = "Nro. Elemento PEP"
        Me.PSNELPEP.Name = "PSNELPEP"
        Me.PSNELPEP.ReadOnly = True
        Me.PSNELPEP.Width = 135
        '
        'PSNORSAP
        '
        Me.PSNORSAP.DataPropertyName = "PSNORSAP"
        Me.PSNORSAP.HeaderText = "Nr. Orden SAP"
        Me.PSNORSAP.Name = "PSNORSAP"
        Me.PSNORSAP.ReadOnly = True
        Me.PSNORSAP.Width = 112
        '
        'PSNGFSAP
        '
        Me.PSNGFSAP.DataPropertyName = "PSNGFSAP"
        Me.PSNGFSAP.HeaderText = "Nr. Grafo"
        Me.PSNGFSAP.Name = "PSNGFSAP"
        Me.PSNGFSAP.ReadOnly = True
        Me.PSNGFSAP.Width = 84
        '
        'PSTCTCST
        '
        Me.PSTCTCST.DataPropertyName = "PSTCTCST"
        Me.PSTCTCST.HeaderText = "CI. Terrestre"
        Me.PSTCTCST.Name = "PSTCTCST"
        Me.PSTCTCST.ReadOnly = True
        Me.PSTCTCST.Visible = False
        '
        'PSTCTCSF
        '
        Me.PSTCTCSF.DataPropertyName = "PSTCTCSF"
        Me.PSTCTCSF.HeaderText = "CI. Fluvial"
        Me.PSTCTCSF.Name = "PSTCTCSF"
        Me.PSTCTCSF.ReadOnly = True
        Me.PSTCTCSF.Visible = False
        '
        'PSTCTCSA
        '
        Me.PSTCTCSA.DataPropertyName = "PSTCTCSA"
        Me.PSTCTCSA.HeaderText = "CI. Aereo"
        Me.PSTCTCSA.Name = "PSTCTCSA"
        Me.PSTCTCSA.ReadOnly = True
        Me.PSTCTCSA.Visible = False
        '
        'PSCCEBEN
        '
        Me.PSCCEBEN.DataPropertyName = "PSCCEBEN"
        Me.PSCCEBEN.HeaderText = "Código CeBe SAP"
        Me.PSCCEBEN.Name = "PSCCEBEN"
        Me.PSCCEBEN.ReadOnly = True
        Me.PSCCEBEN.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'frmImportarCIExcel_PPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 305)
        Me.Controls.Add(Me.KryptonPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportarCIExcel_PPC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Imputación xls"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dgExcelCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.hgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.Panel.ResumeLayout(False)
        Me.hgFiltros.Panel.PerformLayout()
        CType(Me.hgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgFiltros.ResumeLayout(False)
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
    Friend WithEvents hgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaCerrarVentana As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtRutaXlsCabecera As System.Windows.Forms.TextBox
    Friend WithEvents btnExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAbrirCabecera As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgExcelCabecera As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Chk As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents PNCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORCML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPPOSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTPIMSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNCTAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCNCOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNELPEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNORSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSNGFSAP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCTCST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCTCSF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSTCTCSA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCCEBEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
