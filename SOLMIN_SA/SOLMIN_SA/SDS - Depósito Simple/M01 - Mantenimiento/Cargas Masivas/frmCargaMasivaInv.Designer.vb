<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaMasivaInv
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
        Dim BeCompania2 As RANSA.Controls.UbicacionPlanta.Compania.beCompania = New RANSA.Controls.UbicacionPlanta.Compania.beCompania()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.UcCompania_Cmb011 = New RANSA.Controls.UbicacionPlanta.ucCompania_Cmb01()
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaArchivo = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCargaAlmacen = New System.Windows.Forms.TabPage()
        Me.dgvCargaInvAlm = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.RESULT_CARGA_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MERCADERIA_CALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMRCD2_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ALMACEN_CALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN_CALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA_CALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD_CALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDEN_SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCNTR_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRCTC_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAUTR_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNCN5_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNPS5_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNVL5_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNDS2_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPDP6_ALM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpCargaUbicacion = New System.Windows.Forms.TabPage()
        Me.dgvCargaInvUbic = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.RESULT_CARGA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESULT_REG_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MERCADERIA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKU_DES_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_ALMACEN_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZONA_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBICACION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDEN_SERVICIO_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCNTR_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NCRCTC_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAUTR_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNCN5_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNPS5_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUNVL5_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FUNDS2_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTPDP6_UBIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpCargaAlmacen.SuspendLayout()
        CType(Me.dgvCargaInvAlm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCargaUbicacion.SuspendLayout()
        CType(Me.dgvCargaInvUbic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.UcCompania_Cmb011)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1444, 91)
        Me.Panel1.TabIndex = 3
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
        BeCompania2.CCMPN_CodigoCompania = ""
        BeCompania2.Orden = -1
        BeCompania2.TCMPCM_DescripcionCompania = ""
        Me.UcCompania_Cmb011.oBeCompania = BeCompania2
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(347, 28)
        Me.UcCompania_Cmb011.TabIndex = 118
        Me.UcCompania_Cmb011.Usuario = ""
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnexportar, Me.btnGuardar, Me.btnCargaArchivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 91)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1444, 27)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.TabControl1.Controls.Add(Me.tpCargaAlmacen)
        Me.TabControl1.Controls.Add(Me.tpCargaUbicacion)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1444, 622)
        Me.TabControl1.TabIndex = 5
        '
        'tpCargaAlmacen
        '
        Me.tpCargaAlmacen.Controls.Add(Me.dgvCargaInvAlm)
        Me.tpCargaAlmacen.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaAlmacen.Name = "tpCargaAlmacen"
        Me.tpCargaAlmacen.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCargaAlmacen.Size = New System.Drawing.Size(1436, 593)
        Me.tpCargaAlmacen.TabIndex = 1
        Me.tpCargaAlmacen.Text = "Carga Inventario - Almacén"
        Me.tpCargaAlmacen.UseVisualStyleBackColor = True
        '
        'dgvCargaInvAlm
        '
        Me.dgvCargaInvAlm.AllowUserToAddRows = False
        Me.dgvCargaInvAlm.AllowUserToDeleteRows = False
        Me.dgvCargaInvAlm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaInvAlm.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_ALM, Me.RESULT_REG_ALM, Me.MERCADERIA_CALM, Me.TMRCD2_ALM, Me.TIPO_ALMACEN_CALM, Me.ALMACEN_CALM, Me.ZONA_CALM, Me.CANTIDAD_CALM, Me.ORDEN_SERVICIO, Me.Column10, Me.NCNTR_ALM, Me.NCRCTC_ALM, Me.NAUTR_ALM, Me.CUNCN5_ALM, Me.CUNPS5_ALM, Me.CUNVL5_ALM, Me.FUNDS2_ALM, Me.CTPDP6_ALM})
        Me.dgvCargaInvAlm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargaInvAlm.Location = New System.Drawing.Point(3, 3)
        Me.dgvCargaInvAlm.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCargaInvAlm.Name = "dgvCargaInvAlm"
        Me.dgvCargaInvAlm.ReadOnly = True
        Me.dgvCargaInvAlm.Size = New System.Drawing.Size(1430, 587)
        Me.dgvCargaInvAlm.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCargaInvAlm.TabIndex = 2
        '
        'RESULT_CARGA_ALM
        '
        Me.RESULT_CARGA_ALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_CARGA_ALM.DataPropertyName = "OBS_CARGA"
        Me.RESULT_CARGA_ALM.HeaderText = "Carga"
        Me.RESULT_CARGA_ALM.Name = "RESULT_CARGA_ALM"
        Me.RESULT_CARGA_ALM.ReadOnly = True
        Me.RESULT_CARGA_ALM.Width = 81
        '
        'RESULT_REG_ALM
        '
        Me.RESULT_REG_ALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_REG_ALM.DataPropertyName = "OBS_REGISTRO"
        Me.RESULT_REG_ALM.HeaderText = "Registro"
        Me.RESULT_REG_ALM.Name = "RESULT_REG_ALM"
        Me.RESULT_REG_ALM.ReadOnly = True
        Me.RESULT_REG_ALM.Width = 97
        '
        'MERCADERIA_CALM
        '
        Me.MERCADERIA_CALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MERCADERIA_CALM.DataPropertyName = "SKU"
        Me.MERCADERIA_CALM.HeaderText = "SKU"
        Me.MERCADERIA_CALM.Name = "MERCADERIA_CALM"
        Me.MERCADERIA_CALM.ReadOnly = True
        Me.MERCADERIA_CALM.Width = 69
        '
        'TMRCD2_ALM
        '
        Me.TMRCD2_ALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TMRCD2_ALM.DataPropertyName = "TMRCD2"
        Me.TMRCD2_ALM.HeaderText = "Descripción"
        Me.TMRCD2_ALM.Name = "TMRCD2_ALM"
        Me.TMRCD2_ALM.ReadOnly = True
        Me.TMRCD2_ALM.Width = 120
        '
        'TIPO_ALMACEN_CALM
        '
        Me.TIPO_ALMACEN_CALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_ALMACEN_CALM.DataPropertyName = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN_CALM.HeaderText = "Tipo Almacén"
        Me.TIPO_ALMACEN_CALM.Name = "TIPO_ALMACEN_CALM"
        Me.TIPO_ALMACEN_CALM.ReadOnly = True
        Me.TIPO_ALMACEN_CALM.Width = 123
        '
        'ALMACEN_CALM
        '
        Me.ALMACEN_CALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALMACEN_CALM.DataPropertyName = "ALMACEN"
        Me.ALMACEN_CALM.HeaderText = "Almacén"
        Me.ALMACEN_CALM.Name = "ALMACEN_CALM"
        Me.ALMACEN_CALM.ReadOnly = True
        '
        'ZONA_CALM
        '
        Me.ZONA_CALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZONA_CALM.DataPropertyName = "ZONA"
        Me.ZONA_CALM.HeaderText = "Zona"
        Me.ZONA_CALM.Name = "ZONA_CALM"
        Me.ZONA_CALM.ReadOnly = True
        Me.ZONA_CALM.Width = 76
        '
        'CANTIDAD_CALM
        '
        Me.CANTIDAD_CALM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANTIDAD_CALM.DataPropertyName = "CANTIDAD"
        Me.CANTIDAD_CALM.HeaderText = "Cantidad"
        Me.CANTIDAD_CALM.Name = "CANTIDAD_CALM"
        Me.CANTIDAD_CALM.ReadOnly = True
        Me.CANTIDAD_CALM.Width = 102
        '
        'ORDEN_SERVICIO
        '
        Me.ORDEN_SERVICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ORDEN_SERVICIO.DataPropertyName = "NORDSR"
        Me.ORDEN_SERVICIO.HeaderText = "Orden Servicio"
        Me.ORDEN_SERVICIO.Name = "ORDEN_SERVICIO"
        Me.ORDEN_SERVICIO.ReadOnly = True
        Me.ORDEN_SERVICIO.Width = 128
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = ""
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'NCNTR_ALM
        '
        Me.NCNTR_ALM.DataPropertyName = "NCNTR"
        Me.NCNTR_ALM.HeaderText = "NCNTR"
        Me.NCNTR_ALM.Name = "NCNTR_ALM"
        Me.NCNTR_ALM.ReadOnly = True
        Me.NCNTR_ALM.Visible = False
        '
        'NCRCTC_ALM
        '
        Me.NCRCTC_ALM.DataPropertyName = "NCRCTC"
        Me.NCRCTC_ALM.HeaderText = "NCRCTC"
        Me.NCRCTC_ALM.Name = "NCRCTC_ALM"
        Me.NCRCTC_ALM.ReadOnly = True
        Me.NCRCTC_ALM.Visible = False
        '
        'NAUTR_ALM
        '
        Me.NAUTR_ALM.DataPropertyName = "NAUTR"
        Me.NAUTR_ALM.HeaderText = "NAUTR"
        Me.NAUTR_ALM.Name = "NAUTR_ALM"
        Me.NAUTR_ALM.ReadOnly = True
        Me.NAUTR_ALM.Visible = False
        '
        'CUNCN5_ALM
        '
        Me.CUNCN5_ALM.DataPropertyName = "CUNCN5"
        Me.CUNCN5_ALM.HeaderText = "CUNCN5"
        Me.CUNCN5_ALM.Name = "CUNCN5_ALM"
        Me.CUNCN5_ALM.ReadOnly = True
        Me.CUNCN5_ALM.Visible = False
        '
        'CUNPS5_ALM
        '
        Me.CUNPS5_ALM.DataPropertyName = "CUNCN5"
        Me.CUNPS5_ALM.HeaderText = "CUNPS5"
        Me.CUNPS5_ALM.Name = "CUNPS5_ALM"
        Me.CUNPS5_ALM.ReadOnly = True
        Me.CUNPS5_ALM.Visible = False
        '
        'CUNVL5_ALM
        '
        Me.CUNVL5_ALM.DataPropertyName = "CUNVL5"
        Me.CUNVL5_ALM.HeaderText = "CUNVL5"
        Me.CUNVL5_ALM.Name = "CUNVL5_ALM"
        Me.CUNVL5_ALM.ReadOnly = True
        Me.CUNVL5_ALM.Visible = False
        '
        'FUNDS2_ALM
        '
        Me.FUNDS2_ALM.DataPropertyName = "FUNDS2"
        Me.FUNDS2_ALM.HeaderText = "FUNDS2"
        Me.FUNDS2_ALM.Name = "FUNDS2_ALM"
        Me.FUNDS2_ALM.ReadOnly = True
        Me.FUNDS2_ALM.Visible = False
        '
        'CTPDP6_ALM
        '
        Me.CTPDP6_ALM.DataPropertyName = "CTPDP6"
        Me.CTPDP6_ALM.HeaderText = "CTPDP6"
        Me.CTPDP6_ALM.Name = "CTPDP6_ALM"
        Me.CTPDP6_ALM.ReadOnly = True
        Me.CTPDP6_ALM.Visible = False
        '
        'tpCargaUbicacion
        '
        Me.tpCargaUbicacion.Controls.Add(Me.dgvCargaInvUbic)
        Me.tpCargaUbicacion.Location = New System.Drawing.Point(4, 25)
        Me.tpCargaUbicacion.Name = "tpCargaUbicacion"
        Me.tpCargaUbicacion.Size = New System.Drawing.Size(1436, 593)
        Me.tpCargaUbicacion.TabIndex = 2
        Me.tpCargaUbicacion.Text = "Carga Inventario- Ubicación"
        Me.tpCargaUbicacion.UseVisualStyleBackColor = True
        '
        'dgvCargaInvUbic
        '
        Me.dgvCargaInvUbic.AllowUserToAddRows = False
        Me.dgvCargaInvUbic.AllowUserToDeleteRows = False
        Me.dgvCargaInvUbic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargaInvUbic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESULT_CARGA_UBIC, Me.RESULT_REG_UBIC, Me.MERCADERIA_UBIC, Me.SKU_DES_UBIC, Me.TIPO_ALMACEN_UBIC, Me.ALMACEN_UBIC, Me.ZONA_UBIC, Me.UBICACION, Me.CANTIDAD_UBIC, Me.ORDEN_SERVICIO_UBIC, Me.DataGridViewTextBoxColumn10, Me.NCNTR_UBIC, Me.NCRCTC_UBIC, Me.NAUTR_UBIC, Me.CUNCN5_UBIC, Me.CUNPS5_UBIC, Me.CUNVL5_UBIC, Me.FUNDS2_UBIC, Me.CTPDP6_UBIC})
        Me.dgvCargaInvUbic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCargaInvUbic.Location = New System.Drawing.Point(0, 0)
        Me.dgvCargaInvUbic.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCargaInvUbic.Name = "dgvCargaInvUbic"
        Me.dgvCargaInvUbic.ReadOnly = True
        Me.dgvCargaInvUbic.Size = New System.Drawing.Size(1436, 593)
        Me.dgvCargaInvUbic.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvCargaInvUbic.TabIndex = 3
        '
        'RESULT_CARGA_UBIC
        '
        Me.RESULT_CARGA_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_CARGA_UBIC.DataPropertyName = "OBS_CARGA"
        Me.RESULT_CARGA_UBIC.HeaderText = "Carga"
        Me.RESULT_CARGA_UBIC.Name = "RESULT_CARGA_UBIC"
        Me.RESULT_CARGA_UBIC.ReadOnly = True
        Me.RESULT_CARGA_UBIC.Width = 81
        '
        'RESULT_REG_UBIC
        '
        Me.RESULT_REG_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RESULT_REG_UBIC.DataPropertyName = "OBS_REGISTRO"
        Me.RESULT_REG_UBIC.HeaderText = "Registro"
        Me.RESULT_REG_UBIC.Name = "RESULT_REG_UBIC"
        Me.RESULT_REG_UBIC.ReadOnly = True
        Me.RESULT_REG_UBIC.Width = 97
        '
        'MERCADERIA_UBIC
        '
        Me.MERCADERIA_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MERCADERIA_UBIC.DataPropertyName = "SKU"
        Me.MERCADERIA_UBIC.HeaderText = "SKU"
        Me.MERCADERIA_UBIC.Name = "MERCADERIA_UBIC"
        Me.MERCADERIA_UBIC.ReadOnly = True
        Me.MERCADERIA_UBIC.Width = 69
        '
        'SKU_DES_UBIC
        '
        Me.SKU_DES_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKU_DES_UBIC.DataPropertyName = "TMRCD2"
        Me.SKU_DES_UBIC.HeaderText = "Descripción"
        Me.SKU_DES_UBIC.Name = "SKU_DES_UBIC"
        Me.SKU_DES_UBIC.ReadOnly = True
        Me.SKU_DES_UBIC.Width = 120
        '
        'TIPO_ALMACEN_UBIC
        '
        Me.TIPO_ALMACEN_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TIPO_ALMACEN_UBIC.DataPropertyName = "TIPO_ALMACEN"
        Me.TIPO_ALMACEN_UBIC.HeaderText = "Tipo Almacén"
        Me.TIPO_ALMACEN_UBIC.Name = "TIPO_ALMACEN_UBIC"
        Me.TIPO_ALMACEN_UBIC.ReadOnly = True
        Me.TIPO_ALMACEN_UBIC.Width = 123
        '
        'ALMACEN_UBIC
        '
        Me.ALMACEN_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ALMACEN_UBIC.DataPropertyName = "ALMACEN"
        Me.ALMACEN_UBIC.HeaderText = "Almacén"
        Me.ALMACEN_UBIC.Name = "ALMACEN_UBIC"
        Me.ALMACEN_UBIC.ReadOnly = True
        '
        'ZONA_UBIC
        '
        Me.ZONA_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ZONA_UBIC.DataPropertyName = "ZONA"
        Me.ZONA_UBIC.HeaderText = "Zona"
        Me.ZONA_UBIC.Name = "ZONA_UBIC"
        Me.ZONA_UBIC.ReadOnly = True
        Me.ZONA_UBIC.Width = 76
        '
        'UBICACION
        '
        Me.UBICACION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UBICACION.DataPropertyName = "UBICACION"
        Me.UBICACION.HeaderText = "Ubicación"
        Me.UBICACION.Name = "UBICACION"
        Me.UBICACION.ReadOnly = True
        Me.UBICACION.Width = 108
        '
        'CANTIDAD_UBIC
        '
        Me.CANTIDAD_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CANTIDAD_UBIC.DataPropertyName = "CANTIDAD"
        Me.CANTIDAD_UBIC.HeaderText = "Cantidad"
        Me.CANTIDAD_UBIC.Name = "CANTIDAD_UBIC"
        Me.CANTIDAD_UBIC.ReadOnly = True
        Me.CANTIDAD_UBIC.Width = 102
        '
        'ORDEN_SERVICIO_UBIC
        '
        Me.ORDEN_SERVICIO_UBIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ORDEN_SERVICIO_UBIC.DataPropertyName = "NORDSR"
        Me.ORDEN_SERVICIO_UBIC.HeaderText = "Orden Servicio"
        Me.ORDEN_SERVICIO_UBIC.Name = "ORDEN_SERVICIO_UBIC"
        Me.ORDEN_SERVICIO_UBIC.ReadOnly = True
        Me.ORDEN_SERVICIO_UBIC.Width = 128
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.HeaderText = ""
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'NCNTR_UBIC
        '
        Me.NCNTR_UBIC.DataPropertyName = "NCNTR"
        Me.NCNTR_UBIC.HeaderText = "NCNTR"
        Me.NCNTR_UBIC.Name = "NCNTR_UBIC"
        Me.NCNTR_UBIC.ReadOnly = True
        Me.NCNTR_UBIC.Visible = False
        '
        'NCRCTC_UBIC
        '
        Me.NCRCTC_UBIC.DataPropertyName = "NCRCTC"
        Me.NCRCTC_UBIC.HeaderText = "NCRCTC"
        Me.NCRCTC_UBIC.Name = "NCRCTC_UBIC"
        Me.NCRCTC_UBIC.ReadOnly = True
        Me.NCRCTC_UBIC.Visible = False
        '
        'NAUTR_UBIC
        '
        Me.NAUTR_UBIC.DataPropertyName = "NAUTR"
        Me.NAUTR_UBIC.HeaderText = "NAUTR"
        Me.NAUTR_UBIC.Name = "NAUTR_UBIC"
        Me.NAUTR_UBIC.ReadOnly = True
        Me.NAUTR_UBIC.Visible = False
        '
        'CUNCN5_UBIC
        '
        Me.CUNCN5_UBIC.DataPropertyName = "CUNCN5"
        Me.CUNCN5_UBIC.HeaderText = "CUNCN5"
        Me.CUNCN5_UBIC.Name = "CUNCN5_UBIC"
        Me.CUNCN5_UBIC.ReadOnly = True
        Me.CUNCN5_UBIC.Visible = False
        '
        'CUNPS5_UBIC
        '
        Me.CUNPS5_UBIC.DataPropertyName = "CUNPS5"
        Me.CUNPS5_UBIC.HeaderText = "CUNPS5"
        Me.CUNPS5_UBIC.Name = "CUNPS5_UBIC"
        Me.CUNPS5_UBIC.ReadOnly = True
        Me.CUNPS5_UBIC.Visible = False
        '
        'CUNVL5_UBIC
        '
        Me.CUNVL5_UBIC.DataPropertyName = "CUNVL5"
        Me.CUNVL5_UBIC.HeaderText = "CUNVL5"
        Me.CUNVL5_UBIC.Name = "CUNVL5_UBIC"
        Me.CUNVL5_UBIC.ReadOnly = True
        Me.CUNVL5_UBIC.Visible = False
        '
        'FUNDS2_UBIC
        '
        Me.FUNDS2_UBIC.DataPropertyName = "FUNDS2"
        Me.FUNDS2_UBIC.HeaderText = "FUNDS2"
        Me.FUNDS2_UBIC.Name = "FUNDS2_UBIC"
        Me.FUNDS2_UBIC.ReadOnly = True
        Me.FUNDS2_UBIC.Visible = False
        '
        'CTPDP6_UBIC
        '
        Me.CTPDP6_UBIC.DataPropertyName = "CTPDP6"
        Me.CTPDP6_UBIC.HeaderText = "CTPDP6"
        Me.CTPDP6_UBIC.Name = "CTPDP6_UBIC"
        Me.CTPDP6_UBIC.ReadOnly = True
        Me.CTPDP6_UBIC.Visible = False
        '
        'frmCargaMasivaInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 740)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCargaMasivaInv"
        Me.Text = "Carga Inventario Masivo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tpCargaAlmacen.ResumeLayout(False)
        CType(Me.dgvCargaInvAlm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCargaUbicacion.ResumeLayout(False)
        CType(Me.dgvCargaInvUbic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCargaArchivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCargaAlmacen As System.Windows.Forms.TabPage
    Friend WithEvents tpCargaUbicacion As System.Windows.Forms.TabPage
    Friend WithEvents dgvCargaInvAlm As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dgvCargaInvUbic As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents RESULT_CARGA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MERCADERIA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SKU_DES_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ALMACEN_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UBICACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORDEN_SERVICIO_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTR_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRCTC_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAUTR_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS5_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNVL5_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNDS2_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPDP6_UBIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_CARGA_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESULT_REG_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MERCADERIA_CALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMRCD2_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO_ALMACEN_CALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN_CALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZONA_CALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD_CALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORDEN_SERVICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCNTR_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NCRCTC_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAUTR_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNCN5_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNPS5_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUNVL5_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FUNDS2_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CTPDP6_ALM As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
