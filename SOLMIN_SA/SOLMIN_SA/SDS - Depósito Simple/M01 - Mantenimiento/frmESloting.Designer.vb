<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESloting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESloting))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnBuscarPosicion = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnBuscarMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblCodigoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCodigoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtDescMerca01 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtGrupo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaGrupoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtPrioridad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtPosicion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtColumna = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPasillo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.txtAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.txtTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaTipoAlmacenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.txtFamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaFamiliaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.lblFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.btnBuscarPosicion)
        Me.KryptonPanel.Controls.Add(Me.btnBuscarMercaderia)
        Me.KryptonPanel.Controls.Add(Me.lblCodigoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.txtCodigoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.txtDescMerca01)
        Me.KryptonPanel.Controls.Add(Me.txtGrupo)
        Me.KryptonPanel.Controls.Add(Me.txtPrioridad)
        Me.KryptonPanel.Controls.Add(Me.txtPosicion)
        Me.KryptonPanel.Controls.Add(Me.txtColumna)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Controls.Add(Me.txtPasillo)
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.txtAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblAlmacen)
        Me.KryptonPanel.Controls.Add(Me.lblTipoAlmacen)
        Me.KryptonPanel.Controls.Add(Me.txtCliente)
        Me.KryptonPanel.Controls.Add(Me.txtFamilia)
        Me.KryptonPanel.Controls.Add(Me.lblFamilia)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(560, 366)
        Me.KryptonPanel.TabIndex = 0
        '
        'btnBuscarPosicion
        '
        Me.btnBuscarPosicion.Location = New System.Drawing.Point(483, 234)
        Me.btnBuscarPosicion.Name = "btnBuscarPosicion"
        Me.btnBuscarPosicion.Size = New System.Drawing.Size(30, 25)
        Me.btnBuscarPosicion.TabIndex = 26
        Me.btnBuscarPosicion.Text = "..."
        Me.btnBuscarPosicion.Values.ExtraText = ""
        Me.btnBuscarPosicion.Values.Image = Nothing
        Me.btnBuscarPosicion.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscarPosicion.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscarPosicion.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscarPosicion.Values.Text = "..."
        '
        'btnBuscarMercaderia
        '
        Me.btnBuscarMercaderia.Location = New System.Drawing.Point(237, 182)
        Me.btnBuscarMercaderia.Name = "btnBuscarMercaderia"
        Me.btnBuscarMercaderia.Size = New System.Drawing.Size(35, 25)
        Me.btnBuscarMercaderia.TabIndex = 25
        Me.btnBuscarMercaderia.Text = "..."
        Me.btnBuscarMercaderia.Values.ExtraText = ""
        Me.btnBuscarMercaderia.Values.Image = Nothing
        Me.btnBuscarMercaderia.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnBuscarMercaderia.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnBuscarMercaderia.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnBuscarMercaderia.Values.Text = "..."
        '
        'lblCodigoMercaderia
        '
        Me.lblCodigoMercaderia.Location = New System.Drawing.Point(14, 188)
        Me.lblCodigoMercaderia.Name = "lblCodigoMercaderia"
        Me.lblCodigoMercaderia.Size = New System.Drawing.Size(98, 19)
        Me.lblCodigoMercaderia.TabIndex = 11
        Me.lblCodigoMercaderia.Text = "Cod. Mercadería : "
        Me.lblCodigoMercaderia.Values.ExtraText = ""
        Me.lblCodigoMercaderia.Values.Image = Nothing
        Me.lblCodigoMercaderia.Values.Text = "Cod. Mercadería : "
        '
        'txtCodigoMercaderia
        '
        Me.txtCodigoMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoMercaderia.Location = New System.Drawing.Point(118, 186)
        Me.txtCodigoMercaderia.MaxLength = 30
        Me.txtCodigoMercaderia.Name = "txtCodigoMercaderia"
        Me.txtCodigoMercaderia.Size = New System.Drawing.Size(113, 21)
        Me.txtCodigoMercaderia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoMercaderia.TabIndex = 12
        '
        'txtDescMerca01
        '
        Me.txtDescMerca01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescMerca01.Location = New System.Drawing.Point(118, 213)
        Me.txtDescMerca01.MaxLength = 50
        Me.txtDescMerca01.Name = "txtDescMerca01"
        Me.txtDescMerca01.Size = New System.Drawing.Size(395, 21)
        Me.txtDescMerca01.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescMerca01.TabIndex = 15
        '
        'txtGrupo
        '
        Me.txtGrupo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaGrupoListar})
        Me.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupo.Location = New System.Drawing.Point(118, 159)
        Me.txtGrupo.MaxLength = 30
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(395, 21)
        Me.txtGrupo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGrupo.TabIndex = 10
        '
        'bsaGrupoListar
        '
        Me.bsaGrupoListar.ExtraText = ""
        Me.bsaGrupoListar.Image = Nothing
        Me.bsaGrupoListar.Text = ""
        Me.bsaGrupoListar.ToolTipImage = Nothing
        Me.bsaGrupoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaGrupoListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'txtPrioridad
        '
        Me.txtPrioridad.Location = New System.Drawing.Point(118, 321)
        Me.txtPrioridad.Name = "txtPrioridad"
        Me.txtPrioridad.Size = New System.Drawing.Size(395, 21)
        Me.txtPrioridad.TabIndex = 24
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(118, 238)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(359, 21)
        Me.txtPosicion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPosicion.TabIndex = 22
        '
        'txtColumna
        '
        Me.txtColumna.Location = New System.Drawing.Point(118, 290)
        Me.txtColumna.Name = "txtColumna"
        Me.txtColumna.Size = New System.Drawing.Size(359, 21)
        Me.txtColumna.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtColumna.TabIndex = 20
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(54, 323)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(58, 19)
        Me.KryptonLabel6.TabIndex = 23
        Me.KryptonLabel6.Text = "Prioridad:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Prioridad:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(43, 215)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(69, 19)
        Me.KryptonLabel5.TabIndex = 14
        Me.KryptonLabel5.Text = "Mercaderia:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Mercaderia:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(68, 161)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Text = "Grupo:"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Grupo:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(58, 240)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(54, 19)
        Me.KryptonLabel3.TabIndex = 21
        Me.KryptonLabel3.Text = "Posición:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Posición:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(55, 292)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(57, 19)
        Me.KryptonLabel2.TabIndex = 19
        Me.KryptonLabel2.Text = "Columna:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Columna:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(68, 265)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(44, 19)
        Me.KryptonLabel1.TabIndex = 17
        Me.KryptonLabel1.Text = "Pasillo:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Pasillo:"
        '
        'txtPasillo
        '
        Me.txtPasillo.Location = New System.Drawing.Point(118, 263)
        Me.txtPasillo.Name = "txtPasillo"
        Me.txtPasillo.Size = New System.Drawing.Size(359, 21)
        Me.txtPasillo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPasillo.TabIndex = 18
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.tsbGuardar, Me.ToolStripSeparator3})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(560, 25)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripLabel1.Tag = "SLOTING"
        Me.ToolStripLabel1.Text = "SLOTING EDICION"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripButton2.Text = "&Cancelar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaAlmacenListar})
        Me.txtAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacen.Location = New System.Drawing.Point(118, 105)
        Me.txtAlmacen.MaxLength = 50
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Size = New System.Drawing.Size(395, 21)
        Me.txtAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAlmacen.TabIndex = 4
        '
        'bsaAlmacenListar
        '
        Me.bsaAlmacenListar.ExtraText = ""
        Me.bsaAlmacenListar.Image = Nothing
        Me.bsaAlmacenListar.Text = ""
        Me.bsaAlmacenListar.ToolTipImage = Nothing
        Me.bsaAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaAlmacenListar.UniqueName = "9BC1C9592405475E9BC1C9592405475E"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoAlmacenListar})
        Me.txtTipoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(118, 78)
        Me.txtTipoAlmacen.MaxLength = 50
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(395, 21)
        Me.txtTipoAlmacen.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoAlmacen.TabIndex = 2
        '
        'bsaTipoAlmacenListar
        '
        Me.bsaTipoAlmacenListar.ExtraText = ""
        Me.bsaTipoAlmacenListar.Image = Nothing
        Me.bsaTipoAlmacenListar.Text = ""
        Me.bsaTipoAlmacenListar.ToolTipImage = Nothing
        Me.bsaTipoAlmacenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoAlmacenListar.UniqueName = "A81EDC60E5B049C0A81EDC60E5B049C0"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(53, 107)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(59, 19)
        Me.lblAlmacen.TabIndex = 3
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(74, 80)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(38, 19)
        Me.lblTipoAlmacen.TabIndex = 1
        Me.lblTipoAlmacen.Text = "Tipo : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo : "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(118, 51)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(395, 21)
        Me.txtCliente.TabIndex = 6
        '
        'txtFamilia
        '
        Me.txtFamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaFamiliaListar})
        Me.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFamilia.Location = New System.Drawing.Point(118, 132)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(395, 21)
        Me.txtFamilia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFamilia.TabIndex = 8
        '
        'bsaFamiliaListar
        '
        Me.bsaFamiliaListar.ExtraText = ""
        Me.bsaFamiliaListar.Image = Nothing
        Me.bsaFamiliaListar.Text = ""
        Me.bsaFamiliaListar.ToolTipImage = Nothing
        Me.bsaFamiliaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaFamiliaListar.UniqueName = "F3380058F2EE4F7FF3380058F2EE4F7F"
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(61, 134)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(51, 19)
        Me.lblFamilia.TabIndex = 7
        Me.lblFamilia.Text = "Familia : "
        Me.lblFamilia.Values.ExtraText = ""
        Me.lblFamilia.Values.Image = Nothing
        Me.lblFamilia.Values.Text = "Familia : "
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(62, 53)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmESloting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 366)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmESloting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sugerencia Ubicacion Mercaderia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtFamilia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaFamiliaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaTipoAlmacenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPasillo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPosicion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtColumna As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPrioridad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtGrupo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaGrupoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtCodigoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescMerca01 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnBuscarMercaderia As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnBuscarPosicion As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
