<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSDSWReporteCierre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSDSWReporteCierre))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.hgVisorPrevia = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.pcxEspera = New System.Windows.Forms.PictureBox
        Me.VisorReportesCrystal = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.KryptonHeaderGroup2 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
        Me.lblcodcliente = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.bsaClienteListar = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnActualizar = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.bgwGifAnimado = New System.ComponentModel.BackgroundWorker
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgVisorPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgVisorPrevia.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgVisorPrevia.Panel.SuspendLayout()
        Me.hgVisorPrevia.SuspendLayout()
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup2.Panel.SuspendLayout()
        Me.KryptonHeaderGroup2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgVisorPrevia)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup2)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(798, 628)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgVisorPrevia
        '
        Me.hgVisorPrevia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgVisorPrevia.Location = New System.Drawing.Point(0, 105)
        Me.hgVisorPrevia.Name = "hgVisorPrevia"
        '
        'hgVisorPrevia.Panel
        '
        Me.hgVisorPrevia.Panel.Controls.Add(Me.pcxEspera)
        Me.hgVisorPrevia.Panel.Controls.Add(Me.VisorReportesCrystal)
        Me.hgVisorPrevia.Size = New System.Drawing.Size(798, 523)
        Me.hgVisorPrevia.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hgVisorPrevia.TabIndex = 2
        Me.hgVisorPrevia.Text = "Visualizar"
        Me.hgVisorPrevia.ValuesPrimary.Description = ""
        Me.hgVisorPrevia.ValuesPrimary.Heading = "Visualizar"
        '  Me.hgVisorPrevia.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.Lupa
        Me.hgVisorPrevia.ValuesSecondary.Description = ""
        Me.hgVisorPrevia.ValuesSecondary.Heading = ""
        Me.hgVisorPrevia.ValuesSecondary.Image = Nothing
        '
        'pcxEspera
        '
        Me.pcxEspera.Image = CType(resources.GetObject("pcxEspera.Image"), System.Drawing.Image)
        Me.pcxEspera.Location = New System.Drawing.Point(381, 181)
        Me.pcxEspera.Name = "pcxEspera"
        Me.pcxEspera.Size = New System.Drawing.Size(66, 66)
        Me.pcxEspera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcxEspera.TabIndex = 47
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
        Me.VisorReportesCrystal.Size = New System.Drawing.Size(796, 498)
        Me.VisorReportesCrystal.TabIndex = 0
        Me.VisorReportesCrystal.ViewTimeSelectionFormula = ""
        Me.VisorReportesCrystal.Visible = False
        '
        'KryptonHeaderGroup2
        '
        Me.KryptonHeaderGroup2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup2.Name = "KryptonHeaderGroup2"
        '
        'KryptonHeaderGroup2.Panel
        '
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.lblcodcliente)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.txtCliente)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.dtpfecha)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup2.Panel.Controls.Add(Me.btnActualizar)
        Me.KryptonHeaderGroup2.Size = New System.Drawing.Size(798, 105)
        Me.KryptonHeaderGroup2.StateCommon.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonHeaderGroup2.TabIndex = 1
        Me.KryptonHeaderGroup2.Text = "Consulta"
        Me.KryptonHeaderGroup2.ValuesPrimary.Description = ""
        Me.KryptonHeaderGroup2.ValuesPrimary.Heading = "Consulta"
        '  Me.KryptonHeaderGroup2.ValuesPrimary.Image = Global.SOLMIN_SA.My.Resources.Resources.clipboard_list
        Me.KryptonHeaderGroup2.ValuesSecondary.Description = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Heading = ""
        Me.KryptonHeaderGroup2.ValuesSecondary.Image = Nothing
        '
        'lblcodcliente
        '
        Me.lblcodcliente.Location = New System.Drawing.Point(71, 17)
        Me.lblcodcliente.Name = "lblcodcliente"
        Me.lblcodcliente.Size = New System.Drawing.Size(16, 16)
        Me.lblcodcliente.TabIndex = 85
        Me.lblcodcliente.Text = "0"
        Me.lblcodcliente.Values.ExtraText = ""
        Me.lblcodcliente.Values.Image = Nothing
        Me.lblcodcliente.Values.Text = "0"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 17)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 16)
        Me.KryptonLabel1.TabIndex = 83
        Me.KryptonLabel1.Text = "Cliente : "
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Cliente : "
        '
        'txtCliente
        '
        Me.txtCliente.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.bsaClienteListar})
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Location = New System.Drawing.Point(121, 14)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(192, 19)
        Me.txtCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCliente.TabIndex = 84
        '
        'bsaClienteListar
        '
        Me.bsaClienteListar.ExtraText = ""
        Me.bsaClienteListar.Image = Nothing
        Me.bsaClienteListar.Text = ""
        Me.bsaClienteListar.ToolTipImage = Nothing
        Me.bsaClienteListar.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.bsaClienteListar.UniqueName = "AAA4BECF6E674984AAA4BECF6E674984"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(121, 47)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpfecha.TabIndex = 82
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(11, 51)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(94, 16)
        Me.KryptonLabel2.TabIndex = 49
        Me.KryptonLabel2.Text = "Fecha de Cierre:"
        Me.KryptonLabel2.Values.ExtraText = ""
        Me.KryptonLabel2.Values.Image = Nothing
        Me.KryptonLabel2.Values.Text = "Fecha de Cierre:"
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Location = New System.Drawing.Point(720, 6)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(68, 68)
        Me.btnActualizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.Image.ImageV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnActualizar.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.btnActualizar.StateCommon.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnActualizar.TabIndex = 48
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
        'frmReporteCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 628)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmReporteCierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consistencia"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgVisorPrevia.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgVisorPrevia.Panel.ResumeLayout(False)
        Me.hgVisorPrevia.Panel.PerformLayout()
        CType(Me.hgVisorPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgVisorPrevia.ResumeLayout(False)
        CType(Me.pcxEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup2.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup2.ResumeLayout(False)
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
    Friend WithEvents KryptonHeaderGroup2 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents btnActualizar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents hgVisorPrevia As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents pcxEspera As System.Windows.Forms.PictureBox
    Friend WithEvents VisorReportesCrystal As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblcodcliente As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaClienteListar As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bgwGifAnimado As System.ComponentModel.BackgroundWorker
End Class
