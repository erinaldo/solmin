<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenTarifaAdmin
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
        Dim BePlanta1 As Ransa.Controls.UbicacionPlanta.Planta.bePlanta = New Ransa.Controls.UbicacionPlanta.Planta.bePlanta()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMenuOpciones = New System.Windows.Forms.ToolStrip()
        Me.btnCancelarTarifa = New System.Windows.Forms.ToolStripButton()
        Me.tsSep_05 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGrabarTarifa = New System.Windows.Forms.ToolStripButton()
        Me.tssSep_02 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01()
        Me.cboDivision = New System.Windows.Forms.ComboBox()
        Me.txtTarifaInterna = New System.Windows.Forms.TextBox()
        Me.lblTarifaInterna = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpDatosAdic = New System.Windows.Forms.TabPage()
        Me.tpTipoFijo = New System.Windows.Forms.TabPage()
        Me.lblDiadeCorte = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDiasdeCorte = New System.Windows.Forms.TextBox()
        Me.lblCodTarifaRef = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCodTarifaRef = New Ransa.Utilitario.ucAyuda()
        Me.tpTipoPermanencia = New System.Windows.Forms.TabPage()
        Me.lblPeriodo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPeriodoLibre = New System.Windows.Forms.TextBox()
        Me.chkPeriodoLibre = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.lblDiasFacturar = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtDiasFacturar = New System.Windows.Forms.TextBox()
        Me.lblTipoAlmacen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoAlmacen = New Ransa.Utilitario.ucAyuda()
        Me.lbltipoMercaderia = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TxtTipoMaterial = New Ransa.Utilitario.ucAyuda()
        Me.lblCentCostoOrigen = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbCentCostoOrigen = New Ransa.Utilitario.ucAyuda()
        Me.cboServicio = New Ransa.Utilitario.ucAyuda()
        Me.lblCentCostoDestino = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboLogicaFacturacion = New Ransa.Utilitario.ucAyuda()
        Me.cmbCentCostoDestino = New Ransa.Utilitario.ucAyuda()
        Me.cboTipoActivo = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel18 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadProductiva = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel17 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtTipoServicio = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblLogicaFacturacion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbCentroBeneficio = New Ransa.Utilitario.ucAyuda()
        Me.cmbMoneda = New Ransa.Utilitario.ucAyuda()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbUnidadMedida = New Ransa.Utilitario.ucAyuda()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCodTarifa = New System.Windows.Forms.TextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblDescripcion = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboTipoTarifa = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.dtgRangoTarifa = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tsBarraRango = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtIniRango = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtFinRango = New System.Windows.Forms.ToolStripTextBox()
        Me.btnQuitaRango = New System.Windows.Forms.ToolStripButton()
        Me.btnAgregaRango = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtMontoRango = New System.Windows.Forms.ToolStripTextBox()
        Me.CodTarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodRango = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RangoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RangoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenuOpciones.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpTipoFijo.SuspendLayout()
        Me.tpTipoPermanencia.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgRangoTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsBarraRango.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenuOpciones
        '
        Me.tsMenuOpciones.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsMenuOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsMenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelarTarifa, Me.tsSep_05, Me.btnGrabarTarifa, Me.tssSep_02})
        Me.tsMenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.tsMenuOpciones.Name = "tsMenuOpciones"
        Me.tsMenuOpciones.Size = New System.Drawing.Size(1451, 27)
        Me.tsMenuOpciones.TabIndex = 0
        '
        'btnCancelarTarifa
        '
        Me.btnCancelarTarifa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelarTarifa.Image = Global.SOLMIN_CT.My.Resources.Resources._exit
        Me.btnCancelarTarifa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarTarifa.Name = "btnCancelarTarifa"
        Me.btnCancelarTarifa.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelarTarifa.Text = "Cancelar"
        '
        'tsSep_05
        '
        Me.tsSep_05.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSep_05.Name = "tsSep_05"
        Me.tsSep_05.Size = New System.Drawing.Size(6, 27)
        '
        'btnGrabarTarifa
        '
        Me.btnGrabarTarifa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGrabarTarifa.Image = Global.SOLMIN_CT.My.Resources.Resources.save_all
        Me.btnGrabarTarifa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabarTarifa.Name = "btnGrabarTarifa"
        Me.btnGrabarTarifa.Size = New System.Drawing.Size(86, 24)
        Me.btnGrabarTarifa.Text = "Guardar"
        '
        'tssSep_02
        '
        Me.tssSep_02.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSep_02.Name = "tssSep_02"
        Me.tssSep_02.Size = New System.Drawing.Size(6, 27)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcPLanta_Cmb011)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboDivision)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTarifaInterna)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTarifaInterna)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCentCostoOrigen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCentCostoOrigen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboServicio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCentCostoDestino)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboLogicaFacturacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCentCostoDestino)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboTipoActivo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel18)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtUnidadProductiva)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTipoServicio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLogicaFacturacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCentroBeneficio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbMoneda)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbUnidadMedida)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCantidad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCantidad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCodTarifa)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMonto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KryptonLabel11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboTipoTarifa)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtgRangoTarifa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tsBarraRango)
        Me.SplitContainer1.Size = New System.Drawing.Size(1451, 676)
        Me.SplitContainer1.SplitterDistance = 427
        Me.SplitContainer1.TabIndex = 1
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
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(1051, 8)
        Me.UcPLanta_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(200, 26)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        BePlanta1.CCMPN_CodigoCompania = ""
        BePlanta1.CDSPSP_CodSedeSAP = Nothing
        BePlanta1.CDVSN_CodigoDivision = ""
        BePlanta1.CPLNDV_CodigoPlanta = 0.0R
        BePlanta1.Orden = -1
        BePlanta1.TPLNTA_DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.obePlanta = BePlanta1
        Me.UcPLanta_Cmb011.pHabilitado = False
        Me.UcPLanta_Cmb011.Planta = 0.0R
        Me.UcPLanta_Cmb011.PlantaDefault = -1.0R
        Me.UcPLanta_Cmb011.pRequerido = True
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(368, 28)
        Me.UcPLanta_Cmb011.TabIndex = 133
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'cboDivision
        '
        Me.cboDivision.BackColor = System.Drawing.SystemColors.Info
        Me.cboDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivision.FormattingEnabled = True
        Me.cboDivision.Location = New System.Drawing.Point(592, 11)
        Me.cboDivision.Name = "cboDivision"
        Me.cboDivision.Size = New System.Drawing.Size(322, 24)
        Me.cboDivision.TabIndex = 131
        '
        'txtTarifaInterna
        '
        Me.txtTarifaInterna.BackColor = System.Drawing.Color.White
        Me.txtTarifaInterna.Location = New System.Drawing.Point(165, 256)
        Me.txtTarifaInterna.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifaInterna.MaxLength = 16
        Me.txtTarifaInterna.Name = "txtTarifaInterna"
        Me.txtTarifaInterna.Size = New System.Drawing.Size(265, 22)
        Me.txtTarifaInterna.TabIndex = 115
        Me.txtTarifaInterna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTarifaInterna
        '
        Me.lblTarifaInterna.Location = New System.Drawing.Point(36, 254)
        Me.lblTarifaInterna.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTarifaInterna.Name = "lblTarifaInterna"
        Me.lblTarifaInterna.Size = New System.Drawing.Size(109, 24)
        Me.lblTarifaInterna.TabIndex = 29
        Me.lblTarifaInterna.Text = "Tarifa Interna :"
        Me.lblTarifaInterna.Values.ExtraText = ""
        Me.lblTarifaInterna.Values.Image = Nothing
        Me.lblTarifaInterna.Values.Text = "Tarifa Interna :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpDatosAdic)
        Me.TabControl1.Controls.Add(Me.tpTipoFijo)
        Me.TabControl1.Controls.Add(Me.tpTipoPermanencia)
        Me.TabControl1.Location = New System.Drawing.Point(382, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1041, 93)
        Me.TabControl1.TabIndex = 35
        '
        'tpDatosAdic
        '
        Me.tpDatosAdic.Location = New System.Drawing.Point(4, 25)
        Me.tpDatosAdic.Name = "tpDatosAdic"
        Me.tpDatosAdic.Size = New System.Drawing.Size(1033, 64)
        Me.tpDatosAdic.TabIndex = 2
        Me.tpDatosAdic.UseVisualStyleBackColor = True
        '
        'tpTipoFijo
        '
        Me.tpTipoFijo.Controls.Add(Me.lblDiadeCorte)
        Me.tpTipoFijo.Controls.Add(Me.txtDiasdeCorte)
        Me.tpTipoFijo.Controls.Add(Me.lblCodTarifaRef)
        Me.tpTipoFijo.Controls.Add(Me.txtCodTarifaRef)
        Me.tpTipoFijo.Location = New System.Drawing.Point(4, 25)
        Me.tpTipoFijo.Name = "tpTipoFijo"
        Me.tpTipoFijo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTipoFijo.Size = New System.Drawing.Size(1033, 64)
        Me.tpTipoFijo.TabIndex = 0
        Me.tpTipoFijo.Text = "Fijo"
        Me.tpTipoFijo.UseVisualStyleBackColor = True
        '
        'lblDiadeCorte
        '
        Me.lblDiadeCorte.Location = New System.Drawing.Point(17, 11)
        Me.lblDiadeCorte.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiadeCorte.Name = "lblDiadeCorte"
        Me.lblDiadeCorte.Size = New System.Drawing.Size(104, 24)
        Me.lblDiadeCorte.TabIndex = 13375
        Me.lblDiadeCorte.Text = "Día de Corte :"
        Me.lblDiadeCorte.Values.ExtraText = ""
        Me.lblDiadeCorte.Values.Image = Nothing
        Me.lblDiadeCorte.Values.Text = "Día de Corte :"
        '
        'txtDiasdeCorte
        '
        Me.txtDiasdeCorte.Location = New System.Drawing.Point(150, 13)
        Me.txtDiasdeCorte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiasdeCorte.MaxLength = 2
        Me.txtDiasdeCorte.Name = "txtDiasdeCorte"
        Me.txtDiasdeCorte.Size = New System.Drawing.Size(63, 22)
        Me.txtDiasdeCorte.TabIndex = 40
        Me.txtDiasdeCorte.Text = "0"
        Me.txtDiasdeCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCodTarifaRef
        '
        Me.lblCodTarifaRef.Location = New System.Drawing.Point(230, 11)
        Me.lblCodTarifaRef.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCodTarifaRef.Name = "lblCodTarifaRef"
        Me.lblCodTarifaRef.Size = New System.Drawing.Size(123, 24)
        Me.lblCodTarifaRef.TabIndex = 13372
        Me.lblCodTarifaRef.Text = "Cod. Tarifa  Ref :"
        Me.lblCodTarifaRef.Values.ExtraText = ""
        Me.lblCodTarifaRef.Values.Image = Nothing
        Me.lblCodTarifaRef.Values.Text = "Cod. Tarifa  Ref :"
        '
        'txtCodTarifaRef
        '
        Me.txtCodTarifaRef.BackColor = System.Drawing.Color.Transparent
        Me.txtCodTarifaRef.DataSource = Nothing
        Me.txtCodTarifaRef.DispleyMember = ""
        Me.txtCodTarifaRef.Etiquetas_Form = Nothing
        Me.txtCodTarifaRef.ListColumnas = Nothing
        Me.txtCodTarifaRef.Location = New System.Drawing.Point(374, 8)
        Me.txtCodTarifaRef.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodTarifaRef.Name = "txtCodTarifaRef"
        Me.txtCodTarifaRef.Obligatorio = True
        Me.txtCodTarifaRef.PopupHeight = 0
        Me.txtCodTarifaRef.PopupWidth = 0
        Me.txtCodTarifaRef.Size = New System.Drawing.Size(317, 27)
        Me.txtCodTarifaRef.SizeFont = 0
        Me.txtCodTarifaRef.TabIndex = 45
        Me.txtCodTarifaRef.ValueMember = ""
        '
        'tpTipoPermanencia
        '
        Me.tpTipoPermanencia.Controls.Add(Me.lblPeriodo)
        Me.tpTipoPermanencia.Controls.Add(Me.txtPeriodoLibre)
        Me.tpTipoPermanencia.Controls.Add(Me.chkPeriodoLibre)
        Me.tpTipoPermanencia.Controls.Add(Me.lblDiasFacturar)
        Me.tpTipoPermanencia.Controls.Add(Me.txtDiasFacturar)
        Me.tpTipoPermanencia.Controls.Add(Me.lblTipoAlmacen)
        Me.tpTipoPermanencia.Controls.Add(Me.txtTipoAlmacen)
        Me.tpTipoPermanencia.Controls.Add(Me.lbltipoMercaderia)
        Me.tpTipoPermanencia.Controls.Add(Me.TxtTipoMaterial)
        Me.tpTipoPermanencia.Location = New System.Drawing.Point(4, 25)
        Me.tpTipoPermanencia.Name = "tpTipoPermanencia"
        Me.tpTipoPermanencia.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTipoPermanencia.Size = New System.Drawing.Size(1033, 64)
        Me.tpTipoPermanencia.TabIndex = 1
        Me.tpTipoPermanencia.Text = "Permanencia"
        Me.tpTipoPermanencia.UseVisualStyleBackColor = True
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(7, 4)
        Me.lblPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(106, 24)
        Me.lblPeriodo.TabIndex = 13346
        Me.lblPeriodo.Text = "Periodo libre :"
        Me.lblPeriodo.Values.ExtraText = ""
        Me.lblPeriodo.Values.Image = Nothing
        Me.lblPeriodo.Values.Text = "Periodo libre :"
        '
        'txtPeriodoLibre
        '
        Me.txtPeriodoLibre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeriodoLibre.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPeriodoLibre.Location = New System.Drawing.Point(141, 6)
        Me.txtPeriodoLibre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPeriodoLibre.MaxLength = 10
        Me.txtPeriodoLibre.Name = "txtPeriodoLibre"
        Me.txtPeriodoLibre.Size = New System.Drawing.Size(63, 22)
        Me.txtPeriodoLibre.TabIndex = 50
        Me.txtPeriodoLibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPeriodoLibre
        '
        Me.chkPeriodoLibre.Checked = False
        Me.chkPeriodoLibre.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkPeriodoLibre.Location = New System.Drawing.Point(212, 4)
        Me.chkPeriodoLibre.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPeriodoLibre.Name = "chkPeriodoLibre"
        Me.chkPeriodoLibre.Size = New System.Drawing.Size(233, 24)
        Me.chkPeriodoLibre.TabIndex = 55
        Me.chkPeriodoLibre.Text = "En cálculo excluir periodo libre "
        Me.chkPeriodoLibre.Values.ExtraText = ""
        Me.chkPeriodoLibre.Values.Image = Nothing
        Me.chkPeriodoLibre.Values.Text = "En cálculo excluir periodo libre "
        '
        'lblDiasFacturar
        '
        Me.lblDiasFacturar.Location = New System.Drawing.Point(507, 4)
        Me.lblDiasFacturar.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiasFacturar.Name = "lblDiasFacturar"
        Me.lblDiasFacturar.Size = New System.Drawing.Size(120, 24)
        Me.lblDiasFacturar.TabIndex = 13371
        Me.lblDiasFacturar.Text = "Días a Facturar :"
        Me.lblDiasFacturar.Values.ExtraText = ""
        Me.lblDiasFacturar.Values.Image = Nothing
        Me.lblDiasFacturar.Values.Text = "Días a Facturar :"
        '
        'txtDiasFacturar
        '
        Me.txtDiasFacturar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiasFacturar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiasFacturar.Location = New System.Drawing.Point(656, 6)
        Me.txtDiasFacturar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiasFacturar.MaxLength = 10
        Me.txtDiasFacturar.Name = "txtDiasFacturar"
        Me.txtDiasFacturar.Size = New System.Drawing.Size(133, 22)
        Me.txtDiasFacturar.TabIndex = 60
        Me.txtDiasFacturar.Text = "0"
        Me.txtDiasFacturar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTipoAlmacen
        '
        Me.lblTipoAlmacen.Location = New System.Drawing.Point(9, 35)
        Me.lblTipoAlmacen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTipoAlmacen.Name = "lblTipoAlmacen"
        Me.lblTipoAlmacen.Size = New System.Drawing.Size(112, 24)
        Me.lblTipoAlmacen.TabIndex = 13366
        Me.lblTipoAlmacen.Text = "Tipo Almacén :"
        Me.lblTipoAlmacen.Values.ExtraText = ""
        Me.lblTipoAlmacen.Values.Image = Nothing
        Me.lblTipoAlmacen.Values.Text = "Tipo Almacén :"
        '
        'txtTipoAlmacen
        '
        Me.txtTipoAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoAlmacen.DataSource = Nothing
        Me.txtTipoAlmacen.DispleyMember = ""
        Me.txtTipoAlmacen.Etiquetas_Form = Nothing
        Me.txtTipoAlmacen.ListColumnas = Nothing
        Me.txtTipoAlmacen.Location = New System.Drawing.Point(141, 32)
        Me.txtTipoAlmacen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTipoAlmacen.Name = "txtTipoAlmacen"
        Me.txtTipoAlmacen.Obligatorio = True
        Me.txtTipoAlmacen.PopupHeight = 0
        Me.txtTipoAlmacen.PopupWidth = 0
        Me.txtTipoAlmacen.Size = New System.Drawing.Size(283, 27)
        Me.txtTipoAlmacen.SizeFont = 0
        Me.txtTipoAlmacen.TabIndex = 65
        Me.txtTipoAlmacen.ValueMember = ""
        '
        'lbltipoMercaderia
        '
        Me.lbltipoMercaderia.Location = New System.Drawing.Point(497, 35)
        Me.lbltipoMercaderia.Margin = New System.Windows.Forms.Padding(4)
        Me.lbltipoMercaderia.Name = "lbltipoMercaderia"
        Me.lbltipoMercaderia.Size = New System.Drawing.Size(130, 24)
        Me.lbltipoMercaderia.TabIndex = 13369
        Me.lbltipoMercaderia.Text = "Tipo Mercadería :"
        Me.lbltipoMercaderia.Values.ExtraText = ""
        Me.lbltipoMercaderia.Values.Image = Nothing
        Me.lbltipoMercaderia.Values.Text = "Tipo Mercadería :"
        '
        'TxtTipoMaterial
        '
        Me.TxtTipoMaterial.BackColor = System.Drawing.Color.Transparent
        Me.TxtTipoMaterial.DataSource = Nothing
        Me.TxtTipoMaterial.DispleyMember = ""
        Me.TxtTipoMaterial.Etiquetas_Form = Nothing
        Me.TxtTipoMaterial.ListColumnas = Nothing
        Me.TxtTipoMaterial.Location = New System.Drawing.Point(656, 32)
        Me.TxtTipoMaterial.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtTipoMaterial.Name = "TxtTipoMaterial"
        Me.TxtTipoMaterial.Obligatorio = True
        Me.TxtTipoMaterial.PopupHeight = 0
        Me.TxtTipoMaterial.PopupWidth = 0
        Me.TxtTipoMaterial.Size = New System.Drawing.Size(338, 27)
        Me.TxtTipoMaterial.SizeFont = 0
        Me.TxtTipoMaterial.TabIndex = 70
        Me.TxtTipoMaterial.ValueMember = ""
        '
        'lblCentCostoOrigen
        '
        Me.lblCentCostoOrigen.Location = New System.Drawing.Point(477, 254)
        Me.lblCentCostoOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCentCostoOrigen.Name = "lblCentCostoOrigen"
        Me.lblCentCostoOrigen.Size = New System.Drawing.Size(106, 24)
        Me.lblCentCostoOrigen.TabIndex = 31
        Me.lblCentCostoOrigen.Text = "CeCo Origen :"
        Me.lblCentCostoOrigen.Values.ExtraText = ""
        Me.lblCentCostoOrigen.Values.Image = Nothing
        Me.lblCentCostoOrigen.Values.Text = "CeCo Origen :"
        '
        'cmbCentCostoOrigen
        '
        Me.cmbCentCostoOrigen.BackColor = System.Drawing.Color.Transparent
        Me.cmbCentCostoOrigen.DataSource = Nothing
        Me.cmbCentCostoOrigen.DispleyMember = ""
        Me.cmbCentCostoOrigen.Etiquetas_Form = Nothing
        Me.cmbCentCostoOrigen.ListColumnas = Nothing
        Me.cmbCentCostoOrigen.Location = New System.Drawing.Point(598, 252)
        Me.cmbCentCostoOrigen.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbCentCostoOrigen.Name = "cmbCentCostoOrigen"
        Me.cmbCentCostoOrigen.Obligatorio = True
        Me.cmbCentCostoOrigen.PopupHeight = 0
        Me.cmbCentCostoOrigen.PopupWidth = 0
        Me.cmbCentCostoOrigen.Size = New System.Drawing.Size(266, 26)
        Me.cmbCentCostoOrigen.SizeFont = 0
        Me.cmbCentCostoOrigen.TabIndex = 120
        Me.cmbCentCostoOrigen.ValueMember = ""
        '
        'cboServicio
        '
        Me.cboServicio.BackColor = System.Drawing.Color.Transparent
        Me.cboServicio.DataSource = Nothing
        Me.cboServicio.DispleyMember = ""
        Me.cboServicio.Etiquetas_Form = Nothing
        Me.cboServicio.ListColumnas = Nothing
        Me.cboServicio.Location = New System.Drawing.Point(166, 44)
        Me.cboServicio.Margin = New System.Windows.Forms.Padding(5)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Obligatorio = True
        Me.cboServicio.PopupHeight = 0
        Me.cboServicio.PopupWidth = 0
        Me.cboServicio.Size = New System.Drawing.Size(748, 27)
        Me.cboServicio.SizeFont = 0
        Me.cboServicio.TabIndex = 20
        Me.cboServicio.ValueMember = ""
        '
        'lblCentCostoDestino
        '
        Me.lblCentCostoDestino.Location = New System.Drawing.Point(916, 254)
        Me.lblCentCostoDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCentCostoDestino.Name = "lblCentCostoDestino"
        Me.lblCentCostoDestino.Size = New System.Drawing.Size(112, 24)
        Me.lblCentCostoDestino.TabIndex = 33
        Me.lblCentCostoDestino.Text = "CeCo Destino :"
        Me.lblCentCostoDestino.Values.ExtraText = ""
        Me.lblCentCostoDestino.Values.Image = Nothing
        Me.lblCentCostoDestino.Values.Text = "CeCo Destino :"
        '
        'cboLogicaFacturacion
        '
        Me.cboLogicaFacturacion.BackColor = System.Drawing.Color.Transparent
        Me.cboLogicaFacturacion.DataSource = Nothing
        Me.cboLogicaFacturacion.DispleyMember = ""
        Me.cboLogicaFacturacion.Etiquetas_Form = Nothing
        Me.cboLogicaFacturacion.ListColumnas = Nothing
        Me.cboLogicaFacturacion.Location = New System.Drawing.Point(1051, 43)
        Me.cboLogicaFacturacion.Margin = New System.Windows.Forms.Padding(5)
        Me.cboLogicaFacturacion.Name = "cboLogicaFacturacion"
        Me.cboLogicaFacturacion.Obligatorio = True
        Me.cboLogicaFacturacion.PopupHeight = 0
        Me.cboLogicaFacturacion.PopupWidth = 0
        Me.cboLogicaFacturacion.Size = New System.Drawing.Size(367, 28)
        Me.cboLogicaFacturacion.SizeFont = 0
        Me.cboLogicaFacturacion.TabIndex = 25
        Me.cboLogicaFacturacion.ValueMember = ""
        Me.cboLogicaFacturacion.Visible = False
        '
        'cmbCentCostoDestino
        '
        Me.cmbCentCostoDestino.BackColor = System.Drawing.Color.Transparent
        Me.cmbCentCostoDestino.DataSource = Nothing
        Me.cmbCentCostoDestino.DispleyMember = ""
        Me.cmbCentCostoDestino.Etiquetas_Form = Nothing
        Me.cmbCentCostoDestino.ListColumnas = Nothing
        Me.cmbCentCostoDestino.Location = New System.Drawing.Point(1051, 252)
        Me.cmbCentCostoDestino.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbCentCostoDestino.Name = "cmbCentCostoDestino"
        Me.cmbCentCostoDestino.Obligatorio = True
        Me.cmbCentCostoDestino.PopupHeight = 0
        Me.cmbCentCostoDestino.PopupWidth = 0
        Me.cmbCentCostoDestino.Size = New System.Drawing.Size(372, 26)
        Me.cmbCentCostoDestino.SizeFont = 0
        Me.cmbCentCostoDestino.TabIndex = 125
        Me.cmbCentCostoDestino.ValueMember = ""
        '
        'cboTipoActivo
        '
        Me.cboTipoActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoActivo.FormattingEnabled = True
        Me.cboTipoActivo.Location = New System.Drawing.Point(996, 218)
        Me.cboTipoActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoActivo.Name = "cboTipoActivo"
        Me.cboTipoActivo.Size = New System.Drawing.Size(141, 24)
        Me.cboTipoActivo.TabIndex = 105
        '
        'KryptonLabel18
        '
        Me.KryptonLabel18.Location = New System.Drawing.Point(889, 218)
        Me.KryptonLabel18.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel18.Name = "KryptonLabel18"
        Me.KryptonLabel18.Size = New System.Drawing.Size(96, 24)
        Me.KryptonLabel18.TabIndex = 25
        Me.KryptonLabel18.Text = "Tipo Activo :"
        Me.KryptonLabel18.Values.ExtraText = ""
        Me.KryptonLabel18.Values.Image = Nothing
        Me.KryptonLabel18.Values.Text = "Tipo Activo :"
        '
        'txtUnidadProductiva
        '
        Me.txtUnidadProductiva.BackColor = System.Drawing.Color.Transparent
        Me.txtUnidadProductiva.DataSource = Nothing
        Me.txtUnidadProductiva.DispleyMember = ""
        Me.txtUnidadProductiva.Etiquetas_Form = Nothing
        Me.txtUnidadProductiva.ListColumnas = Nothing
        Me.txtUnidadProductiva.Location = New System.Drawing.Point(592, 215)
        Me.txtUnidadProductiva.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUnidadProductiva.Name = "txtUnidadProductiva"
        Me.txtUnidadProductiva.Obligatorio = True
        Me.txtUnidadProductiva.PopupHeight = 0
        Me.txtUnidadProductiva.PopupWidth = 0
        Me.txtUnidadProductiva.Size = New System.Drawing.Size(266, 27)
        Me.txtUnidadProductiva.SizeFont = 0
        Me.txtUnidadProductiva.TabIndex = 100
        Me.txtUnidadProductiva.ValueMember = ""
        '
        'KryptonLabel17
        '
        Me.KryptonLabel17.Location = New System.Drawing.Point(432, 218)
        Me.KryptonLabel17.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel17.Name = "KryptonLabel17"
        Me.KryptonLabel17.Size = New System.Drawing.Size(145, 24)
        Me.KryptonLabel17.TabIndex = 23
        Me.KryptonLabel17.Text = "Unidad Productiva :"
        Me.KryptonLabel17.Values.ExtraText = ""
        Me.KryptonLabel17.Values.Image = Nothing
        Me.KryptonLabel17.Values.Text = "Unidad Productiva :"
        '
        'txtTipoServicio
        '
        Me.txtTipoServicio.BackColor = System.Drawing.Color.Transparent
        Me.txtTipoServicio.DataSource = Nothing
        Me.txtTipoServicio.DispleyMember = ""
        Me.txtTipoServicio.Etiquetas_Form = Nothing
        Me.txtTipoServicio.ListColumnas = Nothing
        Me.txtTipoServicio.Location = New System.Drawing.Point(159, 215)
        Me.txtTipoServicio.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTipoServicio.Name = "txtTipoServicio"
        Me.txtTipoServicio.Obligatorio = True
        Me.txtTipoServicio.PopupHeight = 0
        Me.txtTipoServicio.PopupWidth = 0
        Me.txtTipoServicio.Size = New System.Drawing.Size(265, 27)
        Me.txtTipoServicio.SizeFont = 0
        Me.txtTipoServicio.TabIndex = 95
        Me.txtTipoServicio.ValueMember = ""
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(12, 218)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(127, 24)
        Me.KryptonLabel3.TabIndex = 21
        Me.KryptonLabel3.Text = "Tipo de Servicio :"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Tipo de Servicio :"
        '
        'lblLogicaFacturacion
        '
        Me.lblLogicaFacturacion.Location = New System.Drawing.Point(923, 47)
        Me.lblLogicaFacturacion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLogicaFacturacion.Name = "lblLogicaFacturacion"
        Me.lblLogicaFacturacion.Size = New System.Drawing.Size(131, 24)
        Me.lblLogicaFacturacion.TabIndex = 8
        Me.lblLogicaFacturacion.Text = "Lóg. Facturación :"
        Me.lblLogicaFacturacion.Values.ExtraText = ""
        Me.lblLogicaFacturacion.Values.Image = Nothing
        Me.lblLogicaFacturacion.Values.Text = "Lóg. Facturación :"
        Me.lblLogicaFacturacion.Visible = False
        '
        'cmbCentroBeneficio
        '
        Me.cmbCentroBeneficio.BackColor = System.Drawing.Color.Transparent
        Me.cmbCentroBeneficio.DataSource = Nothing
        Me.cmbCentroBeneficio.DispleyMember = ""
        Me.cmbCentroBeneficio.Etiquetas_Form = Nothing
        Me.cmbCentroBeneficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCentroBeneficio.ListColumnas = Nothing
        Me.cmbCentroBeneficio.Location = New System.Drawing.Point(1230, 215)
        Me.cmbCentroBeneficio.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbCentroBeneficio.Name = "cmbCentroBeneficio"
        Me.cmbCentroBeneficio.Obligatorio = True
        Me.cmbCentroBeneficio.PopupHeight = 0
        Me.cmbCentroBeneficio.PopupWidth = 0
        Me.cmbCentroBeneficio.Size = New System.Drawing.Size(193, 27)
        Me.cmbCentroBeneficio.SizeFont = 0
        Me.cmbCentroBeneficio.TabIndex = 110
        Me.cmbCentroBeneficio.ValueMember = ""
        '
        'cmbMoneda
        '
        Me.cmbMoneda.BackColor = System.Drawing.Color.Transparent
        Me.cmbMoneda.DataSource = Nothing
        Me.cmbMoneda.DispleyMember = ""
        Me.cmbMoneda.Etiquetas_Form = Nothing
        Me.cmbMoneda.ListColumnas = Nothing
        Me.cmbMoneda.Location = New System.Drawing.Point(1257, 175)
        Me.cmbMoneda.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Obligatorio = True
        Me.cmbMoneda.PopupHeight = 0
        Me.cmbMoneda.PopupWidth = 0
        Me.cmbMoneda.Size = New System.Drawing.Size(166, 27)
        Me.cmbMoneda.SizeFont = 0
        Me.cmbMoneda.TabIndex = 90
        Me.cmbMoneda.ValueMember = ""
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(53, 15)
        Me.KryptonLabel7.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(92, 24)
        Me.KryptonLabel7.TabIndex = 0
        Me.KryptonLabel7.Text = "Cod. Tarifa :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Cod. Tarifa :"
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.BackColor = System.Drawing.Color.Transparent
        Me.cmbUnidadMedida.DataSource = Nothing
        Me.cmbUnidadMedida.DispleyMember = ""
        Me.cmbUnidadMedida.Etiquetas_Form = Nothing
        Me.cmbUnidadMedida.ListColumnas = Nothing
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(592, 175)
        Me.cmbUnidadMedida.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Obligatorio = True
        Me.cmbUnidadMedida.PopupHeight = 0
        Me.cmbUnidadMedida.PopupWidth = 0
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(266, 27)
        Me.cmbUnidadMedida.SizeFont = 0
        Me.cmbUnidadMedida.TabIndex = 80
        Me.cmbUnidadMedida.ValueMember = ""
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(159, 180)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.MaxLength = 16
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(265, 22)
        Me.txtCantidad.TabIndex = 75
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(59, 178)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(80, 24)
        Me.lblCantidad.TabIndex = 13
        Me.lblCantidad.Text = "Cantidad :"
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad :"
        '
        'txtCodTarifa
        '
        Me.txtCodTarifa.Location = New System.Drawing.Point(166, 17)
        Me.txtCodTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodTarifa.MaxLength = 1024
        Me.txtCodTarifa.Name = "txtCodTarifa"
        Me.txtCodTarifa.ReadOnly = True
        Me.txtCodTarifa.Size = New System.Drawing.Size(125, 22)
        Me.txtCodTarifa.TabIndex = 5
        Me.txtCodTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(453, 178)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(124, 24)
        Me.KryptonLabel4.TabIndex = 15
        Me.KryptonLabel4.Text = "Unidad Medida :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Unidad Medida :"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(46, 287)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(99, 24)
        Me.lblDescripcion.TabIndex = 35
        Me.lblDescripcion.Text = "Descripción :"
        Me.lblDescripcion.Values.ExtraText = ""
        Me.lblDescripcion.Values.Image = Nothing
        Me.lblDescripcion.Values.Text = "Descripción :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtTarifa)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(165, 317)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1258, 84)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tarifa"
        '
        'txtTarifa
        '
        Me.txtTarifa.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTarifa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarifa.Location = New System.Drawing.Point(11, 18)
        Me.txtTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifa.Multiline = True
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.ReadOnly = True
        Me.txtTarifa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTarifa.Size = New System.Drawing.Size(1239, 57)
        Me.txtTarifa.TabIndex = 135
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(165, 287)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(1258, 22)
        Me.txtDescripcion.TabIndex = 130
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMonto.Location = New System.Drawing.Point(996, 180)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonto.MaxLength = 16
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(141, 22)
        Me.txtMonto.TabIndex = 85
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(514, 15)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(73, 24)
        Me.KryptonLabel5.TabIndex = 2
        Me.KryptonLabel5.Text = "División :"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "División :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(868, 178)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(117, 24)
        Me.KryptonLabel1.TabIndex = 17
        Me.KryptonLabel1.Text = "Importe Venta :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Importe Venta :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(1160, 178)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(76, 24)
        Me.KryptonLabel2.TabIndex = 19
        Me.KryptonLabel2.Text = "Moneda :"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Moneda :"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(1160, 218)
        Me.KryptonLabel6.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel6.TabIndex = 27
        Me.KryptonLabel6.Text = "Ce. Be :"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Ce. Be :"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(923, 15)
        Me.KryptonLabel9.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(61, 24)
        Me.KryptonLabel9.TabIndex = 4
        Me.KryptonLabel9.Text = "Planta :"
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Planta :"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(33, 101)
        Me.KryptonLabel10.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(112, 24)
        Me.KryptonLabel10.TabIndex = 10
        Me.KryptonLabel10.Text = "Tipo de Tarifa :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Tipo de Tarifa :"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(73, 47)
        Me.KryptonLabel11.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(72, 24)
        Me.KryptonLabel11.TabIndex = 6
        Me.KryptonLabel11.Text = "Servicio :"
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Servicio :"
        '
        'cboTipoTarifa
        '
        Me.cboTipoTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoTarifa.DropDownWidth = 285
        Me.cboTipoTarifa.FormattingEnabled = False
        Me.cboTipoTarifa.ItemHeight = 20
        Me.cboTipoTarifa.Location = New System.Drawing.Point(166, 101)
        Me.cboTipoTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoTarifa.MaxDropDownItems = 10
        Me.cboTipoTarifa.Name = "cboTipoTarifa"
        Me.cboTipoTarifa.Size = New System.Drawing.Size(209, 28)
        Me.cboTipoTarifa.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTipoTarifa.TabIndex = 30
        '
        'dtgRangoTarifa
        '
        Me.dtgRangoTarifa.AllowUserToAddRows = False
        Me.dtgRangoTarifa.AllowUserToDeleteRows = False
        Me.dtgRangoTarifa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodTarifa, Me.CodRango, Me.RangoInicial, Me.RangoFinal, Me.Tarifa})
        Me.dtgRangoTarifa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgRangoTarifa.Location = New System.Drawing.Point(0, 27)
        Me.dtgRangoTarifa.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgRangoTarifa.Name = "dtgRangoTarifa"
        Me.dtgRangoTarifa.RowTemplate.Height = 24
        Me.dtgRangoTarifa.Size = New System.Drawing.Size(1451, 218)
        Me.dtgRangoTarifa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dtgRangoTarifa.TabIndex = 1
        '
        'tsBarraRango
        '
        Me.tsBarraRango.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsBarraRango.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsBarraRango.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtIniRango, Me.ToolStripLabel2, Me.txtFinRango, Me.btnQuitaRango, Me.btnAgregaRango, Me.ToolStripLabel3, Me.txtMontoRango})
        Me.tsBarraRango.Location = New System.Drawing.Point(0, 0)
        Me.tsBarraRango.Name = "tsBarraRango"
        Me.tsBarraRango.Size = New System.Drawing.Size(1451, 27)
        Me.tsBarraRango.TabIndex = 0
        Me.tsBarraRango.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 24)
        Me.ToolStripLabel1.Text = "Desde"
        '
        'txtIniRango
        '
        Me.txtIniRango.MaxLength = 16
        Me.txtIniRango.Name = "txtIniRango"
        Me.txtIniRango.Size = New System.Drawing.Size(105, 27)
        Me.txtIniRango.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(47, 24)
        Me.ToolStripLabel2.Text = "Hasta"
        '
        'txtFinRango
        '
        Me.txtFinRango.MaxLength = 16
        Me.txtFinRango.Name = "txtFinRango"
        Me.txtFinRango.Size = New System.Drawing.Size(105, 27)
        Me.txtFinRango.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnQuitaRango
        '
        Me.btnQuitaRango.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnQuitaRango.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnQuitaRango.Image = Global.SOLMIN_CT.My.Resources.Resources.button_cancel
        Me.btnQuitaRango.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuitaRango.Name = "btnQuitaRango"
        Me.btnQuitaRango.Size = New System.Drawing.Size(24, 24)
        Me.btnQuitaRango.Text = "Quitar"
        '
        'btnAgregaRango
        '
        Me.btnAgregaRango.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAgregaRango.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAgregaRango.Image = Global.SOLMIN_CT.My.Resources.Resources.edit_add
        Me.btnAgregaRango.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregaRango.Name = "btnAgregaRango"
        Me.btnAgregaRango.Size = New System.Drawing.Size(24, 24)
        Me.btnAgregaRango.Text = "Agregar"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripLabel3.Text = "Monto"
        '
        'txtMontoRango
        '
        Me.txtMontoRango.MaxLength = 16
        Me.txtMontoRango.Name = "txtMontoRango"
        Me.txtMontoRango.Size = New System.Drawing.Size(105, 27)
        '
        'CodTarifa
        '
        Me.CodTarifa.DataPropertyName = "NRTFSV"
        Me.CodTarifa.HeaderText = "CodTarifa"
        Me.CodTarifa.Name = "CodTarifa"
        Me.CodTarifa.ReadOnly = True
        '
        'CodRango
        '
        Me.CodRango.DataPropertyName = "NRRNGO"
        Me.CodRango.HeaderText = "CodRango"
        Me.CodRango.Name = "CodRango"
        Me.CodRango.ReadOnly = True
        '
        'RangoInicial
        '
        Me.RangoInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RangoInicial.DataPropertyName = "VALMIN"
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = "0"
        Me.RangoInicial.DefaultCellStyle = DataGridViewCellStyle1
        Me.RangoInicial.HeaderText = "Rango Inicial"
        Me.RangoInicial.Name = "RangoInicial"
        Me.RangoInicial.ReadOnly = True
        Me.RangoInicial.Width = 120
        '
        'RangoFinal
        '
        Me.RangoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RangoFinal.DataPropertyName = "VALMAX"
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0"
        Me.RangoFinal.DefaultCellStyle = DataGridViewCellStyle2
        Me.RangoFinal.HeaderText = "Rango Final"
        Me.RangoFinal.Name = "RangoFinal"
        Me.RangoFinal.ReadOnly = True
        Me.RangoFinal.Width = 120
        '
        'Tarifa
        '
        Me.Tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tarifa.DataPropertyName = "IVLSRV"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Tarifa.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tarifa.HeaderText = "Tarifa"
        Me.Tarifa.Name = "Tarifa"
        '
        'frmGenTarifaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 703)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tsMenuOpciones)
        Me.Name = "frmGenTarifaAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tarifa Administración"
        Me.tsMenuOpciones.ResumeLayout(False)
        Me.tsMenuOpciones.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpTipoFijo.ResumeLayout(False)
        Me.tpTipoFijo.PerformLayout()
        Me.tpTipoPermanencia.ResumeLayout(False)
        Me.tpTipoPermanencia.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgRangoTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsBarraRango.ResumeLayout(False)
        Me.tsBarraRango.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tsMenuOpciones As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelarTarifa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSep_05 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGrabarTarifa As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSep_02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cboServicio As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboLogicaFacturacion As Ransa.Utilitario.ucAyuda
    Friend WithEvents cboTipoActivo As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel18 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtUnidadProductiva As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel17 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoServicio As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtDiasdeCorte As System.Windows.Forms.TextBox
    Friend WithEvents lblDiadeCorte As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lbltipoMercaderia As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTipoAlmacen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblTipoAlmacen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblLogicaFacturacion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCentroBeneficio As Ransa.Utilitario.ucAyuda
    Friend WithEvents cmbMoneda As Ransa.Utilitario.ucAyuda
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbUnidadMedida As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodTarifa As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblDescripcion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkPeriodoLibre As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTarifa As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPeriodoLibre As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPeriodo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboTipoTarifa As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents txtDiasFacturar As System.Windows.Forms.TextBox
    Friend WithEvents lblDiasFacturar As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtTipoMaterial As Ransa.Utilitario.ucAyuda
    Friend WithEvents txtCodTarifaRef As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblCodTarifaRef As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTarifaInterna As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtTarifaInterna As System.Windows.Forms.TextBox
    Friend WithEvents lblCentCostoDestino As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbCentCostoDestino As Ransa.Utilitario.ucAyuda
    Friend WithEvents cmbCentCostoOrigen As Ransa.Utilitario.ucAyuda
    Friend WithEvents lblCentCostoOrigen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtgRangoTarifa As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tsBarraRango As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtIniRango As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFinRango As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnQuitaRango As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAgregaRango As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtMontoRango As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpTipoFijo As System.Windows.Forms.TabPage
    Friend WithEvents tpTipoPermanencia As System.Windows.Forms.TabPage
    Friend WithEvents tpDatosAdic As System.Windows.Forms.TabPage
    Friend WithEvents cboDivision As System.Windows.Forms.ComboBox
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Friend WithEvents CodTarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodRango As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RangoInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RangoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tarifa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
