<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteRotacionProductoMensual
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteRotacionProductoMensual))
        Me.khgFiltros = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.bsaOcultarFiltros = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.bsaCerrar = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnProcesar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtCliente = New RANSA.Controls.Cliente.ucCliente_TxtF01
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.tsReporte = New System.Windows.Forms.ToolStrip
        Me.tsbExportarPDF = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_001 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbExportarExcel = New System.Windows.Forms.ToolStripButton
        Me.tssSeparador_002 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbEnviarCorreo = New System.Windows.Forms.ToolStripButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        Me.HGReporte = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.khgFiltros.Panel.SuspendLayout()
        Me.khgFiltros.SuspendLayout()
        Me.tsReporte.SuspendLayout()
        CType(Me.HGReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HGReporte.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HGReporte.Panel.SuspendLayout()
        Me.HGReporte.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.khgFiltros.Panel.Controls.Add(Me.txtAnio)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel1)
        Me.khgFiltros.Panel.Controls.Add(Me.btnProcesar)
        Me.khgFiltros.Panel.Controls.Add(Me.txtCliente)
        Me.khgFiltros.Panel.Controls.Add(Me.KryptonLabel4)
        Me.khgFiltros.Size = New System.Drawing.Size(867, 100)
        Me.khgFiltros.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.khgFiltros.TabIndex = 8
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
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(422, 20)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(64, 20)
        Me.txtAnio.TabIndex = 76
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(385, 21)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(36, 19)
        Me.KryptonLabel1.TabIndex = 75
        Me.KryptonLabel1.Text = "Año :"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Año :"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(770, 3)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(84, 65)
        Me.btnProcesar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnProcesar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnProcesar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnProcesar.TabIndex = 73
        Me.btnProcesar.Text = "&Procesar"
        Me.btnProcesar.Values.ExtraText = "Consulta"
        Me.btnProcesar.Values.Image = CType(resources.GetObject("btnProcesar.Values.Image"), System.Drawing.Image)
        Me.btnProcesar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnProcesar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnProcesar.Values.Text = "&Procesar"
        '
        'txtCliente
        '
        Me.txtCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.txtCliente.BackColor = System.Drawing.Color.Transparent
        Me.txtCliente.Location = New System.Drawing.Point(83, 20)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.pAccesoPorUsuario = True
        Me.txtCliente.pRequerido = True
        Me.txtCliente.pTipoCliente = RANSA.Controls.Cliente.ucCliente_TxtF01.eTipoCliente.Normal
        Me.txtCliente.Size = New System.Drawing.Size(278, 21)
        Me.txtCliente.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(16, 22)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(50, 19)
        Me.KryptonLabel4.TabIndex = 63
        Me.KryptonLabel4.Text = "Cliente : "
        Me.KryptonLabel4.Values.ExtraText = ""
        Me.KryptonLabel4.Values.Image = Nothing
        Me.KryptonLabel4.Values.Text = "Cliente : "
        '
        'tsReporte
        '
        Me.tsReporte.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tsReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportarPDF, Me.tssSeparador_001, Me.tsbExportarExcel, Me.tssSeparador_002, Me.tsbEnviarCorreo})
        Me.tsReporte.Location = New System.Drawing.Point(0, 100)
        Me.tsReporte.Name = "tsReporte"
        Me.tsReporte.Size = New System.Drawing.Size(867, 39)
        Me.tsReporte.TabIndex = 54
        '
        'tsbExportarPDF
        '
        Me.tsbExportarPDF.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarPDF.Enabled = False
        Me.tsbExportarPDF.Image = CType(resources.GetObject("tsbExportarPDF.Image"), System.Drawing.Image)
        Me.tsbExportarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarPDF.Name = "tsbExportarPDF"
        Me.tsbExportarPDF.Size = New System.Drawing.Size(117, 36)
        Me.tsbExportarPDF.Text = "Exportar a PDT"
        '
        'tssSeparador_001
        '
        Me.tssSeparador_001.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_001.Name = "tssSeparador_001"
        Me.tssSeparador_001.Size = New System.Drawing.Size(6, 39)
        '
        'tsbExportarExcel
        '
        Me.tsbExportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExportarExcel.Enabled = False
        Me.tsbExportarExcel.Image = CType(resources.GetObject("tsbExportarExcel.Image"), System.Drawing.Image)
        Me.tsbExportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportarExcel.Name = "tsbExportarExcel"
        Me.tsbExportarExcel.Size = New System.Drawing.Size(114, 36)
        Me.tsbExportarExcel.Text = "Exportar Excel"
        '
        'tssSeparador_002
        '
        Me.tssSeparador_002.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssSeparador_002.Name = "tssSeparador_002"
        Me.tssSeparador_002.Size = New System.Drawing.Size(6, 39)
        '
        'tsbEnviarCorreo
        '
        Me.tsbEnviarCorreo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbEnviarCorreo.Enabled = False
        Me.tsbEnviarCorreo.Image = CType(resources.GetObject("tsbEnviarCorreo.Image"), System.Drawing.Image)
        Me.tsbEnviarCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEnviarCorreo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEnviarCorreo.Name = "tsbEnviarCorreo"
        Me.tsbEnviarCorreo.Size = New System.Drawing.Size(133, 36)
        Me.tsbEnviarCorreo.Text = "Enviar por Correo"
        '
        'bgwGifAnimado
        '
        '
        'HGReporte
        '
        Me.HGReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HGReporte.HeaderVisiblePrimary = False
        Me.HGReporte.Location = New System.Drawing.Point(0, 139)
        Me.HGReporte.Name = "HGReporte"
        '
        'HGReporte.Panel
        '
        Me.HGReporte.Panel.Controls.Add(Me.pcxEspera)
        Me.HGReporte.Panel.Controls.Add(Me.crvReporte)
        Me.HGReporte.Size = New System.Drawing.Size(867, 465)
        Me.HGReporte.TabIndex = 55
        Me.HGReporte.Text = "Heading"
        Me.HGReporte.ValuesPrimary.Description = ""
        Me.HGReporte.ValuesPrimary.Heading = "Heading"
        Me.HGReporte.ValuesPrimary.Image = CType(resources.GetObject("HGReporte.ValuesPrimary.Image"), System.Drawing.Image)
        Me.HGReporte.ValuesSecondary.Description = ""
        Me.HGReporte.ValuesSecondary.Heading = "Description"
        Me.HGReporte.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.BackColor = System.Drawing.Color.Transparent
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(406, 138)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 56
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'crvReporte
        '
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
        Me.crvReporte.Size = New System.Drawing.Size(865, 443)
        Me.crvReporte.TabIndex = 55
        Me.crvReporte.ViewTimeSelectionFormula = ""
        Me.crvReporte.Visible = False
        '
        'frmReporteRotacionProductoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 604)
        Me.Controls.Add(Me.HGReporte)
        Me.Controls.Add(Me.tsReporte)
        Me.Controls.Add(Me.khgFiltros)
        Me.Name = "frmReporteRotacionProductoMensual"
        Me.Text = "Reporte Indicadores"
        CType(Me.khgFiltros.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.Panel.ResumeLayout(False)
        Me.khgFiltros.Panel.PerformLayout()
        CType(Me.khgFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.khgFiltros.ResumeLayout(False)
        Me.tsReporte.ResumeLayout(False)
        Me.tsReporte.PerformLayout()
        CType(Me.HGReporte.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGReporte.Panel.ResumeLayout(False)
        Me.HGReporte.Panel.PerformLayout()
        CType(Me.HGReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HGReporte.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents khgFiltros As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents bsaOcultarFiltros As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents bsaCerrar As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents btnProcesar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtCliente As Ransa.Controls.Cliente.ucCliente_TxtF01
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tsReporte As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExportarPDF As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_001 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbExportarExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador_002 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbEnviarCorreo As System.Windows.Forms.ToolStripButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents HGReporte As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
End Class
