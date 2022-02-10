<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReversionProvisionDeVenta
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReversionProvisionDeVenta))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim BeCompania1 As Ransa.Controls.UbicacionPlanta.Compania.beCompania = New Ransa.Controls.UbicacionPlanta.Compania.beCompania
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.spContainer001 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
        Me.dtgOperaciones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.lblTipoCambio_1 = New System.Windows.Forms.ToolStripLabel
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.tss001 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.tss002 = New System.Windows.Forms.ToolStripSeparator
        Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.cmbRegionVenta = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.cmbMes = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.lblMes = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblAnio = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator1 = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
        Me.PNNMPRVT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSCRGVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REGION_VENTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO_PROVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SALDO_PROVISION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaProvision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HoraProvision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCNTCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.spContainer001, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spContainer001.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spContainer001.Panel1.SuspendLayout()
        CType(Me.spContainer001.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spContainer001.Panel2.SuspendLayout()
        Me.spContainer001.SuspendLayout()
        CType(Me.dtgOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGFiltro.Panel.SuspendLayout()
        Me.HGFiltro.SuspendLayout()
        CType(Me.cmbRegionVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.spContainer001)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.HGFiltro)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(889, 471)
        Me.KryptonPanel.TabIndex = 0
        '
        'spContainer001
        '
        Me.spContainer001.Cursor = System.Windows.Forms.Cursors.Default
        Me.spContainer001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spContainer001.Location = New System.Drawing.Point(0, 115)
        Me.spContainer001.Name = "spContainer001"
        Me.spContainer001.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spContainer001.Panel1
        '
        Me.spContainer001.Panel1.Controls.Add(Me.dtgOperaciones)
        '
        'spContainer001.Panel2
        '
        Me.spContainer001.Panel2.Controls.Add(Me.KryptonDataGridView1)
        Me.spContainer001.Size = New System.Drawing.Size(889, 356)
        Me.spContainer001.SplitterDistance = 128
        Me.spContainer001.TabIndex = 6
        '
        'dtgOperaciones
        '
        Me.dtgOperaciones.AllowUserToAddRows = False
        Me.dtgOperaciones.AllowUserToDeleteRows = False
        Me.dtgOperaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgOperaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNNMPRVT, Me.PSCRGVTA, Me.REGION_VENTA, Me.MONTO_PROVISION, Me.SALDO_PROVISION, Me.FechaProvision, Me.HoraProvision})
        Me.dtgOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.dtgOperaciones.Name = "dtgOperaciones"
        Me.dtgOperaciones.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgOperaciones.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOperaciones.Size = New System.Drawing.Size(889, 128)
        Me.dtgOperaciones.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgOperaciones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOperaciones.TabIndex = 6
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCNTCS, Me.TCNTCS, Me.CCLNT, Me.TCMPCL, Me.Column1, Me.Column2})
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.KryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(889, 223)
        Me.KryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.KryptonDataGridView1.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel4, Me.lblTipoCambio_1, Me.btnBuscar, Me.tss001, Me.btnExportar, Me.tss002})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 90)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(889, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel4.Text = "T.C.  "
        '
        'lblTipoCambio_1
        '
        Me.lblTipoCambio_1.Name = "lblTipoCambio_1"
        Me.lblTipoCambio_1.Size = New System.Drawing.Size(13, 22)
        Me.lblTipoCambio_1.Text = "0"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'tss001
        '
        Me.tss001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss001.Name = "tss001"
        Me.tss001.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_CT.My.Resources.Resources.icono_exp_excel
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(99, 22)
        Me.btnExportar.Text = "Exportar Excel"
        '
        'tss002
        '
        Me.tss002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss002.Name = "tss002"
        Me.tss002.Size = New System.Drawing.Size(6, 25)
        '
        'HGFiltro
        '
        Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.HGFiltro.HeaderVisibleSecondary = False
        Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
        Me.HGFiltro.Name = "HGFiltro"
        '
        'HGFiltro.Panel
        '
        Me.HGFiltro.Panel.Controls.Add(Me.cmbRegionVenta)
        Me.HGFiltro.Panel.Controls.Add(Me.cmbMes)
        Me.HGFiltro.Panel.Controls.Add(Me.lblMes)
        Me.HGFiltro.Panel.Controls.Add(Me.lblAnio)
        Me.HGFiltro.Panel.Controls.Add(Me.txtAnio)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HGFiltro.Panel.Controls.Add(Me.UcCompania)
        Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel4)
        Me.HGFiltro.Size = New System.Drawing.Size(889, 90)
        Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HGFiltro.TabIndex = 2
        Me.HGFiltro.Text = "Filtro"
        Me.HGFiltro.ValuesPrimary.Description = ""
        Me.HGFiltro.ValuesPrimary.Heading = "Filtro"
        Me.HGFiltro.ValuesPrimary.Image = Nothing
        Me.HGFiltro.ValuesSecondary.Description = ""
        Me.HGFiltro.ValuesSecondary.Heading = "Description"
        Me.HGFiltro.ValuesSecondary.Image = Nothing
        '
        'cmbRegionVenta
        '
        Me.cmbRegionVenta.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmbRegionVenta.EditValue = ""
        Me.cmbRegionVenta.Location = New System.Drawing.Point(379, 7)
        Me.cmbRegionVenta.Name = "cmbRegionVenta"
        Me.cmbRegionVenta.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cmbRegionVenta.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmbRegionVenta.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbRegionVenta.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbRegionVenta.Properties.Appearance.Options.UseBackColor = True
        Me.cmbRegionVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbRegionVenta.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbRegionVenta.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbRegionVenta.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbRegionVenta.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbRegionVenta.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbRegionVenta.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbRegionVenta.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbRegionVenta.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbRegionVenta.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbRegionVenta.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbRegionVenta.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbRegionVenta.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbRegionVenta.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbRegionVenta.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbRegionVenta.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbRegionVenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbRegionVenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cmbRegionVenta.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRegionVenta.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cmbRegionVenta.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cmbRegionVenta.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cmbRegionVenta.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbRegionVenta.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbRegionVenta.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.cmbRegionVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.cmbRegionVenta.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cmbRegionVenta.Properties.SelectAllItemCaption = "TODOS"
        Me.cmbRegionVenta.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cmbRegionVenta.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbRegionVenta.Size = New System.Drawing.Size(255, 22)
        Me.cmbRegionVenta.TabIndex = 85
        Me.cmbRegionVenta.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'cmbMes
        '
        Me.cmbMes.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmbMes.Location = New System.Drawing.Point(379, 35)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cmbMes.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmbMes.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbMes.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbMes.Properties.Appearance.Options.UseBackColor = True
        Me.cmbMes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbMes.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbMes.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbMes.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbMes.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbMes.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbMes.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbMes.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbMes.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbMes.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbMes.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbMes.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbMes.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbMes.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbMes.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbMes.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbMes.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbMes.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbMes.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbMes.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbMes.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbMes.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbMes.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbMes.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbMes.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbMes.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbMes.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbMes.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbMes.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbMes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.cmbMes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMes.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cmbMes.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cmbMes.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cmbMes.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.cmbMes.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbMes.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.cmbMes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.cmbMes.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cmbMes.Properties.SelectAllItemCaption = "Todos"
        Me.cmbMes.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cmbMes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbMes.Size = New System.Drawing.Size(153, 22)
        Me.cmbMes.TabIndex = 82
        Me.cmbMes.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblMes
        '
        Me.lblMes.Location = New System.Drawing.Point(321, 37)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(39, 20)
        Me.lblMes.TabIndex = 81
        Me.lblMes.Text = "Mes :"
        Me.lblMes.Values.ExtraText = ""
        Me.lblMes.Values.Image = Nothing
        Me.lblMes.Values.Text = "Mes :"
        '
        'lblAnio
        '
        Me.lblAnio.Location = New System.Drawing.Point(38, 37)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(39, 20)
        Me.lblAnio.TabIndex = 80
        Me.lblAnio.Text = "Año :"
        Me.lblAnio.Values.ExtraText = ""
        Me.lblAnio.Values.Image = Nothing
        Me.lblAnio.Values.Text = "Año :"
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(77, 35)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(93, 22)
        Me.txtAnio.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.TabIndex = 79
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TypeValidator1.SetTypes(Me.txtAnio, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(297, 9)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(63, 20)
        Me.KryptonLabel2.TabIndex = 74
        Me.KryptonLabel2.Text = "Negocio :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Negocio :"
        '
        'UcCompania
        '
        Me.UcCompania.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania.CCMPN_ANTERIOR = Nothing
        Me.UcCompania.CCMPN_CodigoCompania = Nothing
        Me.UcCompania.CCMPN_CompaniaDefault = "EZ"
        Me.UcCompania.CCMPN_Descripcion = Nothing
        Me.UcCompania.Habilitar = True
        Me.UcCompania.Location = New System.Drawing.Point(77, 5)
        Me.UcCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania.Name = "UcCompania"
        BeCompania1.CCMPN_CodigoCompania = ""
        BeCompania1.Orden = -1
        BeCompania1.TCMPCM_DescripcionCompania = ""
        Me.UcCompania.oBeCompania = BeCompania1
        Me.UcCompania.Size = New System.Drawing.Size(203, 24)
        Me.UcCompania.TabIndex = 0
        Me.UcCompania.Usuario = ""
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(5, 9)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel4.TabIndex = 0
        Me.KryptonLabel4.Text = "Compañia :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañia :"
        '
        'PNNMPRVT
        '
        Me.PNNMPRVT.DataPropertyName = "PNNMPRVT"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PNNMPRVT.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNNMPRVT.HeaderText = "Nr. Revisión"
        Me.PNNMPRVT.Name = "PNNMPRVT"
        Me.PNNMPRVT.ReadOnly = True
        '
        'PSCRGVTA
        '
        Me.PSCRGVTA.DataPropertyName = "PSCRGVTA"
        Me.PSCRGVTA.HeaderText = "Cod. Región Venta"
        Me.PSCRGVTA.Name = "PSCRGVTA"
        Me.PSCRGVTA.ReadOnly = True
        '
        'REGION_VENTA
        '
        Me.REGION_VENTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.REGION_VENTA.HeaderText = "Región Venta"
        Me.REGION_VENTA.Name = "REGION_VENTA"
        Me.REGION_VENTA.ReadOnly = True
        '
        'MONTO_PROVISION
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.MONTO_PROVISION.DefaultCellStyle = DataGridViewCellStyle2
        Me.MONTO_PROVISION.HeaderText = "Monto"
        Me.MONTO_PROVISION.Name = "MONTO_PROVISION"
        Me.MONTO_PROVISION.ReadOnly = True
        '
        'SALDO_PROVISION
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SALDO_PROVISION.DefaultCellStyle = DataGridViewCellStyle3
        Me.SALDO_PROVISION.HeaderText = "Saldo"
        Me.SALDO_PROVISION.Name = "SALDO_PROVISION"
        Me.SALDO_PROVISION.ReadOnly = True
        '
        'FechaProvision
        '
        Me.FechaProvision.DataPropertyName = "FechaProvision"
        Me.FechaProvision.HeaderText = "Fecha Provisión"
        Me.FechaProvision.Name = "FechaProvision"
        Me.FechaProvision.ReadOnly = True
        '
        'HoraProvision
        '
        Me.HoraProvision.HeaderText = "Hora Provisión"
        Me.HoraProvision.Name = "HoraProvision"
        Me.HoraProvision.ReadOnly = True
        '
        'CCNTCS
        '
        Me.CCNTCS.DataPropertyName = "CCNTCS"
        Me.CCNTCS.FillWeight = 170.0!
        Me.CCNTCS.HeaderText = "Cod. Centro Beneficio"
        Me.CCNTCS.Name = "CCNTCS"
        Me.CCNTCS.ReadOnly = True
        Me.CCNTCS.Width = 150
        '
        'TCNTCS
        '
        Me.TCNTCS.DataPropertyName = "TCNTCS"
        Me.TCNTCS.FillWeight = 200.0!
        Me.TCNTCS.HeaderText = "Des Centro Beneficio"
        Me.TCNTCS.Name = "TCNTCS"
        Me.TCNTCS.ReadOnly = True
        Me.TCNTCS.Width = 150
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "Cod. Cliente"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        '
        'TCMPCL
        '
        Me.TCMPCL.DataPropertyName = "TCMPCL"
        Me.TCMPCL.HeaderText = "Razón Social Cliente"
        Me.TCMPCL.Name = "TCMPCL"
        Me.TCMPCL.ReadOnly = True
        Me.TCMPCL.Width = 250
        '
        'Column1
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column1.HeaderText = "Mes"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "..."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'frmReversionDeVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 471)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmReversionDeVentas"
        Me.Text = "Reversión de Provisión de Venta"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.spContainer001.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContainer001.Panel1.ResumeLayout(False)
        CType(Me.spContainer001.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContainer001.Panel2.ResumeLayout(False)
        CType(Me.spContainer001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spContainer001.ResumeLayout(False)
        CType(Me.dtgOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.Panel.ResumeLayout(False)
        Me.HGFiltro.Panel.PerformLayout()
        CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGFiltro.ResumeLayout(False)
        CType(Me.cmbRegionVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HGFiltro As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTipoCambio_1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblMes As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAnio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents cmbRegionVenta As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbMes As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents TypeValidator1 As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents spContainer001 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents dtgOperaciones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNNMPRVT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSCRGVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGION_VENTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO_PROVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDO_PROVISION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaProvision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraProvision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCNTCS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
