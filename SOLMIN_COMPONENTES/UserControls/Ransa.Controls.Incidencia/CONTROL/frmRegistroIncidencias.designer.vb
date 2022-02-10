<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroIncidencias
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
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta
        Dim BePlantaDeEntrega1 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega2 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega3 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Dim BePlantaDeEntrega4 As Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega = New Ransa.TypeDef.PlantaDeEntrega.bePlantaDeEntrega
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnRAlmacenSimple = New System.Windows.Forms.Button
        Me.cbxTipoDocRef = New System.Windows.Forms.ComboBox
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ktbxProceso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtEmail = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtResponsable = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.ucResponsable = New Ransa.Utilitario.ucAyuda
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbIncPara = New System.Windows.Forms.ComboBox
        Me.cmbNegocio = New System.Windows.Forms.ComboBox
        Me.txtCantidad = New Ransa.Utilitario.UCtxtSoloDecimales
        Me.txtUnidadCantidad = New Ransa.Utilitario.ucAyuda
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboOrigen = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboNivel = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDocRefCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtZonaAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda
        Me.txtIncidencia = New Ransa.Utilitario.ucAyuda
        Me.dteHoraRecepcion = New System.Windows.Forms.DateTimePicker
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.UcPlantaDeEntrega_TxtF011 = New Ransa.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
        Me.UcClienteTercero_xtF011 = New Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
        Me.txtContacto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaRecepcion = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGrabar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.txtTitulo = New System.Windows.Forms.ToolStripLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(459, 656)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnRAlmacenSimple)
        Me.KryptonPanel1.Controls.Add(Me.cbxTipoDocRef)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel23)
        Me.KryptonPanel1.Controls.Add(Me.ktbxProceso)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel22)
        Me.KryptonPanel1.Controls.Add(Me.txtEmail)
        Me.KryptonPanel1.Controls.Add(Me.txtResponsable)
        Me.KryptonPanel1.Controls.Add(Me.ucResponsable)
        Me.KryptonPanel1.Controls.Add(Me.cmbArea)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel17)
        Me.KryptonPanel1.Controls.Add(Me.cmbIncPara)
        Me.KryptonPanel1.Controls.Add(Me.cmbNegocio)
        Me.KryptonPanel1.Controls.Add(Me.txtCantidad)
        Me.KryptonPanel1.Controls.Add(Me.txtUnidadCantidad)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel11)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel10)
        Me.KryptonPanel1.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel12)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel21)
        Me.KryptonPanel1.Controls.Add(Me.cboOrigen)
        Me.KryptonPanel1.Controls.Add(Me.cboNivel)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel19)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel20)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel18)
        Me.KryptonPanel1.Controls.Add(Me.txtDocRefCliente)
        Me.KryptonPanel1.Controls.Add(Me.txtZonaAlmacen)
        Me.KryptonPanel1.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel1.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel1.Controls.Add(Me.txtIncidencia)
        Me.KryptonPanel1.Controls.Add(Me.dteHoraRecepcion)
        Me.KryptonPanel1.Controls.Add(Me.txtCliente)
        Me.KryptonPanel1.Controls.Add(Me.UcPlantaDeEntrega_TxtF011)
        Me.KryptonPanel1.Controls.Add(Me.UcClienteTercero_xtF011)
        Me.KryptonPanel1.Controls.Add(Me.txtContacto)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel13)
        Me.KryptonPanel1.Controls.Add(Me.dteFechaRecepcion)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel14)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel9)
        Me.KryptonPanel1.Controls.Add(Me.txtDescripcion)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel15)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel16)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel8)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel7)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(459, 656)
        Me.KryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel1.TabIndex = 1
        '
        'btnRAlmacenSimple
        '
        Me.btnRAlmacenSimple.Location = New System.Drawing.Point(424, 317)
        Me.btnRAlmacenSimple.Name = "btnRAlmacenSimple"
        Me.btnRAlmacenSimple.Size = New System.Drawing.Size(21, 20)
        Me.btnRAlmacenSimple.TabIndex = 21
        Me.btnRAlmacenSimple.Text = "..."
        Me.btnRAlmacenSimple.UseVisualStyleBackColor = True
        '
        'cbxTipoDocRef
        '
        Me.cbxTipoDocRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocRef.FormattingEnabled = True
        Me.cbxTipoDocRef.Location = New System.Drawing.Point(118, 290)
        Me.cbxTipoDocRef.Name = "cbxTipoDocRef"
        Me.cbxTipoDocRef.Size = New System.Drawing.Size(329, 21)
        Me.cbxTipoDocRef.TabIndex = 20
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(15, 290)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel23.TabIndex = 47
        Me.KryptonLabel23.Text = "Tipo Doc. Ref. :"
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Tipo Doc. Ref. :"
        '
        'ktbxProceso
        '
        Me.ktbxProceso.Enabled = False
        Me.ktbxProceso.Location = New System.Drawing.Point(118, 232)
        Me.ktbxProceso.Name = "ktbxProceso"
        Me.ktbxProceso.Size = New System.Drawing.Size(238, 22)
        Me.ktbxProceso.TabIndex = 46
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(15, 236)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel22.TabIndex = 45
        Me.KryptonLabel22.Text = "Proceso :"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Proceso :"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(325, 597)
        Me.txtEmail.MaxLength = 35
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtEmail.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmail.TabIndex = 44
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(119, 597)
        Me.txtResponsable.MaxLength = 35
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(207, 22)
        Me.txtResponsable.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResponsable.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResponsable.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResponsable.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResponsable.TabIndex = 30
        '
        'ucResponsable
        '
        Me.ucResponsable.BackColor = System.Drawing.Color.Transparent
        Me.ucResponsable.DataSource = Nothing
        Me.ucResponsable.DispleyMember = ""
        Me.ucResponsable.Etiquetas_Form = Nothing
        Me.ucResponsable.ListColumnas = Nothing
        Me.ucResponsable.Location = New System.Drawing.Point(424, 597)
        Me.ucResponsable.Name = "ucResponsable"
        Me.ucResponsable.Obligatorio = False
        Me.ucResponsable.PopupHeight = 0
        Me.ucResponsable.PopupWidth = 0
        Me.ucResponsable.Size = New System.Drawing.Size(22, 22)
        Me.ucResponsable.SizeFont = 0
        Me.ucResponsable.TabIndex = 43
        Me.ucResponsable.ValueMember = ""
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(118, 40)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(329, 21)
        Me.cmbArea.TabIndex = 1
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(15, 42)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel17.TabIndex = 0
        Me.KryptonLabel17.Text = " Área: "
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = " Área: "
        '
        'cmbIncPara
        '
        Me.cmbIncPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIncPara.FormattingEnabled = True
        Me.cmbIncPara.Location = New System.Drawing.Point(118, 152)
        Me.cmbIncPara.Name = "cmbIncPara"
        Me.cmbIncPara.Size = New System.Drawing.Size(329, 21)
        Me.cmbIncPara.TabIndex = 11
        '
        'cmbNegocio
        '
        Me.cmbNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNegocio.FormattingEnabled = True
        Me.cmbNegocio.Location = New System.Drawing.Point(118, 178)
        Me.cmbNegocio.Name = "cmbNegocio"
        Me.cmbNegocio.Size = New System.Drawing.Size(329, 21)
        Me.cmbNegocio.TabIndex = 13
        '
        'txtCantidad
        '
        Me.txtCantidad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.ForeColor = System.Drawing.Color.Transparent
        Me.txtCantidad.Location = New System.Drawing.Point(118, 438)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.NumerosDecimales = 5
        Me.txtCantidad.NumerosEnteros = 10
        Me.txtCantidad.Obligatorio = True
        Me.txtCantidad.Size = New System.Drawing.Size(140, 22)
        Me.txtCantidad.TabIndex = 23
        '
        'txtUnidadCantidad
        '
        Me.txtUnidadCantidad.BackColor = System.Drawing.Color.White
        Me.txtUnidadCantidad.DataSource = Nothing
        Me.txtUnidadCantidad.DispleyMember = ""
        Me.txtUnidadCantidad.Etiquetas_Form = Nothing
        Me.txtUnidadCantidad.ForeColor = System.Drawing.Color.Transparent
        Me.txtUnidadCantidad.ListColumnas = Nothing
        Me.txtUnidadCantidad.Location = New System.Drawing.Point(326, 438)
        Me.txtUnidadCantidad.Name = "txtUnidadCantidad"
        Me.txtUnidadCantidad.Obligatorio = True
        Me.txtUnidadCantidad.PopupHeight = 0
        Me.txtUnidadCantidad.PopupWidth = 0
        Me.txtUnidadCantidad.Size = New System.Drawing.Size(120, 23)
        Me.txtUnidadCantidad.SizeFont = 0
        Me.txtUnidadCantidad.TabIndex = 24
        Me.txtUnidadCantidad.ValueMember = ""
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(266, 441)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel11.TabIndex = 26
        Me.KryptonLabel11.Text = "Unidad :"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Unidad :"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(15, 437)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel10.TabIndex = 24
        Me.KryptonLabel10.Text = "Cantidad :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Cantidad :"
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CodSedeSAP = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.ItemTodos = False
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(118, 67)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDSPSP_CodSedeSAP = Nothing
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = True
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.pRequerido = True
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(331, 23)
        Me.UcPLanta_Cmb011.TabIndex = 3
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(15, 180)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(63, 20)
        Me.KryptonLabel12.TabIndex = 12
        Me.KryptonLabel12.Text = "Negocio :"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Negocio :"
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(15, 68)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel21.TabIndex = 2
        Me.KryptonLabel21.Text = "Planta :"
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Planta :"
        '
        'cboOrigen
        '
        Me.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigen.DropDownWidth = 121
        Me.cboOrigen.FormattingEnabled = False
        Me.cboOrigen.ItemHeight = 15
        Me.cboOrigen.Location = New System.Drawing.Point(118, 122)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(143, 23)
        Me.cboOrigen.TabIndex = 7
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.DropDownWidth = 122
        Me.cboNivel.FormattingEnabled = False
        Me.cboNivel.ItemHeight = 15
        Me.cboNivel.Location = New System.Drawing.Point(340, 123)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(108, 23)
        Me.cboNivel.TabIndex = 9
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(274, 125)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel19.TabIndex = 8
        Me.KryptonLabel19.Text = "Nivel :"
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Nivel :"
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(15, 152)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(62, 20)
        Me.KryptonLabel20.TabIndex = 10
        Me.KryptonLabel20.Text = "Inc. Para :"
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Inc. Para :"
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(15, 126)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(96, 20)
        Me.KryptonLabel18.TabIndex = 6
        Me.KryptonLabel18.Text = "Reportado por :"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Reportado por :"
        '
        'txtDocRefCliente
        '
        Me.txtDocRefCliente.Enabled = False
        Me.txtDocRefCliente.Location = New System.Drawing.Point(119, 316)
        Me.txtDocRefCliente.MaxLength = 50
        Me.txtDocRefCliente.Name = "txtDocRefCliente"
        Me.txtDocRefCliente.Size = New System.Drawing.Size(327, 22)
        Me.txtDocRefCliente.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDocRefCliente.TabIndex = 21
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.txtZonaAlmacen.DataSource = Nothing
        Me.txtZonaAlmacen.DispleyMember = ""
        Me.txtZonaAlmacen.Etiquetas_Form = Nothing
        Me.txtZonaAlmacen.ListColumnas = Nothing
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(118, 516)
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Obligatorio = False
        Me.txtZonaAlmacen.PopupHeight = 0
        Me.txtZonaAlmacen.PopupWidth = 0
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(328, 22)
        Me.txtZonaAlmacen.SizeFont = 0
        Me.txtZonaAlmacen.TabIndex = 27
        Me.txtZonaAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.Etiquetas_Form = Nothing
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(118, 491)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = False
        Me.txtAlmacen.PopupHeight = 0
        Me.txtAlmacen.PopupWidth = 0
        Me.txtAlmacen.Size = New System.Drawing.Size(328, 22)
        Me.txtAlmacen.SizeFont = 0
        Me.txtAlmacen.TabIndex = 26
        Me.txtAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.Etiquetas_Form = Nothing
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(118, 466)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = False
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(328, 22)
        Me.txtTipoAlmacen.SizeFont = 0
        Me.txtTipoAlmacen.TabIndex = 25
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'txtIncidencia
        '
        Me.txtIncidencia.BackColor = System.Drawing.Color.Transparent
        Me.txtIncidencia.DataSource = Nothing
        Me.txtIncidencia.DispleyMember = ""
        Me.txtIncidencia.Etiquetas_Form = Nothing
        Me.txtIncidencia.ListColumnas = Nothing
        Me.txtIncidencia.Location = New System.Drawing.Point(118, 205)
        Me.txtIncidencia.Name = "txtIncidencia"
        Me.txtIncidencia.Obligatorio = True
        Me.txtIncidencia.PopupHeight = 0
        Me.txtIncidencia.PopupWidth = 0
        Me.txtIncidencia.Size = New System.Drawing.Size(329, 22)
        Me.txtIncidencia.SizeFont = 0
        Me.txtIncidencia.TabIndex = 15
        Me.txtIncidencia.ValueMember = ""
        '
        'dteHoraRecepcion
        '
        Me.dteHoraRecepcion.CustomFormat = "H:mm:ss"
        Me.dteHoraRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dteHoraRecepcion.Location = New System.Drawing.Point(340, 262)
        Me.dteHoraRecepcion.Name = "dteHoraRecepcion"
        Me.dteHoraRecepcion.ShowUpDown = True
        Me.dteHoraRecepcion.Size = New System.Drawing.Size(104, 20)
        Me.dteHoraRecepcion.TabIndex = 19
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(118, 94)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(331, 22)
        Me.txtCliente.TabIndex = 5
        '
        'UcPlantaDeEntrega_TxtF011
        '
        Me.UcPlantaDeEntrega_TxtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcPlantaDeEntrega_TxtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcPlantaDeEntrega_TxtF011.CodCliente = 0
        Me.UcPlantaDeEntrega_TxtF011.CodClienteTercero = 0
        Me.UcPlantaDeEntrega_TxtF011.CodigoPlantaCliente = 0
        BePlantaDeEntrega1.PageCount = 0
        BePlantaDeEntrega1.PageNumber = 0
        BePlantaDeEntrega1.PageSize = 0
        BePlantaDeEntrega1.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega1.PSCPLNAF = Nothing
        BePlantaDeEntrega1.PSCPRPCL = Nothing
        BePlantaDeEntrega1.PSSTPORL = Nothing
        BePlantaDeEntrega1.PSTCMPPL = ""
        BePlantaDeEntrega1.PSTDRCPL = ""
        BePlantaDeEntrega1.PSTDRPRC = ""
        BePlantaDeEntrega1.PSTPRVCL = ""
        BePlantaDeEntrega1.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.InfPlantaDeEntrega = BePlantaDeEntrega1
        BePlantaDeEntrega2.PageCount = 0
        BePlantaDeEntrega2.PageNumber = 0
        BePlantaDeEntrega2.PageSize = 0
        BePlantaDeEntrega2.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega2.PSCPLNAF = Nothing
        BePlantaDeEntrega2.PSCPRPCL = Nothing
        BePlantaDeEntrega2.PSSTPORL = Nothing
        BePlantaDeEntrega2.PSTCMPPL = ""
        BePlantaDeEntrega2.PSTDRCPL = ""
        BePlantaDeEntrega2.PSTDRPRC = ""
        BePlantaDeEntrega2.PSTPRVCL = ""
        BePlantaDeEntrega2.TIPOCLIENTE = True
        Me.UcPlantaDeEntrega_TxtF011.ItemActual = BePlantaDeEntrega2
        Me.UcPlantaDeEntrega_TxtF011.Lectura = False
        Me.UcPlantaDeEntrega_TxtF011.Location = New System.Drawing.Point(118, 569)
        Me.UcPlantaDeEntrega_TxtF011.Name = "UcPlantaDeEntrega_TxtF011"
        Me.UcPlantaDeEntrega_TxtF011.Size = New System.Drawing.Size(327, 22)
        Me.UcPlantaDeEntrega_TxtF011.TabIndex = 29
        Me.UcPlantaDeEntrega_TxtF011.TipoPlantaDeEntrega = True
        '
        'UcClienteTercero_xtF011
        '
        Me.UcClienteTercero_xtF011.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcClienteTercero_xtF011.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UcClienteTercero_xtF011.CodCliente = 0
        Me.UcClienteTercero_xtF011.CodigoPlantaCliente = 0
        BePlantaDeEntrega3.PageCount = 0
        BePlantaDeEntrega3.PageNumber = 0
        BePlantaDeEntrega3.PageSize = 0
        BePlantaDeEntrega3.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega3.PSCPLNAF = Nothing
        BePlantaDeEntrega3.PSCPRPCL = Nothing
        BePlantaDeEntrega3.PSSTPORL = Nothing
        BePlantaDeEntrega3.PSTCMPPL = ""
        BePlantaDeEntrega3.PSTDRCPL = ""
        BePlantaDeEntrega3.PSTDRPRC = ""
        BePlantaDeEntrega3.PSTPRVCL = ""
        BePlantaDeEntrega3.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.InfPlantaDeEntrega = BePlantaDeEntrega3
        BePlantaDeEntrega4.PageCount = 0
        BePlantaDeEntrega4.PageNumber = 0
        BePlantaDeEntrega4.PageSize = 0
        BePlantaDeEntrega4.PNCCLNT = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPLCLP = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPLNCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNCPSRVCL = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PNNRUCPR = New Decimal(New Integer() {0, 0, 0, 0})
        BePlantaDeEntrega4.PSCPLNAF = Nothing
        BePlantaDeEntrega4.PSCPRPCL = Nothing
        BePlantaDeEntrega4.PSSTPORL = Nothing
        BePlantaDeEntrega4.PSTCMPPL = ""
        BePlantaDeEntrega4.PSTDRCPL = ""
        BePlantaDeEntrega4.PSTDRPRC = ""
        BePlantaDeEntrega4.PSTPRVCL = ""
        BePlantaDeEntrega4.TIPOCLIENTE = True
        Me.UcClienteTercero_xtF011.ItemActual = BePlantaDeEntrega4
        Me.UcClienteTercero_xtF011.Location = New System.Drawing.Point(118, 543)
        Me.UcClienteTercero_xtF011.MostrarRuc = False
        Me.UcClienteTercero_xtF011.Name = "UcClienteTercero_xtF011"
        Me.UcClienteTercero_xtF011.Ruc = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcClienteTercero_xtF011.Size = New System.Drawing.Size(327, 22)
        Me.UcClienteTercero_xtF011.TabIndex = 28
        Me.UcClienteTercero_xtF011.TipoRelacion = ""
        '
        'txtContacto
        '
        Me.txtContacto.Location = New System.Drawing.Point(118, 625)
        Me.txtContacto.MaxLength = 35
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(328, 22)
        Me.txtContacto.TabIndex = 41
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(15, 623)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel13.TabIndex = 40
        Me.KryptonLabel13.Text = "Contacto :"
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Contacto :"
        '
        'dteFechaRecepcion
        '
        Me.dteFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaRecepcion.Location = New System.Drawing.Point(118, 262)
        Me.dteFechaRecepcion.Name = "dteFechaRecepcion"
        Me.dteFechaRecepcion.Size = New System.Drawing.Size(105, 20)
        Me.dteFechaRecepcion.TabIndex = 17
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(15, 208)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel14.TabIndex = 14
        Me.KryptonLabel14.Text = "Incidencia :"
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Incidencia :"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(15, 492)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel9.TabIndex = 30
        Me.KryptonLabel9.Text = "Almacén :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Almacén :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 346)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(328, 84)
        Me.txtDescripcion.TabIndex = 22
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(15, 317)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(103, 20)
        Me.KryptonLabel15.TabIndex = 20
        Me.KryptonLabel15.Text = "Doc. Ref Cliente :"
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Doc. Ref Cliente :"
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(15, 100)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel16.TabIndex = 4
        Me.KryptonLabel16.Text = "Cliente :"
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Cliente :"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(15, 375)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(80, 20)
        Me.KryptonLabel8.TabIndex = 22
        Me.KryptonLabel8.Text = "Descripción :"
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Descripción :"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(15, 543)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel7.TabIndex = 34
        Me.KryptonLabel7.Text = "Planta :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Planta :"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(15, 569)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel6.TabIndex = 36
        Me.KryptonLabel6.Text = "Tercero :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Tercero :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(15, 597)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel5.TabIndex = 38
        Me.KryptonLabel5.Text = "Responsable :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Responsable :"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 518)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(44, 20)
        Me.KryptonLabel4.TabIndex = 32
        Me.KryptonLabel4.Text = "Zona :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Zona :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 464)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel3.TabIndex = 28
        Me.KryptonLabel3.Text = "Tip. Alm. :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tip. Alm. :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(274, 261)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(59, 20)
        Me.KryptonLabel2.TabIndex = 18
        Me.KryptonLabel2.Text = "Hora Inc:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Hora Inc:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(15, 262)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel1.TabIndex = 16
        Me.KryptonLabel1.Text = "Fecha Inc. :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha Inc. :"
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalir, Me.ToolStripSeparator3, Me.tsbGrabar, Me.ToolStripSeparator1, Me.txtTitulo})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(459, 25)
        Me.tsMenuOpciones.TabIndex = 16
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources._exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        Me.tsbSalir.ToolTipText = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGrabar
        '
        Me.tsbGrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGrabar.Image = Global.Ransa.Controls.Incidencia.My.Resources.Resources.button_ok
        Me.tsbGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGrabar.Name = "tsbGrabar"
        Me.tsbGrabar.Size = New System.Drawing.Size(62, 22)
        Me.tsbGrabar.Text = "&Grabar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(0, 22)
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PSALMACEN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 79
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PSTIPO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PSCPSLL"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pasillo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PSCCLMN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Columna"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 82
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PSCPSCN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Posición"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PSNCRPRD"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Prioridad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 83
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PSMERCADERIA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mercaderia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 93
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PSCLIENTE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PSGRUPO"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Grupo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 69
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PSFAMILIA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Familia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 72
        '
        'frmRegistroIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRegistroIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro incidencia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescripcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContacto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPlantaDeEntrega_TxtF011 As RANSA.Controls.PlantaDeEntrega.ucPlantaDeEntrega_TxtF01
    Friend WithEvents UcClienteTercero_xtF011 As Ransa.Controls.PlantaDeEntrega.ucClienteTercero_xtF01
    'Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents dteHoraRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIncidencia As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtZonaAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtDocRefCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboOrigen As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboNivel As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents txtTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtCantidad As Ransa.Utilitario.UCtxtSoloDecimales
    Friend WithEvents txtUnidadCantidad As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbIncPara As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNegocio As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Private WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtResponsable As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ucResponsable As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtEmail As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ktbxProceso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxTipoDocRef As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnRAlmacenSimple As System.Windows.Forms.Button
End Class
