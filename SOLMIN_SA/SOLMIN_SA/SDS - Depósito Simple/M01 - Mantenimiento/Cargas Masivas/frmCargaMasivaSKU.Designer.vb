<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaMasivaSKU
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
        Me.components = New System.ComponentModel.Container()
        Dim BeCompania3 As RANSA.Controls.UbicacionPlanta.Compania.beCompania = New RANSA.Controls.UbicacionPlanta.Compania.beCompania()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.chkQ_OS = New System.Windows.Forms.CheckBox()
        Me.txtsku = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaArchivo = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListadoSKU = New System.Windows.Forms.TabPage()
        Me.dgMercaderias = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.CMRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TFMCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGRCLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MON_COSTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QIMCT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMVTA_SOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMVTA_DOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QLRGMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QANCMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QALTMR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QARMT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QARMT3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CINFMR_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRFMR_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPIMR_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EAN13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNCTL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCNTSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Q_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNDS2_DESPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpCargaSKU = New System.Windows.Forms.TabPage()
        Me.dgcargasku = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.tpCargaOS = New System.Windows.Forms.TabPage()
        Me.dgcargasos = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.RESULT_CARGA_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNID_MED_CANTIDAD_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNID_MED_PESO_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNID_MED_VALOR_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDAD_DESPACHO_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_CARGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REGISTRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBS_REGISTRO_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMRCLR_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD2_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD3_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCTR_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_FAMILIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMRCD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONEDA_COSTO_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTO_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QLRGMR_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QANCMR_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QALTMR_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QARMT2_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QARMT3_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CINFMR_COD_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPRFMR_COD_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPIMR_COD_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EAN13_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCRE_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNCTL_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCNTSR_CM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GENERAR_OS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OS_UM_CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OS_UM_PESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OS_UM_VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OS_UM_DESPACHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpListadoSKU.SuspendLayout()
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCargaSKU.SuspendLayout()
        CType(Me.dgcargasku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCargaOS.SuspendLayout()
        CType(Me.dgcargasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.UcCompania_Cmb011)
        Me.Panel1.Controls.Add(Me.chkQ_OS)
        Me.Panel1.Controls.Add(Me.txtsku)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1369, 91)
        Me.Panel1.TabIndex = 2
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(17, 11)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(88, 24)
        Me.KryptonLabel4.TabIndex = 117
        Me.KryptonLabel4.Text = "Compañía : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Compañía : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_CompaniaDefault = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Habilitar = True
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(114, 7)
        Me.UcCompania_Cmb011.Margin = New System.Windows.Forms.Padding(5)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(200, 28)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        BeCompania3.CCMPN_CodigoCompania = ""
        BeCompania3.Orden = -1
        BeCompania3.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania3
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(347, 28)
        Me.UcCompania_Cmb011.TabIndex = 118
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'chkQ_OS
        '
        Me.chkQ_OS.AutoSize = True
        Me.chkQ_OS.Location = New System.Drawing.Point(859, 49)
        Me.chkQ_OS.Name = "chkQ_OS"
        Me.chkQ_OS.Size = New System.Drawing.Size(145, 21)
        Me.chkQ_OS.TabIndex = 116
        Me.chkQ_OS.Text = "Con más de 1 O/S"
        Me.chkQ_OS.UseVisualStyleBackColor = True
        '
        'txtsku
        '
        Me.txtsku.Location = New System.Drawing.Point(566, 45)
        Me.txtsku.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsku.MaxLength = 30
        Me.txtsku.Name = "txtsku"
        Me.txtsku.Size = New System.Drawing.Size(276, 26)
        Me.txtsku.TabIndex = 113
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(499, 47)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(43, 24)
        Me.KryptonLabel2.TabIndex = 112
        Me.KryptonLabel2.Text = "SKU:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "SKU:"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.CCMPN = "EZ"
        Me.txtCliente.Location = New System.Drawing.Point(114, 45)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pCDDRSP_CodClienteSAP = ""
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.pVisualizaNegocio = False
        Me.txtCliente.Size = New System.Drawing.Size(347, 26)
        Me.txtCliente.TabIndex = 109
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(17, 47)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 24)
        Me.KryptonLabel1.TabIndex = 108
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.btnexportar, Me.btnGuardar, Me.btnCargaArchivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 91)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1369, 27)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SA.My.Resources.Resources.search1
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.btnBuscar.Text = "Buscar"
        '
        'btnexportar
        '
        Me.btnexportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnexportar.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(89, 24)
        Me.btnexportar.Text = "Exportar"
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
        'btnCargaArchivo
        '
        Me.btnCargaArchivo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCargaArchivo.Image = Global.SOLMIN_SA.My.Resources.Resources.GenerarReporte
        Me.btnCargaArchivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaArchivo.Name = "btnCargaArchivo"
        Me.btnCargaArchivo.Size = New System.Drawing.Size(158, 24)
        Me.btnCargaArchivo.Text = "Abrir Archivo Excel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpListadoSKU)
        Me.TabControl1.Controls.Add(Me.tpCargaSKU)
        Me.TabControl1.Controls.Add(Me.tpCargaOS)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1369, 443)
        Me.TabControl1.TabIndex = 4
        '
        'tpListadoSKU
        '
        Me.tpListadoSKU.Controls.Add(Me.dgMercaderias)
        Me.tpListadoSKU.Location = New System.Drawing.Point(4, 25)
        Me.tpListadoSKU.Name = "tpListadoSKU"
        Me.tpListadoSKU.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListadoSKU.Size = New System.Drawing.Size(1361, 414)
        Me.tpListadoSKU.TabIndex = 0
        Me.tpListadoSKU.Text = "Listado SKU/OS"
        Me.tpListadoSKU.UseVisualStyleBackColor = True
        '
        'dgMercaderias
        '
        Me.dgMercaderias.AllowUserToAddRows = False
        Me.dgMercaderias.AllowUserToDeleteRows = False
        Me.dgMercaderias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMercaderias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgMercaderias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMercaderias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CMRCLR, Me.TMRCD2, Me.TMRCD3, Me.TMRCTR, Me.TFMCLR, Me.TGRCLR, Me.MON_COSTO, Me.QIMCT, Me.IMVTA_SOL, Me.IMVTA_DOL, Me.QLRGMR, Me.QANCMR, Me.QALTMR, Me.QARMT2, Me.QARMT3, Me.CINFMR_DESC, Me.CPRFMR_DESC, Me.CAPIMR_DESC, Me.EAN13, Me.MARCRE, Me.FUNCTL, Me.SCNTSR, Me.Q_OS, Me.NCNTR, Me.NORDSR, Me.CUNCN5, Me.CUNPS5, Me.CUNVL5, Me.FUNDS2_DESPACHO, Me.Column1})
        Me.dgMercaderias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMercaderias.Location = New System.Drawing.Point(3, 3)
        Me.dgMercaderias.Margin = New System.Windows.Forms.Padding(4)
        Me.dgMercaderias.Name = "dgMercaderias"
        Me.dgMercaderias.Size = New System.Drawing.Size(1355, 408)
        Me.dgMercaderias.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgMercaderias.TabIndex = 4
        '
        'CMRCLR
        '
        Me.CMRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMRCLR.DataPropertyName = "CMRCLR"
        Me.CMRCLR.HeaderText = "SKU"
        Me.CMRCLR.Name = "CMRCLR"
        Me.CMRCLR.ReadOnly = True
        Me.CMRCLR.Width = 69
        '
        'TMRCD2
        '
        Me.TMRCD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2.DataPropertyName = "TMRCD2"
        Me.TMRCD2.HeaderText = "Descripción SKU"
        Me.TMRCD2.Name = "TMRCD2"
        Me.TMRCD2.ReadOnly = True
        Me.TMRCD2.Width = 139
        '
        'TMRCD3
        '
        Me.TMRCD3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD3.DataPropertyName = "TMRCD3"
        Me.TMRCD3.HeaderText = "Descripción 2"
        Me.TMRCD3.Name = "TMRCD3"
        Me.TMRCD3.ReadOnly = True
        Me.TMRCD3.Width = 122
        '
        'TMRCTR
        '
        Me.TMRCTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCTR.DataPropertyName = "TMRCTR"
        Me.TMRCTR.HeaderText = "Marca/Modelo"
        Me.TMRCTR.Name = "TMRCTR"
        Me.TMRCTR.ReadOnly = True
        Me.TMRCTR.Width = 141
        '
        'TFMCLR
        '
        Me.TFMCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TFMCLR.DataPropertyName = "TFMCLR"
        Me.TFMCLR.HeaderText = "Familia"
        Me.TFMCLR.Name = "TFMCLR"
        Me.TFMCLR.ReadOnly = True
        Me.TFMCLR.Width = 89
        '
        'TGRCLR
        '
        Me.TGRCLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TGRCLR.DataPropertyName = "TGRCLR"
        Me.TGRCLR.HeaderText = "Grupo"
        Me.TGRCLR.Name = "TGRCLR"
        Me.TGRCLR.ReadOnly = True
        Me.TGRCLR.Width = 83
        '
        'MON_COSTO
        '
        Me.MON_COSTO.DataPropertyName = "MON_COSTO"
        Me.MON_COSTO.HeaderText = "Moneda Costo"
        Me.MON_COSTO.Name = "MON_COSTO"
        Me.MON_COSTO.ReadOnly = True
        Me.MON_COSTO.Width = 128
        '
        'QIMCT
        '
        Me.QIMCT.DataPropertyName = "QIMCT"
        Me.QIMCT.HeaderText = "Costo"
        Me.QIMCT.Name = "QIMCT"
        Me.QIMCT.ReadOnly = True
        Me.QIMCT.Width = 80
        '
        'IMVTA_SOL
        '
        Me.IMVTA_SOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMVTA_SOL.DataPropertyName = "IMVTA_SOL"
        Me.IMVTA_SOL.HeaderText = "Precio Venta(S/.)"
        Me.IMVTA_SOL.Name = "IMVTA_SOL"
        Me.IMVTA_SOL.ReadOnly = True
        Me.IMVTA_SOL.Width = 139
        '
        'IMVTA_DOL
        '
        Me.IMVTA_DOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IMVTA_DOL.DataPropertyName = "IMVTA_DOL"
        Me.IMVTA_DOL.HeaderText = "Precio Venta $"
        Me.IMVTA_DOL.Name = "IMVTA_DOL"
        Me.IMVTA_DOL.ReadOnly = True
        Me.IMVTA_DOL.Width = 114
        '
        'QLRGMR
        '
        Me.QLRGMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QLRGMR.DataPropertyName = "QLRGMR"
        Me.QLRGMR.HeaderText = "Largo"
        Me.QLRGMR.Name = "QLRGMR"
        Me.QLRGMR.ReadOnly = True
        Me.QLRGMR.Width = 80
        '
        'QANCMR
        '
        Me.QANCMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QANCMR.DataPropertyName = "QANCMR"
        Me.QANCMR.HeaderText = "Ancho"
        Me.QANCMR.Name = "QANCMR"
        Me.QANCMR.ReadOnly = True
        Me.QANCMR.Width = 84
        '
        'QALTMR
        '
        Me.QALTMR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QALTMR.DataPropertyName = "QALTMR"
        Me.QALTMR.HeaderText = "Alto"
        Me.QALTMR.Name = "QALTMR"
        Me.QALTMR.ReadOnly = True
        Me.QALTMR.Width = 70
        '
        'QARMT2
        '
        Me.QARMT2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QARMT2.DataPropertyName = "QARMT2"
        Me.QARMT2.HeaderText = "Área"
        Me.QARMT2.Name = "QARMT2"
        Me.QARMT2.ReadOnly = True
        Me.QARMT2.Width = 73
        '
        'QARMT3
        '
        Me.QARMT3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QARMT3.DataPropertyName = "QARMT3"
        Me.QARMT3.HeaderText = "M3"
        Me.QARMT3.Name = "QARMT3"
        Me.QARMT3.ReadOnly = True
        Me.QARMT3.Width = 63
        '
        'CINFMR_DESC
        '
        Me.CINFMR_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CINFMR_DESC.DataPropertyName = "DESC_INFLAMABILIDAD"
        Me.CINFMR_DESC.HeaderText = "Inflamabilidad"
        Me.CINFMR_DESC.Name = "CINFMR_DESC"
        Me.CINFMR_DESC.ReadOnly = True
        Me.CINFMR_DESC.Width = 139
        '
        'CPRFMR_DESC
        '
        Me.CPRFMR_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPRFMR_DESC.DataPropertyName = "DESC_PERFUMANCIA"
        Me.CPRFMR_DESC.HeaderText = "Perfumancia"
        Me.CPRFMR_DESC.Name = "CPRFMR_DESC"
        Me.CPRFMR_DESC.ReadOnly = True
        Me.CPRFMR_DESC.Width = 123
        '
        'CAPIMR_DESC
        '
        Me.CAPIMR_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CAPIMR_DESC.DataPropertyName = "DESC_APILABILIDAD"
        Me.CAPIMR_DESC.HeaderText = "Apilabilidad"
        Me.CAPIMR_DESC.Name = "CAPIMR_DESC"
        Me.CAPIMR_DESC.ReadOnly = True
        Me.CAPIMR_DESC.Width = 124
        '
        'EAN13
        '
        Me.EAN13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EAN13.DataPropertyName = "EAN13"
        Me.EAN13.HeaderText = "EAN13"
        Me.EAN13.Name = "EAN13"
        Me.EAN13.ReadOnly = True
        Me.EAN13.Width = 87
        '
        'MARCRE
        '
        Me.MARCRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MARCRE.DataPropertyName = "MARCRE"
        Me.MARCRE.HeaderText = "Ctrl Ubicación"
        Me.MARCRE.Name = "MARCRE"
        Me.MARCRE.ReadOnly = True
        Me.MARCRE.Width = 124
        '
        'FUNCTL
        '
        Me.FUNCTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FUNCTL.DataPropertyName = "FUNCTL"
        Me.FUNCTL.HeaderText = "Ctrl. Lote"
        Me.FUNCTL.Name = "FUNCTL"
        Me.FUNCTL.ReadOnly = True
        Me.FUNCTL.Width = 94
        '
        'SCNTSR
        '
        Me.SCNTSR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCNTSR.DataPropertyName = "SCNTSR"
        Me.SCNTSR.HeaderText = "Ctrl. Serie"
        Me.SCNTSR.Name = "SCNTSR"
        Me.SCNTSR.ReadOnly = True
        Me.SCNTSR.Width = 97
        '
        'Q_OS
        '
        Me.Q_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Q_OS.DataPropertyName = "CANT_OS"
        Me.Q_OS.HeaderText = "Cant. O/S x SKU"
        Me.Q_OS.Name = "Q_OS"
        Me.Q_OS.ReadOnly = True
        Me.Q_OS.Width = 110
        '
        'NCNTR
        '
        Me.NCNTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NCNTR.DataPropertyName = "NCNTR"
        Me.NCNTR.HeaderText = "Número Contrato"
        Me.NCNTR.Name = "NCNTR"
        Me.NCNTR.ReadOnly = True
        Me.NCNTR.Width = 145
        '
        'NORDSR
        '
        Me.NORDSR.DataPropertyName = "NORDSR"
        Me.NORDSR.HeaderText = "Orden Servicio"
        Me.NORDSR.Name = "NORDSR"
        Me.NORDSR.ReadOnly = True
        Me.NORDSR.Width = 128
        '
        'CUNCN5
        '
        Me.CUNCN5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNCN5.DataPropertyName = "CUNCN5"
        Me.CUNCN5.HeaderText = "Unidad Cant.(O/S)"
        Me.CUNCN5.Name = "CUNCN5"
        Me.CUNCN5.ReadOnly = True
        Me.CUNCN5.Width = 149
        '
        'CUNPS5
        '
        Me.CUNPS5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNPS5.DataPropertyName = "CUNPS5"
        Me.CUNPS5.HeaderText = "Unidad Peso(O/S)"
        Me.CUNPS5.Name = "CUNPS5"
        Me.CUNPS5.ReadOnly = True
        Me.CUNPS5.Width = 146
        '
        'CUNVL5
        '
        Me.CUNVL5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CUNVL5.DataPropertyName = "CUNVL5"
        Me.CUNVL5.HeaderText = "Unidad Valor(O/S)"
        Me.CUNVL5.Name = "CUNVL5"
        Me.CUNVL5.ReadOnly = True
        Me.CUNVL5.Width = 149
        '
        'FUNDS2_DESPACHO
        '
        Me.FUNDS2_DESPACHO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FUNDS2_DESPACHO.DataPropertyName = "FUNDS2"
        Me.FUNDS2_DESPACHO.HeaderText = "Unidad  Despacho"
        Me.FUNDS2_DESPACHO.Name = "FUNDS2_DESPACHO"
        Me.FUNDS2_DESPACHO.ReadOnly = True
        Me.FUNDS2_DESPACHO.Width = 150
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'tpCargaSKU
        '
        Me.tpCargaSKU.Controls.Add(Me.dgcargasku)
        Me.tpCargaSKU.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaSKU.Name = "tpCargaSKU"
        Me.tpCargaSKU.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCargaSKU.Size = New System.Drawing.Size(1361, 414)
        Me.tpCargaSKU.TabIndex = 1
        Me.tpCargaSKU.Text = "Carga SKU"
        Me.tpCargaSKU.UseVisualStyleBackColor = True
        '
        'dgcargasku
        '
        Me.dgcargasku.AllowUserToAddRows = False
        Me.dgcargasku.AllowUserToDeleteRows = False
        Me.dgcargasku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgcargasku.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgcargasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcargasku.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA, Me.RESULT_REGISTRO, Me.OBS_REGISTRO_OS, Me.CMRCLR_CM, Me.TMRCD2_CM, Me.TMRCD3_CM, Me.TMRCTR_CM, Me.COD_FAMILIA, Me.COD_GRUPO, Me.CMRCD, Me.MONEDA_COSTO_CM, Me.COSTO_CM, Me.QLRGMR_CM, Me.QANCMR_CM, Me.QALTMR_CM, Me.QARMT2_CM, Me.QARMT3_CM, Me.CINFMR_COD_CM, Me.CPRFMR_COD_CM, Me.CAPIMR_COD_CM, Me.EAN13_CM, Me.MARCRE_CM, Me.FUNCTL_CM, Me.SCNTSR_CM, Me.GENERAR_OS, Me.OS_UM_CANTIDAD, Me.OS_UM_PESO, Me.OS_UM_VALOR, Me.OS_UM_DESPACHO, Me.DataGridViewTextBoxColumn27})
        Me.dgcargasku.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgcargasku.Location = New System.Drawing.Point(3, 3)
        Me.dgcargasku.Margin = New System.Windows.Forms.Padding(4)
        Me.dgcargasku.Name = "dgcargasku"
        Me.dgcargasku.Size = New System.Drawing.Size(1355, 408)
        Me.dgcargasku.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgcargasku.TabIndex = 5
        '
        'tpCargaOS
        '
        Me.tpCargaOS.Controls.Add(Me.dgcargasos)
        Me.tpCargaOS.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaOS.Name = "tpCargaOS"
        Me.tpCargaOS.Size = New System.Drawing.Size(1361, 414)
        Me.tpCargaOS.TabIndex = 2
        Me.tpCargaOS.Text = "Carga O/S"
        Me.tpCargaOS.UseVisualStyleBackColor = True
        '
        'dgcargasos
        '
        Me.dgcargasos.AllowUserToAddRows = False
        Me.dgcargasos.AllowUserToDeleteRows = False
        Me.dgcargasos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgcargasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcargasos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_OS, Me.RESULT_REG_OS, Me.SKU, Me.UNID_MED_CANTIDAD_OS, Me.UNID_MED_PESO_OS, Me.UNID_MED_VALOR_OS, Me.UNIDAD_DESPACHO_OS, Me.DataGridViewTextBoxColumn28})
        Me.dgcargasos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgcargasos.Location = New System.Drawing.Point(0, 0)
        Me.dgcargasos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgcargasos.Name = "dgcargasos"
        Me.dgcargasos.Size = New System.Drawing.Size(1361, 414)
        Me.dgcargasos.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgcargasos.TabIndex = 5
        '
        'RESULT_CARGA_OS
        '
        Me.RESULT_CARGA_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_CARGA_OS.DataPropertyName = "OBS_CARGA"
        Me.RESULT_CARGA_OS.HeaderText = "Carga"
        Me.RESULT_CARGA_OS.Name = "RESULT_CARGA_OS"
        Me.RESULT_CARGA_OS.ReadOnly = True
        Me.RESULT_CARGA_OS.Width = 81
        '
        'RESULT_REG_OS
        '
        Me.RESULT_REG_OS.DataPropertyName = "OBS_REGISTRO"
        Me.RESULT_REG_OS.HeaderText = "Registro"
        Me.RESULT_REG_OS.Name = "RESULT_REG_OS"
        Me.RESULT_REG_OS.ReadOnly = True
        Me.RESULT_REG_OS.Width = 149
        '
        'SKU
        '
        Me.SKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKU.DataPropertyName = "SKU"
        Me.SKU.HeaderText = "SKU"
        Me.SKU.Name = "SKU"
        Me.SKU.ReadOnly = True
        Me.SKU.Width = 69
        '
        'UNID_MED_CANTIDAD_OS
        '
        Me.UNID_MED_CANTIDAD_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UNID_MED_CANTIDAD_OS.DataPropertyName = "UNID_MED_CANTIDAD_OS"
        Me.UNID_MED_CANTIDAD_OS.HeaderText = "U. Med. Cant O/S"
        Me.UNID_MED_CANTIDAD_OS.Name = "UNID_MED_CANTIDAD_OS"
        Me.UNID_MED_CANTIDAD_OS.ReadOnly = True
        Me.UNID_MED_CANTIDAD_OS.Width = 120
        '
        'UNID_MED_PESO_OS
        '
        Me.UNID_MED_PESO_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UNID_MED_PESO_OS.DataPropertyName = "UNID_MED_PESO_OS"
        Me.UNID_MED_PESO_OS.HeaderText = "U. Med. Peso O/S"
        Me.UNID_MED_PESO_OS.Name = "UNID_MED_PESO_OS"
        Me.UNID_MED_PESO_OS.ReadOnly = True
        Me.UNID_MED_PESO_OS.Width = 120
        '
        'UNID_MED_VALOR_OS
        '
        Me.UNID_MED_VALOR_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UNID_MED_VALOR_OS.DataPropertyName = "UNID_MED_VALOR_OS"
        Me.UNID_MED_VALOR_OS.HeaderText = "U. Med. Valor O/S"
        Me.UNID_MED_VALOR_OS.Name = "UNID_MED_VALOR_OS"
        Me.UNID_MED_VALOR_OS.ReadOnly = True
        Me.UNID_MED_VALOR_OS.Width = 123
        '
        'UNIDAD_DESPACHO_OS
        '
        Me.UNIDAD_DESPACHO_OS.DataPropertyName = "UNIDAD_DESPACHO_OS"
        Me.UNIDAD_DESPACHO_OS.HeaderText = "Cntrol Despacho"
        Me.UNIDAD_DESPACHO_OS.Name = "UNIDAD_DESPACHO_OS"
        Me.UNIDAD_DESPACHO_OS.ReadOnly = True
        Me.UNIDAD_DESPACHO_OS.Width = 140
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn28.HeaderText = ""
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'RESULT_CARGA
        '
        Me.RESULT_CARGA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RESULT_CARGA.DataPropertyName = "OBS_CARGA"
        Me.RESULT_CARGA.HeaderText = "Carga"
        Me.RESULT_CARGA.Name = "RESULT_CARGA"
        Me.RESULT_CARGA.ReadOnly = True
        Me.RESULT_CARGA.Width = 139
        '
        'RESULT_REGISTRO
        '
        Me.RESULT_REGISTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.RESULT_REGISTRO.DataPropertyName = "OBS_REGISTRO"
        Me.RESULT_REGISTRO.HeaderText = "Registro"
        Me.RESULT_REGISTRO.Name = "RESULT_REGISTRO"
        Me.RESULT_REGISTRO.ReadOnly = True
        Me.RESULT_REGISTRO.Width = 153
        '
        'OBS_REGISTRO_OS
        '
        Me.OBS_REGISTRO_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OBS_REGISTRO_OS.DataPropertyName = "OBS_REGISTRO_OS"
        Me.OBS_REGISTRO_OS.HeaderText = "Registro OS"
        Me.OBS_REGISTRO_OS.Name = "OBS_REGISTRO_OS"
        Me.OBS_REGISTRO_OS.ReadOnly = True
        Me.OBS_REGISTRO_OS.Width = 120
        '
        'CMRCLR_CM
        '
        Me.CMRCLR_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMRCLR_CM.DataPropertyName = "SKU"
        Me.CMRCLR_CM.HeaderText = "SKU"
        Me.CMRCLR_CM.Name = "CMRCLR_CM"
        Me.CMRCLR_CM.ReadOnly = True
        Me.CMRCLR_CM.Width = 69
        '
        'TMRCD2_CM
        '
        Me.TMRCD2_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2_CM.DataPropertyName = "DESCRIPCION_SKU"
        Me.TMRCD2_CM.HeaderText = "Descripción SKU"
        Me.TMRCD2_CM.Name = "TMRCD2_CM"
        Me.TMRCD2_CM.ReadOnly = True
        Me.TMRCD2_CM.Width = 151
        '
        'TMRCD3_CM
        '
        Me.TMRCD3_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD3_CM.DataPropertyName = "DESCRIPCION_SKU_ADIC"
        Me.TMRCD3_CM.HeaderText = "Descripción 2"
        Me.TMRCD3_CM.Name = "TMRCD3_CM"
        Me.TMRCD3_CM.ReadOnly = True
        Me.TMRCD3_CM.Width = 132
        '
        'TMRCTR_CM
        '
        Me.TMRCTR_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCTR_CM.DataPropertyName = "MARCA_MODELO"
        Me.TMRCTR_CM.HeaderText = "Marca/Modelo"
        Me.TMRCTR_CM.Name = "TMRCTR_CM"
        Me.TMRCTR_CM.ReadOnly = True
        Me.TMRCTR_CM.Width = 141
        '
        'COD_FAMILIA
        '
        Me.COD_FAMILIA.DataPropertyName = "COD_FAMILIA"
        Me.COD_FAMILIA.HeaderText = "Cod. Familia"
        Me.COD_FAMILIA.Name = "COD_FAMILIA"
        Me.COD_FAMILIA.ReadOnly = True
        Me.COD_FAMILIA.Width = 123
        '
        'COD_GRUPO
        '
        Me.COD_GRUPO.DataPropertyName = "COD_GRUPO"
        Me.COD_GRUPO.HeaderText = "Cod Grupo"
        Me.COD_GRUPO.Name = "COD_GRUPO"
        Me.COD_GRUPO.ReadOnly = True
        Me.COD_GRUPO.Width = 114
        '
        'CMRCD
        '
        Me.CMRCD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CMRCD.DataPropertyName = "COD_MERCADERIA_RANSA"
        Me.CMRCD.HeaderText = "Cod. Mercad. Ransa"
        Me.CMRCD.Name = "CMRCD"
        Me.CMRCD.ReadOnly = True
        Me.CMRCD.Width = 158
        '
        'MONEDA_COSTO_CM
        '
        Me.MONEDA_COSTO_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MONEDA_COSTO_CM.DataPropertyName = "MONEDA_COSTO"
        Me.MONEDA_COSTO_CM.HeaderText = "Moneda Costo"
        Me.MONEDA_COSTO_CM.Name = "MONEDA_COSTO_CM"
        Me.MONEDA_COSTO_CM.ReadOnly = True
        Me.MONEDA_COSTO_CM.Width = 128
        '
        'COSTO_CM
        '
        Me.COSTO_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.COSTO_CM.DataPropertyName = "COSTO"
        Me.COSTO_CM.HeaderText = "Costo SKU"
        Me.COSTO_CM.Name = "COSTO_CM"
        Me.COSTO_CM.ReadOnly = True
        Me.COSTO_CM.Width = 103
        '
        'QLRGMR_CM
        '
        Me.QLRGMR_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QLRGMR_CM.DataPropertyName = "LARGO"
        Me.QLRGMR_CM.HeaderText = "Largo"
        Me.QLRGMR_CM.Name = "QLRGMR_CM"
        Me.QLRGMR_CM.ReadOnly = True
        Me.QLRGMR_CM.Width = 80
        '
        'QANCMR_CM
        '
        Me.QANCMR_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QANCMR_CM.DataPropertyName = "ANCHO"
        Me.QANCMR_CM.HeaderText = "Ancho"
        Me.QANCMR_CM.Name = "QANCMR_CM"
        Me.QANCMR_CM.ReadOnly = True
        Me.QANCMR_CM.Width = 84
        '
        'QALTMR_CM
        '
        Me.QALTMR_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QALTMR_CM.DataPropertyName = "ALTO"
        Me.QALTMR_CM.HeaderText = "Alto"
        Me.QALTMR_CM.Name = "QALTMR_CM"
        Me.QALTMR_CM.ReadOnly = True
        Me.QALTMR_CM.Width = 70
        '
        'QARMT2_CM
        '
        Me.QARMT2_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QARMT2_CM.DataPropertyName = "AREA"
        Me.QARMT2_CM.HeaderText = "Área"
        Me.QARMT2_CM.Name = "QARMT2_CM"
        Me.QARMT2_CM.ReadOnly = True
        Me.QARMT2_CM.Width = 73
        '
        'QARMT3_CM
        '
        Me.QARMT3_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QARMT3_CM.DataPropertyName = "M3"
        Me.QARMT3_CM.HeaderText = "M3"
        Me.QARMT3_CM.Name = "QARMT3_CM"
        Me.QARMT3_CM.ReadOnly = True
        Me.QARMT3_CM.Width = 63
        '
        'CINFMR_COD_CM
        '
        Me.CINFMR_COD_CM.DataPropertyName = "COD_INFLAMABILIDAD"
        Me.CINFMR_COD_CM.HeaderText = "Código Inflamabilidad"
        Me.CINFMR_COD_CM.Name = "CINFMR_COD_CM"
        Me.CINFMR_COD_CM.ReadOnly = True
        Me.CINFMR_COD_CM.Width = 176
        '
        'CPRFMR_COD_CM
        '
        Me.CPRFMR_COD_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CPRFMR_COD_CM.DataPropertyName = "COD_PERFUMANCIA"
        Me.CPRFMR_COD_CM.HeaderText = "Código Perfumancia"
        Me.CPRFMR_COD_CM.Name = "CPRFMR_COD_CM"
        Me.CPRFMR_COD_CM.ReadOnly = True
        Me.CPRFMR_COD_CM.Width = 161
        '
        'CAPIMR_COD_CM
        '
        Me.CAPIMR_COD_CM.DataPropertyName = "COD_APILABILIDAD"
        Me.CAPIMR_COD_CM.HeaderText = "Código Apilabilidad"
        Me.CAPIMR_COD_CM.Name = "CAPIMR_COD_CM"
        Me.CAPIMR_COD_CM.ReadOnly = True
        Me.CAPIMR_COD_CM.Width = 162
        '
        'EAN13_CM
        '
        Me.EAN13_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EAN13_CM.DataPropertyName = "EAN13"
        Me.EAN13_CM.HeaderText = "EAN13"
        Me.EAN13_CM.Name = "EAN13_CM"
        Me.EAN13_CM.ReadOnly = True
        Me.EAN13_CM.Width = 87
        '
        'MARCRE_CM
        '
        Me.MARCRE_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MARCRE_CM.DataPropertyName = "CONTROL_UBICACION"
        Me.MARCRE_CM.HeaderText = "Ctrl Ubicación"
        Me.MARCRE_CM.Name = "MARCRE_CM"
        Me.MARCRE_CM.ReadOnly = True
        Me.MARCRE_CM.Width = 124
        '
        'FUNCTL_CM
        '
        Me.FUNCTL_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FUNCTL_CM.DataPropertyName = "CONTROL_LOTE"
        Me.FUNCTL_CM.HeaderText = "Ctrl. Lote"
        Me.FUNCTL_CM.Name = "FUNCTL_CM"
        Me.FUNCTL_CM.ReadOnly = True
        Me.FUNCTL_CM.Width = 94
        '
        'SCNTSR_CM
        '
        Me.SCNTSR_CM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SCNTSR_CM.DataPropertyName = "CONTROL_SERIE"
        Me.SCNTSR_CM.HeaderText = "Ctrl. Serie"
        Me.SCNTSR_CM.Name = "SCNTSR_CM"
        Me.SCNTSR_CM.ReadOnly = True
        Me.SCNTSR_CM.Width = 97
        '
        'GENERAR_OS
        '
        Me.GENERAR_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GENERAR_OS.DataPropertyName = "GENERAR_OS"
        Me.GENERAR_OS.HeaderText = "Generar OS"
        Me.GENERAR_OS.Name = "GENERAR_OS"
        Me.GENERAR_OS.ReadOnly = True
        Me.GENERAR_OS.Width = 108
        '
        'OS_UM_CANTIDAD
        '
        Me.OS_UM_CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OS_UM_CANTIDAD.DataPropertyName = "OS_UM_CANTIDAD"
        Me.OS_UM_CANTIDAD.HeaderText = "OS um Cantidad"
        Me.OS_UM_CANTIDAD.Name = "OS_UM_CANTIDAD"
        Me.OS_UM_CANTIDAD.ReadOnly = True
        Me.OS_UM_CANTIDAD.Width = 138
        '
        'OS_UM_PESO
        '
        Me.OS_UM_PESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OS_UM_PESO.DataPropertyName = "OS_UM_PESO"
        Me.OS_UM_PESO.HeaderText = "OS  um Peso"
        Me.OS_UM_PESO.Name = "OS_UM_PESO"
        Me.OS_UM_PESO.ReadOnly = True
        Me.OS_UM_PESO.Width = 114
        '
        'OS_UM_VALOR
        '
        Me.OS_UM_VALOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OS_UM_VALOR.DataPropertyName = "OS_UM_VALOR"
        Me.OS_UM_VALOR.HeaderText = "OS um Valor"
        Me.OS_UM_VALOR.Name = "OS_UM_VALOR"
        Me.OS_UM_VALOR.ReadOnly = True
        Me.OS_UM_VALOR.Width = 114
        '
        'OS_UM_DESPACHO
        '
        Me.OS_UM_DESPACHO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OS_UM_DESPACHO.DataPropertyName = "OS_UM_DESPACHO"
        Me.OS_UM_DESPACHO.HeaderText = "OS um Despaho"
        Me.OS_UM_DESPACHO.Name = "OS_UM_DESPACHO"
        Me.OS_UM_DESPACHO.ReadOnly = True
        Me.OS_UM_DESPACHO.Width = 137
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn27.HeaderText = ""
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'frmCargaMasivaSKU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCargaMasivaSKU"
        Me.Text = "Carga masiva SKU"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListadoSKU.ResumeLayout(False)
        CType(Me.dgMercaderias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCargaSKU.ResumeLayout(False)
        CType(Me.dgcargasku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCargaOS.ResumeLayout(False)
        CType(Me.dgcargasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtsku As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCargaArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpListadoSKU As System.Windows.Forms.TabPage
    Friend WithEvents tpCargaSKU As System.Windows.Forms.TabPage
    Friend WithEvents tpCargaOS As System.Windows.Forms.TabPage
    Friend WithEvents dgMercaderias As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents chkQ_OS As System.Windows.Forms.CheckBox
    Friend WithEvents dgcargasku As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgcargasos As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents CMRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TFMCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGRCLR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MON_COSTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QIMCT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMVTA_SOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMVTA_DOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QLRGMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QANCMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QALTMR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QARMT2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QARMT3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINFMR_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRFMR_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAPIMR_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EAN13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNCTL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCNTSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Q_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNDS2_DESPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_CARGA_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SKU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNID_MED_CANTIDAD_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNID_MED_PESO_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNID_MED_VALOR_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIDAD_DESPACHO_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_CARGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REGISTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OBS_REGISTRO_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCLR_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD3_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCTR_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_FAMILIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COD_GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMRCD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONEDA_COSTO_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COSTO_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QLRGMR_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QANCMR_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QALTMR_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QARMT2_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QARMT3_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINFMR_COD_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPRFMR_COD_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAPIMR_COD_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EAN13_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MARCRE_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNCTL_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCNTSR_CM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GENERAR_OS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OS_UM_CANTIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OS_UM_PESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OS_UM_VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OS_UM_DESPACHO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
