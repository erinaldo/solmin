<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMovProductoValorizado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptMovProductoValorizado))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEnviarCorreo = New System.Windows.Forms.ToolStripButton
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.ButtonSpecHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinalComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblFechaInicialComp = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnGenerarReporte = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New Ransa.Controls.Cliente.ucCliente_TxtF01
        Me.lblCliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblPlanta = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcPLanta_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
        Me.lblDivision = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcDivision_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
        Me.lblCompania = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.UcCompania_Cmb011 = New Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1025, 641)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup2.HeaderVisiblePrimary = False
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 141)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.pcxEspera)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.crvReporte)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.tsReporte)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(1025, 500)
        Me.KryptonHeaderGroup2.TabIndex = 52
        Me.KryptonHeaderGroup2.Text = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Heading"
        Me.KryptonHeaderGroup2.ValuesPrimary.Image = CType(resources.GetObject("KryptonHeaderGroup2.ValuesPrimary.Image"), System.Drawing.Image)
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = "...Reporte..."
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(534, 182)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 51
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.crvReporte.Location = New System.Drawing.Point(0, 26)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.Size = New System.Drawing.Size(1023, 452)
        Me.crvReporte.TabIndex = 2
        Me.crvReporte.TabStop = False
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbEnviarCorreo})
        Me.tsReporte.Location = New System.Drawing.Point(0, 0)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1023, 26)
        Me.tsReporte.TabIndex = 0
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(101, 23)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 26)
        '
        'tsbEnviarCorreo
        '
        Me.tsbEnviarCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarCorreo.Enabled = False
        Me.tsbEnviarCorreo.Image = Global.SOLMIN_SA.My.Resources.Resources.tsbEnviarCorreo_Image
        Me.tsbEnviarCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEnviarCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarCorreo.Name = "tsbEnviarCorreo"
        Me.tsbEnviarCorreo.Size = New System.Drawing.Size(117, 23)
        Me.tsbEnviarCorreo.Text = "Enviar por Correo"
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.AutoSize = True
        Me.KryptonHeaderGroup1.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.ButtonSpecHeaderGroup1})
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaFinal)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaFinalComp)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dteFechaInicial)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblFechaInicialComp)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.btnGenerarReporte)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCliente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblPlanta)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcPLanta_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblDivision)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcDivision_Cmb011)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lblCompania)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.UcCompania_Cmb011)
        Me.KryptonHeaderGroup1.Panel.MinimumSize = New System.Drawing.Size(0, 120)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(1025, 141)
        Me.KryptonHeaderGroup1.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup1.TabIndex = 1
        Me.KryptonHeaderGroup1.Text = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtros"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Nothing
        Me.KryptonHeaderGroup1.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Description"
        Me.KryptonHeaderGroup1.ValuesSecondary.Image = Nothing
        '
        'ButtonSpecHeaderGroup1
        '
        Me.ButtonSpecHeaderGroup1.ExtraText = ""
        Me.ButtonSpecHeaderGroup1.Image = Nothing
        Me.ButtonSpecHeaderGroup1.Text = ""
        Me.ButtonSpecHeaderGroup1.ToolTipImage = Nothing
        Me.ButtonSpecHeaderGroup1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.ButtonSpecHeaderGroup1.UniqueName = "6AE04AD0C4584EA26AE04AD0C4584EA2"
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(619, 38)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaFinal.TabIndex = 5
        '
        'lblFechaFinalComp
        '
        Me.lblFechaFinalComp.Location = New System.Drawing.Point(536, 38)
        Me.lblFechaFinalComp.Name = "lblFechaFinalComp"
        Me.lblFechaFinalComp.Size = New System.Drawing.Size(77, 19)
        Me.lblFechaFinalComp.TabIndex = 25
        Me.lblFechaFinalComp.Text = "Fecha Salida : "
        Me.lblFechaFinalComp.Values.ExtraText = ""
        Me.lblFechaFinalComp.Values.Image = Nothing
        Me.lblFechaFinalComp.Values.Text = "Fecha Salida : "
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(437, 38)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(102, 20)
        Me.dteFechaInicial.TabIndex = 4
        '
        'lblFechaInicialComp
        '
        Me.lblFechaInicialComp.Location = New System.Drawing.Point(349, 41)
        Me.lblFechaInicialComp.Name = "lblFechaInicialComp"
        Me.lblFechaInicialComp.Size = New System.Drawing.Size(82, 19)
        Me.lblFechaInicialComp.TabIndex = 23
        Me.lblFechaInicialComp.Text = "Fecha Ingreso: "
        Me.lblFechaInicialComp.Values.ExtraText = ""
        Me.lblFechaInicialComp.Values.Image = Nothing
        Me.lblFechaInicialComp.Values.Text = "Fecha Ingreso: "
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarReporte.Location = New System.Drawing.Point(870, 41)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(125, 38)
        Me.btnGenerarReporte.TabIndex = 6
        Me.btnGenerarReporte.Text = " &Generar Reporte "
        Me.btnGenerarReporte.Values.ExtraText = ""
        Me.btnGenerarReporte.Values.Image = CType(resources.GetObject("btnGenerarReporte.Values.Image"), System.Drawing.Image)
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnGenerarReporte.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnGenerarReporte.Values.Text = " &Generar Reporte "
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent

        Me.txtCliente.Location = New System.Drawing.Point(79, 41)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = Ransa.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(264, 21)
        Me.txtCliente.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(23, 43)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 19)
        Me.lblCliente.TabIndex = 63
        Me.lblCliente.Text = "Cliente : "
        Me.lblCliente.Values.ExtraText = ""
        Me.lblCliente.Values.Image = Nothing
        Me.lblCliente.Values.Text = "Cliente : "
        '
        'lblPlanta
        '
        Me.lblPlanta.Location = New System.Drawing.Point(719, 13)
        Me.lblPlanta.Name = "lblPlanta"
        Me.lblPlanta.Size = New System.Drawing.Size(47, 19)
        Me.lblPlanta.TabIndex = 61
        Me.lblPlanta.Text = "Planta : "
        Me.lblPlanta.Values.ExtraText = ""
        Me.lblPlanta.Values.Image = Nothing
        Me.lblPlanta.Values.Text = "Planta : "
        '
        'UcPLanta_Cmb011
        '
        Me.UcPLanta_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcPLanta_Cmb011.CodigoCompania = ""
        Me.UcPLanta_Cmb011.CodigoDivision = ""
        Me.UcPLanta_Cmb011.CPLNDV_ANTERIOR = Nothing
        Me.UcPLanta_Cmb011.DescripcionPlanta = ""
        Me.UcPLanta_Cmb011.Location = New System.Drawing.Point(791, 9)
        Me.UcPLanta_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcPLanta_Cmb011.Name = "UcPLanta_Cmb011"
        Me.UcPLanta_Cmb011.Planta = 0
        Me.UcPLanta_Cmb011.PlantaDefault = -1
        Me.UcPLanta_Cmb011.Size = New System.Drawing.Size(204, 23)
        Me.UcPLanta_Cmb011.TabIndex = 2
        Me.UcPLanta_Cmb011.Usuario = ""
        '
        'lblDivision
        '
        Me.lblDivision.Location = New System.Drawing.Point(376, 13)
        Me.lblDivision.Name = "lblDivision"
        Me.lblDivision.Size = New System.Drawing.Size(55, 19)
        Me.lblDivision.TabIndex = 59
        Me.lblDivision.Text = "Division : "
        Me.lblDivision.Values.ExtraText = ""
        Me.lblDivision.Values.Image = Nothing
        Me.lblDivision.Values.Text = "Division : "
        '
        'UcDivision_Cmb011
        '
        Me.UcDivision_Cmb011.BackColor = System.Drawing.Color.Transparent
        Me.UcDivision_Cmb011.CDVSN_ANTERIOR = Nothing
        Me.UcDivision_Cmb011.Compania = ""
        Me.UcDivision_Cmb011.Division = Nothing
        Me.UcDivision_Cmb011.DivisionDefault = Nothing
        Me.UcDivision_Cmb011.DivisionDescripcion = Nothing
        Me.UcDivision_Cmb011.Location = New System.Drawing.Point(437, 9)
        Me.UcDivision_Cmb011.MinimumSize = New System.Drawing.Size(150, 21)
        Me.UcDivision_Cmb011.Name = "UcDivision_Cmb011"
        Me.UcDivision_Cmb011.Size = New System.Drawing.Size(284, 23)
        Me.UcDivision_Cmb011.TabIndex = 1
        Me.UcDivision_Cmb011.Usuario = ""
        '
        'lblCompania
        '
        Me.lblCompania.Location = New System.Drawing.Point(7, 13)
        Me.lblCompania.Name = "lblCompania"
        Me.lblCompania.Size = New System.Drawing.Size(66, 19)
        Me.lblCompania.TabIndex = 57
        Me.lblCompania.Text = "Compañia : "
        Me.lblCompania.Values.ExtraText = ""
        Me.lblCompania.Values.Image = Nothing
        Me.lblCompania.Values.Text = "Compañia : "
        '
        'UcCompania_Cmb011
        '
        Me.UcCompania_Cmb011.BackColor = System.Drawing.SystemColors.Window
        Me.UcCompania_Cmb011.CCMPN_ANTERIOR = Nothing
        Me.UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing
        Me.UcCompania_Cmb011.CCMPN_Descripcion = Nothing
        Me.UcCompania_Cmb011.Location = New System.Drawing.Point(79, 9)
        Me.UcCompania_Cmb011.MinimumSize = New System.Drawing.Size(150, 23)
        Me.UcCompania_Cmb011.Name = "UcCompania_Cmb011"
        Me.UcCompania_Cmb011.Size = New System.Drawing.Size(264, 23)
        Me.UcCompania_Cmb011.TabIndex = 0
        Me.UcCompania_Cmb011.Usuario = ""
        '
        'bgwGifAnimado
        '
        '
        'frmRptMovProductoValorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 641)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmRptMovProductoValorizado"
        Me.Text = "Reporte Mov. de Producto Valorizado"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
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
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents ButtonSpecHeaderGroup1 As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents lblFechaInicialComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinalComp As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents lblCliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents lblPlanta As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcPLanta_Cmb011 As Ransa.Controls.UbicacionPlanta.ucPLanta_Cmb01
    Private WithEvents lblDivision As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcDivision_Cmb011 As Ransa.Controls.UbicacionPlanta.ucDivision_Cmb01
    Private WithEvents lblCompania As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents UcCompania_Cmb011 As Ransa.Controls.UbicacionPlanta.ucCompania_Cmb01
    Friend WithEvents btnGenerarReporte As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEnviarCorreo As System.Windows.Forms.ToolStripButton
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
End Class
