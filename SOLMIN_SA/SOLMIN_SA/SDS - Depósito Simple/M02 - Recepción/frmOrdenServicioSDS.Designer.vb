<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenServicioSDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenServicioSDS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.dstContratos = New System.Data.DataSet()
        Me.dtContratos = New System.Data.DataTable()
        Me.NCNTR = New System.Data.DataColumn()
        Me.CTPDP3 = New System.Data.DataColumn()
        Me.TABDPS = New System.Data.DataColumn()
        Me.CTPPR1 = New System.Data.DataColumn()
        Me.CUNCN3 = New System.Data.DataColumn()
        Me.CUNPS3 = New System.Data.DataColumn()
        Me.CUNVL3 = New System.Data.DataColumn()
        Me.dstOrdenServicio = New System.Data.DataSet()
        Me.dtOrdenServicio = New System.Data.DataTable()
        Me.ONORDSR = New System.Data.DataColumn()
        Me.ONCNTR = New System.Data.DataColumn()
        Me.ONCRCTC = New System.Data.DataColumn()
        Me.ONAUTR = New System.Data.DataColumn()
        Me.OFEMORS = New System.Data.DataColumn()
        Me.OCTPDP6 = New System.Data.DataColumn()
        Me.OQSLMC = New System.Data.DataColumn()
        Me.OCUNCN5 = New System.Data.DataColumn()
        Me.OQSLMP = New System.Data.DataColumn()
        Me.OCUNPS5 = New System.Data.DataColumn()
        Me.OQSLMV = New System.Data.DataColumn()
        Me.OCUNVL5 = New System.Data.DataColumn()
        Me.OFUNDS2 = New System.Data.DataColumn()
        Me.OFUNCTL = New System.Data.DataColumn()
        Me.OQMRCD1 = New System.Data.DataColumn()
        Me.OQPSMR1 = New System.Data.DataColumn()
        Me.OQVLMR1 = New System.Data.DataColumn()
        Me.hgOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.bsaCrearOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaModificarOS = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.bsaCancelar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.dgListaOrdenesServicio = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.O_NORDSR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_NCRCTC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_NAUTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_FEMORS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CTPDP6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QSLMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CUNCN5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QSLMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CUNPS5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QSLMV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_CUNVL5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_FUNDS2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_FUNCTL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QMRCD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QPSMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.O_QVLMR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hgParametrosCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.cbxUnidadDespacho = New System.Windows.Forms.ComboBox()
        Me.lblUnidadDespacho = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancelarCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnProcesarCrearOS = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cbxControlLote = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtValor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblValor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadValor = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblUnidadValor = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaListarUnidadPeso = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblUnidadPeso = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadCantidad = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.bsaListarUnidadCantidad = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblUnidadCantidad = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dgContratosVigentes = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.M_NCNTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CTPDP3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_TABDPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CTPPR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CUNCN3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CUNPS3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_CUNVL3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hgParametrosModificarOS = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.lblOrdenServicio = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cbxControlDespacho_M = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnCancelarModificarOS = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnActualizarModificarOS = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cbxControlLote_M = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtValor_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadValor_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPeso_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtCantidad_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadPeso_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtUnidadCantidad_M = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.ButtonSpecAny4 = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgOS.Panel.SuspendLayout()
        Me.hgOS.SuspendLayout()
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosCrearOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosCrearOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgParametrosCrearOS.Panel.SuspendLayout()
        Me.hgParametrosCrearOS.SuspendLayout()
        CType(Me.dgContratosVigentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosModificarOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgParametrosModificarOS.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgParametrosModificarOS.Panel.SuspendLayout()
        Me.hgParametrosModificarOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'dstContratos
        '
        Me.dstContratos.DataSetName = "NewDataSet"
        Me.dstContratos.Tables.AddRange(New System.Data.DataTable() {Me.dtContratos})
        '
        'dtContratos
        '
        Me.dtContratos.Columns.AddRange(New System.Data.DataColumn() {Me.NCNTR, Me.CTPDP3, Me.TABDPS, Me.CTPPR1, Me.CUNCN3, Me.CUNPS3, Me.CUNVL3})
        Me.dtContratos.TableName = "dtContratos"
        '
        'NCNTR
        '
        Me.NCNTR.ColumnName = "NCNTR"
        '
        'CTPDP3
        '
        Me.CTPDP3.ColumnName = "CTPDP3"
        '
        'TABDPS
        '
        Me.TABDPS.ColumnName = "TABDPS"
        '
        'CTPPR1
        '
        Me.CTPPR1.ColumnName = "CTPPR1"
        '
        'CUNCN3
        '
        Me.CUNCN3.ColumnName = "CUNCN3"
        '
        'CUNPS3
        '
        Me.CUNPS3.ColumnName = "CUNPS3"
        '
        'CUNVL3
        '
        Me.CUNVL3.ColumnName = "CUNVL3"
        '
        'dstOrdenServicio
        '
        Me.dstOrdenServicio.DataSetName = "NewDataSet"
        Me.dstOrdenServicio.Tables.AddRange(New System.Data.DataTable() {Me.dtOrdenServicio})
        '
        'dtOrdenServicio
        '
        Me.dtOrdenServicio.Columns.AddRange(New System.Data.DataColumn() {Me.ONORDSR, Me.ONCNTR, Me.ONCRCTC, Me.ONAUTR, Me.OFEMORS, Me.OCTPDP6, Me.OQSLMC, Me.OCUNCN5, Me.OQSLMP, Me.OCUNPS5, Me.OQSLMV, Me.OCUNVL5, Me.OFUNDS2, Me.OFUNCTL, Me.OQMRCD1, Me.OQPSMR1, Me.OQVLMR1})
        Me.dtOrdenServicio.TableName = "dtOrdenServicio"
        '
        'ONORDSR
        '
        Me.ONORDSR.ColumnName = "NORDSR"
        Me.ONORDSR.DataType = GetType(Integer)
        '
        'ONCNTR
        '
        Me.ONCNTR.ColumnName = "NCNTR"
        Me.ONCNTR.DataType = GetType(Integer)
        '
        'ONCRCTC
        '
        Me.ONCRCTC.ColumnName = "NCRCTC"
        Me.ONCRCTC.DataType = GetType(Integer)
        '
        'ONAUTR
        '
        Me.ONAUTR.ColumnName = "NAUTR"
        Me.ONAUTR.DataType = GetType(Integer)
        '
        'OFEMORS
        '
        Me.OFEMORS.ColumnName = "FEMORS"
        Me.OFEMORS.DataType = GetType(Date)
        '
        'OCTPDP6
        '
        Me.OCTPDP6.ColumnName = "CTPDP6"
        '
        'OQSLMC
        '
        Me.OQSLMC.ColumnName = "QSLMC"
        Me.OQSLMC.DataType = GetType(Decimal)
        '
        'OCUNCN5
        '
        Me.OCUNCN5.ColumnName = "CUNCN5"
        '
        'OQSLMP
        '
        Me.OQSLMP.ColumnName = "QSLMP"
        Me.OQSLMP.DataType = GetType(Decimal)
        '
        'OCUNPS5
        '
        Me.OCUNPS5.ColumnName = "CUNPS5"
        '
        'OQSLMV
        '
        Me.OQSLMV.ColumnName = "QSLMV"
        Me.OQSLMV.DataType = GetType(Decimal)
        '
        'OCUNVL5
        '
        Me.OCUNVL5.ColumnName = "CUNVL5"
        '
        'OFUNDS2
        '
        Me.OFUNDS2.ColumnName = "FUNDS2"
        '
        'OFUNCTL
        '
        Me.OFUNCTL.ColumnName = "FUNCTL"
        '
        'OQMRCD1
        '
        Me.OQMRCD1.ColumnName = "QMRCD1"
        '
        'OQPSMR1
        '
        Me.OQPSMR1.ColumnName = "QPSMR1"
        '
        'OQVLMR1
        '
        Me.OQVLMR1.ColumnName = "QVLMR1"
        '
        'hgOS
        '
        Me.hgOS.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaCrearOS, Me.bsaModificarOS, Me.bsaCancelar})
        Me.hgOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgOS.HeaderVisibleSecondary = False
        Me.hgOS.Location = New System.Drawing.Point(0, 0)
        Me.hgOS.Name = "hgOS"
        '
        'hgOS.Panel
        '
        Me.hgOS.Panel.Controls.Add(Me.dgListaOrdenesServicio)
        Me.hgOS.Panel.Controls.Add(Me.hgParametrosCrearOS)
        Me.hgOS.Panel.Controls.Add(Me.hgParametrosModificarOS)
        Me.hgOS.Size = New System.Drawing.Size(612, 361)
        Me.hgOS.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgOS.TabIndex = 53
        Me.hgOS.ValuesPrimary.Description = ""
        Me.hgOS.ValuesPrimary.Heading = ""
        Me.hgOS.ValuesPrimary.Image = Nothing
        Me.hgOS.ValuesSecondary.Description = ""
        Me.hgOS.ValuesSecondary.Heading = "Description"
        Me.hgOS.ValuesSecondary.Image = Nothing
        '
        'bsaCrearOS
        '
        Me.bsaCrearOS.ExtraText = ""
        Me.bsaCrearOS.Image = CType(resources.GetObject("bsaCrearOS.Image"), System.Drawing.Image)
        Me.bsaCrearOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCrearOS.Text = " &Crear O/S"
        Me.bsaCrearOS.ToolTipImage = Nothing
        Me.bsaCrearOS.UniqueName = "22A012AE22564A2A22A012AE22564A2A"
        '
        'bsaModificarOS
        '
        Me.bsaModificarOS.ExtraText = ""
        Me.bsaModificarOS.Image = Global.SOLMIN_SA.My.Resources.Resources.edit_add
        Me.bsaModificarOS.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaModificarOS.Text = " &Modificar O/S"
        Me.bsaModificarOS.ToolTipImage = Nothing
        Me.bsaModificarOS.UniqueName = "4061D697752C447A4061D697752C447A"
        '
        'bsaCancelar
        '
        Me.bsaCancelar.ExtraText = ""
        Me.bsaCancelar.Image = Global.SOLMIN_SA.My.Resources.Resources.button_cancel
        Me.bsaCancelar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.bsaCancelar.Text = " &Cancelar"
        Me.bsaCancelar.ToolTipImage = Nothing
        Me.bsaCancelar.UniqueName = "45745F99952B495545745F99952B4955"
        '
        'dgListaOrdenesServicio
        '
        Me.dgListaOrdenesServicio.AllowUserToAddRows = False
        Me.dgListaOrdenesServicio.AllowUserToDeleteRows = False
        Me.dgListaOrdenesServicio.AllowUserToResizeColumns = False
        Me.dgListaOrdenesServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgListaOrdenesServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgListaOrdenesServicio.AutoGenerateColumns = False
        Me.dgListaOrdenesServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgListaOrdenesServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.O_NORDSR, Me.O_NCNTR, Me.O_NCRCTC, Me.O_NAUTR, Me.O_FEMORS, Me.O_CTPDP6, Me.O_QSLMC, Me.O_CUNCN5, Me.O_QSLMP, Me.O_CUNPS5, Me.O_QSLMV, Me.O_CUNVL5, Me.O_FUNDS2, Me.O_FUNCTL, Me.O_QMRCD1, Me.O_QPSMR1, Me.O_QVLMR1})
        Me.dgListaOrdenesServicio.DataMember = "dtOrdenServicio"
        Me.dgListaOrdenesServicio.DataSource = Me.dstOrdenServicio
        Me.dgListaOrdenesServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaOrdenesServicio.Location = New System.Drawing.Point(0, 0)
        Me.dgListaOrdenesServicio.MultiSelect = False
        Me.dgListaOrdenesServicio.Name = "dgListaOrdenesServicio"
        Me.dgListaOrdenesServicio.ReadOnly = True
        Me.dgListaOrdenesServicio.RowHeadersWidth = 20
        Me.dgListaOrdenesServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaOrdenesServicio.Size = New System.Drawing.Size(610, 294)
        Me.dgListaOrdenesServicio.StandardTab = True
        Me.dgListaOrdenesServicio.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgListaOrdenesServicio.StateNormal.Background.Color1 = System.Drawing.Color.White
        Me.dgListaOrdenesServicio.TabIndex = 52
        '
        'O_NORDSR
        '
        Me.O_NORDSR.DataPropertyName = "NORDSR"
        Me.O_NORDSR.HeaderText = "Nro. O/S"
        Me.O_NORDSR.Name = "O_NORDSR"
        Me.O_NORDSR.ReadOnly = True
        Me.O_NORDSR.Width = 82
        '
        'O_NCNTR
        '
        Me.O_NCNTR.DataPropertyName = "NCNTR"
        Me.O_NCNTR.HeaderText = "Contrato"
        Me.O_NCNTR.Name = "O_NCNTR"
        Me.O_NCNTR.ReadOnly = True
        Me.O_NCNTR.Visible = False
        Me.O_NCNTR.Width = 76
        '
        'O_NCRCTC
        '
        Me.O_NCRCTC.DataPropertyName = "NCRCTC"
        Me.O_NCRCTC.HeaderText = "Corr."
        Me.O_NCRCTC.Name = "O_NCRCTC"
        Me.O_NCRCTC.ReadOnly = True
        Me.O_NCRCTC.Visible = False
        Me.O_NCRCTC.Width = 58
        '
        'O_NAUTR
        '
        Me.O_NAUTR.DataPropertyName = "NAUTR"
        Me.O_NAUTR.HeaderText = "Autorización"
        Me.O_NAUTR.Name = "O_NAUTR"
        Me.O_NAUTR.ReadOnly = True
        Me.O_NAUTR.Visible = False
        Me.O_NAUTR.Width = 94
        '
        'O_FEMORS
        '
        Me.O_FEMORS.DataPropertyName = "FEMORS"
        Me.O_FEMORS.HeaderText = "Fecha"
        Me.O_FEMORS.Name = "O_FEMORS"
        Me.O_FEMORS.ReadOnly = True
        Me.O_FEMORS.Width = 67
        '
        'O_CTPDP6
        '
        Me.O_CTPDP6.DataPropertyName = "CTPDP6"
        Me.O_CTPDP6.HeaderText = "Tipo Depósito"
        Me.O_CTPDP6.Name = "O_CTPDP6"
        Me.O_CTPDP6.ReadOnly = True
        Me.O_CTPDP6.Width = 110
        '
        'O_QSLMC
        '
        Me.O_QSLMC.DataPropertyName = "QSLMC"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = "0.0000"
        Me.O_QSLMC.DefaultCellStyle = DataGridViewCellStyle2
        Me.O_QSLMC.HeaderText = "S. Cantidad"
        Me.O_QSLMC.Name = "O_QSLMC"
        Me.O_QSLMC.ReadOnly = True
        Me.O_QSLMC.Width = 96
        '
        'O_CUNCN5
        '
        Me.O_CUNCN5.DataPropertyName = "CUNCN5"
        Me.O_CUNCN5.HeaderText = "Unidad"
        Me.O_CUNCN5.Name = "O_CUNCN5"
        Me.O_CUNCN5.ReadOnly = True
        Me.O_CUNCN5.Width = 74
        '
        'O_QSLMP
        '
        Me.O_QSLMP.DataPropertyName = "QSLMP"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = "0.0000"
        Me.O_QSLMP.DefaultCellStyle = DataGridViewCellStyle3
        Me.O_QSLMP.HeaderText = "S. Peso"
        Me.O_QSLMP.Name = "O_QSLMP"
        Me.O_QSLMP.ReadOnly = True
        Me.O_QSLMP.Width = 73
        '
        'O_CUNPS5
        '
        Me.O_CUNPS5.DataPropertyName = "CUNPS5"
        Me.O_CUNPS5.HeaderText = "Unidad"
        Me.O_CUNPS5.Name = "O_CUNPS5"
        Me.O_CUNPS5.ReadOnly = True
        Me.O_CUNPS5.Width = 74
        '
        'O_QSLMV
        '
        Me.O_QSLMV.DataPropertyName = "QSLMV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = "0.0000"
        Me.O_QSLMV.DefaultCellStyle = DataGridViewCellStyle4
        Me.O_QSLMV.HeaderText = "S. Valor"
        Me.O_QSLMV.Name = "O_QSLMV"
        Me.O_QSLMV.ReadOnly = True
        Me.O_QSLMV.Width = 74
        '
        'O_CUNVL5
        '
        Me.O_CUNVL5.DataPropertyName = "CUNVL5"
        Me.O_CUNVL5.HeaderText = "Unidad"
        Me.O_CUNVL5.Name = "O_CUNVL5"
        Me.O_CUNVL5.ReadOnly = True
        Me.O_CUNVL5.Width = 74
        '
        'O_FUNDS2
        '
        Me.O_FUNDS2.DataPropertyName = "FUNDS2"
        Me.O_FUNDS2.HeaderText = "Status"
        Me.O_FUNDS2.Name = "O_FUNDS2"
        Me.O_FUNDS2.ReadOnly = True
        Me.O_FUNDS2.Visible = False
        Me.O_FUNDS2.Width = 66
        '
        'O_FUNCTL
        '
        Me.O_FUNCTL.DataPropertyName = "FUNCTL"
        Me.O_FUNCTL.HeaderText = "U Despacho"
        Me.O_FUNCTL.Name = "O_FUNCTL"
        Me.O_FUNCTL.ReadOnly = True
        Me.O_FUNCTL.Visible = False
        Me.O_FUNCTL.Width = 96
        '
        'O_QMRCD1
        '
        Me.O_QMRCD1.DataPropertyName = "QMRCD1"
        Me.O_QMRCD1.HeaderText = "QMRCD1"
        Me.O_QMRCD1.Name = "O_QMRCD1"
        Me.O_QMRCD1.ReadOnly = True
        Me.O_QMRCD1.Visible = False
        Me.O_QMRCD1.Width = 82
        '
        'O_QPSMR1
        '
        Me.O_QPSMR1.DataPropertyName = "QPSMR1"
        Me.O_QPSMR1.HeaderText = "QPSMR1"
        Me.O_QPSMR1.Name = "O_QPSMR1"
        Me.O_QPSMR1.ReadOnly = True
        Me.O_QPSMR1.Visible = False
        Me.O_QPSMR1.Width = 81
        '
        'O_QVLMR1
        '
        Me.O_QVLMR1.DataPropertyName = "QVLMR1"
        Me.O_QVLMR1.HeaderText = "QVLMR1"
        Me.O_QVLMR1.Name = "O_QVLMR1"
        Me.O_QVLMR1.ReadOnly = True
        Me.O_QVLMR1.Visible = False
        Me.O_QVLMR1.Width = 80
        '
        'hgParametrosCrearOS
        '
        Me.hgParametrosCrearOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgParametrosCrearOS.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgParametrosCrearOS.HeaderVisibleSecondary = False
        Me.hgParametrosCrearOS.Location = New System.Drawing.Point(0, 294)
        Me.hgParametrosCrearOS.Name = "hgParametrosCrearOS"
        '
        'hgParametrosCrearOS.Panel
        '
        Me.hgParametrosCrearOS.Panel.AutoScroll = True
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.cbxUnidadDespacho)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadDespacho)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.btnCancelarCrearOS)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.btnProcesarCrearOS)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.cbxControlLote)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtUnidadValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadValor)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtUnidadPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadPeso)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.txtUnidadCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.lblUnidadCantidad)
        Me.hgParametrosCrearOS.Panel.Controls.Add(Me.dgContratosVigentes)
        Me.hgParametrosCrearOS.Size = New System.Drawing.Size(610, 17)
        Me.hgParametrosCrearOS.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgParametrosCrearOS.TabIndex = 50
        Me.hgParametrosCrearOS.Text = "Crear Nueva O/S"
        Me.hgParametrosCrearOS.ValuesPrimary.Description = ""
        Me.hgParametrosCrearOS.ValuesPrimary.Heading = "Crear Nueva O/S"
        Me.hgParametrosCrearOS.ValuesPrimary.Image = Nothing
        Me.hgParametrosCrearOS.ValuesSecondary.Description = ""
        Me.hgParametrosCrearOS.ValuesSecondary.Heading = "Description"
        Me.hgParametrosCrearOS.ValuesSecondary.Image = Nothing
        '
        'cbxUnidadDespacho
        '
        Me.cbxUnidadDespacho.FormattingEnabled = True
        Me.cbxUnidadDespacho.Items.AddRange(New Object() {"C", "P"})
        Me.cbxUnidadDespacho.Location = New System.Drawing.Point(108, 166)
        Me.cbxUnidadDespacho.Name = "cbxUnidadDespacho"
        Me.cbxUnidadDespacho.Size = New System.Drawing.Size(42, 21)
        Me.cbxUnidadDespacho.TabIndex = 67
        '
        'lblUnidadDespacho
        '
        Me.lblUnidadDespacho.Location = New System.Drawing.Point(40, 171)
        Me.lblUnidadDespacho.Name = "lblUnidadDespacho"
        Me.lblUnidadDespacho.Size = New System.Drawing.Size(73, 20)
        Me.lblUnidadDespacho.TabIndex = 66
        Me.lblUnidadDespacho.Text = "Unid. Desp:"
        Me.lblUnidadDespacho.Values.ExtraText = ""
        Me.lblUnidadDespacho.Values.Image = Nothing
        Me.lblUnidadDespacho.Values.Text = "Unid. Desp:"
        '
        'btnCancelarCrearOS
        '
        Me.btnCancelarCrearOS.Location = New System.Drawing.Point(271, 203)
        Me.btnCancelarCrearOS.Name = "btnCancelarCrearOS"
        Me.btnCancelarCrearOS.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelarCrearOS.TabIndex = 70
        Me.btnCancelarCrearOS.Text = "Cancelar"
        Me.btnCancelarCrearOS.Values.ExtraText = ""
        Me.btnCancelarCrearOS.Values.Image = CType(resources.GetObject("btnCancelarCrearOS.Values.Image"), System.Drawing.Image)
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelarCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelarCrearOS.Values.Text = "Cancelar"
        '
        'btnProcesarCrearOS
        '
        Me.btnProcesarCrearOS.Location = New System.Drawing.Point(153, 203)
        Me.btnProcesarCrearOS.Name = "btnProcesarCrearOS"
        Me.btnProcesarCrearOS.Size = New System.Drawing.Size(100, 25)
        Me.btnProcesarCrearOS.TabIndex = 69
        Me.btnProcesarCrearOS.Text = "Procesar"
        Me.btnProcesarCrearOS.Values.ExtraText = ""
        Me.btnProcesarCrearOS.Values.Image = CType(resources.GetObject("btnProcesarCrearOS.Values.Image"), System.Drawing.Image)
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesarCrearOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesarCrearOS.Values.Text = "Procesar"
        '
        'cbxControlLote
        '
        Me.cbxControlLote.Checked = False
        Me.cbxControlLote.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.cbxControlLote.Location = New System.Drawing.Point(220, 171)
        Me.cbxControlLote.Name = "cbxControlLote"
        Me.cbxControlLote.Size = New System.Drawing.Size(113, 20)
        Me.cbxControlLote.TabIndex = 68
        Me.cbxControlLote.Text = "Control por Lote"
        Me.cbxControlLote.Values.ExtraText = ""
        Me.cbxControlLote.Values.Image = Nothing
        Me.cbxControlLote.Values.Text = "Control por Lote"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(108, 141)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 22)
        Me.txtValor.TabIndex = 63
        Me.txtValor.Text = "0.00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(40, 144)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(45, 20)
        Me.lblValor.TabIndex = 62
        Me.lblValor.Text = "Valor : "
        Me.lblValor.Values.ExtraText = ""
        Me.lblValor.Values.Image = Nothing
        Me.lblValor.Values.Text = "Valor : "
        '
        'txtUnidadValor
        '
        Me.txtUnidadValor.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny1})
        Me.txtUnidadValor.Location = New System.Drawing.Point(271, 141)
        Me.txtUnidadValor.MaxLength = 10
        Me.txtUnidadValor.Name = "txtUnidadValor"
        Me.txtUnidadValor.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadValor.TabIndex = 65
        Me.txtUnidadValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonSpecAny1
        '
        Me.ButtonSpecAny1.ExtraText = ""
        Me.ButtonSpecAny1.Image = Nothing
        Me.ButtonSpecAny1.Text = ""
        Me.ButtonSpecAny1.ToolTipImage = Nothing
        Me.ButtonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny1.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'lblUnidadValor
        '
        Me.lblUnidadValor.Location = New System.Drawing.Point(213, 144)
        Me.lblUnidadValor.Name = "lblUnidadValor"
        Me.lblUnidadValor.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidadValor.TabIndex = 64
        Me.lblUnidadValor.Text = "Unidad :"
        Me.lblUnidadValor.Values.ExtraText = ""
        Me.lblUnidadValor.Values.Image = Nothing
        Me.lblUnidadValor.Values.Text = "Unidad :"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(108, 116)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(88, 22)
        Me.txtPeso.TabIndex = 59
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPeso
        '
        Me.lblPeso.Location = New System.Drawing.Point(40, 119)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(42, 20)
        Me.lblPeso.TabIndex = 58
        Me.lblPeso.Text = "Peso : "
        Me.lblPeso.Values.ExtraText = ""
        Me.lblPeso.Values.Image = Nothing
        Me.lblPeso.Values.Text = "Peso : "
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(108, 91)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(88, 22)
        Me.txtCantidad.TabIndex = 55
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(40, 94)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 20)
        Me.lblCantidad.TabIndex = 54
        Me.lblCantidad.Text = "Cantidad : "
        Me.lblCantidad.Values.ExtraText = ""
        Me.lblCantidad.Values.Image = Nothing
        Me.lblCantidad.Values.Text = "Cantidad : "
        '
        'txtUnidadPeso
        '
        Me.txtUnidadPeso.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadPeso})
        Me.txtUnidadPeso.Location = New System.Drawing.Point(271, 116)
        Me.txtUnidadPeso.MaxLength = 10
        Me.txtUnidadPeso.Name = "txtUnidadPeso"
        Me.txtUnidadPeso.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadPeso.TabIndex = 61
        Me.txtUnidadPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bsaListarUnidadPeso
        '
        Me.bsaListarUnidadPeso.ExtraText = ""
        Me.bsaListarUnidadPeso.Image = Nothing
        Me.bsaListarUnidadPeso.Text = ""
        Me.bsaListarUnidadPeso.ToolTipImage = Nothing
        Me.bsaListarUnidadPeso.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaListarUnidadPeso.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'lblUnidadPeso
        '
        Me.lblUnidadPeso.Location = New System.Drawing.Point(213, 119)
        Me.lblUnidadPeso.Name = "lblUnidadPeso"
        Me.lblUnidadPeso.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidadPeso.TabIndex = 60
        Me.lblUnidadPeso.Text = "Unidad :"
        Me.lblUnidadPeso.Values.ExtraText = ""
        Me.lblUnidadPeso.Values.Image = Nothing
        Me.lblUnidadPeso.Values.Text = "Unidad :"
        '
        'txtUnidadCantidad
        '
        Me.txtUnidadCantidad.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaListarUnidadCantidad})
        Me.txtUnidadCantidad.Location = New System.Drawing.Point(271, 91)
        Me.txtUnidadCantidad.MaxLength = 10
        Me.txtUnidadCantidad.Name = "txtUnidadCantidad"
        Me.txtUnidadCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadCantidad.TabIndex = 57
        Me.txtUnidadCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bsaListarUnidadCantidad
        '
        Me.bsaListarUnidadCantidad.ExtraText = ""
        Me.bsaListarUnidadCantidad.Image = Nothing
        Me.bsaListarUnidadCantidad.Text = ""
        Me.bsaListarUnidadCantidad.ToolTipImage = Nothing
        Me.bsaListarUnidadCantidad.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaListarUnidadCantidad.UniqueName = "33BE470ED3D044A133BE470ED3D044A1"
        '
        'lblUnidadCantidad
        '
        Me.lblUnidadCantidad.Location = New System.Drawing.Point(213, 94)
        Me.lblUnidadCantidad.Name = "lblUnidadCantidad"
        Me.lblUnidadCantidad.Size = New System.Drawing.Size(56, 20)
        Me.lblUnidadCantidad.TabIndex = 56
        Me.lblUnidadCantidad.Text = "Unidad : "
        Me.lblUnidadCantidad.Values.ExtraText = ""
        Me.lblUnidadCantidad.Values.Image = Nothing
        Me.lblUnidadCantidad.Values.Text = "Unidad : "
        '
        'dgContratosVigentes
        '
        Me.dgContratosVigentes.AllowUserToAddRows = False
        Me.dgContratosVigentes.AllowUserToDeleteRows = False
        Me.dgContratosVigentes.AllowUserToResizeColumns = False
        Me.dgContratosVigentes.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LemonChiffon
        Me.dgContratosVigentes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgContratosVigentes.AutoGenerateColumns = False
        Me.dgContratosVigentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgContratosVigentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.M_NCNTR, Me.M_CTPDP3, Me.M_TABDPS, Me.M_CTPPR1, Me.M_CUNCN3, Me.M_CUNPS3, Me.M_CUNVL3})
        Me.dgContratosVigentes.DataMember = "dtContratos"
        Me.dgContratosVigentes.DataSource = Me.dstContratos
        Me.dgContratosVigentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgContratosVigentes.Location = New System.Drawing.Point(0, 0)
        Me.dgContratosVigentes.MultiSelect = False
        Me.dgContratosVigentes.Name = "dgContratosVigentes"
        Me.dgContratosVigentes.ReadOnly = True
        Me.dgContratosVigentes.RowHeadersWidth = 20
        Me.dgContratosVigentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContratosVigentes.Size = New System.Drawing.Size(608, 71)
        Me.dgContratosVigentes.StandardTab = True
        Me.dgContratosVigentes.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.dgContratosVigentes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgContratosVigentes.TabIndex = 53
        '
        'M_NCNTR
        '
        Me.M_NCNTR.DataPropertyName = "NCNTR"
        Me.M_NCNTR.HeaderText = "Contrato"
        Me.M_NCNTR.Name = "M_NCNTR"
        Me.M_NCNTR.ReadOnly = True
        Me.M_NCNTR.Width = 83
        '
        'M_CTPDP3
        '
        Me.M_CTPDP3.DataPropertyName = "CTPDP3"
        Me.M_CTPDP3.HeaderText = "Depósito"
        Me.M_CTPDP3.Name = "M_CTPDP3"
        Me.M_CTPDP3.ReadOnly = True
        Me.M_CTPDP3.Visible = False
        Me.M_CTPDP3.Width = 78
        '
        'M_TABDPS
        '
        Me.M_TABDPS.DataPropertyName = "TABDPS"
        Me.M_TABDPS.HeaderText = "Depósito"
        Me.M_TABDPS.Name = "M_TABDPS"
        Me.M_TABDPS.ReadOnly = True
        Me.M_TABDPS.Width = 83
        '
        'M_CTPPR1
        '
        Me.M_CTPPR1.DataPropertyName = "CTPPR1"
        Me.M_CTPPR1.HeaderText = "Producto"
        Me.M_CTPPR1.Name = "M_CTPPR1"
        Me.M_CTPPR1.ReadOnly = True
        Me.M_CTPPR1.Width = 85
        '
        'M_CUNCN3
        '
        Me.M_CUNCN3.DataPropertyName = "CUNCN3"
        Me.M_CUNCN3.HeaderText = "Unidad Cantidad"
        Me.M_CUNCN3.Name = "M_CUNCN3"
        Me.M_CUNCN3.ReadOnly = True
        Me.M_CUNCN3.Width = 125
        '
        'M_CUNPS3
        '
        Me.M_CUNPS3.DataPropertyName = "CUNPS3"
        Me.M_CUNPS3.HeaderText = "Unidad Peso"
        Me.M_CUNPS3.Name = "M_CUNPS3"
        Me.M_CUNPS3.ReadOnly = True
        Me.M_CUNPS3.Width = 102
        '
        'M_CUNVL3
        '
        Me.M_CUNVL3.DataPropertyName = "CUNVL3"
        Me.M_CUNVL3.HeaderText = "Unidad Valor"
        Me.M_CUNVL3.Name = "M_CUNVL3"
        Me.M_CUNVL3.ReadOnly = True
        Me.M_CUNVL3.Width = 103
        '
        'hgParametrosModificarOS
        '
        Me.hgParametrosModificarOS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.hgParametrosModificarOS.HeaderPositionSecondary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
        Me.hgParametrosModificarOS.HeaderVisibleSecondary = False
        Me.hgParametrosModificarOS.Location = New System.Drawing.Point(0, 311)
        Me.hgParametrosModificarOS.Name = "hgParametrosModificarOS"
        '
        'hgParametrosModificarOS.Panel
        '
        Me.hgParametrosModificarOS.Panel.AutoScroll = True
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.lblOrdenServicio)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel12)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.cbxControlDespacho_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.btnCancelarModificarOS)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.btnActualizarModificarOS)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.cbxControlLote_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtValor_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel4)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtUnidadValor_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel7)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtPeso_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel8)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtCantidad_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel9)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtUnidadPeso_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel10)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.txtUnidadCantidad_M)
        Me.hgParametrosModificarOS.Panel.Controls.Add(Me.KryptonLabel11)
        Me.hgParametrosModificarOS.Size = New System.Drawing.Size(610, 19)
        Me.hgParametrosModificarOS.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.hgParametrosModificarOS.TabIndex = 51
        Me.hgParametrosModificarOS.Text = "Modificar O/S"
        Me.hgParametrosModificarOS.ValuesPrimary.Description = ""
        Me.hgParametrosModificarOS.ValuesPrimary.Heading = "Modificar O/S"
        Me.hgParametrosModificarOS.ValuesPrimary.Image = Nothing
        Me.hgParametrosModificarOS.ValuesSecondary.Description = ""
        Me.hgParametrosModificarOS.ValuesSecondary.Heading = "Description"
        Me.hgParametrosModificarOS.ValuesSecondary.Image = Nothing
        Me.hgParametrosModificarOS.Visible = False
        '
        'lblOrdenServicio
        '
        Me.lblOrdenServicio.Location = New System.Drawing.Point(275, 173)
        Me.lblOrdenServicio.Name = "lblOrdenServicio"
        Me.lblOrdenServicio.Size = New System.Drawing.Size(16, 20)
        Me.lblOrdenServicio.TabIndex = 89
        Me.lblOrdenServicio.Text = "?"
        Me.lblOrdenServicio.Values.ExtraText = ""
        Me.lblOrdenServicio.Values.Image = Nothing
        Me.lblOrdenServicio.Values.Text = "?"
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(40, 173)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(244, 20)
        Me.KryptonLabel12.TabIndex = 88
        Me.KryptonLabel12.Text = "Se esta Modificando los Valores de la O/S :"
        Me.KryptonLabel12.Values.ExtraText = ""
        Me.KryptonLabel12.Values.Image = Nothing
        Me.KryptonLabel12.Values.Text = "Se esta Modificando los Valores de la O/S :"
        '
        'cbxControlDespacho_M
        '
        Me.cbxControlDespacho_M.FormattingEnabled = True
        Me.cbxControlDespacho_M.Items.AddRange(New Object() {"C", "P"})
        Me.cbxControlDespacho_M.Location = New System.Drawing.Point(108, 96)
        Me.cbxControlDespacho_M.Name = "cbxControlDespacho_M"
        Me.cbxControlDespacho_M.Size = New System.Drawing.Size(42, 21)
        Me.cbxControlDespacho_M.TabIndex = 84
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(40, 101)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel2.TabIndex = 83
        Me.KryptonLabel2.Text = "Unid. Desp:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Unid. Desp:"
        '
        'btnCancelarModificarOS
        '
        Me.btnCancelarModificarOS.Location = New System.Drawing.Point(271, 133)
        Me.btnCancelarModificarOS.Name = "btnCancelarModificarOS"
        Me.btnCancelarModificarOS.Size = New System.Drawing.Size(100, 25)
        Me.btnCancelarModificarOS.TabIndex = 87
        Me.btnCancelarModificarOS.Text = "Cancelar"
        Me.btnCancelarModificarOS.Values.ExtraText = ""
        Me.btnCancelarModificarOS.Values.Image = CType(resources.GetObject("btnCancelarModificarOS.Values.Image"), System.Drawing.Image)
        Me.btnCancelarModificarOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelarModificarOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelarModificarOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelarModificarOS.Values.Text = "Cancelar"
        '
        'btnActualizarModificarOS
        '
        Me.btnActualizarModificarOS.Location = New System.Drawing.Point(153, 133)
        Me.btnActualizarModificarOS.Name = "btnActualizarModificarOS"
        Me.btnActualizarModificarOS.Size = New System.Drawing.Size(100, 25)
        Me.btnActualizarModificarOS.TabIndex = 86
        Me.btnActualizarModificarOS.Text = "Actualizar"
        Me.btnActualizarModificarOS.Values.ExtraText = ""
        Me.btnActualizarModificarOS.Values.Image = CType(resources.GetObject("btnActualizarModificarOS.Values.Image"), System.Drawing.Image)
        Me.btnActualizarModificarOS.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizarModificarOS.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizarModificarOS.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizarModificarOS.Values.Text = "Actualizar"
        '
        'cbxControlLote_M
        '
        Me.cbxControlLote_M.Checked = False
        Me.cbxControlLote_M.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.cbxControlLote_M.Enabled = False
        Me.cbxControlLote_M.Location = New System.Drawing.Point(220, 101)
        Me.cbxControlLote_M.Name = "cbxControlLote_M"
        Me.cbxControlLote_M.Size = New System.Drawing.Size(113, 20)
        Me.cbxControlLote_M.TabIndex = 85
        Me.cbxControlLote_M.Text = "Control por Lote"
        Me.cbxControlLote_M.Values.ExtraText = ""
        Me.cbxControlLote_M.Values.Image = Nothing
        Me.cbxControlLote_M.Values.Text = "Control por Lote"
        '
        'txtValor_M
        '
        Me.txtValor_M.Location = New System.Drawing.Point(108, 71)
        Me.txtValor_M.Name = "txtValor_M"
        Me.txtValor_M.Size = New System.Drawing.Size(88, 22)
        Me.txtValor_M.TabIndex = 80
        Me.txtValor_M.Text = "0.00"
        Me.txtValor_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(40, 74)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel4.TabIndex = 79
        Me.KryptonLabel4.Text = "Valor : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Valor : "
        '
        'txtUnidadValor_M
        '
        Me.txtUnidadValor_M.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny2})
        Me.txtUnidadValor_M.Location = New System.Drawing.Point(271, 71)
        Me.txtUnidadValor_M.MaxLength = 10
        Me.txtUnidadValor_M.Name = "txtUnidadValor_M"
        Me.txtUnidadValor_M.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadValor_M.TabIndex = 82
        Me.txtUnidadValor_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonSpecAny2
        '
        Me.ButtonSpecAny2.ExtraText = ""
        Me.ButtonSpecAny2.Image = Nothing
        Me.ButtonSpecAny2.Text = ""
        Me.ButtonSpecAny2.ToolTipImage = Nothing
        Me.ButtonSpecAny2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny2.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(213, 74)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel7.TabIndex = 81
        Me.KryptonLabel7.Text = "Unidad :"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Unidad :"
        '
        'txtPeso_M
        '
        Me.txtPeso_M.Location = New System.Drawing.Point(108, 46)
        Me.txtPeso_M.Name = "txtPeso_M"
        Me.txtPeso_M.Size = New System.Drawing.Size(88, 22)
        Me.txtPeso_M.TabIndex = 76
        Me.txtPeso_M.Text = "0.00"
        Me.txtPeso_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(40, 49)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel8.TabIndex = 75
        Me.KryptonLabel8.Text = "Peso : "
        Me.KryptonLabel8.Values.ExtraText = ""
        Me.KryptonLabel8.Values.Image = Nothing
        Me.KryptonLabel8.Values.Text = "Peso : "
        '
        'txtCantidad_M
        '
        Me.txtCantidad_M.Location = New System.Drawing.Point(108, 21)
        Me.txtCantidad_M.Name = "txtCantidad_M"
        Me.txtCantidad_M.Size = New System.Drawing.Size(88, 22)
        Me.txtCantidad_M.TabIndex = 72
        Me.txtCantidad_M.Text = "0.00"
        Me.txtCantidad_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(40, 24)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel9.TabIndex = 71
        Me.KryptonLabel9.Text = "Cantidad : "
        Me.KryptonLabel9.Values.ExtraText = ""
        Me.KryptonLabel9.Values.Image = Nothing
        Me.KryptonLabel9.Values.Text = "Cantidad : "
        '
        'txtUnidadPeso_M
        '
        Me.txtUnidadPeso_M.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny3})
        Me.txtUnidadPeso_M.Location = New System.Drawing.Point(271, 46)
        Me.txtUnidadPeso_M.MaxLength = 10
        Me.txtUnidadPeso_M.Name = "txtUnidadPeso_M"
        Me.txtUnidadPeso_M.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadPeso_M.TabIndex = 78
        Me.txtUnidadPeso_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonSpecAny3
        '
        Me.ButtonSpecAny3.ExtraText = ""
        Me.ButtonSpecAny3.Image = Nothing
        Me.ButtonSpecAny3.Text = ""
        Me.ButtonSpecAny3.ToolTipImage = Nothing
        Me.ButtonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny3.UniqueName = "2D4EDDA325914A122D4EDDA325914A12"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(213, 49)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel10.TabIndex = 77
        Me.KryptonLabel10.Text = "Unidad :"
        Me.KryptonLabel10.Values.ExtraText = ""
        Me.KryptonLabel10.Values.Image = Nothing
        Me.KryptonLabel10.Values.Text = "Unidad :"
        '
        'txtUnidadCantidad_M
        '
        Me.txtUnidadCantidad_M.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.ButtonSpecAny4})
        Me.txtUnidadCantidad_M.Location = New System.Drawing.Point(271, 21)
        Me.txtUnidadCantidad_M.MaxLength = 10
        Me.txtUnidadCantidad_M.Name = "txtUnidadCantidad_M"
        Me.txtUnidadCantidad_M.Size = New System.Drawing.Size(100, 22)
        Me.txtUnidadCantidad_M.TabIndex = 74
        Me.txtUnidadCantidad_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonSpecAny4
        '
        Me.ButtonSpecAny4.ExtraText = ""
        Me.ButtonSpecAny4.Image = Nothing
        Me.ButtonSpecAny4.Text = ""
        Me.ButtonSpecAny4.ToolTipImage = Nothing
        Me.ButtonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.ButtonSpecAny4.UniqueName = "33BE470ED3D044A133BE470ED3D044A1"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(213, 24)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel11.TabIndex = 73
        Me.KryptonLabel11.Text = "Unidad : "
        Me.KryptonLabel11.Values.ExtraText = ""
        Me.KryptonLabel11.Values.Image = Nothing
        Me.KryptonLabel11.Values.Text = "Unidad : "
        '
        'frmOrdenServicioSDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 361)
        Me.Controls.Add(Me.hgOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOrdenServicioSDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Nueva O/S"
        CType(Me.dstContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrdenServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.Panel.ResumeLayout(False)
        CType(Me.hgOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgOS.ResumeLayout(False)
        CType(Me.dgListaOrdenesServicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgParametrosCrearOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosCrearOS.Panel.ResumeLayout(False)
        Me.hgParametrosCrearOS.Panel.PerformLayout()
        CType(Me.hgParametrosCrearOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosCrearOS.ResumeLayout(False)
        CType(Me.dgContratosVigentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgParametrosModificarOS.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosModificarOS.Panel.ResumeLayout(False)
        Me.hgParametrosModificarOS.Panel.PerformLayout()
        CType(Me.hgParametrosModificarOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgParametrosModificarOS.ResumeLayout(False)
        Me.ResumeLayout(False)

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
  Friend WithEvents dstContratos As System.Data.DataSet
  Friend WithEvents dtContratos As System.Data.DataTable
  Friend WithEvents NCNTR As System.Data.DataColumn
  Friend WithEvents CTPDP3 As System.Data.DataColumn
  Friend WithEvents TABDPS As System.Data.DataColumn
  Friend WithEvents CTPPR1 As System.Data.DataColumn
  Friend WithEvents CUNCN3 As System.Data.DataColumn
  Friend WithEvents CUNPS3 As System.Data.DataColumn
  Friend WithEvents CUNVL3 As System.Data.DataColumn
  Friend WithEvents dstOrdenServicio As System.Data.DataSet
  Friend WithEvents dtOrdenServicio As System.Data.DataTable
  Friend WithEvents ONORDSR As System.Data.DataColumn
  Friend WithEvents ONCNTR As System.Data.DataColumn
  Friend WithEvents ONCRCTC As System.Data.DataColumn
  Friend WithEvents ONAUTR As System.Data.DataColumn
  Friend WithEvents OFEMORS As System.Data.DataColumn
  Friend WithEvents OCTPDP6 As System.Data.DataColumn
  Friend WithEvents OQSLMC As System.Data.DataColumn
  Friend WithEvents OCUNCN5 As System.Data.DataColumn
  Friend WithEvents OQSLMP As System.Data.DataColumn
  Friend WithEvents OCUNPS5 As System.Data.DataColumn
  Friend WithEvents OQSLMV As System.Data.DataColumn
  Friend WithEvents OCUNVL5 As System.Data.DataColumn
  Friend WithEvents OFUNDS2 As System.Data.DataColumn
  Friend WithEvents OFUNCTL As System.Data.DataColumn
  Friend WithEvents OQMRCD1 As System.Data.DataColumn
  Friend WithEvents OQPSMR1 As System.Data.DataColumn
  Friend WithEvents OQVLMR1 As System.Data.DataColumn
  Friend WithEvents hgOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents bsaCrearOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents bsaModificarOS As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents bsaCancelar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
  Friend WithEvents dgListaOrdenesServicio As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents O_NORDSR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_NCRCTC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_NAUTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_FEMORS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_CTPDP6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_QSLMC As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_CUNCN5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_QSLMP As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_CUNPS5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_QSLMV As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_CUNVL5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_FUNDS2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_FUNCTL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_QMRCD1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_QPSMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents O_QVLMR1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents hgParametrosCrearOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents cbxUnidadDespacho As System.Windows.Forms.ComboBox
  Friend WithEvents lblUnidadDespacho As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnCancelarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents btnProcesarCrearOS As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents cbxControlLote As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents txtValor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblValor As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUnidadValor As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents ButtonSpecAny1 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents lblUnidadValor As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents lblCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaListarUnidadPeso As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents lblUnidadPeso As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUnidadCantidad As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents bsaListarUnidadCantidad As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents lblUnidadCantidad As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents dgContratosVigentes As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
  Friend WithEvents M_NCNTR As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents M_CTPDP3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents M_TABDPS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents M_CTPPR1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents M_CUNCN3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents M_CUNPS3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents M_CUNVL3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents hgParametrosModificarOS As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents lblOrdenServicio As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cbxControlDespacho_M As System.Windows.Forms.ComboBox
  Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents btnCancelarModificarOS As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents btnActualizarModificarOS As ComponentFactory.Krypton.Toolkit.KryptonButton
  Friend WithEvents cbxControlLote_M As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
  Friend WithEvents txtValor_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUnidadValor_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents ButtonSpecAny2 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtPeso_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtCantidad_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUnidadPeso_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents ButtonSpecAny3 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents txtUnidadCantidad_M As ComponentFactory.Krypton.Toolkit.KryptonTextBox
  Friend WithEvents ButtonSpecAny4 As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
  Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
