<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransportistaGenerarAS400
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransportistaGenerarAS400))
        Me.KryptonHeaderGroup5 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtfiltro_codsap = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtruc = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtrazonsocial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtcod = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gwdDatos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.UcPaginacion1 = New Ransa.Utilitario.UCPaginacion()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbPolizaSeguro = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtcodsap_mant = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtruc_mant = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtrazon_mant = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtcodigo_mant = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.txtAbrev = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTRSPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRUCTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUCPR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_RESPSEG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPSEG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCRSGR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIREC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABTRT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDireccionTransportista = New SOLMIN_ST.TextField()
        Me.txtPorSeguro = New Ransa.Utilitario.clsTextBoxNumero()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup5.Panel.SuspendLayout()
        Me.KryptonHeaderGroup5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup5
        '
        Me.KryptonHeaderGroup5.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup5.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup5.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup5.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup5.Name = "KryptonHeaderGroup5"
        '
        'KryptonHeaderGroup5.Panel
        '
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtfiltro_codsap)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtruc)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtrazonsocial)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.txtcod)
        Me.KryptonHeaderGroup5.Panel.Controls.Add(Me.KryptonLabel12)
        Me.KryptonHeaderGroup5.Size = New System.Drawing.Size(1188, 91)
        Me.KryptonHeaderGroup5.TabIndex = 0
        Me.KryptonHeaderGroup5.Text = "Heading"
        Me.KryptonHeaderGroup5.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup5.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup5.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup5.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup5.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup5.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup5.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(550, 24)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(77, 24)
        Me.KryptonLabel7.TabIndex = 7
        Me.KryptonLabel7.Text = "Cod. SAP:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Cod. SAP:"
        '
        'txtfiltro_codsap
        '
        Me.txtfiltro_codsap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfiltro_codsap.Location = New System.Drawing.Point(658, 20)
        Me.txtfiltro_codsap.MaxLength = 20
        Me.txtfiltro_codsap.Name = "txtfiltro_codsap"
        Me.txtfiltro_codsap.Size = New System.Drawing.Size(171, 26)
        Me.txtfiltro_codsap.TabIndex = 6
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Location = New System.Drawing.Point(346, 22)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(171, 26)
        Me.txtruc.TabIndex = 5
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(275, 22)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(44, 24)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Text = "RUC:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "RUC:"
        '
        'txtrazonsocial
        '
        Me.txtrazonsocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrazonsocial.Location = New System.Drawing.Point(127, 54)
        Me.txtrazonsocial.MaxLength = 100
        Me.txtrazonsocial.Name = "txtrazonsocial"
        Me.txtrazonsocial.Size = New System.Drawing.Size(390, 26)
        Me.txtrazonsocial.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(8, 56)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(101, 24)
        Me.KryptonLabel1.TabIndex = 2
        Me.KryptonLabel1.Text = "Razón Social:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Razón Social:"
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Location = New System.Drawing.Point(127, 22)
        Me.txtcod.MaxLength = 6
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(129, 26)
        Me.txtcod.TabIndex = 1
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(8, 22)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(64, 24)
        Me.KryptonLabel12.TabIndex = 0
        Me.KryptonLabel12.Text = "Código:"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Código:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 91)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1188, 27)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_ST.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 118)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gwdDatos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcPaginacion1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPorSeguro)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtAbrev)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDireccionTransportista)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel17)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbPolizaSeguro)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel16)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtcodsap_mant)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtruc_mant)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtrazon_mant)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtcodigo_mant)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1188, 484)
        Me.SplitContainer1.SplitterDistance = 269
        Me.SplitContainer1.TabIndex = 12
        '
        'gwdDatos
        '
        Me.gwdDatos.AllowUserToAddRows = False
        Me.gwdDatos.AllowUserToDeleteRows = False
        Me.gwdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gwdDatos.ColumnHeadersHeight = 30
        Me.gwdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gwdDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CTRSPT, Me.NRUCTR, Me.TCMTRT, Me.RUCPR2, Me.COD_RESPSEG, Me.RESPSEG, Me.PCRSGR, Me.DIREC, Me.TABTRT, Me.Column1})
        Me.gwdDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gwdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gwdDatos.Location = New System.Drawing.Point(0, 0)
        Me.gwdDatos.MultiSelect = False
        Me.gwdDatos.Name = "gwdDatos"
        Me.gwdDatos.ReadOnly = True
        Me.gwdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gwdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gwdDatos.Size = New System.Drawing.Size(1188, 242)
        Me.gwdDatos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.gwdDatos.TabIndex = 14
        '
        'UcPaginacion1
        '
        Me.UcPaginacion1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcPaginacion1.Location = New System.Drawing.Point(0, 242)
        Me.UcPaginacion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcPaginacion1.Name = "UcPaginacion1"
        Me.UcPaginacion1.PageCount = 0
        Me.UcPaginacion1.PageNumber = 1
        Me.UcPaginacion1.PageSize = 20
        Me.UcPaginacion1.Size = New System.Drawing.Size(1188, 27)
        Me.UcPaginacion1.TabIndex = 0
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(30, 124)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(79, 24)
        Me.KryptonLabel8.TabIndex = 9
        Me.KryptonLabel8.Text = "Dirección:"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Dirección:"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel17.Location = New System.Drawing.Point(965, 124)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel17.TabIndex = 13
        Me.KryptonLabel17.Text = "%Seguro"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "%Seguro"
        '
        'cmbPolizaSeguro
        '
        Me.cmbPolizaSeguro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPolizaSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPolizaSeguro.DropDownWidth = 156
        Me.cmbPolizaSeguro.FormattingEnabled = False
        Me.cmbPolizaSeguro.ItemHeight = 20
        Me.cmbPolizaSeguro.Location = New System.Drawing.Point(757, 120)
        Me.cmbPolizaSeguro.Name = "cmbPolizaSeguro"
        Me.cmbPolizaSeguro.Size = New System.Drawing.Size(185, 28)
        Me.cmbPolizaSeguro.TabIndex = 12
        Me.cmbPolizaSeguro.TabStop = False
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel16.Location = New System.Drawing.Point(609, 124)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(104, 24)
        Me.KryptonLabel16.TabIndex = 11
        Me.KryptonLabel16.Text = "Póliza Seguro"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Póliza Seguro"
        '
        'txtcodsap_mant
        '
        Me.txtcodsap_mant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodsap_mant.Location = New System.Drawing.Point(177, 156)
        Me.txtcodsap_mant.MaxLength = 10
        Me.txtcodsap_mant.Name = "txtcodsap_mant"
        Me.txtcodsap_mant.Size = New System.Drawing.Size(129, 26)
        Me.txtcodsap_mant.TabIndex = 16
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(29, 156)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(112, 24)
        Me.KryptonLabel6.TabIndex = 15
        Me.KryptonLabel6.Text = "Cód. Acreedor:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Cód. Acreedor:"
        '
        'txtruc_mant
        '
        Me.txtruc_mant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc_mant.Location = New System.Drawing.Point(396, 55)
        Me.txtruc_mant.MaxLength = 11
        Me.txtruc_mant.Name = "txtruc_mant"
        Me.txtruc_mant.Size = New System.Drawing.Size(171, 26)
        Me.txtruc_mant.TabIndex = 4
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(325, 57)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(44, 24)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Text = "RUC:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "RUC:"
        '
        'txtrazon_mant
        '
        Me.txtrazon_mant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrazon_mant.Location = New System.Drawing.Point(177, 87)
        Me.txtrazon_mant.MaxLength = 40
        Me.txtrazon_mant.Name = "txtrazon_mant"
        Me.txtrazon_mant.Size = New System.Drawing.Size(390, 26)
        Me.txtrazon_mant.TabIndex = 6
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(29, 89)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(101, 24)
        Me.KryptonLabel4.TabIndex = 5
        Me.KryptonLabel4.Text = "Razón Social:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Razón Social:"
        '
        'txtcodigo_mant
        '
        Me.txtcodigo_mant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo_mant.Location = New System.Drawing.Point(177, 55)
        Me.txtcodigo_mant.MaxLength = 10
        Me.txtcodigo_mant.Name = "txtcodigo_mant"
        Me.txtcodigo_mant.Size = New System.Drawing.Size(129, 26)
        Me.txtcodigo_mant.TabIndex = 2
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(29, 57)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(64, 24)
        Me.KryptonLabel5.TabIndex = 1
        Me.KryptonLabel5.Text = "Código:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Código:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.btnModificar, Me.btnGuardar, Me.btnCancelar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1188, 27)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(76, 24)
        Me.btnnuevo.Text = "Nuevo"
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.SOLMIN_ST.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(97, 24)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.SOLMIN_ST.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.SOLMIN_ST.My.Resources.Resources.cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtAbrev
        '
        Me.txtAbrev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbrev.Location = New System.Drawing.Point(757, 87)
        Me.txtAbrev.MaxLength = 20
        Me.txtAbrev.Name = "txtAbrev"
        Me.txtAbrev.Size = New System.Drawing.Size(390, 26)
        Me.txtAbrev.TabIndex = 8
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(609, 89)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(58, 24)
        Me.KryptonLabel9.TabIndex = 7
        Me.KryptonLabel9.Text = "Abrev.:"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Abrev.:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CTRSPT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 68
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NRUCTR"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RUC"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 60
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TCMTRT"
        Me.DataGridViewTextBoxColumn3.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Razón social"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RUCPR2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Código SAP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 137
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "COD_RESPSEG"
        Me.DataGridViewTextBoxColumn5.HeaderText = ""
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RESPSEG"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Resp. Seguro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 128
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PCRSGR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "% Seguro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 105
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DIREC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DIREC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TABTRT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TABTRT"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CTRSPT
        '
        Me.CTRSPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CTRSPT.DataPropertyName = "CTRSPT"
        Me.CTRSPT.HeaderText = "Código"
        Me.CTRSPT.MinimumWidth = 50
        Me.CTRSPT.Name = "CTRSPT"
        Me.CTRSPT.ReadOnly = True
        Me.CTRSPT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CTRSPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CTRSPT.Width = 68
        '
        'NRUCTR
        '
        Me.NRUCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRUCTR.DataPropertyName = "NRUCTR"
        Me.NRUCTR.HeaderText = "RUC"
        Me.NRUCTR.MinimumWidth = 60
        Me.NRUCTR.Name = "NRUCTR"
        Me.NRUCTR.ReadOnly = True
        Me.NRUCTR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NRUCTR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NRUCTR.Width = 60
        '
        'TCMTRT
        '
        Me.TCMTRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TCMTRT.DataPropertyName = "TCMTRT"
        Me.TCMTRT.FillWeight = 300.0!
        Me.TCMTRT.HeaderText = "Razón social"
        Me.TCMTRT.MinimumWidth = 200
        Me.TCMTRT.Name = "TCMTRT"
        Me.TCMTRT.ReadOnly = True
        Me.TCMTRT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TCMTRT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TCMTRT.Width = 200
        '
        'RUCPR2
        '
        Me.RUCPR2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RUCPR2.DataPropertyName = "RUCPR2"
        Me.RUCPR2.HeaderText = "Cód. Acreedor"
        Me.RUCPR2.Name = "RUCPR2"
        Me.RUCPR2.ReadOnly = True
        Me.RUCPR2.Width = 137
        '
        'COD_RESPSEG
        '
        Me.COD_RESPSEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COD_RESPSEG.DataPropertyName = "COD_RESPSEG"
        Me.COD_RESPSEG.HeaderText = "COD_RESPSEG"
        Me.COD_RESPSEG.Name = "COD_RESPSEG"
        Me.COD_RESPSEG.ReadOnly = True
        Me.COD_RESPSEG.Visible = False
        Me.COD_RESPSEG.Width = 138
        '
        'RESPSEG
        '
        Me.RESPSEG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESPSEG.DataPropertyName = "RESPSEG"
        Me.RESPSEG.HeaderText = "Resp. Seguro"
        Me.RESPSEG.Name = "RESPSEG"
        Me.RESPSEG.ReadOnly = True
        Me.RESPSEG.Width = 128
        '
        'PCRSGR
        '
        Me.PCRSGR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PCRSGR.DataPropertyName = "PCRSGR"
        Me.PCRSGR.HeaderText = "% Seguro"
        Me.PCRSGR.Name = "PCRSGR"
        Me.PCRSGR.ReadOnly = True
        Me.PCRSGR.Width = 105
        '
        'DIREC
        '
        Me.DIREC.DataPropertyName = "DIREC"
        Me.DIREC.HeaderText = "DIREC"
        Me.DIREC.Name = "DIREC"
        Me.DIREC.ReadOnly = True
        Me.DIREC.Visible = False
        '
        'TABTRT
        '
        Me.TABTRT.DataPropertyName = "TABTRT"
        Me.TABTRT.HeaderText = "TABTRT"
        Me.TABTRT.Name = "TABTRT"
        Me.TABTRT.ReadOnly = True
        Me.TABTRT.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'txtDireccionTransportista
        '
        Me.txtDireccionTransportista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionTransportista.Location = New System.Drawing.Point(177, 122)
        Me.txtDireccionTransportista.MaxLength = 30
        Me.txtDireccionTransportista.Name = "txtDireccionTransportista"
        Me.txtDireccionTransportista.Size = New System.Drawing.Size(390, 26)
        Me.txtDireccionTransportista.TabIndex = 10
        Me.txtDireccionTransportista.TextValidationType = SOLMIN_ST.ValidationInputType.Numeric
        '
        'txtPorSeguro
        '
        Me.txtPorSeguro.Location = New System.Drawing.Point(1047, 126)
        Me.txtPorSeguro.MaxLength = 10
        Me.txtPorSeguro.Name = "txtPorSeguro"
        Me.txtPorSeguro.NUMDECIMALES = 2
        Me.txtPorSeguro.NUMENTEROS = 6
        Me.txtPorSeguro.Size = New System.Drawing.Size(100, 22)
        Me.txtPorSeguro.TabIndex = 17
        '
        'frmTransportistaGenerarAS400
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 602)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.KryptonHeaderGroup5)
        Me.Name = "frmTransportistaGenerarAS400"
        Me.Text = "Generar Código Transportista"
        CType(Me.KryptonHeaderGroup5.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup5.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup5.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gwdDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonHeaderGroup5 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtruc As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtrazonsocial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtcod As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtruc_mant As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtrazon_mant As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtcodigo_mant As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtcodsap_mant As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtfiltro_codsap As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents gwdDatos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents UcPaginacion1 As Ransa.Utilitario.UCPaginacion
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbPolizaSeguro As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccionTransportista As SOLMIN_ST.TextField
    Friend WithEvents txtAbrev As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CTRSPT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRUCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUCPR2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_RESPSEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESPSEG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCRSGR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIREC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPorSeguro As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
