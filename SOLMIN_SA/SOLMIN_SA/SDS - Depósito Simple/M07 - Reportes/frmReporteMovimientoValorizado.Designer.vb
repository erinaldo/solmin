<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMovimientoValorizado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteMovimientoValorizado))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel4 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel5 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.HGReporte = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbExportarPDF = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_001 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEnviarCorreo = New System.Windows.Forms.ToolStripButton
        Me.tsbGenerarReporte = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaFinal = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblFechaInicial = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel3.SuspendLayout()
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel4.SuspendLayout()
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel5.SuspendLayout()
        CType(Me.HGReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGReporte.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGReporte.Panel.SuspendLayout()
        Me.HGReporte.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsReporte.SuspendLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(1095, 540)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1095, 540)
        Me.KryptonPanel1.TabIndex = 1
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.KryptonPanel3)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(1095, 540)
        Me.KryptonPanel2.TabIndex = 1
        '
        'KryptonPanel3
        '
        Me.KryptonPanel3.Controls.Add(Me.KryptonPanel4)
        Me.KryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel3.Name = "KryptonPanel3"
        Me.KryptonPanel3.Size = New System.Drawing.Size(1095, 540)
        Me.KryptonPanel3.TabIndex = 1
        '
        'KryptonPanel4
        '
        Me.KryptonPanel4.Controls.Add(Me.KryptonPanel5)
        Me.KryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel4.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel4.Name = "KryptonPanel4"
        Me.KryptonPanel4.Size = New System.Drawing.Size(1095, 540)
        Me.KryptonPanel4.TabIndex = 1
        '
        'KryptonPanel5
        '
        Me.KryptonPanel5.Controls.Add(Me.HGReporte)
        Me.KryptonPanel5.Controls.Add(Me.tsReporte)
        Me.KryptonPanel5.Controls.Add(Me.khgFiltros)
        Me.KryptonPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel5.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel5.Name = "KryptonPanel5"
        Me.KryptonPanel5.Size = New System.Drawing.Size(1095, 540)
        Me.KryptonPanel5.TabIndex = 1
        '
        'HGReporte
        '
        Me.HGReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGReporte.HeaderVisiblePrimary = False
        Me.HGReporte.Location = New System.Drawing.Point(0, 108)
        Me.HGReporte.Name = "HGReporte"
        '
        'HGReporte.Panel
        '
        Me.HGReporte.Panel.Controls.Add(Me.pcxEspera)
        Me.HGReporte.Panel.Controls.Add(Me.crvReporte)
        Me.HGReporte.Size = New System.Drawing.Size(1095, 432)
        Me.HGReporte.TabIndex = 58
        Me.HGReporte.Text = "Heading"
        Me.HGReporte.ValuesPrimary.Description = ""
        Me.HGReporte.ValuesPrimary.Heading = "Heading"
        Me.HGReporte.ValuesPrimary.Image = CType(resources.GetObject("HGReporte.ValuesPrimary.Image"), System.Drawing.Image)
        Me.HGReporte.ValuesSecondary.Description = ""
        Me.HGReporte.ValuesSecondary.Heading = ""
        Me.HGReporte.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(575, 163)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 56
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'crvReporte
        '
        Me.crvReporte.AccessibleDescription = "<"
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crvReporte.DisplayGroupTree = False
        Me.crvReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReporte.Location = New System.Drawing.Point(0, 0)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.SelectionFormula = ""
        Me.crvReporte.ShowCloseButton = False
        Me.crvReporte.ShowGotoPageButton = False
        Me.crvReporte.ShowGroupTreeButton = False
        Me.crvReporte.ShowRefreshButton = False
        Me.crvReporte.ShowTextSearchButton = False
        Me.crvReporte.Size = New System.Drawing.Size(1093, 427)
        Me.crvReporte.TabIndex = 55
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'tsReporte
        '
        Me.tsReporte.AccessibleDescription = "<"
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsReporte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarPDF, Me.tssSeparador_001, Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbEnviarCorreo, Me.tsbGenerarReporte, Me.ToolStripSeparator1})
        Me.tsReporte.Location = New System.Drawing.Point(0, 82)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(1095, 26)
        Me.tsReporte.TabIndex = 57
        '
        'tsbExportarPDF
        '
        Me.tsbExportarPDF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarPDF.Enabled = False
        Me.tsbExportarPDF.Image = Global.SOLMIN_SA.My.Resources.Resources.Enviado
        Me.tsbExportarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarPDF.Name = "tsbExportarPDF"
        Me.tsbExportarPDF.Size = New System.Drawing.Size(111, 24)
        Me.tsbExportarPDF.Text = "Exportar a PDT"
        Me.tsbExportarPDF.Visible = False
        '
        'tssSeparador_001
        '
        Me.tssSeparador_001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_001.Name = "tssSeparador_001"
        Me.tssSeparador_001.Size = New System.Drawing.Size(6, 27)
        Me.tssSeparador_001.Visible = False
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = Global.SOLMIN_SA.My.Resources.Resources.excelicon
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(102, 24)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 27)
        '
        'tsbEnviarCorreo
        '
        Me.tsbEnviarCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarCorreo.Enabled = False
        Me.tsbEnviarCorreo.Image = Global.SOLMIN_SA.My.Resources.Resources.Interface_Grilla
        Me.tsbEnviarCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEnviarCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarCorreo.Name = "tsbEnviarCorreo"
        Me.tsbEnviarCorreo.Size = New System.Drawing.Size(120, 24)
        Me.tsbEnviarCorreo.Text = "Enviar por Correo"
        Me.tsbEnviarCorreo.Visible = False
        '
        'tsbGenerarReporte
        '
        Me.tsbGenerarReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbGenerarReporte.Image = Global.SOLMIN_SA.My.Resources.Resources.GenerarReporte
        Me.tsbGenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGenerarReporte.Name = "tsbGenerarReporte"
        Me.tsbGenerarReporte.Size = New System.Drawing.Size(112, 24)
        Me.tsbGenerarReporte.Text = "Generar Reporte"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'khgFiltros
        '
        Me.khgFiltros.AutoSize = True
        Me.khgFiltros.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.bsaOcultarFiltros, Me.bsaCerrar})
        Me.khgFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.khgFiltros.HeaderVisibleSecondary = False
        Me.khgFiltros.Location = New System.Drawing.Point(0, 0)
        Me.khgFiltros.Name = "khgFiltros"
        '
        'khgFiltros.Panel
        '
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.dteFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaFinal)
        Me.khgFiltros.Panel.Controls.Add(Me.lblFechaInicial)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(1095, 82)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 56
        Me.khgFiltros.Text = "Filtros"
        Me.khgFiltros.ValuesPrimary.Description = ""
        Me.khgFiltros.ValuesPrimary.Heading = "Filtros"
        Me.khgFiltros.ValuesPrimary.Image = Nothing
        Me.khgFiltros.ValuesSecondary.Description = ""
        Me.khgFiltros.ValuesSecondary.Heading = "Resultado"
        Me.khgFiltros.ValuesSecondary.Image = Nothing
        '
        'bsaOcultarFiltros
        '
        Me.bsaOcultarFiltros.ExtraText = ""
        Me.bsaOcultarFiltros.Image = Nothing
        Me.bsaOcultarFiltros.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaOcultarFiltros.Text = "Ocultar"
        Me.bsaOcultarFiltros.ToolTipImage = Nothing
        Me.bsaOcultarFiltros.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaOcultarFiltros.UniqueName = "4FD0578D687F46FC4FD0578D687F46FC"
        '
        'bsaCerrar
        '
        Me.bsaCerrar.ExtraText = ""
        Me.bsaCerrar.Image = Nothing
        Me.bsaCerrar.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.bsaCerrar.Text = "Cerrar"
        Me.bsaCerrar.ToolTipImage = Nothing
        Me.bsaCerrar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.bsaCerrar.UniqueName = "C90E4396C7B04154C90E4396C7B04154"
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaFinal.Location = New System.Drawing.Point(704, 19)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaFinal.TabIndex = 2
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaInicial.Location = New System.Drawing.Point(509, 19)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(94, 20)
        Me.dteFechaInicial.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(845, 29)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(10, 20)
        Me.KryptonLabel1.TabIndex = 67
        Me.KryptonLabel1.Text = "                        "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "                        "
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(621, 19)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(77, 20)
        Me.lblFechaFinal.TabIndex = 67
        Me.lblFechaFinal.Text = "Fecha Final : "
        Me.lblFechaFinal.Values.ExtraText = ""
        Me.lblFechaFinal.Values.Image = Nothing
        Me.lblFechaFinal.Values.Text = "Fecha Final : "
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.Location = New System.Drawing.Point(422, 19)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(81, 20)
        Me.lblFechaInicial.TabIndex = 65
        Me.lblFechaInicial.Text = "Fecha Inicio :"
        Me.lblFechaInicial.Values.ExtraText = ""
        Me.lblFechaInicial.Values.Image = Nothing
        Me.lblFechaInicial.Values.Text = "Fecha Inicio :"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(99, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(275, 22)
        Me.txtCliente.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(27, 19)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'bgwGifAnimado
        '
        '
        'frmReporteMovimientoValorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 540)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmReporteMovimientoValorizado"
        Me.Text = "Mov. Valorizado"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        CType(Me.KryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel3.ResumeLayout(False)
        CType(Me.KryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel4.ResumeLayout(False)
        CType(Me.KryptonPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel5.ResumeLayout(False)
        Me.KryptonPanel5.PerformLayout()
        CType(Me.HGReporte.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGReporte.Panel.ResumeLayout(False)
        Me.HGReporte.Panel.PerformLayout()
        CType(Me.HGReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGReporte.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel4 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonPanel5 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents HGReporte As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEnviarCorreo As System.Windows.Forms.ToolStripButton
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFinal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblFechaInicial As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As RANSA.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents tsbGenerarReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
