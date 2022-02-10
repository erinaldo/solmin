<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMercaderiaSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMercaderiaSDS))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.chkControlLote = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.chkMarcaSerie = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtPartidaArancelaria = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPartidaArancelaria = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtProveedor = New Ransa.Controls.Proveedor.ucProveedor_TxtF01()
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01()
        Me.ssMenuInformativo = New System.Windows.Forms.StatusStrip()
        Me.tssMsjGuardar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssMsjCancelar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtCostoPromSoles = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtFamilia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaFamiliaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblCostoPromSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCostoPromProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblFamilia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCostoPromProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadMinProducir = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCantidadMinProducir = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblGrupo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtVolumenEquivalente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtGrupo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaGrupoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblVolumenEquivalente = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCodigoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblUnidadInventario = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCodigoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadInventario = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDescMerca = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblCodigoRANSA = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblFechaInventario = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkPublicacionWEB = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMoneda = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaMonedaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblCodigoReemplazo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescMerca02 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPesoDeclarado = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMensajeMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblValorXMts2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescuento = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDUN14 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblValorVentaSoles = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEAN13 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblValorVentaDolar = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTiempoDescarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTiempoCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblPesoMinServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAreaMts2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblMoneda = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblVolumenMts3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblCostoProveedor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblLargoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFechaVencimiento = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.lblAnchoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkMarcaControl = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblAlturaMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoMinServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblRotacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtApilabilidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaApilabilidadListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblPerfumancia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtRotacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblInflamable = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAlturaMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblApilabilidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtLargoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadMinServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAreaMts2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidadMercReorden = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtInflamable = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaInflamableListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblPesoMercReorden = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadMinServicio = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTiempoCarga = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoMercReorden = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblTiempoDescarga = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadMercReorden = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDUN14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtVolumenMts3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblEAN13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoDeclarado = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDescMerca01 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCostoProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtMarcaModelo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCodigoRANSA = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaCodigoRANSAListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtCodigoReemplazo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaCodigoReemplazoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtValorXMts2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtValorVentaSoles = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUnidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtDescuento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUbicacion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtValorVentaDolar = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAnchoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtPerfumancia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaPerfumanciaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.tsMenuOpciones.SuspendLayout()
        Me.ssMenuInformativo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.tsMenuOpciones)
        Me.KryptonPanel.Controls.Add(Me.chkControlLote)
        Me.KryptonPanel.Controls.Add(Me.chkMarcaSerie)
        Me.KryptonPanel.Controls.Add(Me.txtPartidaArancelaria)
        Me.KryptonPanel.Controls.Add(Me.lblPartidaArancelaria)
        Me.KryptonPanel.Controls.Add(Me.txtProveedor)
        Me.KryptonPanel.Controls.Add(Me.txtCliente)
        Me.KryptonPanel.Controls.Add(Me.ssMenuInformativo)
        Me.KryptonPanel.Controls.Add(Me.txtCostoPromSoles)
        Me.KryptonPanel.Controls.Add(Me.txtFamilia)
        Me.KryptonPanel.Controls.Add(Me.lblCostoPromSoles)
        Me.KryptonPanel.Controls.Add(Me.txtCostoPromProveedor)
        Me.KryptonPanel.Controls.Add(Me.lblFamilia)
        Me.KryptonPanel.Controls.Add(Me.lblCostoPromProveedor)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadMinProducir)
        Me.KryptonPanel.Controls.Add(Me.lblCliente)
        Me.KryptonPanel.Controls.Add(Me.lblCantidadMinProducir)
        Me.KryptonPanel.Controls.Add(Me.lblGrupo)
        Me.KryptonPanel.Controls.Add(Me.txtVolumenEquivalente)
        Me.KryptonPanel.Controls.Add(Me.txtGrupo)
        Me.KryptonPanel.Controls.Add(Me.lblVolumenEquivalente)
        Me.KryptonPanel.Controls.Add(Me.txtCodigoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.lblUnidadInventario)
        Me.KryptonPanel.Controls.Add(Me.lblCodigoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.txtUnidadInventario)
        Me.KryptonPanel.Controls.Add(Me.txtDescMerca)
        Me.KryptonPanel.Controls.Add(Me.txtFechaInventario)
        Me.KryptonPanel.Controls.Add(Me.lblCodigoRANSA)
        Me.KryptonPanel.Controls.Add(Me.lblFechaInventario)
        Me.KryptonPanel.Controls.Add(Me.lblMarcaModelo)
        Me.KryptonPanel.Controls.Add(Me.chkPublicacionWEB)
        Me.KryptonPanel.Controls.Add(Me.lblProveedor)
        Me.KryptonPanel.Controls.Add(Me.txtMoneda)
        Me.KryptonPanel.Controls.Add(Me.lblCodigoReemplazo)
        Me.KryptonPanel.Controls.Add(Me.lblUbicacion)
        Me.KryptonPanel.Controls.Add(Me.txtDescMerca02)
        Me.KryptonPanel.Controls.Add(Me.lblPesoDeclarado)
        Me.KryptonPanel.Controls.Add(Me.lblMensajeMercaderia)
        Me.KryptonPanel.Controls.Add(Me.lblValorXMts2)
        Me.KryptonPanel.Controls.Add(Me.PictureBox1)
        Me.KryptonPanel.Controls.Add(Me.lblDescuento)
        Me.KryptonPanel.Controls.Add(Me.txtDUN14)
        Me.KryptonPanel.Controls.Add(Me.lblValorVentaSoles)
        Me.KryptonPanel.Controls.Add(Me.txtEAN13)
        Me.KryptonPanel.Controls.Add(Me.lblValorVentaDolar)
        Me.KryptonPanel.Controls.Add(Me.txtTiempoDescarga)
        Me.KryptonPanel.Controls.Add(Me.lblFechaVencimiento)
        Me.KryptonPanel.Controls.Add(Me.txtTiempoCarga)
        Me.KryptonPanel.Controls.Add(Me.lblObservaciones)
        Me.KryptonPanel.Controls.Add(Me.lblPesoMinServicio)
        Me.KryptonPanel.Controls.Add(Me.lblAreaMts2)
        Me.KryptonPanel.Controls.Add(Me.lblMoneda)
        Me.KryptonPanel.Controls.Add(Me.lblVolumenMts3)
        Me.KryptonPanel.Controls.Add(Me.lblCostoProveedor)
        Me.KryptonPanel.Controls.Add(Me.lblLargoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.txtFechaVencimiento)
        Me.KryptonPanel.Controls.Add(Me.lblAnchoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.chkMarcaControl)
        Me.KryptonPanel.Controls.Add(Me.lblAlturaMercaderia)
        Me.KryptonPanel.Controls.Add(Me.txtPesoMinServicio)
        Me.KryptonPanel.Controls.Add(Me.lblRotacion)
        Me.KryptonPanel.Controls.Add(Me.txtApilabilidad)
        Me.KryptonPanel.Controls.Add(Me.lblPerfumancia)
        Me.KryptonPanel.Controls.Add(Me.txtRotacion)
        Me.KryptonPanel.Controls.Add(Me.lblInflamable)
        Me.KryptonPanel.Controls.Add(Me.txtAlturaMercaderia)
        Me.KryptonPanel.Controls.Add(Me.lblApilabilidad)
        Me.KryptonPanel.Controls.Add(Me.txtLargoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.lblCantidadMinServicio)
        Me.KryptonPanel.Controls.Add(Me.txtAreaMts2)
        Me.KryptonPanel.Controls.Add(Me.lblCantidadMercReorden)
        Me.KryptonPanel.Controls.Add(Me.txtInflamable)
        Me.KryptonPanel.Controls.Add(Me.lblPesoMercReorden)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadMinServicio)
        Me.KryptonPanel.Controls.Add(Me.lblTiempoCarga)
        Me.KryptonPanel.Controls.Add(Me.txtPesoMercReorden)
        Me.KryptonPanel.Controls.Add(Me.lblTiempoDescarga)
        Me.KryptonPanel.Controls.Add(Me.txtCantidadMercReorden)
        Me.KryptonPanel.Controls.Add(Me.lblDUN14)
        Me.KryptonPanel.Controls.Add(Me.txtVolumenMts3)
        Me.KryptonPanel.Controls.Add(Me.lblEAN13)
        Me.KryptonPanel.Controls.Add(Me.txtPesoDeclarado)
        Me.KryptonPanel.Controls.Add(Me.txtDescMerca01)
        Me.KryptonPanel.Controls.Add(Me.txtCostoProveedor)
        Me.KryptonPanel.Controls.Add(Me.txtMarcaModelo)
        Me.KryptonPanel.Controls.Add(Me.txtCodigoRANSA)
        Me.KryptonPanel.Controls.Add(Me.txtCodigoReemplazo)
        Me.KryptonPanel.Controls.Add(Me.txtValorXMts2)
        Me.KryptonPanel.Controls.Add(Me.txtObservaciones)
        Me.KryptonPanel.Controls.Add(Me.txtValorVentaSoles)
        Me.KryptonPanel.Controls.Add(Me.txtUnidad)
        Me.KryptonPanel.Controls.Add(Me.txtDescuento)
        Me.KryptonPanel.Controls.Add(Me.txtUbicacion)
        Me.KryptonPanel.Controls.Add(Me.txtValorVentaDolar)
        Me.KryptonPanel.Controls.Add(Me.txtAnchoMercaderia)
        Me.KryptonPanel.Controls.Add(Me.txtPerfumancia)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1013, 770)
        Me.KryptonPanel.StateCommon.Color1 = System.Drawing.Color.White
        Me.KryptonPanel.TabIndex = 0
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.btnGuardar})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1013, 27)
        Me.tsMenuOpciones.TabIndex = 146
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGuardar.Image = Global.SOLMIN_SA.My.Resources.Resources.filesave
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.btnGuardar.Text = "Guardar"
        '
        'chkControlLote
        '
        Me.chkControlLote.Checked = False
        Me.chkControlLote.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkControlLote.Location = New System.Drawing.Point(537, 168)
        Me.chkControlLote.Margin = New System.Windows.Forms.Padding(4)
        Me.chkControlLote.Name = "chkControlLote"
        Me.chkControlLote.Size = New System.Drawing.Size(137, 24)
        Me.chkControlLote.TabIndex = 8
        Me.chkControlLote.Text = "Control por Lote"
        Me.chkControlLote.Values.ExtraText = ""
        Me.chkControlLote.Values.Image = Nothing
        Me.chkControlLote.Values.Text = "Control por Lote"
        '
        'chkMarcaSerie
        '
        Me.chkMarcaSerie.Checked = False
        Me.chkMarcaSerie.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMarcaSerie.Location = New System.Drawing.Point(537, 140)
        Me.chkMarcaSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMarcaSerie.Name = "chkMarcaSerie"
        Me.chkMarcaSerie.Size = New System.Drawing.Size(147, 24)
        Me.chkMarcaSerie.TabIndex = 6
        Me.chkMarcaSerie.Text = "Control por Series"
        Me.chkMarcaSerie.Values.ExtraText = ""
        Me.chkMarcaSerie.Values.Image = Nothing
        Me.chkMarcaSerie.Values.Text = "Control por Series"
        '
        'txtPartidaArancelaria
        '
        Me.txtPartidaArancelaria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPartidaArancelaria.Location = New System.Drawing.Point(856, 686)
        Me.txtPartidaArancelaria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPartidaArancelaria.MaxLength = 20
        Me.txtPartidaArancelaria.Name = "txtPartidaArancelaria"
        Me.txtPartidaArancelaria.Size = New System.Drawing.Size(135, 26)
        Me.txtPartidaArancelaria.TabIndex = 49
        '
        'lblPartidaArancelaria
        '
        Me.lblPartidaArancelaria.Location = New System.Drawing.Point(697, 690)
        Me.lblPartidaArancelaria.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPartidaArancelaria.Name = "lblPartidaArancelaria"
        Me.lblPartidaArancelaria.Size = New System.Drawing.Size(147, 24)
        Me.lblPartidaArancelaria.TabIndex = 145
        Me.lblPartidaArancelaria.Text = "Partida Arancelaria : "
        Me.lblPartidaArancelaria.Values.ExtraText = ""
        Me.lblPartidaArancelaria.Values.Image = Nothing
        Me.lblPartidaArancelaria.Values.Text = "Partida Arancelaria : "
        '
        'txtProveedor
        '
        Me.txtProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtProveedor.BackColor = System.Drawing.Color.Transparent
        Me.txtProveedor.Location = New System.Drawing.Point(189, 317)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(5)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.pCodigo = CType(0, Long)
        Me.txtProveedor.pMostarBtnNewProv = False
        Me.txtProveedor.pRequerido = True
        Me.txtProveedor.Size = New System.Drawing.Size(472, 26)
        Me.txtProveedor.TabIndex = 14
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(189, 55)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(472, 26)
        Me.txtCliente.TabIndex = 1
        '
        'ssMenuInformativo
        '
        Me.ssMenuInformativo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssMenuInformativo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssMsjGuardar, Me.tssMsjCancelar})
        Me.ssMenuInformativo.Location = New System.Drawing.Point(0, 748)
        Me.ssMenuInformativo.Name = "ssMenuInformativo"
        Me.ssMenuInformativo.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.ssMenuInformativo.Size = New System.Drawing.Size(1013, 22)
        Me.ssMenuInformativo.TabIndex = 143
        Me.ssMenuInformativo.Text = "StatusStrip1"
        '
        'tssMsjGuardar
        '
        Me.tssMsjGuardar.AutoSize = False
        Me.tssMsjGuardar.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssMsjGuardar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tssMsjGuardar.ForeColor = System.Drawing.Color.DarkBlue
        Me.tssMsjGuardar.Image = CType(resources.GetObject("tssMsjGuardar.Image"), System.Drawing.Image)
        Me.tssMsjGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tssMsjGuardar.Name = "tssMsjGuardar"
        Me.tssMsjGuardar.Size = New System.Drawing.Size(250, 17)
        Me.tssMsjGuardar.Text = "(F2) - GUARDAR INFORMACION"
        Me.tssMsjGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssMsjCancelar
        '
        Me.tssMsjCancelar.AutoSize = False
        Me.tssMsjCancelar.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tssMsjCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tssMsjCancelar.ForeColor = System.Drawing.Color.DarkBlue
        Me.tssMsjCancelar.Image = CType(resources.GetObject("tssMsjCancelar.Image"), System.Drawing.Image)
        Me.tssMsjCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tssMsjCancelar.Name = "tssMsjCancelar"
        Me.tssMsjCancelar.Size = New System.Drawing.Size(150, 17)
        Me.tssMsjCancelar.Text = "(ESC) - Cancelar"
        Me.tssMsjCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCostoPromSoles
        '
        Me.txtCostoPromSoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoPromSoles.Enabled = False
        Me.txtCostoPromSoles.Location = New System.Drawing.Point(189, 409)
        Me.txtCostoPromSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostoPromSoles.MaxLength = 10
        Me.txtCostoPromSoles.Name = "txtCostoPromSoles"
        Me.txtCostoPromSoles.Size = New System.Drawing.Size(107, 26)
        Me.txtCostoPromSoles.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCostoPromSoles.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCostoPromSoles.TabIndex = 21
        Me.txtCostoPromSoles.Text = "0.000"
        Me.txtCostoPromSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFamilia
        '
        Me.txtFamilia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaFamiliaListar})
        Me.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFamilia.Location = New System.Drawing.Point(189, 137)
        Me.txtFamilia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(335, 26)
        Me.txtFamilia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFamilia.TabIndex = 5
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
        'lblCostoPromSoles
        '
        Me.lblCostoPromSoles.Location = New System.Drawing.Point(17, 413)
        Me.lblCostoPromSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCostoPromSoles.Name = "lblCostoPromSoles"
        Me.lblCostoPromSoles.Size = New System.Drawing.Size(142, 24)
        Me.lblCostoPromSoles.TabIndex = 35
        Me.lblCostoPromSoles.Text = "Costo Prom. Soles : "
        Me.lblCostoPromSoles.Values.ExtraText = ""
        Me.lblCostoPromSoles.Values.Image = Nothing
        Me.lblCostoPromSoles.Values.Text = "Costo Prom. Soles : "
        '
        'txtCostoPromProveedor
        '
        Me.txtCostoPromProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoPromProveedor.Enabled = False
        Me.txtCostoPromProveedor.Location = New System.Drawing.Point(884, 378)
        Me.txtCostoPromProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostoPromProveedor.MaxLength = 10
        Me.txtCostoPromProveedor.Name = "txtCostoPromProveedor"
        Me.txtCostoPromProveedor.Size = New System.Drawing.Size(107, 26)
        Me.txtCostoPromProveedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCostoPromProveedor.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCostoPromProveedor.TabIndex = 20
        Me.txtCostoPromProveedor.Text = "0.000"
        Me.txtCostoPromProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(17, 142)
        Me.lblFamilia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(67, 20)
        Me.lblFamilia.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamilia.TabIndex = 8
        Me.lblFamilia.Text = "Familia : "
        Me.lblFamilia.Values.ExtraText = ""
        Me.lblFamilia.Values.Image = Nothing
        Me.lblFamilia.Values.Text = "Familia : "
        '
        'lblCostoPromProveedor
        '
        Me.lblCostoPromProveedor.Location = New System.Drawing.Point(697, 382)
        Me.lblCostoPromProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCostoPromProveedor.Name = "lblCostoPromProveedor"
        Me.lblCostoPromProveedor.Size = New System.Drawing.Size(177, 24)
        Me.lblCostoPromProveedor.TabIndex = 33
        Me.lblCostoPromProveedor.Text = "Costo Prom. Proveedor : "
        Me.lblCostoPromProveedor.Values.ExtraText = ""
        Me.lblCostoPromProveedor.Values.Image = Nothing
        Me.lblCostoPromProveedor.Values.Text = "Costo Prom. Proveedor : "
        '
        'txtCantidadMinProducir
        '
        Me.txtCantidadMinProducir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadMinProducir.Enabled = False
        Me.txtCantidadMinProducir.Location = New System.Drawing.Point(554, 686)
        Me.txtCantidadMinProducir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadMinProducir.MaxLength = 10
        Me.txtCantidadMinProducir.Name = "txtCantidadMinProducir"
        Me.txtCantidadMinProducir.Size = New System.Drawing.Size(107, 26)
        Me.txtCantidadMinProducir.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCantidadMinProducir.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCantidadMinProducir.TabIndex = 48
        Me.txtCantidadMinProducir.Text = "0.000"
        Me.txtCantidadMinProducir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(17, 58)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(73, 20)
        Me.lblCliente.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "CLIENTE"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "CLIENTE"
        '
        'lblCantidadMinProducir
        '
        Me.lblCantidadMinProducir.Location = New System.Drawing.Point(378, 690)
        Me.lblCantidadMinProducir.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadMinProducir.Name = "lblCantidadMinProducir"
        Me.lblCantidadMinProducir.Size = New System.Drawing.Size(149, 24)
        Me.lblCantidadMinProducir.TabIndex = 88
        Me.lblCantidadMinProducir.Text = "Cant. Min. Producir : "
        Me.lblCantidadMinProducir.Values.ExtraText = ""
        Me.lblCantidadMinProducir.Values.Image = Nothing
        Me.lblCantidadMinProducir.Values.Text = "Cant. Min. Producir : "
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(17, 173)
        Me.lblGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(60, 20)
        Me.lblGrupo.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.TabIndex = 10
        Me.lblGrupo.Text = "Grupo : "
        Me.lblGrupo.Values.ExtraText = ""
        Me.lblGrupo.Values.Image = Nothing
        Me.lblGrupo.Values.Text = "Grupo : "
        '
        'txtVolumenEquivalente
        '
        Me.txtVolumenEquivalente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVolumenEquivalente.Enabled = False
        Me.txtVolumenEquivalente.Location = New System.Drawing.Point(884, 655)
        Me.txtVolumenEquivalente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolumenEquivalente.MaxLength = 10
        Me.txtVolumenEquivalente.Name = "txtVolumenEquivalente"
        Me.txtVolumenEquivalente.Size = New System.Drawing.Size(107, 26)
        Me.txtVolumenEquivalente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtVolumenEquivalente.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtVolumenEquivalente.TabIndex = 46
        Me.txtVolumenEquivalente.Text = "0.000"
        Me.txtVolumenEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGrupo
        '
        Me.txtGrupo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaGrupoListar})
        Me.txtGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGrupo.Location = New System.Drawing.Point(189, 169)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrupo.MaxLength = 30
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(335, 26)
        Me.txtGrupo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGrupo.TabIndex = 7
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
        'lblVolumenEquivalente
        '
        Me.lblVolumenEquivalente.Location = New System.Drawing.Point(697, 659)
        Me.lblVolumenEquivalente.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVolumenEquivalente.Name = "lblVolumenEquivalente"
        Me.lblVolumenEquivalente.Size = New System.Drawing.Size(163, 24)
        Me.lblVolumenEquivalente.TabIndex = 84
        Me.lblVolumenEquivalente.Text = "Volumen Equivalente : "
        Me.lblVolumenEquivalente.Values.ExtraText = ""
        Me.lblVolumenEquivalente.Values.Image = Nothing
        Me.lblVolumenEquivalente.Values.Text = "Volumen Equivalente : "
        '
        'txtCodigoMercaderia
        '
        Me.txtCodigoMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoMercaderia.Location = New System.Drawing.Point(189, 86)
        Me.txtCodigoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoMercaderia.MaxLength = 30
        Me.txtCodigoMercaderia.Name = "txtCodigoMercaderia"
        Me.txtCodigoMercaderia.Size = New System.Drawing.Size(335, 26)
        Me.txtCodigoMercaderia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoMercaderia.TabIndex = 2
        '
        'lblUnidadInventario
        '
        Me.lblUnidadInventario.Location = New System.Drawing.Point(378, 659)
        Me.lblUnidadInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUnidadInventario.Name = "lblUnidadInventario"
        Me.lblUnidadInventario.Size = New System.Drawing.Size(141, 24)
        Me.lblUnidadInventario.TabIndex = 82
        Me.lblUnidadInventario.Text = "Unidad Inventario : "
        Me.lblUnidadInventario.Values.ExtraText = ""
        Me.lblUnidadInventario.Values.Image = Nothing
        Me.lblUnidadInventario.Values.Text = "Unidad Inventario : "
        '
        'lblCodigoMercaderia
        '
        Me.lblCodigoMercaderia.Location = New System.Drawing.Point(17, 89)
        Me.lblCodigoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodigoMercaderia.Name = "lblCodigoMercaderia"
        Me.lblCodigoMercaderia.Size = New System.Drawing.Size(149, 24)
        Me.lblCodigoMercaderia.TabIndex = 3
        Me.lblCodigoMercaderia.Text = "Código Mercadería : "
        Me.lblCodigoMercaderia.Values.ExtraText = ""
        Me.lblCodigoMercaderia.Values.Image = Nothing
        Me.lblCodigoMercaderia.Values.Text = "Código Mercadería : "
        '
        'txtUnidadInventario
        '
        Me.txtUnidadInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidadInventario.Enabled = False
        Me.txtUnidadInventario.Location = New System.Drawing.Point(554, 655)
        Me.txtUnidadInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidadInventario.MaxLength = 3
        Me.txtUnidadInventario.Name = "txtUnidadInventario"
        Me.txtUnidadInventario.Size = New System.Drawing.Size(59, 26)
        Me.txtUnidadInventario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUnidadInventario.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUnidadInventario.TabIndex = 45
        '
        'txtDescMerca
        '
        Me.txtDescMerca.Location = New System.Drawing.Point(17, 205)
        Me.txtDescMerca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescMerca.Name = "txtDescMerca"
        Me.txtDescMerca.Size = New System.Drawing.Size(99, 24)
        Me.txtDescMerca.TabIndex = 12
        Me.txtDescMerca.Text = "Descripción : "
        Me.txtDescMerca.Values.ExtraText = ""
        Me.txtDescMerca.Values.Image = Nothing
        Me.txtDescMerca.Values.Text = "Descripción : "
        '
        'txtFechaInventario
        '
        Me.txtFechaInventario.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaInventario.Enabled = False
        Me.txtFechaInventario.Location = New System.Drawing.Point(884, 625)
        Me.txtFechaInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaInventario.Mask = "##/##/####"
        Me.txtFechaInventario.Name = "txtFechaInventario"
        Me.txtFechaInventario.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaInventario.Size = New System.Drawing.Size(107, 26)
        Me.txtFechaInventario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFechaInventario.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtFechaInventario.TabIndex = 43
        Me.txtFechaInventario.Text = "  /  /"
        '
        'lblCodigoRANSA
        '
        Me.lblCodigoRANSA.Location = New System.Drawing.Point(17, 259)
        Me.lblCodigoRANSA.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodigoRANSA.Name = "lblCodigoRANSA"
        Me.lblCodigoRANSA.Size = New System.Drawing.Size(103, 24)
        Me.lblCodigoRANSA.TabIndex = 15
        Me.lblCodigoRANSA.Text = "Cód. RANSA : "
        Me.lblCodigoRANSA.Values.ExtraText = ""
        Me.lblCodigoRANSA.Values.Image = Nothing
        Me.lblCodigoRANSA.Values.Text = "Cód. RANSA : "
        '
        'lblFechaInventario
        '
        Me.lblFechaInventario.Location = New System.Drawing.Point(697, 628)
        Me.lblFechaInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaInventario.Name = "lblFechaInventario"
        Me.lblFechaInventario.Size = New System.Drawing.Size(131, 24)
        Me.lblFechaInventario.TabIndex = 78
        Me.lblFechaInventario.Text = "Fecha Inventario : "
        Me.lblFechaInventario.Values.ExtraText = ""
        Me.lblFechaInventario.Values.Image = Nothing
        Me.lblFechaInventario.Values.Text = "Fecha Inventario : "
        '
        'lblMarcaModelo
        '
        Me.lblMarcaModelo.Location = New System.Drawing.Point(17, 290)
        Me.lblMarcaModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMarcaModelo.Name = "lblMarcaModelo"
        Me.lblMarcaModelo.Size = New System.Drawing.Size(129, 24)
        Me.lblMarcaModelo.TabIndex = 17
        Me.lblMarcaModelo.Text = "Marca / Modelo : "
        Me.lblMarcaModelo.Values.ExtraText = ""
        Me.lblMarcaModelo.Values.Image = Nothing
        Me.lblMarcaModelo.Values.Text = "Marca / Modelo : "
        '
        'chkPublicacionWEB
        '
        Me.chkPublicacionWEB.Checked = False
        Me.chkPublicacionWEB.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkPublicacionWEB.Location = New System.Drawing.Point(537, 113)
        Me.chkPublicacionWEB.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPublicacionWEB.Name = "chkPublicacionWEB"
        Me.chkPublicacionWEB.Size = New System.Drawing.Size(151, 24)
        Me.chkPublicacionWEB.TabIndex = 4
        Me.chkPublicacionWEB.Text = "Publicar en la WEB"
        Me.chkPublicacionWEB.Values.ExtraText = ""
        Me.chkPublicacionWEB.Values.Image = Nothing
        Me.chkPublicacionWEB.Values.Text = "Publicar en la WEB"
        '
        'lblProveedor
        '
        Me.lblProveedor.Location = New System.Drawing.Point(17, 321)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(89, 24)
        Me.lblProveedor.TabIndex = 21
        Me.lblProveedor.Text = "Proveedor : "
        Me.lblProveedor.Values.ExtraText = ""
        Me.lblProveedor.Values.Image = Nothing
        Me.lblProveedor.Values.Text = "Proveedor : "
        '
        'txtMoneda
        '
        Me.txtMoneda.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaMonedaListar})
        Me.txtMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMoneda.Location = New System.Drawing.Point(496, 378)
        Me.txtMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMoneda.MaxLength = 25
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.Size = New System.Drawing.Size(165, 26)
        Me.txtMoneda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMoneda.TabIndex = 19
        '
        'bsaMonedaListar
        '
        Me.bsaMonedaListar.ExtraText = ""
        Me.bsaMonedaListar.Image = Nothing
        Me.bsaMonedaListar.Text = ""
        Me.bsaMonedaListar.ToolTipImage = Nothing
        Me.bsaMonedaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaMonedaListar.UniqueName = "261D51B198E0477E261D51B198E0477E"
        '
        'lblCodigoReemplazo
        '
        Me.lblCodigoReemplazo.Location = New System.Drawing.Point(697, 290)
        Me.lblCodigoReemplazo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodigoReemplazo.Name = "lblCodigoReemplazo"
        Me.lblCodigoReemplazo.Size = New System.Drawing.Size(112, 24)
        Me.lblCodigoReemplazo.TabIndex = 19
        Me.lblCodigoReemplazo.Text = "Merc. Reemp. : "
        Me.lblCodigoReemplazo.Values.ExtraText = ""
        Me.lblCodigoReemplazo.Values.Image = Nothing
        Me.lblCodigoReemplazo.Values.Text = "Merc. Reemp. : "
        '
        'lblUbicacion
        '
        Me.lblUbicacion.Location = New System.Drawing.Point(697, 321)
        Me.lblUbicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(86, 24)
        Me.lblUbicacion.TabIndex = 23
        Me.lblUbicacion.Text = "Ubicación : "
        Me.lblUbicacion.Values.ExtraText = ""
        Me.lblUbicacion.Values.Image = Nothing
        Me.lblUbicacion.Values.Text = "Ubicación : "
        '
        'txtDescMerca02
        '
        Me.txtDescMerca02.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescMerca02.Location = New System.Drawing.Point(189, 223)
        Me.txtDescMerca02.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescMerca02.MaxLength = 75
        Me.txtDescMerca02.Name = "txtDescMerca02"
        Me.txtDescMerca02.Size = New System.Drawing.Size(472, 26)
        Me.txtDescMerca02.TabIndex = 10
        '
        'lblPesoDeclarado
        '
        Me.lblPesoDeclarado.Location = New System.Drawing.Point(17, 474)
        Me.lblPesoDeclarado.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPesoDeclarado.Name = "lblPesoDeclarado"
        Me.lblPesoDeclarado.Size = New System.Drawing.Size(125, 24)
        Me.lblPesoDeclarado.TabIndex = 45
        Me.lblPesoDeclarado.Text = "Peso Declarado : "
        Me.lblPesoDeclarado.Values.ExtraText = ""
        Me.lblPesoDeclarado.Values.Image = Nothing
        Me.lblPesoDeclarado.Values.Text = "Peso Declarado : "
        '
        'lblMensajeMercaderia
        '
        Me.lblMensajeMercaderia.Location = New System.Drawing.Point(189, 113)
        Me.lblMensajeMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMensajeMercaderia.Name = "lblMensajeMercaderia"
        Me.lblMensajeMercaderia.Size = New System.Drawing.Size(14, 17)
        Me.lblMensajeMercaderia.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMensajeMercaderia.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeMercaderia.TabIndex = 5
        Me.lblMensajeMercaderia.Text = "."
        Me.lblMensajeMercaderia.Values.ExtraText = ""
        Me.lblMensajeMercaderia.Values.Image = Nothing
        Me.lblMensajeMercaderia.Values.Text = "."
        '
        'lblValorXMts2
        '
        Me.lblValorXMts2.Location = New System.Drawing.Point(378, 444)
        Me.lblValorXMts2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblValorXMts2.Name = "lblValorXMts2"
        Me.lblValorXMts2.Size = New System.Drawing.Size(108, 24)
        Me.lblValorXMts2.TabIndex = 43
        Me.lblValorXMts2.Text = "Valor por m2 : "
        Me.lblValorXMts2.Values.ExtraText = ""
        Me.lblValorXMts2.Values.Image = Nothing
        Me.lblValorXMts2.Values.Text = "Valor por m2 : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(778, 55)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 130
        Me.PictureBox1.TabStop = False
        '
        'lblDescuento
        '
        Me.lblDescuento.Location = New System.Drawing.Point(697, 413)
        Me.lblDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(108, 24)
        Me.lblDescuento.TabIndex = 39
        Me.lblDescuento.Text = "% Descuento : "
        Me.lblDescuento.Values.ExtraText = ""
        Me.lblDescuento.Values.Image = Nothing
        Me.lblDescuento.Values.Text = "% Descuento : "
        '
        'txtDUN14
        '
        Me.txtDUN14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDUN14.Location = New System.Drawing.Point(189, 655)
        Me.txtDUN14.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDUN14.MaxLength = 15
        Me.txtDUN14.Name = "txtDUN14"
        Me.txtDUN14.Size = New System.Drawing.Size(164, 26)
        Me.txtDUN14.TabIndex = 44
        '
        'lblValorVentaSoles
        '
        Me.lblValorVentaSoles.Location = New System.Drawing.Point(17, 444)
        Me.lblValorVentaSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.lblValorVentaSoles.Name = "lblValorVentaSoles"
        Me.lblValorVentaSoles.Size = New System.Drawing.Size(113, 24)
        Me.lblValorVentaSoles.TabIndex = 41
        Me.lblValorVentaSoles.Text = "Valor Soles S/ :"
        Me.lblValorVentaSoles.Values.ExtraText = ""
        Me.lblValorVentaSoles.Values.Image = Nothing
        Me.lblValorVentaSoles.Values.Text = "Valor Soles S/ :"
        '
        'txtEAN13
        '
        Me.txtEAN13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEAN13.Location = New System.Drawing.Point(189, 686)
        Me.txtEAN13.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEAN13.MaxLength = 15
        Me.txtEAN13.Name = "txtEAN13"
        Me.txtEAN13.Size = New System.Drawing.Size(164, 26)
        Me.txtEAN13.TabIndex = 47
        '
        'lblValorVentaDolar
        '
        Me.lblValorVentaDolar.Location = New System.Drawing.Point(378, 413)
        Me.lblValorVentaDolar.Margin = New System.Windows.Forms.Padding(4)
        Me.lblValorVentaDolar.Name = "lblValorVentaDolar"
        Me.lblValorVentaDolar.Size = New System.Drawing.Size(78, 24)
        Me.lblValorVentaDolar.TabIndex = 37
        Me.lblValorVentaDolar.Text = "Valor U$ : "
        Me.lblValorVentaDolar.Values.ExtraText = ""
        Me.lblValorVentaDolar.Values.Image = Nothing
        Me.lblValorVentaDolar.Values.Text = "Valor U$ : "
        '
        'txtTiempoDescarga
        '
        Me.txtTiempoDescarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTiempoDescarga.Location = New System.Drawing.Point(554, 625)
        Me.txtTiempoDescarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTiempoDescarga.MaxLength = 10
        Me.txtTiempoDescarga.Name = "txtTiempoDescarga"
        Me.txtTiempoDescarga.Size = New System.Drawing.Size(107, 26)
        Me.txtTiempoDescarga.TabIndex = 42
        Me.txtTiempoDescarga.Text = "0.000"
        Me.txtTiempoDescarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechaVencimiento
        '
        Me.lblFechaVencimiento.Location = New System.Drawing.Point(697, 351)
        Me.lblFechaVencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFechaVencimiento.Name = "lblFechaVencimiento"
        Me.lblFechaVencimiento.Size = New System.Drawing.Size(97, 24)
        Me.lblFechaVencimiento.TabIndex = 27
        Me.lblFechaVencimiento.Text = "Fecha Vcto. : "
        Me.lblFechaVencimiento.Values.ExtraText = ""
        Me.lblFechaVencimiento.Values.Image = Nothing
        Me.lblFechaVencimiento.Values.Text = "Fecha Vcto. : "
        '
        'txtTiempoCarga
        '
        Me.txtTiempoCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTiempoCarga.Location = New System.Drawing.Point(189, 625)
        Me.txtTiempoCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTiempoCarga.MaxLength = 10
        Me.txtTiempoCarga.Name = "txtTiempoCarga"
        Me.txtTiempoCarga.Size = New System.Drawing.Size(107, 26)
        Me.txtTiempoCarga.TabIndex = 41
        Me.txtTiempoCarga.Text = "0.000"
        Me.txtTiempoCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 351)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(118, 24)
        Me.lblObservaciones.TabIndex = 25
        Me.lblObservaciones.Text = "Observaciones : "
        Me.lblObservaciones.Values.ExtraText = ""
        Me.lblObservaciones.Values.Image = Nothing
        Me.lblObservaciones.Values.Text = "Observaciones : "
        '
        'lblPesoMinServicio
        '
        Me.lblPesoMinServicio.Location = New System.Drawing.Point(697, 567)
        Me.lblPesoMinServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPesoMinServicio.Name = "lblPesoMinServicio"
        Me.lblPesoMinServicio.Size = New System.Drawing.Size(165, 24)
        Me.lblPesoMinServicio.TabIndex = 68
        Me.lblPesoMinServicio.Text = "Peso Mínimo Servicio : "
        Me.lblPesoMinServicio.Values.ExtraText = ""
        Me.lblPesoMinServicio.Values.Image = Nothing
        Me.lblPesoMinServicio.Values.Text = "Peso Mínimo Servicio : "
        '
        'lblAreaMts2
        '
        Me.lblAreaMts2.Location = New System.Drawing.Point(378, 474)
        Me.lblAreaMts2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAreaMts2.Name = "lblAreaMts2"
        Me.lblAreaMts2.Size = New System.Drawing.Size(98, 24)
        Me.lblAreaMts2.TabIndex = 48
        Me.lblAreaMts2.Text = "Area (Mts2) : "
        Me.lblAreaMts2.Values.ExtraText = ""
        Me.lblAreaMts2.Values.Image = Nothing
        Me.lblAreaMts2.Values.Text = "Area (Mts2) : "
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(378, 382)
        Me.lblMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(76, 24)
        Me.lblMoneda.TabIndex = 31
        Me.lblMoneda.Text = "Moneda : "
        Me.lblMoneda.Values.ExtraText = ""
        Me.lblMoneda.Values.Image = Nothing
        Me.lblMoneda.Values.Text = "Moneda : "
        '
        'lblVolumenMts3
        '
        Me.lblVolumenMts3.Location = New System.Drawing.Point(697, 474)
        Me.lblVolumenMts3.Margin = New System.Windows.Forms.Padding(4)
        Me.lblVolumenMts3.Name = "lblVolumenMts3"
        Me.lblVolumenMts3.Size = New System.Drawing.Size(128, 24)
        Me.lblVolumenMts3.TabIndex = 50
        Me.lblVolumenMts3.Text = "Volumen (Mts3) : "
        Me.lblVolumenMts3.Values.ExtraText = ""
        Me.lblVolumenMts3.Values.Image = Nothing
        Me.lblVolumenMts3.Values.Text = "Volumen (Mts3) : "
        '
        'lblCostoProveedor
        '
        Me.lblCostoProveedor.Location = New System.Drawing.Point(17, 382)
        Me.lblCostoProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCostoProveedor.Name = "lblCostoProveedor"
        Me.lblCostoProveedor.Size = New System.Drawing.Size(133, 24)
        Me.lblCostoProveedor.TabIndex = 29
        Me.lblCostoProveedor.Text = "Costo Proveedor : "
        Me.lblCostoProveedor.Values.ExtraText = ""
        Me.lblCostoProveedor.Values.Image = Nothing
        Me.lblCostoProveedor.Values.Text = "Costo Proveedor : "
        '
        'lblLargoMercaderia
        '
        Me.lblLargoMercaderia.Location = New System.Drawing.Point(17, 505)
        Me.lblLargoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLargoMercaderia.Name = "lblLargoMercaderia"
        Me.lblLargoMercaderia.Size = New System.Drawing.Size(138, 24)
        Me.lblLargoMercaderia.TabIndex = 52
        Me.lblLargoMercaderia.Text = "Largo Mercadería : "
        Me.lblLargoMercaderia.Values.ExtraText = ""
        Me.lblLargoMercaderia.Values.Image = Nothing
        Me.lblLargoMercaderia.Values.Text = "Largo Mercadería : "
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Culture = New System.Globalization.CultureInfo("es-PE")
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(884, 348)
        Me.txtFechaVencimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaVencimiento.Mask = "##/##/####"
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(107, 26)
        Me.txtFechaVencimiento.TabIndex = 17
        Me.txtFechaVencimiento.Text = "  /  /"
        '
        'lblAnchoMercaderia
        '
        Me.lblAnchoMercaderia.Location = New System.Drawing.Point(378, 505)
        Me.lblAnchoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAnchoMercaderia.Name = "lblAnchoMercaderia"
        Me.lblAnchoMercaderia.Size = New System.Drawing.Size(143, 24)
        Me.lblAnchoMercaderia.TabIndex = 54
        Me.lblAnchoMercaderia.Text = "Ancho Mercadería : "
        Me.lblAnchoMercaderia.Values.ExtraText = ""
        Me.lblAnchoMercaderia.Values.Image = Nothing
        Me.lblAnchoMercaderia.Values.Text = "Ancho Mercadería : "
        '
        'chkMarcaControl
        '
        Me.chkMarcaControl.Checked = False
        Me.chkMarcaControl.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkMarcaControl.Location = New System.Drawing.Point(537, 86)
        Me.chkMarcaControl.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMarcaControl.Name = "chkMarcaControl"
        Me.chkMarcaControl.Size = New System.Drawing.Size(164, 24)
        Me.chkMarcaControl.TabIndex = 3
        Me.chkMarcaControl.Text = "Control por Posición"
        Me.chkMarcaControl.Values.ExtraText = ""
        Me.chkMarcaControl.Values.Image = Nothing
        Me.chkMarcaControl.Values.Text = "Control por Posición"
        '
        'lblAlturaMercaderia
        '
        Me.lblAlturaMercaderia.Location = New System.Drawing.Point(697, 505)
        Me.lblAlturaMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblAlturaMercaderia.Name = "lblAlturaMercaderia"
        Me.lblAlturaMercaderia.Size = New System.Drawing.Size(141, 24)
        Me.lblAlturaMercaderia.TabIndex = 56
        Me.lblAlturaMercaderia.Text = "Altura Mercadería : "
        Me.lblAlturaMercaderia.Values.ExtraText = ""
        Me.lblAlturaMercaderia.Values.Image = Nothing
        Me.lblAlturaMercaderia.Values.Text = "Altura Mercadería : "
        '
        'txtPesoMinServicio
        '
        Me.txtPesoMinServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoMinServicio.Location = New System.Drawing.Point(884, 563)
        Me.txtPesoMinServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoMinServicio.MaxLength = 10
        Me.txtPesoMinServicio.Name = "txtPesoMinServicio"
        Me.txtPesoMinServicio.Size = New System.Drawing.Size(107, 26)
        Me.txtPesoMinServicio.TabIndex = 38
        Me.txtPesoMinServicio.Text = "0.000"
        Me.txtPesoMinServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRotacion
        '
        Me.lblRotacion.Location = New System.Drawing.Point(697, 536)
        Me.lblRotacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRotacion.Name = "lblRotacion"
        Me.lblRotacion.Size = New System.Drawing.Size(114, 24)
        Me.lblRotacion.TabIndex = 62
        Me.lblRotacion.Text = "Cód. Rotación : "
        Me.lblRotacion.Values.ExtraText = ""
        Me.lblRotacion.Values.Image = Nothing
        Me.lblRotacion.Values.Text = "Cód. Rotación : "
        '
        'txtApilabilidad
        '
        Me.txtApilabilidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaApilabilidadListar})
        Me.txtApilabilidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApilabilidad.Location = New System.Drawing.Point(554, 532)
        Me.txtApilabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApilabilidad.MaxLength = 2
        Me.txtApilabilidad.Name = "txtApilabilidad"
        Me.txtApilabilidad.Size = New System.Drawing.Size(107, 26)
        Me.txtApilabilidad.TabIndex = 34
        '
        'bsaApilabilidadListar
        '
        Me.bsaApilabilidadListar.ExtraText = ""
        Me.bsaApilabilidadListar.Image = Nothing
        Me.bsaApilabilidadListar.Text = ""
        Me.bsaApilabilidadListar.ToolTipImage = Nothing
        Me.bsaApilabilidadListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaApilabilidadListar.UniqueName = "F7C6AE292FEF4947F7C6AE292FEF4947"
        '
        'lblPerfumancia
        '
        Me.lblPerfumancia.Location = New System.Drawing.Point(17, 567)
        Me.lblPerfumancia.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPerfumancia.Name = "lblPerfumancia"
        Me.lblPerfumancia.Size = New System.Drawing.Size(139, 24)
        Me.lblPerfumancia.TabIndex = 64
        Me.lblPerfumancia.Text = "Cód. Perfumancia : "
        Me.lblPerfumancia.Values.ExtraText = ""
        Me.lblPerfumancia.Values.Image = Nothing
        Me.lblPerfumancia.Values.Text = "Cód. Perfumancia : "
        '
        'txtRotacion
        '
        Me.txtRotacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRotacion.Location = New System.Drawing.Point(884, 532)
        Me.txtRotacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRotacion.MaxLength = 2
        Me.txtRotacion.Name = "txtRotacion"
        Me.txtRotacion.Size = New System.Drawing.Size(55, 26)
        Me.txtRotacion.TabIndex = 35
        '
        'lblInflamable
        '
        Me.lblInflamable.Location = New System.Drawing.Point(17, 536)
        Me.lblInflamable.Margin = New System.Windows.Forms.Padding(4)
        Me.lblInflamable.Name = "lblInflamable"
        Me.lblInflamable.Size = New System.Drawing.Size(126, 24)
        Me.lblInflamable.TabIndex = 58
        Me.lblInflamable.Text = "Cód. Inflamable :"
        Me.lblInflamable.Values.ExtraText = ""
        Me.lblInflamable.Values.Image = Nothing
        Me.lblInflamable.Values.Text = "Cód. Inflamable :"
        '
        'txtAlturaMercaderia
        '
        Me.txtAlturaMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlturaMercaderia.Location = New System.Drawing.Point(884, 502)
        Me.txtAlturaMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlturaMercaderia.MaxLength = 10
        Me.txtAlturaMercaderia.Name = "txtAlturaMercaderia"
        Me.txtAlturaMercaderia.Size = New System.Drawing.Size(107, 26)
        Me.txtAlturaMercaderia.TabIndex = 32
        Me.txtAlturaMercaderia.Text = "0.000"
        Me.txtAlturaMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApilabilidad
        '
        Me.lblApilabilidad.Location = New System.Drawing.Point(378, 536)
        Me.lblApilabilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.lblApilabilidad.Name = "lblApilabilidad"
        Me.lblApilabilidad.Size = New System.Drawing.Size(135, 24)
        Me.lblApilabilidad.TabIndex = 60
        Me.lblApilabilidad.Text = "Cód. Apilabilidad : "
        Me.lblApilabilidad.Values.ExtraText = ""
        Me.lblApilabilidad.Values.Image = Nothing
        Me.lblApilabilidad.Values.Text = "Cód. Apilabilidad : "
        '
        'txtLargoMercaderia
        '
        Me.txtLargoMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLargoMercaderia.Location = New System.Drawing.Point(189, 502)
        Me.txtLargoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLargoMercaderia.MaxLength = 10
        Me.txtLargoMercaderia.Name = "txtLargoMercaderia"
        Me.txtLargoMercaderia.Size = New System.Drawing.Size(107, 26)
        Me.txtLargoMercaderia.TabIndex = 30
        Me.txtLargoMercaderia.Text = "0.000"
        Me.txtLargoMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidadMinServicio
        '
        Me.lblCantidadMinServicio.Location = New System.Drawing.Point(378, 567)
        Me.lblCantidadMinServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadMinServicio.Name = "lblCantidadMinServicio"
        Me.lblCantidadMinServicio.Size = New System.Drawing.Size(145, 24)
        Me.lblCantidadMinServicio.TabIndex = 66
        Me.lblCantidadMinServicio.Text = "Cant. Mín. Servicio : "
        Me.lblCantidadMinServicio.Values.ExtraText = ""
        Me.lblCantidadMinServicio.Values.Image = Nothing
        Me.lblCantidadMinServicio.Values.Text = "Cant. Mín. Servicio : "
        '
        'txtAreaMts2
        '
        Me.txtAreaMts2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAreaMts2.Location = New System.Drawing.Point(554, 471)
        Me.txtAreaMts2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAreaMts2.MaxLength = 10
        Me.txtAreaMts2.Name = "txtAreaMts2"
        Me.txtAreaMts2.Size = New System.Drawing.Size(107, 26)
        Me.txtAreaMts2.TabIndex = 28
        Me.txtAreaMts2.Text = "0.000"
        Me.txtAreaMts2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidadMercReorden
        '
        Me.lblCantidadMercReorden.Location = New System.Drawing.Point(17, 598)
        Me.lblCantidadMercReorden.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidadMercReorden.Name = "lblCantidadMercReorden"
        Me.lblCantidadMercReorden.Size = New System.Drawing.Size(158, 24)
        Me.lblCantidadMercReorden.TabIndex = 70
        Me.lblCantidadMercReorden.Text = "Cant. Merc. Reorden : "
        Me.lblCantidadMercReorden.Values.ExtraText = ""
        Me.lblCantidadMercReorden.Values.Image = Nothing
        Me.lblCantidadMercReorden.Values.Text = "Cant. Merc. Reorden : "
        '
        'txtInflamable
        '
        Me.txtInflamable.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaInflamableListar})
        Me.txtInflamable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInflamable.Location = New System.Drawing.Point(189, 532)
        Me.txtInflamable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInflamable.MaxLength = 20
        Me.txtInflamable.Name = "txtInflamable"
        Me.txtInflamable.Size = New System.Drawing.Size(164, 26)
        Me.txtInflamable.TabIndex = 33
        '
        'bsaInflamableListar
        '
        Me.bsaInflamableListar.ExtraText = ""
        Me.bsaInflamableListar.Image = Nothing
        Me.bsaInflamableListar.Text = ""
        Me.bsaInflamableListar.ToolTipImage = Nothing
        Me.bsaInflamableListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaInflamableListar.UniqueName = "2F993B850EE14F672F993B850EE14F67"
        '
        'lblPesoMercReorden
        '
        Me.lblPesoMercReorden.Location = New System.Drawing.Point(378, 598)
        Me.lblPesoMercReorden.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPesoMercReorden.Name = "lblPesoMercReorden"
        Me.lblPesoMercReorden.Size = New System.Drawing.Size(155, 24)
        Me.lblPesoMercReorden.TabIndex = 72
        Me.lblPesoMercReorden.Text = "Peso Merc. Reorden : "
        Me.lblPesoMercReorden.Values.ExtraText = ""
        Me.lblPesoMercReorden.Values.Image = Nothing
        Me.lblPesoMercReorden.Values.Text = "Peso Merc. Reorden : "
        '
        'txtCantidadMinServicio
        '
        Me.txtCantidadMinServicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadMinServicio.Location = New System.Drawing.Point(554, 563)
        Me.txtCantidadMinServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadMinServicio.MaxLength = 10
        Me.txtCantidadMinServicio.Name = "txtCantidadMinServicio"
        Me.txtCantidadMinServicio.Size = New System.Drawing.Size(107, 26)
        Me.txtCantidadMinServicio.TabIndex = 37
        Me.txtCantidadMinServicio.Text = "0.000"
        Me.txtCantidadMinServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTiempoCarga
        '
        Me.lblTiempoCarga.Location = New System.Drawing.Point(17, 628)
        Me.lblTiempoCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTiempoCarga.Name = "lblTiempoCarga"
        Me.lblTiempoCarga.Size = New System.Drawing.Size(136, 24)
        Me.lblTiempoCarga.TabIndex = 74
        Me.lblTiempoCarga.Text = "Tiempo de Carga : "
        Me.lblTiempoCarga.Values.ExtraText = ""
        Me.lblTiempoCarga.Values.Image = Nothing
        Me.lblTiempoCarga.Values.Text = "Tiempo de Carga : "
        '
        'txtPesoMercReorden
        '
        Me.txtPesoMercReorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoMercReorden.Location = New System.Drawing.Point(554, 594)
        Me.txtPesoMercReorden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoMercReorden.MaxLength = 10
        Me.txtPesoMercReorden.Name = "txtPesoMercReorden"
        Me.txtPesoMercReorden.Size = New System.Drawing.Size(107, 26)
        Me.txtPesoMercReorden.TabIndex = 40
        Me.txtPesoMercReorden.Text = "0.000"
        Me.txtPesoMercReorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTiempoDescarga
        '
        Me.lblTiempoDescarga.Location = New System.Drawing.Point(378, 628)
        Me.lblTiempoDescarga.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTiempoDescarga.Name = "lblTiempoDescarga"
        Me.lblTiempoDescarga.Size = New System.Drawing.Size(137, 24)
        Me.lblTiempoDescarga.TabIndex = 76
        Me.lblTiempoDescarga.Text = "Tiempo Descarga : "
        Me.lblTiempoDescarga.Values.ExtraText = ""
        Me.lblTiempoDescarga.Values.Image = Nothing
        Me.lblTiempoDescarga.Values.Text = "Tiempo Descarga : "
        '
        'txtCantidadMercReorden
        '
        Me.txtCantidadMercReorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadMercReorden.Location = New System.Drawing.Point(189, 594)
        Me.txtCantidadMercReorden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadMercReorden.MaxLength = 10
        Me.txtCantidadMercReorden.Name = "txtCantidadMercReorden"
        Me.txtCantidadMercReorden.Size = New System.Drawing.Size(107, 26)
        Me.txtCantidadMercReorden.TabIndex = 39
        Me.txtCantidadMercReorden.Text = "0.000"
        Me.txtCantidadMercReorden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDUN14
        '
        Me.lblDUN14.Location = New System.Drawing.Point(17, 659)
        Me.lblDUN14.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDUN14.Name = "lblDUN14"
        Me.lblDUN14.Size = New System.Drawing.Size(144, 24)
        Me.lblDUN14.TabIndex = 80
        Me.lblDUN14.Text = "Cód. Barra DUN14 : "
        Me.lblDUN14.Values.ExtraText = ""
        Me.lblDUN14.Values.Image = Nothing
        Me.lblDUN14.Values.Text = "Cód. Barra DUN14 : "
        '
        'txtVolumenMts3
        '
        Me.txtVolumenMts3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVolumenMts3.Location = New System.Drawing.Point(884, 471)
        Me.txtVolumenMts3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVolumenMts3.MaxLength = 10
        Me.txtVolumenMts3.Name = "txtVolumenMts3"
        Me.txtVolumenMts3.Size = New System.Drawing.Size(107, 26)
        Me.txtVolumenMts3.TabIndex = 29
        Me.txtVolumenMts3.Text = "0.000"
        Me.txtVolumenMts3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEAN13
        '
        Me.lblEAN13.Location = New System.Drawing.Point(17, 690)
        Me.lblEAN13.Margin = New System.Windows.Forms.Padding(4)
        Me.lblEAN13.Name = "lblEAN13"
        Me.lblEAN13.Size = New System.Drawing.Size(140, 24)
        Me.lblEAN13.TabIndex = 86
        Me.lblEAN13.Text = "Cód. Barra EAN13 : "
        Me.lblEAN13.Values.ExtraText = ""
        Me.lblEAN13.Values.Image = Nothing
        Me.lblEAN13.Values.Text = "Cód. Barra EAN13 : "
        '
        'txtPesoDeclarado
        '
        Me.txtPesoDeclarado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoDeclarado.Location = New System.Drawing.Point(189, 471)
        Me.txtPesoDeclarado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPesoDeclarado.MaxLength = 10
        Me.txtPesoDeclarado.Name = "txtPesoDeclarado"
        Me.txtPesoDeclarado.Size = New System.Drawing.Size(107, 26)
        Me.txtPesoDeclarado.TabIndex = 26
        Me.txtPesoDeclarado.Text = "0.000"
        Me.txtPesoDeclarado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescMerca01
        '
        Me.txtDescMerca01.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescMerca01.Location = New System.Drawing.Point(189, 201)
        Me.txtDescMerca01.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescMerca01.MaxLength = 50
        Me.txtDescMerca01.Name = "txtDescMerca01"
        Me.txtDescMerca01.Size = New System.Drawing.Size(472, 26)
        Me.txtDescMerca01.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescMerca01.TabIndex = 9
        '
        'txtCostoProveedor
        '
        Me.txtCostoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCostoProveedor.Location = New System.Drawing.Point(189, 378)
        Me.txtCostoProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostoProveedor.MaxLength = 10
        Me.txtCostoProveedor.Name = "txtCostoProveedor"
        Me.txtCostoProveedor.Size = New System.Drawing.Size(107, 26)
        Me.txtCostoProveedor.TabIndex = 18
        Me.txtCostoProveedor.Text = "0.000"
        Me.txtCostoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMarcaModelo
        '
        Me.txtMarcaModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaModelo.Location = New System.Drawing.Point(189, 286)
        Me.txtMarcaModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarcaModelo.MaxLength = 40
        Me.txtMarcaModelo.Name = "txtMarcaModelo"
        Me.txtMarcaModelo.Size = New System.Drawing.Size(472, 26)
        Me.txtMarcaModelo.TabIndex = 12
        '
        'txtCodigoRANSA
        '
        Me.txtCodigoRANSA.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaCodigoRANSAListar})
        Me.txtCodigoRANSA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoRANSA.Location = New System.Drawing.Point(189, 255)
        Me.txtCodigoRANSA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoRANSA.MaxLength = 40
        Me.txtCodigoRANSA.Name = "txtCodigoRANSA"
        Me.txtCodigoRANSA.Size = New System.Drawing.Size(472, 26)
        Me.txtCodigoRANSA.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtCodigoRANSA.TabIndex = 11
        '
        'bsaCodigoRANSAListar
        '
        Me.bsaCodigoRANSAListar.ExtraText = ""
        Me.bsaCodigoRANSAListar.Image = Nothing
        Me.bsaCodigoRANSAListar.Text = ""
        Me.bsaCodigoRANSAListar.ToolTipImage = Nothing
        Me.bsaCodigoRANSAListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaCodigoRANSAListar.UniqueName = "5239A538AF3449BA5239A538AF3449BA"
        '
        'txtCodigoReemplazo
        '
        Me.txtCodigoReemplazo.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaCodigoReemplazoListar})
        Me.txtCodigoReemplazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoReemplazo.Location = New System.Drawing.Point(825, 286)
        Me.txtCodigoReemplazo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoReemplazo.MaxLength = 15
        Me.txtCodigoReemplazo.Name = "txtCodigoReemplazo"
        Me.txtCodigoReemplazo.Size = New System.Drawing.Size(165, 26)
        Me.txtCodigoReemplazo.TabIndex = 13
        '
        'bsaCodigoReemplazoListar
        '
        Me.bsaCodigoReemplazoListar.ExtraText = ""
        Me.bsaCodigoReemplazoListar.Image = Nothing
        Me.bsaCodigoReemplazoListar.Text = ""
        Me.bsaCodigoReemplazoListar.ToolTipImage = Nothing
        Me.bsaCodigoReemplazoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaCodigoReemplazoListar.UniqueName = "79F48869DE8E425379F48869DE8E4253"
        '
        'txtValorXMts2
        '
        Me.txtValorXMts2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorXMts2.Location = New System.Drawing.Point(554, 440)
        Me.txtValorXMts2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorXMts2.MaxLength = 10
        Me.txtValorXMts2.Name = "txtValorXMts2"
        Me.txtValorXMts2.Size = New System.Drawing.Size(107, 26)
        Me.txtValorXMts2.TabIndex = 25
        Me.txtValorXMts2.Text = "0.000"
        Me.txtValorXMts2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(189, 348)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 25
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(472, 26)
        Me.txtObservaciones.TabIndex = 16
        '
        'txtValorVentaSoles
        '
        Me.txtValorVentaSoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorVentaSoles.Location = New System.Drawing.Point(189, 440)
        Me.txtValorVentaSoles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorVentaSoles.Name = "txtValorVentaSoles"
        Me.txtValorVentaSoles.Size = New System.Drawing.Size(107, 26)
        Me.txtValorVentaSoles.TabIndex = 24
        Me.txtValorVentaSoles.Text = "0.000"
        Me.txtValorVentaSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Location = New System.Drawing.Point(294, 471)
        Me.txtUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidad.MaxLength = 3
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(59, 26)
        Me.txtUnidad.TabIndex = 27
        '
        'txtDescuento
        '
        Me.txtDescuento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescuento.Location = New System.Drawing.Point(884, 409)
        Me.txtDescuento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescuento.MaxLength = 5
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(107, 26)
        Me.txtDescuento.TabIndex = 23
        Me.txtDescuento.Text = "0.00"
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUbicacion
        '
        Me.txtUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUbicacion.Location = New System.Drawing.Point(826, 317)
        Me.txtUbicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbicacion.MaxLength = 10
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(164, 26)
        Me.txtUbicacion.TabIndex = 15
        '
        'txtValorVentaDolar
        '
        Me.txtValorVentaDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtValorVentaDolar.Location = New System.Drawing.Point(554, 409)
        Me.txtValorVentaDolar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorVentaDolar.MaxLength = 10
        Me.txtValorVentaDolar.Name = "txtValorVentaDolar"
        Me.txtValorVentaDolar.Size = New System.Drawing.Size(107, 26)
        Me.txtValorVentaDolar.TabIndex = 22
        Me.txtValorVentaDolar.Text = "0.000"
        Me.txtValorVentaDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAnchoMercaderia
        '
        Me.txtAnchoMercaderia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAnchoMercaderia.Location = New System.Drawing.Point(554, 502)
        Me.txtAnchoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnchoMercaderia.MaxLength = 10
        Me.txtAnchoMercaderia.Name = "txtAnchoMercaderia"
        Me.txtAnchoMercaderia.Size = New System.Drawing.Size(107, 26)
        Me.txtAnchoMercaderia.TabIndex = 31
        Me.txtAnchoMercaderia.Text = "0.000"
        Me.txtAnchoMercaderia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPerfumancia
        '
        Me.txtPerfumancia.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaPerfumanciaListar})
        Me.txtPerfumancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPerfumancia.Location = New System.Drawing.Point(189, 563)
        Me.txtPerfumancia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPerfumancia.MaxLength = 2
        Me.txtPerfumancia.Name = "txtPerfumancia"
        Me.txtPerfumancia.Size = New System.Drawing.Size(164, 26)
        Me.txtPerfumancia.TabIndex = 36
        '
        'bsaPerfumanciaListar
        '
        Me.bsaPerfumanciaListar.ExtraText = ""
        Me.bsaPerfumanciaListar.Image = Nothing
        Me.bsaPerfumanciaListar.Text = ""
        Me.bsaPerfumanciaListar.ToolTipImage = Nothing
        Me.bsaPerfumanciaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaPerfumanciaListar.UniqueName = "FF138A830DDA47A8FF138A830DDA47A8"
        '
        'frmMercaderiaSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 770)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMercaderiaSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mercadería"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.ssMenuInformativo.ResumeLayout(False)
        Me.ssMenuInformativo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPesoMinServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtApilabilidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtRotacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAlturaMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtLargoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAreaMts2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtInflamable As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadMinServicio As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPesoMercReorden As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadMercReorden As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtVolumenMts3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPesoDeclarado As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCostoProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoRANSA As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtValorXMts2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtValorVentaSoles As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescuento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtValorVentaDolar As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPerfumancia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAnchoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUbicacion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUnidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoReemplazo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMarcaModelo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescMerca01 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodigoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblEAN13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDUN14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTiempoDescarga As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTiempoCarga As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPesoMercReorden As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCantidadMercReorden As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCantidadMinServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblApilabilidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblInflamable As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPerfumancia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblRotacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlturaMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAnchoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblLargoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblVolumenMts3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAreaMts2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblObservaciones As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaVencimiento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblValorVentaDolar As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblValorVentaSoles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDescuento As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblValorXMts2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPesoDeclarado As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUbicacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigoReemplazo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMarcaModelo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigoRANSA As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDescMerca As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCodigoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGrupo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaGrupoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblGrupo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkMarcaControl As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblCostoProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFechaVencimiento As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblMoneda As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDUN14 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtEAN13 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTiempoDescarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtTiempoCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPesoMinServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtFamilia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaFamiliaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblFamilia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMensajeMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtDescMerca02 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtMoneda As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaMonedaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaInflamableListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaCodigoRANSAListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaCodigoReemplazoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents chkPublicacionWEB As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtFechaInventario As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents lblFechaInventario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtVolumenEquivalente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblVolumenEquivalente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblUnidadInventario As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadInventario As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadMinProducir As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCantidadMinProducir As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCostoPromSoles As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCostoPromSoles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCostoPromProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCostoPromProveedor As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ssMenuInformativo As System.Windows.Forms.StatusStrip
    Friend WithEvents tssMsjGuardar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssMsjCancelar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bsaPerfumanciaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaApilabilidadListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents txtProveedor As RANSA.Controls.Proveedor.ucProveedor_TxtF01
    Friend WithEvents txtPartidaArancelaria As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPartidaArancelaria As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkMarcaSerie As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkControlLote As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
