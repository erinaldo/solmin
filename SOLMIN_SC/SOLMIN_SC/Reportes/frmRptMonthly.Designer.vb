<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMonthly
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.VisorRep = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboEstado = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboCheckPoint = New System.Windows.Forms.ComboBox
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker
        Me.cboTipoOperacion = New System.Windows.Forms.ComboBox
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblBusqueda = New System.Windows.Forms.Label
        Me.pbxBuscar = New System.Windows.Forms.PictureBox
        Me.KryptonLabel24 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCompania = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblRegimen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.oDs = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn66 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn60 = New System.Data.DataColumn
        Me.DataColumn61 = New System.Data.DataColumn
        Me.DataColumn62 = New System.Data.DataColumn
        Me.DataColumn63 = New System.Data.DataColumn
        Me.DataColumn64 = New System.Data.DataColumn
        Me.DataColumn58 = New System.Data.DataColumn
        Me.DataColumn59 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn65 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn67 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn68 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn69 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataTable5 = New System.Data.DataTable
        Me.DataColumn47 = New System.Data.DataColumn
        Me.DataColumn48 = New System.Data.DataColumn
        Me.DataColumn70 = New System.Data.DataColumn
        Me.DataColumn49 = New System.Data.DataColumn
        Me.DataColumn50 = New System.Data.DataColumn
        Me.DataColumn51 = New System.Data.DataColumn
        Me.DataColumn52 = New System.Data.DataColumn
        Me.DataColumn53 = New System.Data.DataColumn
        Me.DataColumn54 = New System.Data.DataColumn
        Me.DataColumn55 = New System.Data.DataColumn
        Me.DataColumn56 = New System.Data.DataColumn
        Me.DataColumn57 = New System.Data.DataColumn
        Me.bgwProcesoReport = New System.ComponentModel.BackgroundWorker
        Me.chkRegimen = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.TabControl1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1056, 588)
        Me.KryptonPanel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 140)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1056, 448)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.VisorRep)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1048, 422)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Resultado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'VisorRep
        '
        Me.VisorRep.ActiveViewIndex = -1
        Me.VisorRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorRep.DisplayGroupTree = False
        Me.VisorRep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorRep.Location = New System.Drawing.Point(3, 3)
        Me.VisorRep.Name = "VisorRep"
        Me.VisorRep.SelectionFormula = ""
        Me.VisorRep.Size = New System.Drawing.Size(1042, 416)
        Me.VisorRep.TabIndex = 13
        Me.VisorRep.ViewTimeSelectionFormula = ""
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscar, Me.ToolStripSeparator1, Me.btnExportar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 115)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1056, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.search
        Me.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(61, 22)
        Me.btnBuscar.Text = "Buscar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExportar.Image = Global.SOLMIN_SC.My.Resources.Resources.excelicon
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(70, 22)
        Me.btnExportar.Text = "Exportar"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.AutoScroll = True
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboEstado)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboTipoOperacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblBusqueda)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.pbxBuscar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel24)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chkRegimen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblRegimen)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1056, 115)
        Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 2
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(340, 33)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(46, 19)
        Me.KryptonLabel5.TabIndex = 88
        Me.KryptonLabel5.Text = "Estado:"
        Me.KryptonLabel5.Values.ExtraText = ""
        Me.KryptonLabel5.Values.Image = Nothing
        Me.KryptonLabel5.Values.Text = "Estado:"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(392, 31)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(126, 21)
        Me.cboEstado.TabIndex = 89
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.KryptonLabel3)
        Me.GroupBox1.Controls.Add(Me.cboCheckPoint)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel6)
        Me.GroupBox1.Controls.Add(Me.KryptonLabel7)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Location = New System.Drawing.Point(524, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 65)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(6, 14)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(61, 19)
        Me.KryptonLabel3.TabIndex = 83
        Me.KryptonLabel3.Text = "Fecha Ref:"
        Me.KryptonLabel3.Values.ExtraText = ""
        Me.KryptonLabel3.Values.Image = Nothing
        Me.KryptonLabel3.Values.Text = "Fecha Ref:"
        '
        'cboCheckPoint
        '
        Me.cboCheckPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCheckPoint.FormattingEnabled = True
        Me.cboCheckPoint.Location = New System.Drawing.Point(75, 12)
        Me.cboCheckPoint.Name = "cboCheckPoint"
        Me.cboCheckPoint.Size = New System.Drawing.Size(227, 21)
        Me.cboCheckPoint.TabIndex = 84
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(9, 39)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(39, 19)
        Me.KryptonLabel6.TabIndex = 48
        Me.KryptonLabel6.Text = "Inicio:"
        Me.KryptonLabel6.Values.ExtraText = ""
        Me.KryptonLabel6.Values.Image = Nothing
        Me.KryptonLabel6.Values.Text = "Inicio:"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(174, 39)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(27, 19)
        Me.KryptonLabel7.TabIndex = 49
        Me.KryptonLabel7.Text = "Fin:"
        Me.KryptonLabel7.Values.ExtraText = ""
        Me.KryptonLabel7.Values.Image = Nothing
        Me.KryptonLabel7.Values.Text = "Fin:"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecFin.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpFecFin.CustomFormat = "MM/yyyy"
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(211, 39)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecFin.TabIndex = 13
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecIni.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpFecIni.CustomFormat = "MM/yyyy"
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(75, 39)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(93, 20)
        Me.dtpFecIni.TabIndex = 5
        '
        'cboTipoOperacion
        '
        Me.cboTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoOperacion.FormattingEnabled = True
        Me.cboTipoOperacion.Location = New System.Drawing.Point(392, 5)
        Me.cboTipoOperacion.Name = "cboTipoOperacion"
        Me.cboTipoOperacion.Size = New System.Drawing.Size(126, 21)
        Me.cboTipoOperacion.TabIndex = 84
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(348, 7)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(38, 19)
        Me.KryptonLabel4.TabIndex = 83
        Me.KryptonLabel4.Text = "Tipo :"
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Tipo :"
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqueda.Location = New System.Drawing.Point(885, 62)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(48, 13)
        Me.lblBusqueda.TabIndex = 82
        Me.lblBusqueda.Text = "Consulta"
        '
        'pbxBuscar
        '
        Me.pbxBuscar.BackColor = System.Drawing.Color.Transparent
        Me.pbxBuscar.Image = Global.SOLMIN_SC.My.Resources.Resources.mozilla_blu
        Me.pbxBuscar.Location = New System.Drawing.Point(855, 57)
        Me.pbxBuscar.Name = "pbxBuscar"
        Me.pbxBuscar.Size = New System.Drawing.Size(24, 21)
        Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxBuscar.TabIndex = 81
        Me.pbxBuscar.TabStop = False
        '
        'KryptonLabel24
        '
        Me.KryptonLabel24.Location = New System.Drawing.Point(9, 7)
        Me.KryptonLabel24.Name = "KryptonLabel24"
        Me.KryptonLabel24.Size = New System.Drawing.Size(63, 19)
        Me.KryptonLabel24.TabIndex = 52
        Me.KryptonLabel24.Text = "Compañía:"
        Me.KryptonLabel24.Values.ExtraText = ""
        Me.KryptonLabel24.Values.Image = Nothing
        Me.KryptonLabel24.Values.Text = "Compañía:"
        '
        'cmbCompania
        '
        Me.cmbCompania.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCompania.CCMPN_ANTERIOR = Nothing
        Me.cmbCompania.CCMPN_CodigoCompania = Nothing
        Me.cmbCompania.CCMPN_CompaniaDefault = Nothing
        Me.cmbCompania.CCMPN_Descripcion = Nothing
        Me.cmbCompania.Location = New System.Drawing.Point(82, 3)
        Me.cmbCompania.MinimumSize = New System.Drawing.Size(150, 23)
        Me.cmbCompania.Name = "cmbCompania"
        Me.cmbCompania.Size = New System.Drawing.Size(252, 23)
        Me.cmbCompania.TabIndex = 51
        Me.cmbCompania.Usuario = ""
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(9, 33)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 19)
        Me.lblCliente.TabIndex = 45
        Me.lblCliente.Text = "Cliente:"
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente:"
        '
        'lblRegimen
        '
        Me.lblRegimen.Location = New System.Drawing.Point(9, 61)
        Me.lblRegimen.Name = "lblRegimen"
        Me.lblRegimen.Size = New System.Drawing.Size(57, 19)
        Me.lblRegimen.TabIndex = 43
        Me.lblRegimen.Text = "Régimen:"
        Me.lblRegimen.Values.ExtraText = ""
        Me.lblRegimen.Values.Image = Nothing
        Me.lblRegimen.Values.Text = "Régimen:"
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
        Me.cmbCliente.CCMPN = "EZ"
        Me.cmbCliente.Location = New System.Drawing.Point(82, 31)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.cmbCliente.Size = New System.Drawing.Size(252, 21)
        Me.cmbCliente.TabIndex = 40
        '
        'oDs
        '
        Me.oDs.DataSetName = "NewDataSet"
        Me.oDs.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2, Me.DataTable3, Me.DataTable4, Me.DataTable5})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn66, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn11, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn58, Me.DataColumn59, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn65, Me.DataColumn10})
        Me.DataTable1.TableName = "dtOperacion"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "REFERENCIA O/C"
        Me.DataColumn1.ColumnName = "NORCML"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "O/S"
        Me.DataColumn2.ColumnName = "PNNMOS"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "REGIMEN"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "TIPO DE DESPACHO"
        Me.DataColumn3.ColumnName = "TDSCRG"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "PESO KG."
        Me.DataColumn4.ColumnName = "QPSOAR"
        Me.DataColumn4.DataType = GetType(Double)
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "FOB US$"
        Me.DataColumn5.ColumnName = "IVFOBD"
        Me.DataColumn5.DataType = GetType(Double)
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "FLETE US$"
        Me.DataColumn11.ColumnName = "VALFLT"
        Me.DataColumn11.DataType = GetType(Double)
        '
        'DataColumn60
        '
        Me.DataColumn60.Caption = "SEGURO US$"
        Me.DataColumn60.ColumnName = "VALSEG"
        Me.DataColumn60.DataType = GetType(Double)
        '
        'DataColumn61
        '
        Me.DataColumn61.Caption = "CIF US$"
        Me.DataColumn61.ColumnName = "IMPCIF"
        Me.DataColumn61.DataType = GetType(Double)
        '
        'DataColumn62
        '
        Me.DataColumn62.Caption = "ADVALOREM US$"
        Me.DataColumn62.ColumnName = "VALADV"
        Me.DataColumn62.DataType = GetType(Double)
        '
        'DataColumn63
        '
        Me.DataColumn63.Caption = "IGV + IPM US$"
        Me.DataColumn63.ColumnName = "IIGVPM"
        Me.DataColumn63.DataType = GetType(Double)
        '
        'DataColumn64
        '
        Me.DataColumn64.Caption = "OTROS GASTOS US$"
        Me.DataColumn64.ColumnName = "VALOGS"
        Me.DataColumn64.DataType = GetType(Double)
        '
        'DataColumn58
        '
        Me.DataColumn58.Caption = "TOTAL FOB US$"
        Me.DataColumn58.ColumnName = "ITTFOB"
        Me.DataColumn58.DataType = GetType(Double)
        '
        'DataColumn59
        '
        Me.DataColumn59.Caption = "TOTAL FLETE US$"
        Me.DataColumn59.ColumnName = "IVLFLT"
        Me.DataColumn59.DataType = GetType(Double)
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "TOTAL SEGURO US$"
        Me.DataColumn6.ColumnName = "IVLSGR"
        Me.DataColumn6.DataType = GetType(Double)
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "TOTAL CIF US$"
        Me.DataColumn7.ColumnName = "ITTCIF"
        Me.DataColumn7.DataType = GetType(Double)
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "TOTAL ADVALOREM US$"
        Me.DataColumn8.ColumnName = "ITTADV"
        Me.DataColumn8.DataType = GetType(Double)
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "TOTAL IGV + IPM US$"
        Me.DataColumn9.ColumnName = "IGVIPM"
        Me.DataColumn9.DataType = GetType(Double)
        '
        'DataColumn65
        '
        Me.DataColumn65.Caption = "TOTAL OTROS GASTOS US$"
        Me.DataColumn65.ColumnName = "ITTOGS"
        Me.DataColumn65.DataType = GetType(Double)
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "TOTAL DERECHOS US$"
        Me.DataColumn10.ColumnName = "TOTAL"
        Me.DataColumn10.DataType = GetType(Double)
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn12, Me.DataColumn13, Me.DataColumn67, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19})
        Me.DataTable2.TableName = "dtFactAduana"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "REFERENCIA O/C"
        Me.DataColumn12.ColumnName = "NORCML"
        '
        'DataColumn13
        '
        Me.DataColumn13.Caption = "O/S"
        Me.DataColumn13.ColumnName = "NORDSR"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "REGIMEN"
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "TIPO DE DESPACHO"
        Me.DataColumn14.ColumnName = "TDSCRG"
        '
        'DataColumn15
        '
        Me.DataColumn15.Caption = "AVISO DE DEBITO US$"
        Me.DataColumn15.ColumnName = "DEVITO"
        Me.DataColumn15.DataType = GetType(Double)
        '
        'DataColumn16
        '
        Me.DataColumn16.Caption = "GASTOS VARIOS"
        Me.DataColumn16.ColumnName = "GSTVAR"
        Me.DataColumn16.DataType = GetType(Double)
        '
        'DataColumn17
        '
        Me.DataColumn17.Caption = "COMISION US$"
        Me.DataColumn17.ColumnName = "COMISI"
        Me.DataColumn17.DataType = GetType(Double)
        '
        'DataColumn18
        '
        Me.DataColumn18.Caption = "OTROS US$"
        Me.DataColumn18.ColumnName = "OTROS"
        Me.DataColumn18.DataType = GetType(Double)
        '
        'DataColumn19
        '
        Me.DataColumn19.Caption = "TOTAL FACTURA US$"
        Me.DataColumn19.ColumnName = "TOTAL"
        Me.DataColumn19.DataType = GetType(Double)
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn68, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.DataTable3.TableName = "dtAvisoDebito"
        '
        'DataColumn20
        '
        Me.DataColumn20.Caption = "REFERENCIA O/C"
        Me.DataColumn20.ColumnName = "NORCML"
        '
        'DataColumn21
        '
        Me.DataColumn21.Caption = "O/S"
        Me.DataColumn21.ColumnName = "NORDSR"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "REGIMEN"
        '
        'DataColumn22
        '
        Me.DataColumn22.Caption = "TIPO DE DESPACHO"
        Me.DataColumn22.ColumnName = "TDSCRG"
        '
        'DataColumn23
        '
        Me.DataColumn23.Caption = "COD."
        Me.DataColumn23.ColumnName = "CSRVRL"
        '
        'DataColumn24
        '
        Me.DataColumn24.Caption = "SERVICIO"
        Me.DataColumn24.ColumnName = "TCMTRF"
        '
        'DataColumn25
        '
        Me.DataColumn25.Caption = "MONTO US$"
        Me.DataColumn25.ColumnName = "MONTO"
        Me.DataColumn25.DataType = GetType(Double)
        '
        'DataColumn26
        '
        Me.DataColumn26.Caption = "TIPO DOC."
        Me.DataColumn26.ColumnName = "TABTPD"
        '
        'DataColumn27
        '
        Me.DataColumn27.Caption = "NRO. DOC."
        Me.DataColumn27.ColumnName = "NDCCT1"
        '
        'DataColumn28
        '
        Me.DataColumn28.Caption = "FECHA DOC."
        Me.DataColumn28.ColumnName = "FDCCT1"
        '
        'DataColumn29
        '
        Me.DataColumn29.Caption = "PROVEEDOR"
        Me.DataColumn29.ColumnName = "NOMPRO"
        '
        'DataColumn30
        '
        Me.DataColumn30.Caption = "TOTAL DEBITO US$"
        Me.DataColumn30.ColumnName = "TOTDEB"
        Me.DataColumn30.DataType = GetType(Double)
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn69, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46})
        Me.DataTable4.TableName = "dtTiempoEntrega"
        '
        'DataColumn31
        '
        Me.DataColumn31.Caption = "REFERENCIA O/C"
        Me.DataColumn31.ColumnName = "NORCML"
        '
        'DataColumn32
        '
        Me.DataColumn32.Caption = "O/S"
        Me.DataColumn32.ColumnName = "PNNMOS"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "REGIMEN"
        '
        'DataColumn33
        '
        Me.DataColumn33.Caption = "TRANSPORTE"
        Me.DataColumn33.ColumnName = "TNMMDT"
        '
        'DataColumn34
        '
        Me.DataColumn34.Caption = "ORIGEN"
        Me.DataColumn34.ColumnName = "TCMPPS"
        '
        'DataColumn35
        '
        Me.DataColumn35.Caption = "VENDOR"
        Me.DataColumn35.ColumnName = "TNMAGC"
        '
        'DataColumn36
        '
        Me.DataColumn36.Caption = "VESSEL"
        Me.DataColumn36.ColumnName = "TCMPVP"
        '
        'DataColumn37
        '
        Me.DataColumn37.Caption = "CANTIDAD"
        Me.DataColumn37.ColumnName = "QCANTI"
        Me.DataColumn37.DataType = GetType(Double)
        '
        'DataColumn38
        '
        Me.DataColumn38.Caption = "TIPO DE CARGA"
        Me.DataColumn38.ColumnName = "TDSCRG"
        '
        'DataColumn39
        '
        Me.DataColumn39.Caption = "PESO KG."
        Me.DataColumn39.ColumnName = "QPSOAR"
        Me.DataColumn39.DataType = GetType(Double)
        '
        'DataColumn40
        '
        Me.DataColumn40.Caption = "ETA"
        Me.DataColumn40.ColumnName = "FAPRAR"
        '
        'DataColumn41
        '
        Me.DataColumn41.Caption = "FACTURA"
        Me.DataColumn41.ColumnName = "FECFAC"
        '
        'DataColumn42
        '
        Me.DataColumn42.Caption = "DOC. EMB."
        Me.DataColumn42.ColumnName = "FECDOC"
        '
        'DataColumn43
        '
        Me.DataColumn43.Caption = "TRADUCCION"
        Me.DataColumn43.ColumnName = "FECTRA"
        '
        'DataColumn44
        '
        Me.DataColumn44.Caption = "DIAS UTILES ANTES DE ETA-FACTURA"
        Me.DataColumn44.ColumnName = "DIAFAC"
        Me.DataColumn44.DataType = GetType(Integer)
        '
        'DataColumn45
        '
        Me.DataColumn45.Caption = "DIAS UTILES ANTES DE ETA- DIAS UTILES DOC. EMB."
        Me.DataColumn45.ColumnName = "DIADOC"
        Me.DataColumn45.DataType = GetType(Integer)
        '
        'DataColumn46
        '
        Me.DataColumn46.Caption = "DIAS UTILES ANTES DE ETA- TRADUCCION"
        Me.DataColumn46.ColumnName = "DIATRA"
        Me.DataColumn46.DataType = GetType(Integer)
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn47, Me.DataColumn48, Me.DataColumn70, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57})
        Me.DataTable5.TableName = "dtContenedores"
        '
        'DataColumn47
        '
        Me.DataColumn47.Caption = "REFERENCIA O/C"
        Me.DataColumn47.ColumnName = "NORCML"
        '
        'DataColumn48
        '
        Me.DataColumn48.Caption = "O/S"
        Me.DataColumn48.ColumnName = "PNNMOS"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "REGIMEN"
        '
        'DataColumn49
        '
        Me.DataColumn49.Caption = "ORIGEN"
        Me.DataColumn49.ColumnName = "TCMPPS"
        '
        'DataColumn50
        '
        Me.DataColumn50.Caption = "DOC. EMB."
        Me.DataColumn50.ColumnName = "NDOCEM"
        '
        'DataColumn51
        '
        Me.DataColumn51.Caption = "PROVEEDOR"
        Me.DataColumn51.ColumnName = "TPRCL1"
        '
        'DataColumn52
        '
        Me.DataColumn52.Caption = "NAVE"
        Me.DataColumn52.ColumnName = "TCMPVP"
        '
        'DataColumn53
        '
        Me.DataColumn53.Caption = "LINEA NAVIERA"
        Me.DataColumn53.ColumnName = "TNMCIN"
        '
        'DataColumn54
        '
        Me.DataColumn54.Caption = "CANTIDAD"
        Me.DataColumn54.ColumnName = "QCANTI"
        Me.DataColumn54.DataType = GetType(Integer)
        '
        'DataColumn55
        '
        Me.DataColumn55.Caption = "TIPO DE CARGA"
        Me.DataColumn55.ColumnName = "TDSCRG"
        '
        'DataColumn56
        '
        Me.DataColumn56.Caption = "PESO KG."
        Me.DataColumn56.ColumnName = "QPSOAR"
        Me.DataColumn56.DataType = GetType(Double)
        '
        'DataColumn57
        '
        Me.DataColumn57.Caption = "ETA"
        Me.DataColumn57.ColumnName = "FAPRAR"
        '
        'bgwProcesoReport
        '
        '
        'chkRegimen
        '
        Me.chkRegimen.CheckOnClick = True
        Me.chkRegimen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.chkRegimen.DropDownHeight = 1
        Me.chkRegimen.FormattingEnabled = True
        Me.chkRegimen.IntegralHeight = False
        Me.chkRegimen.Location = New System.Drawing.Point(82, 59)
        Me.chkRegimen.Name = "chkRegimen"
        Me.chkRegimen.Size = New System.Drawing.Size(436, 21)
        Me.chkRegimen.TabIndex = 44
        Me.chkRegimen.ValueSeparator = ", "
        '
        'frmRptMonthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 588)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRptMonthly"
        Me.Text = "Monthly Report"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
  Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents chkRegimen As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
  Friend WithEvents lblRegimen As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
  Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents KryptonLabel24 As ComponentFactory.Krypton.Toolkit.KryptonLabel
  Friend WithEvents cmbCompania As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
  Friend WithEvents oDs As System.Data.DataSet
  Friend WithEvents DataTable1 As System.Data.DataTable
  Friend WithEvents DataColumn1 As System.Data.DataColumn
  Friend WithEvents DataColumn2 As System.Data.DataColumn
  Friend WithEvents DataColumn66 As System.Data.DataColumn
  Friend WithEvents DataColumn3 As System.Data.DataColumn
  Friend WithEvents DataColumn4 As System.Data.DataColumn
  Friend WithEvents DataColumn5 As System.Data.DataColumn
  Friend WithEvents DataColumn11 As System.Data.DataColumn
  Friend WithEvents DataColumn60 As System.Data.DataColumn
  Friend WithEvents DataColumn61 As System.Data.DataColumn
  Friend WithEvents DataColumn62 As System.Data.DataColumn
  Friend WithEvents DataColumn63 As System.Data.DataColumn
  Friend WithEvents DataColumn64 As System.Data.DataColumn
  Friend WithEvents DataColumn58 As System.Data.DataColumn
  Friend WithEvents DataColumn59 As System.Data.DataColumn
  Friend WithEvents DataColumn6 As System.Data.DataColumn
  Friend WithEvents DataColumn7 As System.Data.DataColumn
  Friend WithEvents DataColumn8 As System.Data.DataColumn
  Friend WithEvents DataColumn9 As System.Data.DataColumn
  Friend WithEvents DataColumn65 As System.Data.DataColumn
  Friend WithEvents DataColumn10 As System.Data.DataColumn
  Friend WithEvents DataTable2 As System.Data.DataTable
  Friend WithEvents DataColumn12 As System.Data.DataColumn
  Friend WithEvents DataColumn13 As System.Data.DataColumn
  Friend WithEvents DataColumn67 As System.Data.DataColumn
  Friend WithEvents DataColumn14 As System.Data.DataColumn
  Friend WithEvents DataColumn15 As System.Data.DataColumn
  Friend WithEvents DataColumn16 As System.Data.DataColumn
  Friend WithEvents DataColumn17 As System.Data.DataColumn
  Friend WithEvents DataColumn18 As System.Data.DataColumn
  Friend WithEvents DataColumn19 As System.Data.DataColumn
  Friend WithEvents DataTable3 As System.Data.DataTable
  Friend WithEvents DataColumn20 As System.Data.DataColumn
  Friend WithEvents DataColumn21 As System.Data.DataColumn
  Friend WithEvents DataColumn68 As System.Data.DataColumn
  Friend WithEvents DataColumn22 As System.Data.DataColumn
  Friend WithEvents DataColumn23 As System.Data.DataColumn
  Friend WithEvents DataColumn24 As System.Data.DataColumn
  Friend WithEvents DataColumn25 As System.Data.DataColumn
  Friend WithEvents DataColumn26 As System.Data.DataColumn
  Friend WithEvents DataColumn27 As System.Data.DataColumn
  Friend WithEvents DataColumn28 As System.Data.DataColumn
  Friend WithEvents DataColumn29 As System.Data.DataColumn
  Friend WithEvents DataColumn30 As System.Data.DataColumn
  Friend WithEvents DataTable4 As System.Data.DataTable
  Friend WithEvents DataColumn31 As System.Data.DataColumn
  Friend WithEvents DataColumn32 As System.Data.DataColumn
  Friend WithEvents DataColumn69 As System.Data.DataColumn
  Friend WithEvents DataColumn33 As System.Data.DataColumn
  Friend WithEvents DataColumn34 As System.Data.DataColumn
  Friend WithEvents DataColumn35 As System.Data.DataColumn
  Friend WithEvents DataColumn36 As System.Data.DataColumn
  Friend WithEvents DataColumn37 As System.Data.DataColumn
  Friend WithEvents DataColumn38 As System.Data.DataColumn
  Friend WithEvents DataColumn39 As System.Data.DataColumn
  Friend WithEvents DataColumn40 As System.Data.DataColumn
  Friend WithEvents DataColumn41 As System.Data.DataColumn
  Friend WithEvents DataColumn42 As System.Data.DataColumn
  Friend WithEvents DataColumn43 As System.Data.DataColumn
  Friend WithEvents DataColumn44 As System.Data.DataColumn
  Friend WithEvents DataColumn45 As System.Data.DataColumn
  Friend WithEvents DataColumn46 As System.Data.DataColumn
  Friend WithEvents DataTable5 As System.Data.DataTable
  Friend WithEvents DataColumn47 As System.Data.DataColumn
  Friend WithEvents DataColumn48 As System.Data.DataColumn
  Friend WithEvents DataColumn70 As System.Data.DataColumn
  Friend WithEvents DataColumn49 As System.Data.DataColumn
  Friend WithEvents DataColumn50 As System.Data.DataColumn
  Friend WithEvents DataColumn51 As System.Data.DataColumn
  Friend WithEvents DataColumn52 As System.Data.DataColumn
  Friend WithEvents DataColumn53 As System.Data.DataColumn
  Friend WithEvents DataColumn54 As System.Data.DataColumn
  Friend WithEvents DataColumn55 As System.Data.DataColumn
  Friend WithEvents DataColumn56 As System.Data.DataColumn
  Friend WithEvents DataColumn57 As System.Data.DataColumn
  Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
  Friend WithEvents VisorRep As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnBuscar As System.Windows.Forms.ToolStripButton
  Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox
  Friend WithEvents lblBusqueda As System.Windows.Forms.Label
  Friend WithEvents bgwProcesoReport As System.ComponentModel.BackgroundWorker
  Friend WithEvents cboTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboCheckPoint As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
