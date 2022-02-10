<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaMantenimientoIncidencia
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.dtgIncidencias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.btnExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tss05 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator
        Me.tss01 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.tss02 = New System.Windows.Forms.ToolStripSeparator
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.tss04 = New System.Windows.Forms.ToolStripSeparator
        Me.lblTitulo = New System.Windows.Forms.ToolStripLabel
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtAnio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.cmbDivision = New DevExpress.XtraEditors.CheckedComboBoxEdit
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TCMPDV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CINCID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TINCSI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ENE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FEB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MAR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ABR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MAY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JUN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JUL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OCT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOV = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.dtgIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        CType(Me.cmbDivision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.dtgIncidencias)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(947, 554)
        Me.KryptonPanel.TabIndex = 0
        '
        'dtgIncidencias
        '
        Me.dtgIncidencias.AllowUserToAddRows = False
        Me.dtgIncidencias.AllowUserToDeleteRows = False
        Me.dtgIncidencias.AllowUserToResizeColumns = False
        Me.dtgIncidencias.AllowUserToResizeRows = False
        Me.dtgIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgIncidencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.CDVSN, Me.TCMPDV, Me.CINCID, Me.TINCSI, Me.ENE, Me.FEB, Me.MAR, Me.ABR, Me.MAY, Me.JUN, Me.JUL, Me.AGO, Me.SEP, Me.OCT, Me.NOV, Me.DIC, Me.TOTAL})
        Me.dtgIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgIncidencias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgIncidencias.Location = New System.Drawing.Point(0, 104)
        Me.dtgIncidencias.MultiSelect = False
        Me.dtgIncidencias.Name = "dtgIncidencias"
        Me.dtgIncidencias.ReadOnly = True
        Me.dtgIncidencias.RowHeadersWidth = 20
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgIncidencias.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dtgIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgIncidencias.Size = New System.Drawing.Size(947, 450)
        Me.dtgIncidencias.StandardTab = True
        Me.dtgIncidencias.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgIncidencias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgIncidencias.TabIndex = 66
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExportarExcel, Me.tss05, Me.btnEliminar, Me.tssSep_02, Me.tss01, Me.btnModificar, Me.tss02, Me.btnAgregar, Me.tss03, Me.btnBuscar, Me.tss04, Me.lblTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 79)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(947, 25)
        Me.tsMenuOpciones.TabIndex = 65
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(70, 22)
        Me.btnExportarExcel.Text = "Exportar"
        '
        'tss05
        '
        Me.tss05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss05.Name = "tss05"
        Me.tss05.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 25)
        '
        'tss01
        '
        Me.tss01.Name = "tss01"
        Me.tss01.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnModificar.Image = Global.SOLMIN_SA.My.Resources.Resources.retencion
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'tss02
        '
        Me.tss02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss02.Name = "tss02"
        Me.tss02.Size = New System.Drawing.Size(6, 25)
        '
        'btnAgregar
        '
        Me.btnAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregar.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'tss03
        '
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 25)
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'tss04
        '
        Me.tss04.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss04.Name = "tss04"
        Me.tss04.Size = New System.Drawing.Size(6, 25)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(103, 22)
        Me.lblTitulo.Text = "Lista Incidencias"
        '
        'khgFiltros
        '
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.txtAnio)
        Me.khgFiltros.Panel.Controls.Add(Me.cmbDivision)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel3)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel2)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.khgFiltros.Size = New System.Drawing.Size(947, 79)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 4
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
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
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(785, 15)
        Me.txtAnio.MaxLength = 4
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(70, 22)
        Me.txtAnio.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnio.TabIndex = 85
        Me.txtAnio.Text = "0"
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDivision
        '
        Me.cmbDivision.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmbDivision.Location = New System.Drawing.Point(437, 14)
        Me.cmbDivision.Name = "cmbDivision"
        Me.cmbDivision.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.cmbDivision.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmbDivision.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbDivision.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbDivision.Properties.Appearance.Options.UseBackColor = True
        Me.cmbDivision.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbDivision.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbDivision.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbDivision.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbDivision.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbDivision.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbDivision.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbDivision.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbDivision.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbDivision.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbDivision.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbDivision.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbDivision.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbDivision.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbDivision.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbDivision.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbDivision.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbDivision.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmbDivision.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmbDivision.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmbDivision.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmbDivision.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbDivision.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmbDivision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cmbDivision.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbDivision.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.cmbDivision.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.cmbDivision.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.cmbDivision.Properties.LookAndFeel.SkinName = "Blue"
        Me.cmbDivision.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cmbDivision.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmbDivision.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.cmbDivision.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.cmbDivision.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.cmbDivision.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.cmbDivision.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbDivision.Size = New System.Drawing.Size(277, 20)
        Me.cmbDivision.TabIndex = 79
        Me.cmbDivision.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(740, 17)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel3.TabIndex = 78
        Me.KryptonLabel3.Text = "Año : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Año : "
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(371, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 78
        Me.KryptonLabel2.Text = "Division : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Division : "
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(5, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel1.TabIndex = 77
        Me.KryptonLabel1.Text = "Compañia : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Compañia : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing

        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(82, 11)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(270, 34)
        Me.UcCompania_Cmb011.TabIndex = 74
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        Me.CCMPN.Width = 79
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "PSCDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.ReadOnly = True
        Me.CDVSN.Visible = False
        Me.CDVSN.Width = 87
        '
        'TCMPDV
        '
        Me.TCMPDV.DataPropertyName = "TCMPDV"
        Me.TCMPDV.HeaderText = "División"
        Me.TCMPDV.Name = "TCMPDV"
        Me.TCMPDV.ReadOnly = True
        Me.TCMPDV.Width = 78
        '
        'CINCID
        '
        Me.CINCID.DataPropertyName = "CINCID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CINCID.DefaultCellStyle = DataGridViewCellStyle1
        Me.CINCID.HeaderText = "Código"
        Me.CINCID.Name = "CINCID"
        Me.CINCID.ReadOnly = True
        Me.CINCID.Width = 75
        '
        'TINCSI
        '
        Me.TINCSI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TINCSI.DataPropertyName = "TINCSI"
        Me.TINCSI.HeaderText = "Descripción"
        Me.TINCSI.Name = "TINCSI"
        Me.TINCSI.ReadOnly = True
        '
        'ENE
        '
        Me.ENE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ENE.DataPropertyName = "ENE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ENE.DefaultCellStyle = DataGridViewCellStyle2
        Me.ENE.HeaderText = "ENE"
        Me.ENE.Name = "ENE"
        Me.ENE.ReadOnly = True
        Me.ENE.Width = 57
        '
        'FEB
        '
        Me.FEB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FEB.DataPropertyName = "FEB"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FEB.DefaultCellStyle = DataGridViewCellStyle3
        Me.FEB.HeaderText = "FEB"
        Me.FEB.Name = "FEB"
        Me.FEB.ReadOnly = True
        Me.FEB.Width = 55
        '
        'MAR
        '
        Me.MAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MAR.DataPropertyName = "MAR"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MAR.DefaultCellStyle = DataGridViewCellStyle4
        Me.MAR.HeaderText = "MAR"
        Me.MAR.Name = "MAR"
        Me.MAR.ReadOnly = True
        Me.MAR.Width = 62
        '
        'ABR
        '
        Me.ABR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ABR.DataPropertyName = "ABR"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ABR.DefaultCellStyle = DataGridViewCellStyle5
        Me.ABR.HeaderText = "ABR"
        Me.ABR.Name = "ABR"
        Me.ABR.ReadOnly = True
        Me.ABR.Width = 58
        '
        'MAY
        '
        Me.MAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MAY.DataPropertyName = "MAY"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MAY.DefaultCellStyle = DataGridViewCellStyle6
        Me.MAY.HeaderText = "MAY"
        Me.MAY.Name = "MAY"
        Me.MAY.ReadOnly = True
        Me.MAY.Width = 62
        '
        'JUN
        '
        Me.JUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.JUN.DataPropertyName = "JUN"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.JUN.DefaultCellStyle = DataGridViewCellStyle7
        Me.JUN.HeaderText = "JUN"
        Me.JUN.Name = "JUN"
        Me.JUN.ReadOnly = True
        Me.JUN.Width = 57
        '
        'JUL
        '
        Me.JUL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.JUL.DataPropertyName = "JUL"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.JUL.DefaultCellStyle = DataGridViewCellStyle8
        Me.JUL.HeaderText = "JUL"
        Me.JUL.Name = "JUL"
        Me.JUL.ReadOnly = True
        Me.JUL.Width = 54
        '
        'AGO
        '
        Me.AGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AGO.DataPropertyName = "AGO"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.AGO.DefaultCellStyle = DataGridViewCellStyle9
        Me.AGO.HeaderText = "AGO"
        Me.AGO.Name = "AGO"
        Me.AGO.ReadOnly = True
        Me.AGO.Width = 61
        '
        'SEP
        '
        Me.SEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SEP.DataPropertyName = "SEP"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SEP.DefaultCellStyle = DataGridViewCellStyle10
        Me.SEP.HeaderText = "SEP"
        Me.SEP.Name = "SEP"
        Me.SEP.ReadOnly = True
        Me.SEP.Width = 55
        '
        'OCT
        '
        Me.OCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OCT.DataPropertyName = "OCT"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.OCT.DefaultCellStyle = DataGridViewCellStyle11
        Me.OCT.HeaderText = "OCT"
        Me.OCT.Name = "OCT"
        Me.OCT.ReadOnly = True
        Me.OCT.Width = 60
        '
        'NOV
        '
        Me.NOV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOV.DataPropertyName = "NOV"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NOV.DefaultCellStyle = DataGridViewCellStyle12
        Me.NOV.HeaderText = "NOV"
        Me.NOV.Name = "NOV"
        Me.NOV.ReadOnly = True
        Me.NOV.Width = 61
        '
        'DIC
        '
        Me.DIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DIC.DataPropertyName = "DIC"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DIC.DefaultCellStyle = DataGridViewCellStyle13
        Me.DIC.HeaderText = "DIC"
        Me.DIC.Name = "DIC"
        Me.DIC.ReadOnly = True
        Me.DIC.Width = 55
        '
        'TOTAL
        '
        Me.TOTAL.DataPropertyName = "TOTAL"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TOTAL.DefaultCellStyle = DataGridViewCellStyle14
        Me.TOTAL.HeaderText = "TOTAL"
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.ReadOnly = True
        Me.TOTAL.Width = 73
        '
        'frmListaMantenimientoIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 554)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmListaMantenimientoIncidencia"
        Me.Text = "Maestro Incidencias"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.dtgIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        CType(Me.cmbDivision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents dtgIncidencias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss04 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbDivision As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAnio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINCID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TINCSI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FEB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ABR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
