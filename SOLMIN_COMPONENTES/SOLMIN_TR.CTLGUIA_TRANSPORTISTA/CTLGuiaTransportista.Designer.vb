<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTLGuiaTransportista
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTLGuiaTransportista))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboPlanta = New System.Windows.Forms.ComboBox
        Me.txtNroOperacion = New System.Windows.Forms.TextBox
        Me.txtTransportista = New CodeTextBox.CodeTextBox
        Me.btnBuscar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.HGGuiasTransporte = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.btnNuevo = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.btnImprimir = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.HGRegistroGuiasTransportista = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtHojaCarguio = New System.Windows.Forms.TextBox
        Me.KryptonLabel45 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtGalonesDiesel = New System.Windows.Forms.TextBox
        Me.txtGalonesGasolina = New System.Windows.Forms.TextBox
        Me.KryptonLabel44 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel42 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtBrevete = New CodeTextBox.CodeTextBox
        Me.txtConsignatario = New System.Windows.Forms.TextBox
        Me.txtRemitente = New System.Windows.Forms.TextBox
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtValorPatrimonio = New System.Windows.Forms.TextBox
        Me.KryptonGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.rdDniConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rdRucConsignatario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.rdDniRemitente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.rdRucRemitente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNroDocumentoConsignatario = New System.Windows.Forms.TextBox
        Me.txtDireccionConsignatario = New System.Windows.Forms.TextBox
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtNroDocumentoRemitente = New System.Windows.Forms.TextBox
        Me.txtDireccionRemitente = New System.Windows.Forms.TextBox
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDireccionDestino = New System.Windows.Forms.TextBox
        Me.txtPlaneamiento = New System.Windows.Forms.TextBox
        Me.KryptonLabel37 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDireccionOrigen = New System.Windows.Forms.TextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.ckbRemitente = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.ckbDestinatario = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup
        Me.ckbIdaVuelta = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.ckbIda = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton
        Me.txtNroGuiaRemision = New System.Windows.Forms.MaskedTextBox
        Me.txtMonedaValorPatrimonio = New CodeTextBox.CodeTextBox
        Me.txtVolumenRemision = New System.Windows.Forms.TextBox
        Me.KryptonLabel33 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel32 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtUnidadMedida = New CodeTextBox.CodeTextBox
        Me.txtDestino = New CodeTextBox.CodeTextBox
        Me.txtOrigen = New CodeTextBox.CodeTextBox
        Me.txtKilometrosXRecorrer = New System.Windows.Forms.TextBox
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel31 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaTranslado = New System.Windows.Forms.DateTimePicker
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ckbMercaderiaPerecible = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.ckbMercaderiaPeligrosa = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
        Me.txtCostoTramo = New System.Windows.Forms.TextBox
        Me.KryptonLabel30 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel29 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel28 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtMonedaFlete = New CodeTextBox.CodeTextBox
        Me.KryptonLabel27 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPesoBruto = New System.Windows.Forms.TextBox
        Me.txtPeso = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.KryptonLabel36 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel35 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel34 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtLugar = New System.Windows.Forms.TextBox
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtAcoplado = New System.Windows.Forms.TextBox
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPlacaTracto = New System.Windows.Forms.TextBox
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaGuia = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtgGuiasTransporte = New System.Windows.Forms.DataGridView
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel43 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboCompania = New System.Windows.Forms.ComboBox
        Me.cboDivision = New System.Windows.Forms.ComboBox
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.HGGuiaRemision = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSeleccionarTodos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnDeseleccionartodos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnPasarLista = New System.Windows.Forms.ToolStripButton
        Me.dtgGuiaRemision = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.btnQuitarElemento = New System.Windows.Forms.ToolStripButton
        Me.dtgGuiasSeleccionadas = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtGuiaCliente = New System.Windows.Forms.TextBox
        Me.KryptonLabel41 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnEliminarOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarOrdenCompra = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox
        Me.KryptonLabel38 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtgOrdenCompra = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpFechaGuiaAnexa = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel40 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnEliminarLista = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAgregarLista = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtNroGuiaAnexa = New System.Windows.Forms.TextBox
        Me.KryptonLabel39 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtgGuiasTransportistaAnexa = New System.Windows.Forms.DataGridView
        Me.Lista = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.HGGuiasTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGGuiasTransporte.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGGuiasTransporte.Panel.SuspendLayout()
        Me.HGGuiasTransporte.SuspendLayout()
        CType(Me.HGRegistroGuiasTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGRegistroGuiasTransportista.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGRegistroGuiasTransportista.Panel.SuspendLayout()
        Me.HGRegistroGuiasTransportista.SuspendLayout()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup4.Panel.SuspendLayout()
        Me.KryptonGroup4.SuspendLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup3.Panel.SuspendLayout()
        Me.KryptonGroup3.SuspendLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup2.Panel.SuspendLayout()
        Me.KryptonGroup2.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.dtgGuiasTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.HGGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGGuiaRemision.Panel.SuspendLayout()
        Me.HGGuiaRemision.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dtgGuiaRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup3.Panel.SuspendLayout()
        Me.KryptonHeaderGroup3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dtgGuiasSeleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup4.Panel.SuspendLayout()
        Me.KryptonHeaderGroup4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgGuiasTransportistaAnexa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(990, 600)
        Me.SplitContainer1.SplitterDistance = 376
        Me.SplitContainer1.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel23)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroOperacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTransportista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnBuscar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.HGGuiasTransporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(990, 376)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.Text = "Filtros de Selección"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros de Selección"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.software_development
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(320, 40)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(78, 16)
        Me.KryptonLabel23.TabIndex = 133
        Me.KryptonLabel23.Text = "N° Operación"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "N° Operación"
        '
        'cboPlanta
        '
        Me.cboPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanta.DropDownWidth = 250
        Me.cboPlanta.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlanta.FormattingEnabled = True
        Me.cboPlanta.Location = New System.Drawing.Point(676, 8)
        Me.cboPlanta.Name = "cboPlanta"
        Me.cboPlanta.Size = New System.Drawing.Size(176, 19)
        Me.cboPlanta.TabIndex = 8
        '
        'txtNroOperacion
        '
        Me.txtNroOperacion.Location = New System.Drawing.Point(400, 36)
        Me.txtNroOperacion.MaxLength = 10
        Me.txtNroOperacion.Name = "txtNroOperacion"
        Me.txtNroOperacion.Size = New System.Drawing.Size(176, 20)
        Me.txtNroOperacion.TabIndex = 132
        '
        'txtTransportista
        '
        Me.txtTransportista.Codigo = ""
        Me.txtTransportista.ControlHeight = 23
        Me.txtTransportista.ControlImage = True
        Me.txtTransportista.ControlReadOnly = False
        Me.txtTransportista.Descripcion = ""
        Me.txtTransportista.DisplayColumnVisible = True
        Me.txtTransportista.DisplayMember = ""
        Me.txtTransportista.KeyColumnWidth = 100
        Me.txtTransportista.KeyField = ""
        Me.txtTransportista.KeySearch = True
        Me.txtTransportista.Location = New System.Drawing.Point(80, 36)
        Me.txtTransportista.Name = "txtTransportista"
        Me.txtTransportista.Size = New System.Drawing.Size(204, 23)
        Me.txtTransportista.TabIndex = 5
        Me.txtTransportista.TextBackColor = System.Drawing.Color.Empty
        Me.txtTransportista.TextForeColor = System.Drawing.Color.Empty
        Me.txtTransportista.ValueColumnVisible = True
        Me.txtTransportista.ValueColumnWidth = 600
        Me.txtTransportista.ValueField = ""
        Me.txtTransportista.ValueMember = ""
        Me.txtTransportista.ValueSearch = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(880, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 24)
        Me.btnBuscar.TabIndex = 131
        Me.btnBuscar.Text = "Procesar"
        Me.btnBuscar.Values.ExtraText = ""
        Me.btnBuscar.Values.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.restart_1
        Me.btnBuscar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscar.Values.Text = "Procesar"
        '
        'HGGuiasTransporte
        '
        Me.HGGuiasTransporte.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.btnNuevo, Me.btnGuardar, Me.btnCancelar, Me.btnImprimir})
        Me.HGGuiasTransporte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HGGuiasTransporte.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGGuiasTransporte.HeaderVisibleSecondary = False
        Me.HGGuiasTransporte.Location = New System.Drawing.Point(0, 68)
        Me.HGGuiasTransporte.Name = "HGGuiasTransporte"
        '
        'HGGuiasTransporte.Panel
        '
        Me.HGGuiasTransporte.Panel.Controls.Add(Me.HGRegistroGuiasTransportista)
        Me.HGGuiasTransporte.Panel.Controls.Add(Me.dtgGuiasTransporte)
        Me.HGGuiasTransporte.Panel.Controls.Add(Me.dtpFecha)
        Me.HGGuiasTransporte.Panel.Controls.Add(Me.KryptonLabel43)
        Me.HGGuiasTransporte.Size = New System.Drawing.Size(988, 287)
        Me.HGGuiasTransporte.TabIndex = 128
        Me.HGGuiasTransporte.Text = "Información de Guías de Transporte"
        Me.HGGuiasTransporte.ValuesPrimary.Description = ""
        Me.HGGuiasTransporte.ValuesPrimary.Heading = "Información de Guías de Transporte"
        Me.HGGuiasTransporte.ValuesPrimary.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.software_development
        Me.HGGuiasTransporte.ValuesSecondary.Description = ""
        Me.HGGuiasTransporte.ValuesSecondary.Heading = "Description"
        Me.HGGuiasTransporte.ValuesSecondary.Image = Nothing
        '
        'btnNuevo
        '
        Me.btnNuevo.ExtraText = ""
        Me.btnNuevo.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.view_text
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.ToolTipImage = Nothing
        Me.btnNuevo.UniqueName = "300BE5753F1546F3300BE5753F1546F3"
        '
        'btnGuardar
        '
        Me.btnGuardar.ExtraText = ""
        Me.btnGuardar.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.filesave
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.ToolTipImage = Nothing
        Me.btnGuardar.UniqueName = "D7F8B676C63F4D7DD7F8B676C63F4D7D"
        '
        'btnCancelar
        '
        Me.btnCancelar.ExtraText = ""
        Me.btnCancelar.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.cancel
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipImage = Nothing
        Me.btnCancelar.UniqueName = "5E1DAD16DA3749475E1DAD16DA374947"
        '
        'btnImprimir
        '
        Me.btnImprimir.ExtraText = ""
        Me.btnImprimir.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.printer1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.ToolTipImage = Nothing
        Me.btnImprimir.UniqueName = "A97FB45314144AFDA97FB45314144AFD"
        '
        'HGRegistroGuiasTransportista
        '
        Me.HGRegistroGuiasTransportista.AutoSize = True
        Me.HGRegistroGuiasTransportista.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup4})
        Me.HGRegistroGuiasTransportista.Collapsed = True
        Me.HGRegistroGuiasTransportista.Dock = System.Windows.Forms.DockStyle.Left
        Me.HGRegistroGuiasTransportista.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.HGRegistroGuiasTransportista.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGRegistroGuiasTransportista.HeaderVisibleSecondary = False
        Me.HGRegistroGuiasTransportista.Location = New System.Drawing.Point(0, 0)
        Me.HGRegistroGuiasTransportista.Name = "HGRegistroGuiasTransportista"
        '
        'HGRegistroGuiasTransportista.Panel
        '
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtHojaCarguio)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel45)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtGalonesDiesel)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtGalonesGasolina)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel44)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel42)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtBrevete)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtConsignatario)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtRemitente)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel7)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtValorPatrimonio)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonGroup4)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonGroup3)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.Panel2)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtNroDocumentoConsignatario)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtDireccionConsignatario)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel19)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel20)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel21)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel22)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtNroDocumentoRemitente)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtDireccionRemitente)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel18)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel17)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel16)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel15)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtDireccionDestino)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtPlaneamiento)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel37)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtDireccionOrigen)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel6)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonGroup2)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonGroup1)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtNroGuiaRemision)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtMonedaValorPatrimonio)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtVolumenRemision)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel33)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel32)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtUnidadMedida)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtDestino)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtOrigen)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtKilometrosXRecorrer)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel14)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel31)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.dtpFechaTranslado)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.Panel3)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.ckbMercaderiaPerecible)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.ckbMercaderiaPeligrosa)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtCostoTramo)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel30)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel29)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel28)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtMonedaFlete)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel27)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel26)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtPesoBruto)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtPeso)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtCantidad)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel36)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel35)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel34)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtLugar)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel25)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtAcoplado)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel24)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel13)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.txtPlacaTracto)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel12)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel11)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel10)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel9)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel8)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.dtpFechaGuia)
        Me.HGRegistroGuiasTransportista.Panel.Controls.Add(Me.KryptonLabel2)
        Me.HGRegistroGuiasTransportista.Size = New System.Drawing.Size(23, 260)
        Me.HGRegistroGuiasTransportista.TabIndex = 128
        Me.HGRegistroGuiasTransportista.Text = "Registro de Guías de Transportista"
        Me.HGRegistroGuiasTransportista.ValuesPrimary.Description = ""
        Me.HGRegistroGuiasTransportista.ValuesPrimary.Heading = "Registro de Guías de Transportista"
        Me.HGRegistroGuiasTransportista.ValuesPrimary.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.software_development
        Me.HGRegistroGuiasTransportista.ValuesSecondary.Description = ""
        Me.HGRegistroGuiasTransportista.ValuesSecondary.Heading = "Description"
        Me.HGRegistroGuiasTransportista.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup4
        '
        Me.ButtonSpecHeaderGroup4.ExtraText = ""
        Me.ButtonSpecHeaderGroup4.Image = Nothing
        Me.ButtonSpecHeaderGroup4.Text = ""
        Me.ButtonSpecHeaderGroup4.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.ButtonSpecHeaderGroup4.UniqueName = "8032D81CFD0A47178032D81CFD0A4717"
        '
        'txtHojaCarguio
        '
        Me.txtHojaCarguio.Location = New System.Drawing.Point(420, 8)
        Me.txtHojaCarguio.Name = "txtHojaCarguio"
        Me.txtHojaCarguio.Size = New System.Drawing.Size(244, 20)
        Me.txtHojaCarguio.TabIndex = 13
        '
        'KryptonLabel45
        '
        Me.KryptonLabel45.Location = New System.Drawing.Point(320, 12)
        Me.KryptonLabel45.Name = "KryptonLabel45"
        Me.KryptonLabel45.Size = New System.Drawing.Size(92, 16)
        Me.KryptonLabel45.TabIndex = 197
        Me.KryptonLabel45.Text = "N° Hoja Carguío"
        Me.KryptonLabel45.Values.ExtraText = ""
        Me.KryptonLabel45.Values.Image = Nothing
        Me.KryptonLabel45.Values.Text = "N° Hoja Carguío"
        '
        'txtGalonesDiesel
        '
        Me.txtGalonesDiesel.Location = New System.Drawing.Point(240, 224)
        Me.txtGalonesDiesel.Name = "txtGalonesDiesel"
        Me.txtGalonesDiesel.Size = New System.Drawing.Size(72, 20)
        Me.txtGalonesDiesel.TabIndex = 12
        '
        'txtGalonesGasolina
        '
        Me.txtGalonesGasolina.Location = New System.Drawing.Point(92, 224)
        Me.txtGalonesGasolina.Name = "txtGalonesGasolina"
        Me.txtGalonesGasolina.Size = New System.Drawing.Size(72, 20)
        Me.txtGalonesGasolina.TabIndex = 11
        '
        'KryptonLabel44
        '
        Me.KryptonLabel44.Location = New System.Drawing.Point(168, 228)
        Me.KryptonLabel44.Name = "KryptonLabel44"
        Me.KryptonLabel44.Size = New System.Drawing.Size(66, 16)
        Me.KryptonLabel44.TabIndex = 194
        Me.KryptonLabel44.Text = "Gal. Diesel"
        Me.KryptonLabel44.Values.ExtraText = ""
        Me.KryptonLabel44.Values.Image = Nothing
        Me.KryptonLabel44.Values.Text = "Gal. Diesel"
        '
        'KryptonLabel42
        '
        Me.KryptonLabel42.Location = New System.Drawing.Point(0, 228)
        Me.KryptonLabel42.Name = "KryptonLabel42"
        Me.KryptonLabel42.Size = New System.Drawing.Size(85, 16)
        Me.KryptonLabel42.TabIndex = 193
        Me.KryptonLabel42.Text = "Gals. Gasolina"
        Me.KryptonLabel42.Values.ExtraText = ""
        Me.KryptonLabel42.Values.Image = Nothing
        Me.KryptonLabel42.Values.Text = "Gals. Gasolina"
        '
        'txtBrevete
        '
        Me.txtBrevete.Codigo = ""
        Me.txtBrevete.ControlHeight = 23
        Me.txtBrevete.ControlImage = True
        Me.txtBrevete.ControlReadOnly = False
        Me.txtBrevete.Descripcion = ""
        Me.txtBrevete.DisplayColumnVisible = True
        Me.txtBrevete.DisplayMember = ""
        Me.txtBrevete.KeyColumnWidth = 100
        Me.txtBrevete.KeyField = ""
        Me.txtBrevete.KeySearch = True
        Me.txtBrevete.Location = New System.Drawing.Point(420, 80)
        Me.txtBrevete.Name = "txtBrevete"
        Me.txtBrevete.Size = New System.Drawing.Size(244, 23)
        Me.txtBrevete.TabIndex = 18
        Me.txtBrevete.TextBackColor = System.Drawing.Color.Empty
        Me.txtBrevete.TextForeColor = System.Drawing.Color.Empty
        Me.txtBrevete.ValueColumnVisible = True
        Me.txtBrevete.ValueColumnWidth = 600
        Me.txtBrevete.ValueField = ""
        Me.txtBrevete.ValueMember = ""
        Me.txtBrevete.ValueSearch = True
        '
        'txtConsignatario
        '
        Me.txtConsignatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConsignatario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsignatario.Location = New System.Drawing.Point(796, 112)
        Me.txtConsignatario.Name = "txtConsignatario"
        Me.txtConsignatario.Size = New System.Drawing.Size(160, 21)
        Me.txtConsignatario.TabIndex = 36
        '
        'txtRemitente
        '
        Me.txtRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemitente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemitente.Location = New System.Drawing.Point(796, 12)
        Me.txtRemitente.Name = "txtRemitente"
        Me.txtRemitente.Size = New System.Drawing.Size(160, 21)
        Me.txtRemitente.TabIndex = 31
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(924, 244)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(38, 16)
        Me.KryptonLabel7.TabIndex = 189
        Me.KryptonLabel7.Text = "..     .."
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "..     .."
        '
        'txtValorPatrimonio
        '
        Me.txtValorPatrimonio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorPatrimonio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPatrimonio.Location = New System.Drawing.Point(584, 184)
        Me.txtValorPatrimonio.Name = "txtValorPatrimonio"
        Me.txtValorPatrimonio.Size = New System.Drawing.Size(80, 21)
        Me.txtValorPatrimonio.TabIndex = 27
        '
        'KryptonGroup4
        '
        Me.KryptonGroup4.Location = New System.Drawing.Point(796, 160)
        Me.KryptonGroup4.Name = "KryptonGroup4"
        '
        'KryptonGroup4.Panel
        '
        Me.KryptonGroup4.Panel.Controls.Add(Me.rdDniConsignatario)
        Me.KryptonGroup4.Panel.Controls.Add(Me.rdRucConsignatario)
        Me.KryptonGroup4.Size = New System.Drawing.Size(160, 20)
        Me.KryptonGroup4.TabIndex = 188
        '
        'rdDniConsignatario
        '
        Me.rdDniConsignatario.Location = New System.Drawing.Point(0, 0)
        Me.rdDniConsignatario.Name = "rdDniConsignatario"
        Me.rdDniConsignatario.Size = New System.Drawing.Size(48, 16)
        Me.rdDniConsignatario.TabIndex = 38
        Me.rdDniConsignatario.Text = "D.N.I"
        Me.rdDniConsignatario.Values.ExtraText = ""
        Me.rdDniConsignatario.Values.Image = Nothing
        Me.rdDniConsignatario.Values.Text = "D.N.I"
        '
        'rdRucConsignatario
        '
        Me.rdRucConsignatario.Checked = True
        Me.rdRucConsignatario.Location = New System.Drawing.Point(76, 0)
        Me.rdRucConsignatario.Name = "rdRucConsignatario"
        Me.rdRucConsignatario.Size = New System.Drawing.Size(53, 16)
        Me.rdRucConsignatario.TabIndex = 39
        Me.rdRucConsignatario.Text = "R.U.C"
        Me.rdRucConsignatario.Values.ExtraText = ""
        Me.rdRucConsignatario.Values.Image = Nothing
        Me.rdRucConsignatario.Values.Text = "R.U.C"
        '
        'KryptonGroup3
        '
        Me.KryptonGroup3.Location = New System.Drawing.Point(796, 60)
        Me.KryptonGroup3.Name = "KryptonGroup3"
        '
        'KryptonGroup3.Panel
        '
        Me.KryptonGroup3.Panel.Controls.Add(Me.rdDniRemitente)
        Me.KryptonGroup3.Panel.Controls.Add(Me.rdRucRemitente)
        Me.KryptonGroup3.Size = New System.Drawing.Size(160, 20)
        Me.KryptonGroup3.TabIndex = 187
        '
        'rdDniRemitente
        '
        Me.rdDniRemitente.Location = New System.Drawing.Point(0, 0)
        Me.rdDniRemitente.Name = "rdDniRemitente"
        Me.rdDniRemitente.Size = New System.Drawing.Size(48, 16)
        Me.rdDniRemitente.TabIndex = 33
        Me.rdDniRemitente.Text = "D.N.I"
        Me.rdDniRemitente.Values.ExtraText = ""
        Me.rdDniRemitente.Values.Image = Nothing
        Me.rdDniRemitente.Values.Text = "D.N.I"
        '
        'rdRucRemitente
        '
        Me.rdRucRemitente.Checked = True
        Me.rdRucRemitente.Location = New System.Drawing.Point(76, 0)
        Me.rdRucRemitente.Name = "rdRucRemitente"
        Me.rdRucRemitente.Size = New System.Drawing.Size(53, 16)
        Me.rdRucRemitente.TabIndex = 34
        Me.rdRucRemitente.Text = "R.U.C"
        Me.rdRucRemitente.Values.ExtraText = ""
        Me.rdRucRemitente.Values.Image = Nothing
        Me.rdRucRemitente.Values.Text = "R.U.C"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(668, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 250)
        Me.Panel2.TabIndex = 183
        '
        'txtNroDocumentoConsignatario
        '
        Me.txtNroDocumentoConsignatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumentoConsignatario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoConsignatario.Location = New System.Drawing.Point(796, 184)
        Me.txtNroDocumentoConsignatario.Name = "txtNroDocumentoConsignatario"
        Me.txtNroDocumentoConsignatario.Size = New System.Drawing.Size(160, 21)
        Me.txtNroDocumentoConsignatario.TabIndex = 40
        '
        'txtDireccionConsignatario
        '
        Me.txtDireccionConsignatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionConsignatario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionConsignatario.Location = New System.Drawing.Point(796, 136)
        Me.txtDireccionConsignatario.Name = "txtDireccionConsignatario"
        Me.txtDireccionConsignatario.Size = New System.Drawing.Size(160, 21)
        Me.txtDireccionConsignatario.TabIndex = 37
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(672, 188)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(111, 16)
        Me.KryptonLabel19.TabIndex = 180
        Me.KryptonLabel19.Text = "Número Documento"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Número Documento"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(672, 164)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(109, 16)
        Me.KryptonLabel20.TabIndex = 179
        Me.KryptonLabel20.Text = "Tipo de Documento"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Tipo de Documento"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(672, 140)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(130, 16)
        Me.KryptonLabel21.TabIndex = 178
        Me.KryptonLabel21.Text = "Dirección de Consignat."
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Dirección de Consignat."
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(672, 116)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(123, 16)
        Me.KryptonLabel22.TabIndex = 177
        Me.KryptonLabel22.Text = "Nombre Consignatario"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Nombre Consignatario"
        '
        'txtNroDocumentoRemitente
        '
        Me.txtNroDocumentoRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumentoRemitente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoRemitente.Location = New System.Drawing.Point(796, 84)
        Me.txtNroDocumentoRemitente.Name = "txtNroDocumentoRemitente"
        Me.txtNroDocumentoRemitente.Size = New System.Drawing.Size(160, 21)
        Me.txtNroDocumentoRemitente.TabIndex = 35
        '
        'txtDireccionRemitente
        '
        Me.txtDireccionRemitente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionRemitente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionRemitente.Location = New System.Drawing.Point(796, 36)
        Me.txtDireccionRemitente.Name = "txtDireccionRemitente"
        Me.txtDireccionRemitente.Size = New System.Drawing.Size(160, 21)
        Me.txtDireccionRemitente.TabIndex = 32
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(672, 88)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(111, 16)
        Me.KryptonLabel18.TabIndex = 173
        Me.KryptonLabel18.Text = "Número Documento"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Número Documento"
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(672, 64)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(109, 16)
        Me.KryptonLabel17.TabIndex = 172
        Me.KryptonLabel17.Text = "Tipo de Documento"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Tipo de Documento"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(672, 40)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(93, 16)
        Me.KryptonLabel16.TabIndex = 171
        Me.KryptonLabel16.Text = "Dirección Remit." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Dirección Remit." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(672, 16)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(105, 16)
        Me.KryptonLabel15.TabIndex = 170
        Me.KryptonLabel15.Text = "Nombre Remitente"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Nombre Remitente"
        '
        'txtDireccionDestino
        '
        Me.txtDireccionDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionDestino.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionDestino.Location = New System.Drawing.Point(92, 176)
        Me.txtDireccionDestino.Name = "txtDireccionDestino"
        Me.txtDireccionDestino.Size = New System.Drawing.Size(220, 21)
        Me.txtDireccionDestino.TabIndex = 8
        '
        'txtPlaneamiento
        '
        Me.txtPlaneamiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaneamiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaneamiento.Location = New System.Drawing.Point(92, 8)
        Me.txtPlaneamiento.Name = "txtPlaneamiento"
        Me.txtPlaneamiento.ReadOnly = True
        Me.txtPlaneamiento.Size = New System.Drawing.Size(100, 21)
        Me.txtPlaneamiento.TabIndex = 0
        '
        'KryptonLabel37
        '
        Me.KryptonLabel37.Location = New System.Drawing.Point(0, 180)
        Me.KryptonLabel37.Name = "KryptonLabel37"
        Me.KryptonLabel37.Size = New System.Drawing.Size(87, 16)
        Me.KryptonLabel37.TabIndex = 169
        Me.KryptonLabel37.Text = "Dirección Dest."
        Me.KryptonLabel37.Values.ExtraText = ""
        Me.KryptonLabel37.Values.Image = Nothing
        Me.KryptonLabel37.Values.Text = "Dirección Dest."
        '
        'txtDireccionOrigen
        '
        Me.txtDireccionOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccionOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionOrigen.Location = New System.Drawing.Point(92, 128)
        Me.txtDireccionOrigen.Name = "txtDireccionOrigen"
        Me.txtDireccionOrigen.Size = New System.Drawing.Size(220, 21)
        Me.txtDireccionOrigen.TabIndex = 6
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(0, 132)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(95, 16)
        Me.KryptonLabel6.TabIndex = 166
        Me.KryptonLabel6.Text = "Dirección Origen"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Dirección Origen"
        '
        'KryptonGroup2
        '
        Me.KryptonGroup2.Location = New System.Drawing.Point(420, 104)
        Me.KryptonGroup2.Name = "KryptonGroup2"
        '
        'KryptonGroup2.Panel
        '
        Me.KryptonGroup2.Panel.Controls.Add(Me.ckbRemitente)
        Me.KryptonGroup2.Panel.Controls.Add(Me.ckbDestinatario)
        Me.KryptonGroup2.Size = New System.Drawing.Size(176, 20)
        Me.KryptonGroup2.TabIndex = 165
        '
        'ckbRemitente
        '
        Me.ckbRemitente.Checked = True
        Me.ckbRemitente.Location = New System.Drawing.Point(0, 0)
        Me.ckbRemitente.Name = "ckbRemitente"
        Me.ckbRemitente.Size = New System.Drawing.Size(74, 16)
        Me.ckbRemitente.TabIndex = 19
        Me.ckbRemitente.Text = "Remitente"
        Me.ckbRemitente.Values.ExtraText = ""
        Me.ckbRemitente.Values.Image = Nothing
        Me.ckbRemitente.Values.Text = "Remitente"
        '
        'ckbDestinatario
        '
        Me.ckbDestinatario.Location = New System.Drawing.Point(76, 0)
        Me.ckbDestinatario.Name = "ckbDestinatario"
        Me.ckbDestinatario.Size = New System.Drawing.Size(83, 16)
        Me.ckbDestinatario.TabIndex = 20
        Me.ckbDestinatario.Text = "Destinatario"
        Me.ckbDestinatario.Values.ExtraText = ""
        Me.ckbDestinatario.Values.Image = Nothing
        Me.ckbDestinatario.Values.Text = "Destinatario"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(420, 156)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.ckbIdaVuelta)
        Me.KryptonGroup1.Panel.Controls.Add(Me.ckbIda)
        Me.KryptonGroup1.Size = New System.Drawing.Size(140, 20)
        Me.KryptonGroup1.TabIndex = 164
        '
        'ckbIdaVuelta
        '
        Me.ckbIdaVuelta.Location = New System.Drawing.Point(55, -1)
        Me.ckbIdaVuelta.Name = "ckbIdaVuelta"
        Me.ckbIdaVuelta.Size = New System.Drawing.Size(73, 16)
        Me.ckbIdaVuelta.TabIndex = 23
        Me.ckbIdaVuelta.Text = "Ida/Vuelta"
        Me.ckbIdaVuelta.Values.ExtraText = ""
        Me.ckbIdaVuelta.Values.Image = Nothing
        Me.ckbIdaVuelta.Values.Text = "Ida/Vuelta"
        '
        'ckbIda
        '
        Me.ckbIda.Checked = True
        Me.ckbIda.Location = New System.Drawing.Point(3, -1)
        Me.ckbIda.Name = "ckbIda"
        Me.ckbIda.Size = New System.Drawing.Size(38, 16)
        Me.ckbIda.TabIndex = 22
        Me.ckbIda.Text = "Ida"
        Me.ckbIda.Values.ExtraText = ""
        Me.ckbIda.Values.Image = Nothing
        Me.ckbIda.Values.Text = "Ida"
        '
        'txtNroGuiaRemision
        '
        Me.txtNroGuiaRemision.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGuiaRemision.Location = New System.Drawing.Point(92, 32)
        Me.txtNroGuiaRemision.Mask = "000-0000000"
        Me.txtNroGuiaRemision.Name = "txtNroGuiaRemision"
        Me.txtNroGuiaRemision.Size = New System.Drawing.Size(84, 21)
        Me.txtNroGuiaRemision.TabIndex = 1
        '
        'txtMonedaValorPatrimonio
        '
        Me.txtMonedaValorPatrimonio.Codigo = ""
        Me.txtMonedaValorPatrimonio.ControlHeight = 23
        Me.txtMonedaValorPatrimonio.ControlImage = True
        Me.txtMonedaValorPatrimonio.ControlReadOnly = False
        Me.txtMonedaValorPatrimonio.Descripcion = ""
        Me.txtMonedaValorPatrimonio.DisplayColumnVisible = True
        Me.txtMonedaValorPatrimonio.DisplayMember = ""
        Me.txtMonedaValorPatrimonio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonedaValorPatrimonio.KeyColumnWidth = 100
        Me.txtMonedaValorPatrimonio.KeyField = ""
        Me.txtMonedaValorPatrimonio.KeySearch = True
        Me.txtMonedaValorPatrimonio.Location = New System.Drawing.Point(420, 208)
        Me.txtMonedaValorPatrimonio.Name = "txtMonedaValorPatrimonio"
        Me.txtMonedaValorPatrimonio.Size = New System.Drawing.Size(244, 23)
        Me.txtMonedaValorPatrimonio.TabIndex = 28
        Me.txtMonedaValorPatrimonio.TextBackColor = System.Drawing.Color.Empty
        Me.txtMonedaValorPatrimonio.TextForeColor = System.Drawing.Color.Empty
        Me.txtMonedaValorPatrimonio.ValueColumnVisible = True
        Me.txtMonedaValorPatrimonio.ValueColumnWidth = 600
        Me.txtMonedaValorPatrimonio.ValueField = ""
        Me.txtMonedaValorPatrimonio.ValueMember = ""
        Me.txtMonedaValorPatrimonio.ValueSearch = True
        '
        'txtVolumenRemision
        '
        Me.txtVolumenRemision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVolumenRemision.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolumenRemision.Location = New System.Drawing.Point(420, 184)
        Me.txtVolumenRemision.Name = "txtVolumenRemision"
        Me.txtVolumenRemision.Size = New System.Drawing.Size(80, 21)
        Me.txtVolumenRemision.TabIndex = 26
        '
        'KryptonLabel33
        '
        Me.KryptonLabel33.Location = New System.Drawing.Point(320, 212)
        Me.KryptonLabel33.Name = "KryptonLabel33"
        Me.KryptonLabel33.Size = New System.Drawing.Size(108, 16)
        Me.KryptonLabel33.TabIndex = 159
        Me.KryptonLabel33.Text = "Moneda Valor Patr."
        Me.KryptonLabel33.Values.ExtraText = ""
        Me.KryptonLabel33.Values.Image = Nothing
        Me.KryptonLabel33.Values.Text = "Moneda Valor Patr."
        '
        'KryptonLabel32
        '
        Me.KryptonLabel32.Location = New System.Drawing.Point(500, 188)
        Me.KryptonLabel32.Name = "KryptonLabel32"
        Me.KryptonLabel32.Size = New System.Drawing.Size(88, 16)
        Me.KryptonLabel32.TabIndex = 158
        Me.KryptonLabel32.Text = "Valor Patrimon."
        Me.KryptonLabel32.Values.ExtraText = ""
        Me.KryptonLabel32.Values.Image = Nothing
        Me.KryptonLabel32.Values.Text = "Valor Patrimon."
        '
        'txtUnidadMedida
        '
        Me.txtUnidadMedida.Codigo = ""
        Me.txtUnidadMedida.ControlHeight = 23
        Me.txtUnidadMedida.ControlImage = True
        Me.txtUnidadMedida.ControlReadOnly = False
        Me.txtUnidadMedida.Descripcion = ""
        Me.txtUnidadMedida.DisplayColumnVisible = True
        Me.txtUnidadMedida.DisplayMember = ""
        Me.txtUnidadMedida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidadMedida.KeyColumnWidth = 100
        Me.txtUnidadMedida.KeyField = ""
        Me.txtUnidadMedida.KeySearch = True
        Me.txtUnidadMedida.Location = New System.Drawing.Point(168, 200)
        Me.txtUnidadMedida.Name = "txtUnidadMedida"
        Me.txtUnidadMedida.Size = New System.Drawing.Size(144, 23)
        Me.txtUnidadMedida.TabIndex = 10
        Me.txtUnidadMedida.TextBackColor = System.Drawing.Color.Empty
        Me.txtUnidadMedida.TextForeColor = System.Drawing.Color.Empty
        Me.txtUnidadMedida.ValueColumnVisible = True
        Me.txtUnidadMedida.ValueColumnWidth = 600
        Me.txtUnidadMedida.ValueField = ""
        Me.txtUnidadMedida.ValueMember = ""
        Me.txtUnidadMedida.ValueSearch = True
        '
        'txtDestino
        '
        Me.txtDestino.Codigo = ""
        Me.txtDestino.ControlHeight = 23
        Me.txtDestino.ControlImage = True
        Me.txtDestino.ControlReadOnly = False
        Me.txtDestino.Descripcion = ""
        Me.txtDestino.DisplayColumnVisible = True
        Me.txtDestino.DisplayMember = ""
        Me.txtDestino.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestino.KeyColumnWidth = 100
        Me.txtDestino.KeyField = ""
        Me.txtDestino.KeySearch = True
        Me.txtDestino.Location = New System.Drawing.Point(92, 152)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(220, 23)
        Me.txtDestino.TabIndex = 7
        Me.txtDestino.TextBackColor = System.Drawing.Color.Empty
        Me.txtDestino.TextForeColor = System.Drawing.Color.Empty
        Me.txtDestino.ValueColumnVisible = True
        Me.txtDestino.ValueColumnWidth = 600
        Me.txtDestino.ValueField = ""
        Me.txtDestino.ValueMember = ""
        Me.txtDestino.ValueSearch = True
        '
        'txtOrigen
        '
        Me.txtOrigen.Codigo = ""
        Me.txtOrigen.ControlHeight = 23
        Me.txtOrigen.ControlImage = True
        Me.txtOrigen.ControlReadOnly = False
        Me.txtOrigen.Descripcion = ""
        Me.txtOrigen.DisplayColumnVisible = True
        Me.txtOrigen.DisplayMember = ""
        Me.txtOrigen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.KeyColumnWidth = 100
        Me.txtOrigen.KeyField = ""
        Me.txtOrigen.KeySearch = True
        Me.txtOrigen.Location = New System.Drawing.Point(92, 104)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(220, 23)
        Me.txtOrigen.TabIndex = 5
        Me.txtOrigen.TextBackColor = System.Drawing.Color.Empty
        Me.txtOrigen.TextForeColor = System.Drawing.Color.Empty
        Me.txtOrigen.ValueColumnVisible = True
        Me.txtOrigen.ValueColumnWidth = 600
        Me.txtOrigen.ValueField = ""
        Me.txtOrigen.ValueMember = ""
        Me.txtOrigen.ValueSearch = True
        '
        'txtKilometrosXRecorrer
        '
        Me.txtKilometrosXRecorrer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKilometrosXRecorrer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilometrosXRecorrer.Location = New System.Drawing.Point(420, 232)
        Me.txtKilometrosXRecorrer.Name = "txtKilometrosXRecorrer"
        Me.txtKilometrosXRecorrer.Size = New System.Drawing.Size(68, 21)
        Me.txtKilometrosXRecorrer.TabIndex = 29
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(0, 12)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(92, 16)
        Me.KryptonLabel14.TabIndex = 154
        Me.KryptonLabel14.Text = "N°Planeamiento"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "N°Planeamiento"
        '
        'KryptonLabel31
        '
        Me.KryptonLabel31.Location = New System.Drawing.Point(320, 188)
        Me.KryptonLabel31.Name = "KryptonLabel31"
        Me.KryptonLabel31.Size = New System.Drawing.Size(105, 16)
        Me.KryptonLabel31.TabIndex = 149
        Me.KryptonLabel31.Text = "Volumen Remisión"
        Me.KryptonLabel31.Values.ExtraText = ""
        Me.KryptonLabel31.Values.Image = Nothing
        Me.KryptonLabel31.Values.Text = "Volumen Remisión"
        '
        'dtpFechaTranslado
        '
        Me.dtpFechaTranslado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaTranslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTranslado.Location = New System.Drawing.Point(92, 56)
        Me.dtpFechaTranslado.Name = "dtpFechaTranslado"
        Me.dtpFechaTranslado.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaTranslado.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(316, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 250)
        Me.Panel3.TabIndex = 151
        '
        'ckbMercaderiaPerecible
        '
        Me.ckbMercaderiaPerecible.Checked = False
        Me.ckbMercaderiaPerecible.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.ckbMercaderiaPerecible.Location = New System.Drawing.Point(564, 152)
        Me.ckbMercaderiaPerecible.Name = "ckbMercaderiaPerecible"
        Me.ckbMercaderiaPerecible.Size = New System.Drawing.Size(102, 16)
        Me.ckbMercaderiaPerecible.TabIndex = 24
        Me.ckbMercaderiaPerecible.Text = "Merc. Perecible"
        Me.ckbMercaderiaPerecible.Values.ExtraText = ""
        Me.ckbMercaderiaPerecible.Values.Image = Nothing
        Me.ckbMercaderiaPerecible.Values.Text = "Merc. Perecible"
        '
        'ckbMercaderiaPeligrosa
        '
        Me.ckbMercaderiaPeligrosa.Checked = False
        Me.ckbMercaderiaPeligrosa.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.ckbMercaderiaPeligrosa.Location = New System.Drawing.Point(564, 168)
        Me.ckbMercaderiaPeligrosa.Name = "ckbMercaderiaPeligrosa"
        Me.ckbMercaderiaPeligrosa.Size = New System.Drawing.Size(102, 16)
        Me.ckbMercaderiaPeligrosa.TabIndex = 25
        Me.ckbMercaderiaPeligrosa.Text = "Merc. Peligrosa"
        Me.ckbMercaderiaPeligrosa.Values.ExtraText = ""
        Me.ckbMercaderiaPeligrosa.Values.Image = Nothing
        Me.ckbMercaderiaPeligrosa.Values.Text = "Merc. Peligrosa"
        '
        'txtCostoTramo
        '
        Me.txtCostoTramo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoTramo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTramo.Location = New System.Drawing.Point(576, 232)
        Me.txtCostoTramo.Name = "txtCostoTramo"
        Me.txtCostoTramo.Size = New System.Drawing.Size(88, 21)
        Me.txtCostoTramo.TabIndex = 30
        '
        'KryptonLabel30
        '
        Me.KryptonLabel30.Location = New System.Drawing.Point(492, 236)
        Me.KryptonLabel30.Name = "KryptonLabel30"
        Me.KryptonLabel30.Size = New System.Drawing.Size(87, 16)
        Me.KryptonLabel30.TabIndex = 145
        Me.KryptonLabel30.Text = "Costo al Tramo"
        Me.KryptonLabel30.Values.ExtraText = ""
        Me.KryptonLabel30.Values.Image = Nothing
        Me.KryptonLabel30.Values.Text = "Costo al Tramo"
        '
        'KryptonLabel29
        '
        Me.KryptonLabel29.Location = New System.Drawing.Point(320, 236)
        Me.KryptonLabel29.Name = "KryptonLabel29"
        Me.KryptonLabel29.Size = New System.Drawing.Size(92, 16)
        Me.KryptonLabel29.TabIndex = 144
        Me.KryptonLabel29.Text = "Kmts x Recorrer"
        Me.KryptonLabel29.Values.ExtraText = ""
        Me.KryptonLabel29.Values.Image = Nothing
        Me.KryptonLabel29.Values.Text = "Kmts x Recorrer"
        '
        'KryptonLabel28
        '
        Me.KryptonLabel28.Location = New System.Drawing.Point(320, 160)
        Me.KryptonLabel28.Name = "KryptonLabel28"
        Me.KryptonLabel28.Size = New System.Drawing.Size(96, 16)
        Me.KryptonLabel28.TabIndex = 143
        Me.KryptonLabel28.Text = "Factor Ida/Vuelta"
        Me.KryptonLabel28.Values.ExtraText = ""
        Me.KryptonLabel28.Values.Image = Nothing
        Me.KryptonLabel28.Values.Text = "Factor Ida/Vuelta"
        '
        'txtMonedaFlete
        '
        Me.txtMonedaFlete.Codigo = ""
        Me.txtMonedaFlete.ControlHeight = 23
        Me.txtMonedaFlete.ControlImage = True
        Me.txtMonedaFlete.ControlReadOnly = False
        Me.txtMonedaFlete.Descripcion = ""
        Me.txtMonedaFlete.DisplayColumnVisible = True
        Me.txtMonedaFlete.DisplayMember = ""
        Me.txtMonedaFlete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonedaFlete.KeyColumnWidth = 100
        Me.txtMonedaFlete.KeyField = ""
        Me.txtMonedaFlete.KeySearch = True
        Me.txtMonedaFlete.Location = New System.Drawing.Point(420, 128)
        Me.txtMonedaFlete.Name = "txtMonedaFlete"
        Me.txtMonedaFlete.Size = New System.Drawing.Size(244, 23)
        Me.txtMonedaFlete.TabIndex = 21
        Me.txtMonedaFlete.TextBackColor = System.Drawing.Color.Empty
        Me.txtMonedaFlete.TextForeColor = System.Drawing.Color.Empty
        Me.txtMonedaFlete.ValueColumnVisible = True
        Me.txtMonedaFlete.ValueColumnWidth = 600
        Me.txtMonedaFlete.ValueField = ""
        Me.txtMonedaFlete.ValueMember = ""
        Me.txtMonedaFlete.ValueSearch = True
        '
        'KryptonLabel27
        '
        Me.KryptonLabel27.Location = New System.Drawing.Point(320, 136)
        Me.KryptonLabel27.Name = "KryptonLabel27"
        Me.KryptonLabel27.Size = New System.Drawing.Size(79, 16)
        Me.KryptonLabel27.TabIndex = 141
        Me.KryptonLabel27.Text = "Moneda Flete"
        Me.KryptonLabel27.Values.ExtraText = ""
        Me.KryptonLabel27.Values.Image = Nothing
        Me.KryptonLabel27.Values.Text = "Moneda Flete"
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(320, 112)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(90, 16)
        Me.KryptonLabel26.TabIndex = 140
        Me.KryptonLabel26.Text = "A Cargo de R/D"
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "A Cargo de R/D"
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoBruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoBruto.Location = New System.Drawing.Point(580, 32)
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.Size = New System.Drawing.Size(84, 21)
        Me.txtPesoBruto.TabIndex = 15
        '
        'txtPeso
        '
        Me.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(420, 32)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(84, 21)
        Me.txtPeso.TabIndex = 14
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(92, 200)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(72, 21)
        Me.txtCantidad.TabIndex = 9
        '
        'KryptonLabel36
        '
        Me.KryptonLabel36.Location = New System.Drawing.Point(512, 36)
        Me.KryptonLabel36.Name = "KryptonLabel36"
        Me.KryptonLabel36.Size = New System.Drawing.Size(66, 16)
        Me.KryptonLabel36.TabIndex = 136
        Me.KryptonLabel36.Text = "Peso Bruto"
        Me.KryptonLabel36.Values.ExtraText = ""
        Me.KryptonLabel36.Values.Image = Nothing
        Me.KryptonLabel36.Values.Text = "Peso Bruto"
        '
        'KryptonLabel35
        '
        Me.KryptonLabel35.Location = New System.Drawing.Point(320, 36)
        Me.KryptonLabel35.Name = "KryptonLabel35"
        Me.KryptonLabel35.Size = New System.Drawing.Size(96, 16)
        Me.KryptonLabel35.TabIndex = 135
        Me.KryptonLabel35.Text = "Peso Mercadería"
        Me.KryptonLabel35.Values.ExtraText = ""
        Me.KryptonLabel35.Values.Image = Nothing
        Me.KryptonLabel35.Values.Text = "Peso Mercadería"
        '
        'KryptonLabel34
        '
        Me.KryptonLabel34.Location = New System.Drawing.Point(0, 204)
        Me.KryptonLabel34.Name = "KryptonLabel34"
        Me.KryptonLabel34.Size = New System.Drawing.Size(97, 16)
        Me.KryptonLabel34.TabIndex = 134
        Me.KryptonLabel34.Text = "Cant. Mercadería"
        Me.KryptonLabel34.Values.ExtraText = ""
        Me.KryptonLabel34.Values.Image = Nothing
        Me.KryptonLabel34.Values.Text = "Cant. Mercadería"
        '
        'txtLugar
        '
        Me.txtLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLugar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugar.Location = New System.Drawing.Point(92, 80)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(216, 21)
        Me.txtLugar.TabIndex = 4
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(48, 84)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(39, 16)
        Me.KryptonLabel25.TabIndex = 132
        Me.KryptonLabel25.Text = "Lugar"
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Lugar"
        '
        'txtAcoplado
        '
        Me.txtAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcoplado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcoplado.Location = New System.Drawing.Point(580, 56)
        Me.txtAcoplado.Name = "txtAcoplado"
        Me.txtAcoplado.Size = New System.Drawing.Size(84, 21)
        Me.txtAcoplado.TabIndex = 17
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(508, 60)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(71, 16)
        Me.KryptonLabel24.TabIndex = 130
        Me.KryptonLabel24.Text = "Placa Acop."
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Placa Acop."
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(320, 84)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(79, 16)
        Me.KryptonLabel13.TabIndex = 128
        Me.KryptonLabel13.Text = "Num. Brevete"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Num. Brevete"
        '
        'txtPlacaTracto
        '
        Me.txtPlacaTracto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaTracto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacaTracto.Location = New System.Drawing.Point(420, 56)
        Me.txtPlacaTracto.Name = "txtPlacaTracto"
        Me.txtPlacaTracto.Size = New System.Drawing.Size(84, 21)
        Me.txtPlacaTracto.TabIndex = 16
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(320, 60)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(74, 16)
        Me.KryptonLabel12.TabIndex = 126
        Me.KryptonLabel12.Text = "Placa Tracto"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Placa Tracto"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(0, 156)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(96, 16)
        Me.KryptonLabel11.TabIndex = 125
        Me.KryptonLabel11.Text = "Lugar de Destino"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Lugar de Destino"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(0, 108)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(92, 16)
        Me.KryptonLabel10.TabIndex = 124
        Me.KryptonLabel10.Text = "Lugar de Origen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Lugar de Origen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(0, 60)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(86, 16)
        Me.KryptonLabel9.TabIndex = 123
        Me.KryptonLabel9.Text = "Fec. Ini. Trans."
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Fec. Ini. Trans."
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(0, 36)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(88, 16)
        Me.KryptonLabel8.TabIndex = 122
        Me.KryptonLabel8.Text = "N° G. Remisión"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "N° G. Remisión"
        '
        'dtpFechaGuia
        '
        Me.dtpFechaGuia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaGuia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaGuia.Location = New System.Drawing.Point(232, 32)
        Me.dtpFechaGuia.Name = "dtpFechaGuia"
        Me.dtpFechaGuia.Size = New System.Drawing.Size(80, 20)
        Me.dtpFechaGuia.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(176, 36)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 16)
        Me.KryptonLabel2.TabIndex = 120
        Me.KryptonLabel2.Text = "Fec. Guía"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fec. Guía"
        '
        'dtgGuiasTransporte
        '
        Me.dtgGuiasTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGuiasTransporte.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgGuiasTransporte.Location = New System.Drawing.Point(32, 32)
        Me.dtgGuiasTransporte.Name = "dtgGuiasTransporte"
        Me.dtgGuiasTransporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGuiasTransporte.Size = New System.Drawing.Size(944, 220)
        Me.dtgGuiasTransporte.TabIndex = 129
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM  yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(76, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(136, 20)
        Me.dtpFecha.TabIndex = 133
        '
        'KryptonLabel43
        '
        Me.KryptonLabel43.Location = New System.Drawing.Point(28, 8)
        Me.KryptonLabel43.Name = "KryptonLabel43"
        Me.KryptonLabel43.Size = New System.Drawing.Size(42, 16)
        Me.KryptonLabel43.TabIndex = 131
        Me.KryptonLabel43.Text = "Fecha"
        Me.KryptonLabel43.Values.ExtraText = ""
        Me.KryptonLabel43.Values.Image = Nothing
        Me.KryptonLabel43.Values.Text = "Fecha"
        '
        'cboCompania
        '
        Me.cboCompania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompania.DropDownWidth = 250
        Me.cboCompania.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompania.FormattingEnabled = True
        Me.cboCompania.Location = New System.Drawing.Point(80, 8)
        Me.cboCompania.Name = "cboCompania"
        Me.cboCompania.Size = New System.Drawing.Size(204, 19)
        Me.cboCompania.TabIndex = 10
        '
        'cboDivision
        '
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.DropDownWidth = 250
        Me.cboDivision.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Location = New System.Drawing.Point(400, 8)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(176, 19)
        Me.cboDivision.TabIndex = 9
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(608, 12)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(69, 16)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Text = "Cód. Planta"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cód. Planta"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(320, 12)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(77, 16)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Text = "Cód. División"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cód. División"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(4, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(62, 16)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Text = "Compañía"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Compañía"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(4, 40)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(76, 16)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Text = "Transportista"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Transportista"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.HGGuiaRemision)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(990, 220)
        Me.SplitContainer2.SplitterDistance = 470
        Me.SplitContainer2.TabIndex = 0
        '
        'HGGuiaRemision
        '
        Me.HGGuiaRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGGuiaRemision.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.HGGuiaRemision.HeaderVisibleSecondary = False
        Me.HGGuiaRemision.Location = New System.Drawing.Point(0, 0)
        Me.HGGuiaRemision.Name = "HGGuiaRemision"
        '
        'HGGuiaRemision.Panel
        '
        Me.HGGuiaRemision.Panel.Controls.Add(Me.ToolStrip1)
        Me.HGGuiaRemision.Panel.Controls.Add(Me.dtgGuiaRemision)
        Me.HGGuiaRemision.Size = New System.Drawing.Size(470, 220)
        Me.HGGuiaRemision.TabIndex = 0
        Me.HGGuiaRemision.Text = "Guías de Remisión"
        Me.HGGuiaRemision.ValuesPrimary.Description = ""
        Me.HGGuiaRemision.ValuesPrimary.Heading = "Guías de Remisión"
        Me.HGGuiaRemision.ValuesPrimary.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.software_development
        Me.HGGuiaRemision.ValuesSecondary.Description = ""
        Me.HGGuiaRemision.ValuesSecondary.Heading = "Description"
        Me.HGGuiaRemision.ValuesSecondary.Image = Nothing
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSeleccionarTodos, Me.ToolStripSeparator1, Me.btnDeseleccionartodos, Me.ToolStripSeparator2, Me.btnPasarLista})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(468, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSeleccionarTodos
        '
        Me.btnSeleccionarTodos.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.btnSeleccionarTodos.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.button_ok
        Me.btnSeleccionarTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSeleccionarTodos.Name = "btnSeleccionarTodos"
        Me.btnSeleccionarTodos.Size = New System.Drawing.Size(107, 22)
        Me.btnSeleccionarTodos.Text = "Seleccionar Todos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnDeseleccionartodos
        '
        Me.btnDeseleccionartodos.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.btnDeseleccionartodos.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.cancel
        Me.btnDeseleccionartodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDeseleccionartodos.Name = "btnDeseleccionartodos"
        Me.btnDeseleccionartodos.Size = New System.Drawing.Size(117, 22)
        Me.btnDeseleccionartodos.Text = "Deseleccionar Todos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnPasarLista
        '
        Me.btnPasarLista.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasarLista.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.forward
        Me.btnPasarLista.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPasarLista.Name = "btnPasarLista"
        Me.btnPasarLista.Size = New System.Drawing.Size(77, 22)
        Me.btnPasarLista.Text = "Pasar a Lista"
        '
        'dtgGuiaRemision
        '
        Me.dtgGuiaRemision.AllowUserToAddRows = False
        Me.dtgGuiaRemision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgGuiaRemision.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgGuiaRemision.Location = New System.Drawing.Point(8, 32)
        Me.dtgGuiaRemision.Name = "dtgGuiaRemision"
        Me.dtgGuiaRemision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGuiaRemision.Size = New System.Drawing.Size(452, 160)
        Me.dtgGuiaRemision.StandardTab = True
        Me.dtgGuiaRemision.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.Lista
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(516, 220)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.KryptonHeaderGroup3)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(508, 193)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Guías de Remisión Seleccionadas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup3
        '
        Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup3.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup3.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup3.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
        '
        'KryptonHeaderGroup3.Panel
        '
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.ToolStrip2)
        Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dtgGuiasSeleccionadas)
        Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(502, 187)
        Me.KryptonHeaderGroup3.TabIndex = 1
        Me.KryptonHeaderGroup3.Text = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup3.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup3.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup3.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnQuitarElemento})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(500, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnQuitarElemento
        '
        Me.btnQuitarElemento.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarElemento.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.back
        Me.btnQuitarElemento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitarElemento.Name = "btnQuitarElemento"
        Me.btnQuitarElemento.Size = New System.Drawing.Size(85, 22)
        Me.btnQuitarElemento.Text = "Quitar de Lista"
        '
        'dtgGuiasSeleccionadas
        '
        Me.dtgGuiasSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGuiasSeleccionadas.Location = New System.Drawing.Point(4, 32)
        Me.dtgGuiasSeleccionadas.Name = "dtgGuiasSeleccionadas"
        Me.dtgGuiasSeleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGuiasSeleccionadas.Size = New System.Drawing.Size(492, 148)
        Me.dtgGuiasSeleccionadas.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.KryptonHeaderGroup2)
        Me.TabPage2.ImageIndex = 0
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(508, 193)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ordenes de Compra"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtgOrdenCompra)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(502, 187)
        Me.KryptonHeaderGroup2.TabIndex = 0
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtGuiaCliente)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel41)
        Me.GroupBox1.Controls.Add(Me.btnEliminarOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.btnAgregarOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.txtOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel38)
        Me.GroupBox1.Location = New System.Drawing.Point(336, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden de Compra"
        '
        'txtGuiaCliente
        '
        Me.txtGuiaCliente.Location = New System.Drawing.Point(8, 80)
        Me.txtGuiaCliente.MaxLength = 15
        Me.txtGuiaCliente.Name = "txtGuiaCliente"
        Me.txtGuiaCliente.Size = New System.Drawing.Size(152, 21)
        Me.txtGuiaCliente.TabIndex = 5
        '
        'KryptonLabel41
        '
        Me.KryptonLabel41.Location = New System.Drawing.Point(4, 64)
        Me.KryptonLabel41.Name = "KryptonLabel41"
        Me.KryptonLabel41.Size = New System.Drawing.Size(104, 16)
        Me.KryptonLabel41.TabIndex = 4
        Me.KryptonLabel41.Text = "N° Guía de Cliente"
        Me.KryptonLabel41.Values.ExtraText = ""
        Me.KryptonLabel41.Values.Image = Nothing
        Me.KryptonLabel41.Values.Text = "N° Guía de Cliente"
        '
        'btnEliminarOrdenCompra
        '
        Me.btnEliminarOrdenCompra.Location = New System.Drawing.Point(8, 140)
        Me.btnEliminarOrdenCompra.Name = "btnEliminarOrdenCompra"
        Me.btnEliminarOrdenCompra.Size = New System.Drawing.Size(152, 25)
        Me.btnEliminarOrdenCompra.TabIndex = 3
        Me.btnEliminarOrdenCompra.Text = "Eliminar de la Lista"
        Me.btnEliminarOrdenCompra.Values.ExtraText = ""
        Me.btnEliminarOrdenCompra.Values.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.cancel
        Me.btnEliminarOrdenCompra.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnEliminarOrdenCompra.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnEliminarOrdenCompra.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnEliminarOrdenCompra.Values.Text = "Eliminar de la Lista"
        '
        'btnAgregarOrdenCompra
        '
        Me.btnAgregarOrdenCompra.Location = New System.Drawing.Point(8, 112)
        Me.btnAgregarOrdenCompra.Name = "btnAgregarOrdenCompra"
        Me.btnAgregarOrdenCompra.Size = New System.Drawing.Size(152, 25)
        Me.btnAgregarOrdenCompra.TabIndex = 2
        Me.btnAgregarOrdenCompra.Text = "Agregar a la Lista"
        Me.btnAgregarOrdenCompra.Values.ExtraText = ""
        Me.btnAgregarOrdenCompra.Values.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.button_ok
        Me.btnAgregarOrdenCompra.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarOrdenCompra.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarOrdenCompra.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarOrdenCompra.Values.Text = "Agregar a la Lista"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Location = New System.Drawing.Point(8, 36)
        Me.txtOrdenCompra.MaxLength = 30
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(152, 21)
        Me.txtOrdenCompra.TabIndex = 1
        '
        'KryptonLabel38
        '
        Me.KryptonLabel38.Location = New System.Drawing.Point(4, 20)
        Me.KryptonLabel38.Name = "KryptonLabel38"
        Me.KryptonLabel38.Size = New System.Drawing.Size(116, 16)
        Me.KryptonLabel38.TabIndex = 0
        Me.KryptonLabel38.Text = "N° Orden de Compra"
        Me.KryptonLabel38.Values.ExtraText = ""
        Me.KryptonLabel38.Values.Image = Nothing
        Me.KryptonLabel38.Values.Text = "N° Orden de Compra"
        '
        'dtgOrdenCompra
        '
        Me.dtgOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOrdenCompra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgOrdenCompra.Location = New System.Drawing.Point(4, 8)
        Me.dtgOrdenCompra.Name = "dtgOrdenCompra"
        Me.dtgOrdenCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOrdenCompra.Size = New System.Drawing.Size(328, 172)
        Me.dtgOrdenCompra.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.KryptonHeaderGroup4)
        Me.TabPage3.ImageIndex = 0
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(508, 193)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Guías de Transportista"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'KryptonHeaderGroup4
        '
        Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup4.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup4.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup4.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(3, 3)
        Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
        '
        'KryptonHeaderGroup4.Panel
        '
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.dtgGuiasTransportistaAnexa)
        Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(502, 187)
        Me.KryptonHeaderGroup4.TabIndex = 1
        Me.KryptonHeaderGroup4.Text = "Heading"
        Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup4.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup4.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup4.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpFechaGuiaAnexa)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel40)
        Me.GroupBox2.Controls.Add(Me.btnEliminarLista)
        Me.GroupBox2.Controls.Add(Me.btnAgregarLista)
        Me.GroupBox2.Controls.Add(Me.txtNroGuiaAnexa)
        Me.GroupBox2.Controls.Add(Me.KryptonLabel39)
        Me.GroupBox2.Location = New System.Drawing.Point(334, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 168)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guía Transportista"
        '
        'dtpFechaGuiaAnexa
        '
        Me.dtpFechaGuiaAnexa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaGuiaAnexa.Location = New System.Drawing.Point(64, 68)
        Me.dtpFechaGuiaAnexa.Name = "dtpFechaGuiaAnexa"
        Me.dtpFechaGuiaAnexa.Size = New System.Drawing.Size(96, 21)
        Me.dtpFechaGuiaAnexa.TabIndex = 5
        '
        'KryptonLabel40
        '
        Me.KryptonLabel40.Location = New System.Drawing.Point(8, 72)
        Me.KryptonLabel40.Name = "KryptonLabel40"
        Me.KryptonLabel40.Size = New System.Drawing.Size(42, 16)
        Me.KryptonLabel40.TabIndex = 4
        Me.KryptonLabel40.Text = "Fecha"
        Me.KryptonLabel40.Values.ExtraText = ""
        Me.KryptonLabel40.Values.Image = Nothing
        Me.KryptonLabel40.Values.Text = "Fecha"
        '
        'btnEliminarLista
        '
        Me.btnEliminarLista.Location = New System.Drawing.Point(8, 140)
        Me.btnEliminarLista.Name = "btnEliminarLista"
        Me.btnEliminarLista.Size = New System.Drawing.Size(152, 25)
        Me.btnEliminarLista.TabIndex = 3
        Me.btnEliminarLista.Text = "Eliminar de la Lista"
        Me.btnEliminarLista.Values.ExtraText = ""
        Me.btnEliminarLista.Values.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.cancel
        Me.btnEliminarLista.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnEliminarLista.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnEliminarLista.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnEliminarLista.Values.Text = "Eliminar de la Lista"
        '
        'btnAgregarLista
        '
        Me.btnAgregarLista.Location = New System.Drawing.Point(8, 112)
        Me.btnAgregarLista.Name = "btnAgregarLista"
        Me.btnAgregarLista.Size = New System.Drawing.Size(152, 25)
        Me.btnAgregarLista.TabIndex = 2
        Me.btnAgregarLista.Text = "Agregar a la Lista"
        Me.btnAgregarLista.Values.ExtraText = ""
        Me.btnAgregarLista.Values.Image = Global.SOLMIN_TR.CTLGUIA_TRANSPORTISTA.My.Resources.Resources.button_ok
        Me.btnAgregarLista.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAgregarLista.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAgregarLista.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAgregarLista.Values.Text = "Agregar a la Lista"
        '
        'txtNroGuiaAnexa
        '
        Me.txtNroGuiaAnexa.Location = New System.Drawing.Point(8, 40)
        Me.txtNroGuiaAnexa.MaxLength = 10
        Me.txtNroGuiaAnexa.Name = "txtNroGuiaAnexa"
        Me.txtNroGuiaAnexa.Size = New System.Drawing.Size(152, 21)
        Me.txtNroGuiaAnexa.TabIndex = 1
        '
        'KryptonLabel39
        '
        Me.KryptonLabel39.Location = New System.Drawing.Point(4, 24)
        Me.KryptonLabel39.Name = "KryptonLabel39"
        Me.KryptonLabel39.Size = New System.Drawing.Size(50, 16)
        Me.KryptonLabel39.TabIndex = 0
        Me.KryptonLabel39.Text = "Número"
        Me.KryptonLabel39.Values.ExtraText = ""
        Me.KryptonLabel39.Values.Image = Nothing
        Me.KryptonLabel39.Values.Text = "Número"
        '
        'dtgGuiasTransportistaAnexa
        '
        Me.dtgGuiasTransportistaAnexa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGuiasTransportistaAnexa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgGuiasTransportistaAnexa.Location = New System.Drawing.Point(2, 8)
        Me.dtgGuiasTransportistaAnexa.Name = "dtgGuiasTransportistaAnexa"
        Me.dtgGuiasTransportistaAnexa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGuiasTransportistaAnexa.Size = New System.Drawing.Size(328, 168)
        Me.dtgGuiasTransportistaAnexa.TabIndex = 2
        '
        'Lista
        '
        Me.Lista.ImageStream = CType(resources.GetObject("Lista.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Lista.TransparentColor = System.Drawing.Color.Transparent
        Me.Lista.Images.SetKeyName(0, "agt_softwareD.png")
        '
        'CTLGuiaTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CTLGuiaTransportista"
        Me.Size = New System.Drawing.Size(990, 600)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.HGGuiasTransporte.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGGuiasTransporte.Panel.ResumeLayout(False)
        Me.HGGuiasTransporte.Panel.PerformLayout()
        CType(Me.HGGuiasTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGGuiasTransporte.ResumeLayout(False)
        CType(Me.HGRegistroGuiasTransportista.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGRegistroGuiasTransportista.Panel.ResumeLayout(False)
        Me.HGRegistroGuiasTransportista.Panel.PerformLayout()
        CType(Me.HGRegistroGuiasTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGRegistroGuiasTransportista.ResumeLayout(False)
        CType(Me.KryptonGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.Panel.ResumeLayout(False)
        Me.KryptonGroup4.Panel.PerformLayout()
        CType(Me.KryptonGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup4.ResumeLayout(False)
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.Panel.ResumeLayout(False)
        Me.KryptonGroup3.Panel.PerformLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.ResumeLayout(False)
        CType(Me.KryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.Panel.ResumeLayout(False)
        Me.KryptonGroup2.Panel.PerformLayout()
        CType(Me.KryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup2.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.dtgGuiasTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.HGGuiaRemision.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGGuiaRemision.Panel.ResumeLayout(False)
        Me.HGGuiaRemision.Panel.PerformLayout()
        CType(Me.HGGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGGuiaRemision.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dtgGuiaRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup3.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup3.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dtgGuiasSeleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgGuiasTransportistaAnexa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransportista As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboCompania As System.Windows.Forms.ComboBox
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents HGGuiaRemision As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgGuiaRemision As System.Windows.Forms.DataGridView
    Friend WithEvents HGGuiasTransporte As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents HGRegistroGuiasTransportista As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup4 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents KryptonGroup4 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rdDniConsignatario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rdRucConsignatario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonGroup3 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents rdDniRemitente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rdRucRemitente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNroDocumentoConsignatario As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionConsignatario As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroDocumentoRemitente As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccionRemitente As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccionDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtPlaneamiento As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel37 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDireccionOrigen As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonGroup2 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents ckbRemitente As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents ckbDestinatario As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents ckbIdaVuelta As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents ckbIda As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtNroGuiaRemision As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMonedaValorPatrimonio As CodeTextBox.CodeTextBox
    Friend WithEvents txtVolumenRemision As System.Windows.Forms.TextBox
    Friend WithEvents txtValorPatrimonio As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel33 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel32 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadMedida As CodeTextBox.CodeTextBox
    Friend WithEvents txtDestino As CodeTextBox.CodeTextBox
    Friend WithEvents txtOrigen As CodeTextBox.CodeTextBox
    Friend WithEvents txtKilometrosXRecorrer As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel31 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaTranslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ckbMercaderiaPerecible As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ckbMercaderiaPeligrosa As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtCostoTramo As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel30 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel29 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel28 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMonedaFlete As CodeTextBox.CodeTextBox
    Friend WithEvents KryptonLabel27 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoBruto As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel36 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel35 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel34 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAcoplado As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPlacaTracto As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaGuia As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgGuiasTransporte As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevo As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnImprimir As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnBuscar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOperacion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents dtgGuiasSeleccionadas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents Lista As System.Windows.Forms.ImageList
    Friend WithEvents btnAgregarOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel38 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSeleccionarTodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDeseleccionartodos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPasarLista As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnQuitarElemento As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminarOrdenCompra As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminarLista As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAgregarLista As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNroGuiaAnexa As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel39 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgGuiasTransportistaAnexa As System.Windows.Forms.DataGridView
    Friend WithEvents KryptonLabel40 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaGuiaAnexa As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtGuiaCliente As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel41 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtConsignatario As System.Windows.Forms.TextBox
    Friend WithEvents txtRemitente As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents KryptonLabel43 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtBrevete As CodeTextBox.CodeTextBox
    Friend WithEvents txtGalonesDiesel As System.Windows.Forms.TextBox
    Friend WithEvents txtGalonesGasolina As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel44 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel42 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtHojaCarguio As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel45 As ComponentFactory.Krypton.Toolkit.KryptonLabel

End Class
