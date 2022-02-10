<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarPreDoc
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer2 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.HeaderDatos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.btnAnulLib = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bntLibPL = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer4 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.txtPL = New System.Windows.Forms.TextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnEliminarPDoc = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtgPreDocumentos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.NRCTRL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_ESTADO_PL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_ESTADO_PL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPDCPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPCTRL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIP_DOC_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SBCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_DOC_FACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_DOC_FACT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERACION = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VLRFDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMPDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPLNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SESTOP_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCPRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPRLQD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NSECFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSGNMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVLSRV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABTPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NDCMFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgOpPendientes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CHK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ADETDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PDETDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGVDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPRCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FAJIMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESC_FAJIMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNIMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPOPER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUITR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NGUIRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRRGU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRROP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDVSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPLNDV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSRVC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMNDA1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotalG = New System.Windows.Forms.TextBox()
        Me.lblMonto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMontoPend = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.cblTipo = New System.Windows.Forms.ComboBox()
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTotalSeleccionado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTotalS = New System.Windows.Forms.TextBox()
        Me.MenuBar = New System.Windows.Forms.ToolStrip()
        Me.btnGenerar = New System.Windows.Forms.ToolStripButton()
        Me.btnQuitar = New System.Windows.Forms.ToolStripButton()
        Me.btnAdicionar = New System.Windows.Forms.ToolStripButton()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.SuspendLayout()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer2.SuspendLayout()
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderDatos.Panel.SuspendLayout()
        Me.HeaderDatos.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        CType(Me.KryptonSplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer4.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer4.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer4.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer4.Panel2.SuspendLayout()
        Me.KryptonSplitContainer4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgPreDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgOpPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1273, 772)
        Me.KryptonPanel.TabIndex = 1
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonSplitContainer2)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1273, 772)
        Me.KryptonSplitContainer1.SplitterDistance = 370
        Me.KryptonSplitContainer1.TabIndex = 3
        '
        'KryptonSplitContainer2
        '
        Me.KryptonSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer2.Name = "KryptonSplitContainer2"
        Me.KryptonSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.KryptonSplitContainer2.Size = New System.Drawing.Size(1273, 370)
        Me.KryptonSplitContainer2.SplitterDistance = 39
        Me.KryptonSplitContainer2.TabIndex = 4
        '
        'HeaderDatos
        '
        Me.HeaderDatos.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnAnulLib, Me.bntLibPL, Me.btnCancelar})
        Me.HeaderDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderDatos.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HeaderDatos.HeaderVisibleSecondary = False
        Me.HeaderDatos.Location = New System.Drawing.Point(0, 0)
        Me.HeaderDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.HeaderDatos.Name = "HeaderDatos"
        '
        'HeaderDatos.Panel
        '
        Me.HeaderDatos.Panel.Controls.Add(Me.KryptonPanel1)
        Me.HeaderDatos.Size = New System.Drawing.Size(1273, 772)
        Me.HeaderDatos.TabIndex = 108
        Me.HeaderDatos.ValuesPrimary.Description = ""
        Me.HeaderDatos.ValuesPrimary.Heading = ""
        Me.HeaderDatos.ValuesPrimary.Image = Nothing
        Me.HeaderDatos.ValuesSecondary.Description = ""
        Me.HeaderDatos.ValuesSecondary.Heading = "Description"
        Me.HeaderDatos.ValuesSecondary.Image = Nothing
        '
        'btnAnulLib
        '
        Me.btnAnulLib.ExtraText = ""
        Me.btnAnulLib.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.db_remove1
        Me.btnAnulLib.Text = "Anular Liberación"
        Me.btnAnulLib.ToolTipImage = Nothing
        Me.btnAnulLib.UniqueName = "FF61E4E0B9BF4D7DFF61E4E0B9BF4D7D"
        '
        'bntLibPL
        '
        Me.bntLibPL.ExtraText = ""
        Me.bntLibPL.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.cell_layout
        Me.bntLibPL.Text = "Liberar PL"
        Me.bntLibPL.ToolTipImage = Nothing
        Me.bntLibPL.UniqueName = "5C51412667A44D255C51412667A44D25"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "3E594715767047333E59471576704733"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonSplitContainer3)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1271, 739)
        Me.KryptonPanel1.TabIndex = 2
        '
        'KryptonSplitContainer3
        '
        Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
        Me.KryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer3.Panel1
        '
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.KryptonSplitContainer4)
        '
        'KryptonSplitContainer3.Panel2
        '
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.dtgOpPendientes)
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.Panel1)
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.MenuBar)
        Me.KryptonSplitContainer3.Size = New System.Drawing.Size(1271, 739)
        Me.KryptonSplitContainer3.SplitterDistance = 277
        Me.KryptonSplitContainer3.TabIndex = 3
        '
        'KryptonSplitContainer4
        '
        Me.KryptonSplitContainer4.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonSplitContainer4.Name = "KryptonSplitContainer4"
        Me.KryptonSplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer4.Panel1
        '
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.cmbMoneda)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.txtPL)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.txtEstado)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonSplitContainer4.Panel1.Controls.Add(Me.KryptonLabel2)
        '
        'KryptonSplitContainer4.Panel2
        '
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.ToolStrip1)
        Me.KryptonSplitContainer4.Panel2.Controls.Add(Me.TabControl1)
        Me.KryptonSplitContainer4.Size = New System.Drawing.Size(1271, 277)
        Me.KryptonSplitContainer4.SplitterDistance = 47
        Me.KryptonSplitContainer4.TabIndex = 4
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(311, 10)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(176, 24)
        Me.cmbMoneda.TabIndex = 21
        '
        'txtPL
        '
        Me.txtPL.BackColor = System.Drawing.SystemColors.Window
        Me.txtPL.Enabled = False
        Me.txtPL.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPL.Location = New System.Drawing.Point(56, 12)
        Me.txtPL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPL.MaxLength = 10
        Me.txtPL.Name = "txtPL"
        Me.txtPL.Size = New System.Drawing.Size(161, 22)
        Me.txtPL.TabIndex = 20
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(9, 10)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(35, 24)
        Me.KryptonLabel4.TabIndex = 19
        Me.KryptonLabel4.Text = "PL :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "PL :"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstado.Enabled = False
        Me.txtEstado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtEstado.Location = New System.Drawing.Point(591, 12)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.MaxLength = 10
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(169, 22)
        Me.txtEstado.TabIndex = 18
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(517, 10)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(57, 24)
        Me.KryptonLabel3.TabIndex = 17
        Me.KryptonLabel3.Text = "Estado"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Estado"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(236, 10)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(68, 24)
        Me.KryptonLabel2.TabIndex = 15
        Me.KryptonLabel2.Text = "Moneda"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Moneda"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.btnEliminarPDoc, Me.btnEditar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1271, 27)
        Me.ToolStrip1.TabIndex = 74
        Me.ToolStrip1.TabStop = True
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(120, 24)
        Me.ToolStripLabel2.Text = "Pre-Documentos"
        '
        'btnEliminarPDoc
        '
        Me.btnEliminarPDoc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEliminarPDoc.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel
        Me.btnEliminarPDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarPDoc.Name = "btnEliminarPDoc"
        Me.btnEliminarPDoc.Size = New System.Drawing.Size(118, 24)
        Me.btnEliminarPDoc.Text = "Eliminar Doc"
        '
        'btnEditar
        '
        Me.btnEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnEditar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(103, 24)
        Me.btnEditar.Text = "Editar Doc"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1271, 225)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtgPreDocumentos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1263, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Operaciones asignadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtgPreDocumentos
        '
        Me.dtgPreDocumentos.AllowUserToAddRows = False
        Me.dtgPreDocumentos.AllowUserToDeleteRows = False
        Me.dtgPreDocumentos.AllowUserToResizeColumns = False
        Me.dtgPreDocumentos.AllowUserToResizeRows = False
        Me.dtgPreDocumentos.ColumnHeadersHeight = 25
        Me.dtgPreDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPreDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NRCTRL, Me.DESC_ESTADO_PL, Me.COD_ESTADO_PL, Me.TPDCPE, Me.TPCTRL, Me.NCRRPD, Me.ID_MONEDA, Me.DESC_MONEDA, Me.IMPORTE, Me.TIP_DOC_CLIENTE, Me.DCCLNT, Me.SBCLNT, Me.TIPO_DOC_FACT, Me.NRO_DOC_FACT, Me.OPERACION, Me.VLRFDT, Me.Column2, Me.TCMPDV, Me.TPLNTA, Me.SESTOP_DESC, Me.NDCPRF, Me.NPRLQD, Me.NSECFC, Me.TCMTRF, Me.TSGNMN, Me.IVLSRV, Me.TABTPD, Me.NDCMFC})
        Me.dtgPreDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgPreDocumentos.Location = New System.Drawing.Point(4, 4)
        Me.dtgPreDocumentos.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgPreDocumentos.Name = "dtgPreDocumentos"
        Me.dtgPreDocumentos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgPreDocumentos.RowHeadersVisible = False
        Me.dtgPreDocumentos.RowHeadersWidth = 20
        Me.dtgPreDocumentos.Size = New System.Drawing.Size(1255, 188)
        Me.dtgPreDocumentos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPreDocumentos.TabIndex = 20
        Me.dtgPreDocumentos.TabStop = False
        '
        'NRCTRL
        '
        Me.NRCTRL.DataPropertyName = "NRCTRL"
        Me.NRCTRL.HeaderText = "NRCTRL"
        Me.NRCTRL.Name = "NRCTRL"
        Me.NRCTRL.Visible = False
        '
        'DESC_ESTADO_PL
        '
        Me.DESC_ESTADO_PL.DataPropertyName = "DESC_ESTADO_PL "
        Me.DESC_ESTADO_PL.HeaderText = "DESC_ESTADO_PL "
        Me.DESC_ESTADO_PL.Name = "DESC_ESTADO_PL"
        Me.DESC_ESTADO_PL.Visible = False
        '
        'COD_ESTADO_PL
        '
        Me.COD_ESTADO_PL.DataPropertyName = "COD_ESTADO_PL"
        Me.COD_ESTADO_PL.HeaderText = "COD_ESTADO_PL"
        Me.COD_ESTADO_PL.Name = "COD_ESTADO_PL"
        Me.COD_ESTADO_PL.Visible = False
        '
        'TPDCPE
        '
        Me.TPDCPE.DataPropertyName = "TPDCPE"
        Me.TPDCPE.HeaderText = "TPDCPE"
        Me.TPDCPE.Name = "TPDCPE"
        Me.TPDCPE.Visible = False
        '
        'TPCTRL
        '
        Me.TPCTRL.DataPropertyName = "TPCTRL"
        Me.TPCTRL.HeaderText = "TPCTRL"
        Me.TPCTRL.Name = "TPCTRL"
        Me.TPCTRL.Visible = False
        '
        'NCRRPD
        '
        Me.NCRRPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCRRPD.DataPropertyName = "NCRRPD"
        Me.NCRRPD.HeaderText = "Id Pre-Doc"
        Me.NCRRPD.Name = "NCRRPD"
        Me.NCRRPD.ReadOnly = True
        Me.NCRRPD.Width = 113
        '
        'ID_MONEDA
        '
        Me.ID_MONEDA.DataPropertyName = "ID_MONEDA"
        Me.ID_MONEDA.HeaderText = "ID_MONEDA"
        Me.ID_MONEDA.Name = "ID_MONEDA"
        Me.ID_MONEDA.Visible = False
        '
        'DESC_MONEDA
        '
        Me.DESC_MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_MONEDA.DataPropertyName = "DESC_MONEDA"
        Me.DESC_MONEDA.HeaderText = "Moneda"
        Me.DESC_MONEDA.Name = "DESC_MONEDA"
        Me.DESC_MONEDA.ReadOnly = True
        Me.DESC_MONEDA.Width = 97
        '
        'IMPORTE
        '
        Me.IMPORTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPORTE.DataPropertyName = "IMPORTE"
        Me.IMPORTE.HeaderText = "Importe"
        Me.IMPORTE.Name = "IMPORTE"
        Me.IMPORTE.ReadOnly = True
        Me.IMPORTE.Width = 95
        '
        'TIP_DOC_CLIENTE
        '
        Me.TIP_DOC_CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIP_DOC_CLIENTE.DataPropertyName = "TIP_DOC_CLIENTE"
        Me.TIP_DOC_CLIENTE.HeaderText = "Tipo Doc Cliente"
        Me.TIP_DOC_CLIENTE.Name = "TIP_DOC_CLIENTE"
        Me.TIP_DOC_CLIENTE.ReadOnly = True
        Me.TIP_DOC_CLIENTE.Width = 153
        '
        'DCCLNT
        '
        Me.DCCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DCCLNT.DataPropertyName = "DCCLNT"
        Me.DCCLNT.HeaderText = "Doc. Cliente"
        Me.DCCLNT.Name = "DCCLNT"
        Me.DCCLNT.ReadOnly = True
        Me.DCCLNT.Width = 122
        '
        'SBCLNT
        '
        Me.SBCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SBCLNT.DataPropertyName = "SBCLNT"
        Me.SBCLNT.HeaderText = "Sub Doc Cliente"
        Me.SBCLNT.Name = "SBCLNT"
        Me.SBCLNT.ReadOnly = True
        Me.SBCLNT.Visible = False
        Me.SBCLNT.Width = 148
        '
        'TIPO_DOC_FACT
        '
        Me.TIPO_DOC_FACT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_DOC_FACT.DataPropertyName = "TIPO_DOC_FACT"
        Me.TIPO_DOC_FACT.HeaderText = "Tipo Doc Fact"
        Me.TIPO_DOC_FACT.Name = "TIPO_DOC_FACT"
        Me.TIPO_DOC_FACT.ReadOnly = True
        Me.TIPO_DOC_FACT.Width = 133
        '
        'NRO_DOC_FACT
        '
        Me.NRO_DOC_FACT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NRO_DOC_FACT.DataPropertyName = "NRO_DOC_FACT"
        Me.NRO_DOC_FACT.HeaderText = "Nro Doc. Fact"
        Me.NRO_DOC_FACT.Name = "NRO_DOC_FACT"
        Me.NRO_DOC_FACT.ReadOnly = True
        Me.NRO_DOC_FACT.Width = 131
        '
        'OPERACION
        '
        Me.OPERACION.DataPropertyName = "OPERACION"
        Me.OPERACION.HeaderText = "Operación"
        Me.OPERACION.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.text_block
        Me.OPERACION.Name = "OPERACION"
        '
        'VLRFDT
        '
        Me.VLRFDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VLRFDT.DataPropertyName = "VLRFDT"
        Me.VLRFDT.HeaderText = "Valor Ref."
        Me.VLRFDT.Name = "VLRFDT"
        Me.VLRFDT.ReadOnly = True
        Me.VLRFDT.Width = 105
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        '
        'TCMPDV
        '
        Me.TCMPDV.DataPropertyName = "División"
        Me.TCMPDV.HeaderText = "TCMPDV"
        Me.TCMPDV.Name = "TCMPDV"
        Me.TCMPDV.Visible = False
        '
        'TPLNTA
        '
        Me.TPLNTA.DataPropertyName = "Planta"
        Me.TPLNTA.HeaderText = "TPLNTA"
        Me.TPLNTA.Name = "TPLNTA"
        Me.TPLNTA.Visible = False
        '
        'SESTOP_DESC
        '
        Me.SESTOP_DESC.DataPropertyName = "Estado OP."
        Me.SESTOP_DESC.HeaderText = "SESTOP_DESC"
        Me.SESTOP_DESC.Name = "SESTOP_DESC"
        Me.SESTOP_DESC.Visible = False
        '
        'NDCPRF
        '
        Me.NDCPRF.DataPropertyName = "Pre-Factura"
        Me.NDCPRF.HeaderText = "NDCPRF"
        Me.NDCPRF.Name = "NDCPRF"
        Me.NDCPRF.Visible = False
        '
        'NPRLQD
        '
        Me.NPRLQD.DataPropertyName = "Pre-Liquidación"
        Me.NPRLQD.HeaderText = "NPRLQD"
        Me.NPRLQD.Name = "NPRLQD"
        Me.NPRLQD.Visible = False
        '
        'NSECFC
        '
        Me.NSECFC.DataPropertyName = "Número Consistencia"
        Me.NSECFC.HeaderText = "NSECFC"
        Me.NSECFC.Name = "NSECFC"
        Me.NSECFC.Visible = False
        '
        'TCMTRF
        '
        Me.TCMTRF.DataPropertyName = "Servicio"
        Me.TCMTRF.HeaderText = "TCMTRF"
        Me.TCMTRF.Name = "TCMTRF"
        Me.TCMTRF.Visible = False
        '
        'TSGNMN
        '
        Me.TSGNMN.DataPropertyName = "Moneda"
        Me.TSGNMN.HeaderText = "TSGNMN"
        Me.TSGNMN.Name = "TSGNMN"
        Me.TSGNMN.Visible = False
        '
        'IVLSRV
        '
        Me.IVLSRV.DataPropertyName = "Importe"
        Me.IVLSRV.HeaderText = "IVLSRV"
        Me.IVLSRV.Name = "IVLSRV"
        Me.IVLSRV.Visible = False
        '
        'TABTPD
        '
        Me.TABTPD.DataPropertyName = "Tipo Doc Fac"
        Me.TABTPD.HeaderText = "TABTPD"
        Me.TABTPD.Name = "TABTPD"
        Me.TABTPD.Visible = False
        '
        'NDCMFC
        '
        Me.NDCMFC.DataPropertyName = "Factura"
        Me.NDCMFC.HeaderText = "NDCMFC"
        Me.NDCMFC.Name = "NDCMFC"
        Me.NDCMFC.Visible = False
        '
        'dtgOpPendientes
        '
        Me.dtgOpPendientes.AllowUserToAddRows = False
        Me.dtgOpPendientes.AllowUserToDeleteRows = False
        Me.dtgOpPendientes.AllowUserToResizeColumns = False
        Me.dtgOpPendientes.AllowUserToResizeRows = False
        Me.dtgOpPendientes.ColumnHeadersHeight = 25
        Me.dtgOpPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgOpPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CHK, Me.ADETDOC, Me.PDETDOC, Me.IGVDOC, Me.NOPRCN, Me.SERVICIO, Me.FAJIMP, Me.DESC_FAJIMP, Me.MONEDA, Me.IMPDOC, Me.PNIMDOC, Me.TPOPER, Me.NGUITR, Me.NGUIRM, Me.NCRRGU, Me.NCRROP, Me.CDVSN, Me.CPLNDV, Me.CSRVC, Me.CMNDA1, Me.CCLNT, Me.Column1})
        Me.dtgOpPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgOpPendientes.Location = New System.Drawing.Point(0, 75)
        Me.dtgOpPendientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgOpPendientes.Name = "dtgOpPendientes"
        Me.dtgOpPendientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.dtgOpPendientes.RowHeadersVisible = False
        Me.dtgOpPendientes.RowHeadersWidth = 20
        Me.dtgOpPendientes.Size = New System.Drawing.Size(1271, 382)
        Me.dtgOpPendientes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgOpPendientes.TabIndex = 85
        Me.dtgOpPendientes.TabStop = False
        '
        'CHK
        '
        Me.CHK.HeaderText = "CHK"
        Me.CHK.Name = "CHK"
        Me.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CHK.Width = 46
        '
        'ADETDOC
        '
        Me.ADETDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ADETDOC.DataPropertyName = "AFECTO_DET"
        Me.ADETDOC.HeaderText = "Afect.Detracción"
        Me.ADETDOC.Name = "ADETDOC"
        Me.ADETDOC.ReadOnly = True
        Me.ADETDOC.Width = 152
        '
        'PDETDOC
        '
        Me.PDETDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PDETDOC.DataPropertyName = "POR_DETRACCION"
        Me.PDETDOC.HeaderText = "%Detracción"
        Me.PDETDOC.Name = "PDETDOC"
        Me.PDETDOC.ReadOnly = True
        Me.PDETDOC.Width = 126
        '
        'IGVDOC
        '
        Me.IGVDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IGVDOC.DataPropertyName = "PIGVA"
        Me.IGVDOC.HeaderText = "IGV"
        Me.IGVDOC.Name = "IGVDOC"
        Me.IGVDOC.ReadOnly = True
        Me.IGVDOC.Width = 65
        '
        'NOPRCN
        '
        Me.NOPRCN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOPRCN.DataPropertyName = "NOPRCN"
        Me.NOPRCN.HeaderText = "Operación"
        Me.NOPRCN.Name = "NOPRCN"
        Me.NOPRCN.ReadOnly = True
        Me.NOPRCN.Width = 111
        '
        'SERVICIO
        '
        Me.SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SERVICIO.DataPropertyName = "SERVICIO"
        Me.SERVICIO.HeaderText = "Servicio"
        Me.SERVICIO.Name = "SERVICIO"
        Me.SERVICIO.ReadOnly = True
        Me.SERVICIO.Width = 94
        '
        'FAJIMP
        '
        Me.FAJIMP.DataPropertyName = "FAJIMP"
        Me.FAJIMP.HeaderText = "FlagAjuste"
        Me.FAJIMP.Name = "FAJIMP"
        Me.FAJIMP.Visible = False
        '
        'DESC_FAJIMP
        '
        Me.DESC_FAJIMP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESC_FAJIMP.DataPropertyName = "DESC_FAJIMP"
        Me.DESC_FAJIMP.HeaderText = "Tipo"
        Me.DESC_FAJIMP.Name = "DESC_FAJIMP"
        Me.DESC_FAJIMP.ReadOnly = True
        Me.DESC_FAJIMP.Width = 72
        '
        'MONEDA
        '
        Me.MONEDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA.DataPropertyName = "MONEDA"
        Me.MONEDA.HeaderText = "Moneda"
        Me.MONEDA.Name = "MONEDA"
        Me.MONEDA.ReadOnly = True
        Me.MONEDA.Width = 97
        '
        'IMPDOC
        '
        Me.IMPDOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMPDOC.DataPropertyName = "IMPORTE_PENDTE"
        Me.IMPDOC.HeaderText = "Imp. Pendiente"
        Me.IMPDOC.Name = "IMPDOC"
        Me.IMPDOC.ReadOnly = True
        Me.IMPDOC.Width = 140
        '
        'PNIMDOC
        '
        Me.PNIMDOC.DataPropertyName = "PNIMDOC"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PNIMDOC.DefaultCellStyle = DataGridViewCellStyle1
        Me.PNIMDOC.HeaderText = "Importe Doc"
        Me.PNIMDOC.Name = "PNIMDOC"
        Me.PNIMDOC.ReadOnly = True
        '
        'TPOPER
        '
        Me.TPOPER.DataPropertyName = "TPOPER"
        Me.TPOPER.HeaderText = "TPOPER"
        Me.TPOPER.Name = "TPOPER"
        Me.TPOPER.Visible = False
        '
        'NGUITR
        '
        Me.NGUITR.DataPropertyName = "NGUITR"
        Me.NGUITR.HeaderText = "NGUITR"
        Me.NGUITR.Name = "NGUITR"
        Me.NGUITR.Visible = False
        '
        'NGUIRM
        '
        Me.NGUIRM.DataPropertyName = "NGUIRM"
        Me.NGUIRM.HeaderText = "NGUIRM"
        Me.NGUIRM.Name = "NGUIRM"
        Me.NGUIRM.Visible = False
        '
        'NCRRGU
        '
        Me.NCRRGU.DataPropertyName = "NCRRGU"
        Me.NCRRGU.HeaderText = "NCRRGU"
        Me.NCRRGU.Name = "NCRRGU"
        Me.NCRRGU.Visible = False
        '
        'NCRROP
        '
        Me.NCRROP.DataPropertyName = "NCRROP"
        Me.NCRROP.HeaderText = "NCRROP"
        Me.NCRROP.Name = "NCRROP"
        Me.NCRROP.Visible = False
        '
        'CDVSN
        '
        Me.CDVSN.DataPropertyName = "CDVSN"
        Me.CDVSN.HeaderText = "CDVSN"
        Me.CDVSN.Name = "CDVSN"
        Me.CDVSN.Visible = False
        '
        'CPLNDV
        '
        Me.CPLNDV.DataPropertyName = "CPLNDV"
        Me.CPLNDV.HeaderText = "CPLNDV"
        Me.CPLNDV.Name = "CPLNDV"
        Me.CPLNDV.Visible = False
        '
        'CSRVC
        '
        Me.CSRVC.DataPropertyName = "CSRVC"
        Me.CSRVC.HeaderText = "CSRVC"
        Me.CSRVC.Name = "CSRVC"
        Me.CSRVC.Visible = False
        '
        'CMNDA1
        '
        Me.CMNDA1.DataPropertyName = "ID_MON_IMPORTE"
        Me.CMNDA1.HeaderText = "CMNDA1"
        Me.CMNDA1.Name = "CMNDA1"
        Me.CMNDA1.Visible = False
        '
        'CCLNT
        '
        Me.CCLNT.DataPropertyName = "CCLNT"
        Me.CCLNT.HeaderText = "CCLNT"
        Me.CCLNT.Name = "CCLNT"
        Me.CCLNT.ReadOnly = True
        Me.CCLNT.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTotalG)
        Me.Panel1.Controls.Add(Me.lblMonto)
        Me.Panel1.Controls.Add(Me.txtMontoPend)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.cblTipo)
        Me.Panel1.Controls.Add(Me.lblMoneda)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblTotalSeleccionado)
        Me.Panel1.Controls.Add(Me.txtTotalS)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1271, 48)
        Me.Panel1.TabIndex = 84
        '
        'txtTotalG
        '
        Me.txtTotalG.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalG.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalG.Location = New System.Drawing.Point(387, 16)
        Me.txtTotalG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalG.MaxLength = 10
        Me.txtTotalG.Name = "txtTotalG"
        Me.txtTotalG.Size = New System.Drawing.Size(127, 22)
        Me.txtTotalG.TabIndex = 89
        Me.txtTotalG.WordWrap = False
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(512, 14)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(105, 24)
        Me.lblMonto.TabIndex = 88
        Me.lblMonto.Text = "Monto. Pndte"
        Me.lblMonto.Values.ExtraText = ""
        Me.lblMonto.Values.Image = Nothing
        Me.lblMonto.Values.Text = "Monto. Pndte"
        Me.lblMonto.Visible = False
        '
        'txtMontoPend
        '
        Me.txtMontoPend.BackColor = System.Drawing.SystemColors.Window
        Me.txtMontoPend.Enabled = False
        Me.txtMontoPend.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtMontoPend.Location = New System.Drawing.Point(665, 15)
        Me.txtMontoPend.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMontoPend.MaxLength = 10
        Me.txtMontoPend.Name = "txtMontoPend"
        Me.txtMontoPend.ReadOnly = True
        Me.txtMontoPend.Size = New System.Drawing.Size(119, 22)
        Me.txtMontoPend.TabIndex = 87
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(13, 14)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(69, 17)
        Me.lblTipo.TabIndex = 86
        Me.lblTipo.Text = "Tipo Doc:"
        '
        'cblTipo
        '
        Me.cblTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblTipo.FormattingEnabled = True
        Me.cblTipo.Location = New System.Drawing.Point(93, 11)
        Me.cblTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cblTipo.Name = "cblTipo"
        Me.cblTipo.Size = New System.Drawing.Size(135, 24)
        Me.cblTipo.TabIndex = 85
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(633, 14)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(85, 24)
        Me.lblMoneda.TabIndex = 84
        Me.lblMoneda.Text = "lblMoneda"
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "lblMoneda"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(259, 15)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(128, 24)
        Me.lblTotal.TabIndex = 82
        Me.lblTotal.Text = "Monto a Generar"
        Me.lblTotal.Values.ExtraText = ""
        Me.lblTotal.Values.Image = Nothing
        Me.lblTotal.Values.Text = "Monto a Generar"
        Me.lblTotal.Visible = False
        '
        'lblTotalSeleccionado
        '
        Me.lblTotalSeleccionado.Location = New System.Drawing.Point(835, 11)
        Me.lblTotalSeleccionado.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotalSeleccionado.Name = "lblTotalSeleccionado"
        Me.lblTotalSeleccionado.Size = New System.Drawing.Size(140, 24)
        Me.lblTotalSeleccionado.TabIndex = 78
        Me.lblTotalSeleccionado.Text = "Total Seleccionado"
        Me.lblTotalSeleccionado.Values.ExtraText = ""
        Me.lblTotalSeleccionado.Values.Image = Nothing
        Me.lblTotalSeleccionado.Values.Text = "Total Seleccionado"
        '
        'txtTotalS
        '
        Me.txtTotalS.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotalS.Enabled = False
        Me.txtTotalS.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalS.Location = New System.Drawing.Point(993, 12)
        Me.txtTotalS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalS.MaxLength = 10
        Me.txtTotalS.Name = "txtTotalS"
        Me.txtTotalS.ReadOnly = True
        Me.txtTotalS.Size = New System.Drawing.Size(140, 22)
        Me.txtTotalS.TabIndex = 77
        '
        'MenuBar
        '
        Me.MenuBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MenuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGenerar, Me.btnQuitar, Me.btnAdicionar})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(1271, 27)
        Me.MenuBar.TabIndex = 74
        Me.MenuBar.TabStop = True
        Me.MenuBar.Text = "ToolStrip1"
        '
        'btnGenerar
        '
        Me.btnGenerar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGenerar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_ok
        Me.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(85, 24)
        Me.btnGenerar.Text = "Generar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuitar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.button_cancel1
        Me.btnQuitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(119, 24)
        Me.btnQuitar.Text = "Quitar Ajuste"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdicionar.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.edit_add
        Me.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(74, 24)
        Me.btnAdicionar.Text = "Ajuste"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NRCTRL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NRCTRL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TPCTRL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NCRRPD"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Doc-RefO/C"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID_MONEDA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ref.Documento Cab."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AFECTO_DET"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Afect.Detracción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "POR_DETRACCION"
        Me.DataGridViewTextBoxColumn6.HeaderText = "%Detracción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PIGVA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IGV"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Operacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MONEDA"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IMPORTE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "AFECTO_DET"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn12.HeaderText = "ImporteDocumento"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "POR_DETRACCION"
        Me.DataGridViewTextBoxColumn13.HeaderText = "%Detracción"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PIGVA"
        Me.DataGridViewTextBoxColumn14.HeaderText = "IGV"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "NOPRCN"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Operacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "SERVICIO"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "MONEDA"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "IMPORTE"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PNIMDOC"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn19.HeaderText = "ImporteDocumento"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TPOPER"
        Me.DataGridViewTextBoxColumn20.HeaderText = "TPOPER"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "NGUITR"
        Me.DataGridViewTextBoxColumn21.HeaderText = "NGUITR"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "NGUIRM"
        Me.DataGridViewTextBoxColumn22.HeaderText = "NGUIRM"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "NCRRGU"
        Me.DataGridViewTextBoxColumn23.HeaderText = "NCRRGU"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NCRROP"
        Me.DataGridViewTextBoxColumn24.HeaderText = "NCRROP"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "CDVSN"
        Me.DataGridViewTextBoxColumn25.HeaderText = "CDVSN"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CPLNDV"
        Me.DataGridViewTextBoxColumn26.HeaderText = "CPLNDV"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CSRVC"
        Me.DataGridViewTextBoxColumn27.HeaderText = "CSRVC"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "ID_MON_IMPORTE"
        Me.DataGridViewTextBoxColumn28.HeaderText = "CMNDA1"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "OPERACION"
        Me.DataGridViewImageColumn1.HeaderText = "Operación"
        Me.DataGridViewImageColumn1.Image = Global.Ransa.Controls.ServicioOperacion.My.Resources.Resources.text_block
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'frmGenerarPreDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 772)
        Me.Controls.Add(Me.HeaderDatos)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmGenerarPreDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Pre-Documentos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer2.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer2.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer2.ResumeLayout(False)
        CType(Me.HeaderDatos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.Panel.ResumeLayout(False)
        CType(Me.HeaderDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderDatos.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        CType(Me.KryptonSplitContainer4.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer4.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer4.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer4.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer4.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer4.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer4.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dtgPreDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgOpPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer2 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HeaderDatos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer4 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnEliminarPDoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MenuBar As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGenerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bntLibPL As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnQuitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdicionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPL As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgOpPendientes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents cblTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTotalSeleccionado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTotalS As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoPend As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalG As System.Windows.Forms.TextBox
    Friend WithEvents lblMonto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Public WithEvents dtgPreDocumentos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents CHK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ADETDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PDETDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IGVDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPRCN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FAJIMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_FAJIMP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNIMDOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPOPER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUITR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NGUIRM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRGU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRROP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDVSN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPLNDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSRVC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMNDA1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRCTRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_ESTADO_PL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_ESTADO_PL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPDCPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPCTRL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRRPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESC_MONEDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIP_DOC_CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SBCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_DOC_FACT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRO_DOC_FACT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OPERACION As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents VLRFDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMPDV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPLNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SESTOP_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCPRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NPRLQD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSECFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TSGNMN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVLSRV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABTPD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NDCMFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAnulLib As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
End Class
