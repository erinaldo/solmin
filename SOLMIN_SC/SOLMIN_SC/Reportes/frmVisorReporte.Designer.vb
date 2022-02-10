<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorReporte
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
    Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carga Internacional", 2, 0)
    Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento Aduanero", 2, 0)
    Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento Aduanero (Resumen)", 2, 0)
    Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estadistico", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
    Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Liquidación de Pagos", 2, 0)
    Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saving ADVALOREM", 2, 0)
    Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3PL Report", 2, 0)
    Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Monthly Report", 2, 0)
    Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otros", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8})
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorReporte))
    Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
    Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.tvwReporte = New System.Windows.Forms.TreeView
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.pbxBuscar = New System.Windows.Forms.PictureBox
    Me.VisorRep = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.KryptonHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ButtonSpecHeaderGroup4 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.txtObservacion = New System.Windows.Forms.TextBox
    Me.KryptonHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ButtonSpecHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.lblCriterio = New System.Windows.Forms.Label
    Me.rdbLevante = New System.Windows.Forms.RadioButton
    Me.rdbETA = New System.Windows.Forms.RadioButton
    Me.pbxEnvio = New System.Windows.Forms.PictureBox
    Me.dtpMesEnvio = New System.Windows.Forms.DateTimePicker
    Me.Label2 = New System.Windows.Forms.Label
    Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Me.ButtonSpecHeaderGroup3 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Me.lblIdioma = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.cboIdioma = New System.Windows.Forms.ComboBox
    Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.chkRegimen = New Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Me.lblRegimen = New ComponentFactory.Krypton.Toolkit.KryptonLabel
    Me.chkTiempo = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Me.cmbCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
    Me.dtpFecFin = New System.Windows.Forms.DateTimePicker
    Me.lblFecFin = New System.Windows.Forms.Label
    Me.txtNroPago = New System.Windows.Forms.TextBox
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.dtpFecIni = New System.Windows.Forms.DateTimePicker
    Me.lblMes = New System.Windows.Forms.Label
    Me.lblOS = New System.Windows.Forms.Label
    Me.txtOS = New System.Windows.Forms.TextBox
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
    CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonSplitContainer1.Panel1.SuspendLayout()
    CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonSplitContainer1.Panel2.SuspendLayout()
    Me.KryptonSplitContainer1.SuspendLayout()
    CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup2.Panel.SuspendLayout()
    Me.KryptonHeaderGroup2.SuspendLayout()
    CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup4.Panel.SuspendLayout()
    Me.KryptonHeaderGroup4.SuspendLayout()
    CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup3.Panel.SuspendLayout()
    Me.KryptonHeaderGroup3.SuspendLayout()
    CType(Me.pbxEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KryptonHeaderGroup1.Panel.SuspendLayout()
    Me.KryptonHeaderGroup1.SuspendLayout()
    CType(Me.oDs, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'KryptonSplitContainer1
    '
    Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
    Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
    '
    'KryptonSplitContainer1.Panel1
    '
    Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonHeaderGroup2)
    '
    'KryptonSplitContainer1.Panel2
    '
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.pbxBuscar)
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.VisorRep)
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup4)
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup3)
    Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonHeaderGroup1)
    Me.KryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighInternalProfile
    Me.KryptonSplitContainer1.Size = New System.Drawing.Size(1001, 663)
    Me.KryptonSplitContainer1.SplitterDistance = 232
    Me.KryptonSplitContainer1.TabIndex = 2
    '
    'KryptonHeaderGroup2
    '
    Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
    '
    'KryptonHeaderGroup2.Panel
    '
    Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tvwReporte)
    Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(232, 663)
    Me.KryptonHeaderGroup2.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup2.TabIndex = 2
    Me.KryptonHeaderGroup2.Text = "Reportes"
    Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Reportes"
    Me.KryptonHeaderGroup2.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
    '
    'tvwReporte
    '
    Me.tvwReporte.Cursor = System.Windows.Forms.Cursors.Hand
    Me.tvwReporte.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvwReporte.ImageIndex = 1
    Me.tvwReporte.ImageList = Me.ImageList1
    Me.tvwReporte.Location = New System.Drawing.Point(0, 0)
    Me.tvwReporte.Name = "tvwReporte"
    TreeNode1.ImageIndex = 2
    TreeNode1.Name = "Nodo1"
    TreeNode1.SelectedImageIndex = 0
    TreeNode1.Tag = "Rep01"
    TreeNode1.Text = "Carga Internacional"
    TreeNode1.ToolTipText = "Reporte Estadístico Mensual de Carga Internacional"
    TreeNode2.ImageIndex = 2
    TreeNode2.Name = "Nodo4"
    TreeNode2.SelectedImageIndex = 0
    TreeNode2.Tag = "Rep02"
    TreeNode2.Text = "Seguimiento Aduanero"
    TreeNode2.ToolTipText = "Reporte Estadístico Mensual de Seguimiento Aduanero"
    TreeNode3.ImageIndex = 2
    TreeNode3.Name = "Nodo1"
    TreeNode3.SelectedImageIndex = 0
    TreeNode3.Tag = "Rep03"
    TreeNode3.Text = "Seguimiento Aduanero (Resumen)"
    TreeNode3.ToolTipText = "Reporte Mensual de Seguimiento Aduanero"
    TreeNode4.Name = "Nodo0"
    TreeNode4.Text = "Estadistico"
    TreeNode5.ImageIndex = 2
    TreeNode5.Name = "Nodo5"
    TreeNode5.SelectedImageIndex = 0
    TreeNode5.Tag = "Rep04"
    TreeNode5.Text = "Liquidación de Pagos"
    TreeNode5.ToolTipText = "Liquidación de Pagos"
    TreeNode6.ImageIndex = 2
    TreeNode6.Name = "Nodo4"
    TreeNode6.SelectedImageIndex = 0
    TreeNode6.Tag = "Rep05"
    TreeNode6.Text = "Saving ADVALOREM"
    TreeNode6.ToolTipText = "Saving ADVALOREM Mensual"
    TreeNode7.ImageIndex = 2
    TreeNode7.Name = "Nodo0"
    TreeNode7.SelectedImageIndex = 0
    TreeNode7.Tag = "Rep06"
    TreeNode7.Text = "3PL Report"
    TreeNode7.ToolTipText = "3PL Report"
    TreeNode8.ImageIndex = 2
    TreeNode8.Name = "Nodo0"
    TreeNode8.SelectedImageIndex = 0
    TreeNode8.Tag = "Rep07"
    TreeNode8.Text = "Monthly Report"
    TreeNode8.ToolTipText = "Monthly Report"
    TreeNode9.Name = "Nodo3"
    TreeNode9.Text = "Otros"
    Me.tvwReporte.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode9})
    Me.tvwReporte.SelectedImageIndex = 1
    Me.tvwReporte.Size = New System.Drawing.Size(230, 641)
    Me.tvwReporte.TabIndex = 1
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "Tips.ico")
    Me.ImageList1.Images.SetKeyName(1, "chart.ico")
    Me.ImageList1.Images.SetKeyName(2, "chart_accept.ico")
    '
    'pbxBuscar
    '
    Me.pbxBuscar.BackColor = System.Drawing.Color.White
    Me.pbxBuscar.Cursor = System.Windows.Forms.Cursors.Default
    Me.pbxBuscar.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pbxBuscar.Enabled = False
    Me.pbxBuscar.Image = CType(resources.GetObject("pbxBuscar.Image"), System.Drawing.Image)
    Me.pbxBuscar.ImageLocation = ""
    Me.pbxBuscar.InitialImage = Nothing
    Me.pbxBuscar.Location = New System.Drawing.Point(0, 176)
    Me.pbxBuscar.Name = "pbxBuscar"
    Me.pbxBuscar.Size = New System.Drawing.Size(764, 365)
    Me.pbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.pbxBuscar.TabIndex = 13
    Me.pbxBuscar.TabStop = False
    Me.pbxBuscar.Visible = False
    '
    'VisorRep
    '
    Me.VisorRep.ActiveViewIndex = -1
    Me.VisorRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.VisorRep.DisplayGroupTree = False
    Me.VisorRep.Dock = System.Windows.Forms.DockStyle.Fill
    Me.VisorRep.Location = New System.Drawing.Point(0, 176)
    Me.VisorRep.Name = "VisorRep"
    Me.VisorRep.SelectionFormula = ""
    Me.VisorRep.Size = New System.Drawing.Size(764, 365)
    Me.VisorRep.TabIndex = 12
    Me.VisorRep.ViewTimeSelectionFormula = ""
    '
    'KryptonHeaderGroup4
    '
    Me.KryptonHeaderGroup4.AutoSize = True
    Me.KryptonHeaderGroup4.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup4})
    Me.KryptonHeaderGroup4.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.KryptonHeaderGroup4.Location = New System.Drawing.Point(0, 541)
    Me.KryptonHeaderGroup4.Name = "KryptonHeaderGroup4"
    '
    'KryptonHeaderGroup4.Panel
    '
    Me.KryptonHeaderGroup4.Panel.Controls.Add(Me.txtObservacion)
    Me.KryptonHeaderGroup4.Size = New System.Drawing.Size(764, 122)
    Me.KryptonHeaderGroup4.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup4.TabIndex = 11
    Me.KryptonHeaderGroup4.Text = "Observaciones"
    Me.KryptonHeaderGroup4.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup4.ValuesPrimary.Heading = "Observaciones"
    Me.KryptonHeaderGroup4.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup4.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup4.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup4.ValuesSecondary.Image = Nothing
    Me.KryptonHeaderGroup4.Visible = False
    '
    'ButtonSpecHeaderGroup4
    '
    Me.ButtonSpecHeaderGroup4.ExtraText = ""
    Me.ButtonSpecHeaderGroup4.Image = Nothing
    Me.ButtonSpecHeaderGroup4.Text = ""
    Me.ButtonSpecHeaderGroup4.ToolTipImage = Nothing
    Me.ButtonSpecHeaderGroup4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.ButtonSpecHeaderGroup4.UniqueName = "ECCB94CD630A41C2ECCB94CD630A41C2"
    '
    'txtObservacion
    '
    Me.txtObservacion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtObservacion.ForeColor = System.Drawing.SystemColors.Desktop
    Me.txtObservacion.Location = New System.Drawing.Point(3, 3)
    Me.txtObservacion.Multiline = True
    Me.txtObservacion.Name = "txtObservacion"
    Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtObservacion.Size = New System.Drawing.Size(734, 91)
    Me.txtObservacion.TabIndex = 10
    '
    'KryptonHeaderGroup3
    '
    Me.KryptonHeaderGroup3.AutoSize = True
    Me.KryptonHeaderGroup3.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup2})
    Me.KryptonHeaderGroup3.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup3.Location = New System.Drawing.Point(0, 112)
    Me.KryptonHeaderGroup3.Name = "KryptonHeaderGroup3"
    '
    'KryptonHeaderGroup3.Panel
    '
    Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.lblCriterio)
    Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.rdbLevante)
    Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.rdbETA)
    Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.pbxEnvio)
    Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.dtpMesEnvio)
    Me.KryptonHeaderGroup3.Panel.Controls.Add(Me.Label2)
    Me.KryptonHeaderGroup3.Size = New System.Drawing.Size(764, 64)
    Me.KryptonHeaderGroup3.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup3.TabIndex = 5
    Me.KryptonHeaderGroup3.Text = "Envío Mensual de Datos de Operación"
    Me.KryptonHeaderGroup3.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup3.ValuesPrimary.Heading = "Envío Mensual de Datos de Operación"
    Me.KryptonHeaderGroup3.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup3.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup3.ValuesSecondary.Heading = ""
    Me.KryptonHeaderGroup3.ValuesSecondary.Image = Nothing
    Me.KryptonHeaderGroup3.Visible = False
    '
    'ButtonSpecHeaderGroup2
    '
    Me.ButtonSpecHeaderGroup2.ExtraText = ""
    Me.ButtonSpecHeaderGroup2.Image = Nothing
    Me.ButtonSpecHeaderGroup2.Text = ""
    Me.ButtonSpecHeaderGroup2.ToolTipImage = Nothing
    Me.ButtonSpecHeaderGroup2.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.ButtonSpecHeaderGroup2.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
    '
    'lblCriterio
    '
    Me.lblCriterio.AutoSize = True
    Me.lblCriterio.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.lblCriterio.Location = New System.Drawing.Point(247, 16)
    Me.lblCriterio.Name = "lblCriterio"
    Me.lblCriterio.Size = New System.Drawing.Size(229, 13)
    Me.lblCriterio.TabIndex = 10
    Me.lblCriterio.Text = "Criterio para el Envío de Información :"
    '
    'rdbLevante
    '
    Me.rdbLevante.AutoSize = True
    Me.rdbLevante.BackColor = System.Drawing.Color.Transparent
    Me.rdbLevante.Location = New System.Drawing.Point(535, 13)
    Me.rdbLevante.Name = "rdbLevante"
    Me.rdbLevante.Size = New System.Drawing.Size(125, 17)
    Me.rdbLevante.TabIndex = 9
    Me.rdbLevante.Text = "Fecha de Levante"
    Me.rdbLevante.UseVisualStyleBackColor = False
    Me.rdbLevante.Visible = False
    '
    'rdbETA
    '
    Me.rdbETA.AutoSize = True
    Me.rdbETA.BackColor = System.Drawing.Color.Transparent
    Me.rdbETA.Checked = True
    Me.rdbETA.Location = New System.Drawing.Point(482, 13)
    Me.rdbETA.Name = "rdbETA"
    Me.rdbETA.Size = New System.Drawing.Size(47, 17)
    Me.rdbETA.TabIndex = 8
    Me.rdbETA.TabStop = True
    Me.rdbETA.Text = "ETA"
    Me.rdbETA.UseVisualStyleBackColor = False
    '
    'pbxEnvio
    '
    Me.pbxEnvio.BackColor = System.Drawing.Color.Transparent
    Me.pbxEnvio.Cursor = System.Windows.Forms.Cursors.Hand
    Me.pbxEnvio.Image = CType(resources.GetObject("pbxEnvio.Image"), System.Drawing.Image)
    Me.pbxEnvio.Location = New System.Drawing.Point(679, 4)
    Me.pbxEnvio.Name = "pbxEnvio"
    Me.pbxEnvio.Size = New System.Drawing.Size(32, 32)
    Me.pbxEnvio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.pbxEnvio.TabIndex = 7
    Me.pbxEnvio.TabStop = False
    '
    'dtpMesEnvio
    '
    Me.dtpMesEnvio.CalendarMonthBackground = System.Drawing.Color.White
    Me.dtpMesEnvio.CalendarTitleForeColor = System.Drawing.Color.White
    Me.dtpMesEnvio.Cursor = System.Windows.Forms.Cursors.Hand
    Me.dtpMesEnvio.CustomFormat = "MM/yyyy"
    Me.dtpMesEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpMesEnvio.Location = New System.Drawing.Point(135, 10)
    Me.dtpMesEnvio.Name = "dtpMesEnvio"
    Me.dtpMesEnvio.Size = New System.Drawing.Size(78, 20)
    Me.dtpMesEnvio.TabIndex = 5
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.Label2.Location = New System.Drawing.Point(19, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(118, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Mes de Operación :"
    '
    'KryptonHeaderGroup1
    '
    Me.KryptonHeaderGroup1.AllowButtonSpecToolTips = True
    Me.KryptonHeaderGroup1.AutoSize = True
    Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup3, Me.ButtonSpecHeaderGroup1})
    Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
    Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
    Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
    '
    'KryptonHeaderGroup1.Panel
    '
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblIdioma)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cboIdioma)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chkRegimen)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblRegimen)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.chkTiempo)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCliente)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecFin)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFecFin)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNroPago)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnBuscar)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtpFecIni)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblMes)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblOS)
    Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtOS)
    Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(764, 112)
    Me.KryptonHeaderGroup1.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.KryptonHeaderGroup1.TabIndex = 1
    Me.KryptonHeaderGroup1.Text = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
    Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
    Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
    Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
    Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Información"
    Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
    '
    'ButtonSpecHeaderGroup3
    '
    Me.ButtonSpecHeaderGroup3.ExtraText = ""
    Me.ButtonSpecHeaderGroup3.Image = Nothing
    Me.ButtonSpecHeaderGroup3.Text = "Exportar"
    Me.ButtonSpecHeaderGroup3.ToolTipBody = "Exportar a Excel"
    Me.ButtonSpecHeaderGroup3.ToolTipImage = Nothing
    Me.ButtonSpecHeaderGroup3.UniqueName = "20B8675001AD4D5020B8675001AD4D50"
    '
    'ButtonSpecHeaderGroup1
    '
    Me.ButtonSpecHeaderGroup1.ExtraText = ""
    Me.ButtonSpecHeaderGroup1.Image = Nothing
    Me.ButtonSpecHeaderGroup1.Text = ""
    Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
    Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
    Me.ButtonSpecHeaderGroup1.UniqueName = "B7D8AF6EA43E42F3B7D8AF6EA43E42F3"
    '
    'lblIdioma
    '
    Me.lblIdioma.Location = New System.Drawing.Point(214, 40)
    Me.lblIdioma.Name = "lblIdioma"
    Me.lblIdioma.Size = New System.Drawing.Size(47, 19)
    Me.lblIdioma.TabIndex = 47
    Me.lblIdioma.Text = "Idioma:"
    Me.lblIdioma.Values.ExtraText = ""
    Me.lblIdioma.Values.Image = Nothing
    Me.lblIdioma.Values.Text = "Idioma:"
    '
    'cboIdioma
    '
    Me.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboIdioma.FormattingEnabled = True
    Me.cboIdioma.Location = New System.Drawing.Point(267, 38)
    Me.cboIdioma.Name = "cboIdioma"
    Me.cboIdioma.Size = New System.Drawing.Size(121, 21)
    Me.cboIdioma.TabIndex = 46
    '
    'lblCliente
    '
    Me.lblCliente.Location = New System.Drawing.Point(3, 15)
    Me.lblCliente.Name = "lblCliente"
    Me.lblCliente.Size = New System.Drawing.Size(47, 19)
    Me.lblCliente.TabIndex = 45
    Me.lblCliente.Text = "Cliente:"
    Me.lblCliente.Values.ExtraText = ""
    Me.lblCliente.Values.Image = Nothing
    Me.lblCliente.Values.Text = "Cliente:"
    '
    'chkRegimen
    '
    Me.chkRegimen.CheckOnClick = True
    Me.chkRegimen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
    Me.chkRegimen.DropDownHeight = 1
    Me.chkRegimen.FormattingEnabled = True
    Me.chkRegimen.IntegralHeight = False
    Me.chkRegimen.Location = New System.Drawing.Point(68, 40)
    Me.chkRegimen.Name = "chkRegimen"
    Me.chkRegimen.Size = New System.Drawing.Size(465, 21)
    Me.chkRegimen.TabIndex = 44
    Me.chkRegimen.ValueSeparator = ", "
    '
    'lblRegimen
    '
    Me.lblRegimen.Location = New System.Drawing.Point(3, 39)
    Me.lblRegimen.Name = "lblRegimen"
    Me.lblRegimen.Size = New System.Drawing.Size(57, 19)
    Me.lblRegimen.TabIndex = 43
    Me.lblRegimen.Text = "Régimen:"
    Me.lblRegimen.Values.ExtraText = ""
    Me.lblRegimen.Values.Image = Nothing
    Me.lblRegimen.Values.Text = "Régimen:"
    '
    'chkTiempo
    '
    Me.chkTiempo.Checked = False
    Me.chkTiempo.CheckState = System.Windows.Forms.CheckState.Unchecked
    Me.chkTiempo.Location = New System.Drawing.Point(16, 39)
    Me.chkTiempo.Name = "chkTiempo"
    Me.chkTiempo.Size = New System.Drawing.Size(182, 19)
    Me.chkTiempo.TabIndex = 41
    Me.chkTiempo.Text = "Mostrar Información de Tiempo"
    Me.chkTiempo.Values.ExtraText = ""
    Me.chkTiempo.Values.Image = Nothing
    Me.chkTiempo.Values.Text = "Mostrar Información de Tiempo"
    '
    'cmbCliente
    '
    Me.cmbCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.cmbCliente.BackColor = System.Drawing.Color.Transparent
    Me.cmbCliente.CCMPN = "EZ"
    Me.cmbCliente.Location = New System.Drawing.Point(68, 12)
    Me.cmbCliente.Name = "cmbCliente"
    Me.cmbCliente.pAccesoPorUsuario = True
    Me.cmbCliente.pRequerido = True
    Me.cmbCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
    Me.cmbCliente.Size = New System.Drawing.Size(260, 21)
    Me.cmbCliente.TabIndex = 40
    '
    'dtpFecFin
    '
    Me.dtpFecFin.CalendarMonthBackground = System.Drawing.Color.White
    Me.dtpFecFin.CalendarTitleForeColor = System.Drawing.Color.White
    Me.dtpFecFin.CustomFormat = "MM/yyyy"
    Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecFin.Location = New System.Drawing.Point(528, 12)
    Me.dtpFecFin.Name = "dtpFecFin"
    Me.dtpFecFin.Size = New System.Drawing.Size(91, 20)
    Me.dtpFecFin.TabIndex = 13
    '
    'lblFecFin
    '
    Me.lblFecFin.AutoSize = True
    Me.lblFecFin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.lblFecFin.Location = New System.Drawing.Point(500, 17)
    Me.lblFecFin.Name = "lblFecFin"
    Me.lblFecFin.Size = New System.Drawing.Size(32, 13)
    Me.lblFecFin.TabIndex = 12
    Me.lblFecFin.Text = "Fin :"
    '
    'txtNroPago
    '
    Me.txtNroPago.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroPago.ForeColor = System.Drawing.SystemColors.Desktop
    Me.txtNroPago.Location = New System.Drawing.Point(611, 11)
    Me.txtNroPago.Name = "txtNroPago"
    Me.txtNroPago.Size = New System.Drawing.Size(23, 20)
    Me.txtNroPago.TabIndex = 11
    Me.txtNroPago.Visible = False
    '
    'btnBuscar
    '
    Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnBuscar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Desktop
    Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(640, 6)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(89, 38)
    Me.btnBuscar.TabIndex = 6
    Me.btnBuscar.Text = "Generar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'dtpFecIni
    '
    Me.dtpFecIni.CalendarMonthBackground = System.Drawing.Color.White
    Me.dtpFecIni.CalendarTitleForeColor = System.Drawing.Color.White
    Me.dtpFecIni.CustomFormat = "MM/yyyy"
    Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecIni.Location = New System.Drawing.Point(406, 15)
    Me.dtpFecIni.Name = "dtpFecIni"
    Me.dtpFecIni.Size = New System.Drawing.Size(93, 20)
    Me.dtpFecIni.TabIndex = 5
    '
    'lblMes
    '
    Me.lblMes.AutoSize = True
    Me.lblMes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.lblMes.Location = New System.Drawing.Point(340, 17)
    Me.lblMes.Name = "lblMes"
    Me.lblMes.Size = New System.Drawing.Size(47, 13)
    Me.lblMes.TabIndex = 1
    Me.lblMes.Text = "Inicio :"
    '
    'lblOS
    '
    Me.lblOS.AutoSize = True
    Me.lblOS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
    Me.lblOS.Location = New System.Drawing.Point(403, 17)
    Me.lblOS.Name = "lblOS"
    Me.lblOS.Size = New System.Drawing.Size(119, 13)
    Me.lblOS.TabIndex = 8
    Me.lblOS.Text = "Orden de Servicio :"
    Me.lblOS.Visible = False
    '
    'txtOS
    '
    Me.txtOS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtOS.ForeColor = System.Drawing.SystemColors.Desktop
    Me.txtOS.Location = New System.Drawing.Point(528, 11)
    Me.txtOS.Name = "txtOS"
    Me.txtOS.Size = New System.Drawing.Size(78, 20)
    Me.txtOS.TabIndex = 9
    Me.txtOS.Visible = False
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
    'frmVisorReporte
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1001, 663)
    Me.Controls.Add(Me.KryptonSplitContainer1)
    Me.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmVisorReporte"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Reportes Estadísticos Mensuales"
    CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
    CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
    Me.KryptonSplitContainer1.Panel2.PerformLayout()
    CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonSplitContainer1.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup2.ResumeLayout(False)
    CType(Me.pbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonHeaderGroup4.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup4.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup4.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup4, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup4.ResumeLayout(False)
    CType(Me.KryptonHeaderGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup3.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup3.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup3, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup3.ResumeLayout(False)
    CType(Me.pbxEnvio, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
    Me.KryptonHeaderGroup1.Panel.PerformLayout()
    CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KryptonHeaderGroup1.ResumeLayout(False)
    CType(Me.oDs, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents tvwReporte As System.Windows.Forms.TreeView
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents txtNroPago As System.Windows.Forms.TextBox
    Friend WithEvents KryptonHeaderGroup3 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup2 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dtpMesEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbETA As System.Windows.Forms.RadioButton
    Friend WithEvents pbxEnvio As System.Windows.Forms.PictureBox
    Friend WithEvents lblCriterio As System.Windows.Forms.Label
    Friend WithEvents rdbLevante As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonSpecHeaderGroup3 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents oDs As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
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
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents KryptonHeaderGroup4 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents VisorRep As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ButtonSpecHeaderGroup4 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents pbxBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecFin As System.Windows.Forms.Label
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents cmbCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents chkTiempo As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents lblRegimen As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents chkRegimen As Ransa.Controls.ServicioOperacion.CheckComboBoxTest.CheckedComboBox
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents lblIdioma As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboIdioma As System.Windows.Forms.ComboBox
End Class
