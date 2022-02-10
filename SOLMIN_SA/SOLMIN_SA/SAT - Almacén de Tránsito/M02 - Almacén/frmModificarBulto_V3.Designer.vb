<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarBulto_V3
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarBulto_V3))
        Me.pnlModificarBulto = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.txtHoraEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tspListadoMercaderia = New System.Windows.Forms.ToolStrip()
        Me.tsbEliminarPaquete = New System.Windows.Forms.ToolStripButton()
        Me.tss03 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAgregarPaquete = New System.Windows.Forms.ToolStripButton()
        Me.tss01 = New System.Windows.Forms.ToolStripSeparator()
        Me.dtgPaquetesDeBulto = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.PNQCTPQT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTLRG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTANC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQMTALT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQVOLMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNQPSOMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUnidadVolumen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaUnidadVolumenListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtMedioSugerido = New Ransa.Utilitario.ucAyuda()
        Me.txtTipoCarga = New Ransa.Utilitario.ucAyuda()
        Me.TxtTipoMaterial = New Ransa.Utilitario.ucAyuda()
        Me.txtUbicacionReferencial = New Ransa.Utilitario.ucAyuda()
        Me.txtZonaAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.txtAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.ucIncidencia = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel26 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel25 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel23 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.LblTipoMaterial = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaSolicitudMedio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaSolicitud = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel15 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtEtiqueta = New Ransa.Utilitario.ucAyuda()
        Me.lblEtiqueta = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTarifa = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTarifa = New Ransa.Utilitario.ucAyuda()
        Me.txtNumeroContenedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnAyudaContenedor = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtUsuarioReferencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblUsuarioReferencia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.chkCnt = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtSigla = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtEntrega = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtAfe = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCuentaImpAfe = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtGuiaProveedor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel22 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtFluvial = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtAereo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel19 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel20 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTerrestre = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel21 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtInformacionAdicional = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblDescripcionAdicional = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoTicket = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPesoTicket = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNroOrdenServicioAgencia = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtVolumenBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaVolumenBulto = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaSalida = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.KryptonBorderEdge1 = New ComponentFactory.Krypton.Toolkit.KryptonBorderEdge()
        Me.lblZonaAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtImporteBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblImporteBulto = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoMovimiento = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaTipoMovimientoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtCodigoEmbarcador = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCodigoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMotivoRecepcion = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaMotivoRecepcionListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblCodigoEmbarcador = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel16 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCodigoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtSentidoCarga = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaSentidoCargaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblCodigoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaTipoBultoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.txtNroTicketBalanza = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaNroTicketBalanzaListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadRecibida = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidadAreaOcupada = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaUnidadPesoListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPesoBulto = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDescripcionWaybill = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel14 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.TypeValidator = New TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator()
        Me.tsMenuOpcionesDetalle = New System.Windows.Forms.ToolStrip()
        Me.btnAdjuntarGuia = New System.Windows.Forms.ToolStripButton()
        Me.tssVistaPrevia = New System.Windows.Forms.ToolStripSeparator()
        Me.tslblDetalleTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.BeBultoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.pnlModificarBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlModificarBulto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tspListadoMercaderia.SuspendLayout()
        CType(Me.dtgPaquetesDeBulto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeBultoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlModificarBulto
        '
        Me.pnlModificarBulto.Controls.Add(Me.txtHoraEntrega)
        Me.pnlModificarBulto.Controls.Add(Me.Panel1)
        Me.pnlModificarBulto.Controls.Add(Me.txtUnidadVolumen)
        Me.pnlModificarBulto.Controls.Add(Me.txtMedioSugerido)
        Me.pnlModificarBulto.Controls.Add(Me.txtTipoCarga)
        Me.pnlModificarBulto.Controls.Add(Me.TxtTipoMaterial)
        Me.pnlModificarBulto.Controls.Add(Me.txtUbicacionReferencial)
        Me.pnlModificarBulto.Controls.Add(Me.txtZonaAlmacen)
        Me.pnlModificarBulto.Controls.Add(Me.txtAlmacen)
        Me.pnlModificarBulto.Controls.Add(Me.txtTipoAlmacen)
        Me.pnlModificarBulto.Controls.Add(Me.ucIncidencia)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel26)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel25)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonTextBox1)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel23)
        Me.pnlModificarBulto.Controls.Add(Me.LblTipoMaterial)
        Me.pnlModificarBulto.Controls.Add(Me.dtpFechaSolicitudMedio)
        Me.pnlModificarBulto.Controls.Add(Me.lblFechaSolicitud)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel15)
        Me.pnlModificarBulto.Controls.Add(Me.txtEtiqueta)
        Me.pnlModificarBulto.Controls.Add(Me.lblEtiqueta)
        Me.pnlModificarBulto.Controls.Add(Me.lblTarifa)
        Me.pnlModificarBulto.Controls.Add(Me.txtTarifa)
        Me.pnlModificarBulto.Controls.Add(Me.txtNumeroContenedor)
        Me.pnlModificarBulto.Controls.Add(Me.txtUsuarioReferencia)
        Me.pnlModificarBulto.Controls.Add(Me.lblUsuarioReferencia)
        Me.pnlModificarBulto.Controls.Add(Me.chkCnt)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel11)
        Me.pnlModificarBulto.Controls.Add(Me.txtSigla)
        Me.pnlModificarBulto.Controls.Add(Me.txtEntrega)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel17)
        Me.pnlModificarBulto.Controls.Add(Me.txtOrigen)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel18)
        Me.pnlModificarBulto.Controls.Add(Me.txtAfe)
        Me.pnlModificarBulto.Controls.Add(Me.lblCuentaImpAfe)
        Me.pnlModificarBulto.Controls.Add(Me.txtGuiaProveedor)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel22)
        Me.pnlModificarBulto.Controls.Add(Me.txtFluvial)
        Me.pnlModificarBulto.Controls.Add(Me.txtAereo)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel19)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel20)
        Me.pnlModificarBulto.Controls.Add(Me.txtTerrestre)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel21)
        Me.pnlModificarBulto.Controls.Add(Me.txtInformacionAdicional)
        Me.pnlModificarBulto.Controls.Add(Me.lblDescripcionAdicional)
        Me.pnlModificarBulto.Controls.Add(Me.txtPesoTicket)
        Me.pnlModificarBulto.Controls.Add(Me.lblPesoTicket)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel13)
        Me.pnlModificarBulto.Controls.Add(Me.txtNroOrdenServicioAgencia)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel24)
        Me.pnlModificarBulto.Controls.Add(Me.txtVolumenBulto)
        Me.pnlModificarBulto.Controls.Add(Me.dtpIngreso)
        Me.pnlModificarBulto.Controls.Add(Me.lblFechaSalida)
        Me.pnlModificarBulto.Controls.Add(Me.dtpFechaSalida)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonBorderEdge1)
        Me.pnlModificarBulto.Controls.Add(Me.lblZonaAlmacen)
        Me.pnlModificarBulto.Controls.Add(Me.lblAlmacen)
        Me.pnlModificarBulto.Controls.Add(Me.lblTipoAlmacen)
        Me.pnlModificarBulto.Controls.Add(Me.btnCancelar)
        Me.pnlModificarBulto.Controls.Add(Me.btnGuardar)
        Me.pnlModificarBulto.Controls.Add(Me.txtImporteBulto)
        Me.pnlModificarBulto.Controls.Add(Me.lblImporteBulto)
        Me.pnlModificarBulto.Controls.Add(Me.txtTipoMovimiento)
        Me.pnlModificarBulto.Controls.Add(Me.txtCodigoEmbarcador)
        Me.pnlModificarBulto.Controls.Add(Me.lblCodigoRecepcion)
        Me.pnlModificarBulto.Controls.Add(Me.txtCodigoRecepcion)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel1)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel2)
        Me.pnlModificarBulto.Controls.Add(Me.txtMotivoRecepcion)
        Me.pnlModificarBulto.Controls.Add(Me.lblCodigoEmbarcador)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel16)
        Me.pnlModificarBulto.Controls.Add(Me.txtCodigoOrigen)
        Me.pnlModificarBulto.Controls.Add(Me.txtSentidoCarga)
        Me.pnlModificarBulto.Controls.Add(Me.lblCodigoOrigen)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel5)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel6)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel3)
        Me.pnlModificarBulto.Controls.Add(Me.txtTipoBulto)
        Me.pnlModificarBulto.Controls.Add(Me.txtNroTicketBalanza)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel7)
        Me.pnlModificarBulto.Controls.Add(Me.txtCantidadRecibida)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel8)
        Me.pnlModificarBulto.Controls.Add(Me.txtCantidadAreaOcupada)
        Me.pnlModificarBulto.Controls.Add(Me.txtUnidadPeso)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel4)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel9)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel10)
        Me.pnlModificarBulto.Controls.Add(Me.txtPesoBulto)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel12)
        Me.pnlModificarBulto.Controls.Add(Me.txtDescripcionWaybill)
        Me.pnlModificarBulto.Controls.Add(Me.KryptonLabel14)
        Me.pnlModificarBulto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlModificarBulto.Location = New System.Drawing.Point(0, 25)
        Me.pnlModificarBulto.Name = "pnlModificarBulto"
        Me.pnlModificarBulto.Size = New System.Drawing.Size(826, 629)
        Me.pnlModificarBulto.StateCommon.Color1 = System.Drawing.Color.White
        Me.pnlModificarBulto.TabIndex = 1
        '
        'txtHoraEntrega
        '
        Me.txtHoraEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraEntrega.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtHoraEntrega.Location = New System.Drawing.Point(778, 11)
        Me.txtHoraEntrega.Mask = "00:00"
        Me.txtHoraEntrega.Name = "txtHoraEntrega"
        Me.txtHoraEntrega.Size = New System.Drawing.Size(38, 20)
        Me.txtHoraEntrega.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.tspListadoMercaderia)
        Me.Panel1.Controls.Add(Me.dtgPaquetesDeBulto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 501)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 128)
        Me.Panel1.TabIndex = 3
        '
        'tspListadoMercaderia
        '
        Me.tspListadoMercaderia.BackColor = System.Drawing.SystemColors.Control
        Me.tspListadoMercaderia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tspListadoMercaderia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspListadoMercaderia.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tspListadoMercaderia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbEliminarPaquete, Me.tss03, Me.tsbAgregarPaquete, Me.tss01})
        Me.tspListadoMercaderia.Location = New System.Drawing.Point(0, 0)
        Me.tspListadoMercaderia.Name = "tspListadoMercaderia"
        Me.tspListadoMercaderia.Size = New System.Drawing.Size(826, 27)
        Me.tspListadoMercaderia.TabIndex = 65
        Me.tspListadoMercaderia.Text = "Anular Items"
        '
        'tsbEliminarPaquete
        '
        Me.tsbEliminarPaquete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEliminarPaquete.Image = Global.SOLMIN_SA.My.Resources.Resources.AnularItem
        Me.tsbEliminarPaquete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminarPaquete.Name = "tsbEliminarPaquete"
        Me.tsbEliminarPaquete.Size = New System.Drawing.Size(74, 24)
        Me.tsbEliminarPaquete.Text = "Eliminar"
        '
        'tss03
        '
        Me.tss03.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss03.Name = "tss03"
        Me.tss03.Size = New System.Drawing.Size(6, 27)
        '
        'tsbAgregarPaquete
        '
        Me.tsbAgregarPaquete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbAgregarPaquete.Image = Global.SOLMIN_SA.My.Resources.Resources.Agregar
        Me.tsbAgregarPaquete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarPaquete.Name = "tsbAgregarPaquete"
        Me.tsbAgregarPaquete.Size = New System.Drawing.Size(73, 24)
        Me.tsbAgregarPaquete.Text = "Agregar"
        '
        'tss01
        '
        Me.tss01.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss01.Name = "tss01"
        Me.tss01.Size = New System.Drawing.Size(6, 27)
        '
        'dtgPaquetesDeBulto
        '
        Me.dtgPaquetesDeBulto.AllowUserToAddRows = False
        Me.dtgPaquetesDeBulto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPaquetesDeBulto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgPaquetesDeBulto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPaquetesDeBulto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PNQCTPQT, Me.PNQMTLRG, Me.PNQMTANC, Me.PNQMTALT, Me.PNQVOLMR, Me.PNQPSOMR, Me.Column1})
        Me.dtgPaquetesDeBulto.Location = New System.Drawing.Point(1, 28)
        Me.dtgPaquetesDeBulto.Name = "dtgPaquetesDeBulto"
        Me.dtgPaquetesDeBulto.RowHeadersWidth = 20
        Me.dtgPaquetesDeBulto.RowTemplate.Height = 24
        Me.dtgPaquetesDeBulto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgPaquetesDeBulto.Size = New System.Drawing.Size(822, 97)
        Me.dtgPaquetesDeBulto.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dtgPaquetesDeBulto.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgPaquetesDeBulto.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dtgPaquetesDeBulto.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Nina", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPaquetesDeBulto.StateCommon.HeaderRow.Content.Font = New System.Drawing.Font("Nina", 8.25!)
        Me.dtgPaquetesDeBulto.TabIndex = 3
        '
        'PNQCTPQT
        '
        Me.PNQCTPQT.DataPropertyName = "PNQCTPQT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PNQCTPQT.DefaultCellStyle = DataGridViewCellStyle7
        Me.PNQCTPQT.HeaderText = "Cantidad Paquete"
        Me.PNQCTPQT.Name = "PNQCTPQT"
        Me.PNQCTPQT.Width = 108
        '
        'PNQMTLRG
        '
        Me.PNQMTLRG.DataPropertyName = "PNQMTLRG"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.PNQMTLRG.DefaultCellStyle = DataGridViewCellStyle8
        Me.PNQMTLRG.HeaderText = "Largo (mts)"
        Me.PNQMTLRG.Name = "PNQMTLRG"
        Me.PNQMTLRG.Width = 86
        '
        'PNQMTANC
        '
        Me.PNQMTANC.DataPropertyName = "PNQMTANC"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PNQMTANC.DefaultCellStyle = DataGridViewCellStyle9
        Me.PNQMTANC.HeaderText = "Ancho (mts)"
        Me.PNQMTANC.Name = "PNQMTANC"
        Me.PNQMTANC.Width = 88
        '
        'PNQMTALT
        '
        Me.PNQMTALT.DataPropertyName = "PNQMTALT"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PNQMTALT.DefaultCellStyle = DataGridViewCellStyle10
        Me.PNQMTALT.HeaderText = "Alto (mts)"
        Me.PNQMTALT.Name = "PNQMTALT"
        Me.PNQMTALT.Width = 78
        '
        'PNQVOLMR
        '
        Me.PNQVOLMR.DataPropertyName = "VOLUMENPAQUETE"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N3"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.PNQVOLMR.DefaultCellStyle = DataGridViewCellStyle11
        Me.PNQVOLMR.HeaderText = "Volumen Paquete"
        Me.PNQVOLMR.Name = "PNQVOLMR"
        Me.PNQVOLMR.ReadOnly = True
        Me.PNQVOLMR.Width = 108
        '
        'PNQPSOMR
        '
        Me.PNQPSOMR.DataPropertyName = "PNQPSOMR"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N3"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.PNQPSOMR.DefaultCellStyle = DataGridViewCellStyle12
        Me.PNQPSOMR.HeaderText = "Peso Paquete"
        Me.PNQPSOMR.Name = "PNQPSOMR"
        Me.PNQPSOMR.Width = 91
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = " "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'txtUnidadVolumen
        '
        Me.txtUnidadVolumen.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaUnidadVolumenListar})
        Me.txtUnidadVolumen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtUnidadVolumen, True)
        Me.txtUnidadVolumen.Location = New System.Drawing.Point(663, 85)
        Me.txtUnidadVolumen.MaxLength = 10
        Me.txtUnidadVolumen.Name = "txtUnidadVolumen"
        Me.txtUnidadVolumen.Size = New System.Drawing.Size(155, 22)
        Me.txtUnidadVolumen.TabIndex = 25
        '
        'bsaUnidadVolumenListar
        '
        Me.bsaUnidadVolumenListar.ExtraText = ""
        Me.bsaUnidadVolumenListar.Image = Nothing
        Me.bsaUnidadVolumenListar.Text = ""
        Me.bsaUnidadVolumenListar.ToolTipImage = Nothing
        Me.bsaUnidadVolumenListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaUnidadVolumenListar.UniqueName = "CD104215694A407ACD104215694A407A"
        '
        'txtMedioSugerido
        '
        Me.txtMedioSugerido.BackColor = System.Drawing.Color.White
        Me.txtMedioSugerido.DataSource = Nothing
        Me.txtMedioSugerido.DispleyMember = ""
        Me.txtMedioSugerido.Etiquetas_Form = Nothing
        Me.txtMedioSugerido.ListColumnas = Nothing
        Me.txtMedioSugerido.Location = New System.Drawing.Point(129, 285)
        Me.txtMedioSugerido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMedioSugerido.Name = "txtMedioSugerido"
        Me.txtMedioSugerido.Obligatorio = False
        Me.txtMedioSugerido.PopupHeight = 0
        Me.txtMedioSugerido.PopupWidth = 0
        Me.txtMedioSugerido.Size = New System.Drawing.Size(177, 23)
        Me.txtMedioSugerido.SizeFont = 0
        Me.txtMedioSugerido.TabIndex = 67
        Me.txtMedioSugerido.ValueMember = ""
        '
        'txtTipoCarga
        '
        Me.txtTipoCarga.BackColor = System.Drawing.Color.White
        Me.txtTipoCarga.DataSource = Nothing
        Me.txtTipoCarga.DispleyMember = ""
        Me.txtTipoCarga.Etiquetas_Form = Nothing
        Me.txtTipoCarga.ListColumnas = Nothing
        Me.txtTipoCarga.Location = New System.Drawing.Point(129, 235)
        Me.txtTipoCarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoCarga.Name = "txtTipoCarga"
        Me.txtTipoCarga.Obligatorio = True
        Me.txtTipoCarga.PopupHeight = 0
        Me.txtTipoCarga.PopupWidth = 0
        Me.txtTipoCarga.Size = New System.Drawing.Size(177, 23)
        Me.txtTipoCarga.SizeFont = 0
        Me.txtTipoCarga.TabIndex = 54
        Me.txtTipoCarga.ValueMember = ""
        '
        'TxtTipoMaterial
        '
        Me.TxtTipoMaterial.BackColor = System.Drawing.Color.White
        Me.TxtTipoMaterial.DataSource = Nothing
        Me.TxtTipoMaterial.DispleyMember = ""
        Me.TxtTipoMaterial.Etiquetas_Form = Nothing
        Me.TxtTipoMaterial.ListColumnas = Nothing
        Me.TxtTipoMaterial.Location = New System.Drawing.Point(129, 212)
        Me.TxtTipoMaterial.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTipoMaterial.Name = "TxtTipoMaterial"
        Me.TxtTipoMaterial.Obligatorio = True
        Me.TxtTipoMaterial.PopupHeight = 0
        Me.TxtTipoMaterial.PopupWidth = 0
        Me.TxtTipoMaterial.Size = New System.Drawing.Size(177, 23)
        Me.TxtTipoMaterial.SizeFont = 0
        Me.TxtTipoMaterial.TabIndex = 49
        Me.TxtTipoMaterial.ValueMember = ""
        '
        'txtUbicacionReferencial
        '
        Me.txtUbicacionReferencial.BackColor = System.Drawing.Color.White
        Me.txtUbicacionReferencial.DataSource = Nothing
        Me.txtUbicacionReferencial.DispleyMember = ""
        Me.txtUbicacionReferencial.Etiquetas_Form = Nothing
        Me.txtUbicacionReferencial.ListColumnas = Nothing
        Me.txtUbicacionReferencial.Location = New System.Drawing.Point(129, 187)
        Me.txtUbicacionReferencial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbicacionReferencial.Name = "txtUbicacionReferencial"
        Me.txtUbicacionReferencial.Obligatorio = True
        Me.txtUbicacionReferencial.PopupHeight = 0
        Me.txtUbicacionReferencial.PopupWidth = 0
        Me.txtUbicacionReferencial.Size = New System.Drawing.Size(178, 23)
        Me.txtUbicacionReferencial.SizeFont = 0
        Me.txtUbicacionReferencial.TabIndex = 43
        Me.txtUbicacionReferencial.ValueMember = ""
        '
        'txtZonaAlmacen
        '
        Me.txtZonaAlmacen.BackColor = System.Drawing.Color.White
        Me.txtZonaAlmacen.DataSource = Nothing
        Me.txtZonaAlmacen.DispleyMember = ""
        Me.txtZonaAlmacen.Etiquetas_Form = Nothing
        Me.txtZonaAlmacen.ListColumnas = Nothing
        Me.txtZonaAlmacen.Location = New System.Drawing.Point(650, 163)
        Me.txtZonaAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZonaAlmacen.Name = "txtZonaAlmacen"
        Me.txtZonaAlmacen.Obligatorio = True
        Me.txtZonaAlmacen.PopupHeight = 0
        Me.txtZonaAlmacen.PopupWidth = 0
        Me.txtZonaAlmacen.Size = New System.Drawing.Size(167, 27)
        Me.txtZonaAlmacen.SizeFont = 0
        Me.txtZonaAlmacen.TabIndex = 41
        Me.txtZonaAlmacen.ValueMember = ""
        '
        'txtAlmacen
        '
        Me.txtAlmacen.BackColor = System.Drawing.Color.White
        Me.txtAlmacen.DataSource = Nothing
        Me.txtAlmacen.DispleyMember = ""
        Me.txtAlmacen.Etiquetas_Form = Nothing
        Me.txtAlmacen.ListColumnas = Nothing
        Me.txtAlmacen.Location = New System.Drawing.Point(418, 163)
        Me.txtAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.Obligatorio = True
        Me.txtAlmacen.PopupHeight = 0
        Me.txtAlmacen.PopupWidth = 0
        Me.txtAlmacen.Size = New System.Drawing.Size(139, 24)
        Me.txtAlmacen.SizeFont = 0
        Me.txtAlmacen.TabIndex = 39
        Me.txtAlmacen.ValueMember = ""
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.White
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.Etiquetas_Form = Nothing
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(129, 162)
        Me.txtTipoAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(177, 23)
        Me.txtTipoAlmacen.SizeFont = 0
        Me.txtTipoAlmacen.TabIndex = 37
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'ucIncidencia
        '
        Me.ucIncidencia.BackColor = System.Drawing.Color.White
        Me.ucIncidencia.DataSource = Nothing
        Me.ucIncidencia.DispleyMember = ""
        Me.ucIncidencia.Etiquetas_Form = Nothing
        Me.ucIncidencia.ListColumnas = Nothing
        Me.ucIncidencia.Location = New System.Drawing.Point(650, 265)
        Me.ucIncidencia.Margin = New System.Windows.Forms.Padding(4)
        Me.ucIncidencia.Name = "ucIncidencia"
        Me.ucIncidencia.Obligatorio = False
        Me.ucIncidencia.PopupHeight = 0
        Me.ucIncidencia.PopupWidth = 0
        Me.ucIncidencia.Size = New System.Drawing.Size(162, 23)
        Me.ucIncidencia.SizeFont = 0
        Me.ucIncidencia.TabIndex = 65
        Me.ucIncidencia.ValueMember = ""
        '
        'KryptonLabel26
        '
        Me.KryptonLabel26.Location = New System.Drawing.Point(564, 264)
        Me.KryptonLabel26.Name = "KryptonLabel26"
        Me.KryptonLabel26.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel26.TabIndex = 64
        Me.KryptonLabel26.Text = "Incidencia: "
        Me.KryptonLabel26.Values.ExtraText = ""
        Me.KryptonLabel26.Values.Image = Nothing
        Me.KryptonLabel26.Values.Text = "Incidencia: "
        '
        'KryptonLabel25
        '
        Me.KryptonLabel25.Location = New System.Drawing.Point(7, 234)
        Me.KryptonLabel25.Name = "KryptonLabel25"
        Me.KryptonLabel25.Size = New System.Drawing.Size(89, 20)
        Me.KryptonLabel25.TabIndex = 53
        Me.KryptonLabel25.Text = "Tipo de Carga: "
        Me.KryptonLabel25.Values.ExtraText = ""
        Me.KryptonLabel25.Values.Image = Nothing
        Me.KryptonLabel25.Values.Text = "Tipo de Carga: "
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Location = New System.Drawing.Point(418, 286)
        Me.KryptonTextBox1.MaxLength = 30
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(138, 22)
        Me.KryptonTextBox1.TabIndex = 69
        '
        'KryptonLabel23
        '
        Me.KryptonLabel23.Location = New System.Drawing.Point(313, 285)
        Me.KryptonLabel23.Name = "KryptonLabel23"
        Me.KryptonLabel23.Size = New System.Drawing.Size(104, 20)
        Me.KryptonLabel23.TabIndex = 68
        Me.KryptonLabel23.Text = "Cta. Almacenaje : "
        Me.KryptonLabel23.Values.ExtraText = ""
        Me.KryptonLabel23.Values.Image = Nothing
        Me.KryptonLabel23.Values.Text = "Cta. Almacenaje : "
        '
        'LblTipoMaterial
        '
        Me.LblTipoMaterial.Location = New System.Drawing.Point(7, 210)
        Me.LblTipoMaterial.Name = "LblTipoMaterial"
        Me.LblTipoMaterial.Size = New System.Drawing.Size(106, 20)
        Me.LblTipoMaterial.TabIndex = 48
        Me.LblTipoMaterial.Text = "Tipo de Material : "
        Me.LblTipoMaterial.Values.ExtraText = ""
        Me.LblTipoMaterial.Values.Image = Nothing
        Me.LblTipoMaterial.Values.Text = "Tipo de Material : "
        '
        'dtpFechaSolicitudMedio
        '
        Me.dtpFechaSolicitudMedio.Checked = False
        Me.dtpFechaSolicitudMedio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSolicitudMedio.Location = New System.Drawing.Point(129, 446)
        Me.dtpFechaSolicitudMedio.Name = "dtpFechaSolicitudMedio"
        Me.dtpFechaSolicitudMedio.ShowCheckBox = True
        Me.dtpFechaSolicitudMedio.Size = New System.Drawing.Size(94, 20)
        Me.dtpFechaSolicitudMedio.TabIndex = 83
        '
        'lblFechaSolicitud
        '
        Me.lblFechaSolicitud.Location = New System.Drawing.Point(7, 443)
        Me.lblFechaSolicitud.Name = "lblFechaSolicitud"
        Me.lblFechaSolicitud.Size = New System.Drawing.Size(98, 20)
        Me.lblFechaSolicitud.TabIndex = 82
        Me.lblFechaSolicitud.Text = "Fecha Solicitud :"
        Me.lblFechaSolicitud.Values.ExtraText = ""
        Me.lblFechaSolicitud.Values.Image = Nothing
        Me.lblFechaSolicitud.Values.Text = "Fecha Solicitud :"
        '
        'KryptonLabel15
        '
        Me.KryptonLabel15.Location = New System.Drawing.Point(7, 285)
        Me.KryptonLabel15.Name = "KryptonLabel15"
        Me.KryptonLabel15.Size = New System.Drawing.Size(52, 20)
        Me.KryptonLabel15.TabIndex = 66
        Me.KryptonLabel15.Text = "Medio : "
        Me.KryptonLabel15.Values.ExtraText = ""
        Me.KryptonLabel15.Values.Image = Nothing
        Me.KryptonLabel15.Values.Text = "Medio : "
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.BackColor = System.Drawing.Color.White
        Me.txtEtiqueta.DataSource = Nothing
        Me.txtEtiqueta.DispleyMember = ""
        Me.txtEtiqueta.Etiquetas_Form = Nothing
        Me.txtEtiqueta.ListColumnas = Nothing
        Me.txtEtiqueta.Location = New System.Drawing.Point(129, 418)
        Me.txtEtiqueta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Obligatorio = False
        Me.txtEtiqueta.PopupHeight = 0
        Me.txtEtiqueta.PopupWidth = 0
        Me.txtEtiqueta.Size = New System.Drawing.Size(177, 23)
        Me.txtEtiqueta.SizeFont = 0
        Me.txtEtiqueta.TabIndex = 83
        Me.txtEtiqueta.ValueMember = ""
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.Location = New System.Drawing.Point(7, 419)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(61, 20)
        Me.lblEtiqueta.TabIndex = 82
        Me.lblEtiqueta.Text = "Etiqueta :"
        Me.lblEtiqueta.Values.ExtraText = ""
        Me.lblEtiqueta.Values.Image = Nothing
        Me.lblEtiqueta.Values.Text = "Etiqueta :"
        '
        'lblTarifa
        '
        Me.lblTarifa.Location = New System.Drawing.Point(7, 390)
        Me.lblTarifa.Name = "lblTarifa"
        Me.lblTarifa.Size = New System.Drawing.Size(47, 20)
        Me.lblTarifa.TabIndex = 80
        Me.lblTarifa.Text = "Tarifa :"
        Me.lblTarifa.Values.ExtraText = ""
        Me.lblTarifa.Values.Image = Nothing
        Me.lblTarifa.Values.Text = "Tarifa :"
        '
        'txtTarifa
        '
        Me.txtTarifa.BackColor = System.Drawing.Color.White
        Me.txtTarifa.DataSource = Nothing
        Me.txtTarifa.DispleyMember = ""
        Me.txtTarifa.Etiquetas_Form = Nothing
        Me.txtTarifa.ListColumnas = Nothing
        Me.txtTarifa.Location = New System.Drawing.Point(129, 390)
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Obligatorio = False
        Me.txtTarifa.PopupHeight = 0
        Me.txtTarifa.PopupWidth = 0
        Me.txtTarifa.Size = New System.Drawing.Size(177, 28)
        Me.txtTarifa.SizeFont = 0
        Me.txtTarifa.TabIndex = 81
        Me.txtTarifa.ValueMember = ""
        '
        'txtNumeroContenedor
        '
        Me.txtNumeroContenedor.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnAyudaContenedor})
        Me.txtNumeroContenedor.Location = New System.Drawing.Point(714, 236)
        Me.txtNumeroContenedor.MaxLength = 7
        Me.txtNumeroContenedor.Name = "txtNumeroContenedor"
        Me.txtNumeroContenedor.Size = New System.Drawing.Size(77, 22)
        Me.txtNumeroContenedor.TabIndex = 59
        '
        'btnAyudaContenedor
        '
        Me.btnAyudaContenedor.ExtraText = ""
        Me.btnAyudaContenedor.Image = Nothing
        Me.btnAyudaContenedor.Text = ""
        Me.btnAyudaContenedor.ToolTipImage = Nothing
        Me.btnAyudaContenedor.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.btnAyudaContenedor.UniqueName = "7B5F8657385249A67B5F8657385249A6"
        '
        'txtUsuarioReferencia
        '
        Me.txtUsuarioReferencia.Location = New System.Drawing.Point(129, 362)
        Me.txtUsuarioReferencia.MaxLength = 40
        Me.txtUsuarioReferencia.Name = "txtUsuarioReferencia"
        Me.txtUsuarioReferencia.Size = New System.Drawing.Size(177, 22)
        Me.txtUsuarioReferencia.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtUsuarioReferencia.TabIndex = 79
        '
        'lblUsuarioReferencia
        '
        Me.lblUsuarioReferencia.Location = New System.Drawing.Point(7, 363)
        Me.lblUsuarioReferencia.Name = "lblUsuarioReferencia"
        Me.lblUsuarioReferencia.Size = New System.Drawing.Size(73, 20)
        Me.lblUsuarioReferencia.TabIndex = 78
        Me.lblUsuarioReferencia.Text = "Referencia :"
        Me.lblUsuarioReferencia.Values.ExtraText = ""
        Me.lblUsuarioReferencia.Values.Image = Nothing
        Me.lblUsuarioReferencia.Values.Text = "Referencia :"
        '
        'chkCnt
        '
        Me.chkCnt.Checked = False
        Me.chkCnt.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkCnt.Location = New System.Drawing.Point(564, 212)
        Me.chkCnt.Name = "chkCnt"
        Me.chkCnt.Size = New System.Drawing.Size(116, 20)
        Me.chkCnt.TabIndex = 52
        Me.chkCnt.Text = "Tipo Contenedor"
        Me.chkCnt.Values.ExtraText = ""
        Me.chkCnt.Values.Image = Nothing
        Me.chkCnt.Values.Text = "Tipo Contenedor"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(564, 234)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(81, 20)
        Me.KryptonLabel11.TabIndex = 57
        Me.KryptonLabel11.Text = "Contenedor : "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Contenedor : "
        '
        'txtSigla
        '
        Me.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSigla.Location = New System.Drawing.Point(663, 236)
        Me.txtSigla.MaxLength = 4
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(45, 22)
        Me.txtSigla.TabIndex = 58
        '
        'txtEntrega
        '
        Me.txtEntrega.Location = New System.Drawing.Point(129, 336)
        Me.txtEntrega.MaxLength = 50
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(177, 22)
        Me.txtEntrega.TabIndex = 75
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(7, 336)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(110, 20)
        Me.KryptonLabel17.TabIndex = 74
        Me.KryptonLabel17.Text = "Lugar de Entrega : "
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Lugar de Entrega : "
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(129, 310)
        Me.txtOrigen.MaxLength = 50
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(177, 22)
        Me.txtOrigen.TabIndex = 71
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(7, 310)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(105, 20)
        Me.KryptonLabel18.TabIndex = 70
        Me.KryptonLabel18.Text = "Lugar de Origen : "
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Lugar de Origen : "
        '
        'txtAfe
        '
        Me.txtAfe.Location = New System.Drawing.Point(418, 310)
        Me.txtAfe.MaxLength = 10
        Me.txtAfe.Name = "txtAfe"
        Me.txtAfe.Size = New System.Drawing.Size(139, 22)
        Me.txtAfe.TabIndex = 73
        '
        'lblCuentaImpAfe
        '
        Me.lblCuentaImpAfe.Location = New System.Drawing.Point(313, 310)
        Me.lblCuentaImpAfe.Name = "lblCuentaImpAfe"
        Me.lblCuentaImpAfe.Size = New System.Drawing.Size(85, 20)
        Me.lblCuentaImpAfe.TabIndex = 72
        Me.lblCuentaImpAfe.Text = "Número AFE : "
        Me.lblCuentaImpAfe.Values.ExtraText = ""
        Me.lblCuentaImpAfe.Values.Image = Nothing
        Me.lblCuentaImpAfe.Values.Text = "Número AFE : "
        '
        'txtGuiaProveedor
        '
        Me.txtGuiaProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuiaProveedor.Location = New System.Drawing.Point(129, 259)
        Me.txtGuiaProveedor.MaxLength = 20
        Me.txtGuiaProveedor.Name = "txtGuiaProveedor"
        Me.txtGuiaProveedor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtGuiaProveedor.Size = New System.Drawing.Size(177, 22)
        Me.txtGuiaProveedor.TabIndex = 61
        '
        'KryptonLabel22
        '
        Me.KryptonLabel22.Location = New System.Drawing.Point(7, 258)
        Me.KryptonLabel22.Name = "KryptonLabel22"
        Me.KryptonLabel22.Size = New System.Drawing.Size(95, 20)
        Me.KryptonLabel22.TabIndex = 60
        Me.KryptonLabel22.Text = "Guía Proveedor"
        Me.KryptonLabel22.Values.ExtraText = ""
        Me.KryptonLabel22.Values.Image = Nothing
        Me.KryptonLabel22.Values.Text = "Guía Proveedor"
        '
        'txtFluvial
        '
        Me.txtFluvial.Location = New System.Drawing.Point(418, 259)
        Me.txtFluvial.MaxLength = 25
        Me.txtFluvial.Name = "txtFluvial"
        Me.txtFluvial.Size = New System.Drawing.Size(138, 22)
        Me.txtFluvial.TabIndex = 63
        '
        'txtAereo
        '
        Me.txtAereo.Location = New System.Drawing.Point(418, 236)
        Me.txtAereo.MaxLength = 25
        Me.txtAereo.Name = "txtAereo"
        Me.txtAereo.Size = New System.Drawing.Size(138, 22)
        Me.txtAereo.TabIndex = 56
        '
        'KryptonLabel19
        '
        Me.KryptonLabel19.Location = New System.Drawing.Point(303, 234)
        Me.KryptonLabel19.Name = "KryptonLabel19"
        Me.KryptonLabel19.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel19.TabIndex = 55
        Me.KryptonLabel19.Text = "Cuenta  Aéreo: "
        Me.KryptonLabel19.Values.ExtraText = ""
        Me.KryptonLabel19.Values.Image = Nothing
        Me.KryptonLabel19.Values.Text = "Cuenta  Aéreo: "
        '
        'KryptonLabel20
        '
        Me.KryptonLabel20.Location = New System.Drawing.Point(313, 258)
        Me.KryptonLabel20.Name = "KryptonLabel20"
        Me.KryptonLabel20.Size = New System.Drawing.Size(93, 20)
        Me.KryptonLabel20.TabIndex = 62
        Me.KryptonLabel20.Text = "Cuenta Fluvial : "
        Me.KryptonLabel20.Values.ExtraText = ""
        Me.KryptonLabel20.Values.Image = Nothing
        Me.KryptonLabel20.Values.Text = "Cuenta Fluvial : "
        '
        'txtTerrestre
        '
        Me.txtTerrestre.Location = New System.Drawing.Point(418, 212)
        Me.txtTerrestre.MaxLength = 25
        Me.txtTerrestre.Name = "txtTerrestre"
        Me.txtTerrestre.Size = New System.Drawing.Size(138, 22)
        Me.txtTerrestre.TabIndex = 51
        '
        'KryptonLabel21
        '
        Me.KryptonLabel21.Location = New System.Drawing.Point(303, 210)
        Me.KryptonLabel21.Name = "KryptonLabel21"
        Me.KryptonLabel21.Size = New System.Drawing.Size(110, 20)
        Me.KryptonLabel21.TabIndex = 50
        Me.KryptonLabel21.Text = "Cuenta  Terrestre : "
        Me.KryptonLabel21.Values.ExtraText = ""
        Me.KryptonLabel21.Values.Image = Nothing
        Me.KryptonLabel21.Values.Text = "Cuenta  Terrestre : "
        '
        'txtInformacionAdicional
        '
        Me.txtInformacionAdicional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInformacionAdicional.Location = New System.Drawing.Point(418, 340)
        Me.txtInformacionAdicional.MaxLength = 40
        Me.txtInformacionAdicional.Multiline = True
        Me.txtInformacionAdicional.Name = "txtInformacionAdicional"
        Me.txtInformacionAdicional.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInformacionAdicional.Size = New System.Drawing.Size(139, 77)
        Me.txtInformacionAdicional.TabIndex = 77
        '
        'lblDescripcionAdicional
        '
        Me.lblDescripcionAdicional.Location = New System.Drawing.Point(313, 336)
        Me.lblDescripcionAdicional.Name = "lblDescripcionAdicional"
        Me.lblDescripcionAdicional.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcionAdicional.TabIndex = 76
        Me.lblDescripcionAdicional.Text = "Observaciones : "
        Me.lblDescripcionAdicional.Values.ExtraText = ""
        Me.lblDescripcionAdicional.Values.Image = Nothing
        Me.lblDescripcionAdicional.Values.Text = "Observaciones : "
        '
        'txtPesoTicket
        '
        Me.txtPesoTicket.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtPesoTicket, True)
        Me.txtPesoTicket.Location = New System.Drawing.Point(650, 190)
        Me.txtPesoTicket.Name = "txtPesoTicket"
        Me.txtPesoTicket.ReadOnly = True
        Me.txtPesoTicket.Size = New System.Drawing.Size(166, 22)
        Me.txtPesoTicket.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPesoTicket.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtPesoTicket.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoTicket.TabIndex = 47
        Me.txtPesoTicket.Text = "0.00"
        Me.txtPesoTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoTicket, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblPesoTicket
        '
        Me.lblPesoTicket.Location = New System.Drawing.Point(565, 189)
        Me.lblPesoTicket.Name = "lblPesoTicket"
        Me.lblPesoTicket.Size = New System.Drawing.Size(78, 20)
        Me.lblPesoTicket.TabIndex = 46
        Me.lblPesoTicket.Text = "Peso Ticket : "
        Me.lblPesoTicket.Values.ExtraText = ""
        Me.lblPesoTicket.Values.Image = Nothing
        Me.lblPesoTicket.Values.Text = "Peso Ticket : "
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(7, 188)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel13.TabIndex = 42
        Me.KryptonLabel13.Text = "Ubicación : "
        Me.KryptonLabel13.Values.ExtraText = ""
        Me.KryptonLabel13.Values.Image = Nothing
        Me.KryptonLabel13.Values.Text = "Ubicación : "
        '
        'txtNroOrdenServicioAgencia
        '
        Me.TypeValidator.SetEnterTAB(Me.txtNroOrdenServicioAgencia, True)
        Me.txtNroOrdenServicioAgencia.Location = New System.Drawing.Point(418, 188)
        Me.txtNroOrdenServicioAgencia.Name = "txtNroOrdenServicioAgencia"
        Me.txtNroOrdenServicioAgencia.Size = New System.Drawing.Size(138, 22)
        Me.txtNroOrdenServicioAgencia.TabIndex = 45
        Me.txtNroOrdenServicioAgencia.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroOrdenServicioAgencia, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(303, 192)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(102, 20)
        Me.KryptonLabel24.TabIndex = 44
        Me.KryptonLabel24.Text = "N° O/S Agencia : "
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "N° O/S Agencia : "
        '
        'txtVolumenBulto
        '
        Me.txtVolumenBulto.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaVolumenBulto})
        Me.TypeValidator.SetDecimales(Me.txtVolumenBulto, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtVolumenBulto, True)
        Me.txtVolumenBulto.Location = New System.Drawing.Point(418, 87)
        Me.txtVolumenBulto.MaxLength = 15
        Me.txtVolumenBulto.Name = "txtVolumenBulto"
        Me.txtVolumenBulto.Size = New System.Drawing.Size(139, 22)
        Me.txtVolumenBulto.TabIndex = 23
        Me.txtVolumenBulto.Text = "0.00"
        Me.txtVolumenBulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtVolumenBulto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'bsaVolumenBulto
        '
        Me.bsaVolumenBulto.ExtraText = ""
        Me.bsaVolumenBulto.Image = Nothing
        Me.bsaVolumenBulto.Text = ""
        Me.bsaVolumenBulto.ToolTipImage = Nothing
        Me.bsaVolumenBulto.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaVolumenBulto.UniqueName = "C1EB01B205CE4D7DC1EB01B205CE4D7D"
        '
        'dtpIngreso
        '
        Me.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIngreso.Location = New System.Drawing.Point(663, 11)
        Me.dtpIngreso.Name = "dtpIngreso"
        Me.dtpIngreso.Size = New System.Drawing.Size(105, 20)
        Me.dtpIngreso.TabIndex = 5
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.Location = New System.Drawing.Point(5, 475)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(98, 20)
        Me.lblFechaSalida.TabIndex = 85
        Me.lblFechaSalida.Text = "Fecha de Salida: "
        Me.lblFechaSalida.Values.ExtraText = ""
        Me.lblFechaSalida.Values.Image = Nothing
        Me.lblFechaSalida.Values.Text = "Fecha de Salida: "
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(129, 475)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(177, 20)
        Me.dtpFechaSalida.TabIndex = 86
        '
        'KryptonBorderEdge1
        '
        Me.KryptonBorderEdge1.Location = New System.Drawing.Point(15, 468)
        Me.KryptonBorderEdge1.Name = "KryptonBorderEdge1"
        Me.KryptonBorderEdge1.Size = New System.Drawing.Size(790, 1)
        Me.KryptonBorderEdge1.TabIndex = 84
        Me.KryptonBorderEdge1.Text = "KryptonBorderEdge1"
        '
        'lblZonaAlmacen
        '
        Me.lblZonaAlmacen.Location = New System.Drawing.Point(565, 163)
        Me.lblZonaAlmacen.Name = "lblZonaAlmacen"
        Me.lblZonaAlmacen.Size = New System.Drawing.Size(44, 20)
        Me.lblZonaAlmacen.TabIndex = 40
        Me.lblZonaAlmacen.Text = "Zona : "
        Me.lblZonaAlmacen.Values.ExtraText = ""
        Me.lblZonaAlmacen.Values.Image = Nothing
        Me.lblZonaAlmacen.Values.Text = "Zona : "
        '
        'lblAlmacen
        '
        Me.lblAlmacen.Location = New System.Drawing.Point(317, 163)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(64, 20)
        Me.lblAlmacen.TabIndex = 38
        Me.lblAlmacen.Text = "Almacen : "
        Me.lblAlmacen.Values.ExtraText = ""
        Me.lblAlmacen.Values.Image = Nothing
        Me.lblAlmacen.Values.Text = "Almacen : "
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(7, 167)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(91, 20)
        Me.lblTipoAlmacen.TabIndex = 36
        Me.lblTipoAlmacen.Text = "Tipo Almacén : "
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo Almacén : "
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(703, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 31)
        Me.btnCancelar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnCancelar.TabIndex = 88
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.Values.ExtraText = ""
        Me.btnCancelar.Values.Image = CType(resources.GetObject("btnCancelar.Values.Image"), System.Drawing.Image)
        Me.btnCancelar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelar.Values.Text = "&Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(600, 419)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 31)
        Me.btnGuardar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnGuardar.TabIndex = 87
        Me.btnGuardar.TabStop = False
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Values.ExtraText = ""
        Me.btnGuardar.Values.Image = CType(resources.GetObject("btnGuardar.Values.Image"), System.Drawing.Image)
        Me.btnGuardar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGuardar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGuardar.Values.Text = "&Guardar"
        '
        'txtImporteBulto
        '
        Me.TypeValidator.SetDecimales(Me.txtImporteBulto, 2)
        Me.txtImporteBulto.Enabled = False
        Me.TypeValidator.SetEnterTAB(Me.txtImporteBulto, True)
        Me.txtImporteBulto.Location = New System.Drawing.Point(418, 137)
        Me.txtImporteBulto.Name = "txtImporteBulto"
        Me.txtImporteBulto.Size = New System.Drawing.Size(139, 22)
        Me.txtImporteBulto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImporteBulto.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImporteBulto.StateDisabled.Content.Color1 = System.Drawing.Color.Black
        Me.txtImporteBulto.StateDisabled.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteBulto.TabIndex = 33
        Me.txtImporteBulto.TabStop = False
        Me.txtImporteBulto.Text = "0.00"
        Me.txtImporteBulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtImporteBulto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'lblImporteBulto
        '
        Me.lblImporteBulto.Location = New System.Drawing.Point(313, 140)
        Me.lblImporteBulto.Name = "lblImporteBulto"
        Me.lblImporteBulto.Size = New System.Drawing.Size(112, 20)
        Me.lblImporteBulto.TabIndex = 32
        Me.lblImporteBulto.Text = "Importe del Bulto : "
        Me.lblImporteBulto.Values.ExtraText = ""
        Me.lblImporteBulto.Values.Image = Nothing
        Me.lblImporteBulto.Values.Text = "Importe del Bulto : "
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoMovimientoListar})
        Me.txtTipoMovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoMovimiento, True)
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(129, 12)
        Me.txtTipoMovimiento.MaxLength = 50
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(177, 22)
        Me.txtTipoMovimiento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoMovimiento.TabIndex = 1
        '
        'bsaTipoMovimientoListar
        '
        Me.bsaTipoMovimientoListar.ExtraText = ""
        Me.bsaTipoMovimientoListar.Image = Nothing
        Me.bsaTipoMovimientoListar.Text = ""
        Me.bsaTipoMovimientoListar.ToolTipImage = Nothing
        Me.bsaTipoMovimientoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoMovimientoListar.UniqueName = "487510825A024D08487510825A024D08"
        '
        'txtCodigoEmbarcador
        '
        Me.txtCodigoEmbarcador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoEmbarcador, True)
        Me.txtCodigoEmbarcador.Location = New System.Drawing.Point(129, 87)
        Me.txtCodigoEmbarcador.MaxLength = 20
        Me.txtCodigoEmbarcador.Name = "txtCodigoEmbarcador"
        Me.txtCodigoEmbarcador.Size = New System.Drawing.Size(178, 22)
        Me.txtCodigoEmbarcador.TabIndex = 21
        '
        'lblCodigoRecepcion
        '
        Me.lblCodigoRecepcion.Location = New System.Drawing.Point(7, 40)
        Me.lblCodigoRecepcion.Name = "lblCodigoRecepcion"
        Me.lblCodigoRecepcion.Size = New System.Drawing.Size(116, 20)
        Me.lblCodigoRecepcion.TabIndex = 8
        Me.lblCodigoRecepcion.Text = "Código Recepción : "
        Me.lblCodigoRecepcion.Values.ExtraText = ""
        Me.lblCodigoRecepcion.Values.Image = Nothing
        Me.lblCodigoRecepcion.Values.Text = "Código Recepción : "
        '
        'txtCodigoRecepcion
        '
        Me.txtCodigoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoRecepcion, True)
        Me.txtCodigoRecepcion.Location = New System.Drawing.Point(129, 37)
        Me.txtCodigoRecepcion.MaxLength = 20
        Me.txtCodigoRecepcion.Name = "txtCodigoRecepcion"
        Me.txtCodigoRecepcion.Size = New System.Drawing.Size(177, 22)
        Me.txtCodigoRecepcion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigoRecepcion.TabIndex = 9
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(562, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(108, 20)
        Me.KryptonLabel1.TabIndex = 4
        Me.KryptonLabel1.Text = "Fecha Recepción :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha Recepción :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(7, 115)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(122, 20)
        Me.KryptonLabel2.TabIndex = 26
        Me.KryptonLabel2.Text = "Incidencia / Motivo : "
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Incidencia / Motivo : "
        '
        'txtMotivoRecepcion
        '
        Me.txtMotivoRecepcion.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaMotivoRecepcionListar})
        Me.txtMotivoRecepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtMotivoRecepcion, True)
        Me.txtMotivoRecepcion.Location = New System.Drawing.Point(129, 112)
        Me.txtMotivoRecepcion.MaxLength = 50
        Me.txtMotivoRecepcion.Name = "txtMotivoRecepcion"
        Me.txtMotivoRecepcion.Size = New System.Drawing.Size(178, 22)
        Me.txtMotivoRecepcion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMotivoRecepcion.TabIndex = 27
        '
        'bsaMotivoRecepcionListar
        '
        Me.bsaMotivoRecepcionListar.ExtraText = ""
        Me.bsaMotivoRecepcionListar.Image = Nothing
        Me.bsaMotivoRecepcionListar.Text = ""
        Me.bsaMotivoRecepcionListar.ToolTipImage = Nothing
        Me.bsaMotivoRecepcionListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaMotivoRecepcionListar.UniqueName = "F324A6DEA8794F36F324A6DEA8794F36"
        '
        'lblCodigoEmbarcador
        '
        Me.lblCodigoEmbarcador.Location = New System.Drawing.Point(7, 90)
        Me.lblCodigoEmbarcador.Name = "lblCodigoEmbarcador"
        Me.lblCodigoEmbarcador.Size = New System.Drawing.Size(125, 20)
        Me.lblCodigoEmbarcador.TabIndex = 20
        Me.lblCodigoEmbarcador.Text = "Código Embarcador : "
        Me.lblCodigoEmbarcador.Values.ExtraText = ""
        Me.lblCodigoEmbarcador.Values.Image = Nothing
        Me.lblCodigoEmbarcador.Values.Text = "Código Embarcador : "
        '
        'KryptonLabel16
        '
        Me.KryptonLabel16.Location = New System.Drawing.Point(7, 140)
        Me.KryptonLabel16.Name = "KryptonLabel16"
        Me.KryptonLabel16.Size = New System.Drawing.Size(111, 20)
        Me.KryptonLabel16.TabIndex = 30
        Me.KryptonLabel16.Text = "Sentido de Carga : "
        Me.KryptonLabel16.Values.ExtraText = ""
        Me.KryptonLabel16.Values.Image = Nothing
        Me.KryptonLabel16.Values.Text = "Sentido de Carga : "
        '
        'txtCodigoOrigen
        '
        Me.txtCodigoOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtCodigoOrigen, True)
        Me.txtCodigoOrigen.Location = New System.Drawing.Point(129, 62)
        Me.txtCodigoOrigen.MaxLength = 15
        Me.txtCodigoOrigen.Name = "txtCodigoOrigen"
        Me.txtCodigoOrigen.Size = New System.Drawing.Size(177, 22)
        Me.txtCodigoOrigen.TabIndex = 15
        '
        'txtSentidoCarga
        '
        Me.txtSentidoCarga.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaSentidoCargaListar})
        Me.txtSentidoCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtSentidoCarga, True)
        Me.txtSentidoCarga.Location = New System.Drawing.Point(129, 137)
        Me.txtSentidoCarga.MaxLength = 50
        Me.txtSentidoCarga.Name = "txtSentidoCarga"
        Me.txtSentidoCarga.Size = New System.Drawing.Size(178, 22)
        Me.txtSentidoCarga.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSentidoCarga.TabIndex = 31
        '
        'bsaSentidoCargaListar
        '
        Me.bsaSentidoCargaListar.ExtraText = ""
        Me.bsaSentidoCargaListar.Image = Nothing
        Me.bsaSentidoCargaListar.Text = ""
        Me.bsaSentidoCargaListar.ToolTipImage = Nothing
        Me.bsaSentidoCargaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaSentidoCargaListar.UniqueName = "80D83D86B08A46CE80D83D86B08A46CE"
        '
        'lblCodigoOrigen
        '
        Me.lblCodigoOrigen.Location = New System.Drawing.Point(7, 65)
        Me.lblCodigoOrigen.Name = "lblCodigoOrigen"
        Me.lblCodigoOrigen.Size = New System.Drawing.Size(97, 20)
        Me.lblCodigoOrigen.TabIndex = 14
        Me.lblCodigoOrigen.Text = "Código Origen : "
        Me.lblCodigoOrigen.Values.ExtraText = ""
        Me.lblCodigoOrigen.Values.Image = Nothing
        Me.lblCodigoOrigen.Values.Text = "Código Origen : "
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(313, 40)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(101, 20)
        Me.KryptonLabel5.TabIndex = 10
        Me.KryptonLabel5.Text = "Cant.Recib.Frgh : "
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Cant.Recib.Frgh : "
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(313, 15)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel6.TabIndex = 2
        Me.KryptonLabel6.Text = "Tipo de Bulto : "
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Tipo de Bulto : "
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 15)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(127, 20)
        Me.KryptonLabel3.TabIndex = 0
        Me.KryptonLabel3.Text = "Tipo de Movimiento : "
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo de Movimiento : "
        '
        'txtTipoBulto
        '
        Me.txtTipoBulto.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaTipoBultoListar})
        Me.txtTipoBulto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtTipoBulto, True)
        Me.txtTipoBulto.Location = New System.Drawing.Point(418, 12)
        Me.txtTipoBulto.MaxLength = 10
        Me.txtTipoBulto.Name = "txtTipoBulto"
        Me.txtTipoBulto.Size = New System.Drawing.Size(139, 22)
        Me.txtTipoBulto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoBulto.TabIndex = 3
        '
        'bsaTipoBultoListar
        '
        Me.bsaTipoBultoListar.ExtraText = ""
        Me.bsaTipoBultoListar.Image = Nothing
        Me.bsaTipoBultoListar.Text = ""
        Me.bsaTipoBultoListar.ToolTipImage = Nothing
        Me.bsaTipoBultoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaTipoBultoListar.UniqueName = "FBC643B4BAEB4B32FBC643B4BAEB4B32"
        '
        'txtNroTicketBalanza
        '
        Me.txtNroTicketBalanza.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaNroTicketBalanzaListar})
        Me.TypeValidator.SetEnterTAB(Me.txtNroTicketBalanza, True)
        Me.txtNroTicketBalanza.Location = New System.Drawing.Point(663, 136)
        Me.txtNroTicketBalanza.Name = "txtNroTicketBalanza"
        Me.txtNroTicketBalanza.Size = New System.Drawing.Size(154, 22)
        Me.txtNroTicketBalanza.TabIndex = 35
        Me.txtNroTicketBalanza.Text = "0"
        Me.TypeValidator.SetTypes(Me.txtNroTicketBalanza, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'bsaNroTicketBalanzaListar
        '
        Me.bsaNroTicketBalanzaListar.ExtraText = ""
        Me.bsaNroTicketBalanzaListar.Image = Nothing
        Me.bsaNroTicketBalanzaListar.Text = ""
        Me.bsaNroTicketBalanzaListar.ToolTipImage = Nothing
        Me.bsaNroTicketBalanzaListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaNroTicketBalanzaListar.UniqueName = "58CA164B7CD4423958CA164B7CD44239"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(313, 65)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel7.TabIndex = 16
        Me.KryptonLabel7.Text = "Peso Bulto : "
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Peso Bulto : "
        '
        'txtCantidadRecibida
        '
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadRecibida, True)
        Me.txtCantidadRecibida.Location = New System.Drawing.Point(418, 37)
        Me.txtCantidadRecibida.MaxLength = 6
        Me.txtCantidadRecibida.Name = "txtCantidadRecibida"
        Me.txtCantidadRecibida.Size = New System.Drawing.Size(139, 22)
        Me.txtCantidadRecibida.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadRecibida.TabIndex = 11
        Me.txtCantidadRecibida.Text = "0"
        Me.txtCantidadRecibida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(562, 62)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel8.TabIndex = 18
        Me.KryptonLabel8.Text = "Unidad Peso : "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Unidad Peso : "
        '
        'txtCantidadAreaOcupada
        '
        Me.TypeValidator.SetDecimales(Me.txtCantidadAreaOcupada, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtCantidadAreaOcupada, True)
        Me.txtCantidadAreaOcupada.Location = New System.Drawing.Point(663, 35)
        Me.txtCantidadAreaOcupada.MaxLength = 6
        Me.txtCantidadAreaOcupada.Name = "txtCantidadAreaOcupada"
        Me.txtCantidadAreaOcupada.Size = New System.Drawing.Size(156, 22)
        Me.txtCantidadAreaOcupada.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidadAreaOcupada.TabIndex = 13
        Me.txtCantidadAreaOcupada.Text = "0.00"
        Me.txtCantidadAreaOcupada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtCantidadAreaOcupada, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'txtUnidadPeso
        '
        Me.txtUnidadPeso.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaUnidadPesoListar})
        Me.txtUnidadPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtUnidadPeso, True)
        Me.txtUnidadPeso.Location = New System.Drawing.Point(663, 60)
        Me.txtUnidadPeso.MaxLength = 10
        Me.txtUnidadPeso.Name = "txtUnidadPeso"
        Me.txtUnidadPeso.Size = New System.Drawing.Size(155, 22)
        Me.txtUnidadPeso.TabIndex = 19
        '
        'bsaUnidadPesoListar
        '
        Me.bsaUnidadPesoListar.ExtraText = ""
        Me.bsaUnidadPesoListar.Image = Nothing
        Me.bsaUnidadPesoListar.Text = ""
        Me.bsaUnidadPesoListar.ToolTipImage = Nothing
        Me.bsaUnidadPesoListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaUnidadPesoListar.UniqueName = "D3DCD48556844981D3DCD48556844981"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(565, 139)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(96, 20)
        Me.KryptonLabel4.TabIndex = 34
        Me.KryptonLabel4.Text = "No. Ticket Blza : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "No. Ticket Blza : "
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(313, 90)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(97, 20)
        Me.KryptonLabel9.TabIndex = 22
        Me.KryptonLabel9.Text = "Volumen Bulto : "
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Volumen Bulto : "
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(562, 87)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(108, 20)
        Me.KryptonLabel10.TabIndex = 24
        Me.KryptonLabel10.Text = "Unidad Volumen : "
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Unidad Volumen : "
        '
        'txtPesoBulto
        '
        Me.TypeValidator.SetDecimales(Me.txtPesoBulto, 2)
        Me.TypeValidator.SetEnterTAB(Me.txtPesoBulto, True)
        Me.txtPesoBulto.Location = New System.Drawing.Point(418, 62)
        Me.txtPesoBulto.Name = "txtPesoBulto"
        Me.txtPesoBulto.Size = New System.Drawing.Size(139, 22)
        Me.txtPesoBulto.TabIndex = 17
        Me.txtPesoBulto.Text = "0.00"
        Me.txtPesoBulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TypeValidator.SetTypes(Me.txtPesoBulto, TypeValidatorKrypton.Controls.TypeValidatorKrypton.TY.Numeros)
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(562, 37)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(94, 20)
        Me.KryptonLabel12.TabIndex = 12
        Me.KryptonLabel12.Text = "Área Ocupada : "
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Área Ocupada : "
        '
        'txtDescripcionWaybill
        '
        Me.txtDescripcionWaybill.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TypeValidator.SetEnterTAB(Me.txtDescripcionWaybill, True)
        Me.txtDescripcionWaybill.Location = New System.Drawing.Point(418, 112)
        Me.txtDescripcionWaybill.MaxLength = 40
        Me.txtDescripcionWaybill.Name = "txtDescripcionWaybill"
        Me.txtDescripcionWaybill.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDescripcionWaybill.Size = New System.Drawing.Size(400, 22)
        Me.txtDescripcionWaybill.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcionWaybill.TabIndex = 29
        '
        'KryptonLabel14
        '
        Me.KryptonLabel14.Location = New System.Drawing.Point(313, 115)
        Me.KryptonLabel14.Name = "KryptonLabel14"
        Me.KryptonLabel14.Size = New System.Drawing.Size(98, 20)
        Me.KryptonLabel14.TabIndex = 28
        Me.KryptonLabel14.Text = "Detalle WayBill : "
        Me.KryptonLabel14.Values.ExtraText = ""
        Me.KryptonLabel14.Values.Image = Nothing
        Me.KryptonLabel14.Values.Text = "Detalle WayBill : "
        '
        'tsMenuOpcionesDetalle
        '
        Me.tsMenuOpcionesDetalle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpcionesDetalle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpcionesDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpcionesDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpcionesDetalle.Name = "tsMenuOpcionesDetalle"
        Me.tsMenuOpcionesDetalle.Size = New System.Drawing.Size(826, 25)
        Me.tsMenuOpcionesDetalle.TabIndex = 1
        Me.tsMenuOpcionesDetalle.Text = "Detalle Guía de Remisión"
        '
        'btnAdjuntarGuia
        '
        Me.btnAdjuntarGuia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAdjuntarGuia.Image = Global.SOLMIN_SA.My.Resources.Resources.text_block
        Me.btnAdjuntarGuia.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdjuntarGuia.Name = "btnAdjuntarGuia"
        Me.btnAdjuntarGuia.Size = New System.Drawing.Size(100, 22)
        Me.btnAdjuntarGuia.Text = "Adjuntar Guía"
        '
        'tssVistaPrevia
        '
        Me.tssVistaPrevia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssVistaPrevia.Name = "tssVistaPrevia"
        Me.tssVistaPrevia.Size = New System.Drawing.Size(6, 25)
        Me.tssVistaPrevia.Visible = False
        '
        'tslblDetalleTitulo
        '
        Me.tslblDetalleTitulo.Name = "tslblDetalleTitulo"
        Me.tslblDetalleTitulo.Size = New System.Drawing.Size(35, 22)
        Me.tslblDetalleTitulo.Text = "Bulto"
        '
        'BeBultoBindingSource
        '
        Me.BeBultoBindingSource.DataSource = GetType(Ransa.TYPEDEF.beBulto)
        '
        'frmModificarBulto_V3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 654)
        Me.Controls.Add(Me.pnlModificarBulto)
        Me.Controls.Add(Me.tsMenuOpcionesDetalle)
        Me.Name = "frmModificarBulto_V3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BULTO - "
        CType(Me.pnlModificarBulto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlModificarBulto.ResumeLayout(False)
        Me.pnlModificarBulto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tspListadoMercaderia.ResumeLayout(False)
        Me.tspListadoMercaderia.PerformLayout()
        CType(Me.dtgPaquetesDeBulto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeBultoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
 

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents pnlModificarBulto As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents TypeValidator As TypeValidatorKrypton.Controls.TypeValidatorKrypton.TypeValidator
    Friend WithEvents txtNroTicketBalanza As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadRecibida As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCantidadAreaOcupada As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtDescripcionWaybill As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel14 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadVolumen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSentidoCarga As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel16 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMotivoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoRecepcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoMovimiento As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoEmbarcador As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoEmbarcador As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodigoOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCodigoOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtImporteBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblImporteBulto As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsaTipoMovimientoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaMotivoRecepcionListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaSentidoCargaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaTipoBultoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaNroTicketBalanzaListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaUnidadPesoListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsaUnidadVolumenListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents btnCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblZonaAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents tsMenuOpcionesDetalle As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdjuntarGuia As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssVistaPrevia As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslblDetalleTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents KryptonBorderEdge1 As ComponentFactory.Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents lblFechaSalida As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVolumenBulto As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaVolumenBulto As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents LblTipoMaterial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaSolicitudMedio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaSolicitud As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel15 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtEtiqueta As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblEtiqueta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTarifa As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTarifa As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtNumeroContenedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnAyudaContenedor As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents txtUsuarioReferencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblUsuarioReferencia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkCnt As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSigla As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtEntrega As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtOrigen As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtAfe As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblCuentaImpAfe As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtGuiaProveedor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel22 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtFluvial As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtAereo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel19 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel20 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTerrestre As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel21 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtInformacionAdicional As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblDescripcionAdicional As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPesoTicket As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPesoTicket As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNroOrdenServicioAgencia As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel23 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel25 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ucIncidencia As RANSA.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel26 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtZonaAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtUbicacionReferencial As Ransa.Utilitario.ucAyuda
    Friend WithEvents TxtTipoMaterial As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtTipoCarga As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtMedioSugerido As Ransa.Utilitario.ucAyuda
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtgPaquetesDeBulto As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents PNQCTPQT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTLRG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTANC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQMTALT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQVOLMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNQPSOMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tspListadoMercaderia As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbEliminarPaquete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss03 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAgregarPaquete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BeBultoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtHoraEntrega As System.Windows.Forms.MaskedTextBox




End Class
