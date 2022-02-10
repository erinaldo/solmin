<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDimensiones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgvDimensiones = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView
        Me.CCMPN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMREQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NCRREQT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TDITES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QMTLRG_D = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QMTANC_D = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QMTALT_D = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPESO_D = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtPeso = New Ransa.Utilitario.clsTextBoxNumero
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtAncho = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtAlto = New Ransa.Utilitario.clsTextBoxNumero
        Me.txtLargo = New Ransa.Utilitario.clsTextBoxNumero
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnModificar = New System.Windows.Forms.ToolStripButton
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvDimensiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.SplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(664, 311)
        Me.KryptonPanel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDimensiones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtPeso)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDescripcion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtAncho)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtAlto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtLargo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.KryptonLabel15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer1.Size = New System.Drawing.Size(664, 311)
        Me.SplitContainer1.SplitterDistance = 173
        Me.SplitContainer1.TabIndex = 1
        '
        'dgvDimensiones
        '
        Me.dgvDimensiones.AllowUserToAddRows = False
        Me.dgvDimensiones.AllowUserToDeleteRows = False
        Me.dgvDimensiones.AllowUserToOrderColumns = True
        Me.dgvDimensiones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDimensiones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvDimensiones.ColumnHeadersHeight = 30
        Me.dgvDimensiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDimensiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CCMPN, Me.NUMREQT, Me.NCRREQT, Me.TDITES, Me.QMTLRG_D, Me.QMTANC_D, Me.QMTALT_D, Me.QPESO_D})
        Me.dgvDimensiones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDimensiones.Location = New System.Drawing.Point(0, 25)
        Me.dgvDimensiones.MultiSelect = False
        Me.dgvDimensiones.Name = "dgvDimensiones"
        Me.dgvDimensiones.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dgvDimensiones.ReadOnly = True
        Me.dgvDimensiones.RowHeadersWidth = 10
        Me.dgvDimensiones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDimensiones.RowTemplate.Height = 16
        Me.dgvDimensiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDimensiones.Size = New System.Drawing.Size(664, 148)
        Me.dgvDimensiones.StandardTab = True
        Me.dgvDimensiones.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvDimensiones.TabIndex = 9
        '
        'CCMPN
        '
        Me.CCMPN.DataPropertyName = "CCMPN"
        Me.CCMPN.HeaderText = "CCMPN"
        Me.CCMPN.Name = "CCMPN"
        Me.CCMPN.ReadOnly = True
        Me.CCMPN.Visible = False
        '
        'NUMREQT
        '
        Me.NUMREQT.DataPropertyName = "NUMREQT"
        Me.NUMREQT.HeaderText = "NUMREQT"
        Me.NUMREQT.Name = "NUMREQT"
        Me.NUMREQT.ReadOnly = True
        Me.NUMREQT.Visible = False
        '
        'NCRREQT
        '
        Me.NCRREQT.DataPropertyName = "NCRREQT"
        Me.NCRREQT.HeaderText = "NCRREQT"
        Me.NCRREQT.Name = "NCRREQT"
        Me.NCRREQT.ReadOnly = True
        Me.NCRREQT.Visible = False
        '
        'TDITES
        '
        Me.TDITES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TDITES.DataPropertyName = "TDITES"
        Me.TDITES.HeaderText = "Descripción"
        Me.TDITES.MinimumWidth = 100
        Me.TDITES.Name = "TDITES"
        Me.TDITES.ReadOnly = True
        '
        'QMTLRG_D
        '
        Me.QMTLRG_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QMTLRG_D.DataPropertyName = "QMTLRG"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QMTLRG_D.DefaultCellStyle = DataGridViewCellStyle1
        Me.QMTLRG_D.HeaderText = "Largo(m)"
        Me.QMTLRG_D.MinimumWidth = 50
        Me.QMTLRG_D.Name = "QMTLRG_D"
        Me.QMTLRG_D.ReadOnly = True
        Me.QMTLRG_D.Width = 85
        '
        'QMTANC_D
        '
        Me.QMTANC_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QMTANC_D.DataPropertyName = "QMTANC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QMTANC_D.DefaultCellStyle = DataGridViewCellStyle2
        Me.QMTANC_D.HeaderText = "Ancho(m)"
        Me.QMTANC_D.MinimumWidth = 50
        Me.QMTANC_D.Name = "QMTANC_D"
        Me.QMTANC_D.ReadOnly = True
        Me.QMTANC_D.Width = 90
        '
        'QMTALT_D
        '
        Me.QMTALT_D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QMTALT_D.DataPropertyName = "QMTALT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QMTALT_D.DefaultCellStyle = DataGridViewCellStyle3
        Me.QMTALT_D.HeaderText = "Alto(m)"
        Me.QMTALT_D.MinimumWidth = 50
        Me.QMTALT_D.Name = "QMTALT_D"
        Me.QMTALT_D.ReadOnly = True
        Me.QMTALT_D.Width = 77
        '
        'QPESO_D
        '
        Me.QPESO_D.DataPropertyName = "QPESO"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.QPESO_D.DefaultCellStyle = DataGridViewCellStyle4
        Me.QPESO_D.HeaderText = "Peso(Kg)"
        Me.QPESO_D.Name = "QPESO_D"
        Me.QPESO_D.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(664, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripLabel1.Text = "Información de medidas"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(562, 89)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.NUMDECIMALES = 5
        Me.txtPeso.NUMENTEROS = 10
        Me.txtPeso.Size = New System.Drawing.Size(84, 20)
        Me.txtPeso.TabIndex = 9
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(500, 89)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(61, 20)
        Me.KryptonLabel4.TabIndex = 8
        Me.KryptonLabel4.Text = "Peso(Kg):"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Peso(Kg):"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 47)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(550, 22)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtAncho
        '
        Me.txtAncho.Location = New System.Drawing.Point(254, 89)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.NUMDECIMALES = 2
        Me.txtAncho.NUMENTEROS = 5
        Me.txtAncho.Size = New System.Drawing.Size(81, 20)
        Me.txtAncho.TabIndex = 5
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAlto
        '
        Me.txtAlto.Location = New System.Drawing.Point(406, 89)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.NUMDECIMALES = 2
        Me.txtAlto.NUMENTEROS = 5
        Me.txtAlto.Size = New System.Drawing.Size(84, 20)
        Me.txtAlto.TabIndex = 7
        Me.txtAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLargo
        '
        Me.txtLargo.Location = New System.Drawing.Point(96, 89)
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.NUMDECIMALES = 2
        Me.txtLargo.NUMENTEROS = 5
        Me.txtLargo.Size = New System.Drawing.Size(80, 20)
        Me.txtLargo.TabIndex = 3
        Me.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(186, 89)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Text = "Ancho(m):"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Ancho(m):"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(350, 89)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel1.TabIndex = 6
        Me.KryptonLabel1.Text = "Alto(m):"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Alto(m):"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(19, 47)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Text = "Descripción:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Descripción:"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(19, 89)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(62, 20)
        Me.KryptonLabel15.TabIndex = 2
        Me.KryptonLabel15.Text = "Largo(m):"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Largo(m):"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripSeparator3, Me.btnModificar, Me.btnGuardar, Me.ToolStripSeparator2, Me.btnCancelar, Me.ToolStripSeparator1, Me.btnEliminar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(664, 25)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.db_add
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(78, 22)
        Me.btnModificar.Text = "Modificar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_ok1
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Ransa.Controls.Transporte.My.Resources.Resources.db_remove
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CCMPN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CCMPN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NUMREQT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NUMREQT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NCRREQT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NCRREQT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TDITES"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QMTLRG"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Largo"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QMTALT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Alto"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "QMTANC"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ancho"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "QPESO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Peso(Kg)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'frmDimensiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 311)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmDimensiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medidas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvDimensiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvDimensiones As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAncho As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtAlto As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents txtLargo As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPeso As Ransa.Utilitario.clsTextBoxNumero
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCMPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMREQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRREQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TDITES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QMTLRG_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QMTANC_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QMTALT_D As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QPESO_D As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
