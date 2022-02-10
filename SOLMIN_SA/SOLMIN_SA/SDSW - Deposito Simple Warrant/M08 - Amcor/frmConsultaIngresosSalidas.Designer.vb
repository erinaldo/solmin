<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIngresosSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaIngresosSalidas))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgSalidas = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.VisorReportesCrystal = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.hgIngresos = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cbxTipo = New System.Windows.Forms.ComboBox
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgSalidas.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgSalidas.Panel.SuspendLayout()
        Me.hgSalidas.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgIngresos.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgIngresos.Panel.SuspendLayout()
        Me.hgIngresos.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgSalidas)
        Me.KryptonPanel.Controls.Add(Me.hgIngresos)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(801, 503)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgSalidas
        '
        Me.hgSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgSalidas.HeaderVisibleSecondary = False
        Me.hgSalidas.Location = New System.Drawing.Point(0, 121)
        Me.hgSalidas.Name = "hgSalidas"
        '
        'hgSalidas.Panel
        '
        Me.hgSalidas.Panel.Controls.Add(Me.pcxEspera)
        Me.hgSalidas.Panel.Controls.Add(Me.VisorReportesCrystal)
        Me.hgSalidas.Size = New System.Drawing.Size(801, 382)
        Me.hgSalidas.TabIndex = 1
        Me.hgSalidas.Text = "Reporte"
        Me.hgSalidas.ValuesPrimary.Description = ""
        Me.hgSalidas.ValuesPrimary.Heading = "Reporte"
        Me.hgSalidas.ValuesPrimary.Image = CType(resources.GetObject("hgSalidas.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgSalidas.ValuesSecondary.Description = ""
        Me.hgSalidas.ValuesSecondary.Heading = "Description"
        Me.hgSalidas.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(640, 243)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 48
        Me.pcxEspera.TabStop = False
        Me.pcxEspera.Visible = False
        '
        'VisorReportesCrystal
        '
        Me.VisorReportesCrystal.ActiveViewIndex = -1
        Me.VisorReportesCrystal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReportesCrystal.DisplayGroupTree = False
        Me.VisorReportesCrystal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorReportesCrystal.Location = New System.Drawing.Point(0, 0)
        Me.VisorReportesCrystal.Name = "VisorReportesCrystal"
        Me.VisorReportesCrystal.SelectionFormula = ""
        Me.VisorReportesCrystal.Size = New System.Drawing.Size(799, 352)
        Me.VisorReportesCrystal.TabIndex = 0
        Me.VisorReportesCrystal.ViewTimeSelectionFormula = ""
        '
        'hgIngresos
        '
        Me.hgIngresos.Dock = System.Windows.Forms.DockStyle.Top
        Me.hgIngresos.HeaderVisibleSecondary = False
        Me.hgIngresos.Location = New System.Drawing.Point(0, 0)
        Me.hgIngresos.Name = "hgIngresos"
        '
        'hgIngresos.Panel
        '
        Me.hgIngresos.Panel.Controls.Add(Me.KryptonLabel1)
        Me.hgIngresos.Panel.Controls.Add(Me.cbxTipo)
        Me.hgIngresos.Panel.Controls.Add(Me.KryptonLabel2)
        Me.hgIngresos.Panel.Controls.Add(Me.dtpFechaIngreso)
        Me.hgIngresos.Panel.Controls.Add(Me.btnActualizar)
        Me.hgIngresos.Size = New System.Drawing.Size(801, 121)
        Me.hgIngresos.TabIndex = 0
        Me.hgIngresos.Text = "Filtros"
        Me.hgIngresos.ValuesPrimary.Description = ""
        Me.hgIngresos.ValuesPrimary.Heading = "Filtros"
        Me.hgIngresos.ValuesPrimary.Image = CType(resources.GetObject("hgIngresos.ValuesPrimary.Image"), System.Drawing.Image)
        Me.hgIngresos.ValuesSecondary.Description = ""
        Me.hgIngresos.ValuesSecondary.Heading = "Description"
        Me.hgIngresos.ValuesSecondary.Image = Nothing
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(39, 45)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(41, 19)
        Me.KryptonLabel1.TabIndex = 82
        Me.KryptonLabel1.Text = "Fecha:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Fecha:"
        '
        'cbxTipo
        '
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Location = New System.Drawing.Point(86, 18)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(83, 21)
        Me.cbxTipo.TabIndex = 81
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 18)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(65, 19)
        Me.KryptonLabel2.TabIndex = 80
        Me.KryptonLabel2.Text = "Tipo Envio:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Tipo Envio:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(86, 45)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaIngreso.TabIndex = 79
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(720, 18)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 68)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 49
        Me.btnActualizar.Text = "&Procesar"
        Me.btnActualizar.Values.ExtraText = "Consulta"
        Me.btnActualizar.Values.Image = CType(resources.GetObject("btnActualizar.Values.Image"), System.Drawing.Image)
        Me.btnActualizar.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnActualizar.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnActualizar.Values.Text = "&Procesar"
        '
        'bgwGifAnimado
        '
        '
        'frmConsultaIngresosSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 503)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "frmConsultaIngresosSalidas"
        Me.Text = "Consultas Ingresos/Salidas"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgSalidas.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSalidas.Panel.ResumeLayout(False)
        Me.hgSalidas.Panel.PerformLayout()
        CType(Me.hgSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgSalidas.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hgIngresos.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgIngresos.Panel.ResumeLayout(False)
        Me.hgIngresos.Panel.PerformLayout()
        CType(Me.hgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgIngresos.ResumeLayout(False)
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
    Friend WithEvents hgIngresos As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents hgSalidas As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents VisorReportesCrystal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
End Class
