<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoLote
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimientoLote))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.lbl_NRUCPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lbl_TNACPR = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lbl_TPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lbl_CPRVCL = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lbl_NDSDMP = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.v = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtObservacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtFechaProduccion = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtFechaIngreso = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.txtCriterioLote = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.txtProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01()
        Me.txtAyuda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnAyuda = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtNrTurno = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcAyuda3 = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImportVenta = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcAyuda2 = New Ransa.Utilitario.ucAyuda()
        Me.txtDocProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtImportProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.v, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.v.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_NRUCPR
        '
        Me.lbl_NRUCPR.Location = New System.Drawing.Point(424, 224)
        Me.lbl_NRUCPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_NRUCPR.Name = "lbl_NRUCPR"
        Me.lbl_NRUCPR.Size = New System.Drawing.Size(157, 24)
        Me.lbl_NRUCPR.TabIndex = 38
        Me.lbl_NRUCPR.Text = "Nro. Doc. Proveedor :"
        Me.lbl_NRUCPR.Values.ExtraText = ""
        Me.lbl_NRUCPR.Values.Image = Nothing
        Me.lbl_NRUCPR.Values.Text = "Nro. Doc. Proveedor :"
        '
        'lbl_TNACPR
        '
        Me.lbl_TNACPR.Location = New System.Drawing.Point(435, 258)
        Me.lbl_TNACPR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TNACPR.Name = "lbl_TNACPR"
        Me.lbl_TNACPR.Size = New System.Drawing.Size(148, 24)
        Me.lbl_TNACPR.TabIndex = 44
        Me.lbl_TNACPR.Text = "Importe Proveedor :"
        Me.lbl_TNACPR.Values.ExtraText = ""
        Me.lbl_TNACPR.Values.Image = Nothing
        Me.lbl_TNACPR.Values.Text = "Importe Proveedor :"
        '
        'lbl_TPRVCL
        '
        Me.lbl_TPRVCL.Location = New System.Drawing.Point(69, 223)
        Me.lbl_TPRVCL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_TPRVCL.Name = "lbl_TPRVCL"
        Me.lbl_TPRVCL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_TPRVCL.Size = New System.Drawing.Size(89, 24)
        Me.lbl_TPRVCL.TabIndex = 34
        Me.lbl_TPRVCL.Text = "Proveedor :"
        Me.lbl_TPRVCL.Values.ExtraText = ""
        Me.lbl_TPRVCL.Values.Image = Nothing
        Me.lbl_TPRVCL.Values.Text = "Proveedor :"
        '
        'lbl_CPRVCL
        '
        Me.lbl_CPRVCL.Location = New System.Drawing.Point(40, 14)
        Me.lbl_CPRVCL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_CPRVCL.Name = "lbl_CPRVCL"
        Me.lbl_CPRVCL.Size = New System.Drawing.Size(119, 24)
        Me.lbl_CPRVCL.TabIndex = 32
        Me.lbl_CPRVCL.Text = "Orden Servicio :"
        Me.lbl_CPRVCL.Values.ExtraText = ""
        Me.lbl_CPRVCL.Values.Image = Nothing
        Me.lbl_CPRVCL.Values.Text = "Orden Servicio :"
        '
        'lbl_NDSDMP
        '
        Me.lbl_NDSDMP.Location = New System.Drawing.Point(5, 258)
        Me.lbl_NDSDMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_NDSDMP.Name = "lbl_NDSDMP"
        Me.lbl_NDSDMP.Size = New System.Drawing.Size(150, 24)
        Me.lbl_NDSDMP.TabIndex = 40
        Me.lbl_NDSDMP.Text = "Moneda Proveedor :"
        Me.lbl_NDSDMP.Values.ExtraText = ""
        Me.lbl_NDSDMP.Values.Image = Nothing
        Me.lbl_NDSDMP.Values.Text = "Moneda Proveedor :"
        '
        'v
        '
        Me.v.Controls.Add(Me.txtObservacion)
        Me.v.Controls.Add(Me.GroupBox1)
        Me.v.Controls.Add(Me.txtProveedor)
        Me.v.Controls.Add(Me.txtAyuda)
        Me.v.Controls.Add(Me.txtNrTurno)
        Me.v.Controls.Add(Me.KryptonLabel7)
        Me.v.Controls.Add(Me.UcAyuda3)
        Me.v.Controls.Add(Me.KryptonLabel2)
        Me.v.Controls.Add(Me.txtImportVenta)
        Me.v.Controls.Add(Me.KryptonLabel3)
        Me.v.Controls.Add(Me.UcAyuda2)
        Me.v.Controls.Add(Me.txtDocProveedor)
        Me.v.Controls.Add(Me.KryptonLabel1)
        Me.v.Controls.Add(Me.lbl_NDSDMP)
        Me.v.Controls.Add(Me.lbl_CPRVCL)
        Me.v.Controls.Add(Me.lbl_TPRVCL)
        Me.v.Controls.Add(Me.txtImportProveedor)
        Me.v.Controls.Add(Me.lbl_TNACPR)
        Me.v.Controls.Add(Me.lbl_NRUCPR)
        Me.v.Dock = System.Windows.Forms.DockStyle.Fill
        Me.v.Location = New System.Drawing.Point(0, 27)
        Me.v.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.v.Name = "v"
        Me.v.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm
        Me.v.Size = New System.Drawing.Size(776, 430)
        Me.v.StateCommon.Color1 = System.Drawing.Color.White
        Me.v.TabIndex = 1
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(160, 357)
        Me.txtObservacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservacion.MaxLength = 25
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(603, 26)
        Me.txtObservacion.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbtFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.rbtFechaProduccion)
        Me.GroupBox1.Controls.Add(Me.rbtFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.rbtCriterioLote)
        Me.GroupBox1.Controls.Add(Me.txtCriterioLote)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.dtpFechaProduccion)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(32, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(741, 158)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione"
        '
        'rbtFechaVencimiento
        '
        Me.rbtFechaVencimiento.Location = New System.Drawing.Point(48, 116)
        Me.rbtFechaVencimiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtFechaVencimiento.Name = "rbtFechaVencimiento"
        Me.rbtFechaVencimiento.Size = New System.Drawing.Size(156, 24)
        Me.rbtFechaVencimiento.TabIndex = 108
        Me.rbtFechaVencimiento.Text = "Fecha Vencimiento:"
        Me.rbtFechaVencimiento.Values.ExtraText = ""
        Me.rbtFechaVencimiento.Values.Image = Nothing
        Me.rbtFechaVencimiento.Values.Text = "Fecha Vencimiento:"
        '
        'rbtFechaProduccion
        '
        Me.rbtFechaProduccion.Location = New System.Drawing.Point(48, 85)
        Me.rbtFechaProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtFechaProduccion.Name = "rbtFechaProduccion"
        Me.rbtFechaProduccion.Size = New System.Drawing.Size(156, 24)
        Me.rbtFechaProduccion.TabIndex = 107
        Me.rbtFechaProduccion.Text = "Fecha Producción  :"
        Me.rbtFechaProduccion.Values.ExtraText = ""
        Me.rbtFechaProduccion.Values.Image = Nothing
        Me.rbtFechaProduccion.Values.Text = "Fecha Producción  :"
        '
        'rbtFechaIngreso
        '
        Me.rbtFechaIngreso.Location = New System.Drawing.Point(48, 54)
        Me.rbtFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtFechaIngreso.Name = "rbtFechaIngreso"
        Me.rbtFechaIngreso.Size = New System.Drawing.Size(155, 24)
        Me.rbtFechaIngreso.TabIndex = 106
        Me.rbtFechaIngreso.Text = "Fecha Ingreso        :"
        Me.rbtFechaIngreso.Values.ExtraText = ""
        Me.rbtFechaIngreso.Values.Image = Nothing
        Me.rbtFechaIngreso.Values.Text = "Fecha Ingreso        :"
        '
        'rbtCriterioLote
        '
        Me.rbtCriterioLote.Checked = True
        Me.rbtCriterioLote.Location = New System.Drawing.Point(48, 23)
        Me.rbtCriterioLote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtCriterioLote.Name = "rbtCriterioLote"
        Me.rbtCriterioLote.Size = New System.Drawing.Size(153, 24)
        Me.rbtCriterioLote.TabIndex = 105
        Me.rbtCriterioLote.Text = "Criterio de Lote     :"
        Me.rbtCriterioLote.Values.ExtraText = ""
        Me.rbtCriterioLote.Values.Image = Nothing
        Me.rbtCriterioLote.Values.Text = "Criterio de Lote     :"
        '
        'txtCriterioLote
        '
        Me.txtCriterioLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCriterioLote.Location = New System.Drawing.Point(220, 21)
        Me.txtCriterioLote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCriterioLote.MaxLength = 15
        Me.txtCriterioLote.Name = "txtCriterioLote"
        Me.txtCriterioLote.Size = New System.Drawing.Size(261, 26)
        Me.txtCriterioLote.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCriterioLote.TabIndex = 0
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Checked = False
        Me.dtpFechaIngreso.Enabled = False
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(220, 53)
        Me.dtpFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaIngreso.TabIndex = 1
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Checked = False
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(220, 117)
        Me.dtpFechaVencimiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(168, 22)
        Me.dtpFechaVencimiento.TabIndex = 3
        '
        'dtpFechaProduccion
        '
        Me.dtpFechaProduccion.Checked = False
        Me.dtpFechaProduccion.Enabled = False
        Me.dtpFechaProduccion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaProduccion.Location = New System.Drawing.Point(220, 85)
        Me.dtpFechaProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaProduccion.Name = "dtpFechaProduccion"
        Me.dtpFechaProduccion.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaProduccion.TabIndex = 2
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(160, 224)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = False
        Me.txtProveedor.Size = New System.Drawing.Size(261, 26)
        Me.txtProveedor.TabIndex = 2
        '
        'txtAyuda
        '
        Me.txtAyuda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAyuda.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAyuda})
        Me.txtAyuda.Location = New System.Drawing.Point(160, 14)
        Me.txtAyuda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAyuda.Name = "txtAyuda"
        Me.txtAyuda.ReadOnly = True
        Me.txtAyuda.Size = New System.Drawing.Size(600, 26)
        Me.txtAyuda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAyuda.TabIndex = 0
        '
        'btnAyuda
        '
        Me.btnAyuda.ExtraText = ""
        Me.btnAyuda.Image = Nothing
        Me.btnAyuda.Text = ""
        Me.btnAyuda.ToolTipImage = Nothing
        Me.btnAyuda.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAyuda.UniqueName = "49E3634C8A8344A049E3634C8A8344A0"
        '
        'txtNrTurno
        '
        Me.txtNrTurno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNrTurno.Location = New System.Drawing.Point(160, 324)
        Me.txtNrTurno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNrTurno.MaxLength = 3
        Me.txtNrTurno.Name = "txtNrTurno"
        Me.txtNrTurno.Size = New System.Drawing.Size(173, 26)
        Me.txtNrTurno.TabIndex = 8
        Me.txtNrTurno.Text = "0"
        Me.txtNrTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(61, 324)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(97, 24)
        Me.KryptonLabel7.TabIndex = 102
        Me.KryptonLabel7.Text = "Nro.  Turno :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Nro.  Turno :"
        '
        'UcAyuda3
        '
        Me.UcAyuda3.BackColor = System.Drawing.Color.Transparent
        Me.UcAyuda3.DataSource = Nothing
        Me.UcAyuda3.DispleyMember = ""
        Me.UcAyuda3.Etiquetas_Form = Nothing
        Me.UcAyuda3.ListColumnas = Nothing
        Me.UcAyuda3.Location = New System.Drawing.Point(160, 289)
        Me.UcAyuda3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcAyuda3.Name = "UcAyuda3"
        Me.UcAyuda3.Obligatorio = False
        Me.UcAyuda3.PopupHeight = 0
        Me.UcAyuda3.PopupWidth = 0
        Me.UcAyuda3.Size = New System.Drawing.Size(261, 27)
        Me.UcAyuda3.SizeFont = 0
        Me.UcAyuda3.TabIndex = 6
        Me.UcAyuda3.ValueMember = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(37, 293)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(120, 24)
        Me.KryptonLabel2.TabIndex = 91
        Me.KryptonLabel2.Text = "Moneda Venta :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Moneda Venta :"
        '
        'txtImportVenta
        '
        Me.txtImportVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportVenta.Location = New System.Drawing.Point(589, 293)
        Me.txtImportVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImportVenta.MaxLength = 10
        Me.txtImportVenta.Name = "txtImportVenta"
        Me.txtImportVenta.Size = New System.Drawing.Size(173, 26)
        Me.txtImportVenta.TabIndex = 7
        Me.txtImportVenta.Text = "00.00"
        Me.txtImportVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(467, 294)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(117, 24)
        Me.KryptonLabel3.TabIndex = 92
        Me.KryptonLabel3.Text = "Importe Venta :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Importe Venta :"
        '
        'UcAyuda2
        '
        Me.UcAyuda2.BackColor = System.Drawing.Color.Transparent
        Me.UcAyuda2.DataSource = Nothing
        Me.UcAyuda2.DispleyMember = ""
        Me.UcAyuda2.Etiquetas_Form = Nothing
        Me.UcAyuda2.ListColumnas = Nothing
        Me.UcAyuda2.Location = New System.Drawing.Point(160, 255)
        Me.UcAyuda2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.UcAyuda2.Name = "UcAyuda2"
        Me.UcAyuda2.Obligatorio = False
        Me.UcAyuda2.PopupHeight = 0
        Me.UcAyuda2.PopupWidth = 0
        Me.UcAyuda2.Size = New System.Drawing.Size(261, 27)
        Me.UcAyuda2.SizeFont = 0
        Me.UcAyuda2.TabIndex = 4
        Me.UcAyuda2.ValueMember = ""
        '
        'txtDocProveedor
        '
        Me.txtDocProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocProveedor.Location = New System.Drawing.Point(589, 224)
        Me.txtDocProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDocProveedor.MaxLength = 15
        Me.txtDocProveedor.Name = "txtDocProveedor"
        Me.txtDocProveedor.Size = New System.Drawing.Size(173, 26)
        Me.txtDocProveedor.TabIndex = 3
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(55, 357)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(104, 24)
        Me.KryptonLabel1.TabIndex = 81
        Me.KryptonLabel1.Text = "Observación : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Observación : "
        '
        'txtImportProveedor
        '
        Me.txtImportProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportProveedor.Location = New System.Drawing.Point(589, 258)
        Me.txtImportProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImportProveedor.MaxLength = 10
        Me.txtImportProveedor.Name = "txtImportProveedor"
        Me.txtImportProveedor.Size = New System.Drawing.Size(173, 26)
        Me.txtImportProveedor.TabIndex = 5
        Me.txtImportProveedor.Text = "00.00"
        Me.txtImportProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.tsbCancelar, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(776, 27)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 24)
        Me.ToolStripLabel1.Tag = ""
        Me.ToolStripLabel1.Text = "Lote"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbCancelar
        '
        Me.tsbCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(90, 24)
        Me.tsbCancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(86, 24)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'frmMantenimientoLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.v)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(794, 543)
        Me.Name = "frmMantenimientoLote"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Lote"
        CType(Me.v, System.ComponentModel.ISupportInitialize).EndInit()
        Me.v.ResumeLayout(False)
        Me.v.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private WithEvents lbl_NRUCPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TNACPR As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_TPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_CPRVCL As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lbl_NDSDMP As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents v As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents txtObservacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtImportProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents txtCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtDocProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents UcAyuda2 As Ransa.Utilitario.ucAyuda
    Friend WithEvents UcAyuda3 As Ransa.Utilitario.ucAyuda
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtImportVenta As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaProduccion As System.Windows.Forms.DateTimePicker
    Private WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents txtNrTurno As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Private WithEvents txtAyuda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAyuda As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtProveedor As Ransa.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents rbtCriterioLote As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFechaVencimiento As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtFechaProduccion As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtFechaIngreso As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
End Class
