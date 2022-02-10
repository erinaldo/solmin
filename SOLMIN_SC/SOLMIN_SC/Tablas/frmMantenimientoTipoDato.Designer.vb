<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoTipoDato
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
    Me.HGDetalle = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Me.dtgTipoDato = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.TabControl1 = New System.Windows.Forms.TabControl
    Me.tabTipoDato = New System.Windows.Forms.TabPage
    Me.txtDescripcionTipoDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.txtCodigoTipoDato = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.tabDetalle = New System.Windows.Forms.TabPage
    Me.dtgTipoDatoDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
    Me.btnCancelar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
    Me.btnEliminar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.btnGuardar = New System.Windows.Forms.ToolStripButton
    Me.btnModificar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.btnNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnBuscar = New System.Windows.Forms.ToolStripButton
    Me.HGFiltro = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.txtFiltro = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NTPODT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TDSTPD = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SESTRG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NTPODT_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.NCODRG_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.TDSCRG_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.CCLNT1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.QCNTN = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.SESTRG_1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonPanel.SuspendLayout()
    CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HGDetalle.Panel.SuspendLayout()
    Me.HGDetalle.SuspendLayout()
    CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonSplitContainer1.Panel1.SuspendLayout()
    CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonSplitContainer1.Panel2.SuspendLayout()
    Me.KryptonSplitContainer1.SuspendLayout()
    CType(Me.dtgTipoDato, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.tabTipoDato.SuspendLayout()
    Me.tabDetalle.SuspendLayout()
    CType(Me.dtgTipoDatoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HGFiltro.Panel.SuspendLayout()
    Me.HGFiltro.SuspendLayout()
    Me.SuspendLayout()
    '
    'KryptonPanel
    '
    Me.KryptonPanel.Controls.Add(Me.HGDetalle)
    Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
    Me.KryptonPanel.Controls.Add(Me.HGFiltro)
    Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
    Me.KryptonPanel.Name = "KryptonPanel"
    Me.KryptonPanel.Size = New System.Drawing.Size(1156, 696)
    Me.KryptonPanel.TabIndex = 0
    '
    'HGDetalle
    '
    Me.HGDetalle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.HGDetalle.HeaderVisibleSecondary = False
    Me.HGDetalle.Location = New System.Drawing.Point(0, 95)
    Me.HGDetalle.Name = "HGDetalle"
    '
    'HGDetalle.Panel
    '
    Me.HGDetalle.Panel.Controls.Add(Me.KryptonSplitContainer1)
    Me.HGDetalle.Size = New System.Drawing.Size(1156, 601)
    Me.HGDetalle.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.HGDetalle.TabIndex = 1
    Me.HGDetalle.Text = "Detalle"
    Me.HGDetalle.ValuesPrimary.Description = ""
    Me.HGDetalle.ValuesPrimary.Heading = "Detalle"
    Me.HGDetalle.ValuesPrimary.Image = Nothing
    Me.HGDetalle.ValuesSecondary.Description = ""
    Me.HGDetalle.ValuesSecondary.Heading = "Description"
    Me.HGDetalle.ValuesSecondary.Image = Nothing
    '
    'KryptonSplitContainer1
    '
    Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
    Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
    Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'KryptonSplitContainer1.Panel1
    '
    Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.dtgTipoDato)
    '
    'KryptonSplitContainer1.Panel2
    '
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.TabControl1)
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
    Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile
    Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1154, 582)
    Me.KryptonSplitContainer1.SplitterDistance = 329
    Me.KryptonSplitContainer1.TabIndex = 3
    '
    'dtgTipoDato
    '
    Me.dtgTipoDato.AllowUserToAddRows = False
    Me.dtgTipoDato.AllowUserToDeleteRows = False
    Me.dtgTipoDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dtgTipoDato.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTPODT, Me.TDSTPD, Me.SESTRG})
    Me.dtgTipoDato.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgTipoDato.Location = New System.Drawing.Point(0, 0)
    Me.dtgTipoDato.Name = "dtgTipoDato"
    Me.dtgTipoDato.ReadOnly = True
    Me.dtgTipoDato.Size = New System.Drawing.Size(1154, 329)
    Me.dtgTipoDato.StateCommon.Background.Color1 = System.Drawing.Color.White
    Me.dtgTipoDato.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgTipoDato.TabIndex = 1
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.tabTipoDato)
    Me.TabControl1.Controls.Add(Me.tabDetalle)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1154, 189)
    Me.TabControl1.TabIndex = 16
    '
    'tabTipoDato
    '
    Me.tabTipoDato.BackColor = System.Drawing.Color.White
    Me.tabTipoDato.Controls.Add(Me.txtDescripcionTipoDato)
    Me.tabTipoDato.Controls.Add(Me.KryptonLabel3)
    Me.tabTipoDato.Controls.Add(Me.KryptonLabel2)
    Me.tabTipoDato.Controls.Add(Me.txtCodigoTipoDato)
    Me.tabTipoDato.Location = New System.Drawing.Point(4, 22)
    Me.tabTipoDato.Name = "tabTipoDato"
    Me.tabTipoDato.Padding = New System.Windows.Forms.Padding(3)
    Me.tabTipoDato.Size = New System.Drawing.Size(1146, 163)
    Me.tabTipoDato.TabIndex = 0
    Me.tabTipoDato.Text = "Tipo Dato"
    '
    'txtDescripcionTipoDato
    '
    Me.txtDescripcionTipoDato.Location = New System.Drawing.Point(141, 69)
    Me.txtDescripcionTipoDato.MaxLength = 50
    Me.txtDescripcionTipoDato.Name = "txtDescripcionTipoDato"
    Me.txtDescripcionTipoDato.Size = New System.Drawing.Size(525, 21)
    Me.txtDescripcionTipoDato.TabIndex = 3
    '
    'KryptonLabel3
    '
    Me.KryptonLabel3.Location = New System.Drawing.Point(36, 69)
    Me.KryptonLabel3.Name = "KryptonLabel3"
    Me.KryptonLabel3.Size = New System.Drawing.Size(74, 19)
    Me.KryptonLabel3.TabIndex = 2
    Me.KryptonLabel3.Text = "Descripción : "
    Me.KryptonLabel3.Values.ExtraText = ""
    Me.KryptonLabel3.Values.Image = Nothing
    Me.KryptonLabel3.Values.Text = "Descripción : "
    '
    'KryptonLabel2
    '
    Me.KryptonLabel2.Location = New System.Drawing.Point(36, 19)
    Me.KryptonLabel2.Name = "KryptonLabel2"
    Me.KryptonLabel2.Size = New System.Drawing.Size(52, 19)
    Me.KryptonLabel2.TabIndex = 0
    Me.KryptonLabel2.Text = "Codigo :"
    Me.KryptonLabel2.Values.ExtraText = ""
    Me.KryptonLabel2.Values.Image = Nothing
    Me.KryptonLabel2.Values.Text = "Codigo :"
    '
    'txtCodigoTipoDato
    '
    Me.txtCodigoTipoDato.Enabled = False
    Me.txtCodigoTipoDato.Location = New System.Drawing.Point(141, 17)
    Me.txtCodigoTipoDato.Name = "txtCodigoTipoDato"
    Me.txtCodigoTipoDato.ReadOnly = True
    Me.txtCodigoTipoDato.Size = New System.Drawing.Size(100, 21)
    Me.txtCodigoTipoDato.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtCodigoTipoDato.TabIndex = 1
    Me.txtCodigoTipoDato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'tabDetalle
    '
    Me.tabDetalle.Controls.Add(Me.dtgTipoDatoDetalle)
    Me.tabDetalle.Location = New System.Drawing.Point(4, 22)
    Me.tabDetalle.Name = "tabDetalle"
    Me.tabDetalle.Padding = New System.Windows.Forms.Padding(3)
    Me.tabDetalle.Size = New System.Drawing.Size(1146, 163)
    Me.tabDetalle.TabIndex = 1
    Me.tabDetalle.Text = "Detalle"
    Me.tabDetalle.UseVisualStyleBackColor = True
    '
    'dtgTipoDatoDetalle
    '
    Me.dtgTipoDatoDetalle.AllowUserToAddRows = False
    Me.dtgTipoDatoDetalle.AllowUserToDeleteRows = False
    Me.dtgTipoDatoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dtgTipoDatoDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTPODT_1, Me.NCODRG_1, Me.TDSCRG_1, Me.CCLNT1, Me.QCNTN, Me.SESTRG_1})
    Me.dtgTipoDatoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dtgTipoDatoDetalle.Location = New System.Drawing.Point(3, 3)
    Me.dtgTipoDatoDetalle.Name = "dtgTipoDatoDetalle"
    Me.dtgTipoDatoDetalle.ReadOnly = True
    Me.dtgTipoDatoDetalle.Size = New System.Drawing.Size(1140, 157)
    Me.dtgTipoDatoDetalle.StateCommon.Background.Color1 = System.Drawing.Color.White
    Me.dtgTipoDatoDetalle.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
    Me.dtgTipoDatoDetalle.TabIndex = 0
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator3, Me.btnEliminar, Me.ToolStripSeparator1, Me.btnGuardar, Me.btnModificar, Me.ToolStripSeparator2, Me.btnNuevo})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(1154, 25)
    Me.ToolStrip2.TabIndex = 15
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnCancelar
    '
    Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnCancelar.Image = Global.SOLMIN_SC.My.Resources.Resources.button_cancel
    Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(71, 22)
    Me.btnCancelar.Text = "Cancelar"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
    '
    'btnEliminar
    '
    Me.btnEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnEliminar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_remove
    Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(68, 22)
    Me.btnEliminar.Text = "Eliminar"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnGuardar
    '
    Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnGuardar.Image = Global.SOLMIN_SC.My.Resources.Resources.db_comit
    Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
    Me.btnGuardar.Text = "Guardar"
    '
    'btnModificar
    '
    Me.btnModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnModificar.Image = Global.SOLMIN_SC.My.Resources.Resources.agt_action_success
    Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(76, 22)
    Me.btnModificar.Text = "Modificar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'btnNuevo
    '
    Me.btnNuevo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnNuevo.Image = Global.SOLMIN_SC.My.Resources.Resources.db_add
    Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(60, 22)
    Me.btnNuevo.Text = "Nuevo"
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 70)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(1156, 25)
    Me.ToolStrip1.TabIndex = 14
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnBuscar
    '
    Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
    Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
    Me.btnBuscar.Text = "Buscar"
    '
    'HGFiltro
    '
    Me.HGFiltro.AutoSize = True
    Me.HGFiltro.Dock = System.Windows.Forms.DockStyle.Top
    Me.HGFiltro.HeaderVisibleSecondary = False
    Me.HGFiltro.Location = New System.Drawing.Point(0, 0)
    Me.HGFiltro.Name = "HGFiltro"
    '
    'HGFiltro.Panel
    '
    Me.HGFiltro.Panel.AutoScroll = True
    Me.HGFiltro.Panel.Controls.Add(Me.txtFiltro)
    Me.HGFiltro.Panel.Controls.Add(Me.KryptonLabel1)
    Me.HGFiltro.Size = New System.Drawing.Size(1156, 70)
    Me.HGFiltro.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.HGFiltro.TabIndex = 0
    Me.HGFiltro.Text = "Filtro"
    Me.HGFiltro.ValuesPrimary.Description = ""
    Me.HGFiltro.ValuesPrimary.Heading = "Filtro"
    Me.HGFiltro.ValuesPrimary.Image = Nothing
    Me.HGFiltro.ValuesSecondary.Description = ""
    Me.HGFiltro.ValuesSecondary.Heading = "Description"
    Me.HGFiltro.ValuesSecondary.Image = Nothing
    '
    'txtFiltro
    '
    Me.txtFiltro.Location = New System.Drawing.Point(164, 19)
    Me.txtFiltro.MaxLength = 50
    Me.txtFiltro.Name = "txtFiltro"
    Me.txtFiltro.Size = New System.Drawing.Size(382, 21)
    Me.txtFiltro.TabIndex = 0
    '
    'KryptonLabel1
    '
    Me.KryptonLabel1.AutoSize = False
    Me.KryptonLabel1.Location = New System.Drawing.Point(20, 13)
    Me.KryptonLabel1.Name = "KryptonLabel1"
    Me.KryptonLabel1.Size = New System.Drawing.Size(126, 36)
    Me.KryptonLabel1.TabIndex = 1
    Me.KryptonLabel1.Text = "Buscar Tipo de Dato"
    Me.KryptonLabel1.Values.ExtraText = ""
    Me.KryptonLabel1.Values.Image = Nothing
    Me.KryptonLabel1.Values.Text = "Buscar Tipo de Dato"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NTPODT"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "NCODRG"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Cod. Detalle"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "TDSCRG"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "SESTRG"
    Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "NTPODT"
    Me.DataGridViewTextBoxColumn5.HeaderText = "Código"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DataGridViewTextBoxColumn6.DataPropertyName = "TDSTPD"
    Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.DataPropertyName = "SESTRG"
    Me.DataGridViewTextBoxColumn7.HeaderText = "Estado"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.DataPropertyName = "QCNTN"
    DataGridViewCellStyle2.Format = "N2"
    DataGridViewCellStyle2.NullValue = "0"
    Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridViewTextBoxColumn8.HeaderText = "Valor"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.DataPropertyName = "SESTRG"
    Me.DataGridViewTextBoxColumn9.HeaderText = "Estado"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    '
    'NTPODT
    '
    Me.NTPODT.DataPropertyName = "NTPODT"
    Me.NTPODT.HeaderText = "Código"
    Me.NTPODT.Name = "NTPODT"
    Me.NTPODT.ReadOnly = True
    '
    'TDSTPD
    '
    Me.TDSTPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TDSTPD.DataPropertyName = "TDSTPD"
    Me.TDSTPD.HeaderText = "Descripción"
    Me.TDSTPD.Name = "TDSTPD"
    Me.TDSTPD.ReadOnly = True
    '
    'SESTRG
    '
    Me.SESTRG.DataPropertyName = "SESTRG"
    Me.SESTRG.HeaderText = "Estado"
    Me.SESTRG.Name = "SESTRG"
    Me.SESTRG.ReadOnly = True
    '
    'NTPODT_1
    '
    Me.NTPODT_1.DataPropertyName = "NTPODT"
    Me.NTPODT_1.HeaderText = "Tipo"
    Me.NTPODT_1.Name = "NTPODT_1"
    Me.NTPODT_1.ReadOnly = True
    '
    'NCODRG_1
    '
    Me.NCODRG_1.DataPropertyName = "NCODRG"
    Me.NCODRG_1.HeaderText = "Cod. Detalle"
    Me.NCODRG_1.Name = "NCODRG_1"
    Me.NCODRG_1.ReadOnly = True
    '
    'TDSCRG_1
    '
    Me.TDSCRG_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.TDSCRG_1.DataPropertyName = "TDSCRG"
    Me.TDSCRG_1.HeaderText = "Descripción"
    Me.TDSCRG_1.Name = "TDSCRG_1"
    Me.TDSCRG_1.ReadOnly = True
    '
    'CCLNT1
    '
    Me.CCLNT1.DataPropertyName = "CCLNT1"
    Me.CCLNT1.HeaderText = "Cliente"
    Me.CCLNT1.Name = "CCLNT1"
    Me.CCLNT1.ReadOnly = True
    '
    'QCNTN
    '
    Me.QCNTN.DataPropertyName = "QCNTN"
    DataGridViewCellStyle1.Format = "N2"
    DataGridViewCellStyle1.NullValue = "0"
    Me.QCNTN.DefaultCellStyle = DataGridViewCellStyle1
    Me.QCNTN.HeaderText = "Valor"
    Me.QCNTN.Name = "QCNTN"
    Me.QCNTN.ReadOnly = True
    '
    'SESTRG_1
    '
    Me.SESTRG_1.DataPropertyName = "SESTRG"
    Me.SESTRG_1.HeaderText = "Estado"
    Me.SESTRG_1.Name = "SESTRG_1"
    Me.SESTRG_1.ReadOnly = True
    '
    'frmMantenimientoTipoDato
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1156, 696)
    Me.Controls.Add(Me.KryptonPanel)
    Me.Name = "frmMantenimientoTipoDato"
    Me.Text = "Mantenimiento de Tipo de Datos"
    CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonPanel.ResumeLayout(False)
    Me.KryptonPanel.PerformLayout()
    CType(Me.HGDetalle.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGDetalle.Panel.ResumeLayout(False)
    CType(Me.HGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGDetalle.ResumeLayout(False)
    CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
    CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
    Me.KryptonSplitContainer1.Panel2.PerformLayout()
    CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonSplitContainer1.ResumeLayout(False)
    CType(Me.dtgTipoDato, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.tabTipoDato.ResumeLayout(False)
    Me.tabTipoDato.PerformLayout()
    Me.tabDetalle.ResumeLayout(False)
    CType(Me.dtgTipoDatoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    CType(Me.HGFiltro.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGFiltro.Panel.ResumeLayout(False)
    Me.HGFiltro.Panel.PerformLayout()
    CType(Me.HGFiltro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HGFiltro.ResumeLayout(False)
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
  Friend WithEvents HGDetalle As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents txtFiltro As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents dtgTipoDato As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents NTPODT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TDSTPD As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SESTRG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents tabTipoDato As System.Windows.Forms.TabPage
  Friend WithEvents txtDescripcionTipoDato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCodigoTipoDato As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents tabDetalle As System.Windows.Forms.TabPage
  Friend WithEvents dtgTipoDatoDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents NTPODT_1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents NCODRG_1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TDSCRG_1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents CCLNT1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents QCNTN As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SESTRG_1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
